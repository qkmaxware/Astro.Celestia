using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_98() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87209"},
        {"Hipparcos Number", "HIP 49352"},
        {"Geneva Identification System", "GEN# +1.00087209"},
        {"Smithsonian Astrophysical Observation", "SAO 43169"},
        {"Wilson Evans Batten Catalogue", "WEB 9125"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.11741752),
        dec: Angle.Degrees(+42.37503654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19736"},
        {"Hipparcos Number", "HIP 14887"},
        {"Geneva Identification System", "GEN# +1.00019736"},
        {"Smithsonian Astrophysical Observation", "SAO 38635"},
        {"Wilson Evans Batten Catalogue", "WEB 2873"},
    },
    visualMagnitude: 6.15,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.03976290),
        dec: Angle.Degrees(+42.37594744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61480",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61480"},
        {"Geneva Identification System", "GEN# +6.20017177"},
        {"Renson", "Renson 31790"},
        {"Wilson Evans Batten Catalogue", "WEB 10942"},
    },
    visualMagnitude: 12.01,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.96308436),
        dec: Angle.Degrees(+42.37773464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71409",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71409"},
        {"Smithsonian Astrophysical Observation", "SAO 45129"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.03759207),
        dec: Angle.Degrees(+42.37817152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123280"},
        {"Hipparcos Number", "HIP 68838"},
        {"Geneva Identification System", "GEN# +1.00123280"},
        {"Smithsonian Astrophysical Observation", "SAO 44882"},
        {"Wilson Evans Batten Catalogue", "WEB 12036"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.43567662),
        dec: Angle.Degrees(+42.37846590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108776",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108776"},
    },
    visualMagnitude: 10.92,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.52430218),
        dec: Angle.Degrees(+42.37967000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27157"},
        {"Hipparcos Number", "HIP 20155"},
        {"Geneva Identification System", "GEN# +1.00027157"},
        {"Smithsonian Astrophysical Observation", "SAO 39461"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.80461243),
        dec: Angle.Degrees(+42.38133161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198690"},
        {"Hipparcos Number", "HIP 102885"},
        {"Celescope Catalog", "CEL 5184"},
        {"Geneva Identification System", "GEN# +1.00198690"},
        {"Smithsonian Astrophysical Observation", "SAO 50125"},
        {"Wilson Evans Batten Catalogue", "WEB 18665"},
    },
    visualMagnitude: 7.32,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.66517980),
        dec: Angle.Degrees(+42.38200906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72153",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9378 AB"},
        {"Henry Draper", "HD 130188"},
        {"Hipparcos Number", "HIP 72153"},
        {"Geneva Identification System", "GEN# +1.00130188"},
        {"Smithsonian Astrophysical Observation", "SAO 45208"},
        {"Wilson Evans Batten Catalogue", "WEB 12416"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.37392562),
        dec: Angle.Degrees(+42.38234127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3130",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3130"},
        {"Smithsonian Astrophysical Observation", "SAO 36560"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.94799300),
        dec: Angle.Degrees(+42.38361376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99170",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13415 AB"},
        {"Henry Draper", "HD 191394"},
        {"Hipparcos Number", "HIP 99170"},
        {"Smithsonian Astrophysical Observation", "SAO 49217"},
        {"Wilson Evans Batten Catalogue", "WEB 17654"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.00482577),
        dec: Angle.Degrees(+42.38499628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2470"},
        {"Hipparcos Number", "HIP 2258"},
        {"Smithsonian Astrophysical Observation", "SAO 36402"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.19092274),
        dec: Angle.Degrees(+42.38503688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84527"},
        {"Hipparcos Number", "HIP 47998"},
        {"Smithsonian Astrophysical Observation", "SAO 43034"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.76083625),
        dec: Angle.Degrees(+42.38561378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49954",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49954"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.98820897),
        dec: Angle.Degrees(+42.38580791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134302"},
        {"Hipparcos Number", "HIP 74030"},
        {"Smithsonian Astrophysical Observation", "SAO 45389"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.92524041),
        dec: Angle.Degrees(+42.38819622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207182"},
        {"Hipparcos Number", "HIP 107471"},
        {"Geneva Identification System", "GEN# +1.00207182"},
        {"Smithsonian Astrophysical Observation", "SAO 51274"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.51539296),
        dec: Angle.Degrees(+42.38923772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109388"},
        {"Hipparcos Number", "HIP 61335"},
        {"Geneva Identification System", "GEN# +1.00109388"},
        {"Smithsonian Astrophysical Observation", "SAO 44232"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.51853094),
        dec: Angle.Degrees(+42.38953308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212777"},
        {"Hipparcos Number", "HIP 110726"},
        {"Smithsonian Astrophysical Observation", "SAO 51989"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.50698922),
        dec: Angle.Degrees(+42.39080167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63212",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63212"},
        {"Smithsonian Astrophysical Observation", "SAO 44397"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.28440318),
        dec: Angle.Degrees(+42.39114487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15623"},
        {"Hipparcos Number", "HIP 11779"},
        {"Smithsonian Astrophysical Observation", "SAO 38096"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.99756955),
        dec: Angle.Degrees(+42.39130077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150204"},
        {"Hipparcos Number", "HIP 81416"},
        {"Smithsonian Astrophysical Observation", "SAO 46198"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.41788651),
        dec: Angle.Degrees(+42.39243519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17015",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17015"},
        {"Geneva Identification System", "GEN# +0.04100727"},
        {"Smithsonian Astrophysical Observation", "SAO 39014"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.72627928),
        dec: Angle.Degrees(+42.39372844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 189.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -298.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213800"},
        {"Hipparcos Number", "HIP 111329"},
        {"Smithsonian Astrophysical Observation", "SAO 52135"},
    },
    visualMagnitude: 9.19,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.33311018),
        dec: Angle.Degrees(+42.39493745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44386",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44386"},
        {"Smithsonian Astrophysical Observation", "SAO 42651"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.62413655),
        dec: Angle.Degrees(+42.39558774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105539",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105539"},
        {"Wilson Evans Batten Catalogue", "WEB 19161"},
    },
    visualMagnitude: 9.19,
    bvColour: 2.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.61963808),
        dec: Angle.Degrees(+42.39625613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43986",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43986"},
        {"Smithsonian Astrophysical Observation", "SAO 42619"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.36222593),
        dec: Angle.Degrees(+42.39921686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33411"},
        {"Hipparcos Number", "HIP 24223"},
        {"Geneva Identification System", "GEN# +1.00033411"},
        {"Smithsonian Astrophysical Observation", "SAO 40101"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.01477046),
        dec: Angle.Degrees(+42.39932684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16108"},
        {"Hipparcos Number", "HIP 12151"},
        {"Smithsonian Astrophysical Observation", "SAO 38161"},
        {"Wilson Evans Batten Catalogue", "WEB 2495"},
    },
    visualMagnitude: 6.80,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.15068726),
        dec: Angle.Degrees(+42.40057819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192832"},
        {"Hipparcos Number", "HIP 99839"},
        {"Geneva Identification System", "GEN# +1.00192832"},
        {"Smithsonian Astrophysical Observation", "SAO 49374"},
        {"Wilson Evans Batten Catalogue", "WEB 17949"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.84799933),
        dec: Angle.Degrees(+42.40100120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21564",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21564"},
    },
    visualMagnitude: 10.58,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.43550737),
        dec: Angle.Degrees(+42.40111972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79700",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79700"},
    },
    visualMagnitude: 11.93,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.98551294),
        dec: Angle.Degrees(+42.40253692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -257.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74390"},
        {"Hipparcos Number", "HIP 42953"},
        {"Smithsonian Astrophysical Observation", "SAO 42530"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.33914134),
        dec: Angle.Degrees(+42.40399999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205511"},
        {"Hipparcos Number", "HIP 106535"},
        {"Geneva Identification System", "GEN# +1.00205511"},
        {"Smithsonian Astrophysical Observation", "SAO 51048"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.65812220),
        dec: Angle.Degrees(+42.40461263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107979",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15400 D"},
        {"Henry Draper", "HD 208056"},
        {"Hipparcos Number", "HIP 107979"},
        {"Geneva Identification System", "GEN# +1.00208056"},
        {"Smithsonian Astrophysical Observation", "SAO 51393"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.13065379),
        dec: Angle.Degrees(+42.40519028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75868",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75868"},
        {"Smithsonian Astrophysical Observation", "SAO 45567"},
    },
    visualMagnitude: 10.17,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.45491997),
        dec: Angle.Degrees(+42.40540537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70955"},
        {"Hipparcos Number", "HIP 41376"},
        {"Smithsonian Astrophysical Observation", "SAO 42356"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.61518466),
        dec: Angle.Degrees(+42.40762565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111751",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111751"},
        {"Smithsonian Astrophysical Observation", "SAO 52208"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.56131179),
        dec: Angle.Degrees(+42.40819513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102570",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14295 AB"},
        {"Henry Draper", "HD 198195"},
        {"Hipparcos Number", "HIP 102570"},
        {"Celescope Catalog", "CEL 5167"},
        {"Smithsonian Astrophysical Observation", "SAO 50055"},
        {"Wilson Evans Batten Catalogue", "WEB 18585"},
    },
    visualMagnitude: 7.22,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.79131551),
        dec: Angle.Degrees(+42.40984207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199099"},
        {"Hipparcos Number", "HIP 103108"},
        {"Celescope Catalog", "CEL 5195"},
        {"Geneva Identification System", "GEN# +1.00199099"},
        {"Smithsonian Astrophysical Observation", "SAO 50183"},
        {"Wilson Evans Batten Catalogue", "WEB 18721"},
    },
    visualMagnitude: 6.67,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.35993293),
        dec: Angle.Degrees(+42.41021201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221102"},
        {"Hipparcos Number", "HIP 115887"},
        {"Smithsonian Astrophysical Observation", "SAO 53065"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.18968254),
        dec: Angle.Degrees(+42.41131689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 276595"},
        {"Hipparcos Number", "HIP 21610"},
    },
    visualMagnitude: 9.94,
    bvColour: 1.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.58888896),
        dec: Angle.Degrees(+42.41158861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69379",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9157 AB"},
        {"Henry Draper", "HD 124371"},
        {"Hipparcos Number", "HIP 69379"},
        {"Smithsonian Astrophysical Observation", "SAO 44932"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.04076095),
        dec: Angle.Degrees(+42.41193171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86109",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86109"},
        {"Smithsonian Astrophysical Observation", "SAO 46823"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.96449358),
        dec: Angle.Degrees(+42.41217096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184875"},
        {"Hipparcos Number", "HIP 96288"},
        {"Celescope Catalog", "CEL 4789"},
        {"Geneva Identification System", "GEN# +1.00184875"},
        {"Smithsonian Astrophysical Observation", "SAO 48601"},
        {"Wilson Evans Batten Catalogue", "WEB 16880"},
    },
    visualMagnitude: 5.34,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.67190527),
        dec: Angle.Degrees(+42.41258465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215029"},
        {"Hipparcos Number", "HIP 112037"},
        {"Smithsonian Astrophysical Observation", "SAO 52268"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.39090385),
        dec: Angle.Degrees(+42.41358212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68233",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68233"},
    },
    visualMagnitude: 11.55,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.52003185),
        dec: Angle.Degrees(+42.41503074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -292.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57586",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57586"},
        {"Geneva Identification System", "GEN# +0.04302152"},
        {"Smithsonian Astrophysical Observation", "SAO 43897"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.09551892),
        dec: Angle.Degrees(+42.41513898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25960",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4124 AB"},
        {"Henry Draper", "HD 36229"},
        {"Hipparcos Number", "HIP 25960"},
        {"Smithsonian Astrophysical Observation", "SAO 40406"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.07686463),
        dec: Angle.Degrees(+42.41589244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18880"},
        {"Hipparcos Number", "HIP 14244"},
        {"Geneva Identification System", "GEN# +1.00018880"},
        {"Smithsonian Astrophysical Observation", "SAO 38540"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.92455621),
        dec: Angle.Degrees(+42.41643834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33785"},
        {"Hipparcos Number", "HIP 24448"},
        {"Geneva Identification System", "GEN# +1.00033785"},
        {"Smithsonian Astrophysical Observation", "SAO 40149"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.66931176),
        dec: Angle.Degrees(+42.41843822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115831",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16773 AB"},
        {"Hipparcos Number", "HIP 115831"},
        {"Smithsonian Astrophysical Observation", "SAO 53053"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.99628778),
        dec: Angle.Degrees(+42.41866660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22019",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3400 AB"},
        {"Henry Draper", "HD 29833"},
        {"Hipparcos Number", "HIP 22019"},
        {"Celescope Catalog", "CEL 458"},
        {"Geneva Identification System", "GEN# +1.00029833J"},
        {"Smithsonian Astrophysical Observation", "SAO 39712"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.01273000),
        dec: Angle.Degrees(+42.41887110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41806"},
        {"Hipparcos Number", "HIP 29180"},
        {"Smithsonian Astrophysical Observation", "SAO 40891"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.34142540),
        dec: Angle.Degrees(+42.41964724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76827",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76827"},
    },
    visualMagnitude: 10.98,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.28826397),
        dec: Angle.Degrees(+42.42000231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79223",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79223"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.52447468),
        dec: Angle.Degrees(+42.42082022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66174"},
        {"Hipparcos Number", "HIP 39478"},
        {"Smithsonian Astrophysical Observation", "SAO 42151"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.02552074),
        dec: Angle.Degrees(+42.42099956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209438"},
        {"Hipparcos Number", "HIP 108795"},
        {"Smithsonian Astrophysical Observation", "SAO 51584"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.60588066),
        dec: Angle.Degrees(+42.42542117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97004"},
        {"Hipparcos Number", "HIP 54614"},
        {"Smithsonian Astrophysical Observation", "SAO 43637"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.65815774),
        dec: Angle.Degrees(+42.42614218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112214",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112214"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.90804314),
        dec: Angle.Degrees(+42.42742444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20498",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3172 AB"},
        {"Henry Draper", "HD 27650"},
        {"Hipparcos Number", "HIP 20498"},
        {"Celescope Catalog", "CEL 393"},
        {"Geneva Identification System", "GEN# +1.00027650J"},
        {"Renson", "Renson 7090"},
        {"Smithsonian Astrophysical Observation", "SAO 39501"},
        {"Wilson Evans Batten Catalogue", "WEB 3923"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.89916321),
        dec: Angle.Degrees(+42.42799219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42596",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42596"},
        {"Smithsonian Astrophysical Observation", "SAO 42487"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.22498744),
        dec: Angle.Degrees(+42.42835235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97974",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97974"},
        {"Smithsonian Astrophysical Observation", "SAO 48965"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.67159045),
        dec: Angle.Degrees(+42.43070065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 172.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 206.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67370"},
        {"Hipparcos Number", "HIP 39938"},
        {"Geneva Identification System", "GEN# +1.00067370"},
        {"Smithsonian Astrophysical Observation", "SAO 42199"},
        {"Wilson Evans Batten Catalogue", "WEB 7781"},
    },
    visualMagnitude: 6.26,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.34608921),
        dec: Angle.Degrees(+42.43078783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79496"},
        {"Hipparcos Number", "HIP 45468"},
        {"Smithsonian Astrophysical Observation", "SAO 42775"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.98041123),
        dec: Angle.Degrees(+42.43286738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201652"},
        {"Hipparcos Number", "HIP 104463"},
        {"Celescope Catalog", "CEL 5251"},
        {"Smithsonian Astrophysical Observation", "SAO 50509"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.41208140),
        dec: Angle.Degrees(+42.43321436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89812",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11269 B"},
        {"Hipparcos Number", "HIP 89812"},
    },
    visualMagnitude: 11.40,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.92737903),
        dec: Angle.Degrees(+44.89066997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125797"},
        {"Hipparcos Number", "HIP 70095"},
        {"Smithsonian Astrophysical Observation", "SAO 45001"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.15180095),
        dec: Angle.Degrees(+42.43475039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95237",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95237"},
        {"Smithsonian Astrophysical Observation", "SAO 48376"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.65139992),
        dec: Angle.Degrees(+42.43627341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149630"},
        {"Hipparcos Number", "HIP 81126"},
        {"Fundamental Katalog 5th Edition", "FK5 621"},
        {"Geneva Identification System", "GEN# +1.00149630"},
        {"Smithsonian Astrophysical Observation", "SAO 46161"},
        {"Wilson Evans Batten Catalogue", "WEB 13718"},
    },
    visualMagnitude: 4.20,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.52578863),
        dec: Angle.Degrees(+42.43689565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278195"},
        {"Hipparcos Number", "HIP 25642"},
        {"Geneva Identification System", "GEN# +1.00278195"},
        {"Wilson Evans Batten Catalogue", "WEB 4973"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.16349613),
        dec: Angle.Degrees(+42.43773887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107174",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15429 B"},
        {"Hipparcos Number", "HIP 107174"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.63757748),
        dec: Angle.Degrees(+42.43790594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39568",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39568"},
        {"Smithsonian Astrophysical Observation", "SAO 42165"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.27026026),
        dec: Angle.Degrees(+42.43892592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107180",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15249 A"},
        {"Henry Draper", "HD 206673"},
        {"Hipparcos Number", "HIP 107180"},
        {"Geneva Identification System", "GEN# +1.00206673"},
        {"Renson", "Renson 57510"},
        {"Smithsonian Astrophysical Observation", "SAO 51214"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.64230263),
        dec: Angle.Degrees(+42.44074313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 276757"},
        {"Hipparcos Number", "HIP 22095"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.32191972),
        dec: Angle.Degrees(+42.44377373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151445"},
        {"Hipparcos Number", "HIP 82041"},
        {"Geneva Identification System", "GEN# +1.00151445"},
        {"Smithsonian Astrophysical Observation", "SAO 46267"},
        {"Wilson Evans Batten Catalogue", "WEB 13853"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.38292688),
        dec: Angle.Degrees(+42.44709215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142373"},
        {"Hipparcos Number", "HIP 77760"},
        {"Cincinnati Publication", "Ci 20 950"},
        {"Fundamental Katalog 5th Edition", "FK5 1416"},
        {"Geneva Identification System", "GEN# +1.00142373"},
        {"Smithsonian Astrophysical Observation", "SAO 45772"},
        {"Wilson Evans Batten Catalogue", "WEB 13156"},
    },
    visualMagnitude: 4.60,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.16747684),
        dec: Angle.Degrees(+42.44998796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 438.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 629.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152579"},
        {"Hipparcos Number", "HIP 82542"},
        {"Smithsonian Astrophysical Observation", "SAO 46338"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.07775224),
        dec: Angle.Degrees(+42.45020820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57060",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57060"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.45829770),
        dec: Angle.Degrees(+42.45078023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43144",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43144"},
        {"Smithsonian Astrophysical Observation", "SAO 42543"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.81431227),
        dec: Angle.Degrees(+42.45102453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23349"},
        {"Hipparcos Number", "HIP 17603"},
        {"Smithsonian Astrophysical Observation", "SAO 39089"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.56381447),
        dec: Angle.Degrees(+42.45475363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60961"},
        {"Hipparcos Number", "HIP 37235"},
        {"Geneva Identification System", "GEN# +1.00060961"},
        {"Smithsonian Astrophysical Observation", "SAO 41907"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.71936990),
        dec: Angle.Degrees(+42.45822723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60846"},
        {"Hipparcos Number", "HIP 37172"},
        {"Geneva Identification System", "GEN# +1.00060846"},
        {"Smithsonian Astrophysical Observation", "SAO 41900"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.57486835),
        dec: Angle.Degrees(+42.46014650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150709"},
        {"Hipparcos Number", "HIP 81666"},
        {"Smithsonian Astrophysical Observation", "SAO 46225"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.23648954),
        dec: Angle.Degrees(+42.46184183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211072"},
        {"Hipparcos Number", "HIP 109738"},
        {"Smithsonian Astrophysical Observation", "SAO 51779"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.43645616),
        dec: Angle.Degrees(+42.46210400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222854"},
        {"Hipparcos Number", "HIP 117080"},
        {"Smithsonian Astrophysical Observation", "SAO 53325"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.02268623),
        dec: Angle.Degrees(+42.46326991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42975"},
        {"Hipparcos Number", "HIP 29748"},
        {"Geneva Identification System", "GEN# +1.00042975"},
        {"Smithsonian Astrophysical Observation", "SAO 40981"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.97785640),
        dec: Angle.Degrees(+42.46481551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129410"},
        {"Hipparcos Number", "HIP 71797"},
        {"Smithsonian Astrophysical Observation", "SAO 45169"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.29154130),
        dec: Angle.Degrees(+42.46519822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72261",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72261"},
    },
    visualMagnitude: 11.05,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.65460524),
        dec: Angle.Degrees(+42.46570448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58449",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58449"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.78663212),
        dec: Angle.Degrees(+42.46640947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169778"},
        {"Hipparcos Number", "HIP 90187"},
        {"Geneva Identification System", "GEN# +1.00169778"},
        {"Smithsonian Astrophysical Observation", "SAO 47465"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.04560229),
        dec: Angle.Degrees(+42.46695214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6852",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6852"},
        {"Smithsonian Astrophysical Observation", "SAO 37240"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.02917247),
        dec: Angle.Degrees(+42.46701142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10539",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10539"},
        {"Smithsonian Astrophysical Observation", "SAO 37903"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.93893993),
        dec: Angle.Degrees(+42.46827310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77236",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9782 AB"},
        {"Henry Draper", "HD 141204"},
        {"Hipparcos Number", "HIP 77236"},
        {"Smithsonian Astrophysical Observation", "SAO 45718"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.55694005),
        dec: Angle.Degrees(+42.46837234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111796"},
        {"Hipparcos Number", "HIP 62748"},
        {"Geneva Identification System", "GEN# +1.00111796"},
        {"Smithsonian Astrophysical Observation", "SAO 44358"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.85578961),
        dec: Angle.Degrees(+42.47270867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43916",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7096 AB"},
        {"Hipparcos Number", "HIP 43916"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.19429083),
        dec: Angle.Degrees(+42.47308954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115376",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115376"},
        {"Smithsonian Astrophysical Observation", "SAO 52945"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.57804381),
        dec: Angle.Degrees(+42.47678368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53428",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53428"},
        {"Smithsonian Astrophysical Observation", "SAO 43526"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.94097411),
        dec: Angle.Degrees(+42.47886762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156756"},
        {"Hipparcos Number", "HIP 84585"},
        {"Smithsonian Astrophysical Observation", "SAO 46612"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.35300181),
        dec: Angle.Degrees(+42.47940633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105585"},
        {"Hipparcos Number", "HIP 59253"},
        {"Geneva Identification System", "GEN# +1.00105585"},
        {"Smithsonian Astrophysical Observation", "SAO 44055"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.31803517),
        dec: Angle.Degrees(+42.48173593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187277"},
        {"Hipparcos Number", "HIP 97366"},
        {"Smithsonian Astrophysical Observation", "SAO 48838"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.84799477),
        dec: Angle.Degrees(+42.48304401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52647",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52647"},
        {"Smithsonian Astrophysical Observation", "SAO 43466"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.47710145),
        dec: Angle.Degrees(+42.48354915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103693"},
        {"Hipparcos Number", "HIP 58239"},
        {"Smithsonian Astrophysical Observation", "SAO 43955"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.17489241),
        dec: Angle.Degrees(+42.48411798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71536"},
        {"Hipparcos Number", "HIP 41655"},
        {"Smithsonian Astrophysical Observation", "SAO 42387"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.40308145),
        dec: Angle.Degrees(+42.48525120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57954",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57954"},
        {"Geneva Identification System", "GEN# +0.04302163"},
        {"Smithsonian Astrophysical Observation", "SAO 43934"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.29867070),
        dec: Angle.Degrees(+42.48842316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47174"},
        {"Hipparcos Number", "HIP 31832"},
        {"Geneva Identification System", "GEN# +1.00047174"},
        {"Smithsonian Astrophysical Observation", "SAO 41239"},
        {"Wilson Evans Batten Catalogue", "WEB 6395"},
    },
    visualMagnitude: 4.80,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.83261264),
        dec: Angle.Degrees(+42.48901214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104050",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104050"},
        {"Smithsonian Astrophysical Observation", "SAO 50421"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.19577857),
        dec: Angle.Degrees(+42.48964317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154392"},
        {"Hipparcos Number", "HIP 83445"},
        {"Renson", "Renson 43630"},
        {"Smithsonian Astrophysical Observation", "SAO 46460"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.81738609),
        dec: Angle.Degrees(+42.49125262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4194"},
        {"Hipparcos Number", "HIP 3510"},
        {"Geneva Identification System", "GEN# +1.00004194"},
        {"Smithsonian Astrophysical Observation", "SAO 36623"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.19964173),
        dec: Angle.Degrees(+42.49693506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23135",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23135"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.67571726),
        dec: Angle.Degrees(+42.49890820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46321"},
        {"Hipparcos Number", "HIP 31379"},
        {"Wilson Evans Batten Catalogue", "WEB 6277"},
    },
    visualMagnitude: 8.91,
    bvColour: 2.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.68594054),
        dec: Angle.Degrees(+42.50355503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20063"},
        {"Hipparcos Number", "HIP 15118"},
        {"Geneva Identification System", "GEN# +1.00020063"},
        {"Smithsonian Astrophysical Observation", "SAO 38674"},
        {"Wilson Evans Batten Catalogue", "WEB 2912"},
    },
    visualMagnitude: 6.07,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.73560789),
        dec: Angle.Degrees(+42.50361942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34635"},
        {"Hipparcos Number", "HIP 24990"},
        {"Celescope Catalog", "CEL 625"},
        {"Geneva Identification System", "GEN# +1.00034635"},
        {"Smithsonian Astrophysical Observation", "SAO 40262"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.26732441),
        dec: Angle.Degrees(+42.50433566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144129"},
        {"Hipparcos Number", "HIP 78565"},
        {"Smithsonian Astrophysical Observation", "SAO 45862"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.64403751),
        dec: Angle.Degrees(+42.50569208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46930",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46930"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.47467585),
        dec: Angle.Degrees(+42.50765051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151189"},
        {"Hipparcos Number", "HIP 81924"},
        {"Smithsonian Astrophysical Observation", "SAO 46251"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.00431845),
        dec: Angle.Degrees(+42.50864216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216733"},
        {"Hipparcos Number", "HIP 113145"},
        {"Celescope Catalog", "CEL 5539"},
        {"Geneva Identification System", "GEN# +1.00216733"},
        {"Smithsonian Astrophysical Observation", "SAO 52480"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.68295256),
        dec: Angle.Degrees(+42.51071708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116657",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16890 A"},
        {"Henry Draper", "HD 222207"},
        {"Hipparcos Number", "HIP 116657"},
        {"Renson", "Renson 60900"},
        {"Smithsonian Astrophysical Observation", "SAO 53225"},
        {"Wilson Evans Batten Catalogue", "WEB 20590"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.61017799),
        dec: Angle.Degrees(+42.51151218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98829",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98829"},
        {"Smithsonian Astrophysical Observation", "SAO 49143"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.04409593),
        dec: Angle.Degrees(+42.51211892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -217.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153472"},
        {"Hipparcos Number", "HIP 83013"},
        {"Fundamental Katalog 5th Edition", "FK5 3349"},
        {"Geneva Identification System", "GEN# +1.00153472"},
        {"Smithsonian Astrophysical Observation", "SAO 46401"},
        {"Wilson Evans Batten Catalogue", "WEB 14035"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.45910609),
        dec: Angle.Degrees(+42.51255034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103272",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14432 AB"},
        {"Henry Draper", "HD 199355"},
        {"Hipparcos Number", "HIP 103272"},
        {"Celescope Catalog", "CEL 5207"},
        {"Geneva Identification System", "GEN# +1.00199355J"},
        {"Smithsonian Astrophysical Observation", "SAO 50226"},
        {"Wilson Evans Batten Catalogue", "WEB 18764"},
    },
    visualMagnitude: 7.03,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.82481994),
        dec: Angle.Degrees(+42.51348646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13015"},
        {"Hipparcos Number", "HIP 9978"},
        {"Smithsonian Astrophysical Observation", "SAO 37792"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.12381776),
        dec: Angle.Degrees(+42.51646426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49023",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49023"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.01980222),
        dec: Angle.Degrees(+42.51661089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224292"},
        {"Hipparcos Number", "HIP 118033"},
        {"Smithsonian Astrophysical Observation", "SAO 53498"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.12989733),
        dec: Angle.Degrees(+42.51873076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148331"},
        {"Hipparcos Number", "HIP 80457"},
        {"Geneva Identification System", "GEN# +1.00148331"},
        {"Smithsonian Astrophysical Observation", "SAO 46077"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.34659519),
        dec: Angle.Degrees(+42.52012623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53765"},
        {"Hipparcos Number", "HIP 34430"},
        {"Geneva Identification System", "GEN# +1.00053765"},
        {"Smithsonian Astrophysical Observation", "SAO 41581"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.06173941),
        dec: Angle.Degrees(+42.52397597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197407"},
        {"Hipparcos Number", "HIP 102154"},
        {"Geneva Identification System", "GEN# +1.00197407"},
        {"Smithsonian Astrophysical Observation", "SAO 49947"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.48453588),
        dec: Angle.Degrees(+42.52468924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3447"},
        {"Hipparcos Number", "HIP 2966"},
        {"Geneva Identification System", "GEN# +1.00003447"},
        {"Smithsonian Astrophysical Observation", "SAO 36523"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.43478205),
        dec: Angle.Degrees(+42.52482155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2755"},
        {"Hipparcos Number", "HIP 2476"},
        {"Smithsonian Astrophysical Observation", "SAO 36438"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.85720549),
        dec: Angle.Degrees(+42.52510543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38358"},
        {"Hipparcos Number", "HIP 27319"},
        {"Fundamental Katalog 5th Edition", "FK5 2431"},
        {"Geneva Identification System", "GEN# +1.00038358"},
        {"Smithsonian Astrophysical Observation", "SAO 40609"},
        {"Wilson Evans Batten Catalogue", "WEB 5369"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.81116596),
        dec: Angle.Degrees(+42.52695878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107908",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107908"},
        {"Smithsonian Astrophysical Observation", "SAO 51373"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.94246135),
        dec: Angle.Degrees(+42.52696548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81420",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81420"},
        {"Smithsonian Astrophysical Observation", "SAO 46201"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.44153543),
        dec: Angle.Degrees(+42.52712545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25410"},
        {"Hipparcos Number", "HIP 18994"},
        {"Geneva Identification System", "GEN# +1.00025410"},
        {"Smithsonian Astrophysical Observation", "SAO 39289"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.04143879),
        dec: Angle.Degrees(+42.52756645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 180.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189409"},
        {"Hipparcos Number", "HIP 98283"},
        {"Smithsonian Astrophysical Observation", "SAO 49041"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.54396254),
        dec: Angle.Degrees(+42.52756954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12826",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12826"},
    },
    visualMagnitude: 11.16,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.21978549),
        dec: Angle.Degrees(+42.52770482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76855"},
        {"Hipparcos Number", "HIP 44203"},
        {"Smithsonian Astrophysical Observation", "SAO 42639"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.06713949),
        dec: Angle.Degrees(+42.52899707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109052"},
        {"Hipparcos Number", "HIP 61116"},
        {"Geneva Identification System", "GEN# +1.00109052"},
        {"Smithsonian Astrophysical Observation", "SAO 44212"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.88419954),
        dec: Angle.Degrees(+42.53072108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8809",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8809"},
        {"Smithsonian Astrophysical Observation", "SAO 37585"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.30733156),
        dec: Angle.Degrees(+42.53106785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110068",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15817 A"},
        {"Hipparcos Number", "HIP 110068"},
        {"Smithsonian Astrophysical Observation", "SAO 51846"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.41867007),
        dec: Angle.Degrees(+42.53136415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104369",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104369"},
        {"Smithsonian Astrophysical Observation", "SAO 50490"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.15926356),
        dec: Angle.Degrees(+42.53564064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 186.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22521"},
        {"Hipparcos Number", "HIP 17022"},
        {"Geneva Identification System", "GEN# +1.00022521"},
        {"Smithsonian Astrophysical Observation", "SAO 39015"},
        {"Wilson Evans Batten Catalogue", "WEB 3235"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.73891587),
        dec: Angle.Degrees(+42.53859836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -194.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55393",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55393"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.13663804),
        dec: Angle.Degrees(+42.54078911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105010",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105010"},
        {"Geneva Identification System", "GEN# +0.04104064"},
        {"Smithsonian Astrophysical Observation", "SAO 50649"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.04003211),
        dec: Angle.Degrees(+42.54093722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191742"},
        {"Hipparcos Number", "HIP 99340"},
        {"Geneva Identification System", "GEN# +1.00191742"},
        {"Renson", "Renson 53440"},
        {"Smithsonian Astrophysical Observation", "SAO 49254"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.44597105),
        dec: Angle.Degrees(+42.54134259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107904"},
        {"Hipparcos Number", "HIP 60467"},
        {"Fundamental Katalog 5th Edition", "FK5 2993"},
        {"Geneva Identification System", "GEN# +1.00107904"},
        {"Smithsonian Astrophysical Observation", "SAO 44155"},
        {"Wilson Evans Batten Catalogue", "WEB 10755"},
    },
    visualMagnitude: 6.03,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.94614816),
        dec: Angle.Degrees(+42.54270856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127518"},
        {"Hipparcos Number", "HIP 70946"},
        {"Smithsonian Astrophysical Observation", "SAO 45083"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.67297708),
        dec: Angle.Degrees(+42.54288886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55255"},
        {"Hipparcos Number", "HIP 34971"},
        {"Smithsonian Astrophysical Observation", "SAO 41631"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.54110026),
        dec: Angle.Degrees(+42.54351891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30526",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5016 AB"},
        {"Henry Draper", "HD 44651"},
        {"Hipparcos Number", "HIP 30526"},
        {"Smithsonian Astrophysical Observation", "SAO 41083"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.24933939),
        dec: Angle.Degrees(+42.54610533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94409",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94409"},
        {"Smithsonian Astrophysical Observation", "SAO 48205"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.22438598),
        dec: Angle.Degrees(+42.54903845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114416"},
        {"Hipparcos Number", "HIP 64234"},
        {"Smithsonian Astrophysical Observation", "SAO 44492"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.48065698),
        dec: Angle.Degrees(+42.54998384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51347",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51347"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.32826680),
        dec: Angle.Degrees(+42.54999761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57862",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57862"},
        {"Smithsonian Astrophysical Observation", "SAO 43920"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.01700709),
        dec: Angle.Degrees(+42.55019796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48408",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48408"},
    },
    visualMagnitude: 10.77,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.03851067),
        dec: Angle.Degrees(+42.55233942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216479"},
        {"Hipparcos Number", "HIP 112968"},
        {"Celescope Catalog", "CEL 5538"},
        {"Geneva Identification System", "GEN# +1.00216479"},
        {"Smithsonian Astrophysical Observation", "SAO 52446"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.17211422),
        dec: Angle.Degrees(+42.55335931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101763",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14077 AB"},
        {"Hipparcos Number", "HIP 101763"},
        {"Smithsonian Astrophysical Observation", "SAO 49870"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.37401186),
        dec: Angle.Degrees(+42.55432807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120702"},
        {"Hipparcos Number", "HIP 67529"},
        {"Geneva Identification System", "GEN# +1.00120702"},
        {"Smithsonian Astrophysical Observation", "SAO 44772"},
        {"Wilson Evans Batten Catalogue", "WEB 11875"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.53374988),
        dec: Angle.Degrees(+42.55728548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42032",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42032"},
        {"Geneva Identification System", "GEN# +0.04301827"},
        {"Wilson Evans Batten Catalogue", "WEB 8083"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.51447195),
        dec: Angle.Degrees(+42.55872704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 198.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11731",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1913 AB"},
        {"Henry Draper", "HD 15561"},
        {"Hipparcos Number", "HIP 11731"},
        {"Smithsonian Astrophysical Observation", "SAO 38085"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.86207480),
        dec: Angle.Degrees(+42.56346669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52303"},
        {"Hipparcos Number", "HIP 33958"},
        {"Smithsonian Astrophysical Observation", "SAO 41513"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.69137863),
        dec: Angle.Degrees(+42.56402818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168602"},
        {"Hipparcos Number", "HIP 89719"},
        {"Smithsonian Astrophysical Observation", "SAO 47380"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.64965571),
        dec: Angle.Degrees(+42.56463466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142108"},
        {"Hipparcos Number", "HIP 77632"},
        {"Smithsonian Astrophysical Observation", "SAO 45757"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.73861452),
        dec: Angle.Degrees(+42.56533769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47311"},
        {"Hipparcos Number", "HIP 31893"},
        {"Geneva Identification System", "GEN# +1.00047311"},
        {"Renson", "Renson 12720"},
        {"Smithsonian Astrophysical Observation", "SAO 41248"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.00623414),
        dec: Angle.Degrees(+42.56551549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12886",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12886"},
    },
    visualMagnitude: 10.80,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.41391698),
        dec: Angle.Degrees(+44.94906212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 409.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136115"},
        {"Hipparcos Number", "HIP 74810"},
        {"Geneva Identification System", "GEN# +1.00136115"},
        {"Smithsonian Astrophysical Observation", "SAO 45469"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.32875303),
        dec: Angle.Degrees(+42.56582027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142926"},
        {"Hipparcos Number", "HIP 77986"},
        {"Geneva Identification System", "GEN# +1.00142926"},
        {"Smithsonian Astrophysical Observation", "SAO 45790"},
        {"Wilson Evans Batten Catalogue", "WEB 13189"},
    },
    visualMagnitude: 5.73,
    bvColour: -0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.87754361),
        dec: Angle.Degrees(+42.56615229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108865",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108865"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.81064205),
        dec: Angle.Degrees(+42.56640363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32143"},
        {"Hipparcos Number", "HIP 23489"},
        {"Celescope Catalog", "CEL 513"},
        {"Geneva Identification System", "GEN# +1.00032143"},
        {"Smithsonian Astrophysical Observation", "SAO 39974"},
        {"Wilson Evans Batten Catalogue", "WEB 4574"},
    },
    visualMagnitude: 7.50,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.73907140),
        dec: Angle.Degrees(+42.56905045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206586"},
        {"Hipparcos Number", "HIP 107125"},
        {"Geneva Identification System", "GEN# +1.00206586"},
        {"Smithsonian Astrophysical Observation", "SAO 51201"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.49621594),
        dec: Angle.Degrees(+42.56910980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193838"},
        {"Hipparcos Number", "HIP 100319"},
        {"Celescope Catalog", "CEL 5035"},
        {"Geneva Identification System", "GEN# +1.00193838"},
        {"Smithsonian Astrophysical Observation", "SAO 49498"},
    },
    visualMagnitude: 8.64,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.17849892),
        dec: Angle.Degrees(+42.57190607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27889",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27889"},
        {"Smithsonian Astrophysical Observation", "SAO 40687"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.52322894),
        dec: Angle.Degrees(+42.57617547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17529",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2738 A"},
        {"Henry Draper", "HD 23230"},
        {"Hipparcos Number", "HIP 17529"},
        {"Fundamental Katalog 5th Edition", "FK5 134"},
        {"Geneva Identification System", "GEN# +1.00023230"},
        {"Smithsonian Astrophysical Observation", "SAO 39078"},
        {"Wilson Evans Batten Catalogue", "WEB 3322"},
    },
    visualMagnitude: 3.77,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.29851422),
        dec: Angle.Degrees(+42.57854437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 277469"},
        {"Hipparcos Number", "HIP 23947"},
        {"Smithsonian Astrophysical Observation", "SAO 40051"},
        {"Wilson Evans Batten Catalogue", "WEB 4670"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.20009626),
        dec: Angle.Degrees(+42.57854536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114850",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114850"},
        {"Smithsonian Astrophysical Observation", "SAO 52844"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.95556212),
        dec: Angle.Degrees(+42.57901360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72778"},
        {"Hipparcos Number", "HIP 42197"},
        {"Fundamental Katalog 5th Edition", "FK5 2671"},
        {"Geneva Identification System", "GEN# +1.00072778"},
        {"Smithsonian Astrophysical Observation", "SAO 42443"},
        {"Wilson Evans Batten Catalogue", "WEB 8109"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.06482215),
        dec: Angle.Degrees(+42.57987853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83645"},
        {"Hipparcos Number", "HIP 47514"},
        {"Smithsonian Astrophysical Observation", "SAO 42976"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.29628131),
        dec: Angle.Degrees(+42.58221753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19744",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3062 AB"},
        {"Henry Draper", "HD 26569"},
        {"Hipparcos Number", "HIP 19744"},
        {"Smithsonian Astrophysical Observation", "SAO 39395"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.49581868),
        dec: Angle.Degrees(+42.58246258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22402"},
        {"Hipparcos Number", "HIP 16938"},
        {"Geneva Identification System", "GEN# +1.00022402"},
        {"Renson", "Renson 5700"},
        {"Smithsonian Astrophysical Observation", "SAO 38999"},
        {"Wilson Evans Batten Catalogue", "WEB 3224"},
    },
    visualMagnitude: 6.41,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.50069342),
        dec: Angle.Degrees(+42.58290278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219711"},
        {"Hipparcos Number", "HIP 115016"},
        {"Geneva Identification System", "GEN# +1.00219711"},
        {"Smithsonian Astrophysical Observation", "SAO 52867"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.41753041),
        dec: Angle.Degrees(+42.58339795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209125"},
        {"Hipparcos Number", "HIP 108614"},
        {"Smithsonian Astrophysical Observation", "SAO 51532"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.04602762),
        dec: Angle.Degrees(+42.58361502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30823"},
        {"Hipparcos Number", "HIP 22699"},
        {"Celescope Catalog", "CEL 478"},
        {"Geneva Identification System", "GEN# +1.00030823"},
        {"Smithsonian Astrophysical Observation", "SAO 39826"},
        {"Wilson Evans Batten Catalogue", "WEB 4386"},
    },
    visualMagnitude: 5.68,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.19902284),
        dec: Angle.Degrees(+42.58662591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142394"},
        {"Hipparcos Number", "HIP 77763"},
        {"Geneva Identification System", "GEN# +1.00142394"},
        {"Renson", "Renson 40400"},
        {"Smithsonian Astrophysical Observation", "SAO 45773"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.17403288),
        dec: Angle.Degrees(+42.58686702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19184"},
        {"Hipparcos Number", "HIP 14469"},
        {"Geneva Identification System", "GEN# +1.00019184"},
        {"Smithsonian Astrophysical Observation", "SAO 38581"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.68461046),
        dec: Angle.Degrees(+42.58784921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161726"},
        {"Hipparcos Number", "HIP 86885"},
        {"Smithsonian Astrophysical Observation", "SAO 46931"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.28444849),
        dec: Angle.Degrees(+42.58796159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17922"},
        {"Hipparcos Number", "HIP 13528"},
        {"Geneva Identification System", "GEN# +1.00017922"},
        {"Smithsonian Astrophysical Observation", "SAO 38428"},
        {"Wilson Evans Batten Catalogue", "WEB 2698"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.55814132),
        dec: Angle.Degrees(+42.58898511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 199.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14064"},
        {"Hipparcos Number", "HIP 10695"},
        {"Geneva Identification System", "GEN# +1.00014064"},
        {"Smithsonian Astrophysical Observation", "SAO 37927"},
        {"Wilson Evans Batten Catalogue", "WEB 2254"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.42424657),
        dec: Angle.Degrees(+42.58953503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43460",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43460"},
        {"Smithsonian Astrophysical Observation", "SAO 42570"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.78147110),
        dec: Angle.Degrees(+42.58963378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16729",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2620 AB"},
        {"Henry Draper", "HD 22089"},
        {"Hipparcos Number", "HIP 16729"},
        {"Smithsonian Astrophysical Observation", "SAO 38964"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.80925176),
        dec: Angle.Degrees(+42.59079956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16735",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2620 C"},
        {"Hipparcos Number", "HIP 16735"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.82205367),
        dec: Angle.Degrees(+42.59195314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218314"},
        {"Hipparcos Number", "HIP 114089"},
        {"Smithsonian Astrophysical Observation", "SAO 52680"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.60722435),
        dec: Angle.Degrees(+42.59238336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16004",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16004"},
        {"Fundamental Katalog 5th Edition", "FK5 4312"},
        {"Smithsonian Astrophysical Observation", "SAO 38827"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.52174639),
        dec: Angle.Degrees(+42.59329156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30341"},
        {"Hipparcos Number", "HIP 22337"},
        {"Geneva Identification System", "GEN# +1.00030341"},
        {"Smithsonian Astrophysical Observation", "SAO 39770"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.15992210),
        dec: Angle.Degrees(+42.59411472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16655"},
        {"Hipparcos Number", "HIP 12559"},
        {"Geneva Identification System", "GEN# +2.10390200"},
        {"Smithsonian Astrophysical Observation", "SAO 38229"},
        {"New General Catalogue", "NGC 1039 200"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.38301391),
        dec: Angle.Degrees(+42.59420246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103656",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103656"},
        {"Geneva Identification System", "GEN# +0.04203935"},
        {"Wilson Evans Batten Catalogue", "WEB 18866"},
    },
    visualMagnitude: 9.53,
    bvColour: 2.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.02658964),
        dec: Angle.Degrees(+42.59756406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214928"},
        {"Hipparcos Number", "HIP 111985"},
        {"Smithsonian Astrophysical Observation", "SAO 52259"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.24459442),
        dec: Angle.Degrees(+42.59844697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179394"},
        {"Hipparcos Number", "HIP 94182"},
        {"Celescope Catalog", "CEL 4711"},
        {"Geneva Identification System", "GEN# +1.00179394"},
        {"Smithsonian Astrophysical Observation", "SAO 48153"},
    },
    visualMagnitude: 7.51,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.61095711),
        dec: Angle.Degrees(+42.60134922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75188",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75188"},
        {"Smithsonian Astrophysical Observation", "SAO 45506"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.47276136),
        dec: Angle.Degrees(+42.60263251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44524",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44524"},
    },
    visualMagnitude: 10.73,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.07805106),
        dec: Angle.Degrees(+42.60398494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23050"},
        {"Hipparcos Number", "HIP 17409"},
        {"Cincinnati Publication", "Ci 18 494"},
        {"Cincinnati Publication 2", "Ci 20 254"},
        {"Geneva Identification System", "GEN# +1.00023050"},
        {"Smithsonian Astrophysical Observation", "SAO 39061"},
        {"Wilson Evans Batten Catalogue", "WEB 3291"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.94752907),
        dec: Angle.Degrees(+42.60398732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 363.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -258.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194708"},
        {"Hipparcos Number", "HIP 100736"},
        {"Geneva Identification System", "GEN# +1.00194708"},
        {"Smithsonian Astrophysical Observation", "SAO 49603"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.35703608),
        dec: Angle.Degrees(+42.60498593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191423"},
        {"Hipparcos Number", "HIP 99177"},
        {"Celescope Catalog", "CEL 4942"},
        {"Geneva Identification System", "GEN# +1.00191423"},
        {"Smithsonian Astrophysical Observation", "SAO 49221"},
        {"Wilson Evans Batten Catalogue", "WEB 17657"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.02965774),
        dec: Angle.Degrees(+42.60610958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199021"},
        {"Hipparcos Number", "HIP 103061"},
        {"Geneva Identification System", "GEN# +1.00199021"},
        {"Smithsonian Astrophysical Observation", "SAO 50172"},
        {"Wilson Evans Batten Catalogue", "WEB 18709"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.22169510),
        dec: Angle.Degrees(+42.60775173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20489"},
        {"Hipparcos Number", "HIP 15454"},
        {"Smithsonian Astrophysical Observation", "SAO 38717"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.82463796),
        dec: Angle.Degrees(+42.61034243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10307"},
        {"Hipparcos Number", "HIP 7918"},
        {"Cincinnati Publication", "Ci 20 118"},
        {"Geneva Identification System", "GEN# +1.00010307"},
        {"Smithsonian Astrophysical Observation", "SAO 37434"},
        {"Wilson Evans Batten Catalogue", "WEB 1688"},
    },
    visualMagnitude: 4.96,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.44381547),
        dec: Angle.Degrees(+42.61380692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 791.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -180.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84469",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84469"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.03469118),
        dec: Angle.Degrees(+42.61381898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57266",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57266"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.15134385),
        dec: Angle.Degrees(+42.61554862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151120"},
        {"Hipparcos Number", "HIP 81879"},
        {"Geneva Identification System", "GEN# +1.00151120"},
        {"Smithsonian Astrophysical Observation", "SAO 46244"},
        {"Wilson Evans Batten Catalogue", "WEB 13831"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.87410766),
        dec: Angle.Degrees(+42.61607203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208699"},
        {"Hipparcos Number", "HIP 108356"},
        {"Smithsonian Astrophysical Observation", "SAO 51473"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.27475177),
        dec: Angle.Degrees(+42.61625831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89781"},
        {"Hipparcos Number", "HIP 50818"},
        {"Geneva Identification System", "GEN# +1.00089781"},
        {"Smithsonian Astrophysical Observation", "SAO 43311"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.64300489),
        dec: Angle.Degrees(+42.61658910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24026"},
        {"Hipparcos Number", "HIP 18053"},
        {"Geneva Identification System", "GEN# +1.00024026"},
        {"Smithsonian Astrophysical Observation", "SAO 39155"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.88150396),
        dec: Angle.Degrees(+42.61793235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49884"},
        {"Hipparcos Number", "HIP 33001"},
        {"Renson", "Renson 13530"},
        {"Smithsonian Astrophysical Observation", "SAO 41400"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.14666695),
        dec: Angle.Degrees(+42.61947416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34098",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34098"},
    },
    visualMagnitude: 10.81,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.05303591),
        dec: Angle.Degrees(+42.62057506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64230"},
        {"Hipparcos Number", "HIP 38640"},
        {"Smithsonian Astrophysical Observation", "SAO 42060"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.68273927),
        dec: Angle.Degrees(+42.62245848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89253",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89253"},
        {"Smithsonian Astrophysical Observation", "SAO 47308"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.20532872),
        dec: Angle.Degrees(+42.62353344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114877"},
        {"Hipparcos Number", "HIP 64470"},
        {"Geneva Identification System", "GEN# +1.00114877"},
        {"Smithsonian Astrophysical Observation", "SAO 44509"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.20638393),
        dec: Angle.Degrees(+42.62661766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 276991"},
        {"Hipparcos Number", "HIP 22618"},
        {"Smithsonian Astrophysical Observation", "SAO 39813"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.99634081),
        dec: Angle.Degrees(+42.62689626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147144"},
        {"Hipparcos Number", "HIP 79876"},
        {"Smithsonian Astrophysical Observation", "SAO 46016"},
        {"Wilson Evans Batten Catalogue", "WEB 13524"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.56456329),
        dec: Angle.Degrees(+42.62696866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9045"},
        {"Hipparcos Number", "HIP 6982"},
        {"Geneva Identification System", "GEN# +1.00009045"},
        {"Smithsonian Astrophysical Observation", "SAO 37269"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.47121581),
        dec: Angle.Degrees(+42.62781453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213799"},
        {"Hipparcos Number", "HIP 111344"},
        {"Smithsonian Astrophysical Observation", "SAO 52137"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.35735172),
        dec: Angle.Degrees(+42.62972954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216120"},
        {"Hipparcos Number", "HIP 112720"},
        {"Smithsonian Astrophysical Observation", "SAO 52400"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.41143295),
        dec: Angle.Degrees(+42.63099492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99233"},
        {"Hipparcos Number", "HIP 55761"},
        {"Geneva Identification System", "GEN# +1.00099233"},
        {"Smithsonian Astrophysical Observation", "SAO 43736"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.38263921),
        dec: Angle.Degrees(+42.63258397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 130.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58819",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58819"},
    },
    visualMagnitude: 10.95,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.96408473),
        dec: Angle.Degrees(+42.63331888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166458"},
        {"Hipparcos Number", "HIP 88874"},
        {"Smithsonian Astrophysical Observation", "SAO 47254"},
    },
    visualMagnitude: 8.34,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.15906164),
        dec: Angle.Degrees(+42.63525237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188399"},
        {"Hipparcos Number", "HIP 97861"},
        {"Smithsonian Astrophysical Observation", "SAO 48939"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.29827880),
        dec: Angle.Degrees(+42.63537422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89052"},
        {"Hipparcos Number", "HIP 50383"},
        {"Smithsonian Astrophysical Observation", "SAO 43269"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.31089008),
        dec: Angle.Degrees(+42.63620754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102788",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102788"},
        {"Smithsonian Astrophysical Observation", "SAO 50109"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.803,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.36998318),
        dec: Angle.Degrees(+42.63912958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133158"},
        {"Hipparcos Number", "HIP 73515"},
        {"Smithsonian Astrophysical Observation", "SAO 45334"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.38157118),
        dec: Angle.Degrees(+42.63990700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59371"},
        {"Hipparcos Number", "HIP 36597"},
        {"Geneva Identification System", "GEN# +1.00059371"},
        {"Smithsonian Astrophysical Observation", "SAO 41833"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.90815194),
        dec: Angle.Degrees(+42.64144645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91994",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91994"},
        {"Smithsonian Astrophysical Observation", "SAO 47763"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.25265748),
        dec: Angle.Degrees(+42.64375785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106570",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106570"},
        {"Smithsonian Astrophysical Observation", "SAO 51055"},
    },
    visualMagnitude: 9.59,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.73630084),
        dec: Angle.Degrees(+42.64405080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28204",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4531 AB"},
        {"Hipparcos Number", "HIP 28204"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.39403976),
        dec: Angle.Degrees(+42.64410073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22580",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22580"},
    },
    visualMagnitude: 10.16,
    bvColour: 1.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.88574759),
        dec: Angle.Degrees(+42.64514550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221948"},
        {"Hipparcos Number", "HIP 116485"},
        {"Smithsonian Astrophysical Observation", "SAO 53177"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.05182352),
        dec: Angle.Degrees(+42.64549141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163418"},
        {"Hipparcos Number", "HIP 87631"},
        {"Smithsonian Astrophysical Observation", "SAO 47043"},
        {"Wilson Evans Batten Catalogue", "WEB 14788"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.50587185),
        dec: Angle.Degrees(+42.64708565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186485"},
        {"Hipparcos Number", "HIP 96992"},
        {"Geneva Identification System", "GEN# +1.00186485"},
        {"Smithsonian Astrophysical Observation", "SAO 48752"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.70802654),
        dec: Angle.Degrees(+42.65010054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77706",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9822 C"},
        {"Henry Draper", "HD 142284"},
        {"Hipparcos Number", "HIP 77706"},
        {"Geneva Identification System", "GEN# +1.00142284"},
        {"Smithsonian Astrophysical Observation", "SAO 45764"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.98436046),
        dec: Angle.Degrees(+42.65161729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64933"},
        {"Hipparcos Number", "HIP 38951"},
        {"Geneva Identification System", "GEN# +1.00064933"},
        {"Smithsonian Astrophysical Observation", "SAO 42095"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.54114693),
        dec: Angle.Degrees(+42.65180964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214805"},
        {"Hipparcos Number", "HIP 111891"},
        {"Smithsonian Astrophysical Observation", "SAO 52242"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.97862971),
        dec: Angle.Degrees(+42.65306675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111890"},
        {"Hipparcos Number", "HIP 62802"},
        {"Smithsonian Astrophysical Observation", "SAO 44362"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.03529472),
        dec: Angle.Degrees(+42.65363518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82895",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82895"},
        {"Smithsonian Astrophysical Observation", "SAO 46379"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.10110924),
        dec: Angle.Degrees(+42.65393784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67985",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67985"},
        {"Smithsonian Astrophysical Observation", "SAO 44799"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.83695451),
        dec: Angle.Degrees(+42.65551819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56941"},
        {"Hipparcos Number", "HIP 35623"},
        {"Fundamental Katalog 5th Edition", "FK5 4662"},
        {"Geneva Identification System", "GEN# +1.00056941"},
        {"Smithsonian Astrophysical Observation", "SAO 41705"},
        {"Wilson Evans Batten Catalogue", "WEB 7100"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.26297004),
        dec: Angle.Degrees(+42.65599942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114106",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16513 A"},
        {"Henry Draper", "HD 218326"},
        {"Hipparcos Number", "HIP 114106"},
        {"Smithsonian Astrophysical Observation", "SAO 52687"},
    },
    visualMagnitude: 8.01,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.65439471),
        dec: Angle.Degrees(+42.65737119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224342"},
        {"Hipparcos Number", "HIP 118071"},
        {"Fundamental Katalog 5th Edition", "FK5 3923"},
        {"Geneva Identification System", "GEN# +1.00224342"},
        {"Smithsonian Astrophysical Observation", "SAO 53511"},
        {"Wilson Evans Batten Catalogue", "WEB 20759"},
    },
    visualMagnitude: 6.01,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.26511635),
        dec: Angle.Degrees(+42.65823773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105247"},
        {"Hipparcos Number", "HIP 59092"},
        {"Geneva Identification System", "GEN# +1.00105247"},
        {"Smithsonian Astrophysical Observation", "SAO 44037"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.77149440),
        dec: Angle.Degrees(+42.65986336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99928"},
        {"Hipparcos Number", "HIP 56105"},
        {"Geneva Identification System", "GEN# +1.00099928"},
        {"Smithsonian Astrophysical Observation", "SAO 43780"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.50645899),
        dec: Angle.Degrees(+42.66150988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126425"},
        {"Hipparcos Number", "HIP 70403"},
        {"Geneva Identification System", "GEN# +1.00126425"},
        {"Smithsonian Astrophysical Observation", "SAO 45035"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.05618458),
        dec: Angle.Degrees(+42.66158696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91059",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91059"},
        {"Smithsonian Astrophysical Observation", "SAO 47610"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.62799930),
        dec: Angle.Degrees(+42.66162130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54439",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54439"},
        {"Smithsonian Astrophysical Observation", "SAO 43621"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.08344836),
        dec: Angle.Degrees(+42.66324094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57337"},
        {"Hipparcos Number", "HIP 35770"},
        {"Geneva Identification System", "GEN# +1.00057337"},
        {"Smithsonian Astrophysical Observation", "SAO 41728"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.68439863),
        dec: Angle.Degrees(+42.66475507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172393"},
        {"Hipparcos Number", "HIP 91364"},
        {"Cincinnati Publication", "Ci 18 2449"},
        {"Geneva Identification System", "GEN# +1.00172393"},
        {"Smithsonian Astrophysical Observation", "SAO 47665"},
        {"Wilson Evans Batten Catalogue", "WEB 15698"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.50724796),
        dec: Angle.Degrees(+42.66505771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 294.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29062",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4696 AB"},
        {"Henry Draper", "HD 41541"},
        {"Hipparcos Number", "HIP 29062"},
        {"Geneva Identification System", "GEN# +1.00041541J"},
        {"Smithsonian Astrophysical Observation", "SAO 40872"},
        {"Wilson Evans Batten Catalogue", "WEB 5691"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.96082306),
        dec: Angle.Degrees(+42.66571065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34040"},
        {"Hipparcos Number", "HIP 24594"},
        {"Smithsonian Astrophysical Observation", "SAO 40185"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.13751909),
        dec: Angle.Degrees(+42.66760892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5292"},
        {"Hipparcos Number", "HIP 4315"},
        {"Geneva Identification System", "GEN# +1.00005292"},
        {"Smithsonian Astrophysical Observation", "SAO 36768"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.80887056),
        dec: Angle.Degrees(+42.67154229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116686",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116686"},
        {"Smithsonian Astrophysical Observation", "SAO 53232"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.70355108),
        dec: Angle.Degrees(+42.67360476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15313",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2445 A"},
        {"Henry Draper", "HD 20316"},
        {"Hipparcos Number", "HIP 15313"},
        {"Geneva Identification System", "GEN# +1.00020316"},
        {"Smithsonian Astrophysical Observation", "SAO 38703"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.39596483),
        dec: Angle.Degrees(+42.67517147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164965"},
        {"Hipparcos Number", "HIP 88286"},
        {"Geneva Identification System", "GEN# +1.00164965"},
        {"Smithsonian Astrophysical Observation", "SAO 47153"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.42979727),
        dec: Angle.Degrees(+42.67575504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34092"},
        {"Hipparcos Number", "HIP 24623"},
        {"Geneva Identification System", "GEN# +1.00034092"},
        {"Smithsonian Astrophysical Observation", "SAO 40188"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.22068873),
        dec: Angle.Degrees(+42.67745885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37283"},
        {"Hipparcos Number", "HIP 26613"},
        {"Smithsonian Astrophysical Observation", "SAO 40515"},
        {"Wilson Evans Batten Catalogue", "WEB 5247"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.85810491),
        dec: Angle.Degrees(+42.68082055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74119"},
        {"Hipparcos Number", "HIP 42833"},
        {"Geneva Identification System", "GEN# +1.00074119"},
        {"Smithsonian Astrophysical Observation", "SAO 42513"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.91494305),
        dec: Angle.Degrees(+42.68179280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202862"},
        {"Hipparcos Number", "HIP 105101"},
        {"Geneva Identification System", "GEN# +1.00202862"},
        {"Smithsonian Astrophysical Observation", "SAO 50671"},
    },
    visualMagnitude: 6.17,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.34656520),
        dec: Angle.Degrees(+42.68356712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182054"},
        {"Hipparcos Number", "HIP 95119"},
        {"Smithsonian Astrophysical Observation", "SAO 48360"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.26178214),
        dec: Angle.Degrees(+42.68705837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118243"},
        {"Hipparcos Number", "HIP 66261"},
        {"Geneva Identification System", "GEN# +1.00118243"},
        {"Smithsonian Astrophysical Observation", "SAO 44670"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.70884312),
        dec: Angle.Degrees(+42.69282933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84035"},
        {"Hipparcos Number", "HIP 47690"},
        {"Cincinnati Publication", "Ci 18 1153"},
        {"Cincinnati Publication 2", "Ci 20 543"},
        {"Fundamental Katalog 5th Edition", "FK5 4863"},
        {"Geneva Identification System", "GEN# +1.00084035"},
        {"Smithsonian Astrophysical Observation", "SAO 42997"},
        {"Wilson Evans Batten Catalogue", "WEB 8935"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.85679899),
        dec: Angle.Degrees(+42.69356785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -826.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3141"},
        {"Hipparcos Number", "HIP 2742"},
        {"Geneva Identification System", "GEN# +1.00003141"},
        {"Smithsonian Astrophysical Observation", "SAO 36489"},
        {"Wilson Evans Batten Catalogue", "WEB 493"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.75416804),
        dec: Angle.Degrees(+42.69495016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -168.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103954"},
        {"Hipparcos Number", "HIP 58392"},
        {"Geneva Identification System", "GEN# +1.00103954"},
        {"Smithsonian Astrophysical Observation", "SAO 43979"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.59681366),
        dec: Angle.Degrees(+42.69518675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13843"},
        {"Hipparcos Number", "HIP 10568"},
        {"Smithsonian Astrophysical Observation", "SAO 37908"},
    },
    visualMagnitude: 7.98,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.00783390),
        dec: Angle.Degrees(+42.69686324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139971"},
        {"Hipparcos Number", "HIP 76684"},
        {"Smithsonian Astrophysical Observation", "SAO 45666"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.88359513),
        dec: Angle.Degrees(+42.69691242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17961"},
        {"Hipparcos Number", "HIP 13559"},
        {"Smithsonian Astrophysical Observation", "SAO 38431"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.66529540),
        dec: Angle.Degrees(+42.69757764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12619",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2052 AB"},
        {"Henry Draper", "HD 16728"},
        {"Hipparcos Number", "HIP 12619"},
        {"Geneva Identification System", "GEN# +2.10390307"},
        {"Smithsonian Astrophysical Observation", "SAO 38254"},
        {"New General Catalogue", "NGC 1039 307"},
    },
    visualMagnitude: 7.97,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.55472044),
        dec: Angle.Degrees(+42.69922920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59162",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8433 AB"},
        {"Henry Draper", "HD 105369"},
        {"Hipparcos Number", "HIP 59162"},
        {"Geneva Identification System", "GEN# +1.00105369J"},
        {"Smithsonian Astrophysical Observation", "SAO 44043"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.99705323),
        dec: Angle.Degrees(+42.69929315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65485",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65485"},
        {"Smithsonian Astrophysical Observation", "SAO 44602"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.32249297),
        dec: Angle.Degrees(+42.69947919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151200"},
        {"Hipparcos Number", "HIP 81926"},
        {"Smithsonian Astrophysical Observation", "SAO 46253"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.00748825),
        dec: Angle.Degrees(+42.69950775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -169.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205060"},
        {"Hipparcos Number", "HIP 106284"},
        {"Celescope Catalog", "CEL 5332"},
        {"Geneva Identification System", "GEN# +1.00205060"},
        {"Smithsonian Astrophysical Observation", "SAO 50977"},
        {"Wilson Evans Batten Catalogue", "WEB 19253"},
    },
    visualMagnitude: 7.22,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.90378817),
        dec: Angle.Degrees(+42.70075969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18664"},
        {"Hipparcos Number", "HIP 14084"},
        {"Smithsonian Astrophysical Observation", "SAO 38516"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.40095269),
        dec: Angle.Degrees(+42.70154518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193217"},
        {"Hipparcos Number", "HIP 100016"},
        {"Geneva Identification System", "GEN# +1.00193217"},
        {"Smithsonian Astrophysical Observation", "SAO 49425"},
        {"Wilson Evans Batten Catalogue", "WEB 18006"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.37106233),
        dec: Angle.Degrees(+42.72206321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75103",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9603 AB"},
        {"Henry Draper", "HD 136752"},
        {"Hipparcos Number", "HIP 75103"},
        {"Smithsonian Astrophysical Observation", "SAO 45499"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.806,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.20099671),
        dec: Angle.Degrees(+42.70192879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115686",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115686"},
        {"Smithsonian Astrophysical Observation", "SAO 53017"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.58325273),
        dec: Angle.Degrees(+42.70238470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116377"},
        {"Hipparcos Number", "HIP 65267"},
        {"Smithsonian Astrophysical Observation", "SAO 44583"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.63589183),
        dec: Angle.Degrees(+42.70329292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10449"},
        {"Hipparcos Number", "HIP 8003"},
        {"Smithsonian Astrophysical Observation", "SAO 37453"},
    },
    visualMagnitude: 9.17,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.68806783),
        dec: Angle.Degrees(+42.70480793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12606",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2049 A"},
        {"Aitken 2", "ADS 2052 C"},
        {"Henry Draper", "HD 16719"},
        {"Hipparcos Number", "HIP 12606"},
        {"Geneva Identification System", "GEN# +2.10390282"},
        {"Smithsonian Astrophysical Observation", "SAO 38248"},
        {"New General Catalogue", "NGC 1039 282"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.52406657),
        dec: Angle.Degrees(+42.70742999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56610",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56610"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.10391083),
        dec: Angle.Degrees(+42.70873688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126379"},
        {"Hipparcos Number", "HIP 70369"},
        {"Smithsonian Astrophysical Observation", "SAO 45031"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.96041189),
        dec: Angle.Degrees(+42.70907575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218659"},
        {"Hipparcos Number", "HIP 114334"},
        {"Geneva Identification System", "GEN# +1.00218659"},
        {"Smithsonian Astrophysical Observation", "SAO 52743"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.34283362),
        dec: Angle.Degrees(+42.71008439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90351",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90351"},
        {"Smithsonian Astrophysical Observation", "SAO 47492"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.53493117),
        dec: Angle.Degrees(+42.71093979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28213"},
        {"Hipparcos Number", "HIP 20919"},
        {"Geneva Identification System", "GEN# +1.00028213"},
        {"Smithsonian Astrophysical Observation", "SAO 39557"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.25846128),
        dec: Angle.Degrees(+42.71571812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62272",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62272"},
    },
    visualMagnitude: 10.26,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.42030301),
        dec: Angle.Degrees(+42.71797222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140831"},
        {"Hipparcos Number", "HIP 77065"},
        {"Smithsonian Astrophysical Observation", "SAO 45700"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.03432273),
        dec: Angle.Degrees(+42.71988997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107824"},
        {"Hipparcos Number", "HIP 60411"},
        {"Geneva Identification System", "GEN# +1.00107824"},
        {"Smithsonian Astrophysical Observation", "SAO 44151"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.80018067),
        dec: Angle.Degrees(+42.72011949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102778"},
        {"Hipparcos Number", "HIP 57705"},
        {"Geneva Identification System", "GEN# +1.00102778"},
        {"Smithsonian Astrophysical Observation", "SAO 43907"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.51516653),
        dec: Angle.Degrees(+42.72022970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27740"},
        {"Hipparcos Number", "HIP 20590"},
        {"Smithsonian Astrophysical Observation", "SAO 39512"},
    },
    visualMagnitude: 8.45,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.15024798),
        dec: Angle.Degrees(+42.72161995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187121"},
        {"Hipparcos Number", "HIP 97299"},
        {"Smithsonian Astrophysical Observation", "SAO 48822"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.62204766),
        dec: Angle.Degrees(+42.72188666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83309",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10316 AB"},
        {"Henry Draper", "HD 154115"},
        {"Hipparcos Number", "HIP 83309"},
        {"Smithsonian Astrophysical Observation", "SAO 46444"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.39016623),
        dec: Angle.Degrees(+42.72710905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66058",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66058"},
        {"Geneva Identification System", "GEN# +0.04302339"},
        {"Smithsonian Astrophysical Observation", "SAO 44645"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.14059122),
        dec: Angle.Degrees(+42.73109502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53821",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8015 A"},
        {"Henry Draper", "HD 95296"},
        {"Hipparcos Number", "HIP 53821"},
        {"Geneva Identification System", "GEN# +1.00095296"},
        {"Smithsonian Astrophysical Observation", "SAO 43565"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.17525238),
        dec: Angle.Degrees(+42.73144828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106639"},
        {"Hipparcos Number", "HIP 59805"},
        {"Geneva Identification System", "GEN# +1.00106639"},
    },
    visualMagnitude: 10.09,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.95381358),
        dec: Angle.Degrees(+42.73154949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113405",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113405"},
        {"Smithsonian Astrophysical Observation", "SAO 52542"},
        {"Wilson Evans Batten Catalogue", "WEB 20171"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.51270606),
        dec: Angle.Degrees(+42.73643268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210630"},
        {"Hipparcos Number", "HIP 109481"},
        {"Smithsonian Astrophysical Observation", "SAO 51730"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.68610140),
        dec: Angle.Degrees(+42.73660974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10103"},
        {"Hipparcos Number", "HIP 7737"},
        {"Smithsonian Astrophysical Observation", "SAO 37411"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.91193718),
        dec: Angle.Degrees(+42.73866590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11320",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11320"},
        {"Smithsonian Astrophysical Observation", "SAO 38018"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.42482209),
        dec: Angle.Degrees(+42.73957175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91265",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91265"},
        {"Smithsonian Astrophysical Observation", "SAO 47652"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.23833518),
        dec: Angle.Degrees(+42.74021450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63380",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63380"},
    },
    visualMagnitude: 12.27,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.81797195),
        dec: Angle.Degrees(+42.74110413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51055",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7765 AB"},
        {"Hipparcos Number", "HIP 51055"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.47342274),
        dec: Angle.Degrees(+42.74304030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63381",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63381"},
        {"Geneva Identification System", "GEN# +0.04302285"},
        {"Smithsonian Astrophysical Observation", "SAO 44412"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.81923953),
        dec: Angle.Degrees(+42.74629457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225068"},
        {"Hipparcos Number", "HIP 254"},
        {"Smithsonian Astrophysical Observation", "SAO 36018"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.78466955),
        dec: Angle.Degrees(+42.74791705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13434",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13434"},
        {"Smithsonian Astrophysical Observation", "SAO 38415"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.24318106),
        dec: Angle.Degrees(+42.74861340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21751"},
        {"Hipparcos Number", "HIP 16473"},
        {"Smithsonian Astrophysical Observation", "SAO 38922"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.03927484),
        dec: Angle.Degrees(+42.74934737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36317",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6094 B"},
        {"Henry Draper", "HD 58662B"},
        {"Hipparcos Number", "HIP 36317"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.13508134),
        dec: Angle.Degrees(+42.75177910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115019",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115019"},
        {"Smithsonian Astrophysical Observation", "SAO 52869"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.43053988),
        dec: Angle.Degrees(+42.75187050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57050",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57050"},
    },
    visualMagnitude: 11.86,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.43788953),
        dec: Angle.Degrees(+42.75219140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -579.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36315",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6094 A"},
        {"Henry Draper", "HD 58662"},
        {"Hipparcos Number", "HIP 36315"},
        {"Smithsonian Astrophysical Observation", "SAO 41794"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.13057857),
        dec: Angle.Degrees(+42.75255907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153"},
        {"Hipparcos Number", "HIP 530"},
        {"Geneva Identification System", "GEN# +1.00000153"},
        {"Smithsonian Astrophysical Observation", "SAO 36062"},
        {"Wilson Evans Batten Catalogue", "WEB 94"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.60817878),
        dec: Angle.Degrees(+42.75275856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34007"},
        {"Hipparcos Number", "HIP 24565"},
        {"Smithsonian Astrophysical Observation", "SAO 40180"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.05261651),
        dec: Angle.Degrees(+42.75634774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113788",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16467 AB"},
        {"Henry Draper", "HD 217782"},
        {"Hipparcos Number", "HIP 113788"},
        {"Celescope Catalog", "CEL 5558"},
        {"Geneva Identification System", "GEN# +1.00217782J"},
        {"Smithsonian Astrophysical Observation", "SAO 52623"},
        {"Wilson Evans Batten Catalogue", "WEB 20215"},
    },
    visualMagnitude: 5.09,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.65140390),
        dec: Angle.Degrees(+42.75780620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65746",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65746"},
        {"Geneva Identification System", "GEN# +0.04302336"},
        {"Smithsonian Astrophysical Observation", "SAO 44622"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.15736766),
        dec: Angle.Degrees(+42.75936688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81538"},
        {"Hipparcos Number", "HIP 46387"},
        {"Geneva Identification System", "GEN# +1.00081538"},
        {"Smithsonian Astrophysical Observation", "SAO 42869"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.88230848),
        dec: Angle.Degrees(+42.76437418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55020",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55020"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.97451060),
        dec: Angle.Degrees(+42.76493485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199512"},
        {"Hipparcos Number", "HIP 103348"},
        {"Smithsonian Astrophysical Observation", "SAO 50257"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.07840263),
        dec: Angle.Degrees(+42.76876406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77376"},
        {"Hipparcos Number", "HIP 44465"},
        {"Smithsonian Astrophysical Observation", "SAO 42662"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.88482719),
        dec: Angle.Degrees(+42.76973838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110193"},
        {"Hipparcos Number", "HIP 61803"},
        {"Geneva Identification System", "GEN# +1.00110193"},
        {"Smithsonian Astrophysical Observation", "SAO 44274"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.99867455),
        dec: Angle.Degrees(+42.77407229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10952",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1786 AB"},
        {"Aitken 2", "ADS 1786"},
        {"Hipparcos Number", "HIP 10952"},
        {"Smithsonian Astrophysical Observation", "SAO 37964"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.26528503),
        dec: Angle.Degrees(+42.77418515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183473"},
        {"Hipparcos Number", "HIP 95703"},
        {"Geneva Identification System", "GEN# +1.00183473"},
        {"Smithsonian Astrophysical Observation", "SAO 48477"},
        {"Wilson Evans Batten Catalogue", "WEB 16742"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.98826336),
        dec: Angle.Degrees(+42.77626062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 154.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12621",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12621"},
        {"Geneva Identification System", "GEN# +2.10390308"},
        {"Smithsonian Astrophysical Observation", "SAO 38255"},
        {"New General Catalogue", "NGC 1039 308"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.55607716),
        dec: Angle.Degrees(+42.77796705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104811",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104811"},
        {"Smithsonian Astrophysical Observation", "SAO 50602"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.51635788),
        dec: Angle.Degrees(+42.78127430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74237",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74237"},
    },
    visualMagnitude: 10.86,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.56264284),
        dec: Angle.Degrees(+42.78224186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -265.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6864",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1161 AB"},
        {"Henry Draper", "HD 8884"},
        {"Hipparcos Number", "HIP 6864"},
        {"Smithsonian Astrophysical Observation", "SAO 37243"},
        {"Wilson Evans Batten Catalogue", "WEB 1495"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.08041642),
        dec: Angle.Degrees(+42.78225798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139704"},
        {"Hipparcos Number", "HIP 76557"},
        {"Smithsonian Astrophysical Observation", "SAO 45646"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.53098597),
        dec: Angle.Degrees(+42.78246309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211662"},
        {"Hipparcos Number", "HIP 110071"},
        {"Smithsonian Astrophysical Observation", "SAO 51848"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.43612407),
        dec: Angle.Degrees(+42.78254859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 171.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40052",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40052"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.72124871),
        dec: Angle.Degrees(+42.78336830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145728"},
        {"Hipparcos Number", "HIP 79269"},
        {"Geneva Identification System", "GEN# +1.00145728"},
        {"Smithsonian Astrophysical Observation", "SAO 45938"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.66527282),
        dec: Angle.Degrees(+42.78392914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204132"},
        {"Hipparcos Number", "HIP 105775"},
        {"Geneva Identification System", "GEN# +1.00204132"},
        {"Smithsonian Astrophysical Observation", "SAO 50822"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.34016132),
        dec: Angle.Degrees(+42.78420291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182989"},
        {"Hipparcos Number", "HIP 95497"},
        {"Geneva Identification System", "GEN# +1.00182989"},
        {"Smithsonian Astrophysical Observation", "SAO 48421"},
        {"Wilson Evans Batten Catalogue", "WEB 16701"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.36666695),
        dec: Angle.Degrees(+42.78483521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15830"},
        {"Hipparcos Number", "HIP 11949"},
        {"Cincinnati Publication", "Ci 18 329"},
        {"Cincinnati Publication 2", "Ci 20 172"},
        {"Geneva Identification System", "GEN# +1.00015830"},
        {"Smithsonian Astrophysical Observation", "SAO 38127"},
        {"Wilson Evans Batten Catalogue", "WEB 2469"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.54307752),
        dec: Angle.Degrees(+42.78572679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 406.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113485",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113485"},
        {"Celescope Catalog", "CEL 5553"},
        {"Geneva Identification System", "GEN# +0.04204558"},
        {"Smithsonian Astrophysical Observation", "SAO 52557"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.73994381),
        dec: Angle.Degrees(+42.78660408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38304",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38304"},
        {"Smithsonian Astrophysical Observation", "SAO 42030"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.71372817),
        dec: Angle.Degrees(+42.78725786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141892"},
        {"Hipparcos Number", "HIP 77530"},
        {"Smithsonian Astrophysical Observation", "SAO 45751"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.46362461),
        dec: Angle.Degrees(+42.78871213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74516",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74516"},
    },
    visualMagnitude: 11.23,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.40623706),
        dec: Angle.Degrees(+42.78951167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -160.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 82.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34269"},
        {"Hipparcos Number", "HIP 24738"},
        {"Geneva Identification System", "GEN# +1.00034269"},
        {"Smithsonian Astrophysical Observation", "SAO 40214"},
        {"Wilson Evans Batten Catalogue", "WEB 4785"},
    },
    visualMagnitude: 5.55,
    bvColour: 1.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.56534453),
        dec: Angle.Degrees(+42.79218517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132131"},
        {"Hipparcos Number", "HIP 73072"},
        {"Geneva Identification System", "GEN# +1.00132131"},
        {"Smithsonian Astrophysical Observation", "SAO 45282"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.00474213),
        dec: Angle.Degrees(+42.79244473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99761"},
        {"Hipparcos Number", "HIP 56018"},
        {"Smithsonian Astrophysical Observation", "SAO 43764"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.21280660),
        dec: Angle.Degrees(+42.79343647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120265"},
        {"Hipparcos Number", "HIP 67294"},
        {"Geneva Identification System", "GEN# +1.00120265"},
        {"Smithsonian Astrophysical Observation", "SAO 44751"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.86690547),
        dec: Angle.Degrees(+42.79501917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59912",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59912"},
        {"Geneva Identification System", "GEN# +0.04302205"},
        {"Smithsonian Astrophysical Observation", "SAO 44107"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.33870528),
        dec: Angle.Degrees(+42.79502164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88909"},
        {"Hipparcos Number", "HIP 50302"},
        {"Geneva Identification System", "GEN# +1.00088909"},
        {"Smithsonian Astrophysical Observation", "SAO 43255"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.05949478),
        dec: Angle.Degrees(+42.79671754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11510",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1866 B"},
        {"Hipparcos Number", "HIP 11510"},
    },
    visualMagnitude: 12.11,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.09778108),
        dec: Angle.Degrees(+42.79890416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130725"},
        {"Hipparcos Number", "HIP 72419"},
    },
    visualMagnitude: 9.94,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.12084265),
        dec: Angle.Degrees(+42.79970578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98551",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98551"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.29012928),
        dec: Angle.Degrees(+42.79988114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43795"},
        {"Hipparcos Number", "HIP 30117"},
        {"Geneva Identification System", "GEN# +1.00043795"},
        {"Smithsonian Astrophysical Observation", "SAO 41030"},
        {"Wilson Evans Batten Catalogue", "WEB 5990"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.06676568),
        dec: Angle.Degrees(+42.79994197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90622",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90622"},
    },
    visualMagnitude: 9.85,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.36692271),
        dec: Angle.Degrees(+42.80217893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11511",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1866 A"},
        {"Henry Draper", "HD 15217"},
        {"Hipparcos Number", "HIP 11511"},
        {"Smithsonian Astrophysical Observation", "SAO 38050"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.10120148),
        dec: Angle.Degrees(+42.80248550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167369"},
        {"Hipparcos Number", "HIP 89257"},
        {"Smithsonian Astrophysical Observation", "SAO 47310"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.22095651),
        dec: Angle.Degrees(+42.80316774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2089",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2089"},
        {"Smithsonian Astrophysical Observation", "SAO 36366"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.59450304),
        dec: Angle.Degrees(+42.80429179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214421"},
        {"Hipparcos Number", "HIP 111664"},
        {"Smithsonian Astrophysical Observation", "SAO 52190"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.31229237),
        dec: Angle.Degrees(+42.81034156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99707"},
        {"Hipparcos Number", "HIP 55991"},
        {"Smithsonian Astrophysical Observation", "SAO 43757"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.12135488),
        dec: Angle.Degrees(+42.81329279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209469"},
        {"Hipparcos Number", "HIP 108819"},
        {"Celescope Catalog", "CEL 5422"},
        {"Geneva Identification System", "GEN# +1.00209469"},
        {"Smithsonian Astrophysical Observation", "SAO 51589"},
        {"Wilson Evans Batten Catalogue", "WEB 19574"},
    },
    visualMagnitude: 7.22,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.68475125),
        dec: Angle.Degrees(+42.81450988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97167"},
        {"Hipparcos Number", "HIP 54681"},
        {"Smithsonian Astrophysical Observation", "SAO 43639"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.90727560),
        dec: Angle.Degrees(+42.81818314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -242.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185872"},
        {"Hipparcos Number", "HIP 96693"},
        {"Celescope Catalog", "CEL 4812"},
        {"Fundamental Katalog 5th Edition", "FK5 3572"},
        {"Geneva Identification System", "GEN# +1.00185872"},
        {"Renson", "Renson 51260"},
        {"Smithsonian Astrophysical Observation", "SAO 48691"},
        {"Wilson Evans Batten Catalogue", "WEB 16963"},
    },
    visualMagnitude: 5.41,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.86027686),
        dec: Angle.Degrees(+42.81821158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66187",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8952 AB"},
        {"Hipparcos Number", "HIP 66187"},
        {"Geneva Identification System", "GEN# +0.04402284J"},
    },
    visualMagnitude: 11.43,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)33, 58.7800),
        dec: Angle.DegreesMinutesSeconds((int)+43, (int)15, 52.200)
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
    primaryId: "HIP 115127",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115127"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.77659274),
        dec: Angle.Degrees(+42.81924480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20752"},
        {"Hipparcos Number", "HIP 15697"},
        {"Smithsonian Astrophysical Observation", "SAO 38757"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.55008175),
        dec: Angle.Degrees(+42.82226533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4883",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4883"},
        {"Smithsonian Astrophysical Observation", "SAO 36870"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.68507507),
        dec: Angle.Degrees(+42.82287613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152792"},
        {"Hipparcos Number", "HIP 82636"},
        {"Geneva Identification System", "GEN# +1.00152792"},
        {"Smithsonian Astrophysical Observation", "SAO 46350"},
        {"Wilson Evans Batten Catalogue", "WEB 13952"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.38430228),
        dec: Angle.Degrees(+42.82564648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -325.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110411",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110411"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.46698979),
        dec: Angle.Degrees(+42.82593408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128660"},
        {"Hipparcos Number", "HIP 71466"},
        {"Geneva Identification System", "GEN# +1.00128660"},
        {"Smithsonian Astrophysical Observation", "SAO 45133"},
        {"Wilson Evans Batten Catalogue", "WEB 12330"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.23290205),
        dec: Angle.Degrees(+42.83130025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 277622"},
        {"Hipparcos Number", "HIP 24281"},
        {"Geneva Identification System", "GEN# +1.00277622"},
        {"Smithsonian Astrophysical Observation", "SAO 40115"},
        {"Wilson Evans Batten Catalogue", "WEB 4711"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.16344570),
        dec: Angle.Degrees(+42.83178064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97194"},
        {"Hipparcos Number", "HIP 54692"},
        {"Geneva Identification System", "GEN# +1.00097194"},
        {"Smithsonian Astrophysical Observation", "SAO 43641"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.95436777),
        dec: Angle.Degrees(+42.83268708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -237.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160419"},
        {"Hipparcos Number", "HIP 86272"},
        {"Smithsonian Astrophysical Observation", "SAO 46850"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.42082767),
        dec: Angle.Degrees(+42.83369096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192403"},
        {"Hipparcos Number", "HIP 99619"},
        {"Smithsonian Astrophysical Observation", "SAO 49326"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.25049378),
        dec: Angle.Degrees(+42.83508413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218754"},
        {"Hipparcos Number", "HIP 114384"},
        {"Smithsonian Astrophysical Observation", "SAO 52751"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.49158281),
        dec: Angle.Degrees(+42.83594603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32548"},
        {"Hipparcos Number", "HIP 23726"},
        {"Geneva Identification System", "GEN# +1.00032548"},
        {"Smithsonian Astrophysical Observation", "SAO 40018"},
        {"Wilson Evans Batten Catalogue", "WEB 4627"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.51169640),
        dec: Angle.Degrees(+42.83707068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100040"},
        {"Hipparcos Number", "HIP 56171"},
        {"Smithsonian Astrophysical Observation", "SAO 43791"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.72237104),
        dec: Angle.Degrees(+42.83865864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211496"},
        {"Hipparcos Number", "HIP 109989"},
        {"Smithsonian Astrophysical Observation", "SAO 51827"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.15134535),
        dec: Angle.Degrees(+42.83987661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50706",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50706"},
        {"Smithsonian Astrophysical Observation", "SAO 43299"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.31204548),
        dec: Angle.Degrees(+42.84175207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134587"},
        {"Hipparcos Number", "HIP 74167"},
        {"Smithsonian Astrophysical Observation", "SAO 45401"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.31268517),
        dec: Angle.Degrees(+42.84437955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11689"},
        {"Hipparcos Number", "HIP 8982"},
        {"Geneva Identification System", "GEN# +1.00011689"},
        {"Smithsonian Astrophysical Observation", "SAO 37616"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.94146465),
        dec: Angle.Degrees(+42.84455169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73972"},
        {"Hipparcos Number", "HIP 42768"},
        {"Smithsonian Astrophysical Observation", "SAO 42509"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.72342595),
        dec: Angle.Degrees(+42.84492915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196789"},
        {"Hipparcos Number", "HIP 101818"},
        {"Geneva Identification System", "GEN# +1.00196789"},
        {"Smithsonian Astrophysical Observation", "SAO 49877"},
        {"Wilson Evans Batten Catalogue", "WEB 18396"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.49513377),
        dec: Angle.Degrees(+42.84522012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 171.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141847"},
        {"Hipparcos Number", "HIP 77497"},
        {"Smithsonian Astrophysical Observation", "SAO 45748"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.36707118),
        dec: Angle.Degrees(+42.84536934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221613"},
        {"Hipparcos Number", "HIP 116259"},
        {"Cincinnati Publication", "Ci 18 3086"},
        {"Geneva Identification System", "GEN# +1.00221613"},
        {"Smithsonian Astrophysical Observation", "SAO 53142"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.34944685),
        dec: Angle.Degrees(+42.84622206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 243.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 167.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6678"},
        {"Hipparcos Number", "HIP 5325"},
        {"Fundamental Katalog 5th Edition", "FK5 4103"},
        {"Geneva Identification System", "GEN# +1.00006678"},
        {"Smithsonian Astrophysical Observation", "SAO 36951"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.02479964),
        dec: Angle.Degrees(+42.84792794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32092",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32092"},
        {"Smithsonian Astrophysical Observation", "SAO 41280"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.56930616),
        dec: Angle.Degrees(+42.84868422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39967"},
        {"Hipparcos Number", "HIP 28246"},
        {"Geneva Identification System", "GEN# +1.00039967"},
        {"Smithsonian Astrophysical Observation", "SAO 40733"},
        {"Wilson Evans Batten Catalogue", "WEB 5526"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.53419328),
        dec: Angle.Degrees(+42.84888928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12375"},
        {"Hipparcos Number", "HIP 9518"},
        {"Smithsonian Astrophysical Observation", "SAO 37720"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.60480847),
        dec: Angle.Degrees(+42.84924892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4621",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4621"},
        {"Smithsonian Astrophysical Observation", "SAO 36822"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.84140912),
        dec: Angle.Degrees(+42.85120134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108100"},
        {"Hipparcos Number", "HIP 60571"},
        {"Geneva Identification System", "GEN# +1.00108100"},
        {"Smithsonian Astrophysical Observation", "SAO 44164"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.23755204),
        dec: Angle.Degrees(+42.85464851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163076"},
        {"Hipparcos Number", "HIP 87454"},
        {"Smithsonian Astrophysical Observation", "SAO 47022"},
    },
    visualMagnitude: 7.56,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.03846557),
        dec: Angle.Degrees(+42.85715976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48860",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48860"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.48462947),
        dec: Angle.Degrees(+42.85817811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10079",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1675 A"},
        {"Henry Draper", "HD 13151"},
        {"Hipparcos Number", "HIP 10079"},
        {"Smithsonian Astrophysical Observation", "SAO 37817"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.40934712),
        dec: Angle.Degrees(+42.85830544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 139.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132109"},
        {"Hipparcos Number", "HIP 73069"},
        {"Geneva Identification System", "GEN# +1.00132109"},
        {"Smithsonian Astrophysical Observation", "SAO 45281"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.99891620),
        dec: Angle.Degrees(+42.85842326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85619",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85619"},
        {"Smithsonian Astrophysical Observation", "SAO 46747"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.43456045),
        dec: Angle.Degrees(+42.85910589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3307",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3307"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.53573020),
        dec: Angle.Degrees(+42.85919189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207755"},
        {"Hipparcos Number", "HIP 107791"},
        {"Geneva Identification System", "GEN# +1.00207755"},
        {"Smithsonian Astrophysical Observation", "SAO 51351"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.54077275),
        dec: Angle.Degrees(+42.85955306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215675"},
        {"Hipparcos Number", "HIP 112419"},
        {"Smithsonian Astrophysical Observation", "SAO 52349"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.55413632),
        dec: Angle.Degrees(+42.85986116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165566"},
        {"Hipparcos Number", "HIP 88515"},
        {"Fundamental Katalog 5th Edition", "FK5 5592"},
        {"Geneva Identification System", "GEN# +1.00165566"},
        {"Smithsonian Astrophysical Observation", "SAO 47191"},
        {"Wilson Evans Batten Catalogue", "WEB 14977"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.12458440),
        dec: Angle.Degrees(+42.86061790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213370"},
        {"Hipparcos Number", "HIP 111077"},
        {"Smithsonian Astrophysical Observation", "SAO 52070"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.53951845),
        dec: Angle.Degrees(+42.86106869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38130"},
        {"Hipparcos Number", "HIP 27178"},
        {"Smithsonian Astrophysical Observation", "SAO 40582"},
        {"Wilson Evans Batten Catalogue", "WEB 5342"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.40171969),
        dec: Angle.Degrees(+42.86350342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99267",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99267"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.25549207),
        dec: Angle.Degrees(+42.86443185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 340.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158590"},
        {"Hipparcos Number", "HIP 85481"},
        {"Smithsonian Astrophysical Observation", "SAO 46737"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.04037633),
        dec: Angle.Degrees(+42.86633970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53381"},
        {"Hipparcos Number", "HIP 34329"},
        {"Geneva Identification System", "GEN# +1.00053381"},
        {"Smithsonian Astrophysical Observation", "SAO 41560"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.74600776),
        dec: Angle.Degrees(+42.86752954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167560"},
        {"Hipparcos Number", "HIP 89336"},
        {"Geneva Identification System", "GEN# +1.00167560"},
        {"Smithsonian Astrophysical Observation", "SAO 47324"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.42438511),
        dec: Angle.Degrees(+42.87939359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1552"},
        {"Hipparcos Number", "HIP 1591"},
        {"Fundamental Katalog 5th Edition", "FK5 4036"},
        {"Geneva Identification System", "GEN# +1.00001552"},
        {"Smithsonian Astrophysical Observation", "SAO 36270"},
        {"Wilson Evans Batten Catalogue", "WEB 288"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.97083884),
        dec: Angle.Degrees(+42.87999295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37163",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37163"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.55796508),
        dec: Angle.Degrees(+42.88022260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15997",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15997"},
        {"Smithsonian Astrophysical Observation", "SAO 38826"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.51619478),
        dec: Angle.Degrees(+42.88087023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23624"},
        {"Hipparcos Number", "HIP 17781"},
        {"Smithsonian Astrophysical Observation", "SAO 39114"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.09401503),
        dec: Angle.Degrees(+42.88107555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138004"},
        {"Hipparcos Number", "HIP 75676"},
        {"Cincinnati Publication", "Ci 18 2070"},
        {"Geneva Identification System", "GEN# +1.00138004A"},
        {"Smithsonian Astrophysical Observation", "SAO 45551"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.91830685),
        dec: Angle.Degrees(+42.88198399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -249.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40694"},
        {"Hipparcos Number", "HIP 28628"},
        {"Geneva Identification System", "GEN# +1.00040694"},
        {"Smithsonian Astrophysical Observation", "SAO 40804"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.66331009),
        dec: Angle.Degrees(+42.88222133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69390"},
        {"Hipparcos Number", "HIP 40711"},
        {"Smithsonian Astrophysical Observation", "SAO 42282"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.64857833),
        dec: Angle.Degrees(+42.88478449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57026",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57026"},
        {"Smithsonian Astrophysical Observation", "SAO 43862"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.38546361),
        dec: Angle.Degrees(+42.88482061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156924"},
        {"Hipparcos Number", "HIP 84646"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.57237993),
        dec: Angle.Degrees(+42.88650406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53076",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53076"},
        {"Smithsonian Astrophysical Observation", "SAO 43495"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.88315374),
        dec: Angle.Degrees(+42.88666673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22157"},
        {"Hipparcos Number", "HIP 16774"},
        {"Smithsonian Astrophysical Observation", "SAO 38973"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.96754350),
        dec: Angle.Degrees(+42.88681409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215347"},
        {"Hipparcos Number", "HIP 112231"},
        {"Smithsonian Astrophysical Observation", "SAO 52313"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.96127755),
        dec: Angle.Degrees(+42.89181775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199580"},
        {"Hipparcos Number", "HIP 103392"},
        {"Cincinnati Publication", "Ci 18 2712"},
        {"Geneva Identification System", "GEN# +1.00199580"},
        {"Smithsonian Astrophysical Observation", "SAO 50265"},
        {"Wilson Evans Batten Catalogue", "WEB 18797"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.19936142),
        dec: Angle.Degrees(+42.89511722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 218.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 225.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56529",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56529"},
        {"Smithsonian Astrophysical Observation", "SAO 43817"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.86436522),
        dec: Angle.Degrees(+42.89572707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15753"},
        {"Hipparcos Number", "HIP 11873"},
        {"Geneva Identification System", "GEN# +1.00015753"},
        {"Smithsonian Astrophysical Observation", "SAO 38112"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.29069864),
        dec: Angle.Degrees(+42.89633723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107823"},
        {"Hipparcos Number", "HIP 60413"},
        {"Geneva Identification System", "GEN# +1.00107823"},
        {"Smithsonian Astrophysical Observation", "SAO 44152"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.80595174),
        dec: Angle.Degrees(+42.89953712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76881"},
        {"Hipparcos Number", "HIP 44233"},
        {"Smithsonian Astrophysical Observation", "SAO 42641"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.13052460),
        dec: Angle.Degrees(+42.90089653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14095"},
        {"Hipparcos Number", "HIP 10721"},
        {"Geneva Identification System", "GEN# +1.00014095"},
        {"Smithsonian Astrophysical Observation", "SAO 37931"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.50305766),
        dec: Angle.Degrees(+42.90122478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32861"},
        {"Hipparcos Number", "HIP 23911"},
        {"Geneva Identification System", "GEN# +1.00032861"},
        {"Smithsonian Astrophysical Observation", "SAO 40046"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.06475472),
        dec: Angle.Degrees(+42.90191394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129754"},
        {"Hipparcos Number", "HIP 71965"},
        {"Smithsonian Astrophysical Observation", "SAO 45185"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.77873189),
        dec: Angle.Degrees(+42.90199469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175466"},
        {"Hipparcos Number", "HIP 92713"},
        {"Smithsonian Astrophysical Observation", "SAO 47895"},
        {"Wilson Evans Batten Catalogue", "WEB 16040"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.36877329),
        dec: Angle.Degrees(+42.90262183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117759",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117759"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.21991658),
        dec: Angle.Degrees(+42.90271820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44249"},
        {"Hipparcos Number", "HIP 30340"},
        {"Smithsonian Astrophysical Observation", "SAO 41054"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.73078100),
        dec: Angle.Degrees(+42.90359005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143327"},
        {"Hipparcos Number", "HIP 78199"},
        {"Smithsonian Astrophysical Observation", "SAO 45806"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.52540163),
        dec: Angle.Degrees(+42.90678790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19922"},
        {"Hipparcos Number", "HIP 15028"},
        {"Geneva Identification System", "GEN# +1.00019922"},
        {"Smithsonian Astrophysical Observation", "SAO 38656"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.41409053),
        dec: Angle.Degrees(+42.90779321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26395"},
        {"Hipparcos Number", "HIP 19628"},
        {"Geneva Identification System", "GEN# +1.00026395"},
        {"Smithsonian Astrophysical Observation", "SAO 39379"},
        {"Wilson Evans Batten Catalogue", "WEB 3750"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.08598840),
        dec: Angle.Degrees(+42.90781647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19130"},
        {"Hipparcos Number", "HIP 14427"},
        {"Smithsonian Astrophysical Observation", "SAO 38576"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.56049234),
        dec: Angle.Degrees(+42.90791799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55539",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55539"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.63253894),
        dec: Angle.Degrees(+42.90899141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187710"},
        {"Hipparcos Number", "HIP 97547"},
        {"Smithsonian Astrophysical Observation", "SAO 48876"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.40487429),
        dec: Angle.Degrees(+42.90952010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223705"},
        {"Hipparcos Number", "HIP 117672"},
        {"Fundamental Katalog 5th Edition", "FK5 6113"},
        {"Geneva Identification System", "GEN# +1.00223705"},
        {"Smithsonian Astrophysical Observation", "SAO 53430"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.96193132),
        dec: Angle.Degrees(+42.90983996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27969"},
        {"Hipparcos Number", "HIP 20753"},
        {"Geneva Identification System", "GEN# +1.00027969"},
        {"Smithsonian Astrophysical Observation", "SAO 39537"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.70560562),
        dec: Angle.Degrees(+42.90991731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 134.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -177.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75972",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75972"},
        {"Smithsonian Astrophysical Observation", "SAO 45581"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.73189725),
        dec: Angle.Degrees(+42.91117013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40801"},
        {"Hipparcos Number", "HIP 28677"},
        {"Fundamental Katalog 5th Edition", "FK5 2461"},
        {"Geneva Identification System", "GEN# +1.00040801"},
        {"Smithsonian Astrophysical Observation", "SAO 40818"},
        {"Wilson Evans Batten Catalogue", "WEB 5606"},
    },
    visualMagnitude: 6.08,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.82447173),
        dec: Angle.Degrees(+42.91188721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220885"},
        {"Hipparcos Number", "HIP 115755"},
        {"Geneva Identification System", "GEN# +1.00220885"},
        {"Renson", "Renson 60550"},
        {"Smithsonian Astrophysical Observation", "SAO 53039"},
        {"Wilson Evans Batten Catalogue", "WEB 20483"},
    },
    visualMagnitude: 5.75,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.78054498),
        dec: Angle.Degrees(+42.91196859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95241"},
        {"Hipparcos Number", "HIP 53791"},
        {"Geneva Identification System", "GEN# +1.00095241"},
        {"Smithsonian Astrophysical Observation", "SAO 43564"},
        {"Wilson Evans Batten Catalogue", "WEB 9747"},
    },
    visualMagnitude: 6.03,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.08650950),
        dec: Angle.Degrees(+42.91202075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174829"},
        {"Hipparcos Number", "HIP 92455"},
        {"Smithsonian Astrophysical Observation", "SAO 47844"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.62931877),
        dec: Angle.Degrees(+42.91209157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50372",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Tania Borealis"},
        {"Henry Draper", "HD 89021"},
        {"Hipparcos Number", "HIP 50372"},
        {"Fundamental Katalog 5th Edition", "FK5 383"},
        {"Geneva Identification System", "GEN# +1.00089021"},
        {"Renson", "Renson 25478"},
        {"Smithsonian Astrophysical Observation", "SAO 43268"},
        {"Wilson Evans Batten Catalogue", "WEB 9245"},
    },
    visualMagnitude: 3.45,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.27469564),
        dec: Angle.Degrees(+42.91446855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -170.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103272"},
        {"Hipparcos Number", "HIP 57985"},
        {"Geneva Identification System", "GEN# +1.00103272"},
        {"Smithsonian Astrophysical Observation", "SAO 43938"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.40911228),
        dec: Angle.Degrees(+42.91607549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100885",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100885"},
        {"Smithsonian Astrophysical Observation", "SAO 49646"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.83437675),
        dec: Angle.Degrees(+42.91608422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96846",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96846"},
        {"Smithsonian Astrophysical Observation", "SAO 48724"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.28484969),
        dec: Angle.Degrees(+42.91648100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77451",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77451"},
        {"Geneva Identification System", "GEN# +6.20030750"},
    },
    visualMagnitude: 11.17,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.18746042),
        dec: Angle.Degrees(+42.91880861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 90.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218380"},
        {"Hipparcos Number", "HIP 114157"},
        {"Smithsonian Astrophysical Observation", "SAO 52698"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.78549661),
        dec: Angle.Degrees(+42.91974606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82196",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82196"},
        {"Smithsonian Astrophysical Observation", "SAO 46290"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.88784706),
        dec: Angle.Degrees(+42.91976504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225022"},
        {"Hipparcos Number", "HIP 216"},
        {"Smithsonian Astrophysical Observation", "SAO 36007"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.67692229),
        dec: Angle.Degrees(+42.92069156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106021"},
        {"Hipparcos Number", "HIP 59472"},
        {"Smithsonian Astrophysical Observation", "SAO 44074"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.97609676),
        dec: Angle.Degrees(+42.92234570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157821"},
        {"Hipparcos Number", "HIP 85106"},
        {"Smithsonian Astrophysical Observation", "SAO 46685"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.90281845),
        dec: Angle.Degrees(+42.92818156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200103"},
        {"Hipparcos Number", "HIP 103648"},
        {"Smithsonian Astrophysical Observation", "SAO 50336"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.00123311),
        dec: Angle.Degrees(+42.93122608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6963"},
        {"Hipparcos Number", "HIP 5521"},
        {"Smithsonian Astrophysical Observation", "SAO 36995"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.67511529),
        dec: Angle.Degrees(+42.93231721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -153.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -199.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7590"},
        {"Hipparcos Number", "HIP 5944"},
        {"Geneva Identification System", "GEN# +1.00007590"},
        {"Smithsonian Astrophysical Observation", "SAO 37069"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.12226076),
        dec: Angle.Degrees(+42.93949385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37551",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37551"},
    },
    visualMagnitude: 10.25,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.60234299),
        dec: Angle.Degrees(+42.93984829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -177.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78512"},
        {"Hipparcos Number", "HIP 45015"},
        {"Geneva Identification System", "GEN# +1.00078512"},
        {"Smithsonian Astrophysical Observation", "SAO 42730"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.52929377),
        dec: Angle.Degrees(+42.94040568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117230",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117230"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.53948534),
        dec: Angle.Degrees(+42.94316027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14437"},
        {"Hipparcos Number", "HIP 10951"},
        {"Renson", "Renson 3640"},
        {"Smithsonian Astrophysical Observation", "SAO 37963"},
    },
    visualMagnitude: 7.26,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.26111181),
        dec: Angle.Degrees(+42.94399354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14695",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14695"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.46294333),
        dec: Angle.Degrees(+42.94573479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50315"},
        {"Hipparcos Number", "HIP 33218"},
        {"Smithsonian Astrophysical Observation", "SAO 41423"},
        {"Wilson Evans Batten Catalogue", "WEB 6679"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.69458662),
        dec: Angle.Degrees(+42.94785856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 915"},
        {"Hipparcos Number", "HIP 1093"},
        {"Smithsonian Astrophysical Observation", "SAO 36178"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.41100419),
        dec: Angle.Degrees(+42.94939358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110476",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110476"},
        {"Smithsonian Astrophysical Observation", "SAO 51933"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.67242247),
        dec: Angle.Degrees(+42.95119929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210208"},
        {"Hipparcos Number", "HIP 109238"},
        {"Smithsonian Astrophysical Observation", "SAO 51671"},
        {"Wilson Evans Batten Catalogue", "WEB 19633"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.95401690),
        dec: Angle.Degrees(+42.95325054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5502",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 11.57,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)10, 29.8200),
        dec: Angle.DegreesMinutesSeconds((int)+42, (int)57, 11.800)
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
    primaryId: "HIP 109831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211211"},
        {"Hipparcos Number", "HIP 109831"},
        {"Fundamental Katalog 5th Edition", "FK5 3778"},
        {"Geneva Identification System", "GEN# +1.00211211"},
        {"Smithsonian Astrophysical Observation", "SAO 51797"},
        {"Wilson Evans Batten Catalogue", "WEB 19726"},
    },
    visualMagnitude: 5.72,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.68471113),
        dec: Angle.Degrees(+42.95396372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198480"},
        {"Hipparcos Number", "HIP 102746"},
        {"Celescope Catalog", "CEL 5177"},
        {"Geneva Identification System", "GEN# +1.00198480"},
        {"Smithsonian Astrophysical Observation", "SAO 50102"},
        {"Wilson Evans Batten Catalogue", "WEB 18628"},
    },
    visualMagnitude: 7.33,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.28087775),
        dec: Angle.Degrees(+42.95492736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13863",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13863"},
        {"Smithsonian Astrophysical Observation", "SAO 38481"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.61716243),
        dec: Angle.Degrees(+42.95630591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165623"},
        {"Hipparcos Number", "HIP 88543"},
        {"Smithsonian Astrophysical Observation", "SAO 47194"},
        {"Wilson Evans Batten Catalogue", "WEB 14991"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.20336923),
        dec: Angle.Degrees(+42.95772527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4102",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4102"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.16478607),
        dec: Angle.Degrees(+42.95805639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51218",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51218"},
    },
    visualMagnitude: 10.08,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.92472097),
        dec: Angle.Degrees(+42.96083319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -184.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172924"},
        {"Hipparcos Number", "HIP 91590"},
        {"Smithsonian Astrophysical Observation", "SAO 47696"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.18327726),
        dec: Angle.Degrees(+42.96250073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147233"},
        {"Hipparcos Number", "HIP 79927"},
        {"Smithsonian Astrophysical Observation", "SAO 46020"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.70610539),
        dec: Angle.Degrees(+42.96347268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82905"},
        {"Hipparcos Number", "HIP 47124"},
        {"Smithsonian Astrophysical Observation", "SAO 42939"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.03743138),
        dec: Angle.Degrees(+42.96674302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36018",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36018"},
        {"Smithsonian Astrophysical Observation", "SAO 41754"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.33788864),
        dec: Angle.Degrees(+42.96774693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51709"},
        {"Hipparcos Number", "HIP 33738"},
        {"Smithsonian Astrophysical Observation", "SAO 41492"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.13931202),
        dec: Angle.Degrees(+42.96776250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29258"},
        {"Hipparcos Number", "HIP 21614"},
        {"Smithsonian Astrophysical Observation", "SAO 39664"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.60416658),
        dec: Angle.Degrees(+42.96883020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25951",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25951"},
        {"Smithsonian Astrophysical Observation", "SAO 40404"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.06006295),
        dec: Angle.Degrees(+42.96997783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205350"},
        {"Hipparcos Number", "HIP 106435"},
        {"Smithsonian Astrophysical Observation", "SAO 51029"},
    },
    visualMagnitude: 8.10,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.36940765),
        dec: Angle.Degrees(+42.97185526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103067",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103067"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.23859191),
        dec: Angle.Degrees(+42.97379389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 144.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182487"},
        {"Hipparcos Number", "HIP 95272"},
        {"Geneva Identification System", "GEN# +1.00182487"},
        {"Smithsonian Astrophysical Observation", "SAO 48383"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.75155431),
        dec: Angle.Degrees(+42.97418607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65368"},
        {"Hipparcos Number", "HIP 39135"},
        {"Smithsonian Astrophysical Observation", "SAO 42117"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.07863915),
        dec: Angle.Degrees(+42.97419523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157806"},
        {"Hipparcos Number", "HIP 85091"},
        {"Fundamental Katalog 5th Edition", "FK5 5532"},
        {"Smithsonian Astrophysical Observation", "SAO 46684"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.86515577),
        dec: Angle.Degrees(+42.97627657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5431"},
        {"Hipparcos Number", "HIP 4411"},
        {"Smithsonian Astrophysical Observation", "SAO 36785"},
    },
    visualMagnitude: 6.53,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.12785159),
        dec: Angle.Degrees(+42.97881029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116231"},
        {"Hipparcos Number", "HIP 65194"},
        {"Geneva Identification System", "GEN# +1.00116231"},
        {"Smithsonian Astrophysical Observation", "SAO 44580"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.40745203),
        dec: Angle.Degrees(+42.97886399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99880",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99880"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.96927228),
        dec: Angle.Degrees(+42.97920300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21565"},
        {"Hipparcos Number", "HIP 16323"},
        {"Smithsonian Astrophysical Observation", "SAO 38892"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.60595504),
        dec: Angle.Degrees(+42.97972772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80965"},
        {"Hipparcos Number", "HIP 46118"},
        {"Smithsonian Astrophysical Observation", "SAO 42839"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.07244579),
        dec: Angle.Degrees(+42.97986983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119964"},
        {"Hipparcos Number", "HIP 67147"},
        {"Smithsonian Astrophysical Observation", "SAO 44736"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.40914383),
        dec: Angle.Degrees(+42.98128034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90523"},
        {"Hipparcos Number", "HIP 51243"},
        {"Smithsonian Astrophysical Observation", "SAO 43352"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.99606892),
        dec: Angle.Degrees(+42.98131400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131712"},
        {"Hipparcos Number", "HIP 72880"},
        {"Fundamental Katalog 5th Edition", "FK5 5321"},
        {"Smithsonian Astrophysical Observation", "SAO 45262"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.43859171),
        dec: Angle.Degrees(+42.98192177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41074"},
        {"Hipparcos Number", "HIP 28823"},
        {"Geneva Identification System", "GEN# +1.00041074"},
        {"Smithsonian Astrophysical Observation", "SAO 40840"},
        {"Wilson Evans Batten Catalogue", "WEB 5640"},
    },
    visualMagnitude: 5.90,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.26425064),
        dec: Angle.Degrees(+42.98198550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38818"},
        {"Hipparcos Number", "HIP 27595"},
        {"Geneva Identification System", "GEN# +1.00038818"},
        {"Smithsonian Astrophysical Observation", "SAO 40643"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.64816952),
        dec: Angle.Degrees(+42.98260063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92775",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92775"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.57051535),
        dec: Angle.Degrees(+42.98282048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 254.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100515",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13786 AB"},
        {"Henry Draper", "HD 194220"},
        {"Hipparcos Number", "HIP 100515"},
        {"Geneva Identification System", "GEN# +1.00194220"},
        {"Smithsonian Astrophysical Observation", "SAO 49550"},
        {"Wilson Evans Batten Catalogue", "WEB 18155"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.73120017),
        dec: Angle.Degrees(+42.98343905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65935",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65935"},
        {"Smithsonian Astrophysical Observation", "SAO 44634"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.75556198),
        dec: Angle.Degrees(+42.98349373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -236.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68012",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68012"},
        {"Smithsonian Astrophysical Observation", "SAO 44802"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.91515467),
        dec: Angle.Degrees(+42.98447671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184148"},
        {"Hipparcos Number", "HIP 96013"},
        {"Smithsonian Astrophysical Observation", "SAO 48545"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.82561685),
        dec: Angle.Degrees(+42.98695658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214677"},
        {"Hipparcos Number", "HIP 111831"},
        {"Smithsonian Astrophysical Observation", "SAO 52224"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.77756018),
        dec: Angle.Degrees(+42.98823912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146045"},
        {"Hipparcos Number", "HIP 79409"},
        {"Smithsonian Astrophysical Observation", "SAO 45963"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.08955500),
        dec: Angle.Degrees(+42.98865488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138932"},
        {"Hipparcos Number", "HIP 76173"},
        {"Smithsonian Astrophysical Observation", "SAO 45610"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.38387956),
        dec: Angle.Degrees(+42.98947324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196687"},
        {"Hipparcos Number", "HIP 101755"},
        {"Celescope Catalog", "CEL 5130"},
        {"Geneva Identification System", "GEN# +1.00196687"},
        {"Smithsonian Astrophysical Observation", "SAO 49867"},
        {"Wilson Evans Batten Catalogue", "WEB 18381"},
    },
    visualMagnitude: 7.28,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.34580635),
        dec: Angle.Degrees(+42.99117813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100529",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13786 C"},
        {"Henry Draper", "HD 194260"},
        {"Hipparcos Number", "HIP 100529"},
        {"Smithsonian Astrophysical Observation", "SAO 49555"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.76114409),
        dec: Angle.Degrees(+42.99401226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177328"},
        {"Hipparcos Number", "HIP 93482"},
        {"Smithsonian Astrophysical Observation", "SAO 48023"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.56820949),
        dec: Angle.Degrees(+42.99575379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70687"},
        {"Hipparcos Number", "HIP 41253"},
        {"Geneva Identification System", "GEN# +1.00070687"},
        {"Smithsonian Astrophysical Observation", "SAO 42349"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.24433768),
        dec: Angle.Degrees(+42.99594351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91331"},
        {"Hipparcos Number", "HIP 51679"},
        {"Smithsonian Astrophysical Observation", "SAO 43380"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.36704557),
        dec: Angle.Degrees(+42.99729854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193610"},
        {"Hipparcos Number", "HIP 100197"},
        {"Geneva Identification System", "GEN# +1.00193610"},
        {"Smithsonian Astrophysical Observation", "SAO 49468"},
        {"Wilson Evans Batten Catalogue", "WEB 18052"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.85232606),
        dec: Angle.Degrees(+42.99875762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86727"},
        {"Hipparcos Number", "HIP 49119"},
        {"Smithsonian Astrophysical Observation", "SAO 43145"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.37998442),
        dec: Angle.Degrees(+42.99913104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3022",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3022"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.62100473),
        dec: Angle.Degrees(+43.00013144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 188.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68195"},
        {"Hipparcos Number", "HIP 40241"},
        {"Geneva Identification System", "GEN# +1.00068195"},
        {"Smithsonian Astrophysical Observation", "SAO 42230"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.28771839),
        dec: Angle.Degrees(+43.00059930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68723"},
        {"Hipparcos Number", "HIP 40447"},
        {"Smithsonian Astrophysical Observation", "SAO 42248"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.87814537),
        dec: Angle.Degrees(+43.00458106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113545"},
        {"Hipparcos Number", "HIP 63748"},
        {"Geneva Identification System", "GEN# +1.00113545"},
        {"Smithsonian Astrophysical Observation", "SAO 44446"},
        {"Wilson Evans Batten Catalogue", "WEB 11276"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.97253050),
        dec: Angle.Degrees(+43.00760782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128092"},
        {"Hipparcos Number", "HIP 71206"},
        {"Smithsonian Astrophysical Observation", "SAO 45113"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.43606491),
        dec: Angle.Degrees(+43.00770583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64912"},
        {"Hipparcos Number", "HIP 38934"},
        {"Smithsonian Astrophysical Observation", "SAO 42094"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.49928354),
        dec: Angle.Degrees(+43.01131765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5211",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5211"},
        {"Smithsonian Astrophysical Observation", "SAO 36930"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.66023765),
        dec: Angle.Degrees(+43.01139582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65525",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65525"},
        {"Geneva Identification System", "GEN# +0.04302330"},
        {"Smithsonian Astrophysical Observation", "SAO 44606"},
    },
    visualMagnitude: 9.89,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.46836194),
        dec: Angle.Degrees(+43.01217677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81385"},
        {"Hipparcos Number", "HIP 46317"},
        {"Smithsonian Astrophysical Observation", "SAO 42860"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.66850132),
        dec: Angle.Degrees(+43.01269647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113354",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16401 A"},
        {"Henry Draper", "HD 217073"},
        {"Hipparcos Number", "HIP 113354"},
        {"Smithsonian Astrophysical Observation", "SAO 52529"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.35702614),
        dec: Angle.Degrees(+43.01280319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176669"},
        {"Hipparcos Number", "HIP 93231"},
        {"Celescope Catalog", "CEL 4683"},
        {"Geneva Identification System", "GEN# +1.00176669"},
        {"Smithsonian Astrophysical Observation", "SAO 47980"},
        {"Wilson Evans Batten Catalogue", "WEB 16164"},
    },
    visualMagnitude: 7.54,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.85944744),
        dec: Angle.Degrees(+43.01321046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111942",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111942"},
        {"Geneva Identification System", "GEN# +0.04204471"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.12591100),
        dec: Angle.Degrees(+43.01349644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29870",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29870"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.34022779),
        dec: Angle.Degrees(+43.01382072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116958",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116958"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.62849141),
        dec: Angle.Degrees(+43.01447218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108711"},
        {"Hipparcos Number", "HIP 60925"},
        {"Geneva Identification System", "GEN# +1.00108711"},
        {"Smithsonian Astrophysical Observation", "SAO 44199"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.29059857),
        dec: Angle.Degrees(+43.01504028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148895"},
        {"Hipparcos Number", "HIP 80761"},
        {"Geneva Identification System", "GEN# +1.00148895"},
        {"Smithsonian Astrophysical Observation", "SAO 46117"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.34715692),
        dec: Angle.Degrees(+43.01567672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62966"},
        {"Hipparcos Number", "HIP 38088"},
        {"Smithsonian Astrophysical Observation", "SAO 42008"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.08313991),
        dec: Angle.Degrees(+43.01820102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69447",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69447"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.28217794),
        dec: Angle.Degrees(+43.01844736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80440"},
        {"Hipparcos Number", "HIP 45871"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.30123117),
        dec: Angle.Degrees(+43.01869734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87695"},
        {"Hipparcos Number", "HIP 49630"},
        {"Fundamental Katalog 5th Edition", "FK5 4903"},
        {"Smithsonian Astrophysical Observation", "SAO 43203"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.93442040),
        dec: Angle.Degrees(+43.01925335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81938"},
        {"Hipparcos Number", "HIP 46597"},
        {"Smithsonian Astrophysical Observation", "SAO 42895"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.53570072),
        dec: Angle.Degrees(+43.01987908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169471"},
        {"Hipparcos Number", "HIP 90059"},
        {"Smithsonian Astrophysical Observation", "SAO 47437"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.67875775),
        dec: Angle.Degrees(+43.02019762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29156"},
        {"Hipparcos Number", "HIP 21538"},
        {"Geneva Identification System", "GEN# +1.00029156"},
        {"Smithsonian Astrophysical Observation", "SAO 39649"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.36259558),
        dec: Angle.Degrees(+43.02098290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53254",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53254"},
        {"Smithsonian Astrophysical Observation", "SAO 43507"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.37527917),
        dec: Angle.Degrees(+43.02431100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93271"},
        {"Hipparcos Number", "HIP 52739"},
        {"Smithsonian Astrophysical Observation", "SAO 43471"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.72627068),
        dec: Angle.Degrees(+43.02677206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13040"},
        {"Hipparcos Number", "HIP 9995"},
        {"Smithsonian Astrophysical Observation", "SAO 37798"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.17919888),
        dec: Angle.Degrees(+43.02690670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49055"},
        {"Hipparcos Number", "HIP 32655"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.17931776),
        dec: Angle.Degrees(+43.02995684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210666"},
        {"Hipparcos Number", "HIP 109511"},
        {"Smithsonian Astrophysical Observation", "SAO 51734"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.76555544),
        dec: Angle.Degrees(+43.03073140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36965",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6191 AB"},
        {"Henry Draper", "HD 60335"},
        {"Hipparcos Number", "HIP 36965"},
        {"Smithsonian Astrophysical Observation", "SAO 41877"},
        {"Wilson Evans Batten Catalogue", "WEB 7334"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.98332747),
        dec: Angle.Degrees(+43.03108733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81853"},
        {"Hipparcos Number", "HIP 46544"},
        {"Smithsonian Astrophysical Observation", "SAO 42888"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.38709241),
        dec: Angle.Degrees(+43.03164566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -157.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128387"},
        {"Hipparcos Number", "HIP 71336"},
        {"Smithsonian Astrophysical Observation", "SAO 45123"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.82821885),
        dec: Angle.Degrees(+43.03190811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28693"},
        {"Hipparcos Number", "HIP 21238"},
        {"Geneva Identification System", "GEN# +1.00028693"},
        {"Smithsonian Astrophysical Observation", "SAO 39602"},
        {"Wilson Evans Batten Catalogue", "WEB 4078"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.33995511),
        dec: Angle.Degrees(+43.03206695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40393",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6675 AB"},
        {"Henry Draper", "HD 68562"},
        {"Hipparcos Number", "HIP 40393"},
        {"Geneva Identification System", "GEN# +1.00068562"},
        {"Smithsonian Astrophysical Observation", "SAO 42242"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.70424446),
        dec: Angle.Degrees(+43.03506781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115751"},
        {"Hipparcos Number", "HIP 64931"},
        {"Geneva Identification System", "GEN# +1.00115751"},
        {"Smithsonian Astrophysical Observation", "SAO 44560"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.63041129),
        dec: Angle.Degrees(+43.03631642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95943",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95943"},
        {"Smithsonian Astrophysical Observation", "SAO 48531"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.67158592),
        dec: Angle.Degrees(+43.03773470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25431"},
        {"Hipparcos Number", "HIP 18999"},
        {"Smithsonian Astrophysical Observation", "SAO 39290"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.06022196),
        dec: Angle.Degrees(+43.03837691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144207"},
        {"Hipparcos Number", "HIP 78599"},
        {"Smithsonian Astrophysical Observation", "SAO 45864"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.71356639),
        dec: Angle.Degrees(+43.03973921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61947",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61947"},
    },
    visualMagnitude: 11.91,
    bvColour: 1.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.44561487),
        dec: Angle.Degrees(+43.04118771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -164.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -218.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56291"},
        {"Hipparcos Number", "HIP 35388"},
        {"Smithsonian Astrophysical Observation", "SAO 41686"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.63534175),
        dec: Angle.Degrees(+43.04126630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104425"},
        {"Hipparcos Number", "HIP 58648"},
        {"Geneva Identification System", "GEN# +1.00104425"},
        {"Smithsonian Astrophysical Observation", "SAO 44000"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.38789039),
        dec: Angle.Degrees(+43.04170266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48173"},
        {"Hipparcos Number", "HIP 32267"},
        {"Smithsonian Astrophysical Observation", "SAO 41304"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.05219246),
        dec: Angle.Degrees(+43.04319396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190025"},
        {"Hipparcos Number", "HIP 98558"},
        {"Celescope Catalog", "CEL 4914"},
        {"Geneva Identification System", "GEN# +1.00190025"},
        {"Smithsonian Astrophysical Observation", "SAO 49087"},
        {"Wilson Evans Batten Catalogue", "WEB 17417"},
    },
    visualMagnitude: 7.53,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.30496275),
        dec: Angle.Degrees(+43.04377899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104513"},
        {"Hipparcos Number", "HIP 58684"},
        {"Fundamental Katalog 5th Edition", "FK5 2965"},
        {"Geneva Identification System", "GEN# +1.00104513"},
        {"Renson", "Renson 30250"},
        {"Smithsonian Astrophysical Observation", "SAO 44002"},
        {"Wilson Evans Batten Catalogue", "WEB 10467"},
    },
    visualMagnitude: 5.22,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.52942963),
        dec: Angle.Degrees(+43.04546506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -345.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135517"},
        {"Hipparcos Number", "HIP 74553"},
        {"Fundamental Katalog 5th Edition", "FK5 5354"},
        {"Geneva Identification System", "GEN# +1.00135517"},
        {"Smithsonian Astrophysical Observation", "SAO 45440"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.49699594),
        dec: Angle.Degrees(+43.04797144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68941",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68941"},
    },
    visualMagnitude: 10.24,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.68286057),
        dec: Angle.Degrees(+43.04834670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89221"},
        {"Hipparcos Number", "HIP 50485"},
        {"Geneva Identification System", "GEN# +1.00089221"},
        {"Smithsonian Astrophysical Observation", "SAO 43276"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.63714463),
        dec: Angle.Degrees(+43.04863393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14095",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14095"},
        {"Smithsonian Astrophysical Observation", "SAO 38518"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.44185629),
        dec: Angle.Degrees(+43.04868584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61604",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61604"},
        {"Geneva Identification System", "GEN# +0.04302241"},
    },
    visualMagnitude: 10.09,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.36039971),
        dec: Angle.Degrees(+43.05418388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83920"},
        {"Hipparcos Number", "HIP 47642"},
        {"Geneva Identification System", "GEN# +1.00083920"},
        {"Renson", "Renson 23940"},
        {"Smithsonian Astrophysical Observation", "SAO 42995"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.69957105),
        dec: Angle.Degrees(+43.05428879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59665"},
        {"Hipparcos Number", "HIP 36697"},
        {"Smithsonian Astrophysical Observation", "SAO 41843"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.23546722),
        dec: Angle.Degrees(+43.05452286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145801"},
        {"Hipparcos Number", "HIP 79297"},
        {"Smithsonian Astrophysical Observation", "SAO 45943"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.74709885),
        dec: Angle.Degrees(+43.05494303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172043"},
        {"Hipparcos Number", "HIP 91164"},
        {"Smithsonian Astrophysical Observation", "SAO 47632"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.97797501),
        dec: Angle.Degrees(+43.05561386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216537"},
        {"Hipparcos Number", "HIP 113003"},
        {"Smithsonian Astrophysical Observation", "SAO 52453"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.28062023),
        dec: Angle.Degrees(+43.05596428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195100"},
        {"Hipparcos Number", "HIP 100910"},
        {"Geneva Identification System", "GEN# +1.00195100"},
        {"Smithsonian Astrophysical Observation", "SAO 49652"},
        {"Wilson Evans Batten Catalogue", "WEB 18231"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.89543673),
        dec: Angle.Degrees(+43.05651012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43901",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7094 AB"},
        {"Hipparcos Number", "HIP 43901"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.14450935),
        dec: Angle.Degrees(+43.05917194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37657"},
        {"Hipparcos Number", "HIP 26872"},
        {"Celescope Catalog", "CEL 930"},
        {"Geneva Identification System", "GEN# +1.00037657"},
        {"Smithsonian Astrophysical Observation", "SAO 40544"},
        {"Wilson Evans Batten Catalogue", "WEB 5295"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.58278549),
        dec: Angle.Degrees(+43.05960152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207218"},
        {"Hipparcos Number", "HIP 107488"},
        {"Geneva Identification System", "GEN# +1.00207218"},
        {"Renson", "Renson 57670"},
        {"Smithsonian Astrophysical Observation", "SAO 51277"},
        {"Wilson Evans Batten Catalogue", "WEB 19403"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.56913248),
        dec: Angle.Degrees(+43.06074886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11719"},
        {"Hipparcos Number", "HIP 9011"},
        {"Geneva Identification System", "GEN# +1.00011719"},
        {"Smithsonian Astrophysical Observation", "SAO 37618"},
        {"Wilson Evans Batten Catalogue", "WEB 1894"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.00287722),
        dec: Angle.Degrees(+43.06094037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28704"},
        {"Hipparcos Number", "HIP 21242"},
        {"Fundamental Katalog 5th Edition", "FK5 1124"},
        {"Geneva Identification System", "GEN# +1.00028704"},
        {"Smithsonian Astrophysical Observation", "SAO 39604"},
        {"Wilson Evans Batten Catalogue", "WEB 4079"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.35374601),
        dec: Angle.Degrees(+43.06388024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200042"},
        {"Hipparcos Number", "HIP 103612"},
        {"Celescope Catalog", "CEL 5227"},
        {"Smithsonian Astrophysical Observation", "SAO 50325"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.88795921),
        dec: Angle.Degrees(+43.06430256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72743"},
        {"Hipparcos Number", "HIP 42189"},
        {"Geneva Identification System", "GEN# +1.00072743"},
        {"Smithsonian Astrophysical Observation", "SAO 42441"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.03600831),
        dec: Angle.Degrees(+43.06532866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46276"},
        {"Hipparcos Number", "HIP 31367"},
        {"Geneva Identification System", "GEN# +1.00046276"},
        {"Smithsonian Astrophysical Observation", "SAO 41188"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.66024255),
        dec: Angle.Degrees(+43.06558124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101323",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101323"},
        {"Renson", "Renson 54600"},
        {"Smithsonian Astrophysical Observation", "SAO 49758"},
    },
    visualMagnitude: 9.13,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.05361640),
        dec: Angle.Degrees(+43.06598397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93663"},
        {"Hipparcos Number", "HIP 52931"},
        {"Smithsonian Astrophysical Observation", "SAO 43483"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.37686086),
        dec: Angle.Degrees(+43.06765523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30814",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5081 AB"},
        {"Henry Draper", "HD 45233"},
        {"Hipparcos Number", "HIP 30814"},
        {"Smithsonian Astrophysical Observation", "SAO 41115"},
    },
    visualMagnitude: 9.35,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.11473839),
        dec: Angle.Degrees(+43.06820788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36604",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36604"},
        {"Smithsonian Astrophysical Observation", "SAO 41834"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.91678948),
        dec: Angle.Degrees(+43.06943124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148094"},
        {"Hipparcos Number", "HIP 80330"},
        {"Geneva Identification System", "GEN# +1.00148094"},
        {"Smithsonian Astrophysical Observation", "SAO 46066"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.99417991),
        dec: Angle.Degrees(+43.07413311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186121"},
        {"Hipparcos Number", "HIP 96805"},
        {"Geneva Identification System", "GEN# +1.00186121"},
        {"Smithsonian Astrophysical Observation", "SAO 48714"},
        {"Wilson Evans Batten Catalogue", "WEB 16989"},
    },
    visualMagnitude: 6.17,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.17145181),
        dec: Angle.Degrees(+43.07782614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222174"},
        {"Hipparcos Number", "HIP 116626"},
        {"Smithsonian Astrophysical Observation", "SAO 53213"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.51507171),
        dec: Angle.Degrees(+43.07787632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10860"},
        {"Hipparcos Number", "HIP 8332"},
        {"Smithsonian Astrophysical Observation", "SAO 37507"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.86314397),
        dec: Angle.Degrees(+43.08042942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115670",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115670"},
        {"Smithsonian Astrophysical Observation", "SAO 53016"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.51763947),
        dec: Angle.Degrees(+43.08114554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172784"},
        {"Hipparcos Number", "HIP 91541"},
        {"Geneva Identification System", "GEN# +1.00172784"},
        {"Smithsonian Astrophysical Observation", "SAO 47683"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.02490895),
        dec: Angle.Degrees(+43.08440851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79723"},
        {"Hipparcos Number", "HIP 45555"},
        {"Geneva Identification System", "GEN# +1.00079723"},
        {"Smithsonian Astrophysical Observation", "SAO 42786"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.26790496),
        dec: Angle.Degrees(+43.08521618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104556"},
        {"Hipparcos Number", "HIP 58708"},
        {"Cincinnati Publication", "Ci 20 678"},
        {"Geneva Identification System", "GEN# +1.00104556"},
        {"Smithsonian Astrophysical Observation", "SAO 44005"},
        {"Wilson Evans Batten Catalogue", "WEB 10469"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.62163890),
        dec: Angle.Degrees(+43.08532391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -347.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -511.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28782"},
        {"Hipparcos Number", "HIP 21290"},
        {"Geneva Identification System", "GEN# +1.00028782"},
        {"Smithsonian Astrophysical Observation", "SAO 39612"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.51874293),
        dec: Angle.Degrees(+43.08745924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60522",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8540 AB"},
        {"Henry Draper", "HD 108005"},
        {"Hipparcos Number", "HIP 60522"},
        {"Geneva Identification System", "GEN# +1.00108005J"},
        {"Smithsonian Astrophysical Observation", "SAO 44161"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.10211627),
        dec: Angle.Degrees(+43.08747469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49116",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49116"},
        {"Smithsonian Astrophysical Observation", "SAO 43144"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.839,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.36021220),
        dec: Angle.Degrees(+43.09695289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191977"},
        {"Hipparcos Number", "HIP 99428"},
        {"Celescope Catalog", "CEL 4961"},
        {"Geneva Identification System", "GEN# +1.00191977"},
        {"Smithsonian Astrophysical Observation", "SAO 49279"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.72278508),
        dec: Angle.Degrees(+43.09732862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105288"},
        {"Hipparcos Number", "HIP 59115"},
        {"Fundamental Katalog 5th Edition", "FK5 5073"},
        {"Geneva Identification System", "GEN# +1.00105288"},
        {"Smithsonian Astrophysical Observation", "SAO 44039"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.83637100),
        dec: Angle.Degrees(+43.09775490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57824",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57824"},
        {"Smithsonian Astrophysical Observation", "SAO 43916"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.87387750),
        dec: Angle.Degrees(+43.09924790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115461",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115461"},
        {"Smithsonian Astrophysical Observation", "SAO 52961"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.83336957),
        dec: Angle.Degrees(+43.10156149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52181",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52181"},
        {"Geneva Identification System", "GEN# +6.20001034"},
        {"Wilson Evans Batten Catalogue", "WEB 9509"},
    },
    visualMagnitude: 11.21,
    bvColour: -0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.90303797),
        dec: Angle.Degrees(+43.10263117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158046"},
        {"Hipparcos Number", "HIP 85230"},
        {"Smithsonian Astrophysical Observation", "SAO 46704"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.865,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.23800288),
        dec: Angle.Degrees(+43.10519508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75430"},
        {"Hipparcos Number", "HIP 43501"},
        {"Smithsonian Astrophysical Observation", "SAO 42572"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.90975141),
        dec: Angle.Degrees(+43.10637071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204995"},
        {"Hipparcos Number", "HIP 106235"},
        {"Celescope Catalog", "CEL 5330"},
        {"Geneva Identification System", "GEN# +1.00204995"},
        {"Smithsonian Astrophysical Observation", "SAO 50962"},
    },
    visualMagnitude: 8.68,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.76412727),
        dec: Angle.Degrees(+43.10640770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69311",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69311"},
    },
    visualMagnitude: 10.03,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.80332460),
        dec: Angle.Degrees(+43.10648152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -193.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46156"},
        {"Hipparcos Number", "HIP 31307"},
        {"Smithsonian Astrophysical Observation", "SAO 41181"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.48237411),
        dec: Angle.Degrees(+43.10974609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145513"},
        {"Hipparcos Number", "HIP 79168"},
        {"Geneva Identification System", "GEN# +1.00145513"},
        {"Smithsonian Astrophysical Observation", "SAO 45917"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.37527606),
        dec: Angle.Degrees(+43.11023182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116056"},
        {"Hipparcos Number", "HIP 65091"},
        {"Cincinnati Publication", "Ci 18 1723"},
        {"Cincinnati Publication 2", "Ci 20 774"},
        {"Fundamental Katalog 5th Edition", "FK5 5178"},
        {"Geneva Identification System", "GEN# +1.00116056"},
        {"Smithsonian Astrophysical Observation", "SAO 44572"},
        {"Wilson Evans Batten Catalogue", "WEB 11496"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.11303900),
        dec: Angle.Degrees(+43.11138103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -425.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37805",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37805"},
    },
    visualMagnitude: 12.18,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.27624889),
        dec: Angle.Degrees(+43.11154306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73554"},
        {"Hipparcos Number", "HIP 42567"},
        {"Geneva Identification System", "GEN# +1.00073554"},
        {"Smithsonian Astrophysical Observation", "SAO 42482"},
        {"Wilson Evans Batten Catalogue", "WEB 8212"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.15319831),
        dec: Angle.Degrees(+43.11445696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -168.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -297.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177412"},
        {"Hipparcos Number", "HIP 93511"},
        {"Geneva Identification System", "GEN# +1.00177412"},
        {"Smithsonian Astrophysical Observation", "SAO 48028"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.66405553),
        dec: Angle.Degrees(+43.11746709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108252"},
        {"Hipparcos Number", "HIP 60666"},
        {"Geneva Identification System", "GEN# +1.00108252"},
        {"Smithsonian Astrophysical Observation", "SAO 44175"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.50002934),
        dec: Angle.Degrees(+43.11822876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104770",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104770"},
        {"Geneva Identification System", "GEN# +6.20055379"},
        {"Smithsonian Astrophysical Observation", "SAO 50589"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.36975201),
        dec: Angle.Degrees(+43.11857191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204306"},
        {"Hipparcos Number", "HIP 105857"},
        {"Geneva Identification System", "GEN# +1.00204306"},
        {"Smithsonian Astrophysical Observation", "SAO 50850"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.60723573),
        dec: Angle.Degrees(+43.11949086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111516",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16094 A"},
        {"Henry Draper", "HD 214153"},
        {"Hipparcos Number", "HIP 111516"},
        {"Smithsonian Astrophysical Observation", "SAO 52166"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.90426400),
        dec: Angle.Degrees(+43.12017301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106494"},
        {"Hipparcos Number", "HIP 59715"},
        {"Smithsonian Astrophysical Observation", "SAO 44090"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.71017742),
        dec: Angle.Degrees(+43.12256989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213420"},
        {"Hipparcos Number", "HIP 111104"},
        {"Fundamental Katalog 5th Edition", "FK5 3800"},
        {"Geneva Identification System", "GEN# +1.00213420"},
        {"Smithsonian Astrophysical Observation", "SAO 52079"},
        {"Wilson Evans Batten Catalogue", "WEB 19891"},
    },
    visualMagnitude: 4.52,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.62192333),
        dec: Angle.Degrees(+43.12338985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35138",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35138"},
        {"Smithsonian Astrophysical Observation", "SAO 41650"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.96284183),
        dec: Angle.Degrees(+43.12643703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110835"},
        {"Hipparcos Number", "HIP 62177"},
        {"Geneva Identification System", "GEN# +1.00110835"},
        {"Smithsonian Astrophysical Observation", "SAO 44308"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.14053887),
        dec: Angle.Degrees(+43.12660757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97439",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97439"},
        {"Geneva Identification System", "GEN# +0.04203471"},
        {"Smithsonian Astrophysical Observation", "SAO 48854"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.06444762),
        dec: Angle.Degrees(+43.12694240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193837"},
        {"Hipparcos Number", "HIP 100308"},
        {"Renson", "Renson 54103"},
        {"Smithsonian Astrophysical Observation", "SAO 49496"},
        {"Wilson Evans Batten Catalogue", "WEB 18093"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.16330800),
        dec: Angle.Degrees(+43.12701539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103355",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103355"},
        {"Geneva Identification System", "GEN# +0.04203914"},
        {"Smithsonian Astrophysical Observation", "SAO 50259"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.10036911),
        dec: Angle.Degrees(+43.12958915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129564"},
        {"Hipparcos Number", "HIP 71848"},
        {"Smithsonian Astrophysical Observation", "SAO 45176"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.44925247),
        dec: Angle.Degrees(+43.13023440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219904"},
        {"Hipparcos Number", "HIP 115124"},
        {"Smithsonian Astrophysical Observation", "SAO 52896"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.77551183),
        dec: Angle.Degrees(+43.13216476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80411",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80411"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.19342477),
        dec: Angle.Degrees(+43.13230347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107899",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107899"},
        {"Geneva Identification System", "GEN# +0.04204233"},
        {"Wilson Evans Batten Catalogue", "WEB 19458"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.92268247),
        dec: Angle.Degrees(+43.13404938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62498",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62498"},
        {"Geneva Identification System", "GEN# +0.04302260"},
        {"Smithsonian Astrophysical Observation", "SAO 44331"},
        {"Wilson Evans Batten Catalogue", "WEB 11094"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.10662765),
        dec: Angle.Degrees(+43.13434302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110756",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110756"},
        {"Smithsonian Astrophysical Observation", "SAO 51992"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.57329439),
        dec: Angle.Degrees(+43.13458130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17016",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2651 AB"},
        {"Henry Draper", "HD 22509"},
        {"Hipparcos Number", "HIP 17016"},
        {"Smithsonian Astrophysical Observation", "SAO 39013"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.72606878),
        dec: Angle.Degrees(+43.13662088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2396",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2396"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.62356291),
        dec: Angle.Degrees(+43.13669629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142780"},
        {"Hipparcos Number", "HIP 77907"},
        {"Geneva Identification System", "GEN# +1.00142780"},
        {"Smithsonian Astrophysical Observation", "SAO 45788"},
        {"Wilson Evans Batten Catalogue", "WEB 13173"},
    },
    visualMagnitude: 5.35,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.65782130),
        dec: Angle.Degrees(+43.13840642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104526"},
        {"Hipparcos Number", "HIP 58698"},
        {"Geneva Identification System", "GEN# +1.00104526"},
        {"Smithsonian Astrophysical Observation", "SAO 44003"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.58680271),
        dec: Angle.Degrees(+43.14059334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41847"},
        {"Hipparcos Number", "HIP 29218"},
        {"Smithsonian Astrophysical Observation", "SAO 40898"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.41519036),
        dec: Angle.Degrees(+43.14076203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54193",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54193"},
        {"Smithsonian Astrophysical Observation", "SAO 43606"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.30961162),
        dec: Angle.Degrees(+43.14168615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8441"},
        {"Hipparcos Number", "HIP 6560"},
        {"Geneva Identification System", "GEN# +1.00008441"},
        {"Renson", "Renson 2050"},
        {"Smithsonian Astrophysical Observation", "SAO 37177"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.07781821),
        dec: Angle.Degrees(+43.14211894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105467",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14907 AB"},
        {"Henry Draper", "HD 203578"},
        {"Hipparcos Number", "HIP 105467"},
        {"Smithsonian Astrophysical Observation", "SAO 50758"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.44085132),
        dec: Angle.Degrees(+43.14398211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83371"},
        {"Hipparcos Number", "HIP 47380"},
        {"Fundamental Katalog 5th Edition", "FK5 2770"},
        {"Geneva Identification System", "GEN# +1.00083371"},
        {"Smithsonian Astrophysical Observation", "SAO 42962"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.79490453),
        dec: Angle.Degrees(+43.14432451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7509"},
        {"Hipparcos Number", "HIP 5902"},
        {"Smithsonian Astrophysical Observation", "SAO 37061"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.95308890),
        dec: Angle.Degrees(+43.14541843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195033"},
        {"Hipparcos Number", "HIP 100877"},
        {"Celescope Catalog", "CEL 5068"},
        {"Geneva Identification System", "GEN# +1.00195033"},
        {"Smithsonian Astrophysical Observation", "SAO 49644"},
    },
    visualMagnitude: 7.66,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.80948712),
        dec: Angle.Degrees(+43.14745274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74986"},
        {"Hipparcos Number", "HIP 43268"},
        {"Smithsonian Astrophysical Observation", "SAO 42556"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.22317584),
        dec: Angle.Degrees(+43.14778863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99135"},
        {"Hipparcos Number", "HIP 55701"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.20123385),
        dec: Angle.Degrees(+43.14895444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23106"},
        {"Hipparcos Number", "HIP 17443"},
        {"Smithsonian Astrophysical Observation", "SAO 39068"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.05698008),
        dec: Angle.Degrees(+43.14896876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208861"},
        {"Hipparcos Number", "HIP 108440"},
        {"Geneva Identification System", "GEN# +1.00208861"},
        {"Smithsonian Astrophysical Observation", "SAO 51489"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.50810681),
        dec: Angle.Degrees(+43.14967048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111153"},
        {"Hipparcos Number", "HIP 62363"},
        {"Fundamental Katalog 5th Edition", "FK5 5131"},
        {"Geneva Identification System", "GEN# +1.00111153"},
        {"Smithsonian Astrophysical Observation", "SAO 44326"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.70182975),
        dec: Angle.Degrees(+43.15195179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5834",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5834"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.70747749),
        dec: Angle.Degrees(+43.15225084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 211.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -191.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1833",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1833"},
        {"Smithsonian Astrophysical Observation", "SAO 36313"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.80832903),
        dec: Angle.Degrees(+43.15253133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46028"},
        {"Hipparcos Number", "HIP 31240"},
        {"Geneva Identification System", "GEN# +1.00046028"},
        {"Smithsonian Astrophysical Observation", "SAO 41172"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.29186951),
        dec: Angle.Degrees(+43.15507466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31207"},
        {"Hipparcos Number", "HIP 22915"},
        {"Geneva Identification System", "GEN# +1.00031207"},
        {"Smithsonian Astrophysical Observation", "SAO 39873"},
        {"Wilson Evans Batten Catalogue", "WEB 4450"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.96853121),
        dec: Angle.Degrees(+43.15568794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12965"},
        {"Hipparcos Number", "HIP 9937"},
        {"Smithsonian Astrophysical Observation", "SAO 37789"},
    },
    visualMagnitude: 8.36,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.98704434),
        dec: Angle.Degrees(+43.15898490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86697",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86697"},
    },
    visualMagnitude: 11.00,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.71178982),
        dec: Angle.Degrees(+43.16402862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105033"},
        {"Hipparcos Number", "HIP 58977"},
        {"Geneva Identification System", "GEN# +1.00105033"},
        {"Smithsonian Astrophysical Observation", "SAO 44023"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.38878935),
        dec: Angle.Degrees(+43.16488470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29373",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4774 A"},
        {"Henry Draper", "HD 42196"},
        {"Hipparcos Number", "HIP 29373"},
        {"Geneva Identification System", "GEN# +1.00042196"},
        {"Smithsonian Astrophysical Observation", "SAO 40928"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.87401395),
        dec: Angle.Degrees(+43.16509065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184024"},
        {"Hipparcos Number", "HIP 95922"},
        {"Smithsonian Astrophysical Observation", "SAO 48525"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.62399092),
        dec: Angle.Degrees(+43.16686770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79359",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79359"},
        {"Smithsonian Astrophysical Observation", "SAO 45959"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.95053330),
        dec: Angle.Degrees(+43.16711181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139193"},
        {"Hipparcos Number", "HIP 76299"},
        {"Geneva Identification System", "GEN# +1.00139193"},
        {"Smithsonian Astrophysical Observation", "SAO 45623"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.79185835),
        dec: Angle.Degrees(+43.16743775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53756",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53756"},
    },
    visualMagnitude: 10.64,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.97421171),
        dec: Angle.Degrees(+43.16791577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161320"},
        {"Hipparcos Number", "HIP 86692"},
        {"Geneva Identification System", "GEN# +1.00161320"},
        {"Smithsonian Astrophysical Observation", "SAO 46905"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.70273129),
        dec: Angle.Degrees(+43.16899181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102426"},
        {"Hipparcos Number", "HIP 57537"},
        {"Geneva Identification System", "GEN# +1.00102426"},
        {"Smithsonian Astrophysical Observation", "SAO 43892"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.88739158),
        dec: Angle.Degrees(+43.16933925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6586",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1120 AB"},
        {"Hipparcos Number", "HIP 6586"},
    },
    visualMagnitude: 10.13,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.16564493),
        dec: Angle.Degrees(+43.16942369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 87.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111677",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111677"},
        {"Smithsonian Astrophysical Observation", "SAO 52194"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.35272885),
        dec: Angle.Degrees(+43.17194865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208455"},
        {"Hipparcos Number", "HIP 108202"},
        {"Geneva Identification System", "GEN# +1.00208455"},
        {"Smithsonian Astrophysical Observation", "SAO 51439"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.82355452),
        dec: Angle.Degrees(+43.17220645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99984"},
        {"Hipparcos Number", "HIP 56148"},
        {"Fundamental Katalog 5th Edition", "FK5 432"},
        {"Geneva Identification System", "GEN# +1.00099984"},
        {"Smithsonian Astrophysical Observation", "SAO 43787"},
        {"Wilson Evans Batten Catalogue", "WEB 10080"},
    },
    visualMagnitude: 5.94,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.62987804),
        dec: Angle.Degrees(+43.17304329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 81.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62419"},
        {"Hipparcos Number", "HIP 37870"},
        {"Smithsonian Astrophysical Observation", "SAO 41986"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.44068818),
        dec: Angle.Degrees(+43.17376300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3396"},
        {"Hipparcos Number", "HIP 2934"},
        {"Smithsonian Astrophysical Observation", "SAO 36514"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.30842901),
        dec: Angle.Degrees(+43.17409505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32655"},
        {"Hipparcos Number", "HIP 23799"},
        {"Geneva Identification System", "GEN# +1.00032655"},
        {"Smithsonian Astrophysical Observation", "SAO 40029"},
        {"Wilson Evans Batten Catalogue", "WEB 4642"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.70649417),
        dec: Angle.Degrees(+43.17470862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102232",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14202 AB"},
        {"Henry Draper", "HD 197559"},
        {"Hipparcos Number", "HIP 102232"},
        {"Celescope Catalog", "CEL 5149"},
        {"Geneva Identification System", "GEN# +1.00197559J"},
        {"Smithsonian Astrophysical Observation", "SAO 49970"},
    },
    visualMagnitude: 8.46,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.72601603),
        dec: Angle.Degrees(+43.17741297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19010"},
        {"Hipparcos Number", "HIP 14347"},
        {"Smithsonian Astrophysical Observation", "SAO 38556"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.25471197),
        dec: Angle.Degrees(+43.17869347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15419"},
        {"Hipparcos Number", "HIP 11642"},
        {"Geneva Identification System", "GEN# +1.00015419"},
        {"Smithsonian Astrophysical Observation", "SAO 38071"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.54818832),
        dec: Angle.Degrees(+43.17884825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25907"},
        {"Hipparcos Number", "HIP 19287"},
        {"Smithsonian Astrophysical Observation", "SAO 39327"},
        {"Wilson Evans Batten Catalogue", "WEB 3706"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.00741569),
        dec: Angle.Degrees(+43.17947845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41923",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41923"},
    },
    visualMagnitude: 11.21,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.21202214),
        dec: Angle.Degrees(+43.17993420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220032"},
        {"Hipparcos Number", "HIP 115217"},
        {"Smithsonian Astrophysical Observation", "SAO 52920"},
    },
    visualMagnitude: 8.37,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.05917005),
        dec: Angle.Degrees(+43.18003459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114159"},
        {"Hipparcos Number", "HIP 64106"},
        {"Geneva Identification System", "GEN# +1.00114159"},
        {"Smithsonian Astrophysical Observation", "SAO 44482"},
        {"Wilson Evans Batten Catalogue", "WEB 11332"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.06310040),
        dec: Angle.Degrees(+43.18132168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53878",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53878"},
        {"Smithsonian Astrophysical Observation", "SAO 43575"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.34157365),
        dec: Angle.Degrees(+43.18324560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14145",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14145"},
        {"Smithsonian Astrophysical Observation", "SAO 38526"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.59827369),
        dec: Angle.Degrees(+43.18388015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102167",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102167"},
        {"Geneva Identification System", "GEN# +0.04203835"},
        {"Smithsonian Astrophysical Observation", "SAO 49955"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.52860104),
        dec: Angle.Degrees(+43.18437999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89693",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89693"},
        {"Smithsonian Astrophysical Observation", "SAO 47370"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.57388052),
        dec: Angle.Degrees(+43.18571068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210496"},
        {"Hipparcos Number", "HIP 109397"},
        {"Smithsonian Astrophysical Observation", "SAO 51711"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.44032083),
        dec: Angle.Degrees(+43.18654767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73643",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73643"},
        {"Smithsonian Astrophysical Observation", "SAO 45349"},
    },
    visualMagnitude: 9.82,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.79237244),
        dec: Angle.Degrees(+43.18749287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41075",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alsciaukat"},
        {"Henry Draper", "HD 70272"},
        {"Hipparcos Number", "HIP 41075"},
        {"Fundamental Katalog 5th Edition", "FK5 314"},
        {"Geneva Identification System", "GEN# +1.00070272"},
        {"Smithsonian Astrophysical Observation", "SAO 42319"},
        {"Wilson Evans Batten Catalogue", "WEB 7956"},
    },
    visualMagnitude: 4.25,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.70887544),
        dec: Angle.Degrees(+43.18837233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94334"},
        {"Hipparcos Number", "HIP 53295"},
        {"Celescope Catalog", "CEL 3753"},
        {"Fundamental Katalog 5th Edition", "FK5 2870"},
        {"Geneva Identification System", "GEN# +1.00094334"},
        {"Renson", "Renson 27230"},
        {"Smithsonian Astrophysical Observation", "SAO 43512"},
        {"Wilson Evans Batten Catalogue", "WEB 9678"},
    },
    visualMagnitude: 4.66,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.49460834),
        dec: Angle.Degrees(+43.19001538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20824",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3225 A"},
        {"Henry Draper", "HD 28065"},
        {"Hipparcos Number", "HIP 20824"},
        {"Smithsonian Astrophysical Observation", "SAO 39545"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.93024999),
        dec: Angle.Degrees(+43.19081162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13014"},
        {"Hipparcos Number", "HIP 9974"},
        {"Geneva Identification System", "GEN# +1.00013014"},
        {"Smithsonian Astrophysical Observation", "SAO 37791"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.10833464),
        dec: Angle.Degrees(+43.19114222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25932"},
        {"Hipparcos Number", "HIP 19298"},
        {"Fundamental Katalog 5th Edition", "FK5 2296"},
        {"Geneva Identification System", "GEN# +1.00025932"},
        {"Smithsonian Astrophysical Observation", "SAO 39331"},
    },
    visualMagnitude: 6.57,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.05459953),
        dec: Angle.Degrees(+43.19118440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195986"},
        {"Hipparcos Number", "HIP 101383"},
        {"Celescope Catalog", "CEL 5108"},
        {"Fundamental Katalog 5th Edition", "FK5 3644"},
        {"Geneva Identification System", "GEN# +1.00195986"},
        {"Smithsonian Astrophysical Observation", "SAO 49772"},
        {"Wilson Evans Batten Catalogue", "WEB 18319"},
    },
    visualMagnitude: 6.61,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.21802364),
        dec: Angle.Degrees(+43.19157525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105068",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14824 AB"},
        {"Henry Draper", "HD 202810"},
        {"Hipparcos Number", "HIP 105068"},
        {"Smithsonian Astrophysical Observation", "SAO 50664"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.26714185),
        dec: Angle.Degrees(+43.19358008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174505"},
        {"Hipparcos Number", "HIP 92305"},
        {"Geneva Identification System", "GEN# +1.00174505"},
        {"Smithsonian Astrophysical Observation", "SAO 47826"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.19797955),
        dec: Angle.Degrees(+43.19524931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109156"},
        {"Hipparcos Number", "HIP 61190"},
        {"Geneva Identification System", "GEN# +1.00109156"},
        {"Smithsonian Astrophysical Observation", "SAO 44220"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.07273069),
        dec: Angle.Degrees(+43.19956266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106923",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106923"},
    },
    visualMagnitude: 11.67,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.82117705),
        dec: Angle.Degrees(+43.20038175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 133.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221784"},
        {"Hipparcos Number", "HIP 116369"},
        {"Smithsonian Astrophysical Observation", "SAO 53162"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.70911054),
        dec: Angle.Degrees(+43.20156046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185581"},
        {"Hipparcos Number", "HIP 96573"},
        {"Smithsonian Astrophysical Observation", "SAO 48667"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.48589421),
        dec: Angle.Degrees(+43.20209620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180757"},
        {"Hipparcos Number", "HIP 94670"},
        {"Smithsonian Astrophysical Observation", "SAO 48254"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.96341627),
        dec: Angle.Degrees(+43.20234086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221516"},
        {"Hipparcos Number", "HIP 116190"},
        {"Smithsonian Astrophysical Observation", "SAO 53130"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.12948087),
        dec: Angle.Degrees(+43.20657519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96834"},
        {"Hipparcos Number", "HIP 54537"},
        {"Geneva Identification System", "GEN# +1.00096834"},
        {"Smithsonian Astrophysical Observation", "SAO 43627"},
        {"Wilson Evans Batten Catalogue", "WEB 9843"},
    },
    visualMagnitude: 5.89,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.41064299),
        dec: Angle.Degrees(+43.20775162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126139"},
        {"Hipparcos Number", "HIP 70254"},
        {"Smithsonian Astrophysical Observation", "SAO 45019"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.62508049),
        dec: Angle.Degrees(+43.21010717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102102"},
        {"Hipparcos Number", "HIP 57326"},
        {"Geneva Identification System", "GEN# +1.00102102"},
        {"Renson", "Renson 29440"},
        {"Smithsonian Astrophysical Observation", "SAO 43881"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.31812590),
        dec: Angle.Degrees(+43.21035296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7979"},
        {"Hipparcos Number", "HIP 6230"},
        {"Smithsonian Astrophysical Observation", "SAO 37120"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.97082545),
        dec: Angle.Degrees(+43.21052702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8378",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8378"},
        {"Smithsonian Astrophysical Observation", "SAO 37517"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.99255763),
        dec: Angle.Degrees(+43.21137224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56820",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56820"},
    },
    visualMagnitude: 10.13,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.71329038),
        dec: Angle.Degrees(+43.21366480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143418"},
        {"Hipparcos Number", "HIP 78226"},
        {"Geneva Identification System", "GEN# +1.00143418"},
        {"Renson", "Renson 40607"},
        {"Smithsonian Astrophysical Observation", "SAO 45811"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.60703654),
        dec: Angle.Degrees(+43.21373072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81774"},
        {"Hipparcos Number", "HIP 46503"},
        {"Geneva Identification System", "GEN# +1.00081774"},
        {"Smithsonian Astrophysical Observation", "SAO 42882"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.25866829),
        dec: Angle.Degrees(+43.21484341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99163"},
        {"Hipparcos Number", "HIP 55729"},
        {"Geneva Identification System", "GEN# +1.00099163"},
        {"Smithsonian Astrophysical Observation", "SAO 43733"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.27693557),
        dec: Angle.Degrees(+43.21596142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151388"},
        {"Hipparcos Number", "HIP 82012"},
        {"Geneva Identification System", "GEN# +1.00151388"},
        {"Smithsonian Astrophysical Observation", "SAO 46262"},
        {"Wilson Evans Batten Catalogue", "WEB 13848"},
    },
    visualMagnitude: 6.07,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.29917503),
        dec: Angle.Degrees(+43.21729222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50131",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50131"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.50752172),
        dec: Angle.Degrees(+43.21744946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208787"},
        {"Hipparcos Number", "HIP 108400"},
        {"Geneva Identification System", "GEN# +1.00208787"},
        {"Smithsonian Astrophysical Observation", "SAO 51484"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.41224864),
        dec: Angle.Degrees(+43.21781068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79158"},
        {"Hipparcos Number", "HIP 45290"},
        {"Fundamental Katalog 5th Edition", "FK5 346"},
        {"Geneva Identification System", "GEN# +1.00079158"},
        {"Renson", "Renson 22480"},
        {"Smithsonian Astrophysical Observation", "SAO 42759"},
        {"Wilson Evans Batten Catalogue", "WEB 8627"},
    },
    visualMagnitude: 5.30,
    bvColour: -0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.45095799),
        dec: Angle.Degrees(+43.21791261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60285",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60285"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.43511663),
        dec: Angle.Degrees(+43.21987142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172187"},
        {"Hipparcos Number", "HIP 91250"},
        {"Fundamental Katalog 5th Edition", "FK5 3481"},
        {"Geneva Identification System", "GEN# +1.00172187"},
        {"Smithsonian Astrophysical Observation", "SAO 47644"},
        {"Wilson Evans Batten Catalogue", "WEB 15679"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.18971607),
        dec: Angle.Degrees(+43.22184097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87384",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87384"},
    },
    visualMagnitude: 10.77,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.83499340),
        dec: Angle.Degrees(+43.22254837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 189.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57699"},
        {"Hipparcos Number", "HIP 35927"},
        {"Smithsonian Astrophysical Observation", "SAO 41741"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.09245253),
        dec: Angle.Degrees(+43.22402790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17918",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17918"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.47230142),
        dec: Angle.Degrees(+43.22579464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190065"},
        {"Hipparcos Number", "HIP 98572"},
        {"Geneva Identification System", "GEN# +1.00190065"},
        {"Smithsonian Astrophysical Observation", "SAO 49092"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.34103726),
        dec: Angle.Degrees(+43.22758457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47834",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7503 AB"},
        {"Henry Draper", "HD 84237"},
        {"Hipparcos Number", "HIP 47834"},
        {"Smithsonian Astrophysical Observation", "SAO 43015"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.25311091),
        dec: Angle.Degrees(+43.22895685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68658",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68658"},
        {"Smithsonian Astrophysical Observation", "SAO 44864"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.81292773),
        dec: Angle.Degrees(+43.22929813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50947"},
        {"Hipparcos Number", "HIP 33472"},
        {"Smithsonian Astrophysical Observation", "SAO 41461"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.36607000),
        dec: Angle.Degrees(+43.22933342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44495"},
        {"Hipparcos Number", "HIP 30466"},
        {"Geneva Identification System", "GEN# +1.00044495"},
        {"Smithsonian Astrophysical Observation", "SAO 41070"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.07243681),
        dec: Angle.Degrees(+43.23044272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21490"},
        {"Hipparcos Number", "HIP 16258"},
        {"Smithsonian Astrophysical Observation", "SAO 38876"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.38389217),
        dec: Angle.Degrees(+43.23077897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204402"},
        {"Hipparcos Number", "HIP 105909"},
        {"Geneva Identification System", "GEN# +1.00204402"},
        {"Smithsonian Astrophysical Observation", "SAO 50868"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.75368678),
        dec: Angle.Degrees(+43.23085028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104635"},
        {"Hipparcos Number", "HIP 58750"},
        {"Geneva Identification System", "GEN# +1.00104635"},
        {"Smithsonian Astrophysical Observation", "SAO 44009"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.74497050),
        dec: Angle.Degrees(+43.23106737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35304"},
        {"Hipparcos Number", "HIP 25386"},
        {"Geneva Identification System", "GEN# +1.00035304"},
        {"Smithsonian Astrophysical Observation", "SAO 40327"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.46519387),
        dec: Angle.Degrees(+43.23232128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8099"},
        {"Hipparcos Number", "HIP 6314"},
        {"Smithsonian Astrophysical Observation", "SAO 37139"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.27645581),
        dec: Angle.Degrees(+43.23384801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75422",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75422"},
        {"Smithsonian Astrophysical Observation", "SAO 45523"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.13891522),
        dec: Angle.Degrees(+43.23435966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164575"},
        {"Hipparcos Number", "HIP 88103"},
        {"Smithsonian Astrophysical Observation", "SAO 47113"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.90368289),
        dec: Angle.Degrees(+43.23519329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16375"},
        {"Hipparcos Number", "HIP 12339"},
        {"Smithsonian Astrophysical Observation", "SAO 38193"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.72586610),
        dec: Angle.Degrees(+43.23584335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44281"},
        {"Hipparcos Number", "HIP 30368"},
        {"Smithsonian Astrophysical Observation", "SAO 41056"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.79679094),
        dec: Angle.Degrees(+43.23629188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222729"},
        {"Hipparcos Number", "HIP 116987"},
        {"Geneva Identification System", "GEN# +1.00222729"},
        {"Smithsonian Astrophysical Observation", "SAO 53308"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.74993902),
        dec: Angle.Degrees(+43.23681232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94898",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94898"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.67270345),
        dec: Angle.Degrees(+43.23681489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -196.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216284"},
        {"Hipparcos Number", "HIP 112838"},
        {"Smithsonian Astrophysical Observation", "SAO 52424"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.77557642),
        dec: Angle.Degrees(+43.23805603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27293"},
        {"Hipparcos Number", "HIP 20259"},
        {"Geneva Identification System", "GEN# +1.00027293"},
        {"Smithsonian Astrophysical Observation", "SAO 39472"},
        {"Wilson Evans Batten Catalogue", "WEB 3870"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.13246187),
        dec: Angle.Degrees(+43.23816534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208878"},
        {"Hipparcos Number", "HIP 108450"},
        {"Celescope Catalog", "CEL 5413"},
        {"Geneva Identification System", "GEN# +1.00208878"},
        {"Smithsonian Astrophysical Observation", "SAO 51496"},
        {"Wilson Evans Batten Catalogue", "WEB 19528"},
    },
    visualMagnitude: 7.43,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.54644852),
        dec: Angle.Degrees(+43.23880404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36641"},
        {"Hipparcos Number", "HIP 26230"},
        {"Geneva Identification System", "GEN# +1.00036641"},
        {"Smithsonian Astrophysical Observation", "SAO 40453"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.83205556),
        dec: Angle.Degrees(+43.23936969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10583"},
        {"Hipparcos Number", "HIP 8103"},
        {"Smithsonian Astrophysical Observation", "SAO 37468"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.02339106),
        dec: Angle.Degrees(+43.24022916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66672",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66672"},
        {"Geneva Identification System", "GEN# +0.04302344"},
    },
    visualMagnitude: 10.94,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.01074266),
        dec: Angle.Degrees(+43.24247997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18312",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18312"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.72979059),
        dec: Angle.Degrees(+43.24592552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218197"},
        {"Hipparcos Number", "HIP 114029"},
        {"Smithsonian Astrophysical Observation", "SAO 52668"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.38223157),
        dec: Angle.Degrees(+43.24617636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66110",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66110"},
        {"Geneva Identification System", "GEN# +0.04402279"},
        {"Wilson Evans Batten Catalogue", "WEB 11683"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.28413151),
        dec: Angle.Degrees(+43.25290099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176798"},
        {"Hipparcos Number", "HIP 93266"},
        {"Geneva Identification System", "GEN# +1.00176798"},
        {"Smithsonian Astrophysical Observation", "SAO 47986"},
        {"Wilson Evans Batten Catalogue", "WEB 16172"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.98860239),
        dec: Angle.Degrees(+43.25362240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139441"},
        {"Hipparcos Number", "HIP 76432"},
        {"Smithsonian Astrophysical Observation", "SAO 45639"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.15164079),
        dec: Angle.Degrees(+43.25612352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58295"},
        {"Hipparcos Number", "HIP 36163"},
        {"Geneva Identification System", "GEN# +1.00058295"},
        {"Smithsonian Astrophysical Observation", "SAO 41772"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.74387401),
        dec: Angle.Degrees(+43.25844467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54687"},
        {"Hipparcos Number", "HIP 34770"},
        {"Smithsonian Astrophysical Observation", "SAO 41613"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.96604297),
        dec: Angle.Degrees(+43.25915088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66824"},
        {"Hipparcos Number", "HIP 39722"},
        {"Fundamental Katalog 5th Edition", "FK5 2627"},
        {"Geneva Identification System", "GEN# +1.00066824"},
        {"Smithsonian Astrophysical Observation", "SAO 42174"},
        {"Wilson Evans Batten Catalogue", "WEB 7752"},
    },
    visualMagnitude: 6.35,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.79147297),
        dec: Angle.Degrees(+43.26044834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95638",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95638"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.80880716),
        dec: Angle.Degrees(+43.26069978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 179.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7348",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7348"},
        {"Smithsonian Astrophysical Observation", "SAO 37327"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.67351607),
        dec: Angle.Degrees(+43.26156328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62873",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62873"},
        {"Geneva Identification System", "GEN# +0.04402232"},
        {"Smithsonian Astrophysical Observation", "SAO 44372"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.29125089),
        dec: Angle.Degrees(+43.26287236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99287",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99287"},
        {"Smithsonian Astrophysical Observation", "SAO 49248"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.32441618),
        dec: Angle.Degrees(+43.26354158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91060"},
        {"Hipparcos Number", "HIP 51536"},
        {"Geneva Identification System", "GEN# +1.00091060"},
        {"Smithsonian Astrophysical Observation", "SAO 43370"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.89504308),
        dec: Angle.Degrees(+43.26470225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64773",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64773"},
        {"Geneva Identification System", "GEN# +0.04402262"},
        {"Smithsonian Astrophysical Observation", "SAO 44538"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.11937926),
        dec: Angle.Degrees(+43.26476831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76970",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76970"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.75104672),
        dec: Angle.Degrees(+43.26531778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222173"},
        {"Hipparcos Number", "HIP 116631"},
        {"Fundamental Katalog 5th Edition", "FK5 891"},
        {"Geneva Identification System", "GEN# +1.00222173"},
        {"Smithsonian Astrophysical Observation", "SAO 53216"},
        {"Wilson Evans Batten Catalogue", "WEB 20588"},
    },
    visualMagnitude: 4.29,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.53407969),
        dec: Angle.Degrees(+43.26807610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165144"},
        {"Hipparcos Number", "HIP 88347"},
        {"Smithsonian Astrophysical Observation", "SAO 47162"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.62653051),
        dec: Angle.Degrees(+43.26855183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198264"},
        {"Hipparcos Number", "HIP 102622"},
        {"Smithsonian Astrophysical Observation", "SAO 50067"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.93052313),
        dec: Angle.Degrees(+43.27008828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69027"},
        {"Hipparcos Number", "HIP 40562"},
        {"Smithsonian Astrophysical Observation", "SAO 42265"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.22840383),
        dec: Angle.Degrees(+43.27066337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6338"},
        {"Hipparcos Number", "HIP 5078"},
        {"Geneva Identification System", "GEN# +1.00006338"},
        {"Smithsonian Astrophysical Observation", "SAO 36906"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.25525611),
        dec: Angle.Degrees(+43.27356263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106999",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15208 AB"},
        {"Henry Draper", "HD 206330"},
        {"Hipparcos Number", "HIP 106999"},
        {"Fundamental Katalog 5th Edition", "FK5 3730"},
        {"Geneva Identification System", "GEN# +1.00206330"},
        {"Smithsonian Astrophysical Observation", "SAO 51167"},
        {"Wilson Evans Batten Catalogue", "WEB 19333"},
    },
    visualMagnitude: 5.09,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.04608744),
        dec: Angle.Degrees(+43.27380044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22365",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Bidelman's Star"},
        {"Henry Draper", "HD 30353"},
        {"Hipparcos Number", "HIP 22365"},
        {"Geneva Identification System", "GEN# +1.00030353"},
        {"Renson", "Renson 7820"},
        {"Smithsonian Astrophysical Observation", "SAO 39773"},
        {"Wilson Evans Batten Catalogue", "WEB 4311"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.22228343),
        dec: Angle.Degrees(+43.27558519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98006"},
        {"Hipparcos Number", "HIP 55094"},
        {"Smithsonian Astrophysical Observation", "SAO 43676"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.20204013),
        dec: Angle.Degrees(+43.27767744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25819"},
        {"Hipparcos Number", "HIP 19239"},
        {"Smithsonian Astrophysical Observation", "SAO 39321"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.85141956),
        dec: Angle.Degrees(+43.27810067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85658"},
        {"Hipparcos Number", "HIP 48576"},
        {"Smithsonian Astrophysical Observation", "SAO 43095"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.61543440),
        dec: Angle.Degrees(+43.27969757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7824"},
        {"Hipparcos Number", "HIP 6118"},
        {"Smithsonian Astrophysical Observation", "SAO 37103"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.63822459),
        dec: Angle.Degrees(+43.28115673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111207",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111207"},
    },
    visualMagnitude: 9.95,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.93866803),
        dec: Angle.Degrees(+43.28116113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113650",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113650"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.25634768),
        dec: Angle.Degrees(+43.28240827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192683"},
        {"Hipparcos Number", "HIP 99751"},
        {"Smithsonian Astrophysical Observation", "SAO 49347"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.59357733),
        dec: Angle.Degrees(+43.28418028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16759",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16759"},
        {"Smithsonian Astrophysical Observation", "SAO 38969"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.90992016),
        dec: Angle.Degrees(+43.29055033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106847",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15167 AB"},
        {"Henry Draper", "HD 206066"},
        {"Hipparcos Number", "HIP 106847"},
        {"Smithsonian Astrophysical Observation", "SAO 51127"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.61374679),
        dec: Angle.Degrees(+43.29079221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216996"},
        {"Hipparcos Number", "HIP 113318"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.23583241),
        dec: Angle.Degrees(+43.29103123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121196"},
        {"Hipparcos Number", "HIP 67768"},
        {"Geneva Identification System", "GEN# +1.00121196"},
        {"Smithsonian Astrophysical Observation", "SAO 44785"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.25248479),
        dec: Angle.Degrees(+43.29199488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22664",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22664"},
    },
    visualMagnitude: 11.03,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.12229467),
        dec: Angle.Degrees(+43.29250941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216815"},
        {"Hipparcos Number", "HIP 113208"},
        {"Smithsonian Astrophysical Observation", "SAO 52493"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.88108585),
        dec: Angle.Degrees(+43.29329060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162112"},
        {"Hipparcos Number", "HIP 87053"},
        {"Geneva Identification System", "GEN# +1.00162112"},
        {"Smithsonian Astrophysical Observation", "SAO 46953"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.81484748),
        dec: Angle.Degrees(+43.29364871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88882",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88882"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.18122407),
        dec: Angle.Degrees(+43.29485384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10204"},
        {"Hipparcos Number", "HIP 7825"},
        {"Geneva Identification System", "GEN# +1.00010204"},
        {"Smithsonian Astrophysical Observation", "SAO 37419"},
        {"Wilson Evans Batten Catalogue", "WEB 1674"},
    },
    visualMagnitude: 5.63,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.16483499),
        dec: Angle.Degrees(+43.29776385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18686"},
        {"Hipparcos Number", "HIP 14103"},
        {"Smithsonian Astrophysical Observation", "SAO 38519"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.46615372),
        dec: Angle.Degrees(+43.29944130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87305",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87305"},
        {"Smithsonian Astrophysical Observation", "SAO 46998"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.58591006),
        dec: Angle.Degrees(+43.30256159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224167"},
        {"Hipparcos Number", "HIP 117971"},
        {"Smithsonian Astrophysical Observation", "SAO 53488"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.91933717),
        dec: Angle.Degrees(+43.30290561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222018"},
        {"Hipparcos Number", "HIP 116522"},
        {"Smithsonian Astrophysical Observation", "SAO 53187"},
        {"Wilson Evans Batten Catalogue", "WEB 20577"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.21591455),
        dec: Angle.Degrees(+43.30892481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151810"},
        {"Hipparcos Number", "HIP 82212"},
        {"Smithsonian Astrophysical Observation", "SAO 46293"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.93437123),
        dec: Angle.Degrees(+43.31056080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158973"},
        {"Hipparcos Number", "HIP 85637"},
        {"Smithsonian Astrophysical Observation", "SAO 46750"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.51951479),
        dec: Angle.Degrees(+43.31057235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82392"},
        {"Hipparcos Number", "HIP 46867"},
        {"Smithsonian Astrophysical Observation", "SAO 42915"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.25755840),
        dec: Angle.Degrees(+43.31066668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75428",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75428"},
        {"Smithsonian Astrophysical Observation", "SAO 45524"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.15186513),
        dec: Angle.Degrees(+43.31097768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112917",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16325 A"},
        {"Henry Draper", "HD 216397"},
        {"Hipparcos Number", "HIP 112917"},
        {"Geneva Identification System", "GEN# +1.00216397"},
        {"Smithsonian Astrophysical Observation", "SAO 52436"},
        {"Wilson Evans Batten Catalogue", "WEB 20108"},
    },
    visualMagnitude: 4.95,
    bvColour: 1.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.00811365),
        dec: Angle.Degrees(+43.31236494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 277320"},
        {"Hipparcos Number", "HIP 23655"},
        {"Geneva Identification System", "GEN# +1.00277320"},
        {"Smithsonian Astrophysical Observation", "SAO 40002"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.25946615),
        dec: Angle.Degrees(+43.31331929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3258",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3258"},
        {"Smithsonian Astrophysical Observation", "SAO 36577"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.37191409),
        dec: Angle.Degrees(+43.31358005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114782",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16625 ABC"},
        {"Henry Draper", "HD 219398"},
        {"Hipparcos Number", "HIP 114782"},
        {"Smithsonian Astrophysical Observation", "SAO 52838"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.76778187),
        dec: Angle.Degrees(+43.31449952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17569"},
        {"Hipparcos Number", "HIP 13259"},
        {"Smithsonian Astrophysical Observation", "SAO 38386"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.65318939),
        dec: Angle.Degrees(+43.31471396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178615"},
        {"Hipparcos Number", "HIP 93910"},
        {"Geneva Identification System", "GEN# +1.00178615"},
        {"Smithsonian Astrophysical Observation", "SAO 48106"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.83325841),
        dec: Angle.Degrees(+43.31522088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24701"},
        {"Hipparcos Number", "HIP 18507"},
        {"Smithsonian Astrophysical Observation", "SAO 39213"},
        {"Wilson Evans Batten Catalogue", "WEB 3566"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.35736260),
        dec: Angle.Degrees(+43.31641300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132130"},
        {"Hipparcos Number", "HIP 73078"},
        {"Geneva Identification System", "GEN# +1.00132130"},
        {"Smithsonian Astrophysical Observation", "SAO 45284"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.03363424),
        dec: Angle.Degrees(+43.31757965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 92.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47805",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47805"},
        {"Smithsonian Astrophysical Observation", "SAO 43010"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.18217447),
        dec: Angle.Degrees(+43.31895578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207331"},
        {"Hipparcos Number", "HIP 107557"},
        {"Smithsonian Astrophysical Observation", "SAO 51294"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.75966894),
        dec: Angle.Degrees(+43.32184113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31617"},
        {"Hipparcos Number", "HIP 23186"},
        {"Celescope Catalog", "CEL 500"},
        {"Geneva Identification System", "GEN# +1.00031617"},
        {"Smithsonian Astrophysical Observation", "SAO 39918"},
        {"Wilson Evans Batten Catalogue", "WEB 4500"},
    },
    visualMagnitude: 7.42,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.83853794),
        dec: Angle.Degrees(+43.32339018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61173"},
        {"Hipparcos Number", "HIP 37344"},
        {"Smithsonian Astrophysical Observation", "SAO 41917"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.98079873),
        dec: Angle.Degrees(+43.32421937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37338"},
        {"Hipparcos Number", "HIP 26666"},
        {"Smithsonian Astrophysical Observation", "SAO 40517"},
        {"Wilson Evans Batten Catalogue", "WEB 5257"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.01217102),
        dec: Angle.Degrees(+43.32445724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156964"},
        {"Hipparcos Number", "HIP 84658"},
        {"Smithsonian Astrophysical Observation", "SAO 46622"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.60165977),
        dec: Angle.Degrees(+43.32525409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105909"},
        {"Hipparcos Number", "HIP 59424"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.84381946),
        dec: Angle.Degrees(+43.32621296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97657"},
        {"Hipparcos Number", "HIP 54915"},
        {"Geneva Identification System", "GEN# +1.00097657"},
        {"Smithsonian Astrophysical Observation", "SAO 43655"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.68855166),
        dec: Angle.Degrees(+43.32957410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20677"},
        {"Hipparcos Number", "HIP 15648"},
        {"Fundamental Katalog 5th Edition", "FK5 2236"},
        {"Geneva Identification System", "GEN# +1.00020677"},
        {"Smithsonian Astrophysical Observation", "SAO 38750"},
        {"Wilson Evans Batten Catalogue", "WEB 3000"},
    },
    visualMagnitude: 4.96,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.36086309),
        dec: Angle.Degrees(+43.32965174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28083"},
        {"Hipparcos Number", "HIP 20835"},
        {"Celescope Catalog", "CEL 401"},
        {"Geneva Identification System", "GEN# +1.00028083"},
        {"Smithsonian Astrophysical Observation", "SAO 39547"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.97811425),
        dec: Angle.Degrees(+43.33113605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114766",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114766"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.71649262),
        dec: Angle.Degrees(+43.33133482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36712",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36712"},
        {"Smithsonian Astrophysical Observation", "SAO 41844"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.26675356),
        dec: Angle.Degrees(+43.33168166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167513"},
        {"Hipparcos Number", "HIP 89317"},
        {"Geneva Identification System", "GEN# +1.00167513"},
        {"Smithsonian Astrophysical Observation", "SAO 47318"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.37210276),
        dec: Angle.Degrees(+43.33181717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222355"},
        {"Hipparcos Number", "HIP 116746"},
        {"Geneva Identification System", "GEN# +1.00222355"},
        {"Smithsonian Astrophysical Observation", "SAO 53246"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.90676061),
        dec: Angle.Degrees(+43.33260586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70071"},
        {"Hipparcos Number", "HIP 40979"},
        {"Geneva Identification System", "GEN# +1.00070071"},
        {"Smithsonian Astrophysical Observation", "SAO 42311"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.43450345),
        dec: Angle.Degrees(+43.33401621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6115"},
        {"Hipparcos Number", "HIP 4913"},
        {"Smithsonian Astrophysical Observation", "SAO 36877"},
    },
    visualMagnitude: 8.44,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.75735446),
        dec: Angle.Degrees(+43.33934800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222750"},
        {"Hipparcos Number", "HIP 117007"},
        {"Geneva Identification System", "GEN# +1.00222750"},
        {"Smithsonian Astrophysical Observation", "SAO 53312"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.79704774),
        dec: Angle.Degrees(+43.34125627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104178"},
        {"Hipparcos Number", "HIP 58516"},
        {"Geneva Identification System", "GEN# +1.00104178"},
        {"Smithsonian Astrophysical Observation", "SAO 43987"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.00480786),
        dec: Angle.Degrees(+43.34365293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90681",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90681"},
        {"Smithsonian Astrophysical Observation", "SAO 47537"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.53517754),
        dec: Angle.Degrees(+43.34399146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88017"},
        {"Hipparcos Number", "HIP 49795"},
        {"Smithsonian Astrophysical Observation", "SAO 43215"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.46610665),
        dec: Angle.Degrees(+43.34414322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104882"},
        {"Hipparcos Number", "HIP 58890"},
        {"Smithsonian Astrophysical Observation", "SAO 44019"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.16775418),
        dec: Angle.Degrees(+43.34489691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47030"},
        {"Hipparcos Number", "HIP 31782"},
        {"Smithsonian Astrophysical Observation", "SAO 41231"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.68028026),
        dec: Angle.Degrees(+43.35293591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115352",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115352"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.46814170),
        dec: Angle.Degrees(+43.35421599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20652"},
        {"Hipparcos Number", "HIP 15617"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.27397489),
        dec: Angle.Degrees(+43.36056492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51939",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51939"},
        {"Smithsonian Astrophysical Observation", "SAO 43404"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.16262479),
        dec: Angle.Degrees(+43.36095241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24910"},
        {"Hipparcos Number", "HIP 18636"},
        {"Smithsonian Astrophysical Observation", "SAO 39227"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.83703969),
        dec: Angle.Degrees(+43.36098305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18377",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2861 AB"},
        {"Hipparcos Number", "HIP 18377"},
        {"Wilson Evans Batten Catalogue", "WEB 3548"},
    },
    visualMagnitude: 10.15,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)55, 40.9500),
        dec: Angle.DegreesMinutesSeconds((int)+43, (int)21, 39.900)
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
    primaryId: "HIP 101511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196216"},
        {"Hipparcos Number", "HIP 101511"},
        {"Geneva Identification System", "GEN# +1.00196216"},
        {"Smithsonian Astrophysical Observation", "SAO 49814"},
        {"Wilson Evans Batten Catalogue", "WEB 18343"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.56708644),
        dec: Angle.Degrees(+43.36121038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2153",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2153"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.80254634),
        dec: Angle.Degrees(+43.36165128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5129"},
        {"Hipparcos Number", "HIP 4205"},
        {"Geneva Identification System", "GEN# +1.00005129"},
        {"Smithsonian Astrophysical Observation", "SAO 36751"},
        {"Wilson Evans Batten Catalogue", "WEB 756"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.41815926),
        dec: Angle.Degrees(+43.36370529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 282.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103811"},
        {"Hipparcos Number", "HIP 58292"},
        {"Geneva Identification System", "GEN# +1.00103811"},
        {"Smithsonian Astrophysical Observation", "SAO 43964"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.31797446),
        dec: Angle.Degrees(+43.36442981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18392"},
        {"Hipparcos Number", "HIP 13887"},
        {"Smithsonian Astrophysical Observation", "SAO 38485"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.70559620),
        dec: Angle.Degrees(+43.36458720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29722"},
        {"Hipparcos Number", "HIP 21928"},
        {"Celescope Catalog", "CEL 456"},
        {"Fundamental Katalog 5th Edition", "FK5 2349"},
        {"Geneva Identification System", "GEN# +1.00029722"},
        {"Smithsonian Astrophysical Observation", "SAO 39699"},
        {"Wilson Evans Batten Catalogue", "WEB 4211"},
    },
    visualMagnitude: 5.30,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.72624534),
        dec: Angle.Degrees(+43.36526451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118722"},
        {"Hipparcos Number", "HIP 66493"},
        {"Smithsonian Astrophysical Observation", "SAO 44688"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.46486652),
        dec: Angle.Degrees(+43.36674677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199395"},
        {"Hipparcos Number", "HIP 103282"},
        {"Geneva Identification System", "GEN# +1.00199395"},
        {"Smithsonian Astrophysical Observation", "SAO 50236"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.86040381),
        dec: Angle.Degrees(+43.36726947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35544"},
        {"Hipparcos Number", "HIP 25542"},
        {"Celescope Catalog", "CEL 701"},
        {"Geneva Identification System", "GEN# +1.00035544"},
        {"Smithsonian Astrophysical Observation", "SAO 40345"},
        {"Wilson Evans Batten Catalogue", "WEB 4957"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.91332879),
        dec: Angle.Degrees(+43.36793799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83518",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83518"},
        {"Smithsonian Astrophysical Observation", "SAO 46467"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.02646301),
        dec: Angle.Degrees(+43.37058559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215687"},
        {"Hipparcos Number", "HIP 112424"},
        {"Geneva Identification System", "GEN# +1.00215687"},
        {"Smithsonian Astrophysical Observation", "SAO 52351"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.57966332),
        dec: Angle.Degrees(+43.37123658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56177",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56177"},
    },
    visualMagnitude: 11.14,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.72859519),
        dec: Angle.Degrees(+43.75135148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -212.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221379"},
        {"Hipparcos Number", "HIP 116088"},
        {"Smithsonian Astrophysical Observation", "SAO 53112"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.84717454),
        dec: Angle.Degrees(+43.37342398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81648",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81648"},
        {"Smithsonian Astrophysical Observation", "SAO 46222"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.18189690),
        dec: Angle.Degrees(+43.37371244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2730"},
        {"Hipparcos Number", "HIP 2434"},
        {"Geneva Identification System", "GEN# +1.00002730"},
        {"Smithsonian Astrophysical Observation", "SAO 36433"},
        {"Wilson Evans Batten Catalogue", "WEB 445"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.75694714),
        dec: Angle.Degrees(+43.37421718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109711",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109711"},
        {"Smithsonian Astrophysical Observation", "SAO 51774"},
    },
    visualMagnitude: 9.18,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.34519794),
        dec: Angle.Degrees(+43.37433969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40722"},
        {"Hipparcos Number", "HIP 28642"},
        {"Smithsonian Astrophysical Observation", "SAO 40808"},
        {"Wilson Evans Batten Catalogue", "WEB 5598"},
    },
    visualMagnitude: 6.38,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.72287474),
        dec: Angle.Degrees(+43.37840424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99685",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13555 A"},
        {"Henry Draper", "HD 192535"},
        {"Hipparcos Number", "HIP 99685"},
        {"Fundamental Katalog 5th Edition", "FK5 3620"},
        {"Geneva Identification System", "GEN# +1.00192535J"},
        {"Smithsonian Astrophysical Observation", "SAO 49336"},
        {"Wilson Evans Batten Catalogue", "WEB 17875"},
    },
    visualMagnitude: 6.13,
    bvColour: 1.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.42839988),
        dec: Angle.Degrees(+43.37900332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86776",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86776"},
        {"Cincinnati Publication", "Ci 20 1062"},
        {"Geneva Identification System", "GEN# +0.04302796"},
        {"Wilson Evans Batten Catalogue", "WEB 14633"},
    },
    visualMagnitude: 10.49,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.98314449),
        dec: Angle.Degrees(+43.38007697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -602.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127663"},
        {"Hipparcos Number", "HIP 71008"},
        {"Smithsonian Astrophysical Observation", "SAO 45090"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.83521244),
        dec: Angle.Degrees(+43.38233354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42367",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42367"},
        {"Smithsonian Astrophysical Observation", "SAO 42469"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.58190418),
        dec: Angle.Degrees(+43.38440827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142518"},
        {"Hipparcos Number", "HIP 77806"},
        {"Smithsonian Astrophysical Observation", "SAO 45779"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.31371600),
        dec: Angle.Degrees(+43.38647132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182694"},
        {"Hipparcos Number", "HIP 95352"},
        {"Geneva Identification System", "GEN# +1.00182694"},
        {"Smithsonian Astrophysical Observation", "SAO 48401"},
        {"Wilson Evans Batten Catalogue", "WEB 16666"},
    },
    visualMagnitude: 5.85,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.98536934),
        dec: Angle.Degrees(+43.38823710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82669"},
        {"Hipparcos Number", "HIP 46998"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.68326454),
        dec: Angle.Degrees(+43.38879314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66166",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66166"},
    },
    visualMagnitude: 10.86,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.44233828),
        dec: Angle.Degrees(+43.38977092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148728"},
        {"Hipparcos Number", "HIP 80668"},
        {"Geneva Identification System", "GEN# +1.00148728"},
        {"Smithsonian Astrophysical Observation", "SAO 46106"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.05009976),
        dec: Angle.Degrees(+43.39087078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62559",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62559"},
        {"Smithsonian Astrophysical Observation", "SAO 44336"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.27243785),
        dec: Angle.Degrees(+43.39096399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152801"},
        {"Hipparcos Number", "HIP 82641"},
        {"Geneva Identification System", "GEN# +1.00152801"},
        {"Smithsonian Astrophysical Observation", "SAO 46353"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.39151771),
        dec: Angle.Degrees(+43.39100019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218417"},
        {"Hipparcos Number", "HIP 114185"},
        {"Smithsonian Astrophysical Observation", "SAO 52709"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.85819977),
        dec: Angle.Degrees(+43.39100923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109105",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109105"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.51260206),
        dec: Angle.Degrees(+43.39406450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159833"},
        {"Hipparcos Number", "HIP 86008"},
        {"Smithsonian Astrophysical Observation", "SAO 46809"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.67241273),
        dec: Angle.Degrees(+43.39736190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55394",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8136 AB"},
        {"Henry Draper", "HD 98527"},
        {"Hipparcos Number", "HIP 55394"},
        {"Smithsonian Astrophysical Observation", "SAO 43703"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.13846213),
        dec: Angle.Degrees(+43.39768189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22255",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3438 ABC"},
        {"Henry Draper", "HD 30196"},
        {"Hipparcos Number", "HIP 22255"},
        {"Geneva Identification System", "GEN# +1.00030196J"},
        {"Smithsonian Astrophysical Observation", "SAO 39750"},
        {"Wilson Evans Batten Catalogue", "WEB 4282"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.87109486),
        dec: Angle.Degrees(+43.40056298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3558",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 627 AB"},
        {"Henry Draper", "HD 4267"},
        {"Hipparcos Number", "HIP 3558"},
        {"Smithsonian Astrophysical Observation", "SAO 36628"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.36818048),
        dec: Angle.Degrees(+43.40092759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73"},
        {"Hipparcos Number", "HIP 470"},
        {"Geneva Identification System", "GEN# +1.00000073"},
        {"Smithsonian Astrophysical Observation", "SAO 36047"},
        {"Wilson Evans Batten Catalogue", "WEB 76"},
    },
    visualMagnitude: 8.47,
    bvColour: -0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.40397116),
        dec: Angle.Degrees(+43.40143611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17238"},
        {"Hipparcos Number", "HIP 13017"},
        {"Smithsonian Astrophysical Observation", "SAO 38333"},
        {"Wilson Evans Batten Catalogue", "WEB 2630"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.84410062),
        dec: Angle.Degrees(+43.40207793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75853",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75853"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.40812054),
        dec: Angle.Degrees(+43.40321669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10518",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10518"},
        {"Smithsonian Astrophysical Observation", "SAO 37898"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.88117848),
        dec: Angle.Degrees(+43.40422329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152905"},
        {"Hipparcos Number", "HIP 82703"},
        {"Geneva Identification System", "GEN# +1.00152905"},
        {"Smithsonian Astrophysical Observation", "SAO 46360"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.57898776),
        dec: Angle.Degrees(+43.40639121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67808"},
        {"Hipparcos Number", "HIP 40098"},
        {"Geneva Identification System", "GEN# +1.00067808"},
        {"Smithsonian Astrophysical Observation", "SAO 42215"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.86973169),
        dec: Angle.Degrees(+43.40724358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107380"},
        {"Hipparcos Number", "HIP 60184"},
        {"Geneva Identification System", "GEN# +1.00107380"},
        {"Smithsonian Astrophysical Observation", "SAO 44133"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.13649733),
        dec: Angle.Degrees(+43.40840157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25704",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25704"},
        {"Wilson Evans Batten Catalogue", "WEB 4987"},
    },
    visualMagnitude: 9.90,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.33376142),
        dec: Angle.Degrees(+43.40915072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69242"},
        {"Hipparcos Number", "HIP 40651"},
        {"Geneva Identification System", "GEN# +1.00069242"},
        {"Smithsonian Astrophysical Observation", "SAO 42275"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.47385105),
        dec: Angle.Degrees(+43.40978386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34613"},
        {"Hipparcos Number", "HIP 24976"},
        {"Celescope Catalog", "CEL 621"},
        {"Geneva Identification System", "GEN# +1.00034613"},
        {"Smithsonian Astrophysical Observation", "SAO 40259"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.23477545),
        dec: Angle.Degrees(+43.41290228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132502"},
        {"Hipparcos Number", "HIP 73236"},
        {"Smithsonian Astrophysical Observation", "SAO 45308"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.51693630),
        dec: Angle.Degrees(+43.41308171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26142",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26142"},
        {"Smithsonian Astrophysical Observation", "SAO 40440"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.60729267),
        dec: Angle.Degrees(+43.41597315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164212"},
        {"Hipparcos Number", "HIP 87944"},
        {"Smithsonian Astrophysical Observation", "SAO 47096"},
        {"Wilson Evans Batten Catalogue", "WEB 14850"},
    },
    visualMagnitude: 6.83,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.48572010),
        dec: Angle.Degrees(+43.41711608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54658",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54658"},
        {"Cincinnati Publication", "Ci 20 615"},
        {"Wilson Evans Batten Catalogue", "WEB 9868"},
    },
    visualMagnitude: 10.92,
    bvColour: 1.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.83326608),
        dec: Angle.Degrees(+43.41841593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -633.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -443.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19159",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2980 AB"},
        {"Henry Draper", "HD 25693"},
        {"Hipparcos Number", "HIP 19159"},
        {"Smithsonian Astrophysical Observation", "SAO 39312"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.60629600),
        dec: Angle.Degrees(+43.41864345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -198.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223570"},
        {"Hipparcos Number", "HIP 117565"},
        {"Smithsonian Astrophysical Observation", "SAO 53411"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.62871185),
        dec: Angle.Degrees(+43.41927827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33983",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33983"},
        {"Smithsonian Astrophysical Observation", "SAO 41516"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.834,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.77051542),
        dec: Angle.Degrees(+43.42041572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32768"},
        {"Hipparcos Number", "HIP 23849"},
        {"Smithsonian Astrophysical Observation", "SAO 40038"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.90369470),
        dec: Angle.Degrees(+43.42102035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199511"},
        {"Hipparcos Number", "HIP 103341"},
        {"Celescope Catalog", "CEL 5210"},
        {"Geneva Identification System", "GEN# +1.00199511"},
        {"Smithsonian Astrophysical Observation", "SAO 50253"},
        {"Wilson Evans Batten Catalogue", "WEB 18780"},
    },
    visualMagnitude: 6.87,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.04827982),
        dec: Angle.Degrees(+43.42430516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101877"},
        {"Smithsonian Astrophysical Observation", "SAO 49893"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.67068134),
        dec: Angle.Degrees(+43.42683435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213484"},
        {"Hipparcos Number", "HIP 111139"},
        {"Smithsonian Astrophysical Observation", "SAO 52093"},
    },
    visualMagnitude: 8.29,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.72668600),
        dec: Angle.Degrees(+43.42782040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62201",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8655 AB"},
        {"Hipparcos Number", "HIP 62201"},
        {"Smithsonian Astrophysical Observation", "SAO 44315"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.22887678),
        dec: Angle.Degrees(+43.42787935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207001"},
        {"Hipparcos Number", "HIP 107361"},
        {"Smithsonian Astrophysical Observation", "SAO 51245"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.18395632),
        dec: Angle.Degrees(+43.42922618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14621"},
        {"Hipparcos Number", "HIP 11109"},
        {"Smithsonian Astrophysical Observation", "SAO 37988"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.74137644),
        dec: Angle.Degrees(+43.42939236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152153"},
        {"Hipparcos Number", "HIP 82355"},
        {"Geneva Identification System", "GEN# +1.00152153"},
        {"Smithsonian Astrophysical Observation", "SAO 46311"},
        {"Wilson Evans Batten Catalogue", "WEB 13904"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.41905893),
        dec: Angle.Degrees(+43.43045963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14872",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14872"},
        {"Smithsonian Astrophysical Observation", "SAO 38632"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.00240171),
        dec: Angle.Degrees(+43.43293585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90372",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90372"},
        {"Smithsonian Astrophysical Observation", "SAO 47494"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.60794414),
        dec: Angle.Degrees(+43.43374654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57179"},
        {"Hipparcos Number", "HIP 35723"},
        {"Smithsonian Astrophysical Observation", "SAO 41717"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.54441869),
        dec: Angle.Degrees(+43.43463288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31894"},
        {"Hipparcos Number", "HIP 23375"},
        {"Celescope Catalog", "CEL 508"},
        {"Geneva Identification System", "GEN# +1.00031894"},
        {"Smithsonian Astrophysical Observation", "SAO 39950"},
        {"Wilson Evans Batten Catalogue", "WEB 4541"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.39289238),
        dec: Angle.Degrees(+43.43574008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131175"},
        {"Hipparcos Number", "HIP 72598"},
        {"Smithsonian Astrophysical Observation", "SAO 45236"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.65457251),
        dec: Angle.Degrees(+43.43840443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 528"},
        {"Hipparcos Number", "HIP 808"},
        {"Smithsonian Astrophysical Observation", "SAO 36115"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.48996359),
        dec: Angle.Degrees(+43.43841927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179184"},
        {"Hipparcos Number", "HIP 94123"},
        {"Smithsonian Astrophysical Observation", "SAO 48136"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.39578197),
        dec: Angle.Degrees(+43.44098254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77497"},
        {"Hipparcos Number", "HIP 44535"},
        {"Smithsonian Astrophysical Observation", "SAO 42674"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.11349330),
        dec: Angle.Degrees(+43.44196619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190045"},
        {"Hipparcos Number", "HIP 98566"},
        {"Geneva Identification System", "GEN# +1.00190045"},
        {"Smithsonian Astrophysical Observation", "SAO 49090"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.31773721),
        dec: Angle.Degrees(+43.44289666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197375"},
        {"Hipparcos Number", "HIP 102122"},
        {"Celescope Catalog", "CEL 5146"},
        {"Geneva Identification System", "GEN# +1.00197375"},
        {"Smithsonian Astrophysical Observation", "SAO 49944"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.42658079),
        dec: Angle.Degrees(+43.44324929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33410"},
        {"Hipparcos Number", "HIP 24235"},
        {"Geneva Identification System", "GEN# +1.00033410"},
        {"Smithsonian Astrophysical Observation", "SAO 40106"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.04930964),
        dec: Angle.Degrees(+43.44378064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102460",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102460"},
        {"Geneva Identification System", "GEN# +0.04203854"},
        {"Smithsonian Astrophysical Observation", "SAO 50034"},
    },
    visualMagnitude: 8.68,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.43536481),
        dec: Angle.Degrees(+43.44514559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108630",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108630"},
        {"Geneva Identification System", "GEN# +0.04204267"},
        {"Smithsonian Astrophysical Observation", "SAO 51539"},
        {"Wilson Evans Batten Catalogue", "WEB 19548"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.10478867),
        dec: Angle.Degrees(+43.44537859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27523"},
        {"Hipparcos Number", "HIP 20433"},
        {"Geneva Identification System", "GEN# +1.00027523"},
        {"Smithsonian Astrophysical Observation", "SAO 39491"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.65580384),
        dec: Angle.Degrees(+43.44929790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166068"},
        {"Hipparcos Number", "HIP 88722"},
        {"Smithsonian Astrophysical Observation", "SAO 47225"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.69802309),
        dec: Angle.Degrees(+43.45191964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86357"},
        {"Hipparcos Number", "HIP 48933"},
        {"Geneva Identification System", "GEN# +1.00086357"},
        {"Smithsonian Astrophysical Observation", "SAO 43126"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.74634292),
        dec: Angle.Degrees(+43.45197787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10025",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10025"},
        {"Smithsonian Astrophysical Observation", "SAO 37803"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.26233637),
        dec: Angle.Degrees(+43.45335118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51097"},
        {"Hipparcos Number", "HIP 33539"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.55089603),
        dec: Angle.Degrees(+43.45490641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77556"},
        {"Hipparcos Number", "HIP 44567"},
        {"Geneva Identification System", "GEN# +1.00077556"},
        {"Smithsonian Astrophysical Observation", "SAO 42680"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.20829784),
        dec: Angle.Degrees(+43.45661225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8671"},
        {"Hipparcos Number", "HIP 6711"},
        {"Geneva Identification System", "GEN# +1.00008671"},
        {"Smithsonian Astrophysical Observation", "SAO 37204"},
        {"Wilson Evans Batten Catalogue", "WEB 1464"},
    },
    visualMagnitude: 5.98,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.57749566),
        dec: Angle.Degrees(+43.45788606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126304"},
        {"Hipparcos Number", "HIP 70347"},
        {"Smithsonian Astrophysical Observation", "SAO 45026"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.89134498),
        dec: Angle.Degrees(+43.45873157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197139"},
        {"Hipparcos Number", "HIP 101986"},
        {"Geneva Identification System", "GEN# +1.00197139"},
        {"Smithsonian Astrophysical Observation", "SAO 49912"},
        {"Wilson Evans Batten Catalogue", "WEB 18436"},
    },
    visualMagnitude: 5.97,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.01339893),
        dec: Angle.Degrees(+43.45901630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113267"},
        {"Hipparcos Number", "HIP 63604"},
        {"Smithsonian Astrophysical Observation", "SAO 44435"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.51869677),
        dec: Angle.Degrees(+43.46085891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25100"},
        {"Hipparcos Number", "HIP 18758"},
        {"Smithsonian Astrophysical Observation", "SAO 39247"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.27492648),
        dec: Angle.Degrees(+43.46104314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166208"},
        {"Hipparcos Number", "HIP 88788"},
        {"Geneva Identification System", "GEN# +1.00166208"},
        {"Smithsonian Astrophysical Observation", "SAO 47237"},
        {"Wilson Evans Batten Catalogue", "WEB 15044"},
    },
    visualMagnitude: 5.00,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.86974331),
        dec: Angle.Degrees(+43.46203247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195574"},
        {"Hipparcos Number", "HIP 101179"},
        {"Smithsonian Astrophysical Observation", "SAO 49720"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.63063612),
        dec: Angle.Degrees(+43.46359208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91408"},
        {"Hipparcos Number", "HIP 51726"},
        {"Smithsonian Astrophysical Observation", "SAO 43386"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.53192342),
        dec: Angle.Degrees(+43.46473325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130353"},
        {"Hipparcos Number", "HIP 72227"},
        {"Geneva Identification System", "GEN# +1.00130353"},
        {"Smithsonian Astrophysical Observation", "SAO 45213"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.57534537),
        dec: Angle.Degrees(+43.46568417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85372"},
        {"Hipparcos Number", "HIP 48432"},
        {"Smithsonian Astrophysical Observation", "SAO 43082"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.11909586),
        dec: Angle.Degrees(+43.46636175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158822"},
        {"Hipparcos Number", "HIP 85573"},
        {"Smithsonian Astrophysical Observation", "SAO 46743"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.31151932),
        dec: Angle.Degrees(+43.46977355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64322"},
        {"Hipparcos Number", "HIP 38688"},
        {"Smithsonian Astrophysical Observation", "SAO 42068"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.80928085),
        dec: Angle.Degrees(+43.46992168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160950"},
        {"Hipparcos Number", "HIP 86501"},
        {"Geneva Identification System", "GEN# +1.00160950"},
        {"Smithsonian Astrophysical Observation", "SAO 46883"},
        {"Wilson Evans Batten Catalogue", "WEB 14589"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.15631676),
        dec: Angle.Degrees(+43.47052764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57504",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57504"},
        {"Smithsonian Astrophysical Observation", "SAO 43889"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.80743287),
        dec: Angle.Degrees(+43.47111088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60078"},
        {"Hipparcos Number", "HIP 36876"},
        {"Smithsonian Astrophysical Observation", "SAO 41862"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.71732917),
        dec: Angle.Degrees(+43.47238826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81919",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10188 AB"},
        {"Henry Draper", "HD 151188"},
        {"Hipparcos Number", "HIP 81919"},
        {"Geneva Identification System", "GEN# +1.00151188"},
        {"Smithsonian Astrophysical Observation", "SAO 46250"},
        {"Wilson Evans Batten Catalogue", "WEB 13835"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.98466124),
        dec: Angle.Degrees(+43.47551313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219307"},
        {"Hipparcos Number", "HIP 114727"},
        {"Geneva Identification System", "GEN# +1.00219307"},
        {"Smithsonian Astrophysical Observation", "SAO 52825"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.59671582),
        dec: Angle.Degrees(+43.47605102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11235"},
        {"Hipparcos Number", "HIP 8637"},
        {"Renson", "Renson 2783"},
        {"Smithsonian Astrophysical Observation", "SAO 37559"},
    },
    visualMagnitude: 8.49,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.84687331),
        dec: Angle.Degrees(+43.47648459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74151"},
        {"Hipparcos Number", "HIP 42845"},
        {"Smithsonian Astrophysical Observation", "SAO 42515"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.96707789),
        dec: Angle.Degrees(+43.48022738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27313",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27313"},
        {"Smithsonian Astrophysical Observation", "SAO 40607"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.79271964),
        dec: Angle.Degrees(+43.48078052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8635",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8635"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.83783346),
        dec: Angle.Degrees(+43.48123870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74971",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9589 AB"},
        {"Hipparcos Number", "HIP 74971"},
        {"Smithsonian Astrophysical Observation", "SAO 45485"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.80500593),
        dec: Angle.Degrees(+43.48131659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129563"},
        {"Hipparcos Number", "HIP 71849"},
        {"Geneva Identification System", "GEN# +1.00129563"},
        {"Smithsonian Astrophysical Observation", "SAO 45177"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.45020355),
        dec: Angle.Degrees(+43.48179318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16964",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16964"},
        {"Smithsonian Astrophysical Observation", "SAO 39003"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.56417030),
        dec: Angle.Degrees(+43.48185914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98839"},
        {"Hipparcos Number", "HIP 55560"},
        {"Fundamental Katalog 5th Edition", "FK5 2908"},
        {"Geneva Identification System", "GEN# +1.00098839"},
        {"Smithsonian Astrophysical Observation", "SAO 43719"},
        {"Wilson Evans Batten Catalogue", "WEB 9986"},
    },
    visualMagnitude: 4.99,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.70672415),
        dec: Angle.Degrees(+43.48273665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61163",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61163"},
        {"Geneva Identification System", "GEN# +0.04402199"},
        {"Smithsonian Astrophysical Observation", "SAO 44218"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.99772846),
        dec: Angle.Degrees(+43.48299161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50455"},
        {"Hipparcos Number", "HIP 33289"},
        {"Smithsonian Astrophysical Observation", "SAO 41434"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.87852725),
        dec: Angle.Degrees(+43.48436901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213854"},
        {"Hipparcos Number", "HIP 111368"},
        {"Smithsonian Astrophysical Observation", "SAO 52146"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.42996167),
        dec: Angle.Degrees(+43.48534399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108391",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108391"},
    },
    visualMagnitude: 10.77,
    bvColour: 1.806,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.38585366),
        dec: Angle.Degrees(+43.49149077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 194.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -157.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60768",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60768"},
        {"Geneva Identification System", "GEN# +0.04402193"},
    },
    visualMagnitude: 10.49,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.84542141),
        dec: Angle.Degrees(+43.49230708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214906"},
        {"Hipparcos Number", "HIP 111961"},
        {"Smithsonian Astrophysical Observation", "SAO 52253"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.18264689),
        dec: Angle.Degrees(+43.49326762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26978",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26978"},
        {"Smithsonian Astrophysical Observation", "SAO 40561"},
        {"Wilson Evans Batten Catalogue", "WEB 5317"},
    },
    visualMagnitude: 9.16,
    bvColour: 2.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.86922400),
        dec: Angle.Degrees(+43.49338743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31220"},
        {"Hipparcos Number", "HIP 22928"},
        {"Geneva Identification System", "GEN# +1.00031220"},
        {"Smithsonian Astrophysical Observation", "SAO 39875"},
        {"Wilson Evans Batten Catalogue", "WEB 4455"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.01404745),
        dec: Angle.Degrees(+43.49350904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2888"},
        {"Hipparcos Number", "HIP 2553"},
        {"Geneva Identification System", "GEN# +1.00002888"},
        {"Renson", "Renson 710"},
        {"Smithsonian Astrophysical Observation", "SAO 36453"},
        {"Wilson Evans Batten Catalogue", "WEB 468"},
    },
    visualMagnitude: 6.69,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.11160979),
        dec: Angle.Degrees(+43.49481723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193632"},
        {"Hipparcos Number", "HIP 100217"},
        {"Geneva Identification System", "GEN# +1.00193632"},
        {"Smithsonian Astrophysical Observation", "SAO 49471"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.89327129),
        dec: Angle.Degrees(+43.49588732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 109.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94918",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94918"},
        {"Smithsonian Astrophysical Observation", "SAO 48319"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.72547013),
        dec: Angle.Degrees(+43.49639161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223635"},
        {"Hipparcos Number", "HIP 117620"},
        {"Geneva Identification System", "GEN# +1.00223635"},
        {"Smithsonian Astrophysical Observation", "SAO 53424"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.82300943),
        dec: Angle.Degrees(+43.49810607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45146",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45146"},
        {"Smithsonian Astrophysical Observation", "SAO 42736"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.97306940),
        dec: Angle.Degrees(+43.49912927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -176.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -227.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69198"},
        {"Hipparcos Number", "HIP 40632"},
        {"Geneva Identification System", "GEN# +1.00069198"},
        {"Smithsonian Astrophysical Observation", "SAO 42272"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.42939933),
        dec: Angle.Degrees(+43.49925299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22074",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22074"},
    },
    visualMagnitude: 11.32,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.22331018),
        dec: Angle.Degrees(+43.49973655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159814"},
        {"Hipparcos Number", "HIP 85992"},
        {"Smithsonian Astrophysical Observation", "SAO 46804"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.62689880),
        dec: Angle.Degrees(+43.50086814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54587",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54587"},
        {"Smithsonian Astrophysical Observation", "SAO 43632"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.57318169),
        dec: Angle.Degrees(+43.50332881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215548"},
        {"Hipparcos Number", "HIP 112342"},
        {"Smithsonian Astrophysical Observation", "SAO 52333"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.32678033),
        dec: Angle.Degrees(+43.50391724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65041"},
        {"Hipparcos Number", "HIP 38979"},
        {"Geneva Identification System", "GEN# +1.00065041"},
        {"Smithsonian Astrophysical Observation", "SAO 42099"},
        {"Wilson Evans Batten Catalogue", "WEB 7643"},
    },
    visualMagnitude: 7.30,
    bvColour: -0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.64529400),
        dec: Angle.Degrees(+43.50395031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28283",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28283"},
        {"Smithsonian Astrophysical Observation", "SAO 40738"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.64056385),
        dec: Angle.Degrees(+43.50421911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17626",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17626"},
        {"Smithsonian Astrophysical Observation", "SAO 39093"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.65104918),
        dec: Angle.Degrees(+43.50614352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133910"},
        {"Hipparcos Number", "HIP 73845"},
        {"Smithsonian Astrophysical Observation", "SAO 45369"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.37429475),
        dec: Angle.Degrees(+43.50846995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -175.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117695",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17063 AB"},
        {"Henry Draper", "HD 223735"},
        {"Hipparcos Number", "HIP 117695"},
        {"Smithsonian Astrophysical Observation", "SAO 53435"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.03978371),
        dec: Angle.Degrees(+43.50864747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40739"},
        {"Hipparcos Number", "HIP 28639"},
        {"Smithsonian Astrophysical Observation", "SAO 40806"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.71115102),
        dec: Angle.Degrees(+43.50956745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8016"},
        {"Hipparcos Number", "HIP 6259"},
        {"Smithsonian Astrophysical Observation", "SAO 37130"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.07501388),
        dec: Angle.Degrees(+43.51014391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156263"},
        {"Hipparcos Number", "HIP 84333"},
        {"Smithsonian Astrophysical Observation", "SAO 46580"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.62161341),
        dec: Angle.Degrees(+43.51183259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216176"},
        {"Hipparcos Number", "HIP 112752"},
        {"Smithsonian Astrophysical Observation", "SAO 52408"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.51202661),
        dec: Angle.Degrees(+43.51383406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 276742"},
        {"Hipparcos Number", "HIP 22197"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.61400319),
        dec: Angle.Degrees(+43.51434164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17271",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2688 A"},
        {"Henry Draper", "HD 22846"},
        {"Hipparcos Number", "HIP 17271"},
        {"Smithsonian Astrophysical Observation", "SAO 39047"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.47908790),
        dec: Angle.Degrees(+43.51446532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184695"},
        {"Hipparcos Number", "HIP 96207"},
        {"Smithsonian Astrophysical Observation", "SAO 48588"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.44638432),
        dec: Angle.Degrees(+43.51732533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9525",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9525"},
        {"Smithsonian Astrophysical Observation", "SAO 37724"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.62767121),
        dec: Angle.Degrees(+43.51762168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14606"},
        {"Hipparcos Number", "HIP 11092"},
        {"Smithsonian Astrophysical Observation", "SAO 37984"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.71050335),
        dec: Angle.Degrees(+43.51771341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182862"},
        {"Hipparcos Number", "HIP 95438"},
        {"Geneva Identification System", "GEN# +1.00182862"},
        {"Smithsonian Astrophysical Observation", "SAO 48413"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.20289911),
        dec: Angle.Degrees(+43.52184340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195254"},
        {"Hipparcos Number", "HIP 100989"},
        {"Geneva Identification System", "GEN# +1.00195254"},
        {"Smithsonian Astrophysical Observation", "SAO 49672"},
    },
    visualMagnitude: 7.69,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.12808126),
        dec: Angle.Degrees(+43.52318021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6585"},
        {"Hipparcos Number", "HIP 5269"},
        {"Geneva Identification System", "GEN# +1.00006585"},
        {"Smithsonian Astrophysical Observation", "SAO 36940"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.83803079),
        dec: Angle.Degrees(+43.52358173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54211",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54211"},
        {"Cincinnati Publication", "Ci 20 606"},
        {"Cincinnati Publication 2", "Ci 18 1349"},
        {"Fundamental Katalog 5th Edition", "FK5 4979"},
        {"Geneva Identification System", "GEN# +0.04402051A"},
        {"Smithsonian Astrophysical Observation", "SAO 43609"},
        {"Wilson Evans Batten Catalogue", "WEB 9800"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.38385827),
        dec: Angle.Degrees(+43.52448449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4410.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 943.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11201"},
        {"Hipparcos Number", "HIP 8615"},
        {"Smithsonian Astrophysical Observation", "SAO 37557"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.78084032),
        dec: Angle.Degrees(+43.52523452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111101",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111101"},
        {"Smithsonian Astrophysical Observation", "SAO 52078"},
    },
    visualMagnitude: 9.28,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.61230193),
        dec: Angle.Degrees(+43.52727237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110768",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15938 AB"},
        {"Hipparcos Number", "HIP 110768"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.61734782),
        dec: Angle.Degrees(+43.52747260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210682"},
        {"Hipparcos Number", "HIP 109522"},
        {"Smithsonian Astrophysical Observation", "SAO 51737"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.79016841),
        dec: Angle.Degrees(+43.52762242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216684"},
        {"Hipparcos Number", "HIP 113110"},
        {"Geneva Identification System", "GEN# +1.00216684"},
        {"Smithsonian Astrophysical Observation", "SAO 52475"},
    },
    visualMagnitude: 7.77,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.58838323),
        dec: Angle.Degrees(+43.52852631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64450",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64450"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.15467703),
        dec: Angle.Degrees(+43.53163746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 108.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110766",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15938 C"},
        {"Hipparcos Number", "HIP 110766"},
        {"Smithsonian Astrophysical Observation", "SAO 51997"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.60549403),
        dec: Angle.Degrees(+43.53619608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84763"},
        {"Hipparcos Number", "HIP 48115"},
        {"Geneva Identification System", "GEN# +1.00084763"},
        {"Smithsonian Astrophysical Observation", "SAO 43047"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.14769448),
        dec: Angle.Degrees(+43.53657051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16855"},
        {"Hipparcos Number", "HIP 12725"},
        {"Geneva Identification System", "GEN# +1.00016855"},
        {"Renson", "Renson 4270"},
        {"Smithsonian Astrophysical Observation", "SAO 38285"},
        {"Wilson Evans Batten Catalogue", "WEB 2588"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.89714063),
        dec: Angle.Degrees(+43.53802547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88312"},
        {"Hipparcos Number", "HIP 49963"},
        {"Smithsonian Astrophysical Observation", "SAO 43230"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.00911091),
        dec: Angle.Degrees(+43.53832988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133230"},
        {"Hipparcos Number", "HIP 73549"},
        {"Geneva Identification System", "GEN# +1.00133230"},
        {"Smithsonian Astrophysical Observation", "SAO 45339"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.47511658),
        dec: Angle.Degrees(+43.54173744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218804"},
        {"Hipparcos Number", "HIP 114430"},
        {"Fundamental Katalog 5th Edition", "FK5 3857"},
        {"Geneva Identification System", "GEN# +1.00218804"},
        {"Smithsonian Astrophysical Observation", "SAO 52761"},
        {"Wilson Evans Batten Catalogue", "WEB 20313"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.61401487),
        dec: Angle.Degrees(+43.54473662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -202.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80847",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10091 AB"},
        {"Henry Draper", "HD 149082"},
        {"Hipparcos Number", "HIP 80847"},
        {"Smithsonian Astrophysical Observation", "SAO 46131"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.65387704),
        dec: Angle.Degrees(+43.54528099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114577",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114577"},
        {"Smithsonian Astrophysical Observation", "SAO 52788"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.16173703),
        dec: Angle.Degrees(+43.54713900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44612"},
        {"Hipparcos Number", "HIP 30507"},
        {"Smithsonian Astrophysical Observation", "SAO 41080"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.19418519),
        dec: Angle.Degrees(+43.54852895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212513"},
        {"Hipparcos Number", "HIP 110572"},
        {"Smithsonian Astrophysical Observation", "SAO 51962"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.99742984),
        dec: Angle.Degrees(+43.54967740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173109"},
        {"Hipparcos Number", "HIP 91666"},
        {"Geneva Identification System", "GEN# +1.00173109"},
        {"Smithsonian Astrophysical Observation", "SAO 47709"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.39582237),
        dec: Angle.Degrees(+43.54970768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58986"},
        {"Hipparcos Number", "HIP 36446"},
        {"Geneva Identification System", "GEN# +1.00058986"},
        {"Smithsonian Astrophysical Observation", "SAO 41811"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.50190074),
        dec: Angle.Degrees(+43.55095406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225217"},
        {"Hipparcos Number", "HIP 363"},
        {"Wilson Evans Batten Catalogue", "WEB 52"},
    },
    visualMagnitude: 8.12,
    bvColour: 2.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.15170942),
        dec: Angle.Degrees(+43.55131855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113228",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113228"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.94858626),
        dec: Angle.Degrees(+43.55163624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63179",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8713 A"},
        {"Henry Draper", "HD 112501"},
        {"Hipparcos Number", "HIP 63179"},
        {"Fundamental Katalog 5th Edition", "FK5 3034"},
        {"Geneva Identification System", "GEN# +1.00112501J"},
        {"Renson", "Renson 32710"},
        {"Smithsonian Astrophysical Observation", "SAO 44395"},
        {"Wilson Evans Batten Catalogue", "WEB 11199"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.16171812),
        dec: Angle.Degrees(+43.55201038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219735"},
        {"Hipparcos Number", "HIP 115027"},
        {"Geneva Identification System", "GEN# +1.00219735"},
        {"Smithsonian Astrophysical Observation", "SAO 52872"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.46101102),
        dec: Angle.Degrees(+43.55338362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125274"},
        {"Hipparcos Number", "HIP 69805"},
        {"Smithsonian Astrophysical Observation", "SAO 44972"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.29448837),
        dec: Angle.Degrees(+43.55519627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181778"},
        {"Hipparcos Number", "HIP 94998"},
        {"Smithsonian Astrophysical Observation", "SAO 48341"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.95923953),
        dec: Angle.Degrees(+43.55626285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37937"},
        {"Hipparcos Number", "HIP 27057"},
        {"Geneva Identification System", "GEN# +1.00037937"},
        {"Smithsonian Astrophysical Observation", "SAO 40570"},
        {"Wilson Evans Batten Catalogue", "WEB 5325"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.07128385),
        dec: Angle.Degrees(+43.55637095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22351"},
        {"Hipparcos Number", "HIP 16912"},
        {"Geneva Identification System", "GEN# +1.00022351"},
        {"Smithsonian Astrophysical Observation", "SAO 38993"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.40935423),
        dec: Angle.Degrees(+43.55819453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159206"},
        {"Hipparcos Number", "HIP 85736"},
        {"Smithsonian Astrophysical Observation", "SAO 46771"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.80522921),
        dec: Angle.Degrees(+43.55872610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122651"},
        {"Hipparcos Number", "HIP 68560"},
        {"Geneva Identification System", "GEN# +1.00122651"},
        {"Smithsonian Astrophysical Observation", "SAO 44856"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.53034199),
        dec: Angle.Degrees(+43.55909397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216851"},
        {"Hipparcos Number", "HIP 113226"},
        {"Geneva Identification System", "GEN# +1.00216851"},
        {"Smithsonian Astrophysical Observation", "SAO 52497"},
        {"Wilson Evans Batten Catalogue", "WEB 20150"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.94610210),
        dec: Angle.Degrees(+43.55929984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174020"},
        {"Hipparcos Number", "HIP 92116"},
        {"Smithsonian Astrophysical Observation", "SAO 47790"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.61709757),
        dec: Angle.Degrees(+43.56083036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105925"},
        {"Hipparcos Number", "HIP 59428"},
        {"Smithsonian Astrophysical Observation", "SAO 44069"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.85552617),
        dec: Angle.Degrees(+43.56103498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -322.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223174"},
        {"Hipparcos Number", "HIP 117309"},
        {"Smithsonian Astrophysical Observation", "SAO 53370"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.80113362),
        dec: Angle.Degrees(+43.56124643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55647"},
        {"Hipparcos Number", "HIP 35145"},
        {"Geneva Identification System", "GEN# +1.00055647"},
        {"Smithsonian Astrophysical Observation", "SAO 41652"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.97677225),
        dec: Angle.Degrees(+43.56201647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150203"},
        {"Hipparcos Number", "HIP 81401"},
        {"Fundamental Katalog 5th Edition", "FK5 5471"},
        {"Geneva Identification System", "GEN# +1.00150203"},
        {"Smithsonian Astrophysical Observation", "SAO 46196"},
        {"Wilson Evans Batten Catalogue", "WEB 13756"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.37568977),
        dec: Angle.Degrees(+43.56469209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107156",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107156"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.58435916),
        dec: Angle.Degrees(+43.56758636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89682",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11249 AB"},
        {"Hipparcos Number", "HIP 89682"},
        {"Smithsonian Astrophysical Observation", "SAO 47367"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.53083507),
        dec: Angle.Degrees(+43.56968234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18781"},
        {"Hipparcos Number", "HIP 14178"},
        {"Smithsonian Astrophysical Observation", "SAO 38528"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.70656606),
        dec: Angle.Degrees(+43.57282421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37162",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37162"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.55359521),
        dec: Angle.Degrees(+43.57364682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49489",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49489"},
        {"Smithsonian Astrophysical Observation", "SAO 43184"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.55330815),
        dec: Angle.Degrees(+43.57403138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22658",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22658"},
    },
    visualMagnitude: 11.60,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.10741679),
        dec: Angle.Degrees(+43.57541472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32480",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5425 A"},
        {"Henry Draper", "HD 48682"},
        {"Henry Draper 2", "HD 48682A"},
        {"Hipparcos Number", "HIP 32480"},
        {"Fundamental Katalog 5th Edition", "FK5 255"},
        {"Geneva Identification System", "GEN# +1.00048682A"},
        {"Smithsonian Astrophysical Observation", "SAO 41330"},
        {"Wilson Evans Batten Catalogue", "WEB 6548"},
    },
    visualMagnitude: 5.24,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.68474593),
        dec: Angle.Degrees(+43.57702483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 165.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10196",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10196"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.78343403),
        dec: Angle.Degrees(+43.57712026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99995"},
        {"Hipparcos Number", "HIP 56145"},
        {"Geneva Identification System", "GEN# +1.00099995"},
        {"Smithsonian Astrophysical Observation", "SAO 43786"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.61943662),
        dec: Angle.Degrees(+43.57831691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -270.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14536"},
        {"Hipparcos Number", "HIP 11037"},
        {"Smithsonian Astrophysical Observation", "SAO 37977"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.52888817),
        dec: Angle.Degrees(+43.57854500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94424"},
        {"Hipparcos Number", "HIP 53349"},
        {"Smithsonian Astrophysical Observation", "SAO 43520"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.65822478),
        dec: Angle.Degrees(+43.58301701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8209"},
        {"Hipparcos Number", "HIP 6401"},
        {"Geneva Identification System", "GEN# +1.00008209"},
        {"Smithsonian Astrophysical Observation", "SAO 37154"},
        {"Wilson Evans Batten Catalogue", "WEB 1416"},
    },
    visualMagnitude: 6.69,
    bvColour: -0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.55243914),
        dec: Angle.Degrees(+43.58413462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75949"},
        {"Hipparcos Number", "HIP 43753"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.68490068),
        dec: Angle.Degrees(+43.58503923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50743",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50743"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.42716047),
        dec: Angle.Degrees(+43.58751005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100364",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13753 B"},
        {"Hipparcos Number", "HIP 100364"},
    },
    visualMagnitude: 8.40,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)21, 15.4900),
        dec: Angle.DegreesMinutesSeconds((int)+43, (int)35, 15.800)
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
    primaryId: "HIP 45054",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45054"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.64382078),
        dec: Angle.Degrees(+43.93258903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100360",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13753 A"},
        {"Henry Draper", "HD 193926"},
        {"Hipparcos Number", "HIP 100360"},
        {"Celescope Catalog", "CEL 5037"},
        {"Geneva Identification System", "GEN# +1.00193926"},
        {"Smithsonian Astrophysical Observation", "SAO 49510"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.30838829),
        dec: Angle.Degrees(+43.58922746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39553"},
        {"Hipparcos Number", "HIP 28012"},
        {"Smithsonian Astrophysical Observation", "SAO 40699"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.88006141),
        dec: Angle.Degrees(+43.59218627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200754"},
        {"Hipparcos Number", "HIP 103973"},
        {"Smithsonian Astrophysical Observation", "SAO 50412"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.99632575),
        dec: Angle.Degrees(+43.59256136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1302",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 215 A"},
        {"Henry Draper", "HD 1185"},
        {"Hipparcos Number", "HIP 1302"},
        {"Geneva Identification System", "GEN# +1.00001185A"},
        {"Renson", "Renson 240"},
        {"Smithsonian Astrophysical Observation", "SAO 36221"},
        {"Wilson Evans Batten Catalogue", "WEB 231"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.08958566),
        dec: Angle.Degrees(+43.59510616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21574",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21574"},
    },
    visualMagnitude: 10.52,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.49379444),
        dec: Angle.Degrees(+43.59513419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16027"},
        {"Hipparcos Number", "HIP 12082"},
        {"Smithsonian Astrophysical Observation", "SAO 38152"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.93142521),
        dec: Angle.Degrees(+43.59872345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116608"},
        {"Hipparcos Number", "HIP 65380"},
        {"Geneva Identification System", "GEN# +1.00116608"},
        {"Smithsonian Astrophysical Observation", "SAO 44595"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.98751252),
        dec: Angle.Degrees(+43.59877869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160486"},
        {"Hipparcos Number", "HIP 86301"},
        {"Geneva Identification System", "GEN# +1.00160486"},
        {"Smithsonian Astrophysical Observation", "SAO 46854"},
        {"Wilson Evans Batten Catalogue", "WEB 14563"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.51428245),
        dec: Angle.Degrees(+43.59893065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 276315"},
        {"Hipparcos Number", "HIP 20575"},
        {"Smithsonian Astrophysical Observation", "SAO 39508"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.11446643),
        dec: Angle.Degrees(+43.59893301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27258"},
        {"Hipparcos Number", "HIP 20238"},
        {"Smithsonian Astrophysical Observation", "SAO 39467"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.05607071),
        dec: Angle.Degrees(+43.59973221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64777",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64777"},
        {"Geneva Identification System", "GEN# +0.04402263"},
    },
    visualMagnitude: 10.03,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.12975069),
        dec: Angle.Degrees(+43.60151306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139780"},
        {"Hipparcos Number", "HIP 76579"},
        {"Geneva Identification System", "GEN# +1.00139780"},
        {"Smithsonian Astrophysical Observation", "SAO 45651"},
        {"Wilson Evans Batten Catalogue", "WEB 12999"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.59483512),
        dec: Angle.Degrees(+43.60424959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189727"},
        {"Hipparcos Number", "HIP 98407"},
        {"Smithsonian Astrophysical Observation", "SAO 49062"},
    },
    visualMagnitude: 8.56,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.92392257),
        dec: Angle.Degrees(+43.60450070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80714"},
        {"Hipparcos Number", "HIP 45979"},
        {"Smithsonian Astrophysical Observation", "SAO 42828"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.64555373),
        dec: Angle.Degrees(+43.60499774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33250"},
        {"Hipparcos Number", "HIP 24140"},
        {"Smithsonian Astrophysical Observation", "SAO 40083"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.76400021),
        dec: Angle.Degrees(+43.60583428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107286"},
        {"Hipparcos Number", "HIP 60140"},
        {"Geneva Identification System", "GEN# +1.00107286"},
        {"Smithsonian Astrophysical Observation", "SAO 44129"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.99418724),
        dec: Angle.Degrees(+43.60886514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157010"},
        {"Hipparcos Number", "HIP 84680"},
        {"Smithsonian Astrophysical Observation", "SAO 46630"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.67248113),
        dec: Angle.Degrees(+43.60917087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144657"},
        {"Hipparcos Number", "HIP 78796"},
        {"Smithsonian Astrophysical Observation", "SAO 45882"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.29002438),
        dec: Angle.Degrees(+43.61281240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
