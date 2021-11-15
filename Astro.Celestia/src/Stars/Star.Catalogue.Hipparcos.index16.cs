using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_16() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120328"},
        {"Hipparcos Number", "HIP 67503"},
        {"Smithsonian Astrophysical Observation", "SAO 241206"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.49325817),
        dec: Angle.Degrees(-51.62163188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198699"},
        {"Hipparcos Number", "HIP 103174"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.55786138),
        dec: Angle.Degrees(-51.62103468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224653"},
        {"Hipparcos Number", "HIP 118300"},
        {"Smithsonian Astrophysical Observation", "SAO 248093"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.92501047),
        dec: Angle.Degrees(-51.62085809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170913"},
        {"Hipparcos Number", "HIP 91079"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.66510350),
        dec: Angle.Degrees(-51.61949826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141545"},
        {"Hipparcos Number", "HIP 77701"},
        {"Smithsonian Astrophysical Observation", "SAO 243057"},
    },
    visualMagnitude: 7.65,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.97482025),
        dec: Angle.Degrees(-51.61947376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122963"},
        {"Hipparcos Number", "HIP 68898"},
        {"Geneva Identification System", "GEN# +1.00122963"},
        {"Smithsonian Astrophysical Observation", "SAO 241444"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.59956107),
        dec: Angle.Degrees(-51.61910437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138945"},
        {"Hipparcos Number", "HIP 76507"},
        {"Smithsonian Astrophysical Observation", "SAO 242773"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.37933259),
        dec: Angle.Degrees(-51.61850295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 298457"},
        {"Hipparcos Number", "HIP 46970"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.59794322),
        dec: Angle.Degrees(-51.61845646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145448"},
        {"Hipparcos Number", "HIP 79513"},
        {"Smithsonian Astrophysical Observation", "SAO 243458"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.37573227),
        dec: Angle.Degrees(-51.61745612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222348"},
        {"Hipparcos Number", "HIP 116776"},
        {"Smithsonian Astrophysical Observation", "SAO 247973"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.00048781),
        dec: Angle.Degrees(-51.61673099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208408"},
        {"Hipparcos Number", "HIP 108383"},
        {"Smithsonian Astrophysical Observation", "SAO 247242"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.36986434),
        dec: Angle.Degrees(-51.61503699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90086"},
        {"Hipparcos Number", "HIP 50825"},
        {"Geneva Identification System", "GEN# +2.32280019"},
        {"Smithsonian Astrophysical Observation", "SAO 237997"},
        {"New General Catalogue", "NGC 3228 19"},
    },
    visualMagnitude: 7.92,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.67173052),
        dec: Angle.Degrees(-51.61375879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76510",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76510"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.38841849),
        dec: Angle.Degrees(-51.61236259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208197"},
        {"Hipparcos Number", "HIP 108269"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.01865483),
        dec: Angle.Degrees(-51.61154061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11937"},
        {"Hipparcos Number", "HIP 9007"},
        {"Cincinnati Publication", "Ci 20 134"},
        {"Fundamental Katalog 5th Edition", "FK5 68"},
        {"Geneva Identification System", "GEN# +1.00011937"},
        {"Smithsonian Astrophysical Observation", "SAO 232573"},
        {"Wilson Evans Batten Catalogue", "WEB 1891"},
    },
    visualMagnitude: 3.69,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.98680207),
        dec: Angle.Degrees(-51.60958673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 681.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 284.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198308"},
        {"Hipparcos Number", "HIP 102950"},
        {"Geneva Identification System", "GEN# +1.00198308"},
        {"Smithsonian Astrophysical Observation", "SAO 246762"},
        {"Wilson Evans Batten Catalogue", "WEB 18678"},
    },
    visualMagnitude: 5.06,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.87520805),
        dec: Angle.Degrees(-51.60816692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60373"},
        {"Hipparcos Number", "HIP 36591"},
        {"Smithsonian Astrophysical Observation", "SAO 235267"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.88668824),
        dec: Angle.Degrees(-51.60496757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213882"},
        {"Hipparcos Number", "HIP 111512"},
        {"Fundamental Katalog 5th Edition", "FK5 3809"},
        {"Smithsonian Astrophysical Observation", "SAO 247502"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.88801035),
        dec: Angle.Degrees(-51.60395117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27366"},
        {"Hipparcos Number", "HIP 19944"},
        {"Smithsonian Astrophysical Observation", "SAO 233462"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.16397587),
        dec: Angle.Degrees(-51.60181092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91306"},
        {"Hipparcos Number", "HIP 51528"},
        {"Geneva Identification System", "GEN# +1.00091306"},
        {"Smithsonian Astrophysical Observation", "SAO 238147"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.87073017),
        dec: Angle.Degrees(-51.60103427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170537"},
        {"Hipparcos Number", "HIP 90914"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.18198535),
        dec: Angle.Degrees(-51.60078793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12372"},
        {"Hipparcos Number", "HIP 9335"},
        {"Smithsonian Astrophysical Observation", "SAO 232597"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.96878635),
        dec: Angle.Degrees(-51.59837385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137465"},
        {"Hipparcos Number", "HIP 75742"},
        {"Geneva Identification System", "GEN# +1.00137465J"},
        {"Smithsonian Astrophysical Observation", "SAO 242569"},
    },
    visualMagnitude: 6.10,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.11338713),
        dec: Angle.Degrees(-51.59792224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138638"},
        {"Hipparcos Number", "HIP 76339"},
        {"Smithsonian Astrophysical Observation", "SAO 242734"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.89073323),
        dec: Angle.Degrees(-51.59621305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63954",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63954"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.60279408),
        dec: Angle.Degrees(-51.59472301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27043"},
        {"Hipparcos Number", "HIP 19733"},
        {"Smithsonian Astrophysical Observation", "SAO 233440"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.44996896),
        dec: Angle.Degrees(-51.59350866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10359"},
        {"Hipparcos Number", "HIP 7766"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.98571040),
        dec: Angle.Degrees(-51.59325995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30398"},
        {"Hipparcos Number", "HIP 22053"},
        {"Smithsonian Astrophysical Observation", "SAO 233656"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.14380298),
        dec: Angle.Degrees(-51.59308995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22867"},
        {"Hipparcos Number", "HIP 16945"},
        {"Smithsonian Astrophysical Observation", "SAO 233192"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.51337526),
        dec: Angle.Degrees(-51.59203697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90771"},
        {"Hipparcos Number", "HIP 51214"},
        {"Smithsonian Astrophysical Observation", "SAO 238079"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.91456050),
        dec: Angle.Degrees(-51.59073665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35182",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35182"},
    },
    visualMagnitude: 9.87,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.06639381),
        dec: Angle.Degrees(-51.59024540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221068"},
        {"Hipparcos Number", "HIP 115929"},
        {"Smithsonian Astrophysical Observation", "SAO 247900"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.31830731),
        dec: Angle.Degrees(-51.58809756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43597"},
        {"Hipparcos Number", "HIP 29595"},
        {"Smithsonian Astrophysical Observation", "SAO 234389"},
        {"Smithsonian Astrophysical Observation 2", "SAO 234391"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.55527557),
        dec: Angle.Degrees(-51.58470305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4468",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4468"},
        {"Geneva Identification System", "GEN# +6.20145180"},
    },
    visualMagnitude: 10.77,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.31738750),
        dec: Angle.Degrees(-51.58429906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76440"},
        {"Hipparcos Number", "HIP 43706"},
        {"Geneva Identification System", "GEN# +1.00076440"},
        {"Smithsonian Astrophysical Observation", "SAO 236384"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.51096646),
        dec: Angle.Degrees(-51.58384560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 178.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225251"},
        {"Hipparcos Number", "HIP 370"},
        {"Smithsonian Astrophysical Observation", "SAO 231916"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.15940288),
        dec: Angle.Degrees(-51.58336438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35024"},
        {"Hipparcos Number", "HIP 24791"},
        {"Smithsonian Astrophysical Observation", "SAO 233925"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.72910077),
        dec: Angle.Degrees(-51.57948769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8449",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8449"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.23477784),
        dec: Angle.Degrees(-51.57766913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 197.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36434"},
        {"Hipparcos Number", "HIP 25661"},
        {"Smithsonian Astrophysical Observation", "SAO 233994"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.21397298),
        dec: Angle.Degrees(-51.57686397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145414"},
        {"Hipparcos Number", "HIP 79494"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.32993021),
        dec: Angle.Degrees(-51.57632844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132101"},
        {"Hipparcos Number", "HIP 73345"},
        {"Geneva Identification System", "GEN# +1.00132101"},
        {"Smithsonian Astrophysical Observation", "SAO 242146"},
    },
    visualMagnitude: 6.78,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.83044350),
        dec: Angle.Degrees(-51.57610379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72386",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72386"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.00450054),
        dec: Angle.Degrees(-51.57601754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35356"},
        {"Hipparcos Number", "HIP 25017"},
        {"Smithsonian Astrophysical Observation", "SAO 233940"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.34603960),
        dec: Angle.Degrees(-51.57540047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101171"},
        {"Hipparcos Number", "HIP 56760"},
        {"Geneva Identification System", "GEN# +1.00101171"},
        {"Smithsonian Astrophysical Observation", "SAO 239245"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.54634706),
        dec: Angle.Degrees(-51.57521699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205847"},
        {"Hipparcos Number", "HIP 106954"},
        {"Geneva Identification System", "GEN# +1.00205847"},
        {"Smithsonian Astrophysical Observation", "SAO 247123"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.92015537),
        dec: Angle.Degrees(-51.57260083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180575"},
        {"Hipparcos Number", "HIP 94975"},
        {"Fundamental Katalog 5th Edition", "FK5 3542"},
        {"Geneva Identification System", "GEN# +1.00180575J"},
        {"Smithsonian Astrophysical Observation", "SAO 246028"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.90584488),
        dec: Angle.Degrees(-51.57250365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19334",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19334"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.15066326),
        dec: Angle.Degrees(-51.57243638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142838"},
        {"Hipparcos Number", "HIP 78287"},
        {"Smithsonian Astrophysical Observation", "SAO 243199"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.77201336),
        dec: Angle.Degrees(-51.57242655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102112"},
        {"Hipparcos Number", "HIP 57299"},
        {"Smithsonian Astrophysical Observation", "SAO 239350"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.24001354),
        dec: Angle.Degrees(-51.57118279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50572",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50572"},
        {"Smithsonian Astrophysical Observation", "SAO 237920"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)19, 50.7600),
        dec: Angle.DegreesMinutesSeconds((int)-51, (int)34, 06.500)
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
    primaryId: "HIP 50575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89713"},
        {"Hipparcos Number", "HIP 50575"},
        {"Geneva Identification System", "GEN# +2.32280001"},
        {"Smithsonian Astrophysical Observation", "SAO 237921"},
        {"New General Catalogue", "NGC 3228 1"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.96813153),
        dec: Angle.Degrees(-51.56788470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17703"},
        {"Hipparcos Number", "HIP 13107"},
        {"Smithsonian Astrophysical Observation", "SAO 232902"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.12978562),
        dec: Angle.Degrees(-51.56781785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96515",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96515"},
    },
    visualMagnitude: 11.73,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.28625774),
        dec: Angle.Degrees(-51.56684909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189329"},
        {"Hipparcos Number", "HIP 98622"},
        {"Smithsonian Astrophysical Observation", "SAO 246396"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.46511322),
        dec: Angle.Degrees(-51.56499406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25470"},
        {"Hipparcos Number", "HIP 18691"},
        {"Geneva Identification System", "GEN# +1.00025470"},
        {"Smithsonian Astrophysical Observation", "SAO 233354"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.06469277),
        dec: Angle.Degrees(-51.56498143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80558"},
        {"Hipparcos Number", "HIP 45675"},
        {"Geneva Identification System", "GEN# +1.00080558"},
        {"Smithsonian Astrophysical Observation", "SAO 236837"},
        {"Wilson Evans Batten Catalogue", "WEB 8673"},
    },
    visualMagnitude: 5.83,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.67650557),
        dec: Angle.Degrees(-51.56065990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179035"},
        {"Hipparcos Number", "HIP 94462"},
        {"Smithsonian Astrophysical Observation", "SAO 245979"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.39564026),
        dec: Angle.Degrees(-51.55917955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77464"},
        {"Hipparcos Number", "HIP 44245"},
        {"Celescope Catalog", "CEL 3140"},
        {"Geneva Identification System", "GEN# +1.00077464"},
        {"Smithsonian Astrophysical Observation", "SAO 236495"},
        {"Wilson Evans Batten Catalogue", "WEB 8489"},
    },
    visualMagnitude: 6.70,
    bvColour: -0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.15833554),
        dec: Angle.Degrees(-51.55558474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21200"},
        {"Hipparcos Number", "HIP 15757"},
        {"Smithsonian Astrophysical Observation", "SAO 233091"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.76206446),
        dec: Angle.Degrees(-51.55481630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83721"},
        {"Hipparcos Number", "HIP 47334"},
        {"Smithsonian Astrophysical Observation", "SAO 237178"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.68202853),
        dec: Angle.Degrees(-51.55438480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71804"},
        {"Hipparcos Number", "HIP 41442"},
        {"Smithsonian Astrophysical Observation", "SAO 235992"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.77935153),
        dec: Angle.Degrees(-51.55344516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120575"},
        {"Hipparcos Number", "HIP 67643"},
        {"Geneva Identification System", "GEN# +1.00120575"},
        {"Smithsonian Astrophysical Observation", "SAO 241231"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.89221338),
        dec: Angle.Degrees(-51.55303207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12792",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12792"},
        {"Smithsonian Astrophysical Observation", "SAO 232873"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.10009526),
        dec: Angle.Degrees(-51.55299697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213139"},
        {"Hipparcos Number", "HIP 111099"},
        {"Smithsonian Astrophysical Observation", "SAO 247467"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.61061507),
        dec: Angle.Degrees(-51.55231858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118497"},
        {"Hipparcos Number", "HIP 66543"},
        {"Celescope Catalog", "CEL 4272"},
        {"Geneva Identification System", "GEN# +1.00118497"},
        {"Smithsonian Astrophysical Observation", "SAO 241024"},
    },
    visualMagnitude: 8.11,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.61355787),
        dec: Angle.Degrees(-51.55204109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146401"},
        {"Hipparcos Number", "HIP 79902"},
        {"Smithsonian Astrophysical Observation", "SAO 243588"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.64330072),
        dec: Angle.Degrees(-51.55184226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63403"},
        {"Hipparcos Number", "HIP 37910"},
        {"Geneva Identification System", "GEN# +1.00063403"},
        {"Smithsonian Astrophysical Observation", "SAO 235494"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.53796611),
        dec: Angle.Degrees(-51.55075627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 298573"},
        {"Hipparcos Number", "HIP 47349"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.72430548),
        dec: Angle.Degrees(-51.55072386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34142"},
        {"Hipparcos Number", "HIP 24253"},
        {"Smithsonian Astrophysical Observation", "SAO 233871"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.09161891),
        dec: Angle.Degrees(-51.55026104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5135"},
        {"Hipparcos Number", "HIP 4105"},
        {"Geneva Identification System", "GEN# +1.00005135"},
        {"Smithsonian Astrophysical Observation", "SAO 232214"},
        {"Wilson Evans Batten Catalogue", "WEB 734"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.16866483),
        dec: Angle.Degrees(-51.55011047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185238"},
        {"Hipparcos Number", "HIP 96803"},
        {"Smithsonian Astrophysical Observation", "SAO 246209"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.16960370),
        dec: Angle.Degrees(-51.54991555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169325"},
        {"Hipparcos Number", "HIP 90413"},
        {"Smithsonian Astrophysical Observation", "SAO 245471"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.71973699),
        dec: Angle.Degrees(-51.54928532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54865",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54865"},
    },
    visualMagnitude: 11.94,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.51392732),
        dec: Angle.Degrees(-51.54881827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151517"},
        {"Hipparcos Number", "HIP 82410"},
        {"Smithsonian Astrophysical Observation", "SAO 244184"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.62354045),
        dec: Angle.Degrees(-51.54713701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123372"},
        {"Hipparcos Number", "HIP 69099"},
        {"Smithsonian Astrophysical Observation", "SAO 241477"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.17085135),
        dec: Angle.Degrees(-51.54640598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22103"},
        {"Hipparcos Number", "HIP 16419"},
        {"Smithsonian Astrophysical Observation", "SAO 233143"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.85348155),
        dec: Angle.Degrees(-51.54134909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97468"},
        {"Hipparcos Number", "HIP 54732"},
        {"Smithsonian Astrophysical Observation", "SAO 238858"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.08449714),
        dec: Angle.Degrees(-51.53964506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52549",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52549"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.16271603),
        dec: Angle.Degrees(-51.53922203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72069"},
        {"Hipparcos Number", "HIP 41570"},
        {"Smithsonian Astrophysical Observation", "SAO 236012"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.13954152),
        dec: Angle.Degrees(-51.53862936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149535"},
        {"Hipparcos Number", "HIP 81441"},
        {"Smithsonian Astrophysical Observation", "SAO 244008"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.50757413),
        dec: Angle.Degrees(-51.53740549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90705"},
        {"Hipparcos Number", "HIP 51174"},
        {"Geneva Identification System", "GEN# +1.00090705"},
        {"Smithsonian Astrophysical Observation", "SAO 238074"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.79136554),
        dec: Angle.Degrees(-51.53656835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25217",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25217"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.90799517),
        dec: Angle.Degrees(-51.53599951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7368"},
        {"Hipparcos Number", "HIP 5676"},
        {"Smithsonian Astrophysical Observation", "SAO 232342"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.23743571),
        dec: Angle.Degrees(-51.53490146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152101"},
        {"Hipparcos Number", "HIP 82670"},
        {"Smithsonian Astrophysical Observation", "SAO 244256"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.49738529),
        dec: Angle.Degrees(-51.53457787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107507"},
        {"Hipparcos Number", "HIP 60284"},
        {"Smithsonian Astrophysical Observation", "SAO 239874"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.42783489),
        dec: Angle.Degrees(-51.53437891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75138",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75138"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.33099523),
        dec: Angle.Degrees(-51.53269774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 297991"},
        {"Hipparcos Number", "HIP 50359"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.23986490),
        dec: Angle.Degrees(-51.53252561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 298677"},
        {"Hipparcos Number", "HIP 48290"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.68280116),
        dec: Angle.Degrees(-51.52799199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37690",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37690"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.99120572),
        dec: Angle.Degrees(-23.68041987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84414"},
        {"Hipparcos Number", "HIP 47703"},
        {"Geneva Identification System", "GEN# +1.00084414"},
        {"Smithsonian Astrophysical Observation", "SAO 237262"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.839,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.89149059),
        dec: Angle.Degrees(-51.52776493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185348"},
        {"Hipparcos Number", "HIP 96849"},
        {"Geneva Identification System", "GEN# +1.00185348"},
        {"Smithsonian Astrophysical Observation", "SAO 246214"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.29385535),
        dec: Angle.Degrees(-51.52575203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121059"},
        {"Hipparcos Number", "HIP 67905"},
        {"Smithsonian Astrophysical Observation", "SAO 241275"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.62340731),
        dec: Angle.Degrees(-51.52361741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1332"},
        {"Hipparcos Number", "HIP 1393"},
        {"Smithsonian Astrophysical Observation", "SAO 231989"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.35152997),
        dec: Angle.Degrees(-51.52236074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72517",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72517"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.40158985),
        dec: Angle.Degrees(-51.52086886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8926"},
        {"Hipparcos Number", "HIP 6756"},
        {"Geneva Identification System", "GEN# +1.00008926"},
        {"Smithsonian Astrophysical Observation", "SAO 232424"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.73769666),
        dec: Angle.Degrees(-51.52033293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174076"},
        {"Hipparcos Number", "HIP 92530"},
        {"Fundamental Katalog 5th Edition", "FK5 5660"},
        {"Geneva Identification System", "GEN# +1.00174076"},
        {"Smithsonian Astrophysical Observation", "SAO 245754"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.84966316),
        dec: Angle.Degrees(-51.52015134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82419"},
        {"Hipparcos Number", "HIP 46594"},
        {"Celescope Catalog", "CEL 3312"},
        {"Geneva Identification System", "GEN# +1.00082419"},
        {"Smithsonian Astrophysical Observation", "SAO 237042"},
        {"Wilson Evans Batten Catalogue", "WEB 8792"},
    },
    visualMagnitude: 5.45,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.52136650),
        dec: Angle.Degrees(-51.51719294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62824",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62824"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.10878367),
        dec: Angle.Degrees(-51.51630658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174616"},
        {"Hipparcos Number", "HIP 92754"},
    },
    visualMagnitude: 9.74,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.52054267),
        dec: Angle.Degrees(-51.51600285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103976"},
        {"Hipparcos Number", "HIP 58384"},
        {"Geneva Identification System", "GEN# +1.00103976"},
        {"Smithsonian Astrophysical Observation", "SAO 239535"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.57775674),
        dec: Angle.Degrees(-51.51583480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201649"},
        {"Hipparcos Number", "HIP 104721"},
        {"Geneva Identification System", "GEN# +1.00201649"},
        {"Smithsonian Astrophysical Observation", "SAO 246910"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.19774358),
        dec: Angle.Degrees(-51.51356620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215711"},
        {"Hipparcos Number", "HIP 112575"},
        {"Smithsonian Astrophysical Observation", "SAO 247589"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.01672262),
        dec: Angle.Degrees(-51.51267826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14228"},
        {"Hipparcos Number", "HIP 10602"},
        {"Fundamental Katalog 5th Edition", "FK5 82"},
        {"Geneva Identification System", "GEN# +1.00014228"},
        {"Renson", "Renson 3610"},
        {"Smithsonian Astrophysical Observation", "SAO 232696"},
        {"Wilson Evans Batten Catalogue", "WEB 2230"},
    },
    visualMagnitude: 3.56,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.12708452),
        dec: Angle.Degrees(-51.51211145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80173",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80173"},
    },
    visualMagnitude: 10.15,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.48757114),
        dec: Angle.Degrees(-51.51184754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133736"},
        {"Hipparcos Number", "HIP 74053"},
        {"Geneva Identification System", "GEN# +1.00133736"},
        {"Smithsonian Astrophysical Observation", "SAO 242245"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.00517288),
        dec: Angle.Degrees(-51.50991939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62689",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62689"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.68343728),
        dec: Angle.Degrees(-51.50982232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -173.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112581"},
        {"Hipparcos Number", "HIP 63307"},
        {"Smithsonian Astrophysical Observation", "SAO 240433"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.60864058),
        dec: Angle.Degrees(-51.50918525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18229"},
        {"Hipparcos Number", "HIP 13485"},
        {"Geneva Identification System", "GEN# +1.00018229"},
        {"Smithsonian Astrophysical Observation", "SAO 232930"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.41724488),
        dec: Angle.Degrees(-51.50751522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192740"},
        {"Hipparcos Number", "HIP 100126"},
        {"Geneva Identification System", "GEN# +1.00192740"},
        {"Smithsonian Astrophysical Observation", "SAO 246524"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.67714229),
        dec: Angle.Degrees(-51.50616677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 241.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123515"},
        {"Hipparcos Number", "HIP 69174"},
        {"Celescope Catalog", "CEL 4303"},
        {"Fundamental Katalog 5th Edition", "FK5 3122"},
        {"Geneva Identification System", "GEN# +1.00123515"},
        {"Renson", "Renson 35380"},
        {"Smithsonian Astrophysical Observation", "SAO 241491"},
        {"Wilson Evans Batten Catalogue", "WEB 12073"},
    },
    visualMagnitude: 5.96,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.39609336),
        dec: Angle.Degrees(-51.50464539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116434"},
        {"Hipparcos Number", "HIP 65426"},
        {"Celescope Catalog", "CEL 4249"},
        {"Smithsonian Astrophysical Observation", "SAO 240811"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.15054009),
        dec: Angle.Degrees(-51.50441093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77305"},
        {"Hipparcos Number", "HIP 44168"},
        {"Fundamental Katalog 5th Edition", "FK5 4801"},
        {"Smithsonian Astrophysical Observation", "SAO 236476"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.93936557),
        dec: Angle.Degrees(-51.50391966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124979"},
        {"Hipparcos Number", "HIP 69892"},
        {"Geneva Identification System", "GEN# +1.00124979"},
        {"Smithsonian Astrophysical Observation", "SAO 241609"},
        {"Wilson Evans Batten Catalogue", "WEB 12159"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.54978120),
        dec: Angle.Degrees(-51.50386157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85439",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85439"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.89963647),
        dec: Angle.Degrees(-51.50325821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85525"},
        {"Hipparcos Number", "HIP 48302"},
        {"Smithsonian Astrophysical Observation", "SAO 237402"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.71486966),
        dec: Angle.Degrees(-51.50307391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147261"},
        {"Hipparcos Number", "HIP 80285"},
        {"Fundamental Katalog 5th Edition", "FK5 5445"},
        {"Smithsonian Astrophysical Observation", "SAO 243730"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.83878611),
        dec: Angle.Degrees(-51.50243438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9195"},
        {"Hipparcos Number", "HIP 6949"},
        {"Geneva Identification System", "GEN# +1.00009195"},
        {"Smithsonian Astrophysical Observation", "SAO 232433"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.839,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.36900529),
        dec: Angle.Degrees(-51.50121176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -273.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58348",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58348"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.49164070),
        dec: Angle.Degrees(-51.50067400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -228.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69148",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69148"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.33332274),
        dec: Angle.Degrees(-51.50062497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94506"},
        {"Hipparcos Number", "HIP 53269"},
        {"Fundamental Katalog 5th Edition", "FK5 4960"},
        {"Smithsonian Astrophysical Observation", "SAO 238576"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.42108084),
        dec: Angle.Degrees(-51.49920959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71775"},
        {"Hipparcos Number", "HIP 41422"},
        {"Smithsonian Astrophysical Observation", "SAO 235984"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.73448711),
        dec: Angle.Degrees(-51.49839657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167299"},
        {"Hipparcos Number", "HIP 89618"},
        {"Smithsonian Astrophysical Observation", "SAO 245374"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.32989626),
        dec: Angle.Degrees(-51.49791519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180021"},
        {"Hipparcos Number", "HIP 94804"},
        {"Fundamental Katalog 5th Edition", "FK5 5696"},
        {"Smithsonian Astrophysical Observation", "SAO 246013"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.35762447),
        dec: Angle.Degrees(-51.49677832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27944"},
        {"Hipparcos Number", "HIP 20396"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.50274960),
        dec: Angle.Degrees(-51.49317293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208876"},
        {"Hipparcos Number", "HIP 108640"},
        {"Geneva Identification System", "GEN# +1.00208876"},
        {"Smithsonian Astrophysical Observation", "SAO 247265"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.13947168),
        dec: Angle.Degrees(-51.49222289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59940",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59940"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.42510522),
        dec: Angle.Degrees(-51.49212629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107024"},
        {"Hipparcos Number", "HIP 60028"},
        {"Geneva Identification System", "GEN# +1.00107024"},
        {"Smithsonian Astrophysical Observation", "SAO 239830"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.65837359),
        dec: Angle.Degrees(-51.49078716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223318"},
        {"Hipparcos Number", "HIP 117441"},
        {"Geneva Identification System", "GEN# +1.00223318"},
        {"Smithsonian Astrophysical Observation", "SAO 248026"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.19221430),
        dec: Angle.Degrees(-51.48886144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58269"},
        {"Hipparcos Number", "HIP 35728"},
        {"Smithsonian Astrophysical Observation", "SAO 235144"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.55783105),
        dec: Angle.Degrees(-51.48730845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27290"},
        {"Hipparcos Number", "HIP 19893"},
        {"Fundamental Katalog 5th Edition", "FK5 157"},
        {"Geneva Identification System", "GEN# +1.00027290"},
        {"Smithsonian Astrophysical Observation", "SAO 233457"},
        {"Wilson Evans Batten Catalogue", "WEB 3801"},
    },
    visualMagnitude: 4.26,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.00621426),
        dec: Angle.Degrees(-51.48709578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 184.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18024"},
        {"Hipparcos Number", "HIP 13350"},
        {"Geneva Identification System", "GEN# +1.00018024"},
        {"Smithsonian Astrophysical Observation", "SAO 232920"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.94387045),
        dec: Angle.Degrees(-51.48686896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76283"},
        {"Hipparcos Number", "HIP 43619"},
        {"Celescope Catalog", "CEL 3038"},
        {"Geneva Identification System", "GEN# +1.00076283"},
        {"Smithsonian Astrophysical Observation", "SAO 236366"},
    },
    visualMagnitude: 8.75,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.25829233),
        dec: Angle.Degrees(-51.48575383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14089"},
        {"Hipparcos Number", "HIP 10481"},
        {"Smithsonian Astrophysical Observation", "SAO 232683"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.78621703),
        dec: Angle.Degrees(-51.48265610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58455",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58455"},
    },
    visualMagnitude: 11.11,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.80904203),
        dec: Angle.Degrees(-51.48078744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2107"},
        {"Hipparcos Number", "HIP 1977"},
        {"Smithsonian Astrophysical Observation", "SAO 232031"},
        {"Wilson Evans Batten Catalogue", "WEB 372"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.26592725),
        dec: Angle.Degrees(-51.47933945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 162.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149989"},
        {"Hipparcos Number", "HIP 81650"},
        {"Geneva Identification System", "GEN# +1.00149989"},
        {"Smithsonian Astrophysical Observation", "SAO 244058"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.18495232),
        dec: Angle.Degrees(-51.47857638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 130.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34678"},
        {"Hipparcos Number", "HIP 24589"},
        {"Smithsonian Astrophysical Observation", "SAO 233904"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.12351290),
        dec: Angle.Degrees(-51.47597732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172780"},
        {"Hipparcos Number", "HIP 91972"},
        {"Smithsonian Astrophysical Observation", "SAO 245673"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.19989637),
        dec: Angle.Degrees(-51.47592498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61031"},
        {"Hipparcos Number", "HIP 36856"},
        {"Geneva Identification System", "GEN# +1.00061031"},
        {"Smithsonian Astrophysical Observation", "SAO 235310"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.66493572),
        dec: Angle.Degrees(-51.47453780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69706",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69706"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.01557694),
        dec: Angle.Degrees(-51.47313211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104839"},
        {"Hipparcos Number", "HIP 58859"},
        {"Geneva Identification System", "GEN# +1.00104839"},
        {"Smithsonian Astrophysical Observation", "SAO 239632"},
    },
    visualMagnitude: 6.48,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.06973585),
        dec: Angle.Degrees(-51.47248922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57254",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57254"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.09993430),
        dec: Angle.Degrees(-51.47123159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102851"},
        {"Hipparcos Number", "HIP 57724"},
        {"Geneva Identification System", "GEN# +1.00102851"},
        {"Smithsonian Astrophysical Observation", "SAO 239417"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.56843051),
        dec: Angle.Degrees(-51.47065583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117920"},
        {"Hipparcos Number", "HIP 66245"},
        {"Smithsonian Astrophysical Observation", "SAO 240960"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.66092264),
        dec: Angle.Degrees(-51.46997632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56380"},
        {"Hipparcos Number", "HIP 34961"},
        {"Geneva Identification System", "GEN# +1.00056380"},
        {"Smithsonian Astrophysical Observation", "SAO 235028"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.50481553),
        dec: Angle.Degrees(-51.46959362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 246.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217487"},
        {"Henry Draper 2", "HD 217487A"},
        {"Hipparcos Number", "HIP 113701"},
        {"Smithsonian Astrophysical Observation", "SAO 247685"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.42578112),
        dec: Angle.Degrees(-51.46815737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41187"},
        {"Hipparcos Number", "HIP 28462"},
        {"Smithsonian Astrophysical Observation", "SAO 234247"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.14443015),
        dec: Angle.Degrees(-51.46801856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66027"},
        {"Hipparcos Number", "HIP 39033"},
        {"Celescope Catalog", "CEL 2129"},
        {"Smithsonian Astrophysical Observation", "SAO 235655"},
    },
    visualMagnitude: 7.34,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.79277954),
        dec: Angle.Degrees(-51.46592192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175606"},
        {"Hipparcos Number", "HIP 93186"},
        {"Geneva Identification System", "GEN# +1.00175606"},
        {"Smithsonian Astrophysical Observation", "SAO 245843"},
        {"Wilson Evans Batten Catalogue", "WEB 16150"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.71381601),
        dec: Angle.Degrees(-51.46529895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35531",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35531"},
    },
    visualMagnitude: 11.19,
    bvColour: 1.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.99629880),
        dec: Angle.Degrees(-51.46283550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 170.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182438"},
        {"Hipparcos Number", "HIP 95642"},
        {"Smithsonian Astrophysical Observation", "SAO 246105"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.81796074),
        dec: Angle.Degrees(-51.46189399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78358"},
        {"Hipparcos Number", "HIP 44643"},
        {"Smithsonian Astrophysical Observation", "SAO 236594"},
    },
    visualMagnitude: 8.58,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.45119449),
        dec: Angle.Degrees(-51.46081369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105012"},
        {"Hipparcos Number", "HIP 58964"},
        {"Smithsonian Astrophysical Observation", "SAO 239652"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.35983605),
        dec: Angle.Degrees(-51.46056781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205680"},
        {"Hipparcos Number", "HIP 106864"},
        {"Smithsonian Astrophysical Observation", "SAO 247119"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.65731283),
        dec: Angle.Degrees(-51.46022533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19614"},
        {"Hipparcos Number", "HIP 14507"},
        {"Smithsonian Astrophysical Observation", "SAO 232998"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.83336749),
        dec: Angle.Degrees(-51.45961512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214707"},
        {"Hipparcos Number", "HIP 111989"},
        {"Smithsonian Astrophysical Observation", "SAO 247546"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.26269171),
        dec: Angle.Degrees(-51.45879884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69859"},
        {"Hipparcos Number", "HIP 40538"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.15766767),
        dec: Angle.Degrees(-51.45868520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130978"},
        {"Hipparcos Number", "HIP 72812"},
        {"Geneva Identification System", "GEN# +1.00130978"},
        {"Smithsonian Astrophysical Observation", "SAO 242087"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.23151786),
        dec: Angle.Degrees(-51.45781960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133325"},
        {"Hipparcos Number", "HIP 73866"},
        {"Smithsonian Astrophysical Observation", "SAO 242218"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.45266669),
        dec: Angle.Degrees(-51.45721278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148811"},
        {"Hipparcos Number", "HIP 81044"},
        {"Smithsonian Astrophysical Observation", "SAO 243939"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.29397995),
        dec: Angle.Degrees(-51.45517693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32729"},
        {"Hipparcos Number", "HIP 23454"},
        {"Geneva Identification System", "GEN# +1.00032729"},
        {"Smithsonian Astrophysical Observation", "SAO 233794"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.62011848),
        dec: Angle.Degrees(-51.45505653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107994",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107994"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.18999358),
        dec: Angle.Degrees(-51.45359372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 304.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31874"},
        {"Hipparcos Number", "HIP 22975"},
        {"Smithsonian Astrophysical Observation", "SAO 233745"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.16141479),
        dec: Angle.Degrees(-51.45207256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110909"},
        {"Hipparcos Number", "HIP 62293"},
        {"Geneva Identification System", "GEN# +1.00110909"},
        {"Smithsonian Astrophysical Observation", "SAO 240226"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.47553345),
        dec: Angle.Degrees(-51.45080111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108257"},
        {"Hipparcos Number", "HIP 60710"},
        {"Geneva Identification System", "GEN# +1.00108257"},
        {"Smithsonian Astrophysical Observation", "SAO 239948"},
        {"Wilson Evans Batten Catalogue", "WEB 10798"},
    },
    visualMagnitude: 4.82,
    bvColour: -0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.63245078),
        dec: Angle.Degrees(-51.45061150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190444"},
        {"Hipparcos Number", "HIP 99114"},
        {"Smithsonian Astrophysical Observation", "SAO 246442"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.83011918),
        dec: Angle.Degrees(-51.45036446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29780"},
        {"Hipparcos Number", "HIP 21643"},
        {"Smithsonian Astrophysical Observation", "SAO 233602"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.72309246),
        dec: Angle.Degrees(-51.45029002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68579",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68579"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.59338356),
        dec: Angle.Degrees(-51.44915298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78025"},
        {"Hipparcos Number", "HIP 44496"},
        {"Celescope Catalog", "CEL 3170"},
        {"Geneva Identification System", "GEN# +1.00078025"},
        {"Smithsonian Astrophysical Observation", "SAO 236551"},
    },
    visualMagnitude: 8.60,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.98961039),
        dec: Angle.Degrees(-51.44898137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65867"},
        {"Hipparcos Number", "HIP 38963"},
        {"Geneva Identification System", "GEN# +1.00065867"},
        {"Smithsonian Astrophysical Observation", "SAO 235646"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.58946876),
        dec: Angle.Degrees(-51.44857837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161439"},
        {"Hipparcos Number", "HIP 87137"},
        {"Geneva Identification System", "GEN# +1.00161439"},
        {"Smithsonian Astrophysical Observation", "SAO 245039"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.05962560),
        dec: Angle.Degrees(-51.44745356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131705"},
        {"Hipparcos Number", "HIP 73154"},
        {"Geneva Identification System", "GEN# +1.00131705"},
        {"Smithsonian Astrophysical Observation", "SAO 242128"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.25808436),
        dec: Angle.Degrees(-51.44720732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111170"},
        {"Hipparcos Number", "HIP 62445"},
        {"Geneva Identification System", "GEN# +1.00111170"},
        {"Smithsonian Astrophysical Observation", "SAO 240263"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.96622686),
        dec: Angle.Degrees(-51.44390842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44206"},
        {"Hipparcos Number", "HIP 29903"},
        {"Renson", "Renson 11720"},
        {"Smithsonian Astrophysical Observation", "SAO 234426"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.44085032),
        dec: Angle.Degrees(-51.44130033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16931"},
        {"Hipparcos Number", "HIP 12517"},
        {"Geneva Identification System", "GEN# +1.00016931"},
        {"Smithsonian Astrophysical Observation", "SAO 232859"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.27612492),
        dec: Angle.Degrees(-51.44119114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 315.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 118.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39323",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39323"},
        {"Geneva Identification System", "GEN# -0.05102813"},
        {"Smithsonian Astrophysical Observation", "SAO 235697"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.59727082),
        dec: Angle.Degrees(-51.44071840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10078"},
        {"Hipparcos Number", "HIP 7556"},
        {"Smithsonian Astrophysical Observation", "SAO 232480"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.33900984),
        dec: Angle.Degrees(-51.44059506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66507"},
        {"Hipparcos Number", "HIP 39227"},
        {"Smithsonian Astrophysical Observation", "SAO 235685"},
    },
    visualMagnitude: 7.67,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.34826820),
        dec: Angle.Degrees(-51.43956137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80282"},
        {"Hipparcos Number", "HIP 45548"},
        {"Celescope Catalog", "CEL 3254"},
        {"Geneva Identification System", "GEN# +1.00080282"},
        {"Renson", "Renson 22830"},
        {"Smithsonian Astrophysical Observation", "SAO 236806"},
    },
    visualMagnitude: 7.60,
    bvColour: -0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.25178753),
        dec: Angle.Degrees(-51.43886261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13203"},
        {"Hipparcos Number", "HIP 9913"},
        {"Geneva Identification System", "GEN# +1.00013203"},
        {"Smithsonian Astrophysical Observation", "SAO 232641"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.89629242),
        dec: Angle.Degrees(-51.43638721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78801"},
        {"Hipparcos Number", "HIP 44847"},
        {"Geneva Identification System", "GEN# +1.00078801"},
        {"Smithsonian Astrophysical Observation", "SAO 236640"},
        {"Wilson Evans Batten Catalogue", "WEB 8570"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.06565928),
        dec: Angle.Degrees(-51.43629339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33132"},
        {"Hipparcos Number", "HIP 23678"},
        {"Geneva Identification System", "GEN# +1.00033132"},
        {"Smithsonian Astrophysical Observation", "SAO 233818"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.34561388),
        dec: Angle.Degrees(-51.43390063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 145.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119834"},
        {"Hipparcos Number", "HIP 67234"},
        {"Geneva Identification System", "GEN# +1.00119834"},
        {"Smithsonian Astrophysical Observation", "SAO 241157"},
        {"Wilson Evans Batten Catalogue", "WEB 11830"},
    },
    visualMagnitude: 4.64,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.66403516),
        dec: Angle.Degrees(-51.43269771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194518"},
        {"Hipparcos Number", "HIP 100967"},
        {"Smithsonian Astrophysical Observation", "SAO 246598"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.06674792),
        dec: Angle.Degrees(-51.43063267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92014",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92014"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.32366554),
        dec: Angle.Degrees(-51.43042675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -280.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47602"},
        {"Hipparcos Number", "HIP 31590"},
        {"Smithsonian Astrophysical Observation", "SAO 234606"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.16976030),
        dec: Angle.Degrees(-51.42989090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147518"},
        {"Hipparcos Number", "HIP 80423"},
        {"Geneva Identification System", "GEN# +1.00147518"},
        {"Smithsonian Astrophysical Observation", "SAO 243768"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.23548859),
        dec: Angle.Degrees(-51.42903224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -170.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91927"},
        {"Hipparcos Number", "HIP 51868"},
        {"Fundamental Katalog 5th Edition", "FK5 4942"},
        {"Smithsonian Astrophysical Observation", "SAO 238226"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.96233953),
        dec: Angle.Degrees(-51.42848043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94520"},
        {"Hipparcos Number", "HIP 53278"},
        {"Smithsonian Astrophysical Observation", "SAO 238578"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.44632275),
        dec: Angle.Degrees(-51.42731188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34962"},
        {"Hipparcos Number", "HIP 24754"},
        {"Geneva Identification System", "GEN# +1.00034962"},
        {"Smithsonian Astrophysical Observation", "SAO 233922"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.61753278),
        dec: Angle.Degrees(-51.42661173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168360"},
        {"Hipparcos Number", "HIP 90014"},
        {"Geneva Identification System", "GEN# +1.00168360"},
        {"Smithsonian Astrophysical Observation", "SAO 245429"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.50844435),
        dec: Angle.Degrees(-51.42657937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94140"},
        {"Hipparcos Number", "HIP 53030"},
        {"Smithsonian Astrophysical Observation", "SAO 238528"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.74873202),
        dec: Angle.Degrees(-51.42602692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23295"},
        {"Hipparcos Number", "HIP 17255"},
        {"Geneva Identification System", "GEN# +1.00023295"},
        {"Smithsonian Astrophysical Observation", "SAO 233227"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.43531081),
        dec: Angle.Degrees(-51.42577997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113133"},
        {"Hipparcos Number", "HIP 63611"},
        {"Smithsonian Astrophysical Observation", "SAO 240493"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.55568501),
        dec: Angle.Degrees(-51.42563279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101328"},
        {"Hipparcos Number", "HIP 56853"},
        {"Smithsonian Astrophysical Observation", "SAO 239262"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.84584138),
        dec: Angle.Degrees(-51.42464317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195959"},
        {"Hipparcos Number", "HIP 101673"},
        {"Smithsonian Astrophysical Observation", "SAO 246657"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.13742513),
        dec: Angle.Degrees(-51.42234175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61597"},
        {"Hipparcos Number", "HIP 37110"},
        {"Geneva Identification System", "GEN# +1.00061597"},
        {"Smithsonian Astrophysical Observation", "SAO 235368"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.38385941),
        dec: Angle.Degrees(-51.42132111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102495",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102495"},
        {"Geneva Identification System", "GEN# -0.02316484"},
    },
    visualMagnitude: 10.73,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.57602566),
        dec: Angle.Degrees(-23.07972086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 210.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -331.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163835"},
        {"Hipparcos Number", "HIP 88222"},
        {"Smithsonian Astrophysical Observation", "SAO 245169"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.24175243),
        dec: Angle.Degrees(-51.41880304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177300"},
        {"Hipparcos Number", "HIP 93844"},
        {"Geneva Identification System", "GEN# +1.00177300"},
        {"Smithsonian Astrophysical Observation", "SAO 245923"},
        {"Wilson Evans Batten Catalogue", "WEB 16318"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.65880929),
        dec: Angle.Degrees(-51.41756176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97202",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97202"},
        {"Geneva Identification System", "GEN# +6.20145043"},
    },
    visualMagnitude: 12.96,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)45, 17.5800),
        dec: Angle.DegreesMinutesSeconds((int)-51, (int)24, 58.700)
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
    primaryId: "HIP 59475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105995"},
        {"Hipparcos Number", "HIP 59475"},
        {"Smithsonian Astrophysical Observation", "SAO 239741"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.98305663),
        dec: Angle.Degrees(-51.41315863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208261"},
        {"Hipparcos Number", "HIP 108300"},
        {"Smithsonian Astrophysical Observation", "SAO 247235"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.10811365),
        dec: Angle.Degrees(-51.41266017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129351"},
        {"Hipparcos Number", "HIP 72013"},
        {"Smithsonian Astrophysical Observation", "SAO 241949"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.94101274),
        dec: Angle.Degrees(-51.41179428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19254"},
        {"Hipparcos Number", "HIP 14257"},
        {"Geneva Identification System", "GEN# +1.00019254"},
        {"Smithsonian Astrophysical Observation", "SAO 232978"},
        {"Wilson Evans Batten Catalogue", "WEB 2794"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.95911779),
        dec: Angle.Degrees(-51.40976689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102657"},
        {"Hipparcos Number", "HIP 57628"},
        {"Geneva Identification System", "GEN# +1.00102657"},
        {"Smithsonian Astrophysical Observation", "SAO 239389"},
    },
    visualMagnitude: 7.74,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.24682489),
        dec: Angle.Degrees(-51.40858742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90643"},
        {"Hipparcos Number", "HIP 51136"},
        {"Geneva Identification System", "GEN# +1.00090643"},
        {"Smithsonian Astrophysical Observation", "SAO 238066"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.69717077),
        dec: Angle.Degrees(-51.40853142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 298374"},
        {"Hipparcos Number", "HIP 46116"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.06867374),
        dec: Angle.Degrees(-51.40758169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42816"},
        {"Hipparcos Number", "HIP 29247"},
        {"Smithsonian Astrophysical Observation", "SAO 234354"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.49693229),
        dec: Angle.Degrees(-51.40635978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131299"},
        {"Hipparcos Number", "HIP 72960"},
        {"Geneva Identification System", "GEN# +1.00131299"},
        {"Smithsonian Astrophysical Observation", "SAO 242107"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.65844649),
        dec: Angle.Degrees(-51.40631078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57949"},
        {"Hipparcos Number", "HIP 35603"},
        {"Smithsonian Astrophysical Observation", "SAO 235121"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.20821260),
        dec: Angle.Degrees(-51.40472371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2203"},
        {"Hipparcos Number", "HIP 2020"},
        {"Fundamental Katalog 5th Edition", "FK5 4042"},
        {"Geneva Identification System", "GEN# +1.00002203"},
        {"Smithsonian Astrophysical Observation", "SAO 232035"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.40945153),
        dec: Angle.Degrees(-51.40296978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53047"},
        {"Hipparcos Number", "HIP 33779"},
        {"Fundamental Katalog 5th Edition", "FK5 2544"},
        {"Geneva Identification System", "GEN# +1.00053047"},
        {"Smithsonian Astrophysical Observation", "SAO 234854"},
        {"Wilson Evans Batten Catalogue", "WEB 6781"},
    },
    visualMagnitude: 5.14,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.21460498),
        dec: Angle.Degrees(-51.40263360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59468"},
        {"Hipparcos Number", "HIP 36210"},
        {"Geneva Identification System", "GEN# +1.00059468"},
        {"Smithsonian Astrophysical Observation", "SAO 235206"},
        {"Wilson Evans Batten Catalogue", "WEB 7212"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.85722164),
        dec: Angle.Degrees(-51.40259511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -285.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 396"},
        {"Hipparcos Number", "HIP 681"},
        {"Geneva Identification System", "GEN# +1.00000396"},
        {"Smithsonian Astrophysical Observation", "SAO 231939"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.10546740),
        dec: Angle.Degrees(-51.40075918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121007"},
        {"Hipparcos Number", "HIP 67885"},
        {"Geneva Identification System", "GEN# +1.00121007"},
        {"Smithsonian Astrophysical Observation", "SAO 241270"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.55246871),
        dec: Angle.Degrees(-51.40000779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 297870"},
        {"Hipparcos Number", "HIP 49958"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.99926929),
        dec: Angle.Degrees(-51.39941499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212423"},
        {"Hipparcos Number", "HIP 110673"},
        {"Fundamental Katalog 5th Edition", "FK5 3792"},
        {"Geneva Identification System", "GEN# +1.00212423"},
        {"Smithsonian Astrophysical Observation", "SAO 247443"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.31990754),
        dec: Angle.Degrees(-51.39825821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161953"},
        {"Hipparcos Number", "HIP 87376"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.78765199),
        dec: Angle.Degrees(-51.39711681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150071"},
        {"Hipparcos Number", "HIP 81692"},
        {"Smithsonian Astrophysical Observation", "SAO 244066"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.32189136),
        dec: Angle.Degrees(-51.39702403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78987",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78987"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.84485043),
        dec: Angle.Degrees(-51.39552182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145075"},
        {"Hipparcos Number", "HIP 79329"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.85633492),
        dec: Angle.Degrees(-51.39339974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111314"},
        {"Hipparcos Number", "HIP 62547"},
        {"Smithsonian Astrophysical Observation", "SAO 240276"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.23355659),
        dec: Angle.Degrees(-51.39174117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137679"},
        {"Hipparcos Number", "HIP 75837"},
        {"Geneva Identification System", "GEN# +1.00137679"},
        {"Smithsonian Astrophysical Observation", "SAO 242606"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.37864223),
        dec: Angle.Degrees(-51.39078429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42719"},
        {"Hipparcos Number", "HIP 29193"},
        {"Geneva Identification System", "GEN# +1.00042719"},
        {"Smithsonian Astrophysical Observation", "SAO 234350"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.36550276),
        dec: Angle.Degrees(-51.38954087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79330",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79330"},
    },
    visualMagnitude: 10.80,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.85702541),
        dec: Angle.Degrees(-51.38935221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169151"},
        {"Hipparcos Number", "HIP 90340"},
        {"Smithsonian Astrophysical Observation", "SAO 245464"},
    },
    visualMagnitude: 7.76,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.48772538),
        dec: Angle.Degrees(-51.38864711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58053",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58053"},
        {"Geneva Identification System", "GEN# -0.05006462"},
    },
    visualMagnitude: 10.97,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.60388905),
        dec: Angle.Degrees(-51.38729640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -256.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 248.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160846"},
        {"Hipparcos Number", "HIP 86860"},
        {"Smithsonian Astrophysical Observation", "SAO 244993"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.20957812),
        dec: Angle.Degrees(-51.38643611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107579"},
        {"Hipparcos Number", "HIP 60318"},
        {"Geneva Identification System", "GEN# +1.00107579"},
        {"Smithsonian Astrophysical Observation", "SAO 239885"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.51924566),
        dec: Angle.Degrees(-51.38585619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213605"},
        {"Hipparcos Number", "HIP 111358"},
        {"Smithsonian Astrophysical Observation", "SAO 247488"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.40641425),
        dec: Angle.Degrees(-51.38567515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54289"},
        {"Hipparcos Number", "HIP 34209"},
        {"Smithsonian Astrophysical Observation", "SAO 234911"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.39618232),
        dec: Angle.Degrees(-51.38408731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127124"},
        {"Hipparcos Number", "HIP 71001"},
        {"Geneva Identification System", "GEN# +1.00127124"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.81719590),
        dec: Angle.Degrees(-51.38218111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88714"},
        {"Hipparcos Number", "HIP 50010"},
        {"Smithsonian Astrophysical Observation", "SAO 237788"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.14396997),
        dec: Angle.Degrees(-51.38109979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3213",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3213"},
        {"Geneva Identification System", "GEN# -0.05200078"},
        {"Wilson Evans Batten Catalogue", "WEB 575"},
    },
    visualMagnitude: 11.27,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.21828874),
        dec: Angle.Degrees(-51.37979488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 213.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -194.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171633"},
        {"Hipparcos Number", "HIP 91427"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.67985864),
        dec: Angle.Degrees(-51.37884712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15773"},
        {"Hipparcos Number", "HIP 11661"},
        {"Geneva Identification System", "GEN# +1.00015773"},
        {"Smithsonian Astrophysical Observation", "SAO 232793"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.59565433),
        dec: Angle.Degrees(-51.37724705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224147"},
        {"Hipparcos Number", "HIP 117961"},
        {"Geneva Identification System", "GEN# +1.00224147"},
        {"Smithsonian Astrophysical Observation", "SAO 248061"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.90569817),
        dec: Angle.Degrees(-51.37405266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 158.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26097"},
        {"Hipparcos Number", "HIP 19077"},
        {"Geneva Identification System", "GEN# +1.00026097"},
        {"Smithsonian Astrophysical Observation", "SAO 233395"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.33648122),
        dec: Angle.Degrees(-51.37230483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 99.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190688"},
        {"Hipparcos Number", "HIP 99222"},
        {"Smithsonian Astrophysical Observation", "SAO 246456"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.13612683),
        dec: Angle.Degrees(-51.37226895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104870"},
        {"Hipparcos Number", "HIP 58886"},
        {"Smithsonian Astrophysical Observation", "SAO 239638"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.16337351),
        dec: Angle.Degrees(-51.37024408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205282"},
        {"Hipparcos Number", "HIP 106634"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.98325119),
        dec: Angle.Degrees(-51.36898670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63276"},
        {"Hipparcos Number", "HIP 37845"},
        {"Geneva Identification System", "GEN# +1.00063276"},
        {"Smithsonian Astrophysical Observation", "SAO 235485"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.37183604),
        dec: Angle.Degrees(-51.36897795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84493"},
        {"Hipparcos Number", "HIP 47747"},
        {"Celescope Catalog", "CEL 3372"},
        {"Geneva Identification System", "GEN# +1.00084493"},
        {"Smithsonian Astrophysical Observation", "SAO 237272"},
    },
    visualMagnitude: 7.72,
    bvColour: -0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.01092863),
        dec: Angle.Degrees(-51.36752309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207228"},
        {"Hipparcos Number", "HIP 107697"},
        {"Smithsonian Astrophysical Observation", "SAO 247192"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.24243115),
        dec: Angle.Degrees(-51.36604953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112054"},
        {"Hipparcos Number", "HIP 62968"},
        {"Geneva Identification System", "GEN# +1.00112054"},
        {"Smithsonian Astrophysical Observation", "SAO 240360"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.54875779),
        dec: Angle.Degrees(-51.36571622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100477"},
        {"Hipparcos Number", "HIP 56368"},
        {"Smithsonian Astrophysical Observation", "SAO 239166"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.32697598),
        dec: Angle.Degrees(-51.36481939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108236"},
        {"Hipparcos Number", "HIP 60689"},
        {"Geneva Identification System", "GEN# +1.00108236"},
        {"Smithsonian Astrophysical Observation", "SAO 239945"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.57482482),
        dec: Angle.Degrees(-51.36271650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70157",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70157"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.32257798),
        dec: Angle.Degrees(-51.36176111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59484"},
        {"Hipparcos Number", "HIP 36228"},
        {"Smithsonian Astrophysical Observation", "SAO 235210"},
    },
    visualMagnitude: 8.70,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.90541113),
        dec: Angle.Degrees(-51.35967974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105920"},
        {"Hipparcos Number", "HIP 59439"},
        {"Geneva Identification System", "GEN# +1.00105920"},
        {"Smithsonian Astrophysical Observation", "SAO 239735"},
    },
    visualMagnitude: 6.23,
    bvColour: 0.816,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.88196180),
        dec: Angle.Degrees(-51.35917843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -199.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220755"},
        {"Hipparcos Number", "HIP 115731"},
        {"Smithsonian Astrophysical Observation", "SAO 247876"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.69883938),
        dec: Angle.Degrees(-51.35891754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34375"},
        {"Hipparcos Number", "HIP 24412"},
        {"Smithsonian Astrophysical Observation", "SAO 233888"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.55764454),
        dec: Angle.Degrees(-51.35743938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217962"},
        {"Hipparcos Number", "HIP 113984"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.25331497),
        dec: Angle.Degrees(-51.35577229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105506",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105506"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.53531512),
        dec: Angle.Degrees(-51.35497835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 205.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64825",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64825"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.33270246),
        dec: Angle.Degrees(-51.35380926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96008"},
        {"Hipparcos Number", "HIP 54060"},
        {"Geneva Identification System", "GEN# +1.00096008"},
        {"Smithsonian Astrophysical Observation", "SAO 238720"},
        {"Wilson Evans Batten Catalogue", "WEB 9778"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.92838949),
        dec: Angle.Degrees(-51.35270345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -207.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200979"},
        {"Hipparcos Number", "HIP 104370"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.16146238),
        dec: Angle.Degrees(-51.35268642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222759"},
        {"Hipparcos Number", "HIP 117037"},
        {"Smithsonian Astrophysical Observation", "SAO 247996"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.88534952),
        dec: Angle.Degrees(-51.34887440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26444"},
        {"Hipparcos Number", "HIP 19312"},
        {"Smithsonian Astrophysical Observation", "SAO 233409"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.09597184),
        dec: Angle.Degrees(-51.34887020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214989"},
        {"Hipparcos Number", "HIP 112160"},
        {"Smithsonian Astrophysical Observation", "SAO 247555"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.75263103),
        dec: Angle.Degrees(-51.34580169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171741"},
        {"Hipparcos Number", "HIP 91455"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.79035254),
        dec: Angle.Degrees(-51.34413110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69532",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69532"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.51456473),
        dec: Angle.Degrees(-51.34391358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80090"},
        {"Hipparcos Number", "HIP 45466"},
        {"Smithsonian Astrophysical Observation", "SAO 236780"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.97758694),
        dec: Angle.Degrees(-51.34330654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75659"},
        {"Hipparcos Number", "HIP 43295"},
        {"Celescope Catalog", "CEL 2959"},
        {"Smithsonian Astrophysical Observation", "SAO 236304"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.29240249),
        dec: Angle.Degrees(-51.34325598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5924"},
        {"Hipparcos Number", "HIP 4673"},
        {"Geneva Identification System", "GEN# +1.00005924"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.99988491),
        dec: Angle.Degrees(-51.34321367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82023",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82023"},
    },
    visualMagnitude: 10.15,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.32964420),
        dec: Angle.Degrees(-51.34259326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127314"},
        {"Hipparcos Number", "HIP 71089"},
        {"Smithsonian Astrophysical Observation", "SAO 241775"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.07143232),
        dec: Angle.Degrees(-51.33864011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65425"},
        {"Hipparcos Number", "HIP 38770"},
        {"Smithsonian Astrophysical Observation", "SAO 235630"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.04813586),
        dec: Angle.Degrees(-51.33844426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148829"},
        {"Hipparcos Number", "HIP 81054"},
        {"Smithsonian Astrophysical Observation", "SAO 243940"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.31794520),
        dec: Angle.Degrees(-51.33692688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86352"},
        {"Hipparcos Number", "HIP 48730"},
        {"Celescope Catalog", "CEL 3409"},
        {"Fundamental Katalog 5th Edition", "FK5 2797"},
        {"Geneva Identification System", "GEN# +1.00086352"},
        {"Smithsonian Astrophysical Observation", "SAO 237514"},
        {"Wilson Evans Batten Catalogue", "WEB 9064"},
    },
    visualMagnitude: 6.39,
    bvColour: -0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.09125711),
        dec: Angle.Degrees(-51.33615432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84753",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84753"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.86315083),
        dec: Angle.Degrees(-51.33441843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 297781"},
        {"Hipparcos Number", "HIP 49564"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.78517122),
        dec: Angle.Degrees(-51.33204323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57396",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57396"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.49997961),
        dec: Angle.Degrees(-51.33184548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205449"},
        {"Hipparcos Number", "HIP 106721"},
        {"Smithsonian Astrophysical Observation", "SAO 247112"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.26470926),
        dec: Angle.Degrees(-51.33098229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35965",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35965"},
        {"Geneva Identification System", "GEN# +6.00102834"},
        {"Geneva Identification System 2", "GEN# -0.05102481"},
        {"Wilson Evans Batten Catalogue", "WEB 7163"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.20053973),
        dec: Angle.Degrees(-51.32839478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 186.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 389.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25495"},
        {"Hipparcos Number", "HIP 18713"},
        {"Geneva Identification System", "GEN# +1.00025495"},
        {"Smithsonian Astrophysical Observation", "SAO 233356"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.13265772),
        dec: Angle.Degrees(-51.32826007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 161.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7856"},
        {"Hipparcos Number", "HIP 6020"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.33584661),
        dec: Angle.Degrees(-51.32550597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19330"},
        {"Hipparcos Number", "HIP 14307"},
        {"Geneva Identification System", "GEN# +1.00019330"},
        {"Smithsonian Astrophysical Observation", "SAO 232983"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.13775258),
        dec: Angle.Degrees(-51.32227515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49191"},
        {"Hipparcos Number", "HIP 32294"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.12491771),
        dec: Angle.Degrees(-51.32224922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219533"},
        {"Hipparcos Number", "HIP 114950"},
        {"Fundamental Katalog 5th Edition", "FK5 6058"},
        {"Geneva Identification System", "GEN# +1.00219533"},
        {"Smithsonian Astrophysical Observation", "SAO 247811"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.24361152),
        dec: Angle.Degrees(-51.31909326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14313",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14313"},
        {"Smithsonian Astrophysical Observation", "SAO 232984"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.857,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.15377851),
        dec: Angle.Degrees(-51.31869584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35596"},
        {"Hipparcos Number", "HIP 25172"},
        {"Renson", "Renson 9170"},
        {"Smithsonian Astrophysical Observation", "SAO 233953"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.76818383),
        dec: Angle.Degrees(-51.31682240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23720"},
        {"Hipparcos Number", "HIP 17516"},
        {"Smithsonian Astrophysical Observation", "SAO 233256"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.25858369),
        dec: Angle.Degrees(-51.31671122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215789"},
        {"Hipparcos Number", "HIP 112623"},
        {"Fundamental Katalog 5th Edition", "FK5 860"},
        {"Geneva Identification System", "GEN# +1.00215789"},
        {"Smithsonian Astrophysical Observation", "SAO 247593"},
        {"Wilson Evans Batten Catalogue", "WEB 20075"},
    },
    visualMagnitude: 3.49,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.13832136),
        dec: Angle.Degrees(-51.31670354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129624"},
        {"Hipparcos Number", "HIP 72135"},
        {"Smithsonian Astrophysical Observation", "SAO 241976"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.32852492),
        dec: Angle.Degrees(-51.31489117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103125"},
        {"Hipparcos Number", "HIP 57885"},
        {"Smithsonian Astrophysical Observation", "SAO 239445"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.07594241),
        dec: Angle.Degrees(-51.31470573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106323"},
        {"Hipparcos Number", "HIP 59657"},
        {"Geneva Identification System", "GEN# +1.00106323"},
        {"Smithsonian Astrophysical Observation", "SAO 239777"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.52273939),
        dec: Angle.Degrees(-51.31436924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87652"},
        {"Hipparcos Number", "HIP 49394"},
        {"Smithsonian Astrophysical Observation", "SAO 237675"},
    },
    visualMagnitude: 6.23,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.25776152),
        dec: Angle.Degrees(-51.31364777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169861"},
        {"Hipparcos Number", "HIP 90608"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.33732861),
        dec: Angle.Degrees(-51.31257355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21176"},
        {"Hipparcos Number", "HIP 15747"},
        {"Geneva Identification System", "GEN# +1.00021176"},
        {"Smithsonian Astrophysical Observation", "SAO 233089"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.71957348),
        dec: Angle.Degrees(-51.31234985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114078"},
        {"Hipparcos Number", "HIP 64146"},
        {"Smithsonian Astrophysical Observation", "SAO 240594"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.20249664),
        dec: Angle.Degrees(-51.31122304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151247"},
        {"Hipparcos Number", "HIP 82294"},
        {"Smithsonian Astrophysical Observation", "SAO 244161"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.22620450),
        dec: Angle.Degrees(-51.30797346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15591"},
        {"Hipparcos Number", "HIP 11530"},
        {"Geneva Identification System", "GEN# +1.00015591"},
        {"Smithsonian Astrophysical Observation", "SAO 232784"},
        {"Wilson Evans Batten Catalogue", "WEB 2407"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.17055050),
        dec: Angle.Degrees(-51.30401489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211089"},
        {"Hipparcos Number", "HIP 109940"},
        {"Renson", "Renson 58620"},
        {"Smithsonian Astrophysical Observation", "SAO 247383"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.00166596),
        dec: Angle.Degrees(-51.30391755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54609"},
        {"Hipparcos Number", "HIP 34307"},
        {"Smithsonian Astrophysical Observation", "SAO 234928"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.69140532),
        dec: Angle.Degrees(-51.30326014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42009"},
        {"Hipparcos Number", "HIP 28859"},
        {"Smithsonian Astrophysical Observation", "SAO 234301"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.37865309),
        dec: Angle.Degrees(-51.30291175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105316"},
        {"Hipparcos Number", "HIP 59131"},
        {"Smithsonian Astrophysical Observation", "SAO 239682"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.88101634),
        dec: Angle.Degrees(-51.30175537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33873"},
        {"Hipparcos Number", "HIP 24098"},
        {"Geneva Identification System", "GEN# +1.00033873"},
        {"Smithsonian Astrophysical Observation", "SAO 233860"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.64185054),
        dec: Angle.Degrees(-51.30170845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 102.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136912"},
        {"Hipparcos Number", "HIP 75498"},
        {"Smithsonian Astrophysical Observation", "SAO 242496"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.33193386),
        dec: Angle.Degrees(-51.30110605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55788"},
        {"Hipparcos Number", "HIP 34755"},
        {"Smithsonian Astrophysical Observation", "SAO 235001"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.92047531),
        dec: Angle.Degrees(-51.29823851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20765"},
        {"Hipparcos Number", "HIP 15400"},
        {"Geneva Identification System", "GEN# +1.00020765"},
        {"Smithsonian Astrophysical Observation", "SAO 233069"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.64406220),
        dec: Angle.Degrees(-51.29697656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197749"},
        {"Hipparcos Number", "HIP 102628"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.94622044),
        dec: Angle.Degrees(-51.29632658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28564"},
        {"Hipparcos Number", "HIP 20813"},
        {"Smithsonian Astrophysical Observation", "SAO 233529"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.89657721),
        dec: Angle.Degrees(-51.29583712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116994"},
        {"Hipparcos Number", "HIP 65715"},
        {"Geneva Identification System", "GEN# +1.00116994"},
        {"Smithsonian Astrophysical Observation", "SAO 240869"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.09218473),
        dec: Angle.Degrees(-51.29217912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87083"},
        {"Hipparcos Number", "HIP 49107"},
        {"Smithsonian Astrophysical Observation", "SAO 237601"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.32823741),
        dec: Angle.Degrees(-51.28918601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23421"},
        {"Hipparcos Number", "HIP 17343"},
        {"Smithsonian Astrophysical Observation", "SAO 233235"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.67918813),
        dec: Angle.Degrees(-51.28676316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115529"},
        {"Hipparcos Number", "HIP 64933"},
        {"Celescope Catalog", "CEL 4229"},
        {"Geneva Identification System", "GEN# +1.00115529"},
        {"Renson", "Renson 33390"},
        {"Smithsonian Astrophysical Observation", "SAO 240721"},
        {"Wilson Evans Batten Catalogue", "WEB 11477"},
    },
    visualMagnitude: 6.18,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.64538086),
        dec: Angle.Degrees(-51.28574682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88541"},
        {"Hipparcos Number", "HIP 49896"},
        {"Smithsonian Astrophysical Observation", "SAO 237765"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.81345865),
        dec: Angle.Degrees(-51.28466961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116038"},
        {"Hipparcos Number", "HIP 65219"},
        {"Smithsonian Astrophysical Observation", "SAO 240778"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.48818828),
        dec: Angle.Degrees(-51.28221363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134396"},
        {"Hipparcos Number", "HIP 74335"},
        {"Smithsonian Astrophysical Observation", "SAO 242295"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.89392397),
        dec: Angle.Degrees(-51.28177186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34648"},
        {"Hipparcos Number", "HIP 24572"},
        {"Smithsonian Astrophysical Observation", "SAO 233901"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.06428498),
        dec: Angle.Degrees(-51.27984874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 91.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220471"},
        {"Hipparcos Number", "HIP 115554"},
        {"Smithsonian Astrophysical Observation", "SAO 247860"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.10617909),
        dec: Angle.Degrees(-51.27952444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30413"},
        {"Hipparcos Number", "HIP 22066"},
        {"Geneva Identification System", "GEN# +1.00030413"},
        {"Smithsonian Astrophysical Observation", "SAO 233663"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.19873950),
        dec: Angle.Degrees(-51.27833815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89979",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89979"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.37368805),
        dec: Angle.Degrees(-51.27811246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92377"},
        {"Hipparcos Number", "HIP 52125"},
        {"Smithsonian Astrophysical Observation", "SAO 238300"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.74739565),
        dec: Angle.Degrees(-51.27707028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8752"},
        {"Hipparcos Number", "HIP 6655"},
        {"Smithsonian Astrophysical Observation", "SAO 232416"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.33710023),
        dec: Angle.Degrees(-51.27637598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148077"},
        {"Hipparcos Number", "HIP 80661"},
        {"Geneva Identification System", "GEN# +1.00148077"},
        {"Smithsonian Astrophysical Observation", "SAO 243842"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.03372201),
        dec: Angle.Degrees(-51.27480009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200302"},
        {"Hipparcos Number", "HIP 104036"},
        {"Smithsonian Astrophysical Observation", "SAO 246850"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.15861957),
        dec: Angle.Degrees(-51.27409825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152023"},
        {"Hipparcos Number", "HIP 82637"},
        {"Smithsonian Astrophysical Observation", "SAO 244243"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.39004870),
        dec: Angle.Degrees(-51.27192276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98872"},
        {"Hipparcos Number", "HIP 55515"},
        {"Smithsonian Astrophysical Observation", "SAO 239001"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.55722340),
        dec: Angle.Degrees(-51.26938681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197506"},
        {"Hipparcos Number", "HIP 102492"},
        {"Smithsonian Astrophysical Observation", "SAO 246724"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.56327590),
        dec: Angle.Degrees(-51.26580966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199623"},
        {"Hipparcos Number", "HIP 103673"},
        {"Fundamental Katalog 5th Edition", "FK5 3673"},
        {"Geneva Identification System", "GEN# +1.00199623"},
        {"Smithsonian Astrophysical Observation", "SAO 246820"},
        {"Wilson Evans Batten Catalogue", "WEB 18868"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.08985065),
        dec: Angle.Degrees(-51.26563421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 132.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49689"},
        {"Hipparcos Number", "HIP 32494"},
        {"Geneva Identification System", "GEN# +1.00049689"},
        {"Smithsonian Astrophysical Observation", "SAO 234705"},
        {"Wilson Evans Batten Catalogue", "WEB 6554"},
    },
    visualMagnitude: 5.39,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.71955730),
        dec: Angle.Degrees(-51.26544940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101218"},
        {"Hipparcos Number", "HIP 56792"},
        {"Smithsonian Astrophysical Observation", "SAO 239248"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.64549439),
        dec: Angle.Degrees(-51.26531879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5783"},
        {"Hipparcos Number", "HIP 4588"},
        {"Fundamental Katalog 5th Edition", "FK5 4090"},
        {"Smithsonian Astrophysical Observation", "SAO 232245"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.68434319),
        dec: Angle.Degrees(-51.26524225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197891"},
        {"Hipparcos Number", "HIP 102710"},
        {"Smithsonian Astrophysical Observation", "SAO 246738"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.17274879),
        dec: Angle.Degrees(-51.26479592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57742",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57742"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.61525679),
        dec: Angle.Degrees(-51.26433888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73680"},
        {"Hipparcos Number", "HIP 42296"},
        {"Smithsonian Astrophysical Observation", "SAO 236128"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.34829154),
        dec: Angle.Degrees(-51.26170707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18397"},
        {"Hipparcos Number", "HIP 13618"},
        {"Fundamental Katalog 5th Edition", "FK5 4265"},
        {"Geneva Identification System", "GEN# +1.00018397"},
        {"Smithsonian Astrophysical Observation", "SAO 232939"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.86435631),
        dec: Angle.Degrees(-51.26070385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79"},
        {"Hipparcos Number", "HIP 469"},
        {"Smithsonian Astrophysical Observation", "SAO 231923"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.40103106),
        dec: Angle.Degrees(-51.26045604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23749"},
        {"Hipparcos Number", "HIP 17532"},
        {"Geneva Identification System", "GEN# +1.00023749"},
        {"Smithsonian Astrophysical Observation", "SAO 233259"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.30278040),
        dec: Angle.Degrees(-51.25991105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164804"},
        {"Hipparcos Number", "HIP 88613"},
        {"Smithsonian Astrophysical Observation", "SAO 245234"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.38646497),
        dec: Angle.Degrees(-51.25936383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 340"},
        {"Hipparcos Number", "HIP 644"},
        {"Smithsonian Astrophysical Observation", "SAO 231935"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.97877242),
        dec: Angle.Degrees(-51.25786512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134559"},
        {"Hipparcos Number", "HIP 74416"},
        {"Geneva Identification System", "GEN# +1.00134559"},
        {"Smithsonian Astrophysical Observation", "SAO 242310"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.12388987),
        dec: Angle.Degrees(-51.25709239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89137"},
        {"Hipparcos Number", "HIP 50253"},
        {"Geneva Identification System", "GEN# +1.00089137"},
        {"Smithsonian Astrophysical Observation", "SAO 237842"},
        {"Wilson Evans Batten Catalogue", "WEB 9232"},
    },
    visualMagnitude: 7.98,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.91705454),
        dec: Angle.Degrees(-51.25670789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83058"},
        {"Hipparcos Number", "HIP 46950"},
        {"Celescope Catalog", "CEL 3331"},
        {"Fundamental Katalog 5th Edition", "FK5 2764"},
        {"Geneva Identification System", "GEN# +1.00083058"},
        {"Smithsonian Astrophysical Observation", "SAO 237107"},
        {"Wilson Evans Batten Catalogue", "WEB 8850"},
    },
    visualMagnitude: 5.01,
    bvColour: -0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.53667204),
        dec: Angle.Degrees(-51.25528201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83226",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83226"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.12635125),
        dec: Angle.Degrees(-51.25449655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52466",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52466"},
    },
    visualMagnitude: 11.28,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.88035048),
        dec: Angle.Degrees(-51.25284754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82664"},
        {"Hipparcos Number", "HIP 46740"},
        {"Geneva Identification System", "GEN# +1.00082664"},
        {"Smithsonian Astrophysical Observation", "SAO 237070"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.89637498),
        dec: Angle.Degrees(-51.25194301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133135"},
        {"Hipparcos Number", "HIP 73772"},
        {"Geneva Identification System", "GEN# +1.00133135"},
        {"Smithsonian Astrophysical Observation", "SAO 242211"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.19560092),
        dec: Angle.Degrees(-51.25127230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106979"},
        {"Hipparcos Number", "HIP 59999"},
        {"Fundamental Katalog 5th Edition", "FK5 5088"},
        {"Smithsonian Astrophysical Observation", "SAO 239825"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.58370401),
        dec: Angle.Degrees(-51.24514255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187391"},
        {"Hipparcos Number", "HIP 97786"},
        {"Smithsonian Astrophysical Observation", "SAO 246309"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.05949483),
        dec: Angle.Degrees(-51.24461455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 298029"},
        {"Henry Draper 2", "HD 89936"},
        {"Hipparcos Number", "HIP 50731"},
        {"Smithsonian Astrophysical Observation", "SAO 237978"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.37944539),
        dec: Angle.Degrees(-51.24258479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149249"},
        {"Hipparcos Number", "HIP 81281"},
        {"Smithsonian Astrophysical Observation", "SAO 243980"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.02164302),
        dec: Angle.Degrees(-51.23978992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44958"},
        {"Hipparcos Number", "HIP 30252"},
        {"Geneva Identification System", "GEN# +1.00044958"},
        {"Smithsonian Astrophysical Observation", "SAO 234463"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.45853449),
        dec: Angle.Degrees(-51.23771911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142019"},
        {"Hipparcos Number", "HIP 77901"},
        {"Smithsonian Astrophysical Observation", "SAO 243104"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.63158511),
        dec: Angle.Degrees(-51.23767696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71969"},
        {"Hipparcos Number", "HIP 41520"},
        {"Smithsonian Astrophysical Observation", "SAO 236005"},
    },
    visualMagnitude: 8.14,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.01805441),
        dec: Angle.Degrees(-51.23542865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88824"},
        {"Hipparcos Number", "HIP 50070"},
        {"Geneva Identification System", "GEN# +1.00088824"},
        {"Smithsonian Astrophysical Observation", "SAO 237804"},
        {"Wilson Evans Batten Catalogue", "WEB 9204"},
    },
    visualMagnitude: 5.27,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.34534010),
        dec: Angle.Degrees(-51.23293774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181295"},
        {"Hipparcos Number", "HIP 95239"},
        {"Geneva Identification System", "GEN# +1.00181295"},
        {"Smithsonian Astrophysical Observation", "SAO 246053"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.65699853),
        dec: Angle.Degrees(-51.23126280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196537"},
        {"Hipparcos Number", "HIP 102006"},
        {"Smithsonian Astrophysical Observation", "SAO 246682"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.06314627),
        dec: Angle.Degrees(-51.22936784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109100"},
        {"Hipparcos Number", "HIP 61196"},
        {"Smithsonian Astrophysical Observation", "SAO 240040"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.10349470),
        dec: Angle.Degrees(-51.22830855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84400"},
        {"Hipparcos Number", "HIP 47694"},
        {"Celescope Catalog", "CEL 3368"},
        {"Geneva Identification System", "GEN# +1.00084400J"},
        {"Smithsonian Astrophysical Observation", "SAO 237260"},
        {"Wilson Evans Batten Catalogue", "WEB 8937"},
    },
    visualMagnitude: 6.15,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.86501179),
        dec: Angle.Degrees(-51.22815640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111198",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111198"},
    },
    visualMagnitude: 11.42,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.91390256),
        dec: Angle.Degrees(-51.22803872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -255.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117524"},
        {"Hipparcos Number", "HIP 66001"},
        {"Smithsonian Astrophysical Observation", "SAO 240923"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.97350376),
        dec: Angle.Degrees(-51.22583762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200811"},
        {"Hipparcos Number", "HIP 104287"},
        {"Smithsonian Astrophysical Observation", "SAO 246878"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.90686546),
        dec: Angle.Degrees(-51.22498362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40909"},
        {"Hipparcos Number", "HIP 28322"},
        {"Smithsonian Astrophysical Observation", "SAO 234236"},
    },
    visualMagnitude: 6.82,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.75735282),
        dec: Angle.Degrees(-51.22320173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167889"},
        {"Hipparcos Number", "HIP 89837"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.99539962),
        dec: Angle.Degrees(-51.22268708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122376"},
        {"Hipparcos Number", "HIP 68630"},
        {"Smithsonian Astrophysical Observation", "SAO 241394"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.71863499),
        dec: Angle.Degrees(-51.21799490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109262",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109262"},
        {"Geneva Identification System", "GEN# -0.05113182A"},
    },
    visualMagnitude: 10.52,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.04101296),
        dec: Angle.Degrees(-51.21792663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 339.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47232"},
        {"Hipparcos Number", "HIP 31376"},
        {"Geneva Identification System", "GEN# +1.00047232"},
        {"Smithsonian Astrophysical Observation", "SAO 234586"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.68304258),
        dec: Angle.Degrees(-51.21655926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41214"},
        {"Hipparcos Number", "HIP 28484"},
        {"Geneva Identification System", "GEN# +1.00041214"},
        {"Renson", "Renson 11010"},
        {"Smithsonian Astrophysical Observation", "SAO 234251"},
        {"Wilson Evans Batten Catalogue", "WEB 5566"},
    },
    visualMagnitude: 5.65,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.20499138),
        dec: Angle.Degrees(-51.21655276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 95.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109908"},
        {"Hipparcos Number", "HIP 61698"},
        {"Geneva Identification System", "GEN# +1.00109908"},
        {"Smithsonian Astrophysical Observation", "SAO 240112"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.70481503),
        dec: Angle.Degrees(-51.21559451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22623"},
        {"Hipparcos Number", "HIP 16794"},
        {"Geneva Identification System", "GEN# +1.00022623"},
        {"Smithsonian Astrophysical Observation", "SAO 233176"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.04220822),
        dec: Angle.Degrees(-51.21553400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -194.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172444"},
        {"Hipparcos Number", "HIP 91786"},
        {"Geneva Identification System", "GEN# +1.00172444"},
        {"Smithsonian Astrophysical Observation", "SAO 245652"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.74401773),
        dec: Angle.Degrees(-51.21528108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9351"},
        {"Hipparcos Number", "HIP 7060"},
        {"Geneva Identification System", "GEN# +1.00009351"},
        {"Smithsonian Astrophysical Observation", "SAO 232445"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.75606539),
        dec: Angle.Degrees(-51.21526118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96407"},
        {"Hipparcos Number", "HIP 54264"},
        {"Geneva Identification System", "GEN# +1.00096407"},
        {"Smithsonian Astrophysical Observation", "SAO 238763"},
        {"Wilson Evans Batten Catalogue", "WEB 9803"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.52392143),
        dec: Angle.Degrees(-51.21274434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189771"},
        {"Hipparcos Number", "HIP 98815"},
        {"Smithsonian Astrophysical Observation", "SAO 246416"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.01359457),
        dec: Angle.Degrees(-51.21245724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56023"},
        {"Hipparcos Number", "HIP 34851"},
        {"Geneva Identification System", "GEN# +1.00056023"},
        {"Smithsonian Astrophysical Observation", "SAO 235012"},
        {"Wilson Evans Batten Catalogue", "WEB 6971"},
    },
    visualMagnitude: 7.20,
    bvColour: -0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.18916350),
        dec: Angle.Degrees(-51.21184456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78599"},
        {"Hipparcos Number", "HIP 44753"},
        {"Fundamental Katalog 5th Edition", "FK5 2722"},
        {"Geneva Identification System", "GEN# +1.00078599"},
        {"Smithsonian Astrophysical Observation", "SAO 236618"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.81122148),
        dec: Angle.Degrees(-51.21182860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120736"},
        {"Hipparcos Number", "HIP 67728"},
        {"Smithsonian Astrophysical Observation", "SAO 241246"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.11895763),
        dec: Angle.Degrees(-51.21051379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152758"},
        {"Hipparcos Number", "HIP 83023"},
        {"Smithsonian Astrophysical Observation", "SAO 244309"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.48632092),
        dec: Angle.Degrees(-51.21023243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111033"},
        {"Hipparcos Number", "HIP 62370"},
        {"Smithsonian Astrophysical Observation", "SAO 240242"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.74123699),
        dec: Angle.Degrees(-51.20580555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146423"},
        {"Hipparcos Number", "HIP 79912"},
        {"Geneva Identification System", "GEN# +1.00146423"},
        {"Smithsonian Astrophysical Observation", "SAO 243594"},
        {"Wilson Evans Batten Catalogue", "WEB 13528"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.66954868),
        dec: Angle.Degrees(-51.20561133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89273"},
        {"Hipparcos Number", "HIP 50332"},
        {"Geneva Identification System", "GEN# +1.00089273"},
        {"Smithsonian Astrophysical Observation", "SAO 237858"},
    },
    visualMagnitude: 6.20,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.16738579),
        dec: Angle.Degrees(-51.20466420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209293"},
        {"Hipparcos Number", "HIP 108915"},
        {"Geneva Identification System", "GEN# +1.00209293"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.93286653),
        dec: Angle.Degrees(-51.20412090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 240.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99020"},
        {"Hipparcos Number", "HIP 55586"},
        {"Smithsonian Astrophysical Observation", "SAO 239016"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.79324145),
        dec: Angle.Degrees(-51.20220661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49594"},
        {"Hipparcos Number", "HIP 32453"},
        {"Smithsonian Astrophysical Observation", "SAO 234701"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.60033574),
        dec: Angle.Degrees(-51.19989474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206975"},
        {"Hipparcos Number", "HIP 107576"},
        {"Smithsonian Astrophysical Observation", "SAO 247177"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.80926688),
        dec: Angle.Degrees(-51.19969715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112409"},
        {"Hipparcos Number", "HIP 63210"},
        {"Geneva Identification System", "GEN# +1.00112409"},
        {"Smithsonian Astrophysical Observation", "SAO 240407"},
        {"Wilson Evans Batten Catalogue", "WEB 11204"},
    },
    visualMagnitude: 5.17,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.26825217),
        dec: Angle.Degrees(-51.19871605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80989",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80989"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.10130825),
        dec: Angle.Degrees(-51.19512920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224184"},
        {"Hipparcos Number", "HIP 117983"},
        {"Smithsonian Astrophysical Observation", "SAO 248064"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.97021358),
        dec: Angle.Degrees(-51.19113099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129475"},
        {"Hipparcos Number", "HIP 72072"},
        {"Smithsonian Astrophysical Observation", "SAO 241963"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.13074918),
        dec: Angle.Degrees(-51.19068563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68633"},
        {"Hipparcos Number", "HIP 40053"},
        {"Celescope Catalog", "CEL 2214"},
        {"Geneva Identification System", "GEN# +1.00068633"},
        {"Smithsonian Astrophysical Observation", "SAO 235791"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.72145534),
        dec: Angle.Degrees(-51.19059347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 297717"},
        {"Hipparcos Number", "HIP 48903"},
    },
    visualMagnitude: 10.73,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.63996209),
        dec: Angle.Degrees(-51.18937650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122139"},
        {"Hipparcos Number", "HIP 68492"},
        {"Smithsonian Astrophysical Observation", "SAO 241374"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.32684817),
        dec: Angle.Degrees(-51.18933926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193644"},
        {"Hipparcos Number", "HIP 100569"},
        {"Smithsonian Astrophysical Observation", "SAO 246557"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.89908428),
        dec: Angle.Degrees(-51.18867260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116559"},
        {"Hipparcos Number", "HIP 65487"},
        {"Smithsonian Astrophysical Observation", "SAO 240826"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.33263483),
        dec: Angle.Degrees(-51.18313838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 297528"},
        {"Hipparcos Number", "HIP 47025"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.75363822),
        dec: Angle.Degrees(-51.18211755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199566"},
        {"Hipparcos Number", "HIP 103647"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.99968258),
        dec: Angle.Degrees(-51.18131318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72877"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.42741187),
        dec: Angle.Degrees(-51.17877284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187029"},
        {"Hipparcos Number", "HIP 97601"},
        {"Smithsonian Astrophysical Observation", "SAO 246292"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.56471045),
        dec: Angle.Degrees(-51.17873654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 298369"},
        {"Hipparcos Number", "HIP 45934"},
        {"Geneva Identification System", "GEN# +1.00298369"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.49344162),
        dec: Angle.Degrees(-51.17650628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176756"},
        {"Hipparcos Number", "HIP 93660"},
        {"Geneva Identification System", "GEN# +1.00176756"},
        {"Smithsonian Astrophysical Observation", "SAO 245902"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.08327515),
        dec: Angle.Degrees(-51.17596522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81847"},
        {"Hipparcos Number", "HIP 46295"},
        {"Celescope Catalog", "CEL 3296"},
        {"Geneva Identification System", "GEN# +1.00081847"},
        {"Renson", "Renson 23260"},
        {"Smithsonian Astrophysical Observation", "SAO 236974"},
    },
    visualMagnitude: 8.33,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.61441335),
        dec: Angle.Degrees(-51.17453651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118754"},
        {"Hipparcos Number", "HIP 66669"},
        {"Smithsonian Astrophysical Observation", "SAO 241048"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.00302716),
        dec: Angle.Degrees(-51.17445427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38166",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38166"},
    },
    visualMagnitude: 11.26,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.30934985),
        dec: Angle.Degrees(-51.17234028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 152.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139886"},
        {"Hipparcos Number", "HIP 76962"},
        {"Smithsonian Astrophysical Observation", "SAO 242858"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.72469108),
        dec: Angle.Degrees(-51.17171428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46755"},
        {"Hipparcos Number", "HIP 31170"},
        {"Smithsonian Astrophysical Observation", "SAO 234563"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.10126503),
        dec: Angle.Degrees(-51.17094870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159425"},
        {"Hipparcos Number", "HIP 86237"},
        {"Smithsonian Astrophysical Observation", "SAO 244891"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.34419957),
        dec: Angle.Degrees(-51.17004785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117150"},
        {"Hipparcos Number", "HIP 65810"},
        {"Celescope Catalog", "CEL 4262"},
        {"Geneva Identification System", "GEN# +1.00117150"},
        {"Smithsonian Astrophysical Observation", "SAO 240883"},
        {"Wilson Evans Batten Catalogue", "WEB 11646"},
    },
    visualMagnitude: 5.04,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.35523124),
        dec: Angle.Degrees(-51.16511504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120837"},
        {"Hipparcos Number", "HIP 67780"},
        {"Smithsonian Astrophysical Observation", "SAO 241257"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.29052096),
        dec: Angle.Degrees(-51.16500905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84259"},
        {"Hipparcos Number", "HIP 47606"},
        {"Smithsonian Astrophysical Observation", "SAO 237240"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.60857240),
        dec: Angle.Degrees(-51.16396809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152967"},
        {"Hipparcos Number", "HIP 83133"},
        {"Smithsonian Astrophysical Observation", "SAO 244327"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.83334214),
        dec: Angle.Degrees(-51.16375684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124297"},
        {"Hipparcos Number", "HIP 69545"},
        {"Geneva Identification System", "GEN# +1.00124297"},
        {"Smithsonian Astrophysical Observation", "SAO 241558"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.54603458),
        dec: Angle.Degrees(-51.16212988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99542"},
        {"Hipparcos Number", "HIP 55835"},
        {"Smithsonian Astrophysical Observation", "SAO 239070"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.66164081),
        dec: Angle.Degrees(-51.16140266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175462"},
        {"Hipparcos Number", "HIP 93113"},
        {"Smithsonian Astrophysical Observation", "SAO 245831"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.52480256),
        dec: Angle.Degrees(-51.15909105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60201"},
        {"Hipparcos Number", "HIP 36523"},
        {"Smithsonian Astrophysical Observation", "SAO 235257"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.70938704),
        dec: Angle.Degrees(-51.15887888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84120"},
        {"Hipparcos Number", "HIP 47520"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.31059996),
        dec: Angle.Degrees(-51.15806412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128585"},
        {"Hipparcos Number", "HIP 71666"},
        {"Geneva Identification System", "GEN# +1.00128585"},
        {"Smithsonian Astrophysical Observation", "SAO 241883"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.87018011),
        dec: Angle.Degrees(-51.15800268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122893"},
        {"Hipparcos Number", "HIP 68852"},
        {"Geneva Identification System", "GEN# +1.00122893"},
        {"Smithsonian Astrophysical Observation", "SAO 241433"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.48575694),
        dec: Angle.Degrees(-51.15731617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12829"},
        {"Hipparcos Number", "HIP 9661"},
        {"Smithsonian Astrophysical Observation", "SAO 232617"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.07445917),
        dec: Angle.Degrees(-51.15354123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78137",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78137"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.32579986),
        dec: Angle.Degrees(-51.15231028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125572"},
        {"Hipparcos Number", "HIP 70201"},
        {"Smithsonian Astrophysical Observation", "SAO 241667"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.44441658),
        dec: Angle.Degrees(-51.15203520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101574",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101574"},
        {"Geneva Identification System", "GEN# +6.20145058"},
    },
    visualMagnitude: 12.14,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.78125264),
        dec: Angle.Degrees(-51.14778730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212747"},
        {"Hipparcos Number", "HIP 110860"},
        {"Smithsonian Astrophysical Observation", "SAO 247454"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.90762557),
        dec: Angle.Degrees(-51.14768660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85953"},
        {"Hipparcos Number", "HIP 48527"},
        {"Celescope Catalog", "CEL 3398"},
        {"Geneva Identification System", "GEN# +1.00085953"},
        {"Smithsonian Astrophysical Observation", "SAO 237464"},
        {"Wilson Evans Batten Catalogue", "WEB 9041"},
    },
    visualMagnitude: 5.95,
    bvColour: -0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.45879641),
        dec: Angle.Degrees(-51.14671460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105530"},
        {"Hipparcos Number", "HIP 59241"},
        {"Smithsonian Astrophysical Observation", "SAO 239699"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.27676734),
        dec: Angle.Degrees(-51.14670592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136487"},
        {"Hipparcos Number", "HIP 75296"},
        {"Smithsonian Astrophysical Observation", "SAO 242465"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.76609775),
        dec: Angle.Degrees(-51.14124900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141562"},
        {"Hipparcos Number", "HIP 77724"},
        {"Smithsonian Astrophysical Observation", "SAO 243058"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.02745274),
        dec: Angle.Degrees(-51.13957151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78485",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78485"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.32909592),
        dec: Angle.Degrees(-51.13893136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28721"},
        {"Hipparcos Number", "HIP 20924"},
        {"Geneva Identification System", "GEN# +1.00028721"},
        {"Smithsonian Astrophysical Observation", "SAO 233534"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.28507638),
        dec: Angle.Degrees(-51.13875632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72372"},
        {"Hipparcos Number", "HIP 41703"},
        {"Renson", "Renson 20030"},
        {"Smithsonian Astrophysical Observation", "SAO 236039"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.56522236),
        dec: Angle.Degrees(-51.13500129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45613"},
        {"Hipparcos Number", "HIP 30581"},
        {"Smithsonian Astrophysical Observation", "SAO 234496"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.41758624),
        dec: Angle.Degrees(-51.13443692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 95.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117314"},
        {"Hipparcos Number", "HIP 65894"},
        {"Smithsonian Astrophysical Observation", "SAO 240901"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.60801443),
        dec: Angle.Degrees(-51.13430915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203986"},
        {"Hipparcos Number", "HIP 105935"},
        {"Smithsonian Astrophysical Observation", "SAO 247034"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.82241917),
        dec: Angle.Degrees(-51.13238209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153370"},
        {"Hipparcos Number", "HIP 83321"},
        {"Geneva Identification System", "GEN# +1.00153370J"},
        {"Smithsonian Astrophysical Observation", "SAO 244370"},
        {"Wilson Evans Batten Catalogue", "WEB 14084"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.44317436),
        dec: Angle.Degrees(-51.13091716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90171",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90171"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.00285186),
        dec: Angle.Degrees(-51.13000224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77523"},
        {"Hipparcos Number", "HIP 44278"},
        {"Celescope Catalog", "CEL 3146"},
        {"Smithsonian Astrophysical Observation", "SAO 236506"},
    },
    visualMagnitude: 9.01,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.25914386),
        dec: Angle.Degrees(-51.12958195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110657"},
        {"Hipparcos Number", "HIP 62137"},
        {"Smithsonian Astrophysical Observation", "SAO 240197"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.02509324),
        dec: Angle.Degrees(-51.12952997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151850"},
        {"Hipparcos Number", "HIP 82562"},
        {"Geneva Identification System", "GEN# +1.00151850"},
        {"Smithsonian Astrophysical Observation", "SAO 244226"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.14023062),
        dec: Angle.Degrees(-51.12884402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217047"},
        {"Hipparcos Number", "HIP 113439"},
        {"Geneva Identification System", "GEN# +1.00217047"},
        {"Smithsonian Astrophysical Observation", "SAO 247662"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.62636800),
        dec: Angle.Degrees(-51.12728594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148400"},
        {"Hipparcos Number", "HIP 80821"},
        {"Smithsonian Astrophysical Observation", "SAO 243893"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.56701986),
        dec: Angle.Degrees(-51.12601151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142218"},
        {"Hipparcos Number", "HIP 78005"},
        {"Smithsonian Astrophysical Observation", "SAO 243131"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.93451435),
        dec: Angle.Degrees(-51.12581571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156643"},
        {"Hipparcos Number", "HIP 84924"},
        {"Geneva Identification System", "GEN# +1.00156643"},
        {"Smithsonian Astrophysical Observation", "SAO 244656"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.33122876),
        dec: Angle.Degrees(-51.12270410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75662",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75662"},
    },
    visualMagnitude: 9.63,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.87665413),
        dec: Angle.Degrees(-51.12117679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143321"},
        {"Hipparcos Number", "HIP 78540"},
        {"Fundamental Katalog 5th Edition", "FK5 3261"},
        {"Geneva Identification System", "GEN# +1.00143321J"},
        {"Smithsonian Astrophysical Observation", "SAO 243262"},
    },
    visualMagnitude: 6.38,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.51869322),
        dec: Angle.Degrees(-51.12073342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161811"},
        {"Hipparcos Number", "HIP 87303"},
        {"Smithsonian Astrophysical Observation", "SAO 245064"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.58040720),
        dec: Angle.Degrees(-51.12014370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96751"},
        {"Hipparcos Number", "HIP 54401"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.98496879),
        dec: Angle.Degrees(-51.11887710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28688",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28688"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.85864724),
        dec: Angle.Degrees(-51.11866208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218464"},
        {"Hipparcos Number", "HIP 114292"},
        {"Smithsonian Astrophysical Observation", "SAO 247754"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.21563883),
        dec: Angle.Degrees(-51.11763056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61241",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61241"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.24648728),
        dec: Angle.Degrees(-51.11403138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139947"},
        {"Hipparcos Number", "HIP 76995"},
        {"Smithsonian Astrophysical Observation", "SAO 242866"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.81598498),
        dec: Angle.Degrees(-51.11366108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110288"},
        {"Hipparcos Number", "HIP 61923"},
        {"Smithsonian Astrophysical Observation", "SAO 240154"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.36074522),
        dec: Angle.Degrees(-51.11202784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108867"},
        {"Hipparcos Number", "HIP 61048"},
        {"Smithsonian Astrophysical Observation", "SAO 240011"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.69136149),
        dec: Angle.Degrees(-51.11141622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67848"},
        {"Hipparcos Number", "HIP 39754"},
        {"Geneva Identification System", "GEN# +1.00067848"},
        {"Smithsonian Astrophysical Observation", "SAO 235753"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.87985171),
        dec: Angle.Degrees(-51.11104860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48154"},
        {"Hipparcos Number", "HIP 31817"},
        {"Geneva Identification System", "GEN# +1.00048154"},
        {"Smithsonian Astrophysical Observation", "SAO 234635"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.78515332),
        dec: Angle.Degrees(-51.11096505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137789"},
        {"Hipparcos Number", "HIP 75890"},
        {"Smithsonian Astrophysical Observation", "SAO 242620"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.51675665),
        dec: Angle.Degrees(-51.10981491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99641"},
        {"Hipparcos Number", "HIP 55893"},
        {"Geneva Identification System", "GEN# +1.00099641"},
        {"Smithsonian Astrophysical Observation", "SAO 239082"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.84664021),
        dec: Angle.Degrees(-51.10897901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211725"},
        {"Hipparcos Number", "HIP 110288"},
        {"Smithsonian Astrophysical Observation", "SAO 247409"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.09516576),
        dec: Angle.Degrees(-51.10872028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206306"},
        {"Hipparcos Number", "HIP 107206"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.70527269),
        dec: Angle.Degrees(-51.10846378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158586"},
        {"Hipparcos Number", "HIP 85864"},
        {"Geneva Identification System", "GEN# +1.00158586"},
        {"Smithsonian Astrophysical Observation", "SAO 244831"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.19729603),
        dec: Angle.Degrees(-51.10250285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118533"},
        {"Hipparcos Number", "HIP 66561"},
        {"Smithsonian Astrophysical Observation", "SAO 241028"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.67026747),
        dec: Angle.Degrees(-51.10197844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20253"},
        {"Hipparcos Number", "HIP 14990"},
        {"Smithsonian Astrophysical Observation", "SAO 233038"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.29621917),
        dec: Angle.Degrees(-51.10141966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211878"},
        {"Hipparcos Number", "HIP 110380"},
        {"Geneva Identification System", "GEN# +1.00211878"},
        {"Smithsonian Astrophysical Observation", "SAO 247419"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.35236348),
        dec: Angle.Degrees(-51.10140806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181980"},
        {"Hipparcos Number", "HIP 95468"},
        {"Smithsonian Astrophysical Observation", "SAO 246085"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.29151759),
        dec: Angle.Degrees(-51.10058036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203774"},
        {"Hipparcos Number", "HIP 105832"},
        {"Smithsonian Astrophysical Observation", "SAO 247030"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.53059890),
        dec: Angle.Degrees(-51.09909724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31613"},
        {"Hipparcos Number", "HIP 22816"},
        {"Smithsonian Astrophysical Observation", "SAO 233728"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.63790829),
        dec: Angle.Degrees(-51.09909128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41702"},
        {"Hipparcos Number", "HIP 28721"},
        {"Smithsonian Astrophysical Observation", "SAO 234282"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.99962938),
        dec: Angle.Degrees(-51.09855249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91648"},
        {"Hipparcos Number", "HIP 51702"},
        {"Smithsonian Astrophysical Observation", "SAO 238189"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.46136701),
        dec: Angle.Degrees(-51.09699285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188743"},
        {"Hipparcos Number", "HIP 98356"},
        {"Smithsonian Astrophysical Observation", "SAO 246369"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.74525190),
        dec: Angle.Degrees(-51.09653232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16170"},
        {"Hipparcos Number", "HIP 11925"},
        {"Fundamental Katalog 5th Edition", "FK5 2177"},
        {"Geneva Identification System", "GEN# +1.00016170"},
        {"Smithsonian Astrophysical Observation", "SAO 232818"},
        {"Wilson Evans Batten Catalogue", "WEB 2467"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.47757346),
        dec: Angle.Degrees(-51.09349627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73127"},
        {"Hipparcos Number", "HIP 42069"},
        {"Celescope Catalog", "CEL 2675"},
        {"Geneva Identification System", "GEN# +1.00073127"},
        {"Smithsonian Astrophysical Observation", "SAO 236093"},
        {"Wilson Evans Batten Catalogue", "WEB 8090"},
    },
    visualMagnitude: 6.58,
    bvColour: -0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.62080315),
        dec: Angle.Degrees(-51.09314856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14943"},
        {"Hipparcos Number", "HIP 11102"},
        {"Geneva Identification System", "GEN# +1.00014943"},
        {"Renson", "Renson 3720"},
        {"Smithsonian Astrophysical Observation", "SAO 232736"},
        {"Wilson Evans Batten Catalogue", "WEB 2335"},
    },
    visualMagnitude: 5.90,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.72772659),
        dec: Angle.Degrees(-51.09228926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86957"},
        {"Hipparcos Number", "HIP 49053"},
        {"Geneva Identification System", "GEN# +1.00086957"},
        {"Smithsonian Astrophysical Observation", "SAO 237581"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.14575367),
        dec: Angle.Degrees(-51.09120551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25316"},
        {"Hipparcos Number", "HIP 18607"},
        {"Fundamental Katalog 5th Edition", "FK5 4361"},
        {"Geneva Identification System", "GEN# +1.00025316"},
        {"Smithsonian Astrophysical Observation", "SAO 233346"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.72437425),
        dec: Angle.Degrees(-51.09071961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83513",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83513"},
        {"Geneva Identification System", "GEN# +6.90708106"},
    },
    visualMagnitude: 11.15,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.01112385),
        dec: Angle.Degrees(-51.09045765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103209"},
        {"Hipparcos Number", "HIP 57938"},
        {"Smithsonian Astrophysical Observation", "SAO 239455"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.22877026),
        dec: Angle.Degrees(-51.08980109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197387"},
        {"Hipparcos Number", "HIP 102444"},
        {"Smithsonian Astrophysical Observation", "SAO 246719"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.38052991),
        dec: Angle.Degrees(-51.08955051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192674"},
        {"Hipparcos Number", "HIP 100090"},
        {"Fundamental Katalog 5th Edition", "FK5 5791"},
        {"Renson", "Renson 53730"},
        {"Smithsonian Astrophysical Observation", "SAO 246522"},
    },
    visualMagnitude: 7.56,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.58053035),
        dec: Angle.Degrees(-51.08678300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194679"},
        {"Hipparcos Number", "HIP 101048"},
        {"Smithsonian Astrophysical Observation", "SAO 246604"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.26554188),
        dec: Angle.Degrees(-51.08489605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65640"},
        {"Hipparcos Number", "HIP 38860"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.28987562),
        dec: Angle.Degrees(-51.08483163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153772"},
        {"Hipparcos Number", "HIP 83509"},
        {"Geneva Identification System", "GEN# +1.00153772"},
        {"Smithsonian Astrophysical Observation", "SAO 244400"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.00512753),
        dec: Angle.Degrees(-51.08364071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155670"},
        {"Hipparcos Number", "HIP 84434"},
        {"Geneva Identification System", "GEN# +1.00155670"},
        {"Smithsonian Astrophysical Observation", "SAO 244562"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.93623233),
        dec: Angle.Degrees(-51.08325808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184393"},
        {"Hipparcos Number", "HIP 96473"},
        {"Smithsonian Astrophysical Observation", "SAO 246182"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.20071280),
        dec: Angle.Degrees(-51.08307353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61902"},
        {"Hipparcos Number", "HIP 37240"},
        {"Geneva Identification System", "GEN# +1.00061902"},
        {"Smithsonian Astrophysical Observation", "SAO 235386"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.72361241),
        dec: Angle.Degrees(-51.08286875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -201.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153771"},
        {"Hipparcos Number", "HIP 83506"},
        {"Geneva Identification System", "GEN# +1.00153771"},
        {"Smithsonian Astrophysical Observation", "SAO 244398"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.99813354),
        dec: Angle.Degrees(-51.08259448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60798",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60798"},
    },
    visualMagnitude: 11.05,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.91185731),
        dec: Angle.Degrees(-51.08229175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87456"},
        {"Hipparcos Number", "HIP 49295"},
        {"Smithsonian Astrophysical Observation", "SAO 237651"},
    },
    visualMagnitude: 8.90,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.92274671),
        dec: Angle.Degrees(-51.07888133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139275"},
        {"Henry Draper 2", "HD 139276"},
        {"Hipparcos Number", "HIP 76679"},
        {"Geneva Identification System", "GEN# +1.00139275"},
        {"Smithsonian Astrophysical Observation", "SAO 242801"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.86347882),
        dec: Angle.Degrees(-51.07792431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87910"},
        {"Hipparcos Number", "HIP 49537"},
        {"Smithsonian Astrophysical Observation", "SAO 237700"},
    },
    visualMagnitude: 7.09,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.71694551),
        dec: Angle.Degrees(-51.07774230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158479"},
        {"Henry Draper 2", "HD 158480"},
        {"Hipparcos Number", "HIP 85820"},
        {"Smithsonian Astrophysical Observation", "SAO 244821"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.04368427),
        dec: Angle.Degrees(-51.07408407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90899"},
        {"Hipparcos Number", "HIP 51286"},
        {"Geneva Identification System", "GEN# +1.00090899"},
        {"Smithsonian Astrophysical Observation", "SAO 238094"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.13425676),
        dec: Angle.Degrees(-51.07192967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165585"},
        {"Hipparcos Number", "HIP 88948"},
        {"Smithsonian Astrophysical Observation", "SAO 245271"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.34720285),
        dec: Angle.Degrees(-51.07093418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76917"},
        {"Hipparcos Number", "HIP 43959"},
        {"Geneva Identification System", "GEN# +1.00076917J"},
        {"Smithsonian Astrophysical Observation", "SAO 236431"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.28716396),
        dec: Angle.Degrees(-51.07056261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106375"},
        {"Hipparcos Number", "HIP 59682"},
        {"Smithsonian Astrophysical Observation", "SAO 239782"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.58395890),
        dec: Angle.Degrees(-51.07053506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205206"},
        {"Hipparcos Number", "HIP 106602"},
    },
    visualMagnitude: 9.80,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.85151501),
        dec: Angle.Degrees(-51.06989205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113088"},
        {"Hipparcos Number", "HIP 63598"},
        {"Smithsonian Astrophysical Observation", "SAO 240488"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.49337058),
        dec: Angle.Degrees(-51.06984546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93921"},
        {"Hipparcos Number", "HIP 52944"},
        {"Smithsonian Astrophysical Observation", "SAO 238516"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.40988161),
        dec: Angle.Degrees(-51.06980575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48266"},
        {"Hipparcos Number", "HIP 31879"},
        {"Smithsonian Astrophysical Observation", "SAO 234645"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.96247362),
        dec: Angle.Degrees(-51.06833050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167257"},
        {"Hipparcos Number", "HIP 89597"},
        {"Fundamental Katalog 5th Edition", "FK5 3453"},
        {"Geneva Identification System", "GEN# +1.00167257"},
        {"Smithsonian Astrophysical Observation", "SAO 245372"},
        {"Wilson Evans Batten Catalogue", "WEB 15256"},
    },
    visualMagnitude: 6.06,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.25382686),
        dec: Angle.Degrees(-51.06824435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172096"},
        {"Hipparcos Number", "HIP 91601"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.21499331),
        dec: Angle.Degrees(-51.06802670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39060"},
        {"Hipparcos Number", "HIP 27321"},
        {"Geneva Identification System", "GEN# +1.00039060"},
        {"Renson", "Renson 10480"},
        {"Smithsonian Astrophysical Observation", "SAO 234134"},
        {"Wilson Evans Batten Catalogue", "WEB 5372"},
    },
    visualMagnitude: 3.85,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.82118054),
        dec: Angle.Degrees(-51.06671329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 81.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150725"},
        {"Hipparcos Number", "HIP 82036"},
        {"Smithsonian Astrophysical Observation", "SAO 244117"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.36893477),
        dec: Angle.Degrees(-51.06588448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37144"},
        {"Hipparcos Number", "HIP 26067"},
        {"Geneva Identification System", "GEN# +1.00037144"},
        {"Smithsonian Astrophysical Observation", "SAO 234023"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.40067383),
        dec: Angle.Degrees(-51.06573543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70505",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70505"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.33697005),
        dec: Angle.Degrees(-51.06547792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87697",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87697"},
    },
    visualMagnitude: 10.86,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.68973914),
        dec: Angle.Degrees(-51.06316390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21360"},
        {"Hipparcos Number", "HIP 15884"},
        {"Geneva Identification System", "GEN# +1.00021360"},
        {"Smithsonian Astrophysical Observation", "SAO 233106"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.15087344),
        dec: Angle.Degrees(-51.06270539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201518"},
        {"Hipparcos Number", "HIP 104655"},
        {"Geneva Identification System", "GEN# +1.00201518"},
        {"Smithsonian Astrophysical Observation", "SAO 246900"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.99015751),
        dec: Angle.Degrees(-51.06265242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33713"},
        {"Hipparcos Number", "HIP 23987"},
        {"Smithsonian Astrophysical Observation", "SAO 233849"},
    },
    visualMagnitude: 8.90,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.34707554),
        dec: Angle.Degrees(-51.06246196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90466",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90466"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.89943939),
        dec: Angle.Degrees(-51.06062120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 149.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92489"},
        {"Hipparcos Number", "HIP 52196"},
        {"Smithsonian Astrophysical Observation", "SAO 238317"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.95635432),
        dec: Angle.Degrees(-51.06034986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95092"},
        {"Hipparcos Number", "HIP 53601"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.49049597),
        dec: Angle.Degrees(-51.06016199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30595"},
        {"Hipparcos Number", "HIP 22186"},
        {"Smithsonian Astrophysical Observation", "SAO 233675"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.59323946),
        dec: Angle.Degrees(-51.05696192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31105"},
        {"Hipparcos Number", "HIP 22497"},
        {"Smithsonian Astrophysical Observation", "SAO 233704"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.59944894),
        dec: Angle.Degrees(-51.05644620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5230"},
        {"Hipparcos Number", "HIP 4187"},
        {"Smithsonian Astrophysical Observation", "SAO 232219"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.36973893),
        dec: Angle.Degrees(-51.05299581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93477"},
        {"Hipparcos Number", "HIP 52711"},
        {"Smithsonian Astrophysical Observation", "SAO 238460"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.65801263),
        dec: Angle.Degrees(-51.05195562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80456"},
        {"Hipparcos Number", "HIP 45631"},
        {"Celescope Catalog", "CEL 3260"},
        {"Geneva Identification System", "GEN# +1.00080456"},
        {"Smithsonian Astrophysical Observation", "SAO 236824"},
        {"Wilson Evans Batten Catalogue", "WEB 8670"},
    },
    visualMagnitude: 5.26,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.52454326),
        dec: Angle.Degrees(-51.05089519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32438"},
        {"Hipparcos Number", "HIP 23293"},
        {"Geneva Identification System", "GEN# +1.00032438"},
        {"Smithsonian Astrophysical Observation", "SAO 233782"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.15802730),
        dec: Angle.Degrees(-51.05031760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204824"},
        {"Hipparcos Number", "HIP 106387"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.21002820),
        dec: Angle.Degrees(-51.05030420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215517"},
        {"Hipparcos Number", "HIP 112448"},
        {"Smithsonian Astrophysical Observation", "SAO 247579"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.67315066),
        dec: Angle.Degrees(-51.05018318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57334"},
        {"Hipparcos Number", "HIP 35359"},
        {"Geneva Identification System", "GEN# +1.00057334"},
        {"Smithsonian Astrophysical Observation", "SAO 235080"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.55123560),
        dec: Angle.Degrees(-51.05009771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113749"},
        {"Hipparcos Number", "HIP 63968"},
        {"Smithsonian Astrophysical Observation", "SAO 240552"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.63534740),
        dec: Angle.Degrees(-51.04947987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135394"},
        {"Hipparcos Number", "HIP 74766"},
        {"Smithsonian Astrophysical Observation", "SAO 242379"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.20804124),
        dec: Angle.Degrees(-51.04756836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31827"},
        {"Hipparcos Number", "HIP 22953"},
        {"Geneva Identification System", "GEN# +1.00031827"},
        {"Smithsonian Astrophysical Observation", "SAO 233740"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.07559212),
        dec: Angle.Degrees(-51.04718663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 182.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112146"},
        {"Hipparcos Number", "HIP 63022"},
        {"Smithsonian Astrophysical Observation", "SAO 240373"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.72422364),
        dec: Angle.Degrees(-51.04718498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32812",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32812"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.60008050),
        dec: Angle.Degrees(-51.04614663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 203.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27826"},
        {"Hipparcos Number", "HIP 20292"},
        {"Smithsonian Astrophysical Observation", "SAO 233489"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.23189248),
        dec: Angle.Degrees(-51.04441543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62119",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62119"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.96843682),
        dec: Angle.Degrees(-51.04430939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105393",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105393"},
        {"Geneva Identification System", "GEN# -0.05112903"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.808,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.21598787),
        dec: Angle.Degrees(-51.04425872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 203.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2070"},
        {"Hipparcos Number", "HIP 1955"},
        {"Cincinnati Publication", "Ci 20 29"},
        {"Geneva Identification System", "GEN# +1.00002070"},
        {"Smithsonian Astrophysical Observation", "SAO 232027"},
        {"Wilson Evans Batten Catalogue", "WEB 368"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.18462337),
        dec: Angle.Degrees(-51.04324736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 545.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -254.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5147"},
        {"Hipparcos Number", "HIP 4118"},
        {"Smithsonian Astrophysical Observation", "SAO 232215"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.19294554),
        dec: Angle.Degrees(-51.04156243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113506"},
        {"Hipparcos Number", "HIP 63838"},
        {"Geneva Identification System", "GEN# +1.00113506"},
        {"Smithsonian Astrophysical Observation", "SAO 240529"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.25289165),
        dec: Angle.Degrees(-51.04123018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17684"},
        {"Hipparcos Number", "HIP 13100"},
        {"Geneva Identification System", "GEN# +1.00017684"},
        {"Smithsonian Astrophysical Observation", "SAO 232899"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.10933921),
        dec: Angle.Degrees(-51.04099976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221567"},
        {"Hipparcos Number", "HIP 116268"},
        {"Smithsonian Astrophysical Observation", "SAO 247925"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.37199760),
        dec: Angle.Degrees(-51.04064142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207452"},
        {"Hipparcos Number", "HIP 107810"},
        {"Geneva Identification System", "GEN# +1.00207452"},
        {"Smithsonian Astrophysical Observation", "SAO 247200"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.61841281),
        dec: Angle.Degrees(-51.03754034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74254"},
        {"Hipparcos Number", "HIP 42585"},
        {"Geneva Identification System", "GEN# +1.00074254"},
        {"Smithsonian Astrophysical Observation", "SAO 236176"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.18894779),
        dec: Angle.Degrees(-51.03749405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7899"},
        {"Hipparcos Number", "HIP 6046"},
        {"Fundamental Katalog 5th Edition", "FK5 4115"},
        {"Renson", "Renson 1970"},
        {"Smithsonian Astrophysical Observation", "SAO 232365"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.42233724),
        dec: Angle.Degrees(-51.03458402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64560",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64560"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.50139402),
        dec: Angle.Degrees(-51.03316600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15221"},
        {"Hipparcos Number", "HIP 11289"},
        {"Smithsonian Astrophysical Observation", "SAO 232763"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.35555978),
        dec: Angle.Degrees(-51.03232869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96021"},
        {"Hipparcos Number", "HIP 54071"},
        {"Smithsonian Astrophysical Observation", "SAO 238724"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.96100129),
        dec: Angle.Degrees(-51.02933854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175146"},
        {"Hipparcos Number", "HIP 92991"},
        {"Smithsonian Astrophysical Observation", "SAO 245820"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.17099559),
        dec: Angle.Degrees(-51.02733759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28108"},
        {"Hipparcos Number", "HIP 20487"},
        {"Smithsonian Astrophysical Observation", "SAO 233501"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.85675312),
        dec: Angle.Degrees(-51.02649865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107649"},
        {"Hipparcos Number", "HIP 60348"},
        {"Smithsonian Astrophysical Observation", "SAO 239890"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.60370286),
        dec: Angle.Degrees(-51.02618049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15933"},
        {"Hipparcos Number", "HIP 11776"},
        {"Smithsonian Astrophysical Observation", "SAO 232805"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.99185077),
        dec: Angle.Degrees(-51.02610960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24407"},
        {"Hipparcos Number", "HIP 17975"},
        {"Smithsonian Astrophysical Observation", "SAO 233296"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.64366611),
        dec: Angle.Degrees(-51.02510943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117397"},
        {"Hipparcos Number", "HIP 65941"},
        {"Smithsonian Astrophysical Observation", "SAO 240912"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.77903859),
        dec: Angle.Degrees(-51.02471936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103124"},
        {"Hipparcos Number", "HIP 57883"},
        {"Smithsonian Astrophysical Observation", "SAO 239444"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.07302752),
        dec: Angle.Degrees(-51.02466113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85072",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85072"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.79922299),
        dec: Angle.Degrees(-51.02438246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10813"},
        {"Hipparcos Number", "HIP 8139"},
        {"Smithsonian Astrophysical Observation", "SAO 232512"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.16253170),
        dec: Angle.Degrees(-51.02055156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221054"},
        {"Hipparcos Number", "HIP 115917"},
        {"Geneva Identification System", "GEN# +1.00221054"},
        {"Smithsonian Astrophysical Observation", "SAO 247896"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.28410928),
        dec: Angle.Degrees(-51.01991229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59219"},
        {"Hipparcos Number", "HIP 36114"},
        {"Fundamental Katalog 5th Edition", "FK5 2575"},
        {"Geneva Identification System", "GEN# +1.00059219"},
        {"Smithsonian Astrophysical Observation", "SAO 235192"},
        {"Wilson Evans Batten Catalogue", "WEB 7191"},
    },
    visualMagnitude: 5.09,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.59106537),
        dec: Angle.Degrees(-51.01849597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176664"},
        {"Hipparcos Number", "HIP 93624"},
        {"Geneva Identification System", "GEN# +1.00176664"},
        {"Smithsonian Astrophysical Observation", "SAO 245899"},
    },
    visualMagnitude: 5.93,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.98967365),
        dec: Angle.Degrees(-51.01824471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90272"},
        {"Hipparcos Number", "HIP 50928"},
        {"Smithsonian Astrophysical Observation", "SAO 238023"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.02496295),
        dec: Angle.Degrees(-51.01723176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39933",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39933"},
        {"Smithsonian Astrophysical Observation", "SAO 235779"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.32707187),
        dec: Angle.Degrees(-51.01703674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145829"},
        {"Hipparcos Number", "HIP 79660"},
        {"Smithsonian Astrophysical Observation", "SAO 243507"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.84956406),
        dec: Angle.Degrees(-51.01685449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51968"},
        {"Hipparcos Number", "HIP 33396"},
        {"Smithsonian Astrophysical Observation", "SAO 234800"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.19329038),
        dec: Angle.Degrees(-51.01602520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202102"},
        {"Hipparcos Number", "HIP 104950"},
        {"Smithsonian Astrophysical Observation", "SAO 246928"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.88848125),
        dec: Angle.Degrees(-51.01252317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119419"},
        {"Hipparcos Number", "HIP 67036"},
        {"Celescope Catalog", "CEL 4279"},
        {"Geneva Identification System", "GEN# +1.00119419"},
        {"Renson", "Renson 34470"},
        {"Smithsonian Astrophysical Observation", "SAO 241120"},
        {"Wilson Evans Batten Catalogue", "WEB 11809"},
    },
    visualMagnitude: 6.44,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.06678409),
        dec: Angle.Degrees(-51.01240595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68276"},
        {"Hipparcos Number", "HIP 39932"},
        {"Celescope Catalog", "CEL 2191"},
        {"Geneva Identification System", "GEN# +1.00068276"},
        {"Smithsonian Astrophysical Observation", "SAO 235778"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.32697519),
        dec: Angle.Degrees(-51.01239725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108405",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108405"},
        {"Geneva Identification System", "GEN# -0.05113128"},
    },
    visualMagnitude: 10.36,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.42181611),
        dec: Angle.Degrees(-51.00525542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -373.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72729",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72729"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.04431992),
        dec: Angle.Degrees(-51.00414970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105070"},
        {"Hipparcos Number", "HIP 58996"},
        {"Smithsonian Astrophysical Observation", "SAO 239657"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.44798147),
        dec: Angle.Degrees(-51.00332276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154297"},
        {"Hipparcos Number", "HIP 83773"},
        {"Smithsonian Astrophysical Observation", "SAO 244448"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.82691711),
        dec: Angle.Degrees(-51.00133671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52142"},
        {"Hipparcos Number", "HIP 33460"},
        {"Geneva Identification System", "GEN# +1.00052142"},
        {"Smithsonian Astrophysical Observation", "SAO 234808"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.34400894),
        dec: Angle.Degrees(-51.00095439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224666"},
        {"Hipparcos Number", "HIP 118306"},
        {"Smithsonian Astrophysical Observation", "SAO 248094"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.94201691),
        dec: Angle.Degrees(-50.99914867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85186"},
        {"Hipparcos Number", "HIP 48123"},
        {"Smithsonian Astrophysical Observation", "SAO 237365"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.17385940),
        dec: Angle.Degrees(-50.99874288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148763"},
        {"Hipparcos Number", "HIP 81024"},
        {"Smithsonian Astrophysical Observation", "SAO 243931"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.22277944),
        dec: Angle.Degrees(-50.99771771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86113"},
        {"Hipparcos Number", "HIP 48628"},
        {"Smithsonian Astrophysical Observation", "SAO 237489"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.74974877),
        dec: Angle.Degrees(-50.99766881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63490"},
        {"Hipparcos Number", "HIP 37948"},
        {"Smithsonian Astrophysical Observation", "SAO 235500"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.66646602),
        dec: Angle.Degrees(-50.99738485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221751"},
        {"Hipparcos Number", "HIP 116385"},
        {"Smithsonian Astrophysical Observation", "SAO 247934"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.75264199),
        dec: Angle.Degrees(-50.99644655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 297690"},
        {"Hipparcos Number", "HIP 48606"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.68518015),
        dec: Angle.Degrees(-50.99457166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58834",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58834"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.01242552),
        dec: Angle.Degrees(-50.99357168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42489"},
        {"Hipparcos Number", "HIP 29093"},
        {"Smithsonian Astrophysical Observation", "SAO 234331"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.05307968),
        dec: Angle.Degrees(-50.99340627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76312",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76312"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.871,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.81765507),
        dec: Angle.Degrees(-50.99328542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86671"},
        {"Hipparcos Number", "HIP 48908"},
        {"Smithsonian Astrophysical Observation", "SAO 237552"},
    },
    visualMagnitude: 8.61,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.65554101),
        dec: Angle.Degrees(-50.99279149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1817"},
        {"Hipparcos Number", "HIP 1766"},
        {"Smithsonian Astrophysical Observation", "SAO 232008"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.58840740),
        dec: Angle.Degrees(-50.99260286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206305"},
        {"Hipparcos Number", "HIP 107201"},
        {"Smithsonian Astrophysical Observation", "SAO 247143"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.69721685),
        dec: Angle.Degrees(-50.99247468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95908"},
        {"Hipparcos Number", "HIP 54025"},
        {"Smithsonian Astrophysical Observation", "SAO 238717"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.80334567),
        dec: Angle.Degrees(-50.99198135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92605"},
        {"Hipparcos Number", "HIP 52255"},
        {"Smithsonian Astrophysical Observation", "SAO 238331"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.15203111),
        dec: Angle.Degrees(-50.99051897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6673"},
        {"Hipparcos Number", "HIP 5224"},
        {"Cincinnati Publication", "Ci 20 77"},
        {"Cincinnati Publication 2", "Ci 18 147"},
        {"Geneva Identification System", "GEN# +1.00006673"},
        {"Smithsonian Astrophysical Observation", "SAO 232297"},
        {"Wilson Evans Batten Catalogue", "WEB 1094"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.69573127),
        dec: Angle.Degrees(-50.98947181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 489.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40273"},
        {"Hipparcos Number", "HIP 27978"},
        {"Geneva Identification System", "GEN# +1.00040273"},
        {"Smithsonian Astrophysical Observation", "SAO 234200"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.75122091),
        dec: Angle.Degrees(-50.98869610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213578"},
        {"Hipparcos Number", "HIP 111343"},
        {"Fundamental Katalog 5th Edition", "FK5 5989"},
        {"Smithsonian Astrophysical Observation", "SAO 247486"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.35730093),
        dec: Angle.Degrees(-50.98719070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4919"},
        {"Hipparcos Number", "HIP 3949"},
        {"Fundamental Katalog 5th Edition", "FK5 2056"},
        {"Geneva Identification System", "GEN# +1.00004919"},
        {"Smithsonian Astrophysical Observation", "SAO 232203"},
        {"Wilson Evans Batten Catalogue", "WEB 707"},
    },
    visualMagnitude: 5.24,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.67136689),
        dec: Angle.Degrees(-50.98692422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219231"},
        {"Hipparcos Number", "HIP 114776"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.74416300),
        dec: Angle.Degrees(-50.98422571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69609",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69609"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.69332350),
        dec: Angle.Degrees(-50.98398393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29429"},
        {"Hipparcos Number", "HIP 21389"},
        {"Smithsonian Astrophysical Observation", "SAO 233580"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.87357210),
        dec: Angle.Degrees(-50.97903836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187294"},
        {"Hipparcos Number", "HIP 97738"},
        {"Geneva Identification System", "GEN# +1.00187294"},
        {"Smithsonian Astrophysical Observation", "SAO 246305"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.92803390),
        dec: Angle.Degrees(-50.97853998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43918"},
        {"Hipparcos Number", "HIP 29762"},
        {"Smithsonian Astrophysical Observation", "SAO 234410"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.01170683),
        dec: Angle.Degrees(-50.97717770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4171"},
        {"Hipparcos Number", "HIP 3422"},
        {"Smithsonian Astrophysical Observation", "SAO 232164"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.89947760),
        dec: Angle.Degrees(-50.97656675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88330",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10991 CD"},
        {"Hipparcos Number", "HIP 88330"},
        {"Geneva Identification System", "GEN# +6.20038123"},
        {"Geneva Identification System 2", "GEN# +2.65140146"},
        {"Wilson Evans Batten Catalogue", "WEB 14929"},
        {"New General Catalogue", "NGC 6514 146"},
    },
    visualMagnitude: 7.14,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.59643025),
        dec: Angle.Degrees(-23.03334738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35858"},
        {"Hipparcos Number", "HIP 25318"},
        {"Smithsonian Astrophysical Observation", "SAO 233969"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.23614989),
        dec: Angle.Degrees(-50.97647266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218124"},
        {"Hipparcos Number", "HIP 114064"},
        {"Smithsonian Astrophysical Observation", "SAO 247722"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.50892695),
        dec: Angle.Degrees(-50.97324881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22460"},
        {"Hipparcos Number", "HIP 16673"},
        {"Smithsonian Astrophysical Observation", "SAO 233166"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.64286103),
        dec: Angle.Degrees(-50.97268872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107479"},
        {"Hipparcos Number", "HIP 60263"},
        {"Smithsonian Astrophysical Observation", "SAO 239872"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.35094255),
        dec: Angle.Degrees(-50.96990152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73340"},
        {"Hipparcos Number", "HIP 42177"},
        {"Celescope Catalog", "CEL 2693"},
        {"Geneva Identification System", "GEN# +1.00073340"},
        {"Renson", "Renson 20360"},
        {"Smithsonian Astrophysical Observation", "SAO 236110"},
        {"Wilson Evans Batten Catalogue", "WEB 8107"},
    },
    visualMagnitude: 5.79,
    bvColour: -0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.96683262),
        dec: Angle.Degrees(-50.96967696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208697"},
        {"Hipparcos Number", "HIP 108558"},
        {"Smithsonian Astrophysical Observation", "SAO 247254"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.85252812),
        dec: Angle.Degrees(-50.96952412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115029"},
        {"Hipparcos Number", "HIP 64663"},
        {"Smithsonian Astrophysical Observation", "SAO 240680"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.81944200),
        dec: Angle.Degrees(-50.96866116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146258"},
        {"Hipparcos Number", "HIP 79840"},
        {"Smithsonian Astrophysical Observation", "SAO 243558"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.45136828),
        dec: Angle.Degrees(-50.96804986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218750"},
        {"Hipparcos Number", "HIP 114477"},
        {"Geneva Identification System", "GEN# +1.00218750"},
        {"Smithsonian Astrophysical Observation", "SAO 247767"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.75639152),
        dec: Angle.Degrees(-50.96770834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -302.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70541"},
        {"Hipparcos Number", "HIP 40862"},
        {"Smithsonian Astrophysical Observation", "SAO 235896"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.07703981),
        dec: Angle.Degrees(-50.96759078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103620"},
        {"Hipparcos Number", "HIP 58174"},
        {"Smithsonian Astrophysical Observation", "SAO 239499"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.97214628),
        dec: Angle.Degrees(-50.96620307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10562"},
        {"Hipparcos Number", "HIP 7920"},
        {"Smithsonian Astrophysical Observation", "SAO 232498"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.44866394),
        dec: Angle.Degrees(-50.96584331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45100"},
        {"Hipparcos Number", "HIP 30322"},
        {"Smithsonian Astrophysical Observation", "SAO 234470"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.66077533),
        dec: Angle.Degrees(-50.96467753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85135"},
        {"Hipparcos Number", "HIP 48094"},
        {"Smithsonian Astrophysical Observation", "SAO 237358"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.08742746),
        dec: Angle.Degrees(-50.96334269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25613"},
        {"Hipparcos Number", "HIP 18785"},
        {"Smithsonian Astrophysical Observation", "SAO 233366"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.37424028),
        dec: Angle.Degrees(-50.95897457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50239"},
        {"Hipparcos Number", "HIP 32739"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.42206496),
        dec: Angle.Degrees(-50.95879697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105973"},
        {"Hipparcos Number", "HIP 59461"},
        {"Geneva Identification System", "GEN# +1.00105973"},
        {"Smithsonian Astrophysical Observation", "SAO 239739"},
    },
    visualMagnitude: 7.67,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.94798640),
        dec: Angle.Degrees(-50.95695340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96484"},
        {"Hipparcos Number", "HIP 54291"},
        {"Geneva Identification System", "GEN# +1.00096484"},
        {"Smithsonian Astrophysical Observation", "SAO 238775"},
        {"Wilson Evans Batten Catalogue", "WEB 9807"},
    },
    visualMagnitude: 6.31,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.61485660),
        dec: Angle.Degrees(-50.95674344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27692"},
        {"Hipparcos Number", "HIP 20191"},
        {"Geneva Identification System", "GEN# +1.00027692"},
        {"Smithsonian Astrophysical Observation", "SAO 233485"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.91126289),
        dec: Angle.Degrees(-50.95673582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78025",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78025"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.98014737),
        dec: Angle.Degrees(-50.95655048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121821"},
        {"Hipparcos Number", "HIP 68325"},
        {"Smithsonian Astrophysical Observation", "SAO 241349"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.79367626),
        dec: Angle.Degrees(-50.95607644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115174"},
        {"Hipparcos Number", "HIP 64752"},
        {"Geneva Identification System", "GEN# +1.00115174"},
        {"Smithsonian Astrophysical Observation", "SAO 240703"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.06055395),
        dec: Angle.Degrees(-50.95507216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143264"},
        {"Hipparcos Number", "HIP 78511"},
        {"Smithsonian Astrophysical Observation", "SAO 243254"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.42075729),
        dec: Angle.Degrees(-50.95371064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187846"},
        {"Hipparcos Number", "HIP 97956"},
        {"Smithsonian Astrophysical Observation", "SAO 246330"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.61951847),
        dec: Angle.Degrees(-50.95277228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15909",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15909"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.21808829),
        dec: Angle.Degrees(-50.95178313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 188.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61566",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61566"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.22845336),
        dec: Angle.Degrees(-50.95045048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135860"},
        {"Hipparcos Number", "HIP 74994"},
        {"Geneva Identification System", "GEN# +1.00135860"},
        {"Smithsonian Astrophysical Observation", "SAO 242411"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.86386759),
        dec: Angle.Degrees(-50.95043474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217403"},
        {"Hipparcos Number", "HIP 113657"},
        {"Geneva Identification System", "GEN# +1.00217403"},
        {"Smithsonian Astrophysical Observation", "SAO 247683"},
        {"Wilson Evans Batten Catalogue", "WEB 20197"},
    },
    visualMagnitude: 5.68,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.28123580),
        dec: Angle.Degrees(-50.95002911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38745"},
        {"Hipparcos Number", "HIP 27131"},
        {"Smithsonian Astrophysical Observation", "SAO 234119"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.29890118),
        dec: Angle.Degrees(-50.94982179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162295"},
        {"Hipparcos Number", "HIP 87535"},
        {"Smithsonian Astrophysical Observation", "SAO 245089"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.24680716),
        dec: Angle.Degrees(-50.94825803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185832"},
        {"Hipparcos Number", "HIP 97060"},
        {"Smithsonian Astrophysical Observation", "SAO 246236"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.87765591),
        dec: Angle.Degrees(-50.94548250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102874"},
        {"Hipparcos Number", "HIP 57746"},
        {"Smithsonian Astrophysical Observation", "SAO 239419"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.62691624),
        dec: Angle.Degrees(-50.94324225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143638"},
        {"Hipparcos Number", "HIP 78697"},
        {"Smithsonian Astrophysical Observation", "SAO 243285"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.97362054),
        dec: Angle.Degrees(-50.94274842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127594"},
        {"Hipparcos Number", "HIP 71225"},
        {"Smithsonian Astrophysical Observation", "SAO 241802"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.47672465),
        dec: Angle.Degrees(-50.94183222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33305"},
        {"Hipparcos Number", "HIP 23785"},
        {"Smithsonian Astrophysical Observation", "SAO 233826"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.67468131),
        dec: Angle.Degrees(-50.94144181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89488",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89488"},
    },
    visualMagnitude: 11.01,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.92431505),
        dec: Angle.Degrees(-50.94003370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213303"},
        {"Hipparcos Number", "HIP 111187"},
        {"Geneva Identification System", "GEN# +1.00213303"},
        {"Smithsonian Astrophysical Observation", "SAO 247470"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.86911873),
        dec: Angle.Degrees(-50.93772639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8315"},
        {"Hipparcos Number", "HIP 6336"},
        {"Smithsonian Astrophysical Observation", "SAO 232390"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.35244159),
        dec: Angle.Degrees(-50.93692359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78740",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78740"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.12016889),
        dec: Angle.Degrees(-50.93505159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136767"},
        {"Hipparcos Number", "HIP 75417"},
        {"Smithsonian Astrophysical Observation", "SAO 242483"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.13076373),
        dec: Angle.Degrees(-50.93470006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109410"},
        {"Hipparcos Number", "HIP 61381"},
        {"Smithsonian Astrophysical Observation", "SAO 240073"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.67993059),
        dec: Angle.Degrees(-50.93323665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12190"},
        {"Hipparcos Number", "HIP 9189"},
        {"Smithsonian Astrophysical Observation", "SAO 232588"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.58263576),
        dec: Angle.Degrees(-50.93295103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85850"},
        {"Hipparcos Number", "HIP 48476"},
        {"Geneva Identification System", "GEN# +1.00085850"},
        {"Smithsonian Astrophysical Observation", "SAO 237451"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.29698908),
        dec: Angle.Degrees(-50.93286439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127485"},
        {"Hipparcos Number", "HIP 71158"},
        {"Smithsonian Astrophysical Observation", "SAO 241789"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.30812525),
        dec: Angle.Degrees(-50.93281293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98137"},
        {"Hipparcos Number", "HIP 55096"},
        {"Geneva Identification System", "GEN# +1.00098137"},
        {"Smithsonian Astrophysical Observation", "SAO 238926"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.20729821),
        dec: Angle.Degrees(-50.92624897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147560"},
        {"Hipparcos Number", "HIP 80436"},
        {"Smithsonian Astrophysical Observation", "SAO 243775"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.27947653),
        dec: Angle.Degrees(-50.92420872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201801"},
        {"Hipparcos Number", "HIP 104793"},
        {"Geneva Identification System", "GEN# +1.00201801"},
        {"Smithsonian Astrophysical Observation", "SAO 246915"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.44888689),
        dec: Angle.Degrees(-50.92412948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60618",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60618"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.36021020),
        dec: Angle.Degrees(-50.92250971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120780"},
        {"Hipparcos Number", "HIP 67742"},
        {"Cincinnati Publication", "Ci 20 817"},
        {"Geneva Identification System", "GEN# +1.00120780"},
        {"Smithsonian Astrophysical Observation", "SAO 241249"},
        {"Wilson Evans Batten Catalogue", "WEB 11910"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.15170971),
        dec: Angle.Degrees(-50.92160377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -583.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151820"},
        {"Hipparcos Number", "HIP 82548"},
        {"Smithsonian Astrophysical Observation", "SAO 244222"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.08676117),
        dec: Angle.Degrees(-50.92120489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89400"},
        {"Hipparcos Number", "HIP 50426"},
        {"Smithsonian Astrophysical Observation", "SAO 237881"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.44275135),
        dec: Angle.Degrees(-50.91969533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99919",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99919"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.09784825),
        dec: Angle.Degrees(-50.91918883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79350"},
        {"Hipparcos Number", "HIP 45129"},
        {"Geneva Identification System", "GEN# +1.00079350"},
        {"Smithsonian Astrophysical Observation", "SAO 236703"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.92511373),
        dec: Angle.Degrees(-50.91708550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71471"},
        {"Hipparcos Number", "HIP 41290"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.36522700),
        dec: Angle.Degrees(-50.91683257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100476"},
        {"Hipparcos Number", "HIP 56370"},
        {"Smithsonian Astrophysical Observation", "SAO 239167"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.32912132),
        dec: Angle.Degrees(-50.91214965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201169"},
        {"Hipparcos Number", "HIP 104467"},
        {"Geneva Identification System", "GEN# +1.00201169"},
        {"Smithsonian Astrophysical Observation", "SAO 246891"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.42918204),
        dec: Angle.Degrees(-50.91023415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112794"},
        {"Hipparcos Number", "HIP 63435"},
        {"Smithsonian Astrophysical Observation", "SAO 240462"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.98510673),
        dec: Angle.Degrees(-50.90971826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224486"},
        {"Hipparcos Number", "HIP 118189"},
        {"Smithsonian Astrophysical Observation", "SAO 248084"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.60389559),
        dec: Angle.Degrees(-50.90898033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140523"},
        {"Henry Draper 2", "HD 140524"},
        {"Hipparcos Number", "HIP 77239"},
        {"Smithsonian Astrophysical Observation", "SAO 242944"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.56297438),
        dec: Angle.Degrees(-50.90827056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79074"},
        {"Hipparcos Number", "HIP 45007"},
        {"Smithsonian Astrophysical Observation", "SAO 236674"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.50331071),
        dec: Angle.Degrees(-50.90748754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76896",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76896"},
    },
    visualMagnitude: 11.53,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.51498664),
        dec: Angle.Degrees(-50.90664884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -143.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -166.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28279"},
        {"Hipparcos Number", "HIP 20618"},
        {"Geneva Identification System", "GEN# +1.00028279"},
        {"Smithsonian Astrophysical Observation", "SAO 233510"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.26536456),
        dec: Angle.Degrees(-50.90600953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81955",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81955"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.13528372),
        dec: Angle.Degrees(-50.89950771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115143"},
        {"Hipparcos Number", "HIP 64734"},
        {"Smithsonian Astrophysical Observation", "SAO 240695"},
    },
    visualMagnitude: 8.49,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.01644379),
        dec: Angle.Degrees(-50.89662088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124233"},
        {"Hipparcos Number", "HIP 69515"},
        {"Smithsonian Astrophysical Observation", "SAO 241554"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.45444651),
        dec: Angle.Degrees(-50.89470336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39489"},
        {"Hipparcos Number", "HIP 27558"},
        {"Smithsonian Astrophysical Observation", "SAO 234155"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.54702691),
        dec: Angle.Degrees(-50.89412931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1842",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1842"},
    },
    visualMagnitude: 11.87,
    bvColour: 1.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.82507861),
        dec: Angle.Degrees(-50.89387237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 548.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222298"},
        {"Hipparcos Number", "HIP 116742"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.88750040),
        dec: Angle.Degrees(-50.89360230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223256"},
        {"Hipparcos Number", "HIP 117389"},
        {"Smithsonian Astrophysical Observation", "SAO 248023"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.02903200),
        dec: Angle.Degrees(-50.89086965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177851"},
        {"Hipparcos Number", "HIP 94069"},
        {"Smithsonian Astrophysical Observation", "SAO 245942"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.25635958),
        dec: Angle.Degrees(-50.88910598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162378"},
        {"Hipparcos Number", "HIP 87575"},
        {"Smithsonian Astrophysical Observation", "SAO 245096"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.36144128),
        dec: Angle.Degrees(-50.88853780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14112"},
        {"Hipparcos Number", "HIP 10506"},
        {"Fundamental Katalog 5th Edition", "FK5 4206"},
        {"Geneva Identification System", "GEN# +1.00014112"},
        {"Smithsonian Astrophysical Observation", "SAO 232686"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.85425028),
        dec: Angle.Degrees(-50.88711142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93199"},
        {"Hipparcos Number", "HIP 52564"},
        {"Geneva Identification System", "GEN# +1.00093199"},
        {"Smithsonian Astrophysical Observation", "SAO 238420"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.836,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.19970693),
        dec: Angle.Degrees(-50.88504909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124525"},
        {"Hipparcos Number", "HIP 69668"},
        {"Geneva Identification System", "GEN# +1.00124525"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.90126351),
        dec: Angle.Degrees(-50.88437888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70509"},
        {"Hipparcos Number", "HIP 40840"},
        {"Geneva Identification System", "GEN# +1.00070509"},
        {"Smithsonian Astrophysical Observation", "SAO 235889"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.00991706),
        dec: Angle.Degrees(-50.88372238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 91.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87815"},
        {"Hipparcos Number", "HIP 49494"},
        {"Smithsonian Astrophysical Observation", "SAO 237692"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.56742170),
        dec: Angle.Degrees(-50.88257311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116455"},
        {"Hipparcos Number", "HIP 65438"},
        {"Geneva Identification System", "GEN# +1.00116455"},
        {"Smithsonian Astrophysical Observation", "SAO 240816"},
    },
    visualMagnitude: 10.33,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.16989766),
        dec: Angle.Degrees(-50.88199838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168547"},
        {"Hipparcos Number", "HIP 90073"},
        {"Smithsonian Astrophysical Observation", "SAO 245433"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.71923020),
        dec: Angle.Degrees(-50.88108370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2634"},
        {"Hipparcos Number", "HIP 2321"},
        {"Smithsonian Astrophysical Observation", "SAO 232064"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.40532024),
        dec: Angle.Degrees(-50.87999493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170611"},
        {"Hipparcos Number", "HIP 90933"},
        {"Smithsonian Astrophysical Observation", "SAO 245546"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.24184884),
        dec: Angle.Degrees(-50.87988225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119742"},
        {"Hipparcos Number", "HIP 67188"},
        {"Smithsonian Astrophysical Observation", "SAO 241151"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.53761372),
        dec: Angle.Degrees(-50.87987440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169901"},
        {"Hipparcos Number", "HIP 90628"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.38729442),
        dec: Angle.Degrees(-50.87793482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20841"},
        {"Hipparcos Number", "HIP 15451"},
        {"Smithsonian Astrophysical Observation", "SAO 233072"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.82324986),
        dec: Angle.Degrees(-50.87529251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136667"},
        {"Hipparcos Number", "HIP 75360"},
        {"Smithsonian Astrophysical Observation", "SAO 242475"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.99717477),
        dec: Angle.Degrees(-50.87427486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173047"},
        {"Hipparcos Number", "HIP 92072"},
        {"Smithsonian Astrophysical Observation", "SAO 245693"},
    },
    visualMagnitude: 6.24,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.48330795),
        dec: Angle.Degrees(-50.87267791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18265"},
        {"Hipparcos Number", "HIP 13518"},
        {"Fundamental Katalog 5th Edition", "FK5 2202"},
        {"Geneva Identification System", "GEN# +1.00018265"},
        {"Smithsonian Astrophysical Observation", "SAO 232933"},
    },
    visualMagnitude: 6.22,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.52696642),
        dec: Angle.Degrees(-50.87141943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66096",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66096"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.23803482),
        dec: Angle.Degrees(-50.87050479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84789"},
        {"Hipparcos Number", "HIP 47921"},
        {"Geneva Identification System", "GEN# +1.00084789"},
        {"Smithsonian Astrophysical Observation", "SAO 237319"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.49999859),
        dec: Angle.Degrees(-50.86948576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194902"},
        {"Hipparcos Number", "HIP 101169"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.59593674),
        dec: Angle.Degrees(-50.86879069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186194"},
        {"Hipparcos Number", "HIP 97213"},
        {"Geneva Identification System", "GEN# +1.00186194"},
        {"Smithsonian Astrophysical Observation", "SAO 246253"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.36094525),
        dec: Angle.Degrees(-50.86745163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -227.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224717"},
        {"Hipparcos Number", "HIP 10"},
        {"Smithsonian Astrophysical Observation", "SAO 248096"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.03625309),
        dec: Angle.Degrees(-50.86707360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60865"},
        {"Hipparcos Number", "HIP 36784"},
        {"Geneva Identification System", "GEN# +1.00060865"},
        {"Smithsonian Astrophysical Observation", "SAO 235300"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.48872577),
        dec: Angle.Degrees(-50.86643767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39797"},
        {"Hipparcos Number", "HIP 27711"},
        {"Smithsonian Astrophysical Observation", "SAO 234177"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.02045735),
        dec: Angle.Degrees(-50.86606646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155621"},
        {"Hipparcos Number", "HIP 84414"},
        {"Smithsonian Astrophysical Observation", "SAO 244561"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.86539501),
        dec: Angle.Degrees(-50.86473088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77273"},
        {"Hipparcos Number", "HIP 44156"},
        {"Smithsonian Astrophysical Observation", "SAO 236470"},
    },
    visualMagnitude: 8.36,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.89365096),
        dec: Angle.Degrees(-50.86441149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98557"},
        {"Hipparcos Number", "HIP 55335"},
        {"Smithsonian Astrophysical Observation", "SAO 238968"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.97731867),
        dec: Angle.Degrees(-50.86198261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11725"},
        {"Hipparcos Number", "HIP 8840"},
        {"Smithsonian Astrophysical Observation", "SAO 232562"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.41492389),
        dec: Angle.Degrees(-50.86083819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133958"},
        {"Hipparcos Number", "HIP 74157"},
        {"Smithsonian Astrophysical Observation", "SAO 242264"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.869,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.28626719),
        dec: Angle.Degrees(-50.86005334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175629"},
        {"Hipparcos Number", "HIP 93182"},
        {"Geneva Identification System", "GEN# +1.00175629"},
        {"Smithsonian Astrophysical Observation", "SAO 245841"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.70109230),
        dec: Angle.Degrees(-50.85967968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113553"},
        {"Hipparcos Number", "HIP 63862"},
        {"Geneva Identification System", "GEN# +1.00113553"},
        {"Smithsonian Astrophysical Observation", "SAO 240531"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.32054609),
        dec: Angle.Degrees(-50.85660616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -134.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188906"},
        {"Hipparcos Number", "HIP 98415"},
        {"Smithsonian Astrophysical Observation", "SAO 246373"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.94653376),
        dec: Angle.Degrees(-50.85581054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219269"},
        {"Hipparcos Number", "HIP 114789"},
        {"Smithsonian Astrophysical Observation", "SAO 247797"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.78742129),
        dec: Angle.Degrees(-50.85518569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38991"},
        {"Hipparcos Number", "HIP 27271"},
        {"Smithsonian Astrophysical Observation", "SAO 234131"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.69388421),
        dec: Angle.Degrees(-50.85477408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57968"},
        {"Hipparcos Number", "HIP 35621"},
        {"Smithsonian Astrophysical Observation", "SAO 235126"},
    },
    visualMagnitude: 7.31,
    bvColour: -0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.25705855),
        dec: Angle.Degrees(-50.85426382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76716"},
        {"Hipparcos Number", "HIP 43847"},
        {"Smithsonian Astrophysical Observation", "SAO 236411"},
    },
    visualMagnitude: 8.35,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.96630272),
        dec: Angle.Degrees(-50.85409990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72471"},
        {"Hipparcos Number", "HIP 41756"},
        {"Smithsonian Astrophysical Observation", "SAO 236043"},
    },
    visualMagnitude: 8.36,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.71943730),
        dec: Angle.Degrees(-50.85351305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16346"},
        {"Hipparcos Number", "HIP 12060"},
        {"Geneva Identification System", "GEN# +1.00016346"},
        {"Smithsonian Astrophysical Observation", "SAO 232825"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.88125586),
        dec: Angle.Degrees(-50.85334894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64427",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64427"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.08454919),
        dec: Angle.Degrees(-50.85298330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68401",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68401"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.03179808),
        dec: Angle.Degrees(-50.85293373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -135.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123528"},
        {"Hipparcos Number", "HIP 69177"},
        {"Smithsonian Astrophysical Observation", "SAO 241493"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.40440121),
        dec: Angle.Degrees(-50.85087157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210428"},
        {"Hipparcos Number", "HIP 109564"},
        {"Smithsonian Astrophysical Observation", "SAO 247348"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.91594243),
        dec: Angle.Degrees(-50.85047559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204554"},
        {"Hipparcos Number", "HIP 106234"},
        {"Geneva Identification System", "GEN# +1.00204554"},
        {"Smithsonian Astrophysical Observation", "SAO 247061"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.76349963),
        dec: Angle.Degrees(-50.84681408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13523",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13523"},
        {"Smithsonian Astrophysical Observation", "SAO 232934"},
        {"Smithsonian Astrophysical Observation 2", "SAO 232935"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.54065588),
        dec: Angle.Degrees(-50.84631749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205390"},
        {"Hipparcos Number", "HIP 106696"},
        {"Cincinnati Publication", "Ci 20 1296"},
        {"Geneva Identification System", "GEN# +1.00205390"},
        {"Smithsonian Astrophysical Observation", "SAO 247109"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.17021740),
        dec: Angle.Degrees(-50.84490039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 424.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -199.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143906"},
        {"Hipparcos Number", "HIP 78805"},
        {"Geneva Identification System", "GEN# +1.00143906"},
        {"Smithsonian Astrophysical Observation", "SAO 243313"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.32240201),
        dec: Angle.Degrees(-50.84482514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83760"},
        {"Hipparcos Number", "HIP 47367"},
        {"Geneva Identification System", "GEN# +1.00083760"},
        {"Smithsonian Astrophysical Observation", "SAO 237187"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.76364200),
        dec: Angle.Degrees(-50.84461429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157219"},
        {"Hipparcos Number", "HIP 85217"},
        {"Geneva Identification System", "GEN# +1.00157219"},
        {"Smithsonian Astrophysical Observation", "SAO 244719"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.19777103),
        dec: Angle.Degrees(-50.84305554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2029",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2029"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.43151179),
        dec: Angle.Degrees(-50.84268490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 153.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38481",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38481"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.21722220),
        dec: Angle.Degrees(-50.84101868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60907"},
        {"Hipparcos Number", "HIP 36802"},
        {"Smithsonian Astrophysical Observation", "SAO 235303"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.53617942),
        dec: Angle.Degrees(-50.84064633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143625"},
        {"Hipparcos Number", "HIP 78694"},
        {"Smithsonian Astrophysical Observation", "SAO 243284"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.96965402),
        dec: Angle.Degrees(-50.84002968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163460"},
        {"Hipparcos Number", "HIP 88043"},
        {"Smithsonian Astrophysical Observation", "SAO 245153"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.74221495),
        dec: Angle.Degrees(-50.83942362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157178"},
        {"Hipparcos Number", "HIP 85182"},
        {"Geneva Identification System", "GEN# +1.00157178"},
        {"Smithsonian Astrophysical Observation", "SAO 244712"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.11396539),
        dec: Angle.Degrees(-50.83927462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134095"},
        {"Hipparcos Number", "HIP 74215"},
        {"Smithsonian Astrophysical Observation", "SAO 242269"},
    },
    visualMagnitude: 8.41,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.49189403),
        dec: Angle.Degrees(-50.83823963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98237",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98237"},
        {"Geneva Identification System", "GEN# -0.02105582"},
    },
    visualMagnitude: 10.80,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.44911459),
        dec: Angle.Degrees(-21.52624175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -238.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -216.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2202"},
        {"Hipparcos Number", "HIP 2028"},
        {"Renson", "Renson 520"},
        {"Smithsonian Astrophysical Observation", "SAO 232036"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.43047312),
        dec: Angle.Degrees(-50.83812542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 148.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193694"},
        {"Hipparcos Number", "HIP 100580"},
        {"Smithsonian Astrophysical Observation", "SAO 246558"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.95156334),
        dec: Angle.Degrees(-50.83791317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67162",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67162"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.45777028),
        dec: Angle.Degrees(-50.83736705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6945"},
        {"Hipparcos Number", "HIP 5401"},
        {"Smithsonian Astrophysical Observation", "SAO 232311"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.28125501),
        dec: Angle.Degrees(-50.83592724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66442",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66442"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.31192685),
        dec: Angle.Degrees(-50.83567231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19916"},
        {"Hipparcos Number", "HIP 14710"},
        {"Fundamental Katalog 5th Edition", "FK5 2223"},
        {"Geneva Identification System", "GEN# +1.00019916"},
        {"Smithsonian Astrophysical Observation", "SAO 233015"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.51621606),
        dec: Angle.Degrees(-50.83245155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88497"},
        {"Hipparcos Number", "HIP 49877"},
        {"Geneva Identification System", "GEN# +1.00088497"},
        {"Smithsonian Astrophysical Observation", "SAO 237762"},
    },
    visualMagnitude: 8.12,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.76264616),
        dec: Angle.Degrees(-50.83011412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149693"},
        {"Hipparcos Number", "HIP 81510"},
        {"Smithsonian Astrophysical Observation", "SAO 244023"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.73037017),
        dec: Angle.Degrees(-50.83011306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71578",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71578"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.57725820),
        dec: Angle.Degrees(-50.82651803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61653",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61653"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.57560067),
        dec: Angle.Degrees(-50.82601504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77793"},
        {"Hipparcos Number", "HIP 44403"},
        {"Celescope Catalog", "CEL 3164"},
        {"Geneva Identification System", "GEN# +1.00077793"},
        {"Smithsonian Astrophysical Observation", "SAO 236531"},
    },
    visualMagnitude: 8.13,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.67901273),
        dec: Angle.Degrees(-50.82571852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13445"},
        {"Hipparcos Number", "HIP 10138"},
        {"Cincinnati Publication", "Ci 20 151"},
        {"Geneva Identification System", "GEN# +1.00013445"},
        {"Smithsonian Astrophysical Observation", "SAO 232658"},
        {"Wilson Evans Batten Catalogue", "WEB 2116"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.60000721),
        dec: Angle.Degrees(-50.82531507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2092.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 654.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84571"},
        {"Hipparcos Number", "HIP 47787"},
        {"Geneva Identification System", "GEN# +1.00084571"},
        {"Smithsonian Astrophysical Observation", "SAO 237288"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.14884647),
        dec: Angle.Degrees(-50.82515440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89463"},
        {"Hipparcos Number", "HIP 50463"},
        {"Renson", "Renson 25690"},
        {"Smithsonian Astrophysical Observation", "SAO 237890"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.55007035),
        dec: Angle.Degrees(-50.82372252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98568"},
        {"Hipparcos Number", "HIP 55339"},
        {"Smithsonian Astrophysical Observation", "SAO 238969"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.98834943),
        dec: Angle.Degrees(-50.82363444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131324"},
        {"Hipparcos Number", "HIP 72972"},
        {"Smithsonian Astrophysical Observation", "SAO 242109"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.69685690),
        dec: Angle.Degrees(-50.82311882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173264"},
        {"Hipparcos Number", "HIP 92159"},
        {"Smithsonian Astrophysical Observation", "SAO 245701"},
    },
    visualMagnitude: 8.20,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.74995477),
        dec: Angle.Degrees(-50.82223586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198955"},
        {"Hipparcos Number", "HIP 103310"},
        {"Smithsonian Astrophysical Observation", "SAO 246795"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.94817709),
        dec: Angle.Degrees(-50.82151018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22176"},
        {"Hipparcos Number", "HIP 16475"},
        {"Geneva Identification System", "GEN# +1.00022176"},
        {"Smithsonian Astrophysical Observation", "SAO 233150"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.04128200),
        dec: Angle.Degrees(-50.81958158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14397"},
        {"Hipparcos Number", "HIP 10725"},
        {"Smithsonian Astrophysical Observation", "SAO 232702"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.50919192),
        dec: Angle.Degrees(-50.81896550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 139.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 88.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64140"},
        {"Hipparcos Number", "HIP 38229"},
        {"Smithsonian Astrophysical Observation", "SAO 235547"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.48048277),
        dec: Angle.Degrees(-50.81813248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97551"},
        {"Hipparcos Number", "HIP 54785"},
        {"Smithsonian Astrophysical Observation", "SAO 238865"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.23712490),
        dec: Angle.Degrees(-50.81709101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110484"},
        {"Hipparcos Number", "HIP 62032"},
        {"Geneva Identification System", "GEN# +1.00110484"},
        {"Smithsonian Astrophysical Observation", "SAO 240178"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.72869983),
        dec: Angle.Degrees(-50.81666857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10934"},
        {"Hipparcos Number", "HIP 8240"},
        {"Geneva Identification System", "GEN# +1.00010934"},
        {"Smithsonian Astrophysical Observation", "SAO 232519"},
        {"Wilson Evans Batten Catalogue", "WEB 1755"},
    },
    visualMagnitude: 5.49,
    bvColour: 1.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.52469172),
        dec: Angle.Degrees(-50.81621317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186250"},
        {"Hipparcos Number", "HIP 97227"},
        {"Smithsonian Astrophysical Observation", "SAO 246256"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.41513962),
        dec: Angle.Degrees(-50.81487901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106845",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106845"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.61268851),
        dec: Angle.Degrees(-50.81194389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74457"},
        {"Hipparcos Number", "HIP 42682"},
        {"Smithsonian Astrophysical Observation", "SAO 236193"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.49378648),
        dec: Angle.Degrees(-50.80950580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223342"},
        {"Hipparcos Number", "HIP 117455"},
        {"Geneva Identification System", "GEN# +1.00223342"},
        {"Smithsonian Astrophysical Observation", "SAO 248027"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.23880501),
        dec: Angle.Degrees(-50.80883684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104775"},
        {"Hipparcos Number", "HIP 58826"},
        {"Smithsonian Astrophysical Observation", "SAO 239626"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.98241489),
        dec: Angle.Degrees(-50.80843970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6612",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6612"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.22211227),
        dec: Angle.Degrees(-50.80823816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 246.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77120"},
        {"Hipparcos Number", "HIP 44067"},
        {"Geneva Identification System", "GEN# +1.00077120"},
        {"Smithsonian Astrophysical Observation", "SAO 236456"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.62813691),
        dec: Angle.Degrees(-50.80700472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179034"},
        {"Hipparcos Number", "HIP 94458"},
        {"Geneva Identification System", "GEN# +1.00179034"},
        {"Smithsonian Astrophysical Observation", "SAO 245980"},
        {"Wilson Evans Batten Catalogue", "WEB 16462"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.38767824),
        dec: Angle.Degrees(-50.80669302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59628",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59628"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.41418199),
        dec: Angle.Degrees(-50.80560997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197544"},
        {"Hipparcos Number", "HIP 102506"},
        {"Smithsonian Astrophysical Observation", "SAO 246725"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.61275090),
        dec: Angle.Degrees(-50.80549116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212038"},
        {"Hipparcos Number", "HIP 110468"},
        {"Cincinnati Publication", "Ci 20 1356"},
        {"Geneva Identification System", "GEN# +1.00212038"},
        {"Smithsonian Astrophysical Observation", "SAO 247427"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.64880294),
        dec: Angle.Degrees(-50.80490412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1058.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56009",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56009"},
        {"Geneva Identification System", "GEN# -0.05006041"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.17102234),
        dec: Angle.Degrees(-50.80460921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 160.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181326"},
        {"Hipparcos Number", "HIP 95242"},
        {"Smithsonian Astrophysical Observation", "SAO 246054"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.66051236),
        dec: Angle.Degrees(-50.80390979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213700"},
        {"Hipparcos Number", "HIP 111412"},
        {"Smithsonian Astrophysical Observation", "SAO 247491"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.57823680),
        dec: Angle.Degrees(-50.80375225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 183.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107665"},
        {"Hipparcos Number", "HIP 60359"},
        {"Smithsonian Astrophysical Observation", "SAO 239896"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.64610795),
        dec: Angle.Degrees(-50.80287243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21505"},
        {"Hipparcos Number", "HIP 15990"},
        {"Geneva Identification System", "GEN# +1.00021505"},
        {"Smithsonian Astrophysical Observation", "SAO 233113"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.49129766),
        dec: Angle.Degrees(-50.80252665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4519"},
        {"Hipparcos Number", "HIP 3644"},
        {"Geneva Identification System", "GEN# +1.00004519"},
        {"Smithsonian Astrophysical Observation", "SAO 232178"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.66803053),
        dec: Angle.Degrees(-50.80164259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 130.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17051"},
        {"Hipparcos Number", "HIP 12653"},
        {"Geneva Identification System", "GEN# +1.00017051"},
        {"Smithsonian Astrophysical Observation", "SAO 232864"},
        {"Wilson Evans Batten Catalogue", "WEB 2575"},
    },
    visualMagnitude: 5.40,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.63816025),
        dec: Angle.Degrees(-50.80082665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 333.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 219.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217029"},
        {"Hipparcos Number", "HIP 113434"},
        {"Smithsonian Astrophysical Observation", "SAO 247661"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.60491659),
        dec: Angle.Degrees(-50.79869009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78788"},
        {"Hipparcos Number", "HIP 44842"},
        {"Smithsonian Astrophysical Observation", "SAO 236639"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.04726321),
        dec: Angle.Degrees(-50.79825237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57967"},
        {"Hipparcos Number", "HIP 35618"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.24754517),
        dec: Angle.Degrees(-50.79797256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137082"},
        {"Hipparcos Number", "HIP 75555"},
        {"Geneva Identification System", "GEN# +1.00137082"},
        {"Smithsonian Astrophysical Observation", "SAO 242520"},
        {"Wilson Evans Batten Catalogue", "WEB 12874"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.52549690),
        dec: Angle.Degrees(-50.79775446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211756"},
        {"Hipparcos Number", "HIP 110303"},
        {"Geneva Identification System", "GEN# +1.00211756"},
        {"Smithsonian Astrophysical Observation", "SAO 247411"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.12463629),
        dec: Angle.Degrees(-50.79698993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99808",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99808"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.76461362),
        dec: Angle.Degrees(-50.79638806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23368"},
        {"Hipparcos Number", "HIP 17314"},
        {"Smithsonian Astrophysical Observation", "SAO 233231"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.59507025),
        dec: Angle.Degrees(-50.79578868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81787",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81787"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.57297351),
        dec: Angle.Degrees(-50.79317013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32761"},
        {"Hipparcos Number", "HIP 23480"},
        {"Smithsonian Astrophysical Observation", "SAO 233798"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.70109879),
        dec: Angle.Degrees(-50.79310331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -171.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43140"},
        {"Hipparcos Number", "HIP 29418"},
        {"Smithsonian Astrophysical Observation", "SAO 234367"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.96669284),
        dec: Angle.Degrees(-50.79271985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117941"},
        {"Hipparcos Number", "HIP 66259"},
        {"Smithsonian Astrophysical Observation", "SAO 240961"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.70760306),
        dec: Angle.Degrees(-50.79224485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65978",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65978"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.91064297),
        dec: Angle.Degrees(-50.79066308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119193"},
        {"Hipparcos Number", "HIP 66923"},
        {"Geneva Identification System", "GEN# +1.00119193"},
        {"Smithsonian Astrophysical Observation", "SAO 241098"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.72767233),
        dec: Angle.Degrees(-50.79019786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200810"},
        {"Hipparcos Number", "HIP 104282"},
        {"Geneva Identification System", "GEN# +1.00200810"},
        {"Smithsonian Astrophysical Observation", "SAO 246876"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.89640627),
        dec: Angle.Degrees(-50.78981820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98980"},
        {"Hipparcos Number", "HIP 55569"},
        {"Smithsonian Astrophysical Observation", "SAO 239012"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.72809492),
        dec: Angle.Degrees(-50.78668814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140274"},
        {"Hipparcos Number", "HIP 77138"},
        {"Smithsonian Astrophysical Observation", "SAO 242915"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.24839094),
        dec: Angle.Degrees(-50.78540737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145598"},
        {"Hipparcos Number", "HIP 79576"},
        {"Geneva Identification System", "GEN# +1.00145598"},
        {"Smithsonian Astrophysical Observation", "SAO 243477"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.54131195),
        dec: Angle.Degrees(-50.78380559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -440.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160996"},
        {"Hipparcos Number", "HIP 86921"},
        {"Smithsonian Astrophysical Observation", "SAO 245004"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.41191506),
        dec: Angle.Degrees(-50.78162921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76007"},
        {"Hipparcos Number", "HIP 43483"},
        {"Geneva Identification System", "GEN# +1.00076007"},
        {"Smithsonian Astrophysical Observation", "SAO 236331"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.85675102),
        dec: Angle.Degrees(-50.77940183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14556"},
        {"Hipparcos Number", "HIP 10843"},
        {"Smithsonian Astrophysical Observation", "SAO 232709"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.89031153),
        dec: Angle.Degrees(-50.77792589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193284"},
        {"Hipparcos Number", "HIP 100411"},
        {"Smithsonian Astrophysical Observation", "SAO 246545"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.42156381),
        dec: Angle.Degrees(-50.77636552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125810"},
        {"Hipparcos Number", "HIP 70325"},
        {"Fundamental Katalog 5th Edition", "FK5 3138"},
        {"Geneva Identification System", "GEN# +1.00125810J"},
        {"Smithsonian Astrophysical Observation", "SAO 241686"},
    },
    visualMagnitude: 6.03,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.83443353),
        dec: Angle.Degrees(-50.77223430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120414"},
        {"Hipparcos Number", "HIP 67542"},
        {"Smithsonian Astrophysical Observation", "SAO 241212"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.59050144),
        dec: Angle.Degrees(-50.77092871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105994"},
        {"Hipparcos Number", "HIP 59481"},
        {"Geneva Identification System", "GEN# +1.00105994"},
        {"Smithsonian Astrophysical Observation", "SAO 239742"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.99525159),
        dec: Angle.Degrees(-50.77011926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73630",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73630"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.75799811),
        dec: Angle.Degrees(-50.76985180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89738"},
        {"Hipparcos Number", "HIP 50595"},
        {"Smithsonian Astrophysical Observation", "SAO 237928"},
    },
    visualMagnitude: 9.07,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.03464519),
        dec: Angle.Degrees(-50.76949294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61455",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61455"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.90652524),
        dec: Angle.Degrees(-50.76676599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183027"},
        {"Hipparcos Number", "HIP 95889"},
        {"Smithsonian Astrophysical Observation", "SAO 246128"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.52221861),
        dec: Angle.Degrees(-50.76665255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94985"},
        {"Hipparcos Number", "HIP 53530"},
        {"Fundamental Katalog 5th Edition", "FK5 2874"},
        {"Geneva Identification System", "GEN# +1.00094985"},
        {"Smithsonian Astrophysical Observation", "SAO 238622"},
        {"Wilson Evans Batten Catalogue", "WEB 9718"},
    },
    visualMagnitude: 5.90,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.28284129),
        dec: Angle.Degrees(-50.76504906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103713"},
        {"Hipparcos Number", "HIP 58226"},
        {"Smithsonian Astrophysical Observation", "SAO 239509"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.12949594),
        dec: Angle.Degrees(-50.75970158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102061"},
        {"Hipparcos Number", "HIP 57259"},
        {"Smithsonian Astrophysical Observation", "SAO 239338"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.13245138),
        dec: Angle.Degrees(-50.75848407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51967"},
        {"Hipparcos Number", "HIP 33400"},
        {"Smithsonian Astrophysical Observation", "SAO 234801"},
    },
    visualMagnitude: 8.35,
    bvColour: -0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.20312226),
        dec: Angle.Degrees(-50.75612824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38213"},
        {"Hipparcos Number", "HIP 26788"},
        {"Smithsonian Astrophysical Observation", "SAO 234091"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.34792044),
        dec: Angle.Degrees(-50.75479643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222323"},
        {"Hipparcos Number", "HIP 116752"},
        {"Smithsonian Astrophysical Observation", "SAO 247967"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.93127523),
        dec: Angle.Degrees(-50.75452758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24023"},
        {"Hipparcos Number", "HIP 17688"},
        {"Fundamental Katalog 5th Edition", "FK5 2271"},
        {"Smithsonian Astrophysical Observation", "SAO 233270"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.83224219),
        dec: Angle.Degrees(-50.75387949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141234"},
        {"Hipparcos Number", "HIP 77579"},
        {"Smithsonian Astrophysical Observation", "SAO 243032"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.58101830),
        dec: Angle.Degrees(-50.75365573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145413"},
        {"Hipparcos Number", "HIP 79474"},
        {"Smithsonian Astrophysical Observation", "SAO 243450"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.29280958),
        dec: Angle.Degrees(-50.75258052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75050"},
        {"Hipparcos Number", "HIP 42972"},
        {"Smithsonian Astrophysical Observation", "SAO 236242"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.37539118),
        dec: Angle.Degrees(-50.75256152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183861"},
        {"Hipparcos Number", "HIP 96221"},
        {"Smithsonian Astrophysical Observation", "SAO 246165"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.50540671),
        dec: Angle.Degrees(-50.75243162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121176"},
        {"Hipparcos Number", "HIP 67957"},
        {"Smithsonian Astrophysical Observation", "SAO 241289"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.75547569),
        dec: Angle.Degrees(-50.75053328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160306"},
        {"Hipparcos Number", "HIP 86589"},
        {"Smithsonian Astrophysical Observation", "SAO 244948"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.43673032),
        dec: Angle.Degrees(-50.74990353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76968"},
        {"Hipparcos Number", "HIP 43989"},
        {"Celescope Catalog", "CEL 3107"},
        {"Geneva Identification System", "GEN# +1.00076968"},
        {"Smithsonian Astrophysical Observation", "SAO 236442"},
        {"Wilson Evans Batten Catalogue", "WEB 8457"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.37022657),
        dec: Angle.Degrees(-50.74950023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189858"},
        {"Hipparcos Number", "HIP 98855"},
        {"Smithsonian Astrophysical Observation", "SAO 246420"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.11480521),
        dec: Angle.Degrees(-50.74916134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147559"},
        {"Hipparcos Number", "HIP 80430"},
        {"Geneva Identification System", "GEN# +1.00147559"},
        {"Smithsonian Astrophysical Observation", "SAO 243772"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.25888088),
        dec: Angle.Degrees(-50.74846927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134220"},
        {"Hipparcos Number", "HIP 74255"},
        {"Geneva Identification System", "GEN# +1.00134220"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.828,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.63459990),
        dec: Angle.Degrees(-50.74717456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47846",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47846"},
    },
    visualMagnitude: 11.43,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.28966802),
        dec: Angle.Degrees(-50.74694034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128777"},
        {"Hipparcos Number", "HIP 71739"},
        {"Smithsonian Astrophysical Observation", "SAO 241900"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.12456110),
        dec: Angle.Degrees(-50.74654485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147601"},
        {"Hipparcos Number", "HIP 80445"},
        {"Geneva Identification System", "GEN# +1.00147601"},
        {"Smithsonian Astrophysical Observation", "SAO 243779"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.31769757),
        dec: Angle.Degrees(-50.74578825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121189"},
        {"Hipparcos Number", "HIP 67970"},
        {"Smithsonian Astrophysical Observation", "SAO 241293"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.79175256),
        dec: Angle.Degrees(-50.74521319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204183"},
        {"Hipparcos Number", "HIP 106029"},
        {"Smithsonian Astrophysical Observation", "SAO 247042"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.13391649),
        dec: Angle.Degrees(-50.74481903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84652"},
        {"Hipparcos Number", "HIP 47848"},
        {"Smithsonian Astrophysical Observation", "SAO 237301"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.29546746),
        dec: Angle.Degrees(-50.74460501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100838"},
        {"Hipparcos Number", "HIP 56577"},
        {"Geneva Identification System", "GEN# +1.00100838"},
        {"Smithsonian Astrophysical Observation", "SAO 239207"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.99554601),
        dec: Angle.Degrees(-50.74244189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12632"},
        {"Hipparcos Number", "HIP 9512"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.59128609),
        dec: Angle.Degrees(-50.73970341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3562"},
        {"Hipparcos Number", "HIP 2993"},
        {"Smithsonian Astrophysical Observation", "SAO 232120"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.50994024),
        dec: Angle.Degrees(-50.73396129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15710"},
        {"Hipparcos Number", "HIP 11620"},
        {"Smithsonian Astrophysical Observation", "SAO 232791"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.47287835),
        dec: Angle.Degrees(-50.73288868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24879"},
        {"Hipparcos Number", "HIP 18316"},
        {"Smithsonian Astrophysical Observation", "SAO 233322"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.74049087),
        dec: Angle.Degrees(-50.73241708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76145",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76145"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.29053252),
        dec: Angle.Degrees(-50.73198964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158781"},
        {"Hipparcos Number", "HIP 85937"},
        {"Smithsonian Astrophysical Observation", "SAO 244846"},
    },
    visualMagnitude: 7.76,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.44485401),
        dec: Angle.Degrees(-50.73103689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14269",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14269"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.99486108),
        dec: Angle.Degrees(-50.72858412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34953"},
        {"Hipparcos Number", "HIP 24756"},
        {"Smithsonian Astrophysical Observation", "SAO 233921"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.62031635),
        dec: Angle.Degrees(-50.72812858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198766"},
        {"Hipparcos Number", "HIP 103206"},
        {"Geneva Identification System", "GEN# +1.00198766"},
        {"Renson", "Renson 55330"},
        {"Smithsonian Astrophysical Observation", "SAO 246786"},
        {"Wilson Evans Batten Catalogue", "WEB 18746"},
    },
    visualMagnitude: 6.23,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.64623925),
        dec: Angle.Degrees(-50.72730230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41439",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41439"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.77008316),
        dec: Angle.Degrees(-50.72643833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160305"},
        {"Hipparcos Number", "HIP 86598"},
        {"Smithsonian Astrophysical Observation", "SAO 244950"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.45433567),
        dec: Angle.Degrees(-50.72429568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71328",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71328"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.79776819),
        dec: Angle.Degrees(-50.72349654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100786"},
        {"Hipparcos Number", "HIP 56543"},
        {"Smithsonian Astrophysical Observation", "SAO 239204"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.90844565),
        dec: Angle.Degrees(-50.72346264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191411"},
        {"Hipparcos Number", "HIP 99537"},
        {"Geneva Identification System", "GEN# +1.00191411"},
        {"Smithsonian Astrophysical Observation", "SAO 246480"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.01194871),
        dec: Angle.Degrees(-50.72295063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105435"},
        {"Hipparcos Number", "HIP 59196"},
        {"Fundamental Katalog 5th Edition", "FK5 452"},
        {"Geneva Identification System", "GEN# +1.00105435"},
        {"Smithsonian Astrophysical Observation", "SAO 239689"},
        {"Wilson Evans Batten Catalogue", "WEB 10531"},
    },
    visualMagnitude: 2.58,
    bvColour: -0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.08976505),
        dec: Angle.Degrees(-50.72240999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105306",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105306"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.93110085),
        dec: Angle.Degrees(-50.72239248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170946"},
        {"Hipparcos Number", "HIP 91084"},
        {"Smithsonian Astrophysical Observation", "SAO 245561"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.67492448),
        dec: Angle.Degrees(-50.72169328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58376",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58376"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.55807771),
        dec: Angle.Degrees(-50.72163865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89587"},
        {"Hipparcos Number", "HIP 50519"},
        {"Geneva Identification System", "GEN# +1.00089587"},
        {"Smithsonian Astrophysical Observation", "SAO 237905"},
        {"Wilson Evans Batten Catalogue", "WEB 9268"},
    },
    visualMagnitude: 6.89,
    bvColour: -0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.76072822),
        dec: Angle.Degrees(-50.71611633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36417"},
        {"Hipparcos Number", "HIP 25663"},
        {"Smithsonian Astrophysical Observation", "SAO 233991"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.21588937),
        dec: Angle.Degrees(-50.71532887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99573"},
        {"Hipparcos Number", "HIP 55855"},
        {"Smithsonian Astrophysical Observation", "SAO 239075"},
    },
    visualMagnitude: 8.84,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.71187773),
        dec: Angle.Degrees(-50.71381944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173756"},
        {"Hipparcos Number", "HIP 92373"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.37459734),
        dec: Angle.Degrees(-50.71190623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126872"},
        {"Hipparcos Number", "HIP 70882"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.43231533),
        dec: Angle.Degrees(-50.71146742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55850",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55850"},
        {"Smithsonian Astrophysical Observation", "SAO 239073"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.70098223),
        dec: Angle.Degrees(-50.71013820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65295"},
        {"Hipparcos Number", "HIP 38715"},
        {"Smithsonian Astrophysical Observation", "SAO 235623"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.89428722),
        dec: Angle.Degrees(-50.70899099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39606"},
        {"Hipparcos Number", "HIP 27622"},
        {"Smithsonian Astrophysical Observation", "SAO 234168"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.72305497),
        dec: Angle.Degrees(-50.70870474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173560"},
        {"Hipparcos Number", "HIP 92288"},
        {"Geneva Identification System", "GEN# +1.00173560"},
        {"Smithsonian Astrophysical Observation", "SAO 245721"},
        {"Wilson Evans Batten Catalogue", "WEB 15925"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.13868840),
        dec: Angle.Degrees(-50.70279751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -209.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144648"},
        {"Hipparcos Number", "HIP 79148"},
        {"Smithsonian Astrophysical Observation", "SAO 243376"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.31633793),
        dec: Angle.Degrees(-50.70133547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 808"},
        {"Hipparcos Number", "HIP 990"},
        {"Smithsonian Astrophysical Observation", "SAO 231969"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.07200125),
        dec: Angle.Degrees(-50.70031286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114772"},
        {"Hipparcos Number", "HIP 64515"},
        {"Geneva Identification System", "GEN# +1.00114772J"},
        {"Smithsonian Astrophysical Observation", "SAO 240655"},
        {"Wilson Evans Batten Catalogue", "WEB 11403"},
    },
    visualMagnitude: 5.90,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.34742745),
        dec: Angle.Degrees(-50.69978590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66687",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66687"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.05603933),
        dec: Angle.Degrees(-50.69790639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109270",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109270"},
        {"Smithsonian Astrophysical Observation", "SAO 247321"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.06323889),
        dec: Angle.Degrees(-50.69360481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 195.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66284"},
        {"Hipparcos Number", "HIP 39142"},
        {"Smithsonian Astrophysical Observation", "SAO 235667"},
    },
    visualMagnitude: 8.38,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.09395984),
        dec: Angle.Degrees(-50.69108728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113295"},
        {"Hipparcos Number", "HIP 63717"},
        {"Smithsonian Astrophysical Observation", "SAO 240509"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.86410671),
        dec: Angle.Degrees(-50.68988590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62146",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62146"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.06559185),
        dec: Angle.Degrees(-50.68988182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133900"},
        {"Hipparcos Number", "HIP 74113"},
        {"Geneva Identification System", "GEN# +1.00133900"},
        {"Smithsonian Astrophysical Observation", "SAO 242254"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.20033326),
        dec: Angle.Degrees(-50.68980390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181516"},
        {"Hipparcos Number", "HIP 95302"},
        {"Smithsonian Astrophysical Observation", "SAO 246062"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.83557572),
        dec: Angle.Degrees(-50.68878859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77643",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77643"},
        {"Geneva Identification System", "GEN# -0.05009903"},
    },
    visualMagnitude: 10.71,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.77398328),
        dec: Angle.Degrees(-50.68762790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 258.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115822"},
        {"Hipparcos Number", "HIP 65098"},
        {"Smithsonian Astrophysical Observation", "SAO 240760"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.12552050),
        dec: Angle.Degrees(-50.68745448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218269"},
        {"Hipparcos Number", "HIP 114167"},
        {"Smithsonian Astrophysical Observation", "SAO 247739"},
    },
    visualMagnitude: 5.81,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.81169415),
        dec: Angle.Degrees(-50.68662467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6293"},
        {"Hipparcos Number", "HIP 4920"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.79425873),
        dec: Angle.Degrees(-50.68358816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214486"},
        {"Hipparcos Number", "HIP 111856"},
        {"Smithsonian Astrophysical Observation", "SAO 247535"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.86763129),
        dec: Angle.Degrees(-50.68144496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69049",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69049"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.00415483),
        dec: Angle.Degrees(-50.68134122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40889"},
        {"Hipparcos Number", "HIP 28315"},
        {"Smithsonian Astrophysical Observation", "SAO 234235"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.74519693),
        dec: Angle.Degrees(-50.67726144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158605"},
        {"Hipparcos Number", "HIP 85874"},
        {"Smithsonian Astrophysical Observation", "SAO 244833"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.22284584),
        dec: Angle.Degrees(-50.67561305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190312"},
        {"Hipparcos Number", "HIP 99053"},
        {"Smithsonian Astrophysical Observation", "SAO 246437"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.65656287),
        dec: Angle.Degrees(-50.67526261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42612"},
        {"Hipparcos Number", "HIP 29144"},
        {"Smithsonian Astrophysical Observation", "SAO 234342"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.21641440),
        dec: Angle.Degrees(-50.67505351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142674"},
        {"Hipparcos Number", "HIP 78203"},
        {"Smithsonian Astrophysical Observation", "SAO 243179"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.53218734),
        dec: Angle.Degrees(-50.67487701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152478"},
        {"Hipparcos Number", "HIP 82868"},
        {"Geneva Identification System", "GEN# +1.00152478"},
        {"Smithsonian Astrophysical Observation", "SAO 244280"},
        {"Wilson Evans Batten Catalogue", "WEB 14006"},
    },
    visualMagnitude: 6.30,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.03687484),
        dec: Angle.Degrees(-50.67476677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59508",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59508"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.07011116),
        dec: Angle.Degrees(-50.67197168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129383"},
        {"Hipparcos Number", "HIP 72024"},
        {"Renson", "Renson 36880"},
        {"Smithsonian Astrophysical Observation", "SAO 241955"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.99277867),
        dec: Angle.Degrees(-50.67097837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106144"},
        {"Hipparcos Number", "HIP 59568"},
        {"Smithsonian Astrophysical Observation", "SAO 239759"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.23415265),
        dec: Angle.Degrees(-50.67085709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201061"},
        {"Hipparcos Number", "HIP 104409"},
        {"Smithsonian Astrophysical Observation", "SAO 246888"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.27011311),
        dec: Angle.Degrees(-50.66988431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156554"},
        {"Hipparcos Number", "HIP 84884"},
        {"Smithsonian Astrophysical Observation", "SAO 244653"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.22097065),
        dec: Angle.Degrees(-50.66854900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185634"},
        {"Hipparcos Number", "HIP 96956"},
        {"Smithsonian Astrophysical Observation", "SAO 246226"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.63950910),
        dec: Angle.Degrees(-50.66759371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70426"},
        {"Hipparcos Number", "HIP 40803"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.92445147),
        dec: Angle.Degrees(-50.66655996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11414"},
        {"Hipparcos Number", "HIP 8595"},
        {"Smithsonian Astrophysical Observation", "SAO 232543"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.73314921),
        dec: Angle.Degrees(-50.66415355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69025"},
        {"Hipparcos Number", "HIP 40213"},
        {"Smithsonian Astrophysical Observation", "SAO 235814"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.19674996),
        dec: Angle.Degrees(-50.66192784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53840"},
        {"Hipparcos Number", "HIP 34060"},
        {"Smithsonian Astrophysical Observation", "SAO 234895"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.97676153),
        dec: Angle.Degrees(-50.66133954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105382"},
        {"Hipparcos Number", "HIP 59173"},
        {"Geneva Identification System", "GEN# +1.00105382"},
        {"Renson", "Renson 30464"},
        {"Smithsonian Astrophysical Observation", "SAO 239687"},
        {"Wilson Evans Batten Catalogue", "WEB 10524"},
    },
    visualMagnitude: 4.46,
    bvColour: -0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.02190127),
        dec: Angle.Degrees(-50.66125439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121293"},
        {"Hipparcos Number", "HIP 68035"},
        {"Smithsonian Astrophysical Observation", "SAO 241305"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.96827264),
        dec: Angle.Degrees(-50.66089882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85297"},
        {"Hipparcos Number", "HIP 48185"},
        {"Geneva Identification System", "GEN# +1.00085297"},
        {"Smithsonian Astrophysical Observation", "SAO 237378"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.33305242),
        dec: Angle.Degrees(-50.65942526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7455"},
        {"Hipparcos Number", "HIP 5735"},
        {"Geneva Identification System", "GEN# +1.00007455"},
        {"Smithsonian Astrophysical Observation", "SAO 232345"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.42698355),
        dec: Angle.Degrees(-50.65864093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138150"},
        {"Hipparcos Number", "HIP 76087"},
        {"Geneva Identification System", "GEN# +1.00138150"},
        {"Smithsonian Astrophysical Observation", "SAO 242666"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.09663473),
        dec: Angle.Degrees(-50.65760447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84024",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84024"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.64109648),
        dec: Angle.Degrees(-50.65747469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155856"},
        {"Hipparcos Number", "HIP 84529"},
        {"Geneva Identification System", "GEN# +1.00155856"},
        {"Smithsonian Astrophysical Observation", "SAO 244580"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.20127856),
        dec: Angle.Degrees(-50.65703830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22466",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22466"},
    },
    visualMagnitude: 11.54,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.52764177),
        dec: Angle.Degrees(-50.65701559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7456"},
        {"Hipparcos Number", "HIP 5745"},
        {"Geneva Identification System", "GEN# +1.00007456"},
        {"Smithsonian Astrophysical Observation", "SAO 232346"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.45261156),
        dec: Angle.Degrees(-50.65538631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160446"},
        {"Hipparcos Number", "HIP 86674"},
        {"Geneva Identification System", "GEN# +1.00160446"},
        {"Smithsonian Astrophysical Observation", "SAO 244958"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.62876175),
        dec: Angle.Degrees(-50.65534722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20624"},
        {"Hipparcos Number", "HIP 15271"},
        {"Smithsonian Astrophysical Observation", "SAO 233061"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.25009599),
        dec: Angle.Degrees(-50.65346152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196402"},
        {"Hipparcos Number", "HIP 101929"},
        {"Smithsonian Astrophysical Observation", "SAO 246679"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.83071555),
        dec: Angle.Degrees(-50.65185342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48926"},
        {"Hipparcos Number", "HIP 32189"},
        {"Smithsonian Astrophysical Observation", "SAO 234671"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.80656157),
        dec: Angle.Degrees(-50.65085836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109194"},
        {"Hipparcos Number", "HIP 61260"},
        {"Geneva Identification System", "GEN# +1.00109194"},
        {"Smithsonian Astrophysical Observation", "SAO 240051"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.31685606),
        dec: Angle.Degrees(-50.65062618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198298"},
        {"Hipparcos Number", "HIP 102941"},
        {"Geneva Identification System", "GEN# +1.00198298"},
        {"Smithsonian Astrophysical Observation", "SAO 246761"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.84850974),
        dec: Angle.Degrees(-50.64947396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23456"},
        {"Hipparcos Number", "HIP 17364"},
        {"Cincinnati Publication", "Ci 20 258"},
        {"Geneva Identification System", "GEN# +1.00023456"},
        {"Smithsonian Astrophysical Observation", "SAO 233238"},
        {"Wilson Evans Batten Catalogue", "WEB 3282"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.76929955),
        dec: Angle.Degrees(-50.64429882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 140.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 502.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82324"},
        {"Hipparcos Number", "HIP 46538"},
        {"Smithsonian Astrophysical Observation", "SAO 237032"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.37578667),
        dec: Angle.Degrees(-50.64422475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108890",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108890"},
        {"Geneva Identification System", "GEN# +6.20145100"},
    },
    visualMagnitude: 12.09,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.86172081),
        dec: Angle.Degrees(-50.64277735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 351.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -485.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16049",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16049"},
        {"Smithsonian Astrophysical Observation", "SAO 233117"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.66987447),
        dec: Angle.Degrees(-50.64270583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 185.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18949"},
        {"Hipparcos Number", "HIP 14042"},
        {"Geneva Identification System", "GEN# +1.00018949"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.21708942),
        dec: Angle.Degrees(-50.64219609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10737"},
        {"Hipparcos Number", "HIP 8079"},
        {"Smithsonian Astrophysical Observation", "SAO 232510"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.94459148),
        dec: Angle.Degrees(-50.64126304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152824"},
        {"Hipparcos Number", "HIP 83057"},
        {"Fundamental Katalog 5th Edition", "FK5 1444"},
        {"Geneva Identification System", "GEN# +1.00152824"},
        {"Smithsonian Astrophysical Observation", "SAO 244313"},
        {"Wilson Evans Batten Catalogue", "WEB 14041"},
    },
    visualMagnitude: 5.53,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.57478718),
        dec: Angle.Degrees(-50.64109176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37781"},
        {"Hipparcos Number", "HIP 26515"},
        {"Smithsonian Astrophysical Observation", "SAO 234059"},
    },
    visualMagnitude: 6.43,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.57258718),
        dec: Angle.Degrees(-50.64104142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98326"},
        {"Hipparcos Number", "HIP 55196"},
        {"Smithsonian Astrophysical Observation", "SAO 238949"},
    },
    visualMagnitude: 9.46,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.52113173),
        dec: Angle.Degrees(-50.64046167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88263"},
        {"Hipparcos Number", "HIP 49743"},
        {"Geneva Identification System", "GEN# +1.00088263"},
        {"Smithsonian Astrophysical Observation", "SAO 237741"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.32559460),
        dec: Angle.Degrees(-50.63960239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113219",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113219"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.93050713),
        dec: Angle.Degrees(-50.63910913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 292.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13133"},
        {"Hipparcos Number", "HIP 9872"},
        {"Geneva Identification System", "GEN# +1.00013133"},
        {"Smithsonian Astrophysical Observation", "SAO 232637"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.74947545),
        dec: Angle.Degrees(-50.63830297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 91.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23996"},
        {"Hipparcos Number", "HIP 17676"},
        {"Geneva Identification System", "GEN# +1.00023996"},
        {"Smithsonian Astrophysical Observation", "SAO 233267"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.79784237),
        dec: Angle.Degrees(-50.63729658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34313"},
        {"Hipparcos Number", "HIP 24381"},
        {"Smithsonian Astrophysical Observation", "SAO 233882"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.45794220),
        dec: Angle.Degrees(-50.63575740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107802"},
        {"Hipparcos Number", "HIP 60442"},
        {"Smithsonian Astrophysical Observation", "SAO 239910"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.87845424),
        dec: Angle.Degrees(-50.63446274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91439"},
        {"Hipparcos Number", "HIP 51597"},
        {"Smithsonian Astrophysical Observation", "SAO 238155"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.09568070),
        dec: Angle.Degrees(-50.63391235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157457"},
        {"Hipparcos Number", "HIP 85312"},
        {"Geneva Identification System", "GEN# +1.00157457"},
        {"Smithsonian Astrophysical Observation", "SAO 244734"},
        {"Wilson Evans Batten Catalogue", "WEB 14402"},
    },
    visualMagnitude: 5.19,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.50012163),
        dec: Angle.Degrees(-50.63353205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157662"},
        {"Hipparcos Number", "HIP 85409"},
        {"Geneva Identification System", "GEN# +1.00157662"},
        {"Smithsonian Astrophysical Observation", "SAO 244755"},
        {"Wilson Evans Batten Catalogue", "WEB 14427"},
    },
    visualMagnitude: 5.90,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.80191959),
        dec: Angle.Degrees(-50.63036560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57319",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57319"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.29358603),
        dec: Angle.Degrees(-50.63021286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6507"},
        {"Hipparcos Number", "HIP 5097"},
        {"Smithsonian Astrophysical Observation", "SAO 232289"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.33639620),
        dec: Angle.Degrees(-50.63008044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94462"},
        {"Hipparcos Number", "HIP 53242"},
        {"Smithsonian Astrophysical Observation", "SAO 238569"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.35716734),
        dec: Angle.Degrees(-50.62829781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2481"},
        {"Hipparcos Number", "HIP 2230"},
        {"Smithsonian Astrophysical Observation", "SAO 232054"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.06336796),
        dec: Angle.Degrees(-50.62802055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4359"},
        {"Hipparcos Number", "HIP 3547"},
        {"Smithsonian Astrophysical Observation", "SAO 232170"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.33165787),
        dec: Angle.Degrees(-50.62696116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85411"},
        {"Hipparcos Number", "HIP 48241"},
        {"Geneva Identification System", "GEN# +1.00085411"},
        {"Smithsonian Astrophysical Observation", "SAO 237387"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.51903606),
        dec: Angle.Degrees(-50.62618589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101682"},
        {"Hipparcos Number", "HIP 57052"},
        {"Geneva Identification System", "GEN# +1.00101682"},
        {"Smithsonian Astrophysical Observation", "SAO 239298"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.43893119),
        dec: Angle.Degrees(-50.62558421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196237"},
        {"Hipparcos Number", "HIP 101833"},
        {"Smithsonian Astrophysical Observation", "SAO 246670"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.54972636),
        dec: Angle.Degrees(-50.62267368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28254"},
        {"Henry Draper 2", "HD 28254A"},
        {"Hipparcos Number", "HIP 20606"},
        {"Smithsonian Astrophysical Observation", "SAO 233508"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.21152830),
        dec: Angle.Degrees(-50.62184138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30542"},
        {"Hipparcos Number", "HIP 22147"},
        {"Geneva Identification System", "GEN# +1.00030542"},
        {"Smithsonian Astrophysical Observation", "SAO 233671"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.49332975),
        dec: Angle.Degrees(-50.62048105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184673"},
        {"Hipparcos Number", "HIP 96583"},
        {"Smithsonian Astrophysical Observation", "SAO 246189"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.51634143),
        dec: Angle.Degrees(-50.61933853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210052"},
        {"Hipparcos Number", "HIP 109331"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.24568851),
        dec: Angle.Degrees(-50.61911367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207042"},
        {"Hipparcos Number", "HIP 107612"},
        {"Smithsonian Astrophysical Observation", "SAO 247184"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.93894367),
        dec: Angle.Degrees(-50.61883984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112194"},
        {"Hipparcos Number", "HIP 63065"},
        {"Geneva Identification System", "GEN# +1.00112194"},
        {"Smithsonian Astrophysical Observation", "SAO 240379"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.82333120),
        dec: Angle.Degrees(-50.61632366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141724"},
        {"Hipparcos Number", "HIP 77771"},
        {"Geneva Identification System", "GEN# +1.00141724"},
        {"Smithsonian Astrophysical Observation", "SAO 243078"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.21380947),
        dec: Angle.Degrees(-50.61580436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27681"},
        {"Hipparcos Number", "HIP 20180"},
        {"Smithsonian Astrophysical Observation", "SAO 233483"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.88579955),
        dec: Angle.Degrees(-50.61477833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32768",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Altaleban"},
        {"Common Name 2", "Taleban"},
        {"Henry Draper", "HD 50310"},
        {"Hipparcos Number", "HIP 32768"},
        {"Fundamental Katalog 5th Edition", "FK5 263"},
        {"Geneva Identification System", "GEN# +1.00050310"},
        {"Smithsonian Astrophysical Observation", "SAO 234735"},
        {"Wilson Evans Batten Catalogue", "WEB 6598"},
    },
    visualMagnitude: 2.94,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.48390349),
        dec: Angle.Degrees(-50.61439973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223577"},
        {"Hipparcos Number", "HIP 117584"},
        {"Smithsonian Astrophysical Observation", "SAO 248038"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.69075903),
        dec: Angle.Degrees(-50.61354257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51266"},
        {"Hipparcos Number", "HIP 33139"},
        {"Geneva Identification System", "GEN# +1.00051266"},
        {"Smithsonian Astrophysical Observation", "SAO 234774"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.50962353),
        dec: Angle.Degrees(-50.61214118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 222.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2587"},
        {"Hipparcos Number", "HIP 2282"},
        {"Geneva Identification System", "GEN# +1.00002587"},
        {"Smithsonian Astrophysical Observation", "SAO 232062"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.29211933),
        dec: Angle.Degrees(-50.61157574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 340.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180310"},
        {"Hipparcos Number", "HIP 94892"},
        {"Smithsonian Astrophysical Observation", "SAO 246021"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.66073393),
        dec: Angle.Degrees(-50.61150686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88793"},
        {"Hipparcos Number", "HIP 50062"},
        {"Geneva Identification System", "GEN# +1.00088793A"},
        {"Smithsonian Astrophysical Observation", "SAO 237800"},
        {"Wilson Evans Batten Catalogue", "WEB 9202"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.32106022),
        dec: Angle.Degrees(-50.61082258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60130"},
        {"Hipparcos Number", "HIP 36489"},
        {"Smithsonian Astrophysical Observation", "SAO 235247"},
    },
    visualMagnitude: 6.55,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.61915446),
        dec: Angle.Degrees(-50.60901444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79761"},
        {"Hipparcos Number", "HIP 45308"},
        {"Smithsonian Astrophysical Observation", "SAO 236739"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.52413358),
        dec: Angle.Degrees(-50.60900254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 481"},
        {"Hipparcos Number", "HIP 742"},
        {"Smithsonian Astrophysical Observation", "SAO 231945"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.27673999),
        dec: Angle.Degrees(-50.60776281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94920"},
        {"Hipparcos Number", "HIP 53500"},
        {"Geneva Identification System", "GEN# +1.00094920"},
        {"Smithsonian Astrophysical Observation", "SAO 238616"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.16821894),
        dec: Angle.Degrees(-50.60765744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35072"},
        {"Hipparcos Number", "HIP 24829"},
        {"Fundamental Katalog 5th Edition", "FK5 199"},
        {"Geneva Identification System", "GEN# +1.00035072"},
        {"Smithsonian Astrophysical Observation", "SAO 233926"},
        {"Wilson Evans Batten Catalogue", "WEB 4810"},
    },
    visualMagnitude: 5.44,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.84214072),
        dec: Angle.Degrees(-50.60652008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 227.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66522"},
        {"Hipparcos Number", "HIP 39246"},
        {"Celescope Catalog", "CEL 2145"},
        {"Geneva Identification System", "GEN# +1.00066522"},
        {"Renson", "Renson 18370"},
        {"Smithsonian Astrophysical Observation", "SAO 235688"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.39628005),
        dec: Angle.Degrees(-50.60561525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70778",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70778"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.12838363),
        dec: Angle.Degrees(-50.60389605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82346"},
        {"Hipparcos Number", "HIP 46554"},
        {"Geneva Identification System", "GEN# +1.00082346"},
        {"Smithsonian Astrophysical Observation", "SAO 237034"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.40544232),
        dec: Angle.Degrees(-50.60376234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187028"},
        {"Hipparcos Number", "HIP 97590"},
        {"Geneva Identification System", "GEN# +1.00187028"},
        {"Smithsonian Astrophysical Observation", "SAO 246291"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.53479348),
        dec: Angle.Degrees(-50.60254472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83080"},
        {"Hipparcos Number", "HIP 46958"},
        {"Renson", "Renson 23680"},
        {"Smithsonian Astrophysical Observation", "SAO 237109"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.57330539),
        dec: Angle.Degrees(-50.60224335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48970",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48970"},
    },
    visualMagnitude: 11.34,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.84165770),
        dec: Angle.Degrees(-50.60145924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -187.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206715"},
        {"Hipparcos Number", "HIP 107417"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.35791826),
        dec: Angle.Degrees(-50.59871036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163379"},
        {"Hipparcos Number", "HIP 88002"},
        {"Geneva Identification System", "GEN# +1.00163379"},
        {"Renson", "Renson 46210"},
        {"Smithsonian Astrophysical Observation", "SAO 245150"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.63581879),
        dec: Angle.Degrees(-50.59843911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199932"},
        {"Hipparcos Number", "HIP 103811"},
        {"Smithsonian Astrophysical Observation", "SAO 246830"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.53951799),
        dec: Angle.Degrees(-50.59582926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201800"},
        {"Hipparcos Number", "HIP 104786"},
        {"Geneva Identification System", "GEN# +1.00201800"},
        {"Smithsonian Astrophysical Observation", "SAO 246914"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.41798285),
        dec: Angle.Degrees(-50.59387662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63237"},
        {"Hipparcos Number", "HIP 37835"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.35158186),
        dec: Angle.Degrees(-50.59374246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75824"},
        {"Hipparcos Number", "HIP 43379"},
        {"Geneva Identification System", "GEN# +1.00075824"},
        {"Smithsonian Astrophysical Observation", "SAO 236322"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.54188897),
        dec: Angle.Degrees(-50.59124098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67249"},
        {"Hipparcos Number", "HIP 39527"},
        {"Fundamental Katalog 5th Edition", "FK5 2626"},
        {"Geneva Identification System", "GEN# +1.00067249"},
        {"Smithsonian Astrophysical Observation", "SAO 235730"},
    },
    visualMagnitude: 5.96,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.17669801),
        dec: Angle.Degrees(-50.59039998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7248"},
        {"Hipparcos Number", "HIP 5605"},
        {"Smithsonian Astrophysical Observation", "SAO 232332"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.861,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.96984320),
        dec: Angle.Degrees(-50.58991987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140842"},
        {"Hipparcos Number", "HIP 77403"},
        {"Geneva Identification System", "GEN# +1.00140842"},
        {"Smithsonian Astrophysical Observation", "SAO 242990"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.02714576),
        dec: Angle.Degrees(-50.58978165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94445"},
        {"Hipparcos Number", "HIP 53230"},
        {"Smithsonian Astrophysical Observation", "SAO 238566"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.33427140),
        dec: Angle.Degrees(-50.58951065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131659"},
        {"Hipparcos Number", "HIP 73131"},
        {"Smithsonian Astrophysical Observation", "SAO 242125"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.18544498),
        dec: Angle.Degrees(-50.58837482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213881"},
        {"Hipparcos Number", "HIP 111511"},
        {"Smithsonian Astrophysical Observation", "SAO 247501"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.88201755),
        dec: Angle.Degrees(-50.58797206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27002"},
        {"Hipparcos Number", "HIP 19722"},
        {"Smithsonian Astrophysical Observation", "SAO 233439"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.40320555),
        dec: Angle.Degrees(-50.58616905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60753"},
        {"Hipparcos Number", "HIP 36745"},
        {"Geneva Identification System", "GEN# +1.00060753"},
        {"Smithsonian Astrophysical Observation", "SAO 235291"},
        {"Wilson Evans Batten Catalogue", "WEB 7305"},
    },
    visualMagnitude: 6.69,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.36383953),
        dec: Angle.Degrees(-50.58426823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138298"},
        {"Hipparcos Number", "HIP 76163"},
        {"Smithsonian Astrophysical Observation", "SAO 242689"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.33843141),
        dec: Angle.Degrees(-50.58308836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82897",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82897"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.10431948),
        dec: Angle.Degrees(-50.58253981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81124",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81124"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.52397070),
        dec: Angle.Degrees(-50.58224139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140904"},
        {"Hipparcos Number", "HIP 77426"},
        {"Smithsonian Astrophysical Observation", "SAO 242995"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.09376631),
        dec: Angle.Degrees(-50.57969357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111708"},
        {"Hipparcos Number", "HIP 62775"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.96308879),
        dec: Angle.Degrees(-50.57926564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61881"},
        {"Hipparcos Number", "HIP 37234"},
        {"Geneva Identification System", "GEN# +1.00061881"},
        {"Smithsonian Astrophysical Observation", "SAO 235384"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.71544857),
        dec: Angle.Degrees(-50.57700710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32064"},
        {"Hipparcos Number", "HIP 23078"},
        {"Smithsonian Astrophysical Observation", "SAO 233762"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.49197799),
        dec: Angle.Degrees(-50.57580966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156047"},
        {"Hipparcos Number", "HIP 84627"},
        {"Smithsonian Astrophysical Observation", "SAO 244598"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.50509683),
        dec: Angle.Degrees(-50.57525834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49261"},
        {"Hipparcos Number", "HIP 32330"},
        {"Smithsonian Astrophysical Observation", "SAO 234685"},
    },
    visualMagnitude: 9.09,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.23169288),
        dec: Angle.Degrees(-50.57224364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91021"},
        {"Hipparcos Number", "HIP 51355"},
        {"Renson", "Renson 26180"},
        {"Smithsonian Astrophysical Observation", "SAO 238111"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.34456849),
        dec: Angle.Degrees(-50.57051293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81335"},
        {"Hipparcos Number", "HIP 46021"},
        {"Smithsonian Astrophysical Observation", "SAO 236910"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.78954941),
        dec: Angle.Degrees(-50.57042237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101099"},
        {"Hipparcos Number", "HIP 56714"},
        {"Smithsonian Astrophysical Observation", "SAO 239238"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.42031685),
        dec: Angle.Degrees(-50.56950621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9466"},
        {"Hipparcos Number", "HIP 7136"},
        {"Geneva Identification System", "GEN# +1.00009466"},
        {"Smithsonian Astrophysical Observation", "SAO 232453"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.98713838),
        dec: Angle.Degrees(-50.56857166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119696"},
        {"Hipparcos Number", "HIP 67170"},
        {"Smithsonian Astrophysical Observation", "SAO 241146"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.46842781),
        dec: Angle.Degrees(-50.56678792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12361"},
        {"Hipparcos Number", "HIP 9332"},
        {"Smithsonian Astrophysical Observation", "SAO 232595"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.95605834),
        dec: Angle.Degrees(-50.56671452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125100"},
        {"Hipparcos Number", "HIP 69943"},
        {"Smithsonian Astrophysical Observation", "SAO 241626"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.70209767),
        dec: Angle.Degrees(-50.56555279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183906"},
        {"Hipparcos Number", "HIP 96243"},
        {"Smithsonian Astrophysical Observation", "SAO 246167"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.55642558),
        dec: Angle.Degrees(-50.56498009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154594"},
        {"Hipparcos Number", "HIP 83915"},
        {"Smithsonian Astrophysical Observation", "SAO 244465"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.25321303),
        dec: Angle.Degrees(-50.56458011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154575"},
        {"Hipparcos Number", "HIP 83902"},
        {"Smithsonian Astrophysical Observation", "SAO 244463"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.22034047),
        dec: Angle.Degrees(-50.56450774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65134"},
        {"Hipparcos Number", "HIP 38649"},
        {"Geneva Identification System", "GEN# +1.00065134"},
        {"Smithsonian Astrophysical Observation", "SAO 235609"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.70575354),
        dec: Angle.Degrees(-50.56434927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112660"},
        {"Hipparcos Number", "HIP 63364"},
        {"Smithsonian Astrophysical Observation", "SAO 240442"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.75326937),
        dec: Angle.Degrees(-50.56410168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123957"},
        {"Hipparcos Number", "HIP 69374"},
        {"Smithsonian Astrophysical Observation", "SAO 241524"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.02787154),
        dec: Angle.Degrees(-50.56313660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83153"},
        {"Hipparcos Number", "HIP 47005"},
        {"Celescope Catalog", "CEL 3333"},
        {"Geneva Identification System", "GEN# +1.00083153"},
        {"Smithsonian Astrophysical Observation", "SAO 237119"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.70518416),
        dec: Angle.Degrees(-50.56253431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132099"},
        {"Hipparcos Number", "HIP 73342"},
        {"Smithsonian Astrophysical Observation", "SAO 242145"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.80884888),
        dec: Angle.Degrees(-50.56121714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42929",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42929"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.23290486),
        dec: Angle.Degrees(-50.56005023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104895"},
        {"Hipparcos Number", "HIP 58897"},
        {"Smithsonian Astrophysical Observation", "SAO 239641"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.861,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.18028052),
        dec: Angle.Degrees(-50.56001294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192549"},
        {"Hipparcos Number", "HIP 100023"},
        {"Smithsonian Astrophysical Observation", "SAO 246516"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.40046907),
        dec: Angle.Degrees(-50.55882835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166376"},
        {"Hipparcos Number", "HIP 89264"},
        {"Smithsonian Astrophysical Observation", "SAO 245320"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.23435912),
        dec: Angle.Degrees(-50.55864163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100499",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100499"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.68746755),
        dec: Angle.Degrees(-50.55701472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158669"},
        {"Hipparcos Number", "HIP 85898"},
        {"Geneva Identification System", "GEN# +1.00158669"},
        {"Smithsonian Astrophysical Observation", "SAO 244836"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.30109121),
        dec: Angle.Degrees(-50.55555169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88044",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88044"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.74256969),
        dec: Angle.Degrees(-50.55513641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221657"},
        {"Hipparcos Number", "HIP 116327"},
        {"Smithsonian Astrophysical Observation", "SAO 247931"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.56090277),
        dec: Angle.Degrees(-50.55334108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96320"},
        {"Hipparcos Number", "HIP 54219"},
        {"Smithsonian Astrophysical Observation", "SAO 238758"},
    },
    visualMagnitude: 8.45,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.40419816),
        dec: Angle.Degrees(-50.55219706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20408"},
        {"Hipparcos Number", "HIP 15106"},
        {"Geneva Identification System", "GEN# +1.00020408"},
        {"Smithsonian Astrophysical Observation", "SAO 233049"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.71762079),
        dec: Angle.Degrees(-50.55212251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222970"},
        {"Hipparcos Number", "HIP 117188"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.40829945),
        dec: Angle.Degrees(-50.55185138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1912"},
        {"Hipparcos Number", "HIP 1828"},
        {"Smithsonian Astrophysical Observation", "SAO 232015"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.79026682),
        dec: Angle.Degrees(-50.54847987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133342"},
        {"Hipparcos Number", "HIP 73870"},
        {"Smithsonian Astrophysical Observation", "SAO 242219"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.46376987),
        dec: Angle.Degrees(-50.54742648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80779"},
        {"Hipparcos Number", "HIP 45765"},
        {"Smithsonian Astrophysical Observation", "SAO 236854"},
    },
    visualMagnitude: 8.98,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.98862750),
        dec: Angle.Degrees(-50.54692822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197696"},
        {"Hipparcos Number", "HIP 102586"},
        {"Smithsonian Astrophysical Observation", "SAO 246731"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.84297358),
        dec: Angle.Degrees(-50.54603422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59394"},
        {"Hipparcos Number", "HIP 36193"},
        {"Smithsonian Astrophysical Observation", "SAO 235201"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.80157074),
        dec: Angle.Degrees(-50.54531181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57533"},
        {"Hipparcos Number", "HIP 35454"},
        {"Smithsonian Astrophysical Observation", "SAO 235093"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.79139493),
        dec: Angle.Degrees(-50.54446399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147170"},
        {"Hipparcos Number", "HIP 80222"},
        {"Geneva Identification System", "GEN# +1.00147170"},
        {"Smithsonian Astrophysical Observation", "SAO 243714"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.64943679),
        dec: Angle.Degrees(-50.54383706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130631"},
        {"Hipparcos Number", "HIP 72638"},
        {"Smithsonian Astrophysical Observation", "SAO 242064"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.76434241),
        dec: Angle.Degrees(-50.54269844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71898"},
        {"Hipparcos Number", "HIP 41486"},
        {"Smithsonian Astrophysical Observation", "SAO 236000"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.91173625),
        dec: Angle.Degrees(-50.54257421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62902",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62902"},
        {"Smithsonian Astrophysical Observation", "SAO 181200"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.37904194),
        dec: Angle.Degrees(-21.29810641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84218",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84218"},
    },
    visualMagnitude: 10.10,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.22718163),
        dec: Angle.Degrees(-50.54216266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148692"},
        {"Hipparcos Number", "HIP 80983"},
        {"Smithsonian Astrophysical Observation", "SAO 243925"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.07318416),
        dec: Angle.Degrees(-50.54191887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96727"},
        {"Hipparcos Number", "HIP 54397"},
        {"Smithsonian Astrophysical Observation", "SAO 238802"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.97112858),
        dec: Angle.Degrees(-50.53944054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186955"},
        {"Hipparcos Number", "HIP 97562"},
        {"Smithsonian Astrophysical Observation", "SAO 246286"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.44609584),
        dec: Angle.Degrees(-50.53774499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19531"},
        {"Hipparcos Number", "HIP 14453"},
        {"Smithsonian Astrophysical Observation", "SAO 232996"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.63811552),
        dec: Angle.Degrees(-50.53740005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221885"},
        {"Hipparcos Number", "HIP 116477"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.02153439),
        dec: Angle.Degrees(-50.53635120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140446"},
        {"Hipparcos Number", "HIP 77206"},
        {"Smithsonian Astrophysical Observation", "SAO 242937"},
    },
    visualMagnitude: 8.53,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.46432220),
        dec: Angle.Degrees(-50.53544415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36611"},
        {"Hipparcos Number", "HIP 25778"},
        {"Geneva Identification System", "GEN# +1.00036611"},
        {"Smithsonian Astrophysical Observation", "SAO 234000"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.56350457),
        dec: Angle.Degrees(-50.53379722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2529"},
        {"Hipparcos Number", "HIP 2256"},
        {"Geneva Identification System", "GEN# +1.00002529"},
        {"Smithsonian Astrophysical Observation", "SAO 232055"},
    },
    visualMagnitude: 6.26,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.17908720),
        dec: Angle.Degrees(-50.53284634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 159.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 297773"},
        {"Hipparcos Number", "HIP 49473"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.51358587),
        dec: Angle.Degrees(-50.53083554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129577"},
        {"Hipparcos Number", "HIP 72100"},
        {"Smithsonian Astrophysical Observation", "SAO 241969"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.23717974),
        dec: Angle.Degrees(-50.53035615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68910",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68910"},
    },
    visualMagnitude: 10.75,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.62120110),
        dec: Angle.Degrees(-50.53009609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45347"},
        {"Hipparcos Number", "HIP 30456"},
        {"Smithsonian Astrophysical Observation", "SAO 234481"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.03052273),
        dec: Angle.Degrees(-50.52986495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99782"},
        {"Hipparcos Number", "HIP 55976"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.06547691),
        dec: Angle.Degrees(-50.52985238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66629"},
        {"Hipparcos Number", "HIP 39294"},
        {"Smithsonian Astrophysical Observation", "SAO 235693"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.51623833),
        dec: Angle.Degrees(-50.52814387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207281"},
        {"Hipparcos Number", "HIP 107716"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.30453294),
        dec: Angle.Degrees(-50.52726125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
