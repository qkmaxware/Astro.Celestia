using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_27() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128725"},
        {"Hipparcos Number", "HIP 71672"},
        {"Smithsonian Astrophysical Observation", "SAO 205808"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.90303547),
        dec: Angle.Degrees(-39.56480749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33353"},
        {"Hipparcos Number", "HIP 23882"},
        {"Geneva Identification System", "GEN# +1.00033353"},
        {"Smithsonian Astrophysical Observation", "SAO 195580"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.97640382),
        dec: Angle.Degrees(-39.56353877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63603"},
        {"Hipparcos Number", "HIP 38071"},
        {"Smithsonian Astrophysical Observation", "SAO 198457"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.02207118),
        dec: Angle.Degrees(-39.56280555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91793"},
        {"Hipparcos Number", "HIP 51821"},
        {"Geneva Identification System", "GEN# +1.00091793"},
        {"Smithsonian Astrophysical Observation", "SAO 201533"},
        {"Wilson Evans Batten Catalogue", "WEB 9442"},
    },
    visualMagnitude: 5.50,
    bvColour: 3.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.80364609),
        dec: Angle.Degrees(-39.56259670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174891"},
        {"Hipparcos Number", "HIP 92810"},
        {"Smithsonian Astrophysical Observation", "SAO 210698"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.65923078),
        dec: Angle.Degrees(-39.56217829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135452"},
        {"Hipparcos Number", "HIP 74745"},
        {"Smithsonian Astrophysical Observation", "SAO 206475"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.13484832),
        dec: Angle.Degrees(-39.56092641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197403"},
        {"Hipparcos Number", "HIP 102387"},
        {"Smithsonian Astrophysical Observation", "SAO 212399"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.21510646),
        dec: Angle.Degrees(-39.56077782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32929"},
        {"Hipparcos Number", "HIP 23639"},
        {"Smithsonian Astrophysical Observation", "SAO 195543"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.22086928),
        dec: Angle.Degrees(-39.56076835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2319"},
        {"Hipparcos Number", "HIP 2114"},
        {"Geneva Identification System", "GEN# +1.00002319"},
        {"Smithsonian Astrophysical Observation", "SAO 192527"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.70980930),
        dec: Angle.Degrees(-39.55924376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153026"},
        {"Hipparcos Number", "HIP 83101"},
        {"Geneva Identification System", "GEN# +1.00153026"},
        {"Smithsonian Astrophysical Observation", "SAO 208258"},
        {"Wilson Evans Batten Catalogue", "WEB 14046"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.72435489),
        dec: Angle.Degrees(-39.55909225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 272.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 223.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197093"},
        {"Hipparcos Number", "HIP 102230"},
        {"Geneva Identification System", "GEN# +1.00197093"},
        {"Smithsonian Astrophysical Observation", "SAO 212369"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.72061320),
        dec: Angle.Degrees(-39.55880998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86195"},
        {"Hipparcos Number", "HIP 48703"},
        {"Smithsonian Astrophysical Observation", "SAO 200878"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.99595982),
        dec: Angle.Degrees(-39.55318034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79100"},
        {"Hipparcos Number", "HIP 45068"},
        {"Smithsonian Astrophysical Observation", "SAO 200068"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.69111464),
        dec: Angle.Degrees(-39.55236388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96337"},
        {"Hipparcos Number", "HIP 54236"},
        {"Smithsonian Astrophysical Observation", "SAO 202080"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.45254052),
        dec: Angle.Degrees(-39.55156893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149777"},
        {"Hipparcos Number", "HIP 81488"},
        {"Smithsonian Astrophysical Observation", "SAO 207867"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.66032555),
        dec: Angle.Degrees(-39.55093927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191729"},
        {"Hipparcos Number", "HIP 99612"},
        {"Smithsonian Astrophysical Observation", "SAO 211903"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.23052366),
        dec: Angle.Degrees(-39.54788454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180546"},
        {"Hipparcos Number", "HIP 94902"},
        {"Geneva Identification System", "GEN# +1.00180546"},
        {"Smithsonian Astrophysical Observation", "SAO 211153"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.68022651),
        dec: Angle.Degrees(-39.54764067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210395"},
        {"Hipparcos Number", "HIP 109508"},
        {"Geneva Identification System", "GEN# +1.00210395"},
        {"Smithsonian Astrophysical Observation", "SAO 213615"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.75748942),
        dec: Angle.Degrees(-39.54736995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112672",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112672"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.25618656),
        dec: Angle.Degrees(-39.54531119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209688"},
        {"Hipparcos Number", "HIP 109111"},
        {"Fundamental Katalog 5th Edition", "FK5 1581"},
        {"Geneva Identification System", "GEN# +1.00209688"},
        {"Smithsonian Astrophysical Observation", "SAO 213543"},
        {"Wilson Evans Batten Catalogue", "WEB 19617"},
    },
    visualMagnitude: 4.47,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.52876518),
        dec: Angle.Degrees(-39.54304903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167582"},
        {"Hipparcos Number", "HIP 89648"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.41747160),
        dec: Angle.Degrees(-39.54227762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156290"},
        {"Hipparcos Number", "HIP 84668"},
        {"Smithsonian Astrophysical Observation", "SAO 208659"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.63834824),
        dec: Angle.Degrees(-39.54171596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126743"},
        {"Hipparcos Number", "HIP 70769"},
        {"Smithsonian Astrophysical Observation", "SAO 205591"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.10475544),
        dec: Angle.Degrees(-39.54140198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49319"},
        {"Hipparcos Number", "HIP 32418"},
        {"Celescope Catalog", "CEL 1383"},
        {"Geneva Identification System", "GEN# +1.00049319"},
        {"Smithsonian Astrophysical Observation", "SAO 197192"},
    },
    visualMagnitude: 6.62,
    bvColour: -0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.51344372),
        dec: Angle.Degrees(-39.54027540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7382"},
        {"Hipparcos Number", "HIP 5709"},
        {"Geneva Identification System", "GEN# +1.00007382"},
        {"Smithsonian Astrophysical Observation", "SAO 192991"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.36002963),
        dec: Angle.Degrees(-39.54017516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 144.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12986"},
        {"Hipparcos Number", "HIP 9812"},
        {"Fundamental Katalog 5th Edition", "FK5 4190"},
        {"Smithsonian Astrophysical Observation", "SAO 193506"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.55984745),
        dec: Angle.Degrees(-39.53887127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5990"},
        {"Hipparcos Number", "HIP 4729"},
        {"Smithsonian Astrophysical Observation", "SAO 192864"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.17973289),
        dec: Angle.Degrees(-39.53784483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58444"},
        {"Hipparcos Number", "HIP 35879"},
        {"Smithsonian Astrophysical Observation", "SAO 197950"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.96309146),
        dec: Angle.Degrees(-39.53778606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175855"},
        {"Hipparcos Number", "HIP 93209"},
        {"Geneva Identification System", "GEN# +1.00175855J"},
        {"Smithsonian Astrophysical Observation", "SAO 210786"},
    },
    visualMagnitude: 6.49,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.79569312),
        dec: Angle.Degrees(-39.53463573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151109"},
        {"Hipparcos Number", "HIP 82154"},
        {"Geneva Identification System", "GEN# +1.00151109"},
        {"Smithsonian Astrophysical Observation", "SAO 208024"},
    },
    visualMagnitude: 6.92,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.75702788),
        dec: Angle.Degrees(-39.53381954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192454"},
        {"Hipparcos Number", "HIP 99930"},
        {"Smithsonian Astrophysical Observation", "SAO 211947"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.11803809),
        dec: Angle.Degrees(-39.53261297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194528"},
        {"Hipparcos Number", "HIP 100904"},
        {"Geneva Identification System", "GEN# +1.00194528"},
        {"Renson", "Renson 54250"},
        {"Smithsonian Astrophysical Observation", "SAO 212132"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.88994207),
        dec: Angle.Degrees(-39.53214704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21394",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21394"},
        {"Smithsonian Astrophysical Observation", "SAO 131341"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.89061131),
        dec: Angle.Degrees(-06.09218079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24663"},
        {"Hipparcos Number", "HIP 18206"},
        {"Geneva Identification System", "GEN# +1.00024663"},
        {"Smithsonian Astrophysical Observation", "SAO 194610"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.40268642),
        dec: Angle.Degrees(-39.53172113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170186"},
        {"Hipparcos Number", "HIP 90668"},
        {"Smithsonian Astrophysical Observation", "SAO 210231"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.49538583),
        dec: Angle.Degrees(-39.53143496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213955"},
        {"Hipparcos Number", "HIP 111519"},
        {"Smithsonian Astrophysical Observation", "SAO 213935"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.91266903),
        dec: Angle.Degrees(-39.53023508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157352"},
        {"Hipparcos Number", "HIP 85188"},
        {"Smithsonian Astrophysical Observation", "SAO 208775"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.14459574),
        dec: Angle.Degrees(-39.52964433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83674"},
        {"Hipparcos Number", "HIP 47373"},
        {"Smithsonian Astrophysical Observation", "SAO 200597"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.77824016),
        dec: Angle.Degrees(-39.52955393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205844"},
        {"Hipparcos Number", "HIP 106900"},
        {"Smithsonian Astrophysical Observation", "SAO 213164"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.76434310),
        dec: Angle.Degrees(-39.52844262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205187"},
        {"Hipparcos Number", "HIP 106543"},
        {"Geneva Identification System", "GEN# +1.00205187"},
        {"Smithsonian Astrophysical Observation", "SAO 213102"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.67362470),
        dec: Angle.Degrees(-39.52770910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225049"},
        {"Hipparcos Number", "HIP 237"},
        {"Fundamental Katalog 5th Edition", "FK5 4004"},
        {"Smithsonian Astrophysical Observation", "SAO 192336"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.73911220),
        dec: Angle.Degrees(-39.52732256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5618"},
        {"Hipparcos Number", "HIP 4476"},
        {"Geneva Identification System", "GEN# +1.00005618"},
        {"Smithsonian Astrophysical Observation", "SAO 192836"},
        {"Wilson Evans Batten Catalogue", "WEB 811"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.33295268),
        dec: Angle.Degrees(-39.52721423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39806"},
        {"Hipparcos Number", "HIP 27811"},
        {"Smithsonian Astrophysical Observation", "SAO 196281"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.27890263),
        dec: Angle.Degrees(-39.52394138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14549"},
        {"Hipparcos Number", "HIP 10880"},
        {"Geneva Identification System", "GEN# +1.00014549"},
        {"Renson", "Renson 3670"},
        {"Smithsonian Astrophysical Observation", "SAO 193645"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.00724511),
        dec: Angle.Degrees(-39.52382597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126447"},
        {"Hipparcos Number", "HIP 70612"},
        {"Geneva Identification System", "GEN# +1.00126447"},
        {"Smithsonian Astrophysical Observation", "SAO 205559"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.65706035),
        dec: Angle.Degrees(-39.52316198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25085"},
        {"Hipparcos Number", "HIP 18513"},
        {"Geneva Identification System", "GEN# +1.00025085"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.37861948),
        dec: Angle.Degrees(-39.52298351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208677"},
        {"Hipparcos Number", "HIP 108509"},
        {"Smithsonian Astrophysical Observation", "SAO 213448"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.73650774),
        dec: Angle.Degrees(-39.52254093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168769"},
        {"Hipparcos Number", "HIP 90112"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.83183510),
        dec: Angle.Degrees(-39.51999837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171881"},
        {"Hipparcos Number", "HIP 91442"},
        {"Geneva Identification System", "GEN# +1.00171881"},
        {"Smithsonian Astrophysical Observation", "SAO 210398"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.73480618),
        dec: Angle.Degrees(-39.51964356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146838"},
        {"Hipparcos Number", "HIP 80010"},
        {"Smithsonian Astrophysical Observation", "SAO 207561"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.98493673),
        dec: Angle.Degrees(-39.51962761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221119"},
        {"Hipparcos Number", "HIP 115946"},
        {"Smithsonian Astrophysical Observation", "SAO 214578"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.36282351),
        dec: Angle.Degrees(-39.51923746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2723"},
        {"Hipparcos Number", "HIP 2392"},
        {"Smithsonian Astrophysical Observation", "SAO 192574"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.62194565),
        dec: Angle.Degrees(-39.51835788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39901",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39901"},
        {"Smithsonian Astrophysical Observation", "SAO 198857"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.24753461),
        dec: Angle.Degrees(-39.51777055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156355"},
        {"Hipparcos Number", "HIP 84694"},
        {"Smithsonian Astrophysical Observation", "SAO 208664"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.70776615),
        dec: Angle.Degrees(-39.51624787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55891"},
        {"Hipparcos Number", "HIP 34889"},
        {"Smithsonian Astrophysical Observation", "SAO 197712"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.28091301),
        dec: Angle.Degrees(-39.51409344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68005"},
        {"Hipparcos Number", "HIP 39907"},
        {"Smithsonian Astrophysical Observation", "SAO 198858"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.26095070),
        dec: Angle.Degrees(-39.51367347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113006"},
        {"Hipparcos Number", "HIP 63532"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.28776335),
        dec: Angle.Degrees(-39.51319638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -198.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207114"},
        {"Hipparcos Number", "HIP 107617"},
        {"Smithsonian Astrophysical Observation", "SAO 213290"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.95920850),
        dec: Angle.Degrees(-39.51187349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125823"},
        {"Hipparcos Number", "HIP 70300"},
        {"Celescope Catalog", "CEL 4317"},
        {"Geneva Identification System", "GEN# +1.00125823"},
        {"Renson", "Renson 35910"},
        {"Smithsonian Astrophysical Observation", "SAO 205497"},
        {"Wilson Evans Batten Catalogue", "WEB 12205"},
    },
    visualMagnitude: 4.41,
    bvColour: -0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.75940538),
        dec: Angle.Degrees(-39.51176599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104154"},
        {"Hipparcos Number", "HIP 58487"},
        {"Smithsonian Astrophysical Observation", "SAO 203014"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.91843263),
        dec: Angle.Degrees(-39.50942625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150487"},
        {"Hipparcos Number", "HIP 81845"},
        {"Geneva Identification System", "GEN# +1.00150487"},
        {"Smithsonian Astrophysical Observation", "SAO 207952"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.75687368),
        dec: Angle.Degrees(-39.50923707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222883"},
        {"Hipparcos Number", "HIP 117123"},
        {"Smithsonian Astrophysical Observation", "SAO 214746"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.16587409),
        dec: Angle.Degrees(-39.50899306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134442"},
        {"Hipparcos Number", "HIP 74308"},
        {"Smithsonian Astrophysical Observation", "SAO 206372"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.82054572),
        dec: Angle.Degrees(-39.50804259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175348"},
        {"Hipparcos Number", "HIP 93005"},
        {"Geneva Identification System", "GEN# +1.00175348"},
        {"Smithsonian Astrophysical Observation", "SAO 210736"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.19706183),
        dec: Angle.Degrees(-39.50789314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155259"},
        {"Hipparcos Number", "HIP 84150"},
        {"Fundamental Katalog 5th Edition", "FK5 3366"},
        {"Geneva Identification System", "GEN# +1.00155259"},
        {"Smithsonian Astrophysical Observation", "SAO 208521"},
        {"Wilson Evans Batten Catalogue", "WEB 14212"},
    },
    visualMagnitude: 5.66,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.06756446),
        dec: Angle.Degrees(-39.50677484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109935"},
        {"Hipparcos Number", "HIP 61710"},
        {"Smithsonian Astrophysical Observation", "SAO 203663"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.73030557),
        dec: Angle.Degrees(-39.50653829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89119"},
        {"Hipparcos Number", "HIP 50283"},
        {"Smithsonian Astrophysical Observation", "SAO 201226"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.00189235),
        dec: Angle.Degrees(-39.50561902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112145"},
        {"Hipparcos Number", "HIP 63012"},
        {"Geneva Identification System", "GEN# +1.00112145"},
        {"Smithsonian Astrophysical Observation", "SAO 203926"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.68136024),
        dec: Angle.Degrees(-39.50524505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152524"},
        {"Hipparcos Number", "HIP 82832"},
        {"Geneva Identification System", "GEN# +2.62420006"},
        {"Smithsonian Astrophysical Observation", "SAO 208191"},
        {"New General Catalogue", "NGC 6242 6"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.90754981),
        dec: Angle.Degrees(-39.50497459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133692"},
        {"Hipparcos Number", "HIP 73973"},
        {"Smithsonian Astrophysical Observation", "SAO 206304"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.77079998),
        dec: Angle.Degrees(-39.50391444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110494"},
        {"Hipparcos Number", "HIP 62028"},
        {"Geneva Identification System", "GEN# +1.00110494"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.71100466),
        dec: Angle.Degrees(-39.50234289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224608"},
        {"Hipparcos Number", "HIP 118265"},
        {"Smithsonian Astrophysical Observation", "SAO 214896"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.82185092),
        dec: Angle.Degrees(-39.50215535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30998"},
        {"Hipparcos Number", "HIP 22501"},
        {"Smithsonian Astrophysical Observation", "SAO 195344"},
    },
    visualMagnitude: 8.38,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.62024014),
        dec: Angle.Degrees(-39.50147064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178844"},
        {"Hipparcos Number", "HIP 94326"},
        {"Geneva Identification System", "GEN# +1.00178844"},
        {"Smithsonian Astrophysical Observation", "SAO 211032"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.98874843),
        dec: Angle.Degrees(-39.50024233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67905"},
        {"Hipparcos Number", "HIP 39864"},
        {"Smithsonian Astrophysical Observation", "SAO 198849"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.15067549),
        dec: Angle.Degrees(-39.49915723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26231"},
        {"Hipparcos Number", "HIP 19238"},
        {"Smithsonian Astrophysical Observation", "SAO 194779"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.84913290),
        dec: Angle.Degrees(-39.49860919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78469"},
        {"Hipparcos Number", "HIP 44743"},
        {"Fundamental Katalog 5th Edition", "FK5 4809"},
        {"Smithsonian Astrophysical Observation", "SAO 199992"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.77095613),
        dec: Angle.Degrees(-39.49847592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149691"},
        {"Hipparcos Number", "HIP 81449"},
        {"Smithsonian Astrophysical Observation", "SAO 207854"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.53159772),
        dec: Angle.Degrees(-39.49796712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35229"},
        {"Hipparcos Number", "HIP 25023"},
        {"Smithsonian Astrophysical Observation", "SAO 195778"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.36730441),
        dec: Angle.Degrees(-39.49790632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119741"},
        {"Hipparcos Number", "HIP 67159"},
        {"Smithsonian Astrophysical Observation", "SAO 204813"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.45255406),
        dec: Angle.Degrees(-39.49623475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75147"},
        {"Hipparcos Number", "HIP 43115"},
        {"Smithsonian Astrophysical Observation", "SAO 199613"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.70662031),
        dec: Angle.Degrees(-39.49609780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165662"},
        {"Hipparcos Number", "HIP 88902"},
        {"Smithsonian Astrophysical Observation", "SAO 209760"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.22187630),
        dec: Angle.Degrees(-39.49440829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129549"},
        {"Hipparcos Number", "HIP 72052"},
        {"Smithsonian Astrophysical Observation", "SAO 205884"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.865,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.06919977),
        dec: Angle.Degrees(-39.49393156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114409"},
        {"Hipparcos Number", "HIP 64310"},
        {"Geneva Identification System", "GEN# +1.00114409"},
        {"Smithsonian Astrophysical Observation", "SAO 204201"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.71589773),
        dec: Angle.Degrees(-39.49262224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1327",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1327"},
        {"Geneva Identification System", "GEN# -0.04000044"},
        {"Smithsonian Astrophysical Observation", "SAO 192441"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.16653289),
        dec: Angle.Degrees(-39.49188169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190759"},
        {"Hipparcos Number", "HIP 99185"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.03704056),
        dec: Angle.Degrees(-39.49155192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185201"},
        {"Hipparcos Number", "HIP 96713"},
        {"Smithsonian Astrophysical Observation", "SAO 211445"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.90692628),
        dec: Angle.Degrees(-39.49143307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173713"},
        {"Hipparcos Number", "HIP 92286"},
        {"Smithsonian Astrophysical Observation", "SAO 210587"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.13432960),
        dec: Angle.Degrees(-39.49107960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192354"},
        {"Hipparcos Number", "HIP 99886"},
        {"Smithsonian Astrophysical Observation", "SAO 211939"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.98722186),
        dec: Angle.Degrees(-39.48992511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -217.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218989"},
        {"Hipparcos Number", "HIP 114586"},
        {"Smithsonian Astrophysical Observation", "SAO 214382"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.20151351),
        dec: Angle.Degrees(-39.48826845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5054",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Nenque"},
        {"Henry Draper", "HD 6434"},
        {"Hipparcos Number", "HIP 5054"},
        {"Cincinnati Publication", "Ci 20 73"},
        {"Cincinnati Publication 2", "Ci 18 141"},
        {"Geneva Identification System", "GEN# +1.00006434"},
        {"Smithsonian Astrophysical Observation", "SAO 192911"},
        {"Wilson Evans Batten Catalogue", "WEB 1036"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.16782838),
        dec: Angle.Degrees(-39.48693482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -168.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -527.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170869"},
        {"Hipparcos Number", "HIP 90975"},
        {"Geneva Identification System", "GEN# +1.00170869"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.36122486),
        dec: Angle.Degrees(-39.48691913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44404"},
        {"Hipparcos Number", "HIP 30079"},
        {"Smithsonian Astrophysical Observation", "SAO 196693"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.94977773),
        dec: Angle.Degrees(-39.48647603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157794"},
        {"Hipparcos Number", "HIP 85411"},
        {"Geneva Identification System", "GEN# +1.00157794"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.80346941),
        dec: Angle.Degrees(-39.48605107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207278"},
        {"Hipparcos Number", "HIP 107684"},
        {"Smithsonian Astrophysical Observation", "SAO 213303"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.20198905),
        dec: Angle.Degrees(-39.48581251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29112"},
        {"Hipparcos Number", "HIP 21224"},
        {"Geneva Identification System", "GEN# +1.00029112"},
        {"Smithsonian Astrophysical Observation", "SAO 195122"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.29108599),
        dec: Angle.Degrees(-39.48572739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150571"},
        {"Hipparcos Number", "HIP 81896"},
        {"Geneva Identification System", "GEN# +1.00150571"},
        {"Smithsonian Astrophysical Observation", "SAO 207962"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.92163552),
        dec: Angle.Degrees(-39.48504366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102399",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102399"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.25652514),
        dec: Angle.Degrees(-39.48430756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -273.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76408"},
        {"Hipparcos Number", "HIP 43749"},
        {"Smithsonian Astrophysical Observation", "SAO 199776"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.66912408),
        dec: Angle.Degrees(-39.48276084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111142"},
        {"Hipparcos Number", "HIP 62410"},
        {"Smithsonian Astrophysical Observation", "SAO 203807"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.84647638),
        dec: Angle.Degrees(-39.48157497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44403"},
        {"Hipparcos Number", "HIP 30085"},
        {"Smithsonian Astrophysical Observation", "SAO 196696"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.96124179),
        dec: Angle.Degrees(-39.47994281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112103"},
        {"Hipparcos Number", "HIP 62988"},
        {"Geneva Identification System", "GEN# +1.00112103"},
        {"Smithsonian Astrophysical Observation", "SAO 203922"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.60307377),
        dec: Angle.Degrees(-39.47733972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97881"},
        {"Hipparcos Number", "HIP 54949"},
        {"Smithsonian Astrophysical Observation", "SAO 202243"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.78572219),
        dec: Angle.Degrees(-39.47693401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202824"},
        {"Hipparcos Number", "HIP 105289"},
        {"Smithsonian Astrophysical Observation", "SAO 212902"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.89986116),
        dec: Angle.Degrees(-39.47659088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125251"},
        {"Hipparcos Number", "HIP 69991"},
        {"Geneva Identification System", "GEN# +1.00125251"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.82144358),
        dec: Angle.Degrees(-39.47318810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96844"},
        {"Hipparcos Number", "HIP 54467"},
        {"Smithsonian Astrophysical Observation", "SAO 202125"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.16466753),
        dec: Angle.Degrees(-39.47225583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120609"},
        {"Hipparcos Number", "HIP 67616"},
        {"Geneva Identification System", "GEN# +1.00120609"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)51, 18.0600),
        dec: Angle.DegreesMinutesSeconds((int)-39, (int)28, 18.400)
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
    primaryId: "HIP 44217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77301"},
        {"Hipparcos Number", "HIP 44217"},
        {"Geneva Identification System", "GEN# +1.00077301"},
        {"Smithsonian Astrophysical Observation", "SAO 199876"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.09769954),
        dec: Angle.Degrees(-39.46999764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47790"},
        {"Hipparcos Number", "HIP 31751"},
        {"Smithsonian Astrophysical Observation", "SAO 197034"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.63248350),
        dec: Angle.Degrees(-39.46982216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100980"},
        {"Hipparcos Number", "HIP 56664"},
        {"Geneva Identification System", "GEN# +1.00100980"},
        {"Smithsonian Astrophysical Observation", "SAO 202638"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.28371735),
        dec: Angle.Degrees(-39.46974143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183022"},
        {"Hipparcos Number", "HIP 95810"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.31637185),
        dec: Angle.Degrees(-39.46808887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195010"},
        {"Hipparcos Number", "HIP 101145"},
        {"Geneva Identification System", "GEN# +1.00195010"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.53538664),
        dec: Angle.Degrees(-39.46697628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -280.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152504"},
        {"Hipparcos Number", "HIP 82819"},
        {"Geneva Identification System", "GEN# +2.62420001"},
        {"Smithsonian Astrophysical Observation", "SAO 208190"},
        {"New General Catalogue", "NGC 6242 1"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.87902176),
        dec: Angle.Degrees(-39.46639719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214867"},
        {"Hipparcos Number", "HIP 112052"},
        {"Smithsonian Astrophysical Observation", "SAO 214016"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.43931154),
        dec: Angle.Degrees(-39.46146757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176770"},
        {"Hipparcos Number", "HIP 93590"},
        {"Smithsonian Astrophysical Observation", "SAO 210862"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.90287731),
        dec: Angle.Degrees(-39.45634220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215643"},
        {"Hipparcos Number", "HIP 112498"},
        {"Geneva Identification System", "GEN# +1.00215643"},
        {"Smithsonian Astrophysical Observation", "SAO 214079"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.81701782),
        dec: Angle.Degrees(-39.45626229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202209"},
        {"Hipparcos Number", "HIP 104959"},
        {"Smithsonian Astrophysical Observation", "SAO 212837"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.89984318),
        dec: Angle.Degrees(-39.45270121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11872",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11872"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.29054304),
        dec: Angle.Degrees(-39.45214160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86992"},
        {"Hipparcos Number", "HIP 49095"},
        {"Smithsonian Astrophysical Observation", "SAO 200965"},
    },
    visualMagnitude: 7.23,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.31141894),
        dec: Angle.Degrees(-39.45079260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116449"},
        {"Hipparcos Number", "HIP 65408"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.09510829),
        dec: Angle.Degrees(-39.44953769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166595"},
        {"Hipparcos Number", "HIP 89293"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.31266210),
        dec: Angle.Degrees(-39.44696193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59529"},
        {"Hipparcos Number", "HIP 36318"},
        {"Geneva Identification System", "GEN# +1.00059529"},
        {"Smithsonian Astrophysical Observation", "SAO 198036"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.13798042),
        dec: Angle.Degrees(-39.44647767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18436"},
        {"Hipparcos Number", "HIP 13715"},
        {"Smithsonian Astrophysical Observation", "SAO 193996"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.14072748),
        dec: Angle.Degrees(-39.44596987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101847"},
        {"Hipparcos Number", "HIP 57148"},
        {"Geneva Identification System", "GEN# +1.00101847"},
        {"Smithsonian Astrophysical Observation", "SAO 202739"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.80422573),
        dec: Angle.Degrees(-39.43895226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -182.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122259"},
        {"Hipparcos Number", "HIP 68532"},
        {"Celescope Catalog", "CEL 4293"},
        {"Smithsonian Astrophysical Observation", "SAO 205105"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.44051174),
        dec: Angle.Degrees(-39.43855476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220622"},
        {"Hipparcos Number", "HIP 115632"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.36266260),
        dec: Angle.Degrees(-39.43655114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205005"},
        {"Hipparcos Number", "HIP 106428"},
        {"Smithsonian Astrophysical Observation", "SAO 213086"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.34645229),
        dec: Angle.Degrees(-39.43467120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143939"},
        {"Hipparcos Number", "HIP 78756"},
        {"Renson", "Renson 40790"},
        {"Smithsonian Astrophysical Observation", "SAO 207299"},
        {"Wilson Evans Batten Catalogue", "WEB 13318"},
    },
    visualMagnitude: 6.95,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.18542199),
        dec: Angle.Degrees(-39.43459697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135171"},
        {"Hipparcos Number", "HIP 74641"},
        {"Smithsonian Astrophysical Observation", "SAO 206451"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.75967838),
        dec: Angle.Degrees(-39.43316497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57146",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "HD 101847BC"},
        {"Hipparcos Number", "HIP 57146"},
    },
    visualMagnitude: 9.64,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.80015765),
        dec: Angle.Degrees(-39.43279322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -182.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185257"},
        {"Hipparcos Number", "HIP 96739"},
        {"Geneva Identification System", "GEN# +1.00185257"},
        {"Renson", "Renson 51170"},
        {"Smithsonian Astrophysical Observation", "SAO 211451"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.98122303),
        dec: Angle.Degrees(-39.43277551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147122"},
        {"Hipparcos Number", "HIP 80146"},
        {"Smithsonian Astrophysical Observation", "SAO 207585"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.39195455),
        dec: Angle.Degrees(-39.43124688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146954"},
        {"Hipparcos Number", "HIP 80066"},
        {"Geneva Identification System", "GEN# +1.00146954"},
        {"Smithsonian Astrophysical Observation", "SAO 207574"},
    },
    visualMagnitude: 6.11,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.13594772),
        dec: Angle.Degrees(-39.43023500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161704"},
        {"Hipparcos Number", "HIP 87198"},
        {"Renson", "Renson 45630"},
        {"Smithsonian Astrophysical Observation", "SAO 209286"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.21509781),
        dec: Angle.Degrees(-39.43023466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1713",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1713"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.38862211),
        dec: Angle.Degrees(-39.43000054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191409"},
        {"Hipparcos Number", "HIP 99463"},
        {"Geneva Identification System", "GEN# +1.00191409"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.80741505),
        dec: Angle.Degrees(-39.42881225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76486"},
        {"Hipparcos Number", "HIP 43791"},
        {"Smithsonian Astrophysical Observation", "SAO 199786"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.78264788),
        dec: Angle.Degrees(-39.42765873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213456"},
        {"Hipparcos Number", "HIP 111226"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.02242168),
        dec: Angle.Degrees(-39.42560777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186526"},
        {"Hipparcos Number", "HIP 97302"},
        {"Smithsonian Astrophysical Observation", "SAO 211543"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.63203986),
        dec: Angle.Degrees(-39.42547970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81411"},
        {"Hipparcos Number", "HIP 46114"},
        {"Geneva Identification System", "GEN# +1.00081411J"},
        {"Renson", "Renson 23140"},
        {"Smithsonian Astrophysical Observation", "SAO 200330"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.06781642),
        dec: Angle.Degrees(-39.42543933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62211"},
        {"Hipparcos Number", "HIP 37437"},
        {"Smithsonian Astrophysical Observation", "SAO 198294"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.28126804),
        dec: Angle.Degrees(-39.42517613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186086"},
        {"Hipparcos Number", "HIP 97112"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.03630491),
        dec: Angle.Degrees(-39.42469105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201772"},
        {"Hipparcos Number", "HIP 104738"},
        {"Geneva Identification System", "GEN# +1.00201772"},
        {"Smithsonian Astrophysical Observation", "SAO 212793"},
        {"Wilson Evans Batten Catalogue", "WEB 19049"},
    },
    visualMagnitude: 5.25,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.26219780),
        dec: Angle.Degrees(-39.42464394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 187.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87293"},
        {"Hipparcos Number", "HIP 49240"},
        {"Smithsonian Astrophysical Observation", "SAO 201002"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.77280220),
        dec: Angle.Degrees(-39.42356355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62034"},
        {"Hipparcos Number", "HIP 37373"},
        {"Geneva Identification System", "GEN# +2.24510191"},
        {"Smithsonian Astrophysical Observation", "SAO 198282"},
        {"New General Catalogue", "NGC 2451 191"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.08317927),
        dec: Angle.Degrees(-39.42088694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65848"},
        {"Hipparcos Number", "HIP 39028"},
        {"Celescope Catalog", "CEL 2124"},
        {"Geneva Identification System", "GEN# +1.00065848"},
        {"Smithsonian Astrophysical Observation", "SAO 198666"},
    },
    visualMagnitude: 7.24,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.78174367),
        dec: Angle.Degrees(-39.42031965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120518"},
        {"Hipparcos Number", "HIP 67564"},
        {"Geneva Identification System", "GEN# +1.00120518"},
        {"Smithsonian Astrophysical Observation", "SAO 204897"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.67430796),
        dec: Angle.Degrees(-39.42026530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -153.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216443"},
        {"Hipparcos Number", "HIP 113034"},
        {"Smithsonian Astrophysical Observation", "SAO 214162"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.37742048),
        dec: Angle.Degrees(-39.41993503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12616"},
        {"Hipparcos Number", "HIP 9539"},
        {"Smithsonian Astrophysical Observation", "SAO 193471"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.65324754),
        dec: Angle.Degrees(-39.41985759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141277"},
        {"Hipparcos Number", "HIP 77524"},
    },
    visualMagnitude: 10.64,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.43747219),
        dec: Angle.Degrees(-39.41913724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107045"},
        {"Hipparcos Number", "HIP 60026"},
        {"Geneva Identification System", "GEN# +1.00107045"},
        {"Smithsonian Astrophysical Observation", "SAO 203332"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.65426651),
        dec: Angle.Degrees(-39.41845024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73695"},
        {"Hipparcos Number", "HIP 42363"},
        {"Geneva Identification System", "GEN# +1.00073695"},
        {"Smithsonian Astrophysical Observation", "SAO 199452"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.56414501),
        dec: Angle.Degrees(-39.41765455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28710"},
        {"Hipparcos Number", "HIP 20972"},
        {"Geneva Identification System", "GEN# +1.00028710"},
        {"Smithsonian Astrophysical Observation", "SAO 195069"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.45143936),
        dec: Angle.Degrees(-39.41658241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11526"},
        {"Hipparcos Number", "HIP 8732"},
        {"Fundamental Katalog 5th Edition", "FK5 4170"},
        {"Geneva Identification System", "GEN# +1.00011526"},
        {"Smithsonian Astrophysical Observation", "SAO 193349"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.09041479),
        dec: Angle.Degrees(-39.41633013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131752"},
        {"Hipparcos Number", "HIP 73116"},
        {"Geneva Identification System", "GEN# +1.00131752"},
        {"Smithsonian Astrophysical Observation", "SAO 206110"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.14907283),
        dec: Angle.Degrees(-39.41597172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75500"},
        {"Hipparcos Number", "HIP 43282"},
        {"Smithsonian Astrophysical Observation", "SAO 199662"},
    },
    visualMagnitude: 7.43,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.25924076),
        dec: Angle.Degrees(-39.41473565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29428"},
        {"Hipparcos Number", "HIP 21438"},
        {"Smithsonian Astrophysical Observation", "SAO 195154"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.06323915),
        dec: Angle.Degrees(-39.41453289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6576"},
        {"Hipparcos Number", "HIP 5157"},
        {"Smithsonian Astrophysical Observation", "SAO 192919"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.50714923),
        dec: Angle.Degrees(-39.41399143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14846"},
        {"Hipparcos Number", "HIP 11078"},
        {"Smithsonian Astrophysical Observation", "SAO 193674"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.64696047),
        dec: Angle.Degrees(-39.41368969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71606"},
        {"Hipparcos Number", "HIP 41420"},
        {"Celescope Catalog", "CEL 2520"},
        {"Geneva Identification System", "GEN# +1.00071606"},
        {"Smithsonian Astrophysical Observation", "SAO 199240"},
    },
    visualMagnitude: 8.18,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.72867789),
        dec: Angle.Degrees(-39.41291798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195113"},
        {"Hipparcos Number", "HIP 101202"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.70261619),
        dec: Angle.Degrees(-39.41211593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221118"},
        {"Hipparcos Number", "HIP 115938"},
        {"Smithsonian Astrophysical Observation", "SAO 214577"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.35134560),
        dec: Angle.Degrees(-39.41196496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66996"},
        {"Hipparcos Number", "HIP 39492"},
        {"Smithsonian Astrophysical Observation", "SAO 198768"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.09180106),
        dec: Angle.Degrees(-39.41093846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121399"},
        {"Hipparcos Number", "HIP 68047"},
        {"Geneva Identification System", "GEN# +1.00121399"},
        {"Smithsonian Astrophysical Observation", "SAO 204997"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.99373821),
        dec: Angle.Degrees(-39.40968915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117440"},
        {"Hipparcos Number", "HIP 65936"},
        {"Geneva Identification System", "GEN# +1.00117440J"},
        {"Smithsonian Astrophysical Observation", "SAO 204545"},
        {"Wilson Evans Batten Catalogue", "WEB 11660"},
    },
    visualMagnitude: 3.90,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.76111861),
        dec: Angle.Degrees(-39.40727983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38385"},
        {"Hipparcos Number", "HIP 26981"},
        {"Fundamental Katalog 5th Edition", "FK5 2430"},
        {"Geneva Identification System", "GEN# +1.00038385"},
        {"Smithsonian Astrophysical Observation", "SAO 196116"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.87562146),
        dec: Angle.Degrees(-39.40691739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223588"},
        {"Hipparcos Number", "HIP 117589"},
        {"Smithsonian Astrophysical Observation", "SAO 214809"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.70898880),
        dec: Angle.Degrees(-39.40615197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164589"},
        {"Hipparcos Number", "HIP 88458"},
        {"Smithsonian Astrophysical Observation", "SAO 209649"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.91221434),
        dec: Angle.Degrees(-39.40527428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188049"},
        {"Hipparcos Number", "HIP 97986"},
        {"Smithsonian Astrophysical Observation", "SAO 211648"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.70109337),
        dec: Angle.Degrees(-39.40495925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77580"},
        {"Hipparcos Number", "HIP 44367"},
        {"Geneva Identification System", "GEN# +1.00077580"},
        {"Smithsonian Astrophysical Observation", "SAO 199902"},
        {"Wilson Evans Batten Catalogue", "WEB 8505"},
    },
    visualMagnitude: 6.25,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.52675733),
        dec: Angle.Degrees(-39.40225721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80170"},
        {"Hipparcos Number", "HIP 45544"},
        {"Geneva Identification System", "GEN# +1.00080170"},
        {"Smithsonian Astrophysical Observation", "SAO 200185"},
        {"Wilson Evans Batten Catalogue", "WEB 8657"},
    },
    visualMagnitude: 5.31,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.23791125),
        dec: Angle.Degrees(-39.40145479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142561"},
        {"Hipparcos Number", "HIP 78098"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.19833681),
        dec: Angle.Degrees(-39.39956822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175143"},
        {"Hipparcos Number", "HIP 92910"},
        {"Smithsonian Astrophysical Observation", "SAO 210722"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.95277884),
        dec: Angle.Degrees(-39.39904814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123747"},
        {"Hipparcos Number", "HIP 69229"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.61065631),
        dec: Angle.Degrees(-39.39694704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198307"},
        {"Hipparcos Number", "HIP 102900"},
        {"Smithsonian Astrophysical Observation", "SAO 212484"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.69633813),
        dec: Angle.Degrees(-39.39652634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30940",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30940"},
    },
    visualMagnitude: 12.62,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.40545147),
        dec: Angle.Degrees(-39.39485716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120108"},
        {"Hipparcos Number", "HIP 67348"},
        {"Smithsonian Astrophysical Observation", "SAO 204851"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.05548620),
        dec: Angle.Degrees(-39.39423504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109903"},
        {"Hipparcos Number", "HIP 61682"},
        {"Smithsonian Astrophysical Observation", "SAO 203658"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.67122173),
        dec: Angle.Degrees(-39.39236826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139544"},
        {"Hipparcos Number", "HIP 76737"},
        {"Smithsonian Astrophysical Observation", "SAO 206852"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.05316119),
        dec: Angle.Degrees(-39.39066699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111930"},
        {"Hipparcos Number", "HIP 62880"},
        {"Smithsonian Astrophysical Observation", "SAO 203904"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.30541687),
        dec: Angle.Degrees(-39.39023156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47333",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47333"},
    },
    visualMagnitude: 10.50,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.68161048),
        dec: Angle.Degrees(-39.38652366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 400.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -358.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48844",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48844"},
    },
    visualMagnitude: 11.16,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.44204024),
        dec: Angle.Degrees(-39.38534374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101309"},
        {"Hipparcos Number", "HIP 56851"},
        {"Geneva Identification System", "GEN# +1.00101309"},
        {"Smithsonian Astrophysical Observation", "SAO 202671"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.84265573),
        dec: Angle.Degrees(-39.38531742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188551"},
        {"Hipparcos Number", "HIP 98208"},
        {"Smithsonian Astrophysical Observation", "SAO 211682"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.33649289),
        dec: Angle.Degrees(-39.38445181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22608"},
        {"Hipparcos Number", "HIP 16837"},
        {"Smithsonian Astrophysical Observation", "SAO 194398"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.17630087),
        dec: Angle.Degrees(-39.38367002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164707"},
        {"Hipparcos Number", "HIP 88500"},
        {"Smithsonian Astrophysical Observation", "SAO 209658"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.07349475),
        dec: Angle.Degrees(-39.38116898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81074"},
        {"Hipparcos Number", "HIP 45955"},
        {"Smithsonian Astrophysical Observation", "SAO 200289"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.58671235),
        dec: Angle.Degrees(-39.38014288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25761"},
        {"Hipparcos Number", "HIP 18928"},
        {"Smithsonian Astrophysical Observation", "SAO 194722"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.86000666),
        dec: Angle.Degrees(-39.37835283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8696"},
        {"Hipparcos Number", "HIP 6634"},
        {"Smithsonian Astrophysical Observation", "SAO 193107"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.28082468),
        dec: Angle.Degrees(-39.37815178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212647"},
        {"Hipparcos Number", "HIP 110784"},
        {"Geneva Identification System", "GEN# +1.00212647"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.65438304),
        dec: Angle.Degrees(-39.37731554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151078"},
        {"Hipparcos Number", "HIP 82135"},
        {"Geneva Identification System", "GEN# +1.00151078"},
        {"Smithsonian Astrophysical Observation", "SAO 208020"},
    },
    visualMagnitude: 5.48,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.69988126),
        dec: Angle.Degrees(-39.37689836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107202"},
        {"Hipparcos Number", "HIP 60113"},
        {"Renson", "Renson 31050"},
        {"Smithsonian Astrophysical Observation", "SAO 203353"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.91968112),
        dec: Angle.Degrees(-39.37687248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206564"},
        {"Hipparcos Number", "HIP 107282"},
        {"Smithsonian Astrophysical Observation", "SAO 213239"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.95691002),
        dec: Angle.Degrees(-39.37575880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114265",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114265"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.12954590),
        dec: Angle.Degrees(-39.37561759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 240.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56719",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56719"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.43695233),
        dec: Angle.Degrees(-39.37212997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36223"},
        {"Hipparcos Number", "HIP 25627"},
        {"Geneva Identification System", "GEN# +1.00036223"},
        {"Smithsonian Astrophysical Observation", "SAO 195892"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.11669480),
        dec: Angle.Degrees(-39.37102679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134556"},
        {"Hipparcos Number", "HIP 74360"},
        {"Smithsonian Astrophysical Observation", "SAO 206383"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.94910647),
        dec: Angle.Degrees(-39.36995489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20035"},
        {"Hipparcos Number", "HIP 14868"},
        {"Smithsonian Astrophysical Observation", "SAO 194149"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.99012417),
        dec: Angle.Degrees(-39.36585279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82827"},
        {"Hipparcos Number", "HIP 46898"},
        {"Smithsonian Astrophysical Observation", "SAO 200497"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.36047806),
        dec: Angle.Degrees(-39.36549474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120959"},
        {"Hipparcos Number", "HIP 67810"},
        {"Smithsonian Astrophysical Observation", "SAO 204950"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.36982929),
        dec: Angle.Degrees(-39.36515820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25713"},
        {"Hipparcos Number", "HIP 18906"},
        {"Smithsonian Astrophysical Observation", "SAO 194719"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.78739178),
        dec: Angle.Degrees(-39.36453799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8076"},
        {"Hipparcos Number", "HIP 6206"},
        {"Geneva Identification System", "GEN# +1.00008076"},
        {"Smithsonian Astrophysical Observation", "SAO 193052"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.88915049),
        dec: Angle.Degrees(-39.36272349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90549"},
        {"Hipparcos Number", "HIP 51104"},
        {"Smithsonian Astrophysical Observation", "SAO 201391"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.60674976),
        dec: Angle.Degrees(-39.36198946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138047"},
        {"Hipparcos Number", "HIP 75979"},
        {"Geneva Identification System", "GEN# +1.00138047"},
        {"Smithsonian Astrophysical Observation", "SAO 206715"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.74512814),
        dec: Angle.Degrees(-39.35939583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101048"},
        {"Hipparcos Number", "HIP 56698"},
        {"Smithsonian Astrophysical Observation", "SAO 202642"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.38579936),
        dec: Angle.Degrees(-39.35881370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142018"},
        {"Hipparcos Number", "HIP 77839"},
        {"Geneva Identification System", "GEN# +1.00142018"},
        {"Smithsonian Astrophysical Observation", "SAO 207086"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.40240179),
        dec: Angle.Degrees(-39.35723647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30432"},
        {"Hipparcos Number", "HIP 22144"},
        {"Fundamental Katalog 5th Edition", "FK5 2355"},
        {"Geneva Identification System", "GEN# +1.00030432"},
        {"Smithsonian Astrophysical Observation", "SAO 195278"},
        {"Wilson Evans Batten Catalogue", "WEB 4258"},
    },
    visualMagnitude: 6.04,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.48122939),
        dec: Angle.Degrees(-39.35657299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119713"},
        {"Hipparcos Number", "HIP 67135"},
        {"Geneva Identification System", "GEN# +1.00119713"},
        {"Renson", "Renson 34520"},
        {"Smithsonian Astrophysical Observation", "SAO 204807"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.38315686),
        dec: Angle.Degrees(-39.35586698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38476",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38476"},
        {"Fundamental Katalog 5th Edition", "FK5 4708"},
        {"Smithsonian Astrophysical Observation", "SAO 198550"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.20710628),
        dec: Angle.Degrees(-39.35412993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190598"},
        {"Hipparcos Number", "HIP 99109"},
        {"Fundamental Katalog 5th Edition", "FK5 5773"},
        {"Geneva Identification System", "GEN# +1.00190598"},
        {"Smithsonian Astrophysical Observation", "SAO 211817"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.82136396),
        dec: Angle.Degrees(-39.35262339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148902"},
        {"Hipparcos Number", "HIP 81029"},
        {"Smithsonian Astrophysical Observation", "SAO 207755"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.24187635),
        dec: Angle.Degrees(-39.35141598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138564"},
        {"Hipparcos Number", "HIP 76234"},
        {"Celescope Catalog", "CEL 4378"},
        {"Geneva Identification System", "GEN# +1.00138564"},
        {"Smithsonian Astrophysical Observation", "SAO 206769"},
        {"Wilson Evans Batten Catalogue", "WEB 12943"},
    },
    visualMagnitude: 6.36,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.58697277),
        dec: Angle.Degrees(-39.34911922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214817"},
        {"Hipparcos Number", "HIP 112013"},
        {"Geneva Identification System", "GEN# +1.00214817"},
        {"Smithsonian Astrophysical Observation", "SAO 214010"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.33661420),
        dec: Angle.Degrees(-39.34849766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173970"},
        {"Hipparcos Number", "HIP 92415"},
        {"Smithsonian Astrophysical Observation", "SAO 210609"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.50287913),
        dec: Angle.Degrees(-39.34828913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202775"},
        {"Hipparcos Number", "HIP 105260"},
        {"Smithsonian Astrophysical Observation", "SAO 212898"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.82569174),
        dec: Angle.Degrees(-39.34811968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163005"},
        {"Hipparcos Number", "HIP 87771"},
        {"Smithsonian Astrophysical Observation", "SAO 209476"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.95462892),
        dec: Angle.Degrees(-39.34689950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210454"},
        {"Hipparcos Number", "HIP 109542"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.84039905),
        dec: Angle.Degrees(-39.34659341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131388"},
        {"Hipparcos Number", "HIP 72950"},
        {"Smithsonian Astrophysical Observation", "SAO 206072"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.63645191),
        dec: Angle.Degrees(-39.34625040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63080"},
        {"Hipparcos Number", "HIP 37829"},
        {"Celescope Catalog", "CEL 2015"},
        {"Geneva Identification System", "GEN# +2.24510255"},
        {"Smithsonian Astrophysical Observation", "SAO 198400"},
        {"New General Catalogue", "NGC 2451 255"},
    },
    visualMagnitude: 7.19,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.33965764),
        dec: Angle.Degrees(-39.34523889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160001"},
        {"Hipparcos Number", "HIP 86419"},
        {"Geneva Identification System", "GEN# +1.00160001"},
        {"Smithsonian Astrophysical Observation", "SAO 209078"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.87280333),
        dec: Angle.Degrees(-39.34423461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88873"},
        {"Hipparcos Number", "HIP 50148"},
        {"Smithsonian Astrophysical Observation", "SAO 201195"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.55396097),
        dec: Angle.Degrees(-39.34388587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164889"},
        {"Hipparcos Number", "HIP 88584"},
        {"Wilson Evans Batten Catalogue", "WEB 15000"},
    },
    visualMagnitude: 9.82,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.30099730),
        dec: Angle.Degrees(-39.34230597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166453"},
        {"Hipparcos Number", "HIP 89224"},
        {"Geneva Identification System", "GEN# +1.00166453"},
        {"Smithsonian Astrophysical Observation", "SAO 209847"},
    },
    visualMagnitude: 7.28,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.12208363),
        dec: Angle.Degrees(-39.34229115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15998"},
        {"Hipparcos Number", "HIP 11859"},
        {"Smithsonian Astrophysical Observation", "SAO 193764"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.26480646),
        dec: Angle.Degrees(-39.34206890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12129"},
        {"Hipparcos Number", "HIP 9179"},
        {"Smithsonian Astrophysical Observation", "SAO 193419"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.53396104),
        dec: Angle.Degrees(-39.34084216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178345"},
        {"Hipparcos Number", "HIP 94160"},
        {"Geneva Identification System", "GEN# +1.00178345"},
        {"Smithsonian Astrophysical Observation", "SAO 211005"},
        {"Wilson Evans Batten Catalogue", "WEB 16403"},
    },
    visualMagnitude: 4.10,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.50730185),
        dec: Angle.Degrees(-39.34070677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154685"},
        {"Hipparcos Number", "HIP 83886"},
        {"Smithsonian Astrophysical Observation", "SAO 208461"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.17890920),
        dec: Angle.Degrees(-39.33798458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224900"},
        {"Hipparcos Number", "HIP 125"},
        {"Geneva Identification System", "GEN# +1.00224900"},
        {"Smithsonian Astrophysical Observation", "SAO 214927"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.40473165),
        dec: Angle.Degrees(-39.33667992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137037"},
        {"Hipparcos Number", "HIP 75490"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.31224873),
        dec: Angle.Degrees(-39.33484436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121691"},
        {"Hipparcos Number", "HIP 68202"},
        {"Smithsonian Astrophysical Observation", "SAO 205036"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.44252985),
        dec: Angle.Degrees(-39.33420020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43659"},
        {"Hipparcos Number", "HIP 29712"},
        {"Smithsonian Astrophysical Observation", "SAO 196633"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.87561225),
        dec: Angle.Degrees(-39.33219945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97865"},
        {"Hipparcos Number", "HIP 54937"},
        {"Smithsonian Astrophysical Observation", "SAO 202241"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.75881789),
        dec: Angle.Degrees(-39.33131612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63401"},
        {"Hipparcos Number", "HIP 37982"},
        {"Celescope Catalog", "CEL 2029"},
        {"Geneva Identification System", "GEN# +2.24510277"},
        {"Renson", "Renson 17480"},
        {"Smithsonian Astrophysical Observation", "SAO 198435"},
        {"New General Catalogue", "NGC 2451 277"},
    },
    visualMagnitude: 6.33,
    bvColour: -0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.77405856),
        dec: Angle.Degrees(-39.33103329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196649"},
        {"Hipparcos Number", "HIP 101990"},
        {"Smithsonian Astrophysical Observation", "SAO 212323"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.03524460),
        dec: Angle.Degrees(-39.33088993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194158"},
        {"Hipparcos Number", "HIP 100743"},
        {"Smithsonian Astrophysical Observation", "SAO 212104"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.38262816),
        dec: Angle.Degrees(-39.32948583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218667"},
        {"Hipparcos Number", "HIP 114409"},
        {"Smithsonian Astrophysical Observation", "SAO 214355"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.55790219),
        dec: Angle.Degrees(-39.32819503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109660"},
        {"Hipparcos Number", "HIP 61544"},
        {"Smithsonian Astrophysical Observation", "SAO 203629"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.15850026),
        dec: Angle.Degrees(-39.32628230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2970"},
        {"Hipparcos Number", "HIP 2580"},
        {"Smithsonian Astrophysical Observation", "SAO 192599"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.18681413),
        dec: Angle.Degrees(-39.32593744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84826"},
        {"Hipparcos Number", "HIP 47983"},
        {"Smithsonian Astrophysical Observation", "SAO 200726"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.70580266),
        dec: Angle.Degrees(-39.32540801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97998"},
        {"Hipparcos Number", "HIP 55013"},
        {"Geneva Identification System", "GEN# +1.00097998"},
        {"Smithsonian Astrophysical Observation", "SAO 202254"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.95479311),
        dec: Angle.Degrees(-39.32396446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -177.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 189.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215570"},
        {"Hipparcos Number", "HIP 112455"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.69078749),
        dec: Angle.Degrees(-39.32345858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26509",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26509"},
        {"Smithsonian Astrophysical Observation", "SAO 196040"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.55870346),
        dec: Angle.Degrees(-39.32309119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87521"},
        {"Hipparcos Number", "HIP 49359"},
        {"Geneva Identification System", "GEN# +1.00087521"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.14212850),
        dec: Angle.Degrees(-39.31710986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -178.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 100.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12523"},
        {"Hipparcos Number", "HIP 9468"},
        {"Smithsonian Astrophysical Observation", "SAO 193461"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.45895930),
        dec: Angle.Degrees(-39.31651433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13864",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13864"},
        {"Smithsonian Astrophysical Observation", "SAO 194014"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.61818753),
        dec: Angle.Degrees(-39.31505204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -195.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -200.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38643"},
        {"Hipparcos Number", "HIP 27156"},
        {"Geneva Identification System", "GEN# +1.00038643"},
        {"Smithsonian Astrophysical Observation", "SAO 196142"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.35099171),
        dec: Angle.Degrees(-39.31258726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48149"},
        {"Hipparcos Number", "HIP 31907"},
        {"Smithsonian Astrophysical Observation", "SAO 197071"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.02682879),
        dec: Angle.Degrees(-39.31239176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111882"},
        {"Hipparcos Number", "HIP 62845"},
        {"Smithsonian Astrophysical Observation", "SAO 203896"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.19558005),
        dec: Angle.Degrees(-39.31214036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145575"},
        {"Hipparcos Number", "HIP 79495"},
        {"Smithsonian Astrophysical Observation", "SAO 207461"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.805,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.33252240),
        dec: Angle.Degrees(-39.31187899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116064"},
        {"Hipparcos Number", "HIP 65201"},
        {"Cincinnati Publication", "Ci 20 775"},
        {"Geneva Identification System", "GEN# +1.00116064"},
        {"Smithsonian Astrophysical Observation", "SAO 204389"},
        {"Wilson Evans Batten Catalogue", "WEB 11508"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.43484160),
        dec: Angle.Degrees(-39.31134077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -754.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 103.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148075"},
        {"Hipparcos Number", "HIP 80593"},
        {"Smithsonian Astrophysical Observation", "SAO 207674"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.81552116),
        dec: Angle.Degrees(-39.31073086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208258"},
        {"Hipparcos Number", "HIP 108267"},
        {"Geneva Identification System", "GEN# +1.00208258"},
        {"Smithsonian Astrophysical Observation", "SAO 213405"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.01260494),
        dec: Angle.Degrees(-39.30894953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131403"},
        {"Hipparcos Number", "HIP 72958"},
        {"Smithsonian Astrophysical Observation", "SAO 206075"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.65611851),
        dec: Angle.Degrees(-39.30891099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214775"},
        {"Hipparcos Number", "HIP 111984"},
        {"Smithsonian Astrophysical Observation", "SAO 214007"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.24422345),
        dec: Angle.Degrees(-39.30691989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154312"},
        {"Hipparcos Number", "HIP 83709"},
        {"Geneva Identification System", "GEN# +1.00154312"},
        {"Smithsonian Astrophysical Observation", "SAO 208408"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.62195957),
        dec: Angle.Degrees(-39.30505121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19603"},
        {"Hipparcos Number", "HIP 14561"},
        {"Geneva Identification System", "GEN# +1.00019603"},
        {"Smithsonian Astrophysical Observation", "SAO 194106"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.00214617),
        dec: Angle.Degrees(-39.30477318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -191.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17830"},
        {"Hipparcos Number", "HIP 13245"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.62366335),
        dec: Angle.Degrees(-39.30293451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107833"},
        {"Hipparcos Number", "HIP 60454"},
        {"Geneva Identification System", "GEN# +1.00107833"},
        {"Smithsonian Astrophysical Observation", "SAO 203421"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.90316593),
        dec: Angle.Degrees(-39.30237217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19386"},
        {"Hipparcos Number", "HIP 14389"},
        {"Smithsonian Astrophysical Observation", "SAO 194078"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.40547198),
        dec: Angle.Degrees(-39.30189145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216301"},
        {"Hipparcos Number", "HIP 112938"},
        {"Smithsonian Astrophysical Observation", "SAO 214149"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.10837279),
        dec: Angle.Degrees(-39.30049618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65925"},
        {"Hipparcos Number", "HIP 39061"},
        {"Geneva Identification System", "GEN# +1.00065925"},
        {"Smithsonian Astrophysical Observation", "SAO 198668"},
        {"Wilson Evans Batten Catalogue", "WEB 7660"},
    },
    visualMagnitude: 5.22,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.86843828),
        dec: Angle.Degrees(-39.29683773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63505",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63505"},
        {"Smithsonian Astrophysical Observation", "SAO 204034"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.18536454),
        dec: Angle.Degrees(-39.29514369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183392"},
        {"Hipparcos Number", "HIP 95985"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.862,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.76680393),
        dec: Angle.Degrees(-39.29332705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 190.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89076"},
        {"Hipparcos Number", "HIP 50251"},
        {"Smithsonian Astrophysical Observation", "SAO 201221"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.90989002),
        dec: Angle.Degrees(-39.29145270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137750"},
        {"Hipparcos Number", "HIP 75802"},
        {"Smithsonian Astrophysical Observation", "SAO 206690"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.28624075),
        dec: Angle.Degrees(-39.29074368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176460"},
        {"Hipparcos Number", "HIP 93465"},
        {"Smithsonian Astrophysical Observation", "SAO 210838"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.52535192),
        dec: Angle.Degrees(-39.29024447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34645"},
        {"Hipparcos Number", "HIP 24640"},
        {"Geneva Identification System", "GEN# +1.00034645"},
        {"Smithsonian Astrophysical Observation", "SAO 195718"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.31271302),
        dec: Angle.Degrees(-39.28812076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54710"},
        {"Hipparcos Number", "HIP 34415"},
        {"Smithsonian Astrophysical Observation", "SAO 197618"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.02565209),
        dec: Angle.Degrees(-39.28674613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172579"},
        {"Hipparcos Number", "HIP 91777"},
        {"Geneva Identification System", "GEN# +1.00172579J"},
        {"Smithsonian Astrophysical Observation", "SAO 210488"},
    },
    visualMagnitude: 7.01,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.72143480),
        dec: Angle.Degrees(-39.28565449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4637"},
        {"Hipparcos Number", "HIP 3737"},
        {"Smithsonian Astrophysical Observation", "SAO 192750"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.99832649),
        dec: Angle.Degrees(-39.28236285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200096"},
        {"Hipparcos Number", "HIP 103857"},
        {"Smithsonian Astrophysical Observation", "SAO 212654"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.66761109),
        dec: Angle.Degrees(-39.28074802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131323"},
        {"Hipparcos Number", "HIP 72918"},
        {"Smithsonian Astrophysical Observation", "SAO 206064"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.53947413),
        dec: Angle.Degrees(-39.27834474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39125"},
        {"Hipparcos Number", "HIP 27445"},
        {"Smithsonian Astrophysical Observation", "SAO 196201"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.16570536),
        dec: Angle.Degrees(-39.27816689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18264"},
        {"Hipparcos Number", "HIP 13561"},
        {"Smithsonian Astrophysical Observation", "SAO 193980"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.67098237),
        dec: Angle.Degrees(-39.27718081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214704"},
        {"Hipparcos Number", "HIP 111951"},
        {"Smithsonian Astrophysical Observation", "SAO 214002"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.15914172),
        dec: Angle.Degrees(-39.27646502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195097"},
        {"Hipparcos Number", "HIP 101193"},
        {"Smithsonian Astrophysical Observation", "SAO 212189"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.67258379),
        dec: Angle.Degrees(-39.27575863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41384",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41384"},
        {"Smithsonian Astrophysical Observation", "SAO 199229"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.64155912),
        dec: Angle.Degrees(-39.27309026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106993"},
        {"Hipparcos Number", "HIP 60003"},
        {"Smithsonian Astrophysical Observation", "SAO 203329"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.59332701),
        dec: Angle.Degrees(-39.27129369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122918"},
        {"Hipparcos Number", "HIP 68831"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.41044079),
        dec: Angle.Degrees(-39.27003678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55449"},
        {"Hipparcos Number", "HIP 34701"},
        {"Celescope Catalog", "CEL 1656"},
        {"Smithsonian Astrophysical Observation", "SAO 197675"},
    },
    visualMagnitude: 7.92,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.81267368),
        dec: Angle.Degrees(-39.26981840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156603"},
        {"Hipparcos Number", "HIP 84836"},
        {"Geneva Identification System", "GEN# +1.00156603"},
        {"Smithsonian Astrophysical Observation", "SAO 208695"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.08967665),
        dec: Angle.Degrees(-39.26952010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219436"},
        {"Hipparcos Number", "HIP 114871"},
        {"Geneva Identification System", "GEN# +1.00219436"},
        {"Smithsonian Astrophysical Observation", "SAO 214417"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.01608611),
        dec: Angle.Degrees(-39.26827130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87560"},
        {"Hipparcos Number", "HIP 49378"},
    },
    visualMagnitude: 10.00,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.21810667),
        dec: Angle.Degrees(-39.26728895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112564"},
        {"Hipparcos Number", "HIP 63280"},
        {"Geneva Identification System", "GEN# +1.00112564"},
        {"Smithsonian Astrophysical Observation", "SAO 203981"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.51321483),
        dec: Angle.Degrees(-39.26724520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161277"},
        {"Hipparcos Number", "HIP 86983"},
        {"Geneva Identification System", "GEN# +1.00161277"},
        {"Renson", "Renson 45440"},
        {"Smithsonian Astrophysical Observation", "SAO 209236"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.62808670),
        dec: Angle.Degrees(-39.26478718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43847"},
        {"Hipparcos Number", "HIP 29808"},
        {"Geneva Identification System", "GEN# +1.00043847"},
        {"Renson", "Renson 11640"},
        {"Smithsonian Astrophysical Observation", "SAO 196646"},
    },
    visualMagnitude: 6.00,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.14833028),
        dec: Angle.Degrees(-39.26434877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206920"},
        {"Hipparcos Number", "HIP 107505"},
        {"Smithsonian Astrophysical Observation", "SAO 213271"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.60075910),
        dec: Angle.Degrees(-39.26340669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1856"},
        {"Hipparcos Number", "HIP 1795"},
        {"Geneva Identification System", "GEN# +1.00001856"},
        {"Smithsonian Astrophysical Observation", "SAO 192491"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.69984257),
        dec: Angle.Degrees(-39.26235447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136145"},
        {"Hipparcos Number", "HIP 75070"},
        {"Smithsonian Astrophysical Observation", "SAO 206534"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.10894065),
        dec: Angle.Degrees(-39.26211520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200854"},
        {"Hipparcos Number", "HIP 104264"},
        {"Smithsonian Astrophysical Observation", "SAO 212724"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.83583266),
        dec: Angle.Degrees(-39.26172962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24488"},
        {"Hipparcos Number", "HIP 18101"},
        {"Geneva Identification System", "GEN# +1.00024488"},
        {"Smithsonian Astrophysical Observation", "SAO 194593"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.03229425),
        dec: Angle.Degrees(-39.26152546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2132"},
        {"Hipparcos Number", "HIP 2001"},
        {"Smithsonian Astrophysical Observation", "SAO 192512"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.34201748),
        dec: Angle.Degrees(-39.26015325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45441",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45441"},
        {"Geneva Identification System", "GEN# -0.03805410"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.90723237),
        dec: Angle.Degrees(-39.25948840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120428"},
        {"Hipparcos Number", "HIP 67530"},
        {"Smithsonian Astrophysical Observation", "SAO 204886"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.53493600),
        dec: Angle.Degrees(-39.25934829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79241"},
        {"Hipparcos Number", "HIP 45127"},
        {"Geneva Identification System", "GEN# +1.00079241"},
        {"Smithsonian Astrophysical Observation", "SAO 200084"},
        {"Wilson Evans Batten Catalogue", "WEB 8610"},
    },
    visualMagnitude: 6.05,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.92061284),
        dec: Angle.Degrees(-39.25887079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169589"},
        {"Hipparcos Number", "HIP 90435"},
        {"Smithsonian Astrophysical Observation", "SAO 210163"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.78385392),
        dec: Angle.Degrees(-39.25855124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82453"},
        {"Hipparcos Number", "HIP 46668"},
        {"Smithsonian Astrophysical Observation", "SAO 200449"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.72805226),
        dec: Angle.Degrees(-39.25741748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3866"},
        {"Hipparcos Number", "HIP 3221"},
        {"Geneva Identification System", "GEN# +1.00003866"},
        {"Smithsonian Astrophysical Observation", "SAO 192677"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.23460304),
        dec: Angle.Degrees(-39.25707121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104694"},
        {"Hipparcos Number", "HIP 58780"},
        {"Geneva Identification System", "GEN# +1.00104694"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.83505154),
        dec: Angle.Degrees(-39.25631763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166617"},
        {"Hipparcos Number", "HIP 89297"},
        {"Smithsonian Astrophysical Observation", "SAO 209860"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.31872246),
        dec: Angle.Degrees(-39.25438445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202662"},
        {"Hipparcos Number", "HIP 105198"},
        {"Smithsonian Astrophysical Observation", "SAO 212885"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.64169441),
        dec: Angle.Degrees(-39.25389351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73118"},
        {"Hipparcos Number", "HIP 42130"},
        {"Smithsonian Astrophysical Observation", "SAO 199405"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.81586352),
        dec: Angle.Degrees(-39.25333958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122208"},
        {"Hipparcos Number", "HIP 68489"},
        {"Geneva Identification System", "GEN# +1.00122208"},
        {"Renson", "Renson 35050"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.32054232),
        dec: Angle.Degrees(-39.25328331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58111"},
        {"Hipparcos Number", "HIP 35739"},
        {"Geneva Identification System", "GEN# +1.00058111"},
        {"Smithsonian Astrophysical Observation", "SAO 197912"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.57902826),
        dec: Angle.Degrees(-39.25320241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -143.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142728"},
        {"Hipparcos Number", "HIP 78163"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.41274658),
        dec: Angle.Degrees(-39.24976617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163874"},
        {"Hipparcos Number", "HIP 88154"},
        {"Geneva Identification System", "GEN# +1.00163874"},
        {"Smithsonian Astrophysical Observation", "SAO 209575"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.07699971),
        dec: Angle.Degrees(-39.24931187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111773"},
        {"Hipparcos Number", "HIP 62787"},
        {"Smithsonian Astrophysical Observation", "SAO 203882"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.98999400),
        dec: Angle.Degrees(-39.24572154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3092"},
        {"Hipparcos Number", "HIP 2673"},
        {"Geneva Identification System", "GEN# +1.00003092"},
        {"Smithsonian Astrophysical Observation", "SAO 192612"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.47042411),
        dec: Angle.Degrees(-39.24552069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196458"},
        {"Hipparcos Number", "HIP 101898"},
        {"Smithsonian Astrophysical Observation", "SAO 212312"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.74005753),
        dec: Angle.Degrees(-39.24432208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1182",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1182"},
        {"Geneva Identification System", "GEN# -0.03900043"},
    },
    visualMagnitude: 11.83,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.69058883),
        dec: Angle.Degrees(-39.24322467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1683"},
        {"Hipparcos Number", "HIP 1667"},
        {"Fundamental Katalog 5th Edition", "FK5 2019"},
        {"Geneva Identification System", "GEN# +1.00001683"},
        {"Smithsonian Astrophysical Observation", "SAO 192474"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.22402894),
        dec: Angle.Degrees(-39.23978178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62227"},
        {"Hipparcos Number", "HIP 37446"},
        {"Celescope Catalog", "CEL 1979"},
        {"Geneva Identification System", "GEN# +2.24510202"},
        {"Smithsonian Astrophysical Observation", "SAO 198297"},
        {"New General Catalogue", "NGC 2451 202"},
    },
    visualMagnitude: 7.73,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.30970441),
        dec: Angle.Degrees(-39.23638078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141314"},
        {"Hipparcos Number", "HIP 77540"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.48827279),
        dec: Angle.Degrees(-39.23615492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100074"},
        {"Hipparcos Number", "HIP 56160"},
        {"Fundamental Katalog 5th Edition", "FK5 5014"},
        {"Geneva Identification System", "GEN# +1.00100074"},
        {"Smithsonian Astrophysical Observation", "SAO 202521"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.68297192),
        dec: Angle.Degrees(-39.23549772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40866"},
        {"Hipparcos Number", "HIP 28389"},
        {"Fundamental Katalog 5th Edition", "FK5 4546"},
        {"Smithsonian Astrophysical Observation", "SAO 196394"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.94952364),
        dec: Angle.Degrees(-39.23535369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196048"},
        {"Hipparcos Number", "HIP 101650"},
        {"Smithsonian Astrophysical Observation", "SAO 212273"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.08350535),
        dec: Angle.Degrees(-39.23503070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75445"},
        {"Hipparcos Number", "HIP 43257"},
        {"Geneva Identification System", "GEN# +1.00075445"},
        {"Renson", "Renson 21120"},
        {"Smithsonian Astrophysical Observation", "SAO 199654"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.17899205),
        dec: Angle.Degrees(-39.23399053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 948",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 948"},
        {"Cincinnati Publication", "Ci 20 11"},
        {"Geneva Identification System", "GEN# -0.03900031"},
        {"Wilson Evans Batten Catalogue", "WEB 170"},
    },
    visualMagnitude: 9.92,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.92120675),
        dec: Angle.Degrees(-39.22963982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 739.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80300",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80300"},
        {"Geneva Identification System", "GEN# -0.03810980"},
    },
    visualMagnitude: 11.01,
    bvColour: -0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.89074946),
        dec: Angle.Degrees(-39.22948995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89552"},
        {"Hipparcos Number", "HIP 50527"},
        {"Smithsonian Astrophysical Observation", "SAO 201278"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.80362983),
        dec: Angle.Degrees(-39.22945942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180494"},
        {"Hipparcos Number", "HIP 94878"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.62246622),
        dec: Angle.Degrees(-39.22916461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124378"},
        {"Hipparcos Number", "HIP 69553"},
        {"Smithsonian Astrophysical Observation", "SAO 205331"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.56138319),
        dec: Angle.Degrees(-39.22852537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108757"},
        {"Hipparcos Number", "HIP 60982"},
        {"Smithsonian Astrophysical Observation", "SAO 203528"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.49375381),
        dec: Angle.Degrees(-39.22731853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194477"},
        {"Hipparcos Number", "HIP 100874"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.80662215),
        dec: Angle.Degrees(-39.22296094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212493"},
        {"Hipparcos Number", "HIP 110680"},
        {"Smithsonian Astrophysical Observation", "SAO 213806"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.861,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.34708040),
        dec: Angle.Degrees(-39.22281195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113598"},
        {"Hipparcos Number", "HIP 63866"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.33224534),
        dec: Angle.Degrees(-39.22204169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36136"},
        {"Hipparcos Number", "HIP 25553"},
        {"Geneva Identification System", "GEN# +1.00036136"},
        {"Smithsonian Astrophysical Observation", "SAO 195878"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.93686735),
        dec: Angle.Degrees(-39.22191897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115122",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115122"},
        {"Smithsonian Astrophysical Observation", "SAO 214447"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.76962734),
        dec: Angle.Degrees(-39.22178222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222615"},
        {"Hipparcos Number", "HIP 116950"},
        {"Smithsonian Astrophysical Observation", "SAO 214720"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.59228839),
        dec: Angle.Degrees(-39.22023687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105095"},
        {"Hipparcos Number", "HIP 59012"},
        {"Smithsonian Astrophysical Observation", "SAO 203121"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.50168977),
        dec: Angle.Degrees(-39.22020365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44844"},
        {"Hipparcos Number", "HIP 30284"},
        {"Smithsonian Astrophysical Observation", "SAO 196742"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.55359428),
        dec: Angle.Degrees(-39.21930075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103854"},
        {"Hipparcos Number", "HIP 58315"},
        {"Geneva Identification System", "GEN# +1.00103854"},
        {"Smithsonian Astrophysical Observation", "SAO 202982"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.802,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.37510730),
        dec: Angle.Degrees(-39.21774724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143996"},
        {"Hipparcos Number", "HIP 78781"},
        {"Smithsonian Astrophysical Observation", "SAO 207304"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.25470708),
        dec: Angle.Degrees(-39.21664243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191272"},
        {"Hipparcos Number", "HIP 99408"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.64503571),
        dec: Angle.Degrees(-39.21250881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225006"},
        {"Hipparcos Number", "HIP 193"},
        {"Smithsonian Astrophysical Observation", "SAO 214938"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.62164007),
        dec: Angle.Degrees(-39.21249918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6094",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6094"},
    },
    visualMagnitude: 11.25,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.56230158),
        dec: Angle.Degrees(-39.21236470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135705"},
        {"Hipparcos Number", "HIP 74863"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.48164266),
        dec: Angle.Degrees(-39.21230124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57240"},
        {"Hipparcos Number", "HIP 35393"},
        {"Celescope Catalog", "CEL 1771"},
        {"Geneva Identification System", "GEN# +1.00057240"},
        {"Smithsonian Astrophysical Observation", "SAO 197836"},
        {"Wilson Evans Batten Catalogue", "WEB 7063"},
    },
    visualMagnitude: 5.24,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.63966607),
        dec: Angle.Degrees(-39.21030701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42664"},
        {"Hipparcos Number", "HIP 29257"},
        {"Smithsonian Astrophysical Observation", "SAO 196552"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.53562975),
        dec: Angle.Degrees(-39.20895922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129419"},
        {"Hipparcos Number", "HIP 72003"},
        {"Smithsonian Astrophysical Observation", "SAO 205864"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.88233060),
        dec: Angle.Degrees(-39.20783723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57844",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57844"},
    },
    visualMagnitude: 10.41,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.92951367),
        dec: Angle.Degrees(-39.20748115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205932"},
        {"Hipparcos Number", "HIP 106952"},
        {"Smithsonian Astrophysical Observation", "SAO 213179"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.91505088),
        dec: Angle.Degrees(-39.20641288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160147"},
        {"Hipparcos Number", "HIP 86474"},
        {"Smithsonian Astrophysical Observation", "SAO 209100"},
    },
    visualMagnitude: 7.44,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.04050994),
        dec: Angle.Degrees(-39.20496324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127969"},
        {"Hipparcos Number", "HIP 71349"},
        {"Smithsonian Astrophysical Observation", "SAO 205726"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.86984513),
        dec: Angle.Degrees(-39.20335204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61376"},
        {"Hipparcos Number", "HIP 37087"},
        {"Geneva Identification System", "GEN# +2.24510146"},
        {"Smithsonian Astrophysical Observation", "SAO 198198"},
        {"New General Catalogue", "NGC 2451 146"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.31862155),
        dec: Angle.Degrees(-39.20194716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62503"},
        {"Hipparcos Number", "HIP 37557"},
        {"Celescope Catalog", "CEL 1991"},
        {"Geneva Identification System", "GEN# +2.24510218"},
        {"Smithsonian Astrophysical Observation", "SAO 198332"},
        {"New General Catalogue", "NGC 2451 218"},
    },
    visualMagnitude: 7.26,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.62763896),
        dec: Angle.Degrees(-39.20129432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197630"},
        {"Hipparcos Number", "HIP 102497"},
        {"Fundamental Katalog 5th Edition", "FK5 3658"},
        {"Geneva Identification System", "GEN# +1.00197630"},
        {"Smithsonian Astrophysical Observation", "SAO 212416"},
        {"Wilson Evans Batten Catalogue", "WEB 18567"},
    },
    visualMagnitude: 5.48,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.58346515),
        dec: Angle.Degrees(-39.19918925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184306"},
        {"Hipparcos Number", "HIP 96367"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.89173596),
        dec: Angle.Degrees(-39.19353387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48797"},
        {"Hipparcos Number", "HIP 32208"},
        {"Fundamental Katalog 5th Edition", "FK5 2519"},
        {"Geneva Identification System", "GEN# +1.00048797"},
        {"Renson", "Renson 13050"},
        {"Smithsonian Astrophysical Observation", "SAO 197134"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.84731179),
        dec: Angle.Degrees(-39.19308157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147513"},
        {"Hipparcos Number", "HIP 80337"},
        {"Fundamental Katalog 5th Edition", "FK5 3295"},
        {"Geneva Identification System", "GEN# +1.00147513"},
        {"Smithsonian Astrophysical Observation", "SAO 207622"},
        {"Wilson Evans Batten Catalogue", "WEB 13592"},
    },
    visualMagnitude: 5.37,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.00514651),
        dec: Angle.Degrees(-39.19298857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9970"},
        {"Hipparcos Number", "HIP 7504"},
        {"Smithsonian Astrophysical Observation", "SAO 193206"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.17372307),
        dec: Angle.Degrees(-39.19293142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8085"},
        {"Hipparcos Number", "HIP 6210"},
        {"Smithsonian Astrophysical Observation", "SAO 193053"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.90254840),
        dec: Angle.Degrees(-39.19005589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159705"},
        {"Hipparcos Number", "HIP 86294"},
        {"Geneva Identification System", "GEN# +1.00159705"},
        {"Smithsonian Astrophysical Observation", "SAO 209048"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.48933666),
        dec: Angle.Degrees(-39.18953748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95326",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95326"},
    },
    visualMagnitude: 12.39,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.91222473),
        dec: Angle.Degrees(-39.18916047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124505"},
        {"Hipparcos Number", "HIP 69630"},
        {"Smithsonian Astrophysical Observation", "SAO 205349"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.76167967),
        dec: Angle.Degrees(-39.18874933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105804",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105804"},
        {"Smithsonian Astrophysical Observation", "SAO 212987"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.41264263),
        dec: Angle.Degrees(-39.18692791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178440"},
        {"Hipparcos Number", "HIP 94180"},
        {"Smithsonian Astrophysical Observation", "SAO 211008"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.60071448),
        dec: Angle.Degrees(-39.18663361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123836"},
        {"Hipparcos Number", "HIP 69272"},
        {"Smithsonian Astrophysical Observation", "SAO 205268"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.71747793),
        dec: Angle.Degrees(-39.18591819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181816"},
        {"Hipparcos Number", "HIP 95324"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.90881682),
        dec: Angle.Degrees(-39.18437408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3431",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3431"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.93999646),
        dec: Angle.Degrees(-39.18185928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30939"},
        {"Hipparcos Number", "HIP 22463"},
        {"Smithsonian Astrophysical Observation", "SAO 195339"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.51752217),
        dec: Angle.Degrees(-39.18099768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91338"},
        {"Hipparcos Number", "HIP 51570"},
        {"Smithsonian Astrophysical Observation", "SAO 201482"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.99856217),
        dec: Angle.Degrees(-39.18027449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28851"},
        {"Hipparcos Number", "HIP 21070"},
        {"Smithsonian Astrophysical Observation", "SAO 195090"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.74764760),
        dec: Angle.Degrees(-39.17919060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 109.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219261"},
        {"Hipparcos Number", "HIP 114771"},
        {"Smithsonian Astrophysical Observation", "SAO 214403"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.73116526),
        dec: Angle.Degrees(-39.17793039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107692"},
        {"Hipparcos Number", "HIP 60370"},
        {"Geneva Identification System", "GEN# +1.00107692"},
        {"Smithsonian Astrophysical Observation", "SAO 203408"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.68615139),
        dec: Angle.Degrees(-39.17732244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174199"},
        {"Hipparcos Number", "HIP 92508"},
        {"Smithsonian Astrophysical Observation", "SAO 210629"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.78639343),
        dec: Angle.Degrees(-39.17488777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203369"},
        {"Hipparcos Number", "HIP 105568"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.71985907),
        dec: Angle.Degrees(-39.17458561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19214"},
        {"Hipparcos Number", "HIP 14280"},
        {"Geneva Identification System", "GEN# +1.00019214"},
        {"Smithsonian Astrophysical Observation", "SAO 194065"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.01738216),
        dec: Angle.Degrees(-39.17089413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93837"},
        {"Hipparcos Number", "HIP 52916"},
        {"Celescope Catalog", "CEL 3724"},
        {"Smithsonian Astrophysical Observation", "SAO 201794"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.33797457),
        dec: Angle.Degrees(-39.17034837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153050"},
        {"Hipparcos Number", "HIP 83104"},
        {"Fundamental Katalog 5th Edition", "FK5 5497"},
        {"Smithsonian Astrophysical Observation", "SAO 208260"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.72984207),
        dec: Angle.Degrees(-39.16848193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7007"},
        {"Hipparcos Number", "HIP 5461"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.47499788),
        dec: Angle.Degrees(-39.16815221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158469"},
        {"Hipparcos Number", "HIP 85747"},
        {"Geneva Identification System", "GEN# +1.00158469"},
        {"Smithsonian Astrophysical Observation", "SAO 208904"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.83243078),
        dec: Angle.Degrees(-39.16536694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7221"},
        {"Hipparcos Number", "HIP 5613"},
        {"Geneva Identification System", "GEN# +1.00007221"},
        {"Smithsonian Astrophysical Observation", "SAO 192974"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.99998194),
        dec: Angle.Degrees(-39.16165201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166553"},
        {"Hipparcos Number", "HIP 89269"},
        {"Smithsonian Astrophysical Observation", "SAO 209855"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.24634397),
        dec: Angle.Degrees(-39.16150113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49630"},
        {"Hipparcos Number", "HIP 32553"},
        {"Smithsonian Astrophysical Observation", "SAO 197217"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.886,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.88581110),
        dec: Angle.Degrees(-39.16097029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139233"},
        {"Hipparcos Number", "HIP 76591"},
        {"Celescope Catalog", "CEL 4386"},
        {"Fundamental Katalog 5th Edition", "FK5 3234"},
        {"Geneva Identification System", "GEN# +1.00139233"},
        {"Smithsonian Astrophysical Observation", "SAO 206826"},
        {"Wilson Evans Batten Catalogue", "WEB 13000"},
    },
    visualMagnitude: 6.59,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.63605643),
        dec: Angle.Degrees(-39.16064212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219860"},
        {"Hipparcos Number", "HIP 115146"},
        {"Fundamental Katalog 5th Edition", "FK5 3867"},
        {"Renson", "Renson 60370"},
        {"Smithsonian Astrophysical Observation", "SAO 214451"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.85732351),
        dec: Angle.Degrees(-39.15838526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216149"},
        {"Hipparcos Number", "HIP 112832"},
        {"Fundamental Katalog 5th Edition", "FK5 1599"},
        {"Geneva Identification System", "GEN# +1.00216149"},
        {"Smithsonian Astrophysical Observation", "SAO 214134"},
        {"Wilson Evans Batten Catalogue", "WEB 20097"},
    },
    visualMagnitude: 5.43,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.75894036),
        dec: Angle.Degrees(-39.15681779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40340"},
        {"Hipparcos Number", "HIP 28097"},
        {"Smithsonian Astrophysical Observation", "SAO 196331"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.08612111),
        dec: Angle.Degrees(-39.15563215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214466"},
        {"Hipparcos Number", "HIP 111819"},
        {"Smithsonian Astrophysical Observation", "SAO 213983"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.73552878),
        dec: Angle.Degrees(-39.15490907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217306"},
        {"Hipparcos Number", "HIP 113585"},
        {"Geneva Identification System", "GEN# +1.00217306"},
        {"Smithsonian Astrophysical Observation", "SAO 214234"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.08883516),
        dec: Angle.Degrees(-39.15474935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149764"},
        {"Hipparcos Number", "HIP 81477"},
        {"Geneva Identification System", "GEN# +1.00149764"},
        {"Renson", "Renson 42360"},
        {"Smithsonian Astrophysical Observation", "SAO 207863"},
    },
    visualMagnitude: 6.93,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.62896088),
        dec: Angle.Degrees(-39.15227824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207906"},
        {"Hipparcos Number", "HIP 108053"},
        {"Smithsonian Astrophysical Observation", "SAO 213366"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.36070884),
        dec: Angle.Degrees(-39.14963269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36967"},
        {"Hipparcos Number", "HIP 26049"},
        {"Smithsonian Astrophysical Observation", "SAO 195961"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.35879877),
        dec: Angle.Degrees(-39.14869018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69819"},
        {"Hipparcos Number", "HIP 40587"},
        {"Smithsonian Astrophysical Observation", "SAO 199044"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.30385757),
        dec: Angle.Degrees(-39.14834125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10552"},
        {"Hipparcos Number", "HIP 7938"},
        {"Geneva Identification System", "GEN# +1.00010552"},
        {"Smithsonian Astrophysical Observation", "SAO 193262"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.50953411),
        dec: Angle.Degrees(-39.14744291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101452"},
        {"Hipparcos Number", "HIP 56925"},
        {"Fundamental Katalog 5th Edition", "FK5 5028"},
        {"Renson", "Renson 29240"},
        {"Smithsonian Astrophysical Observation", "SAO 202696"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.05696285),
        dec: Angle.Degrees(-39.14651526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223441"},
        {"Hipparcos Number", "HIP 117502"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.42073444),
        dec: Angle.Degrees(-39.14384467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8961"},
        {"Hipparcos Number", "HIP 6816"},
        {"Smithsonian Astrophysical Observation", "SAO 193126"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.92163627),
        dec: Angle.Degrees(-39.14226198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75654"},
        {"Hipparcos Number", "HIP 43354"},
        {"Fundamental Katalog 5th Edition", "FK5 2697"},
        {"Geneva Identification System", "GEN# +1.00075654"},
        {"Smithsonian Astrophysical Observation", "SAO 199682"},
        {"Wilson Evans Batten Catalogue", "WEB 8353"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.46833118),
        dec: Angle.Degrees(-39.14170326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211044"},
        {"Hipparcos Number", "HIP 109879"},
        {"Smithsonian Astrophysical Observation", "SAO 213671"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.81984728),
        dec: Angle.Degrees(-39.14091012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28030"},
        {"Hipparcos Number", "HIP 20510"},
        {"Smithsonian Astrophysical Observation", "SAO 194979"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.92895395),
        dec: Angle.Degrees(-39.13986962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118"},
        {"Hipparcos Number", "HIP 501"},
        {"Smithsonian Astrophysical Observation", "SAO 192356"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.50054698),
        dec: Angle.Degrees(-39.13751717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74556"},
        {"Hipparcos Number", "HIP 42805"},
        {"Geneva Identification System", "GEN# +1.00074556"},
        {"Smithsonian Astrophysical Observation", "SAO 199542"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.81766625),
        dec: Angle.Degrees(-39.13696274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13487"},
        {"Hipparcos Number", "HIP 10174"},
        {"Smithsonian Astrophysical Observation", "SAO 193557"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.71175101),
        dec: Angle.Degrees(-39.13685893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163433"},
        {"Hipparcos Number", "HIP 87948"},
        {"Geneva Identification System", "GEN# +1.00163433J"},
        {"Smithsonian Astrophysical Observation", "SAO 209524"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.49082375),
        dec: Angle.Degrees(-39.13646688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211534"},
        {"Hipparcos Number", "HIP 110127"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.62224874),
        dec: Angle.Degrees(-39.13615310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4750"},
        {"Hipparcos Number", "HIP 3827"},
        {"Smithsonian Astrophysical Observation", "SAO 192763"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.27837507),
        dec: Angle.Degrees(-39.13386757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177612"},
        {"Hipparcos Number", "HIP 93893"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.78804619),
        dec: Angle.Degrees(-39.13250437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16254",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16254"},
        {"Smithsonian Astrophysical Observation", "SAO 194334"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.36479764),
        dec: Angle.Degrees(-39.13227903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77060"},
        {"Hipparcos Number", "HIP 44074"},
        {"Smithsonian Astrophysical Observation", "SAO 199848"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.68115704),
        dec: Angle.Degrees(-39.13220660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212953"},
        {"Hipparcos Number", "HIP 110936"},
        {"Fundamental Katalog 5th Edition", "FK5 845"},
        {"Geneva Identification System", "GEN# +1.00212953"},
        {"Smithsonian Astrophysical Observation", "SAO 213850"},
        {"Wilson Evans Batten Catalogue", "WEB 19861"},
    },
    visualMagnitude: 5.47,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.16325785),
        dec: Angle.Degrees(-39.13140099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31007",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31007"},
    },
    visualMagnitude: 12.40,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.60897377),
        dec: Angle.Degrees(-39.13079058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134739"},
        {"Hipparcos Number", "HIP 74350"},
        {"Wilson Evans Batten Catalogue", "WEB 12689"},
    },
    visualMagnitude: 10.74,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.92213275),
        dec: Angle.Degrees(-06.01144723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82785"},
        {"Hipparcos Number", "HIP 46874"},
        {"Geneva Identification System", "GEN# +1.00082785"},
        {"Smithsonian Astrophysical Observation", "SAO 200492"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.28213125),
        dec: Angle.Degrees(-39.12916862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139271"},
        {"Hipparcos Number", "HIP 76608"},
        {"Geneva Identification System", "GEN# +1.00139271"},
        {"Renson", "Renson 39650"},
        {"Smithsonian Astrophysical Observation", "SAO 206827"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.67570146),
        dec: Angle.Degrees(-39.12774671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212385"},
        {"Hipparcos Number", "HIP 110624"},
        {"Geneva Identification System", "GEN# +1.00212385"},
        {"Renson", "Renson 58910"},
        {"Smithsonian Astrophysical Observation", "SAO 213795"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.15633818),
        dec: Angle.Degrees(-39.12704149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94443"},
        {"Hipparcos Number", "HIP 53264"},
        {"Smithsonian Astrophysical Observation", "SAO 201864"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.39977615),
        dec: Angle.Degrees(-39.12353313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6308"},
        {"Hipparcos Number", "HIP 4958"},
        {"Geneva Identification System", "GEN# +1.00006308"},
        {"Smithsonian Astrophysical Observation", "SAO 192895"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.89304400),
        dec: Angle.Degrees(-39.12339079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 158.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22933"},
        {"Hipparcos Number", "HIP 17067"},
        {"Fundamental Katalog 5th Edition", "FK5 4330"},
        {"Smithsonian Astrophysical Observation", "SAO 194434"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.87080392),
        dec: Angle.Degrees(-39.12099507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87577"},
        {"Hipparcos Number", "HIP 49386"},
        {"Smithsonian Astrophysical Observation", "SAO 201028"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.23511284),
        dec: Angle.Degrees(-39.11808639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58157"},
        {"Hipparcos Number", "HIP 35757"},
        {"Smithsonian Astrophysical Observation", "SAO 197919"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.63568771),
        dec: Angle.Degrees(-39.11736869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152885"},
        {"Hipparcos Number", "HIP 83014"},
        {"Smithsonian Astrophysical Observation", "SAO 208237"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.45925516),
        dec: Angle.Degrees(-39.11573382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221486"},
        {"Hipparcos Number", "HIP 116211"},
        {"Smithsonian Astrophysical Observation", "SAO 214611"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.19992565),
        dec: Angle.Degrees(-39.11565749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221486B"},
        {"Hipparcos Number", "HIP 116214"},
    },
    visualMagnitude: 10.99,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.20391724),
        dec: Angle.Degrees(-39.11385102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192702"},
        {"Hipparcos Number", "HIP 100033"},
        {"Geneva Identification System", "GEN# +1.00192702"},
        {"Wilson Evans Batten Catalogue", "WEB 18010"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.43187189),
        dec: Angle.Degrees(-39.11274924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161276"},
        {"Hipparcos Number", "HIP 86968"},
        {"Smithsonian Astrophysical Observation", "SAO 209234"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.60332396),
        dec: Angle.Degrees(-39.11053647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198590"},
        {"Hipparcos Number", "HIP 103049"},
        {"Geneva Identification System", "GEN# +1.00198590"},
        {"Smithsonian Astrophysical Observation", "SAO 212506"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.17972449),
        dec: Angle.Degrees(-39.10861892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5466"},
        {"Hipparcos Number", "HIP 4369"},
        {"Geneva Identification System", "GEN# +1.00005466"},
        {"Smithsonian Astrophysical Observation", "SAO 192822"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.99641546),
        dec: Angle.Degrees(-39.10691094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164036"},
        {"Hipparcos Number", "HIP 88230"},
        {"Smithsonian Astrophysical Observation", "SAO 209590"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.26241180),
        dec: Angle.Degrees(-39.10567561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112680"},
        {"Hipparcos Number", "HIP 63350"},
        {"Smithsonian Astrophysical Observation", "SAO 204001"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.71984222),
        dec: Angle.Degrees(-39.10561548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144668"},
        {"Hipparcos Number", "HIP 79080"},
        {"Geneva Identification System", "GEN# +1.00144668"},
        {"Smithsonian Astrophysical Observation", "SAO 207367"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.14289152),
        dec: Angle.Degrees(-39.10503476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98867"},
        {"Hipparcos Number", "HIP 55526"},
        {"Geneva Identification System", "GEN# +1.00098867"},
        {"Smithsonian Astrophysical Observation", "SAO 202373"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.58961612),
        dec: Angle.Degrees(-39.10495621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88872"},
        {"Hipparcos Number", "HIP 50149"},
        {"Smithsonian Astrophysical Observation", "SAO 201196"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.55709253),
        dec: Angle.Degrees(-39.10368201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152160"},
        {"Hipparcos Number", "HIP 82625"},
        {"Geneva Identification System", "GEN# +1.00152160"},
        {"Smithsonian Astrophysical Observation", "SAO 208141"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.35845613),
        dec: Angle.Degrees(-39.10328968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63424"},
        {"Hipparcos Number", "HIP 37992"},
        {"Geneva Identification System", "GEN# +2.24510281"},
        {"Smithsonian Astrophysical Observation", "SAO 198439"},
        {"New General Catalogue", "NGC 2451 281"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.79234595),
        dec: Angle.Degrees(-39.10324795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69929"},
        {"Hipparcos Number", "HIP 40629"},
        {"Smithsonian Astrophysical Observation", "SAO 199050"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.42208919),
        dec: Angle.Degrees(-39.10299191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55474"},
        {"Hipparcos Number", "HIP 34721"},
        {"Celescope Catalog", "CEL 1657"},
        {"Smithsonian Astrophysical Observation", "SAO 197678"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.84428053),
        dec: Angle.Degrees(-39.10221559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163375"},
        {"Hipparcos Number", "HIP 87924"},
        {"Smithsonian Astrophysical Observation", "SAO 209519"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.42051923),
        dec: Angle.Degrees(-39.10174744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50045",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50045"},
        {"Geneva Identification System", "GEN# -0.03806282"},
    },
    visualMagnitude: 11.05,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.25774318),
        dec: Angle.Degrees(-39.10154575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -326.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -256.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198306"},
        {"Hipparcos Number", "HIP 102898"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.69125259),
        dec: Angle.Degrees(-39.10086735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138374"},
        {"Hipparcos Number", "HIP 76141"},
        {"Smithsonian Astrophysical Observation", "SAO 206747"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.28596710),
        dec: Angle.Degrees(-39.09980296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144477"},
        {"Hipparcos Number", "HIP 79009"},
        {"Smithsonian Astrophysical Observation", "SAO 207347"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.90922239),
        dec: Angle.Degrees(-39.09977919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81429"},
        {"Hipparcos Number", "HIP 46124"},
        {"Smithsonian Astrophysical Observation", "SAO 200333"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.09160726),
        dec: Angle.Degrees(-39.09943991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25072"},
        {"Hipparcos Number", "HIP 18503"},
        {"Smithsonian Astrophysical Observation", "SAO 194648"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.35027754),
        dec: Angle.Degrees(-39.09864606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223304"},
        {"Hipparcos Number", "HIP 117422"},
        {"Smithsonian Astrophysical Observation", "SAO 214785"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.14524118),
        dec: Angle.Degrees(-39.09837473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9465"},
        {"Hipparcos Number", "HIP 7151"},
        {"Smithsonian Astrophysical Observation", "SAO 193169"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.05096841),
        dec: Angle.Degrees(-39.09800347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140242"},
        {"Hipparcos Number", "HIP 77051"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.00469469),
        dec: Angle.Degrees(-39.09475776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187670"},
        {"Hipparcos Number", "HIP 97826"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.18683758),
        dec: Angle.Degrees(-39.09437277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82926",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82926"},
    },
    visualMagnitude: 11.18,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.20216085),
        dec: Angle.Degrees(-39.09365955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144667"},
        {"Hipparcos Number", "HIP 79081"},
        {"Geneva Identification System", "GEN# +1.00144667"},
        {"Renson", "Renson 41010"},
        {"Smithsonian Astrophysical Observation", "SAO 207368"},
    },
    visualMagnitude: 6.65,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.14403299),
        dec: Angle.Degrees(-39.09279944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71932"},
        {"Hipparcos Number", "HIP 41567"},
        {"Fundamental Katalog 5th Edition", "FK5 4764"},
        {"Smithsonian Astrophysical Observation", "SAO 199275"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.13440405),
        dec: Angle.Degrees(-39.09252643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35815",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35815"},
        {"Smithsonian Astrophysical Observation", "SAO 197932"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.79704767),
        dec: Angle.Degrees(-39.09087296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212895"},
        {"Hipparcos Number", "HIP 110912"},
        {"Fundamental Katalog 5th Edition", "FK5 5982"},
        {"Smithsonian Astrophysical Observation", "SAO 213843"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.05517242),
        dec: Angle.Degrees(-39.08916261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31495"},
        {"Hipparcos Number", "HIP 22819"},
        {"Geneva Identification System", "GEN# +1.00031495"},
        {"Smithsonian Astrophysical Observation", "SAO 195395"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.64827462),
        dec: Angle.Degrees(-39.08914340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143232"},
        {"Hipparcos Number", "HIP 78435"},
        {"Geneva Identification System", "GEN# +1.00143232"},
        {"Renson", "Renson 40570"},
        {"Smithsonian Astrophysical Observation", "SAO 207224"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.19538822),
        dec: Angle.Degrees(-39.08838589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15966",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15966"},
        {"Smithsonian Astrophysical Observation", "SAO 194286"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.39820327),
        dec: Angle.Degrees(-39.08735357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172205"},
        {"Hipparcos Number", "HIP 91593"},
        {"Smithsonian Astrophysical Observation", "SAO 210437"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.19121723),
        dec: Angle.Degrees(-39.08733193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214915"},
        {"Hipparcos Number", "HIP 112090"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.55526530),
        dec: Angle.Degrees(-39.08415859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64010"},
        {"Hipparcos Number", "HIP 38250"},
        {"Geneva Identification System", "GEN# +1.00064010"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.53414796),
        dec: Angle.Degrees(-39.08116286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 153.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207277"},
        {"Hipparcos Number", "HIP 107685"},
        {"Geneva Identification System", "GEN# +1.00207277"},
        {"Smithsonian Astrophysical Observation", "SAO 213304"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.20241871),
        dec: Angle.Degrees(-39.07942161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70157"},
        {"Hipparcos Number", "HIP 40740"},
        {"Celescope Catalog", "CEL 2356"},
        {"Geneva Identification System", "GEN# +1.00070157"},
        {"Smithsonian Astrophysical Observation", "SAO 199074"},
    },
    visualMagnitude: 7.08,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.73877722),
        dec: Angle.Degrees(-39.07905628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68474"},
        {"Hipparcos Number", "HIP 40056"},
        {"Celescope Catalog", "CEL 2210"},
        {"Geneva Identification System", "GEN# +1.00068474J"},
        {"Smithsonian Astrophysical Observation", "SAO 198897"},
        {"Wilson Evans Batten Catalogue", "WEB 7815"},
    },
    visualMagnitude: 7.37,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.73944300),
        dec: Angle.Degrees(-39.07810200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32516"},
        {"Hipparcos Number", "HIP 23420"},
        {"Smithsonian Astrophysical Observation", "SAO 195507"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.50293775),
        dec: Angle.Degrees(-39.07748222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72231",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72231"},
    },
    visualMagnitude: 10.10,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.58119705),
        dec: Angle.Degrees(-39.07342934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176206"},
        {"Hipparcos Number", "HIP 93352"},
        {"Smithsonian Astrophysical Observation", "SAO 210811"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.21838241),
        dec: Angle.Degrees(-39.07317418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153920"},
        {"Hipparcos Number", "HIP 83516"},
        {"Smithsonian Astrophysical Observation", "SAO 208359"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.02146433),
        dec: Angle.Degrees(-39.07165521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129912"},
        {"Hipparcos Number", "HIP 72225"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.57320948),
        dec: Angle.Degrees(-39.07101500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5205"},
        {"Hipparcos Number", "HIP 4181"},
        {"Geneva Identification System", "GEN# +1.00005205"},
        {"Smithsonian Astrophysical Observation", "SAO 192798"},
        {"Wilson Evans Batten Catalogue", "WEB 751"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.35484770),
        dec: Angle.Degrees(-39.06792204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59947",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59947"},
    },
    visualMagnitude: 11.17,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.44510900),
        dec: Angle.Degrees(-39.06754140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72514"},
        {"Hipparcos Number", "HIP 41848"},
        {"Celescope Catalog", "CEL 2613"},
        {"Smithsonian Astrophysical Observation", "SAO 199340"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.98728518),
        dec: Angle.Degrees(-39.06627756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72436"},
        {"Hipparcos Number", "HIP 41806"},
        {"Celescope Catalog", "CEL 2596"},
        {"Geneva Identification System", "GEN# +1.00072436"},
        {"Smithsonian Astrophysical Observation", "SAO 199329"},
        {"Wilson Evans Batten Catalogue", "WEB 8050"},
    },
    visualMagnitude: 6.31,
    bvColour: -0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.85291267),
        dec: Angle.Degrees(-39.06413261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91124"},
        {"Hipparcos Number", "HIP 51450"},
        {"Geneva Identification System", "GEN# +1.00091124"},
        {"Smithsonian Astrophysical Observation", "SAO 201456"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.62853943),
        dec: Angle.Degrees(-39.06385961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20413"},
        {"Hipparcos Number", "HIP 15185"},
        {"Smithsonian Astrophysical Observation", "SAO 194196"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.93273014),
        dec: Angle.Degrees(-39.06313897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2943",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2943"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.33953653),
        dec: Angle.Degrees(-39.06241662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171083"},
        {"Hipparcos Number", "HIP 91060"},
        {"Smithsonian Astrophysical Observation", "SAO 210319"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.62831113),
        dec: Angle.Degrees(-39.06129569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72384"},
        {"Hipparcos Number", "HIP 41774"},
        {"Smithsonian Astrophysical Observation", "SAO 199324"},
    },
    visualMagnitude: 7.32,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.77473264),
        dec: Angle.Degrees(-39.06097529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33981"},
        {"Hipparcos Number", "HIP 24242"},
        {"Smithsonian Astrophysical Observation", "SAO 195651"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.06983239),
        dec: Angle.Degrees(-39.05941401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112532",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112532"},
    },
    visualMagnitude: 10.75,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.89443835),
        dec: Angle.Degrees(-39.05911175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71487"},
        {"Hipparcos Number", "HIP 41361"},
        {"Celescope Catalog", "CEL 2505"},
        {"Smithsonian Astrophysical Observation", "SAO 199222"},
    },
    visualMagnitude: 6.07,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.57390136),
        dec: Angle.Degrees(-39.05897459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92987"},
        {"Hipparcos Number", "HIP 52472"},
        {"Fundamental Katalog 5th Edition", "FK5 2858"},
        {"Geneva Identification System", "GEN# +1.00092987"},
        {"Smithsonian Astrophysical Observation", "SAO 201684"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.90108431),
        dec: Angle.Degrees(-39.05844709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120958"},
        {"Hipparcos Number", "HIP 67809"},
        {"Celescope Catalog", "CEL 4285"},
        {"Geneva Identification System", "GEN# +1.00120958"},
        {"Smithsonian Astrophysical Observation", "SAO 204949"},
        {"Wilson Evans Batten Catalogue", "WEB 11921"},
    },
    visualMagnitude: 7.61,
    bvColour: -0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.36764401),
        dec: Angle.Degrees(-39.05720012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12969",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12969"},
    },
    visualMagnitude: 11.41,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.69960363),
        dec: Angle.Degrees(-39.05662139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50157"},
        {"Hipparcos Number", "HIP 32790"},
        {"Smithsonian Astrophysical Observation", "SAO 197264"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.54652548),
        dec: Angle.Degrees(-39.05505331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103504",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103504"},
        {"Smithsonian Astrophysical Observation", "SAO 212583"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.55558373),
        dec: Angle.Degrees(-39.05463425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67191"},
        {"Hipparcos Number", "HIP 39580"},
        {"Geneva Identification System", "GEN# +1.00067191"},
        {"Smithsonian Astrophysical Observation", "SAO 198780"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.31323803),
        dec: Angle.Degrees(-39.05354770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137134"},
        {"Hipparcos Number", "HIP 75527"},
        {"Geneva Identification System", "GEN# +1.00137134"},
        {"Smithsonian Astrophysical Observation", "SAO 206630"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.44162974),
        dec: Angle.Degrees(-39.05241312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224228"},
        {"Hipparcos Number", "HIP 118008"},
        {"Cincinnati Publication", "Ci 18 3137"},
        {"Smithsonian Astrophysical Observation", "SAO 214868"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.04382589),
        dec: Angle.Degrees(-39.05188419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 205.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -185.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20350"},
        {"Hipparcos Number", "HIP 15130"},
        {"Geneva Identification System", "GEN# +1.00020350"},
        {"Smithsonian Astrophysical Observation", "SAO 194181"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.77669051),
        dec: Angle.Degrees(-39.05172482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19904"},
        {"Hipparcos Number", "HIP 14773"},
        {"Smithsonian Astrophysical Observation", "SAO 194134"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.67844794),
        dec: Angle.Degrees(-39.05157369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202482"},
        {"Hipparcos Number", "HIP 105086"},
        {"Geneva Identification System", "GEN# +1.00202482"},
        {"Smithsonian Astrophysical Observation", "SAO 212860"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.31997782),
        dec: Angle.Degrees(-39.04961797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80432"},
        {"Hipparcos Number", "HIP 45667"},
        {"Smithsonian Astrophysical Observation", "SAO 200219"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.63313690),
        dec: Angle.Degrees(-39.04387618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108541"},
        {"Hipparcos Number", "HIP 60855"},
        {"Fundamental Katalog 5th Edition", "FK5 1320"},
        {"Geneva Identification System", "GEN# +1.00108541"},
        {"Smithsonian Astrophysical Observation", "SAO 203508"},
        {"Wilson Evans Batten Catalogue", "WEB 10830"},
    },
    visualMagnitude: 5.45,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.09369113),
        dec: Angle.Degrees(-39.04113804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47890",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47890"},
    },
    visualMagnitude: 12.05,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.41741257),
        dec: Angle.Degrees(-39.04016341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -236.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90996"},
        {"Hipparcos Number", "HIP 51380"},
        {"Smithsonian Astrophysical Observation", "SAO 201445"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.41019427),
        dec: Angle.Degrees(-39.03878810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65439"},
        {"Hipparcos Number", "HIP 38859"},
        {"Smithsonian Astrophysical Observation", "SAO 198631"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.28881142),
        dec: Angle.Degrees(-39.03803319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210364"},
        {"Hipparcos Number", "HIP 109487"},
        {"Smithsonian Astrophysical Observation", "SAO 213611"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.70530599),
        dec: Angle.Degrees(-39.03686418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14629"},
        {"Hipparcos Number", "HIP 10925"},
        {"Geneva Identification System", "GEN# +1.00014629"},
        {"Smithsonian Astrophysical Observation", "SAO 193652"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.17819775),
        dec: Angle.Degrees(-39.03366485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 213.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167687"},
        {"Hipparcos Number", "HIP 89690"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.55278959),
        dec: Angle.Degrees(-39.03248043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160578"},
        {"Hipparcos Number", "HIP 86670"},
        {"Celescope Catalog", "CEL 4553"},
        {"Fundamental Katalog 5th Edition", "FK5 660"},
        {"Geneva Identification System", "GEN# +1.00160578"},
        {"Smithsonian Astrophysical Observation", "SAO 209163"},
        {"Wilson Evans Batten Catalogue", "WEB 14612"},
    },
    visualMagnitude: 2.39,
    bvColour: -0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.62199908),
        dec: Angle.Degrees(-39.02992092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104579"},
        {"Hipparcos Number", "HIP 58712"},
        {"Smithsonian Astrophysical Observation", "SAO 203059"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.63549626),
        dec: Angle.Degrees(-39.02908643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130277"},
        {"Hipparcos Number", "HIP 72413"},
        {"Smithsonian Astrophysical Observation", "SAO 205961"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.09985862),
        dec: Angle.Degrees(-39.02893814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56978"},
        {"Hipparcos Number", "HIP 35287"},
        {"Celescope Catalog", "CEL 1748"},
        {"Geneva Identification System", "GEN# +1.00056978"},
        {"Smithsonian Astrophysical Observation", "SAO 197806"},
    },
    visualMagnitude: 7.38,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.35723839),
        dec: Angle.Degrees(-39.02478302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20029"},
        {"Hipparcos Number", "HIP 14857"},
        {"Geneva Identification System", "GEN# +1.00020029"},
        {"Smithsonian Astrophysical Observation", "SAO 194148"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.96881464),
        dec: Angle.Degrees(-39.02314429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54042",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54042"},
        {"Smithsonian Astrophysical Observation", "SAO 202043"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.88013123),
        dec: Angle.Degrees(-39.02294810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168403"},
        {"Hipparcos Number", "HIP 89955"},
        {"Renson", "Renson 47190"},
        {"Smithsonian Astrophysical Observation", "SAO 210022"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.31008630),
        dec: Angle.Degrees(-39.02170116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50807"},
        {"Hipparcos Number", "HIP 33033"},
        {"Smithsonian Astrophysical Observation", "SAO 197313"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.24161166),
        dec: Angle.Degrees(-39.02106293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 112.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178112"},
        {"Hipparcos Number", "HIP 94074"},
        {"Geneva Identification System", "GEN# +1.00178112"},
        {"Smithsonian Astrophysical Observation", "SAO 210982"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.25987516),
        dec: Angle.Degrees(-39.01888185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158468"},
        {"Hipparcos Number", "HIP 85745"},
        {"Smithsonian Astrophysical Observation", "SAO 208903"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.83197367),
        dec: Angle.Degrees(-39.01808932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126432"},
        {"Hipparcos Number", "HIP 70604"},
        {"Smithsonian Astrophysical Observation", "SAO 205555"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.63026844),
        dec: Angle.Degrees(-39.01762841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211087"},
        {"Hipparcos Number", "HIP 109901"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.828,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.89649293),
        dec: Angle.Degrees(-39.01398608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31025"},
        {"Hipparcos Number", "HIP 22512"},
        {"Smithsonian Astrophysical Observation", "SAO 195345"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.66242805),
        dec: Angle.Degrees(-39.01149064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148704"},
        {"Hipparcos Number", "HIP 80925"},
        {"Cincinnati Publication", "Ci 20 997"},
        {"Geneva Identification System", "GEN# +1.00148704"},
        {"Smithsonian Astrophysical Observation", "SAO 207733"},
        {"Wilson Evans Batten Catalogue", "WEB 13687"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.858,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.87645672),
        dec: Angle.Degrees(-39.01146518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -428.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -333.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149551"},
        {"Hipparcos Number", "HIP 81380"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.30365518),
        dec: Angle.Degrees(-39.01051883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104747"},
        {"Hipparcos Number", "HIP 58799"},
        {"Geneva Identification System", "GEN# +1.00104747"},
        {"Smithsonian Astrophysical Observation", "SAO 203084"},
        {"Wilson Evans Batten Catalogue", "WEB 10478"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.90258445),
        dec: Angle.Degrees(-39.00896467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -369.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200403"},
        {"Hipparcos Number", "HIP 104027"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.13509360),
        dec: Angle.Degrees(-39.00797160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52258",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52258"},
        {"Geneva Identification System", "GEN# -0.03806655"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.15576763),
        dec: Angle.Degrees(-39.00785991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99214"},
        {"Hipparcos Number", "HIP 55696"},
        {"Smithsonian Astrophysical Observation", "SAO 202415"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.18034640),
        dec: Angle.Degrees(-39.00679818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10052",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10052"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.34716316),
        dec: Angle.Degrees(-39.00647287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -422.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178628"},
        {"Hipparcos Number", "HIP 94243"},
        {"Geneva Identification System", "GEN# +1.00178628"},
        {"Renson", "Renson 49680"},
        {"Smithsonian Astrophysical Observation", "SAO 211017"},
        {"Wilson Evans Batten Catalogue", "WEB 16414"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.75794348),
        dec: Angle.Degrees(-39.00468219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222163"},
        {"Hipparcos Number", "HIP 116656"},
        {"Geneva Identification System", "GEN# +1.00222163"},
        {"Smithsonian Astrophysical Observation", "SAO 214678"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.60808572),
        dec: Angle.Degrees(-39.00246650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114470"},
        {"Hipparcos Number", "HIP 64334"},
        {"Smithsonian Astrophysical Observation", "SAO 204207"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.80977512),
        dec: Angle.Degrees(-39.00212082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63882"},
        {"Hipparcos Number", "HIP 38192"},
        {"Geneva Identification System", "GEN# +2.24510306"},
        {"Smithsonian Astrophysical Observation", "SAO 198489"},
        {"New General Catalogue", "NGC 2451 306"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.37730540),
        dec: Angle.Degrees(-39.00120427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20388"},
        {"Hipparcos Number", "HIP 15161"},
        {"Geneva Identification System", "GEN# +1.00020388"},
        {"Smithsonian Astrophysical Observation", "SAO 194188"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.84932154),
        dec: Angle.Degrees(-38.99987104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52094"},
        {"Hipparcos Number", "HIP 33526"},
        {"Smithsonian Astrophysical Observation", "SAO 197420"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.51597122),
        dec: Angle.Degrees(-38.99898607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204165"},
        {"Hipparcos Number", "HIP 105977"},
    },
    visualMagnitude: 9.07,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.95082834),
        dec: Angle.Degrees(-38.99850659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201992"},
        {"Hipparcos Number", "HIP 104842"},
        {"Geneva Identification System", "GEN# +1.00201992"},
        {"Smithsonian Astrophysical Observation", "SAO 212817"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.57766953),
        dec: Angle.Degrees(-38.99735254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142945"},
        {"Hipparcos Number", "HIP 78267"},
        {"Geneva Identification System", "GEN# +1.00142945"},
        {"Smithsonian Astrophysical Observation", "SAO 207184"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.71727947),
        dec: Angle.Degrees(-38.99722822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26071"},
        {"Hipparcos Number", "HIP 19126"},
        {"Geneva Identification System", "GEN# +1.00026071"},
        {"Smithsonian Astrophysical Observation", "SAO 194761"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.50526181),
        dec: Angle.Degrees(-38.99666627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169853"},
        {"Hipparcos Number", "HIP 90541"},
        {"Geneva Identification System", "GEN# +1.00169853"},
        {"Renson", "Renson 47560"},
        {"Smithsonian Astrophysical Observation", "SAO 210197"},
    },
    visualMagnitude: 5.63,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.11297477),
        dec: Angle.Degrees(-38.99556950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208139"},
        {"Hipparcos Number", "HIP 108199"},
        {"Geneva Identification System", "GEN# +1.00208139"},
        {"Renson", "Renson 57870"},
        {"Smithsonian Astrophysical Observation", "SAO 213393"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.81332114),
        dec: Angle.Degrees(-38.99506495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111802"},
        {"Hipparcos Number", "HIP 62804"},
        {"Smithsonian Astrophysical Observation", "SAO 203888"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.04809489),
        dec: Angle.Degrees(-38.99468837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182561"},
        {"Hipparcos Number", "HIP 95615"},
        {"Smithsonian Astrophysical Observation", "SAO 211267"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.72166771),
        dec: Angle.Degrees(-38.99347160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21185",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 12.79,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)32, 30.2000),
        dec: Angle.DegreesMinutesSeconds((int)-38, (int)59, 35.100)
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
    primaryId: "HIP 100868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194476"},
        {"Hipparcos Number", "HIP 100868"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.78309474),
        dec: Angle.Degrees(-38.99301915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75272"},
        {"Hipparcos Number", "HIP 43176"},
        {"Celescope Catalog", "CEL 2921"},
        {"Geneva Identification System", "GEN# +1.00075272"},
        {"Smithsonian Astrophysical Observation", "SAO 199626"},
    },
    visualMagnitude: 6.99,
    bvColour: -0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.91817331),
        dec: Angle.Degrees(-38.99197965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113461"},
        {"Hipparcos Number", "HIP 63780"},
        {"Smithsonian Astrophysical Observation", "SAO 204093"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.08957083),
        dec: Angle.Degrees(-38.98986980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199387"},
        {"Hipparcos Number", "HIP 103500"},
        {"Smithsonian Astrophysical Observation", "SAO 212582"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.53949279),
        dec: Angle.Degrees(-38.98985723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41245"},
        {"Hipparcos Number", "HIP 28593"},
        {"Geneva Identification System", "GEN# +1.00041245"},
        {"Smithsonian Astrophysical Observation", "SAO 196432"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.52633241),
        dec: Angle.Degrees(-38.98947908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28756"},
        {"Hipparcos Number", "HIP 21002"},
        {"Smithsonian Astrophysical Observation", "SAO 195081"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.55749319),
        dec: Angle.Degrees(-38.98903126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161807"},
        {"Hipparcos Number", "HIP 87232"},
        {"Geneva Identification System", "GEN# +1.00161807"},
        {"Smithsonian Astrophysical Observation", "SAO 209304"},
        {"Wilson Evans Batten Catalogue", "WEB 14718"},
    },
    visualMagnitude: 7.01,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.35312757),
        dec: Angle.Degrees(-38.98378309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24330"},
        {"Hipparcos Number", "HIP 17993"},
        {"Smithsonian Astrophysical Observation", "SAO 194573"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.68469830),
        dec: Angle.Degrees(-38.98196579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223479"},
        {"Hipparcos Number", "HIP 117513"},
        {"Smithsonian Astrophysical Observation", "SAO 214799"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.46754513),
        dec: Angle.Degrees(-38.98131716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -223.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34966",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34966"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.52076659),
        dec: Angle.Degrees(-38.97940937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 241.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14498"},
        {"Hipparcos Number", "HIP 10836"},
        {"Smithsonian Astrophysical Observation", "SAO 193640"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.85735315),
        dec: Angle.Degrees(-38.97741223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165350"},
        {"Hipparcos Number", "HIP 88776"},
        {"Smithsonian Astrophysical Observation", "SAO 209726"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.84279733),
        dec: Angle.Degrees(-38.97579537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50833"},
        {"Hipparcos Number", "HIP 33045"},
        {"Smithsonian Astrophysical Observation", "SAO 197314"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.26553525),
        dec: Angle.Degrees(-38.97297327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41936"},
        {"Hipparcos Number", "HIP 28906"},
        {"Smithsonian Astrophysical Observation", "SAO 196495"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.53161234),
        dec: Angle.Degrees(-38.97201511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27017"},
        {"Hipparcos Number", "HIP 19794"},
        {"Fundamental Katalog 5th Edition", "FK5 4388"},
        {"Smithsonian Astrophysical Observation", "SAO 194863"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.63536257),
        dec: Angle.Degrees(-38.97054640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75475"},
        {"Hipparcos Number", "HIP 43272"},
        {"Smithsonian Astrophysical Observation", "SAO 199659"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.22730543),
        dec: Angle.Degrees(-38.97014027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35650"},
        {"Hipparcos Number", "HIP 25283"},
        {"Geneva Identification System", "GEN# +1.00035650"},
        {"Smithsonian Astrophysical Observation", "SAO 195825"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.12557166),
        dec: Angle.Degrees(-38.96951280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113357"},
        {"Hipparcos Number", "HIP 63730"},
        {"Geneva Identification System", "GEN# +1.00113357"},
        {"Smithsonian Astrophysical Observation", "SAO 204080"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.90293663),
        dec: Angle.Degrees(-38.96840616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68678"},
        {"Hipparcos Number", "HIP 40143"},
        {"Celescope Catalog", "CEL 2223"},
        {"Geneva Identification System", "GEN# +1.00068678"},
        {"Smithsonian Astrophysical Observation", "SAO 198920"},
    },
    visualMagnitude: 8.45,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.96640356),
        dec: Angle.Degrees(-38.96798437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48726"},
        {"Hipparcos Number", "HIP 32166"},
        {"Smithsonian Astrophysical Observation", "SAO 197130"},
    },
    visualMagnitude: 8.93,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.74758934),
        dec: Angle.Degrees(-38.96423427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24966"},
        {"Hipparcos Number", "HIP 18437"},
        {"Geneva Identification System", "GEN# +1.00024966"},
        {"Smithsonian Astrophysical Observation", "SAO 194639"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.12230716),
        dec: Angle.Degrees(-38.96216886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78509",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78509"},
        {"Smithsonian Astrophysical Observation", "SAO 140902"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.41571945),
        dec: Angle.Degrees(-05.69487414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20611"},
        {"Hipparcos Number", "HIP 15324"},
        {"Smithsonian Astrophysical Observation", "SAO 194216"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.41837606),
        dec: Angle.Degrees(-38.96193021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8075"},
        {"Hipparcos Number", "HIP 6201"},
        {"Smithsonian Astrophysical Observation", "SAO 193051"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.88031319),
        dec: Angle.Degrees(-38.96130126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140129"},
        {"Hipparcos Number", "HIP 77015"},
        {"Smithsonian Astrophysical Observation", "SAO 206903"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.87449072),
        dec: Angle.Degrees(-38.96063627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15519"},
        {"Hipparcos Number", "HIP 11534"},
        {"Smithsonian Astrophysical Observation", "SAO 193731"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.17986200),
        dec: Angle.Degrees(-38.96037379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100954"},
        {"Hipparcos Number", "HIP 56649"},
        {"Geneva Identification System", "GEN# +1.00100954"},
        {"Smithsonian Astrophysical Observation", "SAO 202633"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.24180116),
        dec: Angle.Degrees(-38.95953403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143978"},
        {"Hipparcos Number", "HIP 78774"},
        {"Smithsonian Astrophysical Observation", "SAO 207303"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.23789043),
        dec: Angle.Degrees(-38.95424680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224444"},
        {"Hipparcos Number", "HIP 118151"},
        {"Geneva Identification System", "GEN# +1.00224444"},
        {"Smithsonian Astrophysical Observation", "SAO 214883"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.49700215),
        dec: Angle.Degrees(-38.95393420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221843"},
        {"Hipparcos Number", "HIP 116452"},
        {"Smithsonian Astrophysical Observation", "SAO 214642"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.95175259),
        dec: Angle.Degrees(-38.95378121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148901"},
        {"Hipparcos Number", "HIP 81034"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.25272993),
        dec: Angle.Degrees(-38.95354244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85310"},
        {"Hipparcos Number", "HIP 48233"},
        {"Smithsonian Astrophysical Observation", "SAO 200786"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.50629871),
        dec: Angle.Degrees(-38.95279387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139143"},
        {"Hipparcos Number", "HIP 76546"},
        {"Smithsonian Astrophysical Observation", "SAO 206819"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.50035726),
        dec: Angle.Degrees(-38.95249780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129238"},
        {"Hipparcos Number", "HIP 71913"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.63767714),
        dec: Angle.Degrees(-38.95243135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216270"},
        {"Hipparcos Number", "HIP 112922"},
        {"Smithsonian Astrophysical Observation", "SAO 214146"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.03782265),
        dec: Angle.Degrees(-38.95210524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181844"},
        {"Hipparcos Number", "HIP 95332"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.92642502),
        dec: Angle.Degrees(-38.95183322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176294"},
        {"Hipparcos Number", "HIP 93394"},
        {"Smithsonian Astrophysical Observation", "SAO 210818"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.32258972),
        dec: Angle.Degrees(-38.95060722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103832",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103832"},
    },
    visualMagnitude: 10.40,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.60742444),
        dec: Angle.Degrees(-38.94995969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -348.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155705"},
        {"Hipparcos Number", "HIP 84377"},
        {"Geneva Identification System", "GEN# +1.00155705"},
        {"Smithsonian Astrophysical Observation", "SAO 208577"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.74811250),
        dec: Angle.Degrees(-38.94679781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3762"},
        {"Hipparcos Number", "HIP 3149"},
        {"Smithsonian Astrophysical Observation", "SAO 192664"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.00849696),
        dec: Angle.Degrees(-38.94618292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88155"},
        {"Hipparcos Number", "HIP 49721"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.27552584),
        dec: Angle.Degrees(-38.94495359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25388"},
        {"Hipparcos Number", "HIP 18702"},
        {"Geneva Identification System", "GEN# +1.00025388"},
        {"Smithsonian Astrophysical Observation", "SAO 194686"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.803,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.09913572),
        dec: Angle.Degrees(-38.94483229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4518"},
        {"Hipparcos Number", "HIP 3664"},
        {"Smithsonian Astrophysical Observation", "SAO 192735"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.71805810),
        dec: Angle.Degrees(-38.94353723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150689"},
        {"Hipparcos Number", "HIP 81935"},
        {"Geneva Identification System", "GEN# +1.00150689"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.06262988),
        dec: Angle.Degrees(-38.94348871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75271"},
        {"Hipparcos Number", "HIP 43179"},
        {"Smithsonian Astrophysical Observation", "SAO 199628"},
    },
    visualMagnitude: 6.96,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.93302008),
        dec: Angle.Degrees(-38.94149685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31688"},
        {"Hipparcos Number", "HIP 22939"},
        {"Smithsonian Astrophysical Observation", "SAO 195413"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.03925728),
        dec: Angle.Degrees(-38.94049367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82627"},
        {"Hipparcos Number", "HIP 46779"},
        {"Renson", "Renson 23520"},
        {"Smithsonian Astrophysical Observation", "SAO 200474"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.00311116),
        dec: Angle.Degrees(-38.93773776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58015"},
        {"Hipparcos Number", "HIP 35698"},
        {"Geneva Identification System", "GEN# +1.00058015"},
        {"Smithsonian Astrophysical Observation", "SAO 197899"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.48647878),
        dec: Angle.Degrees(-38.93682490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193073"},
        {"Hipparcos Number", "HIP 100236"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.94464726),
        dec: Angle.Degrees(-38.93570889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45481"},
        {"Hipparcos Number", "HIP 30599"},
        {"Smithsonian Astrophysical Observation", "SAO 196812"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.45816689),
        dec: Angle.Degrees(-38.93559358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209854"},
        {"Hipparcos Number", "HIP 109195"},
        {"Smithsonian Astrophysical Observation", "SAO 213558"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.80390832),
        dec: Angle.Degrees(-38.93371158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5547"},
        {"Hipparcos Number", "HIP 4432"},
        {"Smithsonian Astrophysical Observation", "SAO 192830"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.18385769),
        dec: Angle.Degrees(-38.93253390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100100",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100100"},
        {"Smithsonian Astrophysical Observation", "SAO 211981"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.61134099),
        dec: Angle.Degrees(-38.93048178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106231"},
        {"Hipparcos Number", "HIP 59607"},
        {"Geneva Identification System", "GEN# +1.00106231"},
        {"Smithsonian Astrophysical Observation", "SAO 203250"},
        {"Wilson Evans Batten Catalogue", "WEB 10593"},
    },
    visualMagnitude: 5.77,
    bvColour: -0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.35441052),
        dec: Angle.Degrees(-38.92915939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86086"},
        {"Hipparcos Number", "HIP 48653"},
        {"Smithsonian Astrophysical Observation", "SAO 200870"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.82956219),
        dec: Angle.Degrees(-38.92652502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65550"},
        {"Hipparcos Number", "HIP 38894"},
        {"Geneva Identification System", "GEN# +1.00065550"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.39729105),
        dec: Angle.Degrees(-38.92484704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49592"},
        {"Hipparcos Number", "HIP 32536"},
        {"Smithsonian Astrophysical Observation", "SAO 197216"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.83831954),
        dec: Angle.Degrees(-38.92130198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87100"},
        {"Hipparcos Number", "HIP 49147"},
        {"Geneva Identification System", "GEN# +1.00087100"},
        {"Smithsonian Astrophysical Observation", "SAO 200980"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.46351405),
        dec: Angle.Degrees(-38.92064382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32425"},
        {"Hipparcos Number", "HIP 23366"},
        {"Smithsonian Astrophysical Observation", "SAO 195499"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.36197549),
        dec: Angle.Degrees(-38.92051486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101941"},
        {"Hipparcos Number", "HIP 57201"},
        {"Geneva Identification System", "GEN# +1.00101941"},
        {"Smithsonian Astrophysical Observation", "SAO 202749"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.94697757),
        dec: Angle.Degrees(-38.91956740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62559"},
        {"Hipparcos Number", "HIP 37594"},
        {"Geneva Identification System", "GEN# +2.24510221"},
        {"New General Catalogue", "NGC 2451 221"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.71024163),
        dec: Angle.Degrees(-38.91804228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77431"},
        {"Hipparcos Number", "HIP 44285"},
        {"Smithsonian Astrophysical Observation", "SAO 199888"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.28949661),
        dec: Angle.Degrees(-38.91769906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112563"},
        {"Hipparcos Number", "HIP 63276"},
        {"Smithsonian Astrophysical Observation", "SAO 203979"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.50415065),
        dec: Angle.Degrees(-38.91721080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8604"},
        {"Hipparcos Number", "HIP 6563"},
        {"Geneva Identification System", "GEN# +1.00008604"},
        {"Smithsonian Astrophysical Observation", "SAO 193097"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.08407958),
        dec: Angle.Degrees(-38.91712235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6055"},
        {"Hipparcos Number", "HIP 4770"},
        {"Fundamental Katalog 5th Edition", "FK5 2064"},
        {"Geneva Identification System", "GEN# +1.00006055"},
        {"Smithsonian Astrophysical Observation", "SAO 192870"},
        {"Wilson Evans Batten Catalogue", "WEB 906"},
    },
    visualMagnitude: 5.59,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.32593934),
        dec: Angle.Degrees(-38.91664868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16438"},
        {"Hipparcos Number", "HIP 12197"},
        {"Smithsonian Astrophysical Observation", "SAO 193814"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.27268536),
        dec: Angle.Degrees(-38.91651009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91520"},
        {"Hipparcos Number", "HIP 51673"},
        {"Renson", "Renson 26330"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.34891076),
        dec: Angle.Degrees(-38.91458900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175437"},
        {"Hipparcos Number", "HIP 93027"},
        {"Smithsonian Astrophysical Observation", "SAO 210747"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.26785461),
        dec: Angle.Degrees(-38.91440654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39805"},
        {"Hipparcos Number", "HIP 27813"},
        {"Smithsonian Astrophysical Observation", "SAO 196280"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.28242366),
        dec: Angle.Degrees(-38.91429463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107914"},
        {"Hipparcos Number", "HIP 60503"},
        {"Smithsonian Astrophysical Observation", "SAO 203431"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.05390559),
        dec: Angle.Degrees(-38.91381568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56977"},
        {"Hipparcos Number", "HIP 35288"},
        {"Smithsonian Astrophysical Observation", "SAO 197807"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.36089873),
        dec: Angle.Degrees(-38.91344148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107860"},
        {"Hipparcos Number", "HIP 60463"},
        {"Geneva Identification System", "GEN# +1.00107860"},
        {"Smithsonian Astrophysical Observation", "SAO 203424"},
        {"Wilson Evans Batten Catalogue", "WEB 10753"},
    },
    visualMagnitude: 5.79,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.93660912),
        dec: Angle.Degrees(-38.91135056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88398"},
        {"Hipparcos Number", "HIP 49849"},
        {"Geneva Identification System", "GEN# +1.00088398"},
        {"Smithsonian Astrophysical Observation", "SAO 201129"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.67383046),
        dec: Angle.Degrees(-38.91091560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178558"},
        {"Hipparcos Number", "HIP 94214"},
        {"Geneva Identification System", "GEN# +1.00178558"},
        {"Smithsonian Astrophysical Observation", "SAO 211014"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.69940600),
        dec: Angle.Degrees(-38.90939528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163322"},
        {"Hipparcos Number", "HIP 87904"},
        {"Smithsonian Astrophysical Observation", "SAO 209512"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.34361164),
        dec: Angle.Degrees(-38.90872903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146904"},
        {"Hipparcos Number", "HIP 80033"},
        {"Smithsonian Astrophysical Observation", "SAO 207571"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.05597904),
        dec: Angle.Degrees(-38.90788894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36154"},
        {"Hipparcos Number", "HIP 25576"},
        {"Smithsonian Astrophysical Observation", "SAO 195883"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.99603784),
        dec: Angle.Degrees(-38.90674814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198581"},
        {"Hipparcos Number", "HIP 103043"},
        {"Geneva Identification System", "GEN# +1.00198581"},
        {"Smithsonian Astrophysical Observation", "SAO 212504"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.15645065),
        dec: Angle.Degrees(-38.90649326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117939"},
        {"Hipparcos Number", "HIP 66238"},
        {"Cincinnati Publication", "Ci 20 787"},
        {"Geneva Identification System", "GEN# +1.00117939"},
        {"Smithsonian Astrophysical Observation", "SAO 204606"},
        {"Wilson Evans Batten Catalogue", "WEB 11703"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.63464665),
        dec: Angle.Degrees(-38.90625631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 446.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -392.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186043"},
        {"Hipparcos Number", "HIP 97080"},
        {"Smithsonian Astrophysical Observation", "SAO 211507"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.93081281),
        dec: Angle.Degrees(-38.90588363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200836"},
        {"Hipparcos Number", "HIP 104246"},
        {"Smithsonian Astrophysical Observation", "SAO 212722"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.80886756),
        dec: Angle.Degrees(-38.90408844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189443"},
        {"Hipparcos Number", "HIP 98590"},
        {"Smithsonian Astrophysical Observation", "SAO 211737"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.38813444),
        dec: Angle.Degrees(-38.90390948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67411"},
        {"Hipparcos Number", "HIP 39662"},
        {"Smithsonian Astrophysical Observation", "SAO 198806"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.57993560),
        dec: Angle.Degrees(-38.89683785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118467"},
        {"Hipparcos Number", "HIP 66495"},
        {"Geneva Identification System", "GEN# +1.00118467"},
        {"Smithsonian Astrophysical Observation", "SAO 204675"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.46844300),
        dec: Angle.Degrees(-38.89665742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44163"},
        {"Hipparcos Number", "HIP 29972"},
        {"Smithsonian Astrophysical Observation", "SAO 196675"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.64880571),
        dec: Angle.Degrees(-38.89469852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185031"},
        {"Hipparcos Number", "HIP 96639"},
        {"Smithsonian Astrophysical Observation", "SAO 211434"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.72021449),
        dec: Angle.Degrees(-38.89411979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70847"},
        {"Hipparcos Number", "HIP 41063"},
        {"Geneva Identification System", "GEN# +1.00070847"},
        {"Renson", "Renson 19570"},
        {"Smithsonian Astrophysical Observation", "SAO 199152"},
    },
    visualMagnitude: 8.98,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.68889571),
        dec: Angle.Degrees(-38.89408010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208993"},
        {"Hipparcos Number", "HIP 108685"},
        {"Smithsonian Astrophysical Observation", "SAO 213473"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.25559798),
        dec: Angle.Degrees(-38.89315778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218021"},
        {"Hipparcos Number", "HIP 113997"},
        {"Smithsonian Astrophysical Observation", "SAO 214296"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.29929920),
        dec: Angle.Degrees(-38.89239942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218242"},
        {"Hipparcos Number", "HIP 114132"},
        {"Geneva Identification System", "GEN# +1.00218242"},
        {"Smithsonian Astrophysical Observation", "SAO 214313"},
        {"Wilson Evans Batten Catalogue", "WEB 20267"},
    },
    visualMagnitude: 5.62,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.72333274),
        dec: Angle.Degrees(-38.89230672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206010"},
        {"Hipparcos Number", "HIP 106996"},
        {"Smithsonian Astrophysical Observation", "SAO 213187"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.04415797),
        dec: Angle.Degrees(-38.89139839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189950"},
        {"Hipparcos Number", "HIP 98824"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.03581836),
        dec: Angle.Degrees(-38.88594235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125068"},
        {"Hipparcos Number", "HIP 69889"},
        {"Smithsonian Astrophysical Observation", "SAO 205404"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.54139749),
        dec: Angle.Degrees(-38.88447263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27241"},
        {"Hipparcos Number", "HIP 19923"},
        {"Smithsonian Astrophysical Observation", "SAO 194886"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.12145545),
        dec: Angle.Degrees(-38.88413495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11470"},
        {"Hipparcos Number", "HIP 8697"},
        {"Smithsonian Astrophysical Observation", "SAO 193343"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.97518409),
        dec: Angle.Degrees(-38.88360256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74576"},
        {"Hipparcos Number", "HIP 42808"},
        {"Cincinnati Publication", "Ci 20 488"},
        {"Geneva Identification System", "GEN# +1.00074576"},
        {"Smithsonian Astrophysical Observation", "SAO 199544"},
        {"Wilson Evans Batten Catalogue", "WEB 8268"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.82606643),
        dec: Angle.Degrees(-38.88320766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -301.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 340.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117382"},
        {"Hipparcos Number", "HIP 65910"},
        {"Smithsonian Astrophysical Observation", "SAO 204540"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.65971392),
        dec: Angle.Degrees(-38.88217332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58087"},
        {"Hipparcos Number", "HIP 35734"},
        {"Smithsonian Astrophysical Observation", "SAO 197910"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.57110981),
        dec: Angle.Degrees(-38.88070761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213"},
        {"Hipparcos Number", "HIP 567"},
        {"Smithsonian Astrophysical Observation", "SAO 192359"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.72206966),
        dec: Angle.Degrees(-38.87768936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113588",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113588"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.09446503),
        dec: Angle.Degrees(-38.87712924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209449"},
        {"Hipparcos Number", "HIP 108950"},
        {"Geneva Identification System", "GEN# +1.00209449"},
        {"Smithsonian Astrophysical Observation", "SAO 213514"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.09394119),
        dec: Angle.Degrees(-38.87620442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52589",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52589"},
    },
    visualMagnitude: 12.19,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.30376731),
        dec: Angle.Degrees(-38.87531919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186032"},
        {"Hipparcos Number", "HIP 97066"},
        {"Smithsonian Astrophysical Observation", "SAO 211504"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.90367373),
        dec: Angle.Degrees(-38.87504300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39161",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39161"},
        {"Smithsonian Astrophysical Observation", "SAO 198694"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.14075877),
        dec: Angle.Degrees(-38.87308288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16962"},
        {"Hipparcos Number", "HIP 12590"},
        {"Geneva Identification System", "GEN# +1.00016962"},
        {"Smithsonian Astrophysical Observation", "SAO 193868"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.48287978),
        dec: Angle.Degrees(-38.87249426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99383"},
        {"Hipparcos Number", "HIP 55790"},
        {"Geneva Identification System", "GEN# +1.00099383"},
        {"Smithsonian Astrophysical Observation", "SAO 202434"},
        {"Wilson Evans Batten Catalogue", "WEB 10027"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.45803729),
        dec: Angle.Degrees(-38.87179275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 173.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117806"},
        {"Hipparcos Number", "HIP 66129"},
        {"Geneva Identification System", "GEN# +1.00117806"},
        {"Smithsonian Astrophysical Observation", "SAO 204583"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.35106412),
        dec: Angle.Degrees(-38.87172225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44041",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44041"},
    },
    visualMagnitude: 10.94,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.52821029),
        dec: Angle.Degrees(-38.87106969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 128.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44039",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44039"},
    },
    visualMagnitude: 11.17,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)58, 05.3400),
        dec: Angle.DegreesMinutesSeconds((int)-38, (int)52, 13.600)
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
    primaryId: "HIP 53232",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53232"},
        {"Smithsonian Astrophysical Observation", "SAO 201862"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.34128466),
        dec: Angle.Degrees(-38.87031593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127193"},
        {"Hipparcos Number", "HIP 70987"},
        {"Fundamental Katalog 5th Edition", "FK5 3148"},
        {"Geneva Identification System", "GEN# +1.00127193"},
        {"Smithsonian Astrophysical Observation", "SAO 205637"},
    },
    visualMagnitude: 5.99,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.79515011),
        dec: Angle.Degrees(-38.86977705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204143"},
        {"Hipparcos Number", "HIP 105975"},
        {"Smithsonian Astrophysical Observation", "SAO 213020"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.94593438),
        dec: Angle.Degrees(-38.86845616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88889"},
        {"Hipparcos Number", "HIP 50151"},
        {"Smithsonian Astrophysical Observation", "SAO 201198"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.57318400),
        dec: Angle.Degrees(-38.86835741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27999"},
        {"Hipparcos Number", "HIP 20496"},
        {"Geneva Identification System", "GEN# +1.00027999"},
        {"Smithsonian Astrophysical Observation", "SAO 194977"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.89582903),
        dec: Angle.Degrees(-38.86525843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31097",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31097"},
    },
    visualMagnitude: 12.72,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.88140530),
        dec: Angle.Degrees(-38.86513975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105090",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Lacaille 8760"},
        {"Henry Draper", "HD 202560"},
        {"Hipparcos Number", "HIP 105090"},
        {"Cincinnati Publication", "Ci 20 1273"},
        {"Geneva Identification System", "GEN# +1.00202560"},
        {"Smithsonian Astrophysical Observation", "SAO 212866"},
        {"Wilson Evans Batten Catalogue", "WEB 19092"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.32379676),
        dec: Angle.Degrees(-38.86457451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3259.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1146.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80555"},
        {"Hipparcos Number", "HIP 45725"},
        {"Smithsonian Astrophysical Observation", "SAO 200234"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.82601330),
        dec: Angle.Degrees(-38.86457411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61832"},
        {"Hipparcos Number", "HIP 37303"},
        {"Geneva Identification System", "GEN# +2.24510178"},
        {"Smithsonian Astrophysical Observation", "SAO 198258"},
        {"New General Catalogue", "NGC 2451 178"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.87319963),
        dec: Angle.Degrees(-38.86401178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62595"},
        {"Hipparcos Number", "HIP 37616"},
        {"Geneva Identification System", "GEN# +2.24510223"},
        {"Smithsonian Astrophysical Observation", "SAO 198342"},
        {"New General Catalogue", "NGC 2451 223"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.77839461),
        dec: Angle.Degrees(-38.86369015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64503"},
        {"Hipparcos Number", "HIP 38455"},
        {"Celescope Catalog", "CEL 2074"},
        {"Geneva Identification System", "GEN# +1.00064503"},
        {"Smithsonian Astrophysical Observation", "SAO 198545"},
        {"Wilson Evans Batten Catalogue", "WEB 7562"},
    },
    visualMagnitude: 4.49,
    bvColour: -0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.16105542),
        dec: Angle.Degrees(-38.86282206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17514",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17514"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.25335350),
        dec: Angle.Degrees(-38.85919328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 198.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126040"},
        {"Hipparcos Number", "HIP 70396"},
    },
    visualMagnitude: 9.60,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.03650358),
        dec: Angle.Degrees(-38.85850548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223710"},
        {"Hipparcos Number", "HIP 117685"},
        {"Smithsonian Astrophysical Observation", "SAO 214831"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.00049846),
        dec: Angle.Degrees(-38.85773340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30081"},
        {"Hipparcos Number", "HIP 21911"},
        {"Fundamental Katalog 5th Edition", "FK5 4422"},
        {"Smithsonian Astrophysical Observation", "SAO 195246"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.67005290),
        dec: Angle.Degrees(-38.85738346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32"},
        {"Hipparcos Number", "HIP 441"},
        {"Geneva Identification System", "GEN# +1.00000032"},
        {"Smithsonian Astrophysical Observation", "SAO 192351"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.33296709),
        dec: Angle.Degrees(-38.85723115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116080"},
        {"Hipparcos Number", "HIP 65218"},
        {"Geneva Identification System", "GEN# +1.00116080"},
        {"Smithsonian Astrophysical Observation", "SAO 204393"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.48795295),
        dec: Angle.Degrees(-38.85437046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189832"},
        {"Hipparcos Number", "HIP 98763"},
        {"Geneva Identification System", "GEN# +1.00189832"},
        {"Renson", "Renson 52630"},
        {"Smithsonian Astrophysical Observation", "SAO 211768"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.89663368),
        dec: Angle.Degrees(-38.85238340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170040"},
        {"Hipparcos Number", "HIP 90604"},
        {"Geneva Identification System", "GEN# +1.00170040"},
        {"Smithsonian Astrophysical Observation", "SAO 210213"},
        {"Wilson Evans Batten Catalogue", "WEB 15516"},
    },
    visualMagnitude: 6.63,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.31995745),
        dec: Angle.Degrees(-38.85126561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174273"},
        {"Hipparcos Number", "HIP 92544"},
        {"Smithsonian Astrophysical Observation", "SAO 210637"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.88038197),
        dec: Angle.Degrees(-38.85049511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13888",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13888"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.70746539),
        dec: Angle.Degrees(-38.84981799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103760"},
        {"Hipparcos Number", "HIP 58254"},
        {"Geneva Identification System", "GEN# +1.00103760"},
        {"Smithsonian Astrophysical Observation", "SAO 202968"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.21302705),
        dec: Angle.Degrees(-38.84927284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72832"},
        {"Hipparcos Number", "HIP 42001"},
        {"Celescope Catalog", "CEL 2645"},
        {"Geneva Identification System", "GEN# +1.00072832"},
        {"Smithsonian Astrophysical Observation", "SAO 199370"},
    },
    visualMagnitude: 5.92,
    bvColour: -0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.41019515),
        dec: Angle.Degrees(-38.84883270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46858"},
        {"Hipparcos Number", "HIP 31302"},
        {"Geneva Identification System", "GEN# +1.00046858"},
        {"Smithsonian Astrophysical Observation", "SAO 196947"},
        {"Wilson Evans Batten Catalogue", "WEB 6260"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.46230573),
        dec: Angle.Degrees(-38.84858396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138875"},
        {"Hipparcos Number", "HIP 76405"},
        {"Smithsonian Astrophysical Observation", "SAO 206794"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.06431956),
        dec: Angle.Degrees(-38.84634127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179810"},
        {"Hipparcos Number", "HIP 94652"},
        {"Smithsonian Astrophysical Observation", "SAO 211095"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.90405390),
        dec: Angle.Degrees(-38.84554861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134777"},
        {"Hipparcos Number", "HIP 74463"},
        {"Geneva Identification System", "GEN# +1.00134777"},
        {"Smithsonian Astrophysical Observation", "SAO 206416"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.25080250),
        dec: Angle.Degrees(-38.84468310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27342"},
        {"Hipparcos Number", "HIP 19989"},
        {"Smithsonian Astrophysical Observation", "SAO 194895"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.31138673),
        dec: Angle.Degrees(-38.84416830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142447"},
        {"Hipparcos Number", "HIP 78057"},
        {"Smithsonian Astrophysical Observation", "SAO 207131"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.05212764),
        dec: Angle.Degrees(-38.84402155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217451"},
        {"Hipparcos Number", "HIP 113666"},
        {"Smithsonian Astrophysical Observation", "SAO 214251"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.31725501),
        dec: Angle.Degrees(-38.84370375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85451"},
        {"Hipparcos Number", "HIP 48301"},
        {"Renson", "Renson 24390"},
        {"Smithsonian Astrophysical Observation", "SAO 200801"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.71089377),
        dec: Angle.Degrees(-38.84204006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7531"},
        {"Hipparcos Number", "HIP 5838"},
        {"Smithsonian Astrophysical Observation", "SAO 193005"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.71468691),
        dec: Angle.Degrees(-38.84172957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77563"},
        {"Hipparcos Number", "HIP 44357"},
        {"Smithsonian Astrophysical Observation", "SAO 199900"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.49406920),
        dec: Angle.Degrees(-38.83750140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177057"},
        {"Hipparcos Number", "HIP 93692"},
        {"Smithsonian Astrophysical Observation", "SAO 210887"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.19176264),
        dec: Angle.Degrees(-38.83739717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135986"},
        {"Hipparcos Number", "HIP 74991"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.86000672),
        dec: Angle.Degrees(-38.83717547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88274"},
        {"Hipparcos Number", "HIP 49792"},
        {"Smithsonian Astrophysical Observation", "SAO 201117"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.45731078),
        dec: Angle.Degrees(-38.83496807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131028"},
        {"Hipparcos Number", "HIP 72759"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.11666992),
        dec: Angle.Degrees(-38.83290216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52359"},
        {"Hipparcos Number", "HIP 33632"},
        {"Celescope Catalog", "CEL 1482"},
        {"Smithsonian Astrophysical Observation", "SAO 197441"},
    },
    visualMagnitude: 8.76,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.79868609),
        dec: Angle.Degrees(-38.83192314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12439",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12439"},
        {"Smithsonian Astrophysical Observation", "SAO 130045"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.02855966),
        dec: Angle.Degrees(-05.67923933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109435"},
        {"Hipparcos Number", "HIP 61405"},
        {"Geneva Identification System", "GEN# +1.00109435"},
        {"Smithsonian Astrophysical Observation", "SAO 203609"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.73188081),
        dec: Angle.Degrees(-38.83159154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1247"},
        {"Hipparcos Number", "HIP 1316"},
        {"Geneva Identification System", "GEN# +1.00001247"},
        {"Smithsonian Astrophysical Observation", "SAO 192438"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.13973520),
        dec: Angle.Degrees(-38.83074716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11299"},
        {"Hipparcos Number", "HIP 8534"},
        {"Smithsonian Astrophysical Observation", "SAO 193328"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.50604751),
        dec: Angle.Degrees(-38.83068215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149423"},
        {"Hipparcos Number", "HIP 81301"},
        {"Smithsonian Astrophysical Observation", "SAO 207810"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.08833197),
        dec: Angle.Degrees(-38.83050650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69971"},
        {"Hipparcos Number", "HIP 40659"},
        {"Geneva Identification System", "GEN# +1.00069971"},
        {"Smithsonian Astrophysical Observation", "SAO 199056"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.50081771),
        dec: Angle.Degrees(-38.82948288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204395"},
        {"Hipparcos Number", "HIP 106083"},
        {"Smithsonian Astrophysical Observation", "SAO 213035"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.33034776),
        dec: Angle.Degrees(-38.82775361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16167"},
        {"Hipparcos Number", "HIP 11990"},
        {"Smithsonian Astrophysical Observation", "SAO 193786"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.65521040),
        dec: Angle.Degrees(-38.82708381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201205"},
        {"Hipparcos Number", "HIP 104428"},
        {"Smithsonian Astrophysical Observation", "SAO 212749"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.31305883),
        dec: Angle.Degrees(-38.82623395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60812"},
        {"Hipparcos Number", "HIP 36857"},
        {"Smithsonian Astrophysical Observation", "SAO 198148"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.66599641),
        dec: Angle.Degrees(-38.82411151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81428"},
        {"Hipparcos Number", "HIP 46129"},
        {"Smithsonian Astrophysical Observation", "SAO 200335"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.10554237),
        dec: Angle.Degrees(-38.82404742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26665",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26665"},
        {"Smithsonian Astrophysical Observation", "SAO 196068"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.00806778),
        dec: Angle.Degrees(-38.82386724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155276"},
        {"Hipparcos Number", "HIP 84151"},
        {"Geneva Identification System", "GEN# +1.00155276"},
        {"Smithsonian Astrophysical Observation", "SAO 208522"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.06896779),
        dec: Angle.Degrees(-38.82241917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111141"},
        {"Hipparcos Number", "HIP 62414"},
        {"Geneva Identification System", "GEN# +1.00111141"},
        {"Smithsonian Astrophysical Observation", "SAO 203810"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.86316643),
        dec: Angle.Degrees(-38.82190955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61310"},
        {"Hipparcos Number", "HIP 37057"},
        {"Geneva Identification System", "GEN# +2.24510141"},
        {"New General Catalogue", "NGC 2451 141"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.23408514),
        dec: Angle.Degrees(-38.82155875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173489"},
        {"Hipparcos Number", "HIP 92186"},
        {"Smithsonian Astrophysical Observation", "SAO 210568"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.82629999),
        dec: Angle.Degrees(-38.82151122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92515"},
        {"Hipparcos Number", "HIP 52235"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.07508255),
        dec: Angle.Degrees(-38.81844356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23576"},
        {"Hipparcos Number", "HIP 17483"},
        {"Geneva Identification System", "GEN# +1.00023576"},
        {"Smithsonian Astrophysical Observation", "SAO 194501"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.18938808),
        dec: Angle.Degrees(-38.81814079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28535"},
        {"Hipparcos Number", "HIP 20863"},
        {"Geneva Identification System", "GEN# +1.00028535"},
        {"Smithsonian Astrophysical Observation", "SAO 195046"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.06298869),
        dec: Angle.Degrees(-38.81802154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62803"},
        {"Hipparcos Number", "HIP 37697"},
        {"Celescope Catalog", "CEL 2005"},
        {"Geneva Identification System", "GEN# +2.24510239"},
        {"Smithsonian Astrophysical Observation", "SAO 198364"},
        {"New General Catalogue", "NGC 2451 239"},
    },
    visualMagnitude: 7.42,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.01047821),
        dec: Angle.Degrees(-38.81799006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78484"},
        {"Hipparcos Number", "HIP 44756"},
        {"Smithsonian Astrophysical Observation", "SAO 199999"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.82439874),
        dec: Angle.Degrees(-38.81763843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6492"},
        {"Hipparcos Number", "HIP 5096"},
        {"Geneva Identification System", "GEN# +1.00006492"},
        {"Renson", "Renson 1660"},
        {"Smithsonian Astrophysical Observation", "SAO 192914"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.33416737),
        dec: Angle.Degrees(-38.81717916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139048"},
        {"Hipparcos Number", "HIP 76489"},
        {"Geneva Identification System", "GEN# +1.00139048"},
        {"Smithsonian Astrophysical Observation", "SAO 206809"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.34073501),
        dec: Angle.Degrees(-38.81493516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84716",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84716"},
        {"Geneva Identification System", "GEN# -0.03811746"},
    },
    visualMagnitude: 11.03,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.75218044),
        dec: Angle.Degrees(-38.81422726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59635"},
        {"Hipparcos Number", "HIP 36363"},
        {"Celescope Catalog", "CEL 1888"},
        {"Fundamental Katalog 5th Edition", "FK5 2580"},
        {"Geneva Identification System", "GEN# +1.00059635"},
        {"Renson", "Renson 16280"},
        {"Smithsonian Astrophysical Observation", "SAO 198045"},
        {"Wilson Evans Batten Catalogue", "WEB 7236"},
    },
    visualMagnitude: 5.41,
    bvColour: -0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.27379583),
        dec: Angle.Degrees(-38.81210490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63186",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63186"},
        {"Smithsonian Astrophysical Observation", "SAO 203959"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.17551013),
        dec: Angle.Degrees(-38.81103434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20232"},
        {"Hipparcos Number", "HIP 15039"},
        {"Smithsonian Astrophysical Observation", "SAO 194172"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.45911058),
        dec: Angle.Degrees(-38.80928244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47146"},
        {"Hipparcos Number", "HIP 31453"},
        {"Smithsonian Astrophysical Observation", "SAO 196979"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.84191256),
        dec: Angle.Degrees(-38.80883471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111071"},
        {"Hipparcos Number", "HIP 62377"},
        {"Smithsonian Astrophysical Observation", "SAO 203801"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.76025741),
        dec: Angle.Degrees(-38.80782074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29824"},
        {"Hipparcos Number", "HIP 21753"},
        {"Smithsonian Astrophysical Observation", "SAO 195216"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.05918717),
        dec: Angle.Degrees(-38.80701054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160874"},
        {"Hipparcos Number", "HIP 86792"},
        {"Geneva Identification System", "GEN# +1.00160874"},
        {"Smithsonian Astrophysical Observation", "SAO 209197"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.02361661),
        dec: Angle.Degrees(-38.80563463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150848"},
        {"Hipparcos Number", "HIP 82021"},
    },
    visualMagnitude: 10.37,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)45, 17.9900),
        dec: Angle.DegreesMinutesSeconds((int)-38, (int)48, 20.200)
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
    primaryId: "HIP 56525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100749"},
        {"Hipparcos Number", "HIP 56525"},
        {"Smithsonian Astrophysical Observation", "SAO 202600"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.84572748),
        dec: Angle.Degrees(-38.80318792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182727"},
        {"Hipparcos Number", "HIP 95686"},
        {"Smithsonian Astrophysical Observation", "SAO 211279"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.93491307),
        dec: Angle.Degrees(-38.80317359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93054",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93054"},
        {"Smithsonian Astrophysical Observation", "SAO 210753"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.32412503),
        dec: Angle.Degrees(-38.80185299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159194"},
        {"Hipparcos Number", "HIP 86047"},
        {"Smithsonian Astrophysical Observation", "SAO 208980"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.77616946),
        dec: Angle.Degrees(-38.79953725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106258"},
        {"Hipparcos Number", "HIP 59626"},
        {"Smithsonian Astrophysical Observation", "SAO 203253"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.40985739),
        dec: Angle.Degrees(-38.79901032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94183"},
        {"Hipparcos Number", "HIP 53101"},
        {"Smithsonian Astrophysical Observation", "SAO 201840"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.94709130),
        dec: Angle.Degrees(-38.79841398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 150.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165794"},
        {"Hipparcos Number", "HIP 88966"},
        {"Geneva Identification System", "GEN# +1.00165794"},
        {"Smithsonian Astrophysical Observation", "SAO 209781"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.39551359),
        dec: Angle.Degrees(-38.79793119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109864"},
        {"Hipparcos Number", "HIP 61664"},
        {"Smithsonian Astrophysical Observation", "SAO 203656"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.60740297),
        dec: Angle.Degrees(-38.79713536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205252"},
        {"Hipparcos Number", "HIP 106575"},
        {"Smithsonian Astrophysical Observation", "SAO 213111"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.76486138),
        dec: Angle.Degrees(-38.79471852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128488"},
        {"Hipparcos Number", "HIP 71581"},
        {"Geneva Identification System", "GEN# +1.00128488"},
        {"Smithsonian Astrophysical Observation", "SAO 205786"},
    },
    visualMagnitude: 6.04,
    bvColour: 1.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.58056742),
        dec: Angle.Degrees(-38.79413357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218225"},
        {"Hipparcos Number", "HIP 114127"},
        {"Smithsonian Astrophysical Observation", "SAO 214312"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.70005051),
        dec: Angle.Degrees(-38.79409253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99063"},
        {"Hipparcos Number", "HIP 55618"},
        {"Smithsonian Astrophysical Observation", "SAO 202398"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.92647423),
        dec: Angle.Degrees(-38.79321915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135666"},
        {"Hipparcos Number", "HIP 74843"},
        {"Smithsonian Astrophysical Observation", "SAO 206491"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.42183471),
        dec: Angle.Degrees(-38.79271829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156301"},
        {"Hipparcos Number", "HIP 84666"},
        {"Smithsonian Astrophysical Observation", "SAO 208658"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.63092263),
        dec: Angle.Degrees(-38.79257520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134255"},
        {"Hipparcos Number", "HIP 74224"},
        {"Geneva Identification System", "GEN# +1.00134255"},
        {"Smithsonian Astrophysical Observation", "SAO 206352"},
    },
    visualMagnitude: 5.98,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.53059680),
        dec: Angle.Degrees(-38.79246057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10371"},
        {"Hipparcos Number", "HIP 7809"},
        {"Smithsonian Astrophysical Observation", "SAO 193245"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.10842833),
        dec: Angle.Degrees(-38.79039843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9328"},
        {"Hipparcos Number", "HIP 7068"},
        {"Smithsonian Astrophysical Observation", "SAO 193158"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.77652223),
        dec: Angle.Degrees(-38.78710210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78741"},
        {"Hipparcos Number", "HIP 44876"},
        {"Smithsonian Astrophysical Observation", "SAO 200023"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.15442376),
        dec: Angle.Degrees(-38.78407146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132015"},
        {"Hipparcos Number", "HIP 73242"},
        {"Smithsonian Astrophysical Observation", "SAO 206141"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.53931436),
        dec: Angle.Degrees(-38.78378014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163304"},
        {"Hipparcos Number", "HIP 87897"},
        {"Smithsonian Astrophysical Observation", "SAO 209510"},
    },
    visualMagnitude: 7.60,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.32208937),
        dec: Angle.Degrees(-38.78265186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203019"},
        {"Hipparcos Number", "HIP 105384"},
        {"Geneva Identification System", "GEN# +1.00203019"},
        {"Smithsonian Astrophysical Observation", "SAO 212925"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.19421125),
        dec: Angle.Degrees(-38.78156145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61642"},
        {"Hipparcos Number", "HIP 37202"},
        {"Geneva Identification System", "GEN# +2.24510163"},
        {"Smithsonian Astrophysical Observation", "SAO 198229"},
        {"New General Catalogue", "NGC 2451 163"},
    },
    visualMagnitude: 6.20,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.63552537),
        dec: Angle.Degrees(-38.78140103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110185"},
        {"Hipparcos Number", "HIP 61859"},
        {"Smithsonian Astrophysical Observation", "SAO 203697"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.17097355),
        dec: Angle.Degrees(-38.78014141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74674"},
        {"Hipparcos Number", "HIP 42857"},
        {"Smithsonian Astrophysical Observation", "SAO 199562"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.00335404),
        dec: Angle.Degrees(-38.77946131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58910"},
        {"Hipparcos Number", "HIP 36057"},
        {"Smithsonian Astrophysical Observation", "SAO 197990"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.46701261),
        dec: Angle.Degrees(-38.77837754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141254"},
        {"Hipparcos Number", "HIP 77520"},
        {"Geneva Identification System", "GEN# +1.00141254"},
        {"Smithsonian Astrophysical Observation", "SAO 207014"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.41519926),
        dec: Angle.Degrees(-38.77741957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215036"},
        {"Hipparcos Number", "HIP 112159"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.75068492),
        dec: Angle.Degrees(-38.77713206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167254"},
        {"Hipparcos Number", "HIP 89531"},
        {"Smithsonian Astrophysical Observation", "SAO 209926"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.02996835),
        dec: Angle.Degrees(-38.77673407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67190"},
        {"Hipparcos Number", "HIP 39583"},
        {"Geneva Identification System", "GEN# +1.00067190"},
        {"Smithsonian Astrophysical Observation", "SAO 198783"},
        {"Wilson Evans Batten Catalogue", "WEB 7736"},
    },
    visualMagnitude: 8.48,
    bvColour: 2.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.33328641),
        dec: Angle.Degrees(-38.77669368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41305",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41305"},
        {"Geneva Identification System", "GEN# -0.03804447"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.41329702),
        dec: Angle.Degrees(-38.77641293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75387",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75387"},
        {"Geneva Identification System", "GEN# -0.00504065"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.07077630),
        dec: Angle.Degrees(-05.60659260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22747"},
        {"Hipparcos Number", "HIP 16940"},
        {"Smithsonian Astrophysical Observation", "SAO 194418"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.50294779),
        dec: Angle.Degrees(-38.77404580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117954"},
        {"Hipparcos Number", "HIP 66240"},
        {"Smithsonian Astrophysical Observation", "SAO 204608"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.64587279),
        dec: Angle.Degrees(-38.77337228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206710"},
        {"Hipparcos Number", "HIP 107389"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.25748683),
        dec: Angle.Degrees(-38.76910906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16540"},
        {"Hipparcos Number", "HIP 12268"},
        {"Smithsonian Astrophysical Observation", "SAO 193827"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.49148249),
        dec: Angle.Degrees(-38.76900729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 657"},
        {"Hipparcos Number", "HIP 875"},
        {"Geneva Identification System", "GEN# +1.00000657"},
        {"Smithsonian Astrophysical Observation", "SAO 192381"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.69076029),
        dec: Angle.Degrees(-38.76885912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202499"},
        {"Hipparcos Number", "HIP 105105"},
        {"Smithsonian Astrophysical Observation", "SAO 212863"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.35575515),
        dec: Angle.Degrees(-38.76508487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211754"},
        {"Hipparcos Number", "HIP 110264"},
        {"Smithsonian Astrophysical Observation", "SAO 213741"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.02369068),
        dec: Angle.Degrees(-38.76505988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86085"},
        {"Hipparcos Number", "HIP 48652"},
        {"Geneva Identification System", "GEN# +1.00086085"},
        {"Smithsonian Astrophysical Observation", "SAO 200869"},
        {"Wilson Evans Batten Catalogue", "WEB 9053"},
    },
    visualMagnitude: 8.93,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.82785955),
        dec: Angle.Degrees(-38.76288085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15571",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15571"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.15634542),
        dec: Angle.Degrees(-38.76200887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152041"},
        {"Hipparcos Number", "HIP 82569"},
        {"Geneva Identification System", "GEN# +1.00152041"},
        {"Smithsonian Astrophysical Observation", "SAO 208128"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.17384484),
        dec: Angle.Degrees(-38.76029754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73654"},
        {"Hipparcos Number", "HIP 42349"},
        {"Celescope Catalog", "CEL 2723"},
        {"Smithsonian Astrophysical Observation", "SAO 199446"},
    },
    visualMagnitude: 8.90,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.51075923),
        dec: Angle.Degrees(-38.75977882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211507"},
        {"Hipparcos Number", "HIP 110115"},
        {"Geneva Identification System", "GEN# +1.00211507"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.58354058),
        dec: Angle.Degrees(-38.75969981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24825"},
        {"Hipparcos Number", "HIP 18337"},
        {"Geneva Identification System", "GEN# +1.00024825"},
        {"Renson", "Renson 6340"},
        {"Smithsonian Astrophysical Observation", "SAO 194625"},
    },
    visualMagnitude: 6.81,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.81477074),
        dec: Angle.Degrees(-38.75923835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165187"},
        {"Hipparcos Number", "HIP 88708"},
        {"Smithsonian Astrophysical Observation", "SAO 209715"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.64461311),
        dec: Angle.Degrees(-38.75714647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209939"},
        {"Hipparcos Number", "HIP 109239"},
        {"Smithsonian Astrophysical Observation", "SAO 213565"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.95453576),
        dec: Angle.Degrees(-38.75500435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129704"},
        {"Hipparcos Number", "HIP 72117"},
        {"Smithsonian Astrophysical Observation", "SAO 205900"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.28409049),
        dec: Angle.Degrees(-38.75467339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94565"},
        {"Hipparcos Number", "HIP 53344"},
        {"Celescope Catalog", "CEL 3760"},
        {"Geneva Identification System", "GEN# +1.00094565A"},
        {"Smithsonian Astrophysical Observation", "SAO 201886"},
    },
    visualMagnitude: 7.02,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.64786170),
        dec: Angle.Degrees(-38.75445419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212129"},
        {"Hipparcos Number", "HIP 110479"},
        {"Geneva Identification System", "GEN# +1.00212129"},
        {"Smithsonian Astrophysical Observation", "SAO 213773"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.68705152),
        dec: Angle.Degrees(-38.75417842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209315"},
        {"Hipparcos Number", "HIP 108883"},
        {"Smithsonian Astrophysical Observation", "SAO 213501"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.84645568),
        dec: Angle.Degrees(-38.75325996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2424",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2424"},
        {"Smithsonian Astrophysical Observation", "SAO 192579"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.72811972),
        dec: Angle.Degrees(-38.75001534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94565B"},
        {"Hipparcos Number", "HIP 53346"},
        {"Smithsonian Astrophysical Observation", "SAO 201887"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.65405303),
        dec: Angle.Degrees(-38.74914065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79019"},
        {"Hipparcos Number", "HIP 45019"},
        {"Smithsonian Astrophysical Observation", "SAO 200054"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.54332598),
        dec: Angle.Degrees(-38.74816890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28850"},
        {"Hipparcos Number", "HIP 21075"},
        {"Smithsonian Astrophysical Observation", "SAO 195092"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.75789166),
        dec: Angle.Degrees(-38.74660198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181110"},
        {"Hipparcos Number", "HIP 95096"},
        {"Fundamental Katalog 5th Edition", "FK5 5702"},
        {"Smithsonian Astrophysical Observation", "SAO 211195"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.19710483),
        dec: Angle.Degrees(-38.74630731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17839"},
        {"Hipparcos Number", "HIP 13256"},
        {"Smithsonian Astrophysical Observation", "SAO 193943"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.64636897),
        dec: Angle.Degrees(-38.74559159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11537"},
        {"Hipparcos Number", "HIP 8739"},
        {"Geneva Identification System", "GEN# +1.00011537"},
        {"Smithsonian Astrophysical Observation", "SAO 193351"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.10908221),
        dec: Angle.Degrees(-38.74525743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119400"},
        {"Hipparcos Number", "HIP 66986"},
        {"Smithsonian Astrophysical Observation", "SAO 204776"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.92377950),
        dec: Angle.Degrees(-38.74375383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76897"},
        {"Hipparcos Number", "HIP 44011"},
        {"Geneva Identification System", "GEN# +1.00076897"},
        {"Renson", "Renson 21690"},
        {"Smithsonian Astrophysical Observation", "SAO 199829"},
    },
    visualMagnitude: 7.50,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.43239026),
        dec: Angle.Degrees(-38.74257722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158565"},
        {"Hipparcos Number", "HIP 85793"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.96089470),
        dec: Angle.Degrees(-38.74094121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102610"},
        {"Hipparcos Number", "HIP 57603"},
        {"Smithsonian Astrophysical Observation", "SAO 202827"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.15123214),
        dec: Angle.Degrees(-38.74080367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134375"},
        {"Hipparcos Number", "HIP 74276"},
        {"Smithsonian Astrophysical Observation", "SAO 206364"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.69831303),
        dec: Angle.Degrees(-38.74026405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17955"},
        {"Hipparcos Number", "HIP 13361"},
        {"Smithsonian Astrophysical Observation", "SAO 193953"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.97224407),
        dec: Angle.Degrees(-38.73766913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146181"},
        {"Hipparcos Number", "HIP 79742"},
        {"Smithsonian Astrophysical Observation", "SAO 207497"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.11826323),
        dec: Angle.Degrees(-38.73669246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137058"},
        {"Hipparcos Number", "HIP 75501"},
        {"Geneva Identification System", "GEN# +1.00137058"},
        {"Smithsonian Astrophysical Observation", "SAO 206616"},
        {"Wilson Evans Batten Catalogue", "WEB 12870"},
    },
    visualMagnitude: 4.60,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.33438516),
        dec: Angle.Degrees(-38.73358810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163941"},
        {"Hipparcos Number", "HIP 88176"},
        {"Geneva Identification System", "GEN# +1.00163941"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.12103152),
        dec: Angle.Degrees(-38.73106188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117792"},
        {"Hipparcos Number", "HIP 66123"},
        {"Smithsonian Astrophysical Observation", "SAO 204580"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.32680033),
        dec: Angle.Degrees(-38.73021653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105593"},
        {"Hipparcos Number", "HIP 59269"},
        {"Smithsonian Astrophysical Observation", "SAO 203178"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.35244054),
        dec: Angle.Degrees(-38.72980765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16360"},
        {"Hipparcos Number", "HIP 12135"},
        {"Geneva Identification System", "GEN# +1.00016360"},
        {"Smithsonian Astrophysical Observation", "SAO 193801"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.07866003),
        dec: Angle.Degrees(-38.72979567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170867"},
        {"Hipparcos Number", "HIP 90968"},
        {"Geneva Identification System", "GEN# +1.00170867"},
        {"Smithsonian Astrophysical Observation", "SAO 210294"},
        {"Smithsonian Astrophysical Observation 2", "SAO 210295"},
        {"Wilson Evans Batten Catalogue", "WEB 15603"},
    },
    visualMagnitude: 5.67,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.34638866),
        dec: Angle.Degrees(-38.72593259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213940"},
        {"Hipparcos Number", "HIP 111513"},
        {"Smithsonian Astrophysical Observation", "SAO 213933"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.89525568),
        dec: Angle.Degrees(-38.72453506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150226"},
        {"Hipparcos Number", "HIP 81699"},
        {"Smithsonian Astrophysical Observation", "SAO 207919"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.33178005),
        dec: Angle.Degrees(-38.72434833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76110"},
        {"Hipparcos Number", "HIP 43603"},
        {"Geneva Identification System", "GEN# +1.00076110"},
        {"Smithsonian Astrophysical Observation", "SAO 199737"},
    },
    visualMagnitude: 5.79,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.20008562),
        dec: Angle.Degrees(-38.72413106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190981"},
        {"Hipparcos Number", "HIP 99264"},
    },
    visualMagnitude: 8.80,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.25445834),
        dec: Angle.Degrees(-38.72350539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3316"},
        {"Hipparcos Number", "HIP 2817"},
        {"Geneva Identification System", "GEN# +1.00003316"},
        {"Smithsonian Astrophysical Observation", "SAO 192625"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.96270254),
        dec: Angle.Degrees(-38.72244549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206933"},
        {"Hipparcos Number", "HIP 107514"},
        {"Smithsonian Astrophysical Observation", "SAO 213274"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.62867464),
        dec: Angle.Degrees(-38.72172860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107972"},
        {"Hipparcos Number", "HIP 60537"},
        {"Smithsonian Astrophysical Observation", "SAO 203438"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.15345365),
        dec: Angle.Degrees(-38.72078456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170868"},
        {"Hipparcos Number", "HIP 90969"},
        {"Geneva Identification System", "GEN# +1.00170868"},
        {"Smithsonian Astrophysical Observation", "SAO 210293"},
        {"Smithsonian Astrophysical Observation 2", "SAO 210296"},
        {"Wilson Evans Batten Catalogue", "WEB 15602"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.34616671),
        dec: Angle.Degrees(-38.72000270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173257"},
        {"Hipparcos Number", "HIP 92092"},
        {"Smithsonian Astrophysical Observation", "SAO 210545"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.53227278),
        dec: Angle.Degrees(-38.71573653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5173"},
        {"Hipparcos Number", "HIP 4165"},
        {"Geneva Identification System", "GEN# +1.00005173"},
        {"Smithsonian Astrophysical Observation", "SAO 192796"},
        {"Wilson Evans Batten Catalogue", "WEB 748"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.30479143),
        dec: Angle.Degrees(-38.71566972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40781"},
        {"Hipparcos Number", "HIP 28333"},
        {"Geneva Identification System", "GEN# +1.00040781"},
        {"Smithsonian Astrophysical Observation", "SAO 196382"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.80582813),
        dec: Angle.Degrees(-38.71079131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 87.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139543"},
        {"Hipparcos Number", "HIP 76732"},
        {"Geneva Identification System", "GEN# +1.00139543"},
        {"Smithsonian Astrophysical Observation", "SAO 206850"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.04274988),
        dec: Angle.Degrees(-38.70915706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76002"},
        {"Hipparcos Number", "HIP 43537"},
        {"Smithsonian Astrophysical Observation", "SAO 199721"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.01058259),
        dec: Angle.Degrees(-38.70864468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212276"},
        {"Hipparcos Number", "HIP 110553"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.93275852),
        dec: Angle.Degrees(-38.70681431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14778"},
        {"Hipparcos Number", "HIP 11017"},
        {"Geneva Identification System", "GEN# +1.00014778"},
        {"Smithsonian Astrophysical Observation", "SAO 193664"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.46749339),
        dec: Angle.Degrees(-38.70595808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31472"},
        {"Hipparcos Number", "HIP 22807"},
        {"Smithsonian Astrophysical Observation", "SAO 195393"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.58847469),
        dec: Angle.Degrees(-38.70573530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22030",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22030"},
        {"Smithsonian Astrophysical Observation", "SAO 195260"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.04322597),
        dec: Angle.Degrees(-38.70517858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222714"},
        {"Hipparcos Number", "HIP 117003"},
        {"Smithsonian Astrophysical Observation", "SAO 214732"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.79237974),
        dec: Angle.Degrees(-38.70429315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90725"},
        {"Hipparcos Number", "HIP 51227"},
        {"Smithsonian Astrophysical Observation", "SAO 201415"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.94817936),
        dec: Angle.Degrees(-38.70367570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111245"},
        {"Hipparcos Number", "HIP 62474"},
        {"Smithsonian Astrophysical Observation", "SAO 203820"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.05075714),
        dec: Angle.Degrees(-38.70230309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1780"},
        {"Hipparcos Number", "HIP 1742"},
        {"Geneva Identification System", "GEN# +1.00001780"},
        {"Smithsonian Astrophysical Observation", "SAO 192484"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.51223118),
        dec: Angle.Degrees(-38.69924966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 206.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15170",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15170"},
        {"Smithsonian Astrophysical Observation", "SAO 194191"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.88089705),
        dec: Angle.Degrees(-38.69784110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83418"},
        {"Hipparcos Number", "HIP 47200"},
        {"Smithsonian Astrophysical Observation", "SAO 200567"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.29199363),
        dec: Angle.Degrees(-38.69460143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200885"},
        {"Hipparcos Number", "HIP 104278"},
        {"Geneva Identification System", "GEN# +1.00200885"},
        {"Smithsonian Astrophysical Observation", "SAO 212725"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.88043714),
        dec: Angle.Degrees(-38.69136397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38611"},
        {"Hipparcos Number", "HIP 27147"},
        {"Smithsonian Astrophysical Observation", "SAO 196140"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.32531514),
        dec: Angle.Degrees(-38.68930137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199350"},
        {"Hipparcos Number", "HIP 103484"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.50028821),
        dec: Angle.Degrees(-38.68848035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26452"},
        {"Hipparcos Number", "HIP 19406"},
        {"Smithsonian Astrophysical Observation", "SAO 194800"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.34820247),
        dec: Angle.Degrees(-38.68646769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224516"},
        {"Hipparcos Number", "HIP 118204"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.64251742),
        dec: Angle.Degrees(-38.68592747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3061"},
        {"Hipparcos Number", "HIP 2650"},
        {"Geneva Identification System", "GEN# +1.00003061"},
        {"Smithsonian Astrophysical Observation", "SAO 192608"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.40211459),
        dec: Angle.Degrees(-38.68574072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201727"},
        {"Hipparcos Number", "HIP 104712"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.16440199),
        dec: Angle.Degrees(-38.68214457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168402"},
        {"Hipparcos Number", "HIP 89951"},
        {"Smithsonian Astrophysical Observation", "SAO 210020"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.29817959),
        dec: Angle.Degrees(-38.68178452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -184.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3246",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3246"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.33520985),
        dec: Angle.Degrees(-38.67894788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189387"},
        {"Hipparcos Number", "HIP 98560"},
        {"Geneva Identification System", "GEN# +1.00189387"},
        {"Smithsonian Astrophysical Observation", "SAO 211735"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.30764908),
        dec: Angle.Degrees(-38.67877858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196985"},
        {"Hipparcos Number", "HIP 102168"},
        {"Smithsonian Astrophysical Observation", "SAO 212357"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.53082923),
        dec: Angle.Degrees(-38.67656198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149533"},
        {"Hipparcos Number", "HIP 81368"},
        {"Smithsonian Astrophysical Observation", "SAO 207834"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.26106041),
        dec: Angle.Degrees(-38.67616825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105115"},
        {"Hipparcos Number", "HIP 59035"},
        {"Smithsonian Astrophysical Observation", "SAO 203126"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.55425985),
        dec: Angle.Degrees(-38.67564037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90392"},
        {"Hipparcos Number", "HIP 51019"},
        {"Smithsonian Astrophysical Observation", "SAO 201376"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.34372472),
        dec: Angle.Degrees(-38.67403226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59158",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59158"},
        {"Geneva Identification System", "GEN# -0.03707677"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.97148498),
        dec: Angle.Degrees(-38.67355648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54036"},
        {"Hipparcos Number", "HIP 34202"},
        {"Smithsonian Astrophysical Observation", "SAO 197560"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.38717758),
        dec: Angle.Degrees(-38.67342606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150486"},
        {"Hipparcos Number", "HIP 81842"},
        {"Geneva Identification System", "GEN# +1.00150486"},
        {"Renson", "Renson 42560"},
        {"Smithsonian Astrophysical Observation", "SAO 207953"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.75266083),
        dec: Angle.Degrees(-38.67234126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59791"},
        {"Hipparcos Number", "HIP 36442"},
        {"Geneva Identification System", "GEN# +1.00059791J"},
        {"Smithsonian Astrophysical Observation", "SAO 198059"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.49289913),
        dec: Angle.Degrees(-38.66704650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51434"},
        {"Hipparcos Number", "HIP 33301"},
        {"Geneva Identification System", "GEN# +1.00051434"},
        {"Smithsonian Astrophysical Observation", "SAO 197368"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.90498860),
        dec: Angle.Degrees(-38.66701745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121452"},
        {"Hipparcos Number", "HIP 68073"},
        {"Smithsonian Astrophysical Observation", "SAO 205007"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.06420280),
        dec: Angle.Degrees(-38.66304550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80072"},
        {"Hipparcos Number", "HIP 45509"},
        {"Smithsonian Astrophysical Observation", "SAO 200175"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.11327820),
        dec: Angle.Degrees(-38.66021705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212964"},
        {"Hipparcos Number", "HIP 110947"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.18686519),
        dec: Angle.Degrees(-38.65839936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11137"},
        {"Hipparcos Number", "HIP 8431"},
        {"Smithsonian Astrophysical Observation", "SAO 193312"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.16982081),
        dec: Angle.Degrees(-38.65732628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128285"},
        {"Hipparcos Number", "HIP 71489"},
        {"Smithsonian Astrophysical Observation", "SAO 205765"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.29212443),
        dec: Angle.Degrees(-38.65710860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168592"},
        {"Hipparcos Number", "HIP 90037"},
        {"Geneva Identification System", "GEN# +1.00168592"},
        {"Smithsonian Astrophysical Observation", "SAO 210048"},
        {"Wilson Evans Batten Catalogue", "WEB 15385"},
    },
    visualMagnitude: 5.09,
    bvColour: 1.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.57751714),
        dec: Angle.Degrees(-38.65682498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171179"},
        {"Hipparcos Number", "HIP 91102"},
        {"Geneva Identification System", "GEN# +1.00171179"},
        {"Smithsonian Astrophysical Observation", "SAO 210330"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.74395991),
        dec: Angle.Degrees(-38.65679991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109321"},
        {"Hipparcos Number", "HIP 61340"},
        {"Smithsonian Astrophysical Observation", "SAO 203591"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.53087158),
        dec: Angle.Degrees(-38.65649948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49775"},
        {"Hipparcos Number", "HIP 32611"},
        {"Smithsonian Astrophysical Observation", "SAO 197232"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.06819054),
        dec: Angle.Degrees(-38.65613246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110709"},
        {"Hipparcos Number", "HIP 62167"},
        {"Fundamental Katalog 5th Edition", "FK5 5126"},
        {"Smithsonian Astrophysical Observation", "SAO 203761"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.10571971),
        dec: Angle.Degrees(-38.65518843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146610"},
        {"Hipparcos Number", "HIP 79908"},
        {"Smithsonian Astrophysical Observation", "SAO 207535"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.66075863),
        dec: Angle.Degrees(-38.65319853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50755"},
        {"Hipparcos Number", "HIP 33025"},
        {"Smithsonian Astrophysical Observation", "SAO 197310"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.21046980),
        dec: Angle.Degrees(-38.65219806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114981"},
        {"Hipparcos Number", "HIP 64622"},
        {"Geneva Identification System", "GEN# +1.00114981"},
        {"Smithsonian Astrophysical Observation", "SAO 204273"},
    },
    visualMagnitude: 7.16,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.66955645),
        dec: Angle.Degrees(-38.65158925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16839"},
        {"Hipparcos Number", "HIP 12504"},
        {"Geneva Identification System", "GEN# +1.00016839"},
        {"Smithsonian Astrophysical Observation", "SAO 193854"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.22072646),
        dec: Angle.Degrees(-38.65122093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18377"},
        {"Hipparcos Number", "HIP 13656"},
        {"Smithsonian Astrophysical Observation", "SAO 193987"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.96119285),
        dec: Angle.Degrees(-38.65076501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219583"},
        {"Hipparcos Number", "HIP 114974"},
        {"Geneva Identification System", "GEN# +1.00219583"},
        {"Smithsonian Astrophysical Observation", "SAO 214432"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.30230203),
        dec: Angle.Degrees(-38.64946053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125747"},
        {"Hipparcos Number", "HIP 70250"},
        {"Smithsonian Astrophysical Observation", "SAO 205486"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.60981156),
        dec: Angle.Degrees(-38.64854739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137538"},
        {"Hipparcos Number", "HIP 75704"},
        {"Smithsonian Astrophysical Observation", "SAO 206667"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.99913819),
        dec: Angle.Degrees(-38.64675355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92443",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92443"},
    },
    visualMagnitude: 11.85,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.58937394),
        dec: Angle.Degrees(-38.64592411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -259.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220982"},
        {"Hipparcos Number", "HIP 115857"},
        {"Geneva Identification System", "GEN# +1.00220982"},
        {"Smithsonian Astrophysical Observation", "SAO 214565"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.10427624),
        dec: Angle.Degrees(-38.64563303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158142"},
        {"Hipparcos Number", "HIP 85583"},
        {"Smithsonian Astrophysical Observation", "SAO 208868"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.33529082),
        dec: Angle.Degrees(-38.64545033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145839"},
        {"Hipparcos Number", "HIP 79610"},
        {"Smithsonian Astrophysical Observation", "SAO 207483"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.67928694),
        dec: Angle.Degrees(-38.64535029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42247"},
        {"Hipparcos Number", "HIP 29065"},
        {"Smithsonian Astrophysical Observation", "SAO 196518"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.97237258),
        dec: Angle.Degrees(-38.64383043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209497"},
        {"Hipparcos Number", "HIP 108983"},
    },
    visualMagnitude: 9.83,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.18244600),
        dec: Angle.Degrees(-38.64300019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162418"},
        {"Hipparcos Number", "HIP 87505"},
        {"Geneva Identification System", "GEN# +1.00162418"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.18233681),
        dec: Angle.Degrees(-38.64262493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207156"},
        {"Hipparcos Number", "HIP 107635"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.02445827),
        dec: Angle.Degrees(-38.64197750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54842"},
        {"Hipparcos Number", "HIP 34470"},
        {"Smithsonian Astrophysical Observation", "SAO 197627"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.16255641),
        dec: Angle.Degrees(-38.64119723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66742"},
        {"Hipparcos Number", "HIP 39408"},
        {"Smithsonian Astrophysical Observation", "SAO 198749"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.84546917),
        dec: Angle.Degrees(-38.63865775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204592"},
        {"Hipparcos Number", "HIP 106203"},
        {"Smithsonian Astrophysical Observation", "SAO 213054"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.67675438),
        dec: Angle.Degrees(-38.63806272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82798"},
        {"Hipparcos Number", "HIP 46888"},
        {"Geneva Identification System", "GEN# +1.00082798"},
        {"Smithsonian Astrophysical Observation", "SAO 200493"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.32083859),
        dec: Angle.Degrees(-38.63769664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -185.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164298"},
        {"Hipparcos Number", "HIP 88319"},
        {"Smithsonian Astrophysical Observation", "SAO 209618"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.56284880),
        dec: Angle.Degrees(-38.63769569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159433"},
        {"Hipparcos Number", "HIP 86170"},
        {"Geneva Identification System", "GEN# +1.00159433"},
        {"Smithsonian Astrophysical Observation", "SAO 209019"},
        {"Wilson Evans Batten Catalogue", "WEB 14532"},
    },
    visualMagnitude: 4.26,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.13686148),
        dec: Angle.Degrees(-38.63486521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -182.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137785"},
        {"Hipparcos Number", "HIP 75818"},
        {"Geneva Identification System", "GEN# +1.00137785"},
        {"Smithsonian Astrophysical Observation", "SAO 206695"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.33040184),
        dec: Angle.Degrees(-38.63482699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72915"},
        {"Hipparcos Number", "HIP 42026"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.50326666),
        dec: Angle.Degrees(-38.63466201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93658"},
        {"Hipparcos Number", "HIP 52832"},
        {"Smithsonian Astrophysical Observation", "SAO 201765"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.04075244),
        dec: Angle.Degrees(-38.63395147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75869"},
        {"Hipparcos Number", "HIP 43466"},
        {"Geneva Identification System", "GEN# +1.00075869"},
        {"Smithsonian Astrophysical Observation", "SAO 199708"},
        {"Wilson Evans Batten Catalogue", "WEB 8377"},
    },
    visualMagnitude: 7.00,
    bvColour: -0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.80799947),
        dec: Angle.Degrees(-38.63309939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200163"},
        {"Hipparcos Number", "HIP 103882"},
        {"Fundamental Katalog 5th Edition", "FK5 790"},
        {"Geneva Identification System", "GEN# +1.00200163"},
        {"Smithsonian Astrophysical Observation", "SAO 212666"},
        {"Wilson Evans Batten Catalogue", "WEB 18915"},
    },
    visualMagnitude: 5.32,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.74156102),
        dec: Angle.Degrees(-38.63118269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126061"},
        {"Hipparcos Number", "HIP 70410"},
        {"Smithsonian Astrophysical Observation", "SAO 205521"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.07096543),
        dec: Angle.Degrees(-38.62927667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47600"},
        {"Hipparcos Number", "HIP 31670"},
        {"Celescope Catalog", "CEL 1331"},
        {"Geneva Identification System", "GEN# +1.00047600"},
        {"Smithsonian Astrophysical Observation", "SAO 197021"},
    },
    visualMagnitude: 7.90,
    bvColour: -0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.41672698),
        dec: Angle.Degrees(-38.62833004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172705"},
        {"Hipparcos Number", "HIP 91827"},
        {"Smithsonian Astrophysical Observation", "SAO 210496"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.83983897),
        dec: Angle.Degrees(-38.62775926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162763"},
        {"Hipparcos Number", "HIP 87665"},
        {"Geneva Identification System", "GEN# +1.00162763"},
        {"Smithsonian Astrophysical Observation", "SAO 209439"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.60157346),
        dec: Angle.Degrees(-38.62623663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46727"},
        {"Hipparcos Number", "HIP 31241"},
        {"Geneva Identification System", "GEN# +1.00046727"},
        {"Smithsonian Astrophysical Observation", "SAO 196930"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.29266641),
        dec: Angle.Degrees(-38.62514452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154287"},
        {"Hipparcos Number", "HIP 83687"},
        {"Smithsonian Astrophysical Observation", "SAO 208399"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.54974256),
        dec: Angle.Degrees(-38.62509888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159215"},
        {"Henry Draper 2", "HD 159215A"},
        {"Hipparcos Number", "HIP 86051"},
        {"Geneva Identification System", "GEN# +1.00159215"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.78583052),
        dec: Angle.Degrees(-38.62390284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -312.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -226.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138204"},
        {"Hipparcos Number", "HIP 76063"},
        {"Geneva Identification System", "GEN# +1.00138204"},
        {"Smithsonian Astrophysical Observation", "SAO 206736"},
        {"Wilson Evans Batten Catalogue", "WEB 12927"},
    },
    visualMagnitude: 6.23,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.01760186),
        dec: Angle.Degrees(-38.62237167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120778"},
        {"Hipparcos Number", "HIP 67712"},
        {"Geneva Identification System", "GEN# +1.00120778"},
        {"Smithsonian Astrophysical Observation", "SAO 204925"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.07318273),
        dec: Angle.Degrees(-38.62123177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205463"},
        {"Hipparcos Number", "HIP 106679"},
        {"Smithsonian Astrophysical Observation", "SAO 213131"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.11581290),
        dec: Angle.Degrees(-38.62113823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154070"},
        {"Hipparcos Number", "HIP 83583"},
        {"Geneva Identification System", "GEN# +1.00154070"},
        {"Smithsonian Astrophysical Observation", "SAO 208378"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.24339539),
        dec: Angle.Degrees(-38.61833328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50653"},
        {"Hipparcos Number", "HIP 32992"},
        {"Smithsonian Astrophysical Observation", "SAO 197304"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.10170706),
        dec: Angle.Degrees(-38.61764707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79523"},
        {"Hipparcos Number", "HIP 45259"},
        {"Geneva Identification System", "GEN# +1.00079523"},
        {"Smithsonian Astrophysical Observation", "SAO 200119"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.35759430),
        dec: Angle.Degrees(-38.61643569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126419"},
        {"Hipparcos Number", "HIP 70593"},
        {"Smithsonian Astrophysical Observation", "SAO 205553"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.59338424),
        dec: Angle.Degrees(-38.61503155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207450"},
        {"Hipparcos Number", "HIP 107779"},
        {"Geneva Identification System", "GEN# +1.00207450"},
        {"Smithsonian Astrophysical Observation", "SAO 213325"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.52036369),
        dec: Angle.Degrees(-38.61429056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 139.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141134"},
        {"Hipparcos Number", "HIP 77462"},
        {"Smithsonian Astrophysical Observation", "SAO 207003"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.865,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.23452180),
        dec: Angle.Degrees(-38.61250886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38461",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38461"},
        {"New General Catalogue", "NGC 2477 936"},
    },
    visualMagnitude: 10.98,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.17627356),
        dec: Angle.Degrees(-38.61210483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165750"},
        {"Hipparcos Number", "HIP 88941"},
        {"Geneva Identification System", "GEN# +1.00165750"},
        {"Smithsonian Astrophysical Observation", "SAO 209773"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.32161120),
        dec: Angle.Degrees(-38.61113417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31163"},
        {"Hipparcos Number", "HIP 22595"},
        {"Smithsonian Astrophysical Observation", "SAO 195363"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.92809720),
        dec: Angle.Degrees(-38.61056001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51607"},
        {"Hipparcos Number", "HIP 33359"},
        {"Celescope Catalog", "CEL 1446"},
        {"Geneva Identification System", "GEN# +1.00051607"},
        {"Smithsonian Astrophysical Observation", "SAO 197382"},
    },
    visualMagnitude: 7.68,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.07456815),
        dec: Angle.Degrees(-38.60967743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8401",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8401"},
        {"Smithsonian Astrophysical Observation", "SAO 129508"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.10131692),
        dec: Angle.Degrees(-05.35404147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77753"},
        {"Hipparcos Number", "HIP 44433"},
        {"Smithsonian Astrophysical Observation", "SAO 199922"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.78936761),
        dec: Angle.Degrees(-38.60963780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86954"},
        {"Hipparcos Number", "HIP 49073"},
        {"Geneva Identification System", "GEN# +1.00086954"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.23680864),
        dec: Angle.Degrees(-38.60931072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72106"},
        {"Hipparcos Number", "HIP 41650"},
        {"Renson", "Renson 19915"},
        {"Smithsonian Astrophysical Observation", "SAO 199291"},
    },
    visualMagnitude: 8.51,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.39543043),
        dec: Angle.Degrees(-38.60588910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127862"},
        {"Hipparcos Number", "HIP 71296"},
        {"Geneva Identification System", "GEN# +1.00127862"},
        {"Smithsonian Astrophysical Observation", "SAO 205716"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.802,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.71364092),
        dec: Angle.Degrees(-38.60409736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143699"},
        {"Hipparcos Number", "HIP 78655"},
        {"Fundamental Katalog 5th Edition", "FK5 3267"},
        {"Geneva Identification System", "GEN# +1.00143699"},
        {"Renson", "Renson 40720"},
        {"Smithsonian Astrophysical Observation", "SAO 207276"},
        {"Wilson Evans Batten Catalogue", "WEB 13296"},
    },
    visualMagnitude: 4.90,
    bvColour: -0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.85084398),
        dec: Angle.Degrees(-38.60247122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131674"},
        {"Hipparcos Number", "HIP 73084"},
        {"Smithsonian Astrophysical Observation", "SAO 206104"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.05400706),
        dec: Angle.Degrees(-38.59937738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16919"},
        {"Hipparcos Number", "HIP 12561"},
        {"Smithsonian Astrophysical Observation", "SAO 193864"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.38656479),
        dec: Angle.Degrees(-38.59880489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225166"},
        {"Hipparcos Number", "HIP 318"},
        {"Smithsonian Astrophysical Observation", "SAO 192344"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.00967468),
        dec: Angle.Degrees(-38.59474913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11643"},
        {"Hipparcos Number", "HIP 8820"},
        {"Fundamental Katalog 5th Edition", "FK5 2127"},
        {"Geneva Identification System", "GEN# +1.00011643"},
        {"Smithsonian Astrophysical Observation", "SAO 193368"},
        {"Wilson Evans Batten Catalogue", "WEB 1857"},
    },
    visualMagnitude: 6.09,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.34615301),
        dec: Angle.Degrees(-38.59470335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174525"},
        {"Hipparcos Number", "HIP 92644"},
        {"Geneva Identification System", "GEN# +1.00174525"},
        {"Smithsonian Astrophysical Observation", "SAO 210657"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.15723572),
        dec: Angle.Degrees(-38.59407516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155826"},
        {"Hipparcos Number", "HIP 84425"},
        {"Cincinnati Publication", "Ci 20 1024"},
        {"Geneva Identification System", "GEN# +1.00155826J"},
        {"Smithsonian Astrophysical Observation", "SAO 208591"},
        {"Wilson Evans Batten Catalogue", "WEB 14251"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.90032398),
        dec: Angle.Degrees(-38.59295116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -169.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -388.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79270"},
        {"Hipparcos Number", "HIP 45154"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.98742507),
        dec: Angle.Degrees(-38.59161022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189386"},
        {"Hipparcos Number", "HIP 98556"},
        {"Geneva Identification System", "GEN# +1.00189386J"},
        {"Smithsonian Astrophysical Observation", "SAO 211734"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.30299219),
        dec: Angle.Degrees(-38.58673337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15959"},
        {"Hipparcos Number", "HIP 11834"},
        {"Smithsonian Astrophysical Observation", "SAO 193761"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.20302838),
        dec: Angle.Degrees(-38.58385078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197000"},
        {"Hipparcos Number", "HIP 102184"},
        {"Smithsonian Astrophysical Observation", "SAO 212361"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.57018651),
        dec: Angle.Degrees(-38.58374345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23716"},
        {"Hipparcos Number", "HIP 17576"},
        {"Geneva Identification System", "GEN# +1.00023716"},
        {"Smithsonian Astrophysical Observation", "SAO 194515"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.46335170),
        dec: Angle.Degrees(-38.58322381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56409"},
        {"Hipparcos Number", "HIP 35067"},
        {"Smithsonian Astrophysical Observation", "SAO 197754"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.76562094),
        dec: Angle.Degrees(-38.58091900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104833",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104833"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.56790516),
        dec: Angle.Degrees(-38.58082708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90256"},
        {"Hipparcos Number", "HIP 50956"},
        {"Smithsonian Astrophysical Observation", "SAO 201362"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.10436423),
        dec: Angle.Degrees(-38.58049748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125511"},
        {"Hipparcos Number", "HIP 70113"},
        {"Smithsonian Astrophysical Observation", "SAO 205460"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.20584968),
        dec: Angle.Degrees(-38.58029078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201991"},
        {"Hipparcos Number", "HIP 104835"},
        {"Smithsonian Astrophysical Observation", "SAO 212815"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.56810288),
        dec: Angle.Degrees(-38.57793125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70116",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70116"},
    },
    visualMagnitude: 11.62,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.20899130),
        dec: Angle.Degrees(-38.57735702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101506"},
        {"Hipparcos Number", "HIP 56967"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.17114811),
        dec: Angle.Degrees(-38.57578311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169123"},
        {"Hipparcos Number", "HIP 90254"},
        {"Smithsonian Astrophysical Observation", "SAO 210112"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.24074395),
        dec: Angle.Degrees(-38.57509353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163691"},
        {"Hipparcos Number", "HIP 88063"},
        {"Smithsonian Astrophysical Observation", "SAO 209550"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.79399004),
        dec: Angle.Degrees(-38.57342178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6235"},
        {"Hipparcos Number", "HIP 4896"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.71374329),
        dec: Angle.Degrees(-38.57210592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170462"},
        {"Hipparcos Number", "HIP 90792"},
        {"Geneva Identification System", "GEN# +1.00170462"},
        {"Smithsonian Astrophysical Observation", "SAO 210258"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.83483640),
        dec: Angle.Degrees(-38.57126272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116266"},
        {"Hipparcos Number", "HIP 65315"},
        {"Smithsonian Astrophysical Observation", "SAO 204419"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.79575361),
        dec: Angle.Degrees(-38.57095243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45943"},
        {"Hipparcos Number", "HIP 30846"},
        {"Geneva Identification System", "GEN# +1.00045943"},
        {"Smithsonian Astrophysical Observation", "SAO 196867"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.17193810),
        dec: Angle.Degrees(-38.57046887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79917"},
        {"Hipparcos Number", "HIP 45439"},
        {"Fundamental Katalog 5th Edition", "FK5 2737"},
        {"Geneva Identification System", "GEN# +1.00079917"},
        {"Smithsonian Astrophysical Observation", "SAO 200159"},
        {"Wilson Evans Batten Catalogue", "WEB 8645"},
    },
    visualMagnitude: 4.92,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.90317393),
        dec: Angle.Degrees(-38.56991789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133417"},
        {"Hipparcos Number", "HIP 73848"},
        {"Geneva Identification System", "GEN# +1.00133417"},
        {"Smithsonian Astrophysical Observation", "SAO 206281"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.38897422),
        dec: Angle.Degrees(-38.56837275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191186"},
        {"Hipparcos Number", "HIP 99369"},
        {"Smithsonian Astrophysical Observation", "SAO 211871"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.53889193),
        dec: Angle.Degrees(-38.56634133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153102"},
        {"Hipparcos Number", "HIP 83119"},
        {"Geneva Identification System", "GEN# +1.00153102"},
        {"Smithsonian Astrophysical Observation", "SAO 208262"},
        {"Wilson Evans Batten Catalogue", "WEB 14049"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.77948267),
        dec: Angle.Degrees(-38.56601410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165470"},
        {"Hipparcos Number", "HIP 88824"},
        {"Geneva Identification System", "GEN# +1.00165470"},
        {"Smithsonian Astrophysical Observation", "SAO 209745"},
    },
    visualMagnitude: 7.36,
    bvColour: -0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.97656256),
        dec: Angle.Degrees(-38.56540906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47914",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47914"},
        {"Smithsonian Astrophysical Observation", "SAO 200711"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.49066900),
        dec: Angle.Degrees(-38.56173522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30997"},
        {"Hipparcos Number", "HIP 22500"},
        {"Geneva Identification System", "GEN# +1.00030997"},
        {"Smithsonian Astrophysical Observation", "SAO 195342"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.61807894),
        dec: Angle.Degrees(-38.56023659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 118.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21853"},
        {"Hipparcos Number", "HIP 16279"},
        {"Smithsonian Astrophysical Observation", "SAO 194338"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.47036241),
        dec: Angle.Degrees(-38.55966579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127324"},
        {"Hipparcos Number", "HIP 71048"},
        {"Smithsonian Astrophysical Observation", "SAO 205646"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.95012067),
        dec: Angle.Degrees(-38.55815111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36702"},
        {"Hipparcos Number", "HIP 25916"},
        {"Geneva Identification System", "GEN# +1.00036702"},
        {"Smithsonian Astrophysical Observation", "SAO 195934"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.96761349),
        dec: Angle.Degrees(-38.55663842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51312"},
        {"Hipparcos Number", "HIP 33254"},
        {"Smithsonian Astrophysical Observation", "SAO 197363"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.77995811),
        dec: Angle.Degrees(-38.55642988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204706"},
        {"Henry Draper 2", "HD 204706A"},
        {"Hipparcos Number", "HIP 106271"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.86977926),
        dec: Angle.Degrees(-38.55637535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128569"},
        {"Hipparcos Number", "HIP 71609"},
        {"Smithsonian Astrophysical Observation", "SAO 205793"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.68025632),
        dec: Angle.Degrees(-38.55427204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18074"},
        {"Hipparcos Number", "HIP 13439"},
        {"Smithsonian Astrophysical Observation", "SAO 193960"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.25975699),
        dec: Angle.Degrees(-38.55263539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40177"},
        {"Hipparcos Number", "HIP 28006"},
        {"Geneva Identification System", "GEN# +1.00040177"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.86547979),
        dec: Angle.Degrees(-38.55237768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206642"},
        {"Hipparcos Number", "HIP 107344"},
        {"Fundamental Katalog 5th Edition", "FK5 3736"},
        {"Geneva Identification System", "GEN# +1.00206642"},
        {"Smithsonian Astrophysical Observation", "SAO 213248"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.12254615),
        dec: Angle.Degrees(-38.55213592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61926"},
        {"Hipparcos Number", "HIP 37336"},
        {"Celescope Catalog", "CEL 1972"},
        {"Geneva Identification System", "GEN# +2.24510186"},
        {"Smithsonian Astrophysical Observation", "SAO 198272"},
        {"Wilson Evans Batten Catalogue", "WEB 7390"},
        {"New General Catalogue", "NGC 2451 186"},
    },
    visualMagnitude: 7.95,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.96962394),
        dec: Angle.Degrees(-38.54831067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38432",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38432"},
        {"New General Catalogue", "NGC 2477 830"},
    },
    visualMagnitude: 11.68,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.09034466),
        dec: Angle.Degrees(-38.54560159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168591"},
        {"Hipparcos Number", "HIP 90038"},
        {"Smithsonian Astrophysical Observation", "SAO 210049"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.57772809),
        dec: Angle.Degrees(-38.54536788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163212"},
        {"Hipparcos Number", "HIP 87856"},
        {"Smithsonian Astrophysical Observation", "SAO 209499"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.21411501),
        dec: Angle.Degrees(-38.53890290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134055"},
        {"Hipparcos Number", "HIP 74144"},
        {"Geneva Identification System", "GEN# +1.00134055"},
        {"Renson", "Renson 38040"},
        {"Smithsonian Astrophysical Observation", "SAO 206335"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.25978230),
        dec: Angle.Degrees(-38.53419483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130568"},
        {"Hipparcos Number", "HIP 72558"},
        {"Geneva Identification System", "GEN# +1.00130568"},
        {"Smithsonian Astrophysical Observation", "SAO 205989"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.52090990),
        dec: Angle.Degrees(-38.53366112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62226"},
        {"Hipparcos Number", "HIP 37450"},
        {"Celescope Catalog", "CEL 1980"},
        {"Geneva Identification System", "GEN# +2.24510203"},
        {"Smithsonian Astrophysical Observation", "SAO 198298"},
        {"Wilson Evans Batten Catalogue", "WEB 7410"},
        {"New General Catalogue", "NGC 2451 203"},
    },
    visualMagnitude: 5.41,
    bvColour: -0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.31595047),
        dec: Angle.Degrees(-38.53357185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114549"},
        {"Hipparcos Number", "HIP 64379"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.92172985),
        dec: Angle.Degrees(-38.53203228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34105"},
        {"Hipparcos Number", "HIP 24322"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.29491890),
        dec: Angle.Degrees(-38.53168721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200073"},
        {"Hipparcos Number", "HIP 103836"},
        {"Geneva Identification System", "GEN# +1.00200073"},
        {"Smithsonian Astrophysical Observation", "SAO 212653"},
        {"Wilson Evans Batten Catalogue", "WEB 18901"},
    },
    visualMagnitude: 5.93,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.61271790),
        dec: Angle.Degrees(-38.53055847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 154.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -169.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190668"},
        {"Hipparcos Number", "HIP 99129"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.87505772),
        dec: Angle.Degrees(-38.53028093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4975"},
        {"Hipparcos Number", "HIP 3999"},
        {"Geneva Identification System", "GEN# +1.00004975"},
        {"Smithsonian Astrophysical Observation", "SAO 192779"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.84198032),
        dec: Angle.Degrees(-38.52874769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62376"},
        {"Hipparcos Number", "HIP 37514"},
        {"Celescope Catalog", "CEL 1985"},
        {"Geneva Identification System", "GEN# +2.24510209"},
        {"Smithsonian Astrophysical Observation", "SAO 198315"},
        {"New General Catalogue", "NGC 2451 209"},
    },
    visualMagnitude: 6.54,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.49184725),
        dec: Angle.Degrees(-38.52839447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8212"},
        {"Hipparcos Number", "HIP 6304"},
        {"Geneva Identification System", "GEN# +1.00008212"},
        {"Smithsonian Astrophysical Observation", "SAO 193065"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.24889661),
        dec: Angle.Degrees(-38.52659131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39752"},
        {"Hipparcos Number", "HIP 27787"},
        {"Geneva Identification System", "GEN# +1.00039752J"},
        {"Smithsonian Astrophysical Observation", "SAO 196274"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.19880653),
        dec: Angle.Degrees(-38.52596969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195597"},
        {"Hipparcos Number", "HIP 101463"},
        {"Geneva Identification System", "GEN# +1.00195597"},
        {"Smithsonian Astrophysical Observation", "SAO 212228"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.44347752),
        dec: Angle.Degrees(-38.52329386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68166",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68166"},
    },
    visualMagnitude: 11.29,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.33036298),
        dec: Angle.Degrees(-38.52280343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158360"},
        {"Hipparcos Number", "HIP 85684"},
        {"Smithsonian Astrophysical Observation", "SAO 208892"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.64970957),
        dec: Angle.Degrees(-38.51963100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158156"},
        {"Hipparcos Number", "HIP 85589"},
        {"Geneva Identification System", "GEN# +1.00158156J"},
        {"Smithsonian Astrophysical Observation", "SAO 208870"},
        {"Wilson Evans Batten Catalogue", "WEB 14447"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.35665611),
        dec: Angle.Degrees(-38.51694348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113679"},
        {"Hipparcos Number", "HIP 63918"},
        {"Geneva Identification System", "GEN# +1.00113679"},
        {"Smithsonian Astrophysical Observation", "SAO 204120"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.47130578),
        dec: Angle.Degrees(-38.51631273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -388.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55866",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55866"},
    },
    visualMagnitude: 11.47,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.75531967),
        dec: Angle.Degrees(-38.51563131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74397",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74397"},
    },
    visualMagnitude: 12.05,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.08419079),
        dec: Angle.Degrees(-38.51471890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -166.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36848"},
        {"Hipparcos Number", "HIP 25993"},
        {"Geneva Identification System", "GEN# +1.00036848"},
        {"Smithsonian Astrophysical Observation", "SAO 195948"},
        {"Wilson Evans Batten Catalogue", "WEB 5058"},
    },
    visualMagnitude: 5.45,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.21407027),
        dec: Angle.Degrees(-38.51334582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62617",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62617"},
    },
    visualMagnitude: 12.67,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.45837994),
        dec: Angle.Degrees(-38.51325793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153789"},
        {"Hipparcos Number", "HIP 83434"},
        {"Smithsonian Astrophysical Observation", "SAO 208344"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.79091942),
        dec: Angle.Degrees(-38.51206842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117233"},
        {"Hipparcos Number", "HIP 65829"},
        {"Smithsonian Astrophysical Observation", "SAO 204522"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.42166878),
        dec: Angle.Degrees(-38.51136730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197650"},
        {"Hipparcos Number", "HIP 102501"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.60131955),
        dec: Angle.Degrees(-38.51122830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63465"},
        {"Hipparcos Number", "HIP 38010"},
        {"Celescope Catalog", "CEL 2035"},
        {"Geneva Identification System", "GEN# +2.24510283"},
        {"Smithsonian Astrophysical Observation", "SAO 198442"},
        {"Wilson Evans Batten Catalogue", "WEB 7496"},
        {"New General Catalogue", "NGC 2451 283"},
    },
    visualMagnitude: 5.07,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.85416576),
        dec: Angle.Degrees(-38.51115599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119712"},
        {"Hipparcos Number", "HIP 67130"},
        {"Smithsonian Astrophysical Observation", "SAO 204805"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.37730200),
        dec: Angle.Degrees(-38.51090074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69210"},
        {"Hipparcos Number", "HIP 40367"},
        {"Smithsonian Astrophysical Observation", "SAO 198983"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.62476652),
        dec: Angle.Degrees(-38.50880297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127952"},
        {"Hipparcos Number", "HIP 71335"},
        {"Smithsonian Astrophysical Observation", "SAO 205723"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.82602247),
        dec: Angle.Degrees(-38.50538493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57239"},
        {"Hipparcos Number", "HIP 35396"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.65066505),
        dec: Angle.Degrees(-38.50518202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194728"},
        {"Hipparcos Number", "HIP 101005"},
        {"Smithsonian Astrophysical Observation", "SAO 212156"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.17216616),
        dec: Angle.Degrees(-38.50240922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84089"},
        {"Hipparcos Number", "HIP 47543"},
        {"Geneva Identification System", "GEN# +1.00084089"},
        {"Smithsonian Astrophysical Observation", "SAO 200637"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.39451189),
        dec: Angle.Degrees(-38.49688581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -197.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219999"},
        {"Hipparcos Number", "HIP 115251"},
        {"Smithsonian Astrophysical Observation", "SAO 214474"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.16006476),
        dec: Angle.Degrees(-38.49642679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103870"},
        {"Hipparcos Number", "HIP 58316"},
        {"Smithsonian Astrophysical Observation", "SAO 202984"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.37758175),
        dec: Angle.Degrees(-38.49630247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137991"},
        {"Hipparcos Number", "HIP 75933"},
        {"Geneva Identification System", "GEN# +1.00137991"},
        {"Smithsonian Astrophysical Observation", "SAO 206707"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.64188112),
        dec: Angle.Degrees(-38.49616497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10686"},
        {"Hipparcos Number", "HIP 8059"},
        {"Smithsonian Astrophysical Observation", "SAO 193269"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.88364888),
        dec: Angle.Degrees(-38.49525698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134990"},
        {"Hipparcos Number", "HIP 74570"},
        {"Smithsonian Astrophysical Observation", "SAO 206436"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.54123423),
        dec: Angle.Degrees(-38.49198358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4743",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4743"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.23226676),
        dec: Angle.Degrees(-38.49120271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55987"},
        {"Hipparcos Number", "HIP 34919"},
        {"Smithsonian Astrophysical Observation", "SAO 197716"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.37216862),
        dec: Angle.Degrees(-38.49117219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5001"},
        {"Hipparcos Number", "HIP 4028"},
        {"Smithsonian Astrophysical Observation", "SAO 192782"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.90096851),
        dec: Angle.Degrees(-38.49107413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208059"},
        {"Hipparcos Number", "HIP 108142"},
        {"Smithsonian Astrophysical Observation", "SAO 213380"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.64467959),
        dec: Angle.Degrees(-38.49069561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222162"},
        {"Hipparcos Number", "HIP 116654"},
        {"Smithsonian Astrophysical Observation", "SAO 214677"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.60391321),
        dec: Angle.Degrees(-38.48974285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99076"},
        {"Hipparcos Number", "HIP 55628"},
        {"Geneva Identification System", "GEN# +1.00099076"},
        {"Smithsonian Astrophysical Observation", "SAO 202400"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.94447006),
        dec: Angle.Degrees(-38.48934223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35301"},
        {"Hipparcos Number", "HIP 25067"},
        {"Fundamental Katalog 5th Edition", "FK5 4492"},
        {"Smithsonian Astrophysical Observation", "SAO 195782"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.49342359),
        dec: Angle.Degrees(-38.48865166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19396"},
        {"Hipparcos Number", "HIP 14400"},
        {"Smithsonian Astrophysical Observation", "SAO 194079"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.44126331),
        dec: Angle.Degrees(-38.48418008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115493"},
        {"Hipparcos Number", "HIP 64893"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.52250416),
        dec: Angle.Degrees(-38.48213942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17668"},
        {"Hipparcos Number", "HIP 13136"},
        {"Smithsonian Astrophysical Observation", "SAO 193930"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.24113513),
        dec: Angle.Degrees(-38.47954392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164297"},
        {"Hipparcos Number", "HIP 88314"},
        {"Smithsonian Astrophysical Observation", "SAO 209613"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.54149125),
        dec: Angle.Degrees(-38.47951670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101170"},
        {"Hipparcos Number", "HIP 56774"},
        {"Smithsonian Astrophysical Observation", "SAO 202657"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.59650172),
        dec: Angle.Degrees(-38.47775061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214465"},
        {"Hipparcos Number", "HIP 111815"},
        {"Smithsonian Astrophysical Observation", "SAO 213982"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.73171209),
        dec: Angle.Degrees(-38.47729938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186372"},
        {"Hipparcos Number", "HIP 97218"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.37185966),
        dec: Angle.Degrees(-38.47611911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29686",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29686"},
        {"Smithsonian Astrophysical Observation", "SAO 196628"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.80812816),
        dec: Angle.Degrees(-38.47397679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159341"},
        {"Hipparcos Number", "HIP 86117"},
        {"Smithsonian Astrophysical Observation", "SAO 209003"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.98874892),
        dec: Angle.Degrees(-38.47273668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8806"},
        {"Hipparcos Number", "HIP 6704"},
        {"Smithsonian Astrophysical Observation", "SAO 193112"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.55441284),
        dec: Angle.Degrees(-38.46916980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160628"},
        {"Hipparcos Number", "HIP 86689"},
        {"Geneva Identification System", "GEN# +1.00160628"},
        {"Smithsonian Astrophysical Observation", "SAO 209168"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.69305179),
        dec: Angle.Degrees(-38.46751370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12426",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12426"},
    },
    visualMagnitude: 11.24,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.98565759),
        dec: Angle.Degrees(-38.46746608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 207.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 309.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208015"},
        {"Hipparcos Number", "HIP 108126"},
        {"Smithsonian Astrophysical Observation", "SAO 213377"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.58641800),
        dec: Angle.Degrees(-38.46687716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4065"},
        {"Hipparcos Number", "HIP 3356"},
        {"Geneva Identification System", "GEN# +1.00004065"},
        {"Smithsonian Astrophysical Observation", "SAO 192690"},
        {"Wilson Evans Batten Catalogue", "WEB 594"},
    },
    visualMagnitude: 6.05,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.67870812),
        dec: Angle.Degrees(-38.46346745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184233"},
        {"Hipparcos Number", "HIP 96322"},
        {"Smithsonian Astrophysical Observation", "SAO 211381"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.76887231),
        dec: Angle.Degrees(-38.46259862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171337"},
        {"Hipparcos Number", "HIP 91183"},
        {"Smithsonian Astrophysical Observation", "SAO 210353"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.03148517),
        dec: Angle.Degrees(-38.46146787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14111"},
        {"Hipparcos Number", "HIP 10564"},
        {"Geneva Identification System", "GEN# +1.00014111"},
        {"Renson", "Renson 3590"},
        {"Smithsonian Astrophysical Observation", "SAO 193612"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.99778527),
        dec: Angle.Degrees(-38.46134265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153747"},
        {"Hipparcos Number", "HIP 83410"},
        {"Geneva Identification System", "GEN# +1.00153747"},
        {"Smithsonian Astrophysical Observation", "SAO 208337"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.72425563),
        dec: Angle.Degrees(-38.46026115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122641"},
        {"Hipparcos Number", "HIP 68715"},
        {"Smithsonian Astrophysical Observation", "SAO 205136"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.00644322),
        dec: Angle.Degrees(-38.45962346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21080"},
        {"Hipparcos Number", "HIP 15733"},
        {"Smithsonian Astrophysical Observation", "SAO 194265"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.67650794),
        dec: Angle.Degrees(-38.45905762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99952"},
        {"Hipparcos Number", "HIP 56081"},
        {"Geneva Identification System", "GEN# +1.00099952"},
        {"Smithsonian Astrophysical Observation", "SAO 202508"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.42561806),
        dec: Angle.Degrees(-38.45686046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149091"},
        {"Hipparcos Number", "HIP 81127"},
        {"Smithsonian Astrophysical Observation", "SAO 207775"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.52715803),
        dec: Angle.Degrees(-38.45608684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92005"},
        {"Hipparcos Number", "HIP 51948"},
        {"Smithsonian Astrophysical Observation", "SAO 201561"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.18902776),
        dec: Angle.Degrees(-38.45605608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73301"},
        {"Hipparcos Number", "HIP 42215"},
        {"Geneva Identification System", "GEN# +1.00073301"},
        {"Smithsonian Astrophysical Observation", "SAO 199421"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.09648558),
        dec: Angle.Degrees(-38.45551660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107620"},
        {"Hipparcos Number", "HIP 60332"},
        {"Smithsonian Astrophysical Observation", "SAO 203402"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.56197834),
        dec: Angle.Degrees(-38.45152538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147685"},
        {"Hipparcos Number", "HIP 80422"},
        {"Geneva Identification System", "GEN# +1.00147685"},
        {"Smithsonian Astrophysical Observation", "SAO 207643"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.22628647),
        dec: Angle.Degrees(-38.44884355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167554"},
        {"Hipparcos Number", "HIP 89632"},
        {"Geneva Identification System", "GEN# +1.00167554"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.37352562),
        dec: Angle.Degrees(-38.44772022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191889"},
        {"Hipparcos Number", "HIP 99668"},
        {"Geneva Identification System", "GEN# +1.00191889"},
        {"Smithsonian Astrophysical Observation", "SAO 211913"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.39107152),
        dec: Angle.Degrees(-38.44764454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -168.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135549"},
        {"Hipparcos Number", "HIP 74782"},
        {"Geneva Identification System", "GEN# +1.00135549"},
        {"Smithsonian Astrophysical Observation", "SAO 206480"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.24755116),
        dec: Angle.Degrees(-38.44758858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101885",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101885"},
        {"Smithsonian Astrophysical Observation", "SAO 212308"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.70078181),
        dec: Angle.Degrees(-38.44381897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53630",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53630"},
    },
    visualMagnitude: 12.34,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.57206375),
        dec: Angle.Degrees(-38.44341919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219913"},
        {"Hipparcos Number", "HIP 115184"},
        {"Smithsonian Astrophysical Observation", "SAO 214462"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.95489580),
        dec: Angle.Degrees(-38.44319044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97896"},
        {"Hipparcos Number", "HIP 54956"},
        {"Smithsonian Astrophysical Observation", "SAO 202246"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.81473111),
        dec: Angle.Degrees(-38.44213152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5533"},
        {"Hipparcos Number", "HIP 4425"},
        {"Smithsonian Astrophysical Observation", "SAO 192828"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.17266149),
        dec: Angle.Degrees(-38.43866167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68982"},
        {"Hipparcos Number", "HIP 40265"},
        {"Celescope Catalog", "CEL 2251"},
        {"Geneva Identification System", "GEN# +1.00068982"},
        {"Smithsonian Astrophysical Observation", "SAO 198954"},
        {"Wilson Evans Batten Catalogue", "WEB 7850"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.34289294),
        dec: Angle.Degrees(-38.43836676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30783",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30783"},
    },
    visualMagnitude: 12.54,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.01555076),
        dec: Angle.Degrees(-38.43770029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
