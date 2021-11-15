using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_53() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219052"},
        {"Hipparcos Number", "HIP 114600"},
        {"Smithsonian Astrophysical Observation", "SAO 146563"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.24411441),
        dec: Angle.Degrees(-09.57044367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1064"},
        {"Hipparcos Number", "HIP 1191"},
        {"Geneva Identification System", "GEN# +1.00001064"},
        {"Smithsonian Astrophysical Observation", "SAO 128660"},
        {"Wilson Evans Batten Catalogue", "WEB 213"},
    },
    visualMagnitude: 5.77,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.72708897),
        dec: Angle.Degrees(-09.56955053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48311"},
        {"Hipparcos Number", "HIP 32119"},
        {"Celescope Catalog", "CEL 1360"},
        {"Geneva Identification System", "GEN# +1.00048311"},
        {"Smithsonian Astrophysical Observation", "SAO 133599"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.63582679),
        dec: Angle.Degrees(-09.56648767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62587"},
        {"Hipparcos Number", "HIP 37737"},
        {"Smithsonian Astrophysical Observation", "SAO 135052"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.09705086),
        dec: Angle.Degrees(-09.56384774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223799"},
        {"Hipparcos Number", "HIP 117745"},
        {"Smithsonian Astrophysical Observation", "SAO 146951"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.19048568),
        dec: Angle.Degrees(-09.56148052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223508"},
        {"Hipparcos Number", "HIP 117533"},
        {"Smithsonian Astrophysical Observation", "SAO 146931"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.54289625),
        dec: Angle.Degrees(-09.56023785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53059"},
        {"Hipparcos Number", "HIP 34004"},
        {"Smithsonian Astrophysical Observation", "SAO 134120"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.82703422),
        dec: Angle.Degrees(-09.55993937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121481"},
        {"Hipparcos Number", "HIP 68024"},
        {"Fundamental Katalog 5th Edition", "FK5 3108"},
        {"Smithsonian Astrophysical Observation", "SAO 139626"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.94986672),
        dec: Angle.Degrees(-09.55989247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2196"},
        {"Hipparcos Number", "HIP 2042"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.47715759),
        dec: Angle.Degrees(-09.55936492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40536"},
        {"Hipparcos Number", "HIP 28325"},
        {"Fundamental Katalog 5th Edition", "FK5 2455"},
        {"Geneva Identification System", "GEN# +1.00040536"},
        {"Renson", "Renson 10820"},
        {"Smithsonian Astrophysical Observation", "SAO 132715"},
        {"Wilson Evans Batten Catalogue", "WEB 5537"},
    },
    visualMagnitude: 5.04,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.76794851),
        dec: Angle.Degrees(-09.55813955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45811",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7311 A"},
        {"Henry Draper", "HD 80586"},
        {"Hipparcos Number", "HIP 45811"},
        {"Geneva Identification System", "GEN# +1.00080586A"},
        {"Smithsonian Astrophysical Observation", "SAO 136768"},
        {"Wilson Evans Batten Catalogue", "WEB 8687"},
    },
    visualMagnitude: 4.80,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.12094162),
        dec: Angle.Degrees(-09.55562948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150177"},
        {"Hipparcos Number", "HIP 81580"},
        {"Geneva Identification System", "GEN# +1.00150177"},
        {"Smithsonian Astrophysical Observation", "SAO 141298"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.91301157),
        dec: Angle.Degrees(-09.55423266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223746"},
        {"Hipparcos Number", "HIP 117713"},
        {"Smithsonian Astrophysical Observation", "SAO 146946"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.10119174),
        dec: Angle.Degrees(-09.55413579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217496"},
        {"Hipparcos Number", "HIP 113658"},
        {"Smithsonian Astrophysical Observation", "SAO 146446"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.28280967),
        dec: Angle.Degrees(-09.55369721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81084",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81084"},
    },
    visualMagnitude: 11.30,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.42353339),
        dec: Angle.Degrees(-09.55288380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35615"},
        {"Hipparcos Number", "HIP 25373"},
        {"Smithsonian Astrophysical Observation", "SAO 132092"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.862,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.41998154),
        dec: Angle.Degrees(-09.55261751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138120"},
        {"Hipparcos Number", "HIP 75912"},
        {"Smithsonian Astrophysical Observation", "SAO 140571"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.58124406),
        dec: Angle.Degrees(-09.55108604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61935"},
        {"Hipparcos Number", "HIP 37447"},
        {"Fundamental Katalog 5th Edition", "FK5 293"},
        {"Geneva Identification System", "GEN# +1.00061935"},
        {"Smithsonian Astrophysical Observation", "SAO 134986"},
        {"Wilson Evans Batten Catalogue", "WEB 7409"},
    },
    visualMagnitude: 3.94,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.31198612),
        dec: Angle.Degrees(-09.55108315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179127"},
        {"Hipparcos Number", "HIP 94297"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.89765741),
        dec: Angle.Degrees(-09.54981883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -425.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30839"},
        {"Hipparcos Number", "HIP 22517"},
        {"Smithsonian Astrophysical Observation", "SAO 131540"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.68280456),
        dec: Angle.Degrees(-09.54970096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107474"},
        {"Hipparcos Number", "HIP 60248"},
        {"Smithsonian Astrophysical Observation", "SAO 138730"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.30584458),
        dec: Angle.Degrees(-09.54926445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41937",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41937"},
    },
    visualMagnitude: 9.92,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.23165370),
        dec: Angle.Degrees(-09.54841719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87535"},
        {"Hipparcos Number", "HIP 49432"},
        {"Smithsonian Astrophysical Observation", "SAO 137346"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.36964841),
        dec: Angle.Degrees(-09.54795047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62235"},
        {"Hipparcos Number", "HIP 37570"},
        {"Smithsonian Astrophysical Observation", "SAO 135017"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.66254028),
        dec: Angle.Degrees(-09.54701197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166606"},
        {"Hipparcos Number", "HIP 89161"},
        {"Smithsonian Astrophysical Observation", "SAO 142144"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.94604030),
        dec: Angle.Degrees(-09.54679412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142901"},
        {"Hipparcos Number", "HIP 78148"},
        {"Geneva Identification System", "GEN# +1.00142901"},
        {"Smithsonian Astrophysical Observation", "SAO 140858"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.36529044),
        dec: Angle.Degrees(-09.54483665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151032"},
        {"Hipparcos Number", "HIP 81999"},
        {"Smithsonian Astrophysical Observation", "SAO 141342"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.829,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.26715962),
        dec: Angle.Degrees(-09.54454399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4306"},
        {"Hipparcos Number", "HIP 3554"},
        {"Geneva Identification System", "GEN# +1.00004306"},
        {"Smithsonian Astrophysical Observation", "SAO 128936"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.36303011),
        dec: Angle.Degrees(-09.54443825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19553"},
        {"Hipparcos Number", "HIP 14599"},
        {"Geneva Identification System", "GEN# +1.00019553"},
        {"Smithsonian Astrophysical Observation", "SAO 130305"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.11528937),
        dec: Angle.Degrees(-09.54422789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112142"},
        {"Hipparcos Number", "HIP 62985"},
        {"Fundamental Katalog 5th Edition", "FK5 1335"},
        {"Geneva Identification System", "GEN# +1.00112142"},
        {"Smithsonian Astrophysical Observation", "SAO 139033"},
        {"Wilson Evans Batten Catalogue", "WEB 11168"},
    },
    visualMagnitude: 4.77,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.58822553),
        dec: Angle.Degrees(-09.53894647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133688"},
        {"Hipparcos Number", "HIP 73886"},
        {"Geneva Identification System", "GEN# +1.00133688"},
        {"Smithsonian Astrophysical Observation", "SAO 140320"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.51987492),
        dec: Angle.Degrees(-09.53811556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114203"},
        {"Hipparcos Number", "HIP 64181"},
        {"Geneva Identification System", "GEN# +1.00114203"},
        {"Smithsonian Astrophysical Observation", "SAO 139183"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.30946673),
        dec: Angle.Degrees(-09.53809931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95724",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12472 A"},
        {"Henry Draper", "HD 183107"},
        {"Hipparcos Number", "HIP 95724"},
        {"Geneva Identification System", "GEN# +1.00183107"},
        {"Smithsonian Astrophysical Observation", "SAO 143431"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.05383472),
        dec: Angle.Degrees(-09.53768615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122835"},
        {"Hipparcos Number", "HIP 68748"},
        {"Smithsonian Astrophysical Observation", "SAO 139712"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.08234869),
        dec: Angle.Degrees(-09.52934026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187650"},
        {"Hipparcos Number", "HIP 97701"},
        {"Smithsonian Astrophysical Observation", "SAO 143854"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.83511715),
        dec: Angle.Degrees(-09.52575348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17640"},
        {"Hipparcos Number", "HIP 13182"},
        {"Smithsonian Astrophysical Observation", "SAO 130134"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.40494990),
        dec: Angle.Degrees(-09.52554183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68001",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9056 A"},
        {"Henry Draper", "HD 121444"},
        {"Hipparcos Number", "HIP 68001"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.88414378),
        dec: Angle.Degrees(-09.52386493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24623"},
        {"Hipparcos Number", "HIP 18277"},
        {"Fundamental Katalog 5th Edition", "FK5 4353"},
        {"Geneva Identification System", "GEN# +1.00024623"},
        {"Smithsonian Astrophysical Observation", "SAO 130812"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.64568635),
        dec: Angle.Degrees(-09.52035847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21394"},
        {"Hipparcos Number", "HIP 16054"},
        {"Fundamental Katalog 5th Edition", "FK5 4313"},
        {"Smithsonian Astrophysical Observation", "SAO 130496"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.68517299),
        dec: Angle.Degrees(-09.51903967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49067",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49067"},
        {"Geneva Identification System", "GEN# -0.00802823"},
        {"Smithsonian Astrophysical Observation", "SAO 137286"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.19976029),
        dec: Angle.Degrees(-09.51674119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -373.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144547"},
        {"Hipparcos Number", "HIP 78932"},
        {"Smithsonian Astrophysical Observation", "SAO 140960"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.69420566),
        dec: Angle.Degrees(-09.51560636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50639"},
        {"Hipparcos Number", "HIP 33109"},
        {"Geneva Identification System", "GEN# +1.00050639"},
        {"Smithsonian Astrophysical Observation", "SAO 133840"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.43695544),
        dec: Angle.Degrees(-09.51535734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9552"},
        {"Hipparcos Number", "HIP 7263"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.39427137),
        dec: Angle.Degrees(-09.51508652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2839",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2839"},
    },
    visualMagnitude: 11.21,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.00045445),
        dec: Angle.Degrees(-09.51421249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -171.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -567.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106270"},
        {"Hipparcos Number", "HIP 59625"},
        {"Geneva Identification System", "GEN# +1.00106270"},
        {"Smithsonian Astrophysical Observation", "SAO 138655"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.40560099),
        dec: Angle.Degrees(-09.51327861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122576"},
        {"Hipparcos Number", "HIP 68638"},
        {"Smithsonian Astrophysical Observation", "SAO 139697"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.75091406),
        dec: Angle.Degrees(-09.50934232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70606"},
        {"Hipparcos Number", "HIP 41051"},
        {"Smithsonian Astrophysical Observation", "SAO 135834"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.65088833),
        dec: Angle.Degrees(-09.50762745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30535"},
        {"Hipparcos Number", "HIP 22304"},
        {"Smithsonian Astrophysical Observation", "SAO 131500"},
    },
    visualMagnitude: 7.17,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.05765773),
        dec: Angle.Degrees(-09.50669988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208421"},
        {"Hipparcos Number", "HIP 108285"},
        {"Smithsonian Astrophysical Observation", "SAO 145755"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.07305561),
        dec: Angle.Degrees(-09.50574350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129109"},
        {"Hipparcos Number", "HIP 71788"},
        {"Geneva Identification System", "GEN# +1.00129109"},
        {"Smithsonian Astrophysical Observation", "SAO 140067"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.26922311),
        dec: Angle.Degrees(-09.50410202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9410"},
        {"Hipparcos Number", "HIP 7168"},
        {"Smithsonian Astrophysical Observation", "SAO 129358"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.10433920),
        dec: Angle.Degrees(-09.50311987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52112"},
        {"Hipparcos Number", "HIP 33663"},
        {"Celescope Catalog", "CEL 1480"},
        {"Geneva Identification System", "GEN# +1.00052112"},
        {"Smithsonian Astrophysical Observation", "SAO 134007"},
    },
    visualMagnitude: 8.80,
    bvColour: -0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.89702523),
        dec: Angle.Degrees(-09.50125582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158230"},
        {"Hipparcos Number", "HIP 85508"},
        {"Smithsonian Astrophysical Observation", "SAO 141680"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.11981337),
        dec: Angle.Degrees(-09.50048755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224253"},
        {"Hipparcos Number", "HIP 118020"},
        {"Cincinnati Publication", "Ci 18 3138"},
        {"Smithsonian Astrophysical Observation", "SAO 146985"},
        {"Wilson Evans Batten Catalogue", "WEB 20753"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.778,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.08958122),
        dec: Angle.Degrees(-09.49899672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -269.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199747"},
        {"Hipparcos Number", "HIP 103599"},
        {"Geneva Identification System", "GEN# +1.00199747"},
        {"Smithsonian Astrophysical Observation", "SAO 145008"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.85822354),
        dec: Angle.Degrees(-09.49604814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102618",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Albali"},
        {"Henry Draper", "HD 198001"},
        {"Hipparcos Number", "HIP 102618"},
        {"Fundamental Katalog 5th Edition", "FK5 781"},
        {"Geneva Identification System", "GEN# +1.00198001"},
        {"Smithsonian Astrophysical Observation", "SAO 144810"},
        {"Wilson Evans Batten Catalogue", "WEB 18594"},
    },
    visualMagnitude: 3.78,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.91888574),
        dec: Angle.Degrees(-09.49568988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44548"},
        {"Hipparcos Number", "HIP 30265"},
        {"Smithsonian Astrophysical Observation", "SAO 133166"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.50199719),
        dec: Angle.Degrees(-09.49394684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135151"},
        {"Hipparcos Number", "HIP 74548"},
        {"Geneva Identification System", "GEN# +1.00135151"},
        {"Smithsonian Astrophysical Observation", "SAO 140390"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.48880381),
        dec: Angle.Degrees(-09.49351060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37916"},
        {"Hipparcos Number", "HIP 26811"},
        {"Geneva Identification System", "GEN# +1.00037916"},
        {"Smithsonian Astrophysical Observation", "SAO 132466"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.39968563),
        dec: Angle.Degrees(-09.49302324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95346"},
        {"Hipparcos Number", "HIP 53794"},
        {"Smithsonian Astrophysical Observation", "SAO 137935"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.09378168),
        dec: Angle.Degrees(-09.49272724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33303",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5597 A"},
        {"Henry Draper", "HD 51081"},
        {"Hipparcos Number", "HIP 33303"},
        {"Geneva Identification System", "GEN# +1.00051081A"},
        {"Smithsonian Astrophysical Observation", "SAO 133904"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.90704545),
        dec: Angle.Degrees(-09.48954820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129713"},
        {"Hipparcos Number", "HIP 72060"},
        {"Geneva Identification System", "GEN# +1.00129713"},
        {"Smithsonian Astrophysical Observation", "SAO 140103"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.08893708),
        dec: Angle.Degrees(-09.48952376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9101"},
        {"Hipparcos Number", "HIP 6957"},
        {"Geneva Identification System", "GEN# +1.00009101"},
        {"Smithsonian Astrophysical Observation", "SAO 129325"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.38428683),
        dec: Angle.Degrees(-09.48910482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33299",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5597 B"},
        {"Henry Draper", "HD 51081B"},
        {"Hipparcos Number", "HIP 33299"},
        {"Geneva Identification System", "GEN# +1.00051081B"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.90367036),
        dec: Angle.Degrees(-09.48760477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189665"},
        {"Hipparcos Number", "HIP 98573"},
        {"Smithsonian Astrophysical Observation", "SAO 143995"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.34836860),
        dec: Angle.Degrees(-09.48742654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97358"},
        {"Hipparcos Number", "HIP 54722"},
        {"Geneva Identification System", "GEN# +1.00097358"},
        {"Smithsonian Astrophysical Observation", "SAO 138053"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.04913407),
        dec: Angle.Degrees(-09.48487961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141128"},
        {"Hipparcos Number", "HIP 77372"},
        {"Geneva Identification System", "GEN# +1.00141128"},
        {"Smithsonian Astrophysical Observation", "SAO 140764"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.90893498),
        dec: Angle.Degrees(-09.48048283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198441"},
        {"Hipparcos Number", "HIP 102890"},
        {"Smithsonian Astrophysical Observation", "SAO 144865"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.805,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.67318033),
        dec: Angle.Degrees(-09.47987172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1170"},
        {"Hipparcos Number", "HIP 1274"},
        {"Smithsonian Astrophysical Observation", "SAO 128670"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.99933459),
        dec: Angle.Degrees(-09.47948877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22173",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22173"},
        {"Geneva Identification System", "GEN# -0.00900978"},
        {"Smithsonian Astrophysical Observation", "SAO 131480"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.56242041),
        dec: Angle.Degrees(-09.47754180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119503"},
        {"Hipparcos Number", "HIP 66987"},
        {"Geneva Identification System", "GEN# +1.00119503A"},
        {"Smithsonian Astrophysical Observation", "SAO 139511"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.92488189),
        dec: Angle.Degrees(-09.47533727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -264.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131695"},
        {"Hipparcos Number", "HIP 73022"},
        {"Smithsonian Astrophysical Observation", "SAO 140225"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.85637031),
        dec: Angle.Degrees(-09.47426221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26723"},
        {"Hipparcos Number", "HIP 19707"},
        {"Smithsonian Astrophysical Observation", "SAO 131040"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.32862698),
        dec: Angle.Degrees(-09.47082491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80219"},
        {"Hipparcos Number", "HIP 45645"},
        {"Smithsonian Astrophysical Observation", "SAO 136743"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.55863253),
        dec: Angle.Degrees(-09.47080418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141919"},
        {"Hipparcos Number", "HIP 77707"},
        {"Geneva Identification System", "GEN# +1.00141919"},
        {"Smithsonian Astrophysical Observation", "SAO 140807"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.98606475),
        dec: Angle.Degrees(-09.46943570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13936"},
        {"Hipparcos Number", "HIP 10512"},
        {"Geneva Identification System", "GEN# +1.00013936"},
        {"Smithsonian Astrophysical Observation", "SAO 129781"},
    },
    visualMagnitude: 6.55,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.86798115),
        dec: Angle.Degrees(-09.46651478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19708",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19708"},
    },
    visualMagnitude: 9.67,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)13, 19.5800),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)27, 59.400)
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
    primaryId: "HIP 56883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101341"},
        {"Hipparcos Number", "HIP 56883"},
        {"Smithsonian Astrophysical Observation", "SAO 138326"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.91474873),
        dec: Angle.Degrees(-09.46615555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12627"},
        {"Hipparcos Number", "HIP 9616"},
        {"Geneva Identification System", "GEN# +1.00012627"},
        {"Smithsonian Astrophysical Observation", "SAO 129663"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.89665980),
        dec: Angle.Degrees(-09.46074912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224093"},
        {"Hipparcos Number", "HIP 117917"},
        {"Geneva Identification System", "GEN# +1.00224093"},
        {"Smithsonian Astrophysical Observation", "SAO 146975"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.76607484),
        dec: Angle.Degrees(-09.46060016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16537",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Ran"},
        {"Henry Draper", "HD 22049"},
        {"Hipparcos Number", "HIP 16537"},
        {"Cincinnati Publication", "Ci 20 241"},
        {"Fundamental Katalog 5th Edition", "FK5 127"},
        {"Geneva Identification System", "GEN# +1.00022049"},
        {"Smithsonian Astrophysical Observation", "SAO 130564"},
        {"Wilson Evans Batten Catalogue", "WEB 3160"},
    },
    visualMagnitude: 3.72,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.23509009),
        dec: Angle.Degrees(-09.45830584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -976.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55754"},
        {"Hipparcos Number", "HIP 34953"},
        {"Celescope Catalog", "CEL 1685"},
        {"Geneva Identification System", "GEN# +1.00055754"},
        {"Smithsonian Astrophysical Observation", "SAO 134390"},
    },
    visualMagnitude: 7.83,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.48396308),
        dec: Angle.Degrees(-09.45562064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34766"},
        {"Hipparcos Number", "HIP 24839"},
        {"Geneva Identification System", "GEN# +1.00034766"},
        {"Smithsonian Astrophysical Observation", "SAO 131986"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.87988339),
        dec: Angle.Degrees(-09.45321825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16673"},
        {"Hipparcos Number", "HIP 12444"},
        {"Geneva Identification System", "GEN# +1.00016673"},
        {"Smithsonian Astrophysical Observation", "SAO 130047"},
        {"Wilson Evans Batten Catalogue", "WEB 2544"},
    },
    visualMagnitude: 5.79,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.05209879),
        dec: Angle.Degrees(-09.45268375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55013"},
        {"Hipparcos Number", "HIP 34680"},
        {"Celescope Catalog", "CEL 1644"},
        {"Geneva Identification System", "GEN# +1.00055013"},
        {"Smithsonian Astrophysical Observation", "SAO 134305"},
    },
    visualMagnitude: 8.75,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.72865499),
        dec: Angle.Degrees(-09.45213454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109309"},
        {"Hipparcos Number", "HIP 61318"},
        {"Geneva Identification System", "GEN# +1.00109309"},
        {"Renson", "Renson 31730"},
        {"Smithsonian Astrophysical Observation", "SAO 138845"},
        {"Wilson Evans Batten Catalogue", "WEB 10912"},
    },
    visualMagnitude: 5.48,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.44498858),
        dec: Angle.Degrees(-09.45207768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41988"},
        {"Hipparcos Number", "HIP 29066"},
        {"Geneva Identification System", "GEN# +1.00041988"},
        {"Smithsonian Astrophysical Observation", "SAO 132866"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.97712035),
        dec: Angle.Degrees(-09.44895773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200227"},
        {"Hipparcos Number", "HIP 103840"},
        {"Smithsonian Astrophysical Observation", "SAO 145044"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.62019695),
        dec: Angle.Degrees(-09.44775147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166029"},
        {"Hipparcos Number", "HIP 88924"},
        {"Geneva Identification System", "GEN# +1.00166029"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.27818837),
        dec: Angle.Degrees(-09.44703378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -289.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16115"},
        {"Hipparcos Number", "HIP 12028"},
        {"Geneva Identification System", "GEN# +1.00016115"},
        {"Smithsonian Astrophysical Observation", "SAO 129989"},
        {"Wilson Evans Batten Catalogue", "WEB 2478"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.77707395),
        dec: Angle.Degrees(-09.44284353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23666"},
        {"Hipparcos Number", "HIP 17627"},
        {"Smithsonian Astrophysical Observation", "SAO 130714"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.65243566),
        dec: Angle.Degrees(-09.44230854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74608"},
        {"Hipparcos Number", "HIP 42903"},
        {"Smithsonian Astrophysical Observation", "SAO 136233"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.15293254),
        dec: Angle.Degrees(-09.44200475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190281"},
        {"Hipparcos Number", "HIP 98857"},
        {"Geneva Identification System", "GEN# +1.00190281"},
        {"Smithsonian Astrophysical Observation", "SAO 144044"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.11533973),
        dec: Angle.Degrees(-09.44152952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17943"},
        {"Hipparcos Number", "HIP 13421"},
        {"Geneva Identification System", "GEN# +1.00017943"},
        {"Smithsonian Astrophysical Observation", "SAO 130160"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.21114190),
        dec: Angle.Degrees(-09.44133236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21318"},
        {"Hipparcos Number", "HIP 15991"},
        {"Smithsonian Astrophysical Observation", "SAO 130485"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.49987947),
        dec: Angle.Degrees(-09.44131006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72190"},
        {"Hipparcos Number", "HIP 41789"},
        {"Smithsonian Astrophysical Observation", "SAO 135995"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.80651146),
        dec: Angle.Degrees(-09.44039088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18273"},
        {"Hipparcos Number", "HIP 13655"},
        {"Geneva Identification System", "GEN# +1.00018273"},
        {"Smithsonian Astrophysical Observation", "SAO 130193"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.96065144),
        dec: Angle.Degrees(-09.43859165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77302",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77302"},
        {"Smithsonian Astrophysical Observation", "SAO 140753"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.73066267),
        dec: Angle.Degrees(-09.43418526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70187",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70187"},
    },
    visualMagnitude: 9.82,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.39491354),
        dec: Angle.Degrees(-09.43321801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42340"},
        {"Hipparcos Number", "HIP 29237"},
        {"Geneva Identification System", "GEN# +1.00042340"},
        {"Smithsonian Astrophysical Observation", "SAO 132902"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.861,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.46464050),
        dec: Angle.Degrees(-09.43286369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32842"},
        {"Hipparcos Number", "HIP 23704"},
        {"Geneva Identification System", "GEN# +1.00032842"},
        {"Smithsonian Astrophysical Observation", "SAO 131758"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.42927595),
        dec: Angle.Degrees(-09.43046876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224883"},
        {"Hipparcos Number", "HIP 118"},
        {"Smithsonian Astrophysical Observation", "SAO 147037"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.38648579),
        dec: Angle.Degrees(-09.43003605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6032"},
        {"Hipparcos Number", "HIP 4788"},
        {"Smithsonian Astrophysical Observation", "SAO 129086"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.36860700),
        dec: Angle.Degrees(-09.43002671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141570"},
        {"Hipparcos Number", "HIP 77563"},
        {"Smithsonian Astrophysical Observation", "SAO 140791"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.53195991),
        dec: Angle.Degrees(-09.42779096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111173",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111173"},
        {"Geneva Identification System", "GEN# +9.80156012"},
    },
    visualMagnitude: 11.16,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.82948428),
        dec: Angle.Degrees(-09.42584461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183062"},
        {"Hipparcos Number", "HIP 95708"},
        {"Smithsonian Astrophysical Observation", "SAO 143428"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.01259893),
        dec: Angle.Degrees(-09.42544711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112572",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112572"},
    },
    visualMagnitude: 10.94,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.00881149),
        dec: Angle.Degrees(-09.42533507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83373"},
        {"Hipparcos Number", "HIP 47249"},
        {"Geneva Identification System", "GEN# +1.00083373"},
        {"Renson", "Renson 23780"},
        {"Smithsonian Astrophysical Observation", "SAO 137011"},
    },
    visualMagnitude: 6.40,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.46475673),
        dec: Angle.Degrees(-09.42446525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31654"},
        {"Hipparcos Number", "HIP 23039"},
        {"Smithsonian Astrophysical Observation", "SAO 131628"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.31861471),
        dec: Angle.Degrees(-09.41880871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207889"},
        {"Hipparcos Number", "HIP 107974"},
        {"Geneva Identification System", "GEN# +1.00207889"},
        {"Smithsonian Astrophysical Observation", "SAO 145718"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.12367700),
        dec: Angle.Degrees(-09.41784254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97107"},
        {"Hipparcos Number", "HIP 54609"},
        {"Smithsonian Astrophysical Observation", "SAO 138027"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.64031521),
        dec: Angle.Degrees(-09.41682395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13945",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2297 AB"},
        {"Henry Draper", "HD 18646"},
        {"Hipparcos Number", "HIP 13945"},
        {"Smithsonian Astrophysical Observation", "SAO 130229"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.90480802),
        dec: Angle.Degrees(-09.41660894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13948",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2297 C"},
        {"Hipparcos Number", "HIP 13948"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.862,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.91611783),
        dec: Angle.Degrees(-09.41184798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181235"},
        {"Hipparcos Number", "HIP 95020"},
        {"Geneva Identification System", "GEN# +1.00181235"},
        {"Smithsonian Astrophysical Observation", "SAO 143272"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.01074715),
        dec: Angle.Degrees(-09.41160658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60139"},
        {"Hipparcos Number", "HIP 36677"},
        {"Geneva Identification System", "GEN# +1.00060139"},
        {"Smithsonian Astrophysical Observation", "SAO 134823"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.18684967),
        dec: Angle.Degrees(-09.41100038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105187"},
        {"Hipparcos Number", "HIP 59060"},
        {"Geneva Identification System", "GEN# +1.00105187"},
        {"Smithsonian Astrophysical Observation", "SAO 138587"},
        {"Wilson Evans Batten Catalogue", "WEB 10517"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.68123467),
        dec: Angle.Degrees(-09.41002564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125264"},
        {"Hipparcos Number", "HIP 69920"},
        {"Smithsonian Astrophysical Observation", "SAO 139858"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.63447137),
        dec: Angle.Degrees(-09.40917977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103477"},
        {"Hipparcos Number", "HIP 58094"},
        {"Smithsonian Astrophysical Observation", "SAO 138477"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.71674760),
        dec: Angle.Degrees(-09.40819173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71412"},
        {"Hipparcos Number", "HIP 41433"},
        {"Smithsonian Astrophysical Observation", "SAO 135927"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.75812796),
        dec: Angle.Degrees(-09.40785822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2718"},
        {"Hipparcos Number", "HIP 2408"},
        {"Smithsonian Astrophysical Observation", "SAO 128798"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.66971690),
        dec: Angle.Degrees(-09.40771739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117719",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117719"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.12217581),
        dec: Angle.Degrees(-09.40697916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 203.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116380"},
        {"Hipparcos Number", "HIP 65332"},
        {"Smithsonian Astrophysical Observation", "SAO 139310"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.85546479),
        dec: Angle.Degrees(-09.40695343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77747",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77747"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.11967940),
        dec: Angle.Degrees(-09.40681845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -234.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4939"},
        {"Hipparcos Number", "HIP 3995"},
        {"Geneva Identification System", "GEN# +1.00004939"},
        {"Smithsonian Astrophysical Observation", "SAO 128989"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.83285255),
        dec: Angle.Degrees(-09.40556546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2503"},
        {"Hipparcos Number", "HIP 2250"},
        {"Geneva Identification System", "GEN# +1.00002503"},
        {"Smithsonian Astrophysical Observation", "SAO 128776"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.16031921),
        dec: Angle.Degrees(-09.40523293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38356",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6412 AB"},
        {"Henry Draper", "HD 63976"},
        {"Hipparcos Number", "HIP 38356"},
        {"Smithsonian Astrophysical Observation", "SAO 135180"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.83535293),
        dec: Angle.Degrees(-09.40469979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10009"},
        {"Hipparcos Number", "HIP 7580"},
        {"Fundamental Katalog 5th Edition", "FK5 2109"},
        {"Geneva Identification System", "GEN# +1.00010009J"},
        {"Smithsonian Astrophysical Observation", "SAO 129412"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.40648858),
        dec: Angle.Degrees(-09.40405165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 249.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 111.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220873"},
        {"Hipparcos Number", "HIP 115786"},
        {"Smithsonian Astrophysical Observation", "SAO 146713"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.85545733),
        dec: Angle.Degrees(-09.40396158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152679"},
        {"Hipparcos Number", "HIP 82788"},
        {"Smithsonian Astrophysical Observation", "SAO 141435"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.78001676),
        dec: Angle.Degrees(-09.40269674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88373"},
        {"Hipparcos Number", "HIP 49898"},
        {"Smithsonian Astrophysical Observation", "SAO 137401"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.81997585),
        dec: Angle.Degrees(-09.40197902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105796"},
        {"Hipparcos Number", "HIP 59359"},
        {"Smithsonian Astrophysical Observation", "SAO 138628"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.67182865),
        dec: Angle.Degrees(-09.40191889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107517"},
        {"Hipparcos Number", "HIP 60277"},
        {"Smithsonian Astrophysical Observation", "SAO 138731"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.39303556),
        dec: Angle.Degrees(-09.39988401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198645"},
        {"Hipparcos Number", "HIP 102991"},
        {"Smithsonian Astrophysical Observation", "SAO 144885"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.99940586),
        dec: Angle.Degrees(-09.39988138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93396"},
        {"Hipparcos Number", "HIP 52733"},
        {"Smithsonian Astrophysical Observation", "SAO 137780"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.70744562),
        dec: Angle.Degrees(-09.39883582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173348"},
        {"Hipparcos Number", "HIP 92009"},
        {"Geneva Identification System", "GEN# +2.66940029"},
        {"Smithsonian Astrophysical Observation", "SAO 142584"},
        {"Wilson Evans Batten Catalogue", "WEB 15850"},
        {"New General Catalogue", "NGC 6694 29"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.29925824),
        dec: Angle.Degrees(-09.39807725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102883"},
        {"Hipparcos Number", "HIP 57763"},
        {"Smithsonian Astrophysical Observation", "SAO 138441"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.68377972),
        dec: Angle.Degrees(-09.39743766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45260"},
        {"Hipparcos Number", "HIP 30621"},
        {"Celescope Catalog", "CEL 1233"},
        {"Geneva Identification System", "GEN# +1.00045260"},
        {"Smithsonian Astrophysical Observation", "SAO 133251"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.52646793),
        dec: Angle.Degrees(-09.39740192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105811"},
        {"Hipparcos Number", "HIP 59367"},
        {"Smithsonian Astrophysical Observation", "SAO 138630"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.70119519),
        dec: Angle.Degrees(-09.39712346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89945"},
        {"Hipparcos Number", "HIP 50827"},
        {"Smithsonian Astrophysical Observation", "SAO 137524"},
        {"Wilson Evans Batten Catalogue", "WEB 9302"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.67410450),
        dec: Angle.Degrees(-09.39513891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48789"},
        {"Hipparcos Number", "HIP 32316"},
        {"Geneva Identification System", "GEN# +1.00048789"},
        {"Smithsonian Astrophysical Observation", "SAO 133632"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.19443611),
        dec: Angle.Degrees(-09.39407852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27928",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27928"},
        {"Geneva Identification System", "GEN# -0.00901261"},
    },
    visualMagnitude: 10.70,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.64187179),
        dec: Angle.Degrees(-09.39361661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 367.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36727"},
        {"Hipparcos Number", "HIP 26052"},
        {"Smithsonian Astrophysical Observation", "SAO 132258"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.36215736),
        dec: Angle.Degrees(-09.39288914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77520"},
        {"Hipparcos Number", "HIP 44407"},
        {"Fundamental Katalog 5th Edition", "FK5 4804"},
        {"Smithsonian Astrophysical Observation", "SAO 136531"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.68798762),
        dec: Angle.Degrees(-09.39166468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202406"},
        {"Hipparcos Number", "HIP 104995"},
        {"Geneva Identification System", "GEN# +1.00202406"},
        {"Renson", "Renson 56400"},
        {"Smithsonian Astrophysical Observation", "SAO 145247"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.97929727),
        dec: Angle.Degrees(-09.39116689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43993"},
        {"Hipparcos Number", "HIP 29996"},
        {"Geneva Identification System", "GEN# +1.00043993"},
        {"Smithsonian Astrophysical Observation", "SAO 133091"},
        {"Wilson Evans Batten Catalogue", "WEB 5952"},
    },
    visualMagnitude: 5.36,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.71075178),
        dec: Angle.Degrees(-09.38996323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214230"},
        {"Hipparcos Number", "HIP 111637"},
        {"Smithsonian Astrophysical Observation", "SAO 146200"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.23229352),
        dec: Angle.Degrees(-09.38932879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210409"},
        {"Hipparcos Number", "HIP 109446"},
        {"Smithsonian Astrophysical Observation", "SAO 145913"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.59135515),
        dec: Angle.Degrees(-09.38776696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23705"},
        {"Hipparcos Number", "HIP 17650"},
        {"Smithsonian Astrophysical Observation", "SAO 130716"},
        {"Wilson Evans Batten Catalogue", "WEB 3363"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.71177560),
        dec: Angle.Degrees(-09.38772285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220376"},
        {"Hipparcos Number", "HIP 115457"},
        {"Geneva Identification System", "GEN# +1.00220376"},
        {"Smithsonian Astrophysical Observation", "SAO 146678"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.82296418),
        dec: Angle.Degrees(-09.38495673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14667"},
        {"Hipparcos Number", "HIP 11012"},
        {"Smithsonian Astrophysical Observation", "SAO 129854"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.45636926),
        dec: Angle.Degrees(-09.38473805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78557"},
        {"Hipparcos Number", "HIP 44880"},
        {"Geneva Identification System", "GEN# +1.00078557"},
        {"Smithsonian Astrophysical Observation", "SAO 136603"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.16754067),
        dec: Angle.Degrees(-09.38421696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74785",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Zubeneschamali"},
        {"Henry Draper", "HD 135742"},
        {"Hipparcos Number", "HIP 74785"},
        {"Fundamental Katalog 5th Edition", "FK5 564"},
        {"Geneva Identification System", "GEN# +1.00135742"},
        {"Smithsonian Astrophysical Observation", "SAO 140430"},
        {"Wilson Evans Batten Catalogue", "WEB 12758"},
    },
    visualMagnitude: 2.61,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.25196591),
        dec: Angle.Degrees(-09.38286694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40535"},
        {"Hipparcos Number", "HIP 28321"},
        {"Geneva Identification System", "GEN# +1.00040535"},
        {"Smithsonian Astrophysical Observation", "SAO 132714"},
        {"Wilson Evans Batten Catalogue", "WEB 5536"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.75445275),
        dec: Angle.Degrees(-09.38225809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74506"},
        {"Hipparcos Number", "HIP 42866"},
        {"Smithsonian Astrophysical Observation", "SAO 136227"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.03158585),
        dec: Angle.Degrees(-09.38139196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7984"},
        {"Hipparcos Number", "HIP 6172"},
        {"Smithsonian Astrophysical Observation", "SAO 129225"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.78856209),
        dec: Angle.Degrees(-09.37894994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124837"},
        {"Hipparcos Number", "HIP 69694"},
        {"Smithsonian Astrophysical Observation", "SAO 139822"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.99173714),
        dec: Angle.Degrees(-09.37890639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39001"},
        {"Hipparcos Number", "HIP 27490"},
        {"Smithsonian Astrophysical Observation", "SAO 132569"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.31671473),
        dec: Angle.Degrees(-09.37792554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102580"},
        {"Hipparcos Number", "HIP 57599"},
        {"Smithsonian Astrophysical Observation", "SAO 138419"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.12878482),
        dec: Angle.Degrees(-09.37600881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48792",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7593 AB"},
        {"Henry Draper", "HD 86241"},
        {"Hipparcos Number", "HIP 48792"},
        {"Renson", "Renson 24660"},
        {"Smithsonian Astrophysical Observation", "SAO 137248"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.26953562),
        dec: Angle.Degrees(-09.37598989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5959"},
        {"Hipparcos Number", "HIP 4736"},
        {"Fundamental Katalog 5th Edition", "FK5 4095"},
        {"Smithsonian Astrophysical Observation", "SAO 129078"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.20874255),
        dec: Angle.Degrees(-09.37357879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10393"},
        {"Hipparcos Number", "HIP 7872"},
        {"Smithsonian Astrophysical Observation", "SAO 129448"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.32283562),
        dec: Angle.Degrees(-09.37175278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46889"},
        {"Hipparcos Number", "HIP 31470"},
        {"Smithsonian Astrophysical Observation", "SAO 133447"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.87933464),
        dec: Angle.Degrees(-09.37121138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88583"},
        {"Hipparcos Number", "HIP 50021"},
        {"Smithsonian Astrophysical Observation", "SAO 137412"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.18581809),
        dec: Angle.Degrees(-09.37088806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194916"},
        {"Hipparcos Number", "HIP 100982"},
        {"Geneva Identification System", "GEN# +1.00194916"},
        {"Smithsonian Astrophysical Observation", "SAO 144465"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.11084036),
        dec: Angle.Degrees(-09.37039647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170901"},
        {"Hipparcos Number", "HIP 90867"},
        {"Smithsonian Astrophysical Observation", "SAO 142374"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.04916786),
        dec: Angle.Degrees(-09.37031935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175058"},
        {"Hipparcos Number", "HIP 92740"},
        {"Geneva Identification System", "GEN# +1.00175058"},
        {"Smithsonian Astrophysical Observation", "SAO 142764"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.48312030),
        dec: Angle.Degrees(-09.37030343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167898"},
        {"Hipparcos Number", "HIP 89646"},
        {"Smithsonian Astrophysical Observation", "SAO 142196"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.41323156),
        dec: Angle.Degrees(-09.36782993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195636"},
        {"Hipparcos Number", "HIP 101379"},
        {"Geneva Identification System", "GEN# +1.00195636"},
        {"Smithsonian Astrophysical Observation", "SAO 144547"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.20409824),
        dec: Angle.Degrees(-09.36414457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47613"},
        {"Hipparcos Number", "HIP 31822"},
        {"Smithsonian Astrophysical Observation", "SAO 133529"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.80317313),
        dec: Angle.Degrees(-09.36336790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9730",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9730"},
        {"Smithsonian Astrophysical Observation", "SAO 129685"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.28402119),
        dec: Angle.Degrees(-09.36096869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15663",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15663"},
        {"Smithsonian Astrophysical Observation", "SAO 130441"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.43172334),
        dec: Angle.Degrees(-09.36074878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214686"},
        {"Hipparcos Number", "HIP 111910"},
        {"Geneva Identification System", "GEN# +1.00214686"},
        {"Smithsonian Astrophysical Observation", "SAO 146230"},
        {"Wilson Evans Batten Catalogue", "WEB 19985"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.03283372),
        dec: Angle.Degrees(-09.35935010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 169.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104833"},
        {"Hipparcos Number", "HIP 58865"},
        {"Geneva Identification System", "GEN# +1.00104833"},
        {"Renson", "Renson 30360"},
        {"Smithsonian Astrophysical Observation", "SAO 138563"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.07747751),
        dec: Angle.Degrees(-09.35832623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157498"},
        {"Hipparcos Number", "HIP 85141"},
        {"Geneva Identification System", "GEN# +1.00157498"},
        {"Smithsonian Astrophysical Observation", "SAO 141647"},
        {"Wilson Evans Batten Catalogue", "WEB 14376"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.99114582),
        dec: Angle.Degrees(-09.35825947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66179"},
        {"Hipparcos Number", "HIP 39288"},
        {"Smithsonian Astrophysical Observation", "SAO 135400"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.50226683),
        dec: Angle.Degrees(-09.35680139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146491"},
        {"Hipparcos Number", "HIP 79791"},
        {"Geneva Identification System", "GEN# +1.00146491"},
        {"Smithsonian Astrophysical Observation", "SAO 141076"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.25427902),
        dec: Angle.Degrees(-09.35647614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201567"},
        {"Hipparcos Number", "HIP 104557"},
        {"Geneva Identification System", "GEN# +1.00201567"},
        {"Smithsonian Astrophysical Observation", "SAO 145171"},
    },
    visualMagnitude: 6.27,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.69529389),
        dec: Angle.Degrees(-09.35393125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8572",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8572"},
        {"Geneva Identification System", "GEN# -0.01000388"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.63539742),
        dec: Angle.Degrees(-09.35101663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 256.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 95.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16152"},
        {"Hipparcos Number", "HIP 12055"},
        {"Geneva Identification System", "GEN# +1.00016152"},
        {"Smithsonian Astrophysical Observation", "SAO 129994"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.85195105),
        dec: Angle.Degrees(-09.35074034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137763"},
        {"Hipparcos Number", "HIP 75718"},
        {"Cincinnati Publication", "Ci 18 2064"},
        {"Geneva Identification System", "GEN# +1.00137763A"},
        {"Smithsonian Astrophysical Observation", "SAO 140550"},
        {"Wilson Evans Batten Catalogue", "WEB 12892"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.788,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.03986870),
        dec: Angle.Degrees(-09.34718625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -363.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4607"},
        {"Hipparcos Number", "HIP 3734"},
        {"Cincinnati Publication", "Ci 18 104"},
        {"Geneva Identification System", "GEN# +1.00004607"},
        {"Smithsonian Astrophysical Observation", "SAO 128961"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.98854552),
        dec: Angle.Degrees(-09.34698336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 194.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 206.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118810"},
        {"Hipparcos Number", "HIP 66623"},
        {"Smithsonian Astrophysical Observation", "SAO 139468"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.84383789),
        dec: Angle.Degrees(-09.34543678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94338"},
        {"Hipparcos Number", "HIP 53223"},
        {"Smithsonian Astrophysical Observation", "SAO 137862"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.29973240),
        dec: Angle.Degrees(-09.34441010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129503"},
        {"Hipparcos Number", "HIP 71969"},
        {"Smithsonian Astrophysical Observation", "SAO 140091"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.79056484),
        dec: Angle.Degrees(-09.34422203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10825"},
        {"Hipparcos Number", "HIP 8217"},
        {"Smithsonian Astrophysical Observation", "SAO 129488"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.45882226),
        dec: Angle.Degrees(-09.34417254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29521"},
        {"Hipparcos Number", "HIP 21625"},
        {"Geneva Identification System", "GEN# +1.00029521"},
        {"Smithsonian Astrophysical Observation", "SAO 131375"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.64232355),
        dec: Angle.Degrees(-09.34320572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101786"},
        {"Hipparcos Number", "HIP 57132"},
        {"Renson", "Renson 29340"},
        {"Smithsonian Astrophysical Observation", "SAO 138364"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.70307227),
        dec: Angle.Degrees(-09.34175861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51913"},
        {"Hipparcos Number", "HIP 33594"},
        {"Geneva Identification System", "GEN# +1.00051913"},
        {"Smithsonian Astrophysical Observation", "SAO 133984"},
    },
    visualMagnitude: 8.76,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.69679207),
        dec: Angle.Degrees(-09.34023004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136583"},
        {"Hipparcos Number", "HIP 75185"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.46963879),
        dec: Angle.Degrees(-09.33840546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182298"},
        {"Hipparcos Number", "HIP 95402"},
        {"Smithsonian Astrophysical Observation", "SAO 143359"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.09699205),
        dec: Angle.Degrees(-09.33828967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54858"},
        {"Hipparcos Number", "HIP 34619"},
        {"Celescope Catalog", "CEL 1634"},
        {"Geneva Identification System", "GEN# +1.00054858"},
        {"Smithsonian Astrophysical Observation", "SAO 134285"},
        {"Wilson Evans Batten Catalogue", "WEB 6930"},
    },
    visualMagnitude: 8.22,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.54730297),
        dec: Angle.Degrees(-09.33631361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54995"},
        {"Hipparcos Number", "HIP 34669"},
        {"Celescope Catalog", "CEL 1642"},
        {"Geneva Identification System", "GEN# +1.00054995"},
        {"Smithsonian Astrophysical Observation", "SAO 134299"},
    },
    visualMagnitude: 7.41,
    bvColour: -0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.69566181),
        dec: Angle.Degrees(-09.33600750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89434"},
        {"Hipparcos Number", "HIP 50523"},
        {"Smithsonian Astrophysical Observation", "SAO 137485"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.79365757),
        dec: Angle.Degrees(-09.33543881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31822"},
        {"Hipparcos Number", "HIP 23128"},
        {"Geneva Identification System", "GEN# +1.00031822"},
        {"Smithsonian Astrophysical Observation", "SAO 131651"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.64910667),
        dec: Angle.Degrees(-09.33405665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45342"},
        {"Hipparcos Number", "HIP 30656"},
        {"Smithsonian Astrophysical Observation", "SAO 133258"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.62294784),
        dec: Angle.Degrees(-09.33277093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95743"},
        {"Hipparcos Number", "HIP 54002"},
        {"Geneva Identification System", "GEN# +1.00095743"},
        {"Smithsonian Astrophysical Observation", "SAO 137955"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.70932500),
        dec: Angle.Degrees(-09.33021014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -202.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21622"},
        {"Hipparcos Number", "HIP 16231"},
        {"Smithsonian Astrophysical Observation", "SAO 130515"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.28518771),
        dec: Angle.Degrees(-09.32883379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92424",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92424"},
    },
    visualMagnitude: 11.36,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.53444515),
        dec: Angle.Degrees(-09.32849354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203364"},
        {"Hipparcos Number", "HIP 105491"},
        {"Geneva Identification System", "GEN# +1.00203364"},
        {"Smithsonian Astrophysical Observation", "SAO 145333"},
        {"Wilson Evans Batten Catalogue", "WEB 19155"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.49437421),
        dec: Angle.Degrees(-09.32785966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72259"},
        {"Hipparcos Number", "HIP 41814"},
        {"Smithsonian Astrophysical Observation", "SAO 136001"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.87610262),
        dec: Angle.Degrees(-09.32729552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80698",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80698"},
        {"Geneva Identification System", "GEN# -0.00904395"},
        {"Renson", "Renson 41964"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.14739018),
        dec: Angle.Degrees(-09.32552136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216222"},
        {"Hipparcos Number", "HIP 112849"},
        {"Fundamental Katalog 5th Edition", "FK5 6016"},
        {"Smithsonian Astrophysical Observation", "SAO 146350"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.80113529),
        dec: Angle.Degrees(-09.32511179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181234"},
        {"Hipparcos Number", "HIP 95015"},
        {"Geneva Identification System", "GEN# +1.00181234"},
        {"Smithsonian Astrophysical Observation", "SAO 143270"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.00070908),
        dec: Angle.Degrees(-09.32282812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -317.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50982"},
        {"Hipparcos Number", "HIP 33261"},
        {"Geneva Identification System", "GEN# +1.00050982"},
        {"Smithsonian Astrophysical Observation", "SAO 133898"},
    },
    visualMagnitude: 7.73,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.79958603),
        dec: Angle.Degrees(-09.32116004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184792"},
        {"Hipparcos Number", "HIP 96435"},
        {"Smithsonian Astrophysical Observation", "SAO 143589"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.09576867),
        dec: Angle.Degrees(-09.31995121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203525"},
        {"Hipparcos Number", "HIP 105574"},
        {"Fundamental Katalog 5th Edition", "FK5 3705"},
        {"Geneva Identification System", "GEN# +1.00203525"},
        {"Smithsonian Astrophysical Observation", "SAO 145351"},
        {"Wilson Evans Batten Catalogue", "WEB 19166"},
    },
    visualMagnitude: 5.99,
    bvColour: 1.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.73446434),
        dec: Angle.Degrees(-09.31927297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82655"},
        {"Hipparcos Number", "HIP 46875"},
        {"Smithsonian Astrophysical Observation", "SAO 136946"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.28305606),
        dec: Angle.Degrees(-09.31645026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116291"},
        {"Hipparcos Number", "HIP 65284"},
        {"Smithsonian Astrophysical Observation", "SAO 139305"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.69086197),
        dec: Angle.Degrees(-09.31630481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4098"},
        {"Hipparcos Number", "HIP 3406"},
        {"Smithsonian Astrophysical Observation", "SAO 128918"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.84521440),
        dec: Angle.Degrees(-09.31587562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 325.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91895",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91895"},
    },
    visualMagnitude: 10.78,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.00362922),
        dec: Angle.Degrees(-09.31580974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140399"},
        {"Hipparcos Number", "HIP 77033"},
        {"Geneva Identification System", "GEN# +1.00140399"},
        {"Smithsonian Astrophysical Observation", "SAO 140722"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.93748618),
        dec: Angle.Degrees(-09.31538706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40147"},
        {"Hipparcos Number", "HIP 28137"},
        {"Geneva Identification System", "GEN# +1.00040147"},
        {"Smithsonian Astrophysical Observation", "SAO 132679"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.871,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.20391200),
        dec: Angle.Degrees(-09.31465221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104038"},
        {"Hipparcos Number", "HIP 58437"},
        {"Smithsonian Astrophysical Observation", "SAO 138514"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.73013228),
        dec: Angle.Degrees(-09.31415695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123255"},
        {"Hipparcos Number", "HIP 68940"},
        {"Geneva Identification System", "GEN# +1.00123255"},
        {"Renson", "Renson 35336"},
        {"Smithsonian Astrophysical Observation", "SAO 139736"},
        {"Wilson Evans Batten Catalogue", "WEB 12046"},
    },
    visualMagnitude: 5.46,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.67877719),
        dec: Angle.Degrees(-09.31352509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100888"},
        {"Hipparcos Number", "HIP 56631"},
        {"Smithsonian Astrophysical Observation", "SAO 138295"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.16946429),
        dec: Angle.Degrees(-09.31305083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110979"},
        {"Hipparcos Number", "HIP 62304"},
        {"Geneva Identification System", "GEN# +1.00110979"},
        {"Smithsonian Astrophysical Observation", "SAO 138958"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.50412361),
        dec: Angle.Degrees(-09.31288128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 311.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60807"},
        {"Hipparcos Number", "HIP 36973"},
        {"Geneva Identification System", "GEN# +1.00060807"},
        {"Smithsonian Astrophysical Observation", "SAO 134877"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.99956245),
        dec: Angle.Degrees(-09.31252455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9279"},
        {"Hipparcos Number", "HIP 7076"},
        {"Smithsonian Astrophysical Observation", "SAO 129346"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.79590568),
        dec: Angle.Degrees(-09.31206378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59692"},
        {"Hipparcos Number", "HIP 36516"},
        {"Geneva Identification System", "GEN# +1.00059692"},
        {"Smithsonian Astrophysical Observation", "SAO 134772"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.67901754),
        dec: Angle.Degrees(-09.31005459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104960"},
        {"Hipparcos Number", "HIP 58936"},
        {"Smithsonian Astrophysical Observation", "SAO 138574"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.27474933),
        dec: Angle.Degrees(-09.30855070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173783"},
        {"Hipparcos Number", "HIP 92198"},
        {"Geneva Identification System", "GEN# +1.00173783"},
        {"Smithsonian Astrophysical Observation", "SAO 142619"},
        {"Wilson Evans Batten Catalogue", "WEB 15900"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.85075938),
        dec: Angle.Degrees(-09.30819143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128080"},
        {"Hipparcos Number", "HIP 71323"},
        {"Smithsonian Astrophysical Observation", "SAO 140013"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.77944102),
        dec: Angle.Degrees(-09.30818596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213817"},
        {"Hipparcos Number", "HIP 111414"},
        {"Smithsonian Astrophysical Observation", "SAO 146162"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.58593798),
        dec: Angle.Degrees(-09.30519574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133255"},
        {"Hipparcos Number", "HIP 73701"},
        {"Smithsonian Astrophysical Observation", "SAO 140294"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.95616081),
        dec: Angle.Degrees(-09.30348079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55117"},
        {"Hipparcos Number", "HIP 34707"},
        {"Celescope Catalog", "CEL 1648"},
        {"Geneva Identification System", "GEN# +1.00055117"},
        {"Smithsonian Astrophysical Observation", "SAO 134320"},
    },
    visualMagnitude: 8.84,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.82073969),
        dec: Angle.Degrees(-09.29985356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8877"},
        {"Hipparcos Number", "HIP 6797"},
        {"Smithsonian Astrophysical Observation", "SAO 129311"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.86783349),
        dec: Angle.Degrees(-09.29707413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21156",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21156"},
        {"Smithsonian Astrophysical Observation", "SAO 131277"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.02998336),
        dec: Angle.Degrees(-09.29658415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41484"},
        {"Hipparcos Number", "HIP 28835"},
        {"Geneva Identification System", "GEN# +1.00041484"},
        {"Smithsonian Astrophysical Observation", "SAO 132812"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.29538101),
        dec: Angle.Degrees(-09.29174234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59112"},
        {"Hipparcos Number", "HIP 36276"},
        {"Smithsonian Astrophysical Observation", "SAO 134712"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.02498941),
        dec: Angle.Degrees(-09.29034554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223963"},
        {"Hipparcos Number", "HIP 117843"},
        {"Geneva Identification System", "GEN# +1.00223963"},
        {"Smithsonian Astrophysical Observation", "SAO 146962"},
        {"Wilson Evans Batten Catalogue", "WEB 20729"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.51230205),
        dec: Angle.Degrees(-09.28989850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170396"},
        {"Hipparcos Number", "HIP 90633"},
        {"Smithsonian Astrophysical Observation", "SAO 142346"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.39597619),
        dec: Angle.Degrees(-09.28859000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118891"},
        {"Hipparcos Number", "HIP 66659"},
        {"Smithsonian Astrophysical Observation", "SAO 139473"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.97424009),
        dec: Angle.Degrees(-09.28487331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84271",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10400 AB"},
        {"Henry Draper", "HD 155718"},
        {"Hipparcos Number", "HIP 84271"},
        {"Smithsonian Astrophysical Observation", "SAO 141562"},
    },
    visualMagnitude: 7.54,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.40566842),
        dec: Angle.Degrees(-09.28381368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5122"},
        {"Hipparcos Number", "HIP 4146"},
        {"Geneva Identification System", "GEN# +1.00005122"},
        {"Smithsonian Astrophysical Observation", "SAO 129010"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.24964569),
        dec: Angle.Degrees(-09.28329355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209249"},
        {"Hipparcos Number", "HIP 108780"},
        {"Smithsonian Astrophysical Observation", "SAO 145823"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.53128301),
        dec: Angle.Degrees(-09.28224904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34263",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5789 AB"},
        {"Henry Draper", "HD 53823"},
        {"Hipparcos Number", "HIP 34263"},
        {"Celescope Catalog", "CEL 1579"},
        {"Geneva Identification System", "GEN# +1.00053823J"},
        {"Smithsonian Astrophysical Observation", "SAO 134189"},
    },
    visualMagnitude: 8.61,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.54312308),
        dec: Angle.Degrees(-09.28161556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91548"},
        {"Hipparcos Number", "HIP 51736"},
        {"Fundamental Katalog 5th Edition", "FK5 4938"},
        {"Smithsonian Astrophysical Observation", "SAO 137646"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.56483540),
        dec: Angle.Degrees(-09.28019280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24277",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24277"},
        {"Smithsonian Astrophysical Observation", "SAO 131871"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.15067346),
        dec: Angle.Degrees(-09.27853784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1834"},
        {"Hipparcos Number", "HIP 1796"},
        {"Geneva Identification System", "GEN# +1.00001834"},
        {"Smithsonian Astrophysical Observation", "SAO 128726"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.70284046),
        dec: Angle.Degrees(-09.27802858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207005"},
        {"Hipparcos Number", "HIP 107487"},
        {"Geneva Identification System", "GEN# +1.00207005"},
        {"Smithsonian Astrophysical Observation", "SAO 145648"},
        {"Wilson Evans Batten Catalogue", "WEB 19402"},
    },
    visualMagnitude: 6.00,
    bvColour: 1.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.56774421),
        dec: Angle.Degrees(-09.27595420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102945"},
        {"Hipparcos Number", "HIP 57790"},
        {"Geneva Identification System", "GEN# +1.00102945"},
        {"Smithsonian Astrophysical Observation", "SAO 138446"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.75874892),
        dec: Angle.Degrees(-09.27331883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184613"},
        {"Hipparcos Number", "HIP 96376"},
        {"Geneva Identification System", "GEN# +1.00184613"},
        {"Smithsonian Astrophysical Observation", "SAO 143566"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.91576701),
        dec: Angle.Degrees(-09.27331879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100702"},
        {"Hipparcos Number", "HIP 56517"},
        {"Geneva Identification System", "GEN# +1.00100702"},
        {"Smithsonian Astrophysical Observation", "SAO 138285"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.80536554),
        dec: Angle.Degrees(-09.27144393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174682"},
        {"Hipparcos Number", "HIP 92589"},
        {"Smithsonian Astrophysical Observation", "SAO 142717"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.99807825),
        dec: Angle.Degrees(-09.27088876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -180.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56306"},
        {"Hipparcos Number", "HIP 35167"},
        {"Geneva Identification System", "GEN# +1.00056306J"},
        {"Smithsonian Astrophysical Observation", "SAO 134436"},
    },
    visualMagnitude: 8.22,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.02795648),
        dec: Angle.Degrees(-09.26969228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47386"},
        {"Hipparcos Number", "HIP 31709"},
        {"Celescope Catalog", "CEL 1329"},
        {"Geneva Identification System", "GEN# +1.00047386"},
        {"Smithsonian Astrophysical Observation", "SAO 133506"},
    },
    visualMagnitude: 8.13,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.49207980),
        dec: Angle.Degrees(-09.26874405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221081"},
        {"Hipparcos Number", "HIP 115906"},
        {"Geneva Identification System", "GEN# +1.00221081"},
        {"Smithsonian Astrophysical Observation", "SAO 146729"},
    },
    visualMagnitude: 6.20,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.25287320),
        dec: Angle.Degrees(-09.26603962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25802"},
        {"Hipparcos Number", "HIP 19063"},
        {"Smithsonian Astrophysical Observation", "SAO 130933"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.27801786),
        dec: Angle.Degrees(-09.26221057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74410",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74410"},
    },
    visualMagnitude: 10.56,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.10647427),
        dec: Angle.Degrees(-09.26096801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59435"},
        {"Hipparcos Number", "HIP 36419"},
        {"Geneva Identification System", "GEN# +1.00059435"},
        {"Renson", "Renson 16240"},
        {"Smithsonian Astrophysical Observation", "SAO 134747"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.39773924),
        dec: Angle.Degrees(-09.25925865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122816"},
        {"Hipparcos Number", "HIP 68752"},
        {"Smithsonian Astrophysical Observation", "SAO 139713"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.08956447),
        dec: Angle.Degrees(-09.25765927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55810"},
        {"Hipparcos Number", "HIP 34970"},
        {"Smithsonian Astrophysical Observation", "SAO 134392"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.54065583),
        dec: Angle.Degrees(-09.25680469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55606",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55606"},
        {"Smithsonian Astrophysical Observation", "SAO 138178"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.87919400),
        dec: Angle.Degrees(-09.25587212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205858"},
        {"Hipparcos Number", "HIP 106837"},
        {"Smithsonian Astrophysical Observation", "SAO 145548"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.59189329),
        dec: Angle.Degrees(-09.25424217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110299"},
        {"Hipparcos Number", "HIP 61903"},
        {"Smithsonian Astrophysical Observation", "SAO 138911"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.28713283),
        dec: Angle.Degrees(-09.24554641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39675",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6588 A"},
        {"Henry Draper", "HD 67159"},
        {"Hipparcos Number", "HIP 39675"},
        {"Geneva Identification System", "GEN# +1.00067159A"},
        {"Smithsonian Astrophysical Observation", "SAO 135505"},
    },
    visualMagnitude: 6.25,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.61423328),
        dec: Angle.Degrees(-09.24446994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10266"},
        {"Hipparcos Number", "HIP 7791"},
        {"Smithsonian Astrophysical Observation", "SAO 129437"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.06942061),
        dec: Angle.Degrees(-09.24280267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11029"},
        {"Hipparcos Number", "HIP 8390"},
        {"Smithsonian Astrophysical Observation", "SAO 129507"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.871,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.05794179),
        dec: Angle.Degrees(-09.24037601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15116"},
        {"Hipparcos Number", "HIP 11343"},
        {"Geneva Identification System", "GEN# +1.00015116"},
        {"Smithsonian Astrophysical Observation", "SAO 129899"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.48533610),
        dec: Angle.Degrees(-09.23989470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26432",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26432"},
        {"Smithsonian Astrophysical Observation", "SAO 132377"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.37749365),
        dec: Angle.Degrees(-09.23932942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39673",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6588 B"},
        {"Henry Draper", "HD 67158"},
        {"Hipparcos Number", "HIP 39673"},
        {"Geneva Identification System", "GEN# +1.00067158"},
        {"Smithsonian Astrophysical Observation", "SAO 135504"},
    },
    visualMagnitude: 7.93,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.60958885),
        dec: Angle.Degrees(-09.23732093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2658"},
        {"Hipparcos Number", "HIP 2357"},
        {"Smithsonian Astrophysical Observation", "SAO 128792"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.53535695),
        dec: Angle.Degrees(-09.23528685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137075"},
        {"Hipparcos Number", "HIP 75391"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.07991023),
        dec: Angle.Degrees(-09.23397723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85559"},
        {"Hipparcos Number", "HIP 48431"},
        {"Smithsonian Astrophysical Observation", "SAO 137198"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.11327012),
        dec: Angle.Degrees(-09.23170775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1833"},
        {"Hipparcos Number", "HIP 1792"},
        {"Geneva Identification System", "GEN# +1.00001833"},
        {"Smithsonian Astrophysical Observation", "SAO 128725"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.69304657),
        dec: Angle.Degrees(-09.23074177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25310",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4011 AB"},
        {"Henry Draper", "HD 35503"},
        {"Hipparcos Number", "HIP 25310"},
        {"Smithsonian Astrophysical Observation", "SAO 132080"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.20383622),
        dec: Angle.Degrees(-09.22988524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159738"},
        {"Hipparcos Number", "HIP 86186"},
        {"Smithsonian Astrophysical Observation", "SAO 141756"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.17082014),
        dec: Angle.Degrees(-09.22842828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32192"},
        {"Hipparcos Number", "HIP 23327"},
        {"Geneva Identification System", "GEN# +1.00032192"},
        {"Smithsonian Astrophysical Observation", "SAO 131695"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.26357159),
        dec: Angle.Degrees(-09.22484471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98270",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98270"},
        {"Wilson Evans Batten Catalogue", "WEB 17335"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.51052105),
        dec: Angle.Degrees(-09.22450342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61204"},
        {"Hipparcos Number", "HIP 37130"},
        {"Smithsonian Astrophysical Observation", "SAO 134916"},
    },
    visualMagnitude: 8.74,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.43827369),
        dec: Angle.Degrees(-09.22375984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46365",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7382 AB"},
        {"Henry Draper", "HD 81728"},
        {"Hipparcos Number", "HIP 46365"},
        {"Geneva Identification System", "GEN# +1.00081728J"},
        {"Smithsonian Astrophysical Observation", "SAO 136861"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.81104547),
        dec: Angle.Degrees(-09.22370303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7234"},
        {"Hipparcos Number", "HIP 5644"},
        {"Cincinnati Publication", "Ci 18 156"},
        {"Smithsonian Astrophysical Observation", "SAO 129175"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.12423811),
        dec: Angle.Degrees(-09.22368841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 386.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27984"},
        {"Hipparcos Number", "HIP 20603"},
        {"Smithsonian Astrophysical Observation", "SAO 131192"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.19109552),
        dec: Angle.Degrees(-09.22350628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90543"},
        {"Hipparcos Number", "HIP 51165"},
        {"Smithsonian Astrophysical Observation", "SAO 137571"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.76710583),
        dec: Angle.Degrees(-09.22294575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64452"},
        {"Hipparcos Number", "HIP 38557"},
        {"Geneva Identification System", "GEN# +1.00064452"},
        {"Smithsonian Astrophysical Observation", "SAO 135222"},
    },
    visualMagnitude: 8.76,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.42192163),
        dec: Angle.Degrees(-09.22088691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111384"},
        {"Hipparcos Number", "HIP 62551"},
        {"Smithsonian Astrophysical Observation", "SAO 138978"},
        {"Wilson Evans Batten Catalogue", "WEB 11102"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.25260537),
        dec: Angle.Degrees(-09.22024760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77231"},
        {"Hipparcos Number", "HIP 44277"},
        {"Smithsonian Astrophysical Observation", "SAO 136494"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.25878276),
        dec: Angle.Degrees(-09.21964842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61977"},
        {"Hipparcos Number", "HIP 37466"},
        {"Geneva Identification System", "GEN# +1.00061977"},
        {"Smithsonian Astrophysical Observation", "SAO 134989"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.34963833),
        dec: Angle.Degrees(-09.21510478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202466"},
        {"Hipparcos Number", "HIP 105019"},
        {"Smithsonian Astrophysical Observation", "SAO 145251"},
        {"Wilson Evans Batten Catalogue", "WEB 19080"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.07408271),
        dec: Angle.Degrees(-09.21466422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111114"},
        {"Hipparcos Number", "HIP 62383"},
        {"Smithsonian Astrophysical Observation", "SAO 138964"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.77648143),
        dec: Angle.Degrees(-09.21443159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129890"},
        {"Hipparcos Number", "HIP 72136"},
        {"Smithsonian Astrophysical Observation", "SAO 140118"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.33417583),
        dec: Angle.Degrees(-09.21420105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157687"},
        {"Hipparcos Number", "HIP 85236"},
        {"Geneva Identification System", "GEN# +1.00157687"},
        {"Smithsonian Astrophysical Observation", "SAO 141655"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.25742477),
        dec: Angle.Degrees(-09.21165671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52772"},
        {"Hipparcos Number", "HIP 33905"},
        {"Geneva Identification System", "GEN# +1.00052772"},
        {"Smithsonian Astrophysical Observation", "SAO 134086"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.55222668),
        dec: Angle.Degrees(-09.21038786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18032"},
        {"Hipparcos Number", "HIP 13475"},
        {"Smithsonian Astrophysical Observation", "SAO 130174"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.39499285),
        dec: Angle.Degrees(-09.20796904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76195"},
        {"Hipparcos Number", "HIP 43731"},
        {"Smithsonian Astrophysical Observation", "SAO 136391"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.59503695),
        dec: Angle.Degrees(-09.20509333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52382"},
        {"Hipparcos Number", "HIP 33754"},
        {"Celescope Catalog", "CEL 1497"},
        {"Geneva Identification System", "GEN# +1.00052382"},
        {"Smithsonian Astrophysical Observation", "SAO 134041"},
        {"Wilson Evans Batten Catalogue", "WEB 6779"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.16391260),
        dec: Angle.Degrees(-09.20297055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145895"},
        {"Hipparcos Number", "HIP 79527"},
        {"Smithsonian Astrophysical Observation", "SAO 141038"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.43242433),
        dec: Angle.Degrees(-09.20290917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130672"},
        {"Hipparcos Number", "HIP 72531"},
        {"Geneva Identification System", "GEN# +1.00130672"},
        {"Smithsonian Astrophysical Observation", "SAO 140161"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.44228530),
        dec: Angle.Degrees(-09.20249524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169753"},
        {"Hipparcos Number", "HIP 90382"},
        {"Geneva Identification System", "GEN# +1.00169753"},
        {"Smithsonian Astrophysical Observation", "SAO 142317"},
        {"Wilson Evans Batten Catalogue", "WEB 15475"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.63967996),
        dec: Angle.Degrees(-09.20165435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120450"},
        {"Hipparcos Number", "HIP 67471"},
        {"Smithsonian Astrophysical Observation", "SAO 139576"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.40341020),
        dec: Angle.Degrees(-09.19888705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190174"},
        {"Hipparcos Number", "HIP 98808"},
        {"Smithsonian Astrophysical Observation", "SAO 144037"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.00452398),
        dec: Angle.Degrees(-09.19721566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81915"},
        {"Hipparcos Number", "HIP 46450"},
        {"Smithsonian Astrophysical Observation", "SAO 136884"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.10610968),
        dec: Angle.Degrees(-09.19664159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21765",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21765"},
        {"Geneva Identification System", "GEN# -0.00900956"},
    },
    visualMagnitude: 10.27,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.12219150),
        dec: Angle.Degrees(-09.19583388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12910"},
        {"Hipparcos Number", "HIP 9811"},
        {"Smithsonian Astrophysical Observation", "SAO 129694"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.55895947),
        dec: Angle.Degrees(-09.19541204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185966"},
        {"Hipparcos Number", "HIP 96917"},
        {"Smithsonian Astrophysical Observation", "SAO 143705"},
    },
    visualMagnitude: 6.31,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.51207344),
        dec: Angle.Degrees(-09.19344910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23019"},
        {"Hipparcos Number", "HIP 17222"},
        {"Smithsonian Astrophysical Observation", "SAO 130666"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.34245334),
        dec: Angle.Degrees(-09.19340054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117004"},
        {"Hipparcos Number", "HIP 65642"},
        {"Smithsonian Astrophysical Observation", "SAO 139345"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.87371253),
        dec: Angle.Degrees(-09.19267646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156288"},
        {"Hipparcos Number", "HIP 84552"},
        {"Smithsonian Astrophysical Observation", "SAO 141588"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.26836057),
        dec: Angle.Degrees(-09.19182639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77196"},
        {"Hipparcos Number", "HIP 44254"},
        {"Smithsonian Astrophysical Observation", "SAO 136489"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.19011279),
        dec: Angle.Degrees(-09.19138528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57215"},
        {"Hipparcos Number", "HIP 35511"},
        {"Smithsonian Astrophysical Observation", "SAO 134520"},
    },
    visualMagnitude: 8.61,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.95265665),
        dec: Angle.Degrees(-09.19111273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218589"},
        {"Hipparcos Number", "HIP 114330"},
        {"Smithsonian Astrophysical Observation", "SAO 146536"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.32857761),
        dec: Angle.Degrees(-09.18720063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84767"},
        {"Hipparcos Number", "HIP 48010"},
        {"Smithsonian Astrophysical Observation", "SAO 137130"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.80864404),
        dec: Angle.Degrees(-09.18686568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63752"},
        {"Hipparcos Number", "HIP 38253"},
        {"Geneva Identification System", "GEN# +1.00063752"},
        {"Smithsonian Astrophysical Observation", "SAO 135158"},
        {"Wilson Evans Batten Catalogue", "WEB 7533"},
    },
    visualMagnitude: 5.60,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.54406881),
        dec: Angle.Degrees(-09.18344160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138764"},
        {"Hipparcos Number", "HIP 76243"},
        {"Geneva Identification System", "GEN# +1.00138764"},
        {"Renson", "Renson 39510"},
        {"Smithsonian Astrophysical Observation", "SAO 140614"},
        {"Wilson Evans Batten Catalogue", "WEB 12944"},
    },
    visualMagnitude: 5.16,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.61055153),
        dec: Angle.Degrees(-09.18334968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48953",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48953"},
        {"Geneva Identification System", "GEN# -0.00802813"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.79749285),
        dec: Angle.Degrees(-09.18322084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219688"},
        {"Hipparcos Number", "HIP 115033"},
        {"Geneva Identification System", "GEN# +1.00219688"},
        {"Smithsonian Astrophysical Observation", "SAO 146620"},
        {"Wilson Evans Batten Catalogue", "WEB 20378"},
    },
    visualMagnitude: 4.41,
    bvColour: -0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.47584844),
        dec: Angle.Degrees(-09.18248990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108979"},
        {"Hipparcos Number", "HIP 61108"},
        {"Smithsonian Astrophysical Observation", "SAO 138830"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.85558795),
        dec: Angle.Degrees(-09.18156355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39852"},
        {"Hipparcos Number", "HIP 27959"},
        {"Celescope Catalog", "CEL 1034"},
        {"Smithsonian Astrophysical Observation", "SAO 132642"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.72567824),
        dec: Angle.Degrees(-09.18102403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55955",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55955"},
        {"Geneva Identification System", "GEN# +9.85672039"},
    },
    visualMagnitude: 12.40,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.00066853),
        dec: Angle.Degrees(-09.18029700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 536.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -851.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165686"},
        {"Hipparcos Number", "HIP 88795"},
        {"Smithsonian Astrophysical Observation", "SAO 142100"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.89074353),
        dec: Angle.Degrees(-09.17793736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54784"},
        {"Hipparcos Number", "HIP 34585"},
        {"Celescope Catalog", "CEL 1626"},
        {"Geneva Identification System", "GEN# +1.00054784"},
        {"Smithsonian Astrophysical Observation", "SAO 134274"},
    },
    visualMagnitude: 9.15,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.45192146),
        dec: Angle.Degrees(-09.17701569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17048"},
        {"Hipparcos Number", "HIP 12760"},
        {"Smithsonian Astrophysical Observation", "SAO 130086"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.99825452),
        dec: Angle.Degrees(-09.17682111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101895"},
        {"Hipparcos Number", "HIP 57180"},
        {"Smithsonian Astrophysical Observation", "SAO 138371"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.89065994),
        dec: Angle.Degrees(-09.17664752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29216"},
        {"Hipparcos Number", "HIP 21400"},
        {"Smithsonian Astrophysical Observation", "SAO 131342"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.90566377),
        dec: Angle.Degrees(-09.17493805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224988"},
        {"Hipparcos Number", "HIP 180"},
        {"Smithsonian Astrophysical Observation", "SAO 147048"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.57090231),
        dec: Angle.Degrees(-09.17489501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172903"},
        {"Hipparcos Number", "HIP 91796"},
        {"Smithsonian Astrophysical Observation", "SAO 142533"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.76477224),
        dec: Angle.Degrees(-09.16982948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183660"},
        {"Hipparcos Number", "HIP 95966"},
        {"Smithsonian Astrophysical Observation", "SAO 143483"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.72514023),
        dec: Angle.Degrees(-09.16896379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111242"},
        {"Hipparcos Number", "HIP 62458"},
        {"Geneva Identification System", "GEN# +1.00111242"},
        {"Smithsonian Astrophysical Observation", "SAO 138970"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.00045974),
        dec: Angle.Degrees(-09.16742847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48217"},
        {"Hipparcos Number", "HIP 32064"},
        {"Geneva Identification System", "GEN# +1.00048217"},
        {"Smithsonian Astrophysical Observation", "SAO 133585"},
        {"Wilson Evans Batten Catalogue", "WEB 6472"},
    },
    visualMagnitude: 5.21,
    bvColour: 1.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.48485939),
        dec: Angle.Degrees(-09.16742468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31936"},
        {"Hipparcos Number", "HIP 23192"},
        {"Geneva Identification System", "GEN# +1.00031936"},
        {"Smithsonian Astrophysical Observation", "SAO 131664"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.86065947),
        dec: Angle.Degrees(-09.16622301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201161"},
        {"Hipparcos Number", "HIP 104331"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.01830296),
        dec: Angle.Degrees(-09.16604484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -365.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49165"},
        {"Hipparcos Number", "HIP 32490"},
        {"Fundamental Katalog 5th Edition", "FK5 4619"},
        {"Geneva Identification System", "GEN# +1.00049165"},
        {"Smithsonian Astrophysical Observation", "SAO 133666"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.70918449),
        dec: Angle.Degrees(-09.16458072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51743",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51743"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.57979173),
        dec: Angle.Degrees(-09.16336150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -189.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137809"},
        {"Hipparcos Number", "HIP 75746"},
        {"Smithsonian Astrophysical Observation", "SAO 140557"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.11696568),
        dec: Angle.Degrees(-09.16008116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221519"},
        {"Hipparcos Number", "HIP 116226"},
        {"Smithsonian Astrophysical Observation", "SAO 146764"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.23340492),
        dec: Angle.Degrees(-09.15951994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202494"},
        {"Hipparcos Number", "HIP 105035"},
        {"Geneva Identification System", "GEN# +1.00202494"},
        {"Smithsonian Astrophysical Observation", "SAO 145256"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.12427944),
        dec: Angle.Degrees(-09.15786138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178747"},
        {"Hipparcos Number", "HIP 94165"},
        {"Smithsonian Astrophysical Observation", "SAO 143089"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.52604596),
        dec: Angle.Degrees(-09.15573273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130447"},
        {"Hipparcos Number", "HIP 72425"},
        {"Smithsonian Astrophysical Observation", "SAO 140147"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.13395938),
        dec: Angle.Degrees(-09.15555148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20395"},
        {"Hipparcos Number", "HIP 15244"},
        {"Geneva Identification System", "GEN# +1.00020395"},
        {"Smithsonian Astrophysical Observation", "SAO 130395"},
        {"Wilson Evans Batten Catalogue", "WEB 2939"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.14902114),
        dec: Angle.Degrees(-09.15474637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215115"},
        {"Hipparcos Number", "HIP 112156"},
        {"Smithsonian Astrophysical Observation", "SAO 146267"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.74908381),
        dec: Angle.Degrees(-09.15434554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203177"},
        {"Hipparcos Number", "HIP 105389"},
        {"Smithsonian Astrophysical Observation", "SAO 145313"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.20862957),
        dec: Angle.Degrees(-09.15162719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27564"},
        {"Hipparcos Number", "HIP 20265"},
        {"Smithsonian Astrophysical Observation", "SAO 131130"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.16328486),
        dec: Angle.Degrees(-09.14937653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136140"},
        {"Hipparcos Number", "HIP 74982"},
        {"Geneva Identification System", "GEN# +1.00136140"},
        {"Smithsonian Astrophysical Observation", "SAO 140456"},
        {"Wilson Evans Batten Catalogue", "WEB 12791"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.84082901),
        dec: Angle.Degrees(-09.14639765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206229"},
        {"Hipparcos Number", "HIP 107056"},
        {"Geneva Identification System", "GEN# +1.00206229"},
        {"Smithsonian Astrophysical Observation", "SAO 145583"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.24019324),
        dec: Angle.Degrees(-09.14205690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76400"},
        {"Hipparcos Number", "HIP 43835"},
        {"Geneva Identification System", "GEN# +1.00076400"},
        {"Smithsonian Astrophysical Observation", "SAO 136414"},
        {"Wilson Evans Batten Catalogue", "WEB 8434"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.91603035),
        dec: Angle.Degrees(-09.14149152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172403"},
        {"Hipparcos Number", "HIP 91567"},
        {"Geneva Identification System", "GEN# +1.00172403"},
        {"Renson", "Renson 48304"},
        {"Smithsonian Astrophysical Observation", "SAO 142484"},
        {"Wilson Evans Batten Catalogue", "WEB 15744"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.08959202),
        dec: Angle.Degrees(-09.14033757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188782"},
        {"Hipparcos Number", "HIP 98179"},
        {"Smithsonian Astrophysical Observation", "SAO 143937"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.28126960),
        dec: Angle.Degrees(-09.13751761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132613"},
        {"Hipparcos Number", "HIP 73435"},
        {"Geneva Identification System", "GEN# +1.00132613"},
        {"Smithsonian Astrophysical Observation", "SAO 140266"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.09647951),
        dec: Angle.Degrees(-09.13583321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205147"},
        {"Hipparcos Number", "HIP 106453"},
        {"Smithsonian Astrophysical Observation", "SAO 145484"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.41371077),
        dec: Angle.Degrees(-09.13438675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101956"},
        {"Hipparcos Number", "HIP 57213"},
        {"Smithsonian Astrophysical Observation", "SAO 138376"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.97951568),
        dec: Angle.Degrees(-09.13234297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57473"},
        {"Hipparcos Number", "HIP 35622"},
        {"Smithsonian Astrophysical Observation", "SAO 134557"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.25838604),
        dec: Angle.Degrees(-09.13199941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26058",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26058"},
    },
    visualMagnitude: 12.22,
    bvColour: 1.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.37443414),
        dec: Angle.Degrees(-09.12953931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 463.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 159.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6304"},
        {"Hipparcos Number", "HIP 4982"},
        {"Geneva Identification System", "GEN# +1.00006304"},
        {"Smithsonian Astrophysical Observation", "SAO 129099"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.96264641),
        dec: Angle.Degrees(-09.12921115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190173"},
        {"Hipparcos Number", "HIP 98804"},
        {"Smithsonian Astrophysical Observation", "SAO 144036"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.00082805),
        dec: Angle.Degrees(-09.12672501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136800"},
        {"Hipparcos Number", "HIP 75284"},
        {"Smithsonian Astrophysical Observation", "SAO 140493"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.72461541),
        dec: Angle.Degrees(-09.12571455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19740"},
        {"Hipparcos Number", "HIP 14740"},
        {"Geneva Identification System", "GEN# +1.00019740"},
        {"Smithsonian Astrophysical Observation", "SAO 130322"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.58233815),
        dec: Angle.Degrees(-09.12541002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75786"},
        {"Hipparcos Number", "HIP 43507"},
        {"Geneva Identification System", "GEN# +1.00075786"},
        {"Smithsonian Astrophysical Observation", "SAO 136352"},
        {"Wilson Evans Batten Catalogue", "WEB 8385"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.93152030),
        dec: Angle.Degrees(-09.12530694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77134"},
        {"Hipparcos Number", "HIP 44212"},
        {"Geneva Identification System", "GEN# +1.00077134"},
        {"Smithsonian Astrophysical Observation", "SAO 136486"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.09005957),
        dec: Angle.Degrees(-09.12312538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -166.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70550"},
        {"Hipparcos Number", "HIP 41021"},
        {"Geneva Identification System", "GEN# +1.00070550"},
        {"Smithsonian Astrophysical Observation", "SAO 135827"},
    },
    visualMagnitude: 8.51,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.56532323),
        dec: Angle.Degrees(-09.12305527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75720"},
        {"Hipparcos Number", "HIP 43474"},
        {"Smithsonian Astrophysical Observation", "SAO 136341"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.83304419),
        dec: Angle.Degrees(-09.12290180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202397"},
        {"Hipparcos Number", "HIP 104985"},
        {"Smithsonian Astrophysical Observation", "SAO 145246"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.95409118),
        dec: Angle.Degrees(-09.12087153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49718"},
        {"Hipparcos Number", "HIP 32714"},
        {"Smithsonian Astrophysical Observation", "SAO 133727"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.38086831),
        dec: Angle.Degrees(-09.12046735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101808"},
        {"Hipparcos Number", "HIP 57138"},
        {"Geneva Identification System", "GEN# +1.00101808"},
        {"Smithsonian Astrophysical Observation", "SAO 138366"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.73773077),
        dec: Angle.Degrees(-09.12000503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102651"},
        {"Hipparcos Number", "HIP 57631"},
        {"Smithsonian Astrophysical Observation", "SAO 138421"},
        {"Wilson Evans Batten Catalogue", "WEB 10347"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.26252001),
        dec: Angle.Degrees(-09.11793724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1680"},
        {"Hipparcos Number", "HIP 1682"},
        {"Smithsonian Astrophysical Observation", "SAO 128706"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.26206131),
        dec: Angle.Degrees(-09.11189060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33725"},
        {"Hipparcos Number", "HIP 24210"},
        {"Cincinnati Publication", "Ci 18 674"},
        {"Cincinnati Publication 2", "Ci 20 317"},
        {"Geneva Identification System", "GEN# +1.00033725"},
        {"Smithsonian Astrophysical Observation", "SAO 131861"},
        {"Wilson Evans Batten Catalogue", "WEB 4703"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.97621046),
        dec: Angle.Degrees(-09.11179838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -558.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75753"},
        {"Hipparcos Number", "HIP 43495"},
        {"Smithsonian Astrophysical Observation", "SAO 136346"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.88773217),
        dec: Angle.Degrees(-09.11147752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54083"},
        {"Hipparcos Number", "HIP 34347"},
        {"Geneva Identification System", "GEN# +1.00054083"},
        {"Smithsonian Astrophysical Observation", "SAO 134215"},
    },
    visualMagnitude: 9.35,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.79777563),
        dec: Angle.Degrees(-09.11108448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65740"},
        {"Hipparcos Number", "HIP 39085"},
        {"Smithsonian Astrophysical Observation", "SAO 135347"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.94261966),
        dec: Angle.Degrees(-09.10819405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20997"},
        {"Hipparcos Number", "HIP 15759"},
        {"Smithsonian Astrophysical Observation", "SAO 130455"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.76835431),
        dec: Angle.Degrees(-09.10710922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -252.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117580"},
        {"Hipparcos Number", "HIP 65957"},
        {"Smithsonian Astrophysical Observation", "SAO 139381"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.84636578),
        dec: Angle.Degrees(-09.10688052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118082"},
        {"Hipparcos Number", "HIP 66250"},
        {"Smithsonian Astrophysical Observation", "SAO 139418"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.67494141),
        dec: Angle.Degrees(-09.10674656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33177"},
        {"Hipparcos Number", "HIP 23905"},
        {"Geneva Identification System", "GEN# +1.00033177"},
        {"Smithsonian Astrophysical Observation", "SAO 131801"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.03584432),
        dec: Angle.Degrees(-09.10659934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115812"},
        {"Hipparcos Number", "HIP 65030"},
        {"Smithsonian Astrophysical Observation", "SAO 139282"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.94797889),
        dec: Angle.Degrees(-09.10557749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53338"},
        {"Hipparcos Number", "HIP 34111"},
        {"Geneva Identification System", "GEN# +1.00053338"},
        {"Smithsonian Astrophysical Observation", "SAO 134143"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.09200331),
        dec: Angle.Degrees(-09.10479305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147774"},
        {"Hipparcos Number", "HIP 80345"},
        {"Smithsonian Astrophysical Observation", "SAO 141148"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.03303264),
        dec: Angle.Degrees(-09.10345220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148766"},
        {"Hipparcos Number", "HIP 80873"},
        {"Smithsonian Astrophysical Observation", "SAO 141211"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.70550763),
        dec: Angle.Degrees(-09.10035279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112964"},
        {"Hipparcos Number", "HIP 63486"},
        {"Geneva Identification System", "GEN# +1.00112964"},
        {"Smithsonian Astrophysical Observation", "SAO 139094"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.12310732),
        dec: Angle.Degrees(-09.10032158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93704"},
        {"Hipparcos Number", "HIP 52884"},
        {"Smithsonian Astrophysical Observation", "SAO 137805"},
        {"Wilson Evans Batten Catalogue", "WEB 9628"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.24132027),
        dec: Angle.Degrees(-09.09996206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58644"},
        {"Hipparcos Number", "HIP 36090"},
        {"Geneva Identification System", "GEN# +1.00058644"},
        {"Smithsonian Astrophysical Observation", "SAO 134662"},
    },
    visualMagnitude: 8.27,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.53065566),
        dec: Angle.Degrees(-09.09655955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131653"},
        {"Hipparcos Number", "HIP 72998"},
        {"Geneva Identification System", "GEN# +1.00131653"},
        {"Smithsonian Astrophysical Observation", "SAO 140220"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.77997671),
        dec: Angle.Degrees(-09.09647587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -199.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -343.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128097"},
        {"Hipparcos Number", "HIP 71331"},
        {"Smithsonian Astrophysical Observation", "SAO 140015"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.81515329),
        dec: Angle.Degrees(-09.09550184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83702"},
        {"Hipparcos Number", "HIP 47442"},
        {"Geneva Identification System", "GEN# +1.00083702"},
        {"Smithsonian Astrophysical Observation", "SAO 137042"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.03003880),
        dec: Angle.Degrees(-09.09525748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216493"},
        {"Hipparcos Number", "HIP 113026"},
        {"Cincinnati Publication", "Ci 18 2989"},
        {"Smithsonian Astrophysical Observation", "SAO 146369"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.35413151),
        dec: Angle.Degrees(-09.09281344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 247.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35660"},
        {"Hipparcos Number", "HIP 25405"},
        {"Geneva Identification System", "GEN# +1.00035660"},
        {"Smithsonian Astrophysical Observation", "SAO 132102"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.51750117),
        dec: Angle.Degrees(-09.09207698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118644"},
        {"Hipparcos Number", "HIP 66535"},
        {"Fundamental Katalog 5th Edition", "FK5 5205"},
        {"Smithsonian Astrophysical Observation", "SAO 139455"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.58253395),
        dec: Angle.Degrees(-09.09158024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45124"},
        {"Hipparcos Number", "HIP 30553"},
        {"Smithsonian Astrophysical Observation", "SAO 133233"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.34112531),
        dec: Angle.Degrees(-09.09112698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35123"},
        {"Hipparcos Number", "HIP 25088"},
        {"Smithsonian Astrophysical Observation", "SAO 132034"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.56226752),
        dec: Angle.Degrees(-09.08783493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114855",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16633 A"},
        {"Henry Draper", "HD 219449"},
        {"Hipparcos Number", "HIP 114855"},
        {"Fundamental Katalog 5th Edition", "FK5 1608"},
        {"Geneva Identification System", "GEN# +1.00219449"},
        {"Smithsonian Astrophysical Observation", "SAO 146598"},
        {"Wilson Evans Batten Catalogue", "WEB 20357"},
    },
    visualMagnitude: 4.24,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.97198728),
        dec: Angle.Degrees(-09.08769554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 368.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205321"},
        {"Hipparcos Number", "HIP 106545"},
        {"Smithsonian Astrophysical Observation", "SAO 145502"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.68027965),
        dec: Angle.Degrees(-09.08693001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131429"},
        {"Hipparcos Number", "HIP 72891"},
        {"Smithsonian Astrophysical Observation", "SAO 140205"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.46416649),
        dec: Angle.Degrees(-09.08592889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206044"},
        {"Hipparcos Number", "HIP 106950"},
        {"Smithsonian Astrophysical Observation", "SAO 145567"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.91107741),
        dec: Angle.Degrees(-09.08397115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206834"},
        {"Hipparcos Number", "HIP 107382"},
        {"Geneva Identification System", "GEN# +1.00206834"},
        {"Smithsonian Astrophysical Observation", "SAO 145637"},
        {"Wilson Evans Batten Catalogue", "WEB 19394"},
    },
    visualMagnitude: 5.10,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.25102876),
        dec: Angle.Degrees(-09.08242443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95938"},
        {"Hipparcos Number", "HIP 54078"},
        {"Geneva Identification System", "GEN# +1.00095938"},
        {"Smithsonian Astrophysical Observation", "SAO 137971"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.98790634),
        dec: Angle.Degrees(-09.08094235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106225"},
        {"Hipparcos Number", "HIP 59600"},
        {"Smithsonian Astrophysical Observation", "SAO 138652"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.33625366),
        dec: Angle.Degrees(-09.07968805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79855"},
        {"Hipparcos Number", "HIP 45498"},
        {"Smithsonian Astrophysical Observation", "SAO 136717"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.06815915),
        dec: Angle.Degrees(-09.07849305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101645"},
        {"Hipparcos Number", "HIP 57049"},
        {"Geneva Identification System", "GEN# +1.00101645"},
        {"Smithsonian Astrophysical Observation", "SAO 138352"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.43643471),
        dec: Angle.Degrees(-09.07686202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -216.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75365",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75365"},
    },
    visualMagnitude: 11.44,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.01516756),
        dec: Angle.Degrees(-09.07635738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -153.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -209.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160836"},
        {"Hipparcos Number", "HIP 86661"},
        {"Geneva Identification System", "GEN# +1.00160836"},
        {"Smithsonian Astrophysical Observation", "SAO 141818"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.60502259),
        dec: Angle.Degrees(-09.07591256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3477"},
        {"Hipparcos Number", "HIP 2961"},
        {"Geneva Identification System", "GEN# +1.00003477"},
        {"Smithsonian Astrophysical Observation", "SAO 128865"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.40671474),
        dec: Angle.Degrees(-09.07348685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8013",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8013"},
        {"Smithsonian Astrophysical Observation", "SAO 129468"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.72684993),
        dec: Angle.Degrees(-09.07118148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146877"},
        {"Hipparcos Number", "HIP 79934"},
        {"Geneva Identification System", "GEN# +1.00146877"},
        {"Smithsonian Astrophysical Observation", "SAO 141091"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.72070403),
        dec: Angle.Degrees(-09.07083875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99587",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99587"},
    },
    visualMagnitude: 10.61,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.15779109),
        dec: Angle.Degrees(-09.06882028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44889"},
        {"Hipparcos Number", "HIP 30441"},
        {"Smithsonian Astrophysical Observation", "SAO 133209"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.99503952),
        dec: Angle.Degrees(-09.06880115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97065",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12823 AB"},
        {"Henry Draper", "HD 186264"},
        {"Hipparcos Number", "HIP 97065"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.89223178),
        dec: Angle.Degrees(-09.06724632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56007"},
        {"Hipparcos Number", "HIP 35050"},
        {"Geneva Identification System", "GEN# +1.00056007"},
        {"Smithsonian Astrophysical Observation", "SAO 134411"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.72739461),
        dec: Angle.Degrees(-09.06539718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13763"},
        {"Hipparcos Number", "HIP 10396"},
        {"Smithsonian Astrophysical Observation", "SAO 129765"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.47313991),
        dec: Angle.Degrees(-09.06468041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51478"},
        {"Hipparcos Number", "HIP 33441"},
        {"Geneva Identification System", "GEN# +1.00051478"},
        {"Smithsonian Astrophysical Observation", "SAO 133942"},
        {"Wilson Evans Batten Catalogue", "WEB 6723"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.29922791),
        dec: Angle.Degrees(-09.06444228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213677"},
        {"Hipparcos Number", "HIP 111332"},
        {"Geneva Identification System", "GEN# +1.00213677"},
        {"Smithsonian Astrophysical Observation", "SAO 146153"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.33896474),
        dec: Angle.Degrees(-09.06340666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 296.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151704"},
        {"Hipparcos Number", "HIP 82327"},
        {"Smithsonian Astrophysical Observation", "SAO 141383"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.32721662),
        dec: Angle.Degrees(-09.06257214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224171"},
        {"Hipparcos Number", "HIP 117977"},
        {"Geneva Identification System", "GEN# +1.00224171"},
        {"Smithsonian Astrophysical Observation", "SAO 146981"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.93503937),
        dec: Angle.Degrees(-09.06181964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22380"},
        {"Hipparcos Number", "HIP 16770"},
        {"Cincinnati Publication", "Ci 18 475"},
        {"Geneva Identification System", "GEN# +1.00022380"},
        {"Smithsonian Astrophysical Observation", "SAO 130597"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.95370863),
        dec: Angle.Degrees(-09.06024562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -208.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219831"},
        {"Hipparcos Number", "HIP 115117"},
        {"Renson", "Renson 60350"},
        {"Smithsonian Astrophysical Observation", "SAO 146637"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.75599311),
        dec: Angle.Degrees(-09.05972013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116190"},
        {"Hipparcos Number", "HIP 65232"},
        {"Smithsonian Astrophysical Observation", "SAO 139298"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.52384621),
        dec: Angle.Degrees(-09.05971095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -221.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115902"},
        {"Hipparcos Number", "HIP 65078"},
        {"Smithsonian Astrophysical Observation", "SAO 139284"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.09180423),
        dec: Angle.Degrees(-09.05969116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89565"},
        {"Hipparcos Number", "HIP 50584"},
        {"Geneva Identification System", "GEN# +1.00089565"},
        {"Smithsonian Astrophysical Observation", "SAO 137495"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.99799665),
        dec: Angle.Degrees(-09.05882983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98246",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13163 A"},
        {"Henry Draper", "HD 188938"},
        {"Hipparcos Number", "HIP 98246"},
        {"Smithsonian Astrophysical Observation", "SAO 143951"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.47375336),
        dec: Angle.Degrees(-09.05842984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45710"},
        {"Hipparcos Number", "HIP 30856"},
        {"Smithsonian Astrophysical Observation", "SAO 133315"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.18726501),
        dec: Angle.Degrees(-09.05658791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1587"},
        {"Hipparcos Number", "HIP 1607"},
        {"Smithsonian Astrophysical Observation", "SAO 128700"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.02695843),
        dec: Angle.Degrees(-09.05647913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109583"},
        {"Hipparcos Number", "HIP 61485"},
        {"Smithsonian Astrophysical Observation", "SAO 138867"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.96840093),
        dec: Angle.Degrees(-09.05528535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69437"},
        {"Hipparcos Number", "HIP 40542"},
        {"Geneva Identification System", "GEN# +1.00069437"},
        {"Smithsonian Astrophysical Observation", "SAO 135715"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.17820134),
        dec: Angle.Degrees(-09.05350298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121864"},
        {"Hipparcos Number", "HIP 68241"},
        {"Smithsonian Astrophysical Observation", "SAO 139655"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.55275204),
        dec: Angle.Degrees(-09.05279959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91726",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11581 A"},
        {"Henry Draper", "HD 172748"},
        {"Hipparcos Number", "HIP 91726"},
        {"Fundamental Katalog 5th Edition", "FK5 1486"},
        {"Geneva Identification System", "GEN# +1.00172748"},
        {"Renson", "Renson 48450"},
        {"Smithsonian Astrophysical Observation", "SAO 142515"},
        {"Wilson Evans Batten Catalogue", "WEB 15779"},
    },
    visualMagnitude: 4.70,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.56842553),
        dec: Angle.Degrees(-09.05255357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73997"},
        {"Hipparcos Number", "HIP 42606"},
        {"Fundamental Katalog 5th Edition", "FK5 2682"},
        {"Geneva Identification System", "GEN# +1.00073997"},
        {"Smithsonian Astrophysical Observation", "SAO 136176"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.25683957),
        dec: Angle.Degrees(-09.05200513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171465"},
        {"Hipparcos Number", "HIP 91133"},
        {"Smithsonian Astrophysical Observation", "SAO 142410"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.84139466),
        dec: Angle.Degrees(-09.05151434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197466"},
        {"Hipparcos Number", "HIP 102351"},
        {"Geneva Identification System", "GEN# +1.00197466"},
        {"Smithsonian Astrophysical Observation", "SAO 144747"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.06809611),
        dec: Angle.Degrees(-09.04962375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36798"},
        {"Hipparcos Number", "HIP 26092"},
        {"Smithsonian Astrophysical Observation", "SAO 132268"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.47274014),
        dec: Angle.Degrees(-09.04871172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122973"},
        {"Hipparcos Number", "HIP 68805"},
        {"Geneva Identification System", "GEN# +1.00122973"},
        {"Smithsonian Astrophysical Observation", "SAO 139725"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.29480149),
        dec: Angle.Degrees(-09.04849338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164483"},
        {"Hipparcos Number", "HIP 88291"},
        {"Geneva Identification System", "GEN# +9.26517001"},
        {"Smithsonian Astrophysical Observation", "SAO 142038"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.43812566),
        dec: Angle.Degrees(-09.04682348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205606"},
        {"Hipparcos Number", "HIP 106693"},
        {"Smithsonian Astrophysical Observation", "SAO 145521"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.15269472),
        dec: Angle.Degrees(-09.04675126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139288"},
        {"Hipparcos Number", "HIP 76517"},
        {"Geneva Identification System", "GEN# +1.00139288"},
        {"Smithsonian Astrophysical Observation", "SAO 140661"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.40827405),
        dec: Angle.Degrees(-09.04491085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92426"},
        {"Hipparcos Number", "HIP 52232"},
        {"Smithsonian Astrophysical Observation", "SAO 137717"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.06313756),
        dec: Angle.Degrees(-09.04403179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189948"},
        {"Hipparcos Number", "HIP 98716"},
        {"Geneva Identification System", "GEN# +1.00189948"},
        {"Smithsonian Astrophysical Observation", "SAO 144024"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.75489450),
        dec: Angle.Degrees(-09.04259358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39421"},
        {"Hipparcos Number", "HIP 27713"},
        {"Celescope Catalog", "CEL 1012"},
        {"Geneva Identification System", "GEN# +1.00039421"},
        {"Smithsonian Astrophysical Observation", "SAO 132603"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.03221102),
        dec: Angle.Degrees(-09.04197853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89166"},
        {"Hipparcos Number", "HIP 50363"},
        {"Smithsonian Astrophysical Observation", "SAO 137462"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.25132786),
        dec: Angle.Degrees(-09.04194951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222756"},
        {"Hipparcos Number", "HIP 117027"},
        {"Smithsonian Astrophysical Observation", "SAO 146864"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.85305132),
        dec: Angle.Degrees(-09.04142982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211392"},
        {"Hipparcos Number", "HIP 110009"},
        {"Geneva Identification System", "GEN# +1.00211392"},
        {"Smithsonian Astrophysical Observation", "SAO 145992"},
        {"Wilson Evans Batten Catalogue", "WEB 19753"},
    },
    visualMagnitude: 5.80,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.21916736),
        dec: Angle.Degrees(-09.04003734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18719"},
        {"Hipparcos Number", "HIP 14001"},
        {"Smithsonian Astrophysical Observation", "SAO 130238"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.07068993),
        dec: Angle.Degrees(-09.03970372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 282.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22892"},
        {"Hipparcos Number", "HIP 17135"},
        {"Geneva Identification System", "GEN# +1.00022892"},
        {"Smithsonian Astrophysical Observation", "SAO 130648"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.04485679),
        dec: Angle.Degrees(-09.03913188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118115"},
        {"Hipparcos Number", "HIP 66266"},
        {"Smithsonian Astrophysical Observation", "SAO 139422"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.72641063),
        dec: Angle.Degrees(-09.03830740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206833"},
        {"Hipparcos Number", "HIP 107379"},
        {"Geneva Identification System", "GEN# +1.00206833"},
        {"Smithsonian Astrophysical Observation", "SAO 145635"},
        {"Wilson Evans Batten Catalogue", "WEB 19392"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.23039595),
        dec: Angle.Degrees(-09.03636672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29705",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4866 AB"},
        {"Henry Draper", "HD 43362"},
        {"Hipparcos Number", "HIP 29705"},
        {"Celescope Catalog", "CEL 1149"},
        {"Geneva Identification System", "GEN# +1.00043362J"},
        {"Smithsonian Astrophysical Observation", "SAO 133029"},
        {"Wilson Evans Batten Catalogue", "WEB 5852"},
    },
    visualMagnitude: 6.09,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.85898495),
        dec: Angle.Degrees(-09.03575110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93572"},
        {"Hipparcos Number", "HIP 52820"},
        {"Smithsonian Astrophysical Observation", "SAO 137791"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.98639313),
        dec: Angle.Degrees(-09.03441129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151221"},
        {"Hipparcos Number", "HIP 82112"},
        {"Smithsonian Astrophysical Observation", "SAO 141353"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.59499316),
        dec: Angle.Degrees(-09.03421044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2945"},
        {"Hipparcos Number", "HIP 2569"},
        {"Smithsonian Astrophysical Observation", "SAO 128817"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.15355029),
        dec: Angle.Degrees(-09.03407299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204216"},
        {"Hipparcos Number", "HIP 105939"},
        {"Smithsonian Astrophysical Observation", "SAO 145407"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.83234662),
        dec: Angle.Degrees(-09.03200451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160017"},
        {"Hipparcos Number", "HIP 86300"},
        {"Geneva Identification System", "GEN# +1.00160017"},
        {"Smithsonian Astrophysical Observation", "SAO 141775"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.50485500),
        dec: Angle.Degrees(-09.02997771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97089"},
        {"Hipparcos Number", "HIP 54599"},
        {"Geneva Identification System", "GEN# +1.00097089"},
        {"Smithsonian Astrophysical Observation", "SAO 138026"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.61692438),
        dec: Angle.Degrees(-09.02742676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51725"},
        {"Hipparcos Number", "HIP 33530"},
        {"Geneva Identification System", "GEN# +1.00051725"},
        {"Smithsonian Astrophysical Observation", "SAO 133965"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.52964489),
        dec: Angle.Degrees(-09.02731096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125059"},
        {"Hipparcos Number", "HIP 69823"},
        {"Smithsonian Astrophysical Observation", "SAO 139847"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.34434060),
        dec: Angle.Degrees(-09.02274894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71831"},
        {"Hipparcos Number", "HIP 41628"},
        {"Smithsonian Astrophysical Observation", "SAO 135969"},
    },
    visualMagnitude: 8.78,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.30104522),
        dec: Angle.Degrees(-09.02265873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218920"},
        {"Hipparcos Number", "HIP 114532"},
        {"Smithsonian Astrophysical Observation", "SAO 146556"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.97860814),
        dec: Angle.Degrees(-09.02199845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154017"},
        {"Hipparcos Number", "HIP 83440"},
        {"Smithsonian Astrophysical Observation", "SAO 141501"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.80645957),
        dec: Angle.Degrees(-09.01762340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9484"},
        {"Hipparcos Number", "HIP 7222"},
        {"Geneva Identification System", "GEN# +1.00009484"},
        {"Renson", "Renson 2280"},
        {"Smithsonian Astrophysical Observation", "SAO 129363"},
    },
    visualMagnitude: 6.60,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.26463144),
        dec: Angle.Degrees(-09.01467905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193801"},
        {"Hipparcos Number", "HIP 100482"},
        {"Smithsonian Astrophysical Observation", "SAO 144354"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.64657528),
        dec: Angle.Degrees(-09.01460746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163492"},
        {"Hipparcos Number", "HIP 87841"},
        {"Geneva Identification System", "GEN# +1.00163492"},
        {"Smithsonian Astrophysical Observation", "SAO 141976"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.17965776),
        dec: Angle.Degrees(-09.01459700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40548",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6714 AB"},
        {"Henry Draper", "HD 69460"},
        {"Hipparcos Number", "HIP 40548"},
        {"Smithsonian Astrophysical Observation", "SAO 135717"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.19848921),
        dec: Angle.Degrees(-09.01425032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13977"},
        {"Hipparcos Number", "HIP 10532"},
        {"Smithsonian Astrophysical Observation", "SAO 129784"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.92378706),
        dec: Angle.Degrees(-09.01314313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182642"},
        {"Hipparcos Number", "HIP 95533"},
        {"Smithsonian Astrophysical Observation", "SAO 143391"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.48535273),
        dec: Angle.Degrees(-09.01258287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14995"},
        {"Hipparcos Number", "HIP 11255"},
        {"Smithsonian Astrophysical Observation", "SAO 129886"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.21632082),
        dec: Angle.Degrees(-09.01210431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218476"},
        {"Hipparcos Number", "HIP 114261"},
        {"Smithsonian Astrophysical Observation", "SAO 146525"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.11138933),
        dec: Angle.Degrees(-09.00965640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30679"},
        {"Hipparcos Number", "HIP 22406"},
        {"Smithsonian Astrophysical Observation", "SAO 131521"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.32916762),
        dec: Angle.Degrees(-09.00937831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160983"},
        {"Hipparcos Number", "HIP 86734"},
        {"Smithsonian Astrophysical Observation", "SAO 141826"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.84649616),
        dec: Angle.Degrees(-09.00919516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23587"},
        {"Hipparcos Number", "HIP 17582"},
        {"Geneva Identification System", "GEN# +1.00023587"},
        {"Smithsonian Astrophysical Observation", "SAO 130711"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.48988405),
        dec: Angle.Degrees(-09.00850671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73743",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73743"},
        {"Smithsonian Astrophysical Observation", "SAO 140300"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.10809825),
        dec: Angle.Degrees(-09.00478586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196058"},
        {"Hipparcos Number", "HIP 101580"},
        {"Smithsonian Astrophysical Observation", "SAO 144598"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.80622741),
        dec: Angle.Degrees(-09.00369660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143066"},
        {"Hipparcos Number", "HIP 78244"},
        {"Geneva Identification System", "GEN# +1.00143066"},
        {"Smithsonian Astrophysical Observation", "SAO 140868"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.63925104),
        dec: Angle.Degrees(-09.00338578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46931"},
        {"Hipparcos Number", "HIP 31490"},
        {"Smithsonian Astrophysical Observation", "SAO 133452"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.92717098),
        dec: Angle.Degrees(-08.99961456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49331"},
        {"Hipparcos Number", "HIP 32558"},
        {"Geneva Identification System", "GEN# +1.00049331"},
        {"Smithsonian Astrophysical Observation", "SAO 133679"},
        {"Wilson Evans Batten Catalogue", "WEB 6565"},
    },
    visualMagnitude: 5.08,
    bvColour: 1.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.90509833),
        dec: Angle.Degrees(-08.99850109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25042"},
        {"Hipparcos Number", "HIP 18561"},
        {"Geneva Identification System", "GEN# +1.00025042"},
        {"Smithsonian Astrophysical Observation", "SAO 130856"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.59467886),
        dec: Angle.Degrees(-08.99833005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139879"},
        {"Hipparcos Number", "HIP 76804"},
        {"Geneva Identification System", "GEN# +1.00139879"},
        {"Smithsonian Astrophysical Observation", "SAO 140696"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.23070631),
        dec: Angle.Degrees(-08.99824274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223084"},
        {"Hipparcos Number", "HIP 117258"},
        {"Geneva Identification System", "GEN# +1.00223084"},
        {"Smithsonian Astrophysical Observation", "SAO 146898"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.64167796),
        dec: Angle.Degrees(-08.99674047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 188.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223807"},
        {"Hipparcos Number", "HIP 117756"},
        {"Geneva Identification System", "GEN# +1.00223807"},
        {"Smithsonian Astrophysical Observation", "SAO 146953"},
        {"Wilson Evans Batten Catalogue", "WEB 20721"},
    },
    visualMagnitude: 5.76,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.21038458),
        dec: Angle.Degrees(-08.99669856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17423"},
        {"Hipparcos Number", "HIP 13032"},
        {"Smithsonian Astrophysical Observation", "SAO 130115"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.87007555),
        dec: Angle.Degrees(-08.99537021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132661"},
        {"Hipparcos Number", "HIP 73446"},
        {"Smithsonian Astrophysical Observation", "SAO 140267"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.13325955),
        dec: Angle.Degrees(-08.99484373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204447"},
        {"Hipparcos Number", "HIP 106055"},
        {"Smithsonian Astrophysical Observation", "SAO 145426"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.22051130),
        dec: Angle.Degrees(-08.99070132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106432"},
        {"Hipparcos Number", "HIP 59702"},
        {"Geneva Identification System", "GEN# +1.00106432"},
        {"Smithsonian Astrophysical Observation", "SAO 138667"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.65737863),
        dec: Angle.Degrees(-08.99005675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77573"},
        {"Hipparcos Number", "HIP 44429"},
        {"Smithsonian Astrophysical Observation", "SAO 136533"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.78438508),
        dec: Angle.Degrees(-08.98986615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76993"},
        {"Hipparcos Number", "HIP 44134"},
        {"Smithsonian Astrophysical Observation", "SAO 136466"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.83315435),
        dec: Angle.Degrees(-08.98981174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93904"},
        {"Hipparcos Number", "HIP 52979"},
        {"Smithsonian Astrophysical Observation", "SAO 137821"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.55659873),
        dec: Angle.Degrees(-08.98849768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13391",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13391"},
        {"Smithsonian Astrophysical Observation", "SAO 130158"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.08991604),
        dec: Angle.Degrees(-08.98642314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39188"},
        {"Hipparcos Number", "HIP 27586"},
        {"Smithsonian Astrophysical Observation", "SAO 132584"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.62420217),
        dec: Angle.Degrees(-08.98479270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114113"},
        {"Hipparcos Number", "HIP 64122"},
        {"Fundamental Katalog 5th Edition", "FK5 3046"},
        {"Geneva Identification System", "GEN# +1.00114113"},
        {"Smithsonian Astrophysical Observation", "SAO 139175"},
        {"Wilson Evans Batten Catalogue", "WEB 11333"},
    },
    visualMagnitude: 5.57,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.13536674),
        dec: Angle.Degrees(-08.98422912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198743"},
        {"Hipparcos Number", "HIP 103045"},
        {"Fundamental Katalog 5th Edition", "FK5 1547"},
        {"Geneva Identification System", "GEN# +1.00198743"},
        {"Renson", "Renson 55320"},
        {"Smithsonian Astrophysical Observation", "SAO 144895"},
        {"Wilson Evans Batten Catalogue", "WEB 18706"},
    },
    visualMagnitude: 4.73,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.16335749),
        dec: Angle.Degrees(-08.98323782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207627"},
        {"Hipparcos Number", "HIP 107820"},
        {"Smithsonian Astrophysical Observation", "SAO 145698"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.64756999),
        dec: Angle.Degrees(-08.98245135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147624"},
        {"Hipparcos Number", "HIP 80291"},
        {"Geneva Identification System", "GEN# +1.00147624"},
        {"Smithsonian Astrophysical Observation", "SAO 141141"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.834,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.84741595),
        dec: Angle.Degrees(-08.98244936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12144"},
        {"Hipparcos Number", "HIP 9265"},
        {"Smithsonian Astrophysical Observation", "SAO 129603"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.76903219),
        dec: Angle.Degrees(-08.98173911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38014",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38014"},
        {"Smithsonian Astrophysical Observation", "SAO 135104"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.86898849),
        dec: Angle.Degrees(-08.98025824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57682"},
        {"Hipparcos Number", "HIP 35707"},
        {"Geneva Identification System", "GEN# +1.00057682"},
        {"Smithsonian Astrophysical Observation", "SAO 134580"},
        {"Wilson Evans Batten Catalogue", "WEB 7113"},
    },
    visualMagnitude: 6.42,
    bvColour: -0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.50853709),
        dec: Angle.Degrees(-08.97941188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206637"},
        {"Hipparcos Number", "HIP 107273"},
        {"Smithsonian Astrophysical Observation", "SAO 145622"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.92528389),
        dec: Angle.Degrees(-08.97638217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 169.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 561"},
        {"Hipparcos Number", "HIP 818"},
        {"Geneva Identification System", "GEN# +1.00000561"},
        {"Smithsonian Astrophysical Observation", "SAO 128619"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.51367088),
        dec: Angle.Degrees(-08.97418208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42437"},
        {"Hipparcos Number", "HIP 29281"},
        {"Smithsonian Astrophysical Observation", "SAO 132914"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.59833509),
        dec: Angle.Degrees(-08.97064834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152469"},
        {"Hipparcos Number", "HIP 82656"},
        {"Smithsonian Astrophysical Observation", "SAO 141422"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.44806186),
        dec: Angle.Degrees(-08.97049330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176141"},
        {"Hipparcos Number", "HIP 93208"},
        {"Geneva Identification System", "GEN# +1.00176141"},
        {"Smithsonian Astrophysical Observation", "SAO 142876"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.78224445),
        dec: Angle.Degrees(-08.97047248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29065"},
        {"Hipparcos Number", "HIP 21297"},
        {"Geneva Identification System", "GEN# +1.00029065"},
        {"Smithsonian Astrophysical Observation", "SAO 131316"},
        {"Wilson Evans Batten Catalogue", "WEB 4095"},
    },
    visualMagnitude: 5.24,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.54913224),
        dec: Angle.Degrees(-08.96998497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43033",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43033"},
        {"Smithsonian Astrophysical Observation", "SAO 136258"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.52699313),
        dec: Angle.Degrees(-08.96761791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15605",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15605"},
        {"Smithsonian Astrophysical Observation", "SAO 130434"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.23711224),
        dec: Angle.Degrees(-08.96483615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46426"},
        {"Hipparcos Number", "HIP 31226"},
        {"Celescope Catalog", "CEL 1295"},
        {"Geneva Identification System", "GEN# +1.00046426"},
        {"Smithsonian Astrophysical Observation", "SAO 133399"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.24696056),
        dec: Angle.Degrees(-08.96403802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212625"},
        {"Hipparcos Number", "HIP 110715"},
        {"Smithsonian Astrophysical Observation", "SAO 146082"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.47395516),
        dec: Angle.Degrees(-08.95938311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71172"},
        {"Hipparcos Number", "HIP 41303"},
        {"Smithsonian Astrophysical Observation", "SAO 135897"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.40581563),
        dec: Angle.Degrees(-08.95606905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171980"},
        {"Hipparcos Number", "HIP 91353"},
        {"Smithsonian Astrophysical Observation", "SAO 142448"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.48684733),
        dec: Angle.Degrees(-08.95505423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91206"},
        {"Hipparcos Number", "HIP 51549"},
        {"Smithsonian Astrophysical Observation", "SAO 137621"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.93544929),
        dec: Angle.Degrees(-08.95181181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150686"},
        {"Hipparcos Number", "HIP 81843"},
        {"Fundamental Katalog 5th Edition", "FK5 5478"},
        {"Geneva Identification System", "GEN# +1.00150686"},
        {"Smithsonian Astrophysical Observation", "SAO 141326"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.75546083),
        dec: Angle.Degrees(-08.95122741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137666"},
        {"Hipparcos Number", "HIP 75673"},
        {"Smithsonian Astrophysical Observation", "SAO 140545"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.90997910),
        dec: Angle.Degrees(-08.94807345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100344"},
        {"Hipparcos Number", "HIP 56315"},
        {"Smithsonian Astrophysical Observation", "SAO 138264"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.18631566),
        dec: Angle.Degrees(-08.94785341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14545",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14545"},
        {"Smithsonian Astrophysical Observation", "SAO 130301"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.94838546),
        dec: Angle.Degrees(-08.94608343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125992"},
        {"Hipparcos Number", "HIP 70302"},
        {"Smithsonian Astrophysical Observation", "SAO 139905"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.76248639),
        dec: Angle.Degrees(-08.94463964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152780"},
        {"Hipparcos Number", "HIP 82835"},
        {"Geneva Identification System", "GEN# +1.00152780"},
        {"Smithsonian Astrophysical Observation", "SAO 141440"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.91799912),
        dec: Angle.Degrees(-08.94366365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163915"},
        {"Hipparcos Number", "HIP 88035"},
        {"Smithsonian Astrophysical Observation", "SAO 142001"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.72650036),
        dec: Angle.Degrees(-08.94050103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7983"},
        {"Hipparcos Number", "HIP 6159"},
        {"Cincinnati Publication", "Ci 20 95"},
        {"Cincinnati Publication 2", "Ci 18 167"},
        {"Geneva Identification System", "GEN# +1.00007983"},
        {"Smithsonian Astrophysical Observation", "SAO 129224"},
        {"Wilson Evans Batten Catalogue", "WEB 1382"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.75050653),
        dec: Angle.Degrees(-08.93837901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -230.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -458.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38185"},
        {"Hipparcos Number", "HIP 26999"},
        {"Celescope Catalog", "CEL 948"},
        {"Geneva Identification System", "GEN# +1.00038185"},
        {"Smithsonian Astrophysical Observation", "SAO 132490"},
    },
    visualMagnitude: 7.61,
    bvColour: -0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.91381417),
        dec: Angle.Degrees(-08.93775661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179290"},
        {"Hipparcos Number", "HIP 94358"},
        {"Smithsonian Astrophysical Observation", "SAO 143125"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.08222700),
        dec: Angle.Degrees(-08.93596851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20410"},
        {"Hipparcos Number", "HIP 15250"},
        {"Smithsonian Astrophysical Observation", "SAO 130399"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.18163169),
        dec: Angle.Degrees(-08.93596162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169156"},
        {"Hipparcos Number", "HIP 90135"},
        {"Geneva Identification System", "GEN# +1.00169156"},
        {"Smithsonian Astrophysical Observation", "SAO 142267"},
        {"Wilson Evans Batten Catalogue", "WEB 15410"},
    },
    visualMagnitude: 4.66,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.91480755),
        dec: Angle.Degrees(-08.93451038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114826"},
        {"Hipparcos Number", "HIP 64497"},
        {"Smithsonian Astrophysical Observation", "SAO 139223"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.30467446),
        dec: Angle.Degrees(-08.93173002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3748"},
        {"Hipparcos Number", "HIP 3158"},
        {"Smithsonian Astrophysical Observation", "SAO 128884"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)40, 09.9600),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)55, 53.300)
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
    primaryId: "HIP 73114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131895"},
        {"Hipparcos Number", "HIP 73114"},
        {"Geneva Identification System", "GEN# +1.00131895"},
        {"Smithsonian Astrophysical Observation", "SAO 140234"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.14054555),
        dec: Angle.Degrees(-08.93129463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 137.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114703",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16611 B"},
        {"Henry Draper", "HD 219175B"},
        {"Hipparcos Number", "HIP 114703"},
        {"Cincinnati Publication", "Ci 18 3039"},
        {"Cincinnati Publication 2", "Ci 20 1409"},
        {"Geneva Identification System", "GEN# +1.00219175B"},
        {"Geneva Identification System 2", "GEN# -0.00906150"},
        {"Smithsonian Astrophysical Observation", "SAO 146578"},
        {"Wilson Evans Batten Catalogue", "WEB 20339"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.53031710),
        dec: Angle.Degrees(-08.93119767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 566.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90765"},
        {"Hipparcos Number", "HIP 51296"},
        {"Smithsonian Astrophysical Observation", "SAO 137593"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.17715567),
        dec: Angle.Degrees(-08.93054969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151632"},
        {"Hipparcos Number", "HIP 82303"},
        {"Geneva Identification System", "GEN# +1.00151632"},
        {"Smithsonian Astrophysical Observation", "SAO 141377"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.24924226),
        dec: Angle.Degrees(-08.92991810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133894"},
        {"Hipparcos Number", "HIP 73984"},
        {"Smithsonian Astrophysical Observation", "SAO 140331"},
        {"Wilson Evans Batten Catalogue", "WEB 12635"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.79052056),
        dec: Angle.Degrees(-08.92862632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98144"},
        {"Hipparcos Number", "HIP 55139"},
        {"Smithsonian Astrophysical Observation", "SAO 138112"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.32733877),
        dec: Angle.Degrees(-08.92858813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70970"},
        {"Hipparcos Number", "HIP 41216"},
        {"Smithsonian Astrophysical Observation", "SAO 135883"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.15459342),
        dec: Angle.Degrees(-08.92834974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33735"},
        {"Hipparcos Number", "HIP 24216"},
        {"Smithsonian Astrophysical Observation", "SAO 131863"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.00312674),
        dec: Angle.Degrees(-08.92810479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16548"},
        {"Hipparcos Number", "HIP 12350"},
        {"Geneva Identification System", "GEN# +1.00016548"},
        {"Smithsonian Astrophysical Observation", "SAO 130036"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.75269246),
        dec: Angle.Degrees(-08.92776305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 272.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176878"},
        {"Hipparcos Number", "HIP 93504"},
        {"Smithsonian Astrophysical Observation", "SAO 142947"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.64772242),
        dec: Angle.Degrees(-08.92758946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34933",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5904 AB"},
        {"Henry Draper", "HD 55736"},
        {"Hipparcos Number", "HIP 34933"},
        {"Geneva Identification System", "GEN# +1.00055736J"},
        {"Smithsonian Astrophysical Observation", "SAO 134379"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.42643522),
        dec: Angle.Degrees(-08.92527253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4137",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4137"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.23192406),
        dec: Angle.Degrees(-08.92496865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -234.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114702",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16611 A"},
        {"Henry Draper", "HD 219175A"},
        {"Henry Draper 2", "HD 219175"},
        {"Hipparcos Number", "HIP 114702"},
        {"Cincinnati Publication", "Ci 18 3038"},
        {"Cincinnati Publication 2", "Ci 20 1408"},
        {"Geneva Identification System", "GEN# +1.00219175A"},
        {"Smithsonian Astrophysical Observation", "SAO 146577"},
        {"Wilson Evans Batten Catalogue", "WEB 20338"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.52977577),
        dec: Angle.Degrees(-08.92423966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 551.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114481"},
        {"Hipparcos Number", "HIP 64319"},
        {"Smithsonian Astrophysical Observation", "SAO 139200"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.74293097),
        dec: Angle.Degrees(-08.92393310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192449"},
        {"Hipparcos Number", "HIP 99829"},
        {"Smithsonian Astrophysical Observation", "SAO 144214"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.82720752),
        dec: Angle.Degrees(-08.92378002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187224"},
        {"Hipparcos Number", "HIP 97519"},
        {"Geneva Identification System", "GEN# +1.00187224"},
        {"Smithsonian Astrophysical Observation", "SAO 143816"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.31034974),
        dec: Angle.Degrees(-08.92288142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100921"},
        {"Hipparcos Number", "HIP 56643"},
        {"Smithsonian Astrophysical Observation", "SAO 138297"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.21631473),
        dec: Angle.Degrees(-08.92134875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220020"},
        {"Hipparcos Number", "HIP 115253"},
        {"Smithsonian Astrophysical Observation", "SAO 146650"},
    },
    visualMagnitude: 7.90,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.16198254),
        dec: Angle.Degrees(-08.91959615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49123"},
        {"Hipparcos Number", "HIP 32461"},
        {"Celescope Catalog", "CEL 1380"},
        {"Geneva Identification System", "GEN# +1.00049123"},
        {"Smithsonian Astrophysical Observation", "SAO 133660"},
    },
    visualMagnitude: 7.20,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.63244851),
        dec: Angle.Degrees(-08.91860252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89147"},
        {"Hipparcos Number", "HIP 50352"},
        {"Smithsonian Astrophysical Observation", "SAO 137460"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.23094935),
        dec: Angle.Degrees(-08.91556633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -200.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60088",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8509 A"},
        {"Henry Draper", "HD 107161"},
        {"Hipparcos Number", "HIP 60088"},
        {"Fundamental Katalog 5th Edition", "FK5 1315"},
        {"Geneva Identification System", "GEN# +1.00107161"},
        {"Smithsonian Astrophysical Observation", "SAO 138716"},
        {"Wilson Evans Batten Catalogue", "WEB 10679"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.83413098),
        dec: Angle.Degrees(-08.91459926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15179"},
        {"Hipparcos Number", "HIP 11376"},
        {"Smithsonian Astrophysical Observation", "SAO 129903"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.62710171),
        dec: Angle.Degrees(-08.91459227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190774"},
        {"Hipparcos Number", "HIP 99085"},
        {"Smithsonian Astrophysical Observation", "SAO 144074"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.73271989),
        dec: Angle.Degrees(-08.91425743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112504"},
        {"Hipparcos Number", "HIP 63225"},
        {"Fundamental Katalog 5th Edition", "FK5 5142"},
        {"Geneva Identification System", "GEN# +1.00112504"},
        {"Smithsonian Astrophysical Observation", "SAO 139060"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.32926142),
        dec: Angle.Degrees(-08.91081357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114643",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16604 AB"},
        {"Henry Draper", "HD 219102"},
        {"Hipparcos Number", "HIP 114643"},
        {"Renson", "Renson 60240"},
        {"Smithsonian Astrophysical Observation", "SAO 146570"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.36477625),
        dec: Angle.Degrees(-08.90810492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21126"},
        {"Hipparcos Number", "HIP 15864"},
        {"Smithsonian Astrophysical Observation", "SAO 130465"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.08927450),
        dec: Angle.Degrees(-08.90804320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177657"},
        {"Hipparcos Number", "HIP 93780"},
        {"Geneva Identification System", "GEN# +1.00177657"},
        {"Smithsonian Astrophysical Observation", "SAO 143011"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.47515540),
        dec: Angle.Degrees(-08.90764350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6976"},
        {"Hipparcos Number", "HIP 5485"},
        {"Geneva Identification System", "GEN# +1.00006976"},
        {"Smithsonian Astrophysical Observation", "SAO 129154"},
        {"Wilson Evans Batten Catalogue", "WEB 1211"},
    },
    visualMagnitude: 6.40,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.54982773),
        dec: Angle.Degrees(-08.90603998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10573",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1736 AB"},
        {"Henry Draper", "HD 14032"},
        {"Hipparcos Number", "HIP 10573"},
        {"Smithsonian Astrophysical Observation", "SAO 129790"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.02780092),
        dec: Angle.Degrees(-08.90475979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1609"},
        {"Hipparcos Number", "HIP 1626"},
        {"Geneva Identification System", "GEN# +1.00001609"},
        {"Smithsonian Astrophysical Observation", "SAO 128701"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.08068878),
        dec: Angle.Degrees(-08.90431808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107038"},
        {"Hipparcos Number", "HIP 60019"},
        {"Geneva Identification System", "GEN# +1.00107038"},
        {"Smithsonian Astrophysical Observation", "SAO 138706"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.63390115),
        dec: Angle.Degrees(-08.90423257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97976"},
        {"Hipparcos Number", "HIP 55040"},
        {"Smithsonian Astrophysical Observation", "SAO 138094"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.01001195),
        dec: Angle.Degrees(-08.90004819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28262"},
        {"Hipparcos Number", "HIP 20787"},
        {"Smithsonian Astrophysical Observation", "SAO 131223"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.78541474),
        dec: Angle.Degrees(-08.89854149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78081",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78081"},
        {"Smithsonian Astrophysical Observation", "SAO 140844"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.15352085),
        dec: Angle.Degrees(-08.89785229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52980",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7942 A"},
        {"Henry Draper", "HD 93903"},
        {"Hipparcos Number", "HIP 52980"},
        {"Fundamental Katalog 5th Edition", "FK5 1281"},
        {"Geneva Identification System", "GEN# +1.00093903A"},
        {"Renson", "Renson 27170"},
        {"Smithsonian Astrophysical Observation", "SAO 137823"},
        {"Wilson Evans Batten Catalogue", "WEB 9637"},
    },
    visualMagnitude: 5.80,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.57524733),
        dec: Angle.Degrees(-08.89772694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13701",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Azha"},
        {"Henry Draper", "HD 18322"},
        {"Hipparcos Number", "HIP 13701"},
        {"Fundamental Katalog 5th Edition", "FK5 104"},
        {"Geneva Identification System", "GEN# +1.00018322"},
        {"Smithsonian Astrophysical Observation", "SAO 130197"},
        {"Wilson Evans Batten Catalogue", "WEB 2718"},
    },
    visualMagnitude: 3.89,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.10668245),
        dec: Angle.Degrees(-08.89760976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223115"},
        {"Hipparcos Number", "HIP 117274"},
        {"Geneva Identification System", "GEN# +1.00223115"},
        {"Smithsonian Astrophysical Observation", "SAO 146901"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.71158157),
        dec: Angle.Degrees(-08.89684675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223797"},
        {"Hipparcos Number", "HIP 117743"},
        {"Smithsonian Astrophysical Observation", "SAO 146949"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.18687361),
        dec: Angle.Degrees(-08.89487373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32395"},
        {"Hipparcos Number", "HIP 23464"},
        {"Smithsonian Astrophysical Observation", "SAO 131714"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.65786095),
        dec: Angle.Degrees(-08.89420164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123177"},
        {"Hipparcos Number", "HIP 68888"},
        {"Fundamental Katalog 5th Edition", "FK5 1366"},
        {"Geneva Identification System", "GEN# +1.00123177"},
        {"Smithsonian Astrophysical Observation", "SAO 139732"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.57405177),
        dec: Angle.Degrees(-08.89166563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66831"},
        {"Hipparcos Number", "HIP 39564"},
        {"Smithsonian Astrophysical Observation", "SAO 135472"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.26163195),
        dec: Angle.Degrees(-08.89022044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32835",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32835"},
        {"Smithsonian Astrophysical Observation", "SAO 133762"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.67421794),
        dec: Angle.Degrees(-08.88862788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35916",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35916"},
        {"Smithsonian Astrophysical Observation", "SAO 134626"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.05942185),
        dec: Angle.Degrees(-08.88761526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94015"},
        {"Hipparcos Number", "HIP 53027"},
        {"Smithsonian Astrophysical Observation", "SAO 137831"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.73798426),
        dec: Angle.Degrees(-08.88721931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80585"},
        {"Hipparcos Number", "HIP 45818"},
        {"Smithsonian Astrophysical Observation", "SAO 136769"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.13706641),
        dec: Angle.Degrees(-08.88717187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149701"},
        {"Hipparcos Number", "HIP 81360"},
        {"Smithsonian Astrophysical Observation", "SAO 141274"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.23360991),
        dec: Angle.Degrees(-08.88663313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87161"},
        {"Hipparcos Number", "HIP 49242"},
        {"Geneva Identification System", "GEN# +1.00087161"},
        {"Smithsonian Astrophysical Observation", "SAO 137318"},
        {"Wilson Evans Batten Catalogue", "WEB 9117"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.77429661),
        dec: Angle.Degrees(-08.88650455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40515"},
        {"Hipparcos Number", "HIP 28318"},
        {"Geneva Identification System", "GEN# +1.00040515"},
        {"Smithsonian Astrophysical Observation", "SAO 132713"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.74805135),
        dec: Angle.Degrees(-08.88492553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124973"},
        {"Hipparcos Number", "HIP 69773"},
        {"Smithsonian Astrophysical Observation", "SAO 139834"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.20310518),
        dec: Angle.Degrees(-08.88443797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199035"},
        {"Hipparcos Number", "HIP 103223"},
        {"Smithsonian Astrophysical Observation", "SAO 144928"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.69300146),
        dec: Angle.Degrees(-08.88323970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36642",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 8.59,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)32, 07.3100),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)52, 59.100)
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
    primaryId: "HIP 45656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80239"},
        {"Hipparcos Number", "HIP 45656"},
        {"Smithsonian Astrophysical Observation", "SAO 136747"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.59278211),
        dec: Angle.Degrees(-08.88277520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220386"},
        {"Hipparcos Number", "HIP 115468"},
        {"Smithsonian Astrophysical Observation", "SAO 146681"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.86130648),
        dec: Angle.Degrees(-08.88244579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 232.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73400"},
        {"Hipparcos Number", "HIP 42343"},
        {"Geneva Identification System", "GEN# +1.00073400"},
        {"Smithsonian Astrophysical Observation", "SAO 136112"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.49021333),
        dec: Angle.Degrees(-08.88151915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -158.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36640",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6158 A"},
        {"Henry Draper", "HD 59984"},
        {"Hipparcos Number", "HIP 36640"},
        {"Geneva Identification System", "GEN# +1.00059984"},
        {"Smithsonian Astrophysical Observation", "SAO 134806"},
    },
    visualMagnitude: 5.90,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.02423825),
        dec: Angle.Degrees(-08.88091851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217376"},
        {"Hipparcos Number", "HIP 113583"},
        {"Geneva Identification System", "GEN# +1.00217376"},
        {"Smithsonian Astrophysical Observation", "SAO 146438"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.08305485),
        dec: Angle.Degrees(-08.88046496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169891"},
        {"Hipparcos Number", "HIP 90436"},
        {"Smithsonian Astrophysical Observation", "SAO 142325"},
    },
    visualMagnitude: 9.07,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.78631771),
        dec: Angle.Degrees(-08.87859106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199746"},
        {"Hipparcos Number", "HIP 103591"},
        {"Smithsonian Astrophysical Observation", "SAO 145005"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.886,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.83843335),
        dec: Angle.Degrees(-08.87842422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87414"},
        {"Hipparcos Number", "HIP 49370"},
        {"Smithsonian Astrophysical Observation", "SAO 137339"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.17923622),
        dec: Angle.Degrees(-08.87772266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41663"},
        {"Hipparcos Number", "HIP 28916"},
        {"Geneva Identification System", "GEN# +1.00041663"},
        {"Smithsonian Astrophysical Observation", "SAO 132837"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.55164254),
        dec: Angle.Degrees(-08.87761699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57517"},
        {"Hipparcos Number", "HIP 35642"},
        {"Geneva Identification System", "GEN# +1.00057517"},
        {"Smithsonian Astrophysical Observation", "SAO 134563"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.31997526),
        dec: Angle.Degrees(-08.87754267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1162"},
        {"Hipparcos Number", "HIP 1266"},
        {"Smithsonian Astrophysical Observation", "SAO 128669"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.96596926),
        dec: Angle.Degrees(-08.87628735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102556"},
        {"Hipparcos Number", "HIP 57585"},
        {"Smithsonian Astrophysical Observation", "SAO 138416"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.07192704),
        dec: Angle.Degrees(-08.87441675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158559"},
        {"Hipparcos Number", "HIP 85662"},
        {"Smithsonian Astrophysical Observation", "SAO 141700"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.59204365),
        dec: Angle.Degrees(-08.87278517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14812",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14812"},
        {"Smithsonian Astrophysical Observation", "SAO 130329"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.81092968),
        dec: Angle.Degrees(-08.87182622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55890",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8167 AB"},
        {"Aitken 2", "ADS 8167"},
        {"Henry Draper", "HD 99563"},
        {"Hipparcos Number", "HIP 55890"},
        {"Renson", "Renson 28660"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.81943456),
        dec: Angle.Degrees(-08.86896100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16659"},
        {"Hipparcos Number", "HIP 12428"},
        {"Smithsonian Astrophysical Observation", "SAO 130043"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.98995839),
        dec: Angle.Degrees(-08.86824850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52329"},
        {"Hipparcos Number", "HIP 33735"},
        {"Geneva Identification System", "GEN# +1.00052329"},
        {"Smithsonian Astrophysical Observation", "SAO 134037"},
    },
    visualMagnitude: 8.63,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.11923045),
        dec: Angle.Degrees(-08.86602985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215961"},
        {"Hipparcos Number", "HIP 112656"},
        {"Smithsonian Astrophysical Observation", "SAO 146331"},
    },
    visualMagnitude: 9.63,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.23102041),
        dec: Angle.Degrees(-08.86487484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98549"},
        {"Hipparcos Number", "HIP 55364"},
        {"Smithsonian Astrophysical Observation", "SAO 138139"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.05264624),
        dec: Angle.Degrees(-08.86441161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55633"},
        {"Hipparcos Number", "HIP 34906"},
        {"Geneva Identification System", "GEN# +1.00055633"},
        {"Smithsonian Astrophysical Observation", "SAO 134371"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.33650146),
        dec: Angle.Degrees(-08.86252415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192920"},
        {"Hipparcos Number", "HIP 100031"},
        {"Geneva Identification System", "GEN# +1.00192920"},
        {"Smithsonian Astrophysical Observation", "SAO 144258"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.42722907),
        dec: Angle.Degrees(-08.86118808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162795"},
        {"Hipparcos Number", "HIP 87545"},
        {"Smithsonian Astrophysical Observation", "SAO 141937"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.27589775),
        dec: Angle.Degrees(-08.86086004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25910"},
        {"Hipparcos Number", "HIP 19121"},
        {"Fundamental Katalog 5th Edition", "FK5 2294"},
        {"Geneva Identification System", "GEN# +1.00025910"},
        {"Smithsonian Astrophysical Observation", "SAO 130948"},
        {"Wilson Evans Batten Catalogue", "WEB 3669"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.48538995),
        dec: Angle.Degrees(-08.85608374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23200"},
        {"Hipparcos Number", "HIP 17360"},
        {"Smithsonian Astrophysical Observation", "SAO 130681"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.73843315),
        dec: Angle.Degrees(-08.85586205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149662"},
        {"Hipparcos Number", "HIP 81318"},
        {"Geneva Identification System", "GEN# +1.00149662"},
        {"Smithsonian Astrophysical Observation", "SAO 141270"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.13089955),
        dec: Angle.Degrees(-08.85400161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72295"},
        {"Hipparcos Number", "HIP 41839"},
        {"Geneva Identification System", "GEN# +1.00072295"},
        {"Renson", "Renson 19980"},
        {"Smithsonian Astrophysical Observation", "SAO 136008"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.94039636),
        dec: Angle.Degrees(-08.85399195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95133"},
        {"Hipparcos Number", "HIP 53671"},
        {"Smithsonian Astrophysical Observation", "SAO 137921"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.71813671),
        dec: Angle.Degrees(-08.85322970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69874"},
        {"Hipparcos Number", "HIP 40720"},
        {"Smithsonian Astrophysical Observation", "SAO 135760"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.67787654),
        dec: Angle.Degrees(-08.85266803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20310",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3148 AB"},
        {"Henry Draper", "HD 27612"},
        {"Hipparcos Number", "HIP 20310"},
        {"Smithsonian Astrophysical Observation", "SAO 131139"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.26705366),
        dec: Angle.Degrees(-08.85195658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222891"},
        {"Hipparcos Number", "HIP 117122"},
        {"Smithsonian Astrophysical Observation", "SAO 146880"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.16178037),
        dec: Angle.Degrees(-08.84878820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18015"},
        {"Hipparcos Number", "HIP 13467"},
        {"Smithsonian Astrophysical Observation", "SAO 130170"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.36320488),
        dec: Angle.Degrees(-08.84800980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56977",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8265 A"},
        {"Henry Draper", "HD 101502"},
        {"Hipparcos Number", "HIP 56977"},
        {"Geneva Identification System", "GEN# +1.00101502"},
        {"Smithsonian Astrophysical Observation", "SAO 138342"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.20303055),
        dec: Angle.Degrees(-08.84672410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42115",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42115"},
    },
    visualMagnitude: 12.54,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.77349287),
        dec: Angle.Degrees(-08.84586923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53428"},
        {"Hipparcos Number", "HIP 34135"},
        {"Celescope Catalog", "CEL 1552"},
        {"Geneva Identification System", "GEN# +1.00053428"},
        {"Smithsonian Astrophysical Observation", "SAO 134153"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.16743913),
        dec: Angle.Degrees(-08.84586491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98853"},
        {"Hipparcos Number", "HIP 55531"},
        {"Geneva Identification System", "GEN# +1.00098853"},
        {"Smithsonian Astrophysical Observation", "SAO 138166"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.61978580),
        dec: Angle.Degrees(-08.84265134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191639"},
        {"Hipparcos Number", "HIP 99457"},
        {"Fundamental Katalog 5th Edition", "FK5 3618"},
        {"Geneva Identification System", "GEN# +1.00191639"},
        {"Smithsonian Astrophysical Observation", "SAO 144144"},
        {"Wilson Evans Batten Catalogue", "WEB 17773"},
    },
    visualMagnitude: 6.39,
    bvColour: -0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.79198547),
        dec: Angle.Degrees(-08.84233932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160142"},
        {"Hipparcos Number", "HIP 86343"},
        {"Smithsonian Astrophysical Observation", "SAO 141781"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.65886222),
        dec: Angle.Degrees(-08.84102889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134756"},
        {"Hipparcos Number", "HIP 74371"},
        {"Smithsonian Astrophysical Observation", "SAO 140373"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.96502171),
        dec: Angle.Degrees(-08.83992563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51966",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7854 AB"},
        {"Henry Draper", "HD 91962"},
        {"Hipparcos Number", "HIP 51966"},
        {"Geneva Identification System", "GEN# +1.00091962"},
        {"Smithsonian Astrophysical Observation", "SAO 137678"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.25030218),
        dec: Angle.Degrees(-08.83976089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44199"},
        {"Hipparcos Number", "HIP 30107"},
        {"Smithsonian Astrophysical Observation", "SAO 133126"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.03596276),
        dec: Angle.Degrees(-08.83756466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26584"},
        {"Hipparcos Number", "HIP 19590"},
        {"Smithsonian Astrophysical Observation", "SAO 131020"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.98375060),
        dec: Angle.Degrees(-08.83750229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65307"},
        {"Hipparcos Number", "HIP 38914"},
        {"Geneva Identification System", "GEN# +1.00065307"},
        {"Smithsonian Astrophysical Observation", "SAO 135301"},
        {"Wilson Evans Batten Catalogue", "WEB 7624"},
    },
    visualMagnitude: 9.74,
    bvColour: -0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.45558734),
        dec: Angle.Degrees(-08.83748178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86029"},
        {"Hipparcos Number", "HIP 48687"},
        {"Geneva Identification System", "GEN# +1.00086029"},
        {"Renson", "Renson 24546"},
        {"Smithsonian Astrophysical Observation", "SAO 137234"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.93750904),
        dec: Angle.Degrees(-08.83650257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85055"},
        {"Hipparcos Number", "HIP 48184"},
        {"Smithsonian Astrophysical Observation", "SAO 137157"},
        {"Wilson Evans Batten Catalogue", "WEB 8996"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.32189745),
        dec: Angle.Degrees(-08.83507361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86171"},
        {"Hipparcos Number", "HIP 48754"},
        {"Geneva Identification System", "GEN# +1.00086171"},
        {"Smithsonian Astrophysical Observation", "SAO 137240"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.16074258),
        dec: Angle.Degrees(-08.83486532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -236.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 127.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 989"},
        {"Hipparcos Number", "HIP 1141"},
        {"Smithsonian Astrophysical Observation", "SAO 128652"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.56925211),
        dec: Angle.Degrees(-08.83248683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108350"},
        {"Hipparcos Number", "HIP 60745"},
        {"Geneva Identification System", "GEN# +1.00108350"},
        {"Smithsonian Astrophysical Observation", "SAO 138786"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.74546579),
        dec: Angle.Degrees(-08.82963943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38592"},
        {"Hipparcos Number", "HIP 27254"},
        {"Smithsonian Astrophysical Observation", "SAO 132525"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.65771385),
        dec: Angle.Degrees(-08.82871256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222635"},
        {"Hipparcos Number", "HIP 116951"},
        {"Smithsonian Astrophysical Observation", "SAO 146853"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.59300413),
        dec: Angle.Degrees(-08.82860678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157744"},
        {"Hipparcos Number", "HIP 85273"},
        {"Smithsonian Astrophysical Observation", "SAO 141656"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.35969159),
        dec: Angle.Degrees(-08.82852536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193822"},
        {"Hipparcos Number", "HIP 100481"},
        {"Geneva Identification System", "GEN# +1.00193822"},
        {"Smithsonian Astrophysical Observation", "SAO 144355"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.64579958),
        dec: Angle.Degrees(-08.82522589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222545"},
        {"Hipparcos Number", "HIP 116891"},
        {"Smithsonian Astrophysical Observation", "SAO 146847"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.39974641),
        dec: Angle.Degrees(-08.82498496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224550"},
        {"Hipparcos Number", "HIP 118219"},
        {"Smithsonian Astrophysical Observation", "SAO 147009"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.70148489),
        dec: Angle.Degrees(-08.82443598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 360"},
        {"Hipparcos Number", "HIP 671"},
        {"Geneva Identification System", "GEN# +1.00000360"},
        {"Smithsonian Astrophysical Observation", "SAO 128604"},
        {"Wilson Evans Batten Catalogue", "WEB 112"},
    },
    visualMagnitude: 5.99,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.07313617),
        dec: Angle.Degrees(-08.82402541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1522"},
        {"Hipparcos Number", "HIP 1562"},
        {"Fundamental Katalog 5th Edition", "FK5 9"},
        {"Geneva Identification System", "GEN# +1.00001522A"},
        {"Smithsonian Astrophysical Observation", "SAO 128694"},
        {"Wilson Evans Batten Catalogue", "WEB 284"},
    },
    visualMagnitude: 3.56,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.85701265),
        dec: Angle.Degrees(-08.82382948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162060"},
        {"Hipparcos Number", "HIP 87239"},
        {"Smithsonian Astrophysical Observation", "SAO 141893"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.36955978),
        dec: Angle.Degrees(-08.82330054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21839"},
        {"Hipparcos Number", "HIP 16371"},
        {"Smithsonian Astrophysical Observation", "SAO 130536"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.72228186),
        dec: Angle.Degrees(-08.82075513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63095"},
        {"Hipparcos Number", "HIP 37956"},
        {"Geneva Identification System", "GEN# +1.00063095"},
        {"Smithsonian Astrophysical Observation", "SAO 135093"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.70817913),
        dec: Angle.Degrees(-08.81998157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15197",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Zibal"},
        {"Henry Draper", "HD 20320"},
        {"Hipparcos Number", "HIP 15197"},
        {"Fundamental Katalog 5th Edition", "FK5 1091"},
        {"Geneva Identification System", "GEN# +1.00020320"},
        {"Renson", "Renson 5060"},
        {"Smithsonian Astrophysical Observation", "SAO 130387"},
        {"Wilson Evans Batten Catalogue", "WEB 2924"},
    },
    visualMagnitude: 4.80,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.95844499),
        dec: Angle.Degrees(-08.81984050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26464"},
        {"Hipparcos Number", "HIP 19511"},
        {"Geneva Identification System", "GEN# +1.00026464"},
        {"Smithsonian Astrophysical Observation", "SAO 131005"},
        {"Wilson Evans Batten Catalogue", "WEB 3737"},
    },
    visualMagnitude: 5.70,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.69890202),
        dec: Angle.Degrees(-08.81982097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4971"},
        {"Hipparcos Number", "HIP 4031"},
        {"Smithsonian Astrophysical Observation", "SAO 128993"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.90539802),
        dec: Angle.Degrees(-08.81834977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13720"},
        {"Hipparcos Number", "HIP 10365"},
        {"Smithsonian Astrophysical Observation", "SAO 129760"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.39618462),
        dec: Angle.Degrees(-08.81650953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71665"},
        {"Hipparcos Number", "HIP 41547"},
        {"Geneva Identification System", "GEN# +1.00071665"},
        {"Smithsonian Astrophysical Observation", "SAO 135956"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.08241484),
        dec: Angle.Degrees(-08.81618099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73781",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73781"},
        {"Geneva Identification System", "GEN# -0.00803901"},
        {"Smithsonian Astrophysical Observation", "SAO 140306"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.21354272),
        dec: Angle.Degrees(-08.81568275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218332"},
        {"Hipparcos Number", "HIP 114172"},
        {"Smithsonian Astrophysical Observation", "SAO 146516"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.82191519),
        dec: Angle.Degrees(-08.81554682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14281",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14281"},
        {"Smithsonian Astrophysical Observation", "SAO 130266"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.02230870),
        dec: Angle.Degrees(-08.81546679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155400"},
        {"Hipparcos Number", "HIP 84098"},
        {"Geneva Identification System", "GEN# +1.00155400"},
        {"Smithsonian Astrophysical Observation", "SAO 141548"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.89073879),
        dec: Angle.Degrees(-08.81541504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189947"},
        {"Hipparcos Number", "HIP 98711"},
        {"Smithsonian Astrophysical Observation", "SAO 144022"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.73582017),
        dec: Angle.Degrees(-08.81212962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175314"},
        {"Hipparcos Number", "HIP 92843"},
        {"Smithsonian Astrophysical Observation", "SAO 142794"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.77225723),
        dec: Angle.Degrees(-08.81109730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21949"},
        {"Hipparcos Number", "HIP 16462"},
        {"Geneva Identification System", "GEN# +1.00021949"},
        {"Smithsonian Astrophysical Observation", "SAO 130549"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.01015483),
        dec: Angle.Degrees(-08.81103516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12815"},
        {"Hipparcos Number", "HIP 9755"},
        {"Smithsonian Astrophysical Observation", "SAO 129688"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.36363756),
        dec: Angle.Degrees(-08.80988500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218528"},
        {"Hipparcos Number", "HIP 114284"},
        {"Smithsonian Astrophysical Observation", "SAO 146529"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.20579715),
        dec: Angle.Degrees(-08.80782515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44722",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44722"},
        {"Geneva Identification System", "GEN# -0.00802582"},
        {"Smithsonian Astrophysical Observation", "SAO 136586"},
        {"Wilson Evans Batten Catalogue", "WEB 8553"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.68970461),
        dec: Angle.Degrees(-08.80734614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -308.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 210.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53754"},
        {"Hipparcos Number", "HIP 34236"},
        {"Celescope Catalog", "CEL 1570"},
        {"Geneva Identification System", "GEN# +1.00053754"},
        {"Smithsonian Astrophysical Observation", "SAO 134180"},
        {"Wilson Evans Batten Catalogue", "WEB 6856"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.46062092),
        dec: Angle.Degrees(-08.80708000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29939"},
        {"Hipparcos Number", "HIP 21908"},
        {"Smithsonian Astrophysical Observation", "SAO 131423"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.66708473),
        dec: Angle.Degrees(-08.80559828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43251"},
        {"Hipparcos Number", "HIP 29657"},
        {"Celescope Catalog", "CEL 1141"},
        {"Geneva Identification System", "GEN# +1.00043251"},
        {"Smithsonian Astrophysical Observation", "SAO 133015"},
    },
    visualMagnitude: 7.22,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.72786507),
        dec: Angle.Degrees(-08.80422405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210278"},
        {"Hipparcos Number", "HIP 109380"},
        {"Fundamental Katalog 5th Edition", "FK5 5957"},
        {"Smithsonian Astrophysical Observation", "SAO 145907"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.37704552),
        dec: Angle.Degrees(-08.80054527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26576",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26576"},
        {"Smithsonian Astrophysical Observation", "SAO 132418"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.75276788),
        dec: Angle.Degrees(-08.79540578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76602",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9728 B"},
        {"Henry Draper", "HD 139460"},
        {"Hipparcos Number", "HIP 76602"},
        {"Geneva Identification System", "GEN# +1.00139460"},
        {"Smithsonian Astrophysical Observation", "SAO 140671"},
        {"Wilson Evans Batten Catalogue", "WEB 13003"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.66644170),
        dec: Angle.Degrees(-08.79465490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21986",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3409 AB"},
        {"Hipparcos Number", "HIP 21986"},
        {"Geneva Identification System", "GEN# +1.00030021J"},
    },
    visualMagnitude: 5.98,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.89469925),
        dec: Angle.Degrees(-08.79424587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198240"},
        {"Hipparcos Number", "HIP 102777"},
        {"Smithsonian Astrophysical Observation", "SAO 144840"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.33089447),
        dec: Angle.Degrees(-08.79400877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140895"},
        {"Hipparcos Number", "HIP 77262"},
        {"Smithsonian Astrophysical Observation", "SAO 140744"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.61477214),
        dec: Angle.Degrees(-08.79216177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -149.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76603",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9728 A"},
        {"Henry Draper", "HD 139461"},
        {"Hipparcos Number", "HIP 76603"},
        {"Geneva Identification System", "GEN# +1.00139461A"},
        {"Smithsonian Astrophysical Observation", "SAO 140672"},
        {"Wilson Evans Batten Catalogue", "WEB 13004"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.66696618),
        dec: Angle.Degrees(-08.79142377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204198"},
        {"Hipparcos Number", "HIP 105931"},
        {"Geneva Identification System", "GEN# +1.00204198"},
        {"Smithsonian Astrophysical Observation", "SAO 145406"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.81622406),
        dec: Angle.Degrees(-08.78951013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145961"},
        {"Hipparcos Number", "HIP 79558"},
        {"Geneva Identification System", "GEN# +1.00145961"},
        {"Smithsonian Astrophysical Observation", "SAO 141045"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.50963522),
        dec: Angle.Degrees(-08.78950725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78732"},
        {"Hipparcos Number", "HIP 44961"},
        {"Geneva Identification System", "GEN# +1.00078732"},
        {"Smithsonian Astrophysical Observation", "SAO 136622"},
        {"Wilson Evans Batten Catalogue", "WEB 8588"},
    },
    visualMagnitude: 5.47,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.39824927),
        dec: Angle.Degrees(-08.78763061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116682"},
        {"Hipparcos Number", "HIP 65480"},
        {"Smithsonian Astrophysical Observation", "SAO 139330"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.31178980),
        dec: Angle.Degrees(-08.78585311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117269"},
        {"Hipparcos Number", "HIP 65807"},
        {"Smithsonian Astrophysical Observation", "SAO 139361"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.33779218),
        dec: Angle.Degrees(-08.78551596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57078"},
        {"Hipparcos Number", "HIP 35475"},
        {"Geneva Identification System", "GEN# +1.00057078"},
        {"Smithsonian Astrophysical Observation", "SAO 134510"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.84216952),
        dec: Angle.Degrees(-08.78311475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9111"},
        {"Hipparcos Number", "HIP 6964"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.41631012),
        dec: Angle.Degrees(-08.78293757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47364"},
        {"Hipparcos Number", "HIP 31693"},
        {"Smithsonian Astrophysical Observation", "SAO 133500"},
        {"Wilson Evans Batten Catalogue", "WEB 6358"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.46345150),
        dec: Angle.Degrees(-08.78168115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83772"},
        {"Hipparcos Number", "HIP 47459"},
        {"Fundamental Katalog 5th Edition", "FK5 4858"},
        {"Smithsonian Astrophysical Observation", "SAO 137047"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.12733691),
        dec: Angle.Degrees(-08.78152327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200620"},
        {"Hipparcos Number", "HIP 104046"},
        {"Geneva Identification System", "GEN# +1.00200620"},
        {"Smithsonian Astrophysical Observation", "SAO 145074"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.18745109),
        dec: Angle.Degrees(-08.77944530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143858"},
        {"Hipparcos Number", "HIP 78633"},
        {"Geneva Identification System", "GEN# +1.00143858"},
        {"Smithsonian Astrophysical Observation", "SAO 140920"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.79033414),
        dec: Angle.Degrees(-08.77908714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87062",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87062"},
        {"Cincinnati Publication", "Ci 20 1064"},
        {"Geneva Identification System", "GEN# +9.80020015"},
        {"Geneva Identification System 2", "GEN# -0.00804501"},
        {"Wilson Evans Batten Catalogue", "WEB 14687"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.86594052),
        dec: Angle.Degrees(-08.77904096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 242.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -364.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166161"},
        {"Hipparcos Number", "HIP 88977"},
        {"Geneva Identification System", "GEN# +1.00166161"},
        {"Smithsonian Astrophysical Observation", "SAO 142126"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.41976206),
        dec: Angle.Degrees(-08.77887176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -191.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86838",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86838"},
        {"Smithsonian Astrophysical Observation", "SAO 141846"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.15454688),
        dec: Angle.Degrees(-08.77464142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144391"},
        {"Hipparcos Number", "HIP 78874"},
        {"Geneva Identification System", "GEN# +1.00144391"},
        {"Smithsonian Astrophysical Observation", "SAO 140946"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.50501407),
        dec: Angle.Degrees(-08.77042083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20290"},
        {"Hipparcos Number", "HIP 15173"},
        {"Smithsonian Astrophysical Observation", "SAO 130386"},
        {"Wilson Evans Batten Catalogue", "WEB 2920"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.88229967),
        dec: Angle.Degrees(-08.77006541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194233"},
        {"Hipparcos Number", "HIP 100680"},
        {"Smithsonian Astrophysical Observation", "SAO 144392"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.18542330),
        dec: Angle.Degrees(-08.76943998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22321"},
        {"Hipparcos Number", "HIP 16734"},
        {"Smithsonian Astrophysical Observation", "SAO 130591"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.82147497),
        dec: Angle.Degrees(-08.76821895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135184"},
        {"Hipparcos Number", "HIP 74560"},
        {"Geneva Identification System", "GEN# +1.00135184"},
        {"Smithsonian Astrophysical Observation", "SAO 140393"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.51786414),
        dec: Angle.Degrees(-08.76678970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221890"},
        {"Hipparcos Number", "HIP 116470"},
        {"Geneva Identification System", "GEN# +1.00221890"},
        {"Smithsonian Astrophysical Observation", "SAO 146799"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.00111910),
        dec: Angle.Degrees(-08.76607901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211935"},
        {"Hipparcos Number", "HIP 110338"},
        {"Smithsonian Astrophysical Observation", "SAO 146032"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.21393515),
        dec: Angle.Degrees(-08.76547449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43723",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7080 AB"},
        {"Hipparcos Number", "HIP 43723"},
        {"Smithsonian Astrophysical Observation", "SAO 136388"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.56175248),
        dec: Angle.Degrees(-08.76085630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32187",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32187"},
        {"Geneva Identification System", "GEN# +6.10180568"},
        {"Wilson Evans Batten Catalogue", "WEB 6494"},
    },
    visualMagnitude: 9.91,
    bvColour: 3.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.80199627),
        dec: Angle.Degrees(-08.75838845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82506"},
        {"Hipparcos Number", "HIP 46801"},
        {"Smithsonian Astrophysical Observation", "SAO 136936"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.05092814),
        dec: Angle.Degrees(-08.75818093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45380",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7258 A"},
        {"Henry Draper", "HD 79597"},
        {"Hipparcos Number", "HIP 45380"},
        {"Smithsonian Astrophysical Observation", "SAO 136690"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.72107884),
        dec: Angle.Degrees(-08.75792187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150733"},
        {"Hipparcos Number", "HIP 81865"},
        {"Smithsonian Astrophysical Observation", "SAO 141327"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.81292463),
        dec: Angle.Degrees(-08.75701293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126847"},
        {"Hipparcos Number", "HIP 70752"},
        {"Fundamental Katalog 5th Edition", "FK5 5280"},
        {"Smithsonian Astrophysical Observation", "SAO 139949"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.04209247),
        dec: Angle.Degrees(-08.75695767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181910"},
        {"Hipparcos Number", "HIP 95240"},
        {"Smithsonian Astrophysical Observation", "SAO 143327"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.65779891),
        dec: Angle.Degrees(-08.75534941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113286",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113286"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.10342155),
        dec: Angle.Degrees(-08.75476724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33328"},
        {"Hipparcos Number", "HIP 23972"},
        {"Celescope Catalog", "CEL 549"},
        {"Fundamental Katalog 5th Edition", "FK5 190"},
        {"Geneva Identification System", "GEN# +1.00033328"},
        {"Smithsonian Astrophysical Observation", "SAO 131824"},
        {"Wilson Evans Batten Catalogue", "WEB 4673"},
    },
    visualMagnitude: 4.25,
    bvColour: -0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.28659571),
        dec: Angle.Degrees(-08.75407607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11535",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1890 AB"},
        {"Henry Draper", "HD 15423"},
        {"Hipparcos Number", "HIP 11535"},
        {"Smithsonian Astrophysical Observation", "SAO 129931"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.778,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.18097979),
        dec: Angle.Degrees(-08.75309420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25545"},
        {"Hipparcos Number", "HIP 18896"},
        {"Geneva Identification System", "GEN# +1.00025545"},
        {"Smithsonian Astrophysical Observation", "SAO 130898"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.76213491),
        dec: Angle.Degrees(-08.75306049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20598",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3197 AB"},
        {"Henry Draper", "HD 27983"},
        {"Hipparcos Number", "HIP 20598"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.17504169),
        dec: Angle.Degrees(-08.75291541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143178"},
        {"Hipparcos Number", "HIP 78298"},
        {"Geneva Identification System", "GEN# +1.00143178"},
        {"Smithsonian Astrophysical Observation", "SAO 140878"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.81617480),
        dec: Angle.Degrees(-08.75260488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45381",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7258 B"},
        {"Hipparcos Number", "HIP 45381"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.72301625),
        dec: Angle.Degrees(-08.75081956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137845"},
        {"Hipparcos Number", "HIP 75763"},
        {"Smithsonian Astrophysical Observation", "SAO 140559"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.16126861),
        dec: Angle.Degrees(-08.74729618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212112"},
        {"Hipparcos Number", "HIP 110427"},
        {"Smithsonian Astrophysical Observation", "SAO 146047"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.50922228),
        dec: Angle.Degrees(-08.74710802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 176.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40189"},
        {"Hipparcos Number", "HIP 28155"},
        {"Geneva Identification System", "GEN# +1.00040189"},
        {"Smithsonian Astrophysical Observation", "SAO 132684"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.23548034),
        dec: Angle.Degrees(-08.74699750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79931"},
        {"Hipparcos Number", "HIP 45526"},
        {"Geneva Identification System", "GEN# +1.00079931"},
        {"Smithsonian Astrophysical Observation", "SAO 136728"},
        {"Wilson Evans Batten Catalogue", "WEB 8656"},
    },
    visualMagnitude: 5.49,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.17240336),
        dec: Angle.Degrees(-08.74475953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109801",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109801"},
        {"Cincinnati Publication", "Ci 20 1348"},
        {"Geneva Identification System", "GEN# +6.10141332"},
        {"Wilson Evans Batten Catalogue", "WEB 19722"},
    },
    visualMagnitude: 11.95,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.60023640),
        dec: Angle.Degrees(-08.74359829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -568.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204834"},
        {"Hipparcos Number", "HIP 106268"},
        {"Smithsonian Astrophysical Observation", "SAO 145452"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.86648698),
        dec: Angle.Degrees(-08.74297041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139898"},
        {"Hipparcos Number", "HIP 76813"},
        {"Geneva Identification System", "GEN# +1.00139898"},
        {"Smithsonian Astrophysical Observation", "SAO 140697"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.25136356),
        dec: Angle.Degrees(-08.74192412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147431"},
        {"Hipparcos Number", "HIP 80193"},
        {"Fundamental Katalog 5th Edition", "FK5 5442"},
        {"Smithsonian Astrophysical Observation", "SAO 141122"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.57251735),
        dec: Angle.Degrees(-08.74161023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5268"},
        {"Hipparcos Number", "HIP 4257"},
        {"Geneva Identification System", "GEN# +1.00005268"},
        {"Smithsonian Astrophysical Observation", "SAO 129019"},
        {"Wilson Evans Batten Catalogue", "WEB 762"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.57326200),
        dec: Angle.Degrees(-08.74054656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88868"},
        {"Hipparcos Number", "HIP 50202"},
        {"Smithsonian Astrophysical Observation", "SAO 137439"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.73620031),
        dec: Angle.Degrees(-08.74051518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13347"},
        {"Hipparcos Number", "HIP 10126"},
        {"Smithsonian Astrophysical Observation", "SAO 129727"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.56406023),
        dec: Angle.Degrees(-08.74013551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59806"},
        {"Hipparcos Number", "HIP 36574"},
        {"Smithsonian Astrophysical Observation", "SAO 134785"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.84998504),
        dec: Angle.Degrees(-08.74004975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112742"},
        {"Hipparcos Number", "HIP 63362"},
        {"Smithsonian Astrophysical Observation", "SAO 139078"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.74829605),
        dec: Angle.Degrees(-08.73881012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73399"},
        {"Hipparcos Number", "HIP 42345"},
        {"Geneva Identification System", "GEN# +1.00073399"},
        {"Smithsonian Astrophysical Observation", "SAO 136113"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.49617347),
        dec: Angle.Degrees(-08.73511987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10945",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10945"},
        {"Smithsonian Astrophysical Observation", "SAO 129844"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.24915061),
        dec: Angle.Degrees(-08.73496393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115503"},
        {"Hipparcos Number", "HIP 64865"},
        {"Fundamental Katalog 5th Edition", "FK5 5172"},
        {"Geneva Identification System", "GEN# +1.00115503"},
        {"Smithsonian Astrophysical Observation", "SAO 139268"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.43373573),
        dec: Angle.Degrees(-08.73314448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166664"},
        {"Hipparcos Number", "HIP 89181"},
        {"Geneva Identification System", "GEN# +1.00166664"},
        {"Smithsonian Astrophysical Observation", "SAO 142147"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.00574571),
        dec: Angle.Degrees(-08.73091738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109142",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109142"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.62471311),
        dec: Angle.Degrees(-08.73063782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42881"},
        {"Hipparcos Number", "HIP 29497"},
        {"Geneva Identification System", "GEN# +1.00042881"},
        {"Smithsonian Astrophysical Observation", "SAO 132972"},
    },
    visualMagnitude: 6.91,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.23127306),
        dec: Angle.Degrees(-08.72904344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206419"},
        {"Hipparcos Number", "HIP 107148"},
        {"Smithsonian Astrophysical Observation", "SAO 145597"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.54869154),
        dec: Angle.Degrees(-08.72847653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92753"},
        {"Hipparcos Number", "HIP 52385"},
        {"Smithsonian Astrophysical Observation", "SAO 137739"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.61366238),
        dec: Angle.Degrees(-08.72719674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63088",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63088"},
        {"Geneva Identification System", "GEN# -0.00703509"},
        {"Smithsonian Astrophysical Observation", "SAO 139042"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.89495540),
        dec: Angle.Degrees(-08.72412133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88098"},
        {"Hipparcos Number", "HIP 49752"},
        {"Smithsonian Astrophysical Observation", "SAO 137377"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.34505522),
        dec: Angle.Degrees(-08.72096299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41348"},
        {"Hipparcos Number", "HIP 28740"},
        {"Smithsonian Astrophysical Observation", "SAO 132794"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.04879976),
        dec: Angle.Degrees(-08.71912167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94521",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12188 A"},
        {"Henry Draper", "HD 179799"},
        {"Hipparcos Number", "HIP 94521"},
        {"Smithsonian Astrophysical Observation", "SAO 143163"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.56664106),
        dec: Angle.Degrees(-08.71902793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172488"},
        {"Hipparcos Number", "HIP 91599"},
        {"Geneva Identification System", "GEN# +1.00172488"},
        {"Smithsonian Astrophysical Observation", "SAO 142489"},
        {"Wilson Evans Batten Catalogue", "WEB 15749"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.20023930),
        dec: Angle.Degrees(-08.71874716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143177"},
        {"Hipparcos Number", "HIP 78296"},
        {"Geneva Identification System", "GEN# +1.00143177"},
        {"Smithsonian Astrophysical Observation", "SAO 140877"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.81183252),
        dec: Angle.Degrees(-08.71851564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -137.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209560"},
        {"Hipparcos Number", "HIP 108964"},
        {"Geneva Identification System", "GEN# +1.00209560"},
        {"Smithsonian Astrophysical Observation", "SAO 145849"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.13118311),
        dec: Angle.Degrees(-08.71718575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 805"},
        {"Hipparcos Number", "HIP 993"},
        {"Smithsonian Astrophysical Observation", "SAO 128638"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.09223756),
        dec: Angle.Degrees(-08.70977153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89721"},
        {"Hipparcos Number", "HIP 50698"},
        {"Geneva Identification System", "GEN# +1.00089721"},
        {"Smithsonian Astrophysical Observation", "SAO 137511"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.28939913),
        dec: Angle.Degrees(-08.70959040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33791",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33791"},
        {"Wilson Evans Batten Catalogue", "WEB 6784"},
    },
    visualMagnitude: 10.38,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.24925656),
        dec: Angle.Degrees(-08.70899771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111910"},
        {"Hipparcos Number", "HIP 62844"},
        {"Smithsonian Astrophysical Observation", "SAO 139014"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.18959410),
        dec: Angle.Degrees(-08.70886854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162883"},
        {"Hipparcos Number", "HIP 87590"},
        {"Geneva Identification System", "GEN# +1.00162883"},
        {"Smithsonian Astrophysical Observation", "SAO 141946"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.39524541),
        dec: Angle.Degrees(-08.70836010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19999"},
        {"Hipparcos Number", "HIP 14935"},
        {"Smithsonian Astrophysical Observation", "SAO 130351"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.14604924),
        dec: Angle.Degrees(-08.70533129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94540"},
        {"Hipparcos Number", "HIP 53348"},
        {"Smithsonian Astrophysical Observation", "SAO 137877"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.65664846),
        dec: Angle.Degrees(-08.70434058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111116",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111116"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.65172884),
        dec: Angle.Degrees(-08.70407925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119149"},
        {"Hipparcos Number", "HIP 66803"},
        {"Fundamental Katalog 5th Edition", "FK5 1355"},
        {"Geneva Identification System", "GEN# +1.00119149"},
        {"Smithsonian Astrophysical Observation", "SAO 139490"},
        {"Wilson Evans Batten Catalogue", "WEB 11778"},
    },
    visualMagnitude: 5.03,
    bvColour: 1.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.40346122),
        dec: Angle.Degrees(-08.70308218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15871"},
        {"Hipparcos Number", "HIP 11846"},
        {"Smithsonian Astrophysical Observation", "SAO 129969"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.23062539),
        dec: Angle.Degrees(-08.70030661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116210"},
        {"Hipparcos Number", "HIP 65250"},
        {"Smithsonian Astrophysical Observation", "SAO 139301"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.57818499),
        dec: Angle.Degrees(-08.69960006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50581",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50581"},
        {"Geneva Identification System", "GEN# -0.00703007"},
        {"Wilson Evans Batten Catalogue", "WEB 9278"},
    },
    visualMagnitude: 10.74,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.98597381),
        dec: Angle.Degrees(-08.69887848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6605"},
        {"Hipparcos Number", "HIP 5217"},
        {"Smithsonian Astrophysical Observation", "SAO 129122"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.67829110),
        dec: Angle.Degrees(-08.69714425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205803"},
        {"Hipparcos Number", "HIP 106800"},
        {"Smithsonian Astrophysical Observation", "SAO 145541"},
    },
    visualMagnitude: 8.45,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.47806177),
        dec: Angle.Degrees(-08.69629008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131271"},
        {"Hipparcos Number", "HIP 72808"},
        {"Geneva Identification System", "GEN# +1.00131271"},
        {"Smithsonian Astrophysical Observation", "SAO 140196"},
        {"Wilson Evans Batten Catalogue", "WEB 12508"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.22351794),
        dec: Angle.Degrees(-08.69569712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79286"},
        {"Hipparcos Number", "HIP 45226"},
        {"Smithsonian Astrophysical Observation", "SAO 136669"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.25030793),
        dec: Angle.Degrees(-08.69556585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73255",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9452 AB"},
        {"Henry Draper", "HD 132229"},
        {"Hipparcos Number", "HIP 73255"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.57273120),
        dec: Angle.Degrees(-08.69453785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29152"},
        {"Hipparcos Number", "HIP 21370"},
        {"Smithsonian Astrophysical Observation", "SAO 131333"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.77848286),
        dec: Angle.Degrees(-08.69345902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180293"},
        {"Hipparcos Number", "HIP 94708"},
        {"Fundamental Katalog 5th Edition", "FK5 5695"},
        {"Smithsonian Astrophysical Observation", "SAO 143200"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.06940285),
        dec: Angle.Degrees(-08.69006863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125549"},
        {"Hipparcos Number", "HIP 70060"},
        {"Smithsonian Astrophysical Observation", "SAO 139874"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.06206643),
        dec: Angle.Degrees(-08.68865716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144068"},
        {"Hipparcos Number", "HIP 78733"},
        {"Geneva Identification System", "GEN# +1.00144068"},
        {"Smithsonian Astrophysical Observation", "SAO 140929"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.09714287),
        dec: Angle.Degrees(-08.68632230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214528"},
        {"Hipparcos Number", "HIP 111820"},
        {"Smithsonian Astrophysical Observation", "SAO 146220"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.73894543),
        dec: Angle.Degrees(-08.68485609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110901"},
        {"Hipparcos Number", "HIP 62255"},
        {"Smithsonian Astrophysical Observation", "SAO 138954"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.36819451),
        dec: Angle.Degrees(-08.68299218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1412",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1412"},
        {"Geneva Identification System", "GEN# -0.00900040"},
    },
    visualMagnitude: 10.99,
    bvColour: 1.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.41968822),
        dec: Angle.Degrees(-08.68231088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 302.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37280",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6256 AB"},
        {"Henry Draper", "HD 61506"},
        {"Hipparcos Number", "HIP 37280"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.82750820),
        dec: Angle.Degrees(-08.68165336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9143",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9143"},
        {"Smithsonian Astrophysical Observation", "SAO 129585"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.45896157),
        dec: Angle.Degrees(-08.68014556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108510"},
        {"Hipparcos Number", "HIP 60816"},
        {"Geneva Identification System", "GEN# +1.00108510"},
        {"Smithsonian Astrophysical Observation", "SAO 138799"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.98176410),
        dec: Angle.Degrees(-08.67790512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -224.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34486",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5826 A"},
        {"Henry Draper", "HD 54542"},
        {"Hipparcos Number", "HIP 34486"},
        {"Geneva Identification System", "GEN# +1.00054542"},
        {"Smithsonian Astrophysical Observation", "SAO 134253"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.20386851),
        dec: Angle.Degrees(-08.67683182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71557",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9326 AB"},
        {"Henry Draper", "HD 128612"},
        {"Hipparcos Number", "HIP 71557"},
        {"Smithsonian Astrophysical Observation", "SAO 140043"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.52757321),
        dec: Angle.Degrees(-08.67535086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160407"},
        {"Hipparcos Number", "HIP 86467"},
        {"Smithsonian Astrophysical Observation", "SAO 141794"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.00418474),
        dec: Angle.Degrees(-08.67491800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220109"},
        {"Hipparcos Number", "HIP 115305"},
        {"Smithsonian Astrophysical Observation", "SAO 146656"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.29998306),
        dec: Angle.Degrees(-08.67417003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34491",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5826 B"},
        {"Henry Draper", "HD 54543"},
        {"Hipparcos Number", "HIP 34491"},
        {"Geneva Identification System", "GEN# +1.00054543"},
        {"Smithsonian Astrophysical Observation", "SAO 134254"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.20698281),
        dec: Angle.Degrees(-08.67369193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62157",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62157"},
    },
    visualMagnitude: 10.50,
    bvColour: -0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.08430370),
        dec: Angle.Degrees(-08.67130778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70422"},
        {"Hipparcos Number", "HIP 40962"},
        {"Smithsonian Astrophysical Observation", "SAO 135814"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.39552955),
        dec: Angle.Degrees(-08.67074992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26237"},
        {"Hipparcos Number", "HIP 19354"},
        {"Geneva Identification System", "GEN# +1.00026237"},
        {"Smithsonian Astrophysical Observation", "SAO 130981"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.19406735),
        dec: Angle.Degrees(-08.67024963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43049"},
        {"Hipparcos Number", "HIP 29562"},
        {"Smithsonian Astrophysical Observation", "SAO 132993"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.42492233),
        dec: Angle.Degrees(-08.66956881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119026"},
        {"Hipparcos Number", "HIP 66757"},
        {"Smithsonian Astrophysical Observation", "SAO 139484"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.24123703),
        dec: Angle.Degrees(-08.66934796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124354"},
        {"Hipparcos Number", "HIP 69463"},
        {"Smithsonian Astrophysical Observation", "SAO 139792"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.32209802),
        dec: Angle.Degrees(-08.66920267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189417"},
        {"Hipparcos Number", "HIP 98464"},
        {"Geneva Identification System", "GEN# +1.00189417"},
        {"Smithsonian Astrophysical Observation", "SAO 143980"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.07325158),
        dec: Angle.Degrees(-08.66881142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97247"},
        {"Hipparcos Number", "HIP 54672"},
        {"Smithsonian Astrophysical Observation", "SAO 138045"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.86728056),
        dec: Angle.Degrees(-08.66631512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35155"},
        {"Hipparcos Number", "HIP 25092"},
        {"Geneva Identification System", "GEN# +1.00035155"},
        {"Smithsonian Astrophysical Observation", "SAO 132035"},
        {"Wilson Evans Batten Catalogue", "WEB 4865"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.57757056),
        dec: Angle.Degrees(-08.66610717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23916",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3722 A"},
        {"Henry Draper", "HD 33224"},
        {"Hipparcos Number", "HIP 23916"},
        {"Celescope Catalog", "CEL 543"},
        {"Geneva Identification System", "GEN# +1.00033224A"},
        {"Smithsonian Astrophysical Observation", "SAO 131806"},
        {"Wilson Evans Batten Catalogue", "WEB 4664"},
    },
    visualMagnitude: 5.80,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.08411634),
        dec: Angle.Degrees(-08.66527389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23493",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3640 AB"},
        {"Henry Draper", "HD 32468"},
        {"Hipparcos Number", "HIP 23493"},
        {"Geneva Identification System", "GEN# +1.00032468"},
        {"Smithsonian Astrophysical Observation", "SAO 131720"},
    },
    visualMagnitude: 6.86,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.75819489),
        dec: Angle.Degrees(-08.66314367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136257"},
        {"Hipparcos Number", "HIP 75038"},
        {"Geneva Identification System", "GEN# +1.00136257"},
        {"Smithsonian Astrophysical Observation", "SAO 140461"},
        {"Wilson Evans Batten Catalogue", "WEB 12799"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.00011285),
        dec: Angle.Degrees(-08.66121818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -201.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89379"},
        {"Hipparcos Number", "HIP 50498"},
        {"Smithsonian Astrophysical Observation", "SAO 137482"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.67633884),
        dec: Angle.Degrees(-08.66005519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10530"},
        {"Hipparcos Number", "HIP 7983"},
        {"Fundamental Katalog 5th Edition", "FK5 4152"},
        {"Geneva Identification System", "GEN# +1.00010530"},
        {"Smithsonian Astrophysical Observation", "SAO 129464"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.63322152),
        dec: Angle.Degrees(-08.65956083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6514"},
        {"Hipparcos Number", "HIP 5154"},
        {"Smithsonian Astrophysical Observation", "SAO 129116"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.49131364),
        dec: Angle.Degrees(-08.65948394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46390",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alphard"},
        {"Henry Draper", "HD 81797"},
        {"Hipparcos Number", "HIP 46390"},
        {"Fundamental Katalog 5th Edition", "FK5 354"},
        {"Geneva Identification System", "GEN# +1.00081797"},
        {"Smithsonian Astrophysical Observation", "SAO 136871"},
        {"Wilson Evans Batten Catalogue", "WEB 8768"},
    },
    visualMagnitude: 1.99,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.89688260),
        dec: Angle.Degrees(-08.65868335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2361"},
        {"Hipparcos Number", "HIP 2167"},
        {"Geneva Identification System", "GEN# +1.00002361"},
        {"Smithsonian Astrophysical Observation", "SAO 128769"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.83584766),
        dec: Angle.Degrees(-08.65842297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10654"},
        {"Hipparcos Number", "HIP 8089"},
        {"Geneva Identification System", "GEN# +1.00010654"},
        {"Smithsonian Astrophysical Observation", "SAO 129475"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.96555568),
        dec: Angle.Degrees(-08.65768556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70958",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70958"},
    },
    visualMagnitude: 12.43,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)30, 50.1900),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)39, 27.600)
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
    primaryId: "HIP 75171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136566"},
        {"Hipparcos Number", "HIP 75171"},
        {"Geneva Identification System", "GEN# +1.00136566"},
        {"Smithsonian Astrophysical Observation", "SAO 140483"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.41676409),
        dec: Angle.Degrees(-08.65656842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31111"},
        {"Hipparcos Number", "HIP 22693"},
        {"Smithsonian Astrophysical Observation", "SAO 131567"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.19314908),
        dec: Angle.Degrees(-08.65572247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11627"},
        {"Hipparcos Number", "HIP 8861"},
        {"Smithsonian Astrophysical Observation", "SAO 129557"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.49587881),
        dec: Angle.Degrees(-08.65423954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33069"},
        {"Hipparcos Number", "HIP 23834"},
        {"Celescope Catalog", "CEL 537"},
        {"Geneva Identification System", "GEN# +1.00033069"},
        {"Smithsonian Astrophysical Observation", "SAO 131791"},
    },
    visualMagnitude: 7.00,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.85947896),
        dec: Angle.Degrees(-08.65316228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34702"},
        {"Hipparcos Number", "HIP 24804"},
        {"Smithsonian Astrophysical Observation", "SAO 131978"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.76687717),
        dec: Angle.Degrees(-08.65305367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198273"},
        {"Hipparcos Number", "HIP 102793"},
        {"Cincinnati Publication", "Ci 18 2692"},
        {"Geneva Identification System", "GEN# +1.00198273"},
        {"Smithsonian Astrophysical Observation", "SAO 144844"},
        {"Wilson Evans Batten Catalogue", "WEB 18641"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.37345487),
        dec: Angle.Degrees(-08.65213589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -344.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34524"},
        {"Hipparcos Number", "HIP 24692"},
        {"Smithsonian Astrophysical Observation", "SAO 131955"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.43791121),
        dec: Angle.Degrees(-08.65164034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177399"},
        {"Hipparcos Number", "HIP 93702"},
        {"Smithsonian Astrophysical Observation", "SAO 142991"},
        {"Wilson Evans Batten Catalogue", "WEB 16280"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.20767531),
        dec: Angle.Degrees(-08.65117465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41969"},
        {"Hipparcos Number", "HIP 29049"},
        {"Smithsonian Astrophysical Observation", "SAO 132862"},
    },
    visualMagnitude: 8.35,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.92645810),
        dec: Angle.Degrees(-08.65063886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61224",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61224"},
    },
    visualMagnitude: 10.12,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.18824482),
        dec: Angle.Degrees(-08.64894027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -168.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142596"},
        {"Hipparcos Number", "HIP 78003"},
        {"Geneva Identification System", "GEN# +1.00142596"},
        {"Smithsonian Astrophysical Observation", "SAO 140838"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.92613495),
        dec: Angle.Degrees(-08.64749707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127339"},
        {"Hipparcos Number", "HIP 70956"},
        {"Cincinnati Publication", "Ci 20 864"},
        {"Geneva Identification System", "GEN# +1.00127339"},
        {"Smithsonian Astrophysical Observation", "SAO 139977"},
        {"Wilson Evans Batten Catalogue", "WEB 12282"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.70194441),
        dec: Angle.Degrees(-08.64575059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1269.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -241.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26246",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4170 AB"},
        {"Henry Draper", "HD 37079"},
        {"Hipparcos Number", "HIP 26246"},
        {"Smithsonian Astrophysical Observation", "SAO 132327"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.86151332),
        dec: Angle.Degrees(-08.64558763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140030"},
        {"Hipparcos Number", "HIP 76868"},
        {"Geneva Identification System", "GEN# +1.00140030"},
        {"Smithsonian Astrophysical Observation", "SAO 140703"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.44826288),
        dec: Angle.Degrees(-08.64555564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218236"},
        {"Hipparcos Number", "HIP 114102"},
        {"Smithsonian Astrophysical Observation", "SAO 146512"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.64167457),
        dec: Angle.Degrees(-08.64544596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32099"},
        {"Hipparcos Number", "HIP 23262"},
        {"Geneva Identification System", "GEN# +1.00032099"},
        {"Renson", "Renson 8182"},
        {"Smithsonian Astrophysical Observation", "SAO 131680"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.08024219),
        dec: Angle.Degrees(-08.64309065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51026"},
        {"Hipparcos Number", "HIP 33278"},
        {"Smithsonian Astrophysical Observation", "SAO 133900"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.83220958),
        dec: Angle.Degrees(-08.64200351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74915"},
        {"Hipparcos Number", "HIP 43089"},
        {"Smithsonian Astrophysical Observation", "SAO 136268"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.64756731),
        dec: Angle.Degrees(-08.64089573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112944"},
        {"Hipparcos Number", "HIP 63474"},
        {"Smithsonian Astrophysical Observation", "SAO 139092"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.09962083),
        dec: Angle.Degrees(-08.63985416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75422"},
        {"Hipparcos Number", "HIP 43330"},
        {"Geneva Identification System", "GEN# +1.00075422"},
        {"Smithsonian Astrophysical Observation", "SAO 136316"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.41876851),
        dec: Angle.Degrees(-08.63799420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196960"},
        {"Hipparcos Number", "HIP 102055"},
        {"Smithsonian Astrophysical Observation", "SAO 144689"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.22793205),
        dec: Angle.Degrees(-08.63792467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41013"},
        {"Hipparcos Number", "HIP 28598"},
        {"Smithsonian Astrophysical Observation", "SAO 132765"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.54075666),
        dec: Angle.Degrees(-08.63779393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26993"},
        {"Hipparcos Number", "HIP 19871"},
        {"Smithsonian Astrophysical Observation", "SAO 131071"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.92936497),
        dec: Angle.Degrees(-08.63701822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186497"},
        {"Hipparcos Number", "HIP 97173"},
        {"Geneva Identification System", "GEN# +1.00186497"},
        {"Smithsonian Astrophysical Observation", "SAO 143753"},
        {"Wilson Evans Batten Catalogue", "WEB 17059"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.26165081),
        dec: Angle.Degrees(-08.63580229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168014"},
        {"Hipparcos Number", "HIP 89686"},
        {"Smithsonian Astrophysical Observation", "SAO 142203"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.53533217),
        dec: Angle.Degrees(-08.63365590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109555"},
        {"Hipparcos Number", "HIP 61456"},
        {"Smithsonian Astrophysical Observation", "SAO 138862"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.91181186),
        dec: Angle.Degrees(-08.63115547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185862"},
        {"Hipparcos Number", "HIP 96883"},
        {"Smithsonian Astrophysical Observation", "SAO 143699"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.40597307),
        dec: Angle.Degrees(-08.62895122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57570",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8310 A"},
        {"Henry Draper", "HD 102524"},
        {"Hipparcos Number", "HIP 57570"},
        {"Smithsonian Astrophysical Observation", "SAO 138414"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.00115525),
        dec: Angle.Degrees(-08.62759845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222157"},
        {"Hipparcos Number", "HIP 116639"},
        {"Geneva Identification System", "GEN# +1.00222157"},
        {"Smithsonian Astrophysical Observation", "SAO 146815"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.55160148),
        dec: Angle.Degrees(-08.62750970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43288"},
        {"Hipparcos Number", "HIP 29672"},
        {"Geneva Identification System", "GEN# +1.00043288"},
        {"Smithsonian Astrophysical Observation", "SAO 133019"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.76642444),
        dec: Angle.Degrees(-08.62716948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78731"},
        {"Hipparcos Number", "HIP 44963"},
        {"Smithsonian Astrophysical Observation", "SAO 136623"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.40047795),
        dec: Angle.Degrees(-08.62670847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57566",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8310 B"},
        {"Hipparcos Number", "HIP 57566"},
        {"Smithsonian Astrophysical Observation", "SAO 138413"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.99855266),
        dec: Angle.Degrees(-08.62598186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18531"},
        {"Hipparcos Number", "HIP 13861"},
        {"Smithsonian Astrophysical Observation", "SAO 130212"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.61363777),
        dec: Angle.Degrees(-08.62590920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135794"},
        {"Hipparcos Number", "HIP 74805"},
        {"Geneva Identification System", "GEN# +1.00135794"},
        {"Smithsonian Astrophysical Observation", "SAO 140432"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.31912062),
        dec: Angle.Degrees(-08.62528088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67967",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67967"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.77935536),
        dec: Angle.Degrees(-08.62267109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106481"},
        {"Hipparcos Number", "HIP 59725"},
        {"Geneva Identification System", "GEN# +1.00106481"},
        {"Smithsonian Astrophysical Observation", "SAO 138669"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.73730928),
        dec: Angle.Degrees(-08.62242731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40043"},
        {"Hipparcos Number", "HIP 28063"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.00003309),
        dec: Angle.Degrees(-08.62217842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153292"},
        {"Hipparcos Number", "HIP 83103"},
        {"Smithsonian Astrophysical Observation", "SAO 141464"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.72729433),
        dec: Angle.Degrees(-08.62026026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74525",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74525"},
        {"Geneva Identification System", "GEN# -0.00803922"},
        {"Smithsonian Astrophysical Observation", "SAO 140388"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.43646011),
        dec: Angle.Degrees(-08.61965430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36286"},
        {"Hipparcos Number", "HIP 25772"},
        {"Geneva Identification System", "GEN# +1.00036286"},
        {"Smithsonian Astrophysical Observation", "SAO 132188"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.55163095),
        dec: Angle.Degrees(-08.61920213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150052"},
        {"Hipparcos Number", "HIP 81499"},
        {"Smithsonian Astrophysical Observation", "SAO 141291"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.806,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.69885606),
        dec: Angle.Degrees(-08.61858536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75409"},
        {"Hipparcos Number", "HIP 43322"},
        {"Geneva Identification System", "GEN# +1.00075409"},
        {"Smithsonian Astrophysical Observation", "SAO 136313"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.39816184),
        dec: Angle.Degrees(-08.61505579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109084"},
        {"Hipparcos Number", "HIP 61165"},
        {"Smithsonian Astrophysical Observation", "SAO 138835"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.00595190),
        dec: Angle.Degrees(-08.61174656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213897"},
        {"Hipparcos Number", "HIP 111451"},
        {"Smithsonian Astrophysical Observation", "SAO 146169"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.67442081),
        dec: Angle.Degrees(-08.61001280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194978"},
        {"Hipparcos Number", "HIP 101024"},
        {"Smithsonian Astrophysical Observation", "SAO 144477"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.21239432),
        dec: Angle.Degrees(-08.60996017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14923"},
        {"Hipparcos Number", "HIP 11207"},
        {"Geneva Identification System", "GEN# +1.00014923"},
        {"Smithsonian Astrophysical Observation", "SAO 129878"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.07158143),
        dec: Angle.Degrees(-08.60920997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31371",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5216 AB"},
        {"Henry Draper", "HD 46738"},
        {"Hipparcos Number", "HIP 31371"},
        {"Celescope Catalog", "CEL 1306"},
        {"Geneva Identification System", "GEN# +1.00046738J"},
        {"Smithsonian Astrophysical Observation", "SAO 133430"},
        {"Wilson Evans Batten Catalogue", "WEB 6279"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.66940611),
        dec: Angle.Degrees(-08.60811424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12998"},
        {"Hipparcos Number", "HIP 9875"},
        {"Fundamental Katalog 5th Edition", "FK5 4192"},
        {"Geneva Identification System", "GEN# +1.00012998"},
        {"Smithsonian Astrophysical Observation", "SAO 129701"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.76045573),
        dec: Angle.Degrees(-08.60630763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151961"},
        {"Hipparcos Number", "HIP 82448"},
        {"Smithsonian Astrophysical Observation", "SAO 141399"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.73995049),
        dec: Angle.Degrees(-08.60496063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21995"},
        {"Hipparcos Number", "HIP 16494"},
        {"Geneva Identification System", "GEN# +1.00021995"},
        {"Smithsonian Astrophysical Observation", "SAO 130557"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.09949359),
        dec: Angle.Degrees(-08.60314735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -237.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187438"},
        {"Hipparcos Number", "HIP 97600"},
        {"Smithsonian Astrophysical Observation", "SAO 143831"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.56447602),
        dec: Angle.Degrees(-08.60173668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204605"},
        {"Hipparcos Number", "HIP 106142"},
        {"Smithsonian Astrophysical Observation", "SAO 145437"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.49271503),
        dec: Angle.Degrees(-08.60147315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11791"},
        {"Hipparcos Number", "HIP 8969"},
        {"Smithsonian Astrophysical Observation", "SAO 129568"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.88470382),
        dec: Angle.Degrees(-08.60120014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145747"},
        {"Hipparcos Number", "HIP 79460"},
        {"Geneva Identification System", "GEN# +1.00145747"},
        {"Smithsonian Astrophysical Observation", "SAO 141029"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.22868442),
        dec: Angle.Degrees(-08.60107517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96532"},
        {"Hipparcos Number", "HIP 54361"},
        {"Smithsonian Astrophysical Observation", "SAO 137993"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.82166076),
        dec: Angle.Degrees(-08.60060742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20621"},
        {"Hipparcos Number", "HIP 15426"},
        {"Smithsonian Astrophysical Observation", "SAO 130413"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.70722662),
        dec: Angle.Degrees(-08.59678495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39264",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6526 AB"},
        {"Henry Draper", "HD 66094"},
        {"Henry Draper 2", "HD 66095"},
        {"Hipparcos Number", "HIP 39264"},
        {"Smithsonian Astrophysical Observation", "SAO 135392"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.43554787),
        dec: Angle.Degrees(-08.59317239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78556"},
        {"Hipparcos Number", "HIP 44883"},
        {"Fundamental Katalog 5th Edition", "FK5 2725"},
        {"Geneva Identification System", "GEN# +1.00078556"},
        {"Renson", "Renson 22250"},
        {"Smithsonian Astrophysical Observation", "SAO 136604"},
        {"Wilson Evans Batten Catalogue", "WEB 8574"},
    },
    visualMagnitude: 5.60,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.17580020),
        dec: Angle.Degrees(-08.58951324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19350"},
        {"Hipparcos Number", "HIP 14449"},
        {"Geneva Identification System", "GEN# +1.00019350"},
        {"Smithsonian Astrophysical Observation", "SAO 130283"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.61767046),
        dec: Angle.Degrees(-08.58946567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77014"},
        {"Hipparcos Number", "HIP 44151"},
        {"Smithsonian Astrophysical Observation", "SAO 136469"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.87323268),
        dec: Angle.Degrees(-08.58924482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83047"},
        {"Hipparcos Number", "HIP 47073"},
        {"Geneva Identification System", "GEN# +1.00083047"},
        {"Smithsonian Astrophysical Observation", "SAO 136986"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.90554604),
        dec: Angle.Degrees(-08.58876481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144962"},
        {"Hipparcos Number", "HIP 79110"},
        {"Geneva Identification System", "GEN# +1.00144962"},
        {"Smithsonian Astrophysical Observation", "SAO 140985"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.20646309),
        dec: Angle.Degrees(-08.58863621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8819"},
        {"Hipparcos Number", "HIP 6740"},
        {"Fundamental Katalog 5th Edition", "FK5 4135"},
        {"Smithsonian Astrophysical Observation", "SAO 129303"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.69720092),
        dec: Angle.Degrees(-08.58711392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23392"},
        {"Hipparcos Number", "HIP 17462"},
        {"Geneva Identification System", "GEN# +1.00023392"},
        {"Smithsonian Astrophysical Observation", "SAO 130700"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.13632739),
        dec: Angle.Degrees(-08.58679845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44037"},
        {"Hipparcos Number", "HIP 30028"},
        {"Celescope Catalog", "CEL 1173"},
        {"Geneva Identification System", "GEN# +1.00044037"},
        {"Smithsonian Astrophysical Observation", "SAO 133098"},
        {"Wilson Evans Batten Catalogue", "WEB 5963"},
    },
    visualMagnitude: 6.22,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.78309489),
        dec: Angle.Degrees(-08.58601705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208619"},
        {"Hipparcos Number", "HIP 108407"},
        {"Smithsonian Astrophysical Observation", "SAO 145770"},
    },
    visualMagnitude: 8.55,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.42342141),
        dec: Angle.Degrees(-08.58176827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142331"},
        {"Hipparcos Number", "HIP 77883"},
        {"Smithsonian Astrophysical Observation", "SAO 140831"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.58271315),
        dec: Angle.Degrees(-08.58032337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61797",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61797"},
    },
    visualMagnitude: 11.45,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.98328549),
        dec: Angle.Degrees(-08.57799673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -175.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67429"},
        {"Hipparcos Number", "HIP 39761"},
        {"Smithsonian Astrophysical Observation", "SAO 135531"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.90318159),
        dec: Angle.Degrees(-08.57738741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128202"},
        {"Hipparcos Number", "HIP 71379"},
        {"Smithsonian Astrophysical Observation", "SAO 140022"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.95136760),
        dec: Angle.Degrees(-08.57525571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188154"},
        {"Hipparcos Number", "HIP 97928"},
        {"Geneva Identification System", "GEN# +1.00188154A"},
        {"Smithsonian Astrophysical Observation", "SAO 143894"},
        {"Wilson Evans Batten Catalogue", "WEB 17230"},
    },
    visualMagnitude: 5.76,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.53446904),
        dec: Angle.Degrees(-08.57416489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65877"},
        {"Cincinnati Publication", "Ci 20 784"},
        {"Geneva Identification System", "GEN# -0.00703632"},
    },
    visualMagnitude: 12.31,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.55955416),
        dec: Angle.Degrees(-08.57370307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1107.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -475.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15053",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2418 AB"},
        {"Henry Draper", "HD 20152"},
        {"Hipparcos Number", "HIP 15053"},
        {"Smithsonian Astrophysical Observation", "SAO 130369"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.49956223),
        dec: Angle.Degrees(-08.57340036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113565"},
        {"Hipparcos Number", "HIP 63818"},
        {"Smithsonian Astrophysical Observation", "SAO 139140"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.19579953),
        dec: Angle.Degrees(-08.57100078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171128"},
        {"Hipparcos Number", "HIP 90965"},
        {"Geneva Identification System", "GEN# +1.00171128"},
        {"Smithsonian Astrophysical Observation", "SAO 142382"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.33641175),
        dec: Angle.Degrees(-08.56676990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16200"},
        {"Hipparcos Number", "HIP 12092"},
        {"Smithsonian Astrophysical Observation", "SAO 130002"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.96830878),
        dec: Angle.Degrees(-08.56555384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76646",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9732 AB"},
        {"Henry Draper", "HD 139555"},
        {"Hipparcos Number", "HIP 76646"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.77472077),
        dec: Angle.Degrees(-08.56445752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208612"},
        {"Hipparcos Number", "HIP 108402"},
        {"Fundamental Katalog 5th Edition", "FK5 3753"},
        {"Geneva Identification System", "GEN# +1.00208612"},
        {"Smithsonian Astrophysical Observation", "SAO 145768"},
    },
    visualMagnitude: 6.80,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.41395890),
        dec: Angle.Degrees(-08.56433030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74564",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74564"},
        {"Smithsonian Astrophysical Observation", "SAO 140397"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.52979133),
        dec: Angle.Degrees(-08.56292076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90600",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90600"},
        {"Geneva Identification System", "GEN# -0.00804617"},
        {"Smithsonian Astrophysical Observation", "SAO 142343"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.30969630),
        dec: Angle.Degrees(-08.56137221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74123"},
        {"Hipparcos Number", "HIP 42670"},
        {"Smithsonian Astrophysical Observation", "SAO 136188"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.45565867),
        dec: Angle.Degrees(-08.55979919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105621"},
        {"Hipparcos Number", "HIP 59283"},
        {"Smithsonian Astrophysical Observation", "SAO 138614"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.41397696),
        dec: Angle.Degrees(-08.55968428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216288"},
        {"Hipparcos Number", "HIP 112899"},
        {"Smithsonian Astrophysical Observation", "SAO 146359"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.94148757),
        dec: Angle.Degrees(-08.55880197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32755"},
        {"Hipparcos Number", "HIP 23652"},
        {"Geneva Identification System", "GEN# +1.00032755"},
        {"Smithsonian Astrophysical Observation", "SAO 131748"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.24915032),
        dec: Angle.Degrees(-08.55766653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107599"},
        {"Hipparcos Number", "HIP 60315"},
        {"Smithsonian Astrophysical Observation", "SAO 138736"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.51761053),
        dec: Angle.Degrees(-08.55766309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161679"},
        {"Hipparcos Number", "HIP 87050"},
        {"Smithsonian Astrophysical Observation", "SAO 141873"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.79971605),
        dec: Angle.Degrees(-08.55717694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24156",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24156"},
        {"Smithsonian Astrophysical Observation", "SAO 131854"},
        {"Wilson Evans Batten Catalogue", "WEB 4692"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.81040926),
        dec: Angle.Degrees(-08.55678833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73581"},
        {"Hipparcos Number", "HIP 42409"},
        {"Smithsonian Astrophysical Observation", "SAO 136128"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.71155542),
        dec: Angle.Degrees(-08.55637025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57321"},
        {"Hipparcos Number", "HIP 35561"},
        {"Geneva Identification System", "GEN# +1.00057321"},
        {"Smithsonian Astrophysical Observation", "SAO 134531"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.07845539),
        dec: Angle.Degrees(-08.54978925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103891"},
        {"Hipparcos Number", "HIP 58331"},
        {"Geneva Identification System", "GEN# +1.00103891"},
        {"Smithsonian Astrophysical Observation", "SAO 138501"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.43902935),
        dec: Angle.Degrees(-08.54876585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145607"},
        {"Hipparcos Number", "HIP 79387"},
        {"Geneva Identification System", "GEN# +1.00145607"},
        {"Smithsonian Astrophysical Observation", "SAO 141024"},
        {"Wilson Evans Batten Catalogue", "WEB 13423"},
    },
    visualMagnitude: 5.43,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.03037216),
        dec: Angle.Degrees(-08.54757943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65585"},
        {"Hipparcos Number", "HIP 39029"},
        {"Smithsonian Astrophysical Observation", "SAO 135331"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.78203393),
        dec: Angle.Degrees(-08.54663287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51477"},
        {"Hipparcos Number", "HIP 33437"},
        {"Celescope Catalog", "CEL 1449"},
        {"Geneva Identification System", "GEN# +1.00051477"},
        {"Smithsonian Astrophysical Observation", "SAO 133941"},
        {"Wilson Evans Batten Catalogue", "WEB 6722"},
    },
    visualMagnitude: 8.08,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.28949895),
        dec: Angle.Degrees(-08.54196465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21518"},
        {"Hipparcos Number", "HIP 16139"},
        {"Smithsonian Astrophysical Observation", "SAO 130505"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.99187311),
        dec: Angle.Degrees(-08.53844814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78054"},
        {"Hipparcos Number", "HIP 44653"},
        {"Smithsonian Astrophysical Observation", "SAO 136574"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.47238672),
        dec: Angle.Degrees(-08.53592922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68467"},
        {"Hipparcos Number", "HIP 40166"},
        {"Smithsonian Astrophysical Observation", "SAO 135624"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.05249132),
        dec: Angle.Degrees(-08.53585597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91787"},
        {"Hipparcos Number", "HIP 51869"},
        {"Smithsonian Astrophysical Observation", "SAO 137665"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.96411735),
        dec: Angle.Degrees(-08.53443500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76086",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76086"},
        {"Geneva Identification System", "GEN# -0.00803999"},
        {"Wilson Evans Batten Catalogue", "WEB 12929"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.09664497),
        dec: Angle.Degrees(-08.53358307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196467"},
        {"Hipparcos Number", "HIP 101813"},
        {"Smithsonian Astrophysical Observation", "SAO 144638"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.48786389),
        dec: Angle.Degrees(-08.53356312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13750"},
        {"Hipparcos Number", "HIP 10393"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.46772003),
        dec: Angle.Degrees(-08.53264474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110836"},
        {"Hipparcos Number", "HIP 62206"},
        {"Smithsonian Astrophysical Observation", "SAO 138948"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.24859587),
        dec: Angle.Degrees(-08.53199761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137948"},
        {"Hipparcos Number", "HIP 75820"},
        {"Smithsonian Astrophysical Observation", "SAO 140566"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.33160477),
        dec: Angle.Degrees(-08.53087335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221016"},
        {"Hipparcos Number", "HIP 115875"},
        {"Smithsonian Astrophysical Observation", "SAO 146721"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.14308012),
        dec: Angle.Degrees(-08.52864788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209038"},
        {"Hipparcos Number", "HIP 108642"},
        {"Geneva Identification System", "GEN# +1.00209038"},
        {"Smithsonian Astrophysical Observation", "SAO 145800"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.14524666),
        dec: Angle.Degrees(-08.52603688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155105"},
        {"Hipparcos Number", "HIP 83977"},
        {"Fundamental Katalog 5th Edition", "FK5 5514"},
        {"Geneva Identification System", "GEN# +1.00155105"},
        {"Smithsonian Astrophysical Observation", "SAO 141540"},
        {"Wilson Evans Batten Catalogue", "WEB 14187"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.50024852),
        dec: Angle.Degrees(-08.52425887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12292"},
        {"Hipparcos Number", "HIP 9372"},
        {"Geneva Identification System", "GEN# +1.00012292A"},
        {"Smithsonian Astrophysical Observation", "SAO 129624"},
        {"Wilson Evans Batten Catalogue", "WEB 1968"},
    },
    visualMagnitude: 5.43,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.11154942),
        dec: Angle.Degrees(-08.52382616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111818"},
        {"Hipparcos Number", "HIP 62795"},
        {"Smithsonian Astrophysical Observation", "SAO 139005"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.01686979),
        dec: Angle.Degrees(-08.52359007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58812"},
        {"Hipparcos Number", "HIP 36151"},
        {"Smithsonian Astrophysical Observation", "SAO 134678"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.70930382),
        dec: Angle.Degrees(-08.52229380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70938"},
        {"Hipparcos Number", "HIP 41201"},
        {"Smithsonian Astrophysical Observation", "SAO 135876"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.11613498),
        dec: Angle.Degrees(-08.52023712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163844"},
        {"Hipparcos Number", "HIP 88011"},
        {"Geneva Identification System", "GEN# +1.00163844"},
        {"Smithsonian Astrophysical Observation", "SAO 141995"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.66183238),
        dec: Angle.Degrees(-08.51967756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132742"},
        {"Hipparcos Number", "HIP 73473"},
        {"Fundamental Katalog 5th Edition", "FK5 1394"},
        {"Geneva Identification System", "GEN# +1.00132742J"},
        {"Renson", "Renson 37660"},
        {"Smithsonian Astrophysical Observation", "SAO 140270"},
        {"Wilson Evans Batten Catalogue", "WEB 12574"},
    },
    visualMagnitude: 4.91,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.24328191),
        dec: Angle.Degrees(-08.51893488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69541",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9170 AB"},
        {"Henry Draper", "HD 124497"},
        {"Hipparcos Number", "HIP 69541"},
        {"Smithsonian Astrophysical Observation", "SAO 139803"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.53786982),
        dec: Angle.Degrees(-08.51847774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59541"},
        {"Hipparcos Number", "HIP 36456"},
        {"Geneva Identification System", "GEN# +1.00059541"},
        {"Smithsonian Astrophysical Observation", "SAO 134759"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.52090239),
        dec: Angle.Degrees(-08.51798909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71252"},
        {"Hipparcos Number", "HIP 41343"},
        {"Geneva Identification System", "GEN# +1.00071252"},
        {"Smithsonian Astrophysical Observation", "SAO 135908"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.52611709),
        dec: Angle.Degrees(-08.51507505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198990"},
        {"Hipparcos Number", "HIP 103187"},
        {"Smithsonian Astrophysical Observation", "SAO 144921"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.59028996),
        dec: Angle.Degrees(-08.51143435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212757"},
        {"Hipparcos Number", "HIP 110792"},
        {"Fundamental Katalog 5th Edition", "FK5 5979"},
        {"Smithsonian Astrophysical Observation", "SAO 146088"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.69590103),
        dec: Angle.Degrees(-08.51092890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10098"},
        {"Hipparcos Number", "HIP 7657"},
        {"Smithsonian Astrophysical Observation", "SAO 129422"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.65254634),
        dec: Angle.Degrees(-08.50946332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49210",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49210"},
        {"Geneva Identification System", "GEN# +6.00273811"},
    },
    visualMagnitude: 10.95,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.66295171),
        dec: Angle.Degrees(-08.50701413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17012",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2660 AB"},
        {"Henry Draper", "HD 22714"},
        {"Hipparcos Number", "HIP 17012"},
        {"Smithsonian Astrophysical Observation", "SAO 130632"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.70901638),
        dec: Angle.Degrees(-08.50693238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211748"},
        {"Hipparcos Number", "HIP 110208"},
        {"Smithsonian Astrophysical Observation", "SAO 146017"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.85845336),
        dec: Angle.Degrees(-08.50602992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82638"},
        {"Hipparcos Number", "HIP 46869"},
        {"Geneva Identification System", "GEN# +1.00082638"},
        {"Smithsonian Astrophysical Observation", "SAO 136945"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.25832855),
        dec: Angle.Degrees(-08.50528990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8728"},
        {"Hipparcos Number", "HIP 6690"},
        {"Geneva Identification System", "GEN# +1.00008728"},
        {"Smithsonian Astrophysical Observation", "SAO 129293"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.47986778),
        dec: Angle.Degrees(-08.50433653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130620"},
        {"Hipparcos Number", "HIP 72496"},
        {"Geneva Identification System", "GEN# +1.00130620"},
        {"Smithsonian Astrophysical Observation", "SAO 140159"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.35564426),
        dec: Angle.Degrees(-08.50427847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30076"},
        {"Hipparcos Number", "HIP 22024"},
        {"Fundamental Katalog 5th Edition", "FK5 1131"},
        {"Geneva Identification System", "GEN# +1.00030076"},
        {"Smithsonian Astrophysical Observation", "SAO 131451"},
        {"Wilson Evans Batten Catalogue", "WEB 4230"},
    },
    visualMagnitude: 5.78,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.02215847),
        dec: Angle.Degrees(-08.50357425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39823",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39823"},
        {"Smithsonian Astrophysical Observation", "SAO 135545"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.05120095),
        dec: Angle.Degrees(-08.50318066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120067"},
        {"Hipparcos Number", "HIP 67282"},
        {"Smithsonian Astrophysical Observation", "SAO 139545"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.83917715),
        dec: Angle.Degrees(-08.50252536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114175"},
        {"Hipparcos Number", "HIP 64171"},
        {"Smithsonian Astrophysical Observation", "SAO 139181"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.27658184),
        dec: Angle.Degrees(-08.50111040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209360"},
        {"Hipparcos Number", "HIP 108848"},
        {"Smithsonian Astrophysical Observation", "SAO 145833"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.75385214),
        dec: Angle.Degrees(-08.50001436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50981"},
        {"Hipparcos Number", "HIP 33255"},
        {"Geneva Identification System", "GEN# +1.00050981J"},
        {"Smithsonian Astrophysical Observation", "SAO 133896"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.78038507),
        dec: Angle.Degrees(-08.49897538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74217"},
        {"Hipparcos Number", "HIP 42732"},
        {"Smithsonian Astrophysical Observation", "SAO 136201"},
    },
    visualMagnitude: 7.01,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.62783254),
        dec: Angle.Degrees(-08.49853283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16936",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16936"},
        {"Smithsonian Astrophysical Observation", "SAO 130617"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.49021407),
        dec: Angle.Degrees(-08.49504846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47801"},
        {"Hipparcos Number", "HIP 31902"},
        {"Smithsonian Astrophysical Observation", "SAO 133546"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.02218545),
        dec: Angle.Degrees(-08.49495376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26002"},
        {"Hipparcos Number", "HIP 19185"},
        {"Smithsonian Astrophysical Observation", "SAO 130957"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.67428964),
        dec: Angle.Degrees(-08.49361015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84843"},
        {"Hipparcos Number", "HIP 48062"},
        {"Smithsonian Astrophysical Observation", "SAO 137136"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.96357052),
        dec: Angle.Degrees(-08.49298097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24402"},
        {"Hipparcos Number", "HIP 18133"},
        {"Smithsonian Astrophysical Observation", "SAO 130788"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.15521481),
        dec: Angle.Degrees(-08.49154947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119586"},
        {"Hipparcos Number", "HIP 67031"},
        {"Geneva Identification System", "GEN# +1.00119586"},
        {"Smithsonian Astrophysical Observation", "SAO 139519"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.05384471),
        dec: Angle.Degrees(-08.48829668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 210",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4 AB"},
        {"Henry Draper", "HD 225015"},
        {"Hipparcos Number", "HIP 210"},
        {"Geneva Identification System", "GEN# +1.00225015J"},
        {"Smithsonian Astrophysical Observation", "SAO 128549"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.66214867),
        dec: Angle.Degrees(-08.48794379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224593"},
        {"Hipparcos Number", "HIP 118253"},
        {"Geneva Identification System", "GEN# +1.00224593"},
        {"Smithsonian Astrophysical Observation", "SAO 147011"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.78298599),
        dec: Angle.Degrees(-08.48760376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105343"},
        {"Hipparcos Number", "HIP 59149"},
        {"Geneva Identification System", "GEN# +1.00105343"},
        {"Smithsonian Astrophysical Observation", "SAO 138597"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.94664149),
        dec: Angle.Degrees(-08.48599267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121166"},
        {"Hipparcos Number", "HIP 67855"},
        {"Geneva Identification System", "GEN# +1.00121166"},
        {"Smithsonian Astrophysical Observation", "SAO 139607"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.861,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.47984432),
        dec: Angle.Degrees(-08.48420840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79707"},
        {"Hipparcos Number", "HIP 45422"},
        {"Geneva Identification System", "GEN# +1.00079707"},
        {"Smithsonian Astrophysical Observation", "SAO 136698"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.84313140),
        dec: Angle.Degrees(-08.48269262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84487"},
        {"Hipparcos Number", "HIP 47874"},
        {"Smithsonian Astrophysical Observation", "SAO 137103"},
        {"Wilson Evans Batten Catalogue", "WEB 8955"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.35543300),
        dec: Angle.Degrees(-08.48246244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24051",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24051"},
        {"Smithsonian Astrophysical Observation", "SAO 131839"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.53127866),
        dec: Angle.Degrees(-08.48169396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45728"},
        {"Hipparcos Number", "HIP 30865"},
        {"Celescope Catalog", "CEL 1260"},
        {"Geneva Identification System", "GEN# +1.00045728"},
        {"Smithsonian Astrophysical Observation", "SAO 133318"},
    },
    visualMagnitude: 8.27,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.19989396),
        dec: Angle.Degrees(-08.47976410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99238"},
        {"Hipparcos Number", "HIP 55730"},
        {"Smithsonian Astrophysical Observation", "SAO 138192"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.27769043),
        dec: Angle.Degrees(-08.47564337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12328"},
        {"Hipparcos Number", "HIP 9406"},
        {"Geneva Identification System", "GEN# +1.00012328"},
        {"Smithsonian Astrophysical Observation", "SAO 129630"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.20586364),
        dec: Angle.Degrees(-08.47158346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37492"},
        {"Hipparcos Number", "HIP 26541"},
        {"Celescope Catalog", "CEL 891"},
        {"Geneva Identification System", "GEN# +1.00037492"},
        {"Smithsonian Astrophysical Observation", "SAO 132407"},
    },
    visualMagnitude: 7.10,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.66550032),
        dec: Angle.Degrees(-08.47102140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207095"},
        {"Hipparcos Number", "HIP 107539"},
        {"Smithsonian Astrophysical Observation", "SAO 145660"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.71576818),
        dec: Angle.Degrees(-08.47023551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74928"},
        {"Hipparcos Number", "HIP 43102"},
        {"Smithsonian Astrophysical Observation", "SAO 136271"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.67278557),
        dec: Angle.Degrees(-08.46860069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14344",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14344"},
        {"Smithsonian Astrophysical Observation", "SAO 130276"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.24481755),
        dec: Angle.Degrees(-08.46856079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70831"},
        {"Hipparcos Number", "HIP 41155"},
        {"Smithsonian Astrophysical Observation", "SAO 135862"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.95661856),
        dec: Angle.Degrees(-08.46852723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151135"},
        {"Hipparcos Number", "HIP 82072"},
        {"Smithsonian Astrophysical Observation", "SAO 141349"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.45671600),
        dec: Angle.Degrees(-08.46769538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206469"},
        {"Hipparcos Number", "HIP 107167"},
        {"Geneva Identification System", "GEN# +1.00206469"},
        {"Smithsonian Astrophysical Observation", "SAO 145600"},
        {"Wilson Evans Batten Catalogue", "WEB 19358"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.61762185),
        dec: Angle.Degrees(-08.46507019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45973",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7330 A"},
        {"Henry Draper", "HD 80941"},
        {"Hipparcos Number", "HIP 45973"},
        {"Smithsonian Astrophysical Observation", "SAO 136795"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.63394804),
        dec: Angle.Degrees(-08.46473862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80786",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80786"},
        {"Smithsonian Astrophysical Observation", "SAO 141200"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.43668627),
        dec: Angle.Degrees(-08.46427411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52938"},
        {"Hipparcos Number", "HIP 33959"},
        {"Geneva Identification System", "GEN# +2.23230159"},
        {"Smithsonian Astrophysical Observation", "SAO 134103"},
        {"New General Catalogue", "NGC 2323 159"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.69239256),
        dec: Angle.Degrees(-08.45235969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132866"},
        {"Hipparcos Number", "HIP 73523"},
        {"Smithsonian Astrophysical Observation", "SAO 140277"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.41058738),
        dec: Angle.Degrees(-08.46273167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222903"},
        {"Hipparcos Number", "HIP 117127"},
        {"Geneva Identification System", "GEN# +1.00222903"},
        {"Renson", "Renson 61136"},
        {"Smithsonian Astrophysical Observation", "SAO 146882"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.17500012),
        dec: Angle.Degrees(-08.46267449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45692"},
        {"Hipparcos Number", "HIP 30830"},
        {"Geneva Identification System", "GEN# +1.00045692"},
        {"Smithsonian Astrophysical Observation", "SAO 133311"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.14895403),
        dec: Angle.Degrees(-08.46226585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 104.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129904"},
        {"Hipparcos Number", "HIP 72143"},
        {"Smithsonian Astrophysical Observation", "SAO 140119"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.33991409),
        dec: Angle.Degrees(-08.46204590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59111"},
        {"Hipparcos Number", "HIP 36292"},
        {"Smithsonian Astrophysical Observation", "SAO 134715"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.05087065),
        dec: Angle.Degrees(-08.46067748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174681"},
        {"Hipparcos Number", "HIP 92595"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.01020307),
        dec: Angle.Degrees(-08.46051362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29323"},
        {"Hipparcos Number", "HIP 21484"},
        {"Smithsonian Astrophysical Observation", "SAO 131351"},
    },
    visualMagnitude: 7.08,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.20862685),
        dec: Angle.Degrees(-08.46048060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115495",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16725 AB"},
        {"Henry Draper", "HD 220436"},
        {"Hipparcos Number", "HIP 115495"},
        {"Geneva Identification System", "GEN# +1.00220436J"},
        {"Smithsonian Astrophysical Observation", "SAO 146683"},
        {"Wilson Evans Batten Catalogue", "WEB 20446"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.93881529),
        dec: Angle.Degrees(-08.46007063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14440",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14440"},
        {"Smithsonian Astrophysical Observation", "SAO 130282"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.60367647),
        dec: Angle.Degrees(-08.45936137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31625"},
        {"Hipparcos Number", "HIP 23011"},
        {"Fundamental Katalog 5th Edition", "FK5 4452"},
        {"Geneva Identification System", "GEN# +1.00031625"},
        {"Smithsonian Astrophysical Observation", "SAO 131622"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.24470499),
        dec: Angle.Degrees(-08.45888803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174069"},
        {"Hipparcos Number", "HIP 92322"},
        {"Fundamental Katalog 5th Edition", "FK5 5653"},
        {"Geneva Identification System", "GEN# +1.00174069"},
        {"Smithsonian Astrophysical Observation", "SAO 142648"},
        {"Wilson Evans Batten Catalogue", "WEB 15938"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.24594998),
        dec: Angle.Degrees(-08.45866951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7324",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1232 AB"},
        {"Henry Draper", "HD 9626"},
        {"Hipparcos Number", "HIP 7324"},
        {"Smithsonian Astrophysical Observation", "SAO 129378"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.58090226),
        dec: Angle.Degrees(-08.45759045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197757"},
        {"Hipparcos Number", "HIP 102475"},
        {"Smithsonian Astrophysical Observation", "SAO 144780"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.48854265),
        dec: Angle.Degrees(-08.45643633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217147"},
        {"Hipparcos Number", "HIP 113456"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.65667032),
        dec: Angle.Degrees(-08.45605834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 223.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193275"},
        {"Hipparcos Number", "HIP 100235"},
        {"Smithsonian Astrophysical Observation", "SAO 144295"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.94114246),
        dec: Angle.Degrees(-08.45290885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -177.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141042"},
        {"Hipparcos Number", "HIP 77329"},
        {"Smithsonian Astrophysical Observation", "SAO 140755"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.81417777),
        dec: Angle.Degrees(-08.45288823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53514"},
        {"Hipparcos Number", "HIP 34159"},
        {"Geneva Identification System", "GEN# +1.00053514"},
        {"Smithsonian Astrophysical Observation", "SAO 134160"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.24560095),
        dec: Angle.Degrees(-08.45091451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66983"},
        {"Hipparcos Number", "HIP 39609"},
        {"Geneva Identification System", "GEN# +1.00066983"},
        {"Smithsonian Astrophysical Observation", "SAO 135487"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.41293604),
        dec: Angle.Degrees(-08.45017987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110223"},
        {"Hipparcos Number", "HIP 61858"},
        {"Geneva Identification System", "GEN# +1.00110223"},
        {"Smithsonian Astrophysical Observation", "SAO 138905"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.16971180),
        dec: Angle.Degrees(-08.44809333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88654"},
        {"Hipparcos Number", "HIP 50061"},
        {"Geneva Identification System", "GEN# +1.00088654"},
        {"Smithsonian Astrophysical Observation", "SAO 137417"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.31839173),
        dec: Angle.Degrees(-08.44547826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124353"},
        {"Hipparcos Number", "HIP 69466"},
        {"Smithsonian Astrophysical Observation", "SAO 139794"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.32776980),
        dec: Angle.Degrees(-08.44463482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207078"},
        {"Hipparcos Number", "HIP 107526"},
        {"Geneva Identification System", "GEN# +1.00207078"},
        {"Smithsonian Astrophysical Observation", "SAO 145654"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.67136789),
        dec: Angle.Degrees(-08.44354071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117860"},
        {"Hipparcos Number", "HIP 66115"},
        {"Geneva Identification System", "GEN# +1.00117860"},
        {"Smithsonian Astrophysical Observation", "SAO 139405"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.29772734),
        dec: Angle.Degrees(-08.44346350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -239.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185360"},
        {"Hipparcos Number", "HIP 96654"},
        {"Smithsonian Astrophysical Observation", "SAO 143650"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.76991953),
        dec: Angle.Degrees(-08.44316057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224105"},
        {"Hipparcos Number", "HIP 117924"},
        {"Fundamental Katalog 5th Edition", "FK5 6120"},
        {"Smithsonian Astrophysical Observation", "SAO 146976"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.77911257),
        dec: Angle.Degrees(-08.44146903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113101"},
        {"Hipparcos Number", "HIP 63548"},
        {"Cincinnati Publication", "Ci 20 757"},
        {"Geneva Identification System", "GEN# +1.00113101"},
        {"Smithsonian Astrophysical Observation", "SAO 139102"},
        {"Wilson Evans Batten Catalogue", "WEB 11246"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.33238954),
        dec: Angle.Degrees(-08.44010486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -462.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123340"},
        {"Hipparcos Number", "HIP 68967"},
        {"Geneva Identification System", "GEN# +1.00123340"},
        {"Smithsonian Astrophysical Observation", "SAO 139739"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.78372671),
        dec: Angle.Degrees(-08.43944078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195513"},
        {"Hipparcos Number", "HIP 101309"},
        {"Geneva Identification System", "GEN# +1.00195513"},
        {"Smithsonian Astrophysical Observation", "SAO 144535"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.02187403),
        dec: Angle.Degrees(-08.43832231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35976",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35976"},
        {"Smithsonian Astrophysical Observation", "SAO 134636"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.21209138),
        dec: Angle.Degrees(-08.43677185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117905"},
        {"Hipparcos Number", "HIP 66137"},
        {"Geneva Identification System", "GEN# +1.00117905"},
        {"Smithsonian Astrophysical Observation", "SAO 139408"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.36462980),
        dec: Angle.Degrees(-08.43578049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16123",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16123"},
        {"Geneva Identification System", "GEN# -0.00800655"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.91926231),
        dec: Angle.Degrees(-08.43095763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201101"},
        {"Hipparcos Number", "HIP 104300"},
        {"Geneva Identification System", "GEN# +1.00201101"},
        {"Smithsonian Astrophysical Observation", "SAO 145125"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.94364216),
        dec: Angle.Degrees(-08.43041558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146454"},
        {"Hipparcos Number", "HIP 79763"},
        {"Smithsonian Astrophysical Observation", "SAO 141071"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.19160986),
        dec: Angle.Degrees(-08.42978621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175664"},
        {"Hipparcos Number", "HIP 92995"},
        {"Smithsonian Astrophysical Observation", "SAO 142829"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.18448075),
        dec: Angle.Degrees(-08.42892818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197495"},
        {"Hipparcos Number", "HIP 102362"},
        {"Geneva Identification System", "GEN# +1.00197495"},
        {"Smithsonian Astrophysical Observation", "SAO 144754"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.10621417),
        dec: Angle.Degrees(-08.42769297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29367"},
        {"Hipparcos Number", "HIP 21512"},
        {"Smithsonian Astrophysical Observation", "SAO 131354"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.29218048),
        dec: Angle.Degrees(-08.42624912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113773"},
        {"Hipparcos Number", "HIP 63931"},
        {"Smithsonian Astrophysical Observation", "SAO 139152"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.53887525),
        dec: Angle.Degrees(-08.42348608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -206.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118704"},
        {"Hipparcos Number", "HIP 66560"},
        {"Geneva Identification System", "GEN# +1.00118704"},
        {"Smithsonian Astrophysical Observation", "SAO 139462"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.66805650),
        dec: Angle.Degrees(-08.42117729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57386"},
        {"Hipparcos Number", "HIP 35594"},
        {"Geneva Identification System", "GEN# +1.00057386"},
        {"Smithsonian Astrophysical Observation", "SAO 134543"},
    },
    visualMagnitude: 7.97,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.17909442),
        dec: Angle.Degrees(-08.42102140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84277",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84277"},
        {"Geneva Identification System", "GEN# +9.85687012"},
    },
    visualMagnitude: 12.00,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.41968314),
        dec: Angle.Degrees(-08.41977523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -422.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -409.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213215"},
        {"Hipparcos Number", "HIP 111061"},
        {"Smithsonian Astrophysical Observation", "SAO 146122"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.48295911),
        dec: Angle.Degrees(-08.41890094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215165"},
        {"Hipparcos Number", "HIP 112199"},
        {"Smithsonian Astrophysical Observation", "SAO 146276"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.85926570),
        dec: Angle.Degrees(-08.41856406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49205"},
        {"Hipparcos Number", "HIP 32501"},
        {"Smithsonian Astrophysical Observation", "SAO 133667"},
    },
    visualMagnitude: 8.07,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.74641443),
        dec: Angle.Degrees(-08.41852812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88333"},
        {"Hipparcos Number", "HIP 49865"},
        {"Geneva Identification System", "GEN# +1.00088333"},
        {"Smithsonian Astrophysical Observation", "SAO 137395"},
        {"Wilson Evans Batten Catalogue", "WEB 9181"},
    },
    visualMagnitude: 5.64,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.73275535),
        dec: Angle.Degrees(-08.41835129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51079"},
        {"Hipparcos Number", "HIP 33290"},
        {"Geneva Identification System", "GEN# +1.00051079"},
        {"Smithsonian Astrophysical Observation", "SAO 133902"},
    },
    visualMagnitude: 7.94,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.88148969),
        dec: Angle.Degrees(-08.41750773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25187",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3978 AB"},
        {"Henry Draper", "HD 35281"},
        {"Hipparcos Number", "HIP 25187"},
        {"Celescope Catalog", "CEL 669"},
        {"Geneva Identification System", "GEN# +1.00035281"},
        {"Smithsonian Astrophysical Observation", "SAO 132053"},
    },
    visualMagnitude: 5.99,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.82713053),
        dec: Angle.Degrees(-08.41558811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6286",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6286"},
        {"Smithsonian Astrophysical Observation", "SAO 129240"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.15460915),
        dec: Angle.Degrees(-08.41453768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191298"},
        {"Hipparcos Number", "HIP 99311"},
        {"Smithsonian Astrophysical Observation", "SAO 144118"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.38506473),
        dec: Angle.Degrees(-08.41443632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39787"},
        {"Hipparcos Number", "HIP 27920"},
        {"Smithsonian Astrophysical Observation", "SAO 132634"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.62334626),
        dec: Angle.Degrees(-08.41256181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143459"},
        {"Hipparcos Number", "HIP 78436"},
        {"Fundamental Katalog 5th Edition", "FK5 1420"},
        {"Geneva Identification System", "GEN# +1.00143459"},
        {"Smithsonian Astrophysical Observation", "SAO 140897"},
        {"Wilson Evans Batten Catalogue", "WEB 13259"},
    },
    visualMagnitude: 5.53,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.19850629),
        dec: Angle.Degrees(-08.41132413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107428",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107428"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.37718016),
        dec: Angle.Degrees(-08.40975016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14074",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14074"},
        {"Fundamental Katalog 5th Edition", "FK5 4277"},
        {"Smithsonian Astrophysical Observation", "SAO 130245"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.33550958),
        dec: Angle.Degrees(-08.40866243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88195"},
        {"Hipparcos Number", "HIP 49812"},
        {"Geneva Identification System", "GEN# +1.00088195"},
        {"Smithsonian Astrophysical Observation", "SAO 137385"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.53149046),
        dec: Angle.Degrees(-08.40816325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52312"},
        {"Hipparcos Number", "HIP 33729"},
        {"Celescope Catalog", "CEL 1493"},
        {"Fundamental Katalog 5th Edition", "FK5 1181"},
        {"Geneva Identification System", "GEN# +1.00052312J"},
        {"Smithsonian Astrophysical Observation", "SAO 134036"},
        {"Wilson Evans Batten Catalogue", "WEB 6776"},
    },
    visualMagnitude: 5.95,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.09900277),
        dec: Angle.Degrees(-08.40682482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101472"},
        {"Hipparcos Number", "HIP 56960"},
        {"Fundamental Katalog 5th Edition", "FK5 5032"},
        {"Geneva Identification System", "GEN# +1.00101472"},
        {"Smithsonian Astrophysical Observation", "SAO 138340"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.15249660),
        dec: Angle.Degrees(-08.40562594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38966"},
        {"Hipparcos Number", "HIP 27475"},
        {"Smithsonian Astrophysical Observation", "SAO 132568"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.27381918),
        dec: Angle.Degrees(-08.40559948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84303",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10404 AB"},
        {"Henry Draper", "HD 155802"},
        {"Hipparcos Number", "HIP 84303"},
        {"Geneva Identification System", "GEN# +1.00155802"},
        {"Smithsonian Astrophysical Observation", "SAO 141567"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.53388115),
        dec: Angle.Degrees(-08.40401323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30962"},
        {"Hipparcos Number", "HIP 22590"},
        {"Smithsonian Astrophysical Observation", "SAO 131549"},
    },
    visualMagnitude: 7.17,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.91903348),
        dec: Angle.Degrees(-08.40131798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196633"},
        {"Hipparcos Number", "HIP 101897"},
        {"Geneva Identification System", "GEN# +1.00196633"},
        {"Smithsonian Astrophysical Observation", "SAO 144658"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.73847694),
        dec: Angle.Degrees(-08.39935619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213965"},
        {"Hipparcos Number", "HIP 111479"},
        {"Smithsonian Astrophysical Observation", "SAO 146178"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.79800550),
        dec: Angle.Degrees(-08.39914348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208028"},
        {"Hipparcos Number", "HIP 108062"},
        {"Smithsonian Astrophysical Observation", "SAO 145729"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.40769976),
        dec: Angle.Degrees(-08.39833955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211186"},
        {"Hipparcos Number", "HIP 109899"},
        {"Smithsonian Astrophysical Observation", "SAO 145975"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.89189281),
        dec: Angle.Degrees(-08.39778074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136010"},
        {"Hipparcos Number", "HIP 74918"},
        {"Fundamental Katalog 5th Edition", "FK5 5359"},
        {"Smithsonian Astrophysical Observation", "SAO 140446"},
        {"Wilson Evans Batten Catalogue", "WEB 12780"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.64727737),
        dec: Angle.Degrees(-08.39723681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200759"},
        {"Hipparcos Number", "HIP 104122"},
        {"Geneva Identification System", "GEN# +1.00200759"},
        {"Smithsonian Astrophysical Observation", "SAO 145085"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.41778048),
        dec: Angle.Degrees(-08.39718562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42206"},
        {"Hipparcos Number", "HIP 29156"},
        {"Smithsonian Astrophysical Observation", "SAO 132887"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.25715948),
        dec: Angle.Degrees(-08.39559771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176361"},
        {"Hipparcos Number", "HIP 93298"},
        {"Smithsonian Astrophysical Observation", "SAO 142899"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.05493381),
        dec: Angle.Degrees(-08.39541350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28285"},
        {"Hipparcos Number", "HIP 20797"},
        {"Smithsonian Astrophysical Observation", "SAO 131228"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.84942352),
        dec: Angle.Degrees(-08.39296945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62652"},
        {"Hipparcos Number", "HIP 37776"},
        {"Smithsonian Astrophysical Observation", "SAO 135057"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.19114297),
        dec: Angle.Degrees(-08.39243157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33665",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5665 AB"},
        {"Henry Draper", "HD 52131"},
        {"Hipparcos Number", "HIP 33665"},
        {"Smithsonian Astrophysical Observation", "SAO 134008"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.90460567),
        dec: Angle.Degrees(-08.38988778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95757"},
        {"Hipparcos Number", "HIP 54015"},
        {"Smithsonian Astrophysical Observation", "SAO 137960"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.75230671),
        dec: Angle.Degrees(-08.38986646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27401",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4402 B"},
        {"Hipparcos Number", "HIP 27401"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.04327144),
        dec: Angle.Degrees(-08.38941503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215597"},
        {"Hipparcos Number", "HIP 112427"},
        {"Smithsonian Astrophysical Observation", "SAO 146303"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.58639042),
        dec: Angle.Degrees(-08.38924163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131541"},
        {"Hipparcos Number", "HIP 72943"},
        {"Smithsonian Astrophysical Observation", "SAO 140214"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.62004630),
        dec: Angle.Degrees(-08.38845030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219190"},
        {"Hipparcos Number", "HIP 114707"},
        {"Geneva Identification System", "GEN# +1.00219190"},
        {"Smithsonian Astrophysical Observation", "SAO 146579"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.53273019),
        dec: Angle.Degrees(-08.38711397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87273"},
        {"Hipparcos Number", "HIP 49305"},
        {"Smithsonian Astrophysical Observation", "SAO 137328"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.95818161),
        dec: Angle.Degrees(-08.38574045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174283"},
        {"Hipparcos Number", "HIP 92423"},
        {"Geneva Identification System", "GEN# +1.00174283"},
        {"Smithsonian Astrophysical Observation", "SAO 142667"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.52322769),
        dec: Angle.Degrees(-08.38557940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12344",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12344"},
        {"Smithsonian Astrophysical Observation", "SAO 130034"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.73648158),
        dec: Angle.Degrees(-08.38547681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40168"},
        {"Hipparcos Number", "HIP 28149"},
        {"Geneva Identification System", "GEN# +1.00040168"},
        {"Smithsonian Astrophysical Observation", "SAO 132683"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.22803248),
        dec: Angle.Degrees(-08.38403153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27402",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4402 A"},
        {"Henry Draper", "HD 38824"},
        {"Hipparcos Number", "HIP 27402"},
        {"Celescope Catalog", "CEL 982"},
        {"Geneva Identification System", "GEN# +1.00038824"},
        {"Smithsonian Astrophysical Observation", "SAO 132549"},
    },
    visualMagnitude: 7.30,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.04343063),
        dec: Angle.Degrees(-08.38363207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94552"},
        {"Hipparcos Number", "HIP 53364"},
        {"Smithsonian Astrophysical Observation", "SAO 137879"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.69008629),
        dec: Angle.Degrees(-08.37887984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25646",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4071 A"},
        {"Henry Draper", "HD 36059"},
        {"Hipparcos Number", "HIP 25646"},
        {"Geneva Identification System", "GEN# +1.00036059"},
        {"Smithsonian Astrophysical Observation", "SAO 132154"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.828,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.17706901),
        dec: Angle.Degrees(-08.37667885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61864"},
        {"Hipparcos Number", "HIP 37429"},
        {"Smithsonian Astrophysical Observation", "SAO 134981"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.24418221),
        dec: Angle.Degrees(-08.37621189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167198"},
        {"Hipparcos Number", "HIP 89381"},
        {"Smithsonian Astrophysical Observation", "SAO 142171"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.60034259),
        dec: Angle.Degrees(-08.37407716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77381"},
        {"Hipparcos Number", "HIP 44354"},
        {"Smithsonian Astrophysical Observation", "SAO 136513"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.48915656),
        dec: Angle.Degrees(-08.37403474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25644",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4071 B"},
        {"Hipparcos Number", "HIP 25644"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.17080111),
        dec: Angle.Degrees(-08.37299936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123826"},
        {"Hipparcos Number", "HIP 69203"},
        {"Smithsonian Astrophysical Observation", "SAO 139766"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.52043641),
        dec: Angle.Degrees(-08.37173547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148367"},
        {"Hipparcos Number", "HIP 80628"},
        {"Fundamental Katalog 5th Edition", "FK5 3299"},
        {"Geneva Identification System", "GEN# +1.00148367J"},
        {"Renson", "Renson 41940"},
        {"Smithsonian Astrophysical Observation", "SAO 141187"},
        {"Wilson Evans Batten Catalogue", "WEB 13636"},
    },
    visualMagnitude: 4.62,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.95094563),
        dec: Angle.Degrees(-08.37170055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182977"},
        {"Hipparcos Number", "HIP 95678"},
        {"Smithsonian Astrophysical Observation", "SAO 143418"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.91884397),
        dec: Angle.Degrees(-08.37091383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91366",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91366"},
        {"Geneva Identification System", "GEN# -0.00804663"},
        {"Wilson Evans Batten Catalogue", "WEB 15699"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.51377959),
        dec: Angle.Degrees(-08.36892748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107890"},
        {"Hipparcos Number", "HIP 60479"},
        {"Smithsonian Astrophysical Observation", "SAO 138756"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.97981711),
        dec: Angle.Degrees(-08.36876844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
