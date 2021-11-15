using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_72() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136831"},
        {"Hipparcos Number", "HIP 75230"},
        {"Fundamental Katalog 5th Edition", "FK5 3213"},
        {"Geneva Identification System", "GEN# +1.00136831"},
        {"Smithsonian Astrophysical Observation", "SAO 101508"},
        {"Wilson Evans Batten Catalogue", "WEB 12832"},
    },
    visualMagnitude: 6.29,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.59682931),
        dec: Angle.Degrees(+12.56753162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10549"},
        {"Hipparcos Number", "HIP 8026"},
        {"Smithsonian Astrophysical Observation", "SAO 92592"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.76098920),
        dec: Angle.Degrees(+12.56767218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69826",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69826"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.808,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.35845628),
        dec: Angle.Degrees(+12.56774469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103298",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14429 A"},
        {"Henry Draper", "HD 199254"},
        {"Hipparcos Number", "HIP 103298"},
        {"Geneva Identification System", "GEN# +1.00199254"},
        {"Renson", "Renson 55510"},
        {"Smithsonian Astrophysical Observation", "SAO 106666"},
        {"Wilson Evans Batten Catalogue", "WEB 18773"},
    },
    visualMagnitude: 5.54,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.91063822),
        dec: Angle.Degrees(+12.56850687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64584"},
        {"Hipparcos Number", "HIP 38669"},
        {"Smithsonian Astrophysical Observation", "SAO 97364"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.75831924),
        dec: Angle.Degrees(+12.56950690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44497"},
        {"Hipparcos Number", "HIP 30318"},
        {"Geneva Identification System", "GEN# +1.00044497"},
        {"Smithsonian Astrophysical Observation", "SAO 95599"},
        {"Wilson Evans Batten Catalogue", "WEB 6027"},
    },
    visualMagnitude: 6.00,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.65176776),
        dec: Angle.Degrees(+12.57031541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101878",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101878"},
        {"Geneva Identification System", "GEN# +0.01204410"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.67407380),
        dec: Angle.Degrees(+12.57163855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11764"},
        {"Hipparcos Number", "HIP 8973"},
        {"Geneva Identification System", "GEN# +1.00011764"},
        {"Smithsonian Astrophysical Observation", "SAO 92700"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.91411136),
        dec: Angle.Degrees(+12.57328209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77123"},
        {"Hipparcos Number", "HIP 44264"},
        {"Smithsonian Astrophysical Observation", "SAO 98290"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.21047297),
        dec: Angle.Degrees(+12.57335122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69480",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9165 AB"},
        {"Henry Draper", "HD 124442"},
        {"Hipparcos Number", "HIP 69480"},
        {"Geneva Identification System", "GEN# +1.00124442J"},
        {"Smithsonian Astrophysical Observation", "SAO 100918"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.36223713),
        dec: Angle.Degrees(+12.57394858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214959"},
        {"Hipparcos Number", "HIP 112050"},
        {"Smithsonian Astrophysical Observation", "SAO 108107"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.43719113),
        dec: Angle.Degrees(+12.57435905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153865"},
        {"Hipparcos Number", "HIP 83310"},
        {"Smithsonian Astrophysical Observation", "SAO 102534"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.39025015),
        dec: Angle.Degrees(+12.57658374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214298"},
        {"Hipparcos Number", "HIP 111649"},
        {"Smithsonian Astrophysical Observation", "SAO 108043"},
        {"Wilson Evans Batten Catalogue", "WEB 19956"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.27023357),
        dec: Angle.Degrees(+12.57689455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 268184"},
        {"Hipparcos Number", "HIP 33910"},
        {"Smithsonian Astrophysical Observation", "SAO 96405"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.56666388),
        dec: Angle.Degrees(+12.57754760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51024"},
        {"Hipparcos Number", "HIP 33352"},
        {"Geneva Identification System", "GEN# +1.00051024"},
        {"Smithsonian Astrophysical Observation", "SAO 96289"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.05070825),
        dec: Angle.Degrees(+12.58049950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107888"},
        {"Hipparcos Number", "HIP 60475"},
        {"Wilson Evans Batten Catalogue", "WEB 10756"},
    },
    visualMagnitude: 10.39,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.97303737),
        dec: Angle.Degrees(+12.58066308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -168.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145851"},
        {"Hipparcos Number", "HIP 79444"},
        {"Geneva Identification System", "GEN# +1.00145851"},
        {"Smithsonian Astrophysical Observation", "SAO 102010"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.19196722),
        dec: Angle.Degrees(+12.58165716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52586"},
        {"Hipparcos Number", "HIP 33917"},
        {"Smithsonian Astrophysical Observation", "SAO 96406"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.57683349),
        dec: Angle.Degrees(+12.58171044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71247",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71247"},
        {"Geneva Identification System", "GEN# +9.80066007"},
    },
    visualMagnitude: 10.78,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.55745493),
        dec: Angle.Degrees(+12.58206463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -501.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 202.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81900"},
        {"Hipparcos Number", "HIP 46486"},
        {"Geneva Identification System", "GEN# +1.00081900"},
        {"Smithsonian Astrophysical Observation", "SAO 98595"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.21866032),
        dec: Angle.Degrees(+12.58409049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286844"},
        {"Hipparcos Number", "HIP 21205"},
        {"Smithsonian Astrophysical Observation", "SAO 94000"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.23322451),
        dec: Angle.Degrees(+12.58456963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9607",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9607"},
        {"Geneva Identification System", "GEN# +9.80003038"},
    },
    visualMagnitude: 11.54,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.88668271),
        dec: Angle.Degrees(+12.58484575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 382.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2245",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2245"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.13470477),
        dec: Angle.Degrees(+12.58791993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66665",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66665"},
        {"Cincinnati Publication", "Ci 18 1772"},
        {"Geneva Identification System", "GEN# +0.01302698"},
        {"Smithsonian Astrophysical Observation", "SAO 100656"},
        {"Wilson Evans Batten Catalogue", "WEB 11760"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.99794203),
        dec: Angle.Degrees(+12.59005311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -285.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3474",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3474"},
        {"Smithsonian Astrophysical Observation", "SAO 92059"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.09731043),
        dec: Angle.Degrees(+12.59084280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52976"},
        {"Hipparcos Number", "HIP 34055"},
        {"Geneva Identification System", "GEN# +1.00052976"},
        {"Smithsonian Astrophysical Observation", "SAO 96432"},
        {"Wilson Evans Batten Catalogue", "WEB 6827"},
    },
    visualMagnitude: 6.01,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.96501258),
        dec: Angle.Degrees(+12.59425915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123439"},
        {"Hipparcos Number", "HIP 68986"},
        {"Fundamental Katalog 5th Edition", "FK5 5253"},
        {"Smithsonian Astrophysical Observation", "SAO 100857"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.85581938),
        dec: Angle.Degrees(+12.59426891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75174"},
        {"Hipparcos Number", "HIP 43262"},
        {"Geneva Identification System", "GEN# +1.00075174"},
        {"Smithsonian Astrophysical Observation", "SAO 98144"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.18714405),
        dec: Angle.Degrees(+12.59601389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2828",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2828"},
    },
    visualMagnitude: 11.26,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.97085680),
        dec: Angle.Degrees(+12.59740149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -366.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -313.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182843"},
        {"Hipparcos Number", "HIP 95552"},
        {"Smithsonian Astrophysical Observation", "SAO 104827"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.52870707),
        dec: Angle.Degrees(+12.59852937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47683",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47683"},
        {"Smithsonian Astrophysical Observation", "SAO 98729"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.84216013),
        dec: Angle.Degrees(+12.59931473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32005"},
        {"Hipparcos Number", "HIP 23301"},
        {"Celescope Catalog", "CEL 506"},
        {"Fundamental Katalog 5th Edition", "FK5 4457"},
        {"Geneva Identification System", "GEN# +1.00032005"},
        {"Smithsonian Astrophysical Observation", "SAO 94255"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.17402182),
        dec: Angle.Degrees(+12.60394607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8250"},
        {"Hipparcos Number", "HIP 6376"},
        {"Smithsonian Astrophysical Observation", "SAO 92395"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.49281613),
        dec: Angle.Degrees(+12.60417535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209710"},
        {"Hipparcos Number", "HIP 109024"},
        {"Smithsonian Astrophysical Observation", "SAO 107649"},
    },
    visualMagnitude: 7.54,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.30009806),
        dec: Angle.Degrees(+12.60506451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154656"},
        {"Hipparcos Number", "HIP 83691"},
        {"Cincinnati Publication", "Ci 18 2280"},
        {"Geneva Identification System", "GEN# +1.00154656"},
        {"Smithsonian Astrophysical Observation", "SAO 102594"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.57514445),
        dec: Angle.Degrees(+12.60651450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -204.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 126.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114088",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114088"},
    },
    visualMagnitude: 11.46,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.59855271),
        dec: Angle.Degrees(+12.60754050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 319.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22952"},
        {"Hipparcos Number", "HIP 17235"},
        {"Geneva Identification System", "GEN# +1.00022952"},
        {"Smithsonian Astrophysical Observation", "SAO 93553"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.36770523),
        dec: Angle.Degrees(+12.60811249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170757"},
        {"Henry Draper 2", "HD 170757B"},
        {"Henry Draper 3", "HD 170757A"},
        {"Hipparcos Number", "HIP 90727"},
        {"Geneva Identification System", "GEN# +1.00170757"},
        {"Smithsonian Astrophysical Observation", "SAO 103793"},
        {"Wilson Evans Batten Catalogue", "WEB 15541"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.66357089),
        dec: Angle.Degrees(+12.61118853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40571"},
        {"Hipparcos Number", "HIP 28433"},
        {"Smithsonian Astrophysical Observation", "SAO 95105"},
    },
    visualMagnitude: 6.80,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.07159957),
        dec: Angle.Degrees(+12.61142758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81018",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81018"},
        {"Geneva Identification System", "GEN# +9.80138039"},
    },
    visualMagnitude: 12.13,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.19020337),
        dec: Angle.Degrees(+12.61310688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -766.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97938"},
        {"Hipparcos Number", "HIP 55029"},
        {"Geneva Identification System", "GEN# +1.00097938"},
        {"Smithsonian Astrophysical Observation", "SAO 99526"},
        {"Wilson Evans Batten Catalogue", "WEB 9927"},
    },
    visualMagnitude: 6.82,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.98479734),
        dec: Angle.Degrees(+12.61361435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15471",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15471"},
        {"Smithsonian Astrophysical Observation", "SAO 93383"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.86952800),
        dec: Angle.Degrees(+12.61547860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41042"},
        {"Hipparcos Number", "HIP 28673"},
        {"Smithsonian Astrophysical Observation", "SAO 95165"},
    },
    visualMagnitude: 7.39,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.81333532),
        dec: Angle.Degrees(+12.61770813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89307"},
        {"Hipparcos Number", "HIP 50473"},
        {"Geneva Identification System", "GEN# +1.00089307"},
        {"Smithsonian Astrophysical Observation", "SAO 99049"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.58937836),
        dec: Angle.Degrees(+12.62120337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -272.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197925"},
        {"Hipparcos Number", "HIP 102514"},
        {"Geneva Identification System", "GEN# +1.00197925"},
        {"Smithsonian Astrophysical Observation", "SAO 106473"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.62823570),
        dec: Angle.Degrees(+12.62211377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286693"},
        {"Hipparcos Number", "HIP 20187"},
        {"Geneva Identification System", "GEN# +5.20251171"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.90322073),
        dec: Angle.Degrees(+12.62436876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 168.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84376",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84376"},
        {"Smithsonian Astrophysical Observation", "SAO 102686"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.74491259),
        dec: Angle.Degrees(+12.62545877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207757"},
        {"Hipparcos Number", "HIP 107848"},
        {"Geneva Identification System", "GEN# +1.00207757"},
        {"Smithsonian Astrophysical Observation", "SAO 107436"},
        {"Wilson Evans Batten Catalogue", "WEB 19447"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.75822786),
        dec: Angle.Degrees(+12.62559362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66134",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66134"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.35970481),
        dec: Angle.Degrees(+12.62610718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163750"},
        {"Hipparcos Number", "HIP 87899"},
        {"Geneva Identification System", "GEN# +1.00163750"},
        {"Smithsonian Astrophysical Observation", "SAO 103240"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.32776121),
        dec: Angle.Degrees(+12.62682070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88052",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88052"},
        {"Smithsonian Astrophysical Observation", "SAO 103270"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.76139503),
        dec: Angle.Degrees(+12.62707896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111273"},
        {"Hipparcos Number", "HIP 62457"},
        {"Smithsonian Astrophysical Observation", "SAO 100267"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.99994318),
        dec: Angle.Degrees(+12.62758259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21051"},
        {"Hipparcos Number", "HIP 15850"},
        {"Fundamental Katalog 5th Edition", "FK5 2241"},
        {"Geneva Identification System", "GEN# +1.00021051"},
        {"Smithsonian Astrophysical Observation", "SAO 93416"},
        {"Wilson Evans Batten Catalogue", "WEB 3025"},
    },
    visualMagnitude: 6.03,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.04214254),
        dec: Angle.Degrees(+12.62964221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105542",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105542"},
        {"Smithsonian Astrophysical Observation", "SAO 107080"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.63310194),
        dec: Angle.Degrees(+12.63071126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197276"},
        {"Hipparcos Number", "HIP 102188"},
        {"Smithsonian Astrophysical Observation", "SAO 106404"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.58363096),
        dec: Angle.Degrees(+12.63279717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223363"},
        {"Hipparcos Number", "HIP 117451"},
        {"Smithsonian Astrophysical Observation", "SAO 108850"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.22698023),
        dec: Angle.Degrees(+12.63310386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231825"},
        {"Hipparcos Number", "HIP 96224"},
        {"Geneva Identification System", "GEN# +1.00231825"},
        {"Smithsonian Astrophysical Observation", "SAO 104973"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.50915738),
        dec: Angle.Degrees(+12.63632211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -263.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154609"},
        {"Hipparcos Number", "HIP 83663"},
        {"Smithsonian Astrophysical Observation", "SAO 102591"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.49893002),
        dec: Angle.Degrees(+12.63936635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65737"},
        {"Hipparcos Number", "HIP 39164"},
        {"Smithsonian Astrophysical Observation", "SAO 97469"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.15177561),
        dec: Angle.Degrees(+12.64180933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61802",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61802"},
        {"Geneva Identification System", "GEN# +0.01302567"},
        {"Smithsonian Astrophysical Observation", "SAO 100198"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.99739481),
        dec: Angle.Degrees(+12.64301775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -317.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102227"},
        {"Hipparcos Number", "HIP 57391"},
        {"Smithsonian Astrophysical Observation", "SAO 99782"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.49506651),
        dec: Angle.Degrees(+12.64331388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55922",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55922"},
        {"Geneva Identification System", "GEN# +0.01302410"},
    },
    visualMagnitude: 10.60,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.91874705),
        dec: Angle.Degrees(+12.64530704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -349.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105322"},
        {"Hipparcos Number", "HIP 59137"},
        {"Geneva Identification System", "GEN# +1.00105322"},
        {"Smithsonian Astrophysical Observation", "SAO 99954"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.89997624),
        dec: Angle.Degrees(+12.64909077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9148"},
        {"Hipparcos Number", "HIP 7011"},
        {"Smithsonian Astrophysical Observation", "SAO 92468"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.56887107),
        dec: Angle.Degrees(+12.64940001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223982"},
        {"Hipparcos Number", "HIP 117854"},
        {"Smithsonian Astrophysical Observation", "SAO 108898"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.55591522),
        dec: Angle.Degrees(+12.64977774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50085",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50085"},
    },
    visualMagnitude: 11.82,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.38539768),
        dec: Angle.Degrees(+12.65130540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38899"},
        {"Hipparcos Number", "HIP 27511"},
        {"Celescope Catalog", "CEL 995"},
        {"Geneva Identification System", "GEN# +1.00038899"},
        {"Smithsonian Astrophysical Observation", "SAO 94888"},
        {"Wilson Evans Batten Catalogue", "WEB 5402"},
    },
    visualMagnitude: 4.89,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.38726446),
        dec: Angle.Degrees(+12.65136584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197104"},
        {"Hipparcos Number", "HIP 102077"},
        {"Geneva Identification System", "GEN# +1.00197104"},
        {"Smithsonian Astrophysical Observation", "SAO 106381"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.30084187),
        dec: Angle.Degrees(+12.65207579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64814"},
        {"Hipparcos Number", "HIP 38767"},
        {"Smithsonian Astrophysical Observation", "SAO 97384"},
    },
    visualMagnitude: 8.84,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.04025962),
        dec: Angle.Degrees(+12.65319821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48361",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48361"},
        {"Smithsonian Astrophysical Observation", "SAO 98812"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.88909066),
        dec: Angle.Degrees(+12.65400271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82865"},
        {"Hipparcos Number", "HIP 47022"},
        {"Geneva Identification System", "GEN# +1.00082865"},
        {"Smithsonian Astrophysical Observation", "SAO 98652"},
    },
    visualMagnitude: 6.81,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.74875205),
        dec: Angle.Degrees(+12.65456383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17084",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17084"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.90683997),
        dec: Angle.Degrees(+12.65474834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71250"},
        {"Hipparcos Number", "HIP 41400"},
        {"Fundamental Katalog 5th Edition", "FK5 2658"},
        {"Geneva Identification System", "GEN# +1.00071250"},
        {"Smithsonian Astrophysical Observation", "SAO 97819"},
        {"Wilson Evans Batten Catalogue", "WEB 8007"},
    },
    visualMagnitude: 5.56,
    bvColour: 1.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.68312445),
        dec: Angle.Degrees(+12.65486252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224932"},
        {"Hipparcos Number", "HIP 153"},
        {"Smithsonian Astrophysical Observation", "SAO 108970"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.48454484),
        dec: Angle.Degrees(+12.65495324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17608"},
        {"Hipparcos Number", "HIP 13201"},
        {"Geneva Identification System", "GEN# +1.00017608"},
        {"Smithsonian Astrophysical Observation", "SAO 93132"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.47277691),
        dec: Angle.Degrees(+12.65569458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15083",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15083"},
        {"Smithsonian Astrophysical Observation", "SAO 93353"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.63318669),
        dec: Angle.Degrees(+12.65701318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208529"},
        {"Hipparcos Number", "HIP 108307"},
        {"Smithsonian Astrophysical Observation", "SAO 107523"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.12650643),
        dec: Angle.Degrees(+12.65881849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19120"},
        {"Hipparcos Number", "HIP 14343"},
        {"Smithsonian Astrophysical Observation", "SAO 93263"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.24104580),
        dec: Angle.Degrees(+12.66005459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59764"},
        {"Hipparcos Number", "HIP 36631"},
        {"Geneva Identification System", "GEN# +1.00059764"},
        {"Smithsonian Astrophysical Observation", "SAO 96990"},
        {"Wilson Evans Batten Catalogue", "WEB 7281"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.99687271),
        dec: Angle.Degrees(+12.66139818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221813"},
        {"Hipparcos Number", "HIP 116396"},
        {"Smithsonian Astrophysical Observation", "SAO 108694"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.79540454),
        dec: Angle.Degrees(+12.66212254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150122"},
        {"Hipparcos Number", "HIP 81476"},
        {"Geneva Identification System", "GEN# +1.00150122"},
        {"Smithsonian Astrophysical Observation", "SAO 102283"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.62502246),
        dec: Angle.Degrees(+12.66216379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155073"},
        {"Hipparcos Number", "HIP 83908"},
        {"Smithsonian Astrophysical Observation", "SAO 102614"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.23336248),
        dec: Angle.Degrees(+12.66280059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102406"},
        {"Hipparcos Number", "HIP 57506"},
        {"Geneva Identification System", "GEN# +1.00102406"},
        {"Smithsonian Astrophysical Observation", "SAO 99790"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.81424107),
        dec: Angle.Degrees(+12.66451835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88520",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88520"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.14400903),
        dec: Angle.Degrees(+12.66514643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116032",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116032"},
        {"Smithsonian Astrophysical Observation", "SAO 108651"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.66685681),
        dec: Angle.Degrees(+12.66683058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96003"},
        {"Hipparcos Number", "HIP 54141"},
        {"Geneva Identification System", "GEN# +1.00096003"},
        {"Renson", "Renson 27650"},
        {"Smithsonian Astrophysical Observation", "SAO 99428"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.13890367),
        dec: Angle.Degrees(+12.66699449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25037",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3936 AB"},
        {"Henry Draper", "HD 34948"},
        {"Hipparcos Number", "HIP 25037"},
        {"Smithsonian Astrophysical Observation", "SAO 94490"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.41864458),
        dec: Angle.Degrees(+12.66838319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46659"},
        {"Hipparcos Number", "HIP 31427"},
        {"Smithsonian Astrophysical Observation", "SAO 95867"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.77962833),
        dec: Angle.Degrees(+12.66899342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109814"},
        {"Hipparcos Number", "HIP 61616"},
        {"Geneva Identification System", "GEN# +1.00109814"},
        {"Smithsonian Astrophysical Observation", "SAO 100182"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.40855466),
        dec: Angle.Degrees(+12.66955073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241430"},
        {"Hipparcos Number", "HIP 24181"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.88662202),
        dec: Angle.Degrees(+12.66998165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114215",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16524 AB"},
        {"Henry Draper", "HD 218430"},
        {"Hipparcos Number", "HIP 114215"},
        {"Smithsonian Astrophysical Observation", "SAO 108415"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.95064979),
        dec: Angle.Degrees(+12.67318989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 230275"},
        {"Hipparcos Number", "HIP 93154"},
        {"Smithsonian Astrophysical Observation", "SAO 104298"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.62793177),
        dec: Angle.Degrees(+12.67441288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81856"},
        {"Hipparcos Number", "HIP 46453"},
        {"Geneva Identification System", "GEN# +1.00081856"},
        {"Smithsonian Astrophysical Observation", "SAO 98591"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.11219745),
        dec: Angle.Degrees(+12.67529555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163286"},
        {"Hipparcos Number", "HIP 87701"},
        {"Smithsonian Astrophysical Observation", "SAO 103207"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.71297896),
        dec: Angle.Degrees(+12.67740224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65804"},
        {"Hipparcos Number", "HIP 39183"},
        {"Smithsonian Astrophysical Observation", "SAO 97474"},
    },
    visualMagnitude: 6.79,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.20467441),
        dec: Angle.Degrees(+12.67844914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200599"},
        {"Hipparcos Number", "HIP 103989"},
        {"Smithsonian Astrophysical Observation", "SAO 106813"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.03445855),
        dec: Angle.Degrees(+12.67864958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116378",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116378"},
        {"Smithsonian Astrophysical Observation", "SAO 108690"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.74003196),
        dec: Angle.Degrees(+12.67900633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121198"},
        {"Hipparcos Number", "HIP 67838"},
        {"Smithsonian Astrophysical Observation", "SAO 100755"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.43530451),
        dec: Angle.Degrees(+12.68026008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74228"},
        {"Henry Draper 2", "HD 74229"},
        {"Hipparcos Number", "HIP 42795"},
        {"Fundamental Katalog 5th Edition", "FK5 2686"},
        {"Geneva Identification System", "GEN# +1.00074228"},
        {"Smithsonian Astrophysical Observation", "SAO 98069"},
        {"Wilson Evans Batten Catalogue", "WEB 8264"},
    },
    visualMagnitude: 5.62,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.80139680),
        dec: Angle.Degrees(+12.68087080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195134"},
        {"Hipparcos Number", "HIP 101055"},
        {"Celescope Catalog", "CEL 5075"},
        {"Geneva Identification System", "GEN# +1.00195134"},
        {"Smithsonian Astrophysical Observation", "SAO 106152"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.28649040),
        dec: Angle.Degrees(+12.68104033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99048",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13377 A"},
        {"Henry Draper", "HD 190868"},
        {"Hipparcos Number", "HIP 99048"},
        {"Smithsonian Astrophysical Observation", "SAO 105697"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.64104907),
        dec: Angle.Degrees(+12.68164972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11520"},
        {"Hipparcos Number", "HIP 8827"},
        {"Geneva Identification System", "GEN# +1.00011520"},
        {"Smithsonian Astrophysical Observation", "SAO 92682"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.37477967),
        dec: Angle.Degrees(+12.68248358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99045",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13377 B"},
        {"Hipparcos Number", "HIP 99045"},
    },
    visualMagnitude: 12.65,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.63639686),
        dec: Angle.Degrees(+12.68324933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66938",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66938"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.77558811),
        dec: Angle.Degrees(+12.68497835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107774"},
        {"Hipparcos Number", "HIP 60403"},
        {"Geneva Identification System", "GEN# +1.00107774"},
        {"Smithsonian Astrophysical Observation", "SAO 100069"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.77129389),
        dec: Angle.Degrees(+12.68518324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12456"},
        {"Hipparcos Number", "HIP 9517"},
        {"Smithsonian Astrophysical Observation", "SAO 92761"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.60387105),
        dec: Angle.Degrees(+12.68519208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286988"},
        {"Hipparcos Number", "HIP 22012"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.97322952),
        dec: Angle.Degrees(+12.68576493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286798"},
        {"Hipparcos Number", "HIP 20745"},
        {"Geneva Identification System", "GEN# +5.20251404"},
    },
    visualMagnitude: 10.50,
    bvColour: 1.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.67812098),
        dec: Angle.Degrees(+12.68661875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62685",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62685"},
        {"Smithsonian Astrophysical Observation", "SAO 100297"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.67437530),
        dec: Angle.Degrees(+12.68683064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15747"},
        {"Hipparcos Number", "HIP 11795"},
        {"Smithsonian Astrophysical Observation", "SAO 92991"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.04925174),
        dec: Angle.Degrees(+12.68703050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111368"},
        {"Hipparcos Number", "HIP 62509"},
        {"Smithsonian Astrophysical Observation", "SAO 100273"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.15850156),
        dec: Angle.Degrees(+12.68798781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 145.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90630",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90630"},
        {"Smithsonian Astrophysical Observation", "SAO 103774"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.39093697),
        dec: Angle.Degrees(+12.68823373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83071"},
        {"Hipparcos Number", "HIP 47127"},
        {"Smithsonian Astrophysical Observation", "SAO 98664"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.04592303),
        dec: Angle.Degrees(+12.68863306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67744"},
        {"Hipparcos Number", "HIP 39978"},
        {"Geneva Identification System", "GEN# +1.00067744"},
        {"Smithsonian Astrophysical Observation", "SAO 97611"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.46374800),
        dec: Angle.Degrees(+12.68913840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185206"},
        {"Hipparcos Number", "HIP 96539"},
        {"Geneva Identification System", "GEN# +1.00185206"},
        {"Smithsonian Astrophysical Observation", "SAO 105067"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.39829346),
        dec: Angle.Degrees(+12.69017115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114171",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114171"},
        {"Cincinnati Publication", "Ci 20 1402"},
        {"Geneva Identification System", "GEN# +0.01104935"},
        {"Smithsonian Astrophysical Observation", "SAO 108409"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.81981005),
        dec: Angle.Degrees(+12.69098569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 440.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6850"},
        {"Hipparcos Number", "HIP 5407"},
        {"Smithsonian Astrophysical Observation", "SAO 92277"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.29643470),
        dec: Angle.Degrees(+12.69300816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48843"},
        {"Hipparcos Number", "HIP 32404"},
        {"Geneva Identification System", "GEN# +1.00048843"},
        {"Smithsonian Astrophysical Observation", "SAO 96084"},
        {"Wilson Evans Batten Catalogue", "WEB 6535"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.47583193),
        dec: Angle.Degrees(+12.69356775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1497",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1497"},
        {"Smithsonian Astrophysical Observation", "SAO 91838"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.67071041),
        dec: Angle.Degrees(+12.69492362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107390",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107390"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.26918153),
        dec: Angle.Degrees(+12.69863354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32562"},
        {"Hipparcos Number", "HIP 23616"},
        {"Celescope Catalog", "CEL 527"},
        {"Geneva Identification System", "GEN# +1.00032562"},
        {"Smithsonian Astrophysical Observation", "SAO 94292"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.15923462),
        dec: Angle.Degrees(+12.69868057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30014",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4921 AC"},
        {"Henry Draper", "HD 43840"},
        {"Hipparcos Number", "HIP 30014"},
        {"Geneva Identification System", "GEN# +1.00043840"},
        {"Smithsonian Astrophysical Observation", "SAO 95520"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.74846428),
        dec: Angle.Degrees(+12.70142698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112277"},
        {"Hipparcos Number", "HIP 63080"},
        {"Geneva Identification System", "GEN# +1.00112277"},
        {"Smithsonian Astrophysical Observation", "SAO 100336"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.87326939),
        dec: Angle.Degrees(+12.70214775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102400",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14238 CR"},
        {"Henry Draper", "HD 197704"},
        {"Hipparcos Number", "HIP 102400"},
        {"Smithsonian Astrophysical Observation", "SAO 106447"},
        {"Wilson Evans Batten Catalogue", "WEB 18539"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.26255955),
        dec: Angle.Degrees(+12.70234022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117079"},
        {"Hipparcos Number", "HIP 65665"},
        {"Geneva Identification System", "GEN# +1.00117079"},
        {"Smithsonian Astrophysical Observation", "SAO 100575"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.94061734),
        dec: Angle.Degrees(+12.70279573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96346"},
        {"Hipparcos Number", "HIP 54300"},
        {"Smithsonian Astrophysical Observation", "SAO 99441"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.63337026),
        dec: Angle.Degrees(+12.70341466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209300"},
        {"Hipparcos Number", "HIP 108775"},
        {"Smithsonian Astrophysical Observation", "SAO 107602"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.52388806),
        dec: Angle.Degrees(+12.70458528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47362",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47362"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.74879731),
        dec: Angle.Degrees(+12.70532739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10476",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10476"},
        {"Smithsonian Astrophysical Observation", "SAO 92854"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.76081891),
        dec: Angle.Degrees(+12.70995298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 529"},
        {"Hipparcos Number", "HIP 799"},
        {"Smithsonian Astrophysical Observation", "SAO 91749"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.46856966),
        dec: Angle.Degrees(+12.71084240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110249"},
        {"Hipparcos Number", "HIP 61869"},
        {"Geneva Identification System", "GEN# +1.00110249"},
        {"Smithsonian Astrophysical Observation", "SAO 100203"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.18283652),
        dec: Angle.Degrees(+12.71545526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15532",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15532"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.02804511),
        dec: Angle.Degrees(+12.71864496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210909"},
        {"Hipparcos Number", "HIP 109716"},
        {"Geneva Identification System", "GEN# +1.00210909"},
        {"Smithsonian Astrophysical Observation", "SAO 107743"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.35497662),
        dec: Angle.Degrees(+12.72139532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104067",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14610 A"},
        {"Henry Draper", "HD 200757"},
        {"Hipparcos Number", "HIP 104067"},
        {"Smithsonian Astrophysical Observation", "SAO 106823"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.25919006),
        dec: Angle.Degrees(+12.72239377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104066",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14610 BC"},
        {"Hipparcos Number", "HIP 104066"},
    },
    visualMagnitude: 9.05,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.25464141),
        dec: Angle.Degrees(+12.72317534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33748",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5676 A"},
        {"Henry Draper", "HD 52155"},
        {"Hipparcos Number", "HIP 33748"},
        {"Smithsonian Astrophysical Observation", "SAO 96372"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.15465009),
        dec: Angle.Degrees(+12.72339472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141458"},
        {"Hipparcos Number", "HIP 77455"},
        {"Celescope Catalog", "CEL 4396"},
        {"Geneva Identification System", "GEN# +1.00141458"},
        {"Smithsonian Astrophysical Observation", "SAO 101753"},
        {"Wilson Evans Batten Catalogue", "WEB 13116"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.21038602),
        dec: Angle.Degrees(+12.72363804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116574",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116574"},
        {"Geneva Identification System", "GEN# +9.80029055"},
    },
    visualMagnitude: 11.62,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.35272077),
        dec: Angle.Degrees(+12.72520727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 179.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -514.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122833"},
        {"Hipparcos Number", "HIP 68706"},
        {"Smithsonian Astrophysical Observation", "SAO 100833"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.97961730),
        dec: Angle.Degrees(+12.72617212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102398",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14238 AB"},
        {"Henry Draper", "HD 197683"},
        {"Hipparcos Number", "HIP 102398"},
        {"Geneva Identification System", "GEN# +1.00197683J"},
        {"Smithsonian Astrophysical Observation", "SAO 106446"},
        {"Wilson Evans Batten Catalogue", "WEB 18538"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.25103740),
        dec: Angle.Degrees(+12.72674952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102206",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102206"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.63947772),
        dec: Angle.Degrees(+12.72830162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286929"},
        {"Hipparcos Number", "HIP 21723"},
        {"Geneva Identification System", "GEN# +5.20252080"},
    },
    visualMagnitude: 10.04,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.96212962),
        dec: Angle.Degrees(+12.72851730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90208"},
        {"Hipparcos Number", "HIP 50990"},
        {"Fundamental Katalog 5th Edition", "FK5 4925"},
        {"Smithsonian Astrophysical Observation", "SAO 99104"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.24417549),
        dec: Angle.Degrees(+12.73020346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147057"},
        {"Hipparcos Number", "HIP 79947"},
        {"Geneva Identification System", "GEN# +1.00147057"},
        {"Smithsonian Astrophysical Observation", "SAO 102081"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.78609744),
        dec: Angle.Degrees(+12.73020524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114659"},
        {"Hipparcos Number", "HIP 64387"},
        {"Geneva Identification System", "GEN# +1.00114659"},
        {"Smithsonian Astrophysical Observation", "SAO 100454"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.95298606),
        dec: Angle.Degrees(+12.73045884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76707",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76707"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.94655695),
        dec: Angle.Degrees(+12.73367228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286891"},
        {"Hipparcos Number", "HIP 21306"},
        {"Geneva Identification System", "GEN# +1.00286891"},
        {"Smithsonian Astrophysical Observation", "SAO 94013"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.60813313),
        dec: Angle.Degrees(+12.73501673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -331.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21379"},
        {"Hipparcos Number", "HIP 16095"},
        {"Geneva Identification System", "GEN# +1.00021379"},
        {"Smithsonian Astrophysical Observation", "SAO 93439"},
        {"Wilson Evans Batten Catalogue", "WEB 3070"},
    },
    visualMagnitude: 6.29,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.82779564),
        dec: Angle.Degrees(+12.73530724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12657",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12657"},
        {"Geneva Identification System", "GEN# +0.01200378"},
        {"Smithsonian Astrophysical Observation", "SAO 93068"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.65148299),
        dec: Angle.Degrees(+12.73557017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83362"},
        {"Hipparcos Number", "HIP 47291"},
        {"Geneva Identification System", "GEN# +1.00083362"},
        {"Smithsonian Astrophysical Observation", "SAO 98687"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.56695073),
        dec: Angle.Degrees(+12.73629270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160247"},
        {"Hipparcos Number", "HIP 86333"},
        {"Smithsonian Astrophysical Observation", "SAO 102987"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.60545403),
        dec: Angle.Degrees(+12.73733163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47313"},
        {"Hipparcos Number", "HIP 31755"},
        {"Geneva Identification System", "GEN# +1.00047313"},
        {"Smithsonian Astrophysical Observation", "SAO 95934"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.63743636),
        dec: Angle.Degrees(+12.73835686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33753",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5676 D"},
        {"Henry Draper", "HD 52154"},
        {"Hipparcos Number", "HIP 33753"},
        {"Geneva Identification System", "GEN# +1.00052154"},
        {"Smithsonian Astrophysical Observation", "SAO 96373"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.16381838),
        dec: Angle.Degrees(+12.74001616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83613",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10334 A"},
        {"Henry Draper", "HD 154494"},
        {"Hipparcos Number", "HIP 83613"},
        {"Fundamental Katalog 5th Edition", "FK5 635"},
        {"Geneva Identification System", "GEN# +1.00154494"},
        {"Smithsonian Astrophysical Observation", "SAO 102584"},
        {"Wilson Evans Batten Catalogue", "WEB 14142"},
    },
    visualMagnitude: 4.89,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.34441753),
        dec: Angle.Degrees(+12.74085469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69893",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69893"},
        {"Geneva Identification System", "GEN# +0.01302777"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.55118825),
        dec: Angle.Degrees(+12.74214351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -281.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222611"},
        {"Hipparcos Number", "HIP 116923"},
        {"Geneva Identification System", "GEN# +1.00222611"},
        {"Smithsonian Astrophysical Observation", "SAO 108778"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.50118556),
        dec: Angle.Degrees(+12.74381899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94319"},
        {"Hipparcos Number", "HIP 53234"},
        {"Geneva Identification System", "GEN# +1.00094319"},
        {"Smithsonian Astrophysical Observation", "SAO 99344"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.34360724),
        dec: Angle.Degrees(+12.74631645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229594"},
        {"Hipparcos Number", "HIP 92337"},
        {"Smithsonian Astrophysical Observation", "SAO 104132"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.28536001),
        dec: Angle.Degrees(+12.74661822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43873"},
        {"Hipparcos Number", "HIP 30025"},
        {"Celescope Catalog", "CEL 1168"},
        {"Geneva Identification System", "GEN# +1.00043873"},
        {"Smithsonian Astrophysical Observation", "SAO 95524"},
    },
    visualMagnitude: 6.73,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.77612739),
        dec: Angle.Degrees(+12.74674160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50049",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50049"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.27364982),
        dec: Angle.Degrees(+12.74762098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93273"},
        {"Hipparcos Number", "HIP 52683"},
        {"Smithsonian Astrophysical Observation", "SAO 99280"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.58048566),
        dec: Angle.Degrees(+12.74792128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195791"},
        {"Hipparcos Number", "HIP 101410"},
        {"Geneva Identification System", "GEN# +1.00195791"},
        {"Smithsonian Astrophysical Observation", "SAO 106227"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.27092186),
        dec: Angle.Degrees(+12.74836657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86662",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86662"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.60659154),
        dec: Angle.Degrees(+12.74907507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6431",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6431"},
        {"Cincinnati Publication", "Ci 18 180"},
        {"Cincinnati Publication 2", "Ci 20 99"},
        {"Geneva Identification System", "GEN# +0.01200168J"},
        {"Smithsonian Astrophysical Observation", "SAO 92401"},
        {"Wilson Evans Batten Catalogue", "WEB 1424"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.65150360),
        dec: Angle.Degrees(+12.75092621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 403.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208189"},
        {"Hipparcos Number", "HIP 108127"},
        {"Smithsonian Astrophysical Observation", "SAO 107488"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.59178609),
        dec: Angle.Degrees(+12.75109169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15352"},
        {"Hipparcos Number", "HIP 11518"},
        {"Geneva Identification System", "GEN# +1.00015352"},
        {"Smithsonian Astrophysical Observation", "SAO 92967"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.13771490),
        dec: Angle.Degrees(+12.75244695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88861",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88861"},
        {"Smithsonian Astrophysical Observation", "SAO 103413"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.13808177),
        dec: Angle.Degrees(+12.75302589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26703"},
        {"Hipparcos Number", "HIP 19736"},
        {"Geneva Identification System", "GEN# +1.00026703"},
        {"Smithsonian Astrophysical Observation", "SAO 93823"},
        {"Wilson Evans Batten Catalogue", "WEB 3764"},
    },
    visualMagnitude: 6.25,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.45762496),
        dec: Angle.Degrees(+12.75374144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219294"},
        {"Hipparcos Number", "HIP 114744"},
        {"Smithsonian Astrophysical Observation", "SAO 108482"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.65229778),
        dec: Angle.Degrees(+12.75573744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206375"},
        {"Hipparcos Number", "HIP 107085"},
        {"Smithsonian Astrophysical Observation", "SAO 107324"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.34953209),
        dec: Angle.Degrees(+12.75580208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164714"},
        {"Hipparcos Number", "HIP 88304"},
        {"Smithsonian Astrophysical Observation", "SAO 103314"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.49317657),
        dec: Angle.Degrees(+12.75780099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59152"},
        {"Hipparcos Number", "HIP 36371"},
        {"Geneva Identification System", "GEN# +1.00059152"},
        {"Smithsonian Astrophysical Observation", "SAO 96937"},
        {"Wilson Evans Batten Catalogue", "WEB 7239"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.29721613),
        dec: Angle.Degrees(+12.76006690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221115"},
        {"Hipparcos Number", "HIP 115919"},
        {"Fundamental Katalog 5th Edition", "FK5 885"},
        {"Geneva Identification System", "GEN# +1.00221115"},
        {"Smithsonian Astrophysical Observation", "SAO 108638"},
        {"Wilson Evans Batten Catalogue", "WEB 20503"},
    },
    visualMagnitude: 4.54,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.28858456),
        dec: Angle.Degrees(+12.76049243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92183"},
        {"Hipparcos Number", "HIP 52107"},
        {"Smithsonian Astrophysical Observation", "SAO 99227"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.69878923),
        dec: Angle.Degrees(+12.76145771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125816"},
        {"Hipparcos Number", "HIP 70181"},
        {"Geneva Identification System", "GEN# +1.00125816"},
        {"Smithsonian Astrophysical Observation", "SAO 100990"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.38485728),
        dec: Angle.Degrees(+12.76549823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67281",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67281"},
        {"Smithsonian Astrophysical Observation", "SAO 100707"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.83619098),
        dec: Angle.Degrees(+12.76594282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97991",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97991"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.72001647),
        dec: Angle.Degrees(+12.76621317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24923"},
        {"Hipparcos Number", "HIP 18549"},
        {"Smithsonian Astrophysical Observation", "SAO 93694"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.52708324),
        dec: Angle.Degrees(+12.76942851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102695"},
        {"Hipparcos Number", "HIP 57662"},
        {"Smithsonian Astrophysical Observation", "SAO 99814"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.38727219),
        dec: Angle.Degrees(+12.76993330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -183.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1375"},
        {"Hipparcos Number", "HIP 1439"},
        {"Fundamental Katalog 5th Edition", "FK5 4033"},
        {"Geneva Identification System", "GEN# +1.00001375"},
        {"Smithsonian Astrophysical Observation", "SAO 91828"},
        {"Wilson Evans Batten Catalogue", "WEB 263"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.48462707),
        dec: Angle.Degrees(+12.77151352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1662"},
        {"Hipparcos Number", "HIP 1677"},
        {"Geneva Identification System", "GEN# +1.00001662"},
        {"Smithsonian Astrophysical Observation", "SAO 91859"},
        {"Wilson Evans Batten Catalogue", "WEB 307"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.24766205),
        dec: Angle.Degrees(+12.77166455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82789",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82789"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.78178036),
        dec: Angle.Degrees(+12.77392508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35217"},
        {"Hipparcos Number", "HIP 25228"},
        {"Smithsonian Astrophysical Observation", "SAO 94516"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.93272079),
        dec: Angle.Degrees(+12.77579604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64704",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64704"},
        {"Geneva Identification System", "GEN# +0.01302647"},
        {"Smithsonian Astrophysical Observation", "SAO 100480"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.91670163),
        dec: Angle.Degrees(+12.77684653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71372"},
        {"Hipparcos Number", "HIP 41474"},
        {"Geneva Identification System", "GEN# +1.00071372"},
        {"Smithsonian Astrophysical Observation", "SAO 97826"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.88824577),
        dec: Angle.Degrees(+12.77751428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118915"},
        {"Hipparcos Number", "HIP 66653"},
        {"Geneva Identification System", "GEN# +1.00118915"},
        {"Smithsonian Astrophysical Observation", "SAO 100655"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.94363222),
        dec: Angle.Degrees(+12.77785456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212303"},
        {"Hipparcos Number", "HIP 110501"},
        {"Fundamental Katalog 5th Edition", "FK5 5974"},
        {"Smithsonian Astrophysical Observation", "SAO 107871"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.77244628),
        dec: Angle.Degrees(+12.78132746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87647"},
        {"Hipparcos Number", "HIP 49518"},
        {"Geneva Identification System", "GEN# +1.00087647"},
        {"Smithsonian Astrophysical Observation", "SAO 98949"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.65516829),
        dec: Angle.Degrees(+12.78211251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1922",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1922"},
    },
    visualMagnitude: 10.36,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.06865039),
        dec: Angle.Degrees(+12.78380281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130950"},
        {"Hipparcos Number", "HIP 72594"},
        {"Smithsonian Astrophysical Observation", "SAO 101241"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.64584786),
        dec: Angle.Degrees(+12.78418868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4025",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 702 A"},
        {"Henry Draper", "HD 4935"},
        {"Hipparcos Number", "HIP 4025"},
        {"Geneva Identification System", "GEN# +1.00004935J"},
        {"Smithsonian Astrophysical Observation", "SAO 92123"},
        {"Wilson Evans Batten Catalogue", "WEB 722"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.89515300),
        dec: Angle.Degrees(+12.78482380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112503",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112503"},
    },
    visualMagnitude: 11.28,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.83376540),
        dec: Angle.Degrees(+12.78551449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 231.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38308"},
        {"Hipparcos Number", "HIP 27153"},
        {"Geneva Identification System", "GEN# +1.00038308"},
        {"Smithsonian Astrophysical Observation", "SAO 94835"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.34412203),
        dec: Angle.Degrees(+12.78935071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63927",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63927"},
    },
    visualMagnitude: 11.00,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.50783417),
        dec: Angle.Degrees(+12.79173872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17379",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17379"},
        {"Smithsonian Astrophysical Observation", "SAO 93566"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.82542077),
        dec: Angle.Degrees(+12.79397294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287120"},
        {"Hipparcos Number", "HIP 22583"},
        {"Smithsonian Astrophysical Observation", "SAO 94167"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.90139593),
        dec: Angle.Degrees(+12.79419692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194823"},
        {"Hipparcos Number", "HIP 100899"},
        {"Smithsonian Astrophysical Observation", "SAO 106123"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.87456130),
        dec: Angle.Degrees(+12.79837836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145891"},
        {"Hipparcos Number", "HIP 79465"},
        {"Fundamental Katalog 5th Edition", "FK5 3282"},
        {"Geneva Identification System", "GEN# +1.00145891"},
        {"Smithsonian Astrophysical Observation", "SAO 102012"},
        {"Wilson Evans Batten Catalogue", "WEB 13442"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.24067424),
        dec: Angle.Degrees(+12.80063648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37147",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37147"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.50355540),
        dec: Angle.Degrees(+12.80146606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72256"},
        {"Hipparcos Number", "HIP 41865"},
        {"Geneva Identification System", "GEN# +1.00072256"},
        {"Smithsonian Astrophysical Observation", "SAO 97890"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.04741894),
        dec: Angle.Degrees(+12.80278942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128720"},
        {"Hipparcos Number", "HIP 71556"},
        {"Smithsonian Astrophysical Observation", "SAO 101119"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.52397650),
        dec: Angle.Degrees(+12.80378573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 435"},
        {"Hipparcos Number", "HIP 722"},
        {"Geneva Identification System", "GEN# +1.00000435"},
        {"Smithsonian Astrophysical Observation", "SAO 91733"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.23568502),
        dec: Angle.Degrees(+12.80447200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101460"},
        {"Hipparcos Number", "HIP 56958"},
        {"Smithsonian Astrophysical Observation", "SAO 99728"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.14891101),
        dec: Angle.Degrees(+12.80609398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216141"},
        {"Hipparcos Number", "HIP 112770"},
        {"Geneva Identification System", "GEN# +1.00216141"},
        {"Smithsonian Astrophysical Observation", "SAO 108209"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.56584803),
        dec: Angle.Degrees(+12.80620651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104622"},
        {"Hipparcos Number", "HIP 58743"},
        {"Geneva Identification System", "GEN# +1.00104622"},
        {"Smithsonian Astrophysical Observation", "SAO 99924"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.72245611),
        dec: Angle.Degrees(+12.80743098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28302",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4562 AB"},
        {"Henry Draper", "HD 40369"},
        {"Henry Draper 2", "HD 40370"},
        {"Hipparcos Number", "HIP 28302"},
        {"Geneva Identification System", "GEN# +1.00040369J"},
        {"Smithsonian Astrophysical Observation", "SAO 95075"},
        {"Wilson Evans Batten Catalogue", "WEB 5535"},
    },
    visualMagnitude: 5.70,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.72184012),
        dec: Angle.Degrees(+12.80825741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12316"},
        {"Hipparcos Number", "HIP 9430"},
        {"Smithsonian Astrophysical Observation", "SAO 92751"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.28196760),
        dec: Angle.Degrees(+12.80835047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3361",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3361"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.69966079),
        dec: Angle.Degrees(+12.81161830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 193.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70277"},
        {"Hipparcos Number", "HIP 40956"},
        {"Geneva Identification System", "GEN# +1.00070277"},
        {"Smithsonian Astrophysical Observation", "SAO 97752"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.37451908),
        dec: Angle.Degrees(+12.81335606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71721",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71721"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.06572682),
        dec: Angle.Degrees(+12.81417575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63475"},
        {"Hipparcos Number", "HIP 38196"},
        {"Smithsonian Astrophysical Observation", "SAO 97280"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.38465527),
        dec: Angle.Degrees(+12.81429540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66830",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66830"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.44979051),
        dec: Angle.Degrees(+12.81467328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17065",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17065"},
        {"Smithsonian Astrophysical Observation", "SAO 93539"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.86831219),
        dec: Angle.Degrees(+12.81520936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186886"},
        {"Hipparcos Number", "HIP 97310"},
        {"Smithsonian Astrophysical Observation", "SAO 105236"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.64862015),
        dec: Angle.Degrees(+12.81698610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183756"},
        {"Hipparcos Number", "HIP 95926"},
        {"Smithsonian Astrophysical Observation", "SAO 104914"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.63227010),
        dec: Angle.Degrees(+12.81701919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140557"},
        {"Hipparcos Number", "HIP 77041"},
        {"Smithsonian Astrophysical Observation", "SAO 101703"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.97849844),
        dec: Angle.Degrees(+12.81836083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 631"},
        {"Hipparcos Number", "HIP 867"},
        {"Geneva Identification System", "GEN# +1.00000631"},
        {"Smithsonian Astrophysical Observation", "SAO 91759"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.66293453),
        dec: Angle.Degrees(+12.82027132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66138",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66138"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.36947682),
        dec: Angle.Degrees(+12.82035350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224304"},
        {"Hipparcos Number", "HIP 118047"},
        {"Smithsonian Astrophysical Observation", "SAO 108920"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.17019457),
        dec: Angle.Degrees(+12.82057559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20500"},
        {"Hipparcos Number", "HIP 15375"},
        {"Fundamental Katalog 5th Edition", "FK5 4302"},
        {"Smithsonian Astrophysical Observation", "SAO 93375"},
        {"Wilson Evans Batten Catalogue", "WEB 2956"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.56319632),
        dec: Angle.Degrees(+12.82386114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 356342"},
        {"Hipparcos Number", "HIP 98247"},
        {"Smithsonian Astrophysical Observation", "SAO 105472"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.47427500),
        dec: Angle.Degrees(+12.82414189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31830"},
        {"Hipparcos Number", "HIP 23197"},
        {"Smithsonian Astrophysical Observation", "SAO 94246"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.88218615),
        dec: Angle.Degrees(+12.82602954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49655",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49655"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.05970594),
        dec: Angle.Degrees(+12.83296858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103270",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103270"},
        {"Smithsonian Astrophysical Observation", "SAO 106656"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.82244289),
        dec: Angle.Degrees(+12.83337433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143162"},
        {"Hipparcos Number", "HIP 78223"},
        {"Smithsonian Astrophysical Observation", "SAO 101844"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.60179490),
        dec: Angle.Degrees(+12.83518477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55604",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55604"},
        {"Smithsonian Astrophysical Observation", "SAO 99584"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.87167921),
        dec: Angle.Degrees(+12.83588727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204094"},
        {"Hipparcos Number", "HIP 105827"},
        {"Smithsonian Astrophysical Observation", "SAO 107131"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.50972633),
        dec: Angle.Degrees(+12.84012681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93584"},
        {"Hipparcos Number", "HIP 52915"},
        {"Smithsonian Astrophysical Observation", "SAO 99306"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.33242870),
        dec: Angle.Degrees(+12.84274057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -149.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193688"},
        {"Hipparcos Number", "HIP 100353"},
        {"Smithsonian Astrophysical Observation", "SAO 106003"},
    },
    visualMagnitude: 8.12,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.29264868),
        dec: Angle.Degrees(+12.84301027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97937"},
        {"Hipparcos Number", "HIP 55033"},
        {"Geneva Identification System", "GEN# +1.00097937"},
        {"Smithsonian Astrophysical Observation", "SAO 99527"},
        {"Wilson Evans Batten Catalogue", "WEB 9928"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.99092933),
        dec: Angle.Degrees(+12.84493549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16822"},
        {"Hipparcos Number", "HIP 12626"},
        {"Smithsonian Astrophysical Observation", "SAO 93064"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.57281687),
        dec: Angle.Degrees(+12.84618878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7621",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7621"},
        {"Smithsonian Astrophysical Observation", "SAO 92546"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.54178341),
        dec: Angle.Degrees(+12.84620931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11280",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11280"},
    },
    visualMagnitude: 11.63,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.31929511),
        dec: Angle.Degrees(+12.84717445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5309"},
        {"Hipparcos Number", "HIP 4294"},
        {"Geneva Identification System", "GEN# +1.00005309"},
        {"Smithsonian Astrophysical Observation", "SAO 92149"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.75345820),
        dec: Angle.Degrees(+12.84743885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140160"},
        {"Hipparcos Number", "HIP 76866"},
        {"Fundamental Katalog 5th Edition", "FK5 3243"},
        {"Geneva Identification System", "GEN# +1.00140160"},
        {"Renson", "Renson 39840"},
        {"Smithsonian Astrophysical Observation", "SAO 101683"},
        {"Wilson Evans Batten Catalogue", "WEB 13039"},
    },
    visualMagnitude: 5.34,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.44746556),
        dec: Angle.Degrees(+12.84753869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87372"},
        {"Hipparcos Number", "HIP 49381"},
        {"Geneva Identification System", "GEN# +1.00087372"},
        {"Smithsonian Astrophysical Observation", "SAO 98934"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.22627531),
        dec: Angle.Degrees(+12.84768419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49247",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49247"},
        {"Smithsonian Astrophysical Observation", "SAO 98922"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.80128481),
        dec: Angle.Degrees(+12.84810990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111440",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111440"},
        {"Smithsonian Astrophysical Observation", "SAO 108010"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.64169474),
        dec: Angle.Degrees(+12.84811569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58417",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58417"},
        {"Smithsonian Astrophysical Observation", "SAO 99889"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.66643674),
        dec: Angle.Degrees(+12.85474470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56589",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8230 AB"},
        {"Henry Draper", "HD 100797"},
        {"Hipparcos Number", "HIP 56589"},
        {"Smithsonian Astrophysical Observation", "SAO 99686"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.02823583),
        dec: Angle.Degrees(+12.85523582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127540"},
        {"Hipparcos Number", "HIP 71034"},
        {"Geneva Identification System", "GEN# +1.00127540"},
        {"Smithsonian Astrophysical Observation", "SAO 101065"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.92022073),
        dec: Angle.Degrees(+12.85625957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183421"},
        {"Hipparcos Number", "HIP 95791"},
        {"Geneva Identification System", "GEN# +1.00183421"},
        {"Renson", "Renson 50650"},
        {"Smithsonian Astrophysical Observation", "SAO 104885"},
        {"Wilson Evans Batten Catalogue", "WEB 16769"},
    },
    visualMagnitude: 7.45,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.25002842),
        dec: Angle.Degrees(+12.85819711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82265"},
        {"Hipparcos Number", "HIP 46713"},
        {"Smithsonian Astrophysical Observation", "SAO 98624"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.83404931),
        dec: Angle.Degrees(+12.85891070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19551"},
        {"Hipparcos Number", "HIP 14631"},
        {"Geneva Identification System", "GEN# +1.00019551"},
        {"Smithsonian Astrophysical Observation", "SAO 93301"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.25393350),
        dec: Angle.Degrees(+12.85965179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62407"},
        {"Hipparcos Number", "HIP 37723"},
        {"Smithsonian Astrophysical Observation", "SAO 97199"},
        {"Wilson Evans Batten Catalogue", "WEB 7456"},
    },
    visualMagnitude: 6.40,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.05860871),
        dec: Angle.Degrees(+12.86011602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44851"},
        {"Hipparcos Number", "HIP 30494"},
        {"Smithsonian Astrophysical Observation", "SAO 95638"},
        {"Wilson Evans Batten Catalogue", "WEB 6069"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.15250472),
        dec: Angle.Degrees(+12.86078066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216919"},
        {"Hipparcos Number", "HIP 113319"},
        {"Smithsonian Astrophysical Observation", "SAO 108276"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.23974513),
        dec: Angle.Degrees(+12.86127204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44318"},
        {"Hipparcos Number", "HIP 30245"},
        {"Geneva Identification System", "GEN# +1.00044318"},
        {"Smithsonian Astrophysical Observation", "SAO 95580"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.43736813),
        dec: Angle.Degrees(+12.86195604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60801"},
        {"Hipparcos Number", "HIP 37045"},
        {"Smithsonian Astrophysical Observation", "SAO 97078"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.19166056),
        dec: Angle.Degrees(+12.86552437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147868"},
        {"Hipparcos Number", "HIP 80332"},
        {"Smithsonian Astrophysical Observation", "SAO 102130"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.99985887),
        dec: Angle.Degrees(+12.86603134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91910"},
        {"Hipparcos Number", "HIP 51968"},
        {"Smithsonian Astrophysical Observation", "SAO 99210"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.25682900),
        dec: Angle.Degrees(+12.86618159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 230853"},
        {"Hipparcos Number", "HIP 94314"},
        {"Smithsonian Astrophysical Observation", "SAO 104577"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.94685059),
        dec: Angle.Degrees(+12.87113627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75804",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75804"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.28882286),
        dec: Angle.Degrees(+12.87122715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3718",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3718"},
        {"Smithsonian Astrophysical Observation", "SAO 92089"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.93164546),
        dec: Angle.Degrees(+12.87224330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117717",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17069 AB"},
        {"Henry Draper", "HD 223769"},
        {"Hipparcos Number", "HIP 117717"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.12181755),
        dec: Angle.Degrees(+12.87283934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128481"},
        {"Hipparcos Number", "HIP 71452"},
        {"Smithsonian Astrophysical Observation", "SAO 101105"},
        {"Wilson Evans Batten Catalogue", "WEB 12328"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.18195641),
        dec: Angle.Degrees(+12.87814986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27725",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4461 A"},
        {"Henry Draper", "HD 39306"},
        {"Hipparcos Number", "HIP 27725"},
        {"Smithsonian Astrophysical Observation", "SAO 94944"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.06401595),
        dec: Angle.Degrees(+12.87833770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150857"},
        {"Hipparcos Number", "HIP 81863"},
        {"Smithsonian Astrophysical Observation", "SAO 102342"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.81119331),
        dec: Angle.Degrees(+12.87838301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4552"},
        {"Hipparcos Number", "HIP 3712"},
        {"Smithsonian Astrophysical Observation", "SAO 92088"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.92129534),
        dec: Angle.Degrees(+12.87936579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154861"},
        {"Hipparcos Number", "HIP 83793"},
        {"Geneva Identification System", "GEN# +1.00154861"},
        {"Smithsonian Astrophysical Observation", "SAO 102604"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.87671834),
        dec: Angle.Degrees(+12.87940359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34134"},
        {"Hipparcos Number", "HIP 24527"},
        {"Smithsonian Astrophysical Observation", "SAO 94423"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.93008127),
        dec: Angle.Degrees(+12.87960041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 149.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4677"},
        {"Hipparcos Number", "HIP 3808"},
        {"Smithsonian Astrophysical Observation", "SAO 92098"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.23721271),
        dec: Angle.Degrees(+12.87970265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151782"},
        {"Hipparcos Number", "HIP 82304"},
        {"Smithsonian Astrophysical Observation", "SAO 102405"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.25162612),
        dec: Angle.Degrees(+12.88196827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179561"},
        {"Hipparcos Number", "HIP 94380"},
        {"Smithsonian Astrophysical Observation", "SAO 104598"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.14946420),
        dec: Angle.Degrees(+12.88282964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52333",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52333"},
        {"Smithsonian Astrophysical Observation", "SAO 99250"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.42422959),
        dec: Angle.Degrees(+12.88436814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133925"},
        {"Hipparcos Number", "HIP 73951"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.67924457),
        dec: Angle.Degrees(+12.88810236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38263"},
        {"Hipparcos Number", "HIP 27116"},
        {"Smithsonian Astrophysical Observation", "SAO 94827"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.25541760),
        dec: Angle.Degrees(+12.88836458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93268",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11916 B"},
        {"Henry Draper", "HD 176485"},
        {"Hipparcos Number", "HIP 93268"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.99014511),
        dec: Angle.Degrees(+12.88928589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93273",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11916 A"},
        {"Henry Draper", "HD 176486"},
        {"Hipparcos Number", "HIP 93273"},
        {"Smithsonian Astrophysical Observation", "SAO 104332"},
        {"Wilson Evans Batten Catalogue", "WEB 16173"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.99482683),
        dec: Angle.Degrees(+12.89003495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78968"},
        {"Hipparcos Number", "HIP 45107"},
        {"Geneva Identification System", "GEN# +1.00078968"},
        {"Smithsonian Astrophysical Observation", "SAO 98421"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.85642603),
        dec: Angle.Degrees(+12.89108529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72679",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72679"},
        {"Smithsonian Astrophysical Observation", "SAO 101253"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.90146402),
        dec: Angle.Degrees(+12.89484851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39771"},
        {"Hipparcos Number", "HIP 27997"},
        {"Geneva Identification System", "GEN# +1.00039771"},
        {"Smithsonian Astrophysical Observation", "SAO 94993"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.81587894),
        dec: Angle.Degrees(+12.89536438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58464",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58464"},
        {"Geneva Identification System", "GEN# +0.01302479"},
        {"Smithsonian Astrophysical Observation", "SAO 99895"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.84506040),
        dec: Angle.Degrees(+12.89550557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32362",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alzirr"},
        {"Henry Draper", "HD 48737"},
        {"Hipparcos Number", "HIP 32362"},
        {"Fundamental Katalog 5th Edition", "FK5 256"},
        {"Geneva Identification System", "GEN# +1.00048737"},
        {"Smithsonian Astrophysical Observation", "SAO 96074"},
        {"Wilson Evans Batten Catalogue", "WEB 6527"},
    },
    visualMagnitude: 3.35,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.32263980),
        dec: Angle.Degrees(+12.89605513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211476"},
        {"Hipparcos Number", "HIP 110035"},
        {"Cincinnati Publication", "Ci 20 1351"},
        {"Geneva Identification System", "GEN# +1.00211476"},
        {"Smithsonian Astrophysical Observation", "SAO 107794"},
        {"Wilson Evans Batten Catalogue", "WEB 19756"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.31096602),
        dec: Angle.Degrees(+12.89825178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 857.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83871"},
        {"Hipparcos Number", "HIP 47551"},
        {"Geneva Identification System", "GEN# +1.00083871"},
        {"Smithsonian Astrophysical Observation", "SAO 98715"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.41137426),
        dec: Angle.Degrees(+12.89867953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15114"},
        {"Hipparcos Number", "HIP 11369"},
        {"Smithsonian Astrophysical Observation", "SAO 92950"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.61230273),
        dec: Angle.Degrees(+12.89885152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286502"},
        {"Hipparcos Number", "HIP 18937"},
        {"Smithsonian Astrophysical Observation", "SAO 93743"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.88313343),
        dec: Angle.Degrees(+12.89889237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21675"},
        {"Hipparcos Number", "HIP 16314"},
        {"Geneva Identification System", "GEN# +1.00021675"},
        {"Smithsonian Astrophysical Observation", "SAO 93461"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.56394664),
        dec: Angle.Degrees(+12.90190406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16275"},
        {"Hipparcos Number", "HIP 12198"},
        {"Geneva Identification System", "GEN# +1.00016275"},
        {"Smithsonian Astrophysical Observation", "SAO 93028"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.27352449),
        dec: Angle.Degrees(+12.90210947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27902"},
        {"Hipparcos Number", "HIP 20595"},
        {"Celescope Catalog", "CEL 395"},
        {"Geneva Identification System", "GEN# +1.00027902"},
        {"Smithsonian Astrophysical Observation", "SAO 93916"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.16847558),
        dec: Angle.Degrees(+12.90403604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113205",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113205"},
        {"Smithsonian Astrophysical Observation", "SAO 108259"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.87776974),
        dec: Angle.Degrees(+12.90536939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24572"},
        {"Hipparcos Number", "HIP 18315"},
        {"Geneva Identification System", "GEN# +1.00024572"},
        {"Smithsonian Astrophysical Observation", "SAO 93669"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.74042051),
        dec: Angle.Degrees(+12.90612681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106282",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106282"},
        {"Smithsonian Astrophysical Observation", "SAO 107202"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.89894733),
        dec: Angle.Degrees(+12.90751112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6558",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6558"},
        {"Geneva Identification System", "GEN# +0.01200172"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.06819527),
        dec: Angle.Degrees(+12.90775202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 267.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287189"},
        {"Hipparcos Number", "HIP 22753"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.41369204),
        dec: Angle.Degrees(+12.90805081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92898",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11843 A"},
        {"Henry Draper", "HD 230093"},
        {"Hipparcos Number", "HIP 92898"},
        {"Smithsonian Astrophysical Observation", "SAO 104265"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.93195079),
        dec: Angle.Degrees(+12.90837356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17876",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17876"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.36485354),
        dec: Angle.Degrees(+12.90884339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151796"},
        {"Hipparcos Number", "HIP 82316"},
        {"Smithsonian Astrophysical Observation", "SAO 102406"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.28999391),
        dec: Angle.Degrees(+12.90912958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99751"},
        {"Hipparcos Number", "HIP 56003"},
        {"Geneva Identification System", "GEN# +1.00099751"},
        {"Smithsonian Astrophysical Observation", "SAO 99620"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.15521562),
        dec: Angle.Degrees(+12.90935107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92897",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 11.78,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)55, 42.0700),
        dec: Angle.DegreesMinutesSeconds((int)+12, (int)54, 35.800)
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
    primaryId: "HIP 25577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35818"},
        {"Hipparcos Number", "HIP 25577"},
        {"Smithsonian Astrophysical Observation", "SAO 94575"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.99623257),
        dec: Angle.Degrees(+12.91172449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115678"},
        {"Hipparcos Number", "HIP 64935"},
        {"Geneva Identification System", "GEN# +1.00115678"},
        {"Smithsonian Astrophysical Observation", "SAO 100506"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.65282118),
        dec: Angle.Degrees(+12.91172833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17878",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17878"},
        {"Smithsonian Astrophysical Observation", "SAO 93621"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.36579257),
        dec: Angle.Degrees(+12.91207393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89099"},
        {"Hipparcos Number", "HIP 50357"},
        {"Geneva Identification System", "GEN# +1.00089099"},
        {"Smithsonian Astrophysical Observation", "SAO 99035"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.23583960),
        dec: Angle.Degrees(+12.91356833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2816"},
        {"Hipparcos Number", "HIP 2498"},
        {"Smithsonian Astrophysical Observation", "SAO 91945"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.92296934),
        dec: Angle.Degrees(+12.91388642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -157.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92903",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92903"},
    },
    visualMagnitude: 9.99,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.94081558),
        dec: Angle.Degrees(+12.91475948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182147"},
        {"Hipparcos Number", "HIP 95250"},
        {"Smithsonian Astrophysical Observation", "SAO 104776"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.69629856),
        dec: Angle.Degrees(+12.91497239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76368",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9708 AB"},
        {"Henry Draper", "HD 139086"},
        {"Hipparcos Number", "HIP 76368"},
        {"Smithsonian Astrophysical Observation", "SAO 101633"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.96271630),
        dec: Angle.Degrees(+12.91629477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114393",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114393"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.51875190),
        dec: Angle.Degrees(+12.91848461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107116"},
        {"Hipparcos Number", "HIP 60065"},
        {"Geneva Identification System", "GEN# +1.00107116"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.75814910),
        dec: Angle.Degrees(+12.91913863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91245"},
        {"Hipparcos Number", "HIP 51590"},
        {"Geneva Identification System", "GEN# +1.00091245"},
        {"Smithsonian Astrophysical Observation", "SAO 99174"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.07066123),
        dec: Angle.Degrees(+12.91918950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211420"},
        {"Hipparcos Number", "HIP 109991"},
        {"Geneva Identification System", "GEN# +1.00211420"},
        {"Smithsonian Astrophysical Observation", "SAO 107786"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.16727803),
        dec: Angle.Degrees(+12.92025764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119732"},
        {"Hipparcos Number", "HIP 67067"},
        {"Smithsonian Astrophysical Observation", "SAO 100684"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.17998946),
        dec: Angle.Degrees(+12.92060098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181362"},
        {"Hipparcos Number", "HIP 94990"},
        {"Smithsonian Astrophysical Observation", "SAO 104724"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.93638454),
        dec: Angle.Degrees(+12.92110724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30469"},
        {"Hipparcos Number", "HIP 22327"},
        {"Geneva Identification System", "GEN# +1.00030469"},
        {"Smithsonian Astrophysical Observation", "SAO 94134"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.13877397),
        dec: Angle.Degrees(+12.92544936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52306",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52306"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.32224891),
        dec: Angle.Degrees(+12.92768066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52940",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52940"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.40008710),
        dec: Angle.Degrees(+12.92875531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52942",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52942"},
        {"Smithsonian Astrophysical Observation", "SAO 99310"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.40486798),
        dec: Angle.Degrees(+12.92932109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145184"},
        {"Hipparcos Number", "HIP 79139"},
        {"Geneva Identification System", "GEN# +1.00145184"},
        {"Smithsonian Astrophysical Observation", "SAO 101965"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.30251437),
        dec: Angle.Degrees(+12.93209925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 99.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73348"},
        {"Hipparcos Number", "HIP 42373"},
        {"Smithsonian Astrophysical Observation", "SAO 97989"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.59605124),
        dec: Angle.Degrees(+12.93364379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21754"},
        {"Hipparcos Number", "HIP 16369"},
        {"Fundamental Katalog 5th Edition", "FK5 125"},
        {"Geneva Identification System", "GEN# +1.00021754"},
        {"Smithsonian Astrophysical Observation", "SAO 93469"},
        {"Wilson Evans Batten Catalogue", "WEB 3128"},
    },
    visualMagnitude: 4.14,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.71819576),
        dec: Angle.Degrees(+12.93668186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211697"},
        {"Hipparcos Number", "HIP 110150"},
        {"Smithsonian Astrophysical Observation", "SAO 107817"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.68359151),
        dec: Angle.Degrees(+12.93869859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185271"},
        {"Hipparcos Number", "HIP 96555"},
        {"Fundamental Katalog 5th Edition", "FK5 5725"},
        {"Smithsonian Astrophysical Observation", "SAO 105070"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.44650249),
        dec: Angle.Degrees(+12.93874973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61416",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61416"},
        {"Smithsonian Astrophysical Observation", "SAO 100158"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.77783949),
        dec: Angle.Degrees(+12.93894901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18067"},
        {"Hipparcos Number", "HIP 13557"},
        {"Smithsonian Astrophysical Observation", "SAO 93176"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.65662725),
        dec: Angle.Degrees(+12.93927366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108204",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108204"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.82749361),
        dec: Angle.Degrees(+12.94014652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137531"},
        {"Hipparcos Number", "HIP 75562"},
        {"Geneva Identification System", "GEN# +1.00137531"},
        {"Smithsonian Astrophysical Observation", "SAO 101553"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.55355670),
        dec: Angle.Degrees(+12.94077006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154064"},
        {"Hipparcos Number", "HIP 83399"},
        {"Geneva Identification System", "GEN# +1.00154064"},
        {"Smithsonian Astrophysical Observation", "SAO 102550"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.67810804),
        dec: Angle.Degrees(+12.94240028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9139",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9139"},
        {"Smithsonian Astrophysical Observation", "SAO 92725"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.45203048),
        dec: Angle.Degrees(+12.94315638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76912",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76912"},
    },
    visualMagnitude: 10.03,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.56878217),
        dec: Angle.Degrees(+12.94334143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -374.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67808",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67808"},
        {"Cincinnati Publication", "Ci 20 821"},
        {"Geneva Identification System", "GEN# +0.01302721"},
        {"Wilson Evans Batten Catalogue", "WEB 11922"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.36522264),
        dec: Angle.Degrees(+12.94418695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -153.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -646.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65358",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65358"},
        {"Geneva Identification System", "GEN# +0.01302661"},
        {"Smithsonian Astrophysical Observation", "SAO 100547"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.92727970),
        dec: Angle.Degrees(+12.94736090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241070"},
        {"Hipparcos Number", "HIP 23962"},
        {"Smithsonian Astrophysical Observation", "SAO 94348"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.26008333),
        dec: Angle.Degrees(+12.94850486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201841"},
        {"Hipparcos Number", "HIP 104640"},
        {"Geneva Identification System", "GEN# +1.00201841"},
        {"Smithsonian Astrophysical Observation", "SAO 106904"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.94578205),
        dec: Angle.Degrees(+12.95177683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68292",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68292"},
        {"Smithsonian Astrophysical Observation", "SAO 100803"},
        {"Wilson Evans Batten Catalogue", "WEB 11983"},
    },
    visualMagnitude: 10.95,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.69306446),
        dec: Angle.Degrees(+12.95190730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200394"},
        {"Hipparcos Number", "HIP 103878"},
        {"Smithsonian Astrophysical Observation", "SAO 106793"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.73334159),
        dec: Angle.Degrees(+12.95216109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39883",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39883"},
        {"Smithsonian Astrophysical Observation", "SAO 97596"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.20306528),
        dec: Angle.Degrees(+12.95313519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10566"},
        {"Hipparcos Number", "HIP 8041"},
        {"Smithsonian Astrophysical Observation", "SAO 92595"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.80957841),
        dec: Angle.Degrees(+12.95476007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6557"},
        {"Hipparcos Number", "HIP 5204"},
        {"Fundamental Katalog 5th Edition", "FK5 2068"},
        {"Geneva Identification System", "GEN# +1.00006557"},
        {"Smithsonian Astrophysical Observation", "SAO 92250"},
        {"Wilson Evans Batten Catalogue", "WEB 1093"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.64007727),
        dec: Angle.Degrees(+12.95597351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225194"},
        {"Hipparcos Number", "HIP 348"},
        {"Cincinnati Publication", "Ci 18 3160"},
        {"Geneva Identification System", "GEN# +1.00225194"},
        {"Smithsonian Astrophysical Observation", "SAO 91687"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.08880039),
        dec: Angle.Degrees(+12.95705512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 317.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15272"},
        {"Hipparcos Number", "HIP 11461"},
        {"Geneva Identification System", "GEN# +1.00015272"},
        {"Smithsonian Astrophysical Observation", "SAO 92960"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.96038737),
        dec: Angle.Degrees(+12.95755790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101078"},
        {"Hipparcos Number", "HIP 56739"},
        {"Smithsonian Astrophysical Observation", "SAO 99705"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.50228583),
        dec: Angle.Degrees(+12.95758728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3884"},
        {"Hipparcos Number", "HIP 3262"},
        {"Geneva Identification System", "GEN# +1.00003884"},
        {"Smithsonian Astrophysical Observation", "SAO 92030"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.38214692),
        dec: Angle.Degrees(+12.95945973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124570"},
        {"Hipparcos Number", "HIP 69536"},
        {"Geneva Identification System", "GEN# +1.00124570"},
        {"Smithsonian Astrophysical Observation", "SAO 100925"},
        {"Wilson Evans Batten Catalogue", "WEB 12113"},
    },
    visualMagnitude: 5.53,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.52221581),
        dec: Angle.Degrees(+12.95957667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -254.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42446",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Gakyid"},
        {"Henry Draper", "HD 73534"},
        {"Hipparcos Number", "HIP 42446"},
        {"Geneva Identification System", "GEN# +1.00073534"},
        {"Smithsonian Astrophysical Observation", "SAO 98004"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.81613153),
        dec: Angle.Degrees(+12.96060186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287271"},
        {"Hipparcos Number", "HIP 23163"},
        {"Smithsonian Astrophysical Observation", "SAO 94242"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.74943364),
        dec: Angle.Degrees(+12.96063661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77830",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77830"},
        {"Wilson Evans Batten Catalogue", "WEB 13163"},
    },
    visualMagnitude: 11.10,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.37938742),
        dec: Angle.Degrees(+12.96116455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286355"},
        {"Hipparcos Number", "HIP 18504"},
        {"Smithsonian Astrophysical Observation", "SAO 93688"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.35527825),
        dec: Angle.Degrees(+12.96264361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39882"},
        {"Hipparcos Number", "HIP 28064"},
        {"Geneva Identification System", "GEN# +1.00039882"},
        {"Smithsonian Astrophysical Observation", "SAO 95003"},
        {"Wilson Evans Batten Catalogue", "WEB 5495"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.00223808),
        dec: Angle.Degrees(+12.96280093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203140"},
        {"Hipparcos Number", "HIP 105326"},
        {"Smithsonian Astrophysical Observation", "SAO 107039"},
        {"Wilson Evans Batten Catalogue", "WEB 19131"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.01702555),
        dec: Angle.Degrees(+12.96283350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153110"},
        {"Hipparcos Number", "HIP 82946"},
        {"Smithsonian Astrophysical Observation", "SAO 102490"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.25580045),
        dec: Angle.Degrees(+12.96366163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111068"},
        {"Hipparcos Number", "HIP 62353"},
        {"Geneva Identification System", "GEN# +1.00111068"},
        {"Smithsonian Astrophysical Observation", "SAO 100251"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.65136049),
        dec: Angle.Degrees(+12.96404071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108432",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108432"},
        {"Smithsonian Astrophysical Observation", "SAO 107545"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.48006653),
        dec: Angle.Degrees(+12.96453451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57901"},
        {"Hipparcos Number", "HIP 35872"},
        {"Cincinnati Publication", "Ci 18 885"},
        {"Cincinnati Publication 2", "Ci 20 424"},
        {"Geneva Identification System", "GEN# +1.00057901"},
        {"Smithsonian Astrophysical Observation", "SAO 96852"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.94589902),
        dec: Angle.Degrees(+12.96575197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -425.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103698",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103698"},
        {"Smithsonian Astrophysical Observation", "SAO 106751"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.19304531),
        dec: Angle.Degrees(+12.96816878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116787",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16914 AB"},
        {"Hipparcos Number", "HIP 116787"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.02521635),
        dec: Angle.Degrees(+12.96829664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132372"},
        {"Hipparcos Number", "HIP 73272"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.63232642),
        dec: Angle.Degrees(+12.96917503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76831"},
        {"Hipparcos Number", "HIP 44102"},
        {"Smithsonian Astrophysical Observation", "SAO 98273"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.73804414),
        dec: Angle.Degrees(+12.96992196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27837"},
        {"Hipparcos Number", "HIP 20540"},
        {"Geneva Identification System", "GEN# +5.20251304"},
        {"Smithsonian Astrophysical Observation", "SAO 93908"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.01865121),
        dec: Angle.Degrees(+12.97249974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16534",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16534"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.22970755),
        dec: Angle.Degrees(+12.97459886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8335",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8335"},
        {"Smithsonian Astrophysical Observation", "SAO 92631"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.87456523),
        dec: Angle.Degrees(+12.97533681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172763"},
        {"Hipparcos Number", "HIP 91661"},
        {"Smithsonian Astrophysical Observation", "SAO 103990"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.37669627),
        dec: Angle.Degrees(+12.97534323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72315",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72315"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.82643470),
        dec: Angle.Degrees(+12.97984021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -189.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51208",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51208"},
        {"Geneva Identification System", "GEN# +9.80043051"},
    },
    visualMagnitude: 10.69,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.89595037),
        dec: Angle.Degrees(+12.98025534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -289.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168271"},
        {"Hipparcos Number", "HIP 89700"},
        {"Smithsonian Astrophysical Observation", "SAO 103584"},
        {"Wilson Evans Batten Catalogue", "WEB 15287"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.60225285),
        dec: Angle.Degrees(+12.98043124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197195"},
        {"Hipparcos Number", "HIP 102147"},
        {"Geneva Identification System", "GEN# +1.00197195"},
        {"Smithsonian Astrophysical Observation", "SAO 106391"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.47235463),
        dec: Angle.Degrees(+12.98062143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31876",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5302 AB"},
        {"Henry Draper", "HD 47575"},
        {"Hipparcos Number", "HIP 31876"},
        {"Geneva Identification System", "GEN# +1.00047575J"},
        {"Smithsonian Astrophysical Observation", "SAO 95963"},
        {"Wilson Evans Batten Catalogue", "WEB 6405"},
    },
    visualMagnitude: 5.99,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.94885571),
        dec: Angle.Degrees(+12.98280259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65523"},
        {"Hipparcos Number", "HIP 39068"},
        {"Geneva Identification System", "GEN# +1.00065523"},
        {"Smithsonian Astrophysical Observation", "SAO 97446"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.89906135),
        dec: Angle.Degrees(+12.98317323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -237.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109793"},
        {"Hipparcos Number", "HIP 61600"},
        {"Geneva Identification System", "GEN# +1.00109793"},
        {"Smithsonian Astrophysical Observation", "SAO 100180"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.34231643),
        dec: Angle.Degrees(+12.98360805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43441",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43441"},
        {"Smithsonian Astrophysical Observation", "SAO 98164"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.71182990),
        dec: Angle.Degrees(+12.98481739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18698"},
        {"Hipparcos Number", "HIP 14037"},
        {"Smithsonian Astrophysical Observation", "SAO 93233"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.19189922),
        dec: Angle.Degrees(+12.98484361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105262"},
        {"Hipparcos Number", "HIP 59099"},
        {"Geneva Identification System", "GEN# +1.00105262"},
        {"Smithsonian Astrophysical Observation", "SAO 99943"},
        {"Wilson Evans Batten Catalogue", "WEB 10520"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.79505120),
        dec: Angle.Degrees(+12.98557133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198089"},
        {"Hipparcos Number", "HIP 102610"},
        {"Geneva Identification System", "GEN# +1.00198089"},
        {"Smithsonian Astrophysical Observation", "SAO 106494"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.90773584),
        dec: Angle.Degrees(+12.98615478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171874"},
        {"Hipparcos Number", "HIP 91233"},
        {"Geneva Identification System", "GEN# +1.00171874"},
        {"Smithsonian Astrophysical Observation", "SAO 103897"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.15258778),
        dec: Angle.Degrees(+12.98758373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202258"},
        {"Hipparcos Number", "HIP 104821"},
        {"Geneva Identification System", "GEN# +1.00202258"},
        {"Smithsonian Astrophysical Observation", "SAO 106944"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.54259731),
        dec: Angle.Degrees(+12.98798669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40281"},
        {"Hipparcos Number", "HIP 28268"},
        {"Smithsonian Astrophysical Observation", "SAO 95063"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.59290542),
        dec: Angle.Degrees(+12.98854264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29977"},
        {"Hipparcos Number", "HIP 22021"},
        {"Geneva Identification System", "GEN# +1.00029977"},
        {"Smithsonian Astrophysical Observation", "SAO 94090"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.01548881),
        dec: Angle.Degrees(+12.99122769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14278"},
        {"Hipparcos Number", "HIP 10784"},
        {"Geneva Identification System", "GEN# +1.00014278"},
        {"Smithsonian Astrophysical Observation", "SAO 92882"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.71689526),
        dec: Angle.Degrees(+12.99218496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 203.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199427"},
        {"Hipparcos Number", "HIP 103381"},
        {"Smithsonian Astrophysical Observation", "SAO 106684"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.18219156),
        dec: Angle.Degrees(+12.99272146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 230428"},
        {"Hipparcos Number", "HIP 93388"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.30846255),
        dec: Angle.Degrees(+12.99509537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26991",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4304 AB"},
        {"Henry Draper", "HD 38068"},
        {"Hipparcos Number", "HIP 26991"},
        {"Smithsonian Astrophysical Observation", "SAO 94806"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.90034435),
        dec: Angle.Degrees(+12.99565168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177490"},
        {"Hipparcos Number", "HIP 93664"},
        {"Geneva Identification System", "GEN# +1.00177490"},
        {"Smithsonian Astrophysical Observation", "SAO 104439"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.09475477),
        dec: Angle.Degrees(+12.99701637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14711",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14711"},
        {"Geneva Identification System", "GEN# +9.80079006"},
    },
    visualMagnitude: 11.13,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.51749664),
        dec: Angle.Degrees(+12.99721937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -164.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52519",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52519"},
        {"Smithsonian Astrophysical Observation", "SAO 99270"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.07836941),
        dec: Angle.Degrees(+12.99825266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59478",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8456 AB"},
        {"Henry Draper", "HD 106025"},
        {"Hipparcos Number", "HIP 59478"},
        {"Geneva Identification System", "GEN# +1.00106025"},
        {"Smithsonian Astrophysical Observation", "SAO 99981"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.98885862),
        dec: Angle.Degrees(+12.99995327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115606"},
        {"Hipparcos Number", "HIP 64886"},
        {"Geneva Identification System", "GEN# +1.00115606"},
        {"Renson", "Renson 33440"},
        {"Smithsonian Astrophysical Observation", "SAO 100505"},
        {"Wilson Evans Batten Catalogue", "WEB 11468"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.51033119),
        dec: Angle.Degrees(+13.00011846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32659"},
        {"Hipparcos Number", "HIP 23674"},
        {"Smithsonian Astrophysical Observation", "SAO 94304"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.33434059),
        dec: Angle.Degrees(+13.00103471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39828"},
        {"Hipparcos Number", "HIP 28029"},
        {"Geneva Identification System", "GEN# +1.00039828"},
        {"Smithsonian Astrophysical Observation", "SAO 94997"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.91259041),
        dec: Angle.Degrees(+13.00189524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29497"},
        {"Hipparcos Number", "HIP 21672"},
        {"Celescope Catalog", "CEL 450"},
        {"Geneva Identification System", "GEN# +1.00029497"},
        {"Smithsonian Astrophysical Observation", "SAO 94053"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.78611316),
        dec: Angle.Degrees(+13.00313913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125451"},
        {"Hipparcos Number", "HIP 69989"},
        {"Fundamental Katalog 5th Edition", "FK5 1372"},
        {"Geneva Identification System", "GEN# +1.00125451"},
        {"Smithsonian Astrophysical Observation", "SAO 100975"},
        {"Wilson Evans Batten Catalogue", "WEB 12171"},
    },
    visualMagnitude: 5.41,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.81757038),
        dec: Angle.Degrees(+13.00437724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193392"},
        {"Hipparcos Number", "HIP 100226"},
        {"Smithsonian Astrophysical Observation", "SAO 105967"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.91031422),
        dec: Angle.Degrees(+13.00480958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138901"},
        {"Hipparcos Number", "HIP 76257"},
        {"Geneva Identification System", "GEN# +1.00138901"},
        {"Smithsonian Astrophysical Observation", "SAO 101621"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.65160573),
        dec: Angle.Degrees(+13.00572411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99209"},
        {"Hipparcos Number", "HIP 55721"},
        {"Geneva Identification System", "GEN# +1.00099209"},
        {"Smithsonian Astrophysical Observation", "SAO 99599"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.26177989),
        dec: Angle.Degrees(+13.00780468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104350"},
        {"Hipparcos Number", "HIP 58605"},
        {"Geneva Identification System", "GEN# +1.00104350"},
        {"Smithsonian Astrophysical Observation", "SAO 99908"},
        {"Wilson Evans Batten Catalogue", "WEB 10458"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.26460431),
        dec: Angle.Degrees(+13.00838201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215859"},
        {"Hipparcos Number", "HIP 112580"},
        {"Geneva Identification System", "GEN# +1.00215859"},
        {"Smithsonian Astrophysical Observation", "SAO 108182"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.02807530),
        dec: Angle.Degrees(+13.00911124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100639",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13804 AB"},
        {"Henry Draper", "HD 194261"},
        {"Hipparcos Number", "HIP 100639"},
        {"Smithsonian Astrophysical Observation", "SAO 106064"},
    },
    visualMagnitude: 8.34,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.09624288),
        dec: Angle.Degrees(+13.00985108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120510"},
        {"Hipparcos Number", "HIP 67470"},
        {"Geneva Identification System", "GEN# +1.00120510"},
        {"Smithsonian Astrophysical Observation", "SAO 100726"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.40063124),
        dec: Angle.Degrees(+13.01023955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -148.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193391"},
        {"Hipparcos Number", "HIP 100222"},
        {"Smithsonian Astrophysical Observation", "SAO 105965"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.90542873),
        dec: Angle.Degrees(+13.01080712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96514"},
        {"Hipparcos Number", "HIP 54370"},
        {"Smithsonian Astrophysical Observation", "SAO 99457"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.86018591),
        dec: Angle.Degrees(+13.01348577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102809"},
        {"Hipparcos Number", "HIP 57721"},
        {"Geneva Identification System", "GEN# +1.00102809"},
        {"Smithsonian Astrophysical Observation", "SAO 99820"},
        {"Wilson Evans Batten Catalogue", "WEB 10361"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.56036311),
        dec: Angle.Degrees(+13.01368400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49702",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49702"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.19117220),
        dec: Angle.Degrees(+13.01423063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44812"},
        {"Hipparcos Number", "HIP 30483"},
        {"Geneva Identification System", "GEN# +1.00044812"},
        {"Smithsonian Astrophysical Observation", "SAO 95631"},
        {"Wilson Evans Batten Catalogue", "WEB 6067"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.11701076),
        dec: Angle.Degrees(+13.01505172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191337"},
        {"Hipparcos Number", "HIP 99265"},
        {"Geneva Identification System", "GEN# +1.00191337"},
        {"Smithsonian Astrophysical Observation", "SAO 105750"},
        {"Wilson Evans Batten Catalogue", "WEB 17692"},
    },
    visualMagnitude: 7.94,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.25297283),
        dec: Angle.Degrees(+13.01588865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161540"},
        {"Hipparcos Number", "HIP 86912"},
        {"Smithsonian Astrophysical Observation", "SAO 103081"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.38301456),
        dec: Angle.Degrees(+13.01953304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114480"},
        {"Hipparcos Number", "HIP 64299"},
        {"Geneva Identification System", "GEN# +1.00114480"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.68225259),
        dec: Angle.Degrees(+13.02114562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68834"},
        {"Hipparcos Number", "HIP 40375"},
        {"Cincinnati Publication", "Ci 20 466"},
        {"Geneva Identification System", "GEN# +1.00068834"},
        {"Smithsonian Astrophysical Observation", "SAO 97673"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.65069293),
        dec: Angle.Degrees(+13.02258943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -422.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 96.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26655",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4253 A"},
        {"Henry Draper", "HD 37560"},
        {"Hipparcos Number", "HIP 26655"},
        {"Smithsonian Astrophysical Observation", "SAO 94737"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.97782733),
        dec: Angle.Degrees(+13.02274885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182900"},
        {"Hipparcos Number", "HIP 95572"},
        {"Geneva Identification System", "GEN# +1.00182900"},
        {"Smithsonian Astrophysical Observation", "SAO 104832"},
        {"Wilson Evans Batten Catalogue", "WEB 16712"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.60052721),
        dec: Angle.Degrees(+13.02365808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9463",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9463"},
    },
    visualMagnitude: 10.16,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.44929308),
        dec: Angle.Degrees(+13.02450453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161424"},
        {"Hipparcos Number", "HIP 86877"},
        {"Geneva Identification System", "GEN# +1.00161424"},
        {"Smithsonian Astrophysical Observation", "SAO 103076"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.25179762),
        dec: Angle.Degrees(+13.02471016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61525",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61525"},
        {"Geneva Identification System", "GEN# +0.01302555"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.07300123),
        dec: Angle.Degrees(+13.02524934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40931"},
        {"Hipparcos Number", "HIP 28621"},
        {"Smithsonian Astrophysical Observation", "SAO 95153"},
        {"Wilson Evans Batten Catalogue", "WEB 5593"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.63884459),
        dec: Angle.Degrees(+13.02551574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195943"},
        {"Hipparcos Number", "HIP 101483"},
        {"Geneva Identification System", "GEN# +1.00195943"},
        {"Renson", "Renson 54620"},
        {"Smithsonian Astrophysical Observation", "SAO 106248"},
        {"Wilson Evans Batten Catalogue", "WEB 18334"},
    },
    visualMagnitude: 5.39,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.48748693),
        dec: Angle.Degrees(+13.02720146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87777"},
        {"Hipparcos Number", "HIP 49617"},
        {"Geneva Identification System", "GEN# +1.00087777"},
        {"Smithsonian Astrophysical Observation", "SAO 98959"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.89648316),
        dec: Angle.Degrees(+13.02863065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -180.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93363"},
        {"Hipparcos Number", "HIP 52744"},
        {"Smithsonian Astrophysical Observation", "SAO 99287"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.75069111),
        dec: Angle.Degrees(+13.02995765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151493"},
        {"Hipparcos Number", "HIP 82163"},
        {"Smithsonian Astrophysical Observation", "SAO 102384"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.79073941),
        dec: Angle.Degrees(+13.03133849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43649"},
        {"Hipparcos Number", "HIP 29920"},
        {"Celescope Catalog", "CEL 1163"},
        {"Geneva Identification System", "GEN# +1.00043649"},
        {"Smithsonian Astrophysical Observation", "SAO 95499"},
        {"Wilson Evans Batten Catalogue", "WEB 5927"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.47912664),
        dec: Angle.Degrees(+13.03136720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138039"},
        {"Hipparcos Number", "HIP 75799"},
        {"Geneva Identification System", "GEN# +1.00138039"},
        {"Smithsonian Astrophysical Observation", "SAO 101577"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.28361381),
        dec: Angle.Degrees(+13.03261763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105304"},
        {"Hipparcos Number", "HIP 59126"},
        {"Cincinnati Publication", "Ci 20 683"},
        {"Geneva Identification System", "GEN# +1.00105304"},
        {"Smithsonian Astrophysical Observation", "SAO 99950"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.86949205),
        dec: Angle.Degrees(+13.03325098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -379.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 259526"},
        {"Hipparcos Number", "HIP 31276"},
        {"Smithsonian Astrophysical Observation", "SAO 95831"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.39609209),
        dec: Angle.Degrees(+13.03492349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287276"},
        {"Hipparcos Number", "HIP 23085"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.52711528),
        dec: Angle.Degrees(+13.03501101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76889",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76889"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.50127757),
        dec: Angle.Degrees(+13.03775817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150257"},
        {"Hipparcos Number", "HIP 81550"},
        {"Smithsonian Astrophysical Observation", "SAO 102295"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.83412778),
        dec: Angle.Degrees(+13.03811553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5638",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5638"},
        {"Smithsonian Astrophysical Observation", "SAO 92312"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.11260214),
        dec: Angle.Degrees(+13.03919163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52746",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52746"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.75796014),
        dec: Angle.Degrees(+13.03927854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150711"},
        {"Hipparcos Number", "HIP 81795"},
        {"Geneva Identification System", "GEN# +1.00150711"},
        {"Smithsonian Astrophysical Observation", "SAO 102334"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.59326941),
        dec: Angle.Degrees(+13.04122149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213619"},
        {"Hipparcos Number", "HIP 111282"},
        {"Geneva Identification System", "GEN# +1.00213619"},
        {"Smithsonian Astrophysical Observation", "SAO 107988"},
        {"Wilson Evans Batten Catalogue", "WEB 19909"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.16402259),
        dec: Angle.Degrees(+13.04449273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190133"},
        {"Hipparcos Number", "HIP 98721"},
        {"Smithsonian Astrophysical Observation", "SAO 105598"},
    },
    visualMagnitude: 9.12,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.76667076),
        dec: Angle.Degrees(+13.04471089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24155"},
        {"Hipparcos Number", "HIP 18033"},
        {"Geneva Identification System", "GEN# +1.00024155"},
        {"Renson", "Renson 6190"},
        {"Smithsonian Astrophysical Observation", "SAO 93637"},
        {"Wilson Evans Batten Catalogue", "WEB 3475"},
    },
    visualMagnitude: 6.30,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.81607255),
        dec: Angle.Degrees(+13.04613170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 355719"},
        {"Hipparcos Number", "HIP 97163"},
        {"Smithsonian Astrophysical Observation", "SAO 105208"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.23675051),
        dec: Angle.Degrees(+13.04657579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28355"},
        {"Hipparcos Number", "HIP 20901"},
        {"Celescope Catalog", "CEL 410"},
        {"Fundamental Katalog 5th Edition", "FK5 2330"},
        {"Geneva Identification System", "GEN# +5.20250074"},
        {"Renson", "Renson 7270"},
        {"Smithsonian Astrophysical Observation", "SAO 93960"},
        {"Wilson Evans Batten Catalogue", "WEB 4015"},
    },
    visualMagnitude: 5.02,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.20875444),
        dec: Angle.Degrees(+13.04763905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47631"},
        {"Hipparcos Number", "HIP 31915"},
        {"Smithsonian Astrophysical Observation", "SAO 95979"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.04774677),
        dec: Angle.Degrees(+13.04771981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19789"},
        {"Hipparcos Number", "HIP 14821"},
        {"Geneva Identification System", "GEN# +1.00019789"},
        {"Smithsonian Astrophysical Observation", "SAO 93327"},
        {"Wilson Evans Batten Catalogue", "WEB 2863"},
    },
    visualMagnitude: 6.11,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.84136712),
        dec: Angle.Degrees(+13.04780325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68776"},
        {"Hipparcos Number", "HIP 40354"},
        {"Fundamental Katalog 5th Edition", "FK5 4740"},
        {"Smithsonian Astrophysical Observation", "SAO 97671"},
        {"Wilson Evans Batten Catalogue", "WEB 7870"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.58752479),
        dec: Angle.Degrees(+13.04834017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6195"},
        {"Hipparcos Number", "HIP 4915"},
        {"Smithsonian Astrophysical Observation", "SAO 92220"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.77627734),
        dec: Angle.Degrees(+13.04881125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10329",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10329"},
        {"Smithsonian Astrophysical Observation", "SAO 92843"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.26635936),
        dec: Angle.Degrees(+13.05037452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146874"},
        {"Hipparcos Number", "HIP 79858"},
        {"Geneva Identification System", "GEN# +1.00146874"},
        {"Smithsonian Astrophysical Observation", "SAO 102069"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.52020339),
        dec: Angle.Degrees(+13.05229803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83683"},
        {"Hipparcos Number", "HIP 47468"},
        {"Geneva Identification System", "GEN# +1.00083683"},
        {"Smithsonian Astrophysical Observation", "SAO 98704"},
        {"Wilson Evans Batten Catalogue", "WEB 8906"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.14679771),
        dec: Angle.Degrees(+13.05406058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216864"},
        {"Hipparcos Number", "HIP 113285"},
        {"Geneva Identification System", "GEN# +1.00216864"},
        {"Smithsonian Astrophysical Observation", "SAO 108268"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.10271468),
        dec: Angle.Degrees(+13.05459847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286589"},
        {"Hipparcos Number", "HIP 19808"},
        {"Geneva Identification System", "GEN# +5.20251068"},
    },
    visualMagnitude: 10.69,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.71610149),
        dec: Angle.Degrees(+13.05499937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15841",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15841"},
    },
    visualMagnitude: 10.99,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.01483964),
        dec: Angle.Degrees(+13.05504179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204542"},
        {"Hipparcos Number", "HIP 106060"},
        {"Geneva Identification System", "GEN# +1.00204542"},
        {"Smithsonian Astrophysical Observation", "SAO 107166"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.24289680),
        dec: Angle.Degrees(+13.05930197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229970"},
        {"Hipparcos Number", "HIP 92762"},
        {"Geneva Identification System", "GEN# +1.00229970"},
        {"Smithsonian Astrophysical Observation", "SAO 104237"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.54273155),
        dec: Angle.Degrees(+13.06086123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106186"},
        {"Hipparcos Number", "HIP 59581"},
        {"Geneva Identification System", "GEN# +1.00106186"},
        {"Smithsonian Astrophysical Observation", "SAO 99993"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.27487943),
        dec: Angle.Degrees(+13.06130383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206903"},
        {"Hipparcos Number", "HIP 107375"},
        {"Smithsonian Astrophysical Observation", "SAO 107368"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.22364311),
        dec: Angle.Degrees(+13.06240945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287363"},
        {"Hipparcos Number", "HIP 23462"},
        {"Smithsonian Astrophysical Observation", "SAO 94281"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.65320358),
        dec: Angle.Degrees(+13.06394374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5854",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5854"},
        {"Smithsonian Astrophysical Observation", "SAO 92332"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.76873137),
        dec: Angle.Degrees(+13.06589172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85268"},
        {"Hipparcos Number", "HIP 48324"},
        {"Fundamental Katalog 5th Edition", "FK5 4876"},
        {"Geneva Identification System", "GEN# +1.00085268"},
        {"Smithsonian Astrophysical Observation", "SAO 98809"},
        {"Wilson Evans Batten Catalogue", "WEB 9010"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.75821994),
        dec: Angle.Degrees(+13.06625701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231116"},
        {"Hipparcos Number", "HIP 94907"},
        {"Smithsonian Astrophysical Observation", "SAO 104705"},
    },
    visualMagnitude: 8.62,
    bvColour: 2.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.69232808),
        dec: Angle.Degrees(+13.06835140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210130"},
        {"Hipparcos Number", "HIP 109251"},
        {"Geneva Identification System", "GEN# +1.00210130"},
        {"Smithsonian Astrophysical Observation", "SAO 107680"},
        {"Wilson Evans Batten Catalogue", "WEB 19634"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.99196831),
        dec: Angle.Degrees(+13.06930508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88814",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11086 A"},
        {"Henry Draper", "HD 165910"},
        {"Hipparcos Number", "HIP 88814"},
        {"Geneva Identification System", "GEN# +1.00165910A"},
        {"Smithsonian Astrophysical Observation", "SAO 103406"},
        {"Wilson Evans Batten Catalogue", "WEB 15049"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.95145605),
        dec: Angle.Degrees(+13.07109090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189184"},
        {"Hipparcos Number", "HIP 98303"},
        {"Smithsonian Astrophysical Observation", "SAO 105488"},
    },
    visualMagnitude: 9.43,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.59813276),
        dec: Angle.Degrees(+13.07359959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20124"},
        {"Hipparcos Number", "HIP 15081"},
        {"Smithsonian Astrophysical Observation", "SAO 93352"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.61379997),
        dec: Angle.Degrees(+13.07389703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76908"},
        {"Hipparcos Number", "HIP 44148"},
        {"Smithsonian Astrophysical Observation", "SAO 98278"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.86205290),
        dec: Angle.Degrees(+13.07440776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81518",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81518"},
        {"Smithsonian Astrophysical Observation", "SAO 102293"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.76541338),
        dec: Angle.Degrees(+13.07707613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184608"},
        {"Hipparcos Number", "HIP 96305"},
        {"Smithsonian Astrophysical Observation", "SAO 104995"},
    },
    visualMagnitude: 8.56,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.71631819),
        dec: Angle.Degrees(+13.07770524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101487"},
        {"Hipparcos Number", "HIP 56976"},
        {"Geneva Identification System", "GEN# +1.00101487"},
        {"Smithsonian Astrophysical Observation", "SAO 99730"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.20164664),
        dec: Angle.Degrees(+13.07803451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57269"},
        {"Hipparcos Number", "HIP 35620"},
        {"Smithsonian Astrophysical Observation", "SAO 96802"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.25675938),
        dec: Angle.Degrees(+13.07923470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79954"},
        {"Hipparcos Number", "HIP 45578"},
        {"Geneva Identification System", "GEN# +1.00079954"},
        {"Smithsonian Astrophysical Observation", "SAO 98473"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.34083324),
        dec: Angle.Degrees(+13.08156798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27385"},
        {"Hipparcos Number", "HIP 20204"},
        {"Geneva Identification System", "GEN# +1.00027385"},
        {"Smithsonian Astrophysical Observation", "SAO 93869"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.94713407),
        dec: Angle.Degrees(+13.08586892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192541"},
        {"Hipparcos Number", "HIP 99807"},
        {"Geneva Identification System", "GEN# +1.00192541"},
        {"Renson", "Renson 53670"},
        {"Smithsonian Astrophysical Observation", "SAO 105890"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.75820774),
        dec: Angle.Degrees(+13.08758964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60896",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60896"},
        {"Geneva Identification System", "GEN# +0.01302540"},
        {"Smithsonian Astrophysical Observation", "SAO 100120"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.19949037),
        dec: Angle.Degrees(+13.08800049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33965",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5725 AB"},
        {"Henry Draper", "HD 52715"},
        {"Hipparcos Number", "HIP 33965"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.71047662),
        dec: Angle.Degrees(+13.08941049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196571"},
        {"Hipparcos Number", "HIP 101816"},
        {"Smithsonian Astrophysical Observation", "SAO 106327"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.49427282),
        dec: Angle.Degrees(+13.09241987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102605",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102605"},
        {"Smithsonian Astrophysical Observation", "SAO 106493"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.89937614),
        dec: Angle.Degrees(+13.09268633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128168"},
        {"Hipparcos Number", "HIP 71316"},
        {"Smithsonian Astrophysical Observation", "SAO 101090"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.75388153),
        dec: Angle.Degrees(+13.09585575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138701"},
        {"Hipparcos Number", "HIP 76158"},
        {"Geneva Identification System", "GEN# +1.00138701"},
        {"Smithsonian Astrophysical Observation", "SAO 101612"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.32347063),
        dec: Angle.Degrees(+13.09685064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178512"},
        {"Hipparcos Number", "HIP 94009"},
        {"Fundamental Katalog 5th Edition", "FK5 5682"},
        {"Geneva Identification System", "GEN# +1.00178512"},
        {"Smithsonian Astrophysical Observation", "SAO 104520"},
        {"Wilson Evans Batten Catalogue", "WEB 16363"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.10192977),
        dec: Angle.Degrees(+13.09800088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157637"},
        {"Hipparcos Number", "HIP 85129"},
        {"Geneva Identification System", "GEN# +1.00157637"},
        {"Smithsonian Astrophysical Observation", "SAO 102794"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.97091028),
        dec: Angle.Degrees(+13.09930815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 85.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189598"},
        {"Hipparcos Number", "HIP 98468"},
        {"Geneva Identification System", "GEN# +1.00189598"},
        {"Smithsonian Astrophysical Observation", "SAO 105529"},
        {"Wilson Evans Batten Catalogue", "WEB 17383"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.08182221),
        dec: Angle.Degrees(+13.10084412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57770"},
        {"Hipparcos Number", "HIP 35812"},
        {"Geneva Identification System", "GEN# +1.00057770"},
        {"Wilson Evans Batten Catalogue", "WEB 7138"},
    },
    visualMagnitude: 11.20,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.78897554),
        dec: Angle.Degrees(+13.10135167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45194"},
        {"Hipparcos Number", "HIP 30665"},
        {"Geneva Identification System", "GEN# +1.00045194"},
        {"Smithsonian Astrophysical Observation", "SAO 95686"},
        {"Wilson Evans Batten Catalogue", "WEB 6116"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.66333841),
        dec: Angle.Degrees(+13.10142119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130086"},
        {"Hipparcos Number", "HIP 72183"},
        {"Smithsonian Astrophysical Observation", "SAO 101197"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.46578805),
        dec: Angle.Degrees(+13.10159259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213522"},
        {"Hipparcos Number", "HIP 111213"},
        {"Geneva Identification System", "GEN# +1.00213522"},
        {"Smithsonian Astrophysical Observation", "SAO 107978"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.95457121),
        dec: Angle.Degrees(+13.10435569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158873"},
        {"Hipparcos Number", "HIP 85733"},
        {"Geneva Identification System", "GEN# +1.00158873"},
        {"Smithsonian Astrophysical Observation", "SAO 102880"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.80169118),
        dec: Angle.Degrees(+13.10522050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89245",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89245"},
        {"Smithsonian Astrophysical Observation", "SAO 103483"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.17430836),
        dec: Angle.Degrees(+13.10599799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91240",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91240"},
        {"Smithsonian Astrophysical Observation", "SAO 103900"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.16535892),
        dec: Angle.Degrees(+13.10702524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133406"},
        {"Hipparcos Number", "HIP 73705"},
        {"Geneva Identification System", "GEN# +1.00133406"},
        {"Smithsonian Astrophysical Observation", "SAO 101358"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.98870735),
        dec: Angle.Degrees(+13.10711258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180398"},
        {"Hipparcos Number", "HIP 94682"},
        {"Geneva Identification System", "GEN# +1.00180398"},
        {"Smithsonian Astrophysical Observation", "SAO 104665"},
        {"Wilson Evans Batten Catalogue", "WEB 16509"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.99161415),
        dec: Angle.Degrees(+13.10820487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41141"},
        {"Hipparcos Number", "HIP 28709"},
        {"Smithsonian Astrophysical Observation", "SAO 95180"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.95100038),
        dec: Angle.Degrees(+13.10999118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220848"},
        {"Hipparcos Number", "HIP 115751"},
        {"Geneva Identification System", "GEN# +1.00220848"},
        {"Smithsonian Astrophysical Observation", "SAO 108613"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.76721819),
        dec: Angle.Degrees(+13.11091278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122327"},
        {"Hipparcos Number", "HIP 68470"},
        {"Geneva Identification System", "GEN# +1.00122327"},
        {"Smithsonian Astrophysical Observation", "SAO 100813"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.26941532),
        dec: Angle.Degrees(+13.11141213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80654"},
        {"Hipparcos Number", "HIP 45879"},
        {"Fundamental Katalog 5th Edition", "FK5 4831"},
        {"Geneva Identification System", "GEN# +1.00080654"},
        {"Smithsonian Astrophysical Observation", "SAO 98520"},
        {"Wilson Evans Batten Catalogue", "WEB 8701"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.32724973),
        dec: Angle.Degrees(+13.11164715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 252488"},
        {"Hipparcos Number", "HIP 29184"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.34661198),
        dec: Angle.Degrees(+13.11192965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113119",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113119"},
        {"Geneva Identification System", "GEN# +0.01204906"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.61768029),
        dec: Angle.Degrees(+13.11249802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -239.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134249"},
        {"Hipparcos Number", "HIP 74090"},
        {"Smithsonian Astrophysical Observation", "SAO 101397"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.12494470),
        dec: Angle.Degrees(+13.11272981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286839"},
        {"Hipparcos Number", "HIP 21179"},
    },
    visualMagnitude: 11.00,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.10663018),
        dec: Angle.Degrees(+13.11327759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190659"},
        {"Hipparcos Number", "HIP 98966"},
        {"Smithsonian Astrophysical Observation", "SAO 105665"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.39559710),
        dec: Angle.Degrees(+13.11395058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200962"},
        {"Hipparcos Number", "HIP 104179"},
        {"Geneva Identification System", "GEN# +1.00200962"},
        {"Smithsonian Astrophysical Observation", "SAO 106836"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.60788029),
        dec: Angle.Degrees(+13.11456703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30383"},
        {"Hipparcos Number", "HIP 22267"},
        {"Smithsonian Astrophysical Observation", "SAO 94125"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.91673392),
        dec: Angle.Degrees(+13.11466574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135222"},
        {"Hipparcos Number", "HIP 74515"},
        {"Smithsonian Astrophysical Observation", "SAO 101446"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.40126162),
        dec: Angle.Degrees(+13.11543892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22266",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22266"},
    },
    visualMagnitude: 11.97,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.90826627),
        dec: Angle.Degrees(+13.11593504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66664"},
        {"Hipparcos Number", "HIP 39567"},
        {"Fundamental Katalog 5th Edition", "FK5 2625"},
        {"Geneva Identification System", "GEN# +1.00066664"},
        {"Smithsonian Astrophysical Observation", "SAO 97542"},
        {"Wilson Evans Batten Catalogue", "WEB 7733"},
    },
    visualMagnitude: 5.14,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.26879080),
        dec: Angle.Degrees(+13.11837053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94318"},
        {"Hipparcos Number", "HIP 53233"},
        {"Smithsonian Astrophysical Observation", "SAO 99343"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.34291499),
        dec: Angle.Degrees(+13.11872563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97087"},
        {"Hipparcos Number", "HIP 54618"},
        {"Geneva Identification System", "GEN# +1.00097087"},
        {"Smithsonian Astrophysical Observation", "SAO 99481"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.66803520),
        dec: Angle.Degrees(+13.11916222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180686"},
        {"Hipparcos Number", "HIP 94768"},
        {"Geneva Identification System", "GEN# +1.00180686"},
        {"Smithsonian Astrophysical Observation", "SAO 104679"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.24387210),
        dec: Angle.Degrees(+13.11922085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108693",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15543 A"},
        {"Henry Draper", "HD 209166"},
        {"Hipparcos Number", "HIP 108693"},
        {"Fundamental Katalog 5th Edition", "FK5 826"},
        {"Geneva Identification System", "GEN# +1.00209166"},
        {"Smithsonian Astrophysical Observation", "SAO 107587"},
        {"Wilson Evans Batten Catalogue", "WEB 19559"},
    },
    visualMagnitude: 5.61,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.27214600),
        dec: Angle.Degrees(+13.11996136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286885"},
        {"Hipparcos Number", "HIP 21453"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.10322032),
        dec: Angle.Degrees(+13.12267059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29528"},
        {"Hipparcos Number", "HIP 21703"},
        {"Geneva Identification System", "GEN# +1.00029528"},
        {"Smithsonian Astrophysical Observation", "SAO 94057"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.90151304),
        dec: Angle.Degrees(+13.12344166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 236.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108919",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108919"},
        {"Smithsonian Astrophysical Observation", "SAO 107629"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.94197792),
        dec: Angle.Degrees(+13.12507587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141827"},
        {"Hipparcos Number", "HIP 77616"},
        {"Smithsonian Astrophysical Observation", "SAO 101770"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.67478336),
        dec: Angle.Degrees(+13.12678645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40756"},
        {"Hipparcos Number", "HIP 28538"},
        {"Smithsonian Astrophysical Observation", "SAO 95129"},
    },
    visualMagnitude: 7.78,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.37091067),
        dec: Angle.Degrees(+13.13159453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45300",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45300"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.48381591),
        dec: Angle.Degrees(+13.13256716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156456"},
        {"Hipparcos Number", "HIP 84560"},
        {"Smithsonian Astrophysical Observation", "SAO 102711"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.29232822),
        dec: Angle.Degrees(+13.13439813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144346"},
        {"Hipparcos Number", "HIP 78773"},
        {"Smithsonian Astrophysical Observation", "SAO 101909"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.23745060),
        dec: Angle.Degrees(+13.13591801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183615"},
        {"Hipparcos Number", "HIP 95868"},
        {"Geneva Identification System", "GEN# +1.00183615"},
        {"Smithsonian Astrophysical Observation", "SAO 104902"},
        {"Wilson Evans Batten Catalogue", "WEB 16785"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.47571156),
        dec: Angle.Degrees(+13.13744759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71750"},
        {"Hipparcos Number", "HIP 41635"},
        {"Geneva Identification System", "GEN# +1.00071750"},
        {"Smithsonian Astrophysical Observation", "SAO 97850"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.34991565),
        dec: Angle.Degrees(+13.13760885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5124",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5124"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.41047654),
        dec: Angle.Degrees(+13.13769905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 158.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159610"},
        {"Hipparcos Number", "HIP 86041"},
        {"Smithsonian Astrophysical Observation", "SAO 102935"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.75885714),
        dec: Angle.Degrees(+13.13775395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286789"},
        {"Hipparcos Number", "HIP 20762"},
        {"Geneva Identification System", "GEN# +5.20251407"},
    },
    visualMagnitude: 10.48,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.72616515),
        dec: Angle.Degrees(+13.13821629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88254",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88254"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.32805131),
        dec: Angle.Degrees(+13.14226236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15113",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15113"},
        {"Smithsonian Astrophysical Observation", "SAO 93356"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.73009935),
        dec: Angle.Degrees(+13.14238309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16084"},
        {"Hipparcos Number", "HIP 12049"},
        {"Geneva Identification System", "GEN# +1.00016084"},
        {"Smithsonian Astrophysical Observation", "SAO 93012"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.83690881),
        dec: Angle.Degrees(+13.14277276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 253422"},
        {"Hipparcos Number", "HIP 29493"},
        {"Fundamental Katalog 5th Edition", "FK5 4566"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.22540896),
        dec: Angle.Degrees(+13.14460855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214473"},
        {"Hipparcos Number", "HIP 111754"},
        {"Geneva Identification System", "GEN# +1.00214473"},
        {"Smithsonian Astrophysical Observation", "SAO 108059"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.57962986),
        dec: Angle.Degrees(+13.14655011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54565"},
        {"Hipparcos Number", "HIP 34591"},
        {"Smithsonian Astrophysical Observation", "SAO 96577"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.47478075),
        dec: Angle.Degrees(+13.14757507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37754"},
        {"Hipparcos Number", "HIP 26798"},
        {"Fundamental Katalog 5th Edition", "FK5 4517"},
        {"Smithsonian Astrophysical Observation", "SAO 94764"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.37071296),
        dec: Angle.Degrees(+13.14829972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35968"},
        {"Hipparcos Number", "HIP 25671"},
        {"Geneva Identification System", "GEN# +1.00035968"},
        {"Smithsonian Astrophysical Observation", "SAO 94584"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.24864333),
        dec: Angle.Degrees(+13.14860993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150633"},
        {"Hipparcos Number", "HIP 81748"},
        {"Cincinnati Publication", "Ci 18 2226"},
        {"Geneva Identification System", "GEN# +1.00150633"},
        {"Smithsonian Astrophysical Observation", "SAO 102327"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.45925399),
        dec: Angle.Degrees(+13.14943097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -243.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132032"},
        {"Hipparcos Number", "HIP 73128"},
        {"Geneva Identification System", "GEN# +1.00132032"},
        {"Smithsonian Astrophysical Observation", "SAO 101296"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.18309710),
        dec: Angle.Degrees(+13.14943788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75129",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75129"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.28625191),
        dec: Angle.Degrees(+13.14980996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4409"},
        {"Hipparcos Number", "HIP 3625"},
        {"Smithsonian Astrophysical Observation", "SAO 92071"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.62335874),
        dec: Angle.Degrees(+13.15210510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222995"},
        {"Hipparcos Number", "HIP 117186"},
        {"Geneva Identification System", "GEN# +1.00222995"},
        {"Smithsonian Astrophysical Observation", "SAO 108813"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.40506818),
        dec: Angle.Degrees(+13.15271060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90348"},
        {"Hipparcos Number", "HIP 51070"},
        {"Geneva Identification System", "GEN# +1.00090348"},
        {"Smithsonian Astrophysical Observation", "SAO 99115"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.52378458),
        dec: Angle.Degrees(+13.15273635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67425"},
        {"Hipparcos Number", "HIP 39839"},
        {"Smithsonian Astrophysical Observation", "SAO 97587"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.09680525),
        dec: Angle.Degrees(+13.15333506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65240",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65240"},
        {"Smithsonian Astrophysical Observation", "SAO 100535"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.53475464),
        dec: Angle.Degrees(+13.15539593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214245"},
        {"Hipparcos Number", "HIP 111615"},
        {"Geneva Identification System", "GEN# +1.00214245"},
        {"Smithsonian Astrophysical Observation", "SAO 108038"},
        {"Wilson Evans Batten Catalogue", "WEB 19952"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.17427892),
        dec: Angle.Degrees(+13.15576701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149160"},
        {"Hipparcos Number", "HIP 80997"},
        {"Geneva Identification System", "GEN# +1.00149160"},
        {"Smithsonian Astrophysical Observation", "SAO 102230"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.12942699),
        dec: Angle.Degrees(+13.15652455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286496"},
        {"Hipparcos Number", "HIP 19180"},
        {"Smithsonian Astrophysical Observation", "SAO 93767"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.66861811),
        dec: Angle.Degrees(+13.15726698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212671"},
        {"Hipparcos Number", "HIP 110705"},
        {"Geneva Identification System", "GEN# +1.00212671"},
        {"Smithsonian Astrophysical Observation", "SAO 107908"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.44304612),
        dec: Angle.Degrees(+13.15735206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90957",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90957"},
        {"Geneva Identification System", "GEN# +0.01303683"},
        {"Wilson Evans Batten Catalogue", "WEB 15601"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.32028543),
        dec: Angle.Degrees(+13.15774694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -274.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108136"},
        {"Hipparcos Number", "HIP 60604"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.32760047),
        dec: Angle.Degrees(+13.15950214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85979",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10633 A"},
        {"Henry Draper", "HD 159466"},
        {"Hipparcos Number", "HIP 85979"},
        {"Smithsonian Astrophysical Observation", "SAO 102925"},
        {"Wilson Evans Batten Catalogue", "WEB 14506"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.59164064),
        dec: Angle.Degrees(+13.16102699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9417"},
        {"Hipparcos Number", "HIP 7198"},
        {"Smithsonian Astrophysical Observation", "SAO 92500"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.19188685),
        dec: Angle.Degrees(+13.16138576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57340"},
        {"Hipparcos Number", "HIP 35646"},
        {"Geneva Identification System", "GEN# +1.00057340"},
        {"Smithsonian Astrophysical Observation", "SAO 96809"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.33745782),
        dec: Angle.Degrees(+13.16471449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95770"},
        {"Hipparcos Number", "HIP 54034"},
        {"Smithsonian Astrophysical Observation", "SAO 99418"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.83101729),
        dec: Angle.Degrees(+13.16530091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17105"},
        {"Hipparcos Number", "HIP 12844"},
        {"Smithsonian Astrophysical Observation", "SAO 93086"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.28197556),
        dec: Angle.Degrees(+13.16531004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62888",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8696 AB"},
        {"Henry Draper", "HD 112016"},
        {"Hipparcos Number", "HIP 62888"},
        {"Smithsonian Astrophysical Observation", "SAO 100319"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.32825774),
        dec: Angle.Degrees(+13.16542151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96032",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12553 A"},
        {"Henry Draper", "HD 183956"},
        {"Hipparcos Number", "HIP 96032"},
        {"Smithsonian Astrophysical Observation", "SAO 104931"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.88546833),
        dec: Angle.Degrees(+13.16626753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219163"},
        {"Hipparcos Number", "HIP 114660"},
        {"Smithsonian Astrophysical Observation", "SAO 108467"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.40653517),
        dec: Angle.Degrees(+13.16630835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77416",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77416"},
        {"Smithsonian Astrophysical Observation", "SAO 101746"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.07588498),
        dec: Angle.Degrees(+13.16696185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203220"},
        {"Hipparcos Number", "HIP 105371"},
        {"Geneva Identification System", "GEN# +1.00203220"},
        {"Smithsonian Astrophysical Observation", "SAO 107048"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.13966031),
        dec: Angle.Degrees(+13.16703424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68093",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68093"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.11637123),
        dec: Angle.Degrees(+13.16762853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113124"},
        {"Hipparcos Number", "HIP 63556"},
        {"Geneva Identification System", "GEN# +1.00113124"},
        {"Smithsonian Astrophysical Observation", "SAO 100378"},
        {"Wilson Evans Batten Catalogue", "WEB 11247"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.35008497),
        dec: Angle.Degrees(+13.16978338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19477"},
        {"Hipparcos Number", "HIP 14579"},
        {"Smithsonian Astrophysical Observation", "SAO 93292"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.05325282),
        dec: Angle.Degrees(+13.17007889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185938"},
        {"Hipparcos Number", "HIP 96845"},
        {"Geneva Identification System", "GEN# +1.00185938"},
        {"Smithsonian Astrophysical Observation", "SAO 105134"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.28367838),
        dec: Angle.Degrees(+13.17050241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113172"},
        {"Hipparcos Number", "HIP 63577"},
        {"Smithsonian Astrophysical Observation", "SAO 100382"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.42412625),
        dec: Angle.Degrees(+13.17358659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135992"},
        {"Hipparcos Number", "HIP 74855"},
        {"Geneva Identification System", "GEN# +1.00135992"},
        {"Smithsonian Astrophysical Observation", "SAO 101477"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.45205472),
        dec: Angle.Degrees(+13.17361983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115056",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115056"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.55137146),
        dec: Angle.Degrees(+13.17535860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112008",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16179 A"},
        {"Henry Draper", "HD 214893"},
        {"Hipparcos Number", "HIP 112008"},
        {"Smithsonian Astrophysical Observation", "SAO 108100"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.806,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.32381719),
        dec: Angle.Degrees(+13.17549426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13248"},
        {"Hipparcos Number", "HIP 10094"},
        {"Fundamental Katalog 5th Edition", "FK5 4199"},
        {"Geneva Identification System", "GEN# +1.00013248"},
        {"Renson", "Renson 3440"},
        {"Smithsonian Astrophysical Observation", "SAO 92812"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.44401843),
        dec: Angle.Degrees(+13.17582549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103256",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103256"},
        {"Cincinnati Publication", "Ci 20 1237"},
        {"Geneva Identification System", "GEN# +0.01204499"},
        {"Smithsonian Astrophysical Observation", "SAO 106650"},
        {"Wilson Evans Batten Catalogue", "WEB 18762"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.77721400),
        dec: Angle.Degrees(+13.17584752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 549.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 372.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90778",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11418 B"},
        {"Hipparcos Number", "HIP 90778"},
        {"Smithsonian Astrophysical Observation", "SAO 103803"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.80507028),
        dec: Angle.Degrees(+13.17753599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53388",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53388"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.80204026),
        dec: Angle.Degrees(+13.17775729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33202",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5559 A"},
        {"Henry Draper", "HD 50635A"},
        {"Henry Draper 2", "HD 50635"},
        {"Hipparcos Number", "HIP 33202"},
        {"Geneva Identification System", "GEN# +1.00050635"},
        {"Renson", "Renson 13910"},
        {"Smithsonian Astrophysical Observation", "SAO 96265"},
        {"Wilson Evans Batten Catalogue", "WEB 6675"},
    },
    visualMagnitude: 4.73,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.66080771),
        dec: Angle.Degrees(+13.17801628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13638",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2220 AB"},
        {"Hipparcos Number", "HIP 13638"},
        {"Smithsonian Astrophysical Observation", "SAO 93187"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.90497439),
        dec: Angle.Degrees(+13.17843229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167807"},
        {"Hipparcos Number", "HIP 89549"},
        {"Geneva Identification System", "GEN# +1.00167807"},
        {"Smithsonian Astrophysical Observation", "SAO 103547"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.08586758),
        dec: Angle.Degrees(+13.17961518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11042",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11042"},
        {"Smithsonian Astrophysical Observation", "SAO 92904"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.54863457),
        dec: Angle.Degrees(+13.18137114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90777",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11418 A"},
        {"Henry Draper", "HD 170879"},
        {"Hipparcos Number", "HIP 90777"},
        {"Smithsonian Astrophysical Observation", "SAO 103802"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.80398168),
        dec: Angle.Degrees(+13.18206994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120350"},
        {"Hipparcos Number", "HIP 67390"},
        {"Geneva Identification System", "GEN# +1.00120350"},
        {"Smithsonian Astrophysical Observation", "SAO 100718"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.17736990),
        dec: Angle.Degrees(+13.18233029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224447"},
        {"Hipparcos Number", "HIP 118152"},
        {"Smithsonian Astrophysical Observation", "SAO 108934"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.49708488),
        dec: Angle.Degrees(+13.18302409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99646"},
        {"Hipparcos Number", "HIP 55963"},
        {"Smithsonian Astrophysical Observation", "SAO 99617"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.02173673),
        dec: Angle.Degrees(+13.18493014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36709",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36709"},
        {"Smithsonian Astrophysical Observation", "SAO 97007"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.26206701),
        dec: Angle.Degrees(+13.18551654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220184"},
        {"Hipparcos Number", "HIP 115335"},
        {"Smithsonian Astrophysical Observation", "SAO 108565"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.41172348),
        dec: Angle.Degrees(+13.18708646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19270"},
        {"Hipparcos Number", "HIP 14439"},
        {"Fundamental Katalog 5th Edition", "FK5 2220"},
        {"Geneva Identification System", "GEN# +1.00019270"},
        {"Smithsonian Astrophysical Observation", "SAO 93276"},
        {"Wilson Evans Batten Catalogue", "WEB 2814"},
    },
    visualMagnitude: 5.64,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.59869819),
        dec: Angle.Degrees(+13.18740263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70995",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70995"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.80608232),
        dec: Angle.Degrees(+13.18809851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178569"},
        {"Hipparcos Number", "HIP 94032"},
        {"Smithsonian Astrophysical Observation", "SAO 104523"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.16410289),
        dec: Angle.Degrees(+13.18899260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10937"},
        {"Hipparcos Number", "HIP 8342"},
        {"Smithsonian Astrophysical Observation", "SAO 92632"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.90080916),
        dec: Angle.Degrees(+13.19005885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286418"},
        {"Hipparcos Number", "HIP 18683"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.01485807),
        dec: Angle.Degrees(+13.19036435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49564"},
        {"Hipparcos Number", "HIP 32726"},
        {"Geneva Identification System", "GEN# +1.00049564"},
        {"Smithsonian Astrophysical Observation", "SAO 96157"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.40111632),
        dec: Angle.Degrees(+13.19053883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41936",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41936"},
        {"Wilson Evans Batten Catalogue", "WEB 8071"},
    },
    visualMagnitude: 11.36,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.23002470),
        dec: Angle.Degrees(+13.19131255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120541"},
        {"Hipparcos Number", "HIP 67495"},
        {"Geneva Identification System", "GEN# +1.00120541"},
        {"Smithsonian Astrophysical Observation", "SAO 100728"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.46844827),
        dec: Angle.Degrees(+13.19189959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188508"},
        {"Hipparcos Number", "HIP 98016"},
        {"Smithsonian Astrophysical Observation", "SAO 105415"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.77468155),
        dec: Angle.Degrees(+13.19397022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173271"},
        {"Hipparcos Number", "HIP 91885"},
        {"Geneva Identification System", "GEN# +1.00173271"},
        {"Smithsonian Astrophysical Observation", "SAO 104034"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.97227653),
        dec: Angle.Degrees(+13.19473815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166870"},
        {"Hipparcos Number", "HIP 89182"},
        {"Smithsonian Astrophysical Observation", "SAO 103467"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.00939043),
        dec: Angle.Degrees(+13.19678186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142267"},
        {"Hipparcos Number", "HIP 77801"},
        {"Cincinnati Publication", "Ci 20 949"},
        {"Fundamental Katalog 5th Edition", "FK5 3254"},
        {"Geneva Identification System", "GEN# +1.00142267"},
        {"Smithsonian Astrophysical Observation", "SAO 101792"},
        {"Wilson Evans Batten Catalogue", "WEB 13159"},
    },
    visualMagnitude: 6.07,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.30078139),
        dec: Angle.Degrees(+13.19799059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -562.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87999",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87999"},
        {"Wilson Evans Batten Catalogue", "WEB 14860"},
    },
    visualMagnitude: 10.67,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.62857692),
        dec: Angle.Degrees(+13.19834682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17133",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17133"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.04144154),
        dec: Angle.Degrees(+13.19879578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203960"},
        {"Hipparcos Number", "HIP 105744"},
        {"Smithsonian Astrophysical Observation", "SAO 107113"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.26768514),
        dec: Angle.Degrees(+13.19983627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73923"},
        {"Hipparcos Number", "HIP 42630"},
        {"Smithsonian Astrophysical Observation", "SAO 98040"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.31933698),
        dec: Angle.Degrees(+13.20040974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3268"},
        {"Hipparcos Number", "HIP 2832"},
        {"Geneva Identification System", "GEN# +1.00003268"},
        {"Smithsonian Astrophysical Observation", "SAO 91990"},
        {"Wilson Evans Batten Catalogue", "WEB 507"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.97867189),
        dec: Angle.Degrees(+13.20750244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47513",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47513"},
        {"Cincinnati Publication", "Ci 20 540"},
        {"Geneva Identification System", "GEN# +9.80042017"},
        {"Wilson Evans Batten Catalogue", "WEB 8913"},
    },
    visualMagnitude: 10.38,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.29481658),
        dec: Angle.Degrees(+13.20991003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -664.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224372"},
        {"Hipparcos Number", "HIP 118089"},
        {"Geneva Identification System", "GEN# +1.00224372"},
        {"Smithsonian Astrophysical Observation", "SAO 108927"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.31947132),
        dec: Angle.Degrees(+13.21249406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224071"},
        {"Hipparcos Number", "HIP 117899"},
        {"Smithsonian Astrophysical Observation", "SAO 108905"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.71512952),
        dec: Angle.Degrees(+13.21466550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193373"},
        {"Hipparcos Number", "HIP 100208"},
        {"Geneva Identification System", "GEN# +1.00193373"},
        {"Smithsonian Astrophysical Observation", "SAO 105961"},
        {"Wilson Evans Batten Catalogue", "WEB 18054"},
    },
    visualMagnitude: 6.20,
    bvColour: 1.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.87210564),
        dec: Angle.Degrees(+13.21681049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229635"},
        {"Hipparcos Number", "HIP 92388"},
        {"Geneva Identification System", "GEN# +1.00229635"},
        {"Smithsonian Astrophysical Observation", "SAO 104149"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.41025874),
        dec: Angle.Degrees(+13.21914865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -195.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -221.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2648",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2648"},
        {"Smithsonian Astrophysical Observation", "SAO 91967"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.39481112),
        dec: Angle.Degrees(+13.22055988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78420"},
        {"Hipparcos Number", "HIP 44862"},
        {"Smithsonian Astrophysical Observation", "SAO 98383"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.11066539),
        dec: Angle.Degrees(+13.22057496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97339"},
        {"Hipparcos Number", "HIP 54730"},
        {"Geneva Identification System", "GEN# +1.00097339"},
        {"Smithsonian Astrophysical Observation", "SAO 99497"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.07520797),
        dec: Angle.Degrees(+13.22077995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175579"},
        {"Hipparcos Number", "HIP 92876"},
        {"Geneva Identification System", "GEN# +1.00175579"},
        {"Smithsonian Astrophysical Observation", "SAO 104261"},
        {"Wilson Evans Batten Catalogue", "WEB 16082"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.86818210),
        dec: Angle.Degrees(+13.22245533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 869",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 869"},
        {"Smithsonian Astrophysical Observation", "SAO 91760"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.66937648),
        dec: Angle.Degrees(+13.22299119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242688"},
        {"Hipparcos Number", "HIP 24870"},
        {"Smithsonian Astrophysical Observation", "SAO 94463"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.97515940),
        dec: Angle.Degrees(+13.22330911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82557",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82557"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.12398842),
        dec: Angle.Degrees(+13.22393800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113731"},
        {"Hipparcos Number", "HIP 63888"},
        {"Geneva Identification System", "GEN# +1.00113731"},
        {"Smithsonian Astrophysical Observation", "SAO 100409"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.39348874),
        dec: Angle.Degrees(+13.22639945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32249",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5387 A"},
        {"Henry Draper", "HD 48433"},
        {"Hipparcos Number", "HIP 32249"},
        {"Geneva Identification System", "GEN# +1.00048433"},
        {"Smithsonian Astrophysical Observation", "SAO 96051"},
        {"Wilson Evans Batten Catalogue", "WEB 6501"},
    },
    visualMagnitude: 4.49,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.99705857),
        dec: Angle.Degrees(+13.22814319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243086"},
        {"Hipparcos Number", "HIP 25127"},
        {"Smithsonian Astrophysical Observation", "SAO 94502"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.67796662),
        dec: Angle.Degrees(+13.22919231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186548"},
        {"Hipparcos Number", "HIP 97141"},
        {"Smithsonian Astrophysical Observation", "SAO 105200"},
        {"Wilson Evans Batten Catalogue", "WEB 17051"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.14922186),
        dec: Angle.Degrees(+13.23035220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75784"},
        {"Hipparcos Number", "HIP 43569"},
        {"Fundamental Katalog 5th Edition", "FK5 4793"},
        {"Geneva Identification System", "GEN# +1.00075784"},
        {"Smithsonian Astrophysical Observation", "SAO 98188"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.10005640),
        dec: Angle.Degrees(+13.23364990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134323"},
        {"Hipparcos Number", "HIP 74121"},
        {"Geneva Identification System", "GEN# +1.00134323"},
        {"Smithsonian Astrophysical Observation", "SAO 101403"},
        {"Wilson Evans Batten Catalogue", "WEB 12662"},
    },
    visualMagnitude: 6.16,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.22307913),
        dec: Angle.Degrees(+13.23506161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68849",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68849"},
    },
    visualMagnitude: 11.16,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.48011786),
        dec: Angle.Degrees(+13.23572173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 248954"},
        {"Hipparcos Number", "HIP 27883"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.50520953),
        dec: Angle.Degrees(+13.23660548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53199"},
        {"Hipparcos Number", "HIP 34143"},
        {"Smithsonian Astrophysical Observation", "SAO 96457"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.20119921),
        dec: Angle.Degrees(+13.23867179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18813"},
        {"Hipparcos Number", "HIP 14111"},
        {"Smithsonian Astrophysical Observation", "SAO 93246"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.48448591),
        dec: Angle.Degrees(+13.23944436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41566"},
        {"Hipparcos Number", "HIP 28938"},
        {"Smithsonian Astrophysical Observation", "SAO 95233"},
    },
    visualMagnitude: 9.01,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.61987899),
        dec: Angle.Degrees(+13.24220489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65522"},
        {"Hipparcos Number", "HIP 39067"},
        {"Geneva Identification System", "GEN# +1.00065522"},
        {"Smithsonian Astrophysical Observation", "SAO 97445"},
        {"Wilson Evans Batten Catalogue", "WEB 7662"},
    },
    visualMagnitude: 6.05,
    bvColour: 1.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.89611315),
        dec: Angle.Degrees(+13.24220492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186077"},
        {"Hipparcos Number", "HIP 96905"},
        {"Smithsonian Astrophysical Observation", "SAO 105152"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.47825605),
        dec: Angle.Degrees(+13.24678060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17557",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17557"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.40002279),
        dec: Angle.Degrees(+13.24740818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6694",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6694"},
    },
    visualMagnitude: 10.63,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.48888689),
        dec: Angle.Degrees(+13.24834251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 230993"},
        {"Hipparcos Number", "HIP 94618"},
        {"Smithsonian Astrophysical Observation", "SAO 104654"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.82109093),
        dec: Angle.Degrees(+13.24956252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155643"},
        {"Hipparcos Number", "HIP 84167"},
        {"Smithsonian Astrophysical Observation", "SAO 102645"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.09522008),
        dec: Angle.Degrees(+13.25098475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28911"},
        {"Hipparcos Number", "HIP 21267"},
        {"Celescope Catalog", "CEL 430"},
        {"Geneva Identification System", "GEN# +5.20250094"},
        {"Smithsonian Astrophysical Observation", "SAO 94006"},
        {"Wilson Evans Batten Catalogue", "WEB 4088"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.44408500),
        dec: Angle.Degrees(+13.25192686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6512"},
        {"Hipparcos Number", "HIP 5176"},
        {"Geneva Identification System", "GEN# +1.00006512"},
        {"Smithsonian Astrophysical Observation", "SAO 92245"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.55221696),
        dec: Angle.Degrees(+13.25278682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104608",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104608"},
    },
    visualMagnitude: 11.01,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.86008437),
        dec: Angle.Degrees(+13.25332824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72505"},
        {"Hipparcos Number", "HIP 42010"},
        {"Geneva Identification System", "GEN# +1.00072505"},
        {"Smithsonian Astrophysical Observation", "SAO 97913"},
        {"Wilson Evans Batten Catalogue", "WEB 8081"},
    },
    visualMagnitude: 6.26,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.43776897),
        dec: Angle.Degrees(+13.25742717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181830"},
        {"Hipparcos Number", "HIP 95148"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.37128439),
        dec: Angle.Degrees(+13.25768602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159889"},
        {"Hipparcos Number", "HIP 86172"},
        {"Smithsonian Astrophysical Observation", "SAO 102957"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.13903577),
        dec: Angle.Degrees(+13.25933366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82350",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10225 A"},
        {"Henry Draper", "HD 151862"},
        {"Hipparcos Number", "HIP 82350"},
        {"Geneva Identification System", "GEN# +1.00151862J"},
        {"Smithsonian Astrophysical Observation", "SAO 102410"},
        {"Wilson Evans Batten Catalogue", "WEB 13902"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.39447601),
        dec: Angle.Degrees(+13.26119970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82236",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82236"},
        {"Geneva Identification System", "GEN# +0.01303224"},
        {"Renson", "Renson 42920"},
    },
    visualMagnitude: 10.55,
    bvColour: -0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.01956674),
        dec: Angle.Degrees(+13.26177372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106038"},
        {"Hipparcos Number", "HIP 59490"},
        {"Geneva Identification System", "GEN# +1.00106038"},
        {"Smithsonian Astrophysical Observation", "SAO 99984"},
        {"Wilson Evans Batten Catalogue", "WEB 10576"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.00624835),
        dec: Angle.Degrees(+13.26235157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -216.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -438.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74721"},
        {"Hipparcos Number", "HIP 43018"},
        {"Geneva Identification System", "GEN# +1.00074721"},
        {"Smithsonian Astrophysical Observation", "SAO 98102"},
        {"Wilson Evans Batten Catalogue", "WEB 8310"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.49702328),
        dec: Angle.Degrees(+13.26377893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133006"},
        {"Hipparcos Number", "HIP 73537"},
        {"Smithsonian Astrophysical Observation", "SAO 101332"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.45562100),
        dec: Angle.Degrees(+13.26527614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80744",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80744"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.28857510),
        dec: Angle.Degrees(+13.26889549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65044"},
        {"Hipparcos Number", "HIP 38874"},
        {"Smithsonian Astrophysical Observation", "SAO 97410"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.32718338),
        dec: Angle.Degrees(+13.26924804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78446",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9880 AB"},
        {"Henry Draper", "HD 143597"},
        {"Hipparcos Number", "HIP 78446"},
        {"Smithsonian Astrophysical Observation", "SAO 101874"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.22568659),
        dec: Angle.Degrees(+13.27171758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47865",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47865"},
        {"Smithsonian Astrophysical Observation", "SAO 98746"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.33699399),
        dec: Angle.Degrees(+13.27284942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3349"},
        {"Hipparcos Number", "HIP 2885"},
        {"Geneva Identification System", "GEN# +1.00003349"},
        {"Smithsonian Astrophysical Observation", "SAO 91994"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.13808052),
        dec: Angle.Degrees(+13.27288009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135165"},
        {"Hipparcos Number", "HIP 74496"},
        {"Smithsonian Astrophysical Observation", "SAO 101444"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.34176870),
        dec: Angle.Degrees(+13.27337654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147770"},
        {"Hipparcos Number", "HIP 80289"},
        {"Geneva Identification System", "GEN# +1.00147770"},
        {"Smithsonian Astrophysical Observation", "SAO 102123"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.84370972),
        dec: Angle.Degrees(+13.27613226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53633",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7996 A"},
        {"Henry Draper", "HD 95023"},
        {"Hipparcos Number", "HIP 53633"},
        {"Smithsonian Astrophysical Observation", "SAO 99378"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.57828288),
        dec: Angle.Degrees(+13.27832611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53632",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7996 B"},
        {"Hipparcos Number", "HIP 53632"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.57750575),
        dec: Angle.Degrees(+13.28360526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160488"},
        {"Hipparcos Number", "HIP 86435"},
        {"Geneva Identification System", "GEN# +1.00160488"},
        {"Smithsonian Astrophysical Observation", "SAO 103009"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.91733469),
        dec: Angle.Degrees(+13.28394526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63865",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63865"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.32831848),
        dec: Angle.Degrees(+13.28431280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36860"},
        {"Hipparcos Number", "HIP 26231"},
        {"Smithsonian Astrophysical Observation", "SAO 94673"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.83508853),
        dec: Angle.Degrees(+13.28455044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32734"},
        {"Hipparcos Number", "HIP 23710"},
        {"Cincinnati Publication", "Ci 18 656"},
        {"Smithsonian Astrophysical Observation", "SAO 94311"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.45563154),
        dec: Angle.Degrees(+13.28630833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101733",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101733"},
        {"Smithsonian Astrophysical Observation", "SAO 106311"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.30905371),
        dec: Angle.Degrees(+13.28644682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90719"},
        {"Hipparcos Number", "HIP 51295"},
        {"Smithsonian Astrophysical Observation", "SAO 99149"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.17714727),
        dec: Angle.Degrees(+13.28888231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206486"},
        {"Hipparcos Number", "HIP 107131"},
        {"Smithsonian Astrophysical Observation", "SAO 107333"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.51085067),
        dec: Angle.Degrees(+13.28914036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40912"},
        {"Hipparcos Number", "HIP 28620"},
        {"Geneva Identification System", "GEN# +1.00040912"},
        {"Smithsonian Astrophysical Observation", "SAO 95150"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.62828996),
        dec: Angle.Degrees(+13.28978878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16981"},
        {"Hipparcos Number", "HIP 12738"},
        {"Smithsonian Astrophysical Observation", "SAO 93075"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.93725349),
        dec: Angle.Degrees(+13.29015322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83010",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83010"},
    },
    visualMagnitude: 10.66,
    bvColour: 1.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.44202994),
        dec: Angle.Degrees(+13.29144867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22404"},
        {"Hipparcos Number", "HIP 16841"},
        {"Smithsonian Astrophysical Observation", "SAO 93514"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.18710378),
        dec: Angle.Degrees(+13.29185760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127128"},
        {"Hipparcos Number", "HIP 70854"},
        {"Smithsonian Astrophysical Observation", "SAO 101047"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.33606584),
        dec: Angle.Degrees(+13.29395415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132050"},
        {"Hipparcos Number", "HIP 73141"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.20441736),
        dec: Angle.Degrees(+13.29486940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25707"},
        {"Hipparcos Number", "HIP 19067"},
        {"Smithsonian Astrophysical Observation", "SAO 93750"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.29653722),
        dec: Angle.Degrees(+13.29675914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106774"},
        {"Hipparcos Number", "HIP 59867"},
        {"Geneva Identification System", "GEN# +1.00106774"},
        {"Smithsonian Astrophysical Observation", "SAO 100016"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.16942719),
        dec: Angle.Degrees(+13.29712075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198458"},
        {"Hipparcos Number", "HIP 102850"},
        {"Smithsonian Astrophysical Observation", "SAO 106549"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.53953605),
        dec: Angle.Degrees(+13.29842260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90104",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90104"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.82032396),
        dec: Angle.Degrees(+13.30205487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79554",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79554"},
        {"Smithsonian Astrophysical Observation", "SAO 102025"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.50107544),
        dec: Angle.Degrees(+13.30276189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186547"},
        {"Hipparcos Number", "HIP 97139"},
        {"Geneva Identification System", "GEN# +1.00186547"},
        {"Smithsonian Astrophysical Observation", "SAO 105199"},
        {"Wilson Evans Batten Catalogue", "WEB 17050"},
    },
    visualMagnitude: 6.25,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.14246074),
        dec: Angle.Degrees(+13.30280916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168875"},
        {"Hipparcos Number", "HIP 89976"},
        {"Smithsonian Astrophysical Observation", "SAO 103635"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.36567686),
        dec: Angle.Degrees(+13.30619151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64304",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8810 A"},
        {"Henry Draper", "HD 114493"},
        {"Hipparcos Number", "HIP 64304"},
        {"Geneva Identification System", "GEN# +1.00114493"},
        {"Smithsonian Astrophysical Observation", "SAO 100446"},
        {"Wilson Evans Batten Catalogue", "WEB 11364"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.69689763),
        dec: Angle.Degrees(+13.30676545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4164"},
        {"Hipparcos Number", "HIP 3457"},
        {"Geneva Identification System", "GEN# +1.00004164"},
        {"Smithsonian Astrophysical Observation", "SAO 92058"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.05504204),
        dec: Angle.Degrees(+13.30727278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97907"},
        {"Hipparcos Number", "HIP 55016"},
        {"Geneva Identification System", "GEN# +1.00097907"},
        {"Smithsonian Astrophysical Observation", "SAO 99525"},
        {"Wilson Evans Batten Catalogue", "WEB 9925"},
    },
    visualMagnitude: 5.31,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.96623670),
        dec: Angle.Degrees(+13.30759308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32595"},
        {"Hipparcos Number", "HIP 23629"},
        {"Geneva Identification System", "GEN# +1.00032595"},
        {"Smithsonian Astrophysical Observation", "SAO 94296"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.20452674),
        dec: Angle.Degrees(+13.30887401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56347",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56347"},
        {"Smithsonian Astrophysical Observation", "SAO 99658"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.26249168),
        dec: Angle.Degrees(+13.30924706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -236.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156497"},
        {"Hipparcos Number", "HIP 84584"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.35042368),
        dec: Angle.Degrees(+13.31022587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224742"},
        {"Hipparcos Number", "HIP 23"},
        {"Geneva Identification System", "GEN# +1.00224742"},
        {"Smithsonian Astrophysical Observation", "SAO 108955"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.07442930),
        dec: Angle.Degrees(+13.31221083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81291",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81291"},
        {"Smithsonian Astrophysical Observation", "SAO 102266"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.04862562),
        dec: Angle.Degrees(+13.31248699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83509"},
        {"Hipparcos Number", "HIP 47388"},
        {"Geneva Identification System", "GEN# +1.00083509"},
        {"Smithsonian Astrophysical Observation", "SAO 98696"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.82193508),
        dec: Angle.Degrees(+13.31253835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141354"},
        {"Hipparcos Number", "HIP 77425"},
        {"Geneva Identification System", "GEN# +1.00141354"},
        {"Smithsonian Astrophysical Observation", "SAO 101748"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.09170016),
        dec: Angle.Degrees(+13.31340361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196725"},
        {"Hipparcos Number", "HIP 101882"},
        {"Geneva Identification System", "GEN# +1.00196725"},
        {"Smithsonian Astrophysical Observation", "SAO 106342"},
        {"Wilson Evans Batten Catalogue", "WEB 18408"},
    },
    visualMagnitude: 5.69,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.68326968),
        dec: Angle.Degrees(+13.31512567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117536",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117536"},
        {"Smithsonian Astrophysical Observation", "SAO 108862"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.54527567),
        dec: Angle.Degrees(+13.31535175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47149",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47149"},
    },
    visualMagnitude: 11.42,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.11321020),
        dec: Angle.Degrees(+13.31575751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127933"},
        {"Hipparcos Number", "HIP 71211"},
        {"Smithsonian Astrophysical Observation", "SAO 101078"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.44614684),
        dec: Angle.Degrees(+13.31703116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134026"},
        {"Hipparcos Number", "HIP 74002"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.84464697),
        dec: Angle.Degrees(+13.32025387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78875",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9922 A"},
        {"Henry Draper", "HD 144564"},
        {"Hipparcos Number", "HIP 78875"},
        {"Smithsonian Astrophysical Observation", "SAO 101922"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.51173308),
        dec: Angle.Degrees(+13.32097576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132739"},
        {"Hipparcos Number", "HIP 73425"},
        {"Geneva Identification System", "GEN# +1.00132739"},
        {"Renson", "Renson 37650"},
        {"Smithsonian Astrophysical Observation", "SAO 101323"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.07799141),
        dec: Angle.Degrees(+13.32127621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215401"},
        {"Hipparcos Number", "HIP 112299"},
        {"Smithsonian Astrophysical Observation", "SAO 108144"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.19107356),
        dec: Angle.Degrees(+13.32315651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116976",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116976"},
        {"Geneva Identification System", "GEN# +0.01205016"},
        {"Smithsonian Astrophysical Observation", "SAO 108783"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.69964964),
        dec: Angle.Degrees(+13.32337858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111382"},
        {"Hipparcos Number", "HIP 62524"},
        {"Geneva Identification System", "GEN# +1.00111382"},
        {"Smithsonian Astrophysical Observation", "SAO 100276"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.20039424),
        dec: Angle.Degrees(+13.32384719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190969"},
        {"Hipparcos Number", "HIP 99093"},
        {"Smithsonian Astrophysical Observation", "SAO 105705"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.75772544),
        dec: Angle.Degrees(+13.32430121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200242"},
        {"Hipparcos Number", "HIP 103798"},
        {"Smithsonian Astrophysical Observation", "SAO 106767"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.49324026),
        dec: Angle.Degrees(+13.32446180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157789"},
        {"Hipparcos Number", "HIP 85229"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.22796935),
        dec: Angle.Degrees(+13.32870518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160365"},
        {"Hipparcos Number", "HIP 86373"},
        {"Geneva Identification System", "GEN# +1.00160365"},
        {"Smithsonian Astrophysical Observation", "SAO 102999"},
        {"Wilson Evans Batten Catalogue", "WEB 14575"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.74111526),
        dec: Angle.Degrees(+13.32915582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78873",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9922 B"},
        {"Henry Draper", "HD 144563"},
        {"Hipparcos Number", "HIP 78873"},
        {"Smithsonian Astrophysical Observation", "SAO 101921"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.50520663),
        dec: Angle.Degrees(+13.32925273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65220"},
        {"Hipparcos Number", "HIP 38954"},
        {"Geneva Identification System", "GEN# +1.00065220"},
        {"Smithsonian Astrophysical Observation", "SAO 97423"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.54632170),
        dec: Angle.Degrees(+13.32960571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196645"},
        {"Hipparcos Number", "HIP 101848"},
        {"Smithsonian Astrophysical Observation", "SAO 106335"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.58687779),
        dec: Angle.Degrees(+13.33118858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 91.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18044"},
        {"Hipparcos Number", "HIP 13530"},
        {"Smithsonian Astrophysical Observation", "SAO 93172"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.829,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.56342224),
        dec: Angle.Degrees(+13.33131727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64730"},
        {"Hipparcos Number", "HIP 38730"},
        {"Geneva Identification System", "GEN# +1.00064730"},
        {"Smithsonian Astrophysical Observation", "SAO 97374"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.93931454),
        dec: Angle.Degrees(+13.33199464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61871",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61871"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.18516830),
        dec: Angle.Degrees(+13.33405620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85227",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85227"},
        {"Smithsonian Astrophysical Observation", "SAO 102807"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.22385827),
        dec: Angle.Degrees(+13.33444746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48716"},
        {"Hipparcos Number", "HIP 32359"},
        {"Smithsonian Astrophysical Observation", "SAO 96073"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.31074860),
        dec: Angle.Degrees(+13.33593334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144839"},
        {"Hipparcos Number", "HIP 78993"},
        {"Geneva Identification System", "GEN# +1.00144839"},
        {"Smithsonian Astrophysical Observation", "SAO 101938"},
        {"Wilson Evans Batten Catalogue", "WEB 13351"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.85726422),
        dec: Angle.Degrees(+13.33639338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100506",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13767 C"},
        {"Hipparcos Number", "HIP 100506"},
        {"Smithsonian Astrophysical Observation", "SAO 106040"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.70379994),
        dec: Angle.Degrees(+13.33671141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120247"},
        {"Hipparcos Number", "HIP 67336"},
        {"Geneva Identification System", "GEN# +1.00120247"},
        {"Smithsonian Astrophysical Observation", "SAO 100714"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.01970880),
        dec: Angle.Degrees(+13.33674193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196834"},
        {"Hipparcos Number", "HIP 101943"},
        {"Smithsonian Astrophysical Observation", "SAO 106352"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.87532635),
        dec: Angle.Degrees(+13.34093185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6849"},
        {"Hipparcos Number", "HIP 5408"},
        {"Smithsonian Astrophysical Observation", "SAO 92278"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.29861054),
        dec: Angle.Degrees(+13.34153634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90492",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90492"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.98093760),
        dec: Angle.Degrees(+13.34185436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12805"},
        {"Hipparcos Number", "HIP 9782"},
        {"Geneva Identification System", "GEN# +1.00012805"},
        {"Smithsonian Astrophysical Observation", "SAO 92789"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.44603667),
        dec: Angle.Degrees(+13.34276773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112034"},
        {"Hipparcos Number", "HIP 62893"},
        {"Smithsonian Astrophysical Observation", "SAO 100320"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.34015323),
        dec: Angle.Degrees(+13.34390231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77776"},
        {"Hipparcos Number", "HIP 44581"},
        {"Geneva Identification System", "GEN# +1.00077776"},
        {"Smithsonian Astrophysical Observation", "SAO 98343"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.24212883),
        dec: Angle.Degrees(+13.34399858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110815"},
        {"Hipparcos Number", "HIP 62176"},
        {"Fundamental Katalog 5th Edition", "FK5 5127"},
        {"Geneva Identification System", "GEN# +1.00110815"},
        {"Smithsonian Astrophysical Observation", "SAO 100231"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.14020158),
        dec: Angle.Degrees(+13.34863196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146643"},
        {"Hipparcos Number", "HIP 79767"},
        {"Smithsonian Astrophysical Observation", "SAO 102056"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.20114513),
        dec: Angle.Degrees(+13.35050886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49929",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7674 AB"},
        {"Henry Draper", "HD 88355"},
        {"Hipparcos Number", "HIP 49929"},
        {"Geneva Identification System", "GEN# +1.00088355"},
        {"Smithsonian Astrophysical Observation", "SAO 98991"},
        {"Wilson Evans Batten Catalogue", "WEB 9188"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.90911694),
        dec: Angle.Degrees(+13.35520406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66449",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66449"},
        {"Smithsonian Astrophysical Observation", "SAO 100638"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.33765308),
        dec: Angle.Degrees(+13.35692623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44956",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7214 AB"},
        {"Henry Draper", "HD 78609"},
        {"Hipparcos Number", "HIP 44956"},
        {"Smithsonian Astrophysical Observation", "SAO 98395"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.37925419),
        dec: Angle.Degrees(+13.35695262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86070",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10648 AB"},
        {"Henry Draper", "HD 159673"},
        {"Hipparcos Number", "HIP 86070"},
        {"Smithsonian Astrophysical Observation", "SAO 102943"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.86127730),
        dec: Angle.Degrees(+13.36186365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185017"},
        {"Hipparcos Number", "HIP 96466"},
        {"Smithsonian Astrophysical Observation", "SAO 105042"},
    },
    visualMagnitude: 7.72,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.17731741),
        dec: Angle.Degrees(+13.36247112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82053"},
        {"Hipparcos Number", "HIP 46576"},
        {"Smithsonian Astrophysical Observation", "SAO 98605"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.47180495),
        dec: Angle.Degrees(+13.36283571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137126"},
        {"Hipparcos Number", "HIP 75356"},
        {"Geneva Identification System", "GEN# +1.00137126"},
        {"Smithsonian Astrophysical Observation", "SAO 101526"},
        {"Wilson Evans Batten Catalogue", "WEB 12854"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.99351348),
        dec: Angle.Degrees(+13.36482800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225126"},
        {"Hipparcos Number", "HIP 298"},
        {"Smithsonian Astrophysical Observation", "SAO 91681"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.92695552),
        dec: Angle.Degrees(+13.36518977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136925"},
        {"Hipparcos Number", "HIP 75281"},
        {"Geneva Identification System", "GEN# +1.00136925"},
        {"Smithsonian Astrophysical Observation", "SAO 101514"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.71762705),
        dec: Angle.Degrees(+13.36649402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -271.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286352"},
        {"Hipparcos Number", "HIP 18467"},
        {"Smithsonian Astrophysical Observation", "SAO 93682"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.20813285),
        dec: Angle.Degrees(+13.36704734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213063"},
        {"Hipparcos Number", "HIP 110943"},
        {"Smithsonian Astrophysical Observation", "SAO 107944"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.17499326),
        dec: Angle.Degrees(+13.36836869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49476"},
        {"Hipparcos Number", "HIP 32687"},
        {"Smithsonian Astrophysical Observation", "SAO 96145"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.28400316),
        dec: Angle.Degrees(+13.36926892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172558"},
        {"Hipparcos Number", "HIP 91569"},
        {"Geneva Identification System", "GEN# +1.00172558"},
        {"Smithsonian Astrophysical Observation", "SAO 103976"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.09131071),
        dec: Angle.Degrees(+13.37002668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3166"},
        {"Hipparcos Number", "HIP 2734"},
        {"Smithsonian Astrophysical Observation", "SAO 91980"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.73086587),
        dec: Angle.Degrees(+13.37126922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63352"},
        {"Hipparcos Number", "HIP 38147"},
        {"Geneva Identification System", "GEN# +1.00063352"},
        {"Smithsonian Astrophysical Observation", "SAO 97273"},
        {"Wilson Evans Batten Catalogue", "WEB 7516"},
    },
    visualMagnitude: 6.07,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.25755784),
        dec: Angle.Degrees(+13.37188806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175922"},
        {"Hipparcos Number", "HIP 93046"},
        {"Geneva Identification System", "GEN# +1.00175922"},
        {"Renson", "Renson 49120"},
        {"Smithsonian Astrophysical Observation", "SAO 104280"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.30221966),
        dec: Angle.Degrees(+13.37248751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33708"},
        {"Hipparcos Number", "HIP 24286"},
        {"Geneva Identification System", "GEN# +1.00033708"},
        {"Smithsonian Astrophysical Observation", "SAO 94393"},
        {"Wilson Evans Batten Catalogue", "WEB 4710"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.17967404),
        dec: Angle.Degrees(+13.37278923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214437"},
        {"Hipparcos Number", "HIP 111732"},
        {"Smithsonian Astrophysical Observation", "SAO 108055"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.49975429),
        dec: Angle.Degrees(+13.37404654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20656"},
        {"Hipparcos Number", "HIP 15508"},
        {"Geneva Identification System", "GEN# +1.00020656"},
        {"Smithsonian Astrophysical Observation", "SAO 93387"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.96667508),
        dec: Angle.Degrees(+13.37709676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58253",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58253"},
        {"Geneva Identification System", "GEN# +9.80012011"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.21077100),
        dec: Angle.Degrees(+13.37782899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -322.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242038"},
        {"Hipparcos Number", "HIP 24511"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.86310597),
        dec: Angle.Degrees(+13.37842300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52775",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52775"},
        {"Smithsonian Astrophysical Observation", "SAO 99292"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.85274086),
        dec: Angle.Degrees(+13.37904462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137722"},
        {"Hipparcos Number", "HIP 75635"},
        {"Geneva Identification System", "GEN# +1.00137722"},
        {"Smithsonian Astrophysical Observation", "SAO 101561"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.79389304),
        dec: Angle.Degrees(+13.37974843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189692"},
        {"Hipparcos Number", "HIP 98517"},
        {"Smithsonian Astrophysical Observation", "SAO 105543"},
        {"Wilson Evans Batten Catalogue", "WEB 17400"},
    },
    visualMagnitude: 7.22,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.21612451),
        dec: Angle.Degrees(+13.37975192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48233"},
        {"Hipparcos Number", "HIP 32170"},
        {"Smithsonian Astrophysical Observation", "SAO 96033"},
    },
    visualMagnitude: 9.22,
    bvColour: -0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.75848701),
        dec: Angle.Degrees(+13.38168940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179590"},
        {"Hipparcos Number", "HIP 94386"},
        {"Geneva Identification System", "GEN# +1.00179590"},
        {"Smithsonian Astrophysical Observation", "SAO 104606"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.17572828),
        dec: Angle.Degrees(+13.38328796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39032"},
        {"Hipparcos Number", "HIP 27587"},
        {"Smithsonian Astrophysical Observation", "SAO 94907"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.62439226),
        dec: Angle.Degrees(+13.38336577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142442"},
        {"Hipparcos Number", "HIP 77873"},
        {"Smithsonian Astrophysical Observation", "SAO 101802"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.53919334),
        dec: Angle.Degrees(+13.38387620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12281"},
        {"Hipparcos Number", "HIP 9405"},
        {"Smithsonian Astrophysical Observation", "SAO 92748"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.20420168),
        dec: Angle.Degrees(+13.38458607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231391"},
        {"Hipparcos Number", "HIP 95541"},
        {"Smithsonian Astrophysical Observation", "SAO 104825"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.50203299),
        dec: Angle.Degrees(+13.38522284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194406"},
        {"Hipparcos Number", "HIP 100709"},
        {"Geneva Identification System", "GEN# +1.00194406"},
        {"Smithsonian Astrophysical Observation", "SAO 106084"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.26157856),
        dec: Angle.Degrees(+13.38618821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102429"},
        {"Hipparcos Number", "HIP 57527"},
        {"Geneva Identification System", "GEN# +1.00102429"},
        {"Smithsonian Astrophysical Observation", "SAO 99794"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.86033258),
        dec: Angle.Degrees(+13.38628703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68201",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68201"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.43963393),
        dec: Angle.Degrees(+13.38694399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81108"},
        {"Hipparcos Number", "HIP 46094"},
        {"Smithsonian Astrophysical Observation", "SAO 98544"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.00003064),
        dec: Angle.Degrees(+13.38824227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99699",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99699"},
        {"Cincinnati Publication", "Ci 20 1198"},
    },
    visualMagnitude: 11.30,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.46480959),
        dec: Angle.Degrees(+13.38876287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 423.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68224"},
        {"Hipparcos Number", "HIP 40151"},
        {"Geneva Identification System", "GEN# +1.00068224"},
        {"Smithsonian Astrophysical Observation", "SAO 97644"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.98719561),
        dec: Angle.Degrees(+13.38913398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175334"},
        {"Hipparcos Number", "HIP 92778"},
        {"Geneva Identification System", "GEN# +1.00175334"},
        {"Smithsonian Astrophysical Observation", "SAO 104241"},
        {"Wilson Evans Batten Catalogue", "WEB 16054"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.59104368),
        dec: Angle.Degrees(+13.38979878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98388"},
        {"Hipparcos Number", "HIP 55262"},
        {"Geneva Identification System", "GEN# +1.00098388"},
        {"Smithsonian Astrophysical Observation", "SAO 99552"},
        {"Wilson Evans Batten Catalogue", "WEB 9955"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.77792681),
        dec: Angle.Degrees(+13.39075349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112963",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112963"},
        {"Smithsonian Astrophysical Observation", "SAO 108226"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.15745956),
        dec: Angle.Degrees(+13.39108850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114883"},
        {"Hipparcos Number", "HIP 64507"},
        {"Geneva Identification System", "GEN# +1.00114883"},
        {"Smithsonian Astrophysical Observation", "SAO 100469"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.32637289),
        dec: Angle.Degrees(+13.39146775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1553"},
        {"Hipparcos Number", "HIP 1589"},
        {"Geneva Identification System", "GEN# +1.00001553"},
        {"Smithsonian Astrophysical Observation", "SAO 91849"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.96981777),
        dec: Angle.Degrees(+13.39331312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149381"},
        {"Hipparcos Number", "HIP 81095"},
        {"Smithsonian Astrophysical Observation", "SAO 102245"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.45978468),
        dec: Angle.Degrees(+13.39485363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87"},
        {"Hipparcos Number", "HIP 476"},
        {"Fundamental Katalog 5th Edition", "FK5 2004"},
        {"Geneva Identification System", "GEN# +1.00000087"},
        {"Smithsonian Astrophysical Observation", "SAO 91701"},
        {"Wilson Evans Batten Catalogue", "WEB 80"},
    },
    visualMagnitude: 5.55,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.42473238),
        dec: Angle.Degrees(+13.39628227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85109",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10517 AB"},
        {"Henry Draper", "HD 157606"},
        {"Hipparcos Number", "HIP 85109"},
        {"Smithsonian Astrophysical Observation", "SAO 102790"},
        {"Wilson Evans Batten Catalogue", "WEB 14369"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.90798914),
        dec: Angle.Degrees(+13.39760414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49938",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49938"},
        {"Smithsonian Astrophysical Observation", "SAO 98993"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.94690699),
        dec: Angle.Degrees(+13.39818878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26171"},
        {"Hipparcos Number", "HIP 19376"},
        {"Fundamental Katalog 5th Edition", "FK5 2298"},
        {"Geneva Identification System", "GEN# +1.00026171"},
        {"Smithsonian Astrophysical Observation", "SAO 93784"},
        {"Wilson Evans Batten Catalogue", "WEB 3719"},
    },
    visualMagnitude: 5.94,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.25650273),
        dec: Angle.Degrees(+13.39829829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14970"},
        {"Hipparcos Number", "HIP 11271"},
        {"Smithsonian Astrophysical Observation", "SAO 92936"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.28818925),
        dec: Angle.Degrees(+13.40233324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53794"},
        {"Hipparcos Number", "HIP 34328"},
        {"Smithsonian Astrophysical Observation", "SAO 96499"},
    },
    visualMagnitude: 7.78,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.73990574),
        dec: Angle.Degrees(+13.40287225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125123"},
        {"Hipparcos Number", "HIP 69807"},
        {"Smithsonian Astrophysical Observation", "SAO 100954"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.29482873),
        dec: Angle.Degrees(+13.40423464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60183"},
        {"Hipparcos Number", "HIP 36771"},
        {"Geneva Identification System", "GEN# +1.00060183"},
        {"Smithsonian Astrophysical Observation", "SAO 97020"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.44734216),
        dec: Angle.Degrees(+13.40815293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107183",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107183"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.65397212),
        dec: Angle.Degrees(+13.40957263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49140",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49140"},
    },
    visualMagnitude: 10.15,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.43284228),
        dec: Angle.Degrees(+13.40989405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213891"},
        {"Hipparcos Number", "HIP 111422"},
        {"Smithsonian Astrophysical Observation", "SAO 108007"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.60429819),
        dec: Angle.Degrees(+13.41010740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217299"},
        {"Hipparcos Number", "HIP 113536"},
        {"Smithsonian Astrophysical Observation", "SAO 108315"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.91841476),
        dec: Angle.Degrees(+13.41028618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104453"},
        {"Hipparcos Number", "HIP 58663"},
        {"Fundamental Katalog 5th Edition", "FK5 5059"},
        {"Geneva Identification System", "GEN# +1.00104453"},
        {"Smithsonian Astrophysical Observation", "SAO 99915"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.43669415),
        dec: Angle.Degrees(+13.41038917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155374"},
        {"Hipparcos Number", "HIP 84032"},
        {"Geneva Identification System", "GEN# +1.00155374"},
        {"Smithsonian Astrophysical Observation", "SAO 102630"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.67612301),
        dec: Angle.Degrees(+13.41180316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110933"},
        {"Hipparcos Number", "HIP 62251"},
        {"Geneva Identification System", "GEN# +1.00110933"},
        {"Smithsonian Astrophysical Observation", "SAO 100237"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.36135010),
        dec: Angle.Degrees(+13.41264755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36838"},
        {"Hipparcos Number", "HIP 26204"},
        {"Smithsonian Astrophysical Observation", "SAO 94666"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.77493820),
        dec: Angle.Degrees(+13.41308720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49738"},
        {"Hipparcos Number", "HIP 32814"},
        {"Geneva Identification System", "GEN# +1.00049738"},
        {"Smithsonian Astrophysical Observation", "SAO 96179"},
        {"Wilson Evans Batten Catalogue", "WEB 6606"},
    },
    visualMagnitude: 5.68,
    bvColour: 1.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.60624923),
        dec: Angle.Degrees(+13.41319516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16273",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16273"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.45436619),
        dec: Angle.Degrees(+13.41500276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78735",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78735"},
        {"Smithsonian Astrophysical Observation", "SAO 101904"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.10405098),
        dec: Angle.Degrees(+13.41530386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34454"},
        {"Hipparcos Number", "HIP 24716"},
        {"Fundamental Katalog 5th Edition", "FK5 4482"},
        {"Geneva Identification System", "GEN# +1.00034454"},
        {"Wilson Evans Batten Catalogue", "WEB 4780"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.51704047),
        dec: Angle.Degrees(+13.41777143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38094",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6379 A"},
        {"Henry Draper", "HD 63240"},
        {"Hipparcos Number", "HIP 38094"},
        {"Smithsonian Astrophysical Observation", "SAO 97261"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.09548260),
        dec: Angle.Degrees(+13.41842823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1122"},
        {"Hipparcos Number", "HIP 1245"},
        {"Geneva Identification System", "GEN# +1.00001122"},
        {"Smithsonian Astrophysical Observation", "SAO 91800"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.88528629),
        dec: Angle.Degrees(+13.41941870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196884"},
        {"Hipparcos Number", "HIP 101967"},
        {"Smithsonian Astrophysical Observation", "SAO 106362"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.96769915),
        dec: Angle.Degrees(+13.41969505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 356668"},
        {"Hipparcos Number", "HIP 99151"},
        {"Geneva Identification System", "GEN# +1.00356668"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.93861674),
        dec: Angle.Degrees(+13.42063155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -196.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103188"},
        {"Hipparcos Number", "HIP 57941"},
        {"Geneva Identification System", "GEN# +1.00103188"},
        {"Smithsonian Astrophysical Observation", "SAO 99843"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.23369045),
        dec: Angle.Degrees(+13.42113357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64391"},
        {"Hipparcos Number", "HIP 38598"},
        {"Geneva Identification System", "GEN# +1.00064391"},
        {"Smithsonian Astrophysical Observation", "SAO 97352"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.54931536),
        dec: Angle.Degrees(+13.42128198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201307"},
        {"Hipparcos Number", "HIP 104348"},
        {"Geneva Identification System", "GEN# +1.00201307"},
        {"Smithsonian Astrophysical Observation", "SAO 106866"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.09595996),
        dec: Angle.Degrees(+13.42327196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116274",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116274"},
        {"Smithsonian Astrophysical Observation", "SAO 108676"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.38129534),
        dec: Angle.Degrees(+13.42340047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86700",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86700"},
        {"Smithsonian Astrophysical Observation", "SAO 103044"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.71927773),
        dec: Angle.Degrees(+13.42352683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111256"},
        {"Hipparcos Number", "HIP 62442"},
        {"Geneva Identification System", "GEN# +1.00111256"},
        {"Smithsonian Astrophysical Observation", "SAO 100264"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.96311362),
        dec: Angle.Degrees(+13.42394033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8703",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1482 AB"},
        {"Henry Draper", "HD 11364"},
        {"Hipparcos Number", "HIP 8703"},
        {"Smithsonian Astrophysical Observation", "SAO 92668"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.99000041),
        dec: Angle.Degrees(+13.42721904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36045"},
        {"Hipparcos Number", "HIP 25717"},
        {"Geneva Identification System", "GEN# +1.00036045"},
        {"Smithsonian Astrophysical Observation", "SAO 94588"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.36365254),
        dec: Angle.Degrees(+13.42757089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91307",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91307"},
        {"Smithsonian Astrophysical Observation", "SAO 103923"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.37286675),
        dec: Angle.Degrees(+13.42810970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14203"},
        {"Hipparcos Number", "HIP 10730"},
        {"Geneva Identification System", "GEN# +1.00014203"},
        {"Smithsonian Astrophysical Observation", "SAO 92879"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.52488377),
        dec: Angle.Degrees(+13.42977434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15583"},
        {"Hipparcos Number", "HIP 11691"},
        {"Smithsonian Astrophysical Observation", "SAO 92982"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.69884915),
        dec: Angle.Degrees(+13.42984420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 124.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15662",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15662"},
    },
    visualMagnitude: 11.10,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.43063227),
        dec: Angle.Degrees(+13.43217248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12710",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12710"},
        {"Geneva Identification System", "GEN# +9.80004036"},
    },
    visualMagnitude: 11.47,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.84102008),
        dec: Angle.Degrees(+13.43285220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 343.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126583"},
        {"Hipparcos Number", "HIP 70557"},
        {"Cincinnati Publication", "Ci 18 1896"},
        {"Geneva Identification System", "GEN# +1.00126583"},
        {"Smithsonian Astrophysical Observation", "SAO 101019"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.49347036),
        dec: Angle.Degrees(+13.43357104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -297.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220976"},
        {"Hipparcos Number", "HIP 115837"},
        {"Smithsonian Astrophysical Observation", "SAO 108623"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.01690955),
        dec: Angle.Degrees(+13.43364336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30051",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4924 A"},
        {"Henry Draper", "HD 43931"},
        {"Hipparcos Number", "HIP 30051"},
        {"Geneva Identification System", "GEN# +1.00043931"},
        {"Smithsonian Astrophysical Observation", "SAO 95534"},
        {"Wilson Evans Batten Catalogue", "WEB 5971"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.85581640),
        dec: Angle.Degrees(+13.43396441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154692"},
        {"Hipparcos Number", "HIP 83713"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.62896192),
        dec: Angle.Degrees(+13.44027587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113812"},
        {"Hipparcos Number", "HIP 63936"},
        {"Smithsonian Astrophysical Observation", "SAO 100413"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.55316584),
        dec: Angle.Degrees(+13.44141655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50324",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50324"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.15113647),
        dec: Angle.Degrees(+13.44165670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -139.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84182"},
        {"Hipparcos Number", "HIP 47706"},
        {"Smithsonian Astrophysical Observation", "SAO 98730"},
        {"Wilson Evans Batten Catalogue", "WEB 8939"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.90157268),
        dec: Angle.Degrees(+13.44216051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173952"},
        {"Hipparcos Number", "HIP 92222"},
        {"Smithsonian Astrophysical Observation", "SAO 104106"},
        {"Wilson Evans Batten Catalogue", "WEB 15908"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.92399402),
        dec: Angle.Degrees(+13.44233515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115387",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115387"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.60807880),
        dec: Angle.Degrees(+13.44273865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40134",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6649 A"},
        {"Henry Draper", "HD 68197"},
        {"Hipparcos Number", "HIP 40134"},
        {"Smithsonian Astrophysical Observation", "SAO 97643"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.95622415),
        dec: Angle.Degrees(+13.44581134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 247709"},
        {"Hipparcos Number", "HIP 27373"},
        {"Smithsonian Astrophysical Observation", "SAO 94866"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.96518781),
        dec: Angle.Degrees(+13.44583750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118624"},
        {"Hipparcos Number", "HIP 66496"},
        {"Geneva Identification System", "GEN# +1.00118624"},
        {"Smithsonian Astrophysical Observation", "SAO 100641"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.47062598),
        dec: Angle.Degrees(+13.44688507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30055",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4924 B"},
        {"Henry Draper", "HD 43930"},
        {"Hipparcos Number", "HIP 30055"},
        {"Geneva Identification System", "GEN# +1.00043930"},
        {"Smithsonian Astrophysical Observation", "SAO 95536"},
        {"Wilson Evans Batten Catalogue", "WEB 5974"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.87027106),
        dec: Angle.Degrees(+13.44837180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84498"},
        {"Hipparcos Number", "HIP 47930"},
        {"Geneva Identification System", "GEN# +1.00084498"},
        {"Smithsonian Astrophysical Observation", "SAO 98752"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.51165520),
        dec: Angle.Degrees(+13.45006461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117140",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117140"},
        {"Smithsonian Astrophysical Observation", "SAO 108809"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.21564715),
        dec: Angle.Degrees(+13.45109780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49002",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49002"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.95677991),
        dec: Angle.Degrees(+13.45155148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134532"},
        {"Hipparcos Number", "HIP 74218"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.49540786),
        dec: Angle.Degrees(+13.45352428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -257.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55870",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55870"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.77180480),
        dec: Angle.Degrees(+13.45412110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187182"},
        {"Hipparcos Number", "HIP 97431"},
        {"Geneva Identification System", "GEN# +1.00187182"},
        {"Smithsonian Astrophysical Observation", "SAO 105274"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.03603693),
        dec: Angle.Degrees(+13.45460738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147508"},
        {"Hipparcos Number", "HIP 80166"},
        {"Geneva Identification System", "GEN# +1.00147508"},
        {"Smithsonian Astrophysical Observation", "SAO 102104"},
        {"Wilson Evans Batten Catalogue", "WEB 13571"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.47725088),
        dec: Angle.Degrees(+13.45546121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12886"},
        {"Hipparcos Number", "HIP 9828"},
        {"Smithsonian Astrophysical Observation", "SAO 92795"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.62329461),
        dec: Angle.Degrees(+13.46192581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66291",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66291"},
        {"Geneva Identification System", "GEN# +6.20001084"},
        {"Renson", "Renson 34100"},
    },
    visualMagnitude: 11.84,
    bvColour: -0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.79994228),
        dec: Angle.Degrees(+13.46227048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214227"},
        {"Hipparcos Number", "HIP 111607"},
        {"Smithsonian Astrophysical Observation", "SAO 108037"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.15709989),
        dec: Angle.Degrees(+13.46464230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196110"},
        {"Hipparcos Number", "HIP 101554"},
        {"Smithsonian Astrophysical Observation", "SAO 106265"},
    },
    visualMagnitude: 7.50,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.70477212),
        dec: Angle.Degrees(+13.46467748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65923",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65923"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.71921268),
        dec: Angle.Degrees(+13.46753048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217427"},
        {"Hipparcos Number", "HIP 113601"},
        {"Smithsonian Astrophysical Observation", "SAO 108327"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.13484858),
        dec: Angle.Degrees(+13.46864767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176090"},
        {"Hipparcos Number", "HIP 93107"},
        {"Smithsonian Astrophysical Observation", "SAO 104293"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.50995670),
        dec: Angle.Degrees(+13.46896072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135697"},
        {"Hipparcos Number", "HIP 74711"},
        {"Geneva Identification System", "GEN# +1.00135697"},
        {"Smithsonian Astrophysical Observation", "SAO 101464"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.02973372),
        dec: Angle.Degrees(+13.47024122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143762"},
        {"Hipparcos Number", "HIP 78525"},
        {"Geneva Identification System", "GEN# +1.00143762"},
        {"Smithsonian Astrophysical Observation", "SAO 101883"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.46922763),
        dec: Angle.Degrees(+13.47242768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104977"},
        {"Hipparcos Number", "HIP 58943"},
        {"Geneva Identification System", "GEN# +1.00104977"},
        {"Smithsonian Astrophysical Observation", "SAO 99933"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.29045454),
        dec: Angle.Degrees(+13.47293983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63660",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8751 AB"},
        {"Henry Draper", "HD 113322"},
        {"Hipparcos Number", "HIP 63660"},
        {"Smithsonian Astrophysical Observation", "SAO 100391"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.71282277),
        dec: Angle.Degrees(+13.47335327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106740",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106740"},
        {"Wilson Evans Batten Catalogue", "WEB 19299"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.33710949),
        dec: Angle.Degrees(+13.47459637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12479"},
        {"Hipparcos Number", "HIP 9533"},
        {"Geneva Identification System", "GEN# +1.00012479"},
        {"Smithsonian Astrophysical Observation", "SAO 92763"},
        {"Wilson Evans Batten Catalogue", "WEB 2000"},
    },
    visualMagnitude: 5.97,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.64615770),
        dec: Angle.Degrees(+13.47672808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131158"},
        {"Hipparcos Number", "HIP 72674"},
        {"Smithsonian Astrophysical Observation", "SAO 101251"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.88553986),
        dec: Angle.Degrees(+13.47776588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84780"},
        {"Hipparcos Number", "HIP 48060"},
        {"Smithsonian Astrophysical Observation", "SAO 98773"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.96163949),
        dec: Angle.Degrees(+13.47778903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105551",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105551"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.65487421),
        dec: Angle.Degrees(+13.47909482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61885"},
        {"Hipparcos Number", "HIP 37508"},
        {"Geneva Identification System", "GEN# +1.00061885"},
        {"Smithsonian Astrophysical Observation", "SAO 97154"},
        {"Wilson Evans Batten Catalogue", "WEB 7419"},
    },
    visualMagnitude: 5.79,
    bvColour: 1.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.46611813),
        dec: Angle.Degrees(+13.48051383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2579"},
        {"Hipparcos Number", "HIP 2313"},
        {"Smithsonian Astrophysical Observation", "SAO 91922"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.37897372),
        dec: Angle.Degrees(+13.48060695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1772",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 303 A"},
        {"Henry Draper", "HD 1796"},
        {"Hipparcos Number", "HIP 1772"},
        {"Fundamental Katalog 5th Edition", "FK5 2020"},
        {"Geneva Identification System", "GEN# +1.00001796"},
        {"Smithsonian Astrophysical Observation", "SAO 91866"},
        {"Wilson Evans Batten Catalogue", "WEB 316"},
    },
    visualMagnitude: 6.25,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.60602210),
        dec: Angle.Degrees(+13.48243411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165508"},
        {"Hipparcos Number", "HIP 88630"},
        {"Geneva Identification System", "GEN# +1.00165508"},
        {"Smithsonian Astrophysical Observation", "SAO 103376"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.43608328),
        dec: Angle.Degrees(+13.48328934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88938",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11108 AB"},
        {"Henry Draper", "HD 166256"},
        {"Hipparcos Number", "HIP 88938"},
        {"Geneva Identification System", "GEN# +1.00166256J"},
        {"Smithsonian Astrophysical Observation", "SAO 103430"},
    },
    visualMagnitude: 8.52,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.31300757),
        dec: Angle.Degrees(+13.48509949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82213"},
        {"Hipparcos Number", "HIP 46680"},
        {"Smithsonian Astrophysical Observation", "SAO 98620"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.75494063),
        dec: Angle.Degrees(+13.48586096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57886",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57886"},
        {"Geneva Identification System", "GEN# +0.01402443"},
        {"Smithsonian Astrophysical Observation", "SAO 99834"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.07739255),
        dec: Angle.Degrees(+13.48705571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120569"},
        {"Hipparcos Number", "HIP 67519"},
        {"Geneva Identification System", "GEN# +1.00120569"},
        {"Smithsonian Astrophysical Observation", "SAO 100732"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.52323958),
        dec: Angle.Degrees(+13.48725390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207980"},
        {"Hipparcos Number", "HIP 108002"},
        {"Smithsonian Astrophysical Observation", "SAO 107463"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.20832734),
        dec: Angle.Degrees(+13.48887981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110855"},
        {"Hipparcos Number", "HIP 62198"},
        {"Cincinnati Publication", "Ci 18 1619"},
        {"Geneva Identification System", "GEN# +1.00110855"},
        {"Smithsonian Astrophysical Observation", "SAO 100233"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.22090007),
        dec: Angle.Degrees(+13.48946723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -271.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17778"},
        {"Hipparcos Number", "HIP 13324"},
        {"Smithsonian Astrophysical Observation", "SAO 93145"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.87114385),
        dec: Angle.Degrees(+13.49328598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82176"},
        {"Hipparcos Number", "HIP 46650"},
        {"Smithsonian Astrophysical Observation", "SAO 98617"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.67387437),
        dec: Angle.Degrees(+13.49603954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88028",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88028"},
        {"Wilson Evans Batten Catalogue", "WEB 14868"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.70261400),
        dec: Angle.Degrees(+13.49629466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96550"},
        {"Hipparcos Number", "HIP 54386"},
        {"Geneva Identification System", "GEN# +1.00096550"},
        {"Smithsonian Astrophysical Observation", "SAO 99460"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.91393822),
        dec: Angle.Degrees(+13.49904347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87205",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87205"},
        {"Smithsonian Astrophysical Observation", "SAO 103132"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.24643051),
        dec: Angle.Degrees(+13.50208420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115633",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115633"},
        {"Smithsonian Astrophysical Observation", "SAO 108602"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.36748054),
        dec: Angle.Degrees(+13.50404110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66775"},
        {"Hipparcos Number", "HIP 39601"},
        {"Smithsonian Astrophysical Observation", "SAO 97548"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.38833693),
        dec: Angle.Degrees(+13.50417207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24443"},
        {"Hipparcos Number", "HIP 18220"},
        {"Geneva Identification System", "GEN# +1.00024443"},
        {"Smithsonian Astrophysical Observation", "SAO 93655"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.43874958),
        dec: Angle.Degrees(+13.50503063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70785"},
        {"Hipparcos Number", "HIP 41189"},
        {"Geneva Identification System", "GEN# +1.00070785"},
        {"Smithsonian Astrophysical Observation", "SAO 97791"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.08181071),
        dec: Angle.Degrees(+13.50612713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23538"},
        {"Hipparcos Number", "HIP 17617"},
        {"Smithsonian Astrophysical Observation", "SAO 93590"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.60932939),
        dec: Angle.Degrees(+13.50916609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204893"},
        {"Hipparcos Number", "HIP 106254"},
        {"Smithsonian Astrophysical Observation", "SAO 107197"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.82413703),
        dec: Angle.Degrees(+13.51321673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22957",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3540 A"},
        {"Henry Draper", "HD 31421"},
        {"Hipparcos Number", "HIP 22957"},
        {"Geneva Identification System", "GEN# +1.00031421"},
        {"Smithsonian Astrophysical Observation", "SAO 94218"},
        {"Wilson Evans Batten Catalogue", "WEB 4460"},
    },
    visualMagnitude: 4.06,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.09300449),
        dec: Angle.Degrees(+13.51457755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105321"},
        {"Hipparcos Number", "HIP 59138"},
        {"Geneva Identification System", "GEN# +1.00105321"},
        {"Smithsonian Astrophysical Observation", "SAO 99953"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.89972664),
        dec: Angle.Degrees(+13.51693367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136618"},
        {"Hipparcos Number", "HIP 75140"},
        {"Geneva Identification System", "GEN# +1.00136618"},
        {"Smithsonian Astrophysical Observation", "SAO 101502"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.33216326),
        dec: Angle.Degrees(+13.51694724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92565",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11763 AB"},
        {"Henry Draper", "HD 174791"},
        {"Hipparcos Number", "HIP 92565"},
        {"Smithsonian Astrophysical Observation", "SAO 104190"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.93221299),
        dec: Angle.Degrees(+13.51857525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17238",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17238"},
        {"Smithsonian Astrophysical Observation", "SAO 93554"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.37347941),
        dec: Angle.Degrees(+13.52359711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16639"},
        {"Hipparcos Number", "HIP 12461"},
        {"Smithsonian Astrophysical Observation", "SAO 93041"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.11280352),
        dec: Angle.Degrees(+13.52721891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154893"},
        {"Hipparcos Number", "HIP 83808"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.91494103),
        dec: Angle.Degrees(+13.52765105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79492",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9969 AB"},
        {"Aitken 2", "ADS 9969"},
        {"Henry Draper", "HD 145958"},
        {"Hipparcos Number", "HIP 79492"},
        {"Smithsonian Astrophysical Observation", "SAO 102018"},
        {"Wilson Evans Batten Catalogue", "WEB 13449"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.32642684),
        dec: Angle.Degrees(+13.52792867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 183.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -418.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83966"},
        {"Hipparcos Number", "HIP 47589"},
        {"Smithsonian Astrophysical Observation", "SAO 98720"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.55180824),
        dec: Angle.Degrees(+13.52922418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129153"},
        {"Hipparcos Number", "HIP 71759"},
        {"Geneva Identification System", "GEN# +1.00129153"},
        {"Smithsonian Astrophysical Observation", "SAO 101137"},
        {"Wilson Evans Batten Catalogue", "WEB 12363"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.17650164),
        dec: Angle.Degrees(+13.53436103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2547",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2547"},
        {"Smithsonian Astrophysical Observation", "SAO 91952"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.09836849),
        dec: Angle.Degrees(+13.53701211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41480"},
        {"Hipparcos Number", "HIP 28903"},
        {"Smithsonian Astrophysical Observation", "SAO 95226"},
    },
    visualMagnitude: 8.45,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.52607755),
        dec: Angle.Degrees(+13.53701366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25977"},
        {"Hipparcos Number", "HIP 19229"},
        {"Smithsonian Astrophysical Observation", "SAO 93772"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.82824753),
        dec: Angle.Degrees(+13.53832837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115986",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115986"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.48758905),
        dec: Angle.Degrees(+13.54205811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34720"},
        {"Hipparcos Number", "HIP 24883"},
        {"Geneva Identification System", "GEN# +1.00034720"},
        {"Smithsonian Astrophysical Observation", "SAO 94466"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.01508236),
        dec: Angle.Degrees(+13.54520689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127372"},
        {"Hipparcos Number", "HIP 70943"},
        {"Smithsonian Astrophysical Observation", "SAO 101060"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.66662651),
        dec: Angle.Degrees(+13.54521916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178096"},
        {"Hipparcos Number", "HIP 93850"},
        {"Smithsonian Astrophysical Observation", "SAO 104485"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.69733652),
        dec: Angle.Degrees(+13.54753546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193472"},
        {"Hipparcos Number", "HIP 100256"},
        {"Geneva Identification System", "GEN# +1.00193472"},
        {"Renson", "Renson 54020"},
        {"Smithsonian Astrophysical Observation", "SAO 105974"},
        {"Wilson Evans Batten Catalogue", "WEB 18072"},
    },
    visualMagnitude: 5.96,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.00079670),
        dec: Angle.Degrees(+13.54810109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33336"},
        {"Hipparcos Number", "HIP 24059"},
        {"Geneva Identification System", "GEN# +1.00033336"},
        {"Smithsonian Astrophysical Observation", "SAO 94363"},
        {"Wilson Evans Batten Catalogue", "WEB 4686"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.54352394),
        dec: Angle.Degrees(+13.54847265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4302",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4302"},
        {"Smithsonian Astrophysical Observation", "SAO 92152"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.78226574),
        dec: Angle.Degrees(+13.54973653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72490"},
        {"Hipparcos Number", "HIP 41997"},
        {"Geneva Identification System", "GEN# +1.00072490"},
        {"Smithsonian Astrophysical Observation", "SAO 97910"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.40265440),
        dec: Angle.Degrees(+13.55082706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41348",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41348"},
        {"Smithsonian Astrophysical Observation", "SAO 97810"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.53758966),
        dec: Angle.Degrees(+13.55170427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162735"},
        {"Hipparcos Number", "HIP 87420"},
        {"Geneva Identification System", "GEN# +1.00162735"},
        {"Smithsonian Astrophysical Observation", "SAO 103158"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.97071120),
        dec: Angle.Degrees(+13.55207561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100486"},
        {"Hipparcos Number", "HIP 56411"},
        {"Geneva Identification System", "GEN# +1.00100486"},
        {"Smithsonian Astrophysical Observation", "SAO 99666"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.48658334),
        dec: Angle.Degrees(+13.55208193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2277",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2277"},
        {"Smithsonian Astrophysical Observation", "SAO 91917"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.27868048),
        dec: Angle.Degrees(+13.55234738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 977"},
        {"Hipparcos Number", "HIP 1135"},
        {"Geneva Identification System", "GEN# +1.00000977"},
        {"Smithsonian Astrophysical Observation", "SAO 91788"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.54712696),
        dec: Angle.Degrees(+13.55236473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111308"},
        {"Hipparcos Number", "HIP 62478"},
        {"Geneva Identification System", "GEN# +1.00111308"},
        {"Smithsonian Astrophysical Observation", "SAO 100269"},
        {"Wilson Evans Batten Catalogue", "WEB 11091"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.05985106),
        dec: Angle.Degrees(+13.55310064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66985",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66985"},
        {"Geneva Identification System", "GEN# +0.01402655"},
        {"Smithsonian Astrophysical Observation", "SAO 100678"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.91989689),
        dec: Angle.Degrees(+13.55468985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197645"},
        {"Hipparcos Number", "HIP 102380"},
        {"Geneva Identification System", "GEN# +1.00197645"},
        {"Smithsonian Astrophysical Observation", "SAO 106438"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.16170439),
        dec: Angle.Degrees(+13.55535430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42563",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42563"},
        {"Geneva Identification System", "GEN# +0.01401947"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.14066223),
        dec: Angle.Degrees(+13.55676031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -425.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7791"},
        {"Hipparcos Number", "HIP 6050"},
        {"Geneva Identification System", "GEN# +1.00007791"},
        {"Smithsonian Astrophysical Observation", "SAO 92353"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.42780819),
        dec: Angle.Degrees(+13.55749431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94794"},
        {"Hipparcos Number", "HIP 53505"},
        {"Geneva Identification System", "GEN# +1.00094794"},
        {"Smithsonian Astrophysical Observation", "SAO 99364"},
        {"Wilson Evans Batten Catalogue", "WEB 9711"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.18501097),
        dec: Angle.Degrees(+13.55880362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124103"},
        {"Hipparcos Number", "HIP 69315"},
        {"Smithsonian Astrophysical Observation", "SAO 100899"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.81040392),
        dec: Angle.Degrees(+13.55911789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143587"},
        {"Hipparcos Number", "HIP 78439"},
        {"Smithsonian Astrophysical Observation", "SAO 101872"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.20564764),
        dec: Angle.Degrees(+13.55988620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179169"},
        {"Hipparcos Number", "HIP 94233"},
        {"Smithsonian Astrophysical Observation", "SAO 104564"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.73889302),
        dec: Angle.Degrees(+13.56108542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102972",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102972"},
        {"Smithsonian Astrophysical Observation", "SAO 106581"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.93577938),
        dec: Angle.Degrees(+13.56130506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43755",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43755"},
        {"Smithsonian Astrophysical Observation", "SAO 98224"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.69224787),
        dec: Angle.Degrees(+13.56148595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223894"},
        {"Hipparcos Number", "HIP 117801"},
        {"Smithsonian Astrophysical Observation", "SAO 108888"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.35255809),
        dec: Angle.Degrees(+13.56168510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202978"},
        {"Hipparcos Number", "HIP 105231"},
        {"Geneva Identification System", "GEN# +1.00202978"},
        {"Smithsonian Astrophysical Observation", "SAO 107023"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.73774026),
        dec: Angle.Degrees(+13.56601564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94089"},
        {"Hipparcos Number", "HIP 53097"},
        {"Smithsonian Astrophysical Observation", "SAO 99327"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.93771146),
        dec: Angle.Degrees(+13.56603958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173054"},
        {"Hipparcos Number", "HIP 91779"},
        {"Smithsonian Astrophysical Observation", "SAO 104013"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.72589981),
        dec: Angle.Degrees(+13.56675126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52249",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52249"},
        {"Smithsonian Astrophysical Observation", "SAO 99244"},
        {"Wilson Evans Batten Catalogue", "WEB 9517"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.13832660),
        dec: Angle.Degrees(+13.56690821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34547"},
        {"Hipparcos Number", "HIP 24789"},
        {"Geneva Identification System", "GEN# +1.00034547"},
        {"Renson", "Renson 8820"},
        {"Smithsonian Astrophysical Observation", "SAO 94455"},
        {"Wilson Evans Batten Catalogue", "WEB 4795"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.72053929),
        dec: Angle.Degrees(+13.56719541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154278"},
        {"Hipparcos Number", "HIP 83504"},
        {"Geneva Identification System", "GEN# +1.00154278"},
        {"Smithsonian Astrophysical Observation", "SAO 102569"},
        {"Wilson Evans Batten Catalogue", "WEB 14116"},
    },
    visualMagnitude: 6.06,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.99178693),
        dec: Angle.Degrees(+13.56773647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36153",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36153"},
    },
    visualMagnitude: 11.92,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.72468296),
        dec: Angle.Degrees(+13.57247824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71845",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71845"},
        {"Smithsonian Astrophysical Observation", "SAO 101153"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.44337338),
        dec: Angle.Degrees(+13.57586374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16399",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16399"},
        {"Smithsonian Astrophysical Observation", "SAO 93472"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.78925487),
        dec: Angle.Degrees(+13.57611123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38262"},
        {"Hipparcos Number", "HIP 27119"},
        {"Geneva Identification System", "GEN# +1.00038262"},
        {"Smithsonian Astrophysical Observation", "SAO 94828"},
        {"Wilson Evans Batten Catalogue", "WEB 5338"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.26316820),
        dec: Angle.Degrees(+13.57636769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181683"},
        {"Hipparcos Number", "HIP 95107"},
        {"Geneva Identification System", "GEN# +1.00181683"},
        {"Smithsonian Astrophysical Observation", "SAO 104749"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.22452989),
        dec: Angle.Degrees(+13.57670184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1497"},
        {"Hipparcos Number", "HIP 1541"},
        {"Geneva Identification System", "GEN# +1.00001497"},
        {"Smithsonian Astrophysical Observation", "SAO 91844"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.80326792),
        dec: Angle.Degrees(+13.57727485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286578"},
        {"Hipparcos Number", "HIP 19709"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.34400871),
        dec: Angle.Degrees(+13.57867225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76494",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76494"},
        {"Smithsonian Astrophysical Observation", "SAO 101652"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.35470538),
        dec: Angle.Degrees(+13.57959919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185937"},
        {"Hipparcos Number", "HIP 96844"},
        {"Smithsonian Astrophysical Observation", "SAO 105136"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.28137865),
        dec: Angle.Degrees(+13.58160014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35635"},
        {"Hipparcos Number", "HIP 25470"},
        {"Geneva Identification System", "GEN# +1.00035635"},
        {"Smithsonian Astrophysical Observation", "SAO 94551"},
    },
    visualMagnitude: 7.53,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.70123344),
        dec: Angle.Degrees(+13.58220202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64390"},
        {"Hipparcos Number", "HIP 38597"},
        {"Geneva Identification System", "GEN# +1.00064390"},
        {"Smithsonian Astrophysical Observation", "SAO 97351"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.54763990),
        dec: Angle.Degrees(+13.58246836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100406",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100406"},
    },
    visualMagnitude: 10.36,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.40870675),
        dec: Angle.Degrees(+13.58271531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110995"},
        {"Hipparcos Number", "HIP 62296"},
        {"Geneva Identification System", "GEN# +1.00110995"},
        {"Smithsonian Astrophysical Observation", "SAO 100243"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.48050191),
        dec: Angle.Degrees(+13.58310618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61195",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61195"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.08723729),
        dec: Angle.Degrees(+13.58383791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -275.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27579"},
        {"Hipparcos Number", "HIP 20371"},
        {"Geneva Identification System", "GEN# +1.00027579"},
        {"Smithsonian Astrophysical Observation", "SAO 93889"},
        {"Wilson Evans Batten Catalogue", "WEB 3894"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.43893524),
        dec: Angle.Degrees(+13.58493349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102209",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102209"},
        {"Smithsonian Astrophysical Observation", "SAO 106411"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.64628448),
        dec: Angle.Degrees(+13.58615412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128096"},
        {"Hipparcos Number", "HIP 71279"},
        {"Smithsonian Astrophysical Observation", "SAO 101086"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.66201318),
        dec: Angle.Degrees(+13.58632964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57777",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57777"},
        {"Smithsonian Astrophysical Observation", "SAO 99825"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.72233085),
        dec: Angle.Degrees(+13.58739035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161697"},
        {"Hipparcos Number", "HIP 86980"},
        {"Smithsonian Astrophysical Observation", "SAO 103092"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.62388760),
        dec: Angle.Degrees(+13.58832983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151627"},
        {"Hipparcos Number", "HIP 82241"},
        {"Geneva Identification System", "GEN# +1.00151627"},
        {"Smithsonian Astrophysical Observation", "SAO 102393"},
        {"Wilson Evans Batten Catalogue", "WEB 13884"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.03697840),
        dec: Angle.Degrees(+13.59033775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37870"},
        {"Hipparcos Number", "HIP 26861"},
        {"Smithsonian Astrophysical Observation", "SAO 94783"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.54406848),
        dec: Angle.Degrees(+13.59186779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100429",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13755 AB"},
        {"Henry Draper", "HD 193819"},
        {"Hipparcos Number", "HIP 100429"},
        {"Geneva Identification System", "GEN# +1.00193819J"},
        {"Smithsonian Astrophysical Observation", "SAO 106024"},
        {"Wilson Evans Batten Catalogue", "WEB 18131"},
    },
    visualMagnitude: 7.49,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.48287895),
        dec: Angle.Degrees(+13.59254471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11884",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11884"},
        {"Smithsonian Astrophysical Observation", "SAO 92999"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.31707634),
        dec: Angle.Degrees(+13.59461589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 854",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 854"},
        {"Smithsonian Astrophysical Observation", "SAO 91754"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.61845161),
        dec: Angle.Degrees(+13.59498069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87300"},
        {"Hipparcos Number", "HIP 49348"},
        {"Smithsonian Astrophysical Observation", "SAO 98932"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.10998064),
        dec: Angle.Degrees(+13.59512497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129290"},
        {"Hipparcos Number", "HIP 71819"},
        {"Geneva Identification System", "GEN# +1.00129290A"},
        {"Smithsonian Astrophysical Observation", "SAO 101149"},
        {"Wilson Evans Batten Catalogue", "WEB 12371"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.37086455),
        dec: Angle.Degrees(+13.60165467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -387.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18495"},
        {"Hipparcos Number", "HIP 13878"},
        {"Geneva Identification System", "GEN# +1.00018495"},
        {"Smithsonian Astrophysical Observation", "SAO 93216"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.69002533),
        dec: Angle.Degrees(+13.60463823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154228"},
        {"Hipparcos Number", "HIP 83478"},
        {"Geneva Identification System", "GEN# +1.00154228"},
        {"Renson", "Renson 43600"},
        {"Smithsonian Astrophysical Observation", "SAO 102564"},
        {"Wilson Evans Batten Catalogue", "WEB 14110"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.91381185),
        dec: Angle.Degrees(+13.60542885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16991",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16991"},
        {"Smithsonian Astrophysical Observation", "SAO 93529"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.63335865),
        dec: Angle.Degrees(+13.60616716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11861"},
        {"Hipparcos Number", "HIP 9074"},
        {"Geneva Identification System", "GEN# +1.00011861"},
        {"Smithsonian Astrophysical Observation", "SAO 92714"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.20312844),
        dec: Angle.Degrees(+13.60628621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48855",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48855"},
        {"Smithsonian Astrophysical Observation", "SAO 98871"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.46928949),
        dec: Angle.Degrees(+13.60721430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211647"},
        {"Hipparcos Number", "HIP 110112"},
        {"Smithsonian Astrophysical Observation", "SAO 107813"},
        {"Wilson Evans Batten Catalogue", "WEB 19765"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.57597723),
        dec: Angle.Degrees(+13.60805483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57150",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57150"},
        {"Smithsonian Astrophysical Observation", "SAO 99751"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.80946879),
        dec: Angle.Degrees(+13.60831546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85451",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85451"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.93421282),
        dec: Angle.Degrees(+13.61095336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81958",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10186 AB"},
        {"Henry Draper", "HD 151072"},
        {"Hipparcos Number", "HIP 81958"},
        {"Smithsonian Astrophysical Observation", "SAO 102355"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.14124953),
        dec: Angle.Degrees(+13.61110541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113398",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16403 AB"},
        {"Henry Draper", "HD 217075"},
        {"Hipparcos Number", "HIP 113398"},
        {"Smithsonian Astrophysical Observation", "SAO 108292"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.48439972),
        dec: Angle.Degrees(+13.61154254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148621"},
        {"Hipparcos Number", "HIP 80713"},
        {"Geneva Identification System", "GEN# +1.00148621"},
        {"Smithsonian Astrophysical Observation", "SAO 102196"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.19000957),
        dec: Angle.Degrees(+13.61248202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102617",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102617"},
        {"Smithsonian Astrophysical Observation", "SAO 106496"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.91781446),
        dec: Angle.Degrees(+13.61250817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 355915"},
        {"Hipparcos Number", "HIP 97458"},
        {"Smithsonian Astrophysical Observation", "SAO 105279"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.13675586),
        dec: Angle.Degrees(+13.61398760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91611"},
        {"Hipparcos Number", "HIP 51792"},
        {"Smithsonian Astrophysical Observation", "SAO 99188"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.73568792),
        dec: Angle.Degrees(+13.61458738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9180",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9180"},
    },
    visualMagnitude: 11.96,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.53764256),
        dec: Angle.Degrees(+13.61459003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -165.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 258394"},
        {"Henry Draper 2", "HD 258397"},
        {"Hipparcos Number", "HIP 30965"},
        {"Fundamental Katalog 5th Edition", "FK5 4591"},
        {"Smithsonian Astrophysical Observation", "SAO 95749"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.49324395),
        dec: Angle.Degrees(+13.61526703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103544"},
        {"Hipparcos Number", "HIP 58140"},
        {"Geneva Identification System", "GEN# +1.00103544"},
        {"Smithsonian Astrophysical Observation", "SAO 99867"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.86343885),
        dec: Angle.Degrees(+13.61726430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 265134"},
        {"Hipparcos Number", "HIP 32925"},
        {"Smithsonian Astrophysical Observation", "SAO 96198"},
        {"Wilson Evans Batten Catalogue", "WEB 6630"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.89136946),
        dec: Angle.Degrees(+13.61726510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48825",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48825"},
        {"Smithsonian Astrophysical Observation", "SAO 98864"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.40022838),
        dec: Angle.Degrees(+13.61784194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102210"},
        {"Hipparcos Number", "HIP 57379"},
        {"Smithsonian Astrophysical Observation", "SAO 99779"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.45984091),
        dec: Angle.Degrees(+13.61890022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183990"},
        {"Hipparcos Number", "HIP 96045"},
        {"Smithsonian Astrophysical Observation", "SAO 104938"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.92961304),
        dec: Angle.Degrees(+13.61929307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152830"},
        {"Hipparcos Number", "HIP 82798"},
        {"Geneva Identification System", "GEN# +1.00152830"},
        {"Smithsonian Astrophysical Observation", "SAO 102474"},
        {"Wilson Evans Batten Catalogue", "WEB 13997"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.81653725),
        dec: Angle.Degrees(+13.61999289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15975",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15975"},
        {"Smithsonian Astrophysical Observation", "SAO 93430"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.42436833),
        dec: Angle.Degrees(+13.62134106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126646"},
        {"Hipparcos Number", "HIP 70601"},
        {"Smithsonian Astrophysical Observation", "SAO 101024"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.61375287),
        dec: Angle.Degrees(+13.62207766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107811"},
        {"Hipparcos Number", "HIP 60419"},
        {"Geneva Identification System", "GEN# +1.00107811A"},
        {"Smithsonian Astrophysical Observation", "SAO 100071"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.81613440),
        dec: Angle.Degrees(+13.62217156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93203",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11902 A"},
        {"Henry Draper", "HD 176303"},
        {"Hipparcos Number", "HIP 93203"},
        {"Geneva Identification System", "GEN# +1.00176303"},
        {"Smithsonian Astrophysical Observation", "SAO 104308"},
        {"Wilson Evans Batten Catalogue", "WEB 16157"},
    },
    visualMagnitude: 5.27,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.77387015),
        dec: Angle.Degrees(+13.62254853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 257145"},
        {"Hipparcos Number", "HIP 30620"},
        {"Smithsonian Astrophysical Observation", "SAO 95678"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.52391564),
        dec: Angle.Degrees(+13.62283205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74328"},
        {"Hipparcos Number", "HIP 42848"},
        {"Geneva Identification System", "GEN# +1.00074328"},
        {"Smithsonian Astrophysical Observation", "SAO 98076"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.772,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.97052478),
        dec: Angle.Degrees(+13.62396964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70338"},
        {"Hipparcos Number", "HIP 40986"},
        {"Geneva Identification System", "GEN# +1.00070338"},
        {"Smithsonian Astrophysical Observation", "SAO 97761"},
        {"Wilson Evans Batten Catalogue", "WEB 7945"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.47196324),
        dec: Angle.Degrees(+13.62414104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90445"},
        {"Hipparcos Number", "HIP 51133"},
        {"Smithsonian Astrophysical Observation", "SAO 99123"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.68849117),
        dec: Angle.Degrees(+13.62646610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157199"},
        {"Hipparcos Number", "HIP 84927"},
        {"Geneva Identification System", "GEN# +1.00157199"},
        {"Smithsonian Astrophysical Observation", "SAO 102765"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.33728210),
        dec: Angle.Degrees(+13.63040818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31374"},
        {"Hipparcos Number", "HIP 22914"},
        {"Celescope Catalog", "CEL 490"},
        {"Geneva Identification System", "GEN# +1.00031374"},
        {"Smithsonian Astrophysical Observation", "SAO 94213"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.96734553),
        dec: Angle.Degrees(+13.63092599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11259",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11259"},
        {"Smithsonian Astrophysical Observation", "SAO 92933"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.23301693),
        dec: Angle.Degrees(+13.63745291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122695"},
        {"Hipparcos Number", "HIP 68651"},
        {"Smithsonian Astrophysical Observation", "SAO 100831"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.78806725),
        dec: Angle.Degrees(+13.63802915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67337",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67337"},
        {"Geneva Identification System", "GEN# +0.01402663"},
        {"Smithsonian Astrophysical Observation", "SAO 100715"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.02057418),
        dec: Angle.Degrees(+13.63845711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42477"},
        {"Hipparcos Number", "HIP 29371"},
        {"Celescope Catalog", "CEL 1109"},
        {"Geneva Identification System", "GEN# +1.00042477"},
        {"Renson", "Renson 11310"},
        {"Smithsonian Astrophysical Observation", "SAO 95352"},
        {"Wilson Evans Batten Catalogue", "WEB 5770"},
    },
    visualMagnitude: 6.04,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.86630447),
        dec: Angle.Degrees(+13.63860428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133668"},
        {"Hipparcos Number", "HIP 73836"},
        {"Smithsonian Astrophysical Observation", "SAO 101365"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.34424486),
        dec: Angle.Degrees(+13.63909374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69552"},
        {"Hipparcos Number", "HIP 40657"},
        {"Geneva Identification System", "GEN# +1.00069552"},
        {"Smithsonian Astrophysical Observation", "SAO 97714"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.49683651),
        dec: Angle.Degrees(+13.63989995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34415"},
        {"Hipparcos Number", "HIP 24693"},
        {"Geneva Identification System", "GEN# +1.00034415"},
        {"Smithsonian Astrophysical Observation", "SAO 94447"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.44202064),
        dec: Angle.Degrees(+13.63991293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67483"},
        {"Hipparcos Number", "HIP 39874"},
        {"Geneva Identification System", "GEN# +1.00067483"},
        {"Smithsonian Astrophysical Observation", "SAO 97594"},
        {"Wilson Evans Batten Catalogue", "WEB 7772"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.17684992),
        dec: Angle.Degrees(+13.64094892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167195"},
        {"Hipparcos Number", "HIP 89323"},
        {"Geneva Identification System", "GEN# +1.00167195"},
        {"Smithsonian Astrophysical Observation", "SAO 103499"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.39325016),
        dec: Angle.Degrees(+13.64279422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58594",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58594"},
        {"Geneva Identification System", "GEN# +0.01402463"},
        {"Smithsonian Astrophysical Observation", "SAO 99907"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.23399392),
        dec: Angle.Degrees(+13.64396459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100892",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100892"},
        {"Smithsonian Astrophysical Observation", "SAO 106122"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.85833661),
        dec: Angle.Degrees(+13.64411027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7653",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7653"},
        {"Smithsonian Astrophysical Observation", "SAO 92549"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.63970503),
        dec: Angle.Degrees(+13.64683658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 164.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133487"},
        {"Hipparcos Number", "HIP 73736"},
        {"Smithsonian Astrophysical Observation", "SAO 101362"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.08369977),
        dec: Angle.Degrees(+13.64726510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192644"},
        {"Henry Draper 2", "HD 192645"},
        {"Hipparcos Number", "HIP 99847"},
        {"Geneva Identification System", "GEN# +1.00192644"},
        {"Smithsonian Astrophysical Observation", "SAO 105901"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.86697194),
        dec: Angle.Degrees(+13.64816071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108949",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15596 AB"},
        {"Henry Draper", "HD 209601"},
        {"Hipparcos Number", "HIP 108949"},
        {"Smithsonian Astrophysical Observation", "SAO 107633"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.09359014),
        dec: Angle.Degrees(+13.64823895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5038"},
        {"Hipparcos Number", "HIP 4089"},
        {"Smithsonian Astrophysical Observation", "SAO 92128"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.12024866),
        dec: Angle.Degrees(+13.64881626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45684",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45684"},
        {"Smithsonian Astrophysical Observation", "SAO 98486"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.70254645),
        dec: Angle.Degrees(+13.65271487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2411",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2411"},
        {"Smithsonian Astrophysical Observation", "SAO 91932"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.67889977),
        dec: Angle.Degrees(+13.65316566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54458"},
        {"Hipparcos Number", "HIP 34557"},
        {"Smithsonian Astrophysical Observation", "SAO 96570"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.38206119),
        dec: Angle.Degrees(+13.65368509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22607",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3483 AB"},
        {"Henry Draper", "HD 30869"},
        {"Hipparcos Number", "HIP 22607"},
        {"Celescope Catalog", "CEL 476"},
        {"Geneva Identification System", "GEN# +5.20250124"},
        {"Smithsonian Astrophysical Observation", "SAO 94171"},
        {"Wilson Evans Batten Catalogue", "WEB 4371"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.95801730),
        dec: Angle.Degrees(+13.65519410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61191",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61191"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.07617836),
        dec: Angle.Degrees(+13.65817671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42352"},
        {"Hipparcos Number", "HIP 29310"},
        {"Geneva Identification System", "GEN# +1.00042352"},
        {"Smithsonian Astrophysical Observation", "SAO 95335"},
        {"Wilson Evans Batten Catalogue", "WEB 5754"},
    },
    visualMagnitude: 6.93,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.69733686),
        dec: Angle.Degrees(+13.65947301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80045"},
        {"Hipparcos Number", "HIP 45609"},
        {"Smithsonian Astrophysical Observation", "SAO 98475"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.45255669),
        dec: Angle.Degrees(+13.65947571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60415",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60415"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.81030684),
        dec: Angle.Degrees(+13.66191203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151545"},
        {"Hipparcos Number", "HIP 82188"},
        {"Smithsonian Astrophysical Observation", "SAO 102386"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.85783383),
        dec: Angle.Degrees(+13.66388434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94056"},
        {"Hipparcos Number", "HIP 53075"},
        {"Smithsonian Astrophysical Observation", "SAO 99325"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.88319330),
        dec: Angle.Degrees(+13.66675456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131884"},
        {"Hipparcos Number", "HIP 73062"},
        {"Smithsonian Astrophysical Observation", "SAO 101288"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.96199627),
        dec: Angle.Degrees(+13.66699749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76985",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9758 AB"},
        {"Henry Draper", "HD 140438"},
        {"Hipparcos Number", "HIP 76985"},
        {"Geneva Identification System", "GEN# +1.00140438J"},
        {"Smithsonian Astrophysical Observation", "SAO 101699"},
        {"Wilson Evans Batten Catalogue", "WEB 13058"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.79392869),
        dec: Angle.Degrees(+13.66775370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16188"},
        {"Hipparcos Number", "HIP 12137"},
        {"Geneva Identification System", "GEN# +1.00016188"},
        {"Smithsonian Astrophysical Observation", "SAO 93020"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.08182334),
        dec: Angle.Degrees(+13.66851809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62259"},
        {"Hipparcos Number", "HIP 37665"},
        {"Smithsonian Astrophysical Observation", "SAO 97189"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.92725445),
        dec: Angle.Degrees(+13.66895363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39412",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6543 AB"},
        {"Henry Draper", "HD 66301"},
        {"Hipparcos Number", "HIP 39412"},
        {"Smithsonian Astrophysical Observation", "SAO 97513"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.85239793),
        dec: Angle.Degrees(+13.66921159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10921"},
        {"Geneva Identification System", "GEN# +0.01300374"},
        {"Smithsonian Astrophysical Observation", "SAO 92893"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.16319574),
        dec: Angle.Degrees(+13.67023173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 257.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210312"},
        {"Hipparcos Number", "HIP 109355"},
        {"Geneva Identification System", "GEN# +1.00210312"},
        {"Smithsonian Astrophysical Observation", "SAO 107694"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.31501631),
        dec: Angle.Degrees(+13.67107417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51169"},
        {"Hipparcos Number", "HIP 33402"},
        {"Smithsonian Astrophysical Observation", "SAO 96299"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.21138986),
        dec: Angle.Degrees(+13.67180238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115478"},
        {"Hipparcos Number", "HIP 64823"},
        {"Geneva Identification System", "GEN# +1.00115478"},
        {"Smithsonian Astrophysical Observation", "SAO 100497"},
        {"Wilson Evans Batten Catalogue", "WEB 11458"},
    },
    visualMagnitude: 5.33,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.31509739),
        dec: Angle.Degrees(+13.67564684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107011",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107011"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.09693184),
        dec: Angle.Degrees(+13.67689914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 191.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35909"},
        {"Hipparcos Number", "HIP 25638"},
        {"Geneva Identification System", "GEN# +1.00035909"},
        {"Smithsonian Astrophysical Observation", "SAO 94580"},
        {"Wilson Evans Batten Catalogue", "WEB 4972"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.14486508),
        dec: Angle.Degrees(+13.67901580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177350"},
        {"Hipparcos Number", "HIP 93608"},
        {"Smithsonian Astrophysical Observation", "SAO 104421"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.93878083),
        dec: Angle.Degrees(+13.68103635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163531"},
        {"Hipparcos Number", "HIP 87792"},
        {"Smithsonian Astrophysical Observation", "SAO 103222"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.01001396),
        dec: Angle.Degrees(+13.68253366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17031",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17031"},
        {"Smithsonian Astrophysical Observation", "SAO 93530"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.76788281),
        dec: Angle.Degrees(+13.68296023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13357"},
        {"Hipparcos Number", "HIP 10175"},
        {"Geneva Identification System", "GEN# +1.00013357J"},
        {"Wilson Evans Batten Catalogue", "WEB 2125"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.71671610),
        dec: Angle.Degrees(+13.68345373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205954"},
        {"Hipparcos Number", "HIP 106850"},
        {"Smithsonian Astrophysical Observation", "SAO 107293"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.62415950),
        dec: Angle.Degrees(+13.68417626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47451"},
        {"Hipparcos Number", "HIP 31828"},
        {"Smithsonian Astrophysical Observation", "SAO 95951"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.82071303),
        dec: Angle.Degrees(+13.68620275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150012"},
        {"Hipparcos Number", "HIP 81425"},
        {"Fundamental Katalog 5th Edition", "FK5 3316"},
        {"Geneva Identification System", "GEN# +1.00150012"},
        {"Smithsonian Astrophysical Observation", "SAO 102278"},
        {"Wilson Evans Batten Catalogue", "WEB 13760"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.45012563),
        dec: Angle.Degrees(+13.68718619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66444"},
        {"Hipparcos Number", "HIP 39477"},
        {"Smithsonian Astrophysical Observation", "SAO 97526"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.02512612),
        dec: Angle.Degrees(+13.68739669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62716",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62716"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.78913463),
        dec: Angle.Degrees(+13.68769192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105882",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14977 AB"},
        {"Henry Draper", "HD 204215"},
        {"Hipparcos Number", "HIP 105882"},
        {"Smithsonian Astrophysical Observation", "SAO 107139"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.67140008),
        dec: Angle.Degrees(+13.68829078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102283"},
        {"Hipparcos Number", "HIP 57442"},
        {"Smithsonian Astrophysical Observation", "SAO 99785"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.63137577),
        dec: Angle.Degrees(+13.68893437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30634"},
        {"Hipparcos Number", "HIP 22455"},
        {"Smithsonian Astrophysical Observation", "SAO 94153"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.47889451),
        dec: Angle.Degrees(+13.68914691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68570",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68570"},
        {"Wilson Evans Batten Catalogue", "WEB 12008"},
    },
    visualMagnitude: 10.68,
    bvColour: 1.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.58152170),
        dec: Angle.Degrees(+13.68997829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287257"},
        {"Hipparcos Number", "HIP 23162"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.74954253),
        dec: Angle.Degrees(+13.69083251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91294",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91294"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.32256228),
        dec: Angle.Degrees(+13.69161902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131113"},
        {"Hipparcos Number", "HIP 72656"},
        {"Geneva Identification System", "GEN# +1.00131113"},
        {"Smithsonian Astrophysical Observation", "SAO 101248"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.84277817),
        dec: Angle.Degrees(+13.69283510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95593"},
        {"Hipparcos Number", "HIP 53929"},
        {"Smithsonian Astrophysical Observation", "SAO 99410"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.52819774),
        dec: Angle.Degrees(+13.69287879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31531",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5231 AB"},
        {"Henry Draper", "HD 46825"},
        {"Hipparcos Number", "HIP 31531"},
        {"Renson", "Renson 12570"},
        {"Smithsonian Astrophysical Observation", "SAO 95892"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.01831992),
        dec: Angle.Degrees(+13.69405469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 249313"},
        {"Hipparcos Number", "HIP 28045"},
        {"Wilson Evans Batten Catalogue", "WEB 5492"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.96221083),
        dec: Angle.Degrees(+13.69499901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55442",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55442"},
        {"Smithsonian Astrophysical Observation", "SAO 99572"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.31448705),
        dec: Angle.Degrees(+13.69518931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5612"},
        {"Hipparcos Number", "HIP 4520"},
        {"Geneva Identification System", "GEN# +1.00005612"},
        {"Smithsonian Astrophysical Observation", "SAO 92183"},
        {"Wilson Evans Batten Catalogue", "WEB 818"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.47714727),
        dec: Angle.Degrees(+13.69587909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79832",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79832"},
        {"Smithsonian Astrophysical Observation", "SAO 102065"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.43039203),
        dec: Angle.Degrees(+13.69845239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231370"},
        {"Hipparcos Number", "HIP 95496"},
        {"Smithsonian Astrophysical Observation", "SAO 104815"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.36645058),
        dec: Angle.Degrees(+13.70112042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51720"},
        {"Hipparcos Number", "HIP 33623"},
        {"Smithsonian Astrophysical Observation", "SAO 96345"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.78160738),
        dec: Angle.Degrees(+13.70291934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76715",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76715"},
    },
    visualMagnitude: 10.89,
    bvColour: 0.842,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.98531217),
        dec: Angle.Degrees(+13.70322270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -153.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169533"},
        {"Hipparcos Number", "HIP 90221"},
        {"Geneva Identification System", "GEN# +1.00169533"},
        {"Smithsonian Astrophysical Observation", "SAO 103682"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.13111118),
        dec: Angle.Degrees(+13.70659630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40114"},
        {"Hipparcos Number", "HIP 28202"},
        {"Smithsonian Astrophysical Observation", "SAO 95047"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.39104282),
        dec: Angle.Degrees(+13.70796208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38289"},
        {"Hipparcos Number", "HIP 27146"},
        {"Geneva Identification System", "GEN# +1.00038289"},
        {"Smithsonian Astrophysical Observation", "SAO 94834"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.32136985),
        dec: Angle.Degrees(+13.70846647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53418"},
        {"Hipparcos Number", "HIP 34210"},
        {"Smithsonian Astrophysical Observation", "SAO 96475"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.39678799),
        dec: Angle.Degrees(+13.70978002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17639"},
        {"Hipparcos Number", "HIP 13223"},
        {"Fundamental Katalog 5th Edition", "FK5 4260"},
        {"Geneva Identification System", "GEN# +1.00017639"},
        {"Smithsonian Astrophysical Observation", "SAO 93133"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.55394205),
        dec: Angle.Degrees(+13.71048916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94362"},
        {"Hipparcos Number", "HIP 53265"},
        {"Wilson Evans Batten Catalogue", "WEB 9673"},
    },
    visualMagnitude: 11.06,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.40599863),
        dec: Angle.Degrees(+13.71511710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79417",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79417"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.11824513),
        dec: Angle.Degrees(+13.71522354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207979"},
        {"Hipparcos Number", "HIP 108001"},
        {"Smithsonian Astrophysical Observation", "SAO 107462"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.20695321),
        dec: Angle.Degrees(+13.71642043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102574",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102574"},
        {"Smithsonian Astrophysical Observation", "SAO 106487"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.80280939),
        dec: Angle.Degrees(+13.71688073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207165"},
        {"Hipparcos Number", "HIP 107531"},
        {"Smithsonian Astrophysical Observation", "SAO 107392"},
        {"Wilson Evans Batten Catalogue", "WEB 19409"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.69261157),
        dec: Angle.Degrees(+13.71960563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27296"},
        {"Hipparcos Number", "HIP 20150"},
        {"Celescope Catalog", "CEL 384"},
        {"Geneva Identification System", "GEN# +1.00027296"},
        {"Smithsonian Astrophysical Observation", "SAO 93861"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.78766788),
        dec: Angle.Degrees(+13.72063482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141024"},
        {"Hipparcos Number", "HIP 77244"},
        {"Geneva Identification System", "GEN# +1.00141024"},
        {"Smithsonian Astrophysical Observation", "SAO 101728"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.59399773),
        dec: Angle.Degrees(+13.72075878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160980"},
        {"Hipparcos Number", "HIP 86663"},
        {"Smithsonian Astrophysical Observation", "SAO 103039"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.60864137),
        dec: Angle.Degrees(+13.72116427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199253"},
        {"Hipparcos Number", "HIP 103294"},
        {"Fundamental Katalog 5th Edition", "FK5 3669"},
        {"Geneva Identification System", "GEN# +1.00199253"},
        {"Smithsonian Astrophysical Observation", "SAO 106665"},
        {"Wilson Evans Batten Catalogue", "WEB 18772"},
    },
    visualMagnitude: 5.19,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.90282903),
        dec: Angle.Degrees(+13.72156383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219312"},
        {"Hipparcos Number", "HIP 114751"},
        {"Geneva Identification System", "GEN# +1.00219312"},
        {"Smithsonian Astrophysical Observation", "SAO 108485"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.67137421),
        dec: Angle.Degrees(+13.72158009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213341"},
        {"Hipparcos Number", "HIP 111110"},
        {"Smithsonian Astrophysical Observation", "SAO 107961"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.63386875),
        dec: Angle.Degrees(+13.72384717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
