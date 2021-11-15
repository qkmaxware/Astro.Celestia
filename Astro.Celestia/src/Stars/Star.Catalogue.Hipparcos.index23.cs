using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_23() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61964"},
        {"Hipparcos Number", "HIP 37330"},
        {"Geneva Identification System", "GEN# +1.00061964"},
        {"Renson", "Renson 17000"},
        {"Smithsonian Astrophysical Observation", "SAO 218878"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.95033300),
        dec: Angle.Degrees(-43.87237753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112778"},
        {"Hipparcos Number", "HIP 63412"},
        {"Smithsonian Astrophysical Observation", "SAO 223818"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.90654161),
        dec: Angle.Degrees(-43.87166056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105750"},
        {"Hipparcos Number", "HIP 59341"},
        {"Geneva Identification System", "GEN# +1.00105750"},
        {"Smithsonian Astrophysical Observation", "SAO 223258"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.59264341),
        dec: Angle.Degrees(-43.87091526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93198"},
        {"Hipparcos Number", "HIP 52572"},
        {"Geneva Identification System", "GEN# +1.00093198"},
        {"Smithsonian Astrophysical Observation", "SAO 222292"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.25275848),
        dec: Angle.Degrees(-43.86635682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86489",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86489"},
    },
    visualMagnitude: 10.66,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.11143312),
        dec: Angle.Degrees(-43.86582145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89838"},
        {"Hipparcos Number", "HIP 50690"},
        {"Smithsonian Astrophysical Observation", "SAO 221979"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.27574686),
        dec: Angle.Degrees(-43.86544881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137993"},
        {"Hipparcos Number", "HIP 75967"},
        {"Geneva Identification System", "GEN# +1.00137993"},
        {"Smithsonian Astrophysical Observation", "SAO 225854"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.71632748),
        dec: Angle.Degrees(-43.86533929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -178.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177059"},
        {"Hipparcos Number", "HIP 93729"},
        {"Smithsonian Astrophysical Observation", "SAO 229478"},
    },
    visualMagnitude: 8.44,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.27190966),
        dec: Angle.Degrees(-43.86486050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54645"},
        {"Hipparcos Number", "HIP 34373"},
        {"Smithsonian Astrophysical Observation", "SAO 218471"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.88649257),
        dec: Angle.Degrees(-43.86479953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126997"},
        {"Hipparcos Number", "HIP 70918"},
        {"Geneva Identification System", "GEN# +1.00126997"},
        {"Smithsonian Astrophysical Observation", "SAO 224970"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.54163574),
        dec: Angle.Degrees(-43.86382678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205047"},
        {"Hipparcos Number", "HIP 106482"},
        {"Smithsonian Astrophysical Observation", "SAO 230740"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.50070195),
        dec: Angle.Degrees(-43.86345518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 177.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160150"},
        {"Hipparcos Number", "HIP 86490"},
        {"Smithsonian Astrophysical Observation", "SAO 228260"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.11377480),
        dec: Angle.Degrees(-43.86184996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42492",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42492"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.94066946),
        dec: Angle.Degrees(-43.86089234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46914"},
        {"Hipparcos Number", "HIP 31295"},
        {"Smithsonian Astrophysical Observation", "SAO 218024"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.44103162),
        dec: Angle.Degrees(-43.85931978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220592"},
        {"Hipparcos Number", "HIP 115616"},
        {"Smithsonian Astrophysical Observation", "SAO 231600"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.31443919),
        dec: Angle.Degrees(-43.85760578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 326591"},
        {"Hipparcos Number", "HIP 83169"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.95939888),
        dec: Angle.Degrees(-43.85727219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21626"},
        {"Hipparcos Number", "HIP 16128"},
        {"Geneva Identification System", "GEN# +1.00021626"},
        {"Smithsonian Astrophysical Observation", "SAO 216332"},
        {"Wilson Evans Batten Catalogue", "WEB 3074"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.93229029),
        dec: Angle.Degrees(-43.85595489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1320"},
        {"Hipparcos Number", "HIP 1382"},
        {"Cincinnati Publication", "Ci 20 18"},
        {"Geneva Identification System", "GEN# +1.00001320"},
        {"Smithsonian Astrophysical Observation", "SAO 215036"},
        {"Wilson Evans Batten Catalogue", "WEB 249"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.31752626),
        dec: Angle.Degrees(-43.85269422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 397.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22"},
        {"Hipparcos Number", "HIP 427"},
        {"Smithsonian Astrophysical Observation", "SAO 214956"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.29143885),
        dec: Angle.Degrees(-43.85083352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11880"},
        {"Hipparcos Number", "HIP 8975"},
        {"Smithsonian Astrophysical Observation", "SAO 215701"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.92254306),
        dec: Angle.Degrees(-43.85080843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2180"},
        {"Hipparcos Number", "HIP 2026"},
        {"Smithsonian Astrophysical Observation", "SAO 215088"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.42539372),
        dec: Angle.Degrees(-43.84984816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70970",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70970"},
    },
    visualMagnitude: 11.78,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.75262295),
        dec: Angle.Degrees(-43.84982593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127153"},
        {"Hipparcos Number", "HIP 70976"},
        {"Smithsonian Astrophysical Observation", "SAO 224983"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.75643256),
        dec: Angle.Degrees(-43.84817049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205430"},
        {"Hipparcos Number", "HIP 106685"},
        {"Geneva Identification System", "GEN# +1.00205430"},
        {"Smithsonian Astrophysical Observation", "SAO 230750"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.13491539),
        dec: Angle.Degrees(-43.84752851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 326712"},
        {"Hipparcos Number", "HIP 83417"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.75365476),
        dec: Angle.Degrees(-43.84693641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9403"},
        {"Hipparcos Number", "HIP 7104"},
        {"Geneva Identification System", "GEN# +1.00009403"},
        {"Smithsonian Astrophysical Observation", "SAO 215538"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.88574548),
        dec: Angle.Degrees(-43.84654868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169943"},
        {"Hipparcos Number", "HIP 90597"},
        {"Geneva Identification System", "GEN# +1.00169943"},
        {"Smithsonian Astrophysical Observation", "SAO 229056"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.30363419),
        dec: Angle.Degrees(-43.84599218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170386"},
        {"Hipparcos Number", "HIP 90782"},
        {"Smithsonian Astrophysical Observation", "SAO 229085"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.81875597),
        dec: Angle.Degrees(-43.84553342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65211"},
        {"Hipparcos Number", "HIP 38732"},
        {"Celescope Catalog", "CEL 2102"},
        {"Geneva Identification System", "GEN# +1.00065211J"},
        {"Smithsonian Astrophysical Observation", "SAO 219157"},
        {"Wilson Evans Batten Catalogue", "WEB 7594"},
    },
    visualMagnitude: 6.02,
    bvColour: -0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.94414755),
        dec: Angle.Degrees(-43.84505768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77958"},
        {"Hipparcos Number", "HIP 44508"},
        {"Smithsonian Astrophysical Observation", "SAO 220800"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.01178001),
        dec: Angle.Degrees(-43.84362710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210441"},
        {"Hipparcos Number", "HIP 109550"},
        {"Fundamental Katalog 5th Edition", "FK5 5959"},
        {"Geneva Identification System", "GEN# +1.00210441"},
        {"Smithsonian Astrophysical Observation", "SAO 231019"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.86307475),
        dec: Angle.Degrees(-43.84256860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214791"},
        {"Hipparcos Number", "HIP 112009"},
        {"Geneva Identification System", "GEN# +1.00214791"},
        {"Smithsonian Astrophysical Observation", "SAO 231251"},
        {"Wilson Evans Batten Catalogue", "WEB 19996"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.32778583),
        dec: Angle.Degrees(-43.84119604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87334"},
        {"Hipparcos Number", "HIP 49255"},
        {"Geneva Identification System", "GEN# +1.00087334"},
        {"Smithsonian Astrophysical Observation", "SAO 221727"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.82241462),
        dec: Angle.Degrees(-43.84023350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164778"},
        {"Hipparcos Number", "HIP 88549"},
        {"Smithsonian Astrophysical Observation", "SAO 228677"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.20787609),
        dec: Angle.Degrees(-43.84022209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121262"},
        {"Hipparcos Number", "HIP 67992"},
        {"Smithsonian Astrophysical Observation", "SAO 224537"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.85613862),
        dec: Angle.Degrees(-43.83891437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138675"},
        {"Hipparcos Number", "HIP 76301"},
        {"Geneva Identification System", "GEN# +1.00138675"},
        {"Smithsonian Astrophysical Observation", "SAO 225936"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.79677450),
        dec: Angle.Degrees(-43.83891327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 327459"},
        {"Hipparcos Number", "HIP 77705"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.98149214),
        dec: Angle.Degrees(-43.83864328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90898"},
        {"Hipparcos Number", "HIP 51294"},
        {"Geneva Identification System", "GEN# +1.00090898"},
        {"Smithsonian Astrophysical Observation", "SAO 222084"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.17681330),
        dec: Angle.Degrees(-43.83839851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 326915"},
        {"Hipparcos Number", "HIP 83723"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.67045162),
        dec: Angle.Degrees(-43.83800142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154424"},
        {"Hipparcos Number", "HIP 83783"},
        {"Smithsonian Astrophysical Observation", "SAO 227640"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.85638784),
        dec: Angle.Degrees(-43.83697474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168787"},
        {"Hipparcos Number", "HIP 90137"},
        {"Smithsonian Astrophysical Observation", "SAO 228972"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.92118277),
        dec: Angle.Degrees(-43.83584773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170149"},
        {"Hipparcos Number", "HIP 90674"},
        {"Geneva Identification System", "GEN# +1.00170149"},
        {"Smithsonian Astrophysical Observation", "SAO 229069"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.51822263),
        dec: Angle.Degrees(-43.83358384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22037"},
        {"Hipparcos Number", "HIP 16415"},
        {"Smithsonian Astrophysical Observation", "SAO 216363"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.84650179),
        dec: Angle.Degrees(-43.83357878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112885",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112885"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.89986198),
        dec: Angle.Degrees(-43.83249171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116219",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116219"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.21753519),
        dec: Angle.Degrees(-43.83231167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1054"},
        {"Hipparcos Number", "HIP 1172"},
        {"Smithsonian Astrophysical Observation", "SAO 215017"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.66182194),
        dec: Angle.Degrees(-43.83114827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12439"},
        {"Hipparcos Number", "HIP 9408"},
        {"Smithsonian Astrophysical Observation", "SAO 215737"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.22048270),
        dec: Angle.Degrees(-43.83093626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114752"},
        {"Hipparcos Number", "HIP 64503"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.31096215),
        dec: Angle.Degrees(-43.82987385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144478"},
        {"Hipparcos Number", "HIP 79042"},
        {"Geneva Identification System", "GEN# +1.00144478"},
        {"Smithsonian Astrophysical Observation", "SAO 226524"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.01625100),
        dec: Angle.Degrees(-43.82882621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57581"},
        {"Hipparcos Number", "HIP 35508"},
        {"Smithsonian Astrophysical Observation", "SAO 218642"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.94196315),
        dec: Angle.Degrees(-43.82716551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88454"},
        {"Hipparcos Number", "HIP 49873"},
        {"Smithsonian Astrophysical Observation", "SAO 221838"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.75692842),
        dec: Angle.Degrees(-43.82535133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73366"},
        {"Hipparcos Number", "HIP 42199"},
        {"Smithsonian Astrophysical Observation", "SAO 220169"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.07158947),
        dec: Angle.Degrees(-43.82504273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47923"},
        {"Hipparcos Number", "HIP 31788"},
        {"Celescope Catalog", "CEL 1343"},
        {"Geneva Identification System", "GEN# +1.00047923"},
        {"Smithsonian Astrophysical Observation", "SAO 218091"},
        {"Smithsonian Astrophysical Observation 2", "SAO 218092"},
    },
    visualMagnitude: 7.58,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.70034916),
        dec: Angle.Degrees(-43.82481348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143119"},
        {"Hipparcos Number", "HIP 78405"},
        {"Geneva Identification System", "GEN# +1.00143119"},
        {"Smithsonian Astrophysical Observation", "SAO 226435"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.09130128),
        dec: Angle.Degrees(-43.82274426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148762"},
        {"Hipparcos Number", "HIP 80982"},
        {"Smithsonian Astrophysical Observation", "SAO 226863"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.06487727),
        dec: Angle.Degrees(-43.82209012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99126",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99126"},
    },
    visualMagnitude: 13.15,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.86360439),
        dec: Angle.Degrees(-43.81936604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98177"},
        {"Hipparcos Number", "HIP 55125"},
        {"Smithsonian Astrophysical Observation", "SAO 222693"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.29147408),
        dec: Angle.Degrees(-43.81873383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130930"},
        {"Hipparcos Number", "HIP 72742"},
        {"Geneva Identification System", "GEN# +1.00130930"},
        {"Smithsonian Astrophysical Observation", "SAO 225258"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.07420153),
        dec: Angle.Degrees(-43.81774314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -184.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178057"},
        {"Hipparcos Number", "HIP 94084"},
        {"Smithsonian Astrophysical Observation", "SAO 229521"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.29490901),
        dec: Angle.Degrees(-43.81701948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66253"},
        {"Hipparcos Number", "HIP 39182"},
        {"Smithsonian Astrophysical Observation", "SAO 219297"},
    },
    visualMagnitude: 8.31,
    bvColour: -0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.20340310),
        dec: Angle.Degrees(-43.81688958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21493"},
        {"Hipparcos Number", "HIP 16017"},
        {"Smithsonian Astrophysical Observation", "SAO 216318"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.55277415),
        dec: Angle.Degrees(-43.81667878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13423"},
        {"Hipparcos Number", "HIP 10111"},
        {"Geneva Identification System", "GEN# +1.00013423"},
        {"Smithsonian Astrophysical Observation", "SAO 215794"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.51987613),
        dec: Angle.Degrees(-43.81555677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97841"},
        {"Hipparcos Number", "HIP 54926"},
        {"Geneva Identification System", "GEN# +1.00097841"},
        {"Smithsonian Astrophysical Observation", "SAO 222669"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.71377875),
        dec: Angle.Degrees(-43.81249637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42463"},
        {"Hipparcos Number", "HIP 29136"},
        {"Smithsonian Astrophysical Observation", "SAO 217737"},
    },
    visualMagnitude: 7.49,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.19378633),
        dec: Angle.Degrees(-43.81224022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132301"},
        {"Hipparcos Number", "HIP 73383"},
        {"Geneva Identification System", "GEN# +1.00132301"},
        {"Smithsonian Astrophysical Observation", "SAO 225355"},
        {"Wilson Evans Batten Catalogue", "WEB 12565"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.93830658),
        dec: Angle.Degrees(-43.81102178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -194.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82152"},
        {"Hipparcos Number", "HIP 46484"},
        {"Geneva Identification System", "GEN# +1.00082152"},
        {"Smithsonian Astrophysical Observation", "SAO 221203"},
        {"Wilson Evans Batten Catalogue", "WEB 8776"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.20906228),
        dec: Angle.Degrees(-43.81066288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67557"},
        {"Hipparcos Number", "HIP 39694"},
        {"Geneva Identification System", "GEN# +1.00067557"},
        {"Smithsonian Astrophysical Observation", "SAO 219423"},
    },
    visualMagnitude: 8.43,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.68077293),
        dec: Angle.Degrees(-43.80883205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95347"},
        {"Hipparcos Number", "HIP 53762"},
        {"Geneva Identification System", "GEN# +1.00095347"},
        {"Smithsonian Astrophysical Observation", "SAO 222485"},
        {"Wilson Evans Batten Catalogue", "WEB 9738"},
    },
    visualMagnitude: 5.81,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.99762038),
        dec: Angle.Degrees(-43.80713489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13537"},
        {"Hipparcos Number", "HIP 10183"},
        {"Smithsonian Astrophysical Observation", "SAO 215803"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.72995819),
        dec: Angle.Degrees(-43.80702881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23906"},
        {"Hipparcos Number", "HIP 17660"},
        {"Smithsonian Astrophysical Observation", "SAO 216487"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.73782274),
        dec: Angle.Degrees(-43.80694888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157241"},
        {"Hipparcos Number", "HIP 85159"},
        {"Smithsonian Astrophysical Observation", "SAO 227910"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.04618487),
        dec: Angle.Degrees(-43.80496717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34829"},
        {"Hipparcos Number", "HIP 24715"},
        {"Geneva Identification System", "GEN# +1.00034829"},
        {"Smithsonian Astrophysical Observation", "SAO 217275"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.51603586),
        dec: Angle.Degrees(-43.80455132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207972"},
        {"Hipparcos Number", "HIP 108107"},
        {"Smithsonian Astrophysical Observation", "SAO 230892"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.55173777),
        dec: Angle.Degrees(-43.80263527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16698"},
        {"Hipparcos Number", "HIP 12373"},
        {"Smithsonian Astrophysical Observation", "SAO 215991"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.82094023),
        dec: Angle.Degrees(-43.80159061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49942"},
        {"Hipparcos Number", "HIP 32657"},
        {"Celescope Catalog", "CEL 1395"},
        {"Geneva Identification System", "GEN# +1.00049942"},
        {"Smithsonian Astrophysical Observation", "SAO 218218"},
    },
    visualMagnitude: 7.36,
    bvColour: -0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.17969656),
        dec: Angle.Degrees(-43.80151153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49850"},
        {"Hipparcos Number", "HIP 32615"},
        {"Geneva Identification System", "GEN# +1.00049850"},
        {"Smithsonian Astrophysical Observation", "SAO 218208"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.07587065),
        dec: Angle.Degrees(-43.80088693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201187"},
        {"Hipparcos Number", "HIP 104437"},
        {"Geneva Identification System", "GEN# +1.00201187"},
        {"Smithsonian Astrophysical Observation", "SAO 230550"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.33214198),
        dec: Angle.Degrees(-43.79987164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 326583"},
        {"Hipparcos Number", "HIP 83011"},
        {"Smithsonian Astrophysical Observation", "SAO 227496"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.44659862),
        dec: Angle.Degrees(-43.79920413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -246.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147985"},
        {"Hipparcos Number", "HIP 80563"},
        {"Geneva Identification System", "GEN# +1.00147985"},
        {"Smithsonian Astrophysical Observation", "SAO 226769"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.73642848),
        dec: Angle.Degrees(-43.79920268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85662"},
        {"Hipparcos Number", "HIP 48403"},
        {"Geneva Identification System", "GEN# +1.00085662"},
        {"Renson", "Renson 24440"},
        {"Smithsonian Astrophysical Observation", "SAO 221558"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.03053357),
        dec: Angle.Degrees(-43.79764946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16157"},
        {"Hipparcos Number", "HIP 11964"},
        {"Geneva Identification System", "GEN# +1.00016157"},
        {"Smithsonian Astrophysical Observation", "SAO 215947"},
        {"Wilson Evans Batten Catalogue", "WEB 2471"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.59383064),
        dec: Angle.Degrees(-43.79563863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -293.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72743",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72743"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.07627641),
        dec: Angle.Degrees(-43.79203447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84476",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84476"},
        {"Geneva Identification System", "GEN# -0.01004463"},
    },
    visualMagnitude: 10.48,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.04557912),
        dec: Angle.Degrees(-10.89414452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -258.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6768"},
        {"Hipparcos Number", "HIP 5292"},
        {"Geneva Identification System", "GEN# +1.00006768"},
        {"Smithsonian Astrophysical Observation", "SAO 215373"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.93102398),
        dec: Angle.Degrees(-43.79131292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208017"},
        {"Hipparcos Number", "HIP 108134"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.61247751),
        dec: Angle.Degrees(-43.79010940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173339"},
        {"Hipparcos Number", "HIP 92143"},
        {"Geneva Identification System", "GEN# +1.00173339"},
        {"Smithsonian Astrophysical Observation", "SAO 229271"},
        {"Wilson Evans Batten Catalogue", "WEB 15886"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.69834401),
        dec: Angle.Degrees(-43.78859147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52024"},
        {"Hipparcos Number", "HIP 33475"},
        {"Celescope Catalog", "CEL 1461"},
        {"Geneva Identification System", "GEN# +1.00052024"},
        {"Smithsonian Astrophysical Observation", "SAO 218336"},
    },
    visualMagnitude: 7.30,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.38074521),
        dec: Angle.Degrees(-43.78858285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91863"},
        {"Hipparcos Number", "HIP 51850"},
        {"Smithsonian Astrophysical Observation", "SAO 222176"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.89916217),
        dec: Angle.Degrees(-43.78701020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 326267"},
        {"Hipparcos Number", "HIP 82434"},
        {"Geneva Identification System", "GEN# +1.00326267"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.70412559),
        dec: Angle.Degrees(-43.78590696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -396.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1235"},
        {"Hipparcos Number", "HIP 1307"},
        {"Smithsonian Astrophysical Observation", "SAO 215028"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.10007019),
        dec: Angle.Degrees(-43.78013951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203800"},
        {"Hipparcos Number", "HIP 105818"},
        {"Smithsonian Astrophysical Observation", "SAO 230682"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.46157430),
        dec: Angle.Degrees(-43.77803218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94972"},
        {"Hipparcos Number", "HIP 53547"},
        {"Smithsonian Astrophysical Observation", "SAO 222446"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.31854936),
        dec: Angle.Degrees(-43.77731179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187630"},
        {"Hipparcos Number", "HIP 97827"},
        {"Smithsonian Astrophysical Observation", "SAO 229908"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.19089284),
        dec: Angle.Degrees(-43.77656389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87454"},
        {"Hipparcos Number", "HIP 49317"},
        {"Smithsonian Astrophysical Observation", "SAO 221742"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.00202048),
        dec: Angle.Degrees(-43.77623850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168287"},
        {"Hipparcos Number", "HIP 89936"},
        {"Renson", "Renson 47170"},
        {"Smithsonian Astrophysical Observation", "SAO 228939"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.25577126),
        dec: Angle.Degrees(-43.77488698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64303"},
        {"Hipparcos Number", "HIP 38357"},
        {"Smithsonian Astrophysical Observation", "SAO 219070"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.83919032),
        dec: Angle.Degrees(-43.77424424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36477"},
        {"Hipparcos Number", "HIP 25738"},
        {"Smithsonian Astrophysical Observation", "SAO 217362"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.43561437),
        dec: Angle.Degrees(-43.77323951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4662"},
        {"Hipparcos Number", "HIP 3754"},
        {"Smithsonian Astrophysical Observation", "SAO 215239"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.04841829),
        dec: Angle.Degrees(-43.77278094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86993"},
        {"Hipparcos Number", "HIP 49083"},
        {"Smithsonian Astrophysical Observation", "SAO 221698"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.26011858),
        dec: Angle.Degrees(-43.77257756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221032"},
        {"Hipparcos Number", "HIP 115900"},
        {"Smithsonian Astrophysical Observation", "SAO 231620"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.21811141),
        dec: Angle.Degrees(-43.77078272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148043"},
        {"Hipparcos Number", "HIP 80595"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.82926491),
        dec: Angle.Degrees(-43.76969551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116991"},
        {"Hipparcos Number", "HIP 65691"},
        {"Geneva Identification System", "GEN# +1.00116991J"},
        {"Smithsonian Astrophysical Observation", "SAO 224157"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.02401555),
        dec: Angle.Degrees(-43.76860855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150644"},
        {"Hipparcos Number", "HIP 81936"},
        {"Smithsonian Astrophysical Observation", "SAO 227132"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.06346333),
        dec: Angle.Degrees(-43.76835702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126433"},
        {"Hipparcos Number", "HIP 70615"},
        {"Smithsonian Astrophysical Observation", "SAO 224925"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.66485671),
        dec: Angle.Degrees(-43.76801088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23238"},
        {"Hipparcos Number", "HIP 17262"},
        {"Smithsonian Astrophysical Observation", "SAO 216443"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.45891273),
        dec: Angle.Degrees(-43.76773204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122571"},
        {"Hipparcos Number", "HIP 68701"},
        {"Smithsonian Astrophysical Observation", "SAO 224645"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.95335248),
        dec: Angle.Degrees(-43.76712278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51767"},
        {"Hipparcos Number", "HIP 33378"},
        {"Smithsonian Astrophysical Observation", "SAO 218326"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.13806093),
        dec: Angle.Degrees(-43.76291182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75549"},
        {"Hipparcos Number", "HIP 43285"},
        {"Celescope Catalog", "CEL 2949"},
        {"Geneva Identification System", "GEN# +1.00075549"},
        {"Smithsonian Astrophysical Observation", "SAO 220517"},
        {"Wilson Evans Batten Catalogue", "WEB 8342"},
    },
    visualMagnitude: 7.33,
    bvColour: -0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.26404714),
        dec: Angle.Degrees(-43.76122942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92591"},
        {"Hipparcos Number", "HIP 52260"},
        {"Smithsonian Astrophysical Observation", "SAO 222253"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.16908194),
        dec: Angle.Degrees(-43.75739038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73270"},
        {"Hipparcos Number", "HIP 42169"},
        {"Smithsonian Astrophysical Observation", "SAO 220161"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.95091972),
        dec: Angle.Degrees(-43.75550053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158289"},
        {"Hipparcos Number", "HIP 85673"},
        {"Geneva Identification System", "GEN# +1.00158289"},
        {"Smithsonian Astrophysical Observation", "SAO 228046"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.62112248),
        dec: Angle.Degrees(-43.75402065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76160"},
        {"Hipparcos Number", "HIP 43609"},
        {"Geneva Identification System", "GEN# +1.00076160"},
        {"Smithsonian Astrophysical Observation", "SAO 220613"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.22642962),
        dec: Angle.Degrees(-43.75320028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63118"},
        {"Hipparcos Number", "HIP 37823"},
        {"Celescope Catalog", "CEL 2018"},
        {"Geneva Identification System", "GEN# +1.00063118"},
        {"Smithsonian Astrophysical Observation", "SAO 218955"},
        {"Wilson Evans Batten Catalogue", "WEB 7471"},
    },
    visualMagnitude: 6.02,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.32521067),
        dec: Angle.Degrees(-43.75255904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199388"},
        {"Hipparcos Number", "HIP 103517"},
        {"Smithsonian Astrophysical Observation", "SAO 230464"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.57837275),
        dec: Angle.Degrees(-43.75182739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75860"},
        {"Hipparcos Number", "HIP 43443"},
        {"Celescope Catalog", "CEL 2991"},
        {"Geneva Identification System", "GEN# +1.00075860J"},
        {"Smithsonian Astrophysical Observation", "SAO 220566"},
        {"Wilson Evans Batten Catalogue", "WEB 8373"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.72185242),
        dec: Angle.Degrees(-43.75151722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75062"},
        {"Hipparcos Number", "HIP 43029"},
        {"Celescope Catalog", "CEL 2877"},
        {"Geneva Identification System", "GEN# +1.00075062"},
        {"Smithsonian Astrophysical Observation", "SAO 220421"},
    },
    visualMagnitude: 7.91,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.51722746),
        dec: Angle.Degrees(-43.75117164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213080"},
        {"Hipparcos Number", "HIP 111043"},
        {"Geneva Identification System", "GEN# +1.00213080A"},
        {"Smithsonian Astrophysical Observation", "SAO 231161"},
        {"Wilson Evans Batten Catalogue", "WEB 19880"},
    },
    visualMagnitude: 4.12,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.43935610),
        dec: Angle.Degrees(-43.74922804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18709"},
        {"Hipparcos Number", "HIP 13902"},
        {"Fundamental Katalog 5th Edition", "FK5 2210"},
        {"Geneva Identification System", "GEN# +1.00018709"},
        {"Smithsonian Astrophysical Observation", "SAO 216120"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.74595074),
        dec: Angle.Degrees(-43.74792350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -166.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93037"},
        {"Hipparcos Number", "HIP 52494"},
        {"Smithsonian Astrophysical Observation", "SAO 222278"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.97666289),
        dec: Angle.Degrees(-43.74675775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101453"},
        {"Hipparcos Number", "HIP 56924"},
        {"Smithsonian Astrophysical Observation", "SAO 222943"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.05638058),
        dec: Angle.Degrees(-43.74605467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85347",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85347"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.60550866),
        dec: Angle.Degrees(-43.74551667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85486",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85486"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.05920583),
        dec: Angle.Degrees(-43.74545515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149405"},
        {"Hipparcos Number", "HIP 81311"},
        {"Smithsonian Astrophysical Observation", "SAO 226954"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.10628625),
        dec: Angle.Degrees(-43.74469932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219219"},
        {"Hipparcos Number", "HIP 114755"},
        {"Smithsonian Astrophysical Observation", "SAO 231506"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.67745213),
        dec: Angle.Degrees(-43.74465051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74807"},
        {"Hipparcos Number", "HIP 42892"},
        {"Geneva Identification System", "GEN# +1.00074807"},
        {"Smithsonian Astrophysical Observation", "SAO 220373"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.11650569),
        dec: Angle.Degrees(-43.73927486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37815"},
        {"Hipparcos Number", "HIP 26584"},
        {"Smithsonian Astrophysical Observation", "SAO 217454"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.76776621),
        dec: Angle.Degrees(-43.73870648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211203"},
        {"Hipparcos Number", "HIP 109982"},
        {"Smithsonian Astrophysical Observation", "SAO 231065"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.13947377),
        dec: Angle.Degrees(-43.73768056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117119"},
        {"Hipparcos Number", "HIP 65762"},
        {"Geneva Identification System", "GEN# +1.00117119"},
        {"Smithsonian Astrophysical Observation", "SAO 224172"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.23191668),
        dec: Angle.Degrees(-43.73697853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53838"},
        {"Hipparcos Number", "HIP 34113"},
        {"Smithsonian Astrophysical Observation", "SAO 218429"},
    },
    visualMagnitude: 8.07,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.10429233),
        dec: Angle.Degrees(-43.73628592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148825"},
        {"Hipparcos Number", "HIP 81006"},
        {"Smithsonian Astrophysical Observation", "SAO 226870"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.14825204),
        dec: Angle.Degrees(-43.73403085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97866"},
        {"Hipparcos Number", "HIP 54929"},
        {"Geneva Identification System", "GEN# +1.00097866"},
        {"Smithsonian Astrophysical Observation", "SAO 222671"},
    },
    visualMagnitude: 6.22,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.72555764),
        dec: Angle.Degrees(-43.73370761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111144"},
        {"Hipparcos Number", "HIP 62412"},
        {"Smithsonian Astrophysical Observation", "SAO 223672"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.85921980),
        dec: Angle.Degrees(-43.73096646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -196.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101880",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101880"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.67741118),
        dec: Angle.Degrees(-43.73044249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 236.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -371.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134331"},
        {"Hipparcos Number", "HIP 74268"},
        {"Geneva Identification System", "GEN# +1.00134331"},
        {"Smithsonian Astrophysical Observation", "SAO 225508"},
        {"Wilson Evans Batten Catalogue", "WEB 12679"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.67333825),
        dec: Angle.Degrees(-43.72963072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146855"},
        {"Hipparcos Number", "HIP 80050"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.09136009),
        dec: Angle.Degrees(-43.72912398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7186"},
        {"Hipparcos Number", "HIP 5574"},
        {"Smithsonian Astrophysical Observation", "SAO 215403"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.86817810),
        dec: Angle.Degrees(-43.72746477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58975",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58975"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.38763603),
        dec: Angle.Degrees(-43.72713700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -295.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84641"},
        {"Hipparcos Number", "HIP 47877"},
        {"Smithsonian Astrophysical Observation", "SAO 221463"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.36435211),
        dec: Angle.Degrees(-43.72646588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138494"},
        {"Hipparcos Number", "HIP 76213"},
        {"Geneva Identification System", "GEN# +1.00138494"},
        {"Smithsonian Astrophysical Observation", "SAO 225907"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.52475346),
        dec: Angle.Degrees(-43.72565864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142710"},
        {"Hipparcos Number", "HIP 78186"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.46290544),
        dec: Angle.Degrees(-43.72477240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56437"},
        {"Hipparcos Number", "HIP 35047"},
        {"Smithsonian Astrophysical Observation", "SAO 218569"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.71852232),
        dec: Angle.Degrees(-43.72450536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130415"},
        {"Hipparcos Number", "HIP 72514"},
        {"Geneva Identification System", "GEN# +1.00130415"},
        {"Smithsonian Astrophysical Observation", "SAO 225214"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.39631882),
        dec: Angle.Degrees(-43.72233481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181925"},
        {"Hipparcos Number", "HIP 95396"},
        {"Geneva Identification System", "GEN# +1.00181925"},
        {"Smithsonian Astrophysical Observation", "SAO 229660"},
    },
    visualMagnitude: 6.13,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.08939541),
        dec: Angle.Degrees(-43.72205960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19889"},
        {"Hipparcos Number", "HIP 14726"},
        {"Geneva Identification System", "GEN# +1.00019889"},
        {"Smithsonian Astrophysical Observation", "SAO 216194"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.55034667),
        dec: Angle.Degrees(-43.72092557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162545"},
        {"Hipparcos Number", "HIP 87599"},
        {"Smithsonian Astrophysical Observation", "SAO 228519"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.41522530),
        dec: Angle.Degrees(-43.71905401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95795"},
        {"Hipparcos Number", "HIP 53998"},
        {"Smithsonian Astrophysical Observation", "SAO 222516"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.69404016),
        dec: Angle.Degrees(-43.71845867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46415"},
        {"Hipparcos Number", "HIP 31061"},
        {"Geneva Identification System", "GEN# +1.00046415"},
        {"Smithsonian Astrophysical Observation", "SAO 217987"},
        {"Wilson Evans Batten Catalogue", "WEB 6183"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.76896928),
        dec: Angle.Degrees(-43.71713799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11527"},
        {"Hipparcos Number", "HIP 8724"},
        {"Smithsonian Astrophysical Observation", "SAO 215685"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.05786742),
        dec: Angle.Degrees(-43.71704502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134330"},
        {"Hipparcos Number", "HIP 74271"},
        {"Geneva Identification System", "GEN# +1.00134330"},
        {"Smithsonian Astrophysical Observation", "SAO 225510"},
        {"Wilson Evans Batten Catalogue", "WEB 12678"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.68002354),
        dec: Angle.Degrees(-43.71666052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22541"},
        {"Hipparcos Number", "HIP 16772"},
        {"Smithsonian Astrophysical Observation", "SAO 216398"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.95750428),
        dec: Angle.Degrees(-43.71642828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204206"},
        {"Hipparcos Number", "HIP 106019"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.09913940),
        dec: Angle.Degrees(-43.71624070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111313"},
        {"Hipparcos Number", "HIP 62522"},
        {"Smithsonian Astrophysical Observation", "SAO 223681"},
    },
    visualMagnitude: 8.82,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.19631352),
        dec: Angle.Degrees(-43.71539653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174861"},
        {"Hipparcos Number", "HIP 92816"},
        {"Smithsonian Astrophysical Observation", "SAO 229366"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.68364833),
        dec: Angle.Degrees(-43.71538511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63726",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63726"},
    },
    visualMagnitude: 12.06,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.89251712),
        dec: Angle.Degrees(-43.71473500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68271"},
        {"Hipparcos Number", "HIP 39981"},
        {"Geneva Identification System", "GEN# +1.00068271"},
        {"Smithsonian Astrophysical Observation", "SAO 219517"},
    },
    visualMagnitude: 8.43,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.47463522),
        dec: Angle.Degrees(-43.71452244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5042"},
        {"Hipparcos Number", "HIP 4049"},
        {"Geneva Identification System", "GEN# +1.00005042"},
        {"Smithsonian Astrophysical Observation", "SAO 215270"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.96727279),
        dec: Angle.Degrees(-43.70903814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56432",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56432"},
    },
    visualMagnitude: 11.52,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.55046874),
        dec: Angle.Degrees(-43.70716802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154372"},
        {"Hipparcos Number", "HIP 83755"},
        {"Smithsonian Astrophysical Observation", "SAO 227633"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.76868058),
        dec: Angle.Degrees(-43.70637526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151708"},
        {"Hipparcos Number", "HIP 82450"},
        {"Geneva Identification System", "GEN# +1.00151708"},
        {"Smithsonian Astrophysical Observation", "SAO 227298"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.74558485),
        dec: Angle.Degrees(-43.70618383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221918"},
        {"Hipparcos Number", "HIP 116494"},
        {"Smithsonian Astrophysical Observation", "SAO 231688"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.08954819),
        dec: Angle.Degrees(-43.70560332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112699"},
        {"Hipparcos Number", "HIP 63375"},
        {"Smithsonian Astrophysical Observation", "SAO 223806"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.78505955),
        dec: Angle.Degrees(-43.70402394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121914"},
        {"Hipparcos Number", "HIP 68351"},
        {"Fundamental Katalog 5th Edition", "FK5 5238"},
        {"Smithsonian Astrophysical Observation", "SAO 224596"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.86812705),
        dec: Angle.Degrees(-43.70302181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175029"},
        {"Hipparcos Number", "HIP 92880"},
        {"Geneva Identification System", "GEN# +1.00175029"},
        {"Smithsonian Astrophysical Observation", "SAO 229376"},
        {"Wilson Evans Batten Catalogue", "WEB 16079"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.87647939),
        dec: Angle.Degrees(-43.70280869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -191.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77510"},
        {"Hipparcos Number", "HIP 44304"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.34511441),
        dec: Angle.Degrees(-43.70224191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39427"},
        {"Hipparcos Number", "HIP 27578"},
        {"Geneva Identification System", "GEN# +1.00039427"},
        {"Smithsonian Astrophysical Observation", "SAO 217565"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.61393079),
        dec: Angle.Degrees(-43.70014321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 205.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86488"},
        {"Hipparcos Number", "HIP 48838"},
        {"Smithsonian Astrophysical Observation", "SAO 221642"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.42897507),
        dec: Angle.Degrees(-43.69914400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189171"},
        {"Hipparcos Number", "HIP 98494"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.14293225),
        dec: Angle.Degrees(-43.69761114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44204"},
        {"Hipparcos Number", "HIP 29953"},
        {"Smithsonian Astrophysical Observation", "SAO 217835"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.58172328),
        dec: Angle.Degrees(-43.69575934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100396"},
        {"Hipparcos Number", "HIP 56329"},
        {"Geneva Identification System", "GEN# +1.00100396"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.22022993),
        dec: Angle.Degrees(-43.69537662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88185"},
        {"Hipparcos Number", "HIP 49722"},
        {"Geneva Identification System", "GEN# +1.00088185"},
        {"Smithsonian Astrophysical Observation", "SAO 221807"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.27778687),
        dec: Angle.Degrees(-43.69514145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69238"},
        {"Hipparcos Number", "HIP 40350"},
        {"Geneva Identification System", "GEN# +1.00069238"},
        {"Smithsonian Astrophysical Observation", "SAO 219645"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.57662429),
        dec: Angle.Degrees(-43.69439355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32154"},
        {"Hipparcos Number", "HIP 23158"},
        {"Geneva Identification System", "GEN# +1.00032154"},
        {"Smithsonian Astrophysical Observation", "SAO 217097"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.73339858),
        dec: Angle.Degrees(-43.69415240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220993"},
        {"Hipparcos Number", "HIP 115879"},
        {"Smithsonian Astrophysical Observation", "SAO 231619"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.16415402),
        dec: Angle.Degrees(-43.69167131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72816"},
        {"Hipparcos Number", "HIP 41958"},
        {"Geneva Identification System", "GEN# +1.00072816"},
        {"Smithsonian Astrophysical Observation", "SAO 220090"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.29062605),
        dec: Angle.Degrees(-43.68400042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67236",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67236"},
    },
    visualMagnitude: 10.37,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.66924593),
        dec: Angle.Degrees(-43.68203174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94543"},
        {"Hipparcos Number", "HIP 53308"},
        {"Smithsonian Astrophysical Observation", "SAO 222409"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.54885493),
        dec: Angle.Degrees(-43.68062619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173715"},
        {"Hipparcos Number", "HIP 92308"},
        {"Fundamental Katalog 5th Edition", "FK5 1490"},
        {"Geneva Identification System", "GEN# +1.00173715"},
        {"Smithsonian Astrophysical Observation", "SAO 229299"},
        {"Wilson Evans Batten Catalogue", "WEB 15930"},
    },
    visualMagnitude: 5.46,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.21029394),
        dec: Angle.Degrees(-43.67999681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2262"},
        {"Hipparcos Number", "HIP 2072"},
        {"Geneva Identification System", "GEN# +1.00002262"},
        {"Smithsonian Astrophysical Observation", "SAO 215092"},
        {"Wilson Evans Batten Catalogue", "WEB 391"},
    },
    visualMagnitude: 3.93,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.55048418),
        dec: Angle.Degrees(-43.67990933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84729"},
        {"Hipparcos Number", "HIP 47912"},
        {"Fundamental Katalog 5th Edition", "FK5 4865"},
        {"Geneva Identification System", "GEN# +1.00084729"},
        {"Smithsonian Astrophysical Observation", "SAO 221471"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.48110501),
        dec: Angle.Degrees(-43.67877115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192092"},
        {"Hipparcos Number", "HIP 99806"},
        {"Geneva Identification System", "GEN# +1.00192092"},
        {"Smithsonian Astrophysical Observation", "SAO 230118"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.74884368),
        dec: Angle.Degrees(-43.67821044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97394"},
        {"Hipparcos Number", "HIP 54705"},
        {"Geneva Identification System", "GEN# +1.00097394"},
        {"Renson", "Renson 28090"},
        {"Smithsonian Astrophysical Observation", "SAO 222634"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.00528912),
        dec: Angle.Degrees(-43.67697288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14088"},
        {"Hipparcos Number", "HIP 10520"},
        {"Smithsonian Astrophysical Observation", "SAO 215840"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.88844449),
        dec: Angle.Degrees(-43.67483586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80056"},
        {"Hipparcos Number", "HIP 45486"},
        {"Smithsonian Astrophysical Observation", "SAO 221011"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.03144163),
        dec: Angle.Degrees(-43.67370669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16519"},
        {"Hipparcos Number", "HIP 12248"},
        {"Smithsonian Astrophysical Observation", "SAO 215973"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.42583254),
        dec: Angle.Degrees(-43.67327173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 203.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193628"},
        {"Hipparcos Number", "HIP 100528"},
        {"Geneva Identification System", "GEN# +1.00193628"},
        {"Smithsonian Astrophysical Observation", "SAO 230180"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.75874800),
        dec: Angle.Degrees(-43.67062324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188245"},
        {"Hipparcos Number", "HIP 98089"},
        {"Smithsonian Astrophysical Observation", "SAO 229932"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.01586165),
        dec: Angle.Degrees(-43.66989054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61130",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61130"},
        {"Geneva Identification System", "GEN# -0.04207709"},
    },
    visualMagnitude: 10.78,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.90585642),
        dec: Angle.Degrees(-43.66902282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91805"},
        {"Hipparcos Number", "HIP 51816"},
        {"Geneva Identification System", "GEN# +1.00091805"},
        {"Smithsonian Astrophysical Observation", "SAO 222170"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.79354136),
        dec: Angle.Degrees(-43.66466238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138148"},
        {"Hipparcos Number", "HIP 76054"},
        {"Geneva Identification System", "GEN# +1.00138148"},
        {"Smithsonian Astrophysical Observation", "SAO 225872"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.98148880),
        dec: Angle.Degrees(-43.66453473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70780"},
        {"Hipparcos Number", "HIP 41008"},
        {"Geneva Identification System", "GEN# +1.00070780"},
        {"Smithsonian Astrophysical Observation", "SAO 219841"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.53547969),
        dec: Angle.Degrees(-43.66286275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191349"},
        {"Hipparcos Number", "HIP 99465"},
        {"Fundamental Katalog 5th Edition", "FK5 3617"},
        {"Geneva Identification System", "GEN# +1.00191349"},
        {"Smithsonian Astrophysical Observation", "SAO 230089"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.81578207),
        dec: Angle.Degrees(-43.66228271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31648",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31648"},
        {"Geneva Identification System", "GEN# -0.04302572"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.35825724),
        dec: Angle.Degrees(-43.66145292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 165.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148173"},
        {"Hipparcos Number", "HIP 80659"},
        {"Wilson Evans Batten Catalogue", "WEB 13642"},
    },
    visualMagnitude: 9.53,
    bvColour: 3.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.02194312),
        dec: Angle.Degrees(-43.66114146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55938"},
        {"Hipparcos Number", "HIP 34875"},
        {"Smithsonian Astrophysical Observation", "SAO 218542"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.23763847),
        dec: Angle.Degrees(-43.65877831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80383",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80383"},
    },
    visualMagnitude: 11.06,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.11945760),
        dec: Angle.Degrees(-43.65835746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216694"},
        {"Hipparcos Number", "HIP 113210"},
        {"Smithsonian Astrophysical Observation", "SAO 231357"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.89204043),
        dec: Angle.Degrees(-43.65823281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144947"},
        {"Hipparcos Number", "HIP 79243"},
        {"Geneva Identification System", "GEN# +1.00144947"},
        {"Smithsonian Astrophysical Observation", "SAO 226556"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.57899982),
        dec: Angle.Degrees(-43.65656130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147555"},
        {"Hipparcos Number", "HIP 80381"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.11443341),
        dec: Angle.Degrees(-43.65635728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -222.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64459"},
        {"Hipparcos Number", "HIP 38413"},
        {"Geneva Identification System", "GEN# +1.00064459"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.04605590),
        dec: Angle.Degrees(-43.65557340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144793"},
        {"Hipparcos Number", "HIP 79175"},
        {"Smithsonian Astrophysical Observation", "SAO 226540"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.38609369),
        dec: Angle.Degrees(-43.65407274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40919"},
        {"Hipparcos Number", "HIP 28378"},
        {"Smithsonian Astrophysical Observation", "SAO 217656"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.92662215),
        dec: Angle.Degrees(-43.65293605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149231"},
        {"Hipparcos Number", "HIP 81214"},
        {"Geneva Identification System", "GEN# +1.00149231"},
        {"Smithsonian Astrophysical Observation", "SAO 226933"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.83000753),
        dec: Angle.Degrees(-43.65222242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218762"},
        {"Hipparcos Number", "HIP 114475"},
        {"Smithsonian Astrophysical Observation", "SAO 231475"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.74834797),
        dec: Angle.Degrees(-43.64773508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67842"},
        {"Hipparcos Number", "HIP 39808"},
        {"Smithsonian Astrophysical Observation", "SAO 219455"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.01424931),
        dec: Angle.Degrees(-43.64682813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 665",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 665"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.05484372),
        dec: Angle.Degrees(-43.64669264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104059"},
        {"Hipparcos Number", "HIP 58435"},
        {"Geneva Identification System", "GEN# +1.00104059"},
        {"Smithsonian Astrophysical Observation", "SAO 223149"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.72511194),
        dec: Angle.Degrees(-43.64641528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141742"},
        {"Hipparcos Number", "HIP 77745"},
        {"Smithsonian Astrophysical Observation", "SAO 226313"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.09938652),
        dec: Angle.Degrees(-43.64610930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10818"},
        {"Hipparcos Number", "HIP 8158"},
        {"Geneva Identification System", "GEN# +1.00010818"},
        {"Smithsonian Astrophysical Observation", "SAO 215634"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.22856369),
        dec: Angle.Degrees(-43.64562275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43941"},
        {"Hipparcos Number", "HIP 29816"},
        {"Smithsonian Astrophysical Observation", "SAO 217826"},
    },
    visualMagnitude: 7.34,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.18753099),
        dec: Angle.Degrees(-43.64398273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153383"},
        {"Hipparcos Number", "HIP 83288"},
        {"Geneva Identification System", "GEN# +1.00153383"},
        {"Smithsonian Astrophysical Observation", "SAO 227554"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.32035979),
        dec: Angle.Degrees(-43.64342370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126238"},
        {"Hipparcos Number", "HIP 70519"},
        {"Geneva Identification System", "GEN# +1.00126238J"},
        {"Smithsonian Astrophysical Observation", "SAO 224910"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.37473318),
        dec: Angle.Degrees(-43.64333866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150881"},
        {"Henry Draper 2", "HD 150882"},
        {"Hipparcos Number", "HIP 82074"},
        {"Smithsonian Astrophysical Observation", "SAO 227167"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.45780902),
        dec: Angle.Degrees(-43.64309401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61574"},
        {"Hipparcos Number", "HIP 37148"},
        {"Fundamental Katalog 5th Edition", "FK5 4685"},
        {"Smithsonian Astrophysical Observation", "SAO 218847"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.50577737),
        dec: Angle.Degrees(-43.64146456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58196",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58196"},
    },
    visualMagnitude: 11.40,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.03109876),
        dec: Angle.Degrees(-43.63984670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 326260"},
        {"Hipparcos Number", "HIP 82383"},
    },
    visualMagnitude: 10.23,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.51426406),
        dec: Angle.Degrees(-43.63942252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -209.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69676"},
        {"Hipparcos Number", "HIP 40504"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.04353503),
        dec: Angle.Degrees(-43.63684728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155552"},
        {"Hipparcos Number", "HIP 84331"},
        {"Smithsonian Astrophysical Observation", "SAO 227732"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.60649033),
        dec: Angle.Degrees(-43.63669479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72125"},
        {"Hipparcos Number", "HIP 41634"},
        {"Geneva Identification System", "GEN# +1.00072125"},
        {"Smithsonian Astrophysical Observation", "SAO 219993"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.34735234),
        dec: Angle.Degrees(-43.63599866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7858",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7858"},
    },
    visualMagnitude: 11.64,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.26538395),
        dec: Angle.Degrees(-43.63559301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -213.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62317"},
        {"Hipparcos Number", "HIP 37469"},
        {"Celescope Catalog", "CEL 1984"},
        {"Geneva Identification System", "GEN# +1.00062317"},
        {"Renson", "Renson 17090"},
        {"Smithsonian Astrophysical Observation", "SAO 218906"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.35620915),
        dec: Angle.Degrees(-43.63534240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211052"},
        {"Hipparcos Number", "HIP 109896"},
        {"Smithsonian Astrophysical Observation", "SAO 231052"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.87673950),
        dec: Angle.Degrees(-43.63467155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 120.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115988"},
        {"Hipparcos Number", "HIP 65178"},
        {"Geneva Identification System", "GEN# +1.00115988"},
        {"Smithsonian Astrophysical Observation", "SAO 224083"},
    },
    visualMagnitude: 6.67,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.35804558),
        dec: Angle.Degrees(-43.63428489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108602"},
        {"Hipparcos Number", "HIP 60894"},
        {"Smithsonian Astrophysical Observation", "SAO 223460"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.19035591),
        dec: Angle.Degrees(-43.63316652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8049"},
        {"Henry Draper 2", "HD 8049A"},
        {"Hipparcos Number", "HIP 6177"},
        {"Geneva Identification System", "GEN# +1.00008049"},
        {"Smithsonian Astrophysical Observation", "SAO 215457"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.81170328),
        dec: Angle.Degrees(-43.62925166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -241.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43180"},
        {"Hipparcos Number", "HIP 29479"},
        {"Geneva Identification System", "GEN# +1.00043180"},
        {"Smithsonian Astrophysical Observation", "SAO 217779"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.16907910),
        dec: Angle.Degrees(-43.62861605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 535",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 535"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.61846773),
        dec: Angle.Degrees(-43.62772225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91461"},
        {"Hipparcos Number", "HIP 51621"},
        {"Fundamental Katalog 5th Edition", "FK5 4934"},
        {"Smithsonian Astrophysical Observation", "SAO 222132"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.19430622),
        dec: Angle.Degrees(-43.62762865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165124"},
        {"Hipparcos Number", "HIP 88711"},
        {"Smithsonian Astrophysical Observation", "SAO 228703"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.65177758),
        dec: Angle.Degrees(-43.62744264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88942"},
        {"Hipparcos Number", "HIP 50183"},
        {"Smithsonian Astrophysical Observation", "SAO 221893"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.66107365),
        dec: Angle.Degrees(-43.62581766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26507"},
        {"Hipparcos Number", "HIP 19425"},
        {"Renson", "Renson 6740"},
        {"Smithsonian Astrophysical Observation", "SAO 216671"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.40413331),
        dec: Angle.Degrees(-43.62485999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222213"},
        {"Hipparcos Number", "HIP 116693"},
        {"Smithsonian Astrophysical Observation", "SAO 231714"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.71706681),
        dec: Angle.Degrees(-43.62363951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27542"},
        {"Hipparcos Number", "HIP 20121"},
        {"Smithsonian Astrophysical Observation", "SAO 216745"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.71414113),
        dec: Angle.Degrees(-43.62223485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69143"},
        {"Hipparcos Number", "HIP 40315"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.47725158),
        dec: Angle.Degrees(-43.61903533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24976"},
        {"Hipparcos Number", "HIP 18420"},
        {"Geneva Identification System", "GEN# +1.00024976"},
        {"Smithsonian Astrophysical Observation", "SAO 216560"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.07380084),
        dec: Angle.Degrees(-43.61816151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195740"},
        {"Hipparcos Number", "HIP 101535"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.66974447),
        dec: Angle.Degrees(-43.61790481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216751"},
        {"Hipparcos Number", "HIP 113256"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.01887696),
        dec: Angle.Degrees(-43.61788791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190650"},
        {"Hipparcos Number", "HIP 99157"},
        {"Smithsonian Astrophysical Observation", "SAO 230052"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.95476423),
        dec: Angle.Degrees(-43.61631975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18753"},
        {"Hipparcos Number", "HIP 13925"},
        {"Smithsonian Astrophysical Observation", "SAO 216125"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.84952181),
        dec: Angle.Degrees(-43.61534961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54320",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54320"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.68370602),
        dec: Angle.Degrees(-43.61407106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21520"},
        {"Hipparcos Number", "HIP 16038"},
        {"Smithsonian Astrophysical Observation", "SAO 216322"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.64036553),
        dec: Angle.Degrees(-43.61351046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14833"},
        {"Hipparcos Number", "HIP 11040"},
        {"Smithsonian Astrophysical Observation", "SAO 215877"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.54422088),
        dec: Angle.Degrees(-43.61344761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79416"},
        {"Hipparcos Number", "HIP 45189"},
        {"Celescope Catalog", "CEL 3222"},
        {"Geneva Identification System", "GEN# +1.00079416J"},
        {"Renson", "Renson 22530"},
        {"Smithsonian Astrophysical Observation", "SAO 220952"},
        {"Wilson Evans Batten Catalogue", "WEB 8619"},
    },
    visualMagnitude: 5.56,
    bvColour: -0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.12725463),
        dec: Angle.Degrees(-43.61329176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221432"},
        {"Hipparcos Number", "HIP 116172"},
        {"Smithsonian Astrophysical Observation", "SAO 231653"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.08697088),
        dec: Angle.Degrees(-43.61320678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53706"},
        {"Hipparcos Number", "HIP 34069"},
        {"Geneva Identification System", "GEN# +1.00053706"},
        {"Smithsonian Astrophysical Observation", "SAO 218423"},
        {"Wilson Evans Batten Catalogue", "WEB 6832"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.99585067),
        dec: Angle.Degrees(-43.61228317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 396.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104644",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104644"},
        {"Cincinnati Publication", "Ci 20 1264"},
        {"Geneva Identification System", "GEN# +6.20145074"},
    },
    visualMagnitude: 11.98,
    bvColour: 1.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.95581262),
        dec: Angle.Degrees(-43.61197308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 215.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -688.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103481"},
        {"Hipparcos Number", "HIP 58092"},
        {"Geneva Identification System", "GEN# +1.00103481"},
        {"Smithsonian Astrophysical Observation", "SAO 223105"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.70849332),
        dec: Angle.Degrees(-43.61089111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54341"},
        {"Hipparcos Number", "HIP 34276"},
        {"Celescope Catalog", "CEL 1594"},
        {"Smithsonian Astrophysical Observation", "SAO 218453"},
    },
    visualMagnitude: 6.52,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.58720085),
        dec: Angle.Degrees(-43.61078123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53705"},
        {"Hipparcos Number", "HIP 34065"},
        {"Geneva Identification System", "GEN# +1.00053705A"},
        {"Smithsonian Astrophysical Observation", "SAO 218421"},
        {"Wilson Evans Batten Catalogue", "WEB 6831"},
    },
    visualMagnitude: 5.56,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.98916816),
        dec: Angle.Degrees(-43.60898397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 388.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35678"},
        {"Hipparcos Number", "HIP 25269"},
        {"Smithsonian Astrophysical Observation", "SAO 217321"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.06721083),
        dec: Angle.Degrees(-43.60882933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161043"},
        {"Hipparcos Number", "HIP 86905"},
        {"Smithsonian Astrophysical Observation", "SAO 228378"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.36244306),
        dec: Angle.Degrees(-43.60779854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12688"},
        {"Hipparcos Number", "HIP 9588"},
        {"Smithsonian Astrophysical Observation", "SAO 215749"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.79571267),
        dec: Angle.Degrees(-43.60776798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115507"},
        {"Hipparcos Number", "HIP 64918"},
        {"Geneva Identification System", "GEN# +1.00115507"},
        {"Smithsonian Astrophysical Observation", "SAO 224050"},
    },
    visualMagnitude: 8.61,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.59591572),
        dec: Angle.Degrees(-43.60749026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172442"},
        {"Hipparcos Number", "HIP 91731"},
        {"Smithsonian Astrophysical Observation", "SAO 229212"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.58736060),
        dec: Angle.Degrees(-43.60666656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2811"},
        {"Hipparcos Number", "HIP 2465"},
        {"Smithsonian Astrophysical Observation", "SAO 215129"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.82706135),
        dec: Angle.Degrees(-43.60637738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196583"},
        {"Hipparcos Number", "HIP 101977"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.98879378),
        dec: Angle.Degrees(-43.60634801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215628"},
        {"Hipparcos Number", "HIP 112497"},
        {"Geneva Identification System", "GEN# +1.00215628"},
        {"Smithsonian Astrophysical Observation", "SAO 231297"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.80749714),
        dec: Angle.Degrees(-43.60614030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216098"},
        {"Hipparcos Number", "HIP 112806"},
        {"Geneva Identification System", "GEN# +1.00216098"},
        {"Smithsonian Astrophysical Observation", "SAO 231324"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.67249346),
        dec: Angle.Degrees(-43.60590777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181133"},
        {"Hipparcos Number", "HIP 95130"},
        {"Geneva Identification System", "GEN# +1.00181133"},
        {"Smithsonian Astrophysical Observation", "SAO 229637"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.31487841),
        dec: Angle.Degrees(-43.60521480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119779"},
        {"Hipparcos Number", "HIP 67184"},
        {"Smithsonian Astrophysical Observation", "SAO 224407"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.52674664),
        dec: Angle.Degrees(-43.60474053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219342"},
        {"Hipparcos Number", "HIP 114814"},
        {"Geneva Identification System", "GEN# +1.00219342"},
        {"Smithsonian Astrophysical Observation", "SAO 231518"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.86559096),
        dec: Angle.Degrees(-43.60454967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3967"},
        {"Hipparcos Number", "HIP 3285"},
        {"Smithsonian Astrophysical Observation", "SAO 215198"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.47050361),
        dec: Angle.Degrees(-43.60444541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193212"},
        {"Hipparcos Number", "HIP 100331"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.20830373),
        dec: Angle.Degrees(-43.60403679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34781"},
        {"Hipparcos Number", "HIP 24691"},
        {"Geneva Identification System", "GEN# +1.00034781"},
        {"Smithsonian Astrophysical Observation", "SAO 217274"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.43755265),
        dec: Angle.Degrees(-43.60378393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 113.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191273"},
        {"Hipparcos Number", "HIP 99426"},
        {"Geneva Identification System", "GEN# +1.00191273"},
        {"Renson", "Renson 53280"},
        {"Smithsonian Astrophysical Observation", "SAO 230084"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.70919848),
        dec: Angle.Degrees(-43.60295164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8391"},
        {"Hipparcos Number", "HIP 6418"},
        {"Geneva Identification System", "GEN# +1.00008391"},
        {"Smithsonian Astrophysical Observation", "SAO 215478"},
        {"Wilson Evans Batten Catalogue", "WEB 1420"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.60081403),
        dec: Angle.Degrees(-43.60264527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40623"},
        {"Hipparcos Number", "HIP 28226"},
        {"Smithsonian Astrophysical Observation", "SAO 217643"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.45569916),
        dec: Angle.Degrees(-43.60167999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81289"},
        {"Hipparcos Number", "HIP 46047"},
        {"Geneva Identification System", "GEN# +1.00081289"},
        {"Renson", "Renson 23080"},
        {"Smithsonian Astrophysical Observation", "SAO 221121"},
    },
    visualMagnitude: 8.43,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.85649380),
        dec: Angle.Degrees(-43.60138632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222802"},
        {"Hipparcos Number", "HIP 117061"},
        {"Geneva Identification System", "GEN# +1.00222802"},
        {"Smithsonian Astrophysical Observation", "SAO 231755"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.97540424),
        dec: Angle.Degrees(-43.60067714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67531"},
        {"Hipparcos Number", "HIP 39687"},
        {"Geneva Identification System", "GEN# +1.00067531"},
        {"Smithsonian Astrophysical Observation", "SAO 219420"},
    },
    visualMagnitude: 8.67,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.65953840),
        dec: Angle.Degrees(-43.59937879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131258"},
        {"Hipparcos Number", "HIP 72903"},
        {"Geneva Identification System", "GEN# +1.00131258"},
        {"Smithsonian Astrophysical Observation", "SAO 225282"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.50338201),
        dec: Angle.Degrees(-43.59781705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156157"},
        {"Hipparcos Number", "HIP 84628"},
        {"Celescope Catalog", "CEL 4495"},
        {"Geneva Identification System", "GEN# +1.00156157"},
        {"Smithsonian Astrophysical Observation", "SAO 227799"},
    },
    visualMagnitude: 7.02,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.50574070),
        dec: Angle.Degrees(-43.57765360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167384"},
        {"Hipparcos Number", "HIP 89599"},
        {"Smithsonian Astrophysical Observation", "SAO 228868"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.26585858),
        dec: Angle.Degrees(-43.59480446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61712"},
        {"Hipparcos Number", "HIP 37222"},
        {"Geneva Identification System", "GEN# +1.00061712"},
        {"Smithsonian Astrophysical Observation", "SAO 218858"},
    },
    visualMagnitude: 8.98,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.68139870),
        dec: Angle.Degrees(-43.59470452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63223",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63223"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.31951133),
        dec: Angle.Degrees(-43.59211488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4989"},
        {"Hipparcos Number", "HIP 4010"},
        {"Geneva Identification System", "GEN# +1.00004989"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.857,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.86133373),
        dec: Angle.Degrees(-43.59065723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221402"},
        {"Hipparcos Number", "HIP 116154"},
        {"Geneva Identification System", "GEN# +1.00221402"},
        {"Smithsonian Astrophysical Observation", "SAO 231649"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.01827355),
        dec: Angle.Degrees(-43.59001026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44311"},
        {"Hipparcos Number", "HIP 30017"},
        {"Smithsonian Astrophysical Observation", "SAO 217842"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.75031910),
        dec: Angle.Degrees(-43.58964198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94325"},
        {"Hipparcos Number", "HIP 53168"},
        {"Smithsonian Astrophysical Observation", "SAO 222393"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.15199325),
        dec: Angle.Degrees(-43.58462879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37972"},
        {"Hipparcos Number", "HIP 26679"},
        {"Smithsonian Astrophysical Observation", "SAO 217470"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.04835901),
        dec: Angle.Degrees(-43.58462730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223634"},
        {"Hipparcos Number", "HIP 117623"},
        {"Smithsonian Astrophysical Observation", "SAO 231810"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.82919345),
        dec: Angle.Degrees(-43.58396333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102257"},
        {"Hipparcos Number", "HIP 57392"},
        {"Smithsonian Astrophysical Observation", "SAO 223013"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.49551259),
        dec: Angle.Degrees(-43.58366927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53895"},
        {"Hipparcos Number", "HIP 34134"},
        {"Smithsonian Astrophysical Observation", "SAO 218433"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.16561657),
        dec: Angle.Degrees(-43.58150331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17621"},
        {"Hipparcos Number", "HIP 13084"},
        {"Smithsonian Astrophysical Observation", "SAO 216054"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.05061513),
        dec: Angle.Degrees(-43.58141037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87253",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87253"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.42894201),
        dec: Angle.Degrees(-43.57954647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36519"},
        {"Hipparcos Number", "HIP 25766"},
        {"Geneva Identification System", "GEN# +1.00036519"},
        {"Smithsonian Astrophysical Observation", "SAO 217366"},
        {"Wilson Evans Batten Catalogue", "WEB 5004"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.53005218),
        dec: Angle.Degrees(-43.57952880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137767"},
        {"Hipparcos Number", "HIP 75831"},
        {"Geneva Identification System", "GEN# +1.00137767"},
        {"Smithsonian Astrophysical Observation", "SAO 225829"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.35429831),
        dec: Angle.Degrees(-43.57836677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13617"},
        {"Hipparcos Number", "HIP 10238"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.91827518),
        dec: Angle.Degrees(-43.57754765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202946"},
        {"Hipparcos Number", "HIP 105367"},
        {"Geneva Identification System", "GEN# +1.00202946"},
        {"Smithsonian Astrophysical Observation", "SAO 230641"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.13279206),
        dec: Angle.Degrees(-43.57675905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46742"},
        {"Hipparcos Number", "HIP 31221"},
        {"Geneva Identification System", "GEN# +1.00046742"},
        {"Smithsonian Astrophysical Observation", "SAO 218009"},
        {"Wilson Evans Batten Catalogue", "WEB 6238"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.23291272),
        dec: Angle.Degrees(-43.57653022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130807"},
        {"Hipparcos Number", "HIP 72683"},
        {"Celescope Catalog", "CEL 4324"},
        {"Geneva Identification System", "GEN# +1.00130807"},
        {"Smithsonian Astrophysical Observation", "SAO 225248"},
        {"Wilson Evans Batten Catalogue", "WEB 12494"},
    },
    visualMagnitude: 4.32,
    bvColour: -0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.90968050),
        dec: Angle.Degrees(-43.57529383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217503"},
        {"Hipparcos Number", "HIP 113708"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.43767693),
        dec: Angle.Degrees(-43.57375273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173576"},
        {"Hipparcos Number", "HIP 92260"},
        {"Smithsonian Astrophysical Observation", "SAO 229290"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.03302114),
        dec: Angle.Degrees(-43.57294000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103031"},
        {"Hipparcos Number", "HIP 57839"},
        {"Smithsonian Astrophysical Observation", "SAO 223074"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.92100519),
        dec: Angle.Degrees(-43.56809363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61874",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61874"},
        {"Cincinnati Publication", "Ci 20 729"},
    },
    visualMagnitude: 12.24,
    bvColour: 1.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.19549326),
        dec: Angle.Degrees(-43.56806218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -782.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 693.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87543",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87543"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.26987858),
        dec: Angle.Degrees(-43.56704939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194327"},
        {"Hipparcos Number", "HIP 100836"},
        {"Smithsonian Astrophysical Observation", "SAO 230207"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.68490727),
        dec: Angle.Degrees(-43.56565647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140996"},
        {"Hipparcos Number", "HIP 77430"},
        {"Geneva Identification System", "GEN# +1.00140996"},
        {"Smithsonian Astrophysical Observation", "SAO 226228"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.10154810),
        dec: Angle.Degrees(-43.56407175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53680"},
        {"Hipparcos Number", "HIP 34052"},
        {"Geneva Identification System", "GEN# +1.00053680"},
        {"Smithsonian Astrophysical Observation", "SAO 218418"},
        {"Wilson Evans Batten Catalogue", "WEB 6826"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.95956909),
        dec: Angle.Degrees(-43.56229292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 401.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106631"},
        {"Hipparcos Number", "HIP 59815"},
        {"Geneva Identification System", "GEN# +1.00106631"},
        {"Renson", "Renson 30860"},
        {"Smithsonian Astrophysical Observation", "SAO 223315"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.99094148),
        dec: Angle.Degrees(-43.56170299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152335"},
        {"Hipparcos Number", "HIP 82740"},
        {"Smithsonian Astrophysical Observation", "SAO 227404"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.67395541),
        dec: Angle.Degrees(-43.56002337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39917"},
        {"Hipparcos Number", "HIP 27843"},
        {"Geneva Identification System", "GEN# +1.00039917"},
        {"Smithsonian Astrophysical Observation", "SAO 217600"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.36402997),
        dec: Angle.Degrees(-43.55856497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98779"},
        {"Hipparcos Number", "HIP 55474"},
        {"Smithsonian Astrophysical Observation", "SAO 222738"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.40731367),
        dec: Angle.Degrees(-43.55768645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130073"},
        {"Hipparcos Number", "HIP 72338"},
        {"Geneva Identification System", "GEN# +1.00130073"},
        {"Smithsonian Astrophysical Observation", "SAO 225183"},
        {"Wilson Evans Batten Catalogue", "WEB 12439"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.88377435),
        dec: Angle.Degrees(-43.55677516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14007"},
        {"Hipparcos Number", "HIP 10471"},
        {"Smithsonian Astrophysical Observation", "SAO 215836"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.74755634),
        dec: Angle.Degrees(-43.55489223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127879"},
        {"Hipparcos Number", "HIP 71321"},
        {"Geneva Identification System", "GEN# +1.00127879"},
        {"Smithsonian Astrophysical Observation", "SAO 225038"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.77236913),
        dec: Angle.Degrees(-43.55447649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100132"},
        {"Hipparcos Number", "HIP 56190"},
        {"Smithsonian Astrophysical Observation", "SAO 222833"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.77023701),
        dec: Angle.Degrees(-43.55313641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158200"},
        {"Hipparcos Number", "HIP 85633"},
        {"Smithsonian Astrophysical Observation", "SAO 228033"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.49712108),
        dec: Angle.Degrees(-43.55207130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71272",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71272"},
    },
    visualMagnitude: 10.74,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.63988976),
        dec: Angle.Degrees(-43.55143801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -186.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 151.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172486"},
        {"Hipparcos Number", "HIP 91749"},
        {"Smithsonian Astrophysical Observation", "SAO 229218"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.64244894),
        dec: Angle.Degrees(-43.55058255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90033"},
        {"Hipparcos Number", "HIP 50817"},
        {"Smithsonian Astrophysical Observation", "SAO 222002"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.62674534),
        dec: Angle.Degrees(-43.54810096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213413"},
        {"Hipparcos Number", "HIP 111219"},
        {"Geneva Identification System", "GEN# +1.00213413"},
        {"Smithsonian Astrophysical Observation", "SAO 231186"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.99332910),
        dec: Angle.Degrees(-43.54790473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126996"},
        {"Hipparcos Number", "HIP 70919"},
        {"Smithsonian Astrophysical Observation", "SAO 224971"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.54321142),
        dec: Angle.Degrees(-43.54691337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86034"},
        {"Hipparcos Number", "HIP 48611"},
        {"Geneva Identification System", "GEN# +1.00086034"},
        {"Smithsonian Astrophysical Observation", "SAO 221598"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.70224113),
        dec: Angle.Degrees(-43.54674734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173490"},
        {"Hipparcos Number", "HIP 92209"},
        {"Smithsonian Astrophysical Observation", "SAO 229281"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.89062917),
        dec: Angle.Degrees(-43.54633396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94377"},
        {"Hipparcos Number", "HIP 53214"},
        {"Geneva Identification System", "GEN# +1.00094377"},
        {"Smithsonian Astrophysical Observation", "SAO 222399"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.26226177),
        dec: Angle.Degrees(-43.54432311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9835"},
        {"Hipparcos Number", "HIP 7380"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.77576282),
        dec: Angle.Degrees(-43.54424989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96238"},
        {"Hipparcos Number", "HIP 54201"},
        {"Geneva Identification System", "GEN# +1.00096238"},
        {"Smithsonian Astrophysical Observation", "SAO 222551"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.32346107),
        dec: Angle.Degrees(-43.54251801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119758"},
        {"Hipparcos Number", "HIP 67175"},
        {"Geneva Identification System", "GEN# +1.00119758"},
        {"Smithsonian Astrophysical Observation", "SAO 224404"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.49734779),
        dec: Angle.Degrees(-43.53855446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109061"},
        {"Hipparcos Number", "HIP 61175"},
        {"Geneva Identification System", "GEN# +1.00109061"},
        {"Smithsonian Astrophysical Observation", "SAO 223495"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.02284451),
        dec: Angle.Degrees(-43.53611004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24281"},
        {"Hipparcos Number", "HIP 17933"},
        {"Geneva Identification System", "GEN# +1.00024281"},
        {"Smithsonian Astrophysical Observation", "SAO 216512"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.52439457),
        dec: Angle.Degrees(-43.53427845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35158"},
        {"Hipparcos Number", "HIP 24943"},
        {"Geneva Identification System", "GEN# +1.00035158"},
        {"Smithsonian Astrophysical Observation", "SAO 217292"},
        {"Wilson Evans Batten Catalogue", "WEB 4831"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.15388044),
        dec: Angle.Degrees(-43.53404958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31126",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31126"},
        {"Geneva Identification System", "GEN# -0.04302523"},
    },
    visualMagnitude: 10.58,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.96390120),
        dec: Angle.Degrees(-43.53397277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -275.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57222",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57222"},
        {"Smithsonian Astrophysical Observation", "SAO 222984"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.00233755),
        dec: Angle.Degrees(-43.53370271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73528"},
        {"Hipparcos Number", "HIP 42266"},
        {"Smithsonian Astrophysical Observation", "SAO 220190"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.27996058),
        dec: Angle.Degrees(-43.53318111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76282"},
        {"Hipparcos Number", "HIP 43656"},
        {"Celescope Catalog", "CEL 3045"},
        {"Geneva Identification System", "GEN# +1.00076282"},
        {"Smithsonian Astrophysical Observation", "SAO 220624"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.40362059),
        dec: Angle.Degrees(-43.53292212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68270"},
        {"Hipparcos Number", "HIP 39979"},
        {"Geneva Identification System", "GEN# +1.00068270"},
        {"Smithsonian Astrophysical Observation", "SAO 219514"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.46739752),
        dec: Angle.Degrees(-43.52838831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15714",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15714"},
        {"Smithsonian Astrophysical Observation", "SAO 216283"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.60221068),
        dec: Angle.Degrees(-43.52625178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100853"},
        {"Hipparcos Number", "HIP 56596"},
        {"Smithsonian Astrophysical Observation", "SAO 222899"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.05436035),
        dec: Angle.Degrees(-43.52559215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29220"},
        {"Hipparcos Number", "HIP 21284"},
        {"Geneva Identification System", "GEN# +1.00029220"},
        {"Smithsonian Astrophysical Observation", "SAO 216876"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.50487356),
        dec: Angle.Degrees(-43.52451760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169504"},
        {"Hipparcos Number", "HIP 90430"},
        {"Smithsonian Astrophysical Observation", "SAO 229028"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.76674871),
        dec: Angle.Degrees(-43.52406192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92137"},
        {"Hipparcos Number", "HIP 51998"},
        {"Geneva Identification System", "GEN# +1.00092137"},
        {"Smithsonian Astrophysical Observation", "SAO 222200"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.34685305),
        dec: Angle.Degrees(-43.52339863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 620"},
        {"Hipparcos Number", "HIP 845"},
        {"Geneva Identification System", "GEN# +1.00000620"},
        {"Smithsonian Astrophysical Observation", "SAO 214990"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.59487992),
        dec: Angle.Degrees(-43.52292038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200553"},
        {"Hipparcos Number", "HIP 104112"},
        {"Geneva Identification System", "GEN# +1.00200553"},
        {"Smithsonian Astrophysical Observation", "SAO 230516"},
        {"Wilson Evans Batten Catalogue", "WEB 18962"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.38410575),
        dec: Angle.Degrees(-43.52186672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218227"},
        {"Hipparcos Number", "HIP 114131"},
        {"Geneva Identification System", "GEN# +1.00218227J"},
        {"Renson", "Renson 60120"},
        {"Smithsonian Astrophysical Observation", "SAO 231444"},
        {"Wilson Evans Batten Catalogue", "WEB 20266"},
    },
    visualMagnitude: 4.28,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.71986858),
        dec: Angle.Degrees(-43.52032436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13336"},
        {"Hipparcos Number", "HIP 10035"},
        {"Geneva Identification System", "GEN# +1.00013336"},
        {"Smithsonian Astrophysical Observation", "SAO 215785"},
    },
    visualMagnitude: 5.84,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.28888091),
        dec: Angle.Degrees(-43.51647088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83849"},
        {"Hipparcos Number", "HIP 47432"},
        {"Geneva Identification System", "GEN# +1.00083849"},
        {"Smithsonian Astrophysical Observation", "SAO 221388"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.97269384),
        dec: Angle.Degrees(-43.51053050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22987"},
        {"Hipparcos Number", "HIP 17087"},
        {"Smithsonian Astrophysical Observation", "SAO 216429"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.90975748),
        dec: Angle.Degrees(-43.51006451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38243"},
        {"Hipparcos Number", "HIP 26859"},
        {"Smithsonian Astrophysical Observation", "SAO 217482"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.53671420),
        dec: Angle.Degrees(-43.50837798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12808"},
        {"Hipparcos Number", "HIP 9672"},
        {"Geneva Identification System", "GEN# +1.00012808"},
        {"Smithsonian Astrophysical Observation", "SAO 215758"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.10223300),
        dec: Angle.Degrees(-43.50767782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170521"},
        {"Hipparcos Number", "HIP 90842"},
        {"Geneva Identification System", "GEN# +1.00170521"},
        {"Smithsonian Astrophysical Observation", "SAO 229094"},
    },
    visualMagnitude: 5.71,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.98426606),
        dec: Angle.Degrees(-43.50736445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36476"},
        {"Hipparcos Number", "HIP 25741"},
        {"Geneva Identification System", "GEN# +1.00036476"},
        {"Smithsonian Astrophysical Observation", "SAO 217363"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.44576318),
        dec: Angle.Degrees(-43.50732420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204437"},
        {"Hipparcos Number", "HIP 106128"},
        {"Fundamental Katalog 5th Edition", "FK5 5894"},
        {"Geneva Identification System", "GEN# +1.00204437"},
        {"Smithsonian Astrophysical Observation", "SAO 230713"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.46428733),
        dec: Angle.Degrees(-43.50731540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199592"},
        {"Hipparcos Number", "HIP 103625"},
        {"Smithsonian Astrophysical Observation", "SAO 230470"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.93396285),
        dec: Angle.Degrees(-43.50723346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32626"},
        {"Hipparcos Number", "HIP 23450"},
        {"Smithsonian Astrophysical Observation", "SAO 217132"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.61132992),
        dec: Angle.Degrees(-43.50692065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139523"},
        {"Hipparcos Number", "HIP 76749"},
        {"Geneva Identification System", "GEN# +1.00139523"},
        {"Smithsonian Astrophysical Observation", "SAO 226046"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.08264480),
        dec: Angle.Degrees(-43.50630611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218205"},
        {"Hipparcos Number", "HIP 114112"},
        {"Geneva Identification System", "GEN# +1.00218205"},
        {"Smithsonian Astrophysical Observation", "SAO 231443"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.66332438),
        dec: Angle.Degrees(-43.50367960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211768"},
        {"Hipparcos Number", "HIP 110289"},
        {"Smithsonian Astrophysical Observation", "SAO 231086"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.09588531),
        dec: Angle.Degrees(-43.50265440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172160"},
        {"Hipparcos Number", "HIP 91592"},
        {"Smithsonian Astrophysical Observation", "SAO 229187"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.19052392),
        dec: Angle.Degrees(-43.50255012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85512"},
        {"Hipparcos Number", "HIP 48331"},
        {"Cincinnati Publication", "Ci 20 551"},
        {"Geneva Identification System", "GEN# +1.00085512"},
        {"Smithsonian Astrophysical Observation", "SAO 221544"},
        {"Wilson Evans Batten Catalogue", "WEB 9014"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.77783557),
        dec: Angle.Degrees(-43.50163788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 461.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -472.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95285"},
        {"Hipparcos Number", "HIP 53729"},
        {"Smithsonian Astrophysical Observation", "SAO 222478"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.89266424),
        dec: Angle.Degrees(-43.50162091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52757"},
        {"Hipparcos Number", "HIP 33725"},
        {"Smithsonian Astrophysical Observation", "SAO 218378"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.09534919),
        dec: Angle.Degrees(-43.50061892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65460"},
        {"Hipparcos Number", "HIP 38846"},
        {"Celescope Catalog", "CEL 2110"},
        {"Geneva Identification System", "GEN# +1.00065460"},
        {"Smithsonian Astrophysical Observation", "SAO 219189"},
        {"Wilson Evans Batten Catalogue", "WEB 7607"},
    },
    visualMagnitude: 5.36,
    bvColour: -0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.24087180),
        dec: Angle.Degrees(-43.50042396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76380"},
        {"Hipparcos Number", "HIP 43717"},
        {"Geneva Identification System", "GEN# +1.00076380"},
        {"Smithsonian Astrophysical Observation", "SAO 220642"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.55321391),
        dec: Angle.Degrees(-43.49897450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139366"},
        {"Hipparcos Number", "HIP 76671"},
        {"Geneva Identification System", "GEN# +1.00139366"},
        {"Smithsonian Astrophysical Observation", "SAO 226025"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.84640174),
        dec: Angle.Degrees(-43.49695390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206395"},
        {"Hipparcos Number", "HIP 107225"},
        {"Geneva Identification System", "GEN# +1.00206395"},
        {"Smithsonian Astrophysical Observation", "SAO 230807"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.75835418),
        dec: Angle.Degrees(-43.49594701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 206.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32826",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32826"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.64920409),
        dec: Angle.Degrees(-43.49588063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213009"},
        {"Hipparcos Number", "HIP 110997"},
        {"Fundamental Katalog 5th Edition", "FK5 846"},
        {"Geneva Identification System", "GEN# +1.00213009J"},
        {"Smithsonian Astrophysical Observation", "SAO 231154"},
        {"Wilson Evans Batten Catalogue", "WEB 19875"},
    },
    visualMagnitude: 3.97,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.31730866),
        dec: Angle.Degrees(-43.49555433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155221"},
        {"Hipparcos Number", "HIP 84152"},
        {"Geneva Identification System", "GEN# +1.00155221"},
        {"Smithsonian Astrophysical Observation", "SAO 227710"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.07378690),
        dec: Angle.Degrees(-43.49446077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161312"},
        {"Hipparcos Number", "HIP 87033"},
        {"Celescope Catalog", "CEL 4565"},
        {"Geneva Identification System", "GEN# +1.00161312"},
        {"Smithsonian Astrophysical Observation", "SAO 228409"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.74118289),
        dec: Angle.Degrees(-43.49345499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78429"},
        {"Hipparcos Number", "HIP 44713"},
        {"Geneva Identification System", "GEN# +1.00078429"},
        {"Smithsonian Astrophysical Observation", "SAO 220859"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.66163258),
        dec: Angle.Degrees(-43.49241324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 179.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57664"},
        {"Hipparcos Number", "HIP 35554"},
        {"Smithsonian Astrophysical Observation", "SAO 218649"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.04574807),
        dec: Angle.Degrees(-43.49148704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167486"},
        {"Hipparcos Number", "HIP 89635"},
        {"Smithsonian Astrophysical Observation", "SAO 228875"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.38877398),
        dec: Angle.Degrees(-43.49132722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33837"},
        {"Hipparcos Number", "HIP 24128"},
        {"Smithsonian Astrophysical Observation", "SAO 217222"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.74056684),
        dec: Angle.Degrees(-43.49047501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87029",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87029"},
        {"Smithsonian Astrophysical Observation", "SAO 228406"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.73845884),
        dec: Angle.Degrees(-43.49001650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155019"},
        {"Hipparcos Number", "HIP 84057"},
        {"Smithsonian Astrophysical Observation", "SAO 227692"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.77130546),
        dec: Angle.Degrees(-43.48958244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189515"},
        {"Hipparcos Number", "HIP 98654"},
        {"Smithsonian Astrophysical Observation", "SAO 230001"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.56803588),
        dec: Angle.Degrees(-43.48854463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109638"},
        {"Hipparcos Number", "HIP 61536"},
        {"Smithsonian Astrophysical Observation", "SAO 223549"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.10826593),
        dec: Angle.Degrees(-43.48845853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125566"},
        {"Hipparcos Number", "HIP 70163"},
        {"Geneva Identification System", "GEN# +1.00125566"},
        {"Smithsonian Astrophysical Observation", "SAO 224855"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.33344737),
        dec: Angle.Degrees(-43.48844115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -272.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35210"},
        {"Hipparcos Number", "HIP 24981"},
        {"Smithsonian Astrophysical Observation", "SAO 217296"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.23966234),
        dec: Angle.Degrees(-43.48806251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135348"},
        {"Hipparcos Number", "HIP 74716"},
        {"Celescope Catalog", "CEL 4358"},
        {"Geneva Identification System", "GEN# +1.00135348"},
        {"Smithsonian Astrophysical Observation", "SAO 225602"},
        {"Wilson Evans Batten Catalogue", "WEB 12747"},
    },
    visualMagnitude: 6.05,
    bvColour: -0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.04361495),
        dec: Angle.Degrees(-43.48497791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168215"},
        {"Hipparcos Number", "HIP 89907"},
        {"Geneva Identification System", "GEN# +1.00168215"},
        {"Smithsonian Astrophysical Observation", "SAO 228934"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.18879572),
        dec: Angle.Degrees(-43.48456692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171546"},
        {"Hipparcos Number", "HIP 91309"},
        {"Smithsonian Astrophysical Observation", "SAO 229151"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.37668444),
        dec: Angle.Degrees(-43.48387972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85209"},
        {"Hipparcos Number", "HIP 48172"},
        {"Geneva Identification System", "GEN# +1.00085209J"},
        {"Smithsonian Astrophysical Observation", "SAO 221512"},
    },
    visualMagnitude: 6.53,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.28724187),
        dec: Angle.Degrees(-43.48286580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136208"},
        {"Hipparcos Number", "HIP 75111"},
        {"Smithsonian Astrophysical Observation", "SAO 225683"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.23203274),
        dec: Angle.Degrees(-43.48177912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27646"},
        {"Hipparcos Number", "HIP 20193"},
        {"Smithsonian Astrophysical Observation", "SAO 216752"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.92363478),
        dec: Angle.Degrees(-43.47967234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110428"},
        {"Hipparcos Number", "HIP 61999"},
        {"Smithsonian Astrophysical Observation", "SAO 223611"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.58678992),
        dec: Angle.Degrees(-43.47966390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208812"},
        {"Hipparcos Number", "HIP 108589"},
        {"Geneva Identification System", "GEN# +1.00208812"},
        {"Smithsonian Astrophysical Observation", "SAO 230927"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.96232517),
        dec: Angle.Degrees(-43.47939741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99854"},
        {"Hipparcos Number", "HIP 56024"},
        {"Smithsonian Astrophysical Observation", "SAO 222815"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.23168154),
        dec: Angle.Degrees(-43.47924618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6505"},
        {"Hipparcos Number", "HIP 5109"},
        {"Smithsonian Astrophysical Observation", "SAO 215357"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.37395293),
        dec: Angle.Degrees(-43.47776943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142510"},
        {"Hipparcos Number", "HIP 78090"},
        {"Smithsonian Astrophysical Observation", "SAO 226388"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.17359905),
        dec: Angle.Degrees(-43.47712690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197414"},
        {"Hipparcos Number", "HIP 102403"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.27494087),
        dec: Angle.Degrees(-43.47571317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191305"},
        {"Hipparcos Number", "HIP 99448"},
        {"Geneva Identification System", "GEN# +1.00191305"},
        {"Smithsonian Astrophysical Observation", "SAO 230087"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.76970896),
        dec: Angle.Degrees(-43.47441389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214094"},
        {"Hipparcos Number", "HIP 111616"},
        {"Geneva Identification System", "GEN# +1.00214094"},
        {"Smithsonian Astrophysical Observation", "SAO 231214"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.17673400),
        dec: Angle.Degrees(-43.47095942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 269.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123445"},
        {"Henry Draper 2", "HD 123445A"},
        {"Hipparcos Number", "HIP 69113"},
        {"Geneva Identification System", "GEN# +1.00123445A"},
        {"Smithsonian Astrophysical Observation", "SAO 224721"},
        {"Wilson Evans Batten Catalogue", "WEB 12067"},
    },
    visualMagnitude: 6.19,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.21625960),
        dec: Angle.Degrees(-43.47073642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182820"},
        {"Hipparcos Number", "HIP 95741"},
        {"Smithsonian Astrophysical Observation", "SAO 229701"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.10635199),
        dec: Angle.Degrees(-43.46878334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93616"},
        {"Hipparcos Number", "HIP 52811"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.95013182),
        dec: Angle.Degrees(-43.46730829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76534"},
        {"Hipparcos Number", "HIP 43792"},
        {"Celescope Catalog", "CEL 3078"},
        {"Geneva Identification System", "GEN# +1.00076534"},
        {"Smithsonian Astrophysical Observation", "SAO 220660"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.78630155),
        dec: Angle.Degrees(-43.46664456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79810"},
        {"Hipparcos Number", "HIP 45367"},
        {"Geneva Identification System", "GEN# +1.00079810"},
        {"Smithsonian Astrophysical Observation", "SAO 220987"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.68223777),
        dec: Angle.Degrees(-43.46491168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58656"},
        {"Hipparcos Number", "HIP 35939"},
        {"Geneva Identification System", "GEN# +1.00058656"},
        {"Smithsonian Astrophysical Observation", "SAO 218703"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.13042464),
        dec: Angle.Degrees(-43.46445905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184001"},
        {"Hipparcos Number", "HIP 96232"},
        {"Smithsonian Astrophysical Observation", "SAO 229745"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.52788173),
        dec: Angle.Degrees(-43.46427462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71040"},
        {"Hipparcos Number", "HIP 41126"},
        {"Smithsonian Astrophysical Observation", "SAO 219867"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.87060690),
        dec: Angle.Degrees(-43.46409371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164409"},
        {"Hipparcos Number", "HIP 88398"},
        {"Smithsonian Astrophysical Observation", "SAO 228653"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.76083123),
        dec: Angle.Degrees(-43.46278188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97292"},
        {"Hipparcos Number", "HIP 54671"},
        {"Geneva Identification System", "GEN# +1.00097292"},
        {"Smithsonian Astrophysical Observation", "SAO 222627"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.86463939),
        dec: Angle.Degrees(-43.45985253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138565"},
        {"Hipparcos Number", "HIP 76252"},
        {"Celescope Catalog", "CEL 4379"},
        {"Geneva Identification System", "GEN# +1.00138565J"},
        {"Smithsonian Astrophysical Observation", "SAO 225916"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.63783840),
        dec: Angle.Degrees(-43.45953686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5685"},
        {"Hipparcos Number", "HIP 4528"},
        {"Geneva Identification System", "GEN# +1.00005685"},
        {"Smithsonian Astrophysical Observation", "SAO 215303"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.49500287),
        dec: Angle.Degrees(-43.45887244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140976"},
        {"Hipparcos Number", "HIP 77417"},
        {"Geneva Identification System", "GEN# +1.00140976"},
        {"Smithsonian Astrophysical Observation", "SAO 226224"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.07975016),
        dec: Angle.Degrees(-43.45854005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148290"},
        {"Hipparcos Number", "HIP 80731"},
        {"Geneva Identification System", "GEN# +1.00148290"},
        {"Smithsonian Astrophysical Observation", "SAO 226803"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.23288980),
        dec: Angle.Degrees(-43.45832123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111913"},
        {"Hipparcos Number", "HIP 62863"},
        {"Smithsonian Astrophysical Observation", "SAO 223732"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.27074532),
        dec: Angle.Degrees(-43.45661357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28057"},
        {"Hipparcos Number", "HIP 20514"},
        {"Geneva Identification System", "GEN# +1.00028057"},
        {"Smithsonian Astrophysical Observation", "SAO 216775"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.93591918),
        dec: Angle.Degrees(-43.45648315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131703"},
        {"Hipparcos Number", "HIP 73117"},
        {"Smithsonian Astrophysical Observation", "SAO 225310"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.15090615),
        dec: Angle.Degrees(-43.45609871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187417"},
        {"Hipparcos Number", "HIP 97731"},
        {"Smithsonian Astrophysical Observation", "SAO 229898"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.91524753),
        dec: Angle.Degrees(-43.45604721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78039"},
        {"Hipparcos Number", "HIP 44549"},
        {"Geneva Identification System", "GEN# +1.00078039"},
        {"Smithsonian Astrophysical Observation", "SAO 220808"},
        {"Wilson Evans Batten Catalogue", "WEB 8530"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.15096211),
        dec: Angle.Degrees(-43.45402611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77113"},
        {"Hipparcos Number", "HIP 44094"},
        {"Geneva Identification System", "GEN# +1.00077113"},
        {"Renson", "Renson 21740"},
        {"Smithsonian Astrophysical Observation", "SAO 220712"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.71861273),
        dec: Angle.Degrees(-43.45293224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132822"},
        {"Hipparcos Number", "HIP 73597"},
        {"Smithsonian Astrophysical Observation", "SAO 225396"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.65281121),
        dec: Angle.Degrees(-43.45282739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47601"},
        {"Hipparcos Number", "HIP 31642"},
        {"Celescope Catalog", "CEL 1330"},
        {"Geneva Identification System", "GEN# +1.00047601"},
        {"Smithsonian Astrophysical Observation", "SAO 218064"},
        {"Wilson Evans Batten Catalogue", "WEB 6336"},
    },
    visualMagnitude: 6.87,
    bvColour: -0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.33323752),
        dec: Angle.Degrees(-43.45131610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29471"},
        {"Hipparcos Number", "HIP 21451"},
        {"Smithsonian Astrophysical Observation", "SAO 216892"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.10017467),
        dec: Angle.Degrees(-43.45094558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223123"},
        {"Hipparcos Number", "HIP 117296"},
        {"Smithsonian Astrophysical Observation", "SAO 231779"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.74897233),
        dec: Angle.Degrees(-43.44996994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221884"},
        {"Hipparcos Number", "HIP 116473"},
        {"Smithsonian Astrophysical Observation", "SAO 231682"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.00495002),
        dec: Angle.Degrees(-43.44787806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195659"},
        {"Hipparcos Number", "HIP 101515"},
        {"Smithsonian Astrophysical Observation", "SAO 230279"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.56872802),
        dec: Angle.Degrees(-43.44765089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5564",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5564"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.84317175),
        dec: Angle.Degrees(-43.44681962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -359.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81095"},
        {"Hipparcos Number", "HIP 45951"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.57419425),
        dec: Angle.Degrees(-43.44652721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215818"},
        {"Hipparcos Number", "HIP 112616"},
        {"Geneva Identification System", "GEN# +1.00215818"},
        {"Smithsonian Astrophysical Observation", "SAO 231307"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.12606961),
        dec: Angle.Degrees(-43.44639954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128740"},
        {"Hipparcos Number", "HIP 71694"},
        {"Smithsonian Astrophysical Observation", "SAO 225099"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.99166905),
        dec: Angle.Degrees(-43.44605936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206423"},
        {"Hipparcos Number", "HIP 107240"},
        {"Smithsonian Astrophysical Observation", "SAO 230809"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.81427161),
        dec: Angle.Degrees(-43.44546474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183007"},
        {"Hipparcos Number", "HIP 95823"},
        {"Geneva Identification System", "GEN# +1.00183007"},
        {"Renson", "Renson 50590"},
        {"Smithsonian Astrophysical Observation", "SAO 229712"},
        {"Wilson Evans Batten Catalogue", "WEB 16774"},
    },
    visualMagnitude: 5.70,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.34904557),
        dec: Angle.Degrees(-43.44491571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166348"},
        {"Hipparcos Number", "HIP 89211"},
        {"Cincinnati Publication", "Ci 20 1077"},
        {"Geneva Identification System", "GEN# +1.00166348"},
        {"Smithsonian Astrophysical Observation", "SAO 228799"},
        {"Wilson Evans Batten Catalogue", "WEB 15158"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.08868810),
        dec: Angle.Degrees(-43.44383347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -418.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161515"},
        {"Hipparcos Number", "HIP 87125"},
        {"Geneva Identification System", "GEN# +1.00161515"},
        {"Smithsonian Astrophysical Observation", "SAO 228425"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.00677561),
        dec: Angle.Degrees(-43.44334620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143572"},
        {"Hipparcos Number", "HIP 78607"},
        {"Geneva Identification System", "GEN# +1.00143572"},
        {"Smithsonian Astrophysical Observation", "SAO 226464"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.73332322),
        dec: Angle.Degrees(-43.44150890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119430"},
        {"Hipparcos Number", "HIP 67024"},
        {"Geneva Identification System", "GEN# +1.00119430"},
        {"Smithsonian Astrophysical Observation", "SAO 224377"},
    },
    visualMagnitude: 7.09,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.03656645),
        dec: Angle.Degrees(-43.44125571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112329"},
        {"Hipparcos Number", "HIP 63148"},
        {"Smithsonian Astrophysical Observation", "SAO 223768"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.08884850),
        dec: Angle.Degrees(-43.44121870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38032",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38032"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.91018966),
        dec: Angle.Degrees(-43.44042191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104007"},
        {"Hipparcos Number", "HIP 58409"},
        {"Geneva Identification System", "GEN# +1.00104007"},
        {"Smithsonian Astrophysical Observation", "SAO 223143"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.64642439),
        dec: Angle.Degrees(-43.43762428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115838"},
        {"Hipparcos Number", "HIP 65099"},
        {"Smithsonian Astrophysical Observation", "SAO 224074"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.12583405),
        dec: Angle.Degrees(-43.43544994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138011"},
        {"Hipparcos Number", "HIP 75977"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.74188678),
        dec: Angle.Degrees(-43.43488230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29076"},
        {"Hipparcos Number", "HIP 21191"},
        {"Smithsonian Astrophysical Observation", "SAO 216866"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.15444583),
        dec: Angle.Degrees(-43.43419368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173861"},
        {"Hipparcos Number", "HIP 92382"},
        {"Geneva Identification System", "GEN# +1.00173861"},
        {"Renson", "Renson 48720"},
        {"Smithsonian Astrophysical Observation", "SAO 229307"},
        {"Wilson Evans Batten Catalogue", "WEB 15952"},
    },
    visualMagnitude: 5.60,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.39582542),
        dec: Angle.Degrees(-43.43404010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47389",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47389"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.82954149),
        dec: Angle.Degrees(-43.43335567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205679"},
        {"Hipparcos Number", "HIP 106827"},
        {"Smithsonian Astrophysical Observation", "SAO 230766"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.54469590),
        dec: Angle.Degrees(-43.43316708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44816",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Suhail"},
        {"Henry Draper", "HD 78647"},
        {"Hipparcos Number", "HIP 44816"},
        {"Fundamental Katalog 5th Edition", "FK5 345"},
        {"Geneva Identification System", "GEN# +1.00078647"},
        {"Smithsonian Astrophysical Observation", "SAO 220878"},
        {"Wilson Evans Batten Catalogue", "WEB 8567"},
    },
    visualMagnitude: 2.23,
    bvColour: 1.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.99907126),
        dec: Angle.Degrees(-43.43262406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79860"},
        {"Hipparcos Number", "HIP 45399"},
        {"Smithsonian Astrophysical Observation", "SAO 220991"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.77609558),
        dec: Angle.Degrees(-43.43260195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31790"},
        {"Hipparcos Number", "HIP 22971"},
        {"Smithsonian Astrophysical Observation", "SAO 217069"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.14527937),
        dec: Angle.Degrees(-43.43248819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207443"},
        {"Hipparcos Number", "HIP 107785"},
        {"Geneva Identification System", "GEN# +1.00207443"},
        {"Smithsonian Astrophysical Observation", "SAO 230861"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.53188693),
        dec: Angle.Degrees(-43.43086614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48069"},
        {"Hipparcos Number", "HIP 31841"},
        {"Fundamental Katalog 5th Edition", "FK5 4606"},
        {"Geneva Identification System", "GEN# +1.00048069"},
        {"Smithsonian Astrophysical Observation", "SAO 218102"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.86153260),
        dec: Angle.Degrees(-43.42727326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105735"},
        {"Hipparcos Number", "HIP 59329"},
        {"Smithsonian Astrophysical Observation", "SAO 223257"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.56567143),
        dec: Angle.Degrees(-43.42659726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88726",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88726"},
        {"Smithsonian Astrophysical Observation", "SAO 228708"},
    },
    visualMagnitude: 4.92,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.70785224),
        dec: Angle.Degrees(-43.42496169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109946"},
        {"Hipparcos Number", "HIP 61717"},
        {"Renson", "Renson 31910"},
        {"Smithsonian Astrophysical Observation", "SAO 223571"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.75648426),
        dec: Angle.Degrees(-43.42367568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117807"},
        {"Hipparcos Number", "HIP 66139"},
        {"Geneva Identification System", "GEN# +1.00117807"},
        {"Smithsonian Astrophysical Observation", "SAO 224243"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.37290622),
        dec: Angle.Degrees(-43.42273414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76357"},
        {"Hipparcos Number", "HIP 43711"},
        {"Geneva Identification System", "GEN# +1.00076357"},
        {"Smithsonian Astrophysical Observation", "SAO 220640"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.52763876),
        dec: Angle.Degrees(-43.42098088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98095"},
        {"Hipparcos Number", "HIP 55079"},
        {"Smithsonian Astrophysical Observation", "SAO 222688"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.14450311),
        dec: Angle.Degrees(-43.41909864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161413"},
        {"Hipparcos Number", "HIP 87066"},
        {"Geneva Identification System", "GEN# +1.00161413"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.87794342),
        dec: Angle.Degrees(-43.41771056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28813"},
        {"Hipparcos Number", "HIP 21024"},
        {"Smithsonian Astrophysical Observation", "SAO 216844"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.62306511),
        dec: Angle.Degrees(-43.41066598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71609"},
        {"Hipparcos Number", "HIP 41388"},
        {"Celescope Catalog", "CEL 2513"},
        {"Geneva Identification System", "GEN# +1.00071609"},
        {"Smithsonian Astrophysical Observation", "SAO 219923"},
        {"Wilson Evans Batten Catalogue", "WEB 8004"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.65900379),
        dec: Angle.Degrees(-43.40860949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126372"},
        {"Hipparcos Number", "HIP 70581"},
        {"Smithsonian Astrophysical Observation", "SAO 224922"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.55885329),
        dec: Angle.Degrees(-43.40783672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212086"},
        {"Hipparcos Number", "HIP 110469"},
        {"Smithsonian Astrophysical Observation", "SAO 231103"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.65072344),
        dec: Angle.Degrees(-43.40752729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20607"},
        {"Hipparcos Number", "HIP 15293"},
        {"Smithsonian Astrophysical Observation", "SAO 216245"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.32876884),
        dec: Angle.Degrees(-43.40732803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212208"},
        {"Hipparcos Number", "HIP 110519"},
        {"Smithsonian Astrophysical Observation", "SAO 231117"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.85184372),
        dec: Angle.Degrees(-43.40647190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87962",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87962"},
    },
    visualMagnitude: 11.29,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.52659905),
        dec: Angle.Degrees(-43.40611661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45346"},
        {"Hipparcos Number", "HIP 30502"},
        {"Geneva Identification System", "GEN# +1.00045346"},
        {"Smithsonian Astrophysical Observation", "SAO 217912"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.18232056),
        dec: Angle.Degrees(-43.40587683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212165"},
        {"Hipparcos Number", "HIP 110502"},
        {"Geneva Identification System", "GEN# +1.00212165"},
        {"Smithsonian Astrophysical Observation", "SAO 231112"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.77716167),
        dec: Angle.Degrees(-43.40570356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53253"},
        {"Hipparcos Number", "HIP 33909"},
        {"Celescope Catalog", "CEL 1529"},
        {"Geneva Identification System", "GEN# +1.00053253"},
        {"Smithsonian Astrophysical Observation", "SAO 218396"},
    },
    visualMagnitude: 6.44,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.56449056),
        dec: Angle.Degrees(-43.40386918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90559"},
        {"Hipparcos Number", "HIP 51102"},
        {"Geneva Identification System", "GEN# +1.00090559J"},
        {"Smithsonian Astrophysical Observation", "SAO 222052"},
        {"Wilson Evans Batten Catalogue", "WEB 9342"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.60464381),
        dec: Angle.Degrees(-43.40371706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46831",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46831"},
    },
    visualMagnitude: 11.41,
    bvColour: 1.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.14017555),
        dec: Angle.Degrees(-43.40311181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48150"},
        {"Hipparcos Number", "HIP 31875"},
        {"Celescope Catalog", "CEL 1349"},
        {"Geneva Identification System", "GEN# +1.00048150"},
        {"Smithsonian Astrophysical Observation", "SAO 218109"},
    },
    visualMagnitude: 7.40,
    bvColour: -0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.94509152),
        dec: Angle.Degrees(-43.40292086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122632"},
        {"Hipparcos Number", "HIP 68725"},
        {"Smithsonian Astrophysical Observation", "SAO 224649"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.02446231),
        dec: Angle.Degrees(-43.40265410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55399"},
        {"Hipparcos Number", "HIP 34658"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.66493268),
        dec: Angle.Degrees(-43.40090139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68763"},
        {"Hipparcos Number", "HIP 40160"},
        {"Geneva Identification System", "GEN# +1.00068763"},
        {"Smithsonian Astrophysical Observation", "SAO 219586"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.02525761),
        dec: Angle.Degrees(-43.40045038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203131"},
        {"Hipparcos Number", "HIP 105470"},
        {"Smithsonian Astrophysical Observation", "SAO 230652"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.44426786),
        dec: Angle.Degrees(-43.40028731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149711"},
        {"Hipparcos Number", "HIP 81472"},
        {"Celescope Catalog", "CEL 4421"},
        {"Geneva Identification System", "GEN# +1.00149711J"},
        {"Smithsonian Astrophysical Observation", "SAO 226989"},
        {"Wilson Evans Batten Catalogue", "WEB 13766"},
    },
    visualMagnitude: 5.83,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.60958867),
        dec: Angle.Degrees(-43.39837584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104547"},
        {"Hipparcos Number", "HIP 58703"},
        {"Smithsonian Astrophysical Observation", "SAO 223181"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.59943714),
        dec: Angle.Degrees(-43.39817291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37313"},
        {"Hipparcos Number", "HIP 26251"},
        {"Smithsonian Astrophysical Observation", "SAO 217414"},
    },
    visualMagnitude: 8.68,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.86820009),
        dec: Angle.Degrees(-43.39782944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4849"},
        {"Hipparcos Number", "HIP 3903"},
        {"Geneva Identification System", "GEN# +1.00004849"},
        {"Renson", "Renson 1270"},
        {"Smithsonian Astrophysical Observation", "SAO 215254"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.51565121),
        dec: Angle.Degrees(-43.39494468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63467"},
        {"Hipparcos Number", "HIP 37993"},
        {"Celescope Catalog", "CEL 2031"},
        {"Geneva Identification System", "GEN# +1.00063467J"},
        {"Smithsonian Astrophysical Observation", "SAO 218996"},
    },
    visualMagnitude: 7.58,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.79600325),
        dec: Angle.Degrees(-43.39455952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32169"},
        {"Hipparcos Number", "HIP 23164"},
        {"Geneva Identification System", "GEN# +1.00032169"},
        {"Smithsonian Astrophysical Observation", "SAO 217099"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.75120391),
        dec: Angle.Degrees(-43.39240647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165351"},
        {"Hipparcos Number", "HIP 88803"},
        {"Smithsonian Astrophysical Observation", "SAO 228719"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.91807752),
        dec: Angle.Degrees(-43.39200513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142255"},
        {"Hipparcos Number", "HIP 77964"},
        {"Smithsonian Astrophysical Observation", "SAO 226362"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.83426424),
        dec: Angle.Degrees(-43.39173101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206441"},
        {"Hipparcos Number", "HIP 107247"},
        {"Smithsonian Astrophysical Observation", "SAO 230810"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.83387412),
        dec: Angle.Degrees(-43.39134924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95387"},
        {"Hipparcos Number", "HIP 53777"},
        {"Smithsonian Astrophysical Observation", "SAO 222488"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.04861114),
        dec: Angle.Degrees(-43.38950744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114090"},
        {"Hipparcos Number", "HIP 64148"},
        {"Smithsonian Astrophysical Observation", "SAO 223930"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.20997427),
        dec: Angle.Degrees(-43.38901683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58770"},
        {"Hipparcos Number", "HIP 35993"},
        {"Smithsonian Astrophysical Observation", "SAO 218711"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.26940244),
        dec: Angle.Degrees(-43.38711914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122857"},
        {"Hipparcos Number", "HIP 68823"},
        {"Geneva Identification System", "GEN# +1.00122857"},
        {"Smithsonian Astrophysical Observation", "SAO 224665"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.35700493),
        dec: Angle.Degrees(-43.38624097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108935"},
        {"Hipparcos Number", "HIP 61097"},
        {"Geneva Identification System", "GEN# +1.00108935"},
        {"Smithsonian Astrophysical Observation", "SAO 223485"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.82520642),
        dec: Angle.Degrees(-43.38400072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -418.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -191.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29802"},
        {"Hipparcos Number", "HIP 21716"},
        {"Geneva Identification System", "GEN# +1.00029802"},
        {"Smithsonian Astrophysical Observation", "SAO 216922"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.93509900),
        dec: Angle.Degrees(-43.38371632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201317"},
        {"Hipparcos Number", "HIP 104508"},
        {"Geneva Identification System", "GEN# +1.00201317"},
        {"Smithsonian Astrophysical Observation", "SAO 230555"},
    },
    visualMagnitude: 6.56,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.54164020),
        dec: Angle.Degrees(-43.38269184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25434",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25434"},
        {"Smithsonian Astrophysical Observation", "SAO 217336"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.59563519),
        dec: Angle.Degrees(-43.37677141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35996"},
        {"Hipparcos Number", "HIP 25436"},
        {"Smithsonian Astrophysical Observation", "SAO 217337"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.60000097),
        dec: Angle.Degrees(-43.37578534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18935"},
        {"Hipparcos Number", "HIP 14064"},
        {"Smithsonian Astrophysical Observation", "SAO 216138"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.30107629),
        dec: Angle.Degrees(-43.37241588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75608"},
        {"Hipparcos Number", "HIP 43303"},
        {"Celescope Catalog", "CEL 2956"},
        {"Geneva Identification System", "GEN# +1.00075608"},
        {"Smithsonian Astrophysical Observation", "SAO 220523"},
    },
    visualMagnitude: 7.48,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.33861463),
        dec: Angle.Degrees(-43.37068161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114474"},
        {"Hipparcos Number", "HIP 64348"},
        {"Geneva Identification System", "GEN# +1.00114474"},
        {"Smithsonian Astrophysical Observation", "SAO 223966"},
        {"Wilson Evans Batten Catalogue", "WEB 11372"},
    },
    visualMagnitude: 5.24,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.84711464),
        dec: Angle.Degrees(-43.36850529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11665"},
        {"Hipparcos Number", "HIP 8828"},
        {"Smithsonian Astrophysical Observation", "SAO 215695"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.37489185),
        dec: Angle.Degrees(-43.36832477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11423"},
        {"Hipparcos Number", "HIP 8634"},
        {"Smithsonian Astrophysical Observation", "SAO 215678"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.83714726),
        dec: Angle.Degrees(-43.36776737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176724"},
        {"Hipparcos Number", "HIP 93597"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.91787351),
        dec: Angle.Degrees(-43.36768570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128033"},
        {"Hipparcos Number", "HIP 71386"},
        {"Geneva Identification System", "GEN# +1.00128033"},
        {"Wilson Evans Batten Catalogue", "WEB 12323"},
    },
    visualMagnitude: 8.20,
    bvColour: 3.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.96548423),
        dec: Angle.Degrees(-43.36740015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20223"},
        {"Hipparcos Number", "HIP 15007"},
        {"Smithsonian Astrophysical Observation", "SAO 216218"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.35699642),
        dec: Angle.Degrees(-43.36546043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39353"},
        {"Hipparcos Number", "HIP 27532"},
        {"Geneva Identification System", "GEN# +1.00039353"},
        {"Renson", "Renson 10570"},
        {"Smithsonian Astrophysical Observation", "SAO 217563"},
    },
    visualMagnitude: 7.58,
    bvColour: -0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.46303182),
        dec: Angle.Degrees(-43.36468435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122028"},
        {"Hipparcos Number", "HIP 68411"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.06081954),
        dec: Angle.Degrees(-43.36401721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126838"},
        {"Hipparcos Number", "HIP 70833"},
        {"Smithsonian Astrophysical Observation", "SAO 224958"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.27989419),
        dec: Angle.Degrees(-43.36184296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224749"},
        {"Hipparcos Number", "HIP 28"},
        {"Smithsonian Astrophysical Observation", "SAO 231890"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.08724871),
        dec: Angle.Degrees(-43.36179962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185429"},
        {"Hipparcos Number", "HIP 96832"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.22643862),
        dec: Angle.Degrees(-43.36014068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134913"},
        {"Hipparcos Number", "HIP 74542"},
        {"Geneva Identification System", "GEN# +1.00134913"},
        {"Smithsonian Astrophysical Observation", "SAO 225552"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.47660917),
        dec: Angle.Degrees(-43.35665718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84172"},
        {"Hipparcos Number", "HIP 47569"},
        {"Smithsonian Astrophysical Observation", "SAO 221409"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.49531521),
        dec: Angle.Degrees(-43.35533292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26190"},
        {"Hipparcos Number", "HIP 19192"},
        {"Smithsonian Astrophysical Observation", "SAO 216647"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.69342205),
        dec: Angle.Degrees(-43.35509738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113209"},
        {"Hipparcos Number", "HIP 63643"},
        {"Smithsonian Astrophysical Observation", "SAO 223857"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.65837381),
        dec: Angle.Degrees(-43.35481520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75364"},
        {"Hipparcos Number", "HIP 43187"},
        {"Geneva Identification System", "GEN# +1.00075364"},
        {"Smithsonian Astrophysical Observation", "SAO 220489"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.97471288),
        dec: Angle.Degrees(-43.35424856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30894"},
        {"Hipparcos Number", "HIP 22414"},
        {"Geneva Identification System", "GEN# +1.00030894"},
        {"Smithsonian Astrophysical Observation", "SAO 217017"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.35596089),
        dec: Angle.Degrees(-43.35368945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213684"},
        {"Hipparcos Number", "HIP 111389"},
        {"Smithsonian Astrophysical Observation", "SAO 231193"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.50065961),
        dec: Angle.Degrees(-43.35362478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175237"},
        {"Hipparcos Number", "HIP 92973"},
        {"Geneva Identification System", "GEN# +1.00175237"},
        {"Smithsonian Astrophysical Observation", "SAO 229387"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.11619116),
        dec: Angle.Degrees(-43.35040516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -185.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176002"},
        {"Hipparcos Number", "HIP 93283"},
        {"Geneva Identification System", "GEN# +1.00176002"},
        {"Smithsonian Astrophysical Observation", "SAO 229428"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.00565123),
        dec: Angle.Degrees(-43.34714278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186651"},
        {"Hipparcos Number", "HIP 97370"},
        {"Geneva Identification System", "GEN# +1.00186651"},
        {"Smithsonian Astrophysical Observation", "SAO 229865"},
        {"Wilson Evans Batten Catalogue", "WEB 17110"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.85488793),
        dec: Angle.Degrees(-43.34494882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89610"},
        {"Hipparcos Number", "HIP 50551"},
        {"Smithsonian Astrophysical Observation", "SAO 221958"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.88006354),
        dec: Angle.Degrees(-43.34470179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5726"},
        {"Hipparcos Number", "HIP 4551"},
        {"Smithsonian Astrophysical Observation", "SAO 215306"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.55843703),
        dec: Angle.Degrees(-43.34434727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70681"},
        {"Hipparcos Number", "HIP 40954"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.37243383),
        dec: Angle.Degrees(-43.34358293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15739",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15739"},
        {"Smithsonian Astrophysical Observation", "SAO 216286"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.69638211),
        dec: Angle.Degrees(-43.34201768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63466"},
        {"Hipparcos Number", "HIP 37987"},
        {"Smithsonian Astrophysical Observation", "SAO 218995"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.78374068),
        dec: Angle.Degrees(-43.34120374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142278"},
        {"Hipparcos Number", "HIP 77974"},
        {"Smithsonian Astrophysical Observation", "SAO 226366"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.85695217),
        dec: Angle.Degrees(-43.34050316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143863"},
        {"Hipparcos Number", "HIP 78749"},
        {"Smithsonian Astrophysical Observation", "SAO 226479"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.15989569),
        dec: Angle.Degrees(-43.34001659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172111"},
        {"Hipparcos Number", "HIP 91572"},
        {"Renson", "Renson 48230"},
        {"Smithsonian Astrophysical Observation", "SAO 229182"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.10159233),
        dec: Angle.Degrees(-43.33959585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139023"},
        {"Hipparcos Number", "HIP 76491"},
        {"Smithsonian Astrophysical Observation", "SAO 225993"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.34687990),
        dec: Angle.Degrees(-43.33871537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224318"},
        {"Hipparcos Number", "HIP 118055"},
        {"Smithsonian Astrophysical Observation", "SAO 231860"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.22132803),
        dec: Angle.Degrees(-43.33740574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117604",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117604"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.75305044),
        dec: Angle.Degrees(-43.33669341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104645"},
        {"Hipparcos Number", "HIP 58755"},
        {"Smithsonian Astrophysical Observation", "SAO 223187"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.75449133),
        dec: Angle.Degrees(-43.33652449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202628"},
        {"Hipparcos Number", "HIP 105184"},
        {"Geneva Identification System", "GEN# +1.00202628"},
        {"Smithsonian Astrophysical Observation", "SAO 230622"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.61281475),
        dec: Angle.Degrees(-43.33470265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 242.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192942"},
        {"Hipparcos Number", "HIP 100185"},
        {"Smithsonian Astrophysical Observation", "SAO 230151"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.82667234),
        dec: Angle.Degrees(-43.33433402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8001"},
        {"Hipparcos Number", "HIP 6137"},
        {"Geneva Identification System", "GEN# +1.00008001"},
        {"Smithsonian Astrophysical Observation", "SAO 215450"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.68400376),
        dec: Angle.Degrees(-43.33292904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111266"},
        {"Hipparcos Number", "HIP 62493"},
        {"Smithsonian Astrophysical Observation", "SAO 223678"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.09316296),
        dec: Angle.Degrees(-43.33284244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97025"},
        {"Hipparcos Number", "HIP 54545"},
        {"Geneva Identification System", "GEN# +1.00097025"},
        {"Smithsonian Astrophysical Observation", "SAO 222601"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.43253329),
        dec: Angle.Degrees(-43.33266210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204746"},
        {"Hipparcos Number", "HIP 106318"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.00397184),
        dec: Angle.Degrees(-43.33078996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74981"},
        {"Hipparcos Number", "HIP 42980"},
        {"Geneva Identification System", "GEN# +1.00074981"},
        {"Smithsonian Astrophysical Observation", "SAO 220408"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.39476515),
        dec: Angle.Degrees(-43.32914459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195457"},
        {"Hipparcos Number", "HIP 101415"},
        {"Smithsonian Astrophysical Observation", "SAO 230267"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.28391680),
        dec: Angle.Degrees(-43.32532649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98868"},
        {"Hipparcos Number", "HIP 55523"},
        {"Geneva Identification System", "GEN# +1.00098868"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.58150449),
        dec: Angle.Degrees(-43.32500763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -182.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 88.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86005"},
        {"Hipparcos Number", "HIP 48598"},
        {"Geneva Identification System", "GEN# +1.00086005"},
        {"Smithsonian Astrophysical Observation", "SAO 221596"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.66293700),
        dec: Angle.Degrees(-43.32115254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10960"},
        {"Hipparcos Number", "HIP 8279"},
        {"Geneva Identification System", "GEN# +1.00010960"},
        {"Smithsonian Astrophysical Observation", "SAO 215646"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.66908074),
        dec: Angle.Degrees(-43.31947241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9053"},
        {"Hipparcos Number", "HIP 6867"},
        {"Fundamental Katalog 5th Edition", "FK5 49"},
        {"Geneva Identification System", "GEN# +1.00009053"},
        {"Smithsonian Astrophysical Observation", "SAO 215516"},
        {"Wilson Evans Batten Catalogue", "WEB 1501"},
    },
    visualMagnitude: 3.41,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.09142360),
        dec: Angle.Degrees(-43.31772906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152491"},
        {"Hipparcos Number", "HIP 82829"},
        {"Celescope Catalog", "CEL 4454"},
        {"Geneva Identification System", "GEN# +1.00152491"},
        {"Smithsonian Astrophysical Observation", "SAO 227444"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.89712594),
        dec: Angle.Degrees(-43.31594840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74578"},
        {"Hipparcos Number", "HIP 42792"},
        {"Smithsonian Astrophysical Observation", "SAO 220336"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.78577300),
        dec: Angle.Degrees(-43.31384904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75789"},
        {"Hipparcos Number", "HIP 43407"},
        {"Geneva Identification System", "GEN# +1.00075789"},
        {"Smithsonian Astrophysical Observation", "SAO 220558"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.62776400),
        dec: Angle.Degrees(-43.31244188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63806"},
        {"Hipparcos Number", "HIP 38133"},
        {"Celescope Catalog", "CEL 2048"},
        {"Geneva Identification System", "GEN# +1.00063806"},
        {"Smithsonian Astrophysical Observation", "SAO 219024"},
        {"Wilson Evans Batten Catalogue", "WEB 7515"},
    },
    visualMagnitude: 7.12,
    bvColour: -0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.21467339),
        dec: Angle.Degrees(-43.31130149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197132"},
        {"Hipparcos Number", "HIP 102260"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.80842690),
        dec: Angle.Degrees(-43.31015115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83547",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Rapeto"},
        {"Henry Draper", "HD 153950"},
        {"Hipparcos Number", "HIP 83547"},
        {"Geneva Identification System", "GEN# +1.00153950"},
        {"Smithsonian Astrophysical Observation", "SAO 227597"},
        {"Wilson Evans Batten Catalogue", "WEB 14122"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.12825925),
        dec: Angle.Degrees(-43.30942598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186390"},
        {"Hipparcos Number", "HIP 97245"},
        {"Smithsonian Astrophysical Observation", "SAO 229854"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.46841095),
        dec: Angle.Degrees(-43.30324000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65237"},
        {"Hipparcos Number", "HIP 38742"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.97053689),
        dec: Angle.Degrees(-43.30283385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36377",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Hadir"},
        {"Henry Draper", "HD 59717"},
        {"Hipparcos Number", "HIP 36377"},
        {"Fundamental Katalog 5th Edition", "FK5 1194"},
        {"Geneva Identification System", "GEN# +1.00059717A"},
        {"Smithsonian Astrophysical Observation", "SAO 218755"},
        {"Wilson Evans Batten Catalogue", "WEB 7241"},
    },
    visualMagnitude: 3.25,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.30782630),
        dec: Angle.Degrees(-43.30189129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 188.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125582"},
        {"Hipparcos Number", "HIP 70172"},
        {"Renson", "Renson 35870"},
        {"Smithsonian Astrophysical Observation", "SAO 224856"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.35040957),
        dec: Angle.Degrees(-43.30094835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6368"},
        {"Hipparcos Number", "HIP 5006"},
        {"Smithsonian Astrophysical Observation", "SAO 215351"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.02897660),
        dec: Angle.Degrees(-43.30055699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65982"},
        {"Hipparcos Number", "HIP 39071"},
        {"Geneva Identification System", "GEN# +1.00065982"},
        {"Smithsonian Astrophysical Observation", "SAO 219259"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.90713420),
        dec: Angle.Degrees(-43.29948444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 227.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115396"},
        {"Hipparcos Number", "HIP 64851"},
        {"Geneva Identification System", "GEN# +1.00115396"},
        {"Smithsonian Astrophysical Observation", "SAO 224040"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.39815914),
        dec: Angle.Degrees(-43.29919068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204855"},
        {"Hipparcos Number", "HIP 106372"},
        {"Smithsonian Astrophysical Observation", "SAO 230732"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.16566418),
        dec: Angle.Degrees(-43.29829816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3646"},
        {"Hipparcos Number", "HIP 3065"},
        {"Geneva Identification System", "GEN# +1.00003646"},
        {"Smithsonian Astrophysical Observation", "SAO 215178"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.72133562),
        dec: Angle.Degrees(-43.29567219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36609",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36609"},
        {"Smithsonian Astrophysical Observation", "SAO 218779"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)31, 43.3300),
        dec: Angle.DegreesMinutesSeconds((int)-43, (int)17, 37.600)
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
    primaryId: "HIP 23235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32292"},
        {"Hipparcos Number", "HIP 23235"},
        {"Geneva Identification System", "GEN# +1.00032292"},
        {"Smithsonian Astrophysical Observation", "SAO 217104"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.00292898),
        dec: Angle.Degrees(-43.29353583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2786"},
        {"Hipparcos Number", "HIP 2436"},
        {"Smithsonian Astrophysical Observation", "SAO 215125"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.75801415),
        dec: Angle.Degrees(-43.29219055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224268"},
        {"Hipparcos Number", "HIP 118031"},
        {"Smithsonian Astrophysical Observation", "SAO 231857"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.12858562),
        dec: Angle.Degrees(-43.29036588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60287"},
        {"Hipparcos Number", "HIP 36611"},
        {"Smithsonian Astrophysical Observation", "SAO 218780"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.93390739),
        dec: Angle.Degrees(-43.28983172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20433"},
        {"Hipparcos Number", "HIP 15178"},
        {"Smithsonian Astrophysical Observation", "SAO 216234"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.90401056),
        dec: Angle.Degrees(-43.28530678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55775",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55775"},
        {"Geneva Identification System", "GEN# +2.36800027"},
        {"New General Catalogue", "NGC 3680 27"},
    },
    visualMagnitude: 10.79,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.42477663),
        dec: Angle.Degrees(-43.28525540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66679"},
        {"Hipparcos Number", "HIP 39364"},
        {"Smithsonian Astrophysical Observation", "SAO 219341"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.70046775),
        dec: Angle.Degrees(-43.28496625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16418"},
        {"Hipparcos Number", "HIP 12154"},
        {"Smithsonian Astrophysical Observation", "SAO 215965"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.15744172),
        dec: Angle.Degrees(-43.28236809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143750"},
        {"Hipparcos Number", "HIP 78707"},
        {"Geneva Identification System", "GEN# +1.00143750"},
        {"Smithsonian Astrophysical Observation", "SAO 226471"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.01006778),
        dec: Angle.Degrees(-43.28132832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100689"},
        {"Hipparcos Number", "HIP 56496"},
        {"Smithsonian Astrophysical Observation", "SAO 222882"},
    },
    visualMagnitude: 8.78,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.73739988),
        dec: Angle.Degrees(-43.28069394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61946"},
        {"Hipparcos Number", "HIP 37318"},
        {"Celescope Catalog", "CEL 1971"},
        {"Geneva Identification System", "GEN# +1.00061946J"},
        {"Smithsonian Astrophysical Observation", "SAO 218877"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.92444526),
        dec: Angle.Degrees(-43.27964170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65383"},
        {"Hipparcos Number", "HIP 38816"},
        {"Smithsonian Astrophysical Observation", "SAO 219178"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.16209864),
        dec: Angle.Degrees(-43.27835071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69755",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69755"},
    },
    visualMagnitude: 11.94,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.14069777),
        dec: Angle.Degrees(-43.27754792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178443"},
        {"Hipparcos Number", "HIP 94196"},
        {"Geneva Identification System", "GEN# +1.00178443J"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.65357641),
        dec: Angle.Degrees(-43.27659073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97567",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97567"},
    },
    visualMagnitude: 11.29,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.45667753),
        dec: Angle.Degrees(-43.27612571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 246.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201151"},
        {"Hipparcos Number", "HIP 104415"},
        {"Geneva Identification System", "GEN# +1.00201151"},
        {"Renson", "Renson 56120"},
        {"Smithsonian Astrophysical Observation", "SAO 230548"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.28116376),
        dec: Angle.Degrees(-43.27546561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124766"},
        {"Hipparcos Number", "HIP 69750"},
        {"Smithsonian Astrophysical Observation", "SAO 224809"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.13320036),
        dec: Angle.Degrees(-43.27491391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177770"},
        {"Hipparcos Number", "HIP 93970"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.99998273),
        dec: Angle.Degrees(-43.27414013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23237"},
        {"Hipparcos Number", "HIP 17267"},
        {"Smithsonian Astrophysical Observation", "SAO 216444"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.47307104),
        dec: Angle.Degrees(-43.27298125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85156",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85156"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.02289632),
        dec: Angle.Degrees(-43.27291742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84305"},
        {"Hipparcos Number", "HIP 47662"},
        {"Geneva Identification System", "GEN# +1.00084305"},
        {"Smithsonian Astrophysical Observation", "SAO 221425"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.77212899),
        dec: Angle.Degrees(-43.27255743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 109.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214520"},
        {"Hipparcos Number", "HIP 111855"},
        {"Geneva Identification System", "GEN# +1.00214520"},
        {"Smithsonian Astrophysical Observation", "SAO 231235"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.86482022),
        dec: Angle.Degrees(-43.27252762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47202",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Kalausi"},
        {"Henry Draper", "HD 83443"},
        {"Hipparcos Number", "HIP 47202"},
        {"Geneva Identification System", "GEN# +1.00083443"},
        {"Smithsonian Astrophysical Observation", "SAO 221348"},
        {"Wilson Evans Batten Catalogue", "WEB 8879"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.811,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.29920891),
        dec: Angle.Degrees(-43.27191181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79185"},
        {"Hipparcos Number", "HIP 45091"},
        {"Geneva Identification System", "GEN# +1.00079185"},
        {"Smithsonian Astrophysical Observation", "SAO 220929"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.78129011),
        dec: Angle.Degrees(-43.26989094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79154"},
        {"Hipparcos Number", "HIP 45079"},
        {"Smithsonian Astrophysical Observation", "SAO 220926"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.74045324),
        dec: Angle.Degrees(-43.26740367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13280"},
        {"Hipparcos Number", "HIP 9987"},
        {"Smithsonian Astrophysical Observation", "SAO 215781"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.16089513),
        dec: Angle.Degrees(-43.26731973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141838"},
        {"Hipparcos Number", "HIP 77777"},
        {"Smithsonian Astrophysical Observation", "SAO 226324"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.22424349),
        dec: Angle.Degrees(-43.26540202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111073"},
        {"Hipparcos Number", "HIP 62381"},
        {"Smithsonian Astrophysical Observation", "SAO 223668"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.76541402),
        dec: Angle.Degrees(-43.26447110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213457"},
        {"Hipparcos Number", "HIP 111237"},
        {"Geneva Identification System", "GEN# +1.00213457"},
        {"Smithsonian Astrophysical Observation", "SAO 231188"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.04793548),
        dec: Angle.Degrees(-43.26308437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14180"},
        {"Hipparcos Number", "HIP 10601"},
        {"Fundamental Katalog 5th Edition", "FK5 4210"},
        {"Geneva Identification System", "GEN# +1.00014180"},
        {"Smithsonian Astrophysical Observation", "SAO 215844"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.12200820),
        dec: Angle.Degrees(-43.26146097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222398"},
        {"Hipparcos Number", "HIP 116803"},
        {"Smithsonian Astrophysical Observation", "SAO 231728"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.09539522),
        dec: Angle.Degrees(-43.26079749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108256"},
        {"Hipparcos Number", "HIP 60701"},
        {"Smithsonian Astrophysical Observation", "SAO 223438"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.61043509),
        dec: Angle.Degrees(-43.26066542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62625"},
        {"Hipparcos Number", "HIP 37610"},
        {"Smithsonian Astrophysical Observation", "SAO 218924"},
    },
    visualMagnitude: 9.02,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.75678445),
        dec: Angle.Degrees(-43.25805736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76838"},
        {"Hipparcos Number", "HIP 43955"},
        {"Celescope Catalog", "CEL 3101"},
        {"Geneva Identification System", "GEN# +1.00076838J"},
        {"Smithsonian Astrophysical Observation", "SAO 220689"},
        {"Wilson Evans Batten Catalogue", "WEB 8451"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.28149074),
        dec: Angle.Degrees(-43.25620455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84959"},
        {"Hipparcos Number", "HIP 48039"},
        {"Smithsonian Astrophysical Observation", "SAO 221492"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.89759922),
        dec: Angle.Degrees(-43.25315483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18396"},
        {"Hipparcos Number", "HIP 13657"},
        {"Smithsonian Astrophysical Observation", "SAO 216100"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.96489064),
        dec: Angle.Degrees(-43.25309198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95407"},
        {"Hipparcos Number", "HIP 53784"},
        {"Geneva Identification System", "GEN# +1.00095407"},
        {"Smithsonian Astrophysical Observation", "SAO 222489"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.06685582),
        dec: Angle.Degrees(-43.25148382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127440"},
        {"Hipparcos Number", "HIP 71126"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.17514302),
        dec: Angle.Degrees(-43.25091350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94466",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94466"},
    },
    visualMagnitude: 10.05,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.40305651),
        dec: Angle.Degrees(-43.24966590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5810"},
        {"Hipparcos Number", "HIP 4607"},
        {"Smithsonian Astrophysical Observation", "SAO 215311"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.76182462),
        dec: Angle.Degrees(-43.24679261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105283"},
        {"Hipparcos Number", "HIP 59120"},
        {"Geneva Identification System", "GEN# +1.00105283"},
        {"Smithsonian Astrophysical Observation", "SAO 223224"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.84552030),
        dec: Angle.Degrees(-43.24651162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15700"},
        {"Hipparcos Number", "HIP 11639"},
        {"Geneva Identification System", "GEN# +1.00015700"},
        {"Smithsonian Astrophysical Observation", "SAO 215924"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.53996245),
        dec: Angle.Degrees(-43.24495730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43956",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43956"},
        {"Smithsonian Astrophysical Observation", "SAO 220690"},
    },
    visualMagnitude: 10.03,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.28229205),
        dec: Angle.Degrees(-43.24426306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125085"},
        {"Hipparcos Number", "HIP 69897"},
        {"Smithsonian Astrophysical Observation", "SAO 224826"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.57661594),
        dec: Angle.Degrees(-43.24252293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23071"},
        {"Hipparcos Number", "HIP 17145"},
        {"Smithsonian Astrophysical Observation", "SAO 216434"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.08150872),
        dec: Angle.Degrees(-43.24078049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179209"},
        {"Hipparcos Number", "HIP 94470"},
        {"Smithsonian Astrophysical Observation", "SAO 229564"},
    },
    visualMagnitude: 8.84,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.40997385),
        dec: Angle.Degrees(-43.24017398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67976",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67976"},
        {"Wilson Evans Batten Catalogue", "WEB 11942"},
    },
    visualMagnitude: 11.32,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.81149657),
        dec: Angle.Degrees(-43.24016148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3374"},
        {"Hipparcos Number", "HIP 2864"},
        {"Smithsonian Astrophysical Observation", "SAO 215164"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.07650475),
        dec: Angle.Degrees(-43.24006389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43534"},
        {"Hipparcos Number", "HIP 29627"},
        {"Geneva Identification System", "GEN# +1.00043534"},
        {"Smithsonian Astrophysical Observation", "SAO 217799"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.64682614),
        dec: Angle.Degrees(-43.23874586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155203"},
        {"Hipparcos Number", "HIP 84143"},
        {"Celescope Catalog", "CEL 4487"},
        {"Fundamental Katalog 5th Edition", "FK5 638"},
        {"Geneva Identification System", "GEN# +1.00155203"},
        {"Renson", "Renson 43840"},
        {"Smithsonian Astrophysical Observation", "SAO 227707"},
        {"Wilson Evans Batten Catalogue", "WEB 14208"},
    },
    visualMagnitude: 3.32,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.03823300),
        dec: Angle.Degrees(-43.23849039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -287.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21603",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21603"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.56570158),
        dec: Angle.Degrees(-43.23837021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16518"},
        {"Hipparcos Number", "HIP 12245"},
        {"Smithsonian Astrophysical Observation", "SAO 215972"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.41729340),
        dec: Angle.Degrees(-43.23712189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23534"},
        {"Hipparcos Number", "HIP 17442"},
        {"Fundamental Katalog 5th Edition", "FK5 4341"},
        {"Smithsonian Astrophysical Observation", "SAO 216461"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.05527360),
        dec: Angle.Degrees(-43.23622178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140690"},
        {"Hipparcos Number", "HIP 77282"},
        {"Geneva Identification System", "GEN# +1.00140690J"},
        {"Smithsonian Astrophysical Observation", "SAO 226181"},
        {"Wilson Evans Batten Catalogue", "WEB 13092"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.67969572),
        dec: Angle.Degrees(-43.23572930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11144"},
        {"Hipparcos Number", "HIP 8437"},
        {"Smithsonian Astrophysical Observation", "SAO 215663"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.19027326),
        dec: Angle.Degrees(-43.23563525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33528"},
        {"Hipparcos Number", "HIP 23940"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.17658634),
        dec: Angle.Degrees(-43.23562507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1483"},
        {"Hipparcos Number", "HIP 1502"},
        {"Geneva Identification System", "GEN# +1.00001483"},
        {"Smithsonian Astrophysical Observation", "SAO 215047"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.67717473),
        dec: Angle.Degrees(-43.23557050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108637"},
        {"Hipparcos Number", "HIP 60911"},
        {"Geneva Identification System", "GEN# +1.00108637"},
        {"Smithsonian Astrophysical Observation", "SAO 223461"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.25217097),
        dec: Angle.Degrees(-43.23410556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209282"},
        {"Hipparcos Number", "HIP 108854"},
        {"Smithsonian Astrophysical Observation", "SAO 230959"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.78110031),
        dec: Angle.Degrees(-43.23239066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168735"},
        {"Hipparcos Number", "HIP 90106"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.82115832),
        dec: Angle.Degrees(-43.22889991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158800"},
        {"Hipparcos Number", "HIP 85903"},
        {"Geneva Identification System", "GEN# +1.00158800"},
        {"Smithsonian Astrophysical Observation", "SAO 228111"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.31247261),
        dec: Angle.Degrees(-43.22805394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70948"},
        {"Hipparcos Number", "HIP 41085"},
        {"Celescope Catalog", "CEL 2451"},
        {"Smithsonian Astrophysical Observation", "SAO 219857"},
    },
    visualMagnitude: 7.09,
    bvColour: -0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.73821713),
        dec: Angle.Degrees(-43.22789014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79735"},
        {"Hipparcos Number", "HIP 45344"},
        {"Celescope Catalog", "CEL 3235"},
        {"Geneva Identification System", "GEN# +1.00079735J"},
        {"Smithsonian Astrophysical Observation", "SAO 220978"},
        {"Wilson Evans Batten Catalogue", "WEB 8636"},
    },
    visualMagnitude: 5.24,
    bvColour: -0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.60210323),
        dec: Angle.Degrees(-43.22752192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158306"},
        {"Hipparcos Number", "HIP 85682"},
        {"Geneva Identification System", "GEN# +1.00158306"},
        {"Smithsonian Astrophysical Observation", "SAO 228048"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.64121116),
        dec: Angle.Degrees(-43.22600333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87417"},
        {"Hipparcos Number", "HIP 49301"},
        {"Smithsonian Astrophysical Observation", "SAO 221736"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.94430920),
        dec: Angle.Degrees(-43.22514673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65289"},
        {"Hipparcos Number", "HIP 38776"},
        {"Smithsonian Astrophysical Observation", "SAO 219165"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.06182026),
        dec: Angle.Degrees(-43.22395627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38906"},
        {"Hipparcos Number", "HIP 27277"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.71057354),
        dec: Angle.Degrees(-43.22196487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148689"},
        {"Hipparcos Number", "HIP 80943"},
        {"Smithsonian Astrophysical Observation", "SAO 226851"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.91726747),
        dec: Angle.Degrees(-43.21772499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4114"},
        {"Hipparcos Number", "HIP 3390"},
        {"Smithsonian Astrophysical Observation", "SAO 215207"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.79538073),
        dec: Angle.Degrees(-43.21661539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190333"},
        {"Hipparcos Number", "HIP 99029"},
        {"Geneva Identification System", "GEN# +1.00190333"},
        {"Smithsonian Astrophysical Observation", "SAO 230038"},
        {"Wilson Evans Batten Catalogue", "WEB 17604"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.57415972),
        dec: Angle.Degrees(-43.21536448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -245.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220591"},
        {"Hipparcos Number", "HIP 115617"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.31550329),
        dec: Angle.Degrees(-43.21280015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28812"},
        {"Hipparcos Number", "HIP 21020"},
        {"Smithsonian Astrophysical Observation", "SAO 216842"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.61120877),
        dec: Angle.Degrees(-43.21277405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181622"},
        {"Hipparcos Number", "HIP 95285"},
        {"Smithsonian Astrophysical Observation", "SAO 229651"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.77574584),
        dec: Angle.Degrees(-43.21065017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162243"},
        {"Hipparcos Number", "HIP 87452"},
        {"Smithsonian Astrophysical Observation", "SAO 228497"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.03243201),
        dec: Angle.Degrees(-43.20486494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55789",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55789"},
        {"Geneva Identification System", "GEN# +2.36800044"},
        {"New General Catalogue", "NGC 3680 44"},
    },
    visualMagnitude: 10.01,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.45796690),
        dec: Angle.Degrees(-43.20436705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166675"},
        {"Hipparcos Number", "HIP 89345"},
        {"Geneva Identification System", "GEN# +1.00166675"},
        {"Smithsonian Astrophysical Observation", "SAO 228823"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.45295268),
        dec: Angle.Degrees(-43.20429967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2000"},
        {"Hipparcos Number", "HIP 1906"},
        {"Smithsonian Astrophysical Observation", "SAO 215080"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.02524245),
        dec: Angle.Degrees(-43.20336311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22324"},
        {"Hipparcos Number", "HIP 16619"},
        {"Smithsonian Astrophysical Observation", "SAO 216385"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.46534866),
        dec: Angle.Degrees(-43.20246656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147181"},
        {"Hipparcos Number", "HIP 80186"},
        {"Geneva Identification System", "GEN# +1.00147181"},
        {"Smithsonian Astrophysical Observation", "SAO 226694"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.55993635),
        dec: Angle.Degrees(-43.20019743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14832"},
        {"Hipparcos Number", "HIP 11043"},
        {"Fundamental Katalog 5th Edition", "FK5 2162"},
        {"Geneva Identification System", "GEN# +1.00014832"},
        {"Smithsonian Astrophysical Observation", "SAO 215878"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.54875946),
        dec: Angle.Degrees(-43.19991721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85849"},
        {"Hipparcos Number", "HIP 48501"},
        {"Smithsonian Astrophysical Observation", "SAO 221578"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.36700276),
        dec: Angle.Degrees(-43.19624112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47670"},
        {"Hipparcos Number", "HIP 31685"},
        {"Celescope Catalog", "CEL 1337"},
        {"Fundamental Katalog 5th Edition", "FK5 252"},
        {"Geneva Identification System", "GEN# +1.00047670"},
        {"Smithsonian Astrophysical Observation", "SAO 218071"},
        {"Wilson Evans Batten Catalogue", "WEB 6354"},
    },
    visualMagnitude: 3.17,
    bvColour: -0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.44029869),
        dec: Angle.Degrees(-43.19592394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104986",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104986"},
    },
    visualMagnitude: 11.35,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.95551155),
        dec: Angle.Degrees(-43.19442232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93453"},
        {"Hipparcos Number", "HIP 52709"},
        {"Geneva Identification System", "GEN# +1.00093453"},
        {"Smithsonian Astrophysical Observation", "SAO 222318"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.65475590),
        dec: Angle.Degrees(-43.19253898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25335"},
        {"Hipparcos Number", "HIP 18661"},
        {"Smithsonian Astrophysical Observation", "SAO 216593"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.92469132),
        dec: Angle.Degrees(-43.19217898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225156"},
        {"Hipparcos Number", "HIP 310"},
        {"Geneva Identification System", "GEN# +1.00225156"},
        {"Smithsonian Astrophysical Observation", "SAO 214945"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.98741047),
        dec: Angle.Degrees(-43.19150360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83548"},
        {"Hipparcos Number", "HIP 47267"},
        {"Fundamental Katalog 5th Edition", "FK5 2771"},
        {"Geneva Identification System", "GEN# +1.00083548"},
        {"Smithsonian Astrophysical Observation", "SAO 221355"},
        {"Wilson Evans Batten Catalogue", "WEB 8888"},
    },
    visualMagnitude: 5.51,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.50597591),
        dec: Angle.Degrees(-43.19086905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82224"},
        {"Hipparcos Number", "HIP 46526"},
        {"Geneva Identification System", "GEN# +1.00082224"},
        {"Smithsonian Astrophysical Observation", "SAO 221214"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.34379867),
        dec: Angle.Degrees(-43.19022327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55753",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55753"},
        {"Geneva Identification System", "GEN# +2.36800020"},
        {"New General Catalogue", "NGC 3680 20"},
    },
    visualMagnitude: 10.14,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.35932853),
        dec: Angle.Degrees(-43.19000039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33390"},
        {"Hipparcos Number", "HIP 23872"},
        {"Smithsonian Astrophysical Observation", "SAO 217191"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.95568253),
        dec: Angle.Degrees(-43.18791303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220204"},
        {"Hipparcos Number", "HIP 115372"},
        {"Smithsonian Astrophysical Observation", "SAO 231569"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.55888857),
        dec: Angle.Degrees(-43.18691285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171967"},
        {"Hipparcos Number", "HIP 91494"},
        {"Geneva Identification System", "GEN# +1.00171967"},
        {"Smithsonian Astrophysical Observation", "SAO 229172"},
        {"Wilson Evans Batten Catalogue", "WEB 15724"},
    },
    visualMagnitude: 5.42,
    bvColour: 1.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.89660339),
        dec: Angle.Degrees(-43.18577561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119221"},
        {"Hipparcos Number", "HIP 66908"},
        {"Geneva Identification System", "GEN# +1.00119221"},
        {"Smithsonian Astrophysical Observation", "SAO 224355"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.68207798),
        dec: Angle.Degrees(-43.18563837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62212"},
        {"Hipparcos Number", "HIP 37424"},
        {"Celescope Catalog", "CEL 1978"},
        {"Geneva Identification System", "GEN# +1.00062212"},
        {"Smithsonian Astrophysical Observation", "SAO 218896"},
    },
    visualMagnitude: 7.34,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.23945779),
        dec: Angle.Degrees(-43.18458476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214986"},
        {"Hipparcos Number", "HIP 112123"},
        {"Smithsonian Astrophysical Observation", "SAO 231259"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.67451869),
        dec: Angle.Degrees(-43.18348348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59237"},
        {"Hipparcos Number", "HIP 36178"},
        {"Smithsonian Astrophysical Observation", "SAO 218731"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.76332292),
        dec: Angle.Degrees(-43.18315941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12003"},
        {"Hipparcos Number", "HIP 9075"},
        {"Geneva Identification System", "GEN# +1.00012003"},
        {"Smithsonian Astrophysical Observation", "SAO 215711"},
        {"Wilson Evans Batten Catalogue", "WEB 1903"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.20930516),
        dec: Angle.Degrees(-43.17812544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87918"},
        {"Hipparcos Number", "HIP 49575"},
        {"Smithsonian Astrophysical Observation", "SAO 221784"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.80083010),
        dec: Angle.Degrees(-43.17708227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72370"},
        {"Hipparcos Number", "HIP 41744"},
        {"Smithsonian Astrophysical Observation", "SAO 220027"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.68664032),
        dec: Angle.Degrees(-43.17508364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77320"},
        {"Hipparcos Number", "HIP 44213"},
        {"Celescope Catalog", "CEL 3134"},
        {"Geneva Identification System", "GEN# +1.00077320"},
        {"Smithsonian Astrophysical Observation", "SAO 220738"},
    },
    visualMagnitude: 6.04,
    bvColour: -0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.09276114),
        dec: Angle.Degrees(-43.17399229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90117"},
        {"Hipparcos Number", "HIP 50864"},
        {"Smithsonian Astrophysical Observation", "SAO 222008"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.79374620),
        dec: Angle.Degrees(-43.17320849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144240"},
        {"Hipparcos Number", "HIP 78922"},
        {"Smithsonian Astrophysical Observation", "SAO 226506"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.66693817),
        dec: Angle.Degrees(-43.17075915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122524"},
        {"Hipparcos Number", "HIP 68675"},
        {"Smithsonian Astrophysical Observation", "SAO 224642"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.87618863),
        dec: Angle.Degrees(-43.17017949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167095"},
        {"Hipparcos Number", "HIP 89500"},
        {"Geneva Identification System", "GEN# +1.00167095"},
        {"Renson", "Renson 47013"},
        {"Smithsonian Astrophysical Observation", "SAO 228852"},
    },
    visualMagnitude: 7.04,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.96016732),
        dec: Angle.Degrees(-43.16872346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56642"},
        {"Hipparcos Number", "HIP 35135"},
        {"Smithsonian Astrophysical Observation", "SAO 218577"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.95108858),
        dec: Angle.Degrees(-43.16807502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159941"},
        {"Hipparcos Number", "HIP 86406"},
        {"Smithsonian Astrophysical Observation", "SAO 228239"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.83653517),
        dec: Angle.Degrees(-43.16462066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55787",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55787"},
        {"Geneva Identification System", "GEN# +2.36800041"},
        {"New General Catalogue", "NGC 3680 41"},
    },
    visualMagnitude: 10.94,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.45224024),
        dec: Angle.Degrees(-43.16459536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 845"},
        {"Hipparcos Number", "HIP 1019"},
        {"Geneva Identification System", "GEN# +1.00000845"},
        {"Smithsonian Astrophysical Observation", "SAO 215002"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.16896301),
        dec: Angle.Degrees(-43.16447354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129931"},
        {"Hipparcos Number", "HIP 72262"},
        {"Smithsonian Astrophysical Observation", "SAO 225179"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.65882802),
        dec: Angle.Degrees(-43.16319506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24696"},
        {"Hipparcos Number", "HIP 18225"},
        {"Geneva Identification System", "GEN# +1.00024696"},
        {"Smithsonian Astrophysical Observation", "SAO 216543"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.44996840),
        dec: Angle.Degrees(-43.16241200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131225"},
        {"Hipparcos Number", "HIP 72885"},
        {"Smithsonian Astrophysical Observation", "SAO 225276"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.44538812),
        dec: Angle.Degrees(-43.16209001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132242"},
        {"Hipparcos Number", "HIP 73354"},
        {"Geneva Identification System", "GEN# +1.00132242"},
        {"Smithsonian Astrophysical Observation", "SAO 225351"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.86334180),
        dec: Angle.Degrees(-43.15981215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14580",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14580"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.05541163),
        dec: Angle.Degrees(-43.15704049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9160"},
        {"Hipparcos Number", "HIP 6946"},
        {"Geneva Identification System", "GEN# +1.00009160"},
        {"Smithsonian Astrophysical Observation", "SAO 215524"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.36124103),
        dec: Angle.Degrees(-43.15640303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162822"},
        {"Hipparcos Number", "HIP 87711"},
        {"Smithsonian Astrophysical Observation", "SAO 228538"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.74150487),
        dec: Angle.Degrees(-43.15621692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98532"},
        {"Hipparcos Number", "HIP 55315"},
        {"Smithsonian Astrophysical Observation", "SAO 222719"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.92252271),
        dec: Angle.Degrees(-43.15524210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166793"},
        {"Hipparcos Number", "HIP 89373"},
        {"Geneva Identification System", "GEN# +1.00166793"},
        {"Smithsonian Astrophysical Observation", "SAO 228832"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.58128999),
        dec: Angle.Degrees(-43.15415225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17887"},
        {"Hipparcos Number", "HIP 13280"},
        {"Smithsonian Astrophysical Observation", "SAO 216068"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.72602152),
        dec: Angle.Degrees(-43.15355622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137378"},
        {"Hipparcos Number", "HIP 75644"},
        {"Smithsonian Astrophysical Observation", "SAO 225800"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.82470506),
        dec: Angle.Degrees(-43.15263731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76206",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76206"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.50275976),
        dec: Angle.Degrees(-43.15167634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8488"},
        {"Hipparcos Number", "HIP 6470"},
        {"Geneva Identification System", "GEN# +1.00008488"},
        {"Smithsonian Astrophysical Observation", "SAO 215481"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.80497664),
        dec: Angle.Degrees(-43.15007436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219959"},
        {"Hipparcos Number", "HIP 115234"},
        {"Smithsonian Astrophysical Observation", "SAO 231555"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.10459331),
        dec: Angle.Degrees(-43.14938574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119103"},
        {"Hipparcos Number", "HIP 66850"},
        {"Geneva Identification System", "GEN# +1.00119103"},
        {"Smithsonian Astrophysical Observation", "SAO 224349"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.50607400),
        dec: Angle.Degrees(-43.14699242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 327352"},
        {"Hipparcos Number", "HIP 77321"},
    },
    visualMagnitude: 10.77,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.78693985),
        dec: Angle.Degrees(-43.14569386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28244"},
        {"Hipparcos Number", "HIP 20636"},
        {"Smithsonian Astrophysical Observation", "SAO 216792"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.34443035),
        dec: Angle.Degrees(-43.14543398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159868"},
        {"Hipparcos Number", "HIP 86375"},
        {"Geneva Identification System", "GEN# +1.00159868"},
        {"Smithsonian Astrophysical Observation", "SAO 228234"},
        {"Wilson Evans Batten Catalogue", "WEB 14573"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.74879843),
        dec: Angle.Degrees(-43.14510379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -231.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -168.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134745"},
        {"Hipparcos Number", "HIP 74467"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.25176316),
        dec: Angle.Degrees(-43.14485904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216750"},
        {"Hipparcos Number", "HIP 113259"},
        {"Smithsonian Astrophysical Observation", "SAO 231362"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.03031210),
        dec: Angle.Degrees(-43.14429049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193923"},
        {"Hipparcos Number", "HIP 100659"},
        {"Smithsonian Astrophysical Observation", "SAO 230191"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.15003714),
        dec: Angle.Degrees(-43.14139545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4357"},
        {"Hipparcos Number", "HIP 3563"},
        {"Smithsonian Astrophysical Observation", "SAO 215227"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.38754245),
        dec: Angle.Degrees(-43.14114791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185540"},
        {"Hipparcos Number", "HIP 96869"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.35362230),
        dec: Angle.Degrees(-43.14018165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114873"},
        {"Hipparcos Number", "HIP 64557"},
        {"Geneva Identification System", "GEN# +1.00114873"},
        {"Smithsonian Astrophysical Observation", "SAO 223989"},
        {"Wilson Evans Batten Catalogue", "WEB 11417"},
    },
    visualMagnitude: 6.16,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.49083299),
        dec: Angle.Degrees(-43.13916095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87188"},
        {"Hipparcos Number", "HIP 49187"},
        {"Smithsonian Astrophysical Observation", "SAO 221715"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.58801132),
        dec: Angle.Degrees(-43.13853418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91035"},
        {"Hipparcos Number", "HIP 51387"},
        {"Smithsonian Astrophysical Observation", "SAO 222098"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.42864588),
        dec: Angle.Degrees(-43.13576098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210544"},
        {"Hipparcos Number", "HIP 109594"},
        {"Smithsonian Astrophysical Observation", "SAO 231024"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.00958039),
        dec: Angle.Degrees(-43.13460802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132058"},
        {"Hipparcos Number", "HIP 73273"},
        {"Celescope Catalog", "CEL 4329"},
        {"Fundamental Katalog 5th Edition", "FK5 552"},
        {"Geneva Identification System", "GEN# +1.00132058"},
        {"Smithsonian Astrophysical Observation", "SAO 225335"},
        {"Wilson Evans Batten Catalogue", "WEB 12553"},
    },
    visualMagnitude: 2.68,
    bvColour: -0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.63314193),
        dec: Angle.Degrees(-43.13386699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221844"},
        {"Hipparcos Number", "HIP 116451"},
        {"Smithsonian Astrophysical Observation", "SAO 231681"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.94569791),
        dec: Angle.Degrees(-43.13309684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133262"},
        {"Hipparcos Number", "HIP 73804"},
        {"Smithsonian Astrophysical Observation", "SAO 225428"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.27264094),
        dec: Angle.Degrees(-43.13277117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205933"},
        {"Hipparcos Number", "HIP 106968"},
        {"Fundamental Katalog 5th Edition", "FK5 3727"},
        {"Smithsonian Astrophysical Observation", "SAO 230778"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.96700929),
        dec: Angle.Degrees(-43.13200616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91089"},
        {"Hipparcos Number", "HIP 51412"},
        {"Celescope Catalog", "CEL 3554"},
        {"Geneva Identification System", "GEN# +1.00091089"},
        {"Renson", "Renson 26200"},
        {"Smithsonian Astrophysical Observation", "SAO 222099"},
    },
    visualMagnitude: 7.55,
    bvColour: -0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.51306631),
        dec: Angle.Degrees(-43.12980834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201865"},
        {"Hipparcos Number", "HIP 104794"},
        {"Smithsonian Astrophysical Observation", "SAO 230582"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.45179313),
        dec: Angle.Degrees(-43.12979753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58850"},
        {"Hipparcos Number", "HIP 36021"},
        {"Smithsonian Astrophysical Observation", "SAO 218714"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.34585579),
        dec: Angle.Degrees(-43.12889481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46315",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46315"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.66624823),
        dec: Angle.Degrees(-43.12810993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146057"},
        {"Hipparcos Number", "HIP 79716"},
        {"Smithsonian Astrophysical Observation", "SAO 226612"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.03753364),
        dec: Angle.Degrees(-43.12550591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3979"},
        {"Hipparcos Number", "HIP 3288"},
        {"Geneva Identification System", "GEN# +1.00003979"},
        {"Smithsonian Astrophysical Observation", "SAO 215199"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.48953748),
        dec: Angle.Degrees(-43.12481410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169923"},
        {"Hipparcos Number", "HIP 90579"},
        {"Smithsonian Astrophysical Observation", "SAO 229055"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.24794676),
        dec: Angle.Degrees(-43.12478712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220401"},
        {"Hipparcos Number", "HIP 115496"},
        {"Geneva Identification System", "GEN# +1.00220401"},
        {"Smithsonian Astrophysical Observation", "SAO 231587"},
    },
    visualMagnitude: 6.12,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.93920175),
        dec: Angle.Degrees(-43.12445723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87947"},
        {"Hipparcos Number", "HIP 49595"},
        {"Geneva Identification System", "GEN# +1.00087947"},
        {"Smithsonian Astrophysical Observation", "SAO 221787"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.86323157),
        dec: Angle.Degrees(-43.12242746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38954"},
        {"Hipparcos Number", "HIP 27311"},
        {"Smithsonian Astrophysical Observation", "SAO 217534"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.78850579),
        dec: Angle.Degrees(-43.12090322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153713"},
        {"Hipparcos Number", "HIP 83415"},
        {"Geneva Identification System", "GEN# +1.00153713"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.74934609),
        dec: Angle.Degrees(-43.11977327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1280",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1280"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.01101903),
        dec: Angle.Degrees(-43.11896183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96300"},
        {"Hipparcos Number", "HIP 54222"},
        {"Geneva Identification System", "GEN# +1.00096300"},
        {"Smithsonian Astrophysical Observation", "SAO 222558"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.41894871),
        dec: Angle.Degrees(-43.11874692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94485"},
        {"Hipparcos Number", "HIP 53282"},
        {"Fundamental Katalog 5th Edition", "FK5 4962"},
        {"Smithsonian Astrophysical Observation", "SAO 222405"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.45148945),
        dec: Angle.Degrees(-43.11745057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24967"},
        {"Hipparcos Number", "HIP 18417"},
        {"Geneva Identification System", "GEN# +1.00024967"},
        {"Smithsonian Astrophysical Observation", "SAO 216559"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.06442800),
        dec: Angle.Degrees(-43.11582254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51062"},
        {"Hipparcos Number", "HIP 33111"},
        {"Smithsonian Astrophysical Observation", "SAO 218290"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.44731960),
        dec: Angle.Degrees(-43.11416275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60687"},
        {"Hipparcos Number", "HIP 36775"},
        {"Smithsonian Astrophysical Observation", "SAO 218801"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.45937162),
        dec: Angle.Degrees(-43.11373014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19966"},
        {"Hipparcos Number", "HIP 14793"},
        {"Geneva Identification System", "GEN# +1.00019966"},
        {"Smithsonian Astrophysical Observation", "SAO 216203"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.75910846),
        dec: Angle.Degrees(-43.11298749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195334"},
        {"Hipparcos Number", "HIP 101334"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.07394418),
        dec: Angle.Degrees(-43.11277369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89062"},
        {"Hipparcos Number", "HIP 50241"},
        {"Geneva Identification System", "GEN# +1.00089062"},
        {"Smithsonian Astrophysical Observation", "SAO 221910"},
    },
    visualMagnitude: 5.59,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.88145179),
        dec: Angle.Degrees(-43.11224108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128343"},
        {"Hipparcos Number", "HIP 71520"},
        {"Smithsonian Astrophysical Observation", "SAO 225070"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.40230802),
        dec: Angle.Degrees(-43.11131409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51232"},
        {"Hipparcos Number", "HIP 33193"},
        {"Smithsonian Astrophysical Observation", "SAO 218298"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.62012932),
        dec: Angle.Degrees(-43.10852161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180654"},
        {"Hipparcos Number", "HIP 94953"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.83016462),
        dec: Angle.Degrees(-43.10555845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39778"},
        {"Hipparcos Number", "HIP 27767"},
        {"Smithsonian Astrophysical Observation", "SAO 217588"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.13994490),
        dec: Angle.Degrees(-43.10516825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188789"},
        {"Hipparcos Number", "HIP 98335"},
        {"Smithsonian Astrophysical Observation", "SAO 229958"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.68110506),
        dec: Angle.Degrees(-43.10314474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90099"},
        {"Hipparcos Number", "HIP 50859"},
        {"Smithsonian Astrophysical Observation", "SAO 222007"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.77524142),
        dec: Angle.Degrees(-43.10311601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50598"},
        {"Hipparcos Number", "HIP 32951"},
        {"Geneva Identification System", "GEN# +1.00050598"},
        {"Smithsonian Astrophysical Observation", "SAO 218266"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.95464692),
        dec: Angle.Degrees(-43.10127401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101615"},
        {"Hipparcos Number", "HIP 57013"},
        {"Fundamental Katalog 5th Edition", "FK5 2937"},
        {"Geneva Identification System", "GEN# +1.00101615"},
        {"Smithsonian Astrophysical Observation", "SAO 222960"},
        {"Wilson Evans Batten Catalogue", "WEB 10264"},
    },
    visualMagnitude: 5.54,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.33273307),
        dec: Angle.Degrees(-43.09567719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64287"},
        {"Hipparcos Number", "HIP 38355"},
        {"Celescope Catalog", "CEL 2064"},
        {"Geneva Identification System", "GEN# +1.00064287"},
        {"Smithsonian Astrophysical Observation", "SAO 219069"},
        {"Wilson Evans Batten Catalogue", "WEB 7544"},
    },
    visualMagnitude: 6.34,
    bvColour: -0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.83476239),
        dec: Angle.Degrees(-43.09524646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157675"},
        {"Hipparcos Number", "HIP 85367"},
        {"Smithsonian Astrophysical Observation", "SAO 227967"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.66430345),
        dec: Angle.Degrees(-43.09469179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112314",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112314"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.24485536),
        dec: Angle.Degrees(-43.09435710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69821"},
        {"Hipparcos Number", "HIP 40574"},
        {"Smithsonian Astrophysical Observation", "SAO 219725"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.25308543),
        dec: Angle.Degrees(-43.09331032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123004"},
        {"Hipparcos Number", "HIP 68872"},
        {"Geneva Identification System", "GEN# +1.00123004"},
        {"Smithsonian Astrophysical Observation", "SAO 224676"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.54546620),
        dec: Angle.Degrees(-43.09161929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117593",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117593"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.72604185),
        dec: Angle.Degrees(-43.09148673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132961"},
        {"Hipparcos Number", "HIP 73658"},
        {"Smithsonian Astrophysical Observation", "SAO 225405"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.85835558),
        dec: Angle.Degrees(-43.08934076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112907"},
        {"Hipparcos Number", "HIP 63485"},
        {"Smithsonian Astrophysical Observation", "SAO 223832"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.12100039),
        dec: Angle.Degrees(-43.08827398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96725"},
        {"Hipparcos Number", "HIP 54402"},
        {"Smithsonian Astrophysical Observation", "SAO 222589"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.98840321),
        dec: Angle.Degrees(-43.08824429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183468"},
        {"Hipparcos Number", "HIP 96036"},
        {"Smithsonian Astrophysical Observation", "SAO 229730"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.90413905),
        dec: Angle.Degrees(-43.08815477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127294"},
        {"Hipparcos Number", "HIP 71036"},
        {"Geneva Identification System", "GEN# +1.00127294"},
        {"Smithsonian Astrophysical Observation", "SAO 224996"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.92262848),
        dec: Angle.Degrees(-43.08814858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137417"},
        {"Hipparcos Number", "HIP 75661"},
        {"Smithsonian Astrophysical Observation", "SAO 225805"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.87254672),
        dec: Angle.Degrees(-43.08741231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60574"},
        {"Hipparcos Number", "HIP 36729"},
        {"Geneva Identification System", "GEN# +1.00060574"},
        {"Smithsonian Astrophysical Observation", "SAO 218792"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.30550994),
        dec: Angle.Degrees(-43.08613560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200346"},
        {"Hipparcos Number", "HIP 104016"},
        {"Smithsonian Astrophysical Observation", "SAO 230506"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.09489685),
        dec: Angle.Degrees(-43.08555083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216196"},
        {"Hipparcos Number", "HIP 112874"},
        {"Smithsonian Astrophysical Observation", "SAO 231328"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.86690285),
        dec: Angle.Degrees(-43.08524517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90204",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90204"},
        {"Geneva Identification System", "GEN# -0.01004682"},
        {"Smithsonian Astrophysical Observation", "SAO 161434"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.08603977),
        dec: Angle.Degrees(-10.80953042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116466"},
        {"Hipparcos Number", "HIP 65421"},
        {"Smithsonian Astrophysical Observation", "SAO 224118"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.13967181),
        dec: Angle.Degrees(-43.08287537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190085"},
        {"Hipparcos Number", "HIP 98900"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.25806602),
        dec: Angle.Degrees(-43.08280425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24234"},
        {"Hipparcos Number", "HIP 17902"},
        {"Geneva Identification System", "GEN# +1.00024234"},
        {"Smithsonian Astrophysical Observation", "SAO 216508"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.43166697),
        dec: Angle.Degrees(-43.08254360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1549"},
        {"Hipparcos Number", "HIP 1574"},
        {"Smithsonian Astrophysical Observation", "SAO 215053"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.90695646),
        dec: Angle.Degrees(-43.08212128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198804"},
        {"Hipparcos Number", "HIP 103179"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.57516125),
        dec: Angle.Degrees(-43.08207191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166246"},
        {"Hipparcos Number", "HIP 89160"},
        {"Smithsonian Astrophysical Observation", "SAO 228789"},
    },
    visualMagnitude: 7.57,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.94579990),
        dec: Angle.Degrees(-43.08201297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119998"},
        {"Hipparcos Number", "HIP 67303"},
        {"Smithsonian Astrophysical Observation", "SAO 224426"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.89830361),
        dec: Angle.Degrees(-43.08075239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92499"},
        {"Hipparcos Number", "HIP 52218"},
        {"Renson", "Renson 26670"},
        {"Smithsonian Astrophysical Observation", "SAO 222240"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.03583822),
        dec: Angle.Degrees(-43.08068309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102994"},
        {"Hipparcos Number", "HIP 57817"},
        {"Smithsonian Astrophysical Observation", "SAO 223065"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.83868431),
        dec: Angle.Degrees(-43.07973295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217766"},
        {"Hipparcos Number", "HIP 113858"},
        {"Geneva Identification System", "GEN# +1.00217766"},
        {"Smithsonian Astrophysical Observation", "SAO 231414"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.86894798),
        dec: Angle.Degrees(-43.07817657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185815"},
        {"Hipparcos Number", "HIP 96978"},
        {"Smithsonian Astrophysical Observation", "SAO 229825"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.68767124),
        dec: Angle.Degrees(-43.07532863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111984"},
        {"Hipparcos Number", "HIP 62907"},
        {"Geneva Identification System", "GEN# +1.00111984"},
        {"Smithsonian Astrophysical Observation", "SAO 223737"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.38948805),
        dec: Angle.Degrees(-43.07511592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20794"},
        {"Hipparcos Number", "HIP 15510"},
        {"Cincinnati Publication", "Ci 20 227"},
        {"Fundamental Katalog 5th Edition", "FK5 119"},
        {"Geneva Identification System", "GEN# +1.00020794"},
        {"Smithsonian Astrophysical Observation", "SAO 216263"},
        {"Wilson Evans Batten Catalogue", "WEB 2978"},
    },
    visualMagnitude: 4.26,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.97177014),
        dec: Angle.Degrees(-43.07154929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3038.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 726.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152540"},
        {"Hipparcos Number", "HIP 82850"},
        {"Celescope Catalog", "CEL 4455"},
        {"Geneva Identification System", "GEN# +1.00152540"},
        {"Smithsonian Astrophysical Observation", "SAO 227446"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.97288989),
        dec: Angle.Degrees(-43.07084597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213717"},
        {"Hipparcos Number", "HIP 111407"},
        {"Geneva Identification System", "GEN# +1.00213717"},
        {"Smithsonian Astrophysical Observation", "SAO 231196"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.54450538),
        dec: Angle.Degrees(-43.06782091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 140.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 903"},
        {"Hipparcos Number", "HIP 1058"},
        {"Geneva Identification System", "GEN# +1.00000903"},
        {"Smithsonian Astrophysical Observation", "SAO 215005"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.29159465),
        dec: Angle.Degrees(-43.06516969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196650"},
        {"Hipparcos Number", "HIP 102015"},
        {"Smithsonian Astrophysical Observation", "SAO 230318"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.08578742),
        dec: Angle.Degrees(-43.06410258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6444"},
        {"Hipparcos Number", "HIP 5063"},
        {"Geneva Identification System", "GEN# +1.00006444"},
        {"Smithsonian Astrophysical Observation", "SAO 215354"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.19530980),
        dec: Angle.Degrees(-43.06409328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115068"},
        {"Hipparcos Number", "HIP 64677"},
        {"Geneva Identification System", "GEN# +1.00115068"},
        {"Smithsonian Astrophysical Observation", "SAO 224009"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.84417967),
        dec: Angle.Degrees(-43.06301302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35903"},
        {"Hipparcos Number", "HIP 25382"},
        {"Smithsonian Astrophysical Observation", "SAO 217331"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.45940135),
        dec: Angle.Degrees(-43.06204610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158323"},
        {"Henry Draper 2", "HD 158323A"},
        {"Hipparcos Number", "HIP 85685"},
        {"Geneva Identification System", "GEN# +1.00158323"},
        {"Smithsonian Astrophysical Observation", "SAO 228049"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.66428650),
        dec: Angle.Degrees(-43.06175814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107021"},
        {"Hipparcos Number", "HIP 60020"},
        {"Geneva Identification System", "GEN# +1.00107021"},
        {"Smithsonian Astrophysical Observation", "SAO 223347"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.63985209),
        dec: Angle.Degrees(-43.06159004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31311"},
        {"Hipparcos Number", "HIP 22674"},
        {"Geneva Identification System", "GEN# +1.00031311"},
        {"Smithsonian Astrophysical Observation", "SAO 217051"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.14740545),
        dec: Angle.Degrees(-43.06067465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66252"},
        {"Hipparcos Number", "HIP 39185"},
        {"Smithsonian Astrophysical Observation", "SAO 219299"},
    },
    visualMagnitude: 7.35,
    bvColour: -0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.22421857),
        dec: Angle.Degrees(-43.06015212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125383"},
        {"Hipparcos Number", "HIP 70054"},
        {"Geneva Identification System", "GEN# +1.00125383J"},
        {"Smithsonian Astrophysical Observation", "SAO 224838"},
    },
    visualMagnitude: 5.55,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.04045606),
        dec: Angle.Degrees(-43.05886202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49849"},
        {"Hipparcos Number", "HIP 32619"},
        {"Renson", "Renson 13510"},
        {"Smithsonian Astrophysical Observation", "SAO 218209"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.08660589),
        dec: Angle.Degrees(-43.05620076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191991"},
        {"Hipparcos Number", "HIP 99752"},
        {"Smithsonian Astrophysical Observation", "SAO 230115"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.59592240),
        dec: Angle.Degrees(-43.05334672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91820"},
        {"Hipparcos Number", "HIP 51827"},
        {"Smithsonian Astrophysical Observation", "SAO 222171"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.82436261),
        dec: Angle.Degrees(-43.05235003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31131"},
        {"Hipparcos Number", "HIP 22551"},
        {"Geneva Identification System", "GEN# +1.00031131"},
        {"Smithsonian Astrophysical Observation", "SAO 217041"},
        {"Wilson Evans Batten Catalogue", "WEB 4359"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.80404369),
        dec: Angle.Degrees(-43.05186150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152161"},
        {"Hipparcos Number", "HIP 82650"},
        {"Geneva Identification System", "GEN# +1.00152161"},
        {"Smithsonian Astrophysical Observation", "SAO 227359"},
    },
    visualMagnitude: 5.95,
    bvColour: 1.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.42682079),
        dec: Angle.Degrees(-43.05089096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91034"},
        {"Hipparcos Number", "HIP 51379"},
        {"Smithsonian Astrophysical Observation", "SAO 222095"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.40945835),
        dec: Angle.Degrees(-43.05083237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116081"},
        {"Hipparcos Number", "HIP 65229"},
        {"Smithsonian Astrophysical Observation", "SAO 224089"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.51192814),
        dec: Angle.Degrees(-43.05039760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67506",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67506"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.49640107),
        dec: Angle.Degrees(-43.05036504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88811"},
        {"Hipparcos Number", "HIP 50095"},
        {"Smithsonian Astrophysical Observation", "SAO 221876"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.42806745),
        dec: Angle.Degrees(-43.04749689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11890"},
        {"Hipparcos Number", "HIP 8992"},
        {"Smithsonian Astrophysical Observation", "SAO 215703"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.96102009),
        dec: Angle.Degrees(-43.04703920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114797"},
        {"Hipparcos Number", "HIP 64524"},
        {"Smithsonian Astrophysical Observation", "SAO 223985"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.36833028),
        dec: Angle.Degrees(-43.04356109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189140"},
        {"Hipparcos Number", "HIP 98485"},
        {"Geneva Identification System", "GEN# +1.00189140"},
        {"Smithsonian Astrophysical Observation", "SAO 229977"},
        {"Wilson Evans Batten Catalogue", "WEB 17389"},
    },
    visualMagnitude: 6.11,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.11028267),
        dec: Angle.Degrees(-43.04333151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196212"},
        {"Hipparcos Number", "HIP 101758"},
        {"Smithsonian Astrophysical Observation", "SAO 230299"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.35597707),
        dec: Angle.Degrees(-43.04314886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210051"},
        {"Hipparcos Number", "HIP 109300"},
        {"Geneva Identification System", "GEN# +1.00210051"},
        {"Smithsonian Astrophysical Observation", "SAO 230999"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.16389080),
        dec: Angle.Degrees(-43.04119631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108048"},
        {"Hipparcos Number", "HIP 60575"},
        {"Smithsonian Astrophysical Observation", "SAO 223424"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.24653667),
        dec: Angle.Degrees(-43.04045000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80788"},
        {"Hipparcos Number", "HIP 45806"},
        {"Smithsonian Astrophysical Observation", "SAO 221078"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.11463733),
        dec: Angle.Degrees(-43.03402312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146220"},
        {"Hipparcos Number", "HIP 79784"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.24052414),
        dec: Angle.Degrees(-43.03302693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31943"},
        {"Hipparcos Number", "HIP 23055"},
        {"Geneva Identification System", "GEN# +1.00031943"},
        {"Smithsonian Astrophysical Observation", "SAO 217082"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.41897155),
        dec: Angle.Degrees(-43.03247952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29677",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29677"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.78242072),
        dec: Angle.Degrees(-43.03194131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222838"},
        {"Hipparcos Number", "HIP 117092"},
        {"Fundamental Katalog 5th Edition", "FK5 6103"},
        {"Geneva Identification System", "GEN# +1.00222838"},
        {"Renson", "Renson 61110"},
        {"Smithsonian Astrophysical Observation", "SAO 231759"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.06524156),
        dec: Angle.Degrees(-43.02443054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60224"},
        {"Hipparcos Number", "HIP 36583"},
        {"Smithsonian Astrophysical Observation", "SAO 218777"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.86704911),
        dec: Angle.Degrees(-43.02408836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73840",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73840"},
        {"Smithsonian Astrophysical Observation", "SAO 159016"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.35563834),
        dec: Angle.Degrees(-10.59579712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107063"},
        {"Hipparcos Number", "HIP 60040"},
        {"Smithsonian Astrophysical Observation", "SAO 223349"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.69610021),
        dec: Angle.Degrees(-43.02368260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94724"},
        {"Hipparcos Number", "HIP 53411"},
        {"Geneva Identification System", "GEN# +1.00094724"},
        {"Smithsonian Astrophysical Observation", "SAO 222423"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.86354781),
        dec: Angle.Degrees(-43.02054885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30350"},
        {"Hipparcos Number", "HIP 22070"},
        {"Smithsonian Astrophysical Observation", "SAO 216974"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.20623379),
        dec: Angle.Degrees(-43.01770395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31449"},
        {"Hipparcos Number", "HIP 22770"},
        {"Smithsonian Astrophysical Observation", "SAO 217057"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.47703102),
        dec: Angle.Degrees(-43.01368952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44467"},
        {"Hipparcos Number", "HIP 30084"},
        {"Smithsonian Astrophysical Observation", "SAO 217853"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.95723675),
        dec: Angle.Degrees(-43.01244659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139579"},
        {"Hipparcos Number", "HIP 76778"},
        {"Celescope Catalog", "CEL 4390"},
        {"Geneva Identification System", "GEN# +1.00139579"},
        {"Smithsonian Astrophysical Observation", "SAO 226053"},
    },
    visualMagnitude: 8.36,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.14006604),
        dec: Angle.Degrees(-43.01243592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87046",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87046"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.78461032),
        dec: Angle.Degrees(-43.01187908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216530"},
        {"Hipparcos Number", "HIP 113103"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.57236056),
        dec: Angle.Degrees(-43.01041361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29993"},
        {"Hipparcos Number", "HIP 21830"},
        {"Geneva Identification System", "GEN# +1.00029993"},
        {"Smithsonian Astrophysical Observation", "SAO 216934"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.39631825),
        dec: Angle.Degrees(-43.00945905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105796",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105796"},
    },
    visualMagnitude: 10.83,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.38787951),
        dec: Angle.Degrees(-43.00781491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197957"},
        {"Hipparcos Number", "HIP 102705"},
        {"Smithsonian Astrophysical Observation", "SAO 230381"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.15069574),
        dec: Angle.Degrees(-43.00748674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43138"},
        {"Hipparcos Number", "HIP 29467"},
        {"Geneva Identification System", "GEN# +1.00043138"},
        {"Smithsonian Astrophysical Observation", "SAO 217777"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.13081344),
        dec: Angle.Degrees(-43.00634916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152941"},
        {"Hipparcos Number", "HIP 83065"},
        {"Fundamental Katalog 5th Edition", "FK5 5496"},
        {"Smithsonian Astrophysical Observation", "SAO 227507"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.59831480),
        dec: Angle.Degrees(-43.00490271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139945"},
        {"Hipparcos Number", "HIP 76948"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.67455915),
        dec: Angle.Degrees(-43.00482740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17478"},
        {"Hipparcos Number", "HIP 12963"},
        {"Smithsonian Astrophysical Observation", "SAO 216045"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.68757477),
        dec: Angle.Degrees(-43.00475664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200011"},
        {"Hipparcos Number", "HIP 103814"},
        {"Geneva Identification System", "GEN# +1.00200011"},
        {"Smithsonian Astrophysical Observation", "SAO 230492"},
        {"Wilson Evans Batten Catalogue", "WEB 18893"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.55280088),
        dec: Angle.Degrees(-43.00187798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9907"},
        {"Hipparcos Number", "HIP 7442"},
        {"Geneva Identification System", "GEN# +1.00009907"},
        {"Smithsonian Astrophysical Observation", "SAO 215574"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.96045657),
        dec: Angle.Degrees(-43.00170144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6911"},
        {"Hipparcos Number", "HIP 5400"},
        {"Smithsonian Astrophysical Observation", "SAO 215384"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.27402811),
        dec: Angle.Degrees(-43.00139320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105497"},
        {"Hipparcos Number", "HIP 59216"},
        {"Smithsonian Astrophysical Observation", "SAO 223237"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.17878913),
        dec: Angle.Degrees(-43.00135152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128555"},
        {"Hipparcos Number", "HIP 71617"},
        {"Fundamental Katalog 5th Edition", "FK5 5297"},
        {"Geneva Identification System", "GEN# +1.00128555"},
        {"Smithsonian Astrophysical Observation", "SAO 225088"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.70240913),
        dec: Angle.Degrees(-43.00083735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132515"},
        {"Hipparcos Number", "HIP 73479"},
        {"Renson", "Renson 37610"},
        {"Smithsonian Astrophysical Observation", "SAO 225373"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.25561412),
        dec: Angle.Degrees(-42.99935338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86228",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Sargas"},
        {"Henry Draper", "HD 159532"},
        {"Henry Draper 2", "HD 159532A"},
        {"Hipparcos Number", "HIP 86228"},
        {"Celescope Catalog", "CEL 4542"},
        {"Fundamental Katalog 5th Edition", "FK5 654"},
        {"Geneva Identification System", "GEN# +1.00159532"},
        {"Smithsonian Astrophysical Observation", "SAO 228201"},
        {"Wilson Evans Batten Catalogue", "WEB 14543"},
    },
    visualMagnitude: 1.86,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.32969072),
        dec: Angle.Degrees(-42.99782155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200026"},
        {"Hipparcos Number", "HIP 103819"},
        {"Geneva Identification System", "GEN# +1.20200011"},
        {"Geneva Identification System 2", "GEN# +1.00200026"},
        {"Smithsonian Astrophysical Observation", "SAO 230494"},
        {"Wilson Evans Batten Catalogue", "WEB 18898"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.57363196),
        dec: Angle.Degrees(-42.99714155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68109",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68109"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.15825285),
        dec: Angle.Degrees(-42.99308283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123346"},
        {"Hipparcos Number", "HIP 69059"},
        {"Smithsonian Astrophysical Observation", "SAO 224713"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.03518324),
        dec: Angle.Degrees(-42.99285657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86177"},
        {"Hipparcos Number", "HIP 48692"},
        {"Smithsonian Astrophysical Observation", "SAO 221612"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.94616510),
        dec: Angle.Degrees(-42.99181566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151966"},
        {"Hipparcos Number", "HIP 82560"},
        {"Smithsonian Astrophysical Observation", "SAO 227331"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.13290193),
        dec: Angle.Degrees(-42.99173296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141315"},
        {"Hipparcos Number", "HIP 77558"},
        {"Smithsonian Astrophysical Observation", "SAO 226261"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.52454676),
        dec: Angle.Degrees(-42.98987291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73634"},
        {"Hipparcos Number", "HIP 42312"},
        {"Celescope Catalog", "CEL 2720"},
        {"Fundamental Katalog 5th Edition", "FK5 324"},
        {"Geneva Identification System", "GEN# +1.00073634"},
        {"Renson", "Renson 20470"},
        {"Smithsonian Astrophysical Observation", "SAO 220204"},
        {"Wilson Evans Batten Catalogue", "WEB 8130"},
    },
    visualMagnitude: 4.11,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.41100573),
        dec: Angle.Degrees(-42.98910371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97684"},
        {"Hipparcos Number", "HIP 54860"},
        {"Renson", "Renson 28170"},
        {"Smithsonian Astrophysical Observation", "SAO 222656"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.49708001),
        dec: Angle.Degrees(-42.98804715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68601"},
        {"Hipparcos Number", "HIP 40096"},
        {"Geneva Identification System", "GEN# +1.00068601J"},
        {"Renson", "Renson 19020"},
        {"Smithsonian Astrophysical Observation", "SAO 219569"},
        {"Wilson Evans Batten Catalogue", "WEB 7826"},
    },
    visualMagnitude: 4.73,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.85790344),
        dec: Angle.Degrees(-42.98728888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88780"},
        {"Hipparcos Number", "HIP 50086"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.38892064),
        dec: Angle.Degrees(-42.98719791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15973",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15973"},
    },
    visualMagnitude: 11.26,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.41432881),
        dec: Angle.Degrees(-42.98635674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 322.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179163"},
        {"Hipparcos Number", "HIP 94451"},
        {"Smithsonian Astrophysical Observation", "SAO 229560"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.34250095),
        dec: Angle.Degrees(-42.98483267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110018"},
        {"Hipparcos Number", "HIP 61764"},
        {"Smithsonian Astrophysical Observation", "SAO 223578"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.88248064),
        dec: Angle.Degrees(-42.98432561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12892"},
        {"Hipparcos Number", "HIP 9728"},
        {"Smithsonian Astrophysical Observation", "SAO 215761"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.27930660),
        dec: Angle.Degrees(-42.98164492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207726"},
        {"Hipparcos Number", "HIP 107942"},
        {"Smithsonian Astrophysical Observation", "SAO 230873"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.02774118),
        dec: Angle.Degrees(-42.97956624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159985"},
        {"Hipparcos Number", "HIP 86427"},
        {"Geneva Identification System", "GEN# +1.00159985"},
        {"Smithsonian Astrophysical Observation", "SAO 228245"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.88651353),
        dec: Angle.Degrees(-42.97846509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62846"},
        {"Hipparcos Number", "HIP 37699"},
        {"Smithsonian Astrophysical Observation", "SAO 218940"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.01395715),
        dec: Angle.Degrees(-42.97766431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154504"},
        {"Hipparcos Number", "HIP 83818"},
        {"Smithsonian Astrophysical Observation", "SAO 227647"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.95067874),
        dec: Angle.Degrees(-42.97677180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14822"},
        {"Hipparcos Number", "HIP 11034"},
        {"Smithsonian Astrophysical Observation", "SAO 215876"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.52746722),
        dec: Angle.Degrees(-42.97676393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211068"},
        {"Hipparcos Number", "HIP 109904"},
        {"Smithsonian Astrophysical Observation", "SAO 231054"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.89951225),
        dec: Angle.Degrees(-42.97673104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74261",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74261"},
        {"Geneva Identification System", "GEN# -0.04210084"},
    },
    visualMagnitude: 10.63,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.64986131),
        dec: Angle.Degrees(-42.97627919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -324.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -291.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189030"},
        {"Hipparcos Number", "HIP 98420"},
        {"Smithsonian Astrophysical Observation", "SAO 229968"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.96131811),
        dec: Angle.Degrees(-42.97616789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209704"},
        {"Hipparcos Number", "HIP 109138"},
        {"Smithsonian Astrophysical Observation", "SAO 230982"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.60414987),
        dec: Angle.Degrees(-42.97380636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107319"},
        {"Hipparcos Number", "HIP 60182"},
        {"Smithsonian Astrophysical Observation", "SAO 223362"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.11580420),
        dec: Angle.Degrees(-42.97309985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113760",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113760"},
    },
    visualMagnitude: 10.71,
    bvColour: 1.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.56744194),
        dec: Angle.Degrees(-42.97111636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -157.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200320"},
        {"Hipparcos Number", "HIP 103986"},
        {"Smithsonian Astrophysical Observation", "SAO 230504"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.02981184),
        dec: Angle.Degrees(-42.96718127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37655"},
        {"Hipparcos Number", "HIP 26488"},
        {"Geneva Identification System", "GEN# +1.00037655"},
        {"Smithsonian Astrophysical Observation", "SAO 217439"},
        {"Wilson Evans Batten Catalogue", "WEB 5223"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.50745443),
        dec: Angle.Degrees(-42.96415150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 274.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16456"},
        {"Hipparcos Number", "HIP 12199"},
        {"Geneva Identification System", "GEN# +1.00016456"},
        {"Smithsonian Astrophysical Observation", "SAO 215966"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.27367764),
        dec: Angle.Degrees(-42.96336228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87946"},
        {"Hipparcos Number", "HIP 49598"},
        {"Geneva Identification System", "GEN# +1.00087946"},
        {"Smithsonian Astrophysical Observation", "SAO 221788"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.86787047),
        dec: Angle.Degrees(-42.95985641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57688",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57688"},
        {"Smithsonian Astrophysical Observation", "SAO 223045"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.46684488),
        dec: Angle.Degrees(-42.95931948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106867"},
        {"Hipparcos Number", "HIP 59924"},
        {"Smithsonian Astrophysical Observation", "SAO 223334"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.37995353),
        dec: Angle.Degrees(-42.95689861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13377"},
        {"Hipparcos Number", "HIP 10071"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.39871454),
        dec: Angle.Degrees(-42.95662587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64269"},
        {"Hipparcos Number", "HIP 38337"},
        {"Smithsonian Astrophysical Observation", "SAO 219067"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.79041467),
        dec: Angle.Degrees(-42.95636251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193606"},
        {"Hipparcos Number", "HIP 100495"},
        {"Geneva Identification System", "GEN# +1.00193606"},
        {"Smithsonian Astrophysical Observation", "SAO 230179"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.68054107),
        dec: Angle.Degrees(-42.95571827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171577"},
        {"Hipparcos Number", "HIP 91327"},
        {"Geneva Identification System", "GEN# +1.00171577"},
        {"Smithsonian Astrophysical Observation", "SAO 229152"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.41509208),
        dec: Angle.Degrees(-42.95545858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203105"},
        {"Hipparcos Number", "HIP 105452"},
        {"Smithsonian Astrophysical Observation", "SAO 230647"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.37774331),
        dec: Angle.Degrees(-42.95144889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149608"},
        {"Hipparcos Number", "HIP 81415"},
    },
    visualMagnitude: 8.44,
    bvColour: 2.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.41697292),
        dec: Angle.Degrees(-42.95131530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7080"},
        {"Hipparcos Number", "HIP 5505"},
        {"Geneva Identification System", "GEN# +1.00007080"},
        {"Smithsonian Astrophysical Observation", "SAO 215394"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.62990306),
        dec: Angle.Degrees(-42.95117015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79401"},
        {"Hipparcos Number", "HIP 45185"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.11469016),
        dec: Angle.Degrees(-42.95062489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197484"},
        {"Hipparcos Number", "HIP 102446"},
        {"Geneva Identification System", "GEN# +1.00197484"},
        {"Smithsonian Astrophysical Observation", "SAO 230354"},
        {"Wilson Evans Batten Catalogue", "WEB 18551"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.38542369),
        dec: Angle.Degrees(-42.94965255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -202.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12215"},
        {"Hipparcos Number", "HIP 9254"},
        {"Smithsonian Astrophysical Observation", "SAO 215720"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.73591223),
        dec: Angle.Degrees(-42.94911834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14195"},
        {"Hipparcos Number", "HIP 10603"},
        {"Smithsonian Astrophysical Observation", "SAO 215845"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.13142455),
        dec: Angle.Degrees(-42.94863112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66812"},
        {"Hipparcos Number", "HIP 39420"},
        {"Geneva Identification System", "GEN# +1.00066812"},
        {"Smithsonian Astrophysical Observation", "SAO 219355"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.87341734),
        dec: Angle.Degrees(-42.94832058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98938"},
        {"Hipparcos Number", "HIP 55552"},
        {"Smithsonian Astrophysical Observation", "SAO 222758"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.68460673),
        dec: Angle.Degrees(-42.94801937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 325935"},
        {"Hipparcos Number", "HIP 81725"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.39506680),
        dec: Angle.Degrees(-42.94777588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184688"},
        {"Hipparcos Number", "HIP 96529"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.37194213),
        dec: Angle.Degrees(-42.94543359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 383"},
        {"Hipparcos Number", "HIP 674"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.08770637),
        dec: Angle.Degrees(-42.94365592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58155",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58155"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.90008881),
        dec: Angle.Degrees(-42.94289110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34209"},
        {"Hipparcos Number", "HIP 24358"},
        {"Smithsonian Astrophysical Observation", "SAO 217243"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.39923045),
        dec: Angle.Degrees(-42.94240036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194815"},
        {"Hipparcos Number", "HIP 101083"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.36271937),
        dec: Angle.Degrees(-42.93975022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206921"},
        {"Hipparcos Number", "HIP 107507"},
        {"Smithsonian Astrophysical Observation", "SAO 230834"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.60969434),
        dec: Angle.Degrees(-42.93729557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168560"},
        {"Hipparcos Number", "HIP 90039"},
        {"Geneva Identification System", "GEN# +1.00168560"},
        {"Smithsonian Astrophysical Observation", "SAO 228955"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.59117036),
        dec: Angle.Degrees(-42.93439570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115371"},
        {"Hipparcos Number", "HIP 64837"},
        {"Smithsonian Astrophysical Observation", "SAO 224037"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.37077287),
        dec: Angle.Degrees(-42.93291769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108760"},
        {"Hipparcos Number", "HIP 60984"},
        {"Smithsonian Astrophysical Observation", "SAO 223472"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.50197102),
        dec: Angle.Degrees(-42.92960935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74385"},
        {"Hipparcos Number", "HIP 42697"},
        {"Geneva Identification System", "GEN# +1.00074385A"},
        {"Smithsonian Astrophysical Observation", "SAO 220304"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.53221220),
        dec: Angle.Degrees(-42.92922593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -269.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10167"},
        {"Hipparcos Number", "HIP 7649"},
        {"Geneva Identification System", "GEN# +1.00010167"},
        {"Smithsonian Astrophysical Observation", "SAO 215592"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.62823045),
        dec: Angle.Degrees(-42.92785484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173773"},
        {"Hipparcos Number", "HIP 92326"},
        {"Smithsonian Astrophysical Observation", "SAO 229301"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.25807825),
        dec: Angle.Degrees(-42.92785460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14207"},
        {"Hipparcos Number", "HIP 10613"},
        {"Smithsonian Astrophysical Observation", "SAO 215846"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.16090870),
        dec: Angle.Degrees(-42.92694704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205096"},
        {"Hipparcos Number", "HIP 106500"},
        {"Geneva Identification System", "GEN# +1.00205096"},
        {"Smithsonian Astrophysical Observation", "SAO 230741"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.57157750),
        dec: Angle.Degrees(-42.92465886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162786"},
        {"Hipparcos Number", "HIP 87699"},
        {"Celescope Catalog", "CEL 4578"},
        {"Geneva Identification System", "GEN# +1.00162786"},
        {"Renson", "Renson 46030"},
        {"Smithsonian Astrophysical Observation", "SAO 228536"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.69998008),
        dec: Angle.Degrees(-42.92377346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189719"},
        {"Hipparcos Number", "HIP 98739"},
        {"Geneva Identification System", "GEN# +1.00189719J"},
        {"Smithsonian Astrophysical Observation", "SAO 230010"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.81942303),
        dec: Angle.Degrees(-42.92352143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39901"},
        {"Hipparcos Number", "HIP 27835"},
        {"Geneva Identification System", "GEN# +1.00039901"},
        {"Smithsonian Astrophysical Observation", "SAO 217599"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.34519480),
        dec: Angle.Degrees(-42.92135720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167445"},
        {"Hipparcos Number", "HIP 89616"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.31944301),
        dec: Angle.Degrees(-42.91892727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22132"},
        {"Hipparcos Number", "HIP 16482"},
        {"Smithsonian Astrophysical Observation", "SAO 216369"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.05962834),
        dec: Angle.Degrees(-42.91826306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 718",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 718"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.22041567),
        dec: Angle.Degrees(-42.91821148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177688"},
        {"Hipparcos Number", "HIP 93938"},
        {"Geneva Identification System", "GEN# +1.00177688"},
        {"Smithsonian Astrophysical Observation", "SAO 229503"},
        {"Wilson Evans Batten Catalogue", "WEB 16348"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.91313707),
        dec: Angle.Degrees(-42.91757168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72108",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72108"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.25106861),
        dec: Angle.Degrees(-42.91735447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85966"},
        {"Hipparcos Number", "HIP 48565"},
        {"Geneva Identification System", "GEN# +1.00085966"},
        {"Smithsonian Astrophysical Observation", "SAO 221590"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.57573785),
        dec: Angle.Degrees(-42.91715399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159111"},
        {"Hipparcos Number", "HIP 86031"},
        {"Celescope Catalog", "CEL 4537"},
        {"Geneva Identification System", "GEN# +1.00159111"},
        {"Smithsonian Astrophysical Observation", "SAO 228149"},
    },
    visualMagnitude: 8.05,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.72718125),
        dec: Angle.Degrees(-42.91707789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26262"},
        {"Hipparcos Number", "HIP 19242"},
        {"Geneva Identification System", "GEN# +1.00026262"},
        {"Smithsonian Astrophysical Observation", "SAO 216655"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.85517369),
        dec: Angle.Degrees(-42.91681040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112213"},
        {"Hipparcos Number", "HIP 63066"},
        {"Fundamental Katalog 5th Edition", "FK5 3029"},
        {"Geneva Identification System", "GEN# +1.00112213"},
        {"Smithsonian Astrophysical Observation", "SAO 223760"},
        {"Wilson Evans Batten Catalogue", "WEB 11182"},
    },
    visualMagnitude: 5.46,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.83108971),
        dec: Angle.Degrees(-42.91570150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170128"},
        {"Hipparcos Number", "HIP 90653"},
        {"Smithsonian Astrophysical Observation", "SAO 229067"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.46377462),
        dec: Angle.Degrees(-42.91208156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72320"},
        {"Hipparcos Number", "HIP 41724"},
        {"Smithsonian Astrophysical Observation", "SAO 220019"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.62130035),
        dec: Angle.Degrees(-42.90947059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164300"},
        {"Hipparcos Number", "HIP 88338"},
        {"Smithsonian Astrophysical Observation", "SAO 228643"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.60949310),
        dec: Angle.Degrees(-42.90468701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210724"},
        {"Hipparcos Number", "HIP 109704"},
        {"Smithsonian Astrophysical Observation", "SAO 231036"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.32286446),
        dec: Angle.Degrees(-42.90406103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109421",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109421"},
    },
    visualMagnitude: 10.25,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.53347227),
        dec: Angle.Degrees(-42.90202878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92945",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92945"},
    },
    visualMagnitude: 11.91,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.05128883),
        dec: Angle.Degrees(-42.90162670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193132"},
        {"Hipparcos Number", "HIP 100278"},
        {"Geneva Identification System", "GEN# +1.00193132"},
        {"Smithsonian Astrophysical Observation", "SAO 230161"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.09445160),
        dec: Angle.Degrees(-42.90120041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220633"},
        {"Hipparcos Number", "HIP 115647"},
        {"Smithsonian Astrophysical Observation", "SAO 231605"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.41900019),
        dec: Angle.Degrees(-42.89971405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145921"},
        {"Hipparcos Number", "HIP 79661"},
        {"Geneva Identification System", "GEN# +1.00145921"},
        {"Smithsonian Astrophysical Observation", "SAO 226603"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.84991794),
        dec: Angle.Degrees(-42.89940996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72302",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72302"},
        {"Geneva Identification System", "GEN# -0.04209658"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.77488173),
        dec: Angle.Degrees(-42.89579392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108897"},
        {"Hipparcos Number", "HIP 61070"},
        {"Smithsonian Astrophysical Observation", "SAO 223483"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.75208482),
        dec: Angle.Degrees(-42.89487419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156292"},
        {"Hipparcos Number", "HIP 84687"},
        {"Celescope Catalog", "CEL 4500"},
        {"Geneva Identification System", "GEN# +2.63220027"},
        {"Smithsonian Astrophysical Observation", "SAO 227814"},
        {"New General Catalogue", "NGC 6322 27"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.69087582),
        dec: Angle.Degrees(-42.89164408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16754"},
        {"Henry Draper 2", "HD 16754A"},
        {"Henry Draper 3", "HD 16754B"},
        {"Hipparcos Number", "HIP 12413"},
        {"Fundamental Katalog 5th Edition", "FK5 2185"},
        {"Geneva Identification System", "GEN# +1.00016754"},
        {"Smithsonian Astrophysical Observation", "SAO 215996"},
        {"Wilson Evans Batten Catalogue", "WEB 2542"},
    },
    visualMagnitude: 4.74,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.94966387),
        dec: Angle.Degrees(-42.89163328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136221"},
        {"Hipparcos Number", "HIP 75114"},
        {"Smithsonian Astrophysical Observation", "SAO 225686"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.24166661),
        dec: Angle.Degrees(-42.88933436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61472"},
        {"Hipparcos Number", "HIP 37115"},
        {"Smithsonian Astrophysical Observation", "SAO 218845"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.39255375),
        dec: Angle.Degrees(-42.88911803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149017"},
        {"Hipparcos Number", "HIP 81106"},
        {"Geneva Identification System", "GEN# +1.00149017"},
        {"Smithsonian Astrophysical Observation", "SAO 226899"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.48045447),
        dec: Angle.Degrees(-42.88881893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64365"},
        {"Hipparcos Number", "HIP 38370"},
        {"Celescope Catalog", "CEL 2067"},
        {"Geneva Identification System", "GEN# +1.00064365"},
        {"Smithsonian Astrophysical Observation", "SAO 219076"},
        {"Wilson Evans Batten Catalogue", "WEB 7549"},
    },
    visualMagnitude: 6.05,
    bvColour: -0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.91817864),
        dec: Angle.Degrees(-42.88822205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66"},
        {"Hipparcos Number", "HIP 457"},
        {"Geneva Identification System", "GEN# +1.00000066"},
        {"Smithsonian Astrophysical Observation", "SAO 214959"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.36678819),
        dec: Angle.Degrees(-42.88738421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215701"},
        {"Hipparcos Number", "HIP 112541"},
        {"Smithsonian Astrophysical Observation", "SAO 231300"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.92350642),
        dec: Angle.Degrees(-42.88661487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199544"},
        {"Hipparcos Number", "HIP 103588"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.82879900),
        dec: Angle.Degrees(-42.88653190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44405"},
        {"Hipparcos Number", "HIP 30054"},
        {"Smithsonian Astrophysical Observation", "SAO 217847"},
    },
    visualMagnitude: 8.07,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.86866807),
        dec: Angle.Degrees(-42.88638530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86888"},
        {"Hipparcos Number", "HIP 49047"},
        {"Smithsonian Astrophysical Observation", "SAO 221691"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.11250360),
        dec: Angle.Degrees(-42.88637060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133532"},
        {"Hipparcos Number", "HIP 73935"},
        {"Smithsonian Astrophysical Observation", "SAO 225446"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.63552679),
        dec: Angle.Degrees(-42.88562574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216667"},
        {"Hipparcos Number", "HIP 113196"},
        {"Fundamental Katalog 5th Edition", "FK5 6027"},
        {"Geneva Identification System", "GEN# +1.00216667"},
        {"Smithsonian Astrophysical Observation", "SAO 231355"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.85471018),
        dec: Angle.Degrees(-42.88440148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181924"},
        {"Hipparcos Number", "HIP 95381"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.04848914),
        dec: Angle.Degrees(-42.88342448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52675"},
        {"Hipparcos Number", "HIP 33697"},
        {"Smithsonian Astrophysical Observation", "SAO 218376"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.02090812),
        dec: Angle.Degrees(-42.88331494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72938",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72938"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.60187200),
        dec: Angle.Degrees(-42.88282256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113304",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113304"},
    },
    visualMagnitude: 10.77,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.18076030),
        dec: Angle.Degrees(-42.88182472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90531"},
        {"Hipparcos Number", "HIP 51082"},
        {"Smithsonian Astrophysical Observation", "SAO 222048"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.55333900),
        dec: Angle.Degrees(-42.88105632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57113",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57113"},
    },
    visualMagnitude: 11.43,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.63124309),
        dec: Angle.Degrees(-42.88093056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147034"},
        {"Hipparcos Number", "HIP 80125"},
        {"Smithsonian Astrophysical Observation", "SAO 226679"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.32978917),
        dec: Angle.Degrees(-42.88022696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159707"},
        {"Hipparcos Number", "HIP 86311"},
        {"Celescope Catalog", "CEL 4544"},
        {"Geneva Identification System", "GEN# +1.00159707"},
        {"Smithsonian Astrophysical Observation", "SAO 228220"},
        {"Wilson Evans Batten Catalogue", "WEB 14562"},
    },
    visualMagnitude: 6.09,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.53518901),
        dec: Angle.Degrees(-42.88020256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92795"},
        {"Hipparcos Number", "HIP 52362"},
        {"Geneva Identification System", "GEN# +1.00092795"},
        {"Smithsonian Astrophysical Observation", "SAO 222264"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.52708399),
        dec: Angle.Degrees(-42.87799791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117907"},
        {"Hipparcos Number", "HIP 66204"},
        {"Smithsonian Astrophysical Observation", "SAO 224250"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.54839721),
        dec: Angle.Degrees(-42.87762842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151158"},
        {"Hipparcos Number", "HIP 82199"},
        {"Geneva Identification System", "GEN# +1.00151158J"},
        {"Smithsonian Astrophysical Observation", "SAO 227219"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.89306046),
        dec: Angle.Degrees(-42.87673959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164545"},
        {"Hipparcos Number", "HIP 88457"},
    },
    visualMagnitude: 9.86,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.91214077),
        dec: Angle.Degrees(-42.87609673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89785"},
        {"Hipparcos Number", "HIP 50666"},
        {"Smithsonian Astrophysical Observation", "SAO 221976"},
    },
    visualMagnitude: 7.32,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.20169085),
        dec: Angle.Degrees(-42.87240184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41089"},
        {"Hipparcos Number", "HIP 28489"},
        {"Renson", "Renson 10990"},
        {"Smithsonian Astrophysical Observation", "SAO 217668"},
    },
    visualMagnitude: 6.58,
    bvColour: -0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.21263400),
        dec: Angle.Degrees(-42.87047953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80154"},
        {"Hipparcos Number", "HIP 45534"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.20548259),
        dec: Angle.Degrees(-42.86952337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55819"},
        {"Hipparcos Number", "HIP 34833"},
        {"Smithsonian Astrophysical Observation", "SAO 218533"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.13932231),
        dec: Angle.Degrees(-42.86839970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133937"},
        {"Hipparcos Number", "HIP 74100"},
        {"Celescope Catalog", "CEL 4341"},
        {"Geneva Identification System", "GEN# +1.00133937"},
        {"Smithsonian Astrophysical Observation", "SAO 225479"},
        {"Wilson Evans Batten Catalogue", "WEB 12659"},
    },
    visualMagnitude: 5.85,
    bvColour: -0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.16338993),
        dec: Angle.Degrees(-42.86786973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24340"},
        {"Hipparcos Number", "HIP 17984"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.66034546),
        dec: Angle.Degrees(-42.86744675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6520"},
        {"Hipparcos Number", "HIP 5116"},
        {"Smithsonian Astrophysical Observation", "SAO 215358"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.39149010),
        dec: Angle.Degrees(-42.86588652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198907"},
        {"Hipparcos Number", "HIP 103244"},
        {"Smithsonian Astrophysical Observation", "SAO 230435"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.75545185),
        dec: Angle.Degrees(-42.86487689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67513"},
        {"Hipparcos Number", "HIP 39682"},
        {"Smithsonian Astrophysical Observation", "SAO 219419"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.64638352),
        dec: Angle.Degrees(-42.86456179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75570",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75570"},
        {"Smithsonian Astrophysical Observation", "SAO 225775"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.57156833),
        dec: Angle.Degrees(-42.86303304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124873"},
        {"Hipparcos Number", "HIP 69795"},
        {"Smithsonian Astrophysical Observation", "SAO 224816"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.26831045),
        dec: Angle.Degrees(-42.86246961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84957",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84957"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.46255080),
        dec: Angle.Degrees(-42.86224334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137214"},
        {"Hipparcos Number", "HIP 75568"},
        {"Smithsonian Astrophysical Observation", "SAO 225774"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.56382826),
        dec: Angle.Degrees(-42.86222396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218630"},
        {"Hipparcos Number", "HIP 114382"},
        {"Geneva Identification System", "GEN# +1.00218630J"},
        {"Smithsonian Astrophysical Observation", "SAO 231464"},
    },
    visualMagnitude: 5.83,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.49016985),
        dec: Angle.Degrees(-42.86116912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -348.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149404"},
        {"Hipparcos Number", "HIP 81305"},
        {"Celescope Catalog", "CEL 4420"},
        {"Geneva Identification System", "GEN# +1.00149404"},
        {"Smithsonian Astrophysical Observation", "SAO 226953"},
        {"Wilson Evans Batten Catalogue", "WEB 13741"},
    },
    visualMagnitude: 5.46,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.09402476),
        dec: Angle.Degrees(-42.85885401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214409"},
        {"Hipparcos Number", "HIP 111782"},
        {"Smithsonian Astrophysical Observation", "SAO 231231"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.62698672),
        dec: Angle.Degrees(-42.85743341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26352"},
        {"Hipparcos Number", "HIP 19295"},
        {"Geneva Identification System", "GEN# +1.00026352"},
        {"Smithsonian Astrophysical Observation", "SAO 216659"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.04821913),
        dec: Angle.Degrees(-42.85402156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97789"},
        {"Hipparcos Number", "HIP 54903"},
        {"Geneva Identification System", "GEN# +1.00097789"},
        {"Smithsonian Astrophysical Observation", "SAO 222663"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.63471858),
        dec: Angle.Degrees(-42.85299327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109591"},
        {"Hipparcos Number", "HIP 61505"},
        {"Geneva Identification System", "GEN# +1.00109591"},
        {"Smithsonian Astrophysical Observation", "SAO 223546"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.02790798),
        dec: Angle.Degrees(-42.85215194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114922"},
        {"Hipparcos Number", "HIP 64590"},
        {"Smithsonian Astrophysical Observation", "SAO 223993"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.58398741),
        dec: Angle.Degrees(-42.85209141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72835"},
        {"Hipparcos Number", "HIP 41977"},
        {"Smithsonian Astrophysical Observation", "SAO 220096"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.34467835),
        dec: Angle.Degrees(-42.85180958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84398"},
        {"Hipparcos Number", "HIP 47731"},
        {"Geneva Identification System", "GEN# +1.00084398"},
        {"Smithsonian Astrophysical Observation", "SAO 221431"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.95064001),
        dec: Angle.Degrees(-42.85123074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45289"},
        {"Hipparcos Number", "HIP 30476"},
        {"Cincinnati Publication", "Ci 20 387"},
        {"Cincinnati Publication 2", "Ci 18 799"},
        {"Geneva Identification System", "GEN# +1.00045289"},
        {"Smithsonian Astrophysical Observation", "SAO 217907"},
        {"Wilson Evans Batten Catalogue", "WEB 6066"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.10171459),
        dec: Angle.Degrees(-42.84940778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 777.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34505"},
        {"Hipparcos Number", "HIP 24534"},
        {"Smithsonian Astrophysical Observation", "SAO 217256"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.95644199),
        dec: Angle.Degrees(-42.84906576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9229"},
        {"Hipparcos Number", "HIP 6992"},
        {"Smithsonian Astrophysical Observation", "SAO 215529"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.50085021),
        dec: Angle.Degrees(-42.84811429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224194"},
        {"Hipparcos Number", "HIP 117991"},
        {"Smithsonian Astrophysical Observation", "SAO 231851"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.99983874),
        dec: Angle.Degrees(-42.84810822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38354"},
        {"Hipparcos Number", "HIP 26943"},
        {"Smithsonian Astrophysical Observation", "SAO 217486"},
    },
    visualMagnitude: 8.81,
    bvColour: -0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.75763952),
        dec: Angle.Degrees(-42.84808622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133973"},
        {"Hipparcos Number", "HIP 74112"},
        {"Geneva Identification System", "GEN# +1.00133973"},
        {"Smithsonian Astrophysical Observation", "SAO 225485"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.19789300),
        dec: Angle.Degrees(-42.84733799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67016",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67016"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.01866983),
        dec: Angle.Degrees(-42.84633834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207799"},
        {"Hipparcos Number", "HIP 107990"},
        {"Geneva Identification System", "GEN# +1.00207799"},
        {"Smithsonian Astrophysical Observation", "SAO 230879"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.17234561),
        dec: Angle.Degrees(-42.84528433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135306"},
        {"Hipparcos Number", "HIP 74697"},
        {"Renson", "Renson 38400"},
        {"Smithsonian Astrophysical Observation", "SAO 225596"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.98219459),
        dec: Angle.Degrees(-42.84391599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122856"},
        {"Hipparcos Number", "HIP 68818"},
        {"Smithsonian Astrophysical Observation", "SAO 224664"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.34372239),
        dec: Angle.Degrees(-42.84373161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208543"},
        {"Hipparcos Number", "HIP 108436"},
        {"Smithsonian Astrophysical Observation", "SAO 230916"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.49574907),
        dec: Angle.Degrees(-42.84266254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101961",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101961"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.92975233),
        dec: Angle.Degrees(-42.84025556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93230"},
        {"Hipparcos Number", "HIP 52590"},
        {"Smithsonian Astrophysical Observation", "SAO 222295"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.30466418),
        dec: Angle.Degrees(-42.83985034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17324"},
        {"Hipparcos Number", "HIP 12879"},
        {"Geneva Identification System", "GEN# +1.00017324"},
        {"Smithsonian Astrophysical Observation", "SAO 216038"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.38730113),
        dec: Angle.Degrees(-42.83852504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105577"},
        {"Hipparcos Number", "HIP 59257"},
        {"Geneva Identification System", "GEN# +1.00105577"},
        {"Smithsonian Astrophysical Observation", "SAO 223244"},
        {"Wilson Evans Batten Catalogue", "WEB 10539"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.33537022),
        dec: Angle.Degrees(-42.83843765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220156"},
        {"Hipparcos Number", "HIP 115349"},
        {"Smithsonian Astrophysical Observation", "SAO 231565"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.46396432),
        dec: Angle.Degrees(-42.83825702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21504"},
        {"Hipparcos Number", "HIP 16027"},
        {"Smithsonian Astrophysical Observation", "SAO 216319"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.59222445),
        dec: Angle.Degrees(-42.83645834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70715"},
        {"Hipparcos Number", "HIP 40974"},
        {"Celescope Catalog", "CEL 2420"},
        {"Geneva Identification System", "GEN# +1.00070715"},
        {"Smithsonian Astrophysical Observation", "SAO 219830"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.42317026),
        dec: Angle.Degrees(-42.83589635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 326077"},
        {"Hipparcos Number", "HIP 82205"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.91066311),
        dec: Angle.Degrees(-42.83495168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128010"},
        {"Hipparcos Number", "HIP 71368"},
        {"Smithsonian Astrophysical Observation", "SAO 225050"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.93720114),
        dec: Angle.Degrees(-42.83452335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17927"},
        {"Hipparcos Number", "HIP 13318"},
        {"Smithsonian Astrophysical Observation", "SAO 216074"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.84848950),
        dec: Angle.Degrees(-42.83147192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125911"},
        {"Hipparcos Number", "HIP 70345"},
        {"Smithsonian Astrophysical Observation", "SAO 224888"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.88349197),
        dec: Angle.Degrees(-42.83089395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80855"},
        {"Hipparcos Number", "HIP 45849"},
        {"Geneva Identification System", "GEN# +1.00080855"},
        {"Smithsonian Astrophysical Observation", "SAO 221088"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.21149622),
        dec: Angle.Degrees(-42.82872474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10885"},
        {"Hipparcos Number", "HIP 8222"},
        {"Smithsonian Astrophysical Observation", "SAO 215637"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.47021796),
        dec: Angle.Degrees(-42.82772436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139651"},
        {"Hipparcos Number", "HIP 76808"},
        {"Smithsonian Astrophysical Observation", "SAO 226062"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.23872707),
        dec: Angle.Degrees(-42.82559048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18589"},
        {"Hipparcos Number", "HIP 13826"},
        {"Geneva Identification System", "GEN# +1.00018589"},
        {"Smithsonian Astrophysical Observation", "SAO 216109"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.48291607),
        dec: Angle.Degrees(-42.82498241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80934"},
        {"Hipparcos Number", "HIP 45878"},
        {"Geneva Identification System", "GEN# +1.00080934"},
        {"Smithsonian Astrophysical Observation", "SAO 221096"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.32616030),
        dec: Angle.Degrees(-42.82451694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75657"},
        {"Hipparcos Number", "HIP 43326"},
        {"Geneva Identification System", "GEN# +1.00075657"},
        {"Smithsonian Astrophysical Observation", "SAO 220537"},
    },
    visualMagnitude: 7.47,
    bvColour: -0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.41783457),
        dec: Angle.Degrees(-42.82348672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196535"},
        {"Hipparcos Number", "HIP 101954"},
        {"Smithsonian Astrophysical Observation", "SAO 230313"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.90397876),
        dec: Angle.Degrees(-42.82336153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130697"},
        {"Hipparcos Number", "HIP 72627"},
        {"Geneva Identification System", "GEN# +1.00130697"},
        {"Smithsonian Astrophysical Observation", "SAO 225234"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.74470315),
        dec: Angle.Degrees(-42.82245636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95812"},
        {"Hipparcos Number", "HIP 54007"},
        {"Geneva Identification System", "GEN# +1.00095812"},
        {"Smithsonian Astrophysical Observation", "SAO 222518"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.72889088),
        dec: Angle.Degrees(-42.82218454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204988"},
        {"Hipparcos Number", "HIP 106433"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.36541893),
        dec: Angle.Degrees(-42.82090484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43329",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 8.86,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)49, 39.3800),
        dec: Angle.DegreesMinutesSeconds((int)-42, (int)49, 07.000)
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
    primaryId: "HIP 113600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217330"},
        {"Hipparcos Number", "HIP 113600"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.13275806),
        dec: Angle.Degrees(-42.81850809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88245",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88245"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.29382010),
        dec: Angle.Degrees(-42.81762545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144946"},
        {"Hipparcos Number", "HIP 79237"},
        {"Geneva Identification System", "GEN# +1.00144946"},
        {"Smithsonian Astrophysical Observation", "SAO 226555"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.56881166),
        dec: Angle.Degrees(-42.81576172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40808"},
        {"Hipparcos Number", "HIP 28328"},
        {"Fundamental Katalog 5th Edition", "FK5 229"},
        {"Geneva Identification System", "GEN# +1.00040808"},
        {"Smithsonian Astrophysical Observation", "SAO 217650"},
        {"Wilson Evans Batten Catalogue", "WEB 5538"},
    },
    visualMagnitude: 3.96,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.78662719),
        dec: Angle.Degrees(-42.81510761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 325816"},
        {"Hipparcos Number", "HIP 81522"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.76955745),
        dec: Angle.Degrees(-42.81466577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177455"},
        {"Hipparcos Number", "HIP 93847"},
        {"Smithsonian Astrophysical Observation", "SAO 229494"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.68295481),
        dec: Angle.Degrees(-42.81465748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184598"},
        {"Hipparcos Number", "HIP 96500"},
        {"Geneva Identification System", "GEN# +1.00184598"},
        {"Smithsonian Astrophysical Observation", "SAO 229772"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.28140400),
        dec: Angle.Degrees(-42.81176282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68475"},
        {"Hipparcos Number", "HIP 40051"},
        {"Geneva Identification System", "GEN# +1.00068475"},
        {"Smithsonian Astrophysical Observation", "SAO 219546"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.71906503),
        dec: Angle.Degrees(-42.81058240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -341.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160495"},
        {"Hipparcos Number", "HIP 86651"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.57070665),
        dec: Angle.Degrees(-42.80999670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208757"},
        {"Hipparcos Number", "HIP 108556"},
        {"Smithsonian Astrophysical Observation", "SAO 230926"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.85081475),
        dec: Angle.Degrees(-42.80992891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82166"},
        {"Hipparcos Number", "HIP 46495"},
        {"Smithsonian Astrophysical Observation", "SAO 221206"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.24433784),
        dec: Angle.Degrees(-42.80887405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88905"},
        {"Hipparcos Number", "HIP 50162"},
        {"Smithsonian Astrophysical Observation", "SAO 221890"},
    },
    visualMagnitude: 7.22,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.58875527),
        dec: Angle.Degrees(-42.80860761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5174"},
        {"Hipparcos Number", "HIP 4162"},
        {"Smithsonian Astrophysical Observation", "SAO 215276"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.28854425),
        dec: Angle.Degrees(-42.80767479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42447"},
        {"Hipparcos Number", "HIP 29131"},
        {"Smithsonian Astrophysical Observation", "SAO 217736"},
    },
    visualMagnitude: 8.68,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.16486218),
        dec: Angle.Degrees(-42.80667615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85248"},
        {"Hipparcos Number", "HIP 48186"},
        {"Renson", "Renson 24360"},
        {"Smithsonian Astrophysical Observation", "SAO 221515"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.34444809),
        dec: Angle.Degrees(-42.80507559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124523"},
        {"Hipparcos Number", "HIP 69645"},
        {"Geneva Identification System", "GEN# +1.00124523"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.81330686),
        dec: Angle.Degrees(-42.80473939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -272.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95717"},
        {"Hipparcos Number", "HIP 53949"},
        {"Smithsonian Astrophysical Observation", "SAO 222510"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.57255281),
        dec: Angle.Degrees(-42.80422927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182607"},
        {"Hipparcos Number", "HIP 95647"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.83738740),
        dec: Angle.Degrees(-42.80381897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144913"},
        {"Hipparcos Number", "HIP 79220"},
        {"Smithsonian Astrophysical Observation", "SAO 226550"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.51822269),
        dec: Angle.Degrees(-42.80375685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117069"},
        {"Hipparcos Number", "HIP 65731"},
        {"Smithsonian Astrophysical Observation", "SAO 224165"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.11505992),
        dec: Angle.Degrees(-42.79554529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17171"},
        {"Hipparcos Number", "HIP 12751"},
        {"Smithsonian Astrophysical Observation", "SAO 216024"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.97632388),
        dec: Angle.Degrees(-42.79284574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217612"},
        {"Hipparcos Number", "HIP 113778"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.63258693),
        dec: Angle.Degrees(-42.79243992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138579"},
        {"Hipparcos Number", "HIP 76260"},
    },
    visualMagnitude: 9.87,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.65680141),
        dec: Angle.Degrees(-42.79205088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192312"},
        {"Hipparcos Number", "HIP 99888"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.99491579),
        dec: Angle.Degrees(-42.79168229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 326535"},
        {"Hipparcos Number", "HIP 82934"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.22260422),
        dec: Angle.Degrees(-42.79161545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176104"},
        {"Hipparcos Number", "HIP 93334"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.14901209),
        dec: Angle.Degrees(-42.79099232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75127"},
        {"Hipparcos Number", "HIP 43087"},
        {"Celescope Catalog", "CEL 2891"},
        {"Geneva Identification System", "GEN# +4.35100012"},
        {"Smithsonian Astrophysical Observation", "SAO 220441"},
    },
    visualMagnitude: 8.69,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.64348065),
        dec: Angle.Degrees(-42.79063182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41957"},
        {"Hipparcos Number", "HIP 28888"},
        {"Smithsonian Astrophysical Observation", "SAO 217716"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.49079383),
        dec: Angle.Degrees(-42.79053423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110711"},
        {"Hipparcos Number", "HIP 62151"},
        {"Smithsonian Astrophysical Observation", "SAO 223634"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.07694404),
        dec: Angle.Degrees(-42.79012822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109737"},
        {"Hipparcos Number", "HIP 61592"},
        {"Smithsonian Astrophysical Observation", "SAO 223555"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.31152057),
        dec: Angle.Degrees(-42.78912323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40154"},
        {"Hipparcos Number", "HIP 27974"},
        {"Smithsonian Astrophysical Observation", "SAO 217614"},
    },
    visualMagnitude: 9.63,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.74637165),
        dec: Angle.Degrees(-42.78877747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27843"},
        {"Hipparcos Number", "HIP 20374"},
        {"Smithsonian Astrophysical Observation", "SAO 216764"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.44440518),
        dec: Angle.Degrees(-42.78804924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128893"},
        {"Hipparcos Number", "HIP 71767"},
        {"Smithsonian Astrophysical Observation", "SAO 225115"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.19150434),
        dec: Angle.Degrees(-42.78502154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145446"},
        {"Hipparcos Number", "HIP 79461"},
        {"Smithsonian Astrophysical Observation", "SAO 226575"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.22975754),
        dec: Angle.Degrees(-42.78499345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82786"},
        {"Hipparcos Number", "HIP 46863"},
        {"Smithsonian Astrophysical Observation", "SAO 221271"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.24083717),
        dec: Angle.Degrees(-42.78453398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219059"},
        {"Hipparcos Number", "HIP 114636"},
        {"Smithsonian Astrophysical Observation", "SAO 231494"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.34162836),
        dec: Angle.Degrees(-42.78446020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55325"},
        {"Hipparcos Number", "HIP 34638"},
        {"Smithsonian Astrophysical Observation", "SAO 218502"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.61825459),
        dec: Angle.Degrees(-42.78327996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185908"},
        {"Hipparcos Number", "HIP 97038"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.82445178),
        dec: Angle.Degrees(-42.78259192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113976"},
        {"Hipparcos Number", "HIP 64073"},
        {"Smithsonian Astrophysical Observation", "SAO 223920"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.96799652),
        dec: Angle.Degrees(-42.78220655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118337"},
        {"Hipparcos Number", "HIP 66431"},
        {"Smithsonian Astrophysical Observation", "SAO 224278"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.28584031),
        dec: Angle.Degrees(-42.78126533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103342"},
        {"Hipparcos Number", "HIP 58011"},
        {"Smithsonian Astrophysical Observation", "SAO 223094"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.47481415),
        dec: Angle.Degrees(-42.78068600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191584"},
        {"Hipparcos Number", "HIP 99570"},
        {"Geneva Identification System", "GEN# +1.00191584"},
        {"Smithsonian Astrophysical Observation", "SAO 230100"},
        {"Wilson Evans Batten Catalogue", "WEB 17815"},
    },
    visualMagnitude: 6.20,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.09940397),
        dec: Angle.Degrees(-42.77981808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168755"},
        {"Hipparcos Number", "HIP 90109"},
        {"Smithsonian Astrophysical Observation", "SAO 228967"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.82933116),
        dec: Angle.Degrees(-42.77950977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53810"},
        {"Hipparcos Number", "HIP 34118"},
        {"Smithsonian Astrophysical Observation", "SAO 218430"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.11299117),
        dec: Angle.Degrees(-42.77871970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46860",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46860"},
    },
    visualMagnitude: 11.54,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.23523073),
        dec: Angle.Degrees(-42.77857403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155755"},
        {"Hipparcos Number", "HIP 84419"},
        {"Geneva Identification System", "GEN# +1.00155755"},
        {"Smithsonian Astrophysical Observation", "SAO 227752"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.87766049),
        dec: Angle.Degrees(-42.77799586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77829"},
        {"Hipparcos Number", "HIP 44452"},
        {"Smithsonian Astrophysical Observation", "SAO 220786"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.84432344),
        dec: Angle.Degrees(-42.77515189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39796"},
        {"Hipparcos Number", "HIP 27782"},
        {"Geneva Identification System", "GEN# +1.00039796"},
        {"Smithsonian Astrophysical Observation", "SAO 217592"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.18753298),
        dec: Angle.Degrees(-42.77508857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
