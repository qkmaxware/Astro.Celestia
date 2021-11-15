using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_104() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118308",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118308"},
        {"Cincinnati Publication", "Ci 20 1470"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.94888004),
        dec: Angle.Degrees(+50.11249897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 434.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44650"},
        {"Hipparcos Number", "HIP 30572"},
        {"Geneva Identification System", "GEN# +1.00044650"},
        {"Smithsonian Astrophysical Observation", "SAO 25721"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.39117533),
        dec: Angle.Degrees(+50.11299911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2921"},
        {"Smithsonian Astrophysical Observation", "SAO 36510"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.25124330),
        dec: Angle.Degrees(+50.11436492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129695"},
        {"Hipparcos Number", "HIP 71894"},
        {"Smithsonian Astrophysical Observation", "SAO 29249"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.56949058),
        dec: Angle.Degrees(+50.11458283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223734"},
        {"Hipparcos Number", "HIP 117692"},
        {"Smithsonian Astrophysical Observation", "SAO 53434"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.03203832),
        dec: Angle.Degrees(+50.11467456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233500"},
        {"Hipparcos Number", "HIP 40242"},
        {"Smithsonian Astrophysical Observation", "SAO 26728"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.29492581),
        dec: Angle.Degrees(+50.11609766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104828",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104828"},
        {"Smithsonian Astrophysical Observation", "SAO 50607"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.55464183),
        dec: Angle.Degrees(+50.11748159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69342",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69342"},
        {"Geneva Identification System", "GEN# +6.20001092"},
        {"Renson", "Renson 35580"},
        {"Wilson Evans Batten Catalogue", "WEB 12095"},
    },
    visualMagnitude: 11.50,
    bvColour: -0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.88277308),
        dec: Angle.Degrees(+50.11782403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16384"},
        {"Hipparcos Number", "HIP 12382"},
        {"Smithsonian Astrophysical Observation", "SAO 38197"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.84987898),
        dec: Angle.Degrees(+50.11967012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17237",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17237"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.36947271),
        dec: Angle.Degrees(+50.12039901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160384"},
        {"Hipparcos Number", "HIP 86202"},
        {"Smithsonian Astrophysical Observation", "SAO 30481"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.23780887),
        dec: Angle.Degrees(+50.12079012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8160"},
        {"Hipparcos Number", "HIP 6371"},
        {"Smithsonian Astrophysical Observation", "SAO 37148"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.46642194),
        dec: Angle.Degrees(+50.12198828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28794"},
        {"Hipparcos Number", "HIP 21342"},
        {"Geneva Identification System", "GEN# +1.00028794"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.69136814),
        dec: Angle.Degrees(+50.12451938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12984",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2112 AB"},
        {"Henry Draper", "HD 17159"},
        {"Hipparcos Number", "HIP 12984"},
        {"Smithsonian Astrophysical Observation", "SAO 38322"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.75068842),
        dec: Angle.Degrees(+50.12462555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86274"},
        {"Hipparcos Number", "HIP 48917"},
        {"Renson", "Renson 24690"},
        {"Smithsonian Astrophysical Observation", "SAO 27450"},
    },
    visualMagnitude: 6.70,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.68520862),
        dec: Angle.Degrees(+50.12519793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234366"},
        {"Hipparcos Number", "HIP 82883"},
        {"Smithsonian Astrophysical Observation", "SAO 30162"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.07499477),
        dec: Angle.Degrees(+50.12667736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102804",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14345 A"},
        {"Henry Draper", "HD 198624"},
        {"Hipparcos Number", "HIP 102804"},
        {"Geneva Identification System", "GEN# +1.00198624A"},
        {"Smithsonian Astrophysical Observation", "SAO 50116"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.40704730),
        dec: Angle.Degrees(+50.12707030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2296",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2296"},
        {"Smithsonian Astrophysical Observation", "SAO 36411"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.32387022),
        dec: Angle.Degrees(+50.13006037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106113"},
        {"Hipparcos Number", "HIP 59538"},
        {"Smithsonian Astrophysical Observation", "SAO 28301"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.12684116),
        dec: Angle.Degrees(+50.13502389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66947"},
        {"Hipparcos Number", "HIP 39806"},
        {"Smithsonian Astrophysical Observation", "SAO 26683"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.01228269),
        dec: Angle.Degrees(+50.13679259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110948",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110948"},
        {"Smithsonian Astrophysical Observation", "SAO 52045"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.18999383),
        dec: Angle.Degrees(+50.13800543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122546"},
        {"Hipparcos Number", "HIP 68488"},
        {"Fundamental Katalog 5th Edition", "FK5 5244"},
        {"Geneva Identification System", "GEN# +1.00122546"},
        {"Smithsonian Astrophysical Observation", "SAO 28975"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.31903479),
        dec: Angle.Degrees(+50.13902999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215210"},
        {"Hipparcos Number", "HIP 112126"},
        {"Geneva Identification System", "GEN# +1.00215210"},
        {"Smithsonian Astrophysical Observation", "SAO 52290"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.67887589),
        dec: Angle.Degrees(+50.14150132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42087",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42087"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.68097788),
        dec: Angle.Degrees(+50.14209340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149522"},
        {"Hipparcos Number", "HIP 81028"},
        {"Geneva Identification System", "GEN# +1.00149522"},
        {"Smithsonian Astrophysical Observation", "SAO 29983"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.23636715),
        dec: Angle.Degrees(+50.14217433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109566"},
        {"Hipparcos Number", "HIP 61429"},
        {"Smithsonian Astrophysical Observation", "SAO 28436"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.81733590),
        dec: Angle.Degrees(+50.14329644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14188"},
        {"Hipparcos Number", "HIP 10817"},
        {"Smithsonian Astrophysical Observation", "SAO 37946"},
        {"Wilson Evans Batten Catalogue", "WEB 2278"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.80853978),
        dec: Angle.Degrees(+50.14390792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95611",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12470 A"},
        {"Henry Draper", "HD 183361"},
        {"Hipparcos Number", "HIP 95611"},
        {"Geneva Identification System", "GEN# +1.00183361"},
        {"Smithsonian Astrophysical Observation", "SAO 31661"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.69956418),
        dec: Angle.Degrees(+50.14531228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47955"},
        {"Hipparcos Number", "HIP 32237"},
        {"Geneva Identification System", "GEN# +1.00047955"},
        {"Smithsonian Astrophysical Observation", "SAO 25912"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.94476453),
        dec: Angle.Degrees(+50.14543404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35726",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6004 B"},
        {"Henry Draper", "HD 57066"},
        {"Hipparcos Number", "HIP 35726"},
        {"Geneva Identification System", "GEN# +1.00057066"},
        {"Smithsonian Astrophysical Observation", "SAO 26305"},
        {"Wilson Evans Batten Catalogue", "WEB 7117"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.55680466),
        dec: Angle.Degrees(+50.14780092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35731",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6004 A"},
        {"Henry Draper", "HD 57067"},
        {"Hipparcos Number", "HIP 35731"},
        {"Geneva Identification System", "GEN# +1.00057067"},
        {"Smithsonian Astrophysical Observation", "SAO 26306"},
        {"Wilson Evans Batten Catalogue", "WEB 7121"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.56303665),
        dec: Angle.Degrees(+50.14889878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113006",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113006"},
        {"Smithsonian Astrophysical Observation", "SAO 52455"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.29221514),
        dec: Angle.Degrees(+50.15048667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14392"},
        {"Hipparcos Number", "HIP 10944"},
        {"Celescope Catalog", "CEL 258"},
        {"Geneva Identification System", "GEN# +1.00014392"},
        {"Renson", "Renson 3620"},
        {"Smithsonian Astrophysical Observation", "SAO 37960"},
        {"Wilson Evans Batten Catalogue", "WEB 2303"},
    },
    visualMagnitude: 5.57,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.24238707),
        dec: Angle.Degrees(+50.15154156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30046"},
        {"Hipparcos Number", "HIP 22216"},
        {"Smithsonian Astrophysical Observation", "SAO 24817"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.66498098),
        dec: Angle.Degrees(+50.15241730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233442"},
        {"Hipparcos Number", "HIP 37566"},
        {"Smithsonian Astrophysical Observation", "SAO 26475"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.65723009),
        dec: Angle.Degrees(+50.15542746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111306"},
        {"Hipparcos Number", "HIP 62437"},
        {"Fundamental Katalog 5th Edition", "FK5 3019"},
        {"Geneva Identification System", "GEN# +1.00111306"},
        {"Smithsonian Astrophysical Observation", "SAO 28519"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.95156675),
        dec: Angle.Degrees(+50.15696438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138981"},
        {"Hipparcos Number", "HIP 76167"},
        {"Geneva Identification System", "GEN# +1.00138981"},
        {"Smithsonian Astrophysical Observation", "SAO 29569"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.36060990),
        dec: Angle.Degrees(+50.15767143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233906"},
        {"Hipparcos Number", "HIP 59370"},
        {"Smithsonian Astrophysical Observation", "SAO 28276"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.70984070),
        dec: Angle.Degrees(+50.16170097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223037"},
        {"Hipparcos Number", "HIP 117207"},
        {"Smithsonian Astrophysical Observation", "SAO 53354"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.48057898),
        dec: Angle.Degrees(+50.16173741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233700"},
        {"Hipparcos Number", "HIP 49345"},
        {"Smithsonian Astrophysical Observation", "SAO 27501"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.10027838),
        dec: Angle.Degrees(+50.16346114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234441"},
        {"Hipparcos Number", "HIP 85510"},
        {"Smithsonian Astrophysical Observation", "SAO 30405"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.12441698),
        dec: Angle.Degrees(+50.16400004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206748"},
        {"Hipparcos Number", "HIP 107198"},
        {"Smithsonian Astrophysical Observation", "SAO 51219"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.69188104),
        dec: Angle.Degrees(+50.16738301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108738",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108738"},
        {"Smithsonian Astrophysical Observation", "SAO 51568"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.40916660),
        dec: Angle.Degrees(+50.16795470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125141"},
        {"Hipparcos Number", "HIP 69709"},
        {"Geneva Identification System", "GEN# +1.00125141"},
        {"Smithsonian Astrophysical Observation", "SAO 29068"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.02332914),
        dec: Angle.Degrees(+50.16879193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -300.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 186.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233461"},
        {"Hipparcos Number", "HIP 38443"},
        {"Smithsonian Astrophysical Observation", "SAO 26544"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.13152471),
        dec: Angle.Degrees(+50.16935610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9445",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9445"},
        {"Smithsonian Astrophysical Observation", "SAO 37700"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.34602873),
        dec: Angle.Degrees(+50.17085422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96105"},
        {"Hipparcos Number", "HIP 54233"},
        {"Fundamental Katalog 5th Edition", "FK5 2886"},
        {"Geneva Identification System", "GEN# +1.00096105"},
        {"Smithsonian Astrophysical Observation", "SAO 27897"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.44270577),
        dec: Angle.Degrees(+50.17247197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70420"},
        {"Hipparcos Number", "HIP 41175"},
        {"Smithsonian Astrophysical Observation", "SAO 26821"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.03597847),
        dec: Angle.Degrees(+50.17299126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234663"},
        {"Hipparcos Number", "HIP 90719"},
        {"Smithsonian Astrophysical Observation", "SAO 31014"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.63675092),
        dec: Angle.Degrees(+50.17990406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15594"},
        {"Hipparcos Number", "HIP 11785"},
        {"Smithsonian Astrophysical Observation", "SAO 38092"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.02700379),
        dec: Angle.Degrees(+50.18078867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145532"},
        {"Hipparcos Number", "HIP 79134"},
        {"Smithsonian Astrophysical Observation", "SAO 29819"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.28897600),
        dec: Angle.Degrees(+50.18082080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184448"},
        {"Hipparcos Number", "HIP 96077"},
        {"Cincinnati Publication", "Ci 18 2553"},
        {"Geneva Identification System", "GEN# +1.00184448"},
        {"Smithsonian Astrophysical Observation", "SAO 31752"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.01088293),
        dec: Angle.Degrees(+50.18083536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 292.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203136"},
        {"Hipparcos Number", "HIP 105208"},
        {"Geneva Identification System", "GEN# +1.00203136"},
        {"Smithsonian Astrophysical Observation", "SAO 50698"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.66826343),
        dec: Angle.Degrees(+50.18244737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234314"},
        {"Hipparcos Number", "HIP 80999"},
        {"Smithsonian Astrophysical Observation", "SAO 29978"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.13234620),
        dec: Angle.Degrees(+50.18440296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22902"},
        {"Hipparcos Number", "HIP 17359"},
        {"Geneva Identification System", "GEN# +1.00022902"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.73180902),
        dec: Angle.Degrees(+50.18608358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117496"},
        {"Hipparcos Number", "HIP 65823"},
        {"Smithsonian Astrophysical Observation", "SAO 28777"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.40679757),
        dec: Angle.Degrees(+50.18649893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218393"},
        {"Hipparcos Number", "HIP 114154"},
        {"Geneva Identification System", "GEN# +1.00218393"},
        {"Smithsonian Astrophysical Observation", "SAO 52701"},
        {"Wilson Evans Batten Catalogue", "WEB 20272"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.77587777),
        dec: Angle.Degrees(+50.19236076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109586",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15727 A"},
        {"Henry Draper", "HD 210819"},
        {"Hipparcos Number", "HIP 109586"},
        {"Geneva Identification System", "GEN# +2.72430181"},
        {"Smithsonian Astrophysical Observation", "SAO 51749"},
        {"New General Catalogue", "NGC 7243 181"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.98974287),
        dec: Angle.Degrees(+50.19619319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95981",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12563 A"},
        {"Henry Draper", "HD 184241"},
        {"Hipparcos Number", "HIP 95981"},
        {"Smithsonian Astrophysical Observation", "SAO 31729"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.76007917),
        dec: Angle.Degrees(+50.19686095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234053"},
        {"Hipparcos Number", "HIP 66208"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.55288130),
        dec: Angle.Degrees(+50.19858890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25929"},
        {"Hipparcos Number", "HIP 19356"},
        {"Smithsonian Astrophysical Observation", "SAO 24433"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.19715813),
        dec: Angle.Degrees(+50.20048261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148194"},
        {"Hipparcos Number", "HIP 80328"},
        {"Smithsonian Astrophysical Observation", "SAO 29926"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.99039582),
        dec: Angle.Degrees(+50.20274997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17022"},
        {"Hipparcos Number", "HIP 12890"},
        {"Celescope Catalog", "CEL 294"},
        {"Geneva Identification System", "GEN# +1.00017022"},
        {"Smithsonian Astrophysical Observation", "SAO 38302"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.42118005),
        dec: Angle.Degrees(+50.20303810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140396"},
        {"Hipparcos Number", "HIP 76831"},
        {"Smithsonian Astrophysical Observation", "SAO 29622"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.30894990),
        dec: Angle.Degrees(+50.20384105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221728"},
        {"Hipparcos Number", "HIP 116336"},
        {"Smithsonian Astrophysical Observation", "SAO 53155"},
    },
    visualMagnitude: 9.38,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.58971121),
        dec: Angle.Degrees(+50.20928791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215704"},
        {"Hipparcos Number", "HIP 112426"},
        {"Geneva Identification System", "GEN# +1.00215704"},
        {"Smithsonian Astrophysical Observation", "SAO 52353"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.803,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.58398476),
        dec: Angle.Degrees(+50.20997093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 242.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103604",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14520 AB"},
        {"Henry Draper", "HD 200101"},
        {"Hipparcos Number", "HIP 103604"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.86764128),
        dec: Angle.Degrees(+50.21155328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233608"},
        {"Hipparcos Number", "HIP 45098"},
        {"Smithsonian Astrophysical Observation", "SAO 27162"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.80345264),
        dec: Angle.Degrees(+50.21163502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 149.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220362"},
        {"Hipparcos Number", "HIP 115400"},
        {"Smithsonian Astrophysical Observation", "SAO 52953"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.65654862),
        dec: Angle.Degrees(+50.21404733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136562"},
        {"Hipparcos Number", "HIP 74987"},
        {"Geneva Identification System", "GEN# +1.00136562"},
        {"Smithsonian Astrophysical Observation", "SAO 29482"},
        {"Wilson Evans Batten Catalogue", "WEB 12792"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.85080524),
        dec: Angle.Degrees(+50.21460591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7242"},
        {"Hipparcos Number", "HIP 5719"},
        {"Smithsonian Astrophysical Observation", "SAO 37032"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.38892418),
        dec: Angle.Degrees(+50.21533233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213991"},
        {"Hipparcos Number", "HIP 111415"},
        {"Geneva Identification System", "GEN# +1.00213991"},
        {"Smithsonian Astrophysical Observation", "SAO 52154"},
    },
    visualMagnitude: 8.42,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.58645150),
        dec: Angle.Degrees(+50.21622440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15593"},
        {"Hipparcos Number", "HIP 11790"},
        {"Celescope Catalog", "CEL 283"},
        {"Geneva Identification System", "GEN# +1.00015593"},
        {"Smithsonian Astrophysical Observation", "SAO 38093"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.03678892),
        dec: Angle.Degrees(+50.21705747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112028",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112028"},
        {"Smithsonian Astrophysical Observation", "SAO 52269"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.36459020),
        dec: Angle.Degrees(+50.21992348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96441",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12695 A"},
        {"Henry Draper", "HD 185395"},
        {"Hipparcos Number", "HIP 96441"},
        {"Celescope Catalog", "CEL 4802"},
        {"Fundamental Katalog 5th Edition", "FK5 738"},
        {"Geneva Identification System", "GEN# +1.00185395"},
        {"Smithsonian Astrophysical Observation", "SAO 31815"},
        {"Wilson Evans Batten Catalogue", "WEB 16920"},
    },
    visualMagnitude: 4.49,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.11059344),
        dec: Angle.Degrees(+50.22046347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 262.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34919"},
        {"Hipparcos Number", "HIP 25203"},
        {"Smithsonian Astrophysical Observation", "SAO 25168"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.87580859),
        dec: Angle.Degrees(+50.22052141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137293"},
        {"Hipparcos Number", "HIP 75295"},
        {"Smithsonian Astrophysical Observation", "SAO 29506"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.76367921),
        dec: Angle.Degrees(+50.22217926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20365"},
        {"Hipparcos Number", "HIP 15404"},
        {"Geneva Identification System", "GEN# +5.20200383"},
        {"Smithsonian Astrophysical Observation", "SAO 23944"},
        {"Wilson Evans Batten Catalogue", "WEB 2962"},
    },
    visualMagnitude: 5.16,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.65717026),
        dec: Angle.Degrees(+50.22223526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181596"},
        {"Hipparcos Number", "HIP 94880"},
        {"Fundamental Katalog 5th Edition", "FK5 5698"},
        {"Geneva Identification System", "GEN# +1.00181596"},
        {"Smithsonian Astrophysical Observation", "SAO 31556"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.62552586),
        dec: Angle.Degrees(+50.22762684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42212"},
        {"Hipparcos Number", "HIP 29441"},
        {"Wilson Evans Batten Catalogue", "WEB 5788"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.05573211),
        dec: Angle.Degrees(+50.22790029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191329"},
        {"Hipparcos Number", "HIP 99102"},
        {"Geneva Identification System", "GEN# +1.00191329"},
        {"Smithsonian Astrophysical Observation", "SAO 32296"},
        {"Wilson Evans Batten Catalogue", "WEB 17629"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.79769398),
        dec: Angle.Degrees(+50.22961721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233925"},
        {"Hipparcos Number", "HIP 60270"},
        {"Smithsonian Astrophysical Observation", "SAO 28349"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.37079883),
        dec: Angle.Degrees(+50.23092125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1932"},
        {"Hipparcos Number", "HIP 1889"},
        {"Smithsonian Astrophysical Observation", "SAO 36324"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.96856229),
        dec: Angle.Degrees(+50.23123170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192983"},
        {"Hipparcos Number", "HIP 99870"},
        {"Geneva Identification System", "GEN# +1.00192983"},
        {"Smithsonian Astrophysical Observation", "SAO 32400"},
        {"Wilson Evans Batten Catalogue", "WEB 17960"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.93015311),
        dec: Angle.Degrees(+50.23286626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 390",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 390"},
    },
    visualMagnitude: 11.67,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.21175230),
        dec: Angle.Degrees(+50.23487696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210024"},
        {"Hipparcos Number", "HIP 109126"},
        {"Smithsonian Astrophysical Observation", "SAO 51655"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.55760573),
        dec: Angle.Degrees(+50.23554140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47899",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47899"},
    },
    visualMagnitude: 11.10,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.43438098),
        dec: Angle.Degrees(+50.23566232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16184"},
        {"Hipparcos Number", "HIP 12241"},
    },
    visualMagnitude: 7.36,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.40037378),
        dec: Angle.Degrees(+50.23742621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110174",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110174"},
        {"Smithsonian Astrophysical Observation", "SAO 51871"},
        {"New General Catalogue", "NGC 7243 168"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.74045801),
        dec: Angle.Degrees(+50.23834630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185264"},
        {"Hipparcos Number", "HIP 96396"},
        {"Geneva Identification System", "GEN# +1.00185264"},
        {"Smithsonian Astrophysical Observation", "SAO 31804"},
        {"Wilson Evans Batten Catalogue", "WEB 16907"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.98311850),
        dec: Angle.Degrees(+50.23852891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120405"},
        {"Hipparcos Number", "HIP 67321"},
        {"Geneva Identification System", "GEN# +1.00120405"},
        {"Smithsonian Astrophysical Observation", "SAO 28889"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.98220187),
        dec: Angle.Degrees(+50.23941788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233874"},
        {"Hipparcos Number", "HIP 57854"},
        {"Smithsonian Astrophysical Observation", "SAO 28168"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.98095451),
        dec: Angle.Degrees(+50.24121936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182917"},
        {"Hipparcos Number", "HIP 95413"},
        {"Geneva Identification System", "GEN# +1.00182917"},
        {"Smithsonian Astrophysical Observation", "SAO 31632"},
        {"Wilson Evans Batten Catalogue", "WEB 16682"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.13780926),
        dec: Angle.Degrees(+50.24147258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224125"},
        {"Hipparcos Number", "HIP 117936"},
        {"Smithsonian Astrophysical Observation", "SAO 53482"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.84179620),
        dec: Angle.Degrees(+50.24218964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112480",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112480"},
        {"Smithsonian Astrophysical Observation", "SAO 52361"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.75458775),
        dec: Angle.Degrees(+50.24350147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233968"},
        {"Hipparcos Number", "HIP 61918"},
        {"Smithsonian Astrophysical Observation", "SAO 28479"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.35475364),
        dec: Angle.Degrees(+50.24458636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 356"},
        {"Hipparcos Number", "HIP 679"},
        {"Geneva Identification System", "GEN# +1.00000356"},
        {"Smithsonian Astrophysical Observation", "SAO 36089"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.10111748),
        dec: Angle.Degrees(+50.24535175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235072"},
        {"Hipparcos Number", "HIP 98524"},
        {"Smithsonian Astrophysical Observation", "SAO 32202"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.23778088),
        dec: Angle.Degrees(+50.24767111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83272"},
        {"Hipparcos Number", "HIP 47331"},
        {"Geneva Identification System", "GEN# +1.00083272"},
        {"Smithsonian Astrophysical Observation", "SAO 27324"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.67868923),
        dec: Angle.Degrees(+50.24921104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126481"},
        {"Hipparcos Number", "HIP 70408"},
        {"Smithsonian Astrophysical Observation", "SAO 29128"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.06598690),
        dec: Angle.Degrees(+50.24956942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13393"},
        {"Hipparcos Number", "HIP 10282"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.09743472),
        dec: Angle.Degrees(+50.25282992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2712"},
        {"Hipparcos Number", "HIP 2437"},
        {"Smithsonian Astrophysical Observation", "SAO 36432"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.76047877),
        dec: Angle.Degrees(+50.25399522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9675",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9675"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.11294247),
        dec: Angle.Degrees(+50.25460264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93946"},
        {"Hipparcos Number", "HIP 53081"},
        {"Renson", "Renson 27175"},
        {"Smithsonian Astrophysical Observation", "SAO 27799"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.89316277),
        dec: Angle.Degrees(+50.25473283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27292"},
        {"Hipparcos Number", "HIP 20296"},
        {"Geneva Identification System", "GEN# +2.15450003"},
        {"Smithsonian Astrophysical Observation", "SAO 24556"},
        {"Wilson Evans Batten Catalogue", "WEB 3880"},
        {"New General Catalogue", "NGC 1545 3"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.23959841),
        dec: Angle.Degrees(+50.25483723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234687"},
        {"Hipparcos Number", "HIP 91472"},
        {"Smithsonian Astrophysical Observation", "SAO 31087"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.83745710),
        dec: Angle.Degrees(+50.25517209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6701",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6701"},
    },
    visualMagnitude: 11.01,
    bvColour: 1.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.52736590),
        dec: Angle.Degrees(+50.25556005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 290.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234810"},
        {"Hipparcos Number", "HIP 94019"},
        {"Smithsonian Astrophysical Observation", "SAO 31411"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.13046335),
        dec: Angle.Degrees(+50.25660870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70030",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70030"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.94949653),
        dec: Angle.Degrees(+50.25801358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135597"},
        {"Hipparcos Number", "HIP 74557"},
        {"Smithsonian Astrophysical Observation", "SAO 29452"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.50540865),
        dec: Angle.Degrees(+50.26000445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53755",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53755"},
        {"Smithsonian Astrophysical Observation", "SAO 27865"},
    },
    visualMagnitude: 11.02,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.97160300),
        dec: Angle.Degrees(+50.26022449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99773"},
        {"Hipparcos Number", "HIP 56040"},
        {"Smithsonian Astrophysical Observation", "SAO 28031"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.28514321),
        dec: Angle.Degrees(+50.26249518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62987",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62987"},
    },
    visualMagnitude: 10.95,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.60012197),
        dec: Angle.Degrees(+50.26324901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 167.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19672"},
        {"Hipparcos Number", "HIP 14891"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.04612045),
        dec: Angle.Degrees(+50.26329167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94040"},
        {"Hipparcos Number", "HIP 53134"},
        {"Geneva Identification System", "GEN# +1.00094040"},
        {"Smithsonian Astrophysical Observation", "SAO 27805"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.04214700),
        dec: Angle.Degrees(+50.26562098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182691"},
        {"Hipparcos Number", "HIP 95306"},
        {"Celescope Catalog", "CEL 4744"},
        {"Fundamental Katalog 5th Edition", "FK5 3549"},
        {"Geneva Identification System", "GEN# +1.00182691"},
        {"Smithsonian Astrophysical Observation", "SAO 31623"},
        {"Wilson Evans Batten Catalogue", "WEB 16657"},
    },
    visualMagnitude: 6.51,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.84910458),
        dec: Angle.Degrees(+50.27124960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20239",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20239"},
        {"Geneva Identification System", "GEN# +2.15450006"},
        {"New General Catalogue", "NGC 1545 6"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.05617222),
        dec: Angle.Degrees(+50.27476628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67032",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67032"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.05681761),
        dec: Angle.Degrees(+50.27549894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69550"},
        {"Hipparcos Number", "HIP 40806"},
        {"Fundamental Katalog 5th Edition", "FK5 4745"},
        {"Geneva Identification System", "GEN# +1.00069550"},
        {"Smithsonian Astrophysical Observation", "SAO 26776"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.92998968),
        dec: Angle.Degrees(+50.27721259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74777"},
        {"Hipparcos Number", "HIP 43194"},
        {"Geneva Identification System", "GEN# +1.00074777"},
        {"Smithsonian Astrophysical Observation", "SAO 27000"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.99927228),
        dec: Angle.Degrees(+50.27742815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80983"},
        {"Hipparcos Number", "HIP 46156"},
        {"Geneva Identification System", "GEN# +1.00080983"},
        {"Smithsonian Astrophysical Observation", "SAO 27243"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.19314017),
        dec: Angle.Degrees(+50.27830880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14872"},
        {"Hipparcos Number", "HIP 11313"},
        {"Fundamental Katalog 5th Edition", "FK5 2165"},
        {"Geneva Identification System", "GEN# +1.00014872"},
        {"Smithsonian Astrophysical Observation", "SAO 23319"},
        {"Wilson Evans Batten Catalogue", "WEB 2363"},
    },
    visualMagnitude: 4.73,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.40583743),
        dec: Angle.Degrees(+50.27866588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35325"},
        {"Hipparcos Number", "HIP 25456"},
        {"Geneva Identification System", "GEN# +1.00035325"},
        {"Smithsonian Astrophysical Observation", "SAO 25199"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.66627271),
        dec: Angle.Degrees(+50.27884436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193216"},
        {"Hipparcos Number", "HIP 99965"},
        {"Cincinnati Publication", "Ci 18 2649"},
        {"Geneva Identification System", "GEN# +1.00193216"},
        {"Smithsonian Astrophysical Observation", "SAO 32429"},
        {"Wilson Evans Batten Catalogue", "WEB 17991"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.22808500),
        dec: Angle.Degrees(+50.27927108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -221.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -216.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106134"},
        {"Hipparcos Number", "HIP 59543"},
        {"Smithsonian Astrophysical Observation", "SAO 28302"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.16767185),
        dec: Angle.Degrees(+50.27961147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111957"},
        {"Hipparcos Number", "HIP 62818"},
        {"Geneva Identification System", "GEN# +1.00111957"},
        {"Smithsonian Astrophysical Observation", "SAO 28544"},
        {"Wilson Evans Batten Catalogue", "WEB 11138"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.08834976),
        dec: Angle.Degrees(+50.28175405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111169",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16021 A"},
        {"Henry Draper", "HD 213558"},
        {"Hipparcos Number", "HIP 111169"},
        {"Celescope Catalog", "CEL 5482"},
        {"Fundamental Katalog 5th Edition", "FK5 848"},
        {"Geneva Identification System", "GEN# +1.00213558"},
        {"Smithsonian Astrophysical Observation", "SAO 34542"},
        {"Wilson Evans Batten Catalogue", "WEB 19894"},
    },
    visualMagnitude: 3.76,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.82239898),
        dec: Angle.Degrees(+50.28244976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85406",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85406"},
    },
    visualMagnitude: 10.15,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.79546451),
        dec: Angle.Degrees(+50.28347677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104940"},
        {"Hipparcos Number", "HIP 58927"},
        {"Smithsonian Astrophysical Observation", "SAO 28237"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.24941951),
        dec: Angle.Degrees(+50.28372657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210014"},
        {"Hipparcos Number", "HIP 109114"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.53983301),
        dec: Angle.Degrees(+50.28578872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1306"},
        {"Hipparcos Number", "HIP 1401"},
        {"Wilson Evans Batten Catalogue", "WEB 256"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.38369266),
        dec: Angle.Degrees(+50.28735162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4405"},
        {"Hipparcos Number", "HIP 3668"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.73172590),
        dec: Angle.Degrees(+50.28950504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148452"},
        {"Hipparcos Number", "HIP 80485"},
        {"Geneva Identification System", "GEN# +1.00148452"},
        {"Smithsonian Astrophysical Observation", "SAO 29939"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.43694271),
        dec: Angle.Degrees(+50.29017848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77600"},
        {"Hipparcos Number", "HIP 44619"},
        {"Geneva Identification System", "GEN# +1.00077600"},
        {"Smithsonian Astrophysical Observation", "SAO 27112"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.37878001),
        dec: Angle.Degrees(+50.29058974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105072"},
        {"Hipparcos Number", "HIP 59007"},
        {"Smithsonian Astrophysical Observation", "SAO 28247"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.48436955),
        dec: Angle.Degrees(+50.29166504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107456",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107456"},
        {"Geneva Identification System", "GEN# +0.04903615"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.46735172),
        dec: Angle.Degrees(+50.29248645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77636"},
        {"Hipparcos Number", "HIP 44628"},
        {"Geneva Identification System", "GEN# +1.00077636"},
        {"Smithsonian Astrophysical Observation", "SAO 27114"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.41264148),
        dec: Angle.Degrees(+50.29492317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26961"},
        {"Hipparcos Number", "HIP 20070"},
        {"Geneva Identification System", "GEN# +2.15450001"},
        {"Renson", "Renson 6880"},
        {"Smithsonian Astrophysical Observation", "SAO 24531"},
        {"Wilson Evans Batten Catalogue", "WEB 3831"},
        {"Wilson Evans Batten Catalogue 2", "WEB 3832"},
        {"New General Catalogue", "NGC 1545 1"},
    },
    visualMagnitude: 4.60,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.56073112),
        dec: Angle.Degrees(+50.29563944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11571"},
        {"Hipparcos Number", "HIP 8914"},
        {"Smithsonian Astrophysical Observation", "SAO 22736"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.68725056),
        dec: Angle.Degrees(+50.29584118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16625",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16625"},
        {"Renson", "Renson 5500"},
        {"Wilson Evans Batten Catalogue", "WEB 3172"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.47644371),
        dec: Angle.Degrees(+50.29671692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154957"},
        {"Hipparcos Number", "HIP 83680"},
        {"Geneva Identification System", "GEN# +1.00154957"},
        {"Smithsonian Astrophysical Observation", "SAO 30247"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.54484848),
        dec: Angle.Degrees(+50.29875442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 993"},
        {"Hipparcos Number", "HIP 1157"},
    },
    visualMagnitude: 8.31,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.61448216),
        dec: Angle.Degrees(+50.30239222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223275"},
        {"Hipparcos Number", "HIP 117384"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.01260514),
        dec: Angle.Degrees(+50.30290527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23828",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3684 A"},
        {"Henry Draper", "HD 32653"},
        {"Hipparcos Number", "HIP 23828"},
        {"Geneva Identification System", "GEN# +1.00032653A"},
        {"Smithsonian Astrophysical Observation", "SAO 25031"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.84276371),
        dec: Angle.Degrees(+50.30561277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184293"},
        {"Hipparcos Number", "HIP 96014"},
        {"Geneva Identification System", "GEN# +1.00184293"},
        {"Smithsonian Astrophysical Observation", "SAO 31737"},
        {"Wilson Evans Batten Catalogue", "WEB 16819"},
    },
    visualMagnitude: 5.55,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.83066458),
        dec: Angle.Degrees(+50.30659451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154322"},
        {"Hipparcos Number", "HIP 83361"},
        {"Smithsonian Astrophysical Observation", "SAO 30212"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.56782432),
        dec: Angle.Degrees(+50.30827527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190547"},
        {"Hipparcos Number", "HIP 98731"},
        {"Smithsonian Astrophysical Observation", "SAO 32236"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.80360220),
        dec: Angle.Degrees(+50.30896865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221848"},
        {"Hipparcos Number", "HIP 116406"},
    },
    visualMagnitude: 7.23,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.82996211),
        dec: Angle.Degrees(+50.31177945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234006"},
        {"Hipparcos Number", "HIP 63710"},
        {"Smithsonian Astrophysical Observation", "SAO 28619"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.84727332),
        dec: Angle.Degrees(+50.31200988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6174"},
        {"Hipparcos Number", "HIP 4952"},
        {"Geneva Identification System", "GEN# +1.00006174"},
        {"Smithsonian Astrophysical Observation", "SAO 21958"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.87561261),
        dec: Angle.Degrees(+50.31255539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138074"},
        {"Hipparcos Number", "HIP 75677"},
        {"Smithsonian Astrophysical Observation", "SAO 29534"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.91889599),
        dec: Angle.Degrees(+50.31490947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235253"},
        {"Hipparcos Number", "HIP 101108"},
        {"Geneva Identification System", "GEN# +1.00235253"},
        {"Smithsonian Astrophysical Observation", "SAO 32628"},
        {"Wilson Evans Batten Catalogue", "WEB 18262"},
    },
    visualMagnitude: 9.06,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.42774085),
        dec: Angle.Degrees(+50.31863807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164346"},
        {"Hipparcos Number", "HIP 87951"},
        {"Smithsonian Astrophysical Observation", "SAO 30663"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.50415710),
        dec: Angle.Degrees(+50.32425360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10485",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10485"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.80013303),
        dec: Angle.Degrees(+50.32652423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88817"},
        {"Hipparcos Number", "HIP 50280"},
        {"Smithsonian Astrophysical Observation", "SAO 27582"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.98965764),
        dec: Angle.Degrees(+50.32967858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234555"},
        {"Hipparcos Number", "HIP 88641"},
        {"Smithsonian Astrophysical Observation", "SAO 30744"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.46143649),
        dec: Angle.Degrees(+50.33792944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102177",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14189 A"},
        {"Henry Draper", "HD 197511"},
        {"Hipparcos Number", "HIP 102177"},
        {"Geneva Identification System", "GEN# +1.00197511"},
        {"Smithsonian Astrophysical Observation", "SAO 32809"},
        {"Wilson Evans Batten Catalogue", "WEB 18486"},
    },
    visualMagnitude: 5.41,
    bvColour: -0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.55261149),
        dec: Angle.Degrees(+50.34002067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95062",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12343 A"},
        {"Henry Draper", "HD 182076"},
        {"Hipparcos Number", "HIP 95062"},
        {"Smithsonian Astrophysical Observation", "SAO 31586"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.13104015),
        dec: Angle.Degrees(+50.34014402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234344"},
        {"Hipparcos Number", "HIP 82092"},
        {"Cincinnati Publication", "Ci 20 1010"},
        {"Smithsonian Astrophysical Observation", "SAO 30084"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.53218812),
        dec: Angle.Degrees(+50.34377663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 406.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65078"},
        {"Hipparcos Number", "HIP 39049"},
        {"Smithsonian Astrophysical Observation", "SAO 26603"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.83826439),
        dec: Angle.Degrees(+50.34401178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148049"},
        {"Hipparcos Number", "HIP 80264"},
        {"Geneva Identification System", "GEN# +1.00148049"},
        {"Smithsonian Astrophysical Observation", "SAO 29922"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.77931909),
        dec: Angle.Degrees(+50.34423490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24351"},
        {"Hipparcos Number", "HIP 18295"},
        {"Geneva Identification System", "GEN# +1.00024351"},
        {"Smithsonian Astrophysical Observation", "SAO 24290"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.68571045),
        dec: Angle.Degrees(+50.34641515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25642"},
        {"Hipparcos Number", "HIP 19167"},
        {"Fundamental Katalog 5th Edition", "FK5 1113"},
        {"Geneva Identification System", "GEN# +1.00025642"},
        {"Smithsonian Astrophysical Observation", "SAO 24412"},
        {"Wilson Evans Batten Catalogue", "WEB 3682"},
    },
    visualMagnitude: 4.25,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.64606374),
        dec: Angle.Degrees(+50.35135022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200740"},
        {"Hipparcos Number", "HIP 103929"},
        {"Geneva Identification System", "GEN# +1.00200740"},
        {"Smithsonian Astrophysical Observation", "SAO 33091"},
        {"Wilson Evans Batten Catalogue", "WEB 18924"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.85846344),
        dec: Angle.Degrees(+50.35180252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234075"},
        {"Hipparcos Number", "HIP 67532"},
        {"Smithsonian Astrophysical Observation", "SAO 28900"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.55467846),
        dec: Angle.Degrees(+50.35345321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17776"},
        {"Hipparcos Number", "HIP 13432"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.24103039),
        dec: Angle.Degrees(+50.35458001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188014"},
        {"Hipparcos Number", "HIP 97654"},
        {"Geneva Identification System", "GEN# +1.00188014"},
        {"Smithsonian Astrophysical Observation", "SAO 32044"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.69958026),
        dec: Angle.Degrees(+50.35558412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220948"},
        {"Hipparcos Number", "HIP 115804"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.91127062),
        dec: Angle.Degrees(+50.35753330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20282"},
        {"Hipparcos Number", "HIP 15327"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.43016025),
        dec: Angle.Degrees(+50.36110246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179095"},
        {"Hipparcos Number", "HIP 94023"},
        {"Celescope Catalog", "CEL 4708"},
        {"Geneva Identification System", "GEN# +1.00179095"},
        {"Smithsonian Astrophysical Observation", "SAO 31415"},
    },
    visualMagnitude: 6.92,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.13900861),
        dec: Angle.Degrees(+50.36384250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23458"},
        {"Hipparcos Number", "HIP 17713"},
        {"Geneva Identification System", "GEN# +1.00023458"},
        {"Smithsonian Astrophysical Observation", "SAO 24223"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.90906636),
        dec: Angle.Degrees(+50.36396409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213531"},
        {"Hipparcos Number", "HIP 111147"},
    },
    visualMagnitude: 7.73,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.77409573),
        dec: Angle.Degrees(+50.36472040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234114"},
        {"Hipparcos Number", "HIP 69428"},
        {"Smithsonian Astrophysical Observation", "SAO 29040"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.22841662),
        dec: Angle.Degrees(+50.36689167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233832"},
        {"Henry Draper 2", "HD 233832A"},
        {"Hipparcos Number", "HIP 55806"},
        {"Cincinnati Publication", "Ci 20 636"},
        {"Geneva Identification System", "GEN# +1.00233832"},
        {"Smithsonian Astrophysical Observation", "SAO 28018"},
        {"Wilson Evans Batten Catalogue", "WEB 10032"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.52465886),
        dec: Angle.Degrees(+50.37547309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -473.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 125.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233728"},
        {"Hipparcos Number", "HIP 50716"},
        {"Smithsonian Astrophysical Observation", "SAO 27618"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.33245264),
        dec: Angle.Degrees(+50.37579805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186304"},
        {"Hipparcos Number", "HIP 96855"},
        {"Geneva Identification System", "GEN# +1.00186304"},
        {"Smithsonian Astrophysical Observation", "SAO 31888"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.30868801),
        dec: Angle.Degrees(+50.37833504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233577"},
        {"Hipparcos Number", "HIP 43632"},
        {"Smithsonian Astrophysical Observation", "SAO 27029"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.28658788),
        dec: Angle.Degrees(+50.37845112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14853",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14853"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.95820340),
        dec: Angle.Degrees(+50.37971535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48489"},
        {"Hipparcos Number", "HIP 32449"},
        {"Smithsonian Astrophysical Observation", "SAO 25946"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.58630677),
        dec: Angle.Degrees(+50.38047355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72459"},
        {"Hipparcos Number", "HIP 42124"},
        {"Geneva Identification System", "GEN# +1.00072459"},
        {"Renson", "Renson 20060"},
        {"Smithsonian Astrophysical Observation", "SAO 26918"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.80498604),
        dec: Angle.Degrees(+50.38113689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29853",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29853"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.29375552),
        dec: Angle.Degrees(+50.38965935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163216"},
        {"Hipparcos Number", "HIP 87483"},
        {"Smithsonian Astrophysical Observation", "SAO 30619"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.11816560),
        dec: Angle.Degrees(+50.39164941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130445"},
        {"Hipparcos Number", "HIP 72253"},
        {"Geneva Identification System", "GEN# +1.00130445"},
        {"Smithsonian Astrophysical Observation", "SAO 29273"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.62554072),
        dec: Angle.Degrees(+50.39784882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146209"},
        {"Hipparcos Number", "HIP 79449"},
        {"Smithsonian Astrophysical Observation", "SAO 29842"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.20616933),
        dec: Angle.Degrees(+50.39827551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212712"},
        {"Hipparcos Number", "HIP 110682"},
        {"Smithsonian Astrophysical Observation", "SAO 34430"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.35054837),
        dec: Angle.Degrees(+50.40151700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88975",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11128 AB"},
        {"Henry Draper", "HD 166820"},
        {"Hipparcos Number", "HIP 88975"},
        {"Smithsonian Astrophysical Observation", "SAO 30776"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.41931285),
        dec: Angle.Degrees(+50.40204963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202013"},
        {"Hipparcos Number", "HIP 104611"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.86967997),
        dec: Angle.Degrees(+50.40209868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139373"},
        {"Hipparcos Number", "HIP 76345"},
        {"Smithsonian Astrophysical Observation", "SAO 29584"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.90932564),
        dec: Angle.Degrees(+50.40506982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30465"},
        {"Hipparcos Number", "HIP 22513"},
        {"Fundamental Katalog 5th Edition", "FK5 4444"},
        {"Geneva Identification System", "GEN# +1.00030465"},
        {"Smithsonian Astrophysical Observation", "SAO 24863"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.66348193),
        dec: Angle.Degrees(+50.40905445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75429"},
        {"Hipparcos Number", "HIP 43542"},
        {"Geneva Identification System", "GEN# +1.00075429"},
        {"Smithsonian Astrophysical Observation", "SAO 27021"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.02093740),
        dec: Angle.Degrees(+50.40971220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57141",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57141"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.77265700),
        dec: Angle.Degrees(+50.40989405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -240.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126942"},
        {"Hipparcos Number", "HIP 70639"},
        {"Smithsonian Astrophysical Observation", "SAO 29147"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.73625998),
        dec: Angle.Degrees(+50.41018294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116530"},
        {"Hipparcos Number", "HIP 65322"},
        {"Smithsonian Astrophysical Observation", "SAO 28731"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.82572927),
        dec: Angle.Degrees(+50.41021927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44166"},
        {"Hipparcos Number", "HIP 30361"},
        {"Smithsonian Astrophysical Observation", "SAO 25695"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.78690134),
        dec: Angle.Degrees(+50.41098086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35504",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35504"},
    },
    visualMagnitude: 11.22,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.91159103),
        dec: Angle.Degrees(+50.41126672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216523"},
        {"Hipparcos Number", "HIP 112986"},
        {"Geneva Identification System", "GEN# +1.00216523"},
        {"Smithsonian Astrophysical Observation", "SAO 34917"},
    },
    visualMagnitude: 6.46,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.21764368),
        dec: Angle.Degrees(+50.41228825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113809",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113809"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.71222913),
        dec: Angle.Degrees(+50.41247732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110391"},
        {"Hipparcos Number", "HIP 61913"},
        {"Smithsonian Astrophysical Observation", "SAO 28477"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.33635378),
        dec: Angle.Degrees(+50.41594898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31550",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31550"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.06162518),
        dec: Angle.Degrees(+50.41713397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17786"},
        {"Hipparcos Number", "HIP 13443"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.28679554),
        dec: Angle.Degrees(+50.41747371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92211",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92211"},
    },
    visualMagnitude: 9.89,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.89464844),
        dec: Angle.Degrees(+50.42134046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139906"},
        {"Hipparcos Number", "HIP 76594"},
        {"Geneva Identification System", "GEN# +1.00139906"},
        {"Smithsonian Astrophysical Observation", "SAO 29600"},
        {"Wilson Evans Batten Catalogue", "WEB 13001"},
    },
    visualMagnitude: 5.84,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.64250158),
        dec: Angle.Degrees(+50.42335207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196482"},
        {"Hipparcos Number", "HIP 101611"},
        {"Geneva Identification System", "GEN# +1.00196482"},
        {"Smithsonian Astrophysical Observation", "SAO 32716"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.89004273),
        dec: Angle.Degrees(+50.42483011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158064"},
        {"Hipparcos Number", "HIP 85179"},
        {"Fundamental Katalog 5th Edition", "FK5 5533"},
        {"Geneva Identification System", "GEN# +1.00158064"},
        {"Smithsonian Astrophysical Observation", "SAO 30371"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.10862429),
        dec: Angle.Degrees(+50.42528078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142551"},
        {"Hipparcos Number", "HIP 77774"},
        {"Smithsonian Astrophysical Observation", "SAO 29699"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.21807866),
        dec: Angle.Degrees(+50.42552179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4971",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 871 AB"},
        {"Henry Draper", "HD 6194"},
        {"Hipparcos Number", "HIP 4971"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.92671663),
        dec: Angle.Degrees(+50.43183566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115979"},
        {"Hipparcos Number", "HIP 65031"},
        {"Smithsonian Astrophysical Observation", "SAO 28716"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.94934292),
        dec: Angle.Degrees(+50.43348166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61931"},
        {"Hipparcos Number", "HIP 37701"},
        {"Fundamental Katalog 5th Edition", "FK5 2599"},
        {"Geneva Identification System", "GEN# +1.00061931"},
        {"Renson", "Renson 16996"},
        {"Smithsonian Astrophysical Observation", "SAO 26488"},
        {"Wilson Evans Batten Catalogue", "WEB 7452"},
    },
    visualMagnitude: 5.31,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.01744892),
        dec: Angle.Degrees(+50.43386115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6129",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6129"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.66838408),
        dec: Angle.Degrees(+50.43416802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205208"},
        {"Hipparcos Number", "HIP 106333"},
        {"Geneva Identification System", "GEN# +1.00205208"},
        {"Smithsonian Astrophysical Observation", "SAO 33510"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.04373241),
        dec: Angle.Degrees(+50.43571979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204022"},
        {"Hipparcos Number", "HIP 105669"},
        {"Geneva Identification System", "GEN# +1.00204022"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.04840159),
        dec: Angle.Degrees(+50.43606835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16196",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2548 AB"},
        {"Henry Draper", "HD 21332"},
        {"Hipparcos Number", "HIP 16196"},
        {"Smithsonian Astrophysical Observation", "SAO 24055"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.16845024),
        dec: Angle.Degrees(+50.43644846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78792"},
        {"Hipparcos Number", "HIP 45152"},
        {"Geneva Identification System", "GEN# +1.00078792"},
        {"Smithsonian Astrophysical Observation", "SAO 27165"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.98442740),
        dec: Angle.Degrees(+50.43990905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125020"},
        {"Hipparcos Number", "HIP 69663"},
        {"Smithsonian Astrophysical Observation", "SAO 29061"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.86627472),
        dec: Angle.Degrees(+50.44023459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204673"},
        {"Hipparcos Number", "HIP 106028"},
        {"Celescope Catalog", "CEL 5321"},
        {"Geneva Identification System", "GEN# +1.00204673"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.13195493),
        dec: Angle.Degrees(+50.44539562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233489"},
        {"Hipparcos Number", "HIP 39526"},
        {"Smithsonian Astrophysical Observation", "SAO 26654"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.17536200),
        dec: Angle.Degrees(+50.44540467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115706"},
        {"Hipparcos Number", "HIP 64890"},
        {"Geneva Identification System", "GEN# +1.00115706"},
        {"Smithsonian Astrophysical Observation", "SAO 28711"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.52003174),
        dec: Angle.Degrees(+50.44634568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224465"},
        {"Hipparcos Number", "HIP 118162"},
        {"Geneva Identification System", "GEN# +1.00224465"},
        {"Smithsonian Astrophysical Observation", "SAO 35934"},
        {"Wilson Evans Batten Catalogue", "WEB 20774"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.52857069),
        dec: Angle.Degrees(+50.44707965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 245.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14985",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14985"},
        {"Cincinnati Publication", "Ci 18 417"},
    },
    visualMagnitude: 9.92,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.28724386),
        dec: Angle.Degrees(+50.44773811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -268.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190988"},
        {"Hipparcos Number", "HIP 98940"},
        {"Smithsonian Astrophysical Observation", "SAO 32274"},
    },
    visualMagnitude: 7.96,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.32894345),
        dec: Angle.Degrees(+50.44862836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148365"},
        {"Hipparcos Number", "HIP 80426"},
        {"Geneva Identification System", "GEN# +1.00148365"},
        {"Smithsonian Astrophysical Observation", "SAO 29933"},
        {"Wilson Evans Batten Catalogue", "WEB 13608"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.24933455),
        dec: Angle.Degrees(+50.45201870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234041"},
        {"Hipparcos Number", "HIP 65677"},
        {"Smithsonian Astrophysical Observation", "SAO 28762"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.99820175),
        dec: Angle.Degrees(+50.45526429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195447"},
        {"Hipparcos Number", "HIP 101068"},
        {"Renson", "Renson 54447"},
        {"Smithsonian Astrophysical Observation", "SAO 32622"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.33672760),
        dec: Angle.Degrees(+50.46033100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103530",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14504 AB"},
        {"Henry Draper", "HD 199955"},
        {"Hipparcos Number", "HIP 103530"},
        {"Celescope Catalog", "CEL 5224"},
        {"Geneva Identification System", "GEN# +1.00199955J"},
        {"Smithsonian Astrophysical Observation", "SAO 33034"},
        {"Wilson Evans Batten Catalogue", "WEB 18837"},
    },
    visualMagnitude: 5.59,
    bvColour: -0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.62510662),
        dec: Angle.Degrees(+50.46178308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16736"},
        {"Hipparcos Number", "HIP 12662"},
        {"Renson", "Renson 4224"},
        {"Smithsonian Astrophysical Observation", "SAO 23551"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.67249227),
        dec: Angle.Degrees(+50.46398290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190546"},
        {"Hipparcos Number", "HIP 98734"},
        {"Smithsonian Astrophysical Observation", "SAO 32237"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.80624717),
        dec: Angle.Degrees(+50.46498054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201909"},
        {"Hipparcos Number", "HIP 104558"},
        {"Smithsonian Astrophysical Observation", "SAO 33191"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.70005489),
        dec: Angle.Degrees(+50.46853682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104033",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14616 A"},
        {"Henry Draper", "HD 200926"},
        {"Hipparcos Number", "HIP 104033"},
        {"Smithsonian Astrophysical Observation", "SAO 33109"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.14763088),
        dec: Angle.Degrees(+50.47045838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222304"},
        {"Hipparcos Number", "HIP 116709"},
        {"Fundamental Katalog 5th Edition", "FK5 3897"},
        {"Geneva Identification System", "GEN# +1.00222304"},
        {"Smithsonian Astrophysical Observation", "SAO 35642"},
        {"Wilson Evans Batten Catalogue", "WEB 20596"},
    },
    visualMagnitude: 5.35,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.78478065),
        dec: Angle.Degrees(+50.47173744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72440"},
        {"Hipparcos Number", "HIP 42109"},
        {"Geneva Identification System", "GEN# +1.00072440"},
        {"Smithsonian Astrophysical Observation", "SAO 26913"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.75453327),
        dec: Angle.Degrees(+50.47202803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26495"},
        {"Hipparcos Number", "HIP 19738"},
        {"Geneva Identification System", "GEN# +1.00026495"},
        {"Smithsonian Astrophysical Observation", "SAO 24489"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.47766246),
        dec: Angle.Degrees(+50.47823452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86746"},
        {"Hipparcos Number", "HIP 49150"},
        {"Geneva Identification System", "GEN# +1.00086746"},
        {"Smithsonian Astrophysical Observation", "SAO 27479"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.46609237),
        dec: Angle.Degrees(+50.48075701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21584"},
        {"Hipparcos Number", "HIP 16394"},
        {"Renson", "Renson 5390"},
        {"Smithsonian Astrophysical Observation", "SAO 24074"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.77750552),
        dec: Angle.Degrees(+50.48155481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161238"},
        {"Hipparcos Number", "HIP 86592"},
        {"Smithsonian Astrophysical Observation", "SAO 30523"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.44632731),
        dec: Angle.Degrees(+50.48606565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219588"},
        {"Hipparcos Number", "HIP 114892"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.08281353),
        dec: Angle.Degrees(+50.48792869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8426"},
        {"Hipparcos Number", "HIP 6574"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.11274331),
        dec: Angle.Degrees(+50.48927967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208785"},
        {"Hipparcos Number", "HIP 108374"},
        {"Wilson Evans Batten Catalogue", "WEB 19519"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.32460133),
        dec: Angle.Degrees(+50.48948072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221514"},
        {"Hipparcos Number", "HIP 116195"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.14049170),
        dec: Angle.Degrees(+50.49060417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2931"},
        {"Hipparcos Number", "HIP 2602"},
        {"Geneva Identification System", "GEN# +1.00002931"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.26371701),
        dec: Angle.Degrees(+50.49297129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89743"},
        {"Hipparcos Number", "HIP 50815"},
        {"Geneva Identification System", "GEN# +1.00089743"},
        {"Smithsonian Astrophysical Observation", "SAO 27625"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.61984205),
        dec: Angle.Degrees(+50.49415581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88512"},
        {"Hipparcos Number", "HIP 50097"},
        {"Smithsonian Astrophysical Observation", "SAO 27566"},
        {"Wilson Evans Batten Catalogue", "WEB 9209"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.43262466),
        dec: Angle.Degrees(+50.49652458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208512"},
        {"Hipparcos Number", "HIP 108205"},
        {"Geneva Identification System", "GEN# +1.00208512"},
        {"Wilson Evans Batten Catalogue", "WEB 19502"},
    },
    visualMagnitude: 9.23,
    bvColour: 4.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.80737718),
        dec: Angle.Degrees(+50.49715525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99176"},
        {"Hipparcos Number", "HIP 55738"},
        {"Smithsonian Astrophysical Observation", "SAO 28012"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.30819626),
        dec: Angle.Degrees(+50.49887996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144578"},
        {"Hipparcos Number", "HIP 78721"},
        {"Smithsonian Astrophysical Observation", "SAO 29781"},
        {"Wilson Evans Batten Catalogue", "WEB 13309"},
    },
    visualMagnitude: 8.70,
    bvColour: 2.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.05587986),
        dec: Angle.Degrees(+50.49916367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232651"},
        {"Hipparcos Number", "HIP 11307"},
        {"Smithsonian Astrophysical Observation", "SAO 23317"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.39049057),
        dec: Angle.Degrees(+50.49987449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106651",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15135 A"},
        {"Henry Draper", "HD 205795"},
        {"Hipparcos Number", "HIP 106651"},
        {"Celescope Catalog", "CEL 5348"},
        {"Geneva Identification System", "GEN# +1.00205795"},
        {"Renson", "Renson 57320"},
        {"Smithsonian Astrophysical Observation", "SAO 33567"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.04052517),
        dec: Angle.Degrees(+50.50202487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56119"},
        {"Hipparcos Number", "HIP 35367"},
        {"Smithsonian Astrophysical Observation", "SAO 26267"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.58035399),
        dec: Angle.Degrees(+50.50437664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234106"},
        {"Hipparcos Number", "HIP 68885"},
        {"Smithsonian Astrophysical Observation", "SAO 29007"},
    },
    visualMagnitude: 11.14,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.56734871),
        dec: Angle.Degrees(+50.50483261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224625"},
        {"Hipparcos Number", "HIP 118272"},
        {"Smithsonian Astrophysical Observation", "SAO 35958"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.84009077),
        dec: Angle.Degrees(+50.50816171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138382"},
        {"Hipparcos Number", "HIP 75856"},
        {"Smithsonian Astrophysical Observation", "SAO 29546"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.42277625),
        dec: Angle.Degrees(+50.51135234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107717",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15355 B"},
        {"Hipparcos Number", "HIP 107717"},
        {"Smithsonian Astrophysical Observation", "SAO 33780"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.30725941),
        dec: Angle.Degrees(+50.51200016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3901"},
        {"Hipparcos Number", "HIP 3300"},
        {"Fundamental Katalog 5th Edition", "FK5 2046"},
        {"Geneva Identification System", "GEN# +1.00003901"},
        {"Smithsonian Astrophysical Observation", "SAO 21637"},
        {"Wilson Evans Batten Catalogue", "WEB 588"},
    },
    visualMagnitude: 4.80,
    bvColour: -0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.51618425),
        dec: Angle.Degrees(+50.51254151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144468"},
        {"Hipparcos Number", "HIP 78686"},
        {"Smithsonian Astrophysical Observation", "SAO 29779"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.95124183),
        dec: Angle.Degrees(+50.51273469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107718",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15355 A"},
        {"Henry Draper", "HD 207661"},
        {"Hipparcos Number", "HIP 107718"},
        {"Celescope Catalog", "CEL 5390"},
        {"Smithsonian Astrophysical Observation", "SAO 33781"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.31032941),
        dec: Angle.Degrees(+50.51507662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234096"},
        {"Hipparcos Number", "HIP 68349"},
        {"Geneva Identification System", "GEN# +1.00234096"},
        {"Smithsonian Astrophysical Observation", "SAO 28959"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.86532384),
        dec: Angle.Degrees(+50.51690694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96901",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12815 B"},
        {"Henry Draper", "HD 186427"},
        {"Hipparcos Number", "HIP 96901"},
        {"Geneva Identification System", "GEN# +1.00186427"},
        {"Smithsonian Astrophysical Observation", "SAO 31899"},
        {"Wilson Evans Batten Catalogue", "WEB 17005"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.46706651),
        dec: Angle.Degrees(+50.51792062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -135.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -163.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45165"},
        {"Hipparcos Number", "HIP 30844"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.16597799),
        dec: Angle.Degrees(+50.51817239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66704",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8992 A"},
        {"Henry Draper", "HD 119124"},
        {"Hipparcos Number", "HIP 66704"},
        {"Geneva Identification System", "GEN# +1.00119124A"},
        {"Smithsonian Astrophysical Observation", "SAO 28836"},
        {"Wilson Evans Batten Catalogue", "WEB 11766"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.09728108),
        dec: Angle.Degrees(+50.51927223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235477"},
        {"Hipparcos Number", "HIP 105082"},
        {"Geneva Identification System", "GEN# +1.00235477"},
        {"Smithsonian Astrophysical Observation", "SAO 33283"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.31215487),
        dec: Angle.Degrees(+50.51971794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105617",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14941 AB"},
        {"Henry Draper", "HD 203918"},
        {"Hipparcos Number", "HIP 105617"},
        {"Geneva Identification System", "GEN# +1.00203918J"},
        {"Smithsonian Astrophysical Observation", "SAO 33380"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.87233450),
        dec: Angle.Degrees(+50.52371003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96895",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12815 A"},
        {"Henry Draper", "HD 186408"},
        {"Hipparcos Number", "HIP 96895"},
        {"Geneva Identification System", "GEN# +1.00186408"},
        {"Smithsonian Astrophysical Observation", "SAO 31898"},
        {"Wilson Evans Batten Catalogue", "WEB 17003"},
    },
    visualMagnitude: 5.99,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.45453769),
        dec: Angle.Degrees(+50.52544635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125179"},
        {"Hipparcos Number", "HIP 69726"},
        {"Smithsonian Astrophysical Observation", "SAO 29075"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.08854725),
        dec: Angle.Degrees(+50.52624212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60912"},
        {"Hipparcos Number", "HIP 37283"},
        {"Geneva Identification System", "GEN# +1.00060912"},
        {"Smithsonian Astrophysical Observation", "SAO 26449"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.84033701),
        dec: Angle.Degrees(+50.52868572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224612"},
        {"Hipparcos Number", "HIP 118264"},
        {"Geneva Identification System", "GEN# +1.00224612"},
        {"Smithsonian Astrophysical Observation", "SAO 35954"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.81142466),
        dec: Angle.Degrees(+50.52927083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85556"},
        {"Hipparcos Number", "HIP 48548"},
        {"Geneva Identification System", "GEN# +1.00085556"},
        {"Smithsonian Astrophysical Observation", "SAO 27424"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.52322208),
        dec: Angle.Degrees(+50.53114084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37009"},
        {"Hipparcos Number", "HIP 26503"},
        {"Geneva Identification System", "GEN# +1.00037009"},
        {"Smithsonian Astrophysical Observation", "SAO 25289"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.55057472),
        dec: Angle.Degrees(+50.53236871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168221"},
        {"Hipparcos Number", "HIP 89521"},
        {"Smithsonian Astrophysical Observation", "SAO 30853"},
    },
    visualMagnitude: 7.45,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.01369203),
        dec: Angle.Degrees(+50.53268257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177003"},
        {"Hipparcos Number", "HIP 93299"},
        {"Celescope Catalog", "CEL 4685"},
        {"Fundamental Katalog 5th Edition", "FK5 3515"},
        {"Geneva Identification System", "GEN# +1.00177003"},
        {"Renson", "Renson 49360"},
        {"Smithsonian Astrophysical Observation", "SAO 31311"},
        {"Wilson Evans Batten Catalogue", "WEB 16177"},
    },
    visualMagnitude: 5.39,
    bvColour: -0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.05696213),
        dec: Angle.Degrees(+50.53345884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234091"},
        {"Hipparcos Number", "HIP 68152"},
        {"Smithsonian Astrophysical Observation", "SAO 28944"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.28509306),
        dec: Angle.Degrees(+50.53742916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194204"},
        {"Hipparcos Number", "HIP 100447"},
        {"Fundamental Katalog 5th Edition", "FK5 5794"},
        {"Smithsonian Astrophysical Observation", "SAO 32506"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.55252178),
        dec: Angle.Degrees(+50.54112017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64385"},
        {"Hipparcos Number", "HIP 38769"},
        {"Cincinnati Publication", "Ci 18 939"},
        {"Geneva Identification System", "GEN# +1.00064385"},
        {"Smithsonian Astrophysical Observation", "SAO 26578"},
        {"Wilson Evans Batten Catalogue", "WEB 7596"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.04174864),
        dec: Angle.Degrees(+50.54129129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 196.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62253",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62253"},
    },
    visualMagnitude: 10.35,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.36559951),
        dec: Angle.Degrees(+50.54286986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23104"},
        {"Hipparcos Number", "HIP 17476"},
        {"Smithsonian Astrophysical Observation", "SAO 24187"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.17116359),
        dec: Angle.Degrees(+50.54298804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116716",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116716"},
    },
    visualMagnitude: 10.17,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.80186239),
        dec: Angle.Degrees(+50.54492388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105823"},
        {"Hipparcos Number", "HIP 59371"},
        {"Geneva Identification System", "GEN# +1.00105823"},
        {"Smithsonian Astrophysical Observation", "SAO 28277"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.71256807),
        dec: Angle.Degrees(+50.54716194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233755"},
        {"Hipparcos Number", "HIP 51995"},
        {"Smithsonian Astrophysical Observation", "SAO 27708"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.33949125),
        dec: Angle.Degrees(+50.55118545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87258"},
        {"Hipparcos Number", "HIP 49415"},
        {"Smithsonian Astrophysical Observation", "SAO 27513"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.30565719),
        dec: Angle.Degrees(+50.55129885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20344"},
        {"Hipparcos Number", "HIP 15388"},
        {"Geneva Identification System", "GEN# +5.20200379"},
        {"Smithsonian Astrophysical Observation", "SAO 23941"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.59952286),
        dec: Angle.Degrees(+50.55576571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54983"},
        {"Hipparcos Number", "HIP 34927"},
        {"Geneva Identification System", "GEN# +1.00054983"},
        {"Smithsonian Astrophysical Observation", "SAO 26227"},
        {"Wilson Evans Batten Catalogue", "WEB 6982"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.41413838),
        dec: Angle.Degrees(+50.55834106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14562",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14562"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.00473402),
        dec: Angle.Degrees(+50.55924710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33841"},
        {"Hipparcos Number", "HIP 24529"},
        {"Geneva Identification System", "GEN# +1.00033841"},
        {"Smithsonian Astrophysical Observation", "SAO 25097"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.93332376),
        dec: Angle.Degrees(+50.56220610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102223"},
        {"Hipparcos Number", "HIP 57406"},
        {"Geneva Identification System", "GEN# +1.00102223"},
        {"Smithsonian Astrophysical Observation", "SAO 28130"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.53586697),
        dec: Angle.Degrees(+50.56355988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61522"},
        {"Hipparcos Number", "HIP 37535"},
        {"Geneva Identification System", "GEN# +1.00061522"},
        {"Smithsonian Astrophysical Observation", "SAO 26471"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.55305074),
        dec: Angle.Degrees(+50.56614848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204654"},
        {"Hipparcos Number", "HIP 106018"},
        {"Smithsonian Astrophysical Observation", "SAO 33449"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.09669851),
        dec: Angle.Degrees(+50.56706413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81563",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81563"},
    },
    visualMagnitude: 11.88,
    bvColour: 1.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.87488420),
        dec: Angle.Degrees(+50.56860064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 321.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -403.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30145"},
        {"Hipparcos Number", "HIP 22262"},
        {"Geneva Identification System", "GEN# +1.00030145"},
        {"Smithsonian Astrophysical Observation", "SAO 24827"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.89982774),
        dec: Angle.Degrees(+50.56897629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90807"},
        {"Hipparcos Number", "HIP 51434"},
        {"Fundamental Katalog 5th Edition", "FK5 2840"},
        {"Geneva Identification System", "GEN# +1.00090807"},
        {"Smithsonian Astrophysical Observation", "SAO 27665"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.56360548),
        dec: Angle.Degrees(+50.56920938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15138"},
        {"Hipparcos Number", "HIP 11465"},
        {"Geneva Identification System", "GEN# +1.00015138"},
        {"Smithsonian Astrophysical Observation", "SAO 23353"},
        {"Wilson Evans Batten Catalogue", "WEB 2393"},
    },
    visualMagnitude: 6.16,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.96562114),
        dec: Angle.Degrees(+50.57019433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64782",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8843 AB"},
        {"Henry Draper", "HD 115477"},
        {"Hipparcos Number", "HIP 64782"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.15509795),
        dec: Angle.Degrees(+50.57127779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50274"},
        {"Hipparcos Number", "HIP 33264"},
        {"Smithsonian Astrophysical Observation", "SAO 26038"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.80154569),
        dec: Angle.Degrees(+50.57206711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133050"},
        {"Hipparcos Number", "HIP 73450"},
        {"Smithsonian Astrophysical Observation", "SAO 29378"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.14728961),
        dec: Angle.Degrees(+50.57799454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19419"},
        {"Hipparcos Number", "HIP 14647"},
        {"Smithsonian Astrophysical Observation", "SAO 23841"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.32551132),
        dec: Angle.Degrees(+50.58059760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232807"},
        {"Hipparcos Number", "HIP 16642"},
        {"Smithsonian Astrophysical Observation", "SAO 24106"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.53578945),
        dec: Angle.Degrees(+50.58325772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41454"},
        {"Hipparcos Number", "HIP 29080"},
        {"Geneva Identification System", "GEN# +1.00041454"},
        {"Smithsonian Astrophysical Observation", "SAO 25581"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.01815440),
        dec: Angle.Degrees(+50.58328270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6523"},
        {"Hipparcos Number", "HIP 5236"},
        {"Smithsonian Astrophysical Observation", "SAO 22016"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.74339175),
        dec: Angle.Degrees(+50.58608701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191649"},
        {"Hipparcos Number", "HIP 99241"},
        {"Geneva Identification System", "GEN# +1.00191649"},
        {"Smithsonian Astrophysical Observation", "SAO 32310"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.17855815),
        dec: Angle.Degrees(+50.58612905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117281"},
        {"Hipparcos Number", "HIP 65698"},
        {"Geneva Identification System", "GEN# +1.00117281"},
        {"Smithsonian Astrophysical Observation", "SAO 28766"},
        {"Wilson Evans Batten Catalogue", "WEB 11626"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.04952092),
        dec: Angle.Degrees(+50.58718593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222933"},
        {"Hipparcos Number", "HIP 117145"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.23024256),
        dec: Angle.Degrees(+50.58747225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47651",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7490 AB"},
        {"Henry Draper", "HD 83887"},
        {"Hipparcos Number", "HIP 47651"},
        {"Geneva Identification System", "GEN# +1.00083887J"},
        {"Smithsonian Astrophysical Observation", "SAO 27356"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.72513555),
        dec: Angle.Degrees(+50.58839160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63258"},
        {"Hipparcos Number", "HIP 38269"},
        {"Geneva Identification System", "GEN# +1.00063258"},
        {"Smithsonian Astrophysical Observation", "SAO 26530"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.60910898),
        dec: Angle.Degrees(+50.58967308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137718"},
        {"Hipparcos Number", "HIP 75510"},
        {"Geneva Identification System", "GEN# +1.00137718"},
        {"Smithsonian Astrophysical Observation", "SAO 29521"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.38451570),
        dec: Angle.Degrees(+50.59416054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173546"},
        {"Hipparcos Number", "HIP 91819"},
        {"Smithsonian Astrophysical Observation", "SAO 31124"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.81621247),
        dec: Angle.Degrees(+50.60243553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80606"},
        {"Hipparcos Number", "HIP 45982"},
        {"Geneva Identification System", "GEN# +1.00080606"},
        {"Smithsonian Astrophysical Observation", "SAO 27230"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.65635304),
        dec: Angle.Degrees(+50.60370444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80607"},
        {"Hipparcos Number", "HIP 45983"},
        {"Geneva Identification System", "GEN# +1.00080607"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.828,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.66536376),
        dec: Angle.Degrees(+50.60384845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25256"},
        {"Hipparcos Number", "HIP 18904"},
        {"Geneva Identification System", "GEN# +1.00025256"},
        {"Smithsonian Astrophysical Observation", "SAO 24375"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.78401935),
        dec: Angle.Degrees(+50.60485754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42308"},
        {"Hipparcos Number", "HIP 29484"},
        {"Smithsonian Astrophysical Observation", "SAO 25619"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.17884827),
        dec: Angle.Degrees(+50.60503488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32002"},
        {"Hipparcos Number", "HIP 23481"},
        {"Smithsonian Astrophysical Observation", "SAO 24974"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.70242187),
        dec: Angle.Degrees(+50.60566993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156728"},
        {"Hipparcos Number", "HIP 84520"},
        {"Geneva Identification System", "GEN# +1.00156728"},
        {"Smithsonian Astrophysical Observation", "SAO 30320"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.16315457),
        dec: Angle.Degrees(+50.60620367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 111.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93541"},
        {"Hipparcos Number", "HIP 52876"},
        {"Geneva Identification System", "GEN# +1.00093541"},
        {"Smithsonian Astrophysical Observation", "SAO 27774"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.20717428),
        dec: Angle.Degrees(+50.60780221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37076",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6198 AB"},
        {"Henry Draper", "HD 233422"},
        {"Hipparcos Number", "HIP 37076"},
        {"Geneva Identification System", "GEN# +1.00233422"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.28498030),
        dec: Angle.Degrees(+50.60791153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233030"},
        {"Hipparcos Number", "HIP 22755"},
        {"Smithsonian Astrophysical Observation", "SAO 24896"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.42118193),
        dec: Angle.Degrees(+50.60838197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232962"},
        {"Hipparcos Number", "HIP 20950"},
        {"Smithsonian Astrophysical Observation", "SAO 24647"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.38010293),
        dec: Angle.Degrees(+50.60985795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233855"},
        {"Hipparcos Number", "HIP 57156"},
        {"Smithsonian Astrophysical Observation", "SAO 28110"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.82712318),
        dec: Angle.Degrees(+50.61045049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28908"},
        {"Hipparcos Number", "HIP 21417"},
        {"Smithsonian Astrophysical Observation", "SAO 24706"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.94944512),
        dec: Angle.Degrees(+50.61050366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233882"},
        {"Hipparcos Number", "HIP 58245"},
        {"Smithsonian Astrophysical Observation", "SAO 28196"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.18403381),
        dec: Angle.Degrees(+50.61116302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234296"},
        {"Hipparcos Number", "HIP 79805"},
        {"Smithsonian Astrophysical Observation", "SAO 29865"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.31492024),
        dec: Angle.Degrees(+50.61251384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40753"},
        {"Hipparcos Number", "HIP 28701"},
        {"Smithsonian Astrophysical Observation", "SAO 25540"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.92727697),
        dec: Angle.Degrees(+50.61251800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129971"},
        {"Hipparcos Number", "HIP 72021"},
        {"Smithsonian Astrophysical Observation", "SAO 29258"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.96781564),
        dec: Angle.Degrees(+50.61521776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24964",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3904 AB"},
        {"Henry Draper", "HD 34532"},
        {"Hipparcos Number", "HIP 24964"},
        {"Smithsonian Astrophysical Observation", "SAO 25135"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.21024123),
        dec: Angle.Degrees(+50.61581547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112711",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112711"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.37765399),
        dec: Angle.Degrees(+50.61582914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168343"},
        {"Hipparcos Number", "HIP 89556"},
        {"Smithsonian Astrophysical Observation", "SAO 30860"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.11590699),
        dec: Angle.Degrees(+50.61654101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17091"},
        {"Hipparcos Number", "HIP 12937"},
        {"Smithsonian Astrophysical Observation", "SAO 23598"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.59392287),
        dec: Angle.Degrees(+50.61686613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86510"},
        {"Hipparcos Number", "HIP 49040"},
        {"Smithsonian Astrophysical Observation", "SAO 27469"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.08337396),
        dec: Angle.Degrees(+50.61690522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71881"},
        {"Hipparcos Number", "HIP 41844"},
        {"Geneva Identification System", "GEN# +1.00071881"},
        {"Smithsonian Astrophysical Observation", "SAO 26892"},
        {"Wilson Evans Batten Catalogue", "WEB 8055"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.97962433),
        dec: Angle.Degrees(+50.61751642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -338.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235569"},
        {"Hipparcos Number", "HIP 106819"},
        {"Geneva Identification System", "GEN# +1.00235569"},
        {"Smithsonian Astrophysical Observation", "SAO 33609"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.51225521),
        dec: Angle.Degrees(+50.61759239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219290"},
        {"Hipparcos Number", "HIP 114714"},
        {"Geneva Identification System", "GEN# +1.00219290"},
        {"Smithsonian Astrophysical Observation", "SAO 35251"},
        {"Wilson Evans Batten Catalogue", "WEB 20340"},
    },
    visualMagnitude: 6.32,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.55976495),
        dec: Angle.Degrees(+50.61790845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101013"},
        {"Hipparcos Number", "HIP 56731"},
        {"Fundamental Katalog 5th Edition", "FK5 2929"},
        {"Geneva Identification System", "GEN# +1.00101013"},
        {"Smithsonian Astrophysical Observation", "SAO 28081"},
        {"Wilson Evans Batten Catalogue", "WEB 10204"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.47103325),
        dec: Angle.Degrees(+50.61827506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233875"},
        {"Hipparcos Number", "HIP 57873"},
        {"Smithsonian Astrophysical Observation", "SAO 28170"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.04680788),
        dec: Angle.Degrees(+50.61876419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138003"},
        {"Hipparcos Number", "HIP 75641"},
        {"Geneva Identification System", "GEN# +1.00138003"},
        {"Smithsonian Astrophysical Observation", "SAO 29531"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.81225527),
        dec: Angle.Degrees(+50.61955380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48485",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7554 AB"},
        {"Henry Draper", "HD 85439"},
        {"Hipparcos Number", "HIP 48485"},
        {"Geneva Identification System", "GEN# +1.00085439J"},
        {"Smithsonian Astrophysical Observation", "SAO 27416"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.32175764),
        dec: Angle.Degrees(+50.62126150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123898"},
        {"Hipparcos Number", "HIP 69114"},
        {"Geneva Identification System", "GEN# +1.00123898"},
        {"Smithsonian Astrophysical Observation", "SAO 29018"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.21827885),
        dec: Angle.Degrees(+50.62429092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19931",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19931"},
        {"Wilson Evans Batten Catalogue", "WEB 3806"},
    },
    visualMagnitude: 9.73,
    bvColour: 2.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.13828795),
        dec: Angle.Degrees(+50.62629066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44715",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7177 AB"},
        {"Henry Draper", "HD 77801"},
        {"Hipparcos Number", "HIP 44715"},
        {"Smithsonian Astrophysical Observation", "SAO 27124"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.66245844),
        dec: Angle.Degrees(+50.62682525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30254"},
        {"Hipparcos Number", "HIP 22335"},
        {"Smithsonian Astrophysical Observation", "SAO 24846"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.15004734),
        dec: Angle.Degrees(+50.62722133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96321",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12656 AB"},
        {"Henry Draper", "HD 185082"},
        {"Hipparcos Number", "HIP 96321"},
        {"Smithsonian Astrophysical Observation", "SAO 31790"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.76877918),
        dec: Angle.Degrees(+50.62740578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 90.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114417",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114417"},
    },
    visualMagnitude: 10.91,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.58563984),
        dec: Angle.Degrees(+50.62829080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -251.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -319.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235135"},
        {"Hipparcos Number", "HIP 99643"},
        {"Smithsonian Astrophysical Observation", "SAO 32368"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.33238064),
        dec: Angle.Degrees(+50.62983953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3926",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 684 AB"},
        {"Henry Draper", "HD 4777"},
        {"Hipparcos Number", "HIP 3926"},
        {"Geneva Identification System", "GEN# +1.00004777J"},
        {"Smithsonian Astrophysical Observation", "SAO 21759"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.60457440),
        dec: Angle.Degrees(+50.63043283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234575"},
        {"Hipparcos Number", "HIP 89092"},
        {"Smithsonian Astrophysical Observation", "SAO 30791"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.74725572),
        dec: Angle.Degrees(+50.63253517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32088"},
        {"Hipparcos Number", "HIP 23520"},
        {"Smithsonian Astrophysical Observation", "SAO 24981"},
        {"Wilson Evans Batten Catalogue", "WEB 4583"},
    },
    visualMagnitude: 8.43,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.84602234),
        dec: Angle.Degrees(+50.63280814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199020"},
        {"Hipparcos Number", "HIP 103023"},
        {"Smithsonian Astrophysical Observation", "SAO 32950"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.08642672),
        dec: Angle.Degrees(+50.63307433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3923",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 684 C"},
        {"Hipparcos Number", "HIP 3923"},
        {"Smithsonian Astrophysical Observation", "SAO 21758"},
    },
    visualMagnitude: 9.87,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.59465277),
        dec: Angle.Degrees(+50.63367595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16703"},
        {"Hipparcos Number", "HIP 12643"},
        {"Smithsonian Astrophysical Observation", "SAO 23547"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.60749539),
        dec: Angle.Degrees(+50.63627316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25109"},
        {"Hipparcos Number", "HIP 18808"},
        {"Geneva Identification System", "GEN# +1.00025109"},
        {"Smithsonian Astrophysical Observation", "SAO 24353"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.45814905),
        dec: Angle.Degrees(+50.63827144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143595"},
        {"Hipparcos Number", "HIP 78290"},
        {"Smithsonian Astrophysical Observation", "SAO 29739"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.78148858),
        dec: Angle.Degrees(+50.63916715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233821"},
        {"Hipparcos Number", "HIP 55034"},
        {"Geneva Identification System", "GEN# +1.00233821"},
        {"Smithsonian Astrophysical Observation", "SAO 27968"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.99178772),
        dec: Angle.Degrees(+50.64080665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235746"},
        {"Hipparcos Number", "HIP 109520"},
        {"Geneva Identification System", "GEN# +1.00235746"},
        {"Smithsonian Astrophysical Observation", "SAO 34142"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.78802407),
        dec: Angle.Degrees(+50.64154182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131665"},
        {"Hipparcos Number", "HIP 72824"},
        {"Smithsonian Astrophysical Observation", "SAO 29320"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.28233682),
        dec: Angle.Degrees(+50.64295290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12675"},
        {"Hipparcos Number", "HIP 9754"},
        {"Geneva Identification System", "GEN# +1.00012675"},
        {"Smithsonian Astrophysical Observation", "SAO 22914"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.36191712),
        dec: Angle.Degrees(+50.64327437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45753"},
        {"Hipparcos Number", "HIP 31141"},
        {"Geneva Identification System", "GEN# +1.00045753"},
        {"Smithsonian Astrophysical Observation", "SAO 25793"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.00485474),
        dec: Angle.Degrees(+50.64614474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234852"},
        {"Hipparcos Number", "HIP 94743"},
        {"Smithsonian Astrophysical Observation", "SAO 31530"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.18542183),
        dec: Angle.Degrees(+50.64662492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38082"},
        {"Hipparcos Number", "HIP 27190"},
        {"Smithsonian Astrophysical Observation", "SAO 25361"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.45484751),
        dec: Angle.Degrees(+50.64889241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113223",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113223"},
        {"Smithsonian Astrophysical Observation", "SAO 34959"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.93633458),
        dec: Angle.Degrees(+50.65131538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33938",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5697 A"},
        {"Henry Draper", "HD 52098"},
        {"Hipparcos Number", "HIP 33938"},
        {"Geneva Identification System", "GEN# +1.00052098J"},
        {"Smithsonian Astrophysical Observation", "SAO 26113"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.64212207),
        dec: Angle.Degrees(+50.65138900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234530"},
        {"Hipparcos Number", "HIP 88119"},
        {"Smithsonian Astrophysical Observation", "SAO 30677"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.96019107),
        dec: Angle.Degrees(+50.65277346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233114"},
        {"Hipparcos Number", "HIP 25215"},
        {"Smithsonian Astrophysical Observation", "SAO 25170"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.90696709),
        dec: Angle.Degrees(+50.65301367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46385",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46385"},
    },
    visualMagnitude: 11.86,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.87820307),
        dec: Angle.Degrees(+50.65381393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -223.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234201"},
        {"Hipparcos Number", "HIP 73564"},
        {"Smithsonian Astrophysical Observation", "SAO 29387"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.51349320),
        dec: Angle.Degrees(+50.65391041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233564"},
        {"Hipparcos Number", "HIP 42713"},
        {"Smithsonian Astrophysical Observation", "SAO 26969"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.57057047),
        dec: Angle.Degrees(+50.65413603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188169"},
        {"Hipparcos Number", "HIP 97720"},
        {"Geneva Identification System", "GEN# +1.00188169"},
        {"Smithsonian Astrophysical Observation", "SAO 32057"},
        {"Wilson Evans Batten Catalogue", "WEB 17190"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.88706146),
        dec: Angle.Degrees(+50.65416991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4431"},
        {"Hipparcos Number", "HIP 3684"},
        {"Renson", "Renson 1210"},
        {"Smithsonian Astrophysical Observation", "SAO 21701"},
    },
    visualMagnitude: 8.50,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.79720186),
        dec: Angle.Degrees(+50.65463505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234740"},
        {"Hipparcos Number", "HIP 92697"},
        {"Smithsonian Astrophysical Observation", "SAO 31243"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.31775658),
        dec: Angle.Degrees(+50.65611368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189980"},
        {"Hipparcos Number", "HIP 98493"},
        {"Smithsonian Astrophysical Observation", "SAO 32192"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.14213244),
        dec: Angle.Degrees(+50.65634852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235066"},
        {"Hipparcos Number", "HIP 98435"},
        {"Smithsonian Astrophysical Observation", "SAO 32185"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.00712434),
        dec: Angle.Degrees(+50.65856437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98367",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13221 A"},
        {"Henry Draper", "HD 189702"},
        {"Hipparcos Number", "HIP 98367"},
        {"Smithsonian Astrophysical Observation", "SAO 32167"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.77959793),
        dec: Angle.Degrees(+50.66305694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117224",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16980 A"},
        {"Henry Draper", "HD 223046"},
        {"Hipparcos Number", "HIP 117224"},
        {"Smithsonian Astrophysical Observation", "SAO 35742"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.51700802),
        dec: Angle.Degrees(+50.66312029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73132"},
        {"Hipparcos Number", "HIP 42404"},
        {"Geneva Identification System", "GEN# +1.00073132"},
        {"Smithsonian Astrophysical Observation", "SAO 26939"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.69642250),
        dec: Angle.Degrees(+50.66377630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232784"},
        {"Hipparcos Number", "HIP 15798"},
        {"Geneva Identification System", "GEN# +5.20200574"},
        {"Smithsonian Astrophysical Observation", "SAO 24001"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.89625272),
        dec: Angle.Degrees(+50.66460773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221407"},
        {"Hipparcos Number", "HIP 116112"},
        {"Smithsonian Astrophysical Observation", "SAO 35506"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.90438009),
        dec: Angle.Degrees(+50.66548077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72039"},
        {"Hipparcos Number", "HIP 41933"},
        {"Smithsonian Astrophysical Observation", "SAO 26900"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.22775698),
        dec: Angle.Degrees(+50.66566629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65302"},
        {"Hipparcos Number", "HIP 39154"},
        {"Smithsonian Astrophysical Observation", "SAO 26614"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.12129470),
        dec: Angle.Degrees(+50.66596408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9106"},
        {"Hipparcos Number", "HIP 7037"},
        {"Smithsonian Astrophysical Observation", "SAO 22347"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.68508687),
        dec: Angle.Degrees(+50.66602835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234341"},
        {"Hipparcos Number", "HIP 81898"},
        {"Smithsonian Astrophysical Observation", "SAO 30065"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.92692098),
        dec: Angle.Degrees(+50.66604391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71450"},
        {"Hipparcos Number", "HIP 41672"},
        {"Smithsonian Astrophysical Observation", "SAO 26873"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.43875223),
        dec: Angle.Degrees(+50.66655227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203884"},
        {"Hipparcos Number", "HIP 105599"},
        {"Smithsonian Astrophysical Observation", "SAO 33378"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.83259382),
        dec: Angle.Degrees(+50.66779889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160469"},
        {"Hipparcos Number", "HIP 86241"},
        {"Smithsonian Astrophysical Observation", "SAO 30486"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.35448418),
        dec: Angle.Degrees(+50.66858144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81895",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81895"},
    },
    visualMagnitude: 11.67,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.91758443),
        dec: Angle.Degrees(+50.66866136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219599"},
        {"Hipparcos Number", "HIP 114900"},
        {"Smithsonian Astrophysical Observation", "SAO 35280"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.10706443),
        dec: Angle.Degrees(+50.67137145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77188",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9781 AB"},
        {"Henry Draper", "HD 234257"},
        {"Hipparcos Number", "HIP 77188"},
        {"Smithsonian Astrophysical Observation", "SAO 29647"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.41975120),
        dec: Angle.Degrees(+50.67243754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102459",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14273 A"},
        {"Henry Draper", "HD 198039"},
        {"Hipparcos Number", "HIP 102459"},
        {"Geneva Identification System", "GEN# +1.00198039"},
        {"Smithsonian Astrophysical Observation", "SAO 32865"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.42949917),
        dec: Angle.Degrees(+50.67385388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75002"},
        {"Hipparcos Number", "HIP 43311"},
        {"Geneva Identification System", "GEN# +1.00075002"},
        {"Smithsonian Astrophysical Observation", "SAO 27006"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.34952956),
        dec: Angle.Degrees(+50.67386538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49672"},
        {"Hipparcos Number", "HIP 32987"},
        {"Smithsonian Astrophysical Observation", "SAO 26009"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.08350931),
        dec: Angle.Degrees(+50.67398823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207232"},
        {"Hipparcos Number", "HIP 107469"},
        {"Celescope Catalog", "CEL 5381"},
        {"Geneva Identification System", "GEN# +1.00207232"},
        {"Smithsonian Astrophysical Observation", "SAO 33731"},
    },
    visualMagnitude: 7.03,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.51173936),
        dec: Angle.Degrees(+50.67414101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216206"},
        {"Hipparcos Number", "HIP 112761"},
        {"Geneva Identification System", "GEN# +1.00216206"},
        {"Smithsonian Astrophysical Observation", "SAO 34862"},
        {"Wilson Evans Batten Catalogue", "WEB 20091"},
    },
    visualMagnitude: 6.23,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.54204508),
        dec: Angle.Degrees(+50.67691966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159349"},
        {"Hipparcos Number", "HIP 85771"},
        {"Geneva Identification System", "GEN# +1.00159349"},
        {"Smithsonian Astrophysical Observation", "SAO 30437"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.89137028),
        dec: Angle.Degrees(+50.67891864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205808"},
        {"Hipparcos Number", "HIP 106658"},
        {"Celescope Catalog", "CEL 5350"},
        {"Geneva Identification System", "GEN# +1.00205808"},
        {"Smithsonian Astrophysical Observation", "SAO 33568"},
    },
    visualMagnitude: 7.27,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.05552271),
        dec: Angle.Degrees(+50.67908368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79465"},
        {"Hipparcos Number", "HIP 45485"},
        {"Smithsonian Astrophysical Observation", "SAO 27192"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.03134693),
        dec: Angle.Degrees(+50.67983684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70296"},
        {"Hipparcos Number", "HIP 41135"},
        {"Smithsonian Astrophysical Observation", "SAO 26817"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.88346313),
        dec: Angle.Degrees(+50.68267129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235271"},
        {"Hipparcos Number", "HIP 101439"},
        {"Smithsonian Astrophysical Observation", "SAO 32685"},
        {"Wilson Evans Batten Catalogue", "WEB 18328"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.36550253),
        dec: Angle.Degrees(+50.68335865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158096"},
        {"Hipparcos Number", "HIP 85196"},
        {"Geneva Identification System", "GEN# +1.00158096"},
        {"Smithsonian Astrophysical Observation", "SAO 30372"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.15518887),
        dec: Angle.Degrees(+50.68600262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233828"},
        {"Hipparcos Number", "HIP 55498"},
        {"Smithsonian Astrophysical Observation", "SAO 28001"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.48917783),
        dec: Angle.Degrees(+50.68816709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10516"},
        {"Hipparcos Number", "HIP 8068"},
        {"Celescope Catalog", "CEL 161"},
        {"Fundamental Katalog 5th Edition", "FK5 57"},
        {"Geneva Identification System", "GEN# +1.00010516"},
        {"Smithsonian Astrophysical Observation", "SAO 22554"},
        {"Wilson Evans Batten Catalogue", "WEB 1727"},
    },
    visualMagnitude: 4.01,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.91506370),
        dec: Angle.Degrees(+50.68876550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1468"},
        {"Hipparcos Number", "HIP 1524"},
        {"Geneva Identification System", "GEN# +1.00001468"},
        {"Smithsonian Astrophysical Observation", "SAO 21293"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.74420370),
        dec: Angle.Degrees(+50.69401305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153667"},
        {"Hipparcos Number", "HIP 83047"},
        {"Geneva Identification System", "GEN# +1.00153667"},
        {"Smithsonian Astrophysical Observation", "SAO 30181"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.54851741),
        dec: Angle.Degrees(+50.69548575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24546"},
        {"Hipparcos Number", "HIP 18453"},
        {"Geneva Identification System", "GEN# +1.00024546"},
        {"Smithsonian Astrophysical Observation", "SAO 24314"},
        {"Wilson Evans Batten Catalogue", "WEB 3557"},
    },
    visualMagnitude: 5.28,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.15181574),
        dec: Angle.Degrees(+50.69569169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232274"},
        {"Hipparcos Number", "HIP 3710"},
        {"Smithsonian Astrophysical Observation", "SAO 21711"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.91514080),
        dec: Angle.Degrees(+50.69594901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233101"},
        {"Hipparcos Number", "HIP 24805"},
        {"Smithsonian Astrophysical Observation", "SAO 25126"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.76705487),
        dec: Angle.Degrees(+50.69605150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232954"},
        {"Hipparcos Number", "HIP 20768"},
        {"Smithsonian Astrophysical Observation", "SAO 24619"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.74914636),
        dec: Angle.Degrees(+50.69620205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234545"},
        {"Hipparcos Number", "HIP 88411"},
        {"Smithsonian Astrophysical Observation", "SAO 30712"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.77645665),
        dec: Angle.Degrees(+50.69674346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233753"},
        {"Hipparcos Number", "HIP 51962"},
        {"Smithsonian Astrophysical Observation", "SAO 27705"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.22815109),
        dec: Angle.Degrees(+50.69798287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217226"},
        {"Hipparcos Number", "HIP 113449"},
        {"Fundamental Katalog 5th Edition", "FK5 6035"},
        {"Geneva Identification System", "GEN# +1.00217226"},
        {"Smithsonian Astrophysical Observation", "SAO 35010"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.64733995),
        dec: Angle.Degrees(+50.69800598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234867"},
        {"Hipparcos Number", "HIP 94994"},
        {"Smithsonian Astrophysical Observation", "SAO 31573"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.94643863),
        dec: Angle.Degrees(+50.70188829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37723"},
        {"Hipparcos Number", "HIP 26970"},
        {"Smithsonian Astrophysical Observation", "SAO 25342"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.84694990),
        dec: Angle.Degrees(+50.70232094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232844"},
        {"Hipparcos Number", "HIP 17833"},
        {"Smithsonian Astrophysical Observation", "SAO 24243"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.23863623),
        dec: Angle.Degrees(+50.70488902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216500"},
        {"Hipparcos Number", "HIP 112964"},
        {"Smithsonian Astrophysical Observation", "SAO 34909"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.15872940),
        dec: Angle.Degrees(+50.70492907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175535"},
        {"Hipparcos Number", "HIP 92689"},
        {"Geneva Identification System", "GEN# +1.00175535"},
        {"Smithsonian Astrophysical Observation", "SAO 31241"},
        {"Wilson Evans Batten Catalogue", "WEB 16033"},
    },
    visualMagnitude: 4.92,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.30642219),
        dec: Angle.Degrees(+50.70828894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71829"},
        {"Hipparcos Number", "HIP 41836"},
        {"Geneva Identification System", "GEN# +1.00071829"},
        {"Smithsonian Astrophysical Observation", "SAO 26891"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.92926178),
        dec: Angle.Degrees(+50.70893469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233658"},
        {"Hipparcos Number", "HIP 47232"},
        {"Smithsonian Astrophysical Observation", "SAO 27318"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.40740070),
        dec: Angle.Degrees(+50.70981706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6784"},
        {"Hipparcos Number", "HIP 5421"},
        {"Smithsonian Astrophysical Observation", "SAO 22039"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.31908034),
        dec: Angle.Degrees(+50.71284726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124568"},
        {"Hipparcos Number", "HIP 69432"},
        {"Geneva Identification System", "GEN# +1.00124568"},
        {"Smithsonian Astrophysical Observation", "SAO 29041"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.23450178),
        dec: Angle.Degrees(+50.71285236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30189"},
        {"Hipparcos Number", "HIP 22294"},
        {"Geneva Identification System", "GEN# +1.00030189"},
        {"Smithsonian Astrophysical Observation", "SAO 24839"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.01739046),
        dec: Angle.Degrees(+50.71439354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66475",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8979 AB"},
        {"Henry Draper", "HD 118741"},
        {"Hipparcos Number", "HIP 66475"},
        {"Geneva Identification System", "GEN# +1.00118741"},
        {"Smithsonian Astrophysical Observation", "SAO 28819"},
        {"Wilson Evans Batten Catalogue", "WEB 11737"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.42891147),
        dec: Angle.Degrees(+50.71482953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173128"},
        {"Hipparcos Number", "HIP 91627"},
        {"Smithsonian Astrophysical Observation", "SAO 31103"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.29778346),
        dec: Angle.Degrees(+50.71517408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27968"},
        {"Hipparcos Number", "HIP 20803"},
        {"Smithsonian Astrophysical Observation", "SAO 24624"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.86146232),
        dec: Angle.Degrees(+50.71815759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117361"},
        {"Hipparcos Number", "HIP 65754"},
        {"Geneva Identification System", "GEN# +1.00117361"},
        {"Renson", "Renson 33850"},
        {"Smithsonian Astrophysical Observation", "SAO 28771"},
        {"Wilson Evans Batten Catalogue", "WEB 11638"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.19081880),
        dec: Angle.Degrees(+50.71875065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179617"},
        {"Hipparcos Number", "HIP 94218"},
        {"Geneva Identification System", "GEN# +1.00179617"},
        {"Smithsonian Astrophysical Observation", "SAO 31444"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.70505586),
        dec: Angle.Degrees(+50.72012770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135075"},
        {"Hipparcos Number", "HIP 74303"},
        {"Geneva Identification System", "GEN# +1.00135075"},
        {"Smithsonian Astrophysical Observation", "SAO 29435"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.81160670),
        dec: Angle.Degrees(+50.72025617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235286"},
        {"Hipparcos Number", "HIP 101633"},
        {"Smithsonian Astrophysical Observation", "SAO 32721"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.99379040),
        dec: Angle.Degrees(+50.72053219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235471"},
        {"Hipparcos Number", "HIP 105012"},
        {"Smithsonian Astrophysical Observation", "SAO 33268"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.04667458),
        dec: Angle.Degrees(+50.72376963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37976"},
        {"Hipparcos Number", "HIP 27126"},
        {"Smithsonian Astrophysical Observation", "SAO 25353"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.28465570),
        dec: Angle.Degrees(+50.72503556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113271",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113271"},
        {"Smithsonian Astrophysical Observation", "SAO 34968"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.04957976),
        dec: Angle.Degrees(+50.72643416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217087"},
        {"Hipparcos Number", "HIP 113347"},
        {"Smithsonian Astrophysical Observation", "SAO 34994"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.32368312),
        dec: Angle.Degrees(+50.72689687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233833"},
        {"Hipparcos Number", "HIP 56032"},
        {"Smithsonian Astrophysical Observation", "SAO 28030"},
    },
    visualMagnitude: 10.35,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.25947660),
        dec: Angle.Degrees(+50.72745819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16966"},
        {"Hipparcos Number", "HIP 12831"},
        {"Smithsonian Astrophysical Observation", "SAO 23586"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.23863438),
        dec: Angle.Degrees(+50.72751996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2055"},
        {"Hipparcos Number", "HIP 1979"},
        {"Geneva Identification System", "GEN# +1.00002055"},
        {"Smithsonian Astrophysical Observation", "SAO 21380"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.26959214),
        dec: Angle.Degrees(+50.72810475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232871"},
        {"Hipparcos Number", "HIP 18794"},
        {"Smithsonian Astrophysical Observation", "SAO 24352"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.40229167),
        dec: Angle.Degrees(+50.72813448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103359",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14460 A"},
        {"Henry Draper", "HD 199611"},
        {"Hipparcos Number", "HIP 103359"},
        {"Fundamental Katalog 5th Edition", "FK5 3670"},
        {"Geneva Identification System", "GEN# +1.00199611"},
        {"Smithsonian Astrophysical Observation", "SAO 33004"},
        {"Wilson Evans Batten Catalogue", "WEB 18790"},
    },
    visualMagnitude: 5.83,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.10599985),
        dec: Angle.Degrees(+50.72864966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184447"},
        {"Hipparcos Number", "HIP 96076"},
        {"Smithsonian Astrophysical Observation", "SAO 31753"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.00920441),
        dec: Angle.Degrees(+50.72904859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233050"},
        {"Hipparcos Number", "HIP 23389"},
        {"Smithsonian Astrophysical Observation", "SAO 24961"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.41809004),
        dec: Angle.Degrees(+50.73306938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145531"},
        {"Hipparcos Number", "HIP 79131"},
        {"Geneva Identification System", "GEN# +1.00145531"},
        {"Smithsonian Astrophysical Observation", "SAO 29818"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.27957714),
        dec: Angle.Degrees(+50.73324079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10498",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1724 AB"},
        {"Henry Draper", "HD 232624"},
        {"Hipparcos Number", "HIP 10498"},
        {"Smithsonian Astrophysical Observation", "SAO 23092"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.83816347),
        dec: Angle.Degrees(+50.73404223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39222"},
        {"Hipparcos Number", "HIP 27871"},
        {"Smithsonian Astrophysical Observation", "SAO 25441"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.46681537),
        dec: Angle.Degrees(+50.73521025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17772",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2769 A"},
        {"Henry Draper", "HD 23552"},
        {"Hipparcos Number", "HIP 17772"},
        {"Geneva Identification System", "GEN# +1.00023552J"},
        {"Smithsonian Astrophysical Observation", "SAO 24231"},
        {"Wilson Evans Batten Catalogue", "WEB 3402"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.07533696),
        dec: Angle.Degrees(+50.73677203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183584"},
        {"Hipparcos Number", "HIP 95691"},
        {"Smithsonian Astrophysical Observation", "SAO 31679"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.95402856),
        dec: Angle.Degrees(+50.73700620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219511"},
        {"Hipparcos Number", "HIP 114836"},
        {"Smithsonian Astrophysical Observation", "SAO 35268"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.92208627),
        dec: Angle.Degrees(+50.73751489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126913"},
        {"Hipparcos Number", "HIP 70622"},
        {"Smithsonian Astrophysical Observation", "SAO 29146"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.69953911),
        dec: Angle.Degrees(+50.73912255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56375",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56375"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.34049032),
        dec: Angle.Degrees(+50.74133982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44210"},
        {"Hipparcos Number", "HIP 30385"},
        {"Geneva Identification System", "GEN# +1.00044210"},
        {"Smithsonian Astrophysical Observation", "SAO 25697"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.83731871),
        dec: Angle.Degrees(+50.74160487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76290"},
        {"Hipparcos Number", "HIP 43962"},
        {"Smithsonian Astrophysical Observation", "SAO 27058"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.29917881),
        dec: Angle.Degrees(+50.74182248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233468"},
        {"Hipparcos Number", "HIP 38616"},
        {"Smithsonian Astrophysical Observation", "SAO 26564"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.61138911),
        dec: Angle.Degrees(+50.74353907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25224",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25224"},
    },
    visualMagnitude: 11.76,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.92696422),
        dec: Angle.Degrees(+50.74800506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 154.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -201.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55229",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55229"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.65369613),
        dec: Angle.Degrees(+50.74875626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233393"},
        {"Hipparcos Number", "HIP 36358"},
        {"Smithsonian Astrophysical Observation", "SAO 26363"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.26240044),
        dec: Angle.Degrees(+50.74983499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232158"},
        {"Hipparcos Number", "HIP 1583"},
        {"Geneva Identification System", "GEN# +1.00232158"},
        {"Smithsonian Astrophysical Observation", "SAO 21303"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.95527491),
        dec: Angle.Degrees(+50.75017949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233745"},
        {"Hipparcos Number", "HIP 51708"},
        {"Geneva Identification System", "GEN# +1.00233745"},
        {"Smithsonian Astrophysical Observation", "SAO 27684"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.47672067),
        dec: Angle.Degrees(+50.75066579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10843"},
        {"Hipparcos Number", "HIP 8333"},
        {"Smithsonian Astrophysical Observation", "SAO 22626"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.86902361),
        dec: Angle.Degrees(+50.75095817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235542"},
        {"Hipparcos Number", "HIP 106476"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.48091925),
        dec: Angle.Degrees(+50.75110594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223359"},
        {"Hipparcos Number", "HIP 117437"},
        {"Smithsonian Astrophysical Observation", "SAO 35790"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.18750150),
        dec: Angle.Degrees(+50.75254313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234076"},
        {"Hipparcos Number", "HIP 67603"},
        {"Smithsonian Astrophysical Observation", "SAO 28904"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.77953914),
        dec: Angle.Degrees(+50.75336966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41519"},
        {"Hipparcos Number", "HIP 29113"},
        {"Smithsonian Astrophysical Observation", "SAO 25584"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.08959887),
        dec: Angle.Degrees(+50.75445060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -216.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148017"},
        {"Hipparcos Number", "HIP 80236"},
        {"Geneva Identification System", "GEN# +1.00148017"},
        {"Smithsonian Astrophysical Observation", "SAO 29920"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.71498897),
        dec: Angle.Degrees(+50.75707837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25515"},
        {"Hipparcos Number", "HIP 19094"},
        {"Geneva Identification System", "GEN# +1.00025515"},
        {"Renson", "Renson 6520"},
        {"Smithsonian Astrophysical Observation", "SAO 24404"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.40409286),
        dec: Angle.Degrees(+50.75948261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16300"},
        {"Hipparcos Number", "HIP 12330"},
        {"Smithsonian Astrophysical Observation", "SAO 23495"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.70067599),
        dec: Angle.Degrees(+50.76172863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235355"},
        {"Hipparcos Number", "HIP 102469"},
        {"Smithsonian Astrophysical Observation", "SAO 32867"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.45795417),
        dec: Angle.Degrees(+50.76205576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148963"},
        {"Hipparcos Number", "HIP 80743"},
        {"Geneva Identification System", "GEN# +1.00148963"},
        {"Smithsonian Astrophysical Observation", "SAO 29961"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.27910456),
        dec: Angle.Degrees(+50.76640309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198344"},
        {"Hipparcos Number", "HIP 102615"},
        {"Geneva Identification System", "GEN# +1.00198344"},
        {"Smithsonian Astrophysical Observation", "SAO 32893"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.91582159),
        dec: Angle.Degrees(+50.76744921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32809"},
        {"Hipparcos Number", "HIP 23925"},
        {"Smithsonian Astrophysical Observation", "SAO 25044"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.12301681),
        dec: Angle.Degrees(+50.76797652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218925"},
        {"Hipparcos Number", "HIP 114501"},
        {"Geneva Identification System", "GEN# +1.00218925"},
        {"Renson", "Renson 60210"},
        {"Smithsonian Astrophysical Observation", "SAO 35210"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.84796576),
        dec: Angle.Degrees(+50.77132645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187055"},
        {"Hipparcos Number", "HIP 97219"},
        {"Cincinnati Publication", "Ci 20 1166"},
        {"Geneva Identification System", "GEN# +1.00187055"},
        {"Smithsonian Astrophysical Observation", "SAO 31959"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.37539384),
        dec: Angle.Degrees(+50.77189993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 266.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 343.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152551"},
        {"Hipparcos Number", "HIP 82478"},
        {"Geneva Identification System", "GEN# +1.00152551"},
        {"Smithsonian Astrophysical Observation", "SAO 30125"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.84769589),
        dec: Angle.Degrees(+50.77297224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97723",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13049 AB"},
        {"Henry Draper", "HD 188168"},
        {"Hipparcos Number", "HIP 97723"},
        {"Smithsonian Astrophysical Observation", "SAO 32058"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.88993037),
        dec: Angle.Degrees(+50.77340638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215241"},
        {"Hipparcos Number", "HIP 112133"},
        {"Geneva Identification System", "GEN# +1.00215241"},
        {"Smithsonian Astrophysical Observation", "SAO 34724"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.71366581),
        dec: Angle.Degrees(+50.77386552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75115",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75115"},
        {"Smithsonian Astrophysical Observation", "SAO 29491"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.24521086),
        dec: Angle.Degrees(+50.77449085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233281"},
        {"Hipparcos Number", "HIP 32499"},
        {"Smithsonian Astrophysical Observation", "SAO 25955"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.73720687),
        dec: Angle.Degrees(+50.77459530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4924"},
        {"Hipparcos Number", "HIP 4051"},
        {"Geneva Identification System", "GEN# +1.00004924"},
        {"Smithsonian Astrophysical Observation", "SAO 21780"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.97698575),
        dec: Angle.Degrees(+50.77467808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109345",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15677 AB"},
        {"Henry Draper", "HD 210415"},
        {"Hipparcos Number", "HIP 109345"},
        {"Geneva Identification System", "GEN# +1.00210415J"},
        {"Smithsonian Astrophysical Observation", "SAO 34107"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.27495804),
        dec: Angle.Degrees(+50.77576827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42615"},
        {"Hipparcos Number", "HIP 29623"},
        {"Smithsonian Astrophysical Observation", "SAO 25634"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.63320597),
        dec: Angle.Degrees(+50.77649625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39017"},
        {"Hipparcos Number", "HIP 27763"},
        {"Geneva Identification System", "GEN# +1.00039017"},
        {"Smithsonian Astrophysical Observation", "SAO 25427"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.12755040),
        dec: Angle.Degrees(+50.77699135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221232"},
        {"Hipparcos Number", "HIP 115980"},
        {"Geneva Identification System", "GEN# +1.00221232"},
        {"Smithsonian Astrophysical Observation", "SAO 35475"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.47312488),
        dec: Angle.Degrees(+50.77747155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232570"},
        {"Hipparcos Number", "HIP 9093"},
        {"Smithsonian Astrophysical Observation", "SAO 22782"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.28452396),
        dec: Angle.Degrees(+50.77972122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235555"},
        {"Hipparcos Number", "HIP 106626"},
        {"Celescope Catalog", "CEL 5347"},
        {"Geneva Identification System", "GEN# +1.00235555"},
        {"Smithsonian Astrophysical Observation", "SAO 33559"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.95908651),
        dec: Angle.Degrees(+50.78015783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12753",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12753"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.97947159),
        dec: Angle.Degrees(+50.78030061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162579"},
        {"Hipparcos Number", "HIP 87212"},
        {"Fundamental Katalog 5th Edition", "FK5 3416"},
        {"Geneva Identification System", "GEN# +1.00162579"},
        {"Renson", "Renson 45880"},
        {"Smithsonian Astrophysical Observation", "SAO 30591"},
        {"Wilson Evans Batten Catalogue", "WEB 14714"},
    },
    visualMagnitude: 5.02,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.26805764),
        dec: Angle.Degrees(+50.78054478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 218.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234071"},
        {"Hipparcos Number", "HIP 67258"},
        {"Smithsonian Astrophysical Observation", "SAO 28887"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.78945634),
        dec: Angle.Degrees(+50.78168130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186942"},
        {"Hipparcos Number", "HIP 97153"},
        {"Smithsonian Astrophysical Observation", "SAO 31953"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.21113432),
        dec: Angle.Degrees(+50.78285261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198611"},
        {"Hipparcos Number", "HIP 102796"},
        {"Smithsonian Astrophysical Observation", "SAO 32919"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.38794782),
        dec: Angle.Degrees(+50.78322735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211834"},
        {"Hipparcos Number", "HIP 110162"},
        {"Smithsonian Astrophysical Observation", "SAO 34300"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.70823657),
        dec: Angle.Degrees(+50.78351922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232687"},
        {"Hipparcos Number", "HIP 12371"},
        {"Smithsonian Astrophysical Observation", "SAO 23499"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.80990759),
        dec: Angle.Degrees(+50.78382236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24037"},
        {"Hipparcos Number", "HIP 18100"},
        {"Smithsonian Astrophysical Observation", "SAO 24267"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.02913200),
        dec: Angle.Degrees(+50.78412600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200925"},
        {"Hipparcos Number", "HIP 104029"},
        {"Geneva Identification System", "GEN# +1.00200925"},
        {"Smithsonian Astrophysical Observation", "SAO 33108"},
        {"Wilson Evans Batten Catalogue", "WEB 18950"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.13718124),
        dec: Angle.Degrees(+50.78425651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68702"},
        {"Hipparcos Number", "HIP 40477"},
        {"Geneva Identification System", "GEN# +1.00068702"},
        {"Smithsonian Astrophysical Observation", "SAO 26743"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.97040782),
        dec: Angle.Degrees(+50.78571507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78233"},
        {"Hipparcos Number", "HIP 44907"},
        {"Cincinnati Publication", "Ci 20 510"},
        {"Cincinnati Publication 2", "Ci 18 1077"},
        {"Geneva Identification System", "GEN# +1.00078233"},
        {"Smithsonian Astrophysical Observation", "SAO 27137"},
        {"Wilson Evans Batten Catalogue", "WEB 8577"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.22588231),
        dec: Angle.Degrees(+50.78587073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -187.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -372.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236152"},
        {"Hipparcos Number", "HIP 116080"},
        {"Smithsonian Astrophysical Observation", "SAO 35499"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.82915824),
        dec: Angle.Degrees(+50.78616689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234682"},
        {"Hipparcos Number", "HIP 91208"},
        {"Smithsonian Astrophysical Observation", "SAO 31068"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.08809189),
        dec: Angle.Degrees(+50.78643812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223071"},
        {"Hipparcos Number", "HIP 117231"},
        {"Geneva Identification System", "GEN# +1.00223071"},
        {"Smithsonian Astrophysical Observation", "SAO 35746"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.55113235),
        dec: Angle.Degrees(+50.78663920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30698"},
        {"Hipparcos Number", "HIP 22659"},
        {"Geneva Identification System", "GEN# +1.00030698"},
        {"Smithsonian Astrophysical Observation", "SAO 24888"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.10749029),
        dec: Angle.Degrees(+50.78951336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236267"},
        {"Hipparcos Number", "HIP 15"},
        {"Smithsonian Astrophysical Observation", "SAO 35975"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.05030890),
        dec: Angle.Degrees(+50.79117384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169777"},
        {"Hipparcos Number", "HIP 90132"},
        {"Smithsonian Astrophysical Observation", "SAO 30941"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.89920777),
        dec: Angle.Degrees(+50.79154143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167105"},
        {"Hipparcos Number", "HIP 89102"},
        {"Geneva Identification System", "GEN# +1.00167105"},
        {"Smithsonian Astrophysical Observation", "SAO 30793"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.77652666),
        dec: Angle.Degrees(+50.79252214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11291"},
        {"Hipparcos Number", "HIP 8714"},
        {"Celescope Catalog", "CEL 176"},
        {"Fundamental Katalog 5th Edition", "FK5 1052"},
        {"Geneva Identification System", "GEN# +1.00011291"},
        {"Renson", "Renson 2790"},
        {"Smithsonian Astrophysical Observation", "SAO 22696"},
        {"Wilson Evans Batten Catalogue", "WEB 1837"},
    },
    visualMagnitude: 5.70,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.03897527),
        dec: Angle.Degrees(+50.79286359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194445"},
        {"Hipparcos Number", "HIP 100561"},
        {"Geneva Identification System", "GEN# +1.00194445"},
        {"Smithsonian Astrophysical Observation", "SAO 32521"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.86545968),
        dec: Angle.Degrees(+50.79390565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15950",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15950"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.34436193),
        dec: Angle.Degrees(+50.79431200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18154"},
        {"Hipparcos Number", "HIP 13730"},
        {"Smithsonian Astrophysical Observation", "SAO 23720"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.20510238),
        dec: Angle.Degrees(+50.79672309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92668"},
        {"Hipparcos Number", "HIP 52413"},
        {"Smithsonian Astrophysical Observation", "SAO 27744"},
        {"Wilson Evans Batten Catalogue", "WEB 9540"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.71762954),
        dec: Angle.Degrees(+50.79924632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234548"},
        {"Hipparcos Number", "HIP 88505"},
        {"Smithsonian Astrophysical Observation", "SAO 30726"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.09082942),
        dec: Angle.Degrees(+50.79984341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141373"},
        {"Hipparcos Number", "HIP 77263"},
        {"Smithsonian Astrophysical Observation", "SAO 29653"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.61753247),
        dec: Angle.Degrees(+50.79994904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63198",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63198"},
    },
    visualMagnitude: 10.26,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.21648243),
        dec: Angle.Degrees(+50.80073441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200739"},
        {"Hipparcos Number", "HIP 103918"},
        {"Geneva Identification System", "GEN# +1.00200739"},
        {"Renson", "Renson 55960"},
        {"Smithsonian Astrophysical Observation", "SAO 33090"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.83166543),
        dec: Angle.Degrees(+50.80192607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233986"},
        {"Hipparcos Number", "HIP 62696"},
        {"Smithsonian Astrophysical Observation", "SAO 28535"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.70481411),
        dec: Angle.Degrees(+50.80193090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210645"},
        {"Hipparcos Number", "HIP 109459"},
        {"Celescope Catalog", "CEL 5446"},
        {"Geneva Identification System", "GEN# +1.00210645"},
        {"Smithsonian Astrophysical Observation", "SAO 34131"},
    },
    visualMagnitude: 8.28,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.63152630),
        dec: Angle.Degrees(+50.80300599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8440"},
        {"Hipparcos Number", "HIP 6579"},
        {"Smithsonian Astrophysical Observation", "SAO 22254"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.13266329),
        dec: Angle.Degrees(+50.80331344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37839"},
        {"Hipparcos Number", "HIP 27049"},
        {"Smithsonian Astrophysical Observation", "SAO 25346"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.03844472),
        dec: Angle.Degrees(+50.80333488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232419"},
        {"Hipparcos Number", "HIP 6180"},
        {"Smithsonian Astrophysical Observation", "SAO 22181"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.82232277),
        dec: Angle.Degrees(+50.80431683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119198"},
        {"Hipparcos Number", "HIP 66734"},
        {"Smithsonian Astrophysical Observation", "SAO 28840"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.17713407),
        dec: Angle.Degrees(+50.80527906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133070"},
        {"Hipparcos Number", "HIP 73452"},
        {"Geneva Identification System", "GEN# +1.00133070"},
        {"Smithsonian Astrophysical Observation", "SAO 29379"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.15498854),
        dec: Angle.Degrees(+50.80542823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143742"},
        {"Hipparcos Number", "HIP 78366"},
        {"Smithsonian Astrophysical Observation", "SAO 29743"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.99097903),
        dec: Angle.Degrees(+50.80578093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232119"},
        {"Hipparcos Number", "HIP 825"},
        {"Smithsonian Astrophysical Observation", "SAO 21153"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.52776652),
        dec: Angle.Degrees(+50.80683530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176707"},
        {"Hipparcos Number", "HIP 93197"},
        {"Geneva Identification System", "GEN# +1.00176707"},
        {"Smithsonian Astrophysical Observation", "SAO 31304"},
        {"Wilson Evans Batten Catalogue", "WEB 16156"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.74748756),
        dec: Angle.Degrees(+50.80912581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110042",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15813 AB"},
        {"Henry Draper", "HD 211644"},
        {"Hipparcos Number", "HIP 110042"},
        {"Smithsonian Astrophysical Observation", "SAO 34274"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.33433965),
        dec: Angle.Degrees(+50.80926281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235940"},
        {"Hipparcos Number", "HIP 112244"},
        {"Smithsonian Astrophysical Observation", "SAO 34739"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.02370802),
        dec: Angle.Degrees(+50.80998406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51185"},
        {"Hipparcos Number", "HIP 33617"},
        {"Smithsonian Astrophysical Observation", "SAO 26079"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.77057583),
        dec: Angle.Degrees(+50.81098675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151444"},
        {"Hipparcos Number", "HIP 81986"},
        {"Smithsonian Astrophysical Observation", "SAO 30073"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.22427348),
        dec: Angle.Degrees(+50.81205183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234689"},
        {"Hipparcos Number", "HIP 91585"},
        {"Smithsonian Astrophysical Observation", "SAO 31098"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.15162906),
        dec: Angle.Degrees(+50.81395749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235197"},
        {"Hipparcos Number", "HIP 100392"},
        {"Smithsonian Astrophysical Observation", "SAO 32501"},
        {"Wilson Evans Batten Catalogue", "WEB 18120"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.38582740),
        dec: Angle.Degrees(+50.81491781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64481",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64481"},
    },
    visualMagnitude: 11.25,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.25054765),
        dec: Angle.Degrees(+50.81547332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 95.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17582"},
        {"Hipparcos Number", "HIP 13298"},
        {"Smithsonian Astrophysical Observation", "SAO 23657"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.78891196),
        dec: Angle.Degrees(+50.81803932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30660"},
        {"Hipparcos Number", "HIP 22637"},
        {"Smithsonian Astrophysical Observation", "SAO 24884"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.05357524),
        dec: Angle.Degrees(+50.81975574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143873"},
        {"Hipparcos Number", "HIP 78421"},
        {"Geneva Identification System", "GEN# +1.00143873"},
        {"Smithsonian Astrophysical Observation", "SAO 29749"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.14647657),
        dec: Angle.Degrees(+50.81980777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97997",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13135 AB"},
        {"Henry Draper", "HD 188871"},
        {"Hipparcos Number", "HIP 97997"},
        {"Smithsonian Astrophysical Observation", "SAO 32104"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.73413748),
        dec: Angle.Degrees(+50.81996536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54245",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8053 AB"},
        {"Henry Draper", "HD 233803"},
        {"Hipparcos Number", "HIP 54245"},
        {"Geneva Identification System", "GEN# +1.00233803J"},
        {"Smithsonian Astrophysical Observation", "SAO 27899"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.46415476),
        dec: Angle.Degrees(+50.82025771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64128",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64128"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.15218320),
        dec: Angle.Degrees(+50.82100176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87852"},
        {"Hipparcos Number", "HIP 49727"},
        {"Geneva Identification System", "GEN# +1.00087852"},
        {"Smithsonian Astrophysical Observation", "SAO 27536"},
        {"Wilson Evans Batten Catalogue", "WEB 9167"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.28449154),
        dec: Angle.Degrees(+50.82130189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22718"},
        {"Hipparcos Number", "HIP 17231"},
        {"Geneva Identification System", "GEN# +5.20201343"},
        {"Smithsonian Astrophysical Observation", "SAO 24160"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.35702594),
        dec: Angle.Degrees(+50.82142447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166207"},
        {"Hipparcos Number", "HIP 88732"},
        {"Fundamental Katalog 5th Edition", "FK5 3441"},
        {"Geneva Identification System", "GEN# +1.00166207"},
        {"Smithsonian Astrophysical Observation", "SAO 30751"},
        {"Wilson Evans Batten Catalogue", "WEB 15033"},
    },
    visualMagnitude: 6.31,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.72280287),
        dec: Angle.Degrees(+50.82259866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 92.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109521",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15708 A"},
        {"Henry Draper", "HD 210715"},
        {"Hipparcos Number", "HIP 109521"},
        {"Celescope Catalog", "CEL 5450"},
        {"Fundamental Katalog 5th Edition", "FK5 3774"},
        {"Geneva Identification System", "GEN# +1.00210715"},
        {"Smithsonian Astrophysical Observation", "SAO 34143"},
        {"Wilson Evans Batten Catalogue", "WEB 19678"},
    },
    visualMagnitude: 5.38,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.79073322),
        dec: Angle.Degrees(+50.82328938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 126.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7495",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1252 AB"},
        {"Hipparcos Number", "HIP 7495"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.12469747),
        dec: Angle.Degrees(+50.82393092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77570"},
        {"Hipparcos Number", "HIP 44607"},
        {"Geneva Identification System", "GEN# +1.00077570"},
        {"Smithsonian Astrophysical Observation", "SAO 27111"},
        {"Wilson Evans Batten Catalogue", "WEB 8535"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.32853427),
        dec: Angle.Degrees(+50.82395685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232459"},
        {"Hipparcos Number", "HIP 7179"},
        {"Fundamental Katalog 5th Edition", "FK5 4138"},
        {"Geneva Identification System", "GEN# +1.00232459"},
        {"Smithsonian Astrophysical Observation", "SAO 22373"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.13133192),
        dec: Angle.Degrees(+50.82419927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235518"},
        {"Hipparcos Number", "HIP 106042"},
        {"Geneva Identification System", "GEN# +1.00235518"},
        {"Smithsonian Astrophysical Observation", "SAO 33453"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.18405181),
        dec: Angle.Degrees(+50.82588990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219710"},
        {"Hipparcos Number", "HIP 114992"},
        {"Smithsonian Astrophysical Observation", "SAO 35297"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.35213975),
        dec: Angle.Degrees(+50.82703600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233569"},
        {"Hipparcos Number", "HIP 42990"},
        {"Smithsonian Astrophysical Observation", "SAO 26987"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.43759340),
        dec: Angle.Degrees(+50.82790830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234150"},
        {"Hipparcos Number", "HIP 71107"},
        {"Smithsonian Astrophysical Observation", "SAO 29189"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.12736929),
        dec: Angle.Degrees(+50.82806256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150509"},
        {"Hipparcos Number", "HIP 81516"},
        {"Geneva Identification System", "GEN# +1.00150509"},
        {"Smithsonian Astrophysical Observation", "SAO 30032"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.75778522),
        dec: Angle.Degrees(+50.82973868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224648"},
        {"Hipparcos Number", "HIP 118289"},
        {"Geneva Identification System", "GEN# +1.00224648"},
        {"Smithsonian Astrophysical Observation", "SAO 35963"},
    },
    visualMagnitude: 7.19,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.88698694),
        dec: Angle.Degrees(+50.83257994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115300"},
        {"Hipparcos Number", "HIP 64689"},
        {"Geneva Identification System", "GEN# +1.00115300"},
        {"Smithsonian Astrophysical Observation", "SAO 28694"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.87858138),
        dec: Angle.Degrees(+50.83269783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209076"},
        {"Hipparcos Number", "HIP 108537"},
        {"Smithsonian Astrophysical Observation", "SAO 33938"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.81464489),
        dec: Angle.Degrees(+50.83446837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142264"},
        {"Hipparcos Number", "HIP 77659"},
        {"Smithsonian Astrophysical Observation", "SAO 29692"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.81488549),
        dec: Angle.Degrees(+50.83608100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224456"},
        {"Hipparcos Number", "HIP 118158"},
        {"Smithsonian Astrophysical Observation", "SAO 35933"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.51826542),
        dec: Angle.Degrees(+50.83679441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59454",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8454 A"},
        {"Henry Draper", "HD 105980"},
        {"Hipparcos Number", "HIP 59454"},
        {"Geneva Identification System", "GEN# +1.00105980"},
        {"Smithsonian Astrophysical Observation", "SAO 28290"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.92398949),
        dec: Angle.Degrees(+50.83772068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203609"},
        {"Hipparcos Number", "HIP 105459"},
        {"Celescope Catalog", "CEL 5300"},
        {"Geneva Identification System", "GEN# +1.00203609"},
        {"Smithsonian Astrophysical Observation", "SAO 33352"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.41545259),
        dec: Angle.Degrees(+50.83778687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235259"},
        {"Hipparcos Number", "HIP 101203"},
        {"Smithsonian Astrophysical Observation", "SAO 32644"},
        {"Wilson Evans Batten Catalogue", "WEB 18279"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.70854857),
        dec: Angle.Degrees(+50.83901707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23623"},
        {"Hipparcos Number", "HIP 17827"},
        {"Geneva Identification System", "GEN# +1.00023623"},
        {"Smithsonian Astrophysical Observation", "SAO 24241"},
        {"Wilson Evans Batten Catalogue", "WEB 3422"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.22573175),
        dec: Angle.Degrees(+50.84046300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61673",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61673"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.63663417),
        dec: Angle.Degrees(+50.84174845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83857",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10369 A"},
        {"Henry Draper", "HD 155328"},
        {"Hipparcos Number", "HIP 83857"},
        {"Geneva Identification System", "GEN# +1.00155328"},
        {"Renson", "Renson 43900"},
        {"Smithsonian Astrophysical Observation", "SAO 30262"},
        {"Wilson Evans Batten Catalogue", "WEB 14173"},
    },
    visualMagnitude: 6.46,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.07117476),
        dec: Angle.Degrees(+50.84220964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232126"},
        {"Hipparcos Number", "HIP 917"},
        {"Smithsonian Astrophysical Observation", "SAO 21182"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.84058595),
        dec: Angle.Degrees(+50.84310466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27673"},
        {"Hipparcos Number", "HIP 20586"},
        {"Geneva Identification System", "GEN# +1.00027673"},
        {"Smithsonian Astrophysical Observation", "SAO 24589"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.13662461),
        dec: Angle.Degrees(+50.84533116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232945"},
        {"Hipparcos Number", "HIP 20609"},
        {"Smithsonian Astrophysical Observation", "SAO 24595"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.819,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.21675484),
        dec: Angle.Degrees(+50.84542643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235674"},
        {"Hipparcos Number", "HIP 108434"},
        {"Smithsonian Astrophysical Observation", "SAO 33916"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.48384429),
        dec: Angle.Degrees(+50.84549056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 271.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235672"},
        {"Hipparcos Number", "HIP 108394"},
        {"Smithsonian Astrophysical Observation", "SAO 33907"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.40423745),
        dec: Angle.Degrees(+50.84550642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21117"},
        {"Hipparcos Number", "HIP 16047"},
        {"Geneva Identification System", "GEN# +5.20200703"},
        {"Smithsonian Astrophysical Observation", "SAO 24036"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.66428982),
        dec: Angle.Degrees(+50.84656313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202381"},
        {"Hipparcos Number", "HIP 104778"},
        {"Geneva Identification System", "GEN# +1.00202381"},
        {"Smithsonian Astrophysical Observation", "SAO 33239"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.39351762),
        dec: Angle.Degrees(+50.84782839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232563"},
        {"Hipparcos Number", "HIP 8925"},
        {"Smithsonian Astrophysical Observation", "SAO 22745"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.73100506),
        dec: Angle.Degrees(+50.84800891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62156"},
        {"Hipparcos Number", "HIP 37804"},
        {"Geneva Identification System", "GEN# +1.00062156"},
        {"Smithsonian Astrophysical Observation", "SAO 26493"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.27462179),
        dec: Angle.Degrees(+50.84817276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234896"},
        {"Hipparcos Number", "HIP 95637"},
        {"Smithsonian Astrophysical Observation", "SAO 31669"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.80723750),
        dec: Angle.Degrees(+50.84901793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157540"},
        {"Hipparcos Number", "HIP 84917"},
        {"Geneva Identification System", "GEN# +1.00157540"},
        {"Smithsonian Astrophysical Observation", "SAO 30352"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.30601071),
        dec: Angle.Degrees(+50.84909297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217694"},
        {"Hipparcos Number", "HIP 113714"},
        {"Smithsonian Astrophysical Observation", "SAO 35070"},
        {"Wilson Evans Batten Catalogue", "WEB 20205"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.45336203),
        dec: Angle.Degrees(+50.85007026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183203"},
        {"Hipparcos Number", "HIP 95524"},
        {"Geneva Identification System", "GEN# +1.00183203"},
        {"Smithsonian Astrophysical Observation", "SAO 31649"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.45652551),
        dec: Angle.Degrees(+50.85180121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132466"},
        {"Hipparcos Number", "HIP 73188"},
        {"Geneva Identification System", "GEN# +1.00132466"},
        {"Smithsonian Astrophysical Observation", "SAO 29353"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.37471955),
        dec: Angle.Degrees(+50.85288729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145477"},
        {"Hipparcos Number", "HIP 79109"},
        {"Smithsonian Astrophysical Observation", "SAO 29817"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.20646165),
        dec: Angle.Degrees(+50.85736195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206696"},
        {"Hipparcos Number", "HIP 107159"},
        {"Celescope Catalog", "CEL 5371"},
        {"Geneva Identification System", "GEN# +1.00206696"},
        {"Smithsonian Astrophysical Observation", "SAO 33672"},
    },
    visualMagnitude: 7.24,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.58787567),
        dec: Angle.Degrees(+50.85803132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232531"},
        {"Hipparcos Number", "HIP 8316"},
        {"Smithsonian Astrophysical Observation", "SAO 22622"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.81028541),
        dec: Angle.Degrees(+50.85954140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232301"},
        {"Hipparcos Number", "HIP 4168"},
        {"Smithsonian Astrophysical Observation", "SAO 21803"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.30921292),
        dec: Angle.Degrees(+50.86322952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26857"},
        {"Hipparcos Number", "HIP 19986"},
        {"Geneva Identification System", "GEN# +1.00026857"},
        {"Smithsonian Astrophysical Observation", "SAO 24518"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.30128579),
        dec: Angle.Degrees(+50.86582442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18179"},
        {"Hipparcos Number", "HIP 13760"},
        {"Geneva Identification System", "GEN# +1.00018179"},
        {"Smithsonian Astrophysical Observation", "SAO 23725"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.28322747),
        dec: Angle.Degrees(+50.86588217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37033",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37033"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.14883277),
        dec: Angle.Degrees(+50.86671543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232685"},
        {"Hipparcos Number", "HIP 12282"},
        {"Smithsonian Astrophysical Observation", "SAO 23485"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.55089090),
        dec: Angle.Degrees(+50.86809582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85545",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10597 AB"},
        {"Henry Draper", "HD 158868"},
        {"Hipparcos Number", "HIP 85545"},
        {"Smithsonian Astrophysical Observation", "SAO 30413"},
        {"Wilson Evans Batten Catalogue", "WEB 14441"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.24241030),
        dec: Angle.Degrees(+50.87026085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235412"},
        {"Hipparcos Number", "HIP 103492"},
        {"Fundamental Katalog 5th Edition", "FK5 5845"},
        {"Geneva Identification System", "GEN# +1.00235412"},
        {"Smithsonian Astrophysical Observation", "SAO 33028"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.51996934),
        dec: Angle.Degrees(+50.87188500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7481"},
        {"Hipparcos Number", "HIP 5894"},
        {"Smithsonian Astrophysical Observation", "SAO 22136"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.93500072),
        dec: Angle.Degrees(+50.87195637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111164",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16020 AB"},
        {"Henry Draper", "HD 213557"},
        {"Hipparcos Number", "HIP 111164"},
        {"Smithsonian Astrophysical Observation", "SAO 34541"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.81258155),
        dec: Angle.Degrees(+50.87235026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233963"},
        {"Hipparcos Number", "HIP 61680"},
        {"Geneva Identification System", "GEN# +1.00233963"},
        {"Smithsonian Astrophysical Observation", "SAO 28462"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.66555083),
        dec: Angle.Degrees(+50.87346575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181595"},
        {"Hipparcos Number", "HIP 94887"},
        {"Smithsonian Astrophysical Observation", "SAO 31560"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.64139762),
        dec: Angle.Degrees(+50.87409064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236246"},
        {"Hipparcos Number", "HIP 117934"},
        {"Smithsonian Astrophysical Observation", "SAO 35893"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.84043596),
        dec: Angle.Degrees(+50.87709552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234789"},
        {"Hipparcos Number", "HIP 93577"},
        {"Smithsonian Astrophysical Observation", "SAO 31351"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.87892049),
        dec: Angle.Degrees(+50.87720871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11968"},
        {"Hipparcos Number", "HIP 9241"},
        {"Smithsonian Astrophysical Observation", "SAO 22810"},
    },
    visualMagnitude: 9.16,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.70716520),
        dec: Angle.Degrees(+50.87809552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232793"},
        {"Hipparcos Number", "HIP 16088"},
        {"Geneva Identification System", "GEN# +5.20200732"},
        {"Smithsonian Astrophysical Observation", "SAO 24042"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.80876604),
        dec: Angle.Degrees(+50.87893500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5882"},
        {"Hipparcos Number", "HIP 4744"},
        {"Celescope Catalog", "CEL 106"},
        {"Fundamental Katalog 5th Edition", "FK5 4096"},
        {"Geneva Identification System", "GEN# +1.00005882"},
        {"Smithsonian Astrophysical Observation", "SAO 21918"},
        {"Wilson Evans Batten Catalogue", "WEB 897"},
    },
    visualMagnitude: 7.67,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.23524011),
        dec: Angle.Degrees(+50.87903060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193647"},
        {"Hipparcos Number", "HIP 100180"},
        {"Smithsonian Astrophysical Observation", "SAO 32467"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.79683685),
        dec: Angle.Degrees(+50.88044495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57450",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57450"},
        {"Geneva Identification System", "GEN# +0.05101696"},
        {"Wilson Evans Batten Catalogue", "WEB 10320"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.64982912),
        dec: Angle.Degrees(+50.88317828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -870.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -543.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142090"},
        {"Hipparcos Number", "HIP 77573"},
        {"Smithsonian Astrophysical Observation", "SAO 29684"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.56121814),
        dec: Angle.Degrees(+50.88388230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232120"},
        {"Hipparcos Number", "HIP 837"},
        {"Smithsonian Astrophysical Observation", "SAO 21155"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.56783172),
        dec: Angle.Degrees(+50.88488337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234864"},
        {"Hipparcos Number", "HIP 94920"},
        {"Smithsonian Astrophysical Observation", "SAO 31564"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.73149634),
        dec: Angle.Degrees(+50.88517037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166408"},
        {"Hipparcos Number", "HIP 88810"},
        {"Geneva Identification System", "GEN# +1.00166408"},
        {"Smithsonian Astrophysical Observation", "SAO 30760"},
        {"Wilson Evans Batten Catalogue", "WEB 15054"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.94576068),
        dec: Angle.Degrees(+50.88868126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14125"},
        {"Hipparcos Number", "HIP 10773"},
        {"Smithsonian Astrophysical Observation", "SAO 23174"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.65888630),
        dec: Angle.Degrees(+50.88893998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196670"},
        {"Hipparcos Number", "HIP 101691"},
        {"Geneva Identification System", "GEN# +1.00196670J"},
        {"Smithsonian Astrophysical Observation", "SAO 32731"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.17913756),
        dec: Angle.Degrees(+50.88982230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234162"},
        {"Hipparcos Number", "HIP 71392"},
        {"Geneva Identification System", "GEN# +1.00234162"},
        {"Smithsonian Astrophysical Observation", "SAO 29214"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.98212855),
        dec: Angle.Degrees(+50.89043250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234393"},
        {"Hipparcos Number", "HIP 83750"},
        {"Smithsonian Astrophysical Observation", "SAO 30253"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.75791940),
        dec: Angle.Degrees(+50.89246977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235704"},
        {"Hipparcos Number", "HIP 108840"},
        {"Smithsonian Astrophysical Observation", "SAO 34000"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.72705235),
        dec: Angle.Degrees(+50.89293745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232178"},
        {"Hipparcos Number", "HIP 1907"},
        {"Geneva Identification System", "GEN# +1.00232178"},
        {"Smithsonian Astrophysical Observation", "SAO 21362"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.02621640),
        dec: Angle.Degrees(+50.89330623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232866"},
        {"Hipparcos Number", "HIP 18668"},
        {"Smithsonian Astrophysical Observation", "SAO 24333"},
    },
    visualMagnitude: 9.99,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.96138071),
        dec: Angle.Degrees(+50.89362495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232509"},
        {"Hipparcos Number", "HIP 7995"},
        {"Smithsonian Astrophysical Observation", "SAO 22534"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.67575472),
        dec: Angle.Degrees(+50.89588395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234723"},
        {"Hipparcos Number", "HIP 92457"},
        {"Smithsonian Astrophysical Observation", "SAO 31195"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.63114232),
        dec: Angle.Degrees(+50.89598779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193593"},
        {"Hipparcos Number", "HIP 100140"},
        {"Smithsonian Astrophysical Observation", "SAO 32460"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.811,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.70228871),
        dec: Angle.Degrees(+50.89706991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147788"},
        {"Hipparcos Number", "HIP 80133"},
        {"Smithsonian Astrophysical Observation", "SAO 29910"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.34533799),
        dec: Angle.Degrees(+50.89730304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7126",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7126"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.95213364),
        dec: Angle.Degrees(+50.89731680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17307"},
        {"Hipparcos Number", "HIP 13105"},
        {"Smithsonian Astrophysical Observation", "SAO 23626"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.12741130),
        dec: Angle.Degrees(+50.89736135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186774"},
        {"Hipparcos Number", "HIP 97106"},
        {"Geneva Identification System", "GEN# +1.00186774"},
        {"Smithsonian Astrophysical Observation", "SAO 31936"},
    },
    visualMagnitude: 8.26,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.01915906),
        dec: Angle.Degrees(+50.89938477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234062"},
        {"Hipparcos Number", "HIP 66843"},
        {"Smithsonian Astrophysical Observation", "SAO 28854"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.48374802),
        dec: Angle.Degrees(+50.90079545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235212"},
        {"Hipparcos Number", "HIP 100595"},
        {"Smithsonian Astrophysical Observation", "SAO 32524"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.97552836),
        dec: Angle.Degrees(+50.90114545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189253"},
        {"Hipparcos Number", "HIP 98146"},
        {"Celescope Catalog", "CEL 4888"},
        {"Geneva Identification System", "GEN# +1.00189253"},
        {"Smithsonian Astrophysical Observation", "SAO 32130"},
        {"Wilson Evans Batten Catalogue", "WEB 17301"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.18818099),
        dec: Angle.Degrees(+50.90249691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14684"},
        {"Hipparcos Number", "HIP 11171"},
        {"Celescope Catalog", "CEL 266"},
        {"Geneva Identification System", "GEN# +1.00014684"},
        {"Smithsonian Astrophysical Observation", "SAO 23287"},
    },
    visualMagnitude: 8.65,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.95585160),
        dec: Angle.Degrees(+50.90254193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24459",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3802 A"},
        {"Henry Draper", "HD 233091"},
        {"Hipparcos Number", "HIP 24459"},
        {"Geneva Identification System", "GEN# +1.00233091"},
        {"Smithsonian Astrophysical Observation", "SAO 25091"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.72865284),
        dec: Angle.Degrees(+50.90395368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157120"},
        {"Hipparcos Number", "HIP 84681"},
        {"Smithsonian Astrophysical Observation", "SAO 30335"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.67315078),
        dec: Angle.Degrees(+50.90540553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71092"},
        {"Hipparcos Number", "HIP 41493"},
        {"Geneva Identification System", "GEN# +1.00071092"},
        {"Smithsonian Astrophysical Observation", "SAO 26848"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.93529327),
        dec: Angle.Degrees(+50.90688647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140952"},
        {"Hipparcos Number", "HIP 77066"},
        {"Smithsonian Astrophysical Observation", "SAO 29635"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.04044085),
        dec: Angle.Degrees(+50.90781094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222786"},
        {"Hipparcos Number", "HIP 117024"},
        {"Geneva Identification System", "GEN# +1.00222786"},
        {"Smithsonian Astrophysical Observation", "SAO 35705"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.84883586),
        dec: Angle.Degrees(+50.90842982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180347"},
        {"Hipparcos Number", "HIP 94472"},
        {"Geneva Identification System", "GEN# +1.00180347"},
        {"Renson", "Renson 50070"},
        {"Smithsonian Astrophysical Observation", "SAO 31487"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.41155558),
        dec: Angle.Degrees(+50.90865506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95125"},
        {"Hipparcos Number", "HIP 53744"},
        {"Geneva Identification System", "GEN# +1.00095125"},
        {"Smithsonian Astrophysical Observation", "SAO 27863"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.94820332),
        dec: Angle.Degrees(+50.91010516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235608"},
        {"Hipparcos Number", "HIP 107465"},
        {"Geneva Identification System", "GEN# +1.00235608"},
        {"Smithsonian Astrophysical Observation", "SAO 33730"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.50097746),
        dec: Angle.Degrees(+50.91052648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232191"},
        {"Hipparcos Number", "HIP 2205"},
        {"Smithsonian Astrophysical Observation", "SAO 21418"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.96773801),
        dec: Angle.Degrees(+50.91251451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80963"},
        {"Hipparcos Number", "HIP 46152"},
        {"Smithsonian Astrophysical Observation", "SAO 27241"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.18334955),
        dec: Angle.Degrees(+50.91311581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222927"},
        {"Hipparcos Number", "HIP 117134"},
        {"Smithsonian Astrophysical Observation", "SAO 35727"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.20159511),
        dec: Angle.Degrees(+50.91410966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94478"},
        {"Hipparcos Number", "HIP 53393"},
        {"Geneva Identification System", "GEN# +1.00094478"},
        {"Smithsonian Astrophysical Observation", "SAO 27830"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.81218193),
        dec: Angle.Degrees(+50.91597881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10154"},
        {"Hipparcos Number", "HIP 7801"},
        {"Geneva Identification System", "GEN# +1.00010154"},
        {"Smithsonian Astrophysical Observation", "SAO 22498"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.09588031),
        dec: Angle.Degrees(+50.91783740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87357"},
        {"Hipparcos Number", "HIP 49452"},
        {"Geneva Identification System", "GEN# +1.00087357"},
        {"Smithsonian Astrophysical Observation", "SAO 27517"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.44671864),
        dec: Angle.Degrees(+50.91959303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27192"},
        {"Hipparcos Number", "HIP 20234"},
        {"Fundamental Katalog 5th Edition", "FK5 2316"},
        {"Geneva Identification System", "GEN# +1.00027192"},
        {"Smithsonian Astrophysical Observation", "SAO 24544"},
        {"Wilson Evans Batten Catalogue", "WEB 3858"},
    },
    visualMagnitude: 5.55,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.04796760),
        dec: Angle.Degrees(+50.92095135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83600"},
        {"Hipparcos Number", "HIP 47524"},
        {"Smithsonian Astrophysical Observation", "SAO 27341"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.32726557),
        dec: Angle.Degrees(+50.92102884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164782"},
        {"Hipparcos Number", "HIP 88129"},
        {"Geneva Identification System", "GEN# +1.00164782"},
        {"Smithsonian Astrophysical Observation", "SAO 30680"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.01606229),
        dec: Angle.Degrees(+50.92163358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20061"},
        {"Hipparcos Number", "HIP 15171"},
        {"Geneva Identification System", "GEN# +5.20200283"},
        {"Smithsonian Astrophysical Observation", "SAO 23902"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.88115930),
        dec: Angle.Degrees(+50.92575729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232373"},
        {"Hipparcos Number", "HIP 5083"},
        {"Smithsonian Astrophysical Observation", "SAO 21993"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.28382543),
        dec: Angle.Degrees(+50.92593722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235598"},
        {"Hipparcos Number", "HIP 107283"},
        {"Smithsonian Astrophysical Observation", "SAO 33694"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.96048399),
        dec: Angle.Degrees(+50.92781287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234475"},
        {"Hipparcos Number", "HIP 86654"},
        {"Geneva Identification System", "GEN# +1.00234475"},
        {"Smithsonian Astrophysical Observation", "SAO 30527"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.58087813),
        dec: Angle.Degrees(+50.92837498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 92.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127807"},
        {"Hipparcos Number", "HIP 71043"},
        {"Smithsonian Astrophysical Observation", "SAO 29183"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.94328043),
        dec: Angle.Degrees(+50.92849034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76844"},
        {"Hipparcos Number", "HIP 44252"},
        {"Geneva Identification System", "GEN# +1.00076844"},
        {"Smithsonian Astrophysical Observation", "SAO 27082"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.776,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.18522375),
        dec: Angle.Degrees(+50.92889036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235930"},
        {"Hipparcos Number", "HIP 112027"},
        {"Smithsonian Astrophysical Observation", "SAO 34697"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.36180756),
        dec: Angle.Degrees(+50.92909605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184659"},
        {"Hipparcos Number", "HIP 96146"},
        {"Geneva Identification System", "GEN# +1.00184659"},
        {"Smithsonian Astrophysical Observation", "SAO 31764"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.23492642),
        dec: Angle.Degrees(+50.93114010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66173"},
        {"Hipparcos Number", "HIP 39525"},
        {"Smithsonian Astrophysical Observation", "SAO 26653"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.17299822),
        dec: Angle.Degrees(+50.93543959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67202"},
        {"Hipparcos Number", "HIP 39929"},
        {"Geneva Identification System", "GEN# +1.00067202"},
        {"Smithsonian Astrophysical Observation", "SAO 26697"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.32181468),
        dec: Angle.Degrees(+50.93608313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23689"},
        {"Hipparcos Number", "HIP 17869"},
        {"Smithsonian Astrophysical Observation", "SAO 24249"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.35297263),
        dec: Angle.Degrees(+50.93658238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20123"},
        {"Hipparcos Number", "HIP 15219"},
        {"Geneva Identification System", "GEN# +5.20200308"},
        {"Smithsonian Astrophysical Observation", "SAO 23914"},
        {"Wilson Evans Batten Catalogue", "WEB 2934"},
    },
    visualMagnitude: 5.04,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.05085271),
        dec: Angle.Degrees(+50.93771066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135944"},
        {"Hipparcos Number", "HIP 74690"},
        {"Geneva Identification System", "GEN# +1.00135944"},
        {"Smithsonian Astrophysical Observation", "SAO 29464"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.96118036),
        dec: Angle.Degrees(+50.93856795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35572"},
        {"Hipparcos Number", "HIP 25628"},
        {"Smithsonian Astrophysical Observation", "SAO 25211"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.12030841),
        dec: Angle.Degrees(+50.93963947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16863",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16863"},
    },
    visualMagnitude: 11.52,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.25105769),
        dec: Angle.Degrees(+50.94032474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21268"},
        {"Hipparcos Number", "HIP 16149"},
        {"Smithsonian Astrophysical Observation", "SAO 24050"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.02987359),
        dec: Angle.Degrees(+50.94036752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126630"},
        {"Hipparcos Number", "HIP 70489"},
        {"Smithsonian Astrophysical Observation", "SAO 29134"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.26637836),
        dec: Angle.Degrees(+50.94244836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25889"},
        {"Hipparcos Number", "HIP 19322"},
        {"Smithsonian Astrophysical Observation", "SAO 24429"},
    },
    visualMagnitude: 7.70,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.11626248),
        dec: Angle.Degrees(+50.94258277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154413"},
        {"Hipparcos Number", "HIP 83395"},
        {"Smithsonian Astrophysical Observation", "SAO 30213"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.66488862),
        dec: Angle.Degrees(+50.94280306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23140",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23140"},
        {"Geneva Identification System", "GEN# +9.80191015"},
    },
    visualMagnitude: 10.97,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.68968885),
        dec: Angle.Degrees(+50.94464233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 502.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -335.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61362"},
        {"Hipparcos Number", "HIP 37468"},
        {"Smithsonian Astrophysical Observation", "SAO 26465"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.35302171),
        dec: Angle.Degrees(+50.94561414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24227"},
        {"Hipparcos Number", "HIP 18215"},
        {"Geneva Identification System", "GEN# +1.00024227"},
        {"Smithsonian Astrophysical Observation", "SAO 24280"},
        {"Wilson Evans Batten Catalogue", "WEB 3517"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.42586901),
        dec: Angle.Degrees(+50.94612602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232569"},
        {"Hipparcos Number", "HIP 9089"},
        {"Smithsonian Astrophysical Observation", "SAO 22780"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.27073355),
        dec: Angle.Degrees(+50.94954454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102919",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102919"},
        {"Geneva Identification System", "GEN# +0.05003214"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.76607368),
        dec: Angle.Degrees(+50.94955781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118126"},
        {"Hipparcos Number", "HIP 66177"},
        {"Smithsonian Astrophysical Observation", "SAO 28801"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.45817289),
        dec: Angle.Degrees(+50.95035499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93943",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12083 A"},
        {"Henry Draper", "HD 234806"},
        {"Hipparcos Number", "HIP 93943"},
        {"Smithsonian Astrophysical Observation", "SAO 31399"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.92239323),
        dec: Angle.Degrees(+50.95055291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70222"},
        {"Hipparcos Number", "HIP 41087"},
        {"Geneva Identification System", "GEN# +1.00070222"},
        {"Smithsonian Astrophysical Observation", "SAO 26809"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.74375227),
        dec: Angle.Degrees(+50.95397440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93945",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12083 C"},
        {"Hipparcos Number", "HIP 93945"},
    },
    visualMagnitude: 11.60,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.92859504),
        dec: Angle.Degrees(+50.95424968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141712"},
        {"Hipparcos Number", "HIP 77413"},
        {"Smithsonian Astrophysical Observation", "SAO 29676"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.05587407),
        dec: Angle.Degrees(+50.95461188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48041",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7514 AB"},
        {"Henry Draper", "HD 84540"},
        {"Hipparcos Number", "HIP 48041"},
        {"Smithsonian Astrophysical Observation", "SAO 27382"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.90036138),
        dec: Angle.Degrees(+50.95481101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15150"},
        {"Hipparcos Number", "HIP 11478"},
        {"Smithsonian Astrophysical Observation", "SAO 23357"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.00919419),
        dec: Angle.Degrees(+50.95536504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15193",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2425 AB"},
        {"Henry Draper", "HD 20096"},
        {"Hipparcos Number", "HIP 15193"},
        {"Smithsonian Astrophysical Observation", "SAO 23907"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.95270394),
        dec: Angle.Degrees(+50.95597551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12611"},
        {"Hipparcos Number", "HIP 9715"},
        {"Smithsonian Astrophysical Observation", "SAO 22910"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.24547140),
        dec: Angle.Degrees(+50.95609319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45836"},
        {"Hipparcos Number", "HIP 31182"},
        {"Smithsonian Astrophysical Observation", "SAO 25801"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.14733365),
        dec: Angle.Degrees(+50.95774163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18842"},
        {"Hipparcos Number", "HIP 14268"},
        {"Geneva Identification System", "GEN# +1.00018842"},
        {"Smithsonian Astrophysical Observation", "SAO 23783"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.99201644),
        dec: Angle.Degrees(+50.95785270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14304"},
        {"Hipparcos Number", "HIP 10890"},
        {"Geneva Identification System", "GEN# +1.00014304"},
        {"Smithsonian Astrophysical Observation", "SAO 23205"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.03728727),
        dec: Angle.Degrees(+50.95819139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233812"},
        {"Hipparcos Number", "HIP 54586"},
        {"Geneva Identification System", "GEN# +1.00233812"},
        {"Smithsonian Astrophysical Observation", "SAO 27934"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.56492467),
        dec: Angle.Degrees(+50.95820733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118809"},
        {"Hipparcos Number", "HIP 66516"},
        {"Fundamental Katalog 5th Edition", "FK5 5202"},
        {"Geneva Identification System", "GEN# +1.00118809"},
        {"Smithsonian Astrophysical Observation", "SAO 28823"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.51576578),
        dec: Angle.Degrees(+50.95998701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222097"},
        {"Hipparcos Number", "HIP 116572"},
        {"Smithsonian Astrophysical Observation", "SAO 35605"},
    },
    visualMagnitude: 9.26,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.34763232),
        dec: Angle.Degrees(+50.96263093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213233"},
        {"Hipparcos Number", "HIP 110968"},
        {"Geneva Identification System", "GEN# +1.00213233"},
        {"Smithsonian Astrophysical Observation", "SAO 34498"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.24301536),
        dec: Angle.Degrees(+50.96314236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216754"},
        {"Hipparcos Number", "HIP 113152"},
        {"Geneva Identification System", "GEN# +1.00216754"},
        {"Renson", "Renson 59830"},
        {"Smithsonian Astrophysical Observation", "SAO 34940"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.70092779),
        dec: Angle.Degrees(+50.96362842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234731"},
        {"Hipparcos Number", "HIP 92577"},
        {"Fundamental Katalog 5th Edition", "FK5 5662"},
        {"Geneva Identification System", "GEN# +1.00234731"},
        {"Smithsonian Astrophysical Observation", "SAO 31221"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.96837297),
        dec: Angle.Degrees(+50.96777135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4636"},
        {"Hipparcos Number", "HIP 3801"},
        {"Geneva Identification System", "GEN# +1.00004636"},
        {"Smithsonian Astrophysical Observation", "SAO 21729"},
        {"Wilson Evans Batten Catalogue", "WEB 673"},
    },
    visualMagnitude: 4.90,
    bvColour: -0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.20830552),
        dec: Angle.Degrees(+50.96819154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20510"},
        {"Hipparcos Number", "HIP 15531"},
        {"Geneva Identification System", "GEN# +5.20200441"},
        {"Smithsonian Astrophysical Observation", "SAO 23958"},
        {"Wilson Evans Batten Catalogue", "WEB 2983"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.02600973),
        dec: Angle.Degrees(+50.96882308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149719"},
        {"Hipparcos Number", "HIP 81132"},
        {"Geneva Identification System", "GEN# +1.00149719"},
        {"Smithsonian Astrophysical Observation", "SAO 29992"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.53776247),
        dec: Angle.Degrees(+50.96893747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168093"},
        {"Hipparcos Number", "HIP 89452"},
        {"Geneva Identification System", "GEN# +1.00168093"},
        {"Smithsonian Astrophysical Observation", "SAO 30839"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.83329712),
        dec: Angle.Degrees(+50.97135152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122866"},
        {"Hipparcos Number", "HIP 68637"},
        {"Geneva Identification System", "GEN# +1.00122866"},
        {"Smithsonian Astrophysical Observation", "SAO 28989"},
        {"Wilson Evans Batten Catalogue", "WEB 12019"},
    },
    visualMagnitude: 6.16,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.74906428),
        dec: Angle.Degrees(+50.97182541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57493",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57493"},
        {"Geneva Identification System", "GEN# +0.05101697"},
        {"Wilson Evans Batten Catalogue", "WEB 10324"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.76434019),
        dec: Angle.Degrees(+50.97206679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108942"},
        {"Hipparcos Number", "HIP 61044"},
        {"Geneva Identification System", "GEN# +1.00108942"},
        {"Smithsonian Astrophysical Observation", "SAO 28411"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.67539834),
        dec: Angle.Degrees(+50.97499729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -224.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -188.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216106"},
        {"Hipparcos Number", "HIP 112697"},
        {"Geneva Identification System", "GEN# +1.00216106"},
        {"Smithsonian Astrophysical Observation", "SAO 34852"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.32326711),
        dec: Angle.Degrees(+50.97705991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234168"},
        {"Hipparcos Number", "HIP 71738"},
        {"Smithsonian Astrophysical Observation", "SAO 29240"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.12020425),
        dec: Angle.Degrees(+50.97892948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212071"},
        {"Hipparcos Number", "HIP 110316"},
        {"Smithsonian Astrophysical Observation", "SAO 34335"},
        {"Wilson Evans Batten Catalogue", "WEB 19788"},
    },
    visualMagnitude: 6.40,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.16465920),
        dec: Angle.Degrees(+50.98081544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235242"},
        {"Hipparcos Number", "HIP 100916"},
        {"Smithsonian Astrophysical Observation", "SAO 32603"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.91442442),
        dec: Angle.Degrees(+50.98107176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233042"},
        {"Hipparcos Number", "HIP 23064"},
        {"Smithsonian Astrophysical Observation", "SAO 24930"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.44670046),
        dec: Angle.Degrees(+50.98126663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17950"},
        {"Hipparcos Number", "HIP 13584"},
        {"Smithsonian Astrophysical Observation", "SAO 23695"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.74658303),
        dec: Angle.Degrees(+50.98147906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35086"},
        {"Hipparcos Number", "HIP 25316"},
        {"Geneva Identification System", "GEN# +1.00035086"},
        {"Smithsonian Astrophysical Observation", "SAO 25184"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.22992732),
        dec: Angle.Degrees(+50.98164967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86337"},
        {"Hipparcos Number", "HIP 48954"},
        {"Smithsonian Astrophysical Observation", "SAO 27459"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.79915960),
        dec: Angle.Degrees(+50.98310150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233794"},
        {"Hipparcos Number", "HIP 53695"},
        {"Smithsonian Astrophysical Observation", "SAO 27857"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.79179484),
        dec: Angle.Degrees(+50.98372034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160362"},
        {"Hipparcos Number", "HIP 86191"},
        {"Smithsonian Astrophysical Observation", "SAO 30480"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.19267988),
        dec: Angle.Degrees(+50.98454093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3778"},
        {"Hipparcos Number", "HIP 3217"},
        {"Smithsonian Astrophysical Observation", "SAO 21614"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.22744904),
        dec: Angle.Degrees(+50.98654372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221101"},
        {"Hipparcos Number", "HIP 115882"},
        {"Geneva Identification System", "GEN# +1.00221101"},
        {"Smithsonian Astrophysical Observation", "SAO 35452"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.17491515),
        dec: Angle.Degrees(+50.98680774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183298"},
        {"Hipparcos Number", "HIP 95568"},
        {"Geneva Identification System", "GEN# +1.00183298"},
        {"Smithsonian Astrophysical Observation", "SAO 31656"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.59193491),
        dec: Angle.Degrees(+50.98713513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233230"},
        {"Hipparcos Number", "HIP 30082"},
        {"Geneva Identification System", "GEN# +1.00233230"},
        {"Smithsonian Astrophysical Observation", "SAO 25671"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.95418012),
        dec: Angle.Degrees(+50.98725571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234157"},
        {"Hipparcos Number", "HIP 71325"},
        {"Smithsonian Astrophysical Observation", "SAO 29209"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.78578539),
        dec: Angle.Degrees(+50.98763429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232130"},
        {"Hipparcos Number", "HIP 959"},
        {"Geneva Identification System", "GEN# +1.00232130"},
        {"Smithsonian Astrophysical Observation", "SAO 21196"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.96182161),
        dec: Angle.Degrees(+50.98927919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58870",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58870"},
    },
    visualMagnitude: 12.15,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.08337456),
        dec: Angle.Degrees(+50.98928165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -260.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235517"},
        {"Hipparcos Number", "HIP 106020"},
        {"Smithsonian Astrophysical Observation", "SAO 33450"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.10186356),
        dec: Angle.Degrees(+50.98943660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125075"},
        {"Hipparcos Number", "HIP 69674"},
        {"Smithsonian Astrophysical Observation", "SAO 29062"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.92404273),
        dec: Angle.Degrees(+50.99118084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232778"},
        {"Hipparcos Number", "HIP 15610"},
        {"Smithsonian Astrophysical Observation", "SAO 23968"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.25049252),
        dec: Angle.Degrees(+50.99315615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51427",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7796 A"},
        {"Henry Draper", "HD 90806"},
        {"Hipparcos Number", "HIP 51427"},
        {"Geneva Identification System", "GEN# +1.00090806"},
        {"Smithsonian Astrophysical Observation", "SAO 27664"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.54786405),
        dec: Angle.Degrees(+50.99338005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234372"},
        {"Hipparcos Number", "HIP 82957"},
        {"Smithsonian Astrophysical Observation", "SAO 30171"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.29217359),
        dec: Angle.Degrees(+50.99352539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216773"},
        {"Hipparcos Number", "HIP 113162"},
        {"Smithsonian Astrophysical Observation", "SAO 34946"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.73618919),
        dec: Angle.Degrees(+50.99372392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221526"},
        {"Hipparcos Number", "HIP 116199"},
        {"Smithsonian Astrophysical Observation", "SAO 35525"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.15007109),
        dec: Angle.Degrees(+50.99377321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51426",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7796 B"},
        {"Hipparcos Number", "HIP 51426"},
    },
    visualMagnitude: 7.70,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)30, 10.1900),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)59, 43.200)
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
    primaryId: "HIP 109432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235743"},
        {"Hipparcos Number", "HIP 109432"},
        {"Geneva Identification System", "GEN# +1.00235743"},
        {"Smithsonian Astrophysical Observation", "SAO 34122"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.55817302),
        dec: Angle.Degrees(+50.99574003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69790",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9206 AB"},
        {"Henry Draper", "HD 125307"},
        {"Hipparcos Number", "HIP 69790"},
        {"Smithsonian Astrophysical Observation", "SAO 29082"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.26288768),
        dec: Angle.Degrees(+50.99574761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214073"},
        {"Hipparcos Number", "HIP 111459"},
        {"Smithsonian Astrophysical Observation", "SAO 34583"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.72697864),
        dec: Angle.Degrees(+50.99647074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236117"},
        {"Hipparcos Number", "HIP 115602"},
        {"Smithsonian Astrophysical Observation", "SAO 35402"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.26157748),
        dec: Angle.Degrees(+50.99680462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232219"},
        {"Hipparcos Number", "HIP 2691"},
        {"Smithsonian Astrophysical Observation", "SAO 21527"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.54036406),
        dec: Angle.Degrees(+50.99719850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207855"},
        {"Hipparcos Number", "HIP 107814"},
        {"Geneva Identification System", "GEN# +1.00207855"},
        {"Smithsonian Astrophysical Observation", "SAO 33800"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.63460190),
        dec: Angle.Degrees(+50.99861449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233965"},
        {"Hipparcos Number", "HIP 61781"},
        {"Smithsonian Astrophysical Observation", "SAO 28466"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.94204992),
        dec: Angle.Degrees(+50.99927025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232440"},
        {"Hipparcos Number", "HIP 6839"},
        {"Geneva Identification System", "GEN# +1.00232440"},
        {"Smithsonian Astrophysical Observation", "SAO 22296"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.00406534),
        dec: Angle.Degrees(+51.00153595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103541"},
        {"Hipparcos Number", "HIP 58147"},
        {"Geneva Identification System", "GEN# +1.00103541"},
        {"Smithsonian Astrophysical Observation", "SAO 28189"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.87197645),
        dec: Angle.Degrees(+51.00271956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21328",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3298 AB"},
        {"Henry Draper", "HD 28771"},
        {"Hipparcos Number", "HIP 21328"},
        {"Smithsonian Astrophysical Observation", "SAO 24694"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.66304770),
        dec: Angle.Degrees(+51.00326235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107241",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15263 AB"},
        {"Henry Draper", "HD 206845"},
        {"Henry Draper 2", "HD 206844"},
        {"Hipparcos Number", "HIP 107241"},
        {"Geneva Identification System", "GEN# +1.00206844"},
        {"Smithsonian Astrophysical Observation", "SAO 33687"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.81420192),
        dec: Angle.Degrees(+51.00335579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208525"},
        {"Hipparcos Number", "HIP 108217"},
        {"Geneva Identification System", "GEN# +1.00208525"},
        {"Renson", "Renson 57990"},
        {"Smithsonian Astrophysical Observation", "SAO 33871"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.85312450),
        dec: Angle.Degrees(+51.00371102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50657"},
        {"Hipparcos Number", "HIP 33413"},
        {"Smithsonian Astrophysical Observation", "SAO 26055"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.23123082),
        dec: Angle.Degrees(+51.00528739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234238"},
        {"Hipparcos Number", "HIP 75966"},
        {"Smithsonian Astrophysical Observation", "SAO 29554"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.71361614),
        dec: Angle.Degrees(+51.00545554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129208"},
        {"Hipparcos Number", "HIP 71669"},
        {"Smithsonian Astrophysical Observation", "SAO 29236"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.89157203),
        dec: Angle.Degrees(+51.00681263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211513"},
        {"Hipparcos Number", "HIP 109968"},
        {"Smithsonian Astrophysical Observation", "SAO 34251"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.09524489),
        dec: Angle.Degrees(+51.00728877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223422"},
        {"Hipparcos Number", "HIP 117477"},
        {"Smithsonian Astrophysical Observation", "SAO 35801"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.31581072),
        dec: Angle.Degrees(+51.00773515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6300"},
        {"Hipparcos Number", "HIP 5062"},
        {"Celescope Catalog", "CEL 115"},
        {"Geneva Identification System", "GEN# +1.00006300"},
        {"Smithsonian Astrophysical Observation", "SAO 21988"},
        {"Wilson Evans Batten Catalogue", "WEB 1040"},
    },
    visualMagnitude: 6.53,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.19493732),
        dec: Angle.Degrees(+51.00979730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45922",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45922"},
    },
    visualMagnitude: 11.05,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.46167281),
        dec: Angle.Degrees(+51.01006094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232497"},
        {"Hipparcos Number", "HIP 7826"},
        {"Smithsonian Astrophysical Observation", "SAO 22504"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.17536185),
        dec: Angle.Degrees(+51.01038225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5512",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 963 AP"},
        {"Aitken 2", "ADS 963 A"},
        {"Henry Draper", "HD 6918"},
        {"Hipparcos Number", "HIP 5512"},
        {"Geneva Identification System", "GEN# +1.00006918"},
        {"Smithsonian Astrophysical Observation", "SAO 22060"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.64295695),
        dec: Angle.Degrees(+51.01328800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233710"},
        {"Hipparcos Number", "HIP 49798"},
        {"Smithsonian Astrophysical Observation", "SAO 27544"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.47355291),
        dec: Angle.Degrees(+51.01364041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217555"},
        {"Hipparcos Number", "HIP 113625"},
        {"Smithsonian Astrophysical Observation", "SAO 35050"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.18248723),
        dec: Angle.Degrees(+51.01437780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80566"},
        {"Hipparcos Number", "HIP 45965"},
        {"Smithsonian Astrophysical Observation", "SAO 27227"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.61857371),
        dec: Angle.Degrees(+51.01442767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233782"},
        {"Hipparcos Number", "HIP 53222"},
        {"Smithsonian Astrophysical Observation", "SAO 27813"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.30002886),
        dec: Angle.Degrees(+51.01471007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219635"},
        {"Hipparcos Number", "HIP 114943"},
        {"Geneva Identification System", "GEN# +1.00219635"},
        {"Smithsonian Astrophysical Observation", "SAO 35287"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.21856182),
        dec: Angle.Degrees(+51.01471966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72145"},
        {"Hipparcos Number", "HIP 41993"},
        {"Smithsonian Astrophysical Observation", "SAO 26906"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.39152799),
        dec: Angle.Degrees(+51.01509399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214444"},
        {"Hipparcos Number", "HIP 111666"},
        {"Geneva Identification System", "GEN# +1.00214444"},
        {"Smithsonian Astrophysical Observation", "SAO 34625"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.31695325),
        dec: Angle.Degrees(+51.01545168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20403",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3142 AB"},
        {"Henry Draper", "HD 27418"},
        {"Hipparcos Number", "HIP 20403"},
        {"Smithsonian Astrophysical Observation", "SAO 24571"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.52491969),
        dec: Angle.Degrees(+51.01691425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236008"},
        {"Hipparcos Number", "HIP 113470"},
        {"Smithsonian Astrophysical Observation", "SAO 35016"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.69431675),
        dec: Angle.Degrees(+51.01815200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38410"},
        {"Hipparcos Number", "HIP 27416"},
        {"Geneva Identification System", "GEN# +1.00038410"},
        {"Smithsonian Astrophysical Observation", "SAO 25382"},
    },
    visualMagnitude: 8.74,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.08260827),
        dec: Angle.Degrees(+51.01853864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234998"},
        {"Hipparcos Number", "HIP 97316"},
        {"Smithsonian Astrophysical Observation", "SAO 31985"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.65726790),
        dec: Angle.Degrees(+51.02056315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127823"},
        {"Hipparcos Number", "HIP 71054"},
        {"Geneva Identification System", "GEN# +1.00127823"},
        {"Smithsonian Astrophysical Observation", "SAO 29184"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.95923372),
        dec: Angle.Degrees(+51.02102549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34398"},
        {"Hipparcos Number", "HIP 24866"},
        {"Smithsonian Astrophysical Observation", "SAO 25130"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.95916793),
        dec: Angle.Degrees(+51.02262013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235241"},
        {"Hipparcos Number", "HIP 100875"},
        {"Smithsonian Astrophysical Observation", "SAO 32599"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.80776586),
        dec: Angle.Degrees(+51.02270685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197620"},
        {"Hipparcos Number", "HIP 102223"},
        {"Smithsonian Astrophysical Observation", "SAO 32819"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.69623184),
        dec: Angle.Degrees(+51.02531807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62378"},
        {"Hipparcos Number", "HIP 37917"},
        {"Smithsonian Astrophysical Observation", "SAO 26498"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.55834446),
        dec: Angle.Degrees(+51.02565986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3573"},
        {"Hipparcos Number", "HIP 3080"},
        {"Smithsonian Astrophysical Observation", "SAO 21596"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.78203132),
        dec: Angle.Degrees(+51.02714154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36067"},
        {"Hipparcos Number", "HIP 25920"},
        {"Smithsonian Astrophysical Observation", "SAO 25237"},
        {"Wilson Evans Batten Catalogue", "WEB 5036"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.97059817),
        dec: Angle.Degrees(+51.02813877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21550"},
        {"Hipparcos Number", "HIP 16361"},
        {"Geneva Identification System", "GEN# +5.20200887"},
        {"Smithsonian Astrophysical Observation", "SAO 24071"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.69164707),
        dec: Angle.Degrees(+51.02997230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191060"},
        {"Hipparcos Number", "HIP 98985"},
        {"Smithsonian Astrophysical Observation", "SAO 32279"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.42848800),
        dec: Angle.Degrees(+51.03040100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188398"},
        {"Hipparcos Number", "HIP 97821"},
        {"Geneva Identification System", "GEN# +1.00188398"},
        {"Renson", "Renson 52050"},
        {"Smithsonian Astrophysical Observation", "SAO 32074"},
        {"Wilson Evans Batten Catalogue", "WEB 17210"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.16459840),
        dec: Angle.Degrees(+51.03097418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235347"},
        {"Hipparcos Number", "HIP 102369"},
        {"Smithsonian Astrophysical Observation", "SAO 32847"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.13035465),
        dec: Angle.Degrees(+51.03119423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220394"},
        {"Hipparcos Number", "HIP 115431"},
        {"Smithsonian Astrophysical Observation", "SAO 35366"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.73113703),
        dec: Angle.Degrees(+51.03138534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152949"},
        {"Hipparcos Number", "HIP 82668"},
        {"Smithsonian Astrophysical Observation", "SAO 30145"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.49351128),
        dec: Angle.Degrees(+51.03182309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17794"},
        {"Hipparcos Number", "HIP 13459"},
        {"Smithsonian Astrophysical Observation", "SAO 23679"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.32633130),
        dec: Angle.Degrees(+51.03183012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134658"},
        {"Hipparcos Number", "HIP 74151"},
        {"Smithsonian Astrophysical Observation", "SAO 29424"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.26982547),
        dec: Angle.Degrees(+51.03230947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182613"},
        {"Hipparcos Number", "HIP 95273"},
        {"Geneva Identification System", "GEN# +1.00182613"},
        {"Smithsonian Astrophysical Observation", "SAO 31613"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.75230831),
        dec: Angle.Degrees(+51.03412023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7225"},
        {"Hipparcos Number", "HIP 5710"},
        {"Smithsonian Astrophysical Observation", "SAO 22105"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.36270224),
        dec: Angle.Degrees(+51.03448024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6028"},
        {"Hipparcos Number", "HIP 4844"},
        {"Geneva Identification System", "GEN# +1.00006028"},
        {"Smithsonian Astrophysical Observation", "SAO 21938"},
        {"Wilson Evans Batten Catalogue", "WEB 933"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.57695351),
        dec: Angle.Degrees(+51.03497045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14583"},
        {"Hipparcos Number", "HIP 11110"},
        {"Smithsonian Astrophysical Observation", "SAO 23268"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.74147573),
        dec: Angle.Degrees(+51.03627557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232723"},
        {"Hipparcos Number", "HIP 13453"},
        {"Smithsonian Astrophysical Observation", "SAO 23678"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.30831753),
        dec: Angle.Degrees(+51.03654958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170694"},
        {"Hipparcos Number", "HIP 90499"},
        {"Smithsonian Astrophysical Observation", "SAO 30988"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.00660449),
        dec: Angle.Degrees(+51.03657368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208893"},
        {"Hipparcos Number", "HIP 108425"},
        {"Geneva Identification System", "GEN# +1.00208893"},
        {"Smithsonian Astrophysical Observation", "SAO 33913"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.46638291),
        dec: Angle.Degrees(+51.03782551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113423"},
        {"Hipparcos Number", "HIP 63666"},
        {"Fundamental Katalog 5th Edition", "FK5 5151"},
        {"Smithsonian Astrophysical Observation", "SAO 28615"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.72522254),
        dec: Angle.Degrees(+51.03914528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215224"},
        {"Hipparcos Number", "HIP 112130"},
        {"Geneva Identification System", "GEN# +1.00215224"},
        {"Smithsonian Astrophysical Observation", "SAO 34723"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.69200720),
        dec: Angle.Degrees(+51.04360213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5967"},
        {"Hipparcos Number", "HIP 4820"},
        {"Smithsonian Astrophysical Observation", "SAO 21934"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.45998019),
        dec: Angle.Degrees(+51.04526351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235739"},
        {"Hipparcos Number", "HIP 109340"},
        {"Geneva Identification System", "GEN# +1.00235739"},
        {"Smithsonian Astrophysical Observation", "SAO 34106"},
        {"Wilson Evans Batten Catalogue", "WEB 19646"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.26209612),
        dec: Angle.Degrees(+51.04586398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220383"},
        {"Hipparcos Number", "HIP 115416"},
        {"Smithsonian Astrophysical Observation", "SAO 35364"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.69745548),
        dec: Angle.Degrees(+51.04763742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21230",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3287 AB"},
        {"Henry Draper", "HD 28618"},
        {"Hipparcos Number", "HIP 21230"},
        {"Smithsonian Astrophysical Observation", "SAO 24685"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.31544392),
        dec: Angle.Degrees(+51.04765880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233377"},
        {"Hipparcos Number", "HIP 35682"},
        {"Smithsonian Astrophysical Observation", "SAO 26299"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.44444522),
        dec: Angle.Degrees(+51.04821873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77514",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77514"},
    },
    visualMagnitude: 12.84,
    bvColour: 2.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.40258187),
        dec: Angle.Degrees(+51.04852013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -366.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 277.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233735"},
        {"Hipparcos Number", "HIP 51108"},
        {"Smithsonian Astrophysical Observation", "SAO 27643"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.62677078),
        dec: Angle.Degrees(+51.05030554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24129"},
        {"Hipparcos Number", "HIP 18160"},
        {"Geneva Identification System", "GEN# +1.00024129"},
        {"Smithsonian Astrophysical Observation", "SAO 24274"},
        {"Wilson Evans Batten Catalogue", "WEB 3500"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.24327013),
        dec: Angle.Degrees(+51.05083590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46607",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46607"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.55399994),
        dec: Angle.Degrees(+51.05283310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13223"},
        {"Hipparcos Number", "HIP 10162"},
        {"Smithsonian Astrophysical Observation", "SAO 23006"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.66781708),
        dec: Angle.Degrees(+51.05445562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221073"},
        {"Hipparcos Number", "HIP 115873"},
        {"Geneva Identification System", "GEN# +1.00221073"},
        {"Smithsonian Astrophysical Observation", "SAO 35449"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.13881433),
        dec: Angle.Degrees(+51.06340454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233887"},
        {"Hipparcos Number", "HIP 58497"},
        {"Smithsonian Astrophysical Observation", "SAO 28211"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.95339799),
        dec: Angle.Degrees(+51.06397221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205966"},
        {"Hipparcos Number", "HIP 106735"},
        {"Celescope Catalog", "CEL 5353"},
        {"Geneva Identification System", "GEN# +1.00205966"},
        {"Smithsonian Astrophysical Observation", "SAO 33586"},
        {"Wilson Evans Batten Catalogue", "WEB 19298"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.32407240),
        dec: Angle.Degrees(+51.06420316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62393",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62393"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.80495232),
        dec: Angle.Degrees(+51.06452145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175149"},
        {"Hipparcos Number", "HIP 92538"},
        {"Smithsonian Astrophysical Observation", "SAO 31209"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.86201825),
        dec: Angle.Degrees(+51.06525248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116567"},
        {"Hipparcos Number", "HIP 65331"},
        {"Smithsonian Astrophysical Observation", "SAO 28732"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.85514537),
        dec: Angle.Degrees(+51.06598088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13530"},
        {"Hipparcos Number", "HIP 10366"},
        {"Fundamental Katalog 5th Edition", "FK5 77"},
        {"Geneva Identification System", "GEN# +1.00013530"},
        {"Smithsonian Astrophysical Observation", "SAO 23047"},
        {"Wilson Evans Batten Catalogue", "WEB 2169"},
    },
    visualMagnitude: 5.31,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.40008213),
        dec: Angle.Degrees(+51.06623342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 347.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186727"},
        {"Hipparcos Number", "HIP 97078"},
        {"Smithsonian Astrophysical Observation", "SAO 31926"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.92962297),
        dec: Angle.Degrees(+51.06684874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64132",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64132"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.16317839),
        dec: Angle.Degrees(+51.06700427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -223.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10032",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1670 AB"},
        {"Henry Draper", "HD 13053"},
        {"Hipparcos Number", "HIP 10032"},
        {"Smithsonian Astrophysical Observation", "SAO 22968"},
    },
    visualMagnitude: 8.47,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.28683916),
        dec: Angle.Degrees(+51.07335274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1349"},
        {"Hipparcos Number", "HIP 1431"},
        {"Geneva Identification System", "GEN# +1.00001349"},
        {"Smithsonian Astrophysical Observation", "SAO 21278"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.46445902),
        dec: Angle.Degrees(+51.07449386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199578"},
        {"Hipparcos Number", "HIP 103343"},
        {"Celescope Catalog", "CEL 5212"},
        {"Geneva Identification System", "GEN# +1.00199578"},
        {"Smithsonian Astrophysical Observation", "SAO 33001"},
        {"Wilson Evans Batten Catalogue", "WEB 18781"},
    },
    visualMagnitude: 6.61,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.05326699),
        dec: Angle.Degrees(+51.07501290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212138"},
        {"Hipparcos Number", "HIP 110345"},
        {"Smithsonian Astrophysical Observation", "SAO 34343"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.24760189),
        dec: Angle.Degrees(+51.07593576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124984"},
        {"Hipparcos Number", "HIP 69647"},
        {"Smithsonian Astrophysical Observation", "SAO 29058"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.81653108),
        dec: Angle.Degrees(+51.07637377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44386"},
        {"Hipparcos Number", "HIP 30474"},
        {"Smithsonian Astrophysical Observation", "SAO 25710"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.09882825),
        dec: Angle.Degrees(+51.07716517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218344"},
        {"Hipparcos Number", "HIP 114097"},
        {"Geneva Identification System", "GEN# +1.00218344"},
        {"Smithsonian Astrophysical Observation", "SAO 35142"},
        {"Wilson Evans Batten Catalogue", "WEB 20261"},
    },
    visualMagnitude: 7.42,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.63407268),
        dec: Angle.Degrees(+51.07720565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18008"},
        {"Hipparcos Number", "HIP 13623"},
        {"Geneva Identification System", "GEN# +1.00018008"},
        {"Smithsonian Astrophysical Observation", "SAO 23702"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.86875325),
        dec: Angle.Degrees(+51.07881438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36194",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36194"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.80832380),
        dec: Angle.Degrees(+51.07953662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233995"},
        {"Hipparcos Number", "HIP 63164"},
        {"Smithsonian Astrophysical Observation", "SAO 28574"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.13113223),
        dec: Angle.Degrees(+51.08002840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40204"},
        {"Hipparcos Number", "HIP 28424"},
        {"Smithsonian Astrophysical Observation", "SAO 25513"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.04015682),
        dec: Angle.Degrees(+51.08095554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235776"},
        {"Hipparcos Number", "HIP 109963"},
        {"Geneva Identification System", "GEN# +1.00235776"},
        {"Smithsonian Astrophysical Observation", "SAO 34249"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.07674360),
        dec: Angle.Degrees(+51.08578938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233273"},
        {"Hipparcos Number", "HIP 32113"},
        {"Smithsonian Astrophysical Observation", "SAO 25887"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.61483953),
        dec: Angle.Degrees(+51.08601756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232762"},
        {"Hipparcos Number", "HIP 14830"},
        {"Smithsonian Astrophysical Observation", "SAO 23862"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.87612638),
        dec: Angle.Degrees(+51.08636709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160343"},
        {"Hipparcos Number", "HIP 86185"},
        {"Smithsonian Astrophysical Observation", "SAO 30477"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.16812885),
        dec: Angle.Degrees(+51.08669768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71091"},
        {"Hipparcos Number", "HIP 41494"},
        {"Smithsonian Astrophysical Observation", "SAO 26847"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.93633138),
        dec: Angle.Degrees(+51.08941911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40323"},
        {"Hipparcos Number", "HIP 28493"},
        {"Smithsonian Astrophysical Observation", "SAO 25520"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.22306946),
        dec: Angle.Degrees(+51.08967854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26519",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4215 AB"},
        {"Henry Draper", "HD 37031"},
        {"Hipparcos Number", "HIP 26519"},
        {"Geneva Identification System", "GEN# +1.00037031J"},
        {"Smithsonian Astrophysical Observation", "SAO 25292"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.59242843),
        dec: Angle.Degrees(+51.08971383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91529",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11570 A"},
        {"Henry Draper", "HD 172884"},
        {"Hipparcos Number", "HIP 91529"},
        {"Geneva Identification System", "GEN# +1.00172884"},
        {"Smithsonian Astrophysical Observation", "SAO 31094"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.98442166),
        dec: Angle.Degrees(+51.09296644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46135"},
        {"Hipparcos Number", "HIP 31350"},
        {"Smithsonian Astrophysical Observation", "SAO 25816"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.60399431),
        dec: Angle.Degrees(+51.09478170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4475"},
        {"Hipparcos Number", "HIP 3698"},
        {"Smithsonian Astrophysical Observation", "SAO 21706"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.85256718),
        dec: Angle.Degrees(+51.09608592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30015"},
        {"Hipparcos Number", "HIP 22193"},
        {"Geneva Identification System", "GEN# +1.00030015"},
        {"Smithsonian Astrophysical Observation", "SAO 24815"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.61004136),
        dec: Angle.Degrees(+51.09609078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8124"},
        {"Hipparcos Number", "HIP 6359"},
        {"Smithsonian Astrophysical Observation", "SAO 22212"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.41941392),
        dec: Angle.Degrees(+51.09645852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12883"},
        {"Hipparcos Number", "HIP 9918"},
        {"Geneva Identification System", "GEN# +1.00012883"},
        {"Smithsonian Astrophysical Observation", "SAO 22946"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.91505691),
        dec: Angle.Degrees(+51.09775284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232273"},
        {"Hipparcos Number", "HIP 3703"},
        {"Smithsonian Astrophysical Observation", "SAO 21708"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.87622972),
        dec: Angle.Degrees(+51.10003359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97225"},
        {"Hipparcos Number", "HIP 54717"},
        {"Smithsonian Astrophysical Observation", "SAO 27948"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.04257639),
        dec: Angle.Degrees(+51.10207084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232747"},
        {"Hipparcos Number", "HIP 14420"},
        {"Smithsonian Astrophysical Observation", "SAO 23804"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.54545586),
        dec: Angle.Degrees(+51.10212607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20690"},
        {"Hipparcos Number", "HIP 15679"},
        {"Smithsonian Astrophysical Observation", "SAO 23984"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.50073430),
        dec: Angle.Degrees(+51.10316302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2874"},
        {"Hipparcos Number", "HIP 2564"},
        {"Geneva Identification System", "GEN# +1.00002874"},
        {"Smithsonian Astrophysical Observation", "SAO 21504"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.14313817),
        dec: Angle.Degrees(+51.10371953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185934"},
        {"Hipparcos Number", "HIP 96652"},
        {"Geneva Identification System", "GEN# +1.00185934"},
        {"Smithsonian Astrophysical Observation", "SAO 31857"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.76371993),
        dec: Angle.Degrees(+51.10453146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195014"},
        {"Hipparcos Number", "HIP 100824"},
        {"Geneva Identification System", "GEN# +1.00195014"},
        {"Smithsonian Astrophysical Observation", "SAO 32588"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.65723749),
        dec: Angle.Degrees(+51.10585126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29372"},
        {"Hipparcos Number", "HIP 21754"},
        {"Smithsonian Astrophysical Observation", "SAO 24747"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.06138477),
        dec: Angle.Degrees(+51.10717636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109279"},
        {"Hipparcos Number", "HIP 61253"},
        {"Smithsonian Astrophysical Observation", "SAO 28424"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.28900641),
        dec: Angle.Degrees(+51.10808116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11530"},
        {"Hipparcos Number", "HIP 8907"},
        {"Geneva Identification System", "GEN# +1.00011530"},
        {"Smithsonian Astrophysical Observation", "SAO 22734"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.67082488),
        dec: Angle.Degrees(+51.10999930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232335"},
        {"Hipparcos Number", "HIP 4627"},
        {"Smithsonian Astrophysical Observation", "SAO 21897"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.85600340),
        dec: Angle.Degrees(+51.11050996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214411"},
        {"Hipparcos Number", "HIP 111638"},
        {"Celescope Catalog", "CEL 5496"},
        {"Geneva Identification System", "GEN# +1.00214411"},
        {"Smithsonian Astrophysical Observation", "SAO 34621"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.23715778),
        dec: Angle.Degrees(+51.11117009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70222",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9238 AB"},
        {"Henry Draper", "HD 126126"},
        {"Hipparcos Number", "HIP 70222"},
        {"Smithsonian Astrophysical Observation", "SAO 29116"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.50497491),
        dec: Angle.Degrees(+51.11128580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171871"},
        {"Hipparcos Number", "HIP 91049"},
        {"Fundamental Katalog 5th Edition", "FK5 5631"},
        {"Geneva Identification System", "GEN# +1.00171871"},
        {"Smithsonian Astrophysical Observation", "SAO 31054"},
        {"Wilson Evans Batten Catalogue", "WEB 15625"},
    },
    visualMagnitude: 7.81,
    bvColour: -0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.59962698),
        dec: Angle.Degrees(+51.11312223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44846",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44846"},
        {"Wilson Evans Batten Catalogue", "WEB 8569"},
    },
    visualMagnitude: 10.61,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.06004224),
        dec: Angle.Degrees(+51.11371399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163091"},
        {"Hipparcos Number", "HIP 87398"},
        {"Smithsonian Astrophysical Observation", "SAO 30611"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.90837314),
        dec: Angle.Degrees(+51.11422613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27247"},
        {"Hipparcos Number", "HIP 20274"},
        {"Geneva Identification System", "GEN# +1.00027247"},
        {"Smithsonian Astrophysical Observation", "SAO 24548"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.18424299),
        dec: Angle.Degrees(+51.11596963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112805",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16307 AB"},
        {"Henry Draper", "HD 216255"},
        {"Hipparcos Number", "HIP 112805"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.66874779),
        dec: Angle.Degrees(+51.11606962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28176",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28176"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.29932506),
        dec: Angle.Degrees(+51.11698355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234022"},
        {"Hipparcos Number", "HIP 64513"},
        {"Smithsonian Astrophysical Observation", "SAO 28675"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.33954804),
        dec: Angle.Degrees(+51.12384303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235869"},
        {"Hipparcos Number", "HIP 111184"},
        {"Smithsonian Astrophysical Observation", "SAO 34544"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.85253107),
        dec: Angle.Degrees(+51.12402095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8295",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1402 AB"},
        {"Henry Draper", "HD 232528"},
        {"Hipparcos Number", "HIP 8295"},
        {"Smithsonian Astrophysical Observation", "SAO 22616"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.73668699),
        dec: Angle.Degrees(+51.12405069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91680",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11599 AB"},
        {"Henry Draper", "HD 173287"},
        {"Hipparcos Number", "HIP 91680"},
        {"Smithsonian Astrophysical Observation", "SAO 31111"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.43746944),
        dec: Angle.Degrees(+51.12598322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234036"},
        {"Hipparcos Number", "HIP 65455"},
        {"Smithsonian Astrophysical Observation", "SAO 28747"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.23339651),
        dec: Angle.Degrees(+51.12635081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236180"},
        {"Hipparcos Number", "HIP 116507"},
        {"Smithsonian Astrophysical Observation", "SAO 35594"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.13095373),
        dec: Angle.Degrees(+51.12699707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118065"},
        {"Hipparcos Number", "HIP 66133"},
        {"Smithsonian Astrophysical Observation", "SAO 28798"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.35805542),
        dec: Angle.Degrees(+51.12709673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52206",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52206"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.99411636),
        dec: Angle.Degrees(+51.12796140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233726"},
        {"Hipparcos Number", "HIP 50616"},
        {"Smithsonian Astrophysical Observation", "SAO 27607"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.08684723),
        dec: Angle.Degrees(+51.12811520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152465"},
        {"Hipparcos Number", "HIP 82441"},
        {"Smithsonian Astrophysical Observation", "SAO 30122"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.73099907),
        dec: Angle.Degrees(+51.12849277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233654"},
        {"Hipparcos Number", "HIP 47123"},
        {"Smithsonian Astrophysical Observation", "SAO 27309"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.03686271),
        dec: Angle.Degrees(+51.12902238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -177.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232532"},
        {"Hipparcos Number", "HIP 8324"},
        {"Smithsonian Astrophysical Observation", "SAO 22623"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.83147234),
        dec: Angle.Degrees(+51.13203841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204194"},
        {"Hipparcos Number", "HIP 105777"},
        {"Geneva Identification System", "GEN# +1.00204194"},
        {"Smithsonian Astrophysical Observation", "SAO 33417"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.34639786),
        dec: Angle.Degrees(+51.13272435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39862"},
        {"Hipparcos Number", "HIP 28250"},
        {"Smithsonian Astrophysical Observation", "SAO 25494"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.54625390),
        dec: Angle.Degrees(+51.13461757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4253",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 739 AB"},
        {"Hipparcos Number", "HIP 4253"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.846,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.56209382),
        dec: Angle.Degrees(+51.13675384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234955"},
        {"Hipparcos Number", "HIP 96699"},
        {"Smithsonian Astrophysical Observation", "SAO 31864"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.87516847),
        dec: Angle.Degrees(+51.13772504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149283"},
        {"Hipparcos Number", "HIP 80901"},
        {"Smithsonian Astrophysical Observation", "SAO 29970"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.81896182),
        dec: Angle.Degrees(+51.13804172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148433"},
        {"Hipparcos Number", "HIP 80469"},
        {"Geneva Identification System", "GEN# +1.00148433"},
        {"Smithsonian Astrophysical Observation", "SAO 29937"},
        {"Wilson Evans Batten Catalogue", "WEB 13615"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.38348541),
        dec: Angle.Degrees(+51.13852547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234358"},
        {"Hipparcos Number", "HIP 82607"},
        {"Smithsonian Astrophysical Observation", "SAO 30141"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.31602748),
        dec: Angle.Degrees(+51.14000087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197677"},
        {"Hipparcos Number", "HIP 102255"},
        {"Geneva Identification System", "GEN# +1.00197677"},
        {"Smithsonian Astrophysical Observation", "SAO 32827"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.79714070),
        dec: Angle.Degrees(+51.14425071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116752"},
        {"Hipparcos Number", "HIP 65434"},
        {"Smithsonian Astrophysical Observation", "SAO 28742"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.16539811),
        dec: Angle.Degrees(+51.14440408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234842"},
        {"Hipparcos Number", "HIP 94565"},
        {"Smithsonian Astrophysical Observation", "SAO 31505"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.68750364),
        dec: Angle.Degrees(+51.14509850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234720"},
        {"Hipparcos Number", "HIP 92447"},
        {"Smithsonian Astrophysical Observation", "SAO 31191"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.59312884),
        dec: Angle.Degrees(+51.14682727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235290"},
        {"Hipparcos Number", "HIP 101654"},
        {"Smithsonian Astrophysical Observation", "SAO 32725"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.09294252),
        dec: Angle.Degrees(+51.14780051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121047"},
        {"Hipparcos Number", "HIP 67686"},
        {"Geneva Identification System", "GEN# +1.00121047"},
        {"Smithsonian Astrophysical Observation", "SAO 28912"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.98850719),
        dec: Angle.Degrees(+51.14857892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15383"},
        {"Hipparcos Number", "HIP 11658"},
        {"Smithsonian Astrophysical Observation", "SAO 23386"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.58659700),
        dec: Angle.Degrees(+51.14910708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145434"},
        {"Hipparcos Number", "HIP 79074"},
        {"Smithsonian Astrophysical Observation", "SAO 29815"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.13071613),
        dec: Angle.Degrees(+51.15058235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201034"},
        {"Hipparcos Number", "HIP 104084"},
        {"Geneva Identification System", "GEN# +1.00201034"},
        {"Smithsonian Astrophysical Observation", "SAO 33121"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.30896024),
        dec: Angle.Degrees(+51.15097262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193343"},
        {"Hipparcos Number", "HIP 100022"},
        {"Smithsonian Astrophysical Observation", "SAO 32440"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.39863513),
        dec: Angle.Degrees(+51.15232501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76385"},
        {"Hipparcos Number", "HIP 44023"},
        {"Smithsonian Astrophysical Observation", "SAO 27060"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.48131752),
        dec: Angle.Degrees(+51.15370063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140627"},
        {"Hipparcos Number", "HIP 76923"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.60287832),
        dec: Angle.Degrees(+51.15412462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188626"},
        {"Hipparcos Number", "HIP 97902"},
        {"Smithsonian Astrophysical Observation", "SAO 32087"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.43597121),
        dec: Angle.Degrees(+51.15436717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100917"},
        {"Hipparcos Number", "HIP 56665"},
        {"Geneva Identification System", "GEN# +1.00100917"},
        {"Smithsonian Astrophysical Observation", "SAO 28076"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.28457843),
        dec: Angle.Degrees(+51.15456730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114375"},
        {"Hipparcos Number", "HIP 64194"},
        {"Smithsonian Astrophysical Observation", "SAO 28650"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.34460338),
        dec: Angle.Degrees(+51.15500177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214780"},
        {"Hipparcos Number", "HIP 111868"},
        {"Geneva Identification System", "GEN# +1.00214780"},
        {"Smithsonian Astrophysical Observation", "SAO 34664"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.89188605),
        dec: Angle.Degrees(+51.15551661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 180.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98055"},
        {"Hipparcos Number", "HIP 55134"},
        {"Smithsonian Astrophysical Observation", "SAO 27976"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.31039881),
        dec: Angle.Degrees(+51.16195892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233921"},
        {"Hipparcos Number", "HIP 60054"},
        {"Smithsonian Astrophysical Observation", "SAO 28335"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.74006528),
        dec: Angle.Degrees(+51.16390275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38439"},
        {"Hipparcos Number", "HIP 27443"},
        {"Geneva Identification System", "GEN# +1.00038439"},
        {"Smithsonian Astrophysical Observation", "SAO 25388"},
    },
    visualMagnitude: 7.98,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.16136663),
        dec: Angle.Degrees(+51.16528306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29609",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4818 AB"},
        {"Henry Draper", "HD 42614"},
        {"Hipparcos Number", "HIP 29609"},
        {"Smithsonian Astrophysical Observation", "SAO 25632"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.59304417),
        dec: Angle.Degrees(+51.16648681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19322"},
        {"Hipparcos Number", "HIP 14597"},
        {"Geneva Identification System", "GEN# +5.20200040"},
        {"Smithsonian Astrophysical Observation", "SAO 23831"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.11231690),
        dec: Angle.Degrees(+51.16651502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17902"},
        {"Hipparcos Number", "HIP 13540"},
        {"Geneva Identification System", "GEN# +1.00017902"},
        {"Smithsonian Astrophysical Observation", "SAO 23686"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.59526888),
        dec: Angle.Degrees(+51.16699229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26370"},
        {"Hipparcos Number", "HIP 19650"},
        {"Geneva Identification System", "GEN# +1.00026370"},
        {"Smithsonian Astrophysical Observation", "SAO 24466"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.15763567),
        dec: Angle.Degrees(+51.16835877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21586",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21586"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.53199355),
        dec: Angle.Degrees(+51.17073678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 168.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -250.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234083"},
        {"Hipparcos Number", "HIP 67832"},
        {"Smithsonian Astrophysical Observation", "SAO 28926"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.42096294),
        dec: Angle.Degrees(+51.17164055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42466"},
        {"Hipparcos Number", "HIP 29569"},
        {"Geneva Identification System", "GEN# +1.00042466"},
        {"Smithsonian Astrophysical Observation", "SAO 25630"},
        {"Wilson Evans Batten Catalogue", "WEB 5813"},
    },
    visualMagnitude: 6.07,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.43893097),
        dec: Angle.Degrees(+51.17262369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8398"},
        {"Hipparcos Number", "HIP 6548"},
        {"Geneva Identification System", "GEN# +1.00008398"},
        {"Smithsonian Astrophysical Observation", "SAO 22242"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.04878609),
        dec: Angle.Degrees(+51.17353456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76626"},
        {"Hipparcos Number", "HIP 44144"},
        {"Smithsonian Astrophysical Observation", "SAO 27072"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.85301398),
        dec: Angle.Degrees(+51.17357986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22872"},
        {"Hipparcos Number", "HIP 17341"},
        {"Geneva Identification System", "GEN# +1.00022872"},
        {"Smithsonian Astrophysical Observation", "SAO 24174"},
        {"Wilson Evans Batten Catalogue", "WEB 3278"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.67295483),
        dec: Angle.Degrees(+51.17360532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 199.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170577"},
        {"Hipparcos Number", "HIP 90456"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.86819540),
        dec: Angle.Degrees(+51.17459163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235960"},
        {"Hipparcos Number", "HIP 112555"},
        {"Smithsonian Astrophysical Observation", "SAO 34833"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.94894982),
        dec: Angle.Degrees(+51.17691935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232122"},
        {"Hipparcos Number", "HIP 884"},
        {"Smithsonian Astrophysical Observation", "SAO 21174"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.70055534),
        dec: Angle.Degrees(+51.17784908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50979",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50979"},
        {"Smithsonian Astrophysical Observation", "SAO 27635"},
    },
    visualMagnitude: 10.17,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.20052107),
        dec: Angle.Degrees(+51.17806577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236293"},
        {"Hipparcos Number", "HIP 405"},
        {"Geneva Identification System", "GEN# +1.00236293"},
        {"Smithsonian Astrophysical Observation", "SAO 21064"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.23950992),
        dec: Angle.Degrees(+51.18064908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234224"},
        {"Hipparcos Number", "HIP 75203"},
        {"Smithsonian Astrophysical Observation", "SAO 29499"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.52500486),
        dec: Angle.Degrees(+51.18192056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87907",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10941 AB"},
        {"Henry Draper", "HD 234522"},
        {"Hipparcos Number", "HIP 87907"},
        {"Smithsonian Astrophysical Observation", "SAO 30657"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.35023674),
        dec: Angle.Degrees(+51.18833763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232677"},
        {"Hipparcos Number", "HIP 12040"},
        {"Geneva Identification System", "GEN# +1.00232677"},
        {"Smithsonian Astrophysical Observation", "SAO 23445"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.79874012),
        dec: Angle.Degrees(+51.18893667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218964"},
        {"Hipparcos Number", "HIP 114523"},
        {"Geneva Identification System", "GEN# +1.00218964"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.94136597),
        dec: Angle.Degrees(+51.18961175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107136",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Azelfafage"},
        {"Henry Draper", "HD 206672"},
        {"Hipparcos Number", "HIP 107136"},
        {"Celescope Catalog", "CEL 5369"},
        {"Fundamental Katalog 5th Edition", "FK5 3733"},
        {"Geneva Identification System", "GEN# +1.00206672"},
        {"Smithsonian Astrophysical Observation", "SAO 33665"},
        {"Wilson Evans Batten Catalogue", "WEB 19353"},
    },
    visualMagnitude: 4.69,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.52358201),
        dec: Angle.Degrees(+51.18962710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211004"},
        {"Hipparcos Number", "HIP 109668"},
        {"Geneva Identification System", "GEN# +1.00211004"},
        {"Smithsonian Astrophysical Observation", "SAO 34177"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.24116189),
        dec: Angle.Degrees(+51.19028082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234067"},
        {"Hipparcos Number", "HIP 67022"},
        {"Smithsonian Astrophysical Observation", "SAO 28868"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.02609393),
        dec: Angle.Degrees(+51.19058597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19852",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19852"},
        {"Geneva Identification System", "GEN# +2.15280003"},
        {"New General Catalogue", "NGC 1528 3"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.84313876),
        dec: Angle.Degrees(+51.19060274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232174"},
        {"Hipparcos Number", "HIP 1839"},
        {"Geneva Identification System", "GEN# +1.00232174"},
        {"Smithsonian Astrophysical Observation", "SAO 21347"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.82068886),
        dec: Angle.Degrees(+51.19456587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212511"},
        {"Hipparcos Number", "HIP 110543"},
        {"Smithsonian Astrophysical Observation", "SAO 34397"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.90496063),
        dec: Angle.Degrees(+51.19569360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218546"},
        {"Hipparcos Number", "HIP 114245"},
        {"Smithsonian Astrophysical Observation", "SAO 35163"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.07173436),
        dec: Angle.Degrees(+51.19622803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23727"},
        {"Hipparcos Number", "HIP 17905"},
        {"Geneva Identification System", "GEN# +1.00023727"},
        {"Smithsonian Astrophysical Observation", "SAO 24251"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.43639386),
        dec: Angle.Degrees(+51.19625670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11251"},
        {"Hipparcos Number", "HIP 8696"},
        {"Geneva Identification System", "GEN# +1.00011251"},
        {"Smithsonian Astrophysical Observation", "SAO 22691"},
    },
    visualMagnitude: 9.08,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.97524240),
        dec: Angle.Degrees(+51.19849666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232292"},
        {"Hipparcos Number", "HIP 4034"},
        {"Geneva Identification System", "GEN# +1.00232292"},
        {"Smithsonian Astrophysical Observation", "SAO 21776"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.91662151),
        dec: Angle.Degrees(+51.19998049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46776"},
        {"Hipparcos Number", "HIP 31719"},
        {"Smithsonian Astrophysical Observation", "SAO 25850"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.52652922),
        dec: Angle.Degrees(+51.20212015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233990"},
        {"Hipparcos Number", "HIP 62846"},
        {"Smithsonian Astrophysical Observation", "SAO 28547"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.19912376),
        dec: Angle.Degrees(+51.20238048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113697"},
        {"Hipparcos Number", "HIP 63806"},
        {"Geneva Identification System", "GEN# +1.00113697"},
        {"Renson", "Renson 32957"},
        {"Smithsonian Astrophysical Observation", "SAO 28627"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.17703598),
        dec: Angle.Degrees(+51.20281461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232316"},
        {"Hipparcos Number", "HIP 4287"},
        {"Geneva Identification System", "GEN# +1.00232316"},
        {"Smithsonian Astrophysical Observation", "SAO 21834"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.74103489),
        dec: Angle.Degrees(+51.20369375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108400"},
        {"Hipparcos Number", "HIP 60731"},
        {"Smithsonian Astrophysical Observation", "SAO 28389"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.70792431),
        dec: Angle.Degrees(+51.20578471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203028"},
        {"Hipparcos Number", "HIP 105134"},
        {"Geneva Identification System", "GEN# +1.00203028"},
        {"Smithsonian Astrophysical Observation", "SAO 33294"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.46955560),
        dec: Angle.Degrees(+51.20727679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29307"},
        {"Hipparcos Number", "HIP 21712"},
        {"Geneva Identification System", "GEN# +1.00029307"},
        {"Smithsonian Astrophysical Observation", "SAO 24742"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.93015329),
        dec: Angle.Degrees(+51.20826436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137589"},
        {"Hipparcos Number", "HIP 75449"},
        {"Smithsonian Astrophysical Observation", "SAO 29516"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.20871764),
        dec: Angle.Degrees(+51.21023217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235350"},
        {"Hipparcos Number", "HIP 102410"},
        {"Geneva Identification System", "GEN# +1.00235350"},
        {"Smithsonian Astrophysical Observation", "SAO 32856"},
        {"Wilson Evans Batten Catalogue", "WEB 18544"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.29417105),
        dec: Angle.Degrees(+51.21056920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235874"},
        {"Hipparcos Number", "HIP 111309"},
        {"Geneva Identification System", "GEN# +1.00235874"},
        {"Smithsonian Astrophysical Observation", "SAO 34560"},
        {"Wilson Evans Batten Catalogue", "WEB 19914"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.24895979),
        dec: Angle.Degrees(+51.21560210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26113",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26113"},
    },
    visualMagnitude: 11.07,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.53630164),
        dec: Angle.Degrees(+51.21619546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -222.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20191"},
        {"Hipparcos Number", "HIP 15259"},
        {"Geneva Identification System", "GEN# +5.20200333"},
        {"Smithsonian Astrophysical Observation", "SAO 23924"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.20447717),
        dec: Angle.Degrees(+51.21824441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121664"},
        {"Hipparcos Number", "HIP 68003"},
        {"Geneva Identification System", "GEN# +1.00121664"},
        {"Smithsonian Astrophysical Observation", "SAO 28932"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.88578312),
        dec: Angle.Degrees(+51.22015886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109647"},
        {"Hipparcos Number", "HIP 61481"},
        {"Geneva Identification System", "GEN# +1.00109647"},
        {"Smithsonian Astrophysical Observation", "SAO 28439"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.96326263),
        dec: Angle.Degrees(+51.22148513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6260"},
        {"Hipparcos Number", "HIP 5024"},
        {"Smithsonian Astrophysical Observation", "SAO 21979"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.09492690),
        dec: Angle.Degrees(+51.22230796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232703"},
        {"Hipparcos Number", "HIP 12782"},
        {"Smithsonian Astrophysical Observation", "SAO 23577"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.07510396),
        dec: Angle.Degrees(+51.22433084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223152"},
        {"Hipparcos Number", "HIP 117290"},
        {"Smithsonian Astrophysical Observation", "SAO 35757"},
        {"Wilson Evans Batten Catalogue", "WEB 20664"},
    },
    visualMagnitude: 7.49,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.73454311),
        dec: Angle.Degrees(+51.22899986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168428"},
        {"Hipparcos Number", "HIP 89582"},
        {"Geneva Identification System", "GEN# +1.00168428"},
        {"Smithsonian Astrophysical Observation", "SAO 30861"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.20575120),
        dec: Angle.Degrees(+51.22908468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26603"},
        {"Hipparcos Number", "HIP 19813"},
        {"Geneva Identification System", "GEN# +2.15280001"},
        {"Renson", "Renson 6800"},
        {"Smithsonian Astrophysical Observation", "SAO 24496"},
        {"New General Catalogue", "NGC 1528 1"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.73809864),
        dec: Angle.Degrees(+51.23229683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185752"},
        {"Hipparcos Number", "HIP 96595"},
        {"Smithsonian Astrophysical Observation", "SAO 31840"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.54813368),
        dec: Angle.Degrees(+51.23579729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209285"},
        {"Hipparcos Number", "HIP 108662"},
        {"Geneva Identification System", "GEN# +1.00209285"},
        {"Smithsonian Astrophysical Observation", "SAO 33969"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.21089914),
        dec: Angle.Degrees(+51.23605711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184960"},
        {"Hipparcos Number", "HIP 96258"},
        {"Geneva Identification System", "GEN# +1.00184960"},
        {"Smithsonian Astrophysical Observation", "SAO 31782"},
        {"Wilson Evans Batten Catalogue", "WEB 16871"},
    },
    visualMagnitude: 5.71,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.58233594),
        dec: Angle.Degrees(+51.23707706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -188.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36082"},
        {"Hipparcos Number", "HIP 25926"},
        {"Geneva Identification System", "GEN# +1.00036082"},
        {"Smithsonian Astrophysical Observation", "SAO 25238"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.98648366),
        dec: Angle.Degrees(+51.23779685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192680"},
        {"Hipparcos Number", "HIP 99691"},
        {"Renson", "Renson 53750"},
        {"Smithsonian Astrophysical Observation", "SAO 32381"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.44723282),
        dec: Angle.Degrees(+51.23962668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213606"},
        {"Hipparcos Number", "HIP 111197"},
        {"Geneva Identification System", "GEN# +1.00213606"},
        {"Smithsonian Astrophysical Observation", "SAO 34548"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.91049276),
        dec: Angle.Degrees(+51.24144061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162900"},
        {"Hipparcos Number", "HIP 87328"},
        {"Smithsonian Astrophysical Observation", "SAO 30605"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.65752024),
        dec: Angle.Degrees(+51.24209279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222172"},
        {"Hipparcos Number", "HIP 116621"},
        {"Smithsonian Astrophysical Observation", "SAO 35622"},
    },
    visualMagnitude: 8.41,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.50531371),
        dec: Angle.Degrees(+51.24246102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75840"},
        {"Hipparcos Number", "HIP 43738"},
        {"Geneva Identification System", "GEN# +1.00075840"},
        {"Smithsonian Astrophysical Observation", "SAO 27040"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.62631657),
        dec: Angle.Degrees(+51.24461780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234381"},
        {"Hipparcos Number", "HIP 83484"},
        {"Smithsonian Astrophysical Observation", "SAO 30219"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.93852808),
        dec: Angle.Degrees(+51.24681575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19833",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3074 AB"},
        {"Henry Draper", "HD 232923"},
        {"Hipparcos Number", "HIP 19833"},
        {"Geneva Identification System", "GEN# +2.15280002"},
        {"Smithsonian Astrophysical Observation", "SAO 24501"},
        {"New General Catalogue", "NGC 1528 2"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.79061208),
        dec: Angle.Degrees(+51.24696351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205058"},
        {"Hipparcos Number", "HIP 106238"},
        {"Geneva Identification System", "GEN# +1.00205058"},
        {"Smithsonian Astrophysical Observation", "SAO 33491"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.78109245),
        dec: Angle.Degrees(+51.24938585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110254",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15845 AB"},
        {"Henry Draper", "HD 235801"},
        {"Hipparcos Number", "HIP 110254"},
        {"Smithsonian Astrophysical Observation", "SAO 34322"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.00225990),
        dec: Angle.Degrees(+51.25059827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212691"},
        {"Hipparcos Number", "HIP 110661"},
        {"Geneva Identification System", "GEN# +1.00212691"},
        {"Smithsonian Astrophysical Observation", "SAO 34425"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.26386396),
        dec: Angle.Degrees(+51.25581722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93727"},
        {"Hipparcos Number", "HIP 52976"},
        {"Geneva Identification System", "GEN# +1.00093727"},
        {"Smithsonian Astrophysical Observation", "SAO 27781"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.54706457),
        dec: Angle.Degrees(+51.25829742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128658"},
        {"Hipparcos Number", "HIP 71431"},
        {"Geneva Identification System", "GEN# +1.00128658"},
        {"Smithsonian Astrophysical Observation", "SAO 29216"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.10444266),
        dec: Angle.Degrees(+51.25960113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232475"},
        {"Hipparcos Number", "HIP 7529"},
        {"Smithsonian Astrophysical Observation", "SAO 22438"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.23953263),
        dec: Angle.Degrees(+51.26051913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18153"},
        {"Hipparcos Number", "HIP 13732"},
        {"Geneva Identification System", "GEN# +1.00018153"},
        {"Smithsonian Astrophysical Observation", "SAO 23721"},
        {"Wilson Evans Batten Catalogue", "WEB 2721"},
    },
    visualMagnitude: 6.22,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.21108016),
        dec: Angle.Degrees(+51.26135139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221913"},
        {"Hipparcos Number", "HIP 116440"},
        {"Smithsonian Astrophysical Observation", "SAO 35577"},
        {"Wilson Evans Batten Catalogue", "WEB 20571"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.92751221),
        dec: Angle.Degrees(+51.26392309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96326"},
        {"Hipparcos Number", "HIP 54342"},
        {"Geneva Identification System", "GEN# +1.00096326"},
        {"Smithsonian Astrophysical Observation", "SAO 27912"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.75476762),
        dec: Angle.Degrees(+51.26398253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92556",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11780 AB"},
        {"Henry Draper", "HD 234729"},
        {"Henry Draper 2", "HD 234730"},
        {"Hipparcos Number", "HIP 92556"},
        {"Smithsonian Astrophysical Observation", "SAO 31216"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.91337997),
        dec: Angle.Degrees(+51.26403597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45836",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7303 A"},
        {"Henry Draper", "HD 80290"},
        {"Hipparcos Number", "HIP 45836"},
        {"Geneva Identification System", "GEN# +1.00080290"},
        {"Smithsonian Astrophysical Observation", "SAO 27215"},
        {"Wilson Evans Batten Catalogue", "WEB 8690"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.18247620),
        dec: Angle.Degrees(+51.26571262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 145.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3497"},
        {"Hipparcos Number", "HIP 3018"},
        {"Smithsonian Astrophysical Observation", "SAO 21588"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.60362061),
        dec: Angle.Degrees(+51.26844879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83839"},
        {"Hipparcos Number", "HIP 47635"},
        {"Smithsonian Astrophysical Observation", "SAO 27355"},
        {"Wilson Evans Batten Catalogue", "WEB 8924"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.68281276),
        dec: Angle.Degrees(+51.26856293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233899"},
        {"Hipparcos Number", "HIP 59194"},
        {"Smithsonian Astrophysical Observation", "SAO 28256"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.08640593),
        dec: Angle.Degrees(+51.27144184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98070",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98070"},
        {"Cincinnati Publication", "Ci 20 1175"},
    },
    visualMagnitude: 12.28,
    bvColour: 1.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.96820735),
        dec: Angle.Degrees(+51.27196406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 469.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 342.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57045"},
        {"Hipparcos Number", "HIP 35729"},
        {"Smithsonian Astrophysical Observation", "SAO 26304"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.55852028),
        dec: Angle.Degrees(+51.27867034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235972"},
        {"Hipparcos Number", "HIP 112767"},
        {"Smithsonian Astrophysical Observation", "SAO 34864"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.55834267),
        dec: Angle.Degrees(+51.28000657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2207"},
        {"Hipparcos Number", "HIP 2085"},
        {"Geneva Identification System", "GEN# +1.00002207"},
        {"Smithsonian Astrophysical Observation", "SAO 21398"},
        {"Wilson Evans Batten Catalogue", "WEB 392"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.58102835),
        dec: Angle.Degrees(+51.28037084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202616"},
        {"Hipparcos Number", "HIP 104919"},
        {"Smithsonian Astrophysical Observation", "SAO 33260"},
        {"Wilson Evans Batten Catalogue", "WEB 19073"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.79537763),
        dec: Angle.Degrees(+51.28191443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35962"},
        {"Hipparcos Number", "HIP 25855"},
        {"Geneva Identification System", "GEN# +1.00035962"},
        {"Smithsonian Astrophysical Observation", "SAO 25228"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.78707232),
        dec: Angle.Degrees(+51.28275990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220241"},
        {"Hipparcos Number", "HIP 115339"},
        {"Smithsonian Astrophysical Observation", "SAO 35351"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.42524130),
        dec: Angle.Degrees(+51.28383587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52450"},
        {"Hipparcos Number", "HIP 34079"},
        {"Smithsonian Astrophysical Observation", "SAO 26131"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.01096090),
        dec: Angle.Degrees(+51.28591869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111663",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16119 AB"},
        {"Henry Draper", "HD 214443"},
        {"Hipparcos Number", "HIP 111663"},
        {"Smithsonian Astrophysical Observation", "SAO 34624"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.31206043),
        dec: Angle.Degrees(+51.28593878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69603"},
        {"Hipparcos Number", "HIP 40829"},
        {"Geneva Identification System", "GEN# +1.00069603"},
        {"Smithsonian Astrophysical Observation", "SAO 26780"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.99870043),
        dec: Angle.Degrees(+51.28732054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190770"},
        {"Hipparcos Number", "HIP 98836"},
        {"Smithsonian Astrophysical Observation", "SAO 32253"},
        {"Wilson Evans Batten Catalogue", "WEB 17528"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.06144782),
        dec: Angle.Degrees(+51.28797981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194682"},
        {"Hipparcos Number", "HIP 100696"},
        {"Smithsonian Astrophysical Observation", "SAO 32542"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.21304721),
        dec: Angle.Degrees(+51.28973646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14436"},
        {"Hipparcos Number", "HIP 10981"},
        {"Celescope Catalog", "CEL 259"},
        {"Geneva Identification System", "GEN# +1.00014436"},
        {"Smithsonian Astrophysical Observation", "SAO 23235"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.37251197),
        dec: Angle.Degrees(+51.29001965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235480"},
        {"Hipparcos Number", "HIP 105163"},
        {"Smithsonian Astrophysical Observation", "SAO 33300"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.54577214),
        dec: Angle.Degrees(+51.29088198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118557"},
        {"Hipparcos Number", "HIP 66382"},
        {"Smithsonian Astrophysical Observation", "SAO 28814"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.15141493),
        dec: Angle.Degrees(+51.29436128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14490",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14490"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.76702362),
        dec: Angle.Degrees(+51.29458621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46385"},
        {"Hipparcos Number", "HIP 31499"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.95686973),
        dec: Angle.Degrees(+51.29596239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124693"},
        {"Hipparcos Number", "HIP 69492"},
        {"Smithsonian Astrophysical Observation", "SAO 29048"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.41652755),
        dec: Angle.Degrees(+51.29649143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98229",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13191 AB"},
        {"Henry Draper", "HD 189451"},
        {"Hipparcos Number", "HIP 98229"},
        {"Smithsonian Astrophysical Observation", "SAO 32143"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.42548271),
        dec: Angle.Degrees(+51.29873709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169355"},
        {"Hipparcos Number", "HIP 89978"},
        {"Smithsonian Astrophysical Observation", "SAO 30917"},
    },
    visualMagnitude: 6.65,
    bvColour: 1.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.37286063),
        dec: Angle.Degrees(+51.30114427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235843"},
        {"Hipparcos Number", "HIP 110751"},
        {"Smithsonian Astrophysical Observation", "SAO 34447"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.55614230),
        dec: Angle.Degrees(+51.30346159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63835"},
        {"Hipparcos Number", "HIP 38522"},
        {"Geneva Identification System", "GEN# +1.00063835"},
        {"Smithsonian Astrophysical Observation", "SAO 26552"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.32983155),
        dec: Angle.Degrees(+51.30352878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80355"},
        {"Hipparcos Number", "HIP 45859"},
        {"Geneva Identification System", "GEN# +1.00080355"},
        {"Smithsonian Astrophysical Observation", "SAO 27217"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.26267853),
        dec: Angle.Degrees(+51.30566820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 141.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213159"},
        {"Hipparcos Number", "HIP 110924"},
        {"Celescope Catalog", "CEL 5479"},
        {"Geneva Identification System", "GEN# +1.00213159"},
        {"Smithsonian Astrophysical Observation", "SAO 34484"},
    },
    visualMagnitude: 7.73,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.10640540),
        dec: Angle.Degrees(+51.30624491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125349"},
        {"Hipparcos Number", "HIP 69818"},
        {"Geneva Identification System", "GEN# +1.00125349"},
        {"Renson", "Renson 35810"},
        {"Smithsonian Astrophysical Observation", "SAO 29086"},
        {"Wilson Evans Batten Catalogue", "WEB 12152"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.33817309),
        dec: Angle.Degrees(+51.30739213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175900"},
        {"Hipparcos Number", "HIP 92835"},
        {"Geneva Identification System", "GEN# +1.00175900"},
        {"Smithsonian Astrophysical Observation", "SAO 31262"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.72274465),
        dec: Angle.Degrees(+51.30807291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233721"},
        {"Hipparcos Number", "HIP 50127"},
        {"Smithsonian Astrophysical Observation", "SAO 27570"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.49026085),
        dec: Angle.Degrees(+51.30810446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105720"},
        {"Hipparcos Number", "HIP 59312"},
        {"Smithsonian Astrophysical Observation", "SAO 28268"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.51983458),
        dec: Angle.Degrees(+51.30982529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233752"},
        {"Hipparcos Number", "HIP 51880"},
        {"Smithsonian Astrophysical Observation", "SAO 27702"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.99785621),
        dec: Angle.Degrees(+51.31190106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233912"},
        {"Hipparcos Number", "HIP 59595"},
        {"Geneva Identification System", "GEN# +1.00233912"},
        {"Smithsonian Astrophysical Observation", "SAO 28304"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.32247525),
        dec: Angle.Degrees(+51.31223884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59721"},
        {"Hipparcos Number", "HIP 36779"},
        {"Smithsonian Astrophysical Observation", "SAO 26407"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.46469859),
        dec: Angle.Degrees(+51.31420147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198638"},
        {"Hipparcos Number", "HIP 102801"},
        {"Geneva Identification System", "GEN# +1.00198638"},
        {"Smithsonian Astrophysical Observation", "SAO 32921"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.40296050),
        dec: Angle.Degrees(+51.31441426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39913",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6609 AB"},
        {"Henry Draper", "HD 67148"},
        {"Hipparcos Number", "HIP 39913"},
        {"Smithsonian Astrophysical Observation", "SAO 26693"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.27588575),
        dec: Angle.Degrees(+51.31664952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155764"},
        {"Hipparcos Number", "HIP 84044"},
        {"Smithsonian Astrophysical Observation", "SAO 30279"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.72700036),
        dec: Angle.Degrees(+51.31730653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233006"},
        {"Hipparcos Number", "HIP 22210"},
        {"Smithsonian Astrophysical Observation", "SAO 24816"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.64782018),
        dec: Angle.Degrees(+51.31738116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15487"},
        {"Hipparcos Number", "HIP 11721"},
        {"Smithsonian Astrophysical Observation", "SAO 23398"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.82531640),
        dec: Angle.Degrees(+51.32074949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233940"},
        {"Hipparcos Number", "HIP 60686"},
        {"Smithsonian Astrophysical Observation", "SAO 28385"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.56551939),
        dec: Angle.Degrees(+51.32076630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69697"},
        {"Hipparcos Number", "HIP 40867"},
        {"Smithsonian Astrophysical Observation", "SAO 26787"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.09367918),
        dec: Angle.Degrees(+51.32141065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79633"},
        {"Hipparcos Number", "HIP 45557"},
        {"Geneva Identification System", "GEN# +1.00079633"},
        {"Smithsonian Astrophysical Observation", "SAO 27197"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.28148181),
        dec: Angle.Degrees(+51.32219865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40131",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40131"},
        {"Geneva Identification System", "GEN# +6.20030515"},
    },
    visualMagnitude: 10.89,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.95346667),
        dec: Angle.Degrees(+51.32237252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 145.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233839"},
        {"Hipparcos Number", "HIP 56188"},
        {"Smithsonian Astrophysical Observation", "SAO 28042"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.76133815),
        dec: Angle.Degrees(+51.32511244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234773"},
        {"Hipparcos Number", "HIP 93366"},
        {"Smithsonian Astrophysical Observation", "SAO 31324"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.25572203),
        dec: Angle.Degrees(+51.33089443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9840"},
        {"Hipparcos Number", "HIP 7538"},
        {"Smithsonian Astrophysical Observation", "SAO 22440"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.28292257),
        dec: Angle.Degrees(+51.33120620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37183"},
        {"Hipparcos Number", "HIP 26622"},
        {"Smithsonian Astrophysical Observation", "SAO 25306"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.87703068),
        dec: Angle.Degrees(+51.33542613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150267"},
        {"Hipparcos Number", "HIP 81389"},
        {"Geneva Identification System", "GEN# +1.00150267"},
        {"Smithsonian Astrophysical Observation", "SAO 30020"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.32181258),
        dec: Angle.Degrees(+51.33828095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185147"},
        {"Hipparcos Number", "HIP 96331"},
        {"Geneva Identification System", "GEN# +1.00185147"},
        {"Smithsonian Astrophysical Observation", "SAO 31793"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.78636535),
        dec: Angle.Degrees(+51.34372200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 99.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232827"},
        {"Hipparcos Number", "HIP 17386"},
        {"Geneva Identification System", "GEN# +1.00232827"},
        {"Smithsonian Astrophysical Observation", "SAO 24181"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.84950340),
        dec: Angle.Degrees(+51.34466644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104525"},
        {"Hipparcos Number", "HIP 58694"},
        {"Smithsonian Astrophysical Observation", "SAO 28228"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.57357635),
        dec: Angle.Degrees(+51.34506866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181328"},
        {"Hipparcos Number", "HIP 94814"},
        {"Smithsonian Astrophysical Observation", "SAO 31540"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.38836796),
        dec: Angle.Degrees(+51.34646039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144110"},
        {"Hipparcos Number", "HIP 78519"},
        {"Geneva Identification System", "GEN# +1.00144110"},
        {"Smithsonian Astrophysical Observation", "SAO 29761"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.44806422),
        dec: Angle.Degrees(+51.34772433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51095"},
        {"Hipparcos Number", "HIP 33593"},
        {"Smithsonian Astrophysical Observation", "SAO 26077"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.69474482),
        dec: Angle.Degrees(+51.34793633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169028"},
        {"Hipparcos Number", "HIP 89835"},
        {"Geneva Identification System", "GEN# +1.00169028"},
        {"Smithsonian Astrophysical Observation", "SAO 30897"},
        {"Wilson Evans Batten Catalogue", "WEB 15333"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.98373083),
        dec: Angle.Degrees(+51.34794769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64812"},
        {"Hipparcos Number", "HIP 38953"},
        {"Smithsonian Astrophysical Observation", "SAO 26595"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.54632500),
        dec: Angle.Degrees(+51.35106622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234104"},
        {"Hipparcos Number", "HIP 68777"},
        {"Smithsonian Astrophysical Observation", "SAO 28999"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.16042442),
        dec: Angle.Degrees(+51.35196895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27083"},
        {"Hipparcos Number", "HIP 20164"},
        {"Smithsonian Astrophysical Observation", "SAO 24537"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.82566997),
        dec: Angle.Degrees(+51.35697817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236021"},
        {"Hipparcos Number", "HIP 113721"},
        {"Smithsonian Astrophysical Observation", "SAO 35074"},
    },
    visualMagnitude: 9.06,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.47310920),
        dec: Angle.Degrees(+51.35878951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235423"},
        {"Hipparcos Number", "HIP 103715"},
        {"Smithsonian Astrophysical Observation", "SAO 33066"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.25535366),
        dec: Angle.Degrees(+51.35955028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109529"},
        {"Hipparcos Number", "HIP 61403"},
        {"Smithsonian Astrophysical Observation", "SAO 28432"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.72656010),
        dec: Angle.Degrees(+51.36043294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158821"},
        {"Hipparcos Number", "HIP 85518"},
        {"Smithsonian Astrophysical Observation", "SAO 30406"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.14916112),
        dec: Angle.Degrees(+51.36135654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179705"},
        {"Hipparcos Number", "HIP 94239"},
        {"Geneva Identification System", "GEN# +1.00179705"},
        {"Smithsonian Astrophysical Observation", "SAO 31452"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.75291603),
        dec: Angle.Degrees(+51.36226660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234093"},
        {"Hipparcos Number", "HIP 68260"},
        {"Smithsonian Astrophysical Observation", "SAO 28952"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.60781137),
        dec: Angle.Degrees(+51.36398738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232743"},
        {"Hipparcos Number", "HIP 14309"},
        {"Smithsonian Astrophysical Observation", "SAO 23788"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.14585951),
        dec: Angle.Degrees(+51.36582695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69713",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9198 A"},
        {"Henry Draper", "HD 125161"},
        {"Hipparcos Number", "HIP 69713"},
        {"Celescope Catalog", "CEL 4309"},
        {"Fundamental Katalog 5th Edition", "FK5 528"},
        {"Geneva Identification System", "GEN# +1.00125161A"},
        {"Geneva Identification System 2", "GEN# +1.00125161"},
        {"Smithsonian Astrophysical Observation", "SAO 29071"},
        {"Wilson Evans Batten Catalogue", "WEB 12138"},
    },
    visualMagnitude: 4.75,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.04195627),
        dec: Angle.Degrees(+51.36701398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -149.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63278"},
        {"Hipparcos Number", "HIP 38277"},
        {"Geneva Identification System", "GEN# +1.00063278"},
        {"Smithsonian Astrophysical Observation", "SAO 26531"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.63175027),
        dec: Angle.Degrees(+51.36916060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55049"},
        {"Hipparcos Number", "HIP 34963"},
        {"Geneva Identification System", "GEN# +1.00055049"},
        {"Smithsonian Astrophysical Observation", "SAO 26230"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.50965986),
        dec: Angle.Degrees(+51.37124946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53634"},
        {"Hipparcos Number", "HIP 34451"},
        {"Smithsonian Astrophysical Observation", "SAO 26172"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.12595773),
        dec: Angle.Degrees(+51.37297238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38619"},
        {"Hipparcos Number", "HIP 27529"},
        {"Smithsonian Astrophysical Observation", "SAO 25398"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.45625578),
        dec: Angle.Degrees(+51.37353886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72508",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9405 A"},
        {"Henry Draper", "HD 131040"},
        {"Hipparcos Number", "HIP 72508"},
        {"Geneva Identification System", "GEN# +1.00131040A"},
        {"Smithsonian Astrophysical Observation", "SAO 29296"},
        {"Wilson Evans Batten Catalogue", "WEB 12464"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.38486434),
        dec: Angle.Degrees(+51.37449776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23581"},
        {"Hipparcos Number", "HIP 17807"},
        {"Geneva Identification System", "GEN# +1.00023581"},
        {"Smithsonian Astrophysical Observation", "SAO 24235"},
        {"Wilson Evans Batten Catalogue", "WEB 3418"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.16468224),
        dec: Angle.Degrees(+51.37601401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96734"},
        {"Hipparcos Number", "HIP 54518"},
        {"Smithsonian Astrophysical Observation", "SAO 27930"},
        {"Wilson Evans Batten Catalogue", "WEB 9839"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.31977967),
        dec: Angle.Degrees(+51.37899718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45389"},
        {"Hipparcos Number", "HIP 30955"},
        {"Smithsonian Astrophysical Observation", "SAO 25765"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.46657979),
        dec: Angle.Degrees(+51.37950923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178796"},
        {"Hipparcos Number", "HIP 93908"},
        {"Smithsonian Astrophysical Observation", "SAO 31395"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.83101932),
        dec: Angle.Degrees(+51.37963938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232289"},
        {"Hipparcos Number", "HIP 3956"},
        {"Smithsonian Astrophysical Observation", "SAO 21764"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.69625377),
        dec: Angle.Degrees(+51.38279960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 248.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232344"},
        {"Hipparcos Number", "HIP 4683"},
        {"Smithsonian Astrophysical Observation", "SAO 21910"},
        {"Wilson Evans Batten Catalogue", "WEB 881"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.04186402),
        dec: Angle.Degrees(+51.38483325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235425"},
        {"Hipparcos Number", "HIP 103717"},
        {"Smithsonian Astrophysical Observation", "SAO 33067"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.25882032),
        dec: Angle.Degrees(+51.38495994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118188",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17135 A"},
        {"Henry Draper", "HD 224490"},
        {"Hipparcos Number", "HIP 118188"},
        {"Smithsonian Astrophysical Observation", "SAO 35938"},
        {"Wilson Evans Batten Catalogue", "WEB 20776"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.60330655),
        dec: Angle.Degrees(+51.38876254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87312"},
        {"Hipparcos Number", "HIP 49437"},
        {"Fundamental Katalog 5th Edition", "FK5 4899"},
        {"Geneva Identification System", "GEN# +1.00087312"},
        {"Smithsonian Astrophysical Observation", "SAO 27516"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.39872976),
        dec: Angle.Degrees(+51.39111908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233566"},
        {"Hipparcos Number", "HIP 42832"},
        {"Smithsonian Astrophysical Observation", "SAO 26974"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.91267325),
        dec: Angle.Degrees(+51.39525207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118182",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17135 C"},
        {"Hipparcos Number", "HIP 118182"},
    },
    visualMagnitude: 11.10,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.59471012),
        dec: Angle.Degrees(+51.39526308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
