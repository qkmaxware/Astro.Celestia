using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_111() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108019"},
        {"Hipparcos Number", "HIP 60504"},
        {"Geneva Identification System", "GEN# +1.00108019"},
        {"Smithsonian Astrophysical Observation", "SAO 15795"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.05961813),
        dec: Angle.Degrees(+60.83207484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114161",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16518 AB"},
        {"Henry Draper", "HD 218439"},
        {"Hipparcos Number", "HIP 114161"},
        {"Renson", "Renson 60150"},
        {"Smithsonian Astrophysical Observation", "SAO 20432"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.79161995),
        dec: Angle.Degrees(+60.83252971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212776"},
        {"Hipparcos Number", "HIP 110671"},
        {"Geneva Identification System", "GEN# +1.00212776"},
        {"Smithsonian Astrophysical Observation", "SAO 20056"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.30823994),
        dec: Angle.Degrees(+60.83632468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175148"},
        {"Hipparcos Number", "HIP 92436"},
        {"Smithsonian Astrophysical Observation", "SAO 18039"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.57544313),
        dec: Angle.Degrees(+60.83751411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101483"},
        {"Hipparcos Number", "HIP 57000"},
        {"Geneva Identification System", "GEN# +1.00101483"},
        {"Smithsonian Astrophysical Observation", "SAO 15600"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.27510993),
        dec: Angle.Degrees(+60.84257812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14221",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2299"},
        {"Hipparcos Number", "HIP 14221"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.84260936),
        dec: Angle.Degrees(+60.84299375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114995",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114995"},
        {"Geneva Identification System", "GEN# +6.10121080"},
    },
    visualMagnitude: 11.58,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.35665304),
        dec: Angle.Degrees(+60.84540821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51160",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7772 AB"},
        {"Henry Draper", "HD 90275"},
        {"Hipparcos Number", "HIP 51160"},
        {"Smithsonian Astrophysical Observation", "SAO 15182"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.75133661),
        dec: Angle.Degrees(+60.84551697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29755",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29755"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.98657141),
        dec: Angle.Degrees(+60.84602791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216721"},
        {"Hipparcos Number", "HIP 113074"},
        {"Geneva Identification System", "GEN# +1.00216721"},
        {"Smithsonian Astrophysical Observation", "SAO 20306"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.50626361),
        dec: Angle.Degrees(+60.85337388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223960"},
        {"Hipparcos Number", "HIP 117830"},
        {"Celescope Catalog", "CEL 5706"},
        {"Geneva Identification System", "GEN# +1.00223960"},
        {"Smithsonian Astrophysical Observation", "SAO 20923"},
        {"Wilson Evans Batten Catalogue", "WEB 20728"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.45827820),
        dec: Angle.Degrees(+60.85340647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13460",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13460"},
        {"Geneva Identification System", "GEN# +0.06000585"},
        {"Smithsonian Astrophysical Observation", "SAO 12490"},
        {"Wilson Evans Batten Catalogue", "WEB 2688"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.32647055),
        dec: Angle.Degrees(+60.85347536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189724"},
        {"Hipparcos Number", "HIP 98256"},
        {"Geneva Identification System", "GEN# +1.00189724"},
        {"Smithsonian Astrophysical Observation", "SAO 18621"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.48676319),
        dec: Angle.Degrees(+60.85533372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113810"},
        {"Hipparcos Number", "HIP 63859"},
        {"Smithsonian Astrophysical Observation", "SAO 15978"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.31305372),
        dec: Angle.Degrees(+60.86045909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7370"},
        {"Hipparcos Number", "HIP 5863"},
        {"Geneva Identification System", "GEN# +1.00007370"},
        {"Renson", "Renson 1840"},
        {"Smithsonian Astrophysical Observation", "SAO 11658"},
        {"Wilson Evans Batten Catalogue", "WEB 1336"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.79405663),
        dec: Angle.Degrees(+60.86345258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184601"},
        {"Hipparcos Number", "HIP 96049"},
        {"Geneva Identification System", "GEN# +1.00184601"},
        {"Smithsonian Astrophysical Observation", "SAO 18384"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.93599189),
        dec: Angle.Degrees(+60.86440921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49257",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49257"},
        {"Smithsonian Astrophysical Observation", "SAO 15059"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.83110444),
        dec: Angle.Degrees(+60.86810356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23286"},
        {"Hipparcos Number", "HIP 17679"},
        {"Smithsonian Astrophysical Observation", "SAO 12901"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.80925490),
        dec: Angle.Degrees(+60.86913404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15061",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15061"},
        {"Geneva Identification System", "GEN# +0.06000644"},
        {"Smithsonian Astrophysical Observation", "SAO 12665"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.51650167),
        dec: Angle.Degrees(+60.87351228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33142",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33142"},
    },
    visualMagnitude: 11.01,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.51517922),
        dec: Angle.Degrees(+60.87417353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 494.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -991.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25734"},
        {"Hipparcos Number", "HIP 19314"},
        {"Smithsonian Astrophysical Observation", "SAO 13036"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.10092039),
        dec: Angle.Degrees(+60.87667934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66689",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66689"},
        {"Geneva Identification System", "GEN# +6.20001087"},
    },
    visualMagnitude: 11.70,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.06116739),
        dec: Angle.Degrees(+60.88003684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21260"},
        {"Hipparcos Number", "HIP 16223"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.24869302),
        dec: Angle.Degrees(+60.88194616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43207",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43207"},
        {"Smithsonian Astrophysical Observation", "SAO 14666"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.03181477),
        dec: Angle.Degrees(+60.88291721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7252"},
        {"Hipparcos Number", "HIP 5768"},
        {"Celescope Catalog", "CEL 131"},
        {"Geneva Identification System", "GEN# +1.00007252"},
        {"Smithsonian Astrophysical Observation", "SAO 11644"},
        {"Wilson Evans Batten Catalogue", "WEB 1315"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.51520830),
        dec: Angle.Degrees(+60.88312720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29060"},
        {"Hipparcos Number", "HIP 21601"},
        {"Smithsonian Astrophysical Observation", "SAO 13215"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.56268608),
        dec: Angle.Degrees(+60.88425174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110165"},
        {"Hipparcos Number", "HIP 61767"},
        {"Smithsonian Astrophysical Observation", "SAO 15859"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.89474133),
        dec: Angle.Degrees(+60.88475515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79798"},
        {"Hipparcos Number", "HIP 45676"},
        {"Geneva Identification System", "GEN# +1.00079798"},
        {"Renson", "Renson 22710"},
        {"Smithsonian Astrophysical Observation", "SAO 14839"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.67683823),
        dec: Angle.Degrees(+60.88675074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93312"},
        {"Hipparcos Number", "HIP 52798"},
        {"Smithsonian Astrophysical Observation", "SAO 15293"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.91380552),
        dec: Angle.Degrees(+60.88724964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147093"},
        {"Hipparcos Number", "HIP 79718"},
        {"Smithsonian Astrophysical Observation", "SAO 17016"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.04888710),
        dec: Angle.Degrees(+60.88993972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33653"},
        {"Hipparcos Number", "HIP 24525"},
        {"Smithsonian Astrophysical Observation", "SAO 13431"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.92778662),
        dec: Angle.Degrees(+60.89084136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47043",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7432 A"},
        {"Henry Draper", "HD 82569"},
        {"Henry Draper 2", "HD 82569A"},
        {"Hipparcos Number", "HIP 47043"},
        {"Geneva Identification System", "GEN# +1.00082569"},
        {"Renson", "Renson 23490"},
        {"Smithsonian Astrophysical Observation", "SAO 14931"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.80893936),
        dec: Angle.Degrees(+60.89197465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201793"},
        {"Hipparcos Number", "HIP 104422"},
        {"Geneva Identification System", "GEN# +1.00201793"},
        {"Smithsonian Astrophysical Observation", "SAO 19220"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.29434868),
        dec: Angle.Degrees(+60.89452197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109278",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109278"},
        {"Geneva Identification System", "GEN# +0.06002344"},
        {"Smithsonian Astrophysical Observation", "SAO 19882"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.07473370),
        dec: Angle.Degrees(+60.89637918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99070"},
        {"Hipparcos Number", "HIP 55698"},
        {"Smithsonian Astrophysical Observation", "SAO 15497"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.18724174),
        dec: Angle.Degrees(+60.89692750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72707",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72707"},
    },
    visualMagnitude: 12.03,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.98368585),
        dec: Angle.Degrees(+60.90019711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6526",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6526"},
        {"Smithsonian Astrophysical Observation", "SAO 11737"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.95843874),
        dec: Angle.Degrees(+60.90128814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7755",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7755"},
        {"Smithsonian Astrophysical Observation", "SAO 11899"},
        {"Wilson Evans Batten Catalogue", "WEB 1667"},
    },
    visualMagnitude: 7.97,
    bvColour: 2.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.96526748),
        dec: Angle.Degrees(+60.90229503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221935"},
        {"Hipparcos Number", "HIP 116456"},
        {"Geneva Identification System", "GEN# +1.00221935"},
        {"Smithsonian Astrophysical Observation", "SAO 20719"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.96090081),
        dec: Angle.Degrees(+60.90253704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107903"},
        {"Hipparcos Number", "HIP 60453"},
        {"Geneva Identification System", "GEN# +1.00107903"},
        {"Smithsonian Astrophysical Observation", "SAO 15792"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.90097291),
        dec: Angle.Degrees(+60.90309604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106599",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106599"},
    },
    visualMagnitude: 10.72,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.84300251),
        dec: Angle.Degrees(+60.90371432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63478",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63478"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.10596576),
        dec: Angle.Degrees(+60.90493274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103807",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103807"},
        {"Smithsonian Astrophysical Observation", "SAO 19157"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.52697515),
        dec: Angle.Degrees(+60.90888678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117576",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117576"},
        {"Wilson Evans Batten Catalogue", "WEB 20702"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.66467834),
        dec: Angle.Degrees(+60.91087775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107322",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15288 AB"},
        {"Henry Draper", "HD 207067"},
        {"Hipparcos Number", "HIP 107322"},
        {"Smithsonian Astrophysical Observation", "SAO 19611"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.07219831),
        dec: Angle.Degrees(+60.91279881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89546"},
        {"Hipparcos Number", "HIP 50752"},
        {"Smithsonian Astrophysical Observation", "SAO 15153"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.44813258),
        dec: Angle.Degrees(+60.91288364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216572"},
        {"Hipparcos Number", "HIP 112972"},
        {"Smithsonian Astrophysical Observation", "SAO 20292"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.19085544),
        dec: Angle.Degrees(+60.91630734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14558"},
        {"Hipparcos Number", "HIP 11149"},
        {"Geneva Identification System", "GEN# +1.00014558"},
        {"Smithsonian Astrophysical Observation", "SAO 12261"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.85987475),
        dec: Angle.Degrees(+60.91793357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197100"},
        {"Hipparcos Number", "HIP 101862"},
        {"Smithsonian Astrophysical Observation", "SAO 18963"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.61917820),
        dec: Angle.Degrees(+60.91847558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87481"},
        {"Hipparcos Number", "HIP 49578"},
        {"Smithsonian Astrophysical Observation", "SAO 15086"},
        {"Wilson Evans Batten Catalogue", "WEB 9143"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.80872964),
        dec: Angle.Degrees(+60.91987846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76238",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76238"},
        {"Smithsonian Astrophysical Observation", "SAO 16770"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.59641340),
        dec: Angle.Degrees(+60.92166206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113569",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113569"},
    },
    visualMagnitude: 10.86,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.04219995),
        dec: Angle.Degrees(+60.92734037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56664"},
        {"Hipparcos Number", "HIP 35685"},
        {"Geneva Identification System", "GEN# +1.00056664"},
        {"Smithsonian Astrophysical Observation", "SAO 14165"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.44853707),
        dec: Angle.Degrees(+60.92803266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49039"},
        {"Hipparcos Number", "HIP 32806"},
        {"Geneva Identification System", "GEN# +1.00049039"},
        {"Smithsonian Astrophysical Observation", "SAO 13976"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.58282297),
        dec: Angle.Degrees(+60.92939250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -241.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -184.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73745"},
        {"Hipparcos Number", "HIP 42781"},
        {"Smithsonian Astrophysical Observation", "SAO 14637"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.75853291),
        dec: Angle.Degrees(+60.93016465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35802",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35802"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.76773610),
        dec: Angle.Degrees(+60.93042822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -244.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5829",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 999 AB"},
        {"Henry Draper", "HD 7331"},
        {"Hipparcos Number", "HIP 5829"},
        {"Geneva Identification System", "GEN# +1.00007331"},
        {"Smithsonian Astrophysical Observation", "SAO 11652"},
        {"Wilson Evans Batten Catalogue", "WEB 1327"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.69064697),
        dec: Angle.Degrees(+60.93911573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60049",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60049"},
        {"Smithsonian Astrophysical Observation", "SAO 15768"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.72702698),
        dec: Angle.Degrees(+60.94353610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71068"},
        {"Hipparcos Number", "HIP 41581"},
        {"Renson", "Renson 19652"},
        {"Smithsonian Astrophysical Observation", "SAO 14567"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.17082051),
        dec: Angle.Degrees(+60.94372758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176251"},
        {"Hipparcos Number", "HIP 92873"},
        {"Smithsonian Astrophysical Observation", "SAO 18069"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.86510408),
        dec: Angle.Degrees(+60.94623317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211999"},
        {"Hipparcos Number", "HIP 110216"},
        {"Geneva Identification System", "GEN# +1.00211999"},
        {"Smithsonian Astrophysical Observation", "SAO 20008"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.88915090),
        dec: Angle.Degrees(+60.94752650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8013"},
        {"Hipparcos Number", "HIP 6300"},
        {"Celescope Catalog", "CEL 137"},
        {"Geneva Identification System", "GEN# +1.00008013"},
        {"Smithsonian Astrophysical Observation", "SAO 11708"},
    },
    visualMagnitude: 7.55,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.21717447),
        dec: Angle.Degrees(+60.94894149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12938"},
        {"Hipparcos Number", "HIP 10000"},
        {"Smithsonian Astrophysical Observation", "SAO 12146"},
        {"Wilson Evans Batten Catalogue", "WEB 2095"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.19414770),
        dec: Angle.Degrees(+60.95494173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181799"},
        {"Hipparcos Number", "HIP 94860"},
        {"Geneva Identification System", "GEN# +1.00181799"},
        {"Smithsonian Astrophysical Observation", "SAO 18275"},
        {"Wilson Evans Batten Catalogue", "WEB 16558"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.54858009),
        dec: Angle.Degrees(+60.95998284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14209",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14209"},
        {"Smithsonian Astrophysical Observation", "SAO 12579"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.80189067),
        dec: Angle.Degrees(+60.96047598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15250"},
        {"Hipparcos Number", "HIP 11618"},
        {"Geneva Identification System", "GEN# +1.00015250"},
        {"Smithsonian Astrophysical Observation", "SAO 12309"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.46046348),
        dec: Angle.Degrees(+60.96113083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1917"},
        {"Hipparcos Number", "HIP 1892"},
        {"Geneva Identification System", "GEN# +1.00001917"},
        {"Smithsonian Astrophysical Observation", "SAO 11157"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.97214938),
        dec: Angle.Degrees(+60.96163429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4562"},
        {"Hipparcos Number", "HIP 3768"},
        {"Smithsonian Astrophysical Observation", "SAO 11402"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.09694744),
        dec: Angle.Degrees(+60.96176268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126323"},
        {"Hipparcos Number", "HIP 70252"},
        {"Geneva Identification System", "GEN# +1.00126323"},
        {"Smithsonian Astrophysical Observation", "SAO 16355"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.62052386),
        dec: Angle.Degrees(+60.96590392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101075",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101075"},
        {"Smithsonian Astrophysical Observation", "SAO 18892"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.34801009),
        dec: Angle.Degrees(+60.96773187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151554"},
        {"Hipparcos Number", "HIP 81940"},
        {"Geneva Identification System", "GEN# +1.00151554"},
        {"Smithsonian Astrophysical Observation", "SAO 17204"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.07317780),
        dec: Angle.Degrees(+60.97066660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177275"},
        {"Hipparcos Number", "HIP 93296"},
        {"Smithsonian Astrophysical Observation", "SAO 18107"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.05073599),
        dec: Angle.Degrees(+60.97801025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103058",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103058"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.20138949),
        dec: Angle.Degrees(+60.98091166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67133",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67133"},
    },
    visualMagnitude: 11.03,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.38084366),
        dec: Angle.Degrees(+60.98252945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46965",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46965"},
        {"Smithsonian Astrophysical Observation", "SAO 14924"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.58742775),
        dec: Angle.Degrees(+60.98311434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11374"},
        {"Hipparcos Number", "HIP 8835"},
        {"Geneva Identification System", "GEN# +1.00011374"},
        {"Smithsonian Astrophysical Observation", "SAO 12024"},
        {"Wilson Evans Batten Catalogue", "WEB 1861"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.40701924),
        dec: Angle.Degrees(+60.99014539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77292"},
        {"Hipparcos Number", "HIP 44557"},
        {"Geneva Identification System", "GEN# +1.00077292"},
        {"Smithsonian Astrophysical Observation", "SAO 14752"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.17562731),
        dec: Angle.Degrees(+60.99089427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195688"},
        {"Hipparcos Number", "HIP 101096"},
        {"Geneva Identification System", "GEN# +1.00195688"},
        {"Smithsonian Astrophysical Observation", "SAO 18894"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.39897542),
        dec: Angle.Degrees(+60.99240502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65429"},
        {"Hipparcos Number", "HIP 39313"},
        {"Geneva Identification System", "GEN# +1.00065429"},
        {"Smithsonian Astrophysical Observation", "SAO 14406"},
        {"Wilson Evans Batten Catalogue", "WEB 7698"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.56910671),
        dec: Angle.Degrees(+60.99341814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75302",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9623 AB"},
        {"Henry Draper", "HD 137470"},
        {"Hipparcos Number", "HIP 75302"},
        {"Smithsonian Astrophysical Observation", "SAO 16716"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.78759917),
        dec: Angle.Degrees(+60.99347749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158147"},
        {"Hipparcos Number", "HIP 85108"},
        {"Smithsonian Astrophysical Observation", "SAO 17458"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.90715896),
        dec: Angle.Degrees(+60.99847746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109250",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109250"},
        {"Smithsonian Astrophysical Observation", "SAO 19875"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.98920774),
        dec: Angle.Degrees(+60.99965782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1142"},
        {"Hipparcos Number", "HIP 1269"},
        {"Celescope Catalog", "CEL 48"},
        {"Geneva Identification System", "GEN# +1.00001142"},
        {"Smithsonian Astrophysical Observation", "SAO 11074"},
        {"Wilson Evans Batten Catalogue", "WEB 225"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.97863172),
        dec: Angle.Degrees(+61.00019736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117763",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117763"},
        {"Geneva Identification System", "GEN# +0.06002634"},
        {"Smithsonian Astrophysical Observation", "SAO 20912"},
    },
    visualMagnitude: 8.80,
    bvColour: 2.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.23433653),
        dec: Angle.Degrees(+61.00233502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106014",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106014"},
        {"Smithsonian Astrophysical Observation", "SAO 19437"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.08589869),
        dec: Angle.Degrees(+61.00380897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101869",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101869"},
        {"Smithsonian Astrophysical Observation", "SAO 18964"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.64244809),
        dec: Angle.Degrees(+61.00593336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9409",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9409"},
        {"Geneva Identification System", "GEN# +0.06000412"},
        {"Smithsonian Astrophysical Observation", "SAO 12083"},
        {"Wilson Evans Batten Catalogue", "WEB 1975"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.22282538),
        dec: Angle.Degrees(+61.01361172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211457"},
        {"Hipparcos Number", "HIP 109889"},
        {"Smithsonian Astrophysical Observation", "SAO 19964"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.85026944),
        dec: Angle.Degrees(+61.01399896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3442",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3442"},
        {"Smithsonian Astrophysical Observation", "SAO 11350"},
    },
    visualMagnitude: 9.82,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.99500643),
        dec: Angle.Degrees(+61.01555551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49671"},
        {"Hipparcos Number", "HIP 33100"},
        {"Smithsonian Astrophysical Observation", "SAO 13997"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.40859425),
        dec: Angle.Degrees(+61.01559618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91391",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91391"},
        {"Smithsonian Astrophysical Observation", "SAO 17960"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.59046528),
        dec: Angle.Degrees(+61.01729035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208960"},
        {"Hipparcos Number", "HIP 108426"},
        {"Geneva Identification System", "GEN# +1.00208960J"},
        {"Smithsonian Astrophysical Observation", "SAO 19765"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.46638277),
        dec: Angle.Degrees(+61.01887130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210478"},
        {"Hipparcos Number", "HIP 109311"},
        {"Celescope Catalog", "CEL 5443"},
        {"Geneva Identification System", "GEN# +1.00210478"},
        {"Smithsonian Astrophysical Observation", "SAO 19892"},
        {"Wilson Evans Batten Catalogue", "WEB 19643"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.18998592),
        dec: Angle.Degrees(+61.02243050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141768"},
        {"Hipparcos Number", "HIP 77355"},
        {"Geneva Identification System", "GEN# +1.00141768"},
        {"Smithsonian Astrophysical Observation", "SAO 16853"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.86372766),
        dec: Angle.Degrees(+61.02273844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83236",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83236"},
        {"Smithsonian Astrophysical Observation", "SAO 17311"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.16094832),
        dec: Angle.Degrees(+61.02399372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118090",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17119 AB"},
        {"Henry Draper", "HD 224364"},
        {"Hipparcos Number", "HIP 118090"},
        {"Smithsonian Astrophysical Observation", "SAO 20954"},
        {"Wilson Evans Batten Catalogue", "WEB 20761"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.33132507),
        dec: Angle.Degrees(+61.02621011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110084"},
        {"Hipparcos Number", "HIP 61712"},
        {"Smithsonian Astrophysical Observation", "SAO 15853"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.73990862),
        dec: Angle.Degrees(+61.02889513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2070",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2070"},
        {"Smithsonian Astrophysical Observation", "SAO 11187"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.54964931),
        dec: Angle.Degrees(+61.02908735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190861"},
        {"Hipparcos Number", "HIP 98762"},
        {"Smithsonian Astrophysical Observation", "SAO 18681"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.89238206),
        dec: Angle.Degrees(+61.03106299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95209"},
        {"Hipparcos Number", "HIP 53828"},
        {"Smithsonian Astrophysical Observation", "SAO 15359"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.19803375),
        dec: Angle.Degrees(+61.03813781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37585"},
        {"Hipparcos Number", "HIP 26988"},
        {"Geneva Identification System", "GEN# +1.00037585"},
        {"Smithsonian Astrophysical Observation", "SAO 13581"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.89071793),
        dec: Angle.Degrees(+61.03824331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10260"},
        {"Hipparcos Number", "HIP 7939"},
        {"Geneva Identification System", "GEN# +1.00010260"},
        {"Renson", "Renson 2560"},
        {"Smithsonian Astrophysical Observation", "SAO 11920"},
        {"Wilson Evans Batten Catalogue", "WEB 1695"},
    },
    visualMagnitude: 6.69,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.51208457),
        dec: Angle.Degrees(+61.03825058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25474"},
        {"Hipparcos Number", "HIP 19155"},
        {"Smithsonian Astrophysical Observation", "SAO 13019"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.58797238),
        dec: Angle.Degrees(+61.04037347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4781",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 838 AB"},
        {"Henry Draper", "HD 5890"},
        {"Hipparcos Number", "HIP 4781"},
        {"Geneva Identification System", "GEN# +1.00005890"},
        {"Smithsonian Astrophysical Observation", "SAO 11529"},
        {"Wilson Evans Batten Catalogue", "WEB 909"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.35200092),
        dec: Angle.Degrees(+61.04324179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87594",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10887 A"},
        {"Henry Draper", "HD 163714"},
        {"Hipparcos Number", "HIP 87594"},
        {"Smithsonian Astrophysical Observation", "SAO 17673"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.40203302),
        dec: Angle.Degrees(+61.04380521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12708"},
        {"Hipparcos Number", "HIP 9832"},
        {"Geneva Identification System", "GEN# +1.00012708"},
        {"Smithsonian Astrophysical Observation", "SAO 12128"},
        {"Wilson Evans Batten Catalogue", "WEB 2063"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.62918364),
        dec: Angle.Degrees(+61.04481078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91915",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11661"},
        {"Aitken 2", "ADS 11661 AB"},
        {"Henry Draper", "HD 173949"},
        {"Hipparcos Number", "HIP 91915"},
        {"Geneva Identification System", "GEN# +1.00173949J"},
        {"Smithsonian Astrophysical Observation", "SAO 17995"},
        {"Wilson Evans Batten Catalogue", "WEB 15827"},
    },
    visualMagnitude: 6.02,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.07610546),
        dec: Angle.Degrees(+61.04809633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38609",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38609"},
        {"Smithsonian Astrophysical Observation", "SAO 14358"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.58976892),
        dec: Angle.Degrees(+61.05783343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12340"},
        {"Hipparcos Number", "HIP 9575"},
        {"Geneva Identification System", "GEN# +1.00012340"},
        {"Wilson Evans Batten Catalogue", "WEB 2009"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.75579889),
        dec: Angle.Degrees(+61.06516241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12293",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12293"},
        {"Geneva Identification System", "GEN# +0.06000526"},
        {"Smithsonian Astrophysical Observation", "SAO 12366"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.58580906),
        dec: Angle.Degrees(+61.06936420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4962",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 868 AB"},
        {"Henry Draper", "HD 6130"},
        {"Hipparcos Number", "HIP 4962"},
        {"Geneva Identification System", "GEN# +1.00006130"},
        {"Smithsonian Astrophysical Observation", "SAO 11551"},
        {"Wilson Evans Batten Catalogue", "WEB 994"},
    },
    visualMagnitude: 5.92,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.90419820),
        dec: Angle.Degrees(+61.07482982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190187"},
        {"Hipparcos Number", "HIP 98483"},
        {"Smithsonian Astrophysical Observation", "SAO 18647"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.10772515),
        dec: Angle.Degrees(+61.07595542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23380",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3590 AB"},
        {"Henry Draper", "HD 31662"},
        {"Hipparcos Number", "HIP 23380"},
        {"Geneva Identification System", "GEN# +1.00031662J"},
        {"Smithsonian Astrophysical Observation", "SAO 13341"},
        {"Wilson Evans Batten Catalogue", "WEB 4540"},
    },
    visualMagnitude: 6.03,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.40009862),
        dec: Angle.Degrees(+61.07843227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9973"},
        {"Hipparcos Number", "HIP 7697"},
        {"Geneva Identification System", "GEN# +1.00009973"},
        {"Smithsonian Astrophysical Observation", "SAO 11893"},
        {"Wilson Evans Batten Catalogue", "WEB 1645"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.77987375),
        dec: Angle.Degrees(+61.07909352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43169"},
        {"Hipparcos Number", "HIP 29989"},
        {"Smithsonian Astrophysical Observation", "SAO 13798"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.69509722),
        dec: Angle.Degrees(+61.08255633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56290",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8197 AB"},
        {"Henry Draper", "HD 100203"},
        {"Hipparcos Number", "HIP 56290"},
        {"Geneva Identification System", "GEN# +1.00100203J"},
        {"Smithsonian Astrophysical Observation", "SAO 15542"},
        {"Wilson Evans Batten Catalogue", "WEB 10118"},
    },
    visualMagnitude: 5.46,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.08648748),
        dec: Angle.Degrees(+61.08275166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76206"},
        {"Hipparcos Number", "HIP 44006"},
        {"Smithsonian Astrophysical Observation", "SAO 14715"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.40587806),
        dec: Angle.Degrees(+61.08461782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116272"},
        {"Hipparcos Number", "HIP 65165"},
        {"Cincinnati Publication", "Ci 18 1726"},
        {"Fundamental Katalog 5th Edition", "FK5 5180"},
        {"Geneva Identification System", "GEN# +1.00116272"},
        {"Smithsonian Astrophysical Observation", "SAO 16056"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.30146013),
        dec: Angle.Degrees(+61.08471334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -283.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94099"},
        {"Hipparcos Number", "HIP 53204"},
        {"Smithsonian Astrophysical Observation", "SAO 15320"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.22533509),
        dec: Angle.Degrees(+61.08536064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -163.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220819"},
        {"Hipparcos Number", "HIP 115691"},
        {"Geneva Identification System", "GEN# +2.76541267"},
        {"Smithsonian Astrophysical Observation", "SAO 20626"},
        {"Wilson Evans Batten Catalogue", "WEB 20473"},
        {"New General Catalogue", "NGC 7654 1267"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.58729243),
        dec: Angle.Degrees(+61.08685276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88296"},
        {"Hipparcos Number", "HIP 50024"},
        {"Geneva Identification System", "GEN# +1.00088296"},
        {"Smithsonian Astrophysical Observation", "SAO 15118"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.19741225),
        dec: Angle.Degrees(+61.08896801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58807"},
        {"Hipparcos Number", "HIP 36531"},
        {"Geneva Identification System", "GEN# +1.00058807"},
        {"Smithsonian Astrophysical Observation", "SAO 14216"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.73135700),
        dec: Angle.Degrees(+61.09312514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110813"},
        {"Hipparcos Number", "HIP 62126"},
        {"Geneva Identification System", "GEN# +1.00110813"},
        {"Smithsonian Astrophysical Observation", "SAO 15883"},
        {"Wilson Evans Batten Catalogue", "WEB 11043"},
    },
    visualMagnitude: 8.94,
    bvColour: 2.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.98621535),
        dec: Angle.Degrees(+61.09320638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132992"},
        {"Hipparcos Number", "HIP 73344"},
        {"Smithsonian Astrophysical Observation", "SAO 16564"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.81948409),
        dec: Angle.Degrees(+61.09412346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13447",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13447"},
        {"Smithsonian Astrophysical Observation", "SAO 12487"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.29355394),
        dec: Angle.Degrees(+61.09691555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72029",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9371 A"},
        {"Henry Draper", "HD 130173"},
        {"Hipparcos Number", "HIP 72029"},
        {"Smithsonian Astrophysical Observation", "SAO 16478"},
        {"Wilson Evans Batten Catalogue", "WEB 12398"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.01460504),
        dec: Angle.Degrees(+61.09835347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209215"},
        {"Hipparcos Number", "HIP 108580"},
        {"Geneva Identification System", "GEN# +1.00209215"},
        {"Smithsonian Astrophysical Observation", "SAO 19780"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.93255811),
        dec: Angle.Degrees(+61.10096511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76593"},
        {"Hipparcos Number", "HIP 44188"},
        {"Geneva Identification System", "GEN# +1.00076593"},
        {"Smithsonian Astrophysical Observation", "SAO 14733"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.01976297),
        dec: Angle.Degrees(+61.10112049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72028",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9371 B"},
        {"Hipparcos Number", "HIP 72028"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.01452815),
        dec: Angle.Degrees(+61.10156714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225146"},
        {"Hipparcos Number", "HIP 312"},
        {"Celescope Catalog", "CEL 7"},
        {"Geneva Identification System", "GEN# +1.00225146"},
        {"Smithsonian Astrophysical Observation", "SAO 10950"},
        {"Wilson Evans Batten Catalogue", "WEB 45"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.98959785),
        dec: Angle.Degrees(+61.10364174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206079"},
        {"Hipparcos Number", "HIP 106737"},
        {"Geneva Identification System", "GEN# +1.00206079"},
        {"Renson", "Renson 57380"},
        {"Smithsonian Astrophysical Observation", "SAO 19531"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.32757112),
        dec: Angle.Degrees(+61.10556052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15851"},
        {"Henry Draper 2", "HD 15851A"},
        {"Hipparcos Number", "HIP 12067"},
        {"Geneva Identification System", "GEN# +1.00015851"},
        {"Smithsonian Astrophysical Observation", "SAO 12348"},
        {"Wilson Evans Batten Catalogue", "WEB 2483"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.89766253),
        dec: Angle.Degrees(+61.10640880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18488",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2867 A"},
        {"Henry Draper", "HD 24480"},
        {"Hipparcos Number", "HIP 18488"},
        {"Smithsonian Astrophysical Observation", "SAO 12968"},
        {"Wilson Evans Batten Catalogue", "WEB 3562"},
    },
    visualMagnitude: 4.99,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.28455287),
        dec: Angle.Degrees(+61.10891703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7365",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7365"},
    },
    visualMagnitude: 9.89,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.71621781),
        dec: Angle.Degrees(+61.10943105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19916",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19916"},
        {"Smithsonian Astrophysical Observation", "SAO 13072"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.08623234),
        dec: Angle.Degrees(+61.11184935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85583"},
        {"Hipparcos Number", "HIP 48638"},
        {"Fundamental Katalog 5th Edition", "FK5 2790"},
        {"Geneva Identification System", "GEN# +1.00085583"},
        {"Smithsonian Astrophysical Observation", "SAO 15023"},
        {"Wilson Evans Batten Catalogue", "WEB 9052"},
    },
    visualMagnitude: 6.29,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.76395029),
        dec: Angle.Degrees(+61.11613097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198662"},
        {"Hipparcos Number", "HIP 102727"},
        {"Geneva Identification System", "GEN# +1.00198662"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.23872779),
        dec: Angle.Degrees(+61.11885714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42218",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42218"},
        {"Smithsonian Astrophysical Observation", "SAO 14601"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.10825178),
        dec: Angle.Degrees(+61.11922419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105363",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14899 A"},
        {"Henry Draper", "HD 203550"},
        {"Hipparcos Number", "HIP 105363"},
        {"Geneva Identification System", "GEN# +1.00203550"},
        {"Smithsonian Astrophysical Observation", "SAO 19331"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.11603882),
        dec: Angle.Degrees(+61.12022459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207260"},
        {"Hipparcos Number", "HIP 107418"},
        {"Celescope Catalog", "CEL 5380"},
        {"Fundamental Katalog 5th Edition", "FK5 1572"},
        {"Geneva Identification System", "GEN# +1.00207260"},
        {"Smithsonian Astrophysical Observation", "SAO 19624"},
        {"Wilson Evans Batten Catalogue", "WEB 19397"},
    },
    visualMagnitude: 4.25,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.36220534),
        dec: Angle.Degrees(+61.12081043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210352"},
        {"Hipparcos Number", "HIP 109254"},
        {"Smithsonian Astrophysical Observation", "SAO 19876"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.00189257),
        dec: Angle.Degrees(+61.12280081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4151",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 721 A"},
        {"Henry Draper", "HD 5015"},
        {"Hipparcos Number", "HIP 4151"},
        {"Geneva Identification System", "GEN# +1.00005015"},
        {"Smithsonian Astrophysical Observation", "SAO 11444"},
        {"Wilson Evans Batten Catalogue", "WEB 741"},
    },
    visualMagnitude: 4.80,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.26783051),
        dec: Angle.Degrees(+61.12355735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 169.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28326",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4538 AB"},
        {"Henry Draper", "HD 39813"},
        {"Hipparcos Number", "HIP 28326"},
        {"Smithsonian Astrophysical Observation", "SAO 13670"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.77109766),
        dec: Angle.Degrees(+61.12362904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45731",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45731"},
    },
    visualMagnitude: 11.42,
    bvColour: 1.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.84676740),
        dec: Angle.Degrees(+62.05561928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -287.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -382.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23317",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23317"},
    },
    visualMagnitude: 10.03,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.21658194),
        dec: Angle.Degrees(+61.12527033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -221.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99180",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99180"},
        {"Smithsonian Astrophysical Observation", "SAO 18729"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.03211178),
        dec: Angle.Degrees(+61.12665821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105339",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105339"},
        {"Smithsonian Astrophysical Observation", "SAO 19322"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.05195222),
        dec: Angle.Degrees(+61.12704601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19968"},
        {"Hipparcos Number", "HIP 15180"},
        {"Geneva Identification System", "GEN# +1.00019968"},
        {"Smithsonian Astrophysical Observation", "SAO 12673"},
        {"Wilson Evans Batten Catalogue", "WEB 2921"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.91034907),
        dec: Angle.Degrees(+61.12794670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18152"},
        {"Hipparcos Number", "HIP 13797"},
        {"Geneva Identification System", "GEN# +1.00018152"},
        {"Smithsonian Astrophysical Observation", "SAO 12532"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.40758473),
        dec: Angle.Degrees(+61.12875678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2501",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2501"},
        {"Smithsonian Astrophysical Observation", "SAO 11246"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.92888867),
        dec: Angle.Degrees(+61.13055565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8325",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8325"},
        {"Geneva Identification System", "GEN# +2.06630221"},
        {"Smithsonian Astrophysical Observation", "SAO 11982"},
        {"New General Catalogue", "NGC 663 221"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.83404257),
        dec: Angle.Degrees(+61.13194410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211810"},
        {"Hipparcos Number", "HIP 110094"},
        {"Smithsonian Astrophysical Observation", "SAO 19989"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.52644177),
        dec: Angle.Degrees(+61.13412413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 160.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 128.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49761",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49761"},
        {"Smithsonian Astrophysical Observation", "SAO 15101"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.36871008),
        dec: Angle.Degrees(+61.13508389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48438",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48438"},
        {"Smithsonian Astrophysical Observation", "SAO 15006"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.14158502),
        dec: Angle.Degrees(+61.13517830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32001",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32001"},
    },
    visualMagnitude: 11.47,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.29311021),
        dec: Angle.Degrees(+61.13600568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -209.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6303",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6303"},
        {"Smithsonian Astrophysical Observation", "SAO 11710"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.23802137),
        dec: Angle.Degrees(+61.13674995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113527",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113527"},
        {"Geneva Identification System", "GEN# +0.06002465"},
        {"Smithsonian Astrophysical Observation", "SAO 20356"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.88687008),
        dec: Angle.Degrees(+61.14016903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71025"},
        {"Hipparcos Number", "HIP 41568"},
        {"Geneva Identification System", "GEN# +1.00071025"},
        {"Smithsonian Astrophysical Observation", "SAO 14565"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.13769359),
        dec: Angle.Degrees(+61.14157837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14061"},
        {"Hipparcos Number", "HIP 10794"},
        {"Geneva Identification System", "GEN# +1.00014061"},
        {"Smithsonian Astrophysical Observation", "SAO 12217"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.73851007),
        dec: Angle.Degrees(+61.14593046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13338",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13338"},
        {"Smithsonian Astrophysical Observation", "SAO 12475"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.92296245),
        dec: Angle.Degrees(+61.14611796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220057"},
        {"Hipparcos Number", "HIP 115198"},
        {"Celescope Catalog", "CEL 5598"},
        {"Geneva Identification System", "GEN# +2.76540197"},
        {"Smithsonian Astrophysical Observation", "SAO 20562"},
        {"Wilson Evans Batten Catalogue", "WEB 20407"},
        {"New General Catalogue", "NGC 7654 197"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.00270642),
        dec: Angle.Degrees(+61.14984184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66279",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66279"},
        {"Smithsonian Astrophysical Observation", "SAO 16115"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.76418286),
        dec: Angle.Degrees(+61.15082263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108518"},
        {"Hipparcos Number", "HIP 60796"},
        {"Smithsonian Astrophysical Observation", "SAO 15806"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.90393487),
        dec: Angle.Degrees(+61.15273496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110678"},
        {"Hipparcos Number", "HIP 62046"},
        {"Geneva Identification System", "GEN# +1.00110678"},
        {"Smithsonian Astrophysical Observation", "SAO 15877"},
        {"Wilson Evans Batten Catalogue", "WEB 11031"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.76746044),
        dec: Angle.Degrees(+61.15537241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61396"},
        {"Hipparcos Number", "HIP 37595"},
        {"Smithsonian Astrophysical Observation", "SAO 14296"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.71042326),
        dec: Angle.Degrees(+61.15740605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115566",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115566"},
        {"Geneva Identification System", "GEN# +2.76540842"},
        {"Smithsonian Astrophysical Observation", "SAO 20610"},
        {"New General Catalogue", "NGC 7654 842"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.13765197),
        dec: Angle.Degrees(+61.15783736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155513"},
        {"Hipparcos Number", "HIP 83847"},
        {"Geneva Identification System", "GEN# +1.00155513"},
        {"Smithsonian Astrophysical Observation", "SAO 17360"},
        {"Wilson Evans Batten Catalogue", "WEB 14168"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.03149626),
        dec: Angle.Degrees(+61.15946853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105920",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105920"},
        {"Smithsonian Astrophysical Observation", "SAO 19416"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.78259979),
        dec: Angle.Degrees(+61.15967740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216103"},
        {"Hipparcos Number", "HIP 112647"},
        {"Smithsonian Astrophysical Observation", "SAO 20256"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.22004450),
        dec: Angle.Degrees(+61.16144190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51707",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51707"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.47574256),
        dec: Angle.Degrees(+61.16310987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24238"},
        {"Hipparcos Number", "HIP 18324"},
        {"Cincinnati Publication", "Ci 18 521"},
        {"Cincinnati Publication 2", "Ci 20 268"},
        {"Geneva Identification System", "GEN# +1.00024238"},
        {"Smithsonian Astrophysical Observation", "SAO 12955"},
        {"Wilson Evans Batten Catalogue", "WEB 3537"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.76380482),
        dec: Angle.Degrees(+61.16740375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 437.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -245.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75879"},
        {"Hipparcos Number", "HIP 43841"},
        {"Cincinnati Publication", "Ci 18 1045"},
        {"Smithsonian Astrophysical Observation", "SAO 14701"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.94801931),
        dec: Angle.Degrees(+61.16741939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3836",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3836"},
        {"Smithsonian Astrophysical Observation", "SAO 11415"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.31053350),
        dec: Angle.Degrees(+61.16809976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90733",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90733"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.68319765),
        dec: Angle.Degrees(+61.16812866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32356"},
        {"Hipparcos Number", "HIP 23766"},
        {"Geneva Identification System", "GEN# +1.00032356"},
        {"Smithsonian Astrophysical Observation", "SAO 13369"},
        {"Wilson Evans Batten Catalogue", "WEB 4636"},
    },
    visualMagnitude: 6.00,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.62356728),
        dec: Angle.Degrees(+61.16994070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109712",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109712"},
        {"Smithsonian Astrophysical Observation", "SAO 19946"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.34586572),
        dec: Angle.Degrees(+61.17043017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21972"},
        {"Hipparcos Number", "HIP 16767"},
        {"Smithsonian Astrophysical Observation", "SAO 12828"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.93949435),
        dec: Angle.Degrees(+61.17067954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150578"},
        {"Hipparcos Number", "HIP 81451"},
        {"Smithsonian Astrophysical Observation", "SAO 17170"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.54062671),
        dec: Angle.Degrees(+61.17233118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54679",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54679"},
        {"Smithsonian Astrophysical Observation", "SAO 15429"},
    },
    visualMagnitude: 10.14,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.89596647),
        dec: Angle.Degrees(+61.17712204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154859"},
        {"Hipparcos Number", "HIP 83521"},
        {"Smithsonian Astrophysical Observation", "SAO 17337"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.03954575),
        dec: Angle.Degrees(+61.18407773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203265"},
        {"Hipparcos Number", "HIP 105193"},
        {"Smithsonian Astrophysical Observation", "SAO 19298"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.63514400),
        dec: Angle.Degrees(+61.18440127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167347"},
        {"Hipparcos Number", "HIP 89075"},
        {"Smithsonian Astrophysical Observation", "SAO 17798"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.69114558),
        dec: Angle.Degrees(+61.18472375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107976",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107976"},
        {"Smithsonian Astrophysical Observation", "SAO 19695"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.12666656),
        dec: Angle.Degrees(+61.18698196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104055",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104055"},
        {"Smithsonian Astrophysical Observation", "SAO 19179"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.21717848),
        dec: Angle.Degrees(+61.18901127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11821"},
        {"Hipparcos Number", "HIP 9161"},
        {"Geneva Identification System", "GEN# +1.00011821"},
        {"Smithsonian Astrophysical Observation", "SAO 12057"},
        {"Wilson Evans Batten Catalogue", "WEB 1921"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.48666172),
        dec: Angle.Degrees(+61.19265755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118163",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118163"},
        {"Geneva Identification System", "GEN# +2.77900151"},
    },
    visualMagnitude: 11.08,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.53073043),
        dec: Angle.Degrees(+61.19579106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8305",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8305"},
        {"Geneva Identification System", "GEN# +2.06630147"},
        {"Smithsonian Astrophysical Observation", "SAO 11980"},
        {"New General Catalogue", "NGC 663 147"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.78714101),
        dec: Angle.Degrees(+61.19845540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146227"},
        {"Hipparcos Number", "HIP 79345"},
        {"Smithsonian Astrophysical Observation", "SAO 16988"},
        {"Wilson Evans Batten Catalogue", "WEB 13413"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.89637234),
        dec: Angle.Degrees(+61.19937290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183098"},
        {"Hipparcos Number", "HIP 95373"},
        {"Geneva Identification System", "GEN# +1.00183098J"},
        {"Smithsonian Astrophysical Observation", "SAO 18325"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.03308031),
        dec: Angle.Degrees(+61.20339713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97192"},
        {"Hipparcos Number", "HIP 54716"},
        {"Smithsonian Astrophysical Observation", "SAO 15432"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.04248194),
        dec: Angle.Degrees(+61.20432714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70010"},
        {"Hipparcos Number", "HIP 41097"},
        {"Smithsonian Astrophysical Observation", "SAO 14524"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.76297991),
        dec: Angle.Degrees(+61.20558610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13236"},
        {"Hipparcos Number", "HIP 10224"},
        {"Smithsonian Astrophysical Observation", "SAO 12163"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.86541226),
        dec: Angle.Degrees(+61.20591961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4956",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4956"},
        {"Geneva Identification System", "GEN# +0.06000156"},
        {"Smithsonian Astrophysical Observation", "SAO 11548"},
        {"Wilson Evans Batten Catalogue", "WEB 996"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.89001286),
        dec: Angle.Degrees(+61.20876366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188166"},
        {"Hipparcos Number", "HIP 97612"},
        {"Geneva Identification System", "GEN# +1.00188166"},
        {"Smithsonian Astrophysical Observation", "SAO 18556"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.59128154),
        dec: Angle.Degrees(+61.20897379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85089",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85089"},
        {"Smithsonian Astrophysical Observation", "SAO 17457"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.85823185),
        dec: Angle.Degrees(+61.21150098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5658",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5658"},
        {"Wilson Evans Batten Catalogue", "WEB 1280"},
    },
    visualMagnitude: 11.43,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.17153202),
        dec: Angle.Degrees(+61.21336084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1846",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1846"},
    },
    visualMagnitude: 11.07,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.83397359),
        dec: Angle.Degrees(+61.21547843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 297.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21624",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21624"},
        {"Smithsonian Astrophysical Observation", "SAO 13217"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.64099573),
        dec: Angle.Degrees(+61.21594179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24726",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24726"},
        {"Geneva Identification System", "GEN# +0.06100776"},
        {"Smithsonian Astrophysical Observation", "SAO 13447"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.54351898),
        dec: Angle.Degrees(+61.21674910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118174",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118174"},
    },
    visualMagnitude: 11.09,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.57491737),
        dec: Angle.Degrees(+61.22106517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224893"},
        {"Hipparcos Number", "HIP 124"},
        {"Celescope Catalog", "CEL 5752"},
        {"Geneva Identification System", "GEN# +1.00224893"},
        {"Smithsonian Astrophysical Observation", "SAO 21009"},
        {"Wilson Evans Batten Catalogue", "WEB 18"},
    },
    visualMagnitude: 5.58,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.40424537),
        dec: Angle.Degrees(+61.22280406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20569",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20569"},
        {"Smithsonian Astrophysical Observation", "SAO 13133"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.10167283),
        dec: Angle.Degrees(+61.22379312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116108"},
        {"Hipparcos Number", "HIP 65062"},
        {"Geneva Identification System", "GEN# +1.00116108"},
        {"Smithsonian Astrophysical Observation", "SAO 16048"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.04788663),
        dec: Angle.Degrees(+61.22814536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8239",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1384 A"},
        {"Hipparcos Number", "HIP 8239"},
        {"Geneva Identification System", "GEN# +2.06630054"},
        {"Smithsonian Astrophysical Observation", "SAO 11968"},
        {"New General Catalogue", "NGC 663 54"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.52041485),
        dec: Angle.Degrees(+61.22827561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71403",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71403"},
        {"Fundamental Katalog 5th Edition", "FK5 5295"},
        {"Smithsonian Astrophysical Observation", "SAO 16440"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.02109016),
        dec: Angle.Degrees(+61.22920192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12469",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "LS I +63 303"},
        {"Hipparcos Number", "HIP 12469"},
        {"Geneva Identification System", "GEN# +8.01610303"},
        {"Geneva Identification System 2", "GEN# +6.20055754"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.13193708),
        dec: Angle.Degrees(+61.22933035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102856"},
        {"Hipparcos Number", "HIP 57754"},
        {"Geneva Identification System", "GEN# +1.00102856"},
        {"Smithsonian Astrophysical Observation", "SAO 15642"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.66926671),
        dec: Angle.Degrees(+61.22986027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36615"},
        {"Hipparcos Number", "HIP 26371"},
        {"Geneva Identification System", "GEN# +1.00036615"},
        {"Smithsonian Astrophysical Observation", "SAO 13549"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.22956516),
        dec: Angle.Degrees(+61.23257036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149801"},
        {"Hipparcos Number", "HIP 81060"},
        {"Geneva Identification System", "GEN# +1.00149801"},
        {"Smithsonian Astrophysical Observation", "SAO 17139"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.33505662),
        dec: Angle.Degrees(+61.23374956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113702",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113702"},
        {"Smithsonian Astrophysical Observation", "SAO 20373"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.42656801),
        dec: Angle.Degrees(+61.23695813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160934"},
        {"Hipparcos Number", "HIP 86346"},
    },
    visualMagnitude: 10.29,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.66526651),
        dec: Angle.Degrees(+61.23766799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26138"},
        {"Hipparcos Number", "HIP 19620"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.05739112),
        dec: Angle.Degrees(+61.24165484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35073"},
        {"Hipparcos Number", "HIP 25414"},
        {"Geneva Identification System", "GEN# +1.00035073"},
        {"Smithsonian Astrophysical Observation", "SAO 13489"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.53086407),
        dec: Angle.Degrees(+61.24211642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -256.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53255"},
        {"Hipparcos Number", "HIP 34435"},
        {"Smithsonian Astrophysical Observation", "SAO 14083"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.08740706),
        dec: Angle.Degrees(+61.24219431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11716"},
        {"Hipparcos Number", "HIP 9081"},
        {"Geneva Identification System", "GEN# +1.00011716"},
        {"Smithsonian Astrophysical Observation", "SAO 12048"},
        {"Wilson Evans Batten Catalogue", "WEB 1904"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.23542300),
        dec: Angle.Degrees(+61.24540272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210413"},
        {"Hipparcos Number", "HIP 109295"},
        {"Smithsonian Astrophysical Observation", "SAO 19886"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.11726823),
        dec: Angle.Degrees(+61.24830811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74905"},
        {"Hipparcos Number", "HIP 43361"},
        {"Geneva Identification System", "GEN# +1.00074905"},
        {"Smithsonian Astrophysical Observation", "SAO 14674"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.48868825),
        dec: Angle.Degrees(+61.24995256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117575"},
        {"Hipparcos Number", "HIP 65838"},
        {"Smithsonian Astrophysical Observation", "SAO 16089"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.44240016),
        dec: Angle.Degrees(+61.25164153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82703"},
        {"Hipparcos Number", "HIP 47117"},
        {"Geneva Identification System", "GEN# +1.00082703"},
        {"Smithsonian Astrophysical Observation", "SAO 14933"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.02521286),
        dec: Angle.Degrees(+61.25370191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5342"},
        {"Hipparcos Number", "HIP 4384"},
        {"Geneva Identification System", "GEN# +1.00005342"},
        {"Renson", "Renson 1410"},
        {"Smithsonian Astrophysical Observation", "SAO 11475"},
        {"Wilson Evans Batten Catalogue", "WEB 782"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.05454953),
        dec: Angle.Degrees(+61.25401163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36026"},
        {"Hipparcos Number", "HIP 25991"},
        {"Geneva Identification System", "GEN# +1.00036026"},
        {"Renson", "Renson 9280"},
        {"Smithsonian Astrophysical Observation", "SAO 13529"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.20264263),
        dec: Angle.Degrees(+61.25681612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8260",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1388 A"},
        {"Hipparcos Number", "HIP 8260"},
        {"Geneva Identification System", "GEN# +2.06630044"},
        {"Smithsonian Astrophysical Observation", "SAO 11972"},
        {"Wilson Evans Batten Catalogue", "WEB 1760"},
        {"New General Catalogue", "NGC 663 44"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.59909793),
        dec: Angle.Degrees(+61.25825645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20454"},
        {"Hipparcos Number", "HIP 15567"},
        {"Smithsonian Astrophysical Observation", "SAO 12713"},
        {"Wilson Evans Batten Catalogue", "WEB 2990"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.14456557),
        dec: Angle.Degrees(+61.26052174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71876",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9357 AB"},
        {"Henry Draper", "HD 129798"},
        {"Hipparcos Number", "HIP 71876"},
        {"Geneva Identification System", "GEN# +1.00129798J"},
        {"Smithsonian Astrophysical Observation", "SAO 16466"},
        {"Wilson Evans Batten Catalogue", "WEB 12380"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.51315491),
        dec: Angle.Degrees(+61.26198751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204185"},
        {"Hipparcos Number", "HIP 105680"},
        {"Geneva Identification System", "GEN# +1.00204185"},
        {"Smithsonian Astrophysical Observation", "SAO 19384"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.08017087),
        dec: Angle.Degrees(+61.27137705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61081",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61081"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.77335620),
        dec: Angle.Degrees(+61.27195731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 199.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207780"},
        {"Hipparcos Number", "HIP 107723"},
        {"Geneva Identification System", "GEN# +1.00207780"},
        {"Smithsonian Astrophysical Observation", "SAO 19663"},
        {"Wilson Evans Batten Catalogue", "WEB 19429"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.32921360),
        dec: Angle.Degrees(+61.27281592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9696"},
        {"Hipparcos Number", "HIP 7497"},
        {"Renson", "Renson 2390"},
        {"Smithsonian Astrophysical Observation", "SAO 11864"},
        {"Wilson Evans Batten Catalogue", "WEB 1604"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.15808482),
        dec: Angle.Degrees(+61.27673905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9037",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1531 AB"},
        {"Henry Draper", "HD 11669"},
        {"Hipparcos Number", "HIP 9037"},
        {"Geneva Identification System", "GEN# +1.00011669J"},
        {"Smithsonian Astrophysical Observation", "SAO 12046"},
        {"Wilson Evans Batten Catalogue", "WEB 1898"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.09816208),
        dec: Angle.Degrees(+61.28111743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103614",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103614"},
        {"Smithsonian Astrophysical Observation", "SAO 19139"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.89484605),
        dec: Angle.Degrees(+61.28184023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101120"},
        {"Hipparcos Number", "HIP 56786"},
        {"Smithsonian Astrophysical Observation", "SAO 15579"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.63662077),
        dec: Angle.Degrees(+61.28187534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12495",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2018 A"},
        {"Henry Draper", "HD 16429"},
        {"Hipparcos Number", "HIP 12495"},
        {"Geneva Identification System", "GEN# +1.00016429"},
        {"Smithsonian Astrophysical Observation", "SAO 12383"},
        {"Wilson Evans Batten Catalogue", "WEB 2551"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.18729039),
        dec: Angle.Degrees(+61.28223708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20713"},
        {"Hipparcos Number", "HIP 15778"},
        {"Geneva Identification System", "GEN# +1.00020713"},
        {"Smithsonian Astrophysical Observation", "SAO 12733"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.83107879),
        dec: Angle.Degrees(+61.28622326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193873"},
        {"Hipparcos Number", "HIP 100190"},
        {"Smithsonian Astrophysical Observation", "SAO 18805"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.83275742),
        dec: Angle.Degrees(+61.28843817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96478",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96478"},
        {"Smithsonian Astrophysical Observation", "SAO 18435"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.21085729),
        dec: Angle.Degrees(+61.28872188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18352"},
        {"Hipparcos Number", "HIP 13959"},
        {"Geneva Identification System", "GEN# +1.00018352"},
        {"Smithsonian Astrophysical Observation", "SAO 12554"},
        {"Wilson Evans Batten Catalogue", "WEB 2754"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.94738166),
        dec: Angle.Degrees(+61.28994463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18737",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18737"},
        {"Smithsonian Astrophysical Observation", "SAO 12985"},
    },
    visualMagnitude: 9.65,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.20653884),
        dec: Angle.Degrees(+61.29075797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89580",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89580"},
        {"Smithsonian Astrophysical Observation", "SAO 17844"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.20098012),
        dec: Angle.Degrees(+61.29218673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108372",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15499 AB"},
        {"Henry Draper", "HD 208905"},
        {"Hipparcos Number", "HIP 108372"},
        {"Celescope Catalog", "CEL 5411"},
        {"Geneva Identification System", "GEN# +1.00208905J"},
        {"Smithsonian Astrophysical Observation", "SAO 19758"},
        {"Wilson Evans Batten Catalogue", "WEB 19520"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.32361635),
        dec: Angle.Degrees(+61.29531779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194932"},
        {"Hipparcos Number", "HIP 100705"},
        {"Smithsonian Astrophysical Observation", "SAO 18853"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.25684767),
        dec: Angle.Degrees(+61.29818848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125074"},
        {"Hipparcos Number", "HIP 69627"},
        {"Geneva Identification System", "GEN# +1.00125074"},
        {"Smithsonian Astrophysical Observation", "SAO 16316"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.75699787),
        dec: Angle.Degrees(+61.30112969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116703",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116703"},
        {"Smithsonian Astrophysical Observation", "SAO 20749"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.75269559),
        dec: Angle.Degrees(+61.30164831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179039"},
        {"Hipparcos Number", "HIP 93880"},
        {"Geneva Identification System", "GEN# +1.00179039"},
        {"Smithsonian Astrophysical Observation", "SAO 18155"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.77870888),
        dec: Angle.Degrees(+61.30219173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51832"},
        {"Hipparcos Number", "HIP 33966"},
        {"Geneva Identification System", "GEN# +1.00051832"},
        {"Smithsonian Astrophysical Observation", "SAO 14056"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.71375283),
        dec: Angle.Degrees(+61.30778086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107397"},
        {"Hipparcos Number", "HIP 60180"},
        {"Geneva Identification System", "GEN# +1.00107397"},
        {"Smithsonian Astrophysical Observation", "SAO 15775"},
        {"Wilson Evans Batten Catalogue", "WEB 10701"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.11397034),
        dec: Angle.Degrees(+61.30965826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112737",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16300 AB"},
        {"Hipparcos Number", "HIP 112737"},
        {"Geneva Identification System", "GEN# +0.06002444J"},
        {"Smithsonian Astrophysical Observation", "SAO 20269"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.47570779),
        dec: Angle.Degrees(+61.30992545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188481"},
        {"Hipparcos Number", "HIP 97751"},
        {"Smithsonian Astrophysical Observation", "SAO 18567"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.96648088),
        dec: Angle.Degrees(+61.31124635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26890",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26890"},
        {"Smithsonian Astrophysical Observation", "SAO 13572"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.63177297),
        dec: Angle.Degrees(+61.31272675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 290.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225289"},
        {"Hipparcos Number", "HIP 418"},
        {"Celescope Catalog", "CEL 12"},
        {"Geneva Identification System", "GEN# +1.00225289"},
        {"Renson", "Renson 61790"},
        {"Smithsonian Astrophysical Observation", "SAO 10962"},
        {"Wilson Evans Batten Catalogue", "WEB 66"},
    },
    visualMagnitude: 5.80,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.27555231),
        dec: Angle.Degrees(+61.31396468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22370"},
        {"Hipparcos Number", "HIP 17055"},
        {"Smithsonian Astrophysical Observation", "SAO 12848"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.85384783),
        dec: Angle.Degrees(+61.32308307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8769"},
        {"Hipparcos Number", "HIP 6841"},
        {"Geneva Identification System", "GEN# +1.00008769"},
        {"Smithsonian Astrophysical Observation", "SAO 11772"},
        {"Wilson Evans Batten Catalogue", "WEB 1491"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.00497548),
        dec: Angle.Degrees(+61.32501000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7416",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7416"},
    },
    visualMagnitude: 11.31,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.89880554),
        dec: Angle.Degrees(+61.32788352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104087"},
        {"Hipparcos Number", "HIP 58458"},
        {"Smithsonian Astrophysical Observation", "SAO 15676"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.81344841),
        dec: Angle.Degrees(+61.33441668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161014"},
        {"Hipparcos Number", "HIP 86380"},
        {"Smithsonian Astrophysical Observation", "SAO 17586"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.76868736),
        dec: Angle.Degrees(+61.33666795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142193"},
        {"Hipparcos Number", "HIP 77535"},
        {"Smithsonian Astrophysical Observation", "SAO 16864"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.46864510),
        dec: Angle.Degrees(+61.33823766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24443",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24443"},
        {"Smithsonian Astrophysical Observation", "SAO 13424"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.65612298),
        dec: Angle.Degrees(+61.34329766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78658",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9916 AB"},
        {"Henry Draper", "HD 144653"},
        {"Hipparcos Number", "HIP 78658"},
        {"Smithsonian Astrophysical Observation", "SAO 16939"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.86822221),
        dec: Angle.Degrees(+61.34345964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192178"},
        {"Hipparcos Number", "HIP 99381"},
        {"Smithsonian Astrophysical Observation", "SAO 18742"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.56693252),
        dec: Angle.Degrees(+61.34583082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45840",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7300 AB"},
        {"Henry Draper", "HD 80142"},
        {"Hipparcos Number", "HIP 45840"},
        {"Smithsonian Astrophysical Observation", "SAO 14851"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.19176947),
        dec: Angle.Degrees(+61.34956603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45443"},
        {"Hipparcos Number", "HIP 31095"},
        {"Geneva Identification System", "GEN# +1.00045443"},
        {"Smithsonian Astrophysical Observation", "SAO 13866"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.87989184),
        dec: Angle.Degrees(+61.35002102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39016",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39016"},
        {"Smithsonian Astrophysical Observation", "SAO 14392"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.76025068),
        dec: Angle.Degrees(+61.35120755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10677",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1737 AB"},
        {"Aitken 2", "ADS 1737"},
        {"Henry Draper", "HD 13864"},
        {"Hipparcos Number", "HIP 10677"},
        {"Geneva Identification System", "GEN# +1.00013864"},
        {"Smithsonian Astrophysical Observation", "SAO 12207"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.34582606),
        dec: Angle.Degrees(+61.35179594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102840"},
        {"Hipparcos Number", "HIP 57751"},
        {"Smithsonian Astrophysical Observation", "SAO 15641"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.66285010),
        dec: Angle.Degrees(+61.35546841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42656",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42656"},
        {"Smithsonian Astrophysical Observation", "SAO 14625"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.40068755),
        dec: Angle.Degrees(+61.35648122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38375"},
        {"Hipparcos Number", "HIP 27498"},
        {"Smithsonian Astrophysical Observation", "SAO 13622"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.34138403),
        dec: Angle.Degrees(+61.35858875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95490",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95490"},
        {"Geneva Identification System", "GEN# +0.06101860"},
        {"Smithsonian Astrophysical Observation", "SAO 18334"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.35119420),
        dec: Angle.Degrees(+61.35934204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2930",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2930"},
        {"Geneva Identification System", "GEN# +0.06000073"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.29015620),
        dec: Angle.Degrees(+61.36013872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103454",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14495 AB"},
        {"Henry Draper", "HD 199967"},
        {"Hipparcos Number", "HIP 103454"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.41547131),
        dec: Angle.Degrees(+61.36018972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28828"},
        {"Hipparcos Number", "HIP 21447"},
        {"Smithsonian Astrophysical Observation", "SAO 13199"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.08631903),
        dec: Angle.Degrees(+61.36234181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37903",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37903"},
        {"Smithsonian Astrophysical Observation", "SAO 14316"},
    },
    visualMagnitude: 9.96,
    bvColour: -0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.51058965),
        dec: Angle.Degrees(+61.36308206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23819"},
        {"Hipparcos Number", "HIP 18057"},
        {"Fundamental Katalog 5th Edition", "FK5 4349"},
        {"Geneva Identification System", "GEN# +1.00023819"},
        {"Smithsonian Astrophysical Observation", "SAO 12932"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.88616810),
        dec: Angle.Degrees(+61.36463424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196903"},
        {"Hipparcos Number", "HIP 101719"},
        {"Geneva Identification System", "GEN# +1.00196903"},
        {"Smithsonian Astrophysical Observation", "SAO 18948"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.28293549),
        dec: Angle.Degrees(+61.36469163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69601",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69601"},
        {"Geneva Identification System", "GEN# +0.06201340"},
        {"Smithsonian Astrophysical Observation", "SAO 16315"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.68582960),
        dec: Angle.Degrees(+61.36589023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -182.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221900"},
        {"Hipparcos Number", "HIP 116432"},
        {"Geneva Identification System", "GEN# +1.00221900"},
        {"Smithsonian Astrophysical Observation", "SAO 20717"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.90136220),
        dec: Angle.Degrees(+61.36847229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147291"},
        {"Hipparcos Number", "HIP 79823"},
        {"Geneva Identification System", "GEN# +1.00147291"},
        {"Smithsonian Astrophysical Observation", "SAO 17030"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.38059360),
        dec: Angle.Degrees(+61.36872519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136749"},
        {"Hipparcos Number", "HIP 74976"},
        {"Geneva Identification System", "GEN# +1.00136749"},
        {"Smithsonian Astrophysical Observation", "SAO 16685"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.82820545),
        dec: Angle.Degrees(+61.37499637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9154"},
        {"Hipparcos Number", "HIP 7127"},
        {"Smithsonian Astrophysical Observation", "SAO 11800"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.95760697),
        dec: Angle.Degrees(+61.37719865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111513"},
        {"Hipparcos Number", "HIP 62527"},
        {"Cincinnati Publication", "Ci 20 739"},
        {"Geneva Identification System", "GEN# +1.00111513"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.20751772),
        dec: Angle.Degrees(+61.37814013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -554.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 100.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15570"},
        {"Hipparcos Number", "HIP 11837"},
        {"Geneva Identification System", "GEN# +3.18050160"},
        {"Smithsonian Astrophysical Observation", "SAO 12327"},
        {"Wilson Evans Batten Catalogue", "WEB 2451"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.20592381),
        dec: Angle.Degrees(+61.37836045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126469"},
        {"Hipparcos Number", "HIP 70333"},
        {"Geneva Identification System", "GEN# +1.00126469"},
        {"Smithsonian Astrophysical Observation", "SAO 16362"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.85172316),
        dec: Angle.Degrees(+61.38206353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55623",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55623"},
        {"Smithsonian Astrophysical Observation", "SAO 15492"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.93065981),
        dec: Angle.Degrees(+61.38244534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40738"},
        {"Hipparcos Number", "HIP 28822"},
        {"Smithsonian Astrophysical Observation", "SAO 13698"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.26217963),
        dec: Angle.Degrees(+61.39152779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164135"},
        {"Hipparcos Number", "HIP 87766"},
        {"Smithsonian Astrophysical Observation", "SAO 17687"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.92918720),
        dec: Angle.Degrees(+61.39588977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89650"},
        {"Hipparcos Number", "HIP 50810"},
        {"Smithsonian Astrophysical Observation", "SAO 15155"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.60280089),
        dec: Angle.Degrees(+61.39895057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116155"},
        {"Hipparcos Number", "HIP 65095"},
        {"Smithsonian Astrophysical Observation", "SAO 16051"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.12329637),
        dec: Angle.Degrees(+61.39931037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102355"},
        {"Hipparcos Number", "HIP 57498"},
        {"Fundamental Katalog 5th Edition", "FK5 1303"},
        {"Geneva Identification System", "GEN# +1.00102355"},
        {"Smithsonian Astrophysical Observation", "SAO 15631"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.78268236),
        dec: Angle.Degrees(+61.40195962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104782"},
        {"Hipparcos Number", "HIP 58828"},
        {"Smithsonian Astrophysical Observation", "SAO 15699"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.99476517),
        dec: Angle.Degrees(+61.40359586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36555"},
        {"Hipparcos Number", "HIP 26350"},
        {"Geneva Identification System", "GEN# +1.00036555"},
        {"Smithsonian Astrophysical Observation", "SAO 13547"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.16358219),
        dec: Angle.Degrees(+61.40702074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187793"},
        {"Hipparcos Number", "HIP 97432"},
        {"Smithsonian Astrophysical Observation", "SAO 18538"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.03760410),
        dec: Angle.Degrees(+61.41126735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118066",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118066"},
        {"Geneva Identification System", "GEN# +2.77880071"},
        {"New General Catalogue", "NGC 7788 71"},
    },
    visualMagnitude: 10.96,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.25734530),
        dec: Angle.Degrees(+61.41869551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87418",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87418"},
        {"Smithsonian Astrophysical Observation", "SAO 17660"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.96936588),
        dec: Angle.Degrees(+61.41898556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140023"},
        {"Hipparcos Number", "HIP 76556"},
        {"Geneva Identification System", "GEN# +1.00140023"},
        {"Smithsonian Astrophysical Observation", "SAO 16791"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.52453137),
        dec: Angle.Degrees(+61.42034933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -154.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10362"},
        {"Hipparcos Number", "HIP 8020"},
        {"Celescope Catalog", "CEL 159"},
        {"Geneva Identification System", "GEN# +1.00010362"},
        {"Smithsonian Astrophysical Observation", "SAO 11931"},
        {"Wilson Evans Batten Catalogue", "WEB 1717"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.74298829),
        dec: Angle.Degrees(+61.42109575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5459"},
        {"Hipparcos Number", "HIP 4475"},
        {"Geneva Identification System", "GEN# +1.00005459"},
        {"Smithsonian Astrophysical Observation", "SAO 11491"},
        {"Wilson Evans Batten Catalogue", "WEB 809"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.33138601),
        dec: Angle.Degrees(+61.42193312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8312",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8312"},
        {"Geneva Identification System", "GEN# +0.06000348"},
        {"Wilson Evans Batten Catalogue", "WEB 1772"},
    },
    visualMagnitude: 10.43,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.79965951),
        dec: Angle.Degrees(+61.42249364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177274"},
        {"Hipparcos Number", "HIP 93297"},
        {"Geneva Identification System", "GEN# +1.00177274"},
        {"Smithsonian Astrophysical Observation", "SAO 18108"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.05192489),
        dec: Angle.Degrees(+61.42314487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79028"},
        {"Hipparcos Number", "HIP 45333"},
        {"Fundamental Katalog 5th Edition", "FK5 2730"},
        {"Geneva Identification System", "GEN# +1.00079028"},
        {"Smithsonian Astrophysical Observation", "SAO 14819"},
        {"Wilson Evans Batten Catalogue", "WEB 8633"},
    },
    visualMagnitude: 5.18,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.58562984),
        dec: Angle.Degrees(+61.42339501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13553",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13553"},
        {"Smithsonian Astrophysical Observation", "SAO 12503"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.64252819),
        dec: Angle.Degrees(+61.42517489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221143"},
        {"Hipparcos Number", "HIP 115905"},
        {"Geneva Identification System", "GEN# +2.76541673"},
        {"Smithsonian Astrophysical Observation", "SAO 20654"},
        {"New General Catalogue", "NGC 7654 1673"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.25045210),
        dec: Angle.Degrees(+61.42881315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94746"},
        {"Hipparcos Number", "HIP 53558"},
        {"Smithsonian Astrophysical Observation", "SAO 15344"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.34180893),
        dec: Angle.Degrees(+61.43038747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169385"},
        {"Hipparcos Number", "HIP 89860"},
        {"Smithsonian Astrophysical Observation", "SAO 17856"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.07225921),
        dec: Angle.Degrees(+61.43155760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204889"},
        {"Hipparcos Number", "HIP 106066"},
        {"Fundamental Katalog 5th Edition", "FK5 5892"},
        {"Geneva Identification System", "GEN# +1.00204889"},
        {"Smithsonian Astrophysical Observation", "SAO 19447"},
        {"Wilson Evans Batten Catalogue", "WEB 19225"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.26257103),
        dec: Angle.Degrees(+61.43310903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220770"},
        {"Hipparcos Number", "HIP 115661"},
        {"Geneva Identification System", "GEN# +2.76541176"},
        {"Smithsonian Astrophysical Observation", "SAO 20625"},
        {"New General Catalogue", "NGC 7654 1176"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.46045316),
        dec: Angle.Degrees(+61.43480210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80235",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10058 C"},
        {"Henry Draper", "HD 148204"},
        {"Hipparcos Number", "HIP 80235"},
        {"Smithsonian Astrophysical Observation", "SAO 17065"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.71270583),
        dec: Angle.Degrees(+61.43549707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63278",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63278"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.50436741),
        dec: Angle.Degrees(+61.43560603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -288.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221741"},
        {"Hipparcos Number", "HIP 116330"},
        {"Celescope Catalog", "CEL 5632"},
        {"Geneva Identification System", "GEN# +1.00221741"},
        {"Smithsonian Astrophysical Observation", "SAO 20709"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.58087796),
        dec: Angle.Degrees(+61.43738711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128127"},
        {"Hipparcos Number", "HIP 71117"},
        {"Geneva Identification System", "GEN# +1.00128127"},
        {"Smithsonian Astrophysical Observation", "SAO 16424"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.13862309),
        dec: Angle.Degrees(+61.43797314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -225.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 115.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2430",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2430"},
        {"Smithsonian Astrophysical Observation", "SAO 11238"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.74805059),
        dec: Angle.Degrees(+61.43865366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11856",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11856"},
        {"Geneva Identification System", "GEN# +3.18050170"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.25481372),
        dec: Angle.Degrees(+61.43930220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114092",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16514 AB"},
        {"Henry Draper", "HD 218375"},
        {"Hipparcos Number", "HIP 114092"},
        {"Smithsonian Astrophysical Observation", "SAO 20424"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.61889781),
        dec: Angle.Degrees(+61.44017439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142007"},
        {"Hipparcos Number", "HIP 77445"},
        {"Smithsonian Astrophysical Observation", "SAO 16857"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.16908094),
        dec: Angle.Degrees(+61.44182268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47688",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47688"},
        {"Smithsonian Astrophysical Observation", "SAO 14974"},
    },
    visualMagnitude: 9.91,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.85239270),
        dec: Angle.Degrees(+61.44511320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30519",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30519"},
        {"Smithsonian Astrophysical Observation", "SAO 13829"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.22002720),
        dec: Angle.Degrees(+61.44727944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90828",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90828"},
        {"Smithsonian Astrophysical Observation", "SAO 17917"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.93578421),
        dec: Angle.Degrees(+61.45001380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92890",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92890"},
        {"Smithsonian Astrophysical Observation", "SAO 18071"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.89400795),
        dec: Angle.Degrees(+61.45181353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57178"},
        {"Hipparcos Number", "HIP 35892"},
        {"Smithsonian Astrophysical Observation", "SAO 14178"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.99070913),
        dec: Angle.Degrees(+61.45315134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213269"},
        {"Hipparcos Number", "HIP 110940"},
        {"Smithsonian Astrophysical Observation", "SAO 20091"},
        {"Wilson Evans Batten Catalogue", "WEB 19862"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.17185155),
        dec: Angle.Degrees(+61.45549881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11832",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1920"},
        {"Aitken 2", "ADS 1920 A"},
        {"Henry Draper", "HD 15558"},
        {"Hipparcos Number", "HIP 11832"},
        {"Celescope Catalog", "CEL 284"},
        {"Geneva Identification System", "GEN# +3.18050148"},
        {"Smithsonian Astrophysical Observation", "SAO 12326"},
        {"Wilson Evans Batten Catalogue", "WEB 2450"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.17724426),
        dec: Angle.Degrees(+61.45599509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3191"},
        {"Hipparcos Number", "HIP 2816"},
        {"Geneva Identification System", "GEN# +1.00003191"},
        {"Smithsonian Astrophysical Observation", "SAO 11281"},
        {"Wilson Evans Batten Catalogue", "WEB 505"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.96185500),
        dec: Angle.Degrees(+61.45981134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70050"},
        {"Hipparcos Number", "HIP 41106"},
        {"Geneva Identification System", "GEN# +1.00070050"},
        {"Smithsonian Astrophysical Observation", "SAO 14527"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.81753448),
        dec: Angle.Degrees(+61.46044484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40687",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Nasti"},
        {"Henry Draper", "HD 68988"},
        {"Hipparcos Number", "HIP 40687"},
        {"Geneva Identification System", "GEN# +1.00068988"},
        {"Smithsonian Astrophysical Observation", "SAO 14494"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.59173488),
        dec: Angle.Degrees(+61.46064485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221406"},
        {"Hipparcos Number", "HIP 116090"},
        {"Geneva Identification System", "GEN# +2.76541934"},
        {"Smithsonian Astrophysical Observation", "SAO 20679"},
        {"New General Catalogue", "NGC 7654 1934"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.85115353),
        dec: Angle.Degrees(+61.46197946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23013"},
        {"Hipparcos Number", "HIP 17513"},
        {"Smithsonian Astrophysical Observation", "SAO 12888"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.24569183),
        dec: Angle.Degrees(+61.46373888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103953"},
        {"Hipparcos Number", "HIP 58389"},
        {"Geneva Identification System", "GEN# +1.00103953"},
        {"Smithsonian Astrophysical Observation", "SAO 15673"},
        {"Wilson Evans Batten Catalogue", "WEB 10435"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.58534644),
        dec: Angle.Degrees(+61.46457143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12817",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12817"},
    },
    visualMagnitude: 10.84,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.18048210),
        dec: Angle.Degrees(+61.46470047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61185",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61185"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.05376172),
        dec: Angle.Degrees(+61.46505433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41980"},
        {"Hipparcos Number", "HIP 29456"},
        {"Smithsonian Astrophysical Observation", "SAO 13754"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.09370416),
        dec: Angle.Degrees(+61.46805590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -185.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107548"},
        {"Hipparcos Number", "HIP 60269"},
        {"Smithsonian Astrophysical Observation", "SAO 15777"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.36901100),
        dec: Angle.Degrees(+61.46868672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5391",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5391"},
        {"Geneva Identification System", "GEN# +0.06000169"},
        {"Wilson Evans Batten Catalogue", "WEB 1174"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.25041722),
        dec: Angle.Degrees(+61.47079468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107724"},
        {"Hipparcos Number", "HIP 60340"},
        {"Geneva Identification System", "GEN# +1.00107724"},
        {"Smithsonian Astrophysical Observation", "SAO 15784"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.58481488),
        dec: Angle.Degrees(+61.47170836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192139"},
        {"Hipparcos Number", "HIP 99355"},
        {"Smithsonian Astrophysical Observation", "SAO 18740"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.49859873),
        dec: Angle.Degrees(+61.47371449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -139.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 192.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153648"},
        {"Hipparcos Number", "HIP 82927"},
        {"Smithsonian Astrophysical Observation", "SAO 17286"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.20298854),
        dec: Angle.Degrees(+61.47510052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9583"},
        {"Hipparcos Number", "HIP 7418"},
        {"Smithsonian Astrophysical Observation", "SAO 11849"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.90182324),
        dec: Angle.Degrees(+61.47649773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37638"},
        {"Hipparcos Number", "HIP 27046"},
        {"Geneva Identification System", "GEN# +1.00037638"},
        {"Smithsonian Astrophysical Observation", "SAO 13590"},
        {"Wilson Evans Batten Catalogue", "WEB 5322"},
    },
    visualMagnitude: 6.17,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.03525136),
        dec: Angle.Degrees(+61.47653312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46635"},
        {"Hipparcos Number", "HIP 31763"},
        {"Smithsonian Astrophysical Observation", "SAO 13910"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.65158133),
        dec: Angle.Degrees(+61.47778044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114107",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114107"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.65446867),
        dec: Angle.Degrees(+61.47853361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194758"},
        {"Hipparcos Number", "HIP 100615"},
        {"Smithsonian Astrophysical Observation", "SAO 18847"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.03608559),
        dec: Angle.Degrees(+61.47955883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30685"},
        {"Hipparcos Number", "HIP 22754"},
        {"Fundamental Katalog 5th Edition", "FK5 4450"},
        {"Geneva Identification System", "GEN# +1.00030685"},
        {"Renson", "Renson 7945"},
        {"Smithsonian Astrophysical Observation", "SAO 13300"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.41546039),
        dec: Angle.Degrees(+61.48182786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46480"},
        {"Hipparcos Number", "HIP 31676"},
        {"Fundamental Katalog 5th Edition", "FK5 247"},
        {"Geneva Identification System", "GEN# +1.00046480"},
        {"Smithsonian Astrophysical Observation", "SAO 13897"},
        {"Wilson Evans Batten Catalogue", "WEB 6348"},
    },
    visualMagnitude: 5.94,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.42350092),
        dec: Angle.Degrees(+61.48190031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -208.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -274.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120787"},
        {"Hipparcos Number", "HIP 67485"},
        {"Fundamental Katalog 5th Edition", "FK5 3101"},
        {"Geneva Identification System", "GEN# +1.00120787"},
        {"Smithsonian Astrophysical Observation", "SAO 16186"},
        {"Wilson Evans Batten Catalogue", "WEB 11868"},
    },
    visualMagnitude: 5.97,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.43928514),
        dec: Angle.Degrees(+61.48954562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222647"},
        {"Hipparcos Number", "HIP 116944"},
        {"Celescope Catalog", "CEL 5652"},
        {"Geneva Identification System", "GEN# +1.00222647"},
        {"Smithsonian Astrophysical Observation", "SAO 20790"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.57000897),
        dec: Angle.Degrees(+61.49110453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122064"},
        {"Hipparcos Number", "HIP 68184"},
        {"Smithsonian Astrophysical Observation", "SAO 16230"},
        {"Wilson Evans Batten Catalogue", "WEB 11960"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.38373744),
        dec: Angle.Degrees(+61.49233530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 216.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103669",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14544 A"},
        {"Aitken 2", "ADS 14544"},
        {"Henry Draper", "HD 200386"},
        {"Hipparcos Number", "HIP 103669"},
        {"Smithsonian Astrophysical Observation", "SAO 19147"},
        {"Wilson Evans Batten Catalogue", "WEB 18867"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.07237642),
        dec: Angle.Degrees(+61.49736813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30165"},
        {"Hipparcos Number", "HIP 22383"},
        {"Smithsonian Astrophysical Observation", "SAO 13277"},
        {"Wilson Evans Batten Catalogue", "WEB 4313"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.27393161),
        dec: Angle.Degrees(+61.50743949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42902",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42902"},
        {"Geneva Identification System", "GEN# +0.06201013"},
        {"Smithsonian Astrophysical Observation", "SAO 14647"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.15014090),
        dec: Angle.Degrees(+61.50880891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56693",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56693"},
        {"Smithsonian Astrophysical Observation", "SAO 15572"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.36978868),
        dec: Angle.Degrees(+61.51001409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32731"},
        {"Hipparcos Number", "HIP 23982"},
        {"Geneva Identification System", "GEN# +1.00032731"},
        {"Smithsonian Astrophysical Observation", "SAO 13386"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.32269158),
        dec: Angle.Degrees(+61.51101348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215485"},
        {"Hipparcos Number", "HIP 112248"},
        {"Smithsonian Astrophysical Observation", "SAO 20221"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.03296253),
        dec: Angle.Degrees(+61.51183851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 796",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 796"},
    },
    visualMagnitude: 11.18,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.46414999),
        dec: Angle.Degrees(+61.51404444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80331",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Athebyne"},
        {"Aitken", "ADS 10058 A"},
        {"Henry Draper", "HD 148387"},
        {"Hipparcos Number", "HIP 80331"},
        {"Geneva Identification System", "GEN# +1.00148387J"},
        {"Smithsonian Astrophysical Observation", "SAO 17074"},
        {"Wilson Evans Batten Catalogue", "WEB 13593"},
    },
    visualMagnitude: 2.73,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.99794523),
        dec: Angle.Degrees(+61.51407536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42973"},
        {"Hipparcos Number", "HIP 29919"},
        {"Fundamental Katalog 5th Edition", "FK5 2479"},
        {"Geneva Identification System", "GEN# +1.00042973"},
        {"Smithsonian Astrophysical Observation", "SAO 13787"},
        {"Wilson Evans Batten Catalogue", "WEB 5925"},
    },
    visualMagnitude: 5.01,
    bvColour: 1.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.47846658),
        dec: Angle.Degrees(+61.51529221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115131",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16677 AB"},
        {"Hipparcos Number", "HIP 115131"},
        {"Geneva Identification System", "GEN# +2.76540133"},
        {"Smithsonian Astrophysical Observation", "SAO 20557"},
        {"New General Catalogue", "NGC 7654 133"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.80211572),
        dec: Angle.Degrees(+61.51756689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14864",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14864"},
        {"Geneva Identification System", "GEN# +0.06000637"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.98681273),
        dec: Angle.Degrees(+61.52000029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 119.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44399",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44399"},
        {"Smithsonian Astrophysical Observation", "SAO 14744"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.66549809),
        dec: Angle.Degrees(+61.52063287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17948"},
        {"Hipparcos Number", "HIP 13665"},
        {"Fundamental Katalog 5th Edition", "FK5 2201"},
        {"Geneva Identification System", "GEN# +1.00017948"},
        {"Smithsonian Astrophysical Observation", "SAO 12517"},
        {"Wilson Evans Batten Catalogue", "WEB 2711"},
    },
    visualMagnitude: 5.59,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.98642959),
        dec: Angle.Degrees(+61.52106281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 145.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15629"},
        {"Hipparcos Number", "HIP 11891"},
        {"Geneva Identification System", "GEN# +3.18050192"},
        {"Smithsonian Astrophysical Observation", "SAO 12330"},
        {"Wilson Evans Batten Catalogue", "WEB 2457"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.33578505),
        dec: Angle.Degrees(+61.52172056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32879",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32879"},
    },
    visualMagnitude: 10.56,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.77109917),
        dec: Angle.Degrees(+61.52519640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46968",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46968"},
        {"Smithsonian Astrophysical Observation", "SAO 14925"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.59487506),
        dec: Angle.Degrees(+61.52662842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22553",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22553"},
        {"Smithsonian Astrophysical Observation", "SAO 13287"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.80543260),
        dec: Angle.Degrees(+61.52675296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143061"},
        {"Hipparcos Number", "HIP 77915"},
        {"Smithsonian Astrophysical Observation", "SAO 16892"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.68163077),
        dec: Angle.Degrees(+61.52779734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1354",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 222 A"},
        {"Henry Draper", "HD 1239"},
        {"Hipparcos Number", "HIP 1354"},
        {"Geneva Identification System", "GEN# +1.00001239A"},
        {"Smithsonian Astrophysical Observation", "SAO 11084"},
        {"Wilson Evans Batten Catalogue", "WEB 245"},
    },
    visualMagnitude: 5.74,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.23771177),
        dec: Angle.Degrees(+61.53319397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60406"},
        {"Hipparcos Number", "HIP 37150"},
        {"Fundamental Katalog 5th Edition", "FK5 4686"},
        {"Geneva Identification System", "GEN# +1.00060406"},
        {"Smithsonian Astrophysical Observation", "SAO 14263"},
        {"Wilson Evans Batten Catalogue", "WEB 7363"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.51966109),
        dec: Angle.Degrees(+61.53330472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2084",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2084"},
        {"Smithsonian Astrophysical Observation", "SAO 11189"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.57804301),
        dec: Angle.Degrees(+61.53424037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15853",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2501 A"},
        {"Henry Draper", "HD 20798"},
        {"Hipparcos Number", "HIP 15853"},
        {"Geneva Identification System", "GEN# +1.00020798J"},
        {"Smithsonian Astrophysical Observation", "SAO 12741"},
        {"Wilson Evans Batten Catalogue", "WEB 3024"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.05910227),
        dec: Angle.Degrees(+61.53857928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85950",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85950"},
        {"Smithsonian Astrophysical Observation", "SAO 17535"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.49493967),
        dec: Angle.Degrees(+61.54123370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208606"},
        {"Hipparcos Number", "HIP 108209"},
        {"Geneva Identification System", "GEN# +1.00208606"},
        {"Smithsonian Astrophysical Observation", "SAO 19738"},
        {"Wilson Evans Batten Catalogue", "WEB 19503"},
    },
    visualMagnitude: 6.17,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.83582745),
        dec: Angle.Degrees(+61.54181712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11918"},
        {"Hipparcos Number", "HIP 9267"},
        {"Geneva Identification System", "GEN# +1.00011918"},
        {"Smithsonian Astrophysical Observation", "SAO 12072"},
        {"Wilson Evans Batten Catalogue", "WEB 1945"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.77458983),
        dec: Angle.Degrees(+61.54194114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30945",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30945"},
        {"Wilson Evans Batten Catalogue", "WEB 6164"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.42061183),
        dec: Angle.Degrees(+61.54261777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34284",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34284"},
    },
    visualMagnitude: 10.54,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.62024734),
        dec: Angle.Degrees(+61.54342673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173511"},
        {"Hipparcos Number", "HIP 91673"},
        {"Smithsonian Astrophysical Observation", "SAO 17977"},
        {"Wilson Evans Batten Catalogue", "WEB 15767"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.41921530),
        dec: Angle.Degrees(+61.54626934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6755"},
        {"Hipparcos Number", "HIP 5445"},
        {"Cincinnati Publication", "Ci 20 84"},
        {"Cincinnati Publication 2", "Ci 18 149"},
        {"Fundamental Katalog 5th Edition", "FK5 4106"},
        {"Geneva Identification System", "GEN# +1.00006755"},
        {"Smithsonian Astrophysical Observation", "SAO 11602"},
        {"Wilson Evans Batten Catalogue", "WEB 1187"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.42622961),
        dec: Angle.Degrees(+61.54708884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 627.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103736"},
        {"Hipparcos Number", "HIP 58259"},
        {"Geneva Identification System", "GEN# +1.00103736"},
        {"Smithsonian Astrophysical Observation", "SAO 15666"},
        {"Wilson Evans Batten Catalogue", "WEB 10425"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.22197144),
        dec: Angle.Degrees(+61.54931890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11318",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1833 AB"},
        {"Henry Draper", "HD 14817"},
        {"Hipparcos Number", "HIP 11318"},
        {"Celescope Catalog", "CEL 273"},
        {"Geneva Identification System", "GEN# +1.00014817"},
        {"Smithsonian Astrophysical Observation", "SAO 12277"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.41705841),
        dec: Angle.Degrees(+61.54967769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11792",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11792"},
        {"Geneva Identification System", "GEN# +3.18050112"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.04522863),
        dec: Angle.Degrees(+61.55220930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11807",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11807"},
        {"Geneva Identification System", "GEN# +3.18050118"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.06980358),
        dec: Angle.Degrees(+61.55416658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209454"},
        {"Hipparcos Number", "HIP 108720"},
        {"Celescope Catalog", "CEL 5419"},
        {"Geneva Identification System", "GEN# +1.00209454"},
        {"Smithsonian Astrophysical Observation", "SAO 19802"},
        {"Wilson Evans Batten Catalogue", "WEB 19564"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.35715241),
        dec: Angle.Degrees(+61.55610952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206327"},
        {"Hipparcos Number", "HIP 106896"},
        {"Celescope Catalog", "CEL 5361"},
        {"Geneva Identification System", "GEN# +1.00206327"},
        {"Smithsonian Astrophysical Observation", "SAO 19553"},
        {"Wilson Evans Batten Catalogue", "WEB 19319"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.75434432),
        dec: Angle.Degrees(+61.55615525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103394",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14478 AB"},
        {"Henry Draper", "HD 199849"},
        {"Hipparcos Number", "HIP 103394"},
        {"Smithsonian Astrophysical Observation", "SAO 19115"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.21098321),
        dec: Angle.Degrees(+61.56077180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130835"},
        {"Hipparcos Number", "HIP 72349"},
        {"Smithsonian Astrophysical Observation", "SAO 16499"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.91816254),
        dec: Angle.Degrees(+61.56270861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181181"},
        {"Hipparcos Number", "HIP 94649"},
        {"Smithsonian Astrophysical Observation", "SAO 18241"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.89032531),
        dec: Angle.Degrees(+61.56517879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5429"},
        {"Hipparcos Number", "HIP 4456"},
        {"Geneva Identification System", "GEN# +1.00005429"},
        {"Smithsonian Astrophysical Observation", "SAO 11488"},
        {"Wilson Evans Batten Catalogue", "WEB 803"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.27611922),
        dec: Angle.Degrees(+61.56687331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165862"},
        {"Hipparcos Number", "HIP 88483"},
        {"Geneva Identification System", "GEN# +1.00165862"},
        {"Smithsonian Astrophysical Observation", "SAO 17741"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.01101816),
        dec: Angle.Degrees(+61.56790109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40314",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40314"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.47600650),
        dec: Angle.Degrees(+61.56800980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105843",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105843"},
        {"Smithsonian Astrophysical Observation", "SAO 19406"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.56886720),
        dec: Angle.Degrees(+61.57091988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212169"},
        {"Hipparcos Number", "HIP 110304"},
        {"Geneva Identification System", "GEN# +1.00212169"},
        {"Smithsonian Astrophysical Observation", "SAO 20016"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.12596033),
        dec: Angle.Degrees(+61.57770589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6210"},
        {"Hipparcos Number", "HIP 5021"},
        {"Geneva Identification System", "GEN# +1.00006210"},
        {"Smithsonian Astrophysical Observation", "SAO 11557"},
        {"Wilson Evans Batten Catalogue", "WEB 1023"},
    },
    visualMagnitude: 5.83,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.08145357),
        dec: Angle.Degrees(+61.58024409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194556"},
        {"Hipparcos Number", "HIP 100527"},
        {"Smithsonian Astrophysical Observation", "SAO 18836"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.75692401),
        dec: Angle.Degrees(+61.58026730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20157",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3109"},
        {"Henry Draper", "HD 26936"},
        {"Hipparcos Number", "HIP 20157"},
        {"Smithsonian Astrophysical Observation", "SAO 13094"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.80739262),
        dec: Angle.Degrees(+61.58401258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4561"},
        {"Hipparcos Number", "HIP 3767"},
        {"Geneva Identification System", "GEN# +1.00004561"},
        {"Smithsonian Astrophysical Observation", "SAO 11401"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.09385659),
        dec: Angle.Degrees(+61.58453565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137528"},
        {"Hipparcos Number", "HIP 75327"},
        {"Smithsonian Astrophysical Observation", "SAO 16718"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.86427995),
        dec: Angle.Degrees(+61.58503089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43804",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43804"},
        {"Smithsonian Astrophysical Observation", "SAO 14698"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.82025082),
        dec: Angle.Degrees(+61.58793417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115542",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115542"},
        {"Geneva Identification System", "GEN# +2.76540766"},
        {"Smithsonian Astrophysical Observation", "SAO 20606"},
        {"New General Catalogue", "NGC 7654 766"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.06603130),
        dec: Angle.Degrees(+61.58821082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79887"},
        {"Hipparcos Number", "HIP 45732"},
        {"Smithsonian Astrophysical Observation", "SAO 14842"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.84746095),
        dec: Angle.Degrees(+61.58839822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107670"},
        {"Hipparcos Number", "HIP 60316"},
        {"Geneva Identification System", "GEN# +1.00107670"},
        {"Smithsonian Astrophysical Observation", "SAO 15783"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.51797876),
        dec: Angle.Degrees(+61.59140826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12695",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12695"},
        {"New General Catalogue", "NGC 1027 4"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.76963219),
        dec: Angle.Degrees(+61.59264406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16626"},
        {"Hipparcos Number", "HIP 12656"},
        {"Fundamental Katalog 5th Edition", "FK5 2186"},
        {"Geneva Identification System", "GEN# +2.10270001"},
        {"Smithsonian Astrophysical Observation", "SAO 12402"},
        {"New General Catalogue", "NGC 1027 1"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.64909601),
        dec: Angle.Degrees(+61.59368884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115521",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115521"},
        {"Geneva Identification System", "GEN# +2.76540735"},
        {"Geneva Identification System 2", "GEN# +7.30191798"},
        {"New General Catalogue", "NGC 7654 735"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.01371258),
        dec: Angle.Degrees(+61.59724548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179257"},
        {"Hipparcos Number", "HIP 93969"},
        {"Smithsonian Astrophysical Observation", "SAO 18164"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.00014695),
        dec: Angle.Degrees(+61.59812654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102367",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102367"},
        {"Smithsonian Astrophysical Observation", "SAO 19014"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.11289116),
        dec: Angle.Degrees(+61.60118997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37420"},
        {"Hipparcos Number", "HIP 26899"},
        {"Geneva Identification System", "GEN# +1.00037420"},
        {"Smithsonian Astrophysical Observation", "SAO 13574"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.66096821),
        dec: Angle.Degrees(+61.60309307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86560",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10735 B"},
        {"Hipparcos Number", "HIP 86560"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.33356199),
        dec: Angle.Degrees(+61.60516674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86554",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10735 A"},
        {"Henry Draper", "HD 161399"},
        {"Hipparcos Number", "HIP 86554"},
        {"Smithsonian Astrophysical Observation", "SAO 17603"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.32363267),
        dec: Angle.Degrees(+61.60569204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123101"},
        {"Hipparcos Number", "HIP 68690"},
        {"Smithsonian Astrophysical Observation", "SAO 16268"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.90638045),
        dec: Angle.Degrees(+61.60572548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86473"},
        {"Hipparcos Number", "HIP 49075"},
        {"Smithsonian Astrophysical Observation", "SAO 15045"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.24107644),
        dec: Angle.Degrees(+61.60622473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97017",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97017"},
        {"Smithsonian Astrophysical Observation", "SAO 18492"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.76816396),
        dec: Angle.Degrees(+61.60750634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102879",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102879"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.65473429),
        dec: Angle.Degrees(+61.60949918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216827"},
        {"Hipparcos Number", "HIP 113172"},
        {"Geneva Identification System", "GEN# +1.00216827"},
        {"Smithsonian Astrophysical Observation", "SAO 20319"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.75370653),
        dec: Angle.Degrees(+61.61539119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111112",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16011 AB"},
        {"Aitken 2", "ADS 16011"},
        {"Henry Draper", "HD 213530"},
        {"Hipparcos Number", "HIP 111112"},
        {"Smithsonian Astrophysical Observation", "SAO 20115"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.63595269),
        dec: Angle.Degrees(+61.62376899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145198"},
        {"Hipparcos Number", "HIP 78882"},
        {"Geneva Identification System", "GEN# +1.00145198"},
        {"Smithsonian Astrophysical Observation", "SAO 16956"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.54057249),
        dec: Angle.Degrees(+61.62544999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65601"},
        {"Hipparcos Number", "HIP 39378"},
        {"Geneva Identification System", "GEN# +1.00065601"},
        {"Smithsonian Astrophysical Observation", "SAO 14415"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.76459080),
        dec: Angle.Degrees(+61.63123389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101076"},
        {"Hipparcos Number", "HIP 56765"},
        {"Smithsonian Astrophysical Observation", "SAO 15577"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.57639378),
        dec: Angle.Degrees(+61.63154633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25427"},
        {"Hipparcos Number", "HIP 19122"},
        {"Smithsonian Astrophysical Observation", "SAO 13011"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.49371872),
        dec: Angle.Degrees(+61.63277342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153205"},
        {"Hipparcos Number", "HIP 82679"},
        {"Geneva Identification System", "GEN# +1.00153205"},
        {"Smithsonian Astrophysical Observation", "SAO 17264"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.51298104),
        dec: Angle.Degrees(+61.64649216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84795",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84795"},
        {"Smithsonian Astrophysical Observation", "SAO 17435"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.98299644),
        dec: Angle.Degrees(+61.65107664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18915"},
        {"Hipparcos Number", "HIP 14377"},
        {"Geneva Identification System", "GEN# +1.00018915"},
        {"Smithsonian Astrophysical Observation", "SAO 12599"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.36479414),
        dec: Angle.Degrees(+61.65491294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29761"},
        {"Hipparcos Number", "HIP 22094"},
        {"Smithsonian Astrophysical Observation", "SAO 13253"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.31153053),
        dec: Angle.Degrees(+61.65629509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218724"},
        {"Hipparcos Number", "HIP 114332"},
        {"Geneva Identification System", "GEN# +1.00218724"},
        {"Smithsonian Astrophysical Observation", "SAO 20455"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.33417842),
        dec: Angle.Degrees(+61.65640797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20460",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20460"},
        {"Smithsonian Astrophysical Observation", "SAO 13121"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.75493364),
        dec: Angle.Degrees(+61.65752049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104807",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104807"},
        {"Smithsonian Astrophysical Observation", "SAO 19258"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.50598976),
        dec: Angle.Degrees(+61.66111708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78423",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78423"},
        {"Geneva Identification System", "GEN# +0.06201446"},
        {"Smithsonian Astrophysical Observation", "SAO 16923"},
        {"Wilson Evans Batten Catalogue", "WEB 13254"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.15171641),
        dec: Angle.Degrees(+61.66137496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -442.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46426",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46426"},
        {"Smithsonian Astrophysical Observation", "SAO 14883"},
    },
    visualMagnitude: 10.26,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.00191821),
        dec: Angle.Degrees(+61.66141035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5233"},
        {"Hipparcos Number", "HIP 4295"},
        {"Geneva Identification System", "GEN# +1.00005233"},
        {"Smithsonian Astrophysical Observation", "SAO 11463"},
        {"Wilson Evans Batten Catalogue", "WEB 769"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.75423391),
        dec: Angle.Degrees(+61.66242797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32680"},
        {"Hipparcos Number", "HIP 23958"},
        {"Geneva Identification System", "GEN# +1.00032680"},
        {"Smithsonian Astrophysical Observation", "SAO 13384"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.23781102),
        dec: Angle.Degrees(+61.66436122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152875"},
        {"Hipparcos Number", "HIP 82530"},
        {"Smithsonian Astrophysical Observation", "SAO 17248"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.04528156),
        dec: Angle.Degrees(+61.66537612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132890"},
        {"Hipparcos Number", "HIP 73283"},
        {"Smithsonian Astrophysical Observation", "SAO 16561"},
        {"Wilson Evans Batten Catalogue", "WEB 12555"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.66394320),
        dec: Angle.Degrees(+61.66688334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21355"},
        {"Hipparcos Number", "HIP 16283"},
        {"Smithsonian Astrophysical Observation", "SAO 12783"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.47954556),
        dec: Angle.Degrees(+61.66941716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72774",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72774"},
        {"Smithsonian Astrophysical Observation", "SAO 16538"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.14937820),
        dec: Angle.Degrees(+61.67093821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45206",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7226 A"},
        {"Henry Draper", "HD 78767"},
        {"Hipparcos Number", "HIP 45206"},
        {"Smithsonian Astrophysical Observation", "SAO 14808"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.19138679),
        dec: Angle.Degrees(+61.67572841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38924"},
        {"Hipparcos Number", "HIP 27832"},
        {"Smithsonian Astrophysical Observation", "SAO 13642"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.33336475),
        dec: Angle.Degrees(+61.67606740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122944"},
        {"Hipparcos Number", "HIP 68615"},
        {"Smithsonian Astrophysical Observation", "SAO 16258"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.69569180),
        dec: Angle.Degrees(+61.67905439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222682"},
        {"Hipparcos Number", "HIP 116962"},
        {"Fundamental Katalog 5th Edition", "FK5 3900"},
        {"Geneva Identification System", "GEN# +1.00222682J"},
        {"Smithsonian Astrophysical Observation", "SAO 20793"},
        {"Wilson Evans Batten Catalogue", "WEB 20631"},
    },
    visualMagnitude: 6.40,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.63086174),
        dec: Angle.Degrees(+61.67939575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45208",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7226 B"},
        {"Henry Draper", "HD 78766"},
        {"Hipparcos Number", "HIP 45208"},
        {"Renson", "Renson 22330"},
        {"Smithsonian Astrophysical Observation", "SAO 14809"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.19798374),
        dec: Angle.Degrees(+61.68186919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69496"},
        {"Hipparcos Number", "HIP 40899"},
        {"Smithsonian Astrophysical Observation", "SAO 14510"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.19426609),
        dec: Angle.Degrees(+61.68219102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86087",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10660 C"},
        {"Hipparcos Number", "HIP 86087"},
        {"Cincinnati Publication", "Ci 20 1051"},
        {"Geneva Identification System", "GEN# +9.80226066"},
        {"Geneva Identification System 2", "GEN# +6.10010685"},
        {"Geneva Identification System 3", "GEN# +1.00160269C"},
        {"Wilson Evans Batten Catalogue", "WEB 14521"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.89231937),
        dec: Angle.Degrees(+61.68281406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 263.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -514.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24866"},
        {"Hipparcos Number", "HIP 18733"},
        {"Smithsonian Astrophysical Observation", "SAO 12984"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.19476893),
        dec: Angle.Degrees(+61.68337227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159640"},
        {"Hipparcos Number", "HIP 85772"},
        {"Smithsonian Astrophysical Observation", "SAO 17513"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.89216356),
        dec: Angle.Degrees(+61.68389171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13504"},
        {"Hipparcos Number", "HIP 10409"},
        {"Geneva Identification System", "GEN# +1.00013504"},
        {"Smithsonian Astrophysical Observation", "SAO 12179"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.52682869),
        dec: Angle.Degrees(+61.68445618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29797"},
        {"Hipparcos Number", "HIP 22125"},
        {"Smithsonian Astrophysical Observation", "SAO 13256"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.42109410),
        dec: Angle.Degrees(+61.68950727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109856",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109856"},
        {"Geneva Identification System", "GEN# +0.06002369"},
        {"Smithsonian Astrophysical Observation", "SAO 19961"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.75331436),
        dec: Angle.Degrees(+61.69234383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109320",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109320"},
        {"Geneva Identification System", "GEN# +0.06002349"},
        {"Smithsonian Astrophysical Observation", "SAO 19895"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.21490500),
        dec: Angle.Degrees(+61.69381083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7829"},
        {"Hipparcos Number", "HIP 6178"},
        {"Geneva Identification System", "GEN# +1.00007829"},
        {"Smithsonian Astrophysical Observation", "SAO 11691"},
        {"Wilson Evans Batten Catalogue", "WEB 1387"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.81679495),
        dec: Angle.Degrees(+61.69397498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148226"},
        {"Hipparcos Number", "HIP 80243"},
        {"Smithsonian Astrophysical Observation", "SAO 17066"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.72733059),
        dec: Angle.Degrees(+61.69451733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39407",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39407"},
        {"Smithsonian Astrophysical Observation", "SAO 14417"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.83948558),
        dec: Angle.Degrees(+61.69453638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80309",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10052 AB"},
        {"Henry Draper", "HD 148374"},
        {"Hipparcos Number", "HIP 80309"},
        {"Geneva Identification System", "GEN# +1.00148374"},
        {"Smithsonian Astrophysical Observation", "SAO 17073"},
        {"Wilson Evans Batten Catalogue", "WEB 13590"},
    },
    visualMagnitude: 5.67,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.94662440),
        dec: Angle.Degrees(+61.69637867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112864",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16317 AB"},
        {"Henry Draper", "HD 216380"},
        {"Hipparcos Number", "HIP 112864"},
        {"Geneva Identification System", "GEN# +1.00216380J"},
        {"Smithsonian Astrophysical Observation", "SAO 20281"},
        {"Wilson Evans Batten Catalogue", "WEB 20102"},
    },
    visualMagnitude: 5.61,
    bvColour: 0.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.84378464),
        dec: Angle.Degrees(+61.69663851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11857"},
        {"Hipparcos Number", "HIP 9220"},
        {"Celescope Catalog", "CEL 183"},
        {"Geneva Identification System", "GEN# +1.00011857"},
        {"Smithsonian Astrophysical Observation", "SAO 12065"},
        {"Wilson Evans Batten Catalogue", "WEB 1936"},
    },
    visualMagnitude: 6.02,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.63840779),
        dec: Angle.Degrees(+61.69781632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91258",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91258"},
        {"Smithsonian Astrophysical Observation", "SAO 17954"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.22167774),
        dec: Angle.Degrees(+61.70306934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -232.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5688",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 987 AB"},
        {"Henry Draper", "HD 7157"},
        {"Hipparcos Number", "HIP 5688"},
        {"Celescope Catalog", "CEL 129"},
        {"Geneva Identification System", "GEN# +1.00007157J"},
        {"Renson", "Renson 1795"},
        {"Smithsonian Astrophysical Observation", "SAO 11637"},
        {"Wilson Evans Batten Catalogue", "WEB 1297"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.29090532),
        dec: Angle.Degrees(+61.70620371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4634",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4634"},
        {"Smithsonian Astrophysical Observation", "SAO 11509"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.86670682),
        dec: Angle.Degrees(+61.70734504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18757"},
        {"Hipparcos Number", "HIP 14286"},
        {"Cincinnati Publication", "Ci 20 201"},
        {"Geneva Identification System", "GEN# +1.00018757"},
        {"Smithsonian Astrophysical Observation", "SAO 12587"},
        {"Wilson Evans Batten Catalogue", "WEB 2796"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.03645457),
        dec: Angle.Degrees(+61.70751562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 721.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -693.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48445",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48445"},
        {"Smithsonian Astrophysical Observation", "SAO 15008"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.16122093),
        dec: Angle.Degrees(+61.70908144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8464"},
        {"Hipparcos Number", "HIP 6645"},
        {"Geneva Identification System", "GEN# +1.00008464"},
        {"Smithsonian Astrophysical Observation", "SAO 11748"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.31716418),
        dec: Angle.Degrees(+61.70939355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103045"},
        {"Hipparcos Number", "HIP 57865"},
        {"Geneva Identification System", "GEN# +1.00103045"},
        {"Smithsonian Astrophysical Observation", "SAO 15647"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.03192521),
        dec: Angle.Degrees(+61.70944168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211401"},
        {"Hipparcos Number", "HIP 109853"},
        {"Smithsonian Astrophysical Observation", "SAO 19960"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.73511993),
        dec: Angle.Degrees(+61.70954665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19844"},
        {"Hipparcos Number", "HIP 15086"},
        {"Geneva Identification System", "GEN# +1.00019844"},
        {"Smithsonian Astrophysical Observation", "SAO 12667"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.64014053),
        dec: Angle.Degrees(+61.71559609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53669",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7994 A"},
        {"Henry Draper", "HD 94947"},
        {"Hipparcos Number", "HIP 53669"},
        {"Smithsonian Astrophysical Observation", "SAO 15354"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.71015393),
        dec: Angle.Degrees(+61.71569419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53053",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53053"},
        {"Smithsonian Astrophysical Observation", "SAO 15312"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.81436446),
        dec: Angle.Degrees(+61.71589963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93650"},
        {"Hipparcos Number", "HIP 52962"},
        {"Smithsonian Astrophysical Observation", "SAO 15304"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.48283605),
        dec: Angle.Degrees(+61.71695192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -181.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112827"},
        {"Hipparcos Number", "HIP 63312"},
        {"Smithsonian Astrophysical Observation", "SAO 15956"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.62839320),
        dec: Angle.Degrees(+61.71696175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7681"},
        {"Hipparcos Number", "HIP 6084"},
        {"Geneva Identification System", "GEN# +1.00007681"},
        {"Smithsonian Astrophysical Observation", "SAO 11682"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.52988281),
        dec: Angle.Degrees(+61.71791356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81087",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81087"},
        {"Smithsonian Astrophysical Observation", "SAO 17143"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.43365072),
        dec: Angle.Degrees(+61.71827663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12547",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12547"},
        {"Geneva Identification System", "GEN# +2.10270002"},
        {"New General Catalogue", "NGC 1027 2"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.36199554),
        dec: Angle.Degrees(+61.71978018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8261"},
        {"Hipparcos Number", "HIP 6476"},
        {"Geneva Identification System", "GEN# +1.00008261"},
        {"Smithsonian Astrophysical Observation", "SAO 11730"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.81996786),
        dec: Angle.Degrees(+61.72155288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17620",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17620"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.62047330),
        dec: Angle.Degrees(+61.72159579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138406"},
        {"Hipparcos Number", "HIP 75764"},
        {"Renson", "Renson 39407"},
        {"Smithsonian Astrophysical Observation", "SAO 16743"},
        {"Wilson Evans Batten Catalogue", "WEB 12900"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.16360265),
        dec: Angle.Degrees(+61.72663675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1383"},
        {"Hipparcos Number", "HIP 1466"},
        {"Celescope Catalog", "CEL 51"},
        {"Geneva Identification System", "GEN# +1.00001383"},
        {"Smithsonian Astrophysical Observation", "SAO 11092"},
        {"Wilson Evans Batten Catalogue", "WEB 267"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.57391863),
        dec: Angle.Degrees(+61.72706050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63784",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63784"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.10329829),
        dec: Angle.Degrees(+61.72718370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -205.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41689",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41689"},
        {"Geneva Identification System", "GEN# +9.80234035"},
    },
    visualMagnitude: 10.29,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.48197644),
        dec: Angle.Degrees(+61.72749897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 530.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -716.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215484"},
        {"Hipparcos Number", "HIP 112254"},
        {"Geneva Identification System", "GEN# +1.00215484"},
        {"Wilson Evans Batten Catalogue", "WEB 20033"},
    },
    visualMagnitude: 8.57,
    bvColour: 2.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.04632153),
        dec: Angle.Degrees(+61.72850775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15306",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15306"},
        {"Smithsonian Astrophysical Observation", "SAO 12688"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.36528554),
        dec: Angle.Degrees(+61.72908645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81487"},
        {"Hipparcos Number", "HIP 46448"},
        {"Smithsonian Astrophysical Observation", "SAO 14887"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.10444320),
        dec: Angle.Degrees(+61.73123317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3437",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3437"},
        {"Geneva Identification System", "GEN# +2.02250005"},
        {"New General Catalogue", "NGC 225 5"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.96681097),
        dec: Angle.Degrees(+61.73844999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134825"},
        {"Hipparcos Number", "HIP 74133"},
        {"Geneva Identification System", "GEN# +1.00134825"},
        {"Smithsonian Astrophysical Observation", "SAO 16615"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.24103119),
        dec: Angle.Degrees(+61.74140032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205285"},
        {"Hipparcos Number", "HIP 106307"},
        {"Geneva Identification System", "GEN# +1.00205285"},
        {"Renson", "Renson 57200"},
        {"Smithsonian Astrophysical Observation", "SAO 19474"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.95963897),
        dec: Angle.Degrees(+61.74206545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196407"},
        {"Hipparcos Number", "HIP 101481"},
        {"Celescope Catalog", "CEL 5119"},
        {"Geneva Identification System", "GEN# +1.00196407"},
        {"Smithsonian Astrophysical Observation", "SAO 18928"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.48413067),
        dec: Angle.Degrees(+61.74339071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12493"},
        {"Hipparcos Number", "HIP 9689"},
        {"Geneva Identification System", "GEN# +1.00012493"},
        {"Smithsonian Astrophysical Observation", "SAO 12107"},
        {"Wilson Evans Batten Catalogue", "WEB 2033"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.15682556),
        dec: Angle.Degrees(+61.74453243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32227",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32227"},
        {"Smithsonian Astrophysical Observation", "SAO 13941"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.91493859),
        dec: Angle.Degrees(+61.74595162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107582"},
        {"Hipparcos Number", "HIP 60268"},
        {"Cincinnati Publication", "Ci 18 1550"},
        {"Geneva Identification System", "GEN# +1.00107582"},
        {"Smithsonian Astrophysical Observation", "SAO 15778"},
        {"Wilson Evans Batten Catalogue", "WEB 10720"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.36874795),
        dec: Angle.Degrees(+61.74788833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -300.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -262.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54061",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Dubhe"},
        {"Aitken", "ADS 8035 AB"},
        {"Henry Draper", "HD 95689"},
        {"Hipparcos Number", "HIP 54061"},
        {"Fundamental Katalog 5th Edition", "FK5 417"},
        {"Geneva Identification System", "GEN# +1.00095689"},
        {"Smithsonian Astrophysical Observation", "SAO 15384"},
        {"Wilson Evans Batten Catalogue", "WEB 9776"},
    },
    visualMagnitude: 1.81,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.93265365),
        dec: Angle.Degrees(+61.75111888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34623"},
        {"Hipparcos Number", "HIP 25150"},
        {"Geneva Identification System", "GEN# +1.00034623"},
        {"Smithsonian Astrophysical Observation", "SAO 13476"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.72988595),
        dec: Angle.Degrees(+61.75154245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12192"},
        {"Hipparcos Number", "HIP 9461"},
        {"Geneva Identification System", "GEN# +1.00012192"},
        {"Smithsonian Astrophysical Observation", "SAO 12088"},
        {"Wilson Evans Batten Catalogue", "WEB 1984"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.44283020),
        dec: Angle.Degrees(+61.75269388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23037",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3526 AB"},
        {"Henry Draper", "HD 31151"},
        {"Hipparcos Number", "HIP 23037"},
        {"Smithsonian Astrophysical Observation", "SAO 13317"},
        {"Wilson Evans Batten Catalogue", "WEB 4469"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.31423966),
        dec: Angle.Degrees(+61.75310836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5138",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5138"},
        {"Wilson Evans Batten Catalogue", "WEB 1064"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.45093957),
        dec: Angle.Degrees(+61.75493929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157425"},
        {"Hipparcos Number", "HIP 84727"},
        {"Smithsonian Astrophysical Observation", "SAO 17428"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.78918044),
        dec: Angle.Degrees(+61.75741497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113662"},
        {"Hipparcos Number", "HIP 63760"},
        {"Smithsonian Astrophysical Observation", "SAO 15968"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.03408899),
        dec: Angle.Degrees(+61.75768391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59033"},
        {"Hipparcos Number", "HIP 36634"},
        {"Fundamental Katalog 5th Edition", "FK5 2581"},
        {"Geneva Identification System", "GEN# +1.00059033"},
        {"Smithsonian Astrophysical Observation", "SAO 14226"},
        {"Wilson Evans Batten Catalogue", "WEB 7280"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.00931943),
        dec: Angle.Degrees(+61.75807258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43749"},
        {"Hipparcos Number", "HIP 30278"},
        {"Geneva Identification System", "GEN# +1.00043749"},
        {"Smithsonian Astrophysical Observation", "SAO 13818"},
        {"Wilson Evans Batten Catalogue", "WEB 6018"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.53373399),
        dec: Angle.Degrees(+61.76027203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6934",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6934"},
        {"Geneva Identification System", "GEN# +0.06100270"},
        {"Smithsonian Astrophysical Observation", "SAO 11775"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.33582759),
        dec: Angle.Degrees(+61.76167219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213336"},
        {"Hipparcos Number", "HIP 110994"},
        {"Smithsonian Astrophysical Observation", "SAO 20098"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.30622234),
        dec: Angle.Degrees(+61.76202107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51799",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51799"},
        {"Smithsonian Astrophysical Observation", "SAO 15229"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.74997732),
        dec: Angle.Degrees(+61.76227369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94816"},
        {"Hipparcos Number", "HIP 53602"},
        {"Smithsonian Astrophysical Observation", "SAO 15349"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.49173748),
        dec: Angle.Degrees(+61.76617034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1057"},
        {"Hipparcos Number", "HIP 1209"},
        {"Geneva Identification System", "GEN# +1.00001057"},
        {"Smithsonian Astrophysical Observation", "SAO 11068"},
        {"Wilson Evans Batten Catalogue", "WEB 216"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.78065208),
        dec: Angle.Degrees(+61.76720575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18990"},
        {"Hipparcos Number", "HIP 14422"},
        {"Geneva Identification System", "GEN# +1.00018990J"},
        {"Smithsonian Astrophysical Observation", "SAO 12605"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.55162037),
        dec: Angle.Degrees(+61.77225864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80731"},
        {"Hipparcos Number", "HIP 46099"},
        {"Geneva Identification System", "GEN# +1.00080731"},
        {"Smithsonian Astrophysical Observation", "SAO 14866"},
        {"Wilson Evans Batten Catalogue", "WEB 8729"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.01369332),
        dec: Angle.Degrees(+61.77309505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14552"},
        {"Hipparcos Number", "HIP 11156"},
        {"Geneva Identification System", "GEN# +1.00014552"},
        {"Smithsonian Astrophysical Observation", "SAO 12262"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.87870058),
        dec: Angle.Degrees(+61.77372940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199354"},
        {"Hipparcos Number", "HIP 103128"},
        {"Geneva Identification System", "GEN# +1.00199354"},
        {"Smithsonian Astrophysical Observation", "SAO 19085"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.42153688),
        dec: Angle.Degrees(+61.77564137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 140.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99747"},
        {"Hipparcos Number", "HIP 56035"},
        {"Fundamental Katalog 5th Edition", "FK5 2915"},
        {"Geneva Identification System", "GEN# +1.00099747"},
        {"Smithsonian Astrophysical Observation", "SAO 15520"},
        {"Wilson Evans Batten Catalogue", "WEB 10059"},
    },
    visualMagnitude: 5.83,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.26959813),
        dec: Angle.Degrees(+61.77778557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 239.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214007"},
        {"Hipparcos Number", "HIP 111379"},
        {"Fundamental Katalog 5th Edition", "FK5 3808"},
        {"Geneva Identification System", "GEN# +1.00214007"},
        {"Smithsonian Astrophysical Observation", "SAO 20153"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.47134180),
        dec: Angle.Degrees(+61.77809380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171607"},
        {"Hipparcos Number", "HIP 90833"},
        {"Smithsonian Astrophysical Observation", "SAO 17918"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.94968545),
        dec: Angle.Degrees(+61.77890188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3487",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3487"},
        {"Geneva Identification System", "GEN# +2.02250002"},
        {"Smithsonian Astrophysical Observation", "SAO 11357"},
        {"New General Catalogue", "NGC 225 2"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.12783936),
        dec: Angle.Degrees(+61.78054266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25393",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25393"},
        {"Smithsonian Astrophysical Observation", "SAO 13486"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.47878077),
        dec: Angle.Degrees(+61.78306350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 199.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12590"},
        {"Hipparcos Number", "HIP 9756"},
        {"Geneva Identification System", "GEN# +1.00012590"},
        {"Smithsonian Astrophysical Observation", "SAO 12119"},
        {"Wilson Evans Batten Catalogue", "WEB 2052"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.37150890),
        dec: Angle.Degrees(+61.78697438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203232"},
        {"Hipparcos Number", "HIP 105172"},
        {"Smithsonian Astrophysical Observation", "SAO 19294"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.57385288),
        dec: Angle.Degrees(+61.78780563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117078",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117078"},
        {"Geneva Identification System", "GEN# +0.06002613"},
    },
    visualMagnitude: 8.22,
    bvColour: 2.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.01369270),
        dec: Angle.Degrees(+61.78950369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25408"},
        {"Hipparcos Number", "HIP 19115"},
        {"Geneva Identification System", "GEN# +1.00025408"},
        {"Smithsonian Astrophysical Observation", "SAO 13009"},
        {"Wilson Evans Batten Catalogue", "WEB 3668"},
    },
    visualMagnitude: 7.59,
    bvColour: 2.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.47437503),
        dec: Angle.Degrees(+61.79443247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7936",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7936"},
        {"Geneva Identification System", "GEN# +0.06100310"},
        {"Geneva Identification System 2", "GEN# +2.06540259"},
        {"New General Catalogue", "NGC 654 259"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.50387580),
        dec: Angle.Degrees(+61.79545007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26718"},
        {"Hipparcos Number", "HIP 20003"},
        {"Smithsonian Astrophysical Observation", "SAO 13080"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.33378750),
        dec: Angle.Degrees(+61.79695458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23621"},
        {"Hipparcos Number", "HIP 17929"},
        {"Smithsonian Astrophysical Observation", "SAO 12922"},
        {"Wilson Evans Batten Catalogue", "WEB 3450"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.51420851),
        dec: Angle.Degrees(+61.79831829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37919",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37919"},
        {"Smithsonian Astrophysical Observation", "SAO 14318"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.56447152),
        dec: Angle.Degrees(+61.79861234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114929",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16645 AB"},
        {"Hipparcos Number", "HIP 114929"},
        {"Smithsonian Astrophysical Observation", "SAO 20532"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.19621951),
        dec: Angle.Degrees(+61.79943746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106892",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106892"},
        {"Smithsonian Astrophysical Observation", "SAO 19551"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.74636572),
        dec: Angle.Degrees(+61.80152404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55059",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55059"},
        {"Smithsonian Astrophysical Observation", "SAO 15453"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.07793333),
        dec: Angle.Degrees(+61.80284559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207951"},
        {"Hipparcos Number", "HIP 107827"},
        {"Celescope Catalog", "CEL 5395"},
        {"Geneva Identification System", "GEN# +1.00207951"},
        {"Smithsonian Astrophysical Observation", "SAO 19673"},
        {"Wilson Evans Batten Catalogue", "WEB 19443"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.66932301),
        dec: Angle.Degrees(+61.80312436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4817"},
        {"Hipparcos Number", "HIP 3988"},
        {"Geneva Identification System", "GEN# +1.00004817"},
        {"Smithsonian Astrophysical Observation", "SAO 11430"},
        {"Wilson Evans Batten Catalogue", "WEB 711"},
    },
    visualMagnitude: 6.04,
    bvColour: 1.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.81827283),
        dec: Angle.Degrees(+61.80549823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5482",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 958 A"},
        {"Henry Draper", "HD 6832"},
        {"Hipparcos Number", "HIP 5482"},
        {"Geneva Identification System", "GEN# +1.00006832J"},
        {"Renson", "Renson 1764"},
        {"Smithsonian Astrophysical Observation", "SAO 11604"},
        {"Wilson Evans Batten Catalogue", "WEB 1209"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.54209712),
        dec: Angle.Degrees(+61.80818665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11818",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1916 AB"},
        {"Henry Draper", "HD 15522"},
        {"Hipparcos Number", "HIP 11818"},
        {"Smithsonian Astrophysical Observation", "SAO 12322"},
    },
    visualMagnitude: 8.31,
    bvColour: -0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.10075689),
        dec: Angle.Degrees(+61.80865391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156126"},
        {"Hipparcos Number", "HIP 84107"},
        {"Smithsonian Astrophysical Observation", "SAO 17381"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.91774664),
        dec: Angle.Degrees(+61.80964277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6182"},
        {"Hipparcos Number", "HIP 5000"},
        {"Geneva Identification System", "GEN# +1.00006182"},
        {"Smithsonian Astrophysical Observation", "SAO 11554"},
        {"Wilson Evans Batten Catalogue", "WEB 1013"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.01528851),
        dec: Angle.Degrees(+61.81053452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51411",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51411"},
        {"Smithsonian Astrophysical Observation", "SAO 15198"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.51321713),
        dec: Angle.Degrees(+61.81151245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3501",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3501"},
        {"Geneva Identification System", "GEN# +2.02250001"},
        {"Smithsonian Astrophysical Observation", "SAO 11362"},
        {"New General Catalogue", "NGC 225 1"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.17011115),
        dec: Angle.Degrees(+61.81203195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55484",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55484"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.45199337),
        dec: Angle.Degrees(+61.81555913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9722"},
        {"Hipparcos Number", "HIP 7521"},
        {"Geneva Identification System", "GEN# +1.00009722"},
        {"Smithsonian Astrophysical Observation", "SAO 11868"},
        {"Wilson Evans Batten Catalogue", "WEB 1606"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.21052699),
        dec: Angle.Degrees(+61.81611439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117553"},
        {"Hipparcos Number", "HIP 65814"},
        {"Smithsonian Astrophysical Observation", "SAO 16087"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.37258284),
        dec: Angle.Degrees(+61.81863476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34892",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34892"},
        {"Smithsonian Astrophysical Observation", "SAO 14114"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.28295665),
        dec: Angle.Degrees(+61.82127807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34917"},
        {"Hipparcos Number", "HIP 25328"},
        {"Fundamental Katalog 5th Edition", "FK5 4497"},
        {"Smithsonian Astrophysical Observation", "SAO 13484"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.25515691),
        dec: Angle.Degrees(+61.82569107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11162"},
        {"Hipparcos Number", "HIP 8671"},
        {"Geneva Identification System", "GEN# +1.00011162"},
        {"Wilson Evans Batten Catalogue", "WEB 1830"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.91675632),
        dec: Angle.Degrees(+61.83065725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2011"},
        {"Hipparcos Number", "HIP 1960"},
        {"Celescope Catalog", "CEL 74"},
        {"Geneva Identification System", "GEN# +1.00002011"},
        {"Smithsonian Astrophysical Observation", "SAO 11172"},
        {"Wilson Evans Batten Catalogue", "WEB 370"},
    },
    visualMagnitude: 5.38,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.19786908),
        dec: Angle.Degrees(+61.83106347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24639"},
        {"Hipparcos Number", "HIP 18584"},
        {"Smithsonian Astrophysical Observation", "SAO 12978"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.65872878),
        dec: Angle.Degrees(+61.83268657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74940"},
        {"Hipparcos Number", "HIP 43375"},
        {"Geneva Identification System", "GEN# +1.00074940"},
        {"Smithsonian Astrophysical Observation", "SAO 14676"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.53092578),
        dec: Angle.Degrees(+61.83321851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10842"},
        {"Hipparcos Number", "HIP 8385"},
        {"Geneva Identification System", "GEN# +1.00010842"},
        {"Smithsonian Astrophysical Observation", "SAO 11988"},
        {"Wilson Evans Batten Catalogue", "WEB 1782"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.03073143),
        dec: Angle.Degrees(+61.83416723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8074",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8074"},
        {"Geneva Identification System", "GEN# +2.06540002"},
        {"Smithsonian Astrophysical Observation", "SAO 11944"},
        {"New General Catalogue", "NGC 654 2"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.93068856),
        dec: Angle.Degrees(+61.83432365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44849",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44849"},
        {"Smithsonian Astrophysical Observation", "SAO 14773"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.06688717),
        dec: Angle.Degrees(+61.83487507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102422",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14276 A"},
        {"Henry Draper", "HD 198149"},
        {"Hipparcos Number", "HIP 102422"},
        {"Cincinnati Publication", "Ci 20 1230"},
        {"Fundamental Katalog 5th Edition", "FK5 783"},
        {"Geneva Identification System", "GEN# +1.00198149"},
        {"Smithsonian Astrophysical Observation", "SAO 19019"},
        {"Wilson Evans Batten Catalogue", "WEB 18547"},
    },
    visualMagnitude: 3.41,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.32195263),
        dec: Angle.Degrees(+61.83679404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 817.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106200",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106200"},
        {"Smithsonian Astrophysical Observation", "SAO 19463"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.66979510),
        dec: Angle.Degrees(+61.83700658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224055"},
        {"Hipparcos Number", "HIP 117884"},
        {"Celescope Catalog", "CEL 5709"},
        {"Geneva Identification System", "GEN# +1.00224055"},
        {"Smithsonian Astrophysical Observation", "SAO 20932"},
        {"Wilson Evans Batten Catalogue", "WEB 20733"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.67549952),
        dec: Angle.Degrees(+61.83890266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17146",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17146"},
        {"Geneva Identification System", "GEN# +0.06100623"},
        {"Smithsonian Astrophysical Observation", "SAO 12860"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.08320316),
        dec: Angle.Degrees(+61.84400722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81244",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81244"},
        {"Smithsonian Astrophysical Observation", "SAO 17159"},
    },
    visualMagnitude: 10.01,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.89955357),
        dec: Angle.Degrees(+61.84683348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10494"},
        {"Hipparcos Number", "HIP 8106"},
        {"Geneva Identification System", "GEN# +2.06540001"},
        {"Smithsonian Astrophysical Observation", "SAO 11950"},
        {"Wilson Evans Batten Catalogue", "WEB 1731"},
        {"New General Catalogue", "NGC 654 1"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.04840667),
        dec: Angle.Degrees(+61.84980336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33266"},
        {"Hipparcos Number", "HIP 24313"},
        {"Geneva Identification System", "GEN# +1.00033266"},
        {"Smithsonian Astrophysical Observation", "SAO 13409"},
        {"Wilson Evans Batten Catalogue", "WEB 4717"},
    },
    visualMagnitude: 6.17,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.26179051),
        dec: Angle.Degrees(+61.85003527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26670"},
        {"Hipparcos Number", "HIP 19968"},
        {"Geneva Identification System", "GEN# +1.00026670"},
        {"Smithsonian Astrophysical Observation", "SAO 13075"},
        {"Wilson Evans Batten Catalogue", "WEB 3808"},
    },
    visualMagnitude: 5.69,
    bvColour: -0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.22311681),
        dec: Angle.Degrees(+61.85004125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84210",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84210"},
        {"Smithsonian Astrophysical Observation", "SAO 17393"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.21282744),
        dec: Angle.Degrees(+61.85373751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74370",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9537 A"},
        {"Henry Draper", "HD 135421"},
        {"Hipparcos Number", "HIP 74370"},
        {"Geneva Identification System", "GEN# +1.00135421A"},
        {"Geneva Identification System 2", "GEN# +1.10135421"},
        {"Smithsonian Astrophysical Observation", "SAO 16636"},
        {"Wilson Evans Batten Catalogue", "WEB 12692"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.96067365),
        dec: Angle.Degrees(+61.85679089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -162.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 99.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105250",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14868 A"},
        {"Henry Draper", "HD 203374"},
        {"Hipparcos Number", "HIP 105250"},
        {"Celescope Catalog", "CEL 5297"},
        {"Geneva Identification System", "GEN# +1.00203374"},
        {"Smithsonian Astrophysical Observation", "SAO 19309"},
        {"Wilson Evans Batten Catalogue", "WEB 19115"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.78067129),
        dec: Angle.Degrees(+61.85846283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33660",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33660"},
        {"Smithsonian Astrophysical Observation", "SAO 14034"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.89042797),
        dec: Angle.Degrees(+61.85871769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17305"},
        {"Hipparcos Number", "HIP 13171"},
        {"Smithsonian Astrophysical Observation", "SAO 12452"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.34918419),
        dec: Angle.Degrees(+61.86083798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74368",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9537 B"},
        {"Hipparcos Number", "HIP 74368"},
        {"Geneva Identification System", "GEN# +1.00135421B"},
        {"Smithsonian Astrophysical Observation", "SAO 16635"},
        {"Wilson Evans Batten Catalogue", "WEB 12693"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.95957101),
        dec: Angle.Degrees(+61.86122181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -153.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9256"},
        {"Hipparcos Number", "HIP 7193"},
        {"Geneva Identification System", "GEN# +1.00009256"},
        {"Smithsonian Astrophysical Observation", "SAO 11814"},
        {"Wilson Evans Batten Catalogue", "WEB 1551"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.18047745),
        dec: Angle.Degrees(+61.86136829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2772",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 483 A"},
        {"Henry Draper", "HD 3140"},
        {"Hipparcos Number", "HIP 2772"},
        {"Smithsonian Astrophysical Observation", "SAO 11277"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.84150203),
        dec: Angle.Degrees(+61.86468574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114817",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114817"},
        {"Smithsonian Astrophysical Observation", "SAO 20517"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.87181055),
        dec: Angle.Degrees(+61.86591037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39219"},
        {"Hipparcos Number", "HIP 27990"},
        {"Geneva Identification System", "GEN# +1.00039219"},
        {"Smithsonian Astrophysical Observation", "SAO 13650"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.80171033),
        dec: Angle.Degrees(+61.86673905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117087"},
        {"Hipparcos Number", "HIP 65561"},
        {"Geneva Identification System", "GEN# +1.00117087"},
        {"Smithsonian Astrophysical Observation", "SAO 16072"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.63216275),
        dec: Angle.Degrees(+61.86739299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95920",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95920"},
        {"Smithsonian Astrophysical Observation", "SAO 18373"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.61325598),
        dec: Angle.Degrees(+61.87358442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86036",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10660 AB"},
        {"Henry Draper", "HD 160269"},
        {"Hipparcos Number", "HIP 86036"},
        {"Cincinnati Publication", "Ci 20 1049"},
        {"Geneva Identification System", "GEN# +1.00160269"},
        {"Smithsonian Astrophysical Observation", "SAO 17546"},
        {"Wilson Evans Batten Catalogue", "WEB 14517"},
    },
    visualMagnitude: 5.23,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.74687828),
        dec: Angle.Degrees(+61.87583150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 277.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -525.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223767"},
        {"Hipparcos Number", "HIP 117705"},
        {"Celescope Catalog", "CEL 5697"},
        {"Geneva Identification System", "GEN# +1.00223767"},
        {"Smithsonian Astrophysical Observation", "SAO 20902"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.07027373),
        dec: Angle.Degrees(+61.87756791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58184"},
        {"Hipparcos Number", "HIP 36306"},
        {"Smithsonian Astrophysical Observation", "SAO 14206"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.09967513),
        dec: Angle.Degrees(+61.87764835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1613"},
        {"Hipparcos Number", "HIP 1652"},
        {"Geneva Identification System", "GEN# +1.00001613"},
        {"Smithsonian Astrophysical Observation", "SAO 11123"},
        {"Wilson Evans Batten Catalogue", "WEB 302"},
    },
    visualMagnitude: 6.80,
    bvColour: 2.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.18151870),
        dec: Angle.Degrees(+61.87959637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140512"},
        {"Hipparcos Number", "HIP 76776"},
        {"Geneva Identification System", "GEN# +1.00140512"},
        {"Smithsonian Astrophysical Observation", "SAO 16808"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.13733610),
        dec: Angle.Degrees(+61.88070982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167159"},
        {"Hipparcos Number", "HIP 88998"},
        {"Geneva Identification System", "GEN# +1.00167159"},
        {"Smithsonian Astrophysical Observation", "SAO 17794"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.47228441),
        dec: Angle.Degrees(+61.88089335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111027"},
        {"Hipparcos Number", "HIP 62266"},
        {"Geneva Identification System", "GEN# +1.00111027"},
        {"Smithsonian Astrophysical Observation", "SAO 15892"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.40425116),
        dec: Angle.Degrees(+61.88200490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221595"},
        {"Hipparcos Number", "HIP 116224"},
        {"Smithsonian Astrophysical Observation", "SAO 20694"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.22842890),
        dec: Angle.Degrees(+61.88357883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205100"},
        {"Hipparcos Number", "HIP 106194"},
        {"Smithsonian Astrophysical Observation", "SAO 19460"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.64983022),
        dec: Angle.Degrees(+61.88411320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17896",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17896"},
        {"Smithsonian Astrophysical Observation", "SAO 12919"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.41560989),
        dec: Angle.Degrees(+61.88424431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28577"},
        {"Hipparcos Number", "HIP 21292"},
        {"Geneva Identification System", "GEN# +1.00028577"},
        {"Smithsonian Astrophysical Observation", "SAO 13187"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.52221107),
        dec: Angle.Degrees(+61.88429517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17775"},
        {"Hipparcos Number", "HIP 13507"},
        {"Renson", "Renson 4430"},
        {"Smithsonian Astrophysical Observation", "SAO 12498"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.49526146),
        dec: Angle.Degrees(+61.88519473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7103"},
        {"Hipparcos Number", "HIP 5649"},
        {"Geneva Identification System", "GEN# +1.00007103"},
        {"Smithsonian Astrophysical Observation", "SAO 11630"},
        {"Wilson Evans Batten Catalogue", "WEB 1271"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.13655709),
        dec: Angle.Degrees(+61.88561450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7720"},
        {"Hipparcos Number", "HIP 6109"},
        {"Geneva Identification System", "GEN# +1.00007720"},
        {"Smithsonian Astrophysical Observation", "SAO 11684"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.61290159),
        dec: Angle.Degrees(+61.89291945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3499",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3499"},
        {"Geneva Identification System", "GEN# +2.02250003"},
        {"Smithsonian Astrophysical Observation", "SAO 11361"},
        {"New General Catalogue", "NGC 225 3"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.16862338),
        dec: Angle.Degrees(+61.90048926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12208"},
        {"Hipparcos Number", "HIP 9481"},
        {"Geneva Identification System", "GEN# +1.00012208"},
        {"Smithsonian Astrophysical Observation", "SAO 12090"},
        {"Wilson Evans Batten Catalogue", "WEB 1987"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.49603372),
        dec: Angle.Degrees(+61.90506989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181774"},
        {"Hipparcos Number", "HIP 94841"},
        {"Smithsonian Astrophysical Observation", "SAO 18273"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.46448518),
        dec: Angle.Degrees(+61.90580170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7458"},
        {"Hipparcos Number", "HIP 5913"},
        {"Geneva Identification System", "GEN# +1.00007458"},
        {"Smithsonian Astrophysical Observation", "SAO 11666"},
        {"Wilson Evans Batten Catalogue", "WEB 1342"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.01865310),
        dec: Angle.Degrees(+61.90758398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52303",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52303"},
        {"Smithsonian Astrophysical Observation", "SAO 15257"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.30074907),
        dec: Angle.Degrees(+61.90846998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67515",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67515"},
        {"Smithsonian Astrophysical Observation", "SAO 16189"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.51387957),
        dec: Angle.Degrees(+61.90872343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10193",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10193"},
        {"Geneva Identification System", "GEN# +0.06100386"},
        {"Smithsonian Astrophysical Observation", "SAO 12157"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.76468722),
        dec: Angle.Degrees(+61.90889532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201135"},
        {"Hipparcos Number", "HIP 104054"},
        {"Smithsonian Astrophysical Observation", "SAO 19180"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.21310977),
        dec: Angle.Degrees(+61.90902553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210626"},
        {"Hipparcos Number", "HIP 109396"},
        {"Smithsonian Astrophysical Observation", "SAO 19907"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.43757784),
        dec: Angle.Degrees(+61.91013152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13588",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13588"},
        {"Smithsonian Astrophysical Observation", "SAO 12507"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.76377357),
        dec: Angle.Degrees(+61.91048512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40721"},
        {"Hipparcos Number", "HIP 28807"},
        {"Smithsonian Astrophysical Observation", "SAO 13697"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.22658891),
        dec: Angle.Degrees(+61.91080010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3401",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3401"},
        {"Geneva Identification System", "GEN# +0.06100154"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.82605274),
        dec: Angle.Degrees(+61.91115549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213048"},
        {"Hipparcos Number", "HIP 110828"},
        {"Smithsonian Astrophysical Observation", "SAO 20074"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.79544077),
        dec: Angle.Degrees(+61.91239649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20066",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3097 A"},
        {"Henry Draper", "HD 26801"},
        {"Hipparcos Number", "HIP 20066"},
        {"Geneva Identification System", "GEN# +1.00026801A"},
        {"Smithsonian Astrophysical Observation", "SAO 13088"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.54593199),
        dec: Angle.Degrees(+61.91256335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55968"},
        {"Hipparcos Number", "HIP 35452"},
        {"Smithsonian Astrophysical Observation", "SAO 14148"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.78953381),
        dec: Angle.Degrees(+61.91552782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27370",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27370"},
    },
    visualMagnitude: 10.48,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.95659982),
        dec: Angle.Degrees(+61.91649521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221037"},
        {"Hipparcos Number", "HIP 115841"},
        {"Geneva Identification System", "GEN# +2.76541550"},
        {"Smithsonian Astrophysical Observation", "SAO 20648"},
    },
    visualMagnitude: 8.12,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.02419765),
        dec: Angle.Degrees(+61.92034432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109785",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15775 A"},
        {"Henry Draper", "HD 211283"},
        {"Hipparcos Number", "HIP 109785"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.56714440),
        dec: Angle.Degrees(+61.92047048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47005"},
        {"Hipparcos Number", "HIP 31944"},
        {"Smithsonian Astrophysical Observation", "SAO 13917"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.13080485),
        dec: Angle.Degrees(+61.92248382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117034",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117034"},
        {"Geneva Identification System", "GEN# +8.01610027"},
    },
    visualMagnitude: 11.24,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.87749680),
        dec: Angle.Degrees(+61.93004126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83361"},
        {"Hipparcos Number", "HIP 47453"},
        {"Geneva Identification System", "GEN# +1.00083361"},
        {"Smithsonian Astrophysical Observation", "SAO 14957"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.07713529),
        dec: Angle.Degrees(+61.93576014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126551"},
        {"Hipparcos Number", "HIP 70359"},
        {"Smithsonian Astrophysical Observation", "SAO 16365"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.93068141),
        dec: Angle.Degrees(+61.93708626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213870"},
        {"Hipparcos Number", "HIP 111305"},
        {"Smithsonian Astrophysical Observation", "SAO 20144"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.23621266),
        dec: Angle.Degrees(+61.93753666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174016"},
        {"Henry Draper 2", "HD 174017"},
        {"Hipparcos Number", "HIP 91921"},
        {"Geneva Identification System", "GEN# +1.00174016"},
        {"Renson", "Renson 48740"},
        {"Smithsonian Astrophysical Observation", "SAO 17997"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.08824930),
        dec: Angle.Degrees(+61.93872286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45200",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45200"},
        {"Smithsonian Astrophysical Observation", "SAO 14805"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.16518299),
        dec: Angle.Degrees(+61.94145156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208106"},
        {"Hipparcos Number", "HIP 107913"},
        {"Celescope Catalog", "CEL 5397"},
        {"Geneva Identification System", "GEN# +1.00208106"},
        {"Smithsonian Astrophysical Observation", "SAO 19685"},
        {"Wilson Evans Batten Catalogue", "WEB 19459"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.94852338),
        dec: Angle.Degrees(+61.94291513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76592"},
        {"Hipparcos Number", "HIP 44205"},
        {"Smithsonian Astrophysical Observation", "SAO 14735"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.06911721),
        dec: Angle.Degrees(+61.94492203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33566"},
        {"Hipparcos Number", "HIP 24495"},
        {"Smithsonian Astrophysical Observation", "SAO 13428"},
        {"Wilson Evans Batten Catalogue", "WEB 4744"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.83375818),
        dec: Angle.Degrees(+61.94741082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112759",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112759"},
        {"Smithsonian Astrophysical Observation", "SAO 20271"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.54032033),
        dec: Angle.Degrees(+61.94803566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37136"},
        {"Hipparcos Number", "HIP 26700"},
        {"Geneva Identification System", "GEN# +1.00037136"},
        {"Smithsonian Astrophysical Observation", "SAO 13564"},
        {"Wilson Evans Batten Catalogue", "WEB 5264"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.12088115),
        dec: Angle.Degrees(+61.94888797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94861"},
        {"Hipparcos Number", "HIP 53624"},
        {"Geneva Identification System", "GEN# +1.00094861"},
        {"Smithsonian Astrophysical Observation", "SAO 15351"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.56417154),
        dec: Angle.Degrees(+61.95070101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160779"},
        {"Hipparcos Number", "HIP 86275"},
        {"Smithsonian Astrophysical Observation", "SAO 17575"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.42858255),
        dec: Angle.Degrees(+61.95378322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87993"},
        {"Hipparcos Number", "HIP 49851"},
        {"Geneva Identification System", "GEN# +1.00087993"},
        {"Smithsonian Astrophysical Observation", "SAO 15109"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.68069131),
        dec: Angle.Degrees(+61.95766060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92344",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92344"},
        {"Smithsonian Astrophysical Observation", "SAO 18034"},
    },
    visualMagnitude: 9.89,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.30752556),
        dec: Angle.Degrees(+61.95880085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125656"},
        {"Hipparcos Number", "HIP 69927"},
        {"Smithsonian Astrophysical Observation", "SAO 16333"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.65671406),
        dec: Angle.Degrees(+61.95902935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76783",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76783"},
        {"Smithsonian Astrophysical Observation", "SAO 16810"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.15871760),
        dec: Angle.Degrees(+61.95950659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46829",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46829"},
        {"Smithsonian Astrophysical Observation", "SAO 14913"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.13888932),
        dec: Angle.Degrees(+61.96121046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75486"},
        {"Hipparcos Number", "HIP 43644"},
        {"Fundamental Katalog 5th Edition", "FK5 2701"},
        {"Geneva Identification System", "GEN# +1.00075486"},
        {"Renson", "Renson 21133"},
        {"Smithsonian Astrophysical Observation", "SAO 14691"},
        {"Wilson Evans Batten Catalogue", "WEB 8403"},
    },
    visualMagnitude: 5.72,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.34404121),
        dec: Angle.Degrees(+61.96221364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105257",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105257"},
        {"Smithsonian Astrophysical Observation", "SAO 19312"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.81365119),
        dec: Angle.Degrees(+61.96241027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219634"},
        {"Hipparcos Number", "HIP 114904"},
        {"Celescope Catalog", "CEL 5589"},
        {"Geneva Identification System", "GEN# +1.00219634"},
        {"Smithsonian Astrophysical Observation", "SAO 20531"},
        {"Wilson Evans Batten Catalogue", "WEB 20361"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.11271050),
        dec: Angle.Degrees(+61.96295136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49182",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49182"},
        {"Smithsonian Astrophysical Observation", "SAO 15050"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.56629841),
        dec: Angle.Degrees(+61.96447795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220074"},
        {"Hipparcos Number", "HIP 115218"},
        {"Smithsonian Astrophysical Observation", "SAO 20567"},
        {"Wilson Evans Batten Catalogue", "WEB 20410"},
        {"New General Catalogue", "NGC 7654 228"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.05987570),
        dec: Angle.Degrees(+61.97014046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41748",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41748"},
        {"Smithsonian Astrophysical Observation", "SAO 14574"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.69421609),
        dec: Angle.Degrees(+61.97267604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65110",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65110"},
        {"Smithsonian Astrophysical Observation", "SAO 16053"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.15100672),
        dec: Angle.Degrees(+61.97358854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209453"},
        {"Hipparcos Number", "HIP 108718"},
        {"Smithsonian Astrophysical Observation", "SAO 19800"},
        {"Wilson Evans Batten Catalogue", "WEB 19563"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.34621480),
        dec: Angle.Degrees(+61.97383548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179755"},
        {"Hipparcos Number", "HIP 94143"},
        {"Smithsonian Astrophysical Observation", "SAO 18182"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.44373643),
        dec: Angle.Degrees(+61.97666059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76300",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76300"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.79644855),
        dec: Angle.Degrees(+61.97916471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175287"},
        {"Hipparcos Number", "HIP 92461"},
        {"Smithsonian Astrophysical Observation", "SAO 18042"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.64714800),
        dec: Angle.Degrees(+61.98151822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108170",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108170"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.73068500),
        dec: Angle.Degrees(+61.98826670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -171.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224403"},
        {"Hipparcos Number", "HIP 118112"},
        {"Celescope Catalog", "CEL 5723"},
        {"Geneva Identification System", "GEN# +1.00224403"},
        {"Smithsonian Astrophysical Observation", "SAO 20957"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.38550740),
        dec: Angle.Degrees(+61.99131179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11471"},
        {"Hipparcos Number", "HIP 8912"},
        {"Geneva Identification System", "GEN# +1.00011471"},
        {"Smithsonian Astrophysical Observation", "SAO 12033"},
        {"Wilson Evans Batten Catalogue", "WEB 1873"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.67996129),
        dec: Angle.Degrees(+61.99147309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191277"},
        {"Hipparcos Number", "HIP 98962"},
        {"Fundamental Katalog 5th Edition", "FK5 3612"},
        {"Geneva Identification System", "GEN# +1.00191277"},
        {"Smithsonian Astrophysical Observation", "SAO 18700"},
        {"Wilson Evans Batten Catalogue", "WEB 17572"},
    },
    visualMagnitude: 5.40,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.38635475),
        dec: Angle.Degrees(+61.99524822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158652"},
        {"Hipparcos Number", "HIP 85349"},
        {"Smithsonian Astrophysical Observation", "SAO 17485"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.61375180),
        dec: Angle.Degrees(+61.99828323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20536"},
        {"Hipparcos Number", "HIP 15634"},
        {"Geneva Identification System", "GEN# +1.00020536"},
        {"Smithsonian Astrophysical Observation", "SAO 12716"},
        {"Wilson Evans Batten Catalogue", "WEB 2998"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.32937881),
        dec: Angle.Degrees(+61.99921551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205434"},
        {"Hipparcos Number", "HIP 106400"},
        {"Smithsonian Astrophysical Observation", "SAO 19487"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.25253434),
        dec: Angle.Degrees(+62.00197884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 370.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 194.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208581"},
        {"Hipparcos Number", "HIP 108179"},
        {"Smithsonian Astrophysical Observation", "SAO 19734"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.75718566),
        dec: Angle.Degrees(+62.00910717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24653",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24653"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.34761281),
        dec: Angle.Degrees(+62.01373423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196805"},
        {"Hipparcos Number", "HIP 101659"},
        {"Celescope Catalog", "CEL 5128"},
        {"Geneva Identification System", "GEN# +1.00196805"},
        {"Smithsonian Astrophysical Observation", "SAO 18943"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.10035185),
        dec: Angle.Degrees(+62.01443826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66658",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66658"},
        {"Smithsonian Astrophysical Observation", "SAO 16136"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.97275470),
        dec: Angle.Degrees(+62.01526993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118056",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118056"},
        {"Geneva Identification System", "GEN# +0.06102569"},
        {"Smithsonian Astrophysical Observation", "SAO 20950"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.23084463),
        dec: Angle.Degrees(+62.01651840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224892"},
        {"Hipparcos Number", "HIP 131"},
        {"Geneva Identification System", "GEN# +1.00224892"},
        {"Smithsonian Astrophysical Observation", "SAO 21011"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.41994220),
        dec: Angle.Degrees(+62.01815066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42680",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42680"},
        {"Smithsonian Astrophysical Observation", "SAO 14629"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.49091897),
        dec: Angle.Degrees(+62.01899207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42683",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42683"},
        {"Smithsonian Astrophysical Observation", "SAO 14630"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.49626826),
        dec: Angle.Degrees(+62.02342966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16091",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16091"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.81749499),
        dec: Angle.Degrees(+62.02536505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206923"},
        {"Hipparcos Number", "HIP 107234"},
        {"Smithsonian Astrophysical Observation", "SAO 19598"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.77376409),
        dec: Angle.Degrees(+62.03211192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27493"},
        {"Hipparcos Number", "HIP 20548"},
        {"Geneva Identification System", "GEN# +1.00027493"},
        {"Smithsonian Astrophysical Observation", "SAO 13130"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.04160551),
        dec: Angle.Degrees(+62.03260446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68164"},
        {"Hipparcos Number", "HIP 40390"},
        {"Smithsonian Astrophysical Observation", "SAO 14470"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.69604431),
        dec: Angle.Degrees(+62.03664244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 861"},
        {"Hipparcos Number", "HIP 1063"},
        {"Celescope Catalog", "CEL 43"},
        {"Geneva Identification System", "GEN# +1.00000861"},
        {"Renson", "Renson 130"},
        {"Smithsonian Astrophysical Observation", "SAO 11044"},
        {"Wilson Evans Batten Catalogue", "WEB 183"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.30266797),
        dec: Angle.Degrees(+62.04092419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113994"},
        {"Hipparcos Number", "HIP 63952"},
        {"Geneva Identification System", "GEN# +1.00113994"},
        {"Smithsonian Astrophysical Observation", "SAO 15985"},
        {"Wilson Evans Batten Catalogue", "WEB 11306"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.59525880),
        dec: Angle.Degrees(+62.04197396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110346"},
        {"Hipparcos Number", "HIP 61876"},
        {"Smithsonian Astrophysical Observation", "SAO 15865"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.20355148),
        dec: Angle.Degrees(+62.04256440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64018"},
        {"Hipparcos Number", "HIP 38709"},
        {"Geneva Identification System", "GEN# +1.00064018"},
        {"Smithsonian Astrophysical Observation", "SAO 14368"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.87804776),
        dec: Angle.Degrees(+62.04390479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137389"},
        {"Hipparcos Number", "HIP 75256"},
        {"Geneva Identification System", "GEN# +1.00137389"},
        {"Renson", "Renson 39050"},
        {"Smithsonian Astrophysical Observation", "SAO 16712"},
        {"Wilson Evans Batten Catalogue", "WEB 12836"},
    },
    visualMagnitude: 5.99,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.65519206),
        dec: Angle.Degrees(+62.04716944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215009"},
        {"Hipparcos Number", "HIP 111970"},
        {"Smithsonian Astrophysical Observation", "SAO 20202"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.21281626),
        dec: Angle.Degrees(+62.04818469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96180",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12626 AB"},
        {"Henry Draper", "HD 185013"},
        {"Hipparcos Number", "HIP 96180"},
        {"Smithsonian Astrophysical Observation", "SAO 18398"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.34349594),
        dec: Angle.Degrees(+62.05316832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107611",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15339 AB"},
        {"Henry Draper", "HD 207577"},
        {"Hipparcos Number", "HIP 107611"},
        {"Smithsonian Astrophysical Observation", "SAO 19649"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.93912676),
        dec: Angle.Degrees(+62.05674959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62581",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62581"},
        {"Smithsonian Astrophysical Observation", "SAO 15913"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.34777544),
        dec: Angle.Degrees(+62.06067576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2535"},
        {"Hipparcos Number", "HIP 2320"},
        {"Geneva Identification System", "GEN# +1.00002535"},
        {"Smithsonian Astrophysical Observation", "SAO 11225"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.40026334),
        dec: Angle.Degrees(+62.06416651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1544"},
        {"Hipparcos Number", "HIP 1605"},
        {"Celescope Catalog", "CEL 56"},
        {"Geneva Identification System", "GEN# +1.00001544"},
        {"Smithsonian Astrophysical Observation", "SAO 11116"},
        {"Wilson Evans Batten Catalogue", "WEB 291"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.02310041),
        dec: Angle.Degrees(+62.06630889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58665",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58665"},
    },
    visualMagnitude: 11.30,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.43799233),
        dec: Angle.Degrees(+62.06696654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28175"},
        {"Hipparcos Number", "HIP 21037"},
        {"Geneva Identification System", "GEN# +1.00028175"},
        {"Smithsonian Astrophysical Observation", "SAO 13166"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.65730168),
        dec: Angle.Degrees(+62.06987053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22033",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22033"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.05326424),
        dec: Angle.Degrees(+62.07555577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99257",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13449 AB"},
        {"Henry Draper", "HD 191940"},
        {"Hipparcos Number", "HIP 99257"},
        {"Celescope Catalog", "CEL 4953"},
        {"Geneva Identification System", "GEN# +1.00191940J"},
        {"Smithsonian Astrophysical Observation", "SAO 18732"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.23665341),
        dec: Angle.Degrees(+62.07666850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118078",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118078"},
        {"Geneva Identification System", "GEN# +0.06102571"},
        {"Smithsonian Astrophysical Observation", "SAO 20952"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.28841668),
        dec: Angle.Degrees(+62.07774478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192455"},
        {"Hipparcos Number", "HIP 99500"},
        {"Geneva Identification System", "GEN# +1.00192455"},
        {"Smithsonian Astrophysical Observation", "SAO 18751"},
        {"Wilson Evans Batten Catalogue", "WEB 17795"},
    },
    visualMagnitude: 5.70,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.89476753),
        dec: Angle.Degrees(+62.07834754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114815",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114815"},
        {"Geneva Identification System", "GEN# +0.06102408"},
        {"Smithsonian Astrophysical Observation", "SAO 20516"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.802,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.86635434),
        dec: Angle.Degrees(+62.07905116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206165"},
        {"Hipparcos Number", "HIP 106801"},
        {"Celescope Catalog", "CEL 5356"},
        {"Fundamental Katalog 5th Edition", "FK5 3725"},
        {"Geneva Identification System", "GEN# +1.00206165"},
        {"Smithsonian Astrophysical Observation", "SAO 19541"},
        {"Wilson Evans Batten Catalogue", "WEB 19308"},
    },
    visualMagnitude: 4.76,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.48011167),
        dec: Angle.Degrees(+62.08194667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80781",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80781"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.41590648),
        dec: Angle.Degrees(+62.08703343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144108"},
        {"Hipparcos Number", "HIP 78422"},
        {"Smithsonian Astrophysical Observation", "SAO 16922"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.14947928),
        dec: Angle.Degrees(+62.08719581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83238"},
        {"Hipparcos Number", "HIP 47402"},
        {"Smithsonian Astrophysical Observation", "SAO 14952"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.86684328),
        dec: Angle.Degrees(+62.08759762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113680",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113680"},
        {"Geneva Identification System", "GEN# +9.00020064"},
        {"Smithsonian Astrophysical Observation", "SAO 20370"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.37237152),
        dec: Angle.Degrees(+62.08942655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48657"},
        {"Hipparcos Number", "HIP 32652"},
        {"Smithsonian Astrophysical Observation", "SAO 13959"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.16625072),
        dec: Angle.Degrees(+62.09339467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100298"},
        {"Hipparcos Number", "HIP 56351"},
        {"Smithsonian Astrophysical Observation", "SAO 15549"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.26573255),
        dec: Angle.Degrees(+62.09354169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8036",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8036"},
        {"Geneva Identification System", "GEN# +0.06100314"},
        {"Geneva Identification System 2", "GEN# +2.06540307"},
        {"Smithsonian Astrophysical Observation", "SAO 11937"},
        {"Wilson Evans Batten Catalogue", "WEB 1721"},
        {"New General Catalogue", "NGC 654 307"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.79756832),
        dec: Angle.Degrees(+62.09409348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178156"},
        {"Hipparcos Number", "HIP 93571"},
        {"Geneva Identification System", "GEN# +1.00178156"},
        {"Smithsonian Astrophysical Observation", "SAO 18133"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.86985837),
        dec: Angle.Degrees(+62.09452399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56512"},
        {"Hipparcos Number", "HIP 35632"},
        {"Smithsonian Astrophysical Observation", "SAO 14161"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.29452235),
        dec: Angle.Degrees(+62.09570771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204721"},
        {"Hipparcos Number", "HIP 105998"},
        {"Smithsonian Astrophysical Observation", "SAO 19433"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.02075426),
        dec: Angle.Degrees(+62.09650113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138524"},
        {"Hipparcos Number", "HIP 75822"},
        {"Geneva Identification System", "GEN# +1.00138524"},
        {"Smithsonian Astrophysical Observation", "SAO 16746"},
        {"Wilson Evans Batten Catalogue", "WEB 12907"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.33804150),
        dec: Angle.Degrees(+62.09955096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153344"},
        {"Hipparcos Number", "HIP 82750"},
        {"Cincinnati Publication", "Ci 18 2260"},
        {"Geneva Identification System", "GEN# +1.00153344"},
        {"Smithsonian Astrophysical Observation", "SAO 17271"},
        {"Wilson Evans Batten Catalogue", "WEB 13988"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.69329418),
        dec: Angle.Degrees(+62.10006641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -332.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25443"},
        {"Hipparcos Number", "HIP 19139"},
        {"Fundamental Katalog 5th Edition", "FK5 4371"},
        {"Geneva Identification System", "GEN# +1.00025443"},
        {"Smithsonian Astrophysical Observation", "SAO 13012"},
        {"Wilson Evans Batten Catalogue", "WEB 3675"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.53360278),
        dec: Angle.Degrees(+62.10183610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43793"},
        {"Hipparcos Number", "HIP 30298"},
        {"Smithsonian Astrophysical Observation", "SAO 13820"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.59503834),
        dec: Angle.Degrees(+62.10399030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90141"},
        {"Hipparcos Number", "HIP 51066"},
        {"Geneva Identification System", "GEN# +1.00090141"},
        {"Smithsonian Astrophysical Observation", "SAO 15175"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.51545192),
        dec: Angle.Degrees(+62.10587492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99455"},
        {"Hipparcos Number", "HIP 55881"},
        {"Smithsonian Astrophysical Observation", "SAO 15510"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.80607450),
        dec: Angle.Degrees(+62.11127031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117707",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117707"},
        {"Celescope Catalog", "CEL 5698"},
        {"Geneva Identification System", "GEN# +0.06102550"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.08142864),
        dec: Angle.Degrees(+62.11850176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103772",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103772"},
        {"Smithsonian Astrophysical Observation", "SAO 19154"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.42577488),
        dec: Angle.Degrees(+62.12171027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104366",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104366"},
        {"Smithsonian Astrophysical Observation", "SAO 19217"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.14144983),
        dec: Angle.Degrees(+62.12227545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136815"},
        {"Hipparcos Number", "HIP 74998"},
        {"Smithsonian Astrophysical Observation", "SAO 16688"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.86893445),
        dec: Angle.Degrees(+62.12854054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86025"},
        {"Hipparcos Number", "HIP 48872"},
        {"Smithsonian Astrophysical Observation", "SAO 15035"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.51591106),
        dec: Angle.Degrees(+62.12965756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40467",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40467"},
        {"Smithsonian Astrophysical Observation", "SAO 14477"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.94225126),
        dec: Angle.Degrees(+62.13233051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115424",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115424"},
        {"Geneva Identification System", "GEN# +8.03610032"},
        {"Geneva Identification System 2", "GEN# +2.76540568"},
        {"Wilson Evans Batten Catalogue", "WEB 20439"},
        {"New General Catalogue", "NGC 7654 568"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.71140083),
        dec: Angle.Degrees(+62.13438388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116687",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16898 A"},
        {"Henry Draper", "HD 222275"},
        {"Hipparcos Number", "HIP 116687"},
        {"Geneva Identification System", "GEN# +1.00222275"},
        {"Renson", "Renson 60927"},
        {"Smithsonian Astrophysical Observation", "SAO 20745"},
        {"Wilson Evans Batten Catalogue", "WEB 20593"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.70462390),
        dec: Angle.Degrees(+62.13496945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53711"},
        {"Hipparcos Number", "HIP 34615"},
        {"Smithsonian Astrophysical Observation", "SAO 14101"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.53617321),
        dec: Angle.Degrees(+62.13593569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63791"},
        {"Hipparcos Number", "HIP 38621"},
        {"Geneva Identification System", "GEN# +1.00063791"},
        {"Smithsonian Astrophysical Observation", "SAO 14359"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.61992348),
        dec: Angle.Degrees(+62.13653507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54943"},
        {"Hipparcos Number", "HIP 35049"},
        {"Geneva Identification System", "GEN# +1.00054943"},
        {"Smithsonian Astrophysical Observation", "SAO 14126"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.72544542),
        dec: Angle.Degrees(+62.13680580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193534"},
        {"Hipparcos Number", "HIP 100007"},
        {"Smithsonian Astrophysical Observation", "SAO 18793"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.33584156),
        dec: Angle.Degrees(+62.13816918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113017",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16341 A"},
        {"Henry Draper", "HD 216629"},
        {"Henry Draper 2", "HD 216629A"},
        {"Hipparcos Number", "HIP 113017"},
        {"Smithsonian Astrophysical Observation", "SAO 20299"},
    },
    visualMagnitude: 9.34,
    bvColour: -0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.31502200),
        dec: Angle.Degrees(+62.14584012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32185"},
        {"Hipparcos Number", "HIP 23677"},
        {"Smithsonian Astrophysical Observation", "SAO 13363"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.34328994),
        dec: Angle.Degrees(+62.14800660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9383"},
        {"Hipparcos Number", "HIP 7291"},
        {"Geneva Identification System", "GEN# +1.00009383"},
        {"Renson", "Renson 2260"},
        {"Smithsonian Astrophysical Observation", "SAO 11831"},
        {"Wilson Evans Batten Catalogue", "WEB 1571"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.48211907),
        dec: Angle.Degrees(+62.14979421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11004"},
        {"Hipparcos Number", "HIP 8529"},
        {"Fundamental Katalog 5th Edition", "FK5 4167"},
        {"Geneva Identification System", "GEN# +1.00011004"},
        {"Smithsonian Astrophysical Observation", "SAO 12003"},
        {"Wilson Evans Batten Catalogue", "WEB 1814"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.49741849),
        dec: Angle.Degrees(+62.15100630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91203",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91203"},
        {"Smithsonian Astrophysical Observation", "SAO 17944"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.07854854),
        dec: Angle.Degrees(+62.15257445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190490"},
        {"Hipparcos Number", "HIP 98602"},
        {"Smithsonian Astrophysical Observation", "SAO 18657"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.41748557),
        dec: Angle.Degrees(+62.15313752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132069"},
        {"Hipparcos Number", "HIP 72924"},
        {"Smithsonian Astrophysical Observation", "SAO 16545"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.56033979),
        dec: Angle.Degrees(+62.15345396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31614"},
        {"Hipparcos Number", "HIP 23357"},
        {"Fundamental Katalog 5th Edition", "FK5 4459"},
        {"Smithsonian Astrophysical Observation", "SAO 13339"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.34128446),
        dec: Angle.Degrees(+62.15468403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14011",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14011"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.09199381),
        dec: Angle.Degrees(+62.15483819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143186"},
        {"Hipparcos Number", "HIP 77969"},
        {"Smithsonian Astrophysical Observation", "SAO 16895"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.84607853),
        dec: Angle.Degrees(+62.15526105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199305"},
        {"Hipparcos Number", "HIP 103096"},
        {"Cincinnati Publication", "Ci 18 2707"},
        {"Cincinnati Publication 2", "Ci 20 1238"},
        {"Geneva Identification System", "GEN# +1.00199305"},
        {"Wilson Evans Batten Catalogue", "WEB 18720"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.33245263),
        dec: Angle.Degrees(+62.15627228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -774.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8794",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8794"},
        {"Smithsonian Astrophysical Observation", "SAO 12021"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.26638188),
        dec: Angle.Degrees(+62.15867140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201267"},
        {"Hipparcos Number", "HIP 104110"},
        {"Celescope Catalog", "CEL 5245"},
        {"Geneva Identification System", "GEN# +1.00201267J"},
        {"Smithsonian Astrophysical Observation", "SAO 19188"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.38504493),
        dec: Angle.Degrees(+62.15885958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210593"},
        {"Hipparcos Number", "HIP 109379"},
        {"Smithsonian Astrophysical Observation", "SAO 19904"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.37399412),
        dec: Angle.Degrees(+62.15966751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71811",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71811"},
        {"Smithsonian Astrophysical Observation", "SAO 16464"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.33889716),
        dec: Angle.Degrees(+62.16702708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38045",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38045"},
    },
    visualMagnitude: 10.68,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.98182898),
        dec: Angle.Degrees(+62.16982062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154941"},
        {"Hipparcos Number", "HIP 83550"},
        {"Smithsonian Astrophysical Observation", "SAO 17340"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.13336774),
        dec: Angle.Degrees(+62.17220511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79471",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79471"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.27878122),
        dec: Angle.Degrees(+62.17321688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31334",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31334"},
        {"Smithsonian Astrophysical Observation", "SAO 13880"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.55836078),
        dec: Angle.Degrees(+62.17455540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224792"},
        {"Hipparcos Number", "HIP 58"},
        {"Celescope Catalog", "CEL 5745"},
        {"Geneva Identification System", "GEN# +1.00224792"},
        {"Smithsonian Astrophysical Observation", "SAO 20994"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.17376341),
        dec: Angle.Degrees(+62.17600484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161673"},
        {"Hipparcos Number", "HIP 86687"},
        {"Smithsonian Astrophysical Observation", "SAO 17611"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.68158481),
        dec: Angle.Degrees(+62.17605508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111706",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111706"},
        {"Smithsonian Astrophysical Observation", "SAO 20183"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.42895148),
        dec: Angle.Degrees(+62.17710123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121522"},
        {"Hipparcos Number", "HIP 67854"},
        {"Smithsonian Astrophysical Observation", "SAO 16208"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.47830583),
        dec: Angle.Degrees(+62.18029490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60652",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60652"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.47277723),
        dec: Angle.Degrees(+62.18209941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -327.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98261"},
        {"Hipparcos Number", "HIP 55256"},
        {"Geneva Identification System", "GEN# +1.00098261"},
        {"Smithsonian Astrophysical Observation", "SAO 15472"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.76497523),
        dec: Angle.Degrees(+62.18261186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1743"},
        {"Hipparcos Number", "HIP 1743"},
        {"Celescope Catalog", "CEL 65"},
        {"Geneva Identification System", "GEN# +1.00001743"},
        {"Smithsonian Astrophysical Observation", "SAO 11140"},
        {"Wilson Evans Batten Catalogue", "WEB 314"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.51425909),
        dec: Angle.Degrees(+62.18508471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75680"},
        {"Hipparcos Number", "HIP 43744"},
        {"Smithsonian Astrophysical Observation", "SAO 14695"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.64666191),
        dec: Angle.Degrees(+62.18626085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102988",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102988"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.99393109),
        dec: Angle.Degrees(+62.18783991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 115.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29944",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29944"},
        {"Smithsonian Astrophysical Observation", "SAO 13791"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.56388596),
        dec: Angle.Degrees(+62.19289676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100933"},
        {"Hipparcos Number", "HIP 56686"},
        {"Smithsonian Astrophysical Observation", "SAO 15571"},
        {"Wilson Evans Batten Catalogue", "WEB 10191"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.35229055),
        dec: Angle.Degrees(+62.19636026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1010"},
        {"Hipparcos Number", "HIP 1184"},
        {"Geneva Identification System", "GEN# +1.00001010"},
        {"Smithsonian Astrophysical Observation", "SAO 11061"},
        {"Wilson Evans Batten Catalogue", "WEB 210"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.69901875),
        dec: Angle.Degrees(+62.19636772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43016"},
        {"Hipparcos Number", "HIP 29947"},
        {"Smithsonian Astrophysical Observation", "SAO 13792"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.56673069),
        dec: Angle.Degrees(+62.19770680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1400"},
        {"Hipparcos Number", "HIP 1486"},
        {"Geneva Identification System", "GEN# +1.00001400"},
        {"Smithsonian Astrophysical Observation", "SAO 11095"},
        {"Wilson Evans Batten Catalogue", "WEB 273"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.61992860),
        dec: Angle.Degrees(+62.20280486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83500",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83500"},
        {"Smithsonian Astrophysical Observation", "SAO 17336"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.98690618),
        dec: Angle.Degrees(+62.20703306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 111.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73483"},
        {"Hipparcos Number", "HIP 42677"},
        {"Smithsonian Astrophysical Observation", "SAO 14627"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.47529689),
        dec: Angle.Degrees(+62.21038779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118148",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118148"},
        {"Geneva Identification System", "GEN# +0.06102574"},
        {"Smithsonian Astrophysical Observation", "SAO 20962"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.48604045),
        dec: Angle.Degrees(+62.21100193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92633"},
        {"Hipparcos Number", "HIP 52451"},
        {"Smithsonian Astrophysical Observation", "SAO 15270"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.83445770),
        dec: Angle.Degrees(+62.21242642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115245",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16690 A"},
        {"Henry Draper", "HD 220130"},
        {"Hipparcos Number", "HIP 115245"},
        {"Geneva Identification System", "GEN# +2.76540265"},
        {"Smithsonian Astrophysical Observation", "SAO 20572"},
        {"Wilson Evans Batten Catalogue", "WEB 20416"},
        {"New General Catalogue", "NGC 7654 265"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.14390747),
        dec: Angle.Degrees(+62.21326651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223501"},
        {"Hipparcos Number", "HIP 117514"},
        {"Celescope Catalog", "CEL 5687"},
        {"Fundamental Katalog 5th Edition", "FK5 6111"},
        {"Geneva Identification System", "GEN# +1.00223501"},
        {"Smithsonian Astrophysical Observation", "SAO 20881"},
        {"Wilson Evans Batten Catalogue", "WEB 20696"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.47135882),
        dec: Angle.Degrees(+62.21409935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117447",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17022 AB"},
        {"Henry Draper", "HD 223385"},
        {"Hipparcos Number", "HIP 117447"},
        {"Celescope Catalog", "CEL 5682"},
        {"Geneva Identification System", "GEN# +1.00223385"},
        {"Smithsonian Astrophysical Observation", "SAO 20869"},
        {"Wilson Evans Batten Catalogue", "WEB 20685"},
    },
    visualMagnitude: 5.43,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.20906201),
        dec: Angle.Degrees(+62.21451996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14510"},
        {"Hipparcos Number", "HIP 11118"},
        {"Smithsonian Astrophysical Observation", "SAO 12258"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.75320539),
        dec: Angle.Degrees(+62.21657652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15069"},
        {"Hipparcos Number", "HIP 11505"},
        {"Geneva Identification System", "GEN# +3.17950177"},
        {"Smithsonian Astrophysical Observation", "SAO 12295"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.08541823),
        dec: Angle.Degrees(+62.21889780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 171.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29287",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29287"},
        {"Smithsonian Astrophysical Observation", "SAO 13741"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.62137381),
        dec: Angle.Degrees(+62.22101797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -206.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225160"},
        {"Hipparcos Number", "HIP 319"},
        {"Celescope Catalog", "CEL 9"},
        {"Geneva Identification System", "GEN# +1.00225160"},
        {"Smithsonian Astrophysical Observation", "SAO 10952"},
        {"Wilson Evans Batten Catalogue", "WEB 46"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.01581829),
        dec: Angle.Degrees(+62.22195138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114504"},
        {"Hipparcos Number", "HIP 64231"},
        {"Fundamental Katalog 5th Edition", "FK5 3050"},
        {"Geneva Identification System", "GEN# +1.00114504"},
        {"Smithsonian Astrophysical Observation", "SAO 15999"},
        {"Wilson Evans Batten Catalogue", "WEB 11355"},
    },
    visualMagnitude: 6.52,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.45921331),
        dec: Angle.Degrees(+62.22914214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49158"},
        {"Hipparcos Number", "HIP 32889"},
        {"Smithsonian Astrophysical Observation", "SAO 13980"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.79317137),
        dec: Angle.Degrees(+62.22974996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21695"},
        {"Hipparcos Number", "HIP 16573"},
        {"Smithsonian Astrophysical Observation", "SAO 12807"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.33871100),
        dec: Angle.Degrees(+62.22997373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103794"},
        {"Hipparcos Number", "HIP 58296"},
        {"Geneva Identification System", "GEN# +1.00103794"},
        {"Smithsonian Astrophysical Observation", "SAO 15668"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.32395326),
        dec: Angle.Degrees(+62.23104504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27188",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27188"},
        {"Geneva Identification System", "GEN# +0.06200780"},
        {"Wilson Evans Batten Catalogue", "WEB 5346"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.44959614),
        dec: Angle.Degrees(+62.23868581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 297.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -785.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1805",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 307 A"},
        {"Henry Draper", "HD 1810"},
        {"Hipparcos Number", "HIP 1805"},
        {"Celescope Catalog", "CEL 67"},
        {"Geneva Identification System", "GEN# +1.00001810"},
        {"Smithsonian Astrophysical Observation", "SAO 11149"},
        {"Wilson Evans Batten Catalogue", "WEB 322"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.72225424),
        dec: Angle.Degrees(+62.24138839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9116",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9116"},
        {"Geneva Identification System", "GEN# +0.06100358"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.37699154),
        dec: Angle.Degrees(+62.24537339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27174"},
        {"Hipparcos Number", "HIP 20334"},
        {"Geneva Identification System", "GEN# +1.00027174"},
        {"Smithsonian Astrophysical Observation", "SAO 13105"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.34561394),
        dec: Angle.Degrees(+62.24599470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49847",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49847"},
        {"Smithsonian Astrophysical Observation", "SAO 15108"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.66687142),
        dec: Angle.Degrees(+62.25075604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16799"},
        {"Hipparcos Number", "HIP 12793"},
        {"Smithsonian Astrophysical Observation", "SAO 12419"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.10393908),
        dec: Angle.Degrees(+62.25678942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193964"},
        {"Hipparcos Number", "HIP 100221"},
        {"Geneva Identification System", "GEN# +1.00193964"},
        {"Smithsonian Astrophysical Observation", "SAO 18807"},
        {"Wilson Evans Batten Catalogue", "WEB 18061"},
    },
    visualMagnitude: 5.71,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.90290698),
        dec: Angle.Degrees(+62.25741351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5702"},
        {"Hipparcos Number", "HIP 4650"},
        {"Geneva Identification System", "GEN# +1.00005702"},
        {"Smithsonian Astrophysical Observation", "SAO 11511"},
        {"Wilson Evans Batten Catalogue", "WEB 870"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.93571433),
        dec: Angle.Degrees(+62.25911903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212351"},
        {"Hipparcos Number", "HIP 110409"},
        {"Smithsonian Astrophysical Observation", "SAO 20031"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.46278749),
        dec: Angle.Degrees(+62.26168886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210040"},
        {"Hipparcos Number", "HIP 109054"},
        {"Geneva Identification System", "GEN# +1.00210040"},
        {"Smithsonian Astrophysical Observation", "SAO 19858"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.38501203),
        dec: Angle.Degrees(+62.26171681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77349"},
        {"Hipparcos Number", "HIP 44587"},
        {"Smithsonian Astrophysical Observation", "SAO 14753"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.25388376),
        dec: Angle.Degrees(+62.26174453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54318"},
        {"Hipparcos Number", "HIP 34825"},
        {"Smithsonian Astrophysical Observation", "SAO 14112"},
    },
    visualMagnitude: 7.58,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.11657333),
        dec: Angle.Degrees(+62.26252892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14558",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14558"},
        {"Smithsonian Astrophysical Observation", "SAO 12614"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.99043599),
        dec: Angle.Degrees(+62.26453581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88592",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11073 AB"},
        {"Henry Draper", "HD 166206"},
        {"Hipparcos Number", "HIP 88592"},
        {"Smithsonian Astrophysical Observation", "SAO 17751"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.33898681),
        dec: Angle.Degrees(+62.26627290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21577"},
        {"Hipparcos Number", "HIP 16471"},
        {"Smithsonian Astrophysical Observation", "SAO 12799"},
        {"Wilson Evans Batten Catalogue", "WEB 3145"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.03591348),
        dec: Angle.Degrees(+62.26798979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122967"},
        {"Hipparcos Number", "HIP 68623"},
        {"Smithsonian Astrophysical Observation", "SAO 16260"},
        {"Wilson Evans Batten Catalogue", "WEB 12016"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.71116272),
        dec: Angle.Degrees(+62.27001886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194666"},
        {"Hipparcos Number", "HIP 100565"},
        {"Smithsonian Astrophysical Observation", "SAO 18842"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.88368251),
        dec: Angle.Degrees(+62.27111560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 105.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41673",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41673"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.43991225),
        dec: Angle.Degrees(+62.27255051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19276",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19276"},
        {"New General Catalogue", "NGC 1502 23"},
    },
    visualMagnitude: 10.75,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.96565443),
        dec: Angle.Degrees(+62.27489879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138245"},
        {"Hipparcos Number", "HIP 75678"},
        {"Geneva Identification System", "GEN# +1.00138245"},
        {"Smithsonian Astrophysical Observation", "SAO 16740"},
        {"Wilson Evans Batten Catalogue", "WEB 12885"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.91979975),
        dec: Angle.Degrees(+62.27574362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76272",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76272"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.68971115),
        dec: Angle.Degrees(+62.27892800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -255.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109017",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15624 A"},
        {"Henry Draper", "HD 209975"},
        {"Hipparcos Number", "HIP 109017"},
        {"Celescope Catalog", "CEL 5432"},
        {"Geneva Identification System", "GEN# +1.00209975A"},
        {"Smithsonian Astrophysical Observation", "SAO 19849"},
        {"Wilson Evans Batten Catalogue", "WEB 19604"},
    },
    visualMagnitude: 5.07,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.28663039),
        dec: Angle.Degrees(+62.27982101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97486"},
        {"Hipparcos Number", "HIP 54869"},
        {"Geneva Identification System", "GEN# +1.00097486"},
        {"Smithsonian Astrophysical Observation", "SAO 15444"},
        {"Wilson Evans Batten Catalogue", "WEB 9901"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.51929898),
        dec: Angle.Degrees(+62.28213619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220652"},
        {"Hipparcos Number", "HIP 115590"},
        {"Fundamental Katalog 5th Edition", "FK5 882"},
        {"Geneva Identification System", "GEN# +2.76540923"},
        {"Smithsonian Astrophysical Observation", "SAO 20614"},
        {"Wilson Evans Batten Catalogue", "WEB 20461"},
        {"New General Catalogue", "NGC 7654 923"},
    },
    visualMagnitude: 4.96,
    bvColour: 1.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.20936267),
        dec: Angle.Degrees(+62.28283877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131568"},
        {"Hipparcos Number", "HIP 72669"},
        {"Smithsonian Astrophysical Observation", "SAO 16529"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.86905954),
        dec: Angle.Degrees(+62.28334310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22668"},
        {"Hipparcos Number", "HIP 17293"},
        {"Smithsonian Astrophysical Observation", "SAO 12877"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.53446017),
        dec: Angle.Degrees(+62.28540018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225180"},
        {"Hipparcos Number", "HIP 330"},
        {"Celescope Catalog", "CEL 10"},
        {"Geneva Identification System", "GEN# +1.00225180"},
        {"Smithsonian Astrophysical Observation", "SAO 10954"},
        {"Wilson Evans Batten Catalogue", "WEB 47"},
    },
    visualMagnitude: 5.90,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.05693212),
        dec: Angle.Degrees(+62.28766460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221334"},
        {"Hipparcos Number", "HIP 116044"},
        {"Celescope Catalog", "CEL 5625"},
        {"Geneva Identification System", "GEN# +2.76541856"},
        {"Smithsonian Astrophysical Observation", "SAO 20673"},
        {"New General Catalogue", "NGC 7654 1856"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.70496546),
        dec: Angle.Degrees(+62.28865037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9003",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9003"},
        {"Geneva Identification System", "GEN# +8.01620194"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.98037716),
        dec: Angle.Degrees(+62.29901355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70177"},
        {"Hipparcos Number", "HIP 41180"},
        {"Smithsonian Astrophysical Observation", "SAO 14531"},
    },
    visualMagnitude: 7.68,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.05066997),
        dec: Angle.Degrees(+62.30031789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163241"},
        {"Hipparcos Number", "HIP 87356"},
        {"Smithsonian Astrophysical Observation", "SAO 17655"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.74660776),
        dec: Angle.Degrees(+62.30130307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71765",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71765"},
        {"Smithsonian Astrophysical Observation", "SAO 16462"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.18723317),
        dec: Angle.Degrees(+62.30345809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206078"},
        {"Hipparcos Number", "HIP 106730"},
        {"Geneva Identification System", "GEN# +1.00206078"},
        {"Smithsonian Astrophysical Observation", "SAO 19528"},
        {"Wilson Evans Batten Catalogue", "WEB 19297"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.29319768),
        dec: Angle.Degrees(+62.30396468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 115.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216898"},
        {"Hipparcos Number", "HIP 113218"},
        {"Celescope Catalog", "CEL 5543"},
        {"Geneva Identification System", "GEN# +9.00020031"},
        {"Smithsonian Astrophysical Observation", "SAO 20323"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.92691462),
        dec: Angle.Degrees(+62.30634672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205686"},
        {"Hipparcos Number", "HIP 106521"},
        {"Celescope Catalog", "CEL 5346"},
        {"Geneva Identification System", "GEN# +1.00205686"},
        {"Smithsonian Astrophysical Observation", "SAO 19508"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.63450267),
        dec: Angle.Degrees(+62.30776047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81679",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10172 A"},
        {"Henry Draper", "HD 151067"},
        {"Hipparcos Number", "HIP 81679"},
        {"Geneva Identification System", "GEN# +1.00151067"},
        {"Smithsonian Astrophysical Observation", "SAO 17187"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.27628226),
        dec: Angle.Degrees(+62.30801111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7575"},
        {"Hipparcos Number", "HIP 6004"},
        {"Smithsonian Astrophysical Observation", "SAO 11675"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.30769310),
        dec: Angle.Degrees(+62.30808518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207308"},
        {"Hipparcos Number", "HIP 107442"},
        {"Celescope Catalog", "CEL 5382"},
        {"Geneva Identification System", "GEN# +1.00207308"},
        {"Smithsonian Astrophysical Observation", "SAO 19629"},
        {"Wilson Evans Batten Catalogue", "WEB 19399"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.42653747),
        dec: Angle.Degrees(+62.30834682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89289",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89289"},
        {"Smithsonian Astrophysical Observation", "SAO 17820"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.29296671),
        dec: Angle.Degrees(+62.31003395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211456"},
        {"Hipparcos Number", "HIP 109886"},
        {"Smithsonian Astrophysical Observation", "SAO 19963"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.83334215),
        dec: Angle.Degrees(+62.31205720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41689"},
        {"Hipparcos Number", "HIP 29317"},
        {"Geneva Identification System", "GEN# +1.00041689"},
        {"Smithsonian Astrophysical Observation", "SAO 13744"},
        {"Wilson Evans Batten Catalogue", "WEB 5755"},
    },
    visualMagnitude: 8.44,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.72907235),
        dec: Angle.Degrees(+62.31372701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1843"},
        {"Hipparcos Number", "HIP 1844"},
        {"Smithsonian Astrophysical Observation", "SAO 11153"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.83112692),
        dec: Angle.Degrees(+62.31406682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211589"},
        {"Hipparcos Number", "HIP 109964"},
        {"Celescope Catalog", "CEL 5461"},
        {"Smithsonian Astrophysical Observation", "SAO 19970"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.07800874),
        dec: Angle.Degrees(+62.31606080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40108"},
        {"Hipparcos Number", "HIP 28514"},
        {"Smithsonian Astrophysical Observation", "SAO 13681"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.28401629),
        dec: Angle.Degrees(+62.31675598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166227"},
        {"Hipparcos Number", "HIP 88605"},
        {"Smithsonian Astrophysical Observation", "SAO 17752"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.37749963),
        dec: Angle.Degrees(+62.31683487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4412",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4412"},
        {"Smithsonian Astrophysical Observation", "SAO 11479"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.13159905),
        dec: Angle.Degrees(+62.31857899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145068"},
        {"Hipparcos Number", "HIP 78802"},
        {"Smithsonian Astrophysical Observation", "SAO 16949"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.31393668),
        dec: Angle.Degrees(+62.32530101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7139",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7139"},
        {"Geneva Identification System", "GEN# +0.06100284"},
        {"Smithsonian Astrophysical Observation", "SAO 11802"},
    },
    visualMagnitude: 8.04,
    bvColour: 2.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.00106946),
        dec: Angle.Degrees(+62.32902312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19272",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2984 A"},
        {"Henry Draper", "HD 25639"},
        {"Hipparcos Number", "HIP 19272"},
        {"Geneva Identification System", "GEN# +2.15020001"},
        {"Smithsonian Astrophysical Observation", "SAO 13031"},
        {"Wilson Evans Batten Catalogue", "WEB 3701"},
        {"New General Catalogue", "NGC 1502 1"},
        {"New General Catalogue 2", "NGC 1502A"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.96414334),
        dec: Angle.Degrees(+62.33010752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148961"},
        {"Hipparcos Number", "HIP 80631"},
        {"Geneva Identification System", "GEN# +1.00148961"},
        {"Smithsonian Astrophysical Observation", "SAO 17095"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.95939381),
        dec: Angle.Degrees(+62.33236277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112718",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112718"},
        {"Geneva Identification System", "GEN# +9.00020002"},
        {"Smithsonian Astrophysical Observation", "SAO 20264"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.40189912),
        dec: Angle.Degrees(+62.33277627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19270",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2984 B"},
        {"Henry Draper", "HD 25638"},
        {"Hipparcos Number", "HIP 19270"},
        {"Geneva Identification System", "GEN# +2.15020002"},
        {"Smithsonian Astrophysical Observation", "SAO 13030"},
        {"Wilson Evans Batten Catalogue", "WEB 3703"},
        {"New General Catalogue", "NGC 1502 2"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.95535525),
        dec: Angle.Degrees(+62.33295289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6581"},
        {"Hipparcos Number", "HIP 5307"},
        {"Geneva Identification System", "GEN# +1.00006581"},
        {"Smithsonian Astrophysical Observation", "SAO 11587"},
        {"Wilson Evans Batten Catalogue", "WEB 1136"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.97599777),
        dec: Angle.Degrees(+62.33534046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213114"},
        {"Hipparcos Number", "HIP 110855"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.89708701),
        dec: Angle.Degrees(+62.33758841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110313",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110313"},
        {"Geneva Identification System", "GEN# +0.06102284"},
        {"Smithsonian Astrophysical Observation", "SAO 20017"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.15893158),
        dec: Angle.Degrees(+62.33822068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66461",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66461"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.37776799),
        dec: Angle.Degrees(+62.34336333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141988"},
        {"Hipparcos Number", "HIP 77440"},
        {"Geneva Identification System", "GEN# +1.00141988"},
        {"Renson", "Renson 40300"},
        {"Smithsonian Astrophysical Observation", "SAO 16856"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.12462249),
        dec: Angle.Degrees(+62.34426656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23909"},
        {"Hipparcos Number", "HIP 18113"},
        {"Smithsonian Astrophysical Observation", "SAO 12942"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.08615724),
        dec: Angle.Degrees(+62.34481973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4872",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4872"},
        {"Cincinnati Publication", "Ci 20 68"},
        {"Geneva Identification System", "GEN# +0.06100195A"},
        {"Wilson Evans Batten Catalogue", "WEB 944"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.65812055),
        dec: Angle.Degrees(+62.34482783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 730.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51110",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51110"},
        {"Smithsonian Astrophysical Observation", "SAO 15179"},
    },
    visualMagnitude: 10.85,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.63151317),
        dec: Angle.Degrees(+62.34655905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26763"},
        {"Hipparcos Number", "HIP 20027"},
        {"Smithsonian Astrophysical Observation", "SAO 13084"},
    },
    visualMagnitude: 7.15,
    bvColour: 2.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.43310461),
        dec: Angle.Degrees(+62.34662735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36502",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36502"},
        {"Smithsonian Astrophysical Observation", "SAO 14214"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.65028335),
        dec: Angle.Degrees(+62.34943802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9878"},
        {"Hipparcos Number", "HIP 7625"},
        {"Celescope Catalog", "CEL 150"},
        {"Fundamental Katalog 5th Edition", "FK5 2107"},
        {"Geneva Identification System", "GEN# +1.00009878"},
        {"Smithsonian Astrophysical Observation", "SAO 11883"},
        {"Wilson Evans Batten Catalogue", "WEB 1630"},
    },
    visualMagnitude: 6.72,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.55269150),
        dec: Angle.Degrees(+62.35178209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2654"},
        {"Hipparcos Number", "HIP 2409"},
        {"Celescope Catalog", "CEL 77"},
        {"Geneva Identification System", "GEN# +1.00002654"},
        {"Smithsonian Astrophysical Observation", "SAO 11235"},
        {"Wilson Evans Batten Catalogue", "WEB 441"},
    },
    visualMagnitude: 7.39,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.67340286),
        dec: Angle.Degrees(+62.35400760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218229"},
        {"Hipparcos Number", "HIP 114009"},
        {"Geneva Identification System", "GEN# +9.00020072"},
        {"Smithsonian Astrophysical Observation", "SAO 20411"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.33898424),
        dec: Angle.Degrees(+62.35528314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 279",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 279"},
        {"Geneva Identification System", "GEN# +0.06102583"},
        {"Smithsonian Astrophysical Observation", "SAO 10943"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.86377495),
        dec: Angle.Degrees(+62.35780416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37600"},
        {"Hipparcos Number", "HIP 27028"},
        {"Geneva Identification System", "GEN# +1.00037600"},
        {"Smithsonian Astrophysical Observation", "SAO 13588"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.99657715),
        dec: Angle.Degrees(+62.35787024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107273"},
        {"Hipparcos Number", "HIP 60111"},
        {"Smithsonian Astrophysical Observation", "SAO 15772"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.91780340),
        dec: Angle.Degrees(+62.35909315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19245",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19245"},
        {"Geneva Identification System", "GEN# +2.15020049"},
        {"New General Catalogue", "NGC 1502 49"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.86349205),
        dec: Angle.Degrees(+62.36245852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11605"},
        {"Hipparcos Number", "HIP 9000"},
        {"Geneva Identification System", "GEN# +1.00011605"},
        {"Smithsonian Astrophysical Observation", "SAO 12042"},
        {"Wilson Evans Batten Catalogue", "WEB 1887"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.97600784),
        dec: Angle.Degrees(+62.36350715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98487"},
        {"Hipparcos Number", "HIP 55397"},
        {"Geneva Identification System", "GEN# +1.00098487"},
        {"Smithsonian Astrophysical Observation", "SAO 15476"},
        {"Wilson Evans Batten Catalogue", "WEB 9968"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.14802062),
        dec: Angle.Degrees(+62.36423717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3940",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3940"},
        {"Geneva Identification System", "GEN# +0.06100175"},
        {"Smithsonian Astrophysical Observation", "SAO 11423"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.64760557),
        dec: Angle.Degrees(+62.36606894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17454"},
        {"Hipparcos Number", "HIP 13276"},
        {"Geneva Identification System", "GEN# +1.00017454"},
        {"Smithsonian Astrophysical Observation", "SAO 12467"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.72291250),
        dec: Angle.Degrees(+62.36772082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153598"},
        {"Hipparcos Number", "HIP 82891"},
        {"Geneva Identification System", "GEN# +1.00153598"},
        {"Smithsonian Astrophysical Observation", "SAO 17284"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.09138764),
        dec: Angle.Degrees(+62.36986474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121646"},
        {"Hipparcos Number", "HIP 67936"},
        {"Smithsonian Astrophysical Observation", "SAO 16215"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.68629036),
        dec: Angle.Degrees(+62.37750667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10294",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10294"},
        {"Smithsonian Astrophysical Observation", "SAO 12169"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.14462318),
        dec: Angle.Degrees(+62.37819256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19243"},
        {"Hipparcos Number", "HIP 14626"},
        {"Geneva Identification System", "GEN# +1.00019243"},
        {"Smithsonian Astrophysical Observation", "SAO 12619"},
        {"Wilson Evans Batten Catalogue", "WEB 2841"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.22576189),
        dec: Angle.Degrees(+62.38459628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83980"},
        {"Hipparcos Number", "HIP 47774"},
        {"Geneva Identification System", "GEN# +1.00083980"},
        {"Smithsonian Astrophysical Observation", "SAO 14975"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.10259248),
        dec: Angle.Degrees(+62.38829020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25594"},
        {"Hipparcos Number", "HIP 19241"},
        {"Geneva Identification System", "GEN# +2.15020055"},
        {"Smithsonian Astrophysical Observation", "SAO 13027"},
        {"New General Catalogue", "NGC 1502 55"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.85393442),
        dec: Angle.Degrees(+62.39071861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190425"},
        {"Hipparcos Number", "HIP 98557"},
        {"Smithsonian Astrophysical Observation", "SAO 18653"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.30418760),
        dec: Angle.Degrees(+62.39178851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106001",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106001"},
        {"Smithsonian Astrophysical Observation", "SAO 19436"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.03045163),
        dec: Angle.Degrees(+62.39182009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 582"},
        {"Smithsonian Astrophysical Observation", "SAO 10985"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.77282221),
        dec: Angle.Degrees(+62.39273559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198194"},
        {"Hipparcos Number", "HIP 102445"},
        {"Smithsonian Astrophysical Observation", "SAO 19023"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.38243828),
        dec: Angle.Degrees(+62.39589504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101365"},
        {"Hipparcos Number", "HIP 56933"},
        {"Geneva Identification System", "GEN# +1.00101365"},
        {"Smithsonian Astrophysical Observation", "SAO 15589"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.07816571),
        dec: Angle.Degrees(+62.39659860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6174",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6174"},
        {"Wilson Evans Batten Catalogue", "WEB 1384"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.79312995),
        dec: Angle.Degrees(+62.39677450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93053",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11901 A"},
        {"Henry Draper", "HD 176668"},
        {"Hipparcos Number", "HIP 93053"},
        {"Geneva Identification System", "GEN# +1.00176668A"},
        {"Smithsonian Astrophysical Observation", "SAO 18082"},
        {"Wilson Evans Batten Catalogue", "WEB 16117"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.32223249),
        dec: Angle.Degrees(+62.39687223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30221",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4927 A"},
        {"Henry Draper", "HD 43619"},
        {"Hipparcos Number", "HIP 30221"},
        {"Smithsonian Astrophysical Observation", "SAO 13812"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.36715386),
        dec: Angle.Degrees(+62.40149752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91299"},
        {"Hipparcos Number", "HIP 51728"},
        {"Smithsonian Astrophysical Observation", "SAO 15222"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.53551942),
        dec: Angle.Degrees(+62.40235459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19321",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19321"},
        {"Geneva Identification System", "GEN# +2.15020061"},
        {"New General Catalogue", "NGC 1502 61"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.11596434),
        dec: Angle.Degrees(+62.40659084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209869"},
        {"Hipparcos Number", "HIP 108957"},
        {"Celescope Catalog", "CEL 5431"},
        {"Geneva Identification System", "GEN# +1.00209869"},
        {"Smithsonian Astrophysical Observation", "SAO 19836"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.11596381),
        dec: Angle.Degrees(+62.40764731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6209"},
        {"Hipparcos Number", "HIP 5015"},
        {"Smithsonian Astrophysical Observation", "SAO 11556"},
        {"Wilson Evans Batten Catalogue", "WEB 1022"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.06838043),
        dec: Angle.Degrees(+62.41105987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115267",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16692 A"},
        {"Henry Draper", "HD 220147"},
        {"Hipparcos Number", "HIP 115267"},
        {"Geneva Identification System", "GEN# +1.00220147"},
        {"Renson", "Renson 60450"},
        {"Smithsonian Astrophysical Observation", "SAO 20576"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.20381537),
        dec: Angle.Degrees(+62.41254226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11166",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1817 AB"},
        {"Henry Draper", "HD 14557"},
        {"Hipparcos Number", "HIP 11166"},
        {"Smithsonian Astrophysical Observation", "SAO 12263"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.93257698),
        dec: Angle.Degrees(+62.41681312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169616"},
        {"Hipparcos Number", "HIP 89961"},
        {"Smithsonian Astrophysical Observation", "SAO 17862"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.32749291),
        dec: Angle.Degrees(+62.41689593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34955"},
        {"Hipparcos Number", "HIP 25356"},
        {"Smithsonian Astrophysical Observation", "SAO 13485"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.33703540),
        dec: Angle.Degrees(+62.41908686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212495"},
        {"Hipparcos Number", "HIP 110498"},
        {"Celescope Catalog", "CEL 5471"},
        {"Geneva Identification System", "GEN# +1.00212495"},
        {"Smithsonian Astrophysical Observation", "SAO 20042"},
        {"Wilson Evans Batten Catalogue", "WEB 19806"},
    },
    visualMagnitude: 6.04,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.75207260),
        dec: Angle.Degrees(+62.41932818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199609"},
        {"Hipparcos Number", "HIP 103276"},
        {"Smithsonian Astrophysical Observation", "SAO 19097"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.84401997),
        dec: Angle.Degrees(+62.42104329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25090"},
        {"Hipparcos Number", "HIP 18884"},
        {"Geneva Identification System", "GEN# +1.00025090"},
        {"Smithsonian Astrophysical Observation", "SAO 12998"},
        {"Wilson Evans Batten Catalogue", "WEB 3635"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.72978500),
        dec: Angle.Degrees(+62.42131539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147407"},
        {"Hipparcos Number", "HIP 79861"},
        {"Fundamental Katalog 5th Edition", "FK5 5437"},
        {"Smithsonian Astrophysical Observation", "SAO 17032"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.52436777),
        dec: Angle.Degrees(+62.42339855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59937",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59937"},
    },
    visualMagnitude: 9.91,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.40974905),
        dec: Angle.Degrees(+62.42537851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -167.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 101.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90998",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90998"},
        {"Smithsonian Astrophysical Observation", "SAO 17928"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.44863143),
        dec: Angle.Degrees(+62.42768219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116556",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116556"},
        {"Geneva Identification System", "GEN# +0.06102487"},
        {"Wilson Evans Batten Catalogue", "WEB 20580"},
    },
    visualMagnitude: 10.01,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.31692784),
        dec: Angle.Degrees(+62.42899460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16565",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16565"},
        {"Smithsonian Astrophysical Observation", "SAO 12806"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.30721796),
        dec: Angle.Degrees(+62.42943731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221990"},
        {"Hipparcos Number", "HIP 116493"},
        {"Celescope Catalog", "CEL 5637"},
        {"Geneva Identification System", "GEN# +1.00221990"},
        {"Smithsonian Astrophysical Observation", "SAO 20724"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.08766995),
        dec: Angle.Degrees(+62.42993365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196849"},
        {"Hipparcos Number", "HIP 101681"},
        {"Geneva Identification System", "GEN# +1.00196849"},
        {"Smithsonian Astrophysical Observation", "SAO 18946"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.15401245),
        dec: Angle.Degrees(+62.43194799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216945"},
        {"Hipparcos Number", "HIP 113249"},
        {"Smithsonian Astrophysical Observation", "SAO 20328"},
        {"Wilson Evans Batten Catalogue", "WEB 20152"},
    },
    visualMagnitude: 6.53,
    bvColour: 1.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.99312816),
        dec: Angle.Degrees(+62.43227921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46144",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46144"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.15571220),
        dec: Angle.Degrees(+62.43823105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216532"},
        {"Hipparcos Number", "HIP 112947"},
        {"Geneva Identification System", "GEN# +9.00020010"},
        {"Smithsonian Astrophysical Observation", "SAO 20286"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.12732300),
        dec: Angle.Degrees(+62.44054828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42882",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42882"},
        {"Smithsonian Astrophysical Observation", "SAO 14644"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.09582255),
        dec: Angle.Degrees(+62.44188952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46510"},
        {"Hipparcos Number", "HIP 31718"},
        {"Smithsonian Astrophysical Observation", "SAO 13902"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.52606549),
        dec: Angle.Degrees(+62.44525755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78296"},
        {"Hipparcos Number", "HIP 45027"},
        {"Geneva Identification System", "GEN# +1.00078296"},
        {"Smithsonian Astrophysical Observation", "SAO 14793"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.57471502),
        dec: Angle.Degrees(+62.44682217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49880"},
        {"Hipparcos Number", "HIP 33224"},
        {"Smithsonian Astrophysical Observation", "SAO 14002"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.70101416),
        dec: Angle.Degrees(+62.45991758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207198"},
        {"Hipparcos Number", "HIP 107374"},
        {"Celescope Catalog", "CEL 5379"},
        {"Geneva Identification System", "GEN# +1.00207198"},
        {"Smithsonian Astrophysical Observation", "SAO 19621"},
        {"Wilson Evans Batten Catalogue", "WEB 19393"},
    },
    visualMagnitude: 5.94,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.22201408),
        dec: Angle.Degrees(+62.46057429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160361"},
        {"Hipparcos Number", "HIP 86053"},
        {"Fundamental Katalog 5th Edition", "FK5 3398"},
        {"Geneva Identification System", "GEN# +1.00160361"},
        {"Smithsonian Astrophysical Observation", "SAO 17549"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.79451706),
        dec: Angle.Degrees(+62.46170103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101273",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13989 AB"},
        {"Henry Draper", "HD 196069"},
        {"Hipparcos Number", "HIP 101273"},
        {"Smithsonian Astrophysical Observation", "SAO 18913"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.91904366),
        dec: Angle.Degrees(+62.46229164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85987"},
        {"Hipparcos Number", "HIP 48852"},
        {"Smithsonian Astrophysical Observation", "SAO 15033"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.46231947),
        dec: Angle.Degrees(+62.46594295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196587"},
        {"Hipparcos Number", "HIP 101578"},
        {"Smithsonian Astrophysical Observation", "SAO 18935"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.79442309),
        dec: Angle.Degrees(+62.46851071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 141.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 138.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104912",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104912"},
        {"Smithsonian Astrophysical Observation", "SAO 19267"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.76829538),
        dec: Angle.Degrees(+62.47085029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15538",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15538"},
        {"Geneva Identification System", "GEN# +0.06100557"},
        {"Smithsonian Astrophysical Observation", "SAO 12708"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.04766213),
        dec: Angle.Degrees(+62.47291482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136881"},
        {"Hipparcos Number", "HIP 75030"},
        {"Smithsonian Astrophysical Observation", "SAO 16693"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.96892688),
        dec: Angle.Degrees(+62.47415142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23254"},
        {"Hipparcos Number", "HIP 17686"},
        {"Geneva Identification System", "GEN# +1.00023254"},
        {"Smithsonian Astrophysical Observation", "SAO 12900"},
        {"Wilson Evans Batten Catalogue", "WEB 3372"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.82238531),
        dec: Angle.Degrees(+62.47501784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14695"},
        {"Hipparcos Number", "HIP 11254"},
        {"Smithsonian Astrophysical Observation", "SAO 12273"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.21593958),
        dec: Angle.Degrees(+62.47579373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32784"},
        {"Hipparcos Number", "HIP 24009"},
        {"Geneva Identification System", "GEN# +1.00032784"},
        {"Smithsonian Astrophysical Observation", "SAO 13390"},
        {"Wilson Evans Batten Catalogue", "WEB 4678"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.41758336),
        dec: Angle.Degrees(+62.47983135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99282"},
        {"Hipparcos Number", "HIP 55810"},
        {"Smithsonian Astrophysical Observation", "SAO 15504"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.55430943),
        dec: Angle.Degrees(+62.48061443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148294"},
        {"Hipparcos Number", "HIP 80280"},
        {"Smithsonian Astrophysical Observation", "SAO 17069"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.81153577),
        dec: Angle.Degrees(+62.48140423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99899",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99899"},
        {"Smithsonian Astrophysical Observation", "SAO 18786"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.811,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.03720664),
        dec: Angle.Degrees(+62.48182338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111222"},
        {"Hipparcos Number", "HIP 62361"},
        {"Smithsonian Astrophysical Observation", "SAO 15899"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.69956011),
        dec: Angle.Degrees(+62.48282255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61117",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61117"},
        {"Smithsonian Astrophysical Observation", "SAO 15819"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.88744856),
        dec: Angle.Degrees(+62.48329794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60108",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60108"},
        {"Smithsonian Astrophysical Observation", "SAO 15771"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.91648550),
        dec: Angle.Degrees(+62.48372774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145710"},
        {"Hipparcos Number", "HIP 79087"},
        {"Geneva Identification System", "GEN# +1.00145710"},
        {"Smithsonian Astrophysical Observation", "SAO 16975"},
        {"Wilson Evans Batten Catalogue", "WEB 13370"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.15253712),
        dec: Angle.Degrees(+62.48540792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209339"},
        {"Hipparcos Number", "HIP 108650"},
        {"Celescope Catalog", "CEL 5418"},
        {"Geneva Identification System", "GEN# +1.00209339"},
        {"Renson", "Renson 58240"},
        {"Smithsonian Astrophysical Observation", "SAO 19792"},
        {"Wilson Evans Batten Catalogue", "WEB 19551"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.16361047),
        dec: Angle.Degrees(+62.48780193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196131"},
        {"Hipparcos Number", "HIP 101311"},
        {"Smithsonian Astrophysical Observation", "SAO 18915"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.02459025),
        dec: Angle.Degrees(+62.49063903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21212"},
        {"Hipparcos Number", "HIP 16195"},
        {"Geneva Identification System", "GEN# +1.00021212"},
        {"Smithsonian Astrophysical Observation", "SAO 12772"},
        {"Wilson Evans Batten Catalogue", "WEB 3086"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.16330916),
        dec: Angle.Degrees(+62.49300182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54514",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8072 A"},
        {"Henry Draper", "HD 96676"},
        {"Hipparcos Number", "HIP 54514"},
        {"Smithsonian Astrophysical Observation", "SAO 15411"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.30448107),
        dec: Angle.Degrees(+62.49747530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80042"},
        {"Hipparcos Number", "HIP 45797"},
        {"Geneva Identification System", "GEN# +1.00080042"},
        {"Smithsonian Astrophysical Observation", "SAO 14846"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.06751290),
        dec: Angle.Degrees(+62.49933508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85334",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85334"},
        {"Smithsonian Astrophysical Observation", "SAO 17482"},
    },
    visualMagnitude: 9.87,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.58055301),
        dec: Angle.Degrees(+62.49944297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9898",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9898"},
        {"Geneva Identification System", "GEN# +0.06100381"},
        {"Smithsonian Astrophysical Observation", "SAO 12138"},
        {"Wilson Evans Batten Catalogue", "WEB 2076"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.84424473),
        dec: Angle.Degrees(+62.50069119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36595",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6125 A"},
        {"Henry Draper", "HD 58917"},
        {"Hipparcos Number", "HIP 36595"},
        {"Smithsonian Astrophysical Observation", "SAO 14221"},
        {"Wilson Evans Batten Catalogue", "WEB 7274"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.90051745),
        dec: Angle.Degrees(+62.50189395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2451"},
        {"Hipparcos Number", "HIP 2259"},
        {"Geneva Identification System", "GEN# +1.00002451"},
        {"Smithsonian Astrophysical Observation", "SAO 11218"},
        {"Wilson Evans Batten Catalogue", "WEB 420"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.19988799),
        dec: Angle.Degrees(+62.50627815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27030",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27030"},
        {"Smithsonian Astrophysical Observation", "SAO 13587"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.99769483),
        dec: Angle.Degrees(+62.50665623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69148"},
        {"Hipparcos Number", "HIP 40772"},
        {"Geneva Identification System", "GEN# +1.00069148"},
        {"Smithsonian Astrophysical Observation", "SAO 14500"},
        {"Wilson Evans Batten Catalogue", "WEB 7914"},
    },
    visualMagnitude: 5.73,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.82159867),
        dec: Angle.Degrees(+62.50713912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127105"},
        {"Hipparcos Number", "HIP 70640"},
        {"Smithsonian Astrophysical Observation", "SAO 16382"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.74009518),
        dec: Angle.Degrees(+62.50845729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7641",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7641"},
        {"Geneva Identification System", "GEN# +6.20018044"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.60953507),
        dec: Angle.Degrees(+62.50924575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187426"},
        {"Hipparcos Number", "HIP 97271"},
        {"Smithsonian Astrophysical Observation", "SAO 18517"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.53688761),
        dec: Angle.Degrees(+62.51032543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2644",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2644"},
        {"Wilson Evans Batten Catalogue", "WEB 482"},
    },
    visualMagnitude: 11.11,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.37660627),
        dec: Angle.Degrees(+62.51116329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113738",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16466 A"},
        {"Henry Draper", "HD 217796"},
        {"Hipparcos Number", "HIP 113738"},
        {"Smithsonian Astrophysical Observation", "SAO 20381"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.52337432),
        dec: Angle.Degrees(+62.51209816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18818",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2924 AB"},
        {"Henry Draper", "HD 24992"},
        {"Hipparcos Number", "HIP 18818"},
    },
    visualMagnitude: 8.00,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.49312398),
        dec: Angle.Degrees(+62.51408179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83084",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83084"},
        {"Smithsonian Astrophysical Observation", "SAO 17297"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.65986388),
        dec: Angle.Degrees(+62.51769777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114496",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114496"},
        {"Smithsonian Astrophysical Observation", "SAO 20476"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.83753725),
        dec: Angle.Degrees(+62.51965712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124370"},
        {"Hipparcos Number", "HIP 69275"},
        {"Geneva Identification System", "GEN# +1.00124370"},
        {"Smithsonian Astrophysical Observation", "SAO 16298"},
        {"Wilson Evans Batten Catalogue", "WEB 12086"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.72112558),
        dec: Angle.Degrees(+62.52221650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21885"},
        {"Hipparcos Number", "HIP 16714"},
        {"Smithsonian Astrophysical Observation", "SAO 12823"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.75890742),
        dec: Angle.Degrees(+62.52533204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172728"},
        {"Hipparcos Number", "HIP 91315"},
        {"Fundamental Katalog 5th Edition", "FK5 3484"},
        {"Geneva Identification System", "GEN# +1.00172728"},
        {"Renson", "Renson 48420"},
        {"Smithsonian Astrophysical Observation", "SAO 17958"},
        {"Wilson Evans Batten Catalogue", "WEB 15693"},
    },
    visualMagnitude: 5.74,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.38963009),
        dec: Angle.Degrees(+62.52646287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9329"},
        {"Hipparcos Number", "HIP 7261"},
        {"Smithsonian Astrophysical Observation", "SAO 11825"},
        {"Wilson Evans Batten Catalogue", "WEB 1561"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.38826458),
        dec: Angle.Degrees(+62.52663262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203600"},
        {"Hipparcos Number", "HIP 105372"},
        {"Geneva Identification System", "GEN# +1.00203600"},
        {"Smithsonian Astrophysical Observation", "SAO 19335"},
        {"Wilson Evans Batten Catalogue", "WEB 19138"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.14326051),
        dec: Angle.Degrees(+62.52704974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4179"},
        {"Hipparcos Number", "HIP 3532"},
        {"Smithsonian Astrophysical Observation", "SAO 11366"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.26000044),
        dec: Angle.Degrees(+62.52860937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198739"},
        {"Hipparcos Number", "HIP 102761"},
        {"Celescope Catalog", "CEL 5181"},
        {"Geneva Identification System", "GEN# +1.00198739"},
        {"Smithsonian Astrophysical Observation", "SAO 19049"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.31255226),
        dec: Angle.Degrees(+62.52973625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94178",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94178"},
        {"Smithsonian Astrophysical Observation", "SAO 18190"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.56855624),
        dec: Angle.Degrees(+62.53013196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90789",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11443 AB"},
        {"Henry Draper", "HD 171549"},
        {"Hipparcos Number", "HIP 90789"},
        {"Renson", "Renson 48070"},
        {"Smithsonian Astrophysical Observation", "SAO 17911"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.82915712),
        dec: Angle.Degrees(+62.53784923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108825",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108825"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.70031598),
        dec: Angle.Degrees(+62.53960147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8450",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8450"},
    },
    visualMagnitude: 10.96,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.23587385),
        dec: Angle.Degrees(+62.54140300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107651",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107651"},
        {"Geneva Identification System", "GEN# +0.06102201"},
        {"Smithsonian Astrophysical Observation", "SAO 19654"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.07108775),
        dec: Angle.Degrees(+62.54142982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33478"},
        {"Hipparcos Number", "HIP 24444"},
        {"Geneva Identification System", "GEN# +1.00033478"},
        {"Renson", "Renson 8516"},
        {"Smithsonian Astrophysical Observation", "SAO 13423"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.65936865),
        dec: Angle.Degrees(+62.54215487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99994"},
        {"Hipparcos Number", "HIP 56181"},
        {"Smithsonian Astrophysical Observation", "SAO 15529"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.73537474),
        dec: Angle.Degrees(+62.54410137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -152.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -307.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39627",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39627"},
        {"Smithsonian Astrophysical Observation", "SAO 14430"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.46209150),
        dec: Angle.Degrees(+62.54442712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34321",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5758 A"},
        {"Henry Draper", "HD 52821"},
        {"Hipparcos Number", "HIP 34321"},
        {"Geneva Identification System", "GEN# +1.00052821"},
        {"Smithsonian Astrophysical Observation", "SAO 14071"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.72336866),
        dec: Angle.Degrees(+62.54716635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34327",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5758 B"},
        {"Henry Draper", "HD 52858"},
        {"Hipparcos Number", "HIP 34327"},
        {"Smithsonian Astrophysical Observation", "SAO 14072"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.74019569),
        dec: Angle.Degrees(+62.54930992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157409"},
        {"Hipparcos Number", "HIP 84699"},
        {"Smithsonian Astrophysical Observation", "SAO 17426"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.71402485),
        dec: Angle.Degrees(+62.54990528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19590"},
        {"Hipparcos Number", "HIP 14911"},
        {"Smithsonian Astrophysical Observation", "SAO 12655"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.10520535),
        dec: Angle.Degrees(+62.55084733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150552"},
        {"Hipparcos Number", "HIP 81423"},
        {"Smithsonian Astrophysical Observation", "SAO 17168"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.44282510),
        dec: Angle.Degrees(+62.55342572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183611"},
        {"Hipparcos Number", "HIP 95576"},
        {"Fundamental Katalog 5th Edition", "FK5 3556"},
        {"Geneva Identification System", "GEN# +1.00183611"},
        {"Smithsonian Astrophysical Observation", "SAO 18343"},
        {"Wilson Evans Batten Catalogue", "WEB 16715"},
    },
    visualMagnitude: 6.38,
    bvColour: 1.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.61023591),
        dec: Angle.Degrees(+62.55705286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130122"},
        {"Hipparcos Number", "HIP 72009"},
        {"Smithsonian Astrophysical Observation", "SAO 16476"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.91453571),
        dec: Angle.Degrees(+62.56333326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86855"},
        {"Hipparcos Number", "HIP 49277"},
        {"Smithsonian Astrophysical Observation", "SAO 15060"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.87729545),
        dec: Angle.Degrees(+62.56611982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184238"},
        {"Hipparcos Number", "HIP 95835"},
        {"Smithsonian Astrophysical Observation", "SAO 18366"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.37573730),
        dec: Angle.Degrees(+62.56688209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65068",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65068"},
        {"Smithsonian Astrophysical Observation", "SAO 16049"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.06402437),
        dec: Angle.Degrees(+62.57373142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68287",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68287"},
    },
    visualMagnitude: 12.17,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.68470359),
        dec: Angle.Degrees(+62.57543718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 145.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16230"},
        {"Hipparcos Number", "HIP 12355"},
        {"Geneva Identification System", "GEN# +1.00016230"},
        {"Smithsonian Astrophysical Observation", "SAO 12371"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.76461235),
        dec: Angle.Degrees(+62.57561100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122673"},
        {"Hipparcos Number", "HIP 68482"},
        {"Geneva Identification System", "GEN# +1.00122673"},
        {"Smithsonian Astrophysical Observation", "SAO 16252"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.30255288),
        dec: Angle.Degrees(+62.57702203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157102"},
        {"Hipparcos Number", "HIP 84541"},
        {"Smithsonian Astrophysical Observation", "SAO 17418"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.24613271),
        dec: Angle.Degrees(+62.57785364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -157.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 118.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11879",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11879"},
        {"Smithsonian Astrophysical Observation", "SAO 12329"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.31050641),
        dec: Angle.Degrees(+62.58146947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75576"},
        {"Hipparcos Number", "HIP 43696"},
        {"Geneva Identification System", "GEN# +1.00075576"},
        {"Smithsonian Astrophysical Observation", "SAO 14693"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.49789617),
        dec: Angle.Degrees(+62.58389254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105199",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alderamin"},
        {"Aitken", "ADS 14858 A"},
        {"Henry Draper", "HD 203280"},
        {"Hipparcos Number", "HIP 105199"},
        {"Celescope Catalog", "CEL 5294"},
        {"Fundamental Katalog 5th Edition", "FK5 803"},
        {"Geneva Identification System", "GEN# +1.00203280"},
        {"Smithsonian Astrophysical Observation", "SAO 19302"},
        {"Wilson Evans Batten Catalogue", "WEB 19106"},
    },
    visualMagnitude: 2.45,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.64408982),
        dec: Angle.Degrees(+62.58545529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 149.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108052",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15430 A"},
        {"Hipparcos Number", "HIP 108052"},
        {"Geneva Identification System", "GEN# +2.71600004"},
        {"Smithsonian Astrophysical Observation", "SAO 19711"},
        {"Wilson Evans Batten Catalogue", "WEB 19478"},
        {"New General Catalogue", "NGC 7160 4"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.36062905),
        dec: Angle.Degrees(+62.58699081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20008",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3087 A"},
        {"Henry Draper", "HD 26717"},
        {"Hipparcos Number", "HIP 20008"},
        {"Geneva Identification System", "GEN# +1.00026717"},
        {"Smithsonian Astrophysical Observation", "SAO 13079"},
        {"Wilson Evans Batten Catalogue", "WEB 3819"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.34728742),
        dec: Angle.Degrees(+62.58934907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3068"},
        {"Hipparcos Number", "HIP 2717"},
        {"Geneva Identification System", "GEN# +1.00003068"},
        {"Smithsonian Astrophysical Observation", "SAO 11270"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.64778821),
        dec: Angle.Degrees(+62.59047684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16218"},
        {"Hipparcos Number", "HIP 12346"},
        {"Celescope Catalog", "CEL 291"},
        {"Geneva Identification System", "GEN# +1.00016218"},
        {"Smithsonian Astrophysical Observation", "SAO 12369"},
    },
    visualMagnitude: 6.66,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.74288059),
        dec: Angle.Degrees(+62.59156708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12845",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12845"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.28565593),
        dec: Angle.Degrees(+62.59201321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223649"},
        {"Hipparcos Number", "HIP 117617"},
        {"Geneva Identification System", "GEN# +1.00223649"},
        {"Smithsonian Astrophysical Observation", "SAO 20897"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.80791420),
        dec: Angle.Degrees(+62.59285182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216711"},
        {"Hipparcos Number", "HIP 113065"},
        {"Geneva Identification System", "GEN# +9.00020020"},
        {"Smithsonian Astrophysical Observation", "SAO 20305"},
        {"Wilson Evans Batten Catalogue", "WEB 20127"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.47518709),
        dec: Angle.Degrees(+62.59677256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189207"},
        {"Hipparcos Number", "HIP 98025"},
        {"Geneva Identification System", "GEN# +1.00189207"},
        {"Smithsonian Astrophysical Observation", "SAO 18598"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.79654119),
        dec: Angle.Degrees(+62.59800537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112159"},
        {"Hipparcos Number", "HIP 62906"},
        {"Smithsonian Astrophysical Observation", "SAO 15934"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.38899615),
        dec: Angle.Degrees(+62.59912880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141653"},
        {"Hipparcos Number", "HIP 77277"},
        {"Fundamental Katalog 5th Edition", "FK5 587"},
        {"Geneva Identification System", "GEN# +1.00141653"},
        {"Smithsonian Astrophysical Observation", "SAO 16848"},
        {"Wilson Evans Batten Catalogue", "WEB 13096"},
    },
    visualMagnitude: 5.19,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.66647764),
        dec: Angle.Degrees(+62.59969448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108080",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15434 B"},
        {"Henry Draper", "HD 208440"},
        {"Hipparcos Number", "HIP 108080"},
        {"Geneva Identification System", "GEN# +2.71600003"},
        {"Renson", "Renson 57940"},
        {"Smithsonian Astrophysical Observation", "SAO 19719"},
        {"Wilson Evans Batten Catalogue", "WEB 19487"},
        {"New General Catalogue", "NGC 7160 3"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.47209385),
        dec: Angle.Degrees(+62.60021257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35534",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35534"},
        {"Smithsonian Astrophysical Observation", "SAO 14153"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.00138964),
        dec: Angle.Degrees(+62.60197522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16349"},
        {"Hipparcos Number", "HIP 12432"},
        {"Fundamental Katalog 5th Edition", "FK5 4248"},
        {"Geneva Identification System", "GEN# +1.00016349"},
        {"Smithsonian Astrophysical Observation", "SAO 12377"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.00450768),
        dec: Angle.Degrees(+62.60204490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37264"},
        {"Hipparcos Number", "HIP 26806"},
        {"Geneva Identification System", "GEN# +1.00037264"},
        {"Smithsonian Astrophysical Observation", "SAO 13566"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.38998384),
        dec: Angle.Degrees(+62.60661105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36698",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36698"},
        {"Smithsonian Astrophysical Observation", "SAO 14230"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.23744387),
        dec: Angle.Degrees(+62.60847523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6026"},
        {"Hipparcos Number", "HIP 4894"},
        {"Geneva Identification System", "GEN# +1.00006026"},
        {"Smithsonian Astrophysical Observation", "SAO 11540"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.70996758),
        dec: Angle.Degrees(+62.60907390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17993"},
        {"Hipparcos Number", "HIP 13708"},
        {"Smithsonian Astrophysical Observation", "SAO 12521"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.12390650),
        dec: Angle.Degrees(+62.60961974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164330"},
        {"Hipparcos Number", "HIP 87815"},
        {"Geneva Identification System", "GEN# +1.00164330"},
        {"Smithsonian Astrophysical Observation", "SAO 17695"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.08402821),
        dec: Angle.Degrees(+62.60982311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 100.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109416",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109416"},
        {"Geneva Identification System", "GEN# +0.06102263"},
        {"Smithsonian Astrophysical Observation", "SAO 19912"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.51491636),
        dec: Angle.Degrees(+62.61136819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185145"},
        {"Hipparcos Number", "HIP 96206"},
        {"Geneva Identification System", "GEN# +1.00185145"},
        {"Smithsonian Astrophysical Observation", "SAO 18400"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.44469538),
        dec: Angle.Degrees(+62.61286743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108073",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15434 A"},
        {"Henry Draper", "HD 208392"},
        {"Hipparcos Number", "HIP 108073"},
        {"Celescope Catalog", "CEL 5403"},
        {"Geneva Identification System", "GEN# +2.71600002"},
        {"Smithsonian Astrophysical Observation", "SAO 19718"},
        {"Wilson Evans Batten Catalogue", "WEB 19484"},
        {"New General Catalogue", "NGC 7160 2"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.45044481),
        dec: Angle.Degrees(+62.61443001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103385",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103385"},
        {"Smithsonian Astrophysical Observation", "SAO 19114"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.18707577),
        dec: Angle.Degrees(+62.61494211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96027"},
        {"Hipparcos Number", "HIP 54224"},
        {"Smithsonian Astrophysical Observation", "SAO 15396"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.42179775),
        dec: Angle.Degrees(+62.61708982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220421"},
        {"Hipparcos Number", "HIP 115439"},
        {"Smithsonian Astrophysical Observation", "SAO 20595"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.74359099),
        dec: Angle.Degrees(+62.61725607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112404",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112404"},
        {"Smithsonian Astrophysical Observation", "SAO 20235"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.51207902),
        dec: Angle.Degrees(+62.61813275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6493",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6493"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.85577954),
        dec: Angle.Degrees(+62.61818659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157539"},
        {"Hipparcos Number", "HIP 84773"},
        {"Geneva Identification System", "GEN# +1.00157539"},
        {"Smithsonian Astrophysical Observation", "SAO 17431"},
    },
    visualMagnitude: 8.85,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.92032737),
        dec: Angle.Degrees(+62.61920413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164329"},
        {"Hipparcos Number", "HIP 87827"},
        {"Smithsonian Astrophysical Observation", "SAO 17696"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.10929853),
        dec: Angle.Degrees(+62.61961429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41257"},
        {"Hipparcos Number", "HIP 29104"},
        {"Smithsonian Astrophysical Observation", "SAO 13726"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.07449532),
        dec: Angle.Degrees(+62.62096844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48698",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48698"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.96796766),
        dec: Angle.Degrees(+62.62419691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217061"},
        {"Hipparcos Number", "HIP 113301"},
        {"Geneva Identification System", "GEN# +9.00020040"},
        {"Smithsonian Astrophysical Observation", "SAO 20334"},
        {"Wilson Evans Batten Catalogue", "WEB 20158"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.17730254),
        dec: Angle.Degrees(+62.62488476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102529",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14301 AB"},
        {"Henry Draper", "HD 198363"},
        {"Hipparcos Number", "HIP 102529"},
        {"Smithsonian Astrophysical Observation", "SAO 19032"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.65994688),
        dec: Angle.Degrees(+62.62608902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19142"},
        {"Hipparcos Number", "HIP 14553"},
        {"Smithsonian Astrophysical Observation", "SAO 12613"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.96410145),
        dec: Angle.Degrees(+62.63955066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217966"},
        {"Hipparcos Number", "HIP 113851"},
        {"Celescope Catalog", "CEL 5561"},
        {"Smithsonian Astrophysical Observation", "SAO 20394"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.83801382),
        dec: Angle.Degrees(+62.64243412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10375"},
        {"Hipparcos Number", "HIP 8032"},
        {"Geneva Identification System", "GEN# +1.00010375"},
        {"Smithsonian Astrophysical Observation", "SAO 11936"},
        {"Wilson Evans Batten Catalogue", "WEB 1719"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.79441211),
        dec: Angle.Degrees(+62.64348364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47902",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47902"},
    },
    visualMagnitude: 10.21,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.43953089),
        dec: Angle.Degrees(+62.64415227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73659",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73659"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.85810650),
        dec: Angle.Degrees(+62.64704601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22611"},
        {"Hipparcos Number", "HIP 17257"},
        {"Geneva Identification System", "GEN# +1.00022611J"},
        {"Smithsonian Astrophysical Observation", "SAO 12870"},
        {"Wilson Evans Batten Catalogue", "WEB 3265"},
    },
    visualMagnitude: 6.99,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.45070668),
        dec: Angle.Degrees(+62.64845070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48050"},
        {"Hipparcos Number", "HIP 32399"},
        {"Smithsonian Astrophysical Observation", "SAO 13949"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.46214542),
        dec: Angle.Degrees(+62.64957238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34255"},
        {"Hipparcos Number", "HIP 24914"},
        {"Fundamental Katalog 5th Edition", "FK5 2397"},
        {"Geneva Identification System", "GEN# +1.00034255"},
        {"Smithsonian Astrophysical Observation", "SAO 13460"},
        {"Wilson Evans Batten Catalogue", "WEB 4825"},
    },
    visualMagnitude: 5.64,
    bvColour: 1.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.09422730),
        dec: Angle.Degrees(+62.65371666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175489"},
        {"Hipparcos Number", "HIP 92523"},
        {"Smithsonian Astrophysical Observation", "SAO 18048"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.84200007),
        dec: Angle.Degrees(+62.65441543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114225",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114225"},
        {"Geneva Identification System", "GEN# +9.00020080"},
        {"Smithsonian Astrophysical Observation", "SAO 20440"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.98412329),
        dec: Angle.Degrees(+62.65924818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185413"},
        {"Hipparcos Number", "HIP 96337"},
        {"Smithsonian Astrophysical Observation", "SAO 18416"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.79263578),
        dec: Angle.Degrees(+62.65931734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96796",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12803 AB"},
        {"Henry Draper", "HD 186453"},
        {"Hipparcos Number", "HIP 96796"},
        {"Geneva Identification System", "GEN# +1.00186453"},
        {"Smithsonian Astrophysical Observation", "SAO 18469"},
        {"Wilson Evans Batten Catalogue", "WEB 16982"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.14502805),
        dec: Angle.Degrees(+62.66457599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 110.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 779",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 779"},
        {"Geneva Identification System", "GEN# +0.06100008"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.40151993),
        dec: Angle.Degrees(+62.66781255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71204",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71204"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.42759592),
        dec: Angle.Degrees(+62.66957435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223043"},
        {"Hipparcos Number", "HIP 117217"},
        {"Celescope Catalog", "CEL 5667"},
        {"Geneva Identification System", "GEN# +1.00223043"},
        {"Smithsonian Astrophysical Observation", "SAO 20829"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.50279767),
        dec: Angle.Degrees(+62.66997131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5203",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 905 A"},
        {"Henry Draper", "HD 6448"},
        {"Hipparcos Number", "HIP 5203"},
        {"Smithsonian Astrophysical Observation", "SAO 11575"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.64008019),
        dec: Angle.Degrees(+62.67084926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13898"},
        {"Hipparcos Number", "HIP 10702"},
        {"Smithsonian Astrophysical Observation", "SAO 12209"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.44221582),
        dec: Angle.Degrees(+62.67121885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215383"},
        {"Hipparcos Number", "HIP 112197"},
        {"Geneva Identification System", "GEN# +1.00215383"},
        {"Smithsonian Astrophysical Observation", "SAO 20215"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.85680401),
        dec: Angle.Degrees(+62.67137874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51831"},
        {"Hipparcos Number", "HIP 33986"},
        {"Smithsonian Astrophysical Observation", "SAO 14057"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.77771984),
        dec: Angle.Degrees(+62.67367089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12671",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12671"},
        {"Smithsonian Astrophysical Observation", "SAO 12405"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.69794042),
        dec: Angle.Degrees(+62.67382264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7895",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1318 AB"},
        {"Henry Draper", "HD 10196"},
        {"Hipparcos Number", "HIP 7895"},
        {"Smithsonian Astrophysical Observation", "SAO 11914"},
        {"Wilson Evans Batten Catalogue", "WEB 1686"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.39139657),
        dec: Angle.Degrees(+62.67685081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218450"},
        {"Hipparcos Number", "HIP 114166"},
        {"Geneva Identification System", "GEN# +9.00020078"},
        {"Smithsonian Astrophysical Observation", "SAO 20434"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.80487823),
        dec: Angle.Degrees(+62.67688753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8410",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8410"},
        {"Geneva Identification System", "GEN# +0.06100328"},
        {"Smithsonian Astrophysical Observation", "SAO 11989"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.12338091),
        dec: Angle.Degrees(+62.68060838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7330"},
        {"Hipparcos Number", "HIP 5839"},
        {"Geneva Identification System", "GEN# +1.00007330"},
        {"Smithsonian Astrophysical Observation", "SAO 11654"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.72020284),
        dec: Angle.Degrees(+62.68065995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43999",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43999"},
    },
    visualMagnitude: 10.73,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.39148895),
        dec: Angle.Degrees(+62.68303888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44412"},
        {"Hipparcos Number", "HIP 30619"},
        {"Smithsonian Astrophysical Observation", "SAO 13834"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.52226477),
        dec: Angle.Degrees(+62.69007424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114253"},
        {"Hipparcos Number", "HIP 64096"},
        {"Smithsonian Astrophysical Observation", "SAO 15991"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.03077022),
        dec: Angle.Degrees(+62.69026396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33296"},
        {"Hipparcos Number", "HIP 24348"},
        {"Geneva Identification System", "GEN# +1.00033296"},
        {"Smithsonian Astrophysical Observation", "SAO 13413"},
        {"Wilson Evans Batten Catalogue", "WEB 4725"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.38038055),
        dec: Angle.Degrees(+62.69112962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105301"},
        {"Hipparcos Number", "HIP 59128"},
        {"Smithsonian Astrophysical Observation", "SAO 15718"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.87080549),
        dec: Angle.Degrees(+62.69583261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1235",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1235"},
        {"Geneva Identification System", "GEN# +0.06100019"},
        {"Smithsonian Astrophysical Observation", "SAO 11072"},
        {"Wilson Evans Batten Catalogue", "WEB 223"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.84148806),
        dec: Angle.Degrees(+62.69624579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22648",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22648"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.08560382),
        dec: Angle.Degrees(+62.69718206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209112"},
        {"Hipparcos Number", "HIP 108505"},
        {"Geneva Identification System", "GEN# +1.00209112"},
        {"Smithsonian Astrophysical Observation", "SAO 19773"},
        {"Wilson Evans Batten Catalogue", "WEB 19537"},
    },
    visualMagnitude: 5.96,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.72294977),
        dec: Angle.Degrees(+62.69795151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82027"},
        {"Hipparcos Number", "HIP 46794"},
        {"Smithsonian Astrophysical Observation", "SAO 14910"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.03439635),
        dec: Angle.Degrees(+62.70390791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124818"},
        {"Hipparcos Number", "HIP 69471"},
        {"Geneva Identification System", "GEN# +1.00124818"},
        {"Smithsonian Astrophysical Observation", "SAO 16310"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.34187643),
        dec: Angle.Degrees(+62.70458605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83507"},
        {"Hipparcos Number", "HIP 47533"},
        {"Smithsonian Astrophysical Observation", "SAO 14961"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.36325577),
        dec: Angle.Degrees(+62.70470529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177929"},
        {"Hipparcos Number", "HIP 93499"},
        {"Smithsonian Astrophysical Observation", "SAO 18123"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.62943337),
        dec: Angle.Degrees(+62.70549356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28096"},
        {"Hipparcos Number", "HIP 20980"},
        {"Smithsonian Astrophysical Observation", "SAO 13159"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.49367045),
        dec: Angle.Degrees(+62.70655854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109687",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109687"},
        {"Geneva Identification System", "GEN# +0.06202051"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.28484603),
        dec: Angle.Degrees(+62.70889717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208218"},
        {"Hipparcos Number", "HIP 107984"},
        {"Celescope Catalog", "CEL 5400"},
        {"Geneva Identification System", "GEN# +2.71600001"},
        {"Smithsonian Astrophysical Observation", "SAO 19698"},
        {"Wilson Evans Batten Catalogue", "WEB 19471"},
        {"New General Catalogue", "NGC 7160 1"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.14645703),
        dec: Angle.Degrees(+62.71217505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44849"},
        {"Hipparcos Number", "HIP 30808"},
        {"Geneva Identification System", "GEN# +1.00044849"},
        {"Smithsonian Astrophysical Observation", "SAO 13848"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.09126127),
        dec: Angle.Degrees(+62.71249277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100960"},
        {"Hipparcos Number", "HIP 56710"},
        {"Geneva Identification System", "GEN# +1.00100960"},
        {"Smithsonian Astrophysical Observation", "SAO 15573"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.40587683),
        dec: Angle.Degrees(+62.71301260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110462"},
        {"Hipparcos Number", "HIP 61936"},
        {"Fundamental Katalog 5th Edition", "FK5 478"},
        {"Geneva Identification System", "GEN# +1.00110462"},
        {"Smithsonian Astrophysical Observation", "SAO 15871"},
        {"Wilson Evans Batten Catalogue", "WEB 11012"},
    },
    visualMagnitude: 6.02,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.39145671),
        dec: Angle.Degrees(+62.71308183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138664"},
        {"Hipparcos Number", "HIP 75888"},
        {"Smithsonian Astrophysical Observation", "SAO 16751"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.50397166),
        dec: Angle.Degrees(+62.71392509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160053"},
        {"Hipparcos Number", "HIP 85926"},
        {"Smithsonian Astrophysical Observation", "SAO 17529"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.39639286),
        dec: Angle.Degrees(+62.71436622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98838"},
        {"Hipparcos Number", "HIP 55593"},
        {"Geneva Identification System", "GEN# +1.00098838"},
        {"Smithsonian Astrophysical Observation", "SAO 15489"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.82191316),
        dec: Angle.Degrees(+62.71690658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52582"},
        {"Smithsonian Astrophysical Observation", "SAO 15276"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.28596990),
        dec: Angle.Degrees(+62.71724930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118122",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118122"},
        {"Wilson Evans Batten Catalogue", "WEB 20762"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.39567685),
        dec: Angle.Degrees(+62.71824909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18409"},
        {"Hipparcos Number", "HIP 14019"},
        {"Geneva Identification System", "GEN# +1.00018409"},
        {"Smithsonian Astrophysical Observation", "SAO 12558"},
        {"Wilson Evans Batten Catalogue", "WEB 2762"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.12380613),
        dec: Angle.Degrees(+62.72194959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145433"},
        {"Hipparcos Number", "HIP 78960"},
        {"Smithsonian Astrophysical Observation", "SAO 16963"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.78715480),
        dec: Angle.Degrees(+62.72215608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217086"},
        {"Henry Draper 2", "HD 217086A"},
        {"Hipparcos Number", "HIP 113306"},
        {"Geneva Identification System", "GEN# +9.00020041"},
        {"Smithsonian Astrophysical Observation", "SAO 20335"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.19662186),
        dec: Angle.Degrees(+62.72713216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 841"},
        {"Hipparcos Number", "HIP 1042"},
        {"Geneva Identification System", "GEN# +1.00000841"},
        {"Smithsonian Astrophysical Observation", "SAO 11040"},
        {"Wilson Evans Batten Catalogue", "WEB 180"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.25491636),
        dec: Angle.Degrees(+62.72809316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117077",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117077"},
        {"Geneva Identification System", "GEN# +0.06102510"},
        {"Smithsonian Astrophysical Observation", "SAO 20808"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.00972736),
        dec: Angle.Degrees(+62.72970753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20614"},
        {"Hipparcos Number", "HIP 15707"},
        {"Smithsonian Astrophysical Observation", "SAO 12724"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.58595216),
        dec: Angle.Degrees(+62.72975171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15691",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15691"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.53103184),
        dec: Angle.Degrees(+62.73879476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10358",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10358"},
        {"Smithsonian Astrophysical Observation", "SAO 12174"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.37829200),
        dec: Angle.Degrees(+62.73933014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219978"},
        {"Hipparcos Number", "HIP 115141"},
        {"Geneva Identification System", "GEN# +1.00219978"},
        {"Smithsonian Astrophysical Observation", "SAO 20558"},
        {"Wilson Evans Batten Catalogue", "WEB 20398"},
    },
    visualMagnitude: 6.66,
    bvColour: 2.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.84906105),
        dec: Angle.Degrees(+62.73978095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20588"},
        {"Hipparcos Number", "HIP 15686"},
        {"Geneva Identification System", "GEN# +1.00020588"},
        {"Smithsonian Astrophysical Observation", "SAO 12721"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.52027915),
        dec: Angle.Degrees(+62.74144475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173398"},
        {"Hipparcos Number", "HIP 91606"},
        {"Geneva Identification System", "GEN# +1.00173398"},
        {"Smithsonian Astrophysical Observation", "SAO 17975"},
        {"Wilson Evans Batten Catalogue", "WEB 15752"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.23499041),
        dec: Angle.Degrees(+62.74933514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103186"},
        {"Hipparcos Number", "HIP 57946"},
        {"Smithsonian Astrophysical Observation", "SAO 15652"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.25174387),
        dec: Angle.Degrees(+62.75401559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
