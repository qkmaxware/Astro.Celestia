using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_52() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193147"},
        {"Hipparcos Number", "HIP 100168"},
        {"Smithsonian Astrophysical Observation", "SAO 163442"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.77059727),
        dec: Angle.Degrees(-10.80002592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95527",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95527"},
        {"Smithsonian Astrophysical Observation", "SAO 162605"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.47359343),
        dec: Angle.Degrees(-10.79917633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78332",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78332"},
        {"Smithsonian Astrophysical Observation", "SAO 159623"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.92192818),
        dec: Angle.Degrees(-10.79904977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98059",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98059"},
        {"Smithsonian Astrophysical Observation", "SAO 163111"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.92204679),
        dec: Angle.Degrees(-10.79883867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148767"},
        {"Hipparcos Number", "HIP 80869"},
        {"Smithsonian Astrophysical Observation", "SAO 159962"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.69889927),
        dec: Angle.Degrees(-10.79826059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107311"},
        {"Hipparcos Number", "HIP 60160"},
        {"Smithsonian Astrophysical Observation", "SAO 157219"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.05481015),
        dec: Angle.Degrees(-10.79605214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91442"},
        {"Hipparcos Number", "HIP 51674"},
        {"Smithsonian Astrophysical Observation", "SAO 156060"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.35247818),
        dec: Angle.Degrees(-10.79595684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90804",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11414 A"},
        {"Henry Draper", "HD 170740"},
        {"Hipparcos Number", "HIP 90804"},
        {"Smithsonian Astrophysical Observation", "SAO 161569"},
        {"Wilson Evans Batten Catalogue", "WEB 15563"},
    },
    visualMagnitude: 5.77,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.85705350),
        dec: Angle.Degrees(-10.79579343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16679",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2626 AB"},
        {"Henry Draper", "HD 22244"},
        {"Hipparcos Number", "HIP 16679"},
        {"Smithsonian Astrophysical Observation", "SAO 149048"},
    },
    visualMagnitude: 8.84,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.65758250),
        dec: Angle.Degrees(-10.79485113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160914"},
        {"Hipparcos Number", "HIP 86702"},
        {"Smithsonian Astrophysical Observation", "SAO 160772"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.72865649),
        dec: Angle.Degrees(-10.79475496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16925"},
        {"Hipparcos Number", "HIP 12650"},
        {"Smithsonian Astrophysical Observation", "SAO 148562"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.62613450),
        dec: Angle.Degrees(-10.79334853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110192",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110192"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.81321039),
        dec: Angle.Degrees(-10.79226811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224161"},
        {"Hipparcos Number", "HIP 117964"},
        {"Geneva Identification System", "GEN# +1.00224161"},
        {"Smithsonian Astrophysical Observation", "SAO 165955"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.90818828),
        dec: Angle.Degrees(-10.79090016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211719"},
        {"Hipparcos Number", "HIP 110193"},
        {"Smithsonian Astrophysical Observation", "SAO 164997"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.82374217),
        dec: Angle.Degrees(-10.79029253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67650"},
        {"Hipparcos Number", "HIP 39877"},
        {"Geneva Identification System", "GEN# +1.00067650"},
        {"Wilson Evans Batten Catalogue", "WEB 7773"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.18126332),
        dec: Angle.Degrees(-10.78960517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120205"},
        {"Hipparcos Number", "HIP 67344"},
        {"Geneva Identification System", "GEN# +1.00120205"},
        {"Smithsonian Astrophysical Observation", "SAO 158174"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.04254025),
        dec: Angle.Degrees(-10.78873881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -257.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146878"},
        {"Hipparcos Number", "HIP 79928"},
        {"Geneva Identification System", "GEN# +1.00146878"},
        {"Smithsonian Astrophysical Observation", "SAO 159845"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.70659953),
        dec: Angle.Degrees(-10.78606157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51700"},
        {"Hipparcos Number", "HIP 33515"},
        {"Smithsonian Astrophysical Observation", "SAO 152171"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.49585865),
        dec: Angle.Degrees(-10.78591706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28970"},
        {"Hipparcos Number", "HIP 21239"},
        {"Geneva Identification System", "GEN# +1.00028970"},
        {"Smithsonian Astrophysical Observation", "SAO 149725"},
    },
    visualMagnitude: 6.06,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.34202729),
        dec: Angle.Degrees(-10.78540651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51978"},
        {"Hipparcos Number", "HIP 33620"},
        {"Celescope Catalog", "CEL 1474"},
        {"Geneva Identification System", "GEN# +1.00051978J"},
        {"Smithsonian Astrophysical Observation", "SAO 152197"},
    },
    visualMagnitude: 8.33,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.77781004),
        dec: Angle.Degrees(-10.78425944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151769"},
        {"Hipparcos Number", "HIP 82369"},
        {"Fundamental Katalog 5th Edition", "FK5 1438"},
        {"Geneva Identification System", "GEN# +1.00151769"},
        {"Smithsonian Astrophysical Observation", "SAO 160118"},
        {"Wilson Evans Batten Catalogue", "WEB 13906"},
    },
    visualMagnitude: 4.64,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.45822137),
        dec: Angle.Degrees(-10.78280069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189624"},
        {"Hipparcos Number", "HIP 98564"},
        {"Smithsonian Astrophysical Observation", "SAO 163188"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.31416437),
        dec: Angle.Degrees(-10.78111907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206250"},
        {"Hipparcos Number", "HIP 107071"},
        {"Geneva Identification System", "GEN# +1.00206250"},
        {"Smithsonian Astrophysical Observation", "SAO 164576"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.28056599),
        dec: Angle.Degrees(-10.78075061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139"},
        {"Hipparcos Number", "HIP 520"},
        {"Smithsonian Astrophysical Observation", "SAO 147081"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.57055075),
        dec: Angle.Degrees(-10.77847003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14691"},
        {"Hipparcos Number", "HIP 11029"},
        {"Geneva Identification System", "GEN# +1.00014691"},
        {"Smithsonian Astrophysical Observation", "SAO 148354"},
        {"Wilson Evans Batten Catalogue", "WEB 2319"},
    },
    visualMagnitude: 5.43,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.50600237),
        dec: Angle.Degrees(-10.77733458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 153.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23416"},
        {"Hipparcos Number", "HIP 17478"},
        {"Geneva Identification System", "GEN# +1.00023416"},
        {"Smithsonian Astrophysical Observation", "SAO 149140"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.17757028),
        dec: Angle.Degrees(-10.77642630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121630"},
        {"Hipparcos Number", "HIP 68123"},
        {"Smithsonian Astrophysical Observation", "SAO 158250"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.19838617),
        dec: Angle.Degrees(-10.77411156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42565"},
        {"Hipparcos Number", "HIP 29324"},
        {"Smithsonian Astrophysical Observation", "SAO 151195"},
    },
    visualMagnitude: 8.74,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.75652378),
        dec: Angle.Degrees(-10.77333898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50345",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7709 AB"},
        {"Henry Draper", "HD 89130"},
        {"Hipparcos Number", "HIP 50345"},
        {"Smithsonian Astrophysical Observation", "SAO 155865"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.19853250),
        dec: Angle.Degrees(-10.77283155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101970"},
        {"Hipparcos Number", "HIP 57229"},
        {"Smithsonian Astrophysical Observation", "SAO 156861"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.01506431),
        dec: Angle.Degrees(-10.77269796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10767"},
        {"Hipparcos Number", "HIP 8174"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.27732086),
        dec: Angle.Degrees(-10.77209931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65225"},
        {"Hipparcos Number", "HIP 38883"},
        {"Smithsonian Astrophysical Observation", "SAO 153627"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.35598520),
        dec: Angle.Degrees(-10.77060360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83731"},
        {"Hipparcos Number", "HIP 47454"},
        {"Geneva Identification System", "GEN# +1.00083731"},
        {"Smithsonian Astrophysical Observation", "SAO 155387"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.08364165),
        dec: Angle.Degrees(-10.76918307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38454"},
        {"Hipparcos Number", "HIP 27166"},
        {"Smithsonian Astrophysical Observation", "SAO 150772"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.37421127),
        dec: Angle.Degrees(-10.76644780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220339"},
        {"Hipparcos Number", "HIP 115445"},
        {"Cincinnati Publication", "Ci 20 1422"},
        {"Geneva Identification System", "GEN# +1.00220339"},
        {"Smithsonian Astrophysical Observation", "SAO 165664"},
        {"Wilson Evans Batten Catalogue", "WEB 20441"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.76927866),
        dec: Angle.Degrees(-10.76487639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 451.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 260.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97650",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13017 A"},
        {"Henry Draper", "HD 187532"},
        {"Hipparcos Number", "HIP 97650"},
        {"Fundamental Katalog 5th Edition", "FK5 744"},
        {"Geneva Identification System", "GEN# +1.00187532"},
        {"Smithsonian Astrophysical Observation", "SAO 163036"},
        {"Wilson Evans Batten Catalogue", "WEB 17172"},
    },
    visualMagnitude: 5.38,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.69501255),
        dec: Angle.Degrees(-10.76358902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201334"},
        {"Hipparcos Number", "HIP 104427"},
        {"Geneva Identification System", "GEN# +1.00201334"},
        {"Smithsonian Astrophysical Observation", "SAO 164176"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.31044954),
        dec: Angle.Degrees(-10.76225043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35685"},
        {"Hipparcos Number", "HIP 25404"},
        {"Geneva Identification System", "GEN# +1.00035685"},
        {"Smithsonian Astrophysical Observation", "SAO 150437"},
    },
    visualMagnitude: 7.28,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.51747832),
        dec: Angle.Degrees(-10.75774496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37972",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37972"},
    },
    visualMagnitude: 11.66,
    bvColour: 1.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.74908686),
        dec: Angle.Degrees(-10.75735747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78612"},
        {"Hipparcos Number", "HIP 44896"},
        {"Geneva Identification System", "GEN# +1.00078612"},
        {"Smithsonian Astrophysical Observation", "SAO 154945"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.20832224),
        dec: Angle.Degrees(-10.75724158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -354.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58529"},
        {"Hipparcos Number", "HIP 36040"},
        {"Smithsonian Astrophysical Observation", "SAO 152851"},
        {"Wilson Evans Batten Catalogue", "WEB 7179"},
    },
    visualMagnitude: 9.56,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.41074916),
        dec: Angle.Degrees(-10.75670189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152393"},
        {"Hipparcos Number", "HIP 82642"},
        {"Smithsonian Astrophysical Observation", "SAO 160148"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.39160381),
        dec: Angle.Degrees(-10.75339028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19148"},
        {"Hipparcos Number", "HIP 14301"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.10782925),
        dec: Angle.Degrees(-10.75298722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104638"},
        {"Hipparcos Number", "HIP 58751"},
        {"Geneva Identification System", "GEN# +1.00104638"},
        {"Smithsonian Astrophysical Observation", "SAO 157061"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.74922983),
        dec: Angle.Degrees(-10.75234847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125963"},
        {"Hipparcos Number", "HIP 70294"},
        {"Smithsonian Astrophysical Observation", "SAO 158523"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.73419615),
        dec: Angle.Degrees(-10.75069454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48352"},
        {"Hipparcos Number", "HIP 32131"},
        {"Smithsonian Astrophysical Observation", "SAO 151818"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.65439150),
        dec: Angle.Degrees(-10.74961325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70499"},
        {"Hipparcos Number", "HIP 40993"},
        {"Geneva Identification System", "GEN# +1.00070499"},
        {"Smithsonian Astrophysical Observation", "SAO 154158"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.48747304),
        dec: Angle.Degrees(-10.74813418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45955"},
        {"Hipparcos Number", "HIP 30980"},
        {"Geneva Identification System", "GEN# +1.00045955"},
        {"Smithsonian Astrophysical Observation", "SAO 151571"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.53121929),
        dec: Angle.Degrees(-10.74797536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8940",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8940"},
        {"Smithsonian Astrophysical Observation", "SAO 148102"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.78607770),
        dec: Angle.Degrees(-10.74635726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71032"},
        {"Hipparcos Number", "HIP 41229"},
        {"Smithsonian Astrophysical Observation", "SAO 154223"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.20161096),
        dec: Angle.Degrees(-10.74525371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84768"},
        {"Hipparcos Number", "HIP 48007"},
        {"Geneva Identification System", "GEN# +1.00084768"},
        {"Smithsonian Astrophysical Observation", "SAO 155476"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.79273053),
        dec: Angle.Degrees(-10.74381124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5385"},
        {"Hipparcos Number", "HIP 4335"},
        {"Smithsonian Astrophysical Observation", "SAO 147513"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.88812791),
        dec: Angle.Degrees(-10.74254514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197330"},
        {"Hipparcos Number", "HIP 102266"},
        {"Smithsonian Astrophysical Observation", "SAO 163823"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.81777237),
        dec: Angle.Degrees(-10.74215757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114038"},
        {"Hipparcos Number", "HIP 64078"},
        {"Geneva Identification System", "GEN# +1.00114038"},
        {"Smithsonian Astrophysical Observation", "SAO 157739"},
        {"Wilson Evans Batten Catalogue", "WEB 11326"},
    },
    visualMagnitude: 5.15,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.97417871),
        dec: Angle.Degrees(-10.74038528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105281"},
        {"Hipparcos Number", "HIP 59118"},
        {"Geneva Identification System", "GEN# +1.00105281"},
        {"Renson", "Renson 30440"},
        {"Smithsonian Astrophysical Observation", "SAO 157090"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.84186396),
        dec: Angle.Degrees(-10.73952194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8456"},
        {"Hipparcos Number", "HIP 6510"},
        {"Smithsonian Astrophysical Observation", "SAO 147781"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.90499220),
        dec: Angle.Degrees(-10.73852557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62550"},
        {"Hipparcos Number", "HIP 37717"},
        {"Smithsonian Astrophysical Observation", "SAO 153323"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.05162968),
        dec: Angle.Degrees(-10.73771504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136481"},
        {"Hipparcos Number", "HIP 75136"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.32206646),
        dec: Angle.Degrees(-10.73444190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26670",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26670"},
        {"Smithsonian Astrophysical Observation", "SAO 150664"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.02096389),
        dec: Angle.Degrees(-10.73216978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166734"},
        {"Hipparcos Number", "HIP 89218"},
        {"Geneva Identification System", "GEN# +1.00166734"},
        {"Smithsonian Astrophysical Observation", "SAO 161182"},
        {"Wilson Evans Batten Catalogue", "WEB 15162"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.10273434),
        dec: Angle.Degrees(-10.73140403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122679"},
        {"Hipparcos Number", "HIP 68679"},
        {"Smithsonian Astrophysical Observation", "SAO 158313"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.88048649),
        dec: Angle.Degrees(-10.73124477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5055"},
        {"Hipparcos Number", "HIP 4078"},
        {"Smithsonian Astrophysical Observation", "SAO 147491"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.07493435),
        dec: Angle.Degrees(-10.73046574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3008"},
        {"Hipparcos Number", "HIP 2618"},
        {"Geneva Identification System", "GEN# +1.00003008"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.30959029),
        dec: Angle.Degrees(-10.72851654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79219"},
        {"Hipparcos Number", "HIP 45188"},
        {"Smithsonian Astrophysical Observation", "SAO 154996"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.11903631),
        dec: Angle.Degrees(-10.72764748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87214"},
        {"Hipparcos Number", "HIP 49260"},
        {"Smithsonian Astrophysical Observation", "SAO 155691"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.83762881),
        dec: Angle.Degrees(-10.72748048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190389"},
        {"Hipparcos Number", "HIP 98904"},
        {"Smithsonian Astrophysical Observation", "SAO 163243"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.26313545),
        dec: Angle.Degrees(-10.72601162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171919"},
        {"Hipparcos Number", "HIP 91331"},
        {"Smithsonian Astrophysical Observation", "SAO 161682"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.42509113),
        dec: Angle.Degrees(-10.72595698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71781",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71781"},
        {"Smithsonian Astrophysical Observation", "SAO 158729"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.25175001),
        dec: Angle.Degrees(-10.72595146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187353"},
        {"Hipparcos Number", "HIP 97568"},
        {"Geneva Identification System", "GEN# +1.00187353"},
        {"Smithsonian Astrophysical Observation", "SAO 163022"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.46290763),
        dec: Angle.Degrees(-10.72505394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43760"},
        {"Hipparcos Number", "HIP 29885"},
        {"Geneva Identification System", "GEN# +1.00043760"},
        {"Renson", "Renson 11600"},
        {"Smithsonian Astrophysical Observation", "SAO 151318"},
        {"Wilson Evans Batten Catalogue", "WEB 5918"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.39637039),
        dec: Angle.Degrees(-10.72499517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44219"},
        {"Hipparcos Number", "HIP 30114"},
        {"Geneva Identification System", "GEN# +1.00044219"},
        {"Smithsonian Astrophysical Observation", "SAO 151367"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.05950169),
        dec: Angle.Degrees(-10.72496962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103721"},
        {"Hipparcos Number", "HIP 58248"},
        {"Geneva Identification System", "GEN# +1.00103721"},
        {"Smithsonian Astrophysical Observation", "SAO 157001"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.18967371),
        dec: Angle.Degrees(-10.72448962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141717"},
        {"Hipparcos Number", "HIP 77621"},
        {"Geneva Identification System", "GEN# +1.00141717"},
        {"Smithsonian Astrophysical Observation", "SAO 159533"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.70049712),
        dec: Angle.Degrees(-10.72198671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176853"},
        {"Hipparcos Number", "HIP 93502"},
        {"Celescope Catalog", "CEL 4691"},
        {"Fundamental Katalog 5th Edition", "FK5 3520"},
        {"Geneva Identification System", "GEN# +1.00176853"},
        {"Smithsonian Astrophysical Observation", "SAO 162122"},
        {"Wilson Evans Batten Catalogue", "WEB 16232"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.64225756),
        dec: Angle.Degrees(-10.72174487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6524",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6524"},
        {"Smithsonian Astrophysical Observation", "SAO 147783"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.94859281),
        dec: Angle.Degrees(-10.72097321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58605"},
        {"Hipparcos Number", "HIP 36070"},
        {"Geneva Identification System", "GEN# +1.00058605"},
        {"Smithsonian Astrophysical Observation", "SAO 152855"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.48501438),
        dec: Angle.Degrees(-10.71801311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191822"},
        {"Hipparcos Number", "HIP 99543"},
        {"Smithsonian Astrophysical Observation", "SAO 163330"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.02313554),
        dec: Angle.Degrees(-10.71587396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199704"},
        {"Hipparcos Number", "HIP 103581"},
        {"Smithsonian Astrophysical Observation", "SAO 164037"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.81022818),
        dec: Angle.Degrees(-10.71368450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104576"},
        {"Hipparcos Number", "HIP 58722"},
        {"Smithsonian Astrophysical Observation", "SAO 157055"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.66431325),
        dec: Angle.Degrees(-10.71359488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52634",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7917 AB"},
        {"Henry Draper", "HD 93226"},
        {"Hipparcos Number", "HIP 52634"},
        {"Renson", "Renson 26920"},
        {"Smithsonian Astrophysical Observation", "SAO 156202"},
    },
    visualMagnitude: 7.45,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.45094762),
        dec: Angle.Degrees(-10.71355748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197858"},
        {"Hipparcos Number", "HIP 102527"},
        {"Smithsonian Astrophysical Observation", "SAO 163871"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.65625693),
        dec: Angle.Degrees(-10.71349801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26962",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26962"},
        {"Smithsonian Astrophysical Observation", "SAO 150737"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.82592150),
        dec: Angle.Degrees(-10.71225852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83651"},
        {"Hipparcos Number", "HIP 47423"},
        {"Smithsonian Astrophysical Observation", "SAO 155376"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.94107948),
        dec: Angle.Degrees(-10.71220739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117320"},
        {"Hipparcos Number", "HIP 65821"},
        {"Geneva Identification System", "GEN# +1.00117320"},
        {"Smithsonian Astrophysical Observation", "SAO 157963"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.39965268),
        dec: Angle.Degrees(-10.71193958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105870"},
        {"Hipparcos Number", "HIP 59403"},
        {"Smithsonian Astrophysical Observation", "SAO 157130"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.78958784),
        dec: Angle.Degrees(-10.70738792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17231"},
        {"Hipparcos Number", "HIP 12882"},
        {"Smithsonian Astrophysical Observation", "SAO 148588"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.39877218),
        dec: Angle.Degrees(-10.70426351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176633"},
        {"Hipparcos Number", "HIP 93421"},
        {"Smithsonian Astrophysical Observation", "SAO 162099"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.39979128),
        dec: Angle.Degrees(-10.70409383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11131"},
        {"Hipparcos Number", "HIP 8486"},
        {"Geneva Identification System", "GEN# +1.00011131"},
        {"Smithsonian Astrophysical Observation", "SAO 148033"},
        {"Wilson Evans Batten Catalogue", "WEB 1802"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.34762392),
        dec: Angle.Degrees(-10.70331596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171052"},
        {"Hipparcos Number", "HIP 90943"},
        {"Fundamental Katalog 5th Edition", "FK5 5629"},
        {"Geneva Identification System", "GEN# +1.00171052"},
        {"Smithsonian Astrophysical Observation", "SAO 161594"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.26637525),
        dec: Angle.Degrees(-10.70329764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182040"},
        {"Hipparcos Number", "HIP 95289"},
        {"Geneva Identification System", "GEN# +1.00182040"},
        {"Smithsonian Astrophysical Observation", "SAO 162551"},
        {"Wilson Evans Batten Catalogue", "WEB 16652"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.79197196),
        dec: Angle.Degrees(-10.70321065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86638"},
        {"Hipparcos Number", "HIP 48983"},
        {"Smithsonian Astrophysical Observation", "SAO 155639"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.90465740),
        dec: Angle.Degrees(-10.70180491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23065"},
        {"Hipparcos Number", "HIP 17265"},
        {"Cincinnati Publication", "Ci 20 252"},
        {"Cincinnati Publication 2", "Ci 18 495"},
        {"Geneva Identification System", "GEN# +1.00023065"},
        {"Smithsonian Astrophysical Observation", "SAO 149118"},
        {"Wilson Evans Batten Catalogue", "WEB 3266"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.46580826),
        dec: Angle.Degrees(-10.69721737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 302.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -261.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156971"},
        {"Hipparcos Number", "HIP 84883"},
        {"Geneva Identification System", "GEN# +1.00156971"},
        {"Smithsonian Astrophysical Observation", "SAO 160482"},
        {"Wilson Evans Batten Catalogue", "WEB 14335"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.21916423),
        dec: Angle.Degrees(-10.69635486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29649"},
        {"Hipparcos Number", "HIP 21719"},
        {"Smithsonian Astrophysical Observation", "SAO 149806"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.94674855),
        dec: Angle.Degrees(-10.69518202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9185",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9185"},
        {"Smithsonian Astrophysical Observation", "SAO 148132"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.56290716),
        dec: Angle.Degrees(-10.69452417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9830"},
        {"Hipparcos Number", "HIP 7440"},
        {"Smithsonian Astrophysical Observation", "SAO 147899"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.96027458),
        dec: Angle.Degrees(-10.69424666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27824",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27824"},
        {"Smithsonian Astrophysical Observation", "SAO 150910"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.31842430),
        dec: Angle.Degrees(-10.69274092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3770",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3770"},
    },
    visualMagnitude: 10.81,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.10131505),
        dec: Angle.Degrees(-10.69185305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3568"},
        {"Hipparcos Number", "HIP 3029"},
        {"Smithsonian Astrophysical Observation", "SAO 147377"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.63830365),
        dec: Angle.Degrees(-10.69012732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114750",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16618 A"},
        {"Henry Draper", "HD 219279"},
        {"Hipparcos Number", "HIP 114750"},
        {"Geneva Identification System", "GEN# +1.00219279"},
        {"Smithsonian Astrophysical Observation", "SAO 165578"},
    },
    visualMagnitude: 6.13,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.66740368),
        dec: Angle.Degrees(-10.68862744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221891"},
        {"Hipparcos Number", "HIP 116469"},
        {"Geneva Identification System", "GEN# +1.00221891"},
        {"Smithsonian Astrophysical Observation", "SAO 165791"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.98934667),
        dec: Angle.Degrees(-10.68769388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11171"},
        {"Hipparcos Number", "HIP 8497"},
        {"Fundamental Katalog 5th Edition", "FK5 1051"},
        {"Geneva Identification System", "GEN# +1.00011171A"},
        {"Smithsonian Astrophysical Observation", "SAO 148036"},
        {"Wilson Evans Batten Catalogue", "WEB 1807"},
    },
    visualMagnitude: 4.66,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.39662961),
        dec: Angle.Degrees(-10.68618074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -148.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118298"},
        {"Hipparcos Number", "HIP 66362"},
        {"Smithsonian Astrophysical Observation", "SAO 158035"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.04592965),
        dec: Angle.Degrees(-10.68386960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1720"},
        {"Hipparcos Number", "HIP 1698"},
        {"Smithsonian Astrophysical Observation", "SAO 147228"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.34012908),
        dec: Angle.Degrees(-10.68343864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120969"},
        {"Hipparcos Number", "HIP 67763"},
        {"Smithsonian Astrophysical Observation", "SAO 158212"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.22415929),
        dec: Angle.Degrees(-10.68253856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30050"},
        {"Hipparcos Number", "HIP 22000"},
        {"Geneva Identification System", "GEN# +1.00030050"},
        {"Renson", "Renson 7730"},
        {"Smithsonian Astrophysical Observation", "SAO 149847"},
        {"Wilson Evans Batten Catalogue", "WEB 4228"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.94094480),
        dec: Angle.Degrees(-10.68225001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18635"},
        {"Hipparcos Number", "HIP 13933"},
        {"Geneva Identification System", "GEN# +1.00018635"},
        {"Smithsonian Astrophysical Observation", "SAO 148701"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.88082685),
        dec: Angle.Degrees(-10.68167301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186160"},
        {"Hipparcos Number", "HIP 97030"},
        {"Geneva Identification System", "GEN# +1.00186160"},
        {"Smithsonian Astrophysical Observation", "SAO 162928"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.79805629),
        dec: Angle.Degrees(-10.67942462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167138"},
        {"Hipparcos Number", "HIP 89377"},
        {"Smithsonian Astrophysical Observation", "SAO 161207"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.59483058),
        dec: Angle.Degrees(-10.67862406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39635"},
        {"Hipparcos Number", "HIP 27837"},
        {"Smithsonian Astrophysical Observation", "SAO 150915"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.35579181),
        dec: Angle.Degrees(-10.67844186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149287"},
        {"Hipparcos Number", "HIP 81129"},
        {"Smithsonian Astrophysical Observation", "SAO 159982"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.53075145),
        dec: Angle.Degrees(-10.67788690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -170.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213320"},
        {"Hipparcos Number", "HIP 111123"},
        {"Fundamental Katalog 5th Edition", "FK5 1591"},
        {"Geneva Identification System", "GEN# +1.00213320"},
        {"Renson", "Renson 59130"},
        {"Smithsonian Astrophysical Observation", "SAO 165134"},
        {"Wilson Evans Batten Catalogue", "WEB 19892"},
    },
    visualMagnitude: 4.82,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.66172918),
        dec: Angle.Degrees(-10.67788619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99089"},
        {"Hipparcos Number", "HIP 55653"},
        {"Smithsonian Astrophysical Observation", "SAO 156652"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.03019841),
        dec: Angle.Degrees(-10.67786976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14829"},
        {"Hipparcos Number", "HIP 11124"},
        {"Geneva Identification System", "GEN# +1.00014829"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.78845204),
        dec: Angle.Degrees(-10.67746247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50009"},
        {"Hipparcos Number", "HIP 32848"},
        {"Smithsonian Astrophysical Observation", "SAO 151999"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.70066608),
        dec: Angle.Degrees(-10.67715360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8022"},
        {"Hipparcos Number", "HIP 6199"},
        {"Smithsonian Astrophysical Observation", "SAO 147736"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.87879657),
        dec: Angle.Degrees(-10.67648447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132662"},
        {"Hipparcos Number", "HIP 73453"},
        {"Smithsonian Astrophysical Observation", "SAO 158966"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.15630302),
        dec: Angle.Degrees(-10.67310572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85041",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85041"},
        {"Smithsonian Astrophysical Observation", "SAO 160509"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.71204231),
        dec: Angle.Degrees(-10.67170740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13820"},
        {"Hipparcos Number", "HIP 10429"},
        {"Smithsonian Astrophysical Observation", "SAO 148284"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.59085816),
        dec: Angle.Degrees(-10.67016275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34379",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34379"},
        {"Geneva Identification System", "GEN# +2.23430012"},
        {"New General Catalogue", "NGC 2343 12"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.91921993),
        dec: Angle.Degrees(-10.66852428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125774"},
        {"Hipparcos Number", "HIP 70204"},
        {"Smithsonian Astrophysical Observation", "SAO 158515"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.45510765),
        dec: Angle.Degrees(-10.66679545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6123"},
        {"Hipparcos Number", "HIP 4842"},
        {"Smithsonian Astrophysical Observation", "SAO 147579"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.57320721),
        dec: Angle.Degrees(-10.66426660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64837"},
        {"Hipparcos Number", "HIP 38713"},
        {"Geneva Identification System", "GEN# +1.00064837"},
        {"Smithsonian Astrophysical Observation", "SAO 153589"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.88372699),
        dec: Angle.Degrees(-10.66220011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69557"},
        {"Hipparcos Number", "HIP 40582"},
        {"Smithsonian Astrophysical Observation", "SAO 154068"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.29040515),
        dec: Angle.Degrees(-10.66193631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100601",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100601"},
        {"Smithsonian Astrophysical Observation", "SAO 163526"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.99752777),
        dec: Angle.Degrees(-10.66115316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136713"},
        {"Hipparcos Number", "HIP 75253"},
        {"Geneva Identification System", "GEN# +1.00136713"},
        {"Smithsonian Astrophysical Observation", "SAO 159207"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.65303771),
        dec: Angle.Degrees(-10.66063131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -202.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34234",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5782 A"},
        {"Henry Draper", "HD 53755"},
        {"Hipparcos Number", "HIP 34234"},
        {"Celescope Catalog", "CEL 1571"},
        {"Geneva Identification System", "GEN# +1.00053755"},
        {"Smithsonian Astrophysical Observation", "SAO 152363"},
        {"Wilson Evans Batten Catalogue", "WEB 6857"},
    },
    visualMagnitude: 6.50,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.45684067),
        dec: Angle.Degrees(-10.66008280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56800"},
        {"Hipparcos Number", "HIP 35352"},
        {"Geneva Identification System", "GEN# +1.00056800"},
        {"Smithsonian Astrophysical Observation", "SAO 152684"},
    },
    visualMagnitude: 8.28,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.53426355),
        dec: Angle.Degrees(-10.65920600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18414",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2883 AB"},
        {"Henry Draper", "HD 24794"},
        {"Hipparcos Number", "HIP 18414"},
        {"Smithsonian Astrophysical Observation", "SAO 149263"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.05047053),
        dec: Angle.Degrees(-10.65875317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54664"},
        {"Hipparcos Number", "HIP 34539"},
        {"Celescope Catalog", "CEL 1616"},
        {"Geneva Identification System", "GEN# +1.00054664"},
        {"Smithsonian Astrophysical Observation", "SAO 152471"},
    },
    visualMagnitude: 8.95,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.34090180),
        dec: Angle.Degrees(-10.65726084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32265"},
        {"Hipparcos Number", "HIP 23370"},
        {"Geneva Identification System", "GEN# +1.00032265"},
        {"Smithsonian Astrophysical Observation", "SAO 150083"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.36810614),
        dec: Angle.Degrees(-10.64930535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104593"},
        {"Hipparcos Number", "HIP 58726"},
        {"Geneva Identification System", "GEN# +1.00104593"},
        {"Smithsonian Astrophysical Observation", "SAO 157057"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.68828104),
        dec: Angle.Degrees(-10.64926685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40119"},
        {"Hipparcos Number", "HIP 28119"},
        {"Smithsonian Astrophysical Observation", "SAO 150960"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.14360854),
        dec: Angle.Degrees(-10.64888175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207678"},
        {"Hipparcos Number", "HIP 107846"},
        {"Geneva Identification System", "GEN# +1.00207678"},
        {"Smithsonian Astrophysical Observation", "SAO 164691"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.73734881),
        dec: Angle.Degrees(-10.64411030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42963"},
        {"Hipparcos Number", "HIP 29533"},
        {"Geneva Identification System", "GEN# +1.00042963"},
        {"Smithsonian Astrophysical Observation", "SAO 151234"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.32741866),
        dec: Angle.Degrees(-10.64395252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4813"},
        {"Hipparcos Number", "HIP 3909"},
        {"Fundamental Katalog 5th Edition", "FK5 30"},
        {"Geneva Identification System", "GEN# +1.00004813"},
        {"Smithsonian Astrophysical Observation", "SAO 147470"},
        {"Wilson Evans Batten Catalogue", "WEB 696"},
    },
    visualMagnitude: 5.17,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.53218487),
        dec: Angle.Degrees(-10.64377045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -224.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -228.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15872"},
        {"Hipparcos Number", "HIP 11839"},
        {"Smithsonian Astrophysical Observation", "SAO 148452"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.21565009),
        dec: Angle.Degrees(-10.64020334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60966"},
        {"Henry Draper 2", "HD 60967"},
        {"Hipparcos Number", "HIP 37041"},
        {"Geneva Identification System", "GEN# +1.00060966"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.17672638),
        dec: Angle.Degrees(-10.63803115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30089",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Red Rectangle"},
        {"Aitken", "ADS 4954 AB"},
        {"Henry Draper", "HD 44179"},
        {"Hipparcos Number", "HIP 30089"},
        {"Geneva Identification System", "GEN# +1.00044179J"},
        {"Smithsonian Astrophysical Observation", "SAO 151362"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.99259371),
        dec: Angle.Degrees(-10.63736291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32610"},
        {"Hipparcos Number", "HIP 23564"},
        {"Smithsonian Astrophysical Observation", "SAO 150111"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.99779779),
        dec: Angle.Degrees(-10.63519986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3496",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3496"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.16252097),
        dec: Angle.Degrees(-10.63327695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 176.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143810"},
        {"Hipparcos Number", "HIP 78591"},
        {"Geneva Identification System", "GEN# +1.00143810"},
        {"Smithsonian Astrophysical Observation", "SAO 159652"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.69783814),
        dec: Angle.Degrees(-10.63238862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38677"},
        {"Hipparcos Number", "HIP 27305"},
        {"Geneva Identification System", "GEN# +1.00038677"},
        {"Smithsonian Astrophysical Observation", "SAO 150804"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.77610385),
        dec: Angle.Degrees(-10.63017804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38053"},
        {"Hipparcos Number", "HIP 26894"},
        {"Geneva Identification System", "GEN# +1.00038053"},
        {"Smithsonian Astrophysical Observation", "SAO 150722"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.64067200),
        dec: Angle.Degrees(-10.62883134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199881"},
        {"Hipparcos Number", "HIP 103659"},
        {"Geneva Identification System", "GEN# +1.00199881"},
        {"Smithsonian Astrophysical Observation", "SAO 164050"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.03619918),
        dec: Angle.Degrees(-10.62825205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101957"},
        {"Hipparcos Number", "HIP 57218"},
        {"Geneva Identification System", "GEN# +1.00101957"},
        {"Smithsonian Astrophysical Observation", "SAO 156860"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.99165542),
        dec: Angle.Degrees(-10.62763163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11330",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1847 B"},
        {"Hipparcos Number", "HIP 11330"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.45447267),
        dec: Angle.Degrees(-10.62717311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11331",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1847 A"},
        {"Henry Draper", "HD 15118"},
        {"Hipparcos Number", "HIP 11331"},
        {"Smithsonian Astrophysical Observation", "SAO 148382"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.45746855),
        dec: Angle.Degrees(-10.62687351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212758"},
        {"Hipparcos Number", "HIP 110796"},
        {"Smithsonian Astrophysical Observation", "SAO 165081"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.70472498),
        dec: Angle.Degrees(-10.62560361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94781"},
        {"Hipparcos Number", "HIP 53474"},
        {"Smithsonian Astrophysical Observation", "SAO 156338"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.08239905),
        dec: Angle.Degrees(-10.62491777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145551"},
        {"Hipparcos Number", "HIP 79371"},
        {"Smithsonian Astrophysical Observation", "SAO 159768"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.98725434),
        dec: Angle.Degrees(-10.62227703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14418"},
        {"Hipparcos Number", "HIP 10835"},
        {"Smithsonian Astrophysical Observation", "SAO 148329"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.85514444),
        dec: Angle.Degrees(-10.61822877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97953"},
        {"Hipparcos Number", "HIP 55027"},
        {"Smithsonian Astrophysical Observation", "SAO 156573"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.98210947),
        dec: Angle.Degrees(-10.61606270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8579"},
        {"Hipparcos Number", "HIP 6588"},
        {"Smithsonian Astrophysical Observation", "SAO 147790"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.15994954),
        dec: Angle.Degrees(-10.61446387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61277"},
        {"Hipparcos Number", "HIP 37159"},
        {"Smithsonian Astrophysical Observation", "SAO 153179"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.54947172),
        dec: Angle.Degrees(-10.61309433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109523"},
        {"Hipparcos Number", "HIP 61439"},
        {"Smithsonian Astrophysical Observation", "SAO 157377"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.83949395),
        dec: Angle.Degrees(-10.61293188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200783"},
        {"Hipparcos Number", "HIP 104132"},
        {"Geneva Identification System", "GEN# +1.00200783"},
        {"Smithsonian Astrophysical Observation", "SAO 164133"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.46546093),
        dec: Angle.Degrees(-10.61174449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173250"},
        {"Hipparcos Number", "HIP 91961"},
        {"Smithsonian Astrophysical Observation", "SAO 161783"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.17104317),
        dec: Angle.Degrees(-10.61144248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125355"},
        {"Hipparcos Number", "HIP 69976"},
        {"Smithsonian Astrophysical Observation", "SAO 158490"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.77812414),
        dec: Angle.Degrees(-10.61011260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4188"},
        {"Hipparcos Number", "HIP 3455"},
        {"Fundamental Katalog 5th Edition", "FK5 2048"},
        {"Geneva Identification System", "GEN# +1.00004188"},
        {"Smithsonian Astrophysical Observation", "SAO 147423"},
        {"Wilson Evans Batten Catalogue", "WEB 611"},
    },
    visualMagnitude: 4.77,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.04752272),
        dec: Angle.Degrees(-10.60927365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8338"},
        {"Hipparcos Number", "HIP 6423"},
        {"Geneva Identification System", "GEN# +1.00008338"},
        {"Renson", "Renson 2015"},
        {"Smithsonian Astrophysical Observation", "SAO 147765"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.61499215),
        dec: Angle.Degrees(-10.60586472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118101"},
        {"Hipparcos Number", "HIP 66265"},
        {"Smithsonian Astrophysical Observation", "SAO 158022"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.71113931),
        dec: Angle.Degrees(-10.60582793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202149"},
        {"Hipparcos Number", "HIP 104839"},
        {"Geneva Identification System", "GEN# +1.00202149"},
        {"Renson", "Renson 56350"},
        {"Smithsonian Astrophysical Observation", "SAO 164240"},
    },
    visualMagnitude: 6.77,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.56964747),
        dec: Angle.Degrees(-10.60539326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124071"},
        {"Hipparcos Number", "HIP 69338"},
        {"Smithsonian Astrophysical Observation", "SAO 158412"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.87406713),
        dec: Angle.Degrees(-10.60530547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -143.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68689",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68689"},
    },
    visualMagnitude: 11.43,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.90598356),
        dec: Angle.Degrees(-10.60396655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -237.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28574",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4615 A"},
        {"Henry Draper", "HD 40967"},
        {"Hipparcos Number", "HIP 28574"},
        {"Geneva Identification System", "GEN# +1.00040967"},
        {"Smithsonian Astrophysical Observation", "SAO 151037"},
        {"Wilson Evans Batten Catalogue", "WEB 5584"},
    },
    visualMagnitude: 4.92,
    bvColour: -0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.46010757),
        dec: Angle.Degrees(-10.59793918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10878"},
        {"Hipparcos Number", "HIP 8268"},
        {"Geneva Identification System", "GEN# +1.00010878"},
        {"Smithsonian Astrophysical Observation", "SAO 148007"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.62999749),
        dec: Angle.Degrees(-10.59793798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192956"},
        {"Hipparcos Number", "HIP 100065"},
        {"Smithsonian Astrophysical Observation", "SAO 163428"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.51368420),
        dec: Angle.Degrees(-10.59744743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30522"},
        {"Hipparcos Number", "HIP 22292"},
        {"Smithsonian Astrophysical Observation", "SAO 149894"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.01213247),
        dec: Angle.Degrees(-10.58995805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129520"},
        {"Hipparcos Number", "HIP 71982"},
        {"Smithsonian Astrophysical Observation", "SAO 158759"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.83045341),
        dec: Angle.Degrees(-10.58866225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203541"},
        {"Hipparcos Number", "HIP 105589"},
        {"Smithsonian Astrophysical Observation", "SAO 164354"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.79751986),
        dec: Angle.Degrees(-10.58824004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73356",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73356"},
        {"Smithsonian Astrophysical Observation", "SAO 158951"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.87159686),
        dec: Angle.Degrees(-10.58773790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100217"},
        {"Hipparcos Number", "HIP 56254"},
        {"Smithsonian Astrophysical Observation", "SAO 156734"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.96321678),
        dec: Angle.Degrees(-10.58759359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28103"},
        {"Hipparcos Number", "HIP 20666"},
        {"Smithsonian Astrophysical Observation", "SAO 149620"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.41277102),
        dec: Angle.Degrees(-10.58719165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85772"},
        {"Hipparcos Number", "HIP 48534"},
        {"Smithsonian Astrophysical Observation", "SAO 155575"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.48232698),
        dec: Angle.Degrees(-10.58677879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46890"},
        {"Hipparcos Number", "HIP 31456"},
        {"Smithsonian Astrophysical Observation", "SAO 151667"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.85039831),
        dec: Angle.Degrees(-10.58444687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56207"},
        {"Hipparcos Number", "HIP 35127"},
        {"Geneva Identification System", "GEN# +1.00056207"},
        {"Smithsonian Astrophysical Observation", "SAO 152621"},
    },
    visualMagnitude: 5.95,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.93009963),
        dec: Angle.Degrees(-10.58360286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91858"},
        {"Hipparcos Number", "HIP 51907"},
        {"Geneva Identification System", "GEN# +1.00091858"},
        {"Smithsonian Astrophysical Observation", "SAO 156092"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.07239399),
        dec: Angle.Degrees(-10.58332632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190388"},
        {"Hipparcos Number", "HIP 98899"},
        {"Smithsonian Astrophysical Observation", "SAO 163241"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.25171529),
        dec: Angle.Degrees(-10.58108104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176182"},
        {"Hipparcos Number", "HIP 93232"},
        {"Smithsonian Astrophysical Observation", "SAO 162056"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.86109501),
        dec: Angle.Degrees(-10.58024642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132427"},
        {"Hipparcos Number", "HIP 73349"},
        {"Smithsonian Astrophysical Observation", "SAO 158950"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.84536393),
        dec: Angle.Degrees(-10.57781599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206005"},
        {"Hipparcos Number", "HIP 106938"},
        {"Fundamental Katalog 5th Edition", "FK5 3728"},
        {"Geneva Identification System", "GEN# +1.00206005"},
        {"Smithsonian Astrophysical Observation", "SAO 164555"},
    },
    visualMagnitude: 6.07,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.86705640),
        dec: Angle.Degrees(-10.57676913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186461"},
        {"Hipparcos Number", "HIP 97157"},
        {"Smithsonian Astrophysical Observation", "SAO 162945"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.22623907),
        dec: Angle.Degrees(-10.57272432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111595"},
        {"Hipparcos Number", "HIP 62676"},
        {"Smithsonian Astrophysical Observation", "SAO 157542"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.64353384),
        dec: Angle.Degrees(-10.57164299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105968"},
        {"Hipparcos Number", "HIP 59452"},
        {"Geneva Identification System", "GEN# +1.00105968"},
        {"Smithsonian Astrophysical Observation", "SAO 157136"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.91795879),
        dec: Angle.Degrees(-10.57060922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42041"},
        {"Hipparcos Number", "HIP 29086"},
        {"Smithsonian Astrophysical Observation", "SAO 151147"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.03396600),
        dec: Angle.Degrees(-10.57044211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83650"},
        {"Hipparcos Number", "HIP 47427"},
        {"Geneva Identification System", "GEN# +1.00083650"},
        {"Smithsonian Astrophysical Observation", "SAO 155377"},
        {"Wilson Evans Batten Catalogue", "WEB 8902"},
    },
    visualMagnitude: 6.31,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.94759513),
        dec: Angle.Degrees(-10.57028535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15356",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2457 AB"},
        {"Henry Draper", "HD 20551"},
        {"Hipparcos Number", "HIP 15356"},
        {"Geneva Identification System", "GEN# +1.00020551"},
        {"Smithsonian Astrophysical Observation", "SAO 148890"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.50206927),
        dec: Angle.Degrees(-10.57028401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74652",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74652"},
        {"Smithsonian Astrophysical Observation", "SAO 159126"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.81195155),
        dec: Angle.Degrees(-10.56911615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26902"},
        {"Hipparcos Number", "HIP 19804"},
        {"Smithsonian Astrophysical Observation", "SAO 149482"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.69967862),
        dec: Angle.Degrees(-10.56865551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149757"},
        {"Hipparcos Number", "HIP 81377"},
        {"Fundamental Katalog 5th Edition", "FK5 622"},
        {"Geneva Identification System", "GEN# +1.00149757"},
        {"Smithsonian Astrophysical Observation", "SAO 160006"},
        {"Wilson Evans Batten Catalogue", "WEB 13754"},
    },
    visualMagnitude: 2.54,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.28970847),
        dec: Angle.Degrees(-10.56715180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127072"},
        {"Hipparcos Number", "HIP 70867"},
        {"Smithsonian Astrophysical Observation", "SAO 158598"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.38049566),
        dec: Angle.Degrees(-10.56666150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35205"},
        {"Hipparcos Number", "HIP 25131"},
        {"Smithsonian Astrophysical Observation", "SAO 150385"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.68385095),
        dec: Angle.Degrees(-10.56632720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73164"},
        {"Hipparcos Number", "HIP 42225"},
        {"Smithsonian Astrophysical Observation", "SAO 154446"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.13595619),
        dec: Angle.Degrees(-10.56621153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26650"},
        {"Hipparcos Number", "HIP 19643"},
        {"Geneva Identification System", "GEN# +1.00026650"},
        {"Renson", "Renson 6807"},
        {"Smithsonian Astrophysical Observation", "SAO 149455"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.13580815),
        dec: Angle.Degrees(-10.56607862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85019"},
        {"Hipparcos Number", "HIP 48147"},
        {"Fundamental Katalog 5th Edition", "FK5 4870"},
        {"Smithsonian Astrophysical Observation", "SAO 155507"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.22264406),
        dec: Angle.Degrees(-10.56556198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6987",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6987"},
        {"Cincinnati Publication", "Ci 18 200"},
        {"Smithsonian Astrophysical Observation", "SAO 147843"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.48238475),
        dec: Angle.Degrees(-10.56469888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81027",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10104 A"},
        {"Henry Draper", "HD 149108"},
        {"Hipparcos Number", "HIP 81027"},
        {"Geneva Identification System", "GEN# +1.00149108"},
        {"Smithsonian Astrophysical Observation", "SAO 159972"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.23220909),
        dec: Angle.Degrees(-10.56252616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207936"},
        {"Hipparcos Number", "HIP 108018"},
        {"Smithsonian Astrophysical Observation", "SAO 164711"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.25394339),
        dec: Angle.Degrees(-10.56250566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85549"},
        {"Hipparcos Number", "HIP 48419"},
        {"Smithsonian Astrophysical Observation", "SAO 155555"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.06480010),
        dec: Angle.Degrees(-10.56061454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184492"},
        {"Hipparcos Number", "HIP 96327"},
        {"Fundamental Katalog 5th Edition", "FK5 3562"},
        {"Geneva Identification System", "GEN# +1.00184492"},
        {"Smithsonian Astrophysical Observation", "SAO 162792"},
        {"Wilson Evans Batten Catalogue", "WEB 16889"},
    },
    visualMagnitude: 5.12,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.78022188),
        dec: Angle.Degrees(-10.56043644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95049",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12320 AB"},
        {"Henry Draper", "HD 181312"},
        {"Hipparcos Number", "HIP 95049"},
        {"Geneva Identification System", "GEN# +1.00181312J"},
        {"Smithsonian Astrophysical Observation", "SAO 162488"},
        {"Wilson Evans Batten Catalogue", "WEB 16602"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.10282849),
        dec: Angle.Degrees(-10.56037626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82782"},
        {"Hipparcos Number", "HIP 46941"},
        {"Smithsonian Astrophysical Observation", "SAO 155297"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.50095032),
        dec: Angle.Degrees(-10.55734095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142214"},
        {"Hipparcos Number", "HIP 77842"},
        {"Geneva Identification System", "GEN# +1.00142214"},
        {"Smithsonian Astrophysical Observation", "SAO 159562"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.41244193),
        dec: Angle.Degrees(-10.55635533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215874"},
        {"Hipparcos Number", "HIP 112615"},
        {"Fundamental Katalog 5th Edition", "FK5 3825"},
        {"Geneva Identification System", "GEN# +1.00215874"},
        {"Smithsonian Astrophysical Observation", "SAO 165308"},
        {"Wilson Evans Batten Catalogue", "WEB 20076"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.12579744),
        dec: Angle.Degrees(-10.55549675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221825"},
        {"Hipparcos Number", "HIP 116419"},
        {"Smithsonian Astrophysical Observation", "SAO 165786"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.86547653),
        dec: Angle.Degrees(-10.55507834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21654"},
        {"Hipparcos Number", "HIP 16238"},
        {"Geneva Identification System", "GEN# +1.00021654"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.32524814),
        dec: Angle.Degrees(-10.55483348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128752"},
        {"Hipparcos Number", "HIP 71632"},
        {"Geneva Identification System", "GEN# +1.00128752"},
        {"Smithsonian Astrophysical Observation", "SAO 158696"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.75173031),
        dec: Angle.Degrees(-10.55480499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25585"},
        {"Hipparcos Number", "HIP 18924"},
        {"Smithsonian Astrophysical Observation", "SAO 149337"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.85042368),
        dec: Angle.Degrees(-10.55396138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82428"},
        {"Hipparcos Number", "HIP 46744"},
        {"Geneva Identification System", "GEN# +1.00082428"},
        {"Smithsonian Astrophysical Observation", "SAO 155257"},
        {"Wilson Evans Batten Catalogue", "WEB 8816"},
    },
    visualMagnitude: 6.13,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.91236818),
        dec: Angle.Degrees(-10.55196998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28185"},
        {"Hipparcos Number", "HIP 20723"},
        {"Geneva Identification System", "GEN# +1.00028185"},
        {"Smithsonian Astrophysical Observation", "SAO 149631"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.60946903),
        dec: Angle.Degrees(-10.55067442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165830"},
        {"Hipparcos Number", "HIP 88850"},
        {"Geneva Identification System", "GEN# +1.00165830"},
        {"Renson", "Renson 46720"},
        {"Smithsonian Astrophysical Observation", "SAO 161101"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.07267705),
        dec: Angle.Degrees(-10.55062403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13168",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2156 AB"},
        {"Henry Draper", "HD 17617"},
        {"Hipparcos Number", "HIP 13168"},
        {"Smithsonian Astrophysical Observation", "SAO 148622"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.33264043),
        dec: Angle.Degrees(-10.55043096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131007"},
        {"Hipparcos Number", "HIP 72668"},
        {"Smithsonian Astrophysical Observation", "SAO 158854"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.86747061),
        dec: Angle.Degrees(-10.54964584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58645"},
        {"Hipparcos Number", "HIP 36093"},
        {"Smithsonian Astrophysical Observation", "SAO 152864"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.53973983),
        dec: Angle.Degrees(-10.54908491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205000"},
        {"Hipparcos Number", "HIP 106365"},
        {"Smithsonian Astrophysical Observation", "SAO 164464"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.14790847),
        dec: Angle.Degrees(-10.54665637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115466"},
        {"Hipparcos Number", "HIP 64834"},
        {"Geneva Identification System", "GEN# +1.00115466"},
        {"Smithsonian Astrophysical Observation", "SAO 157837"},
        {"Wilson Evans Batten Catalogue", "WEB 11459"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.36406650),
        dec: Angle.Degrees(-10.54632759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153168"},
        {"Hipparcos Number", "HIP 83048"},
        {"Smithsonian Astrophysical Observation", "SAO 160197"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.55089689),
        dec: Angle.Degrees(-10.54571473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24486"},
        {"Hipparcos Number", "HIP 18185"},
        {"Smithsonian Astrophysical Observation", "SAO 149230"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.35038067),
        dec: Angle.Degrees(-10.54541209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34702",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5857 AB"},
        {"Henry Draper", "HD 55118"},
        {"Hipparcos Number", "HIP 34702"},
        {"Celescope Catalog", "CEL 1647"},
        {"Geneva Identification System", "GEN# +1.00055118J"},
        {"Smithsonian Astrophysical Observation", "SAO 152525"},
    },
    visualMagnitude: 7.89,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.81313244),
        dec: Angle.Degrees(-10.54157177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68568"},
        {"Hipparcos Number", "HIP 40201"},
        {"Smithsonian Astrophysical Observation", "SAO 153971"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.16639324),
        dec: Angle.Degrees(-10.53866378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50796",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50796"},
    },
    visualMagnitude: 10.80,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.57515161),
        dec: Angle.Degrees(-10.53757408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24728"},
        {"Hipparcos Number", "HIP 18365"},
        {"Smithsonian Astrophysical Observation", "SAO 149255"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.90492960),
        dec: Angle.Degrees(-10.53664331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38735"},
        {"Hipparcos Number", "HIP 27341"},
        {"Geneva Identification System", "GEN# +1.00038735"},
        {"Smithsonian Astrophysical Observation", "SAO 150814"},
    },
    visualMagnitude: 6.04,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.86207374),
        dec: Angle.Degrees(-10.53291673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220063"},
        {"Hipparcos Number", "HIP 115278"},
        {"Geneva Identification System", "GEN# +1.00220063"},
        {"Smithsonian Astrophysical Observation", "SAO 165638"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.21985034),
        dec: Angle.Degrees(-10.53249545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119773"},
        {"Hipparcos Number", "HIP 67117"},
        {"Smithsonian Astrophysical Observation", "SAO 158146"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.34418128),
        dec: Angle.Degrees(-10.53063154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24327"},
        {"Hipparcos Number", "HIP 18080"},
        {"Smithsonian Astrophysical Observation", "SAO 149215"},
        {"Wilson Evans Batten Catalogue", "WEB 3486"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.97237092),
        dec: Angle.Degrees(-10.53009040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34938"},
        {"Hipparcos Number", "HIP 24953"},
        {"Smithsonian Astrophysical Observation", "SAO 150358"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.16695886),
        dec: Angle.Degrees(-10.52737423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44421"},
        {"Hipparcos Number", "HIP 30212"},
        {"Geneva Identification System", "GEN# +1.00044421"},
        {"Smithsonian Astrophysical Observation", "SAO 151398"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.34478164),
        dec: Angle.Degrees(-10.52612183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223021"},
        {"Hipparcos Number", "HIP 117212"},
        {"Smithsonian Astrophysical Observation", "SAO 165866"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.49794112),
        dec: Angle.Degrees(-10.52486486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119772"},
        {"Hipparcos Number", "HIP 67112"},
        {"Smithsonian Astrophysical Observation", "SAO 158145"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.33277513),
        dec: Angle.Degrees(-10.52407981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155078"},
        {"Hipparcos Number", "HIP 83962"},
        {"Fundamental Katalog 5th Edition", "FK5 1450"},
        {"Geneva Identification System", "GEN# +1.00155078"},
        {"Smithsonian Astrophysical Observation", "SAO 160324"},
        {"Wilson Evans Batten Catalogue", "WEB 14185"},
    },
    visualMagnitude: 5.43,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.44965775),
        dec: Angle.Degrees(-10.52303750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84751"},
        {"Hipparcos Number", "HIP 48001"},
        {"Geneva Identification System", "GEN# +1.00084751"},
        {"Smithsonian Astrophysical Observation", "SAO 155473"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.77142056),
        dec: Angle.Degrees(-10.52298748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151413"},
        {"Hipparcos Number", "HIP 82197"},
        {"Smithsonian Astrophysical Observation", "SAO 160099"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.88885359),
        dec: Angle.Degrees(-10.52201207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213723"},
        {"Hipparcos Number", "HIP 111364"},
        {"Smithsonian Astrophysical Observation", "SAO 165160"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.42123765),
        dec: Angle.Degrees(-10.52098037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203946"},
        {"Hipparcos Number", "HIP 105805"},
        {"Geneva Identification System", "GEN# +1.00203946"},
        {"Smithsonian Astrophysical Observation", "SAO 164381"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.41490709),
        dec: Angle.Degrees(-10.52032641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211358"},
        {"Hipparcos Number", "HIP 109995"},
        {"Smithsonian Astrophysical Observation", "SAO 164971"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.17832615),
        dec: Angle.Degrees(-10.51850029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16836"},
        {"Hipparcos Number", "HIP 12574"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.42550736),
        dec: Angle.Degrees(-10.51713631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218676"},
        {"Hipparcos Number", "HIP 114380"},
        {"Geneva Identification System", "GEN# +1.00218676"},
        {"Smithsonian Astrophysical Observation", "SAO 165525"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.48900504),
        dec: Angle.Degrees(-10.51675775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57080"},
        {"Hipparcos Number", "HIP 35480"},
        {"Smithsonian Astrophysical Observation", "SAO 152720"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.84751898),
        dec: Angle.Degrees(-10.51671137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71253"},
        {"Hipparcos Number", "HIP 41336"},
        {"Smithsonian Astrophysical Observation", "SAO 154247"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.50449547),
        dec: Angle.Degrees(-10.51657643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175250"},
        {"Hipparcos Number", "HIP 92838"},
        {"Renson", "Renson 49016"},
        {"Smithsonian Astrophysical Observation", "SAO 161974"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.72782146),
        dec: Angle.Degrees(-10.51624244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 358435"},
        {"Hipparcos Number", "HIP 105504"},
        {"Geneva Identification System", "GEN# -0.01105581"},
    },
    visualMagnitude: 10.21,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.53253046),
        dec: Angle.Degrees(-10.51328569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55354",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55354"},
    },
    visualMagnitude: 11.79,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.02536633),
        dec: Angle.Degrees(-10.51271247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139707"},
        {"Hipparcos Number", "HIP 76729"},
        {"Geneva Identification System", "GEN# +1.00139707"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.03475877),
        dec: Angle.Degrees(-10.51243289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18931"},
        {"Hipparcos Number", "HIP 14151"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.61017038),
        dec: Angle.Degrees(-10.50961262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225212"},
        {"Hipparcos Number", "HIP 355"},
        {"Fundamental Katalog 5th Edition", "FK5 2001"},
        {"Geneva Identification System", "GEN# +1.00225212"},
        {"Smithsonian Astrophysical Observation", "SAO 147066"},
        {"Wilson Evans Batten Catalogue", "WEB 51"},
    },
    visualMagnitude: 4.99,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.12550980),
        dec: Angle.Degrees(-10.50949443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218870"},
        {"Hipparcos Number", "HIP 114506"},
        {"Fundamental Katalog 5th Edition", "FK5 6048"},
        {"Geneva Identification System", "GEN# +1.00218870"},
        {"Smithsonian Astrophysical Observation", "SAO 165545"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.87003109),
        dec: Angle.Degrees(-10.50943272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70972"},
        {"Hipparcos Number", "HIP 41203"},
        {"Smithsonian Astrophysical Observation", "SAO 154215"},
    },
    visualMagnitude: 8.52,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.12379027),
        dec: Angle.Degrees(-10.50770857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34104",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34104"},
        {"Cincinnati Publication", "Ci 20 411"},
        {"Geneva Identification System", "GEN# +6.10010263"},
        {"Geneva Identification System 2", "GEN# +6.00102725"},
        {"Geneva Identification System 3", "GEN# +6.10220054"},
    },
    visualMagnitude: 10.95,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.07408227),
        dec: Angle.Degrees(-10.50682727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -817.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135680"},
        {"Hipparcos Number", "HIP 74764"},
        {"Smithsonian Astrophysical Observation", "SAO 159147"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.20194782),
        dec: Angle.Degrees(-10.50627045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34640"},
        {"Hipparcos Number", "HIP 24773"},
        {"Smithsonian Astrophysical Observation", "SAO 150322"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.67129265),
        dec: Angle.Degrees(-10.50538307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83937"},
        {"Hipparcos Number", "HIP 47534"},
        {"Smithsonian Astrophysical Observation", "SAO 155401"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.36475917),
        dec: Angle.Degrees(-10.50255993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63896",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63896"},
        {"Smithsonian Astrophysical Observation", "SAO 157711"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.42387583),
        dec: Angle.Degrees(-10.50186303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27506"},
        {"Hipparcos Number", "HIP 20236"},
        {"Smithsonian Astrophysical Observation", "SAO 149551"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.05324169),
        dec: Angle.Degrees(-10.50182698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36886"},
        {"Hipparcos Number", "HIP 26148"},
        {"Smithsonian Astrophysical Observation", "SAO 150580"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.61980576),
        dec: Angle.Degrees(-10.50098454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135825"},
        {"Hipparcos Number", "HIP 74825"},
        {"Geneva Identification System", "GEN# +1.00135825"},
        {"Smithsonian Astrophysical Observation", "SAO 159155"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.38380665),
        dec: Angle.Degrees(-10.50055538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63555"},
        {"Hipparcos Number", "HIP 38161"},
        {"Smithsonian Astrophysical Observation", "SAO 153443"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.30502645),
        dec: Angle.Degrees(-10.49935709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37237"},
        {"Hipparcos Number", "HIP 26349"},
        {"Smithsonian Astrophysical Observation", "SAO 150606"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.15896250),
        dec: Angle.Degrees(-10.49897024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10137"},
        {"Hipparcos Number", "HIP 7692"},
        {"Geneva Identification System", "GEN# +1.00010137"},
        {"Smithsonian Astrophysical Observation", "SAO 147928"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.75063524),
        dec: Angle.Degrees(-10.49857824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48282"},
        {"Hipparcos Number", "HIP 32088"},
        {"Celescope Catalog", "CEL 1359"},
        {"Geneva Identification System", "GEN# +1.00048282"},
        {"Smithsonian Astrophysical Observation", "SAO 151812"},
        {"Wilson Evans Batten Catalogue", "WEB 6478"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.55392225),
        dec: Angle.Degrees(-10.49808512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130068"},
        {"Hipparcos Number", "HIP 72239"},
        {"Smithsonian Astrophysical Observation", "SAO 158793"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.60085035),
        dec: Angle.Degrees(-10.49668935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4071"},
        {"Hipparcos Number", "HIP 3386"},
        {"Smithsonian Astrophysical Observation", "SAO 147417"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.75908797),
        dec: Angle.Degrees(-10.49580348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197536"},
        {"Hipparcos Number", "HIP 102379"},
        {"Fundamental Katalog 5th Edition", "FK5 5826"},
        {"Geneva Identification System", "GEN# +1.00197536"},
        {"Smithsonian Astrophysical Observation", "SAO 163843"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.15415094),
        dec: Angle.Degrees(-10.49447137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92062",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11642 AB"},
        {"Henry Draper", "HD 173457"},
        {"Hipparcos Number", "HIP 92062"},
        {"Smithsonian Astrophysical Observation", "SAO 161805"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.46385369),
        dec: Angle.Degrees(-10.49276601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44796",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7197 A"},
        {"Henry Draper", "HD 78392"},
        {"Hipparcos Number", "HIP 44796"},
        {"Smithsonian Astrophysical Observation", "SAO 154926"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.93541607),
        dec: Angle.Degrees(-10.49064309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31089"},
        {"Hipparcos Number", "HIP 22669"},
        {"Smithsonian Astrophysical Observation", "SAO 149955"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.14525919),
        dec: Angle.Degrees(-10.48865815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42811"},
        {"Hipparcos Number", "HIP 29460"},
        {"Smithsonian Astrophysical Observation", "SAO 151218"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.11306636),
        dec: Angle.Degrees(-10.48830138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45442",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45442"},
        {"Smithsonian Astrophysical Observation", "SAO 155035"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.90780301),
        dec: Angle.Degrees(-10.48818098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81510"},
        {"Hipparcos Number", "HIP 46253"},
        {"Geneva Identification System", "GEN# +1.00081510"},
        {"Smithsonian Astrophysical Observation", "SAO 155175"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.44427174),
        dec: Angle.Degrees(-10.48686804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136835"},
        {"Hipparcos Number", "HIP 75310"},
        {"Geneva Identification System", "GEN# +1.00136835"},
        {"Smithsonian Astrophysical Observation", "SAO 159215"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.79621851),
        dec: Angle.Degrees(-10.48675281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23281"},
        {"Hipparcos Number", "HIP 17395"},
        {"Geneva Identification System", "GEN# +1.00023281"},
        {"Renson", "Renson 5930"},
        {"Smithsonian Astrophysical Observation", "SAO 149132"},
        {"Wilson Evans Batten Catalogue", "WEB 3286"},
    },
    visualMagnitude: 5.59,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.89099355),
        dec: Angle.Degrees(-10.48561144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65647"},
        {"Hipparcos Number", "HIP 39056"},
        {"Smithsonian Astrophysical Observation", "SAO 153674"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.84954844),
        dec: Angle.Degrees(-10.48258937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145654"},
        {"Hipparcos Number", "HIP 79416"},
        {"Smithsonian Astrophysical Observation", "SAO 159776"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.11755956),
        dec: Angle.Degrees(-10.48222996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35204"},
        {"Hipparcos Number", "HIP 25132"},
        {"Smithsonian Astrophysical Observation", "SAO 150384"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.68437630),
        dec: Angle.Degrees(-10.48065279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124036"},
        {"Hipparcos Number", "HIP 69325"},
        {"Smithsonian Astrophysical Observation", "SAO 158411"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.83011710),
        dec: Angle.Degrees(-10.47899767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73767"},
        {"Hipparcos Number", "HIP 42486"},
        {"Fundamental Katalog 5th Edition", "FK5 4777"},
        {"Geneva Identification System", "GEN# +1.00073767"},
        {"Smithsonian Astrophysical Observation", "SAO 154510"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.92851774),
        dec: Angle.Degrees(-10.47700104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104078"},
        {"Hipparcos Number", "HIP 58450"},
        {"Fundamental Katalog 5th Edition", "FK5 2958"},
        {"Smithsonian Astrophysical Observation", "SAO 157028"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.78906616),
        dec: Angle.Degrees(-10.47597109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5601"},
        {"Hipparcos Number", "HIP 4488"},
        {"Geneva Identification System", "GEN# +1.00005601"},
        {"Renson", "Renson 1480"},
        {"Smithsonian Astrophysical Observation", "SAO 147533"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.38543829),
        dec: Angle.Degrees(-10.47577763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107955"},
        {"Hipparcos Number", "HIP 60518"},
        {"Smithsonian Astrophysical Observation", "SAO 157262"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.09017520),
        dec: Angle.Degrees(-10.47522913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139156"},
        {"Hipparcos Number", "HIP 76467"},
        {"Geneva Identification System", "GEN# +1.00139156"},
        {"Smithsonian Astrophysical Observation", "SAO 159383"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.25189174),
        dec: Angle.Degrees(-10.47491375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162116"},
        {"Hipparcos Number", "HIP 87256"},
        {"Smithsonian Astrophysical Observation", "SAO 160843"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.44088776),
        dec: Angle.Degrees(-10.47486099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203053"},
        {"Hipparcos Number", "HIP 105329"},
        {"Smithsonian Astrophysical Observation", "SAO 164314"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.02463599),
        dec: Angle.Degrees(-10.47302725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26609"},
        {"Hipparcos Number", "HIP 19610"},
        {"Geneva Identification System", "GEN# +1.00026609"},
        {"Smithsonian Astrophysical Observation", "SAO 149449"},
        {"Wilson Evans Batten Catalogue", "WEB 3749"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.03715016),
        dec: Angle.Degrees(-10.46915560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71956"},
        {"Hipparcos Number", "HIP 41683"},
        {"Smithsonian Astrophysical Observation", "SAO 154316"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.46153871),
        dec: Angle.Degrees(-10.46677474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91557",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91557"},
        {"Cincinnati Publication", "Ci 20 1099"},
        {"Geneva Identification System", "GEN# +6.10010723"},
        {"Geneva Identification System 2", "GEN# +9.80155030"},
    },
    visualMagnitude: 11.49,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.07468438),
        dec: Angle.Degrees(-10.46397214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -170.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -525.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224743"},
        {"Hipparcos Number", "HIP 33"},
        {"Geneva Identification System", "GEN# +1.00224743"},
        {"Smithsonian Astrophysical Observation", "SAO 165993"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.09918083),
        dec: Angle.Degrees(-10.46245445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63964",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63964"},
        {"Smithsonian Astrophysical Observation", "SAO 157724"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.62172217),
        dec: Angle.Degrees(-10.46184637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -152.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20093",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20093"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.61997039),
        dec: Angle.Degrees(-10.46173602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 163.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -359.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46952"},
        {"Hipparcos Number", "HIP 31496"},
        {"Smithsonian Astrophysical Observation", "SAO 151675"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.94317893),
        dec: Angle.Degrees(-10.46078517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219240"},
        {"Hipparcos Number", "HIP 114733"},
        {"Smithsonian Astrophysical Observation", "SAO 165577"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.62633366),
        dec: Angle.Degrees(-10.46077489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6232"},
        {"Hipparcos Number", "HIP 4922"},
        {"Smithsonian Astrophysical Observation", "SAO 147583"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.79634961),
        dec: Angle.Degrees(-10.46021783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167718"},
        {"Hipparcos Number", "HIP 89589"},
        {"Geneva Identification System", "GEN# +1.00167718"},
        {"Smithsonian Astrophysical Observation", "SAO 161258"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.22736745),
        dec: Angle.Degrees(-10.45850911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -157.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53367"},
        {"Hipparcos Number", "HIP 34116"},
        {"Celescope Catalog", "CEL 1550"},
        {"Geneva Identification System", "GEN# +1.00053367J"},
        {"Smithsonian Astrophysical Observation", "SAO 152320"},
        {"Wilson Evans Batten Catalogue", "WEB 6842"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.10638669),
        dec: Angle.Degrees(-10.45437899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221222"},
        {"Hipparcos Number", "HIP 116006"},
        {"Smithsonian Astrophysical Observation", "SAO 165726"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.56022608),
        dec: Angle.Degrees(-10.45099635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69247"},
        {"Hipparcos Number", "HIP 40465"},
        {"Geneva Identification System", "GEN# +1.00069247"},
        {"Smithsonian Astrophysical Observation", "SAO 154039"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.93815101),
        dec: Angle.Degrees(-10.44833717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209950"},
        {"Hipparcos Number", "HIP 109201"},
        {"Smithsonian Astrophysical Observation", "SAO 164866"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.82543383),
        dec: Angle.Degrees(-10.44686951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103388",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103388"},
        {"Cincinnati Publication", "Ci 20 1242"},
        {"Geneva Identification System", "GEN# +6.10140896"},
        {"Wilson Evans Batten Catalogue", "WEB 18799"},
    },
    visualMagnitude: 11.38,
    bvColour: 1.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.19424722),
        dec: Angle.Degrees(-10.44580703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1109.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104304"},
        {"Hipparcos Number", "HIP 58576"},
        {"Cincinnati Publication", "Ci 20 675"},
        {"Geneva Identification System", "GEN# +1.00104304"},
        {"Smithsonian Astrophysical Observation", "SAO 157041"},
        {"Wilson Evans Batten Catalogue", "WEB 10453"},
    },
    visualMagnitude: 5.54,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.18486353),
        dec: Angle.Degrees(-10.44483921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 141.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -483.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10278"},
        {"Hipparcos Number", "HIP 7799"},
        {"Geneva Identification System", "GEN# +1.00010278"},
        {"Smithsonian Astrophysical Observation", "SAO 147946"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.09301386),
        dec: Angle.Degrees(-10.44436411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 219.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20550"},
        {"Hipparcos Number", "HIP 15354"},
        {"Geneva Identification System", "GEN# +1.00020550"},
        {"Smithsonian Astrophysical Observation", "SAO 148889"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.49581949),
        dec: Angle.Degrees(-10.44279891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184860"},
        {"Hipparcos Number", "HIP 96471"},
        {"Geneva Identification System", "GEN# +1.00184860J"},
        {"Smithsonian Astrophysical Observation", "SAO 162814"},
        {"Wilson Evans Batten Catalogue", "WEB 16926"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.19088968),
        dec: Angle.Degrees(-10.44276795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -293.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -273.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15027",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15027"},
        {"Geneva Identification System", "GEN# -0.01000639"},
    },
    visualMagnitude: 10.93,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.41300397),
        dec: Angle.Degrees(-10.44231945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18095"},
        {"Hipparcos Number", "HIP 13520"},
        {"Geneva Identification System", "GEN# +1.00018095"},
        {"Smithsonian Astrophysical Observation", "SAO 148660"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.52945529),
        dec: Angle.Degrees(-10.44229130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61892",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61892"},
    },
    visualMagnitude: 11.14,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.24769184),
        dec: Angle.Degrees(-10.44196393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148729"},
        {"Hipparcos Number", "HIP 80831"},
        {"Geneva Identification System", "GEN# +1.00148729"},
        {"Smithsonian Astrophysical Observation", "SAO 159955"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.60709903),
        dec: Angle.Degrees(-10.44119715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57625",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57625"},
        {"Geneva Identification System", "GEN# -0.00903371"},
        {"Wilson Evans Batten Catalogue", "WEB 10348"},
    },
    visualMagnitude: 11.57,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.23425638),
        dec: Angle.Degrees(-10.44116280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150053"},
        {"Hipparcos Number", "HIP 81500"},
        {"Smithsonian Astrophysical Observation", "SAO 160023"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.70367663),
        dec: Angle.Degrees(-10.43895581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138425"},
        {"Hipparcos Number", "HIP 76079"},
        {"Geneva Identification System", "GEN# +1.00138425"},
        {"Smithsonian Astrophysical Observation", "SAO 159327"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.07444482),
        dec: Angle.Degrees(-10.43863464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218174"},
        {"Hipparcos Number", "HIP 114056"},
        {"Smithsonian Astrophysical Observation", "SAO 165489"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.47297844),
        dec: Angle.Degrees(-10.43785423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122085"},
        {"Hipparcos Number", "HIP 68376"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.94593305),
        dec: Angle.Degrees(-10.43749741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39361"},
        {"Hipparcos Number", "HIP 27690"},
        {"Smithsonian Astrophysical Observation", "SAO 150877"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.93830104),
        dec: Angle.Degrees(-10.43713387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22799"},
        {"Hipparcos Number", "HIP 17057"},
        {"Geneva Identification System", "GEN# +1.00022799"},
        {"Smithsonian Astrophysical Observation", "SAO 149082"},
    },
    visualMagnitude: 6.19,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.85592628),
        dec: Angle.Degrees(-10.43702564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100861"},
        {"Hipparcos Number", "HIP 56611"},
        {"Smithsonian Astrophysical Observation", "SAO 156780"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.10457475),
        dec: Angle.Degrees(-10.43565775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112188"},
        {"Hipparcos Number", "HIP 63016"},
        {"Geneva Identification System", "GEN# +1.00112188"},
        {"Smithsonian Astrophysical Observation", "SAO 157588"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.71332672),
        dec: Angle.Degrees(-10.43413627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37757"},
        {"Hipparcos Number", "HIP 26704"},
        {"Smithsonian Astrophysical Observation", "SAO 150675"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.12878812),
        dec: Angle.Degrees(-10.43299215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115078"},
        {"Hipparcos Number", "HIP 64635"},
        {"Geneva Identification System", "GEN# +1.00115078"},
        {"Smithsonian Astrophysical Observation", "SAO 157813"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.72237869),
        dec: Angle.Degrees(-10.43244526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25990",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25990"},
        {"Smithsonian Astrophysical Observation", "SAO 150545"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.20261649),
        dec: Angle.Degrees(-10.43079284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87016"},
        {"Hipparcos Number", "HIP 49175"},
        {"Smithsonian Astrophysical Observation", "SAO 155673"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.54231107),
        dec: Angle.Degrees(-10.43046527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8601"},
        {"Hipparcos Number", "HIP 6603"},
        {"Geneva Identification System", "GEN# +1.00008601"},
        {"Smithsonian Astrophysical Observation", "SAO 147794"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.20264531),
        dec: Angle.Degrees(-10.43021519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16862"},
        {"Hipparcos Number", "HIP 12595"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.49046723),
        dec: Angle.Degrees(-10.42975265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55135"},
        {"Hipparcos Number", "HIP 34719"},
        {"Celescope Catalog", "CEL 1651"},
        {"Geneva Identification System", "GEN# +1.00055135"},
        {"Smithsonian Astrophysical Observation", "SAO 152528"},
        {"Wilson Evans Batten Catalogue", "WEB 6938"},
    },
    visualMagnitude: 7.34,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.83687739),
        dec: Angle.Degrees(-10.42883495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66643"},
        {"Hipparcos Number", "HIP 39482"},
        {"Smithsonian Astrophysical Observation", "SAO 153777"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.03592692),
        dec: Angle.Degrees(-10.42866016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194342"},
        {"Hipparcos Number", "HIP 100739"},
        {"Smithsonian Astrophysical Observation", "SAO 163554"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.36320743),
        dec: Angle.Degrees(-10.42775188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80851"},
        {"Hipparcos Number", "HIP 45925"},
        {"Geneva Identification System", "GEN# +1.00080851"},
        {"Smithsonian Astrophysical Observation", "SAO 155126"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.46390146),
        dec: Angle.Degrees(-10.42711646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210734"},
        {"Hipparcos Number", "HIP 109643"},
        {"Smithsonian Astrophysical Observation", "SAO 164925"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.16049705),
        dec: Angle.Degrees(-10.42599624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7296",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7296"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.49549041),
        dec: Angle.Degrees(-10.42386319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -213.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4845",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4845"},
        {"Geneva Identification System", "GEN# -0.01100192"},
        {"Wilson Evans Batten Catalogue", "WEB 934"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.58799588),
        dec: Angle.Degrees(-10.42342915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32913"},
        {"Hipparcos Number", "HIP 23741"},
        {"Geneva Identification System", "GEN# +1.00032913"},
        {"Smithsonian Astrophysical Observation", "SAO 150139"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.54612696),
        dec: Angle.Degrees(-10.42199502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79592",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9971 C"},
        {"Henry Draper", "HD 145996C"},
        {"Hipparcos Number", "HIP 79592"},
    },
    visualMagnitude: 9.70,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)14, 17.1900),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)25, 12.400)
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
    primaryId: "HIP 25210",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3987 AB"},
        {"Henry Draper", "HD 35320"},
        {"Hipparcos Number", "HIP 25210"},
        {"Smithsonian Astrophysical Observation", "SAO 150397"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.89496002),
        dec: Angle.Degrees(-10.41855905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34086"},
        {"Hipparcos Number", "HIP 24425"},
        {"Geneva Identification System", "GEN# +1.00034086"},
        {"Smithsonian Astrophysical Observation", "SAO 150264"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.61525138),
        dec: Angle.Degrees(-10.41663757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79588",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9971 AB"},
        {"Henry Draper", "HD 145996"},
        {"Hipparcos Number", "HIP 79588"},
        {"Smithsonian Astrophysical Observation", "SAO 159803"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.56885980),
        dec: Angle.Degrees(-10.41445350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169312"},
        {"Hipparcos Number", "HIP 90217"},
        {"Smithsonian Astrophysical Observation", "SAO 161439"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.12358578),
        dec: Angle.Degrees(-10.41436743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45680",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7297 AB"},
        {"Henry Draper", "HD 80314"},
        {"Hipparcos Number", "HIP 45680"},
        {"Smithsonian Astrophysical Observation", "SAO 155081"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.69042772),
        dec: Angle.Degrees(-10.41335420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37808"},
        {"Hipparcos Number", "HIP 26728"},
        {"Celescope Catalog", "CEL 925"},
        {"Geneva Identification System", "GEN# +1.00037808"},
        {"Renson", "Renson 10210"},
        {"Smithsonian Astrophysical Observation", "SAO 150680"},
    },
    visualMagnitude: 6.46,
    bvColour: -0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.19246778),
        dec: Angle.Degrees(-10.40866370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16946"},
        {"Hipparcos Number", "HIP 12660"},
        {"Smithsonian Astrophysical Observation", "SAO 148563"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.67064617),
        dec: Angle.Degrees(-10.40783396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216095"},
        {"Hipparcos Number", "HIP 112757"},
        {"Smithsonian Astrophysical Observation", "SAO 165326"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.52891168),
        dec: Angle.Degrees(-10.40779471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50944",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50944"},
        {"Geneva Identification System", "GEN# -0.00903063"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.06157227),
        dec: Angle.Degrees(-10.40526382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 281.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -247.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87007"},
        {"Hipparcos Number", "HIP 49161"},
        {"Smithsonian Astrophysical Observation", "SAO 155669"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.49468792),
        dec: Angle.Degrees(-10.40521354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -228.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106464"},
        {"Hipparcos Number", "HIP 59720"},
        {"Smithsonian Astrophysical Observation", "SAO 157166"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.71622770),
        dec: Angle.Degrees(-10.40048289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96926"},
        {"Hipparcos Number", "HIP 54531"},
        {"Smithsonian Astrophysical Observation", "SAO 156500"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.37786156),
        dec: Angle.Degrees(-10.39703110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -151.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172574"},
        {"Hipparcos Number", "HIP 91657"},
        {"Smithsonian Astrophysical Observation", "SAO 161728"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.36292215),
        dec: Angle.Degrees(-10.39638582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133073"},
        {"Hipparcos Number", "HIP 73615"},
        {"Smithsonian Astrophysical Observation", "SAO 158990"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.71459447),
        dec: Angle.Degrees(-10.39230543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26750"},
        {"Hipparcos Number", "HIP 19717"},
        {"Smithsonian Astrophysical Observation", "SAO 149466"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.37343298),
        dec: Angle.Degrees(-10.38708061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33693"},
        {"Hipparcos Number", "HIP 24191"},
        {"Geneva Identification System", "GEN# +1.00033693"},
        {"Smithsonian Astrophysical Observation", "SAO 150213"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.90484505),
        dec: Angle.Degrees(-10.38703048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14460"},
        {"Hipparcos Number", "HIP 10869"},
        {"Smithsonian Astrophysical Observation", "SAO 148335"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.97028994),
        dec: Angle.Degrees(-10.38575223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36878",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36878"},
        {"Cincinnati Publication", "Ci 20 428"},
        {"Geneva Identification System", "GEN# +6.10220390"},
        {"Wilson Evans Batten Catalogue", "WEB 7325"},
    },
    visualMagnitude: 11.14,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.71961395),
        dec: Angle.Degrees(-10.38496023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 422.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -482.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109618"},
        {"Hipparcos Number", "HIP 61508"},
        {"Smithsonian Astrophysical Observation", "SAO 157388"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.03534356),
        dec: Angle.Degrees(-10.38424980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105827"},
        {"Hipparcos Number", "HIP 59377"},
        {"Smithsonian Astrophysical Observation", "SAO 157129"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.829,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.73542125),
        dec: Angle.Degrees(-10.38396735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -232.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200848"},
        {"Hipparcos Number", "HIP 104167"},
        {"Geneva Identification System", "GEN# +1.00200848"},
        {"Smithsonian Astrophysical Observation", "SAO 164136"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.58585221),
        dec: Angle.Degrees(-10.38185384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174142"},
        {"Hipparcos Number", "HIP 92377"},
        {"Smithsonian Astrophysical Observation", "SAO 161876"},
        {"Wilson Evans Batten Catalogue", "WEB 15951"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.38356930),
        dec: Angle.Degrees(-10.37997497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67619",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67619"},
        {"Smithsonian Astrophysical Observation", "SAO 158199"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.83434461),
        dec: Angle.Degrees(-10.37982560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34022"},
        {"Hipparcos Number", "HIP 24391"},
        {"Smithsonian Astrophysical Observation", "SAO 150254"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.49595498),
        dec: Angle.Degrees(-10.37799585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117270"},
        {"Hipparcos Number", "HIP 65801"},
        {"Smithsonian Astrophysical Observation", "SAO 157961"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.32405602),
        dec: Angle.Degrees(-10.37752632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122289"},
        {"Hipparcos Number", "HIP 68483"},
        {"Smithsonian Astrophysical Observation", "SAO 158294"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.30828444),
        dec: Angle.Degrees(-10.37723615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193397"},
        {"Hipparcos Number", "HIP 100272"},
        {"Geneva Identification System", "GEN# +1.00193397"},
        {"Smithsonian Astrophysical Observation", "SAO 163463"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.07975775),
        dec: Angle.Degrees(-10.37517521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18385"},
        {"Hipparcos Number", "HIP 13740"},
        {"Geneva Identification System", "GEN# +1.00018385"},
        {"Smithsonian Astrophysical Observation", "SAO 148679"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.22783769),
        dec: Angle.Degrees(-10.37503510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8509",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1454 AB"},
        {"Henry Draper", "HD 11181"},
        {"Hipparcos Number", "HIP 8509"},
        {"Smithsonian Astrophysical Observation", "SAO 148039"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.43085735),
        dec: Angle.Degrees(-10.37409847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162796"},
        {"Hipparcos Number", "HIP 87552"},
        {"Geneva Identification System", "GEN# +1.00162796"},
        {"Smithsonian Astrophysical Observation", "SAO 160889"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.29826998),
        dec: Angle.Degrees(-10.37168384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125729"},
        {"Hipparcos Number", "HIP 70183"},
        {"Smithsonian Astrophysical Observation", "SAO 158512"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.38678721),
        dec: Angle.Degrees(-10.37109069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219593"},
        {"Hipparcos Number", "HIP 114959"},
        {"Geneva Identification System", "GEN# +1.00219593"},
        {"Smithsonian Astrophysical Observation", "SAO 165603"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.26744604),
        dec: Angle.Degrees(-10.37087598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82477"},
        {"Hipparcos Number", "HIP 46768"},
        {"Geneva Identification System", "GEN# +1.00082477"},
        {"Smithsonian Astrophysical Observation", "SAO 155262"},
    },
    visualMagnitude: 6.12,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.98237229),
        dec: Angle.Degrees(-10.37039237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115062"},
        {"Hipparcos Number", "HIP 64625"},
        {"Geneva Identification System", "GEN# +1.00115062"},
        {"Smithsonian Astrophysical Observation", "SAO 157811"},
        {"Wilson Evans Batten Catalogue", "WEB 11431"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.68803322),
        dec: Angle.Degrees(-10.37027582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219450"},
        {"Hipparcos Number", "HIP 114858"},
        {"Smithsonian Astrophysical Observation", "SAO 165596"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.97890558),
        dec: Angle.Degrees(-10.36777269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184642"},
        {"Hipparcos Number", "HIP 96388"},
        {"Smithsonian Astrophysical Observation", "SAO 162804"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.95462225),
        dec: Angle.Degrees(-10.36498492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91247"},
        {"Hipparcos Number", "HIP 51569"},
        {"Smithsonian Astrophysical Observation", "SAO 156038"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.99772400),
        dec: Angle.Degrees(-10.35503682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161404"},
        {"Hipparcos Number", "HIP 86936"},
        {"Smithsonian Astrophysical Observation", "SAO 160806"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.46139175),
        dec: Angle.Degrees(-10.35396547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97766",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13028 AB"},
        {"Henry Draper", "HD 187774"},
        {"Hipparcos Number", "HIP 97766"},
        {"Renson", "Renson 51830"},
        {"Smithsonian Astrophysical Observation", "SAO 163059"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.00787135),
        dec: Angle.Degrees(-10.35374217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31952"},
        {"Hipparcos Number", "HIP 23190"},
        {"Smithsonian Astrophysical Observation", "SAO 150055"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.85470340),
        dec: Angle.Degrees(-10.35361740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5489",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5489"},
        {"Geneva Identification System", "GEN# -0.01100220"},
        {"Smithsonian Astrophysical Observation", "SAO 147649"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.56642317),
        dec: Angle.Degrees(-10.35320792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 285.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15906"},
        {"Hipparcos Number", "HIP 11865"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.27243708),
        dec: Angle.Degrees(-10.35155680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -172.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179600"},
        {"Hipparcos Number", "HIP 94464"},
        {"Smithsonian Astrophysical Observation", "SAO 162335"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.39969704),
        dec: Angle.Degrees(-10.34932388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24991",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24991"},
        {"Smithsonian Astrophysical Observation", "SAO 150363"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.26999900),
        dec: Angle.Degrees(-10.34922516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104938",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14786 A"},
        {"Henry Draper", "HD 202332"},
        {"Hipparcos Number", "HIP 104938"},
        {"Smithsonian Astrophysical Observation", "SAO 164257"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.84906371),
        dec: Angle.Degrees(-10.34797442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183170"},
        {"Hipparcos Number", "HIP 95763"},
        {"Smithsonian Astrophysical Observation", "SAO 162655"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.16022380),
        dec: Angle.Degrees(-10.34697330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54662"},
        {"Hipparcos Number", "HIP 34536"},
        {"Celescope Catalog", "CEL 1615"},
        {"Geneva Identification System", "GEN# +1.00054662"},
        {"Smithsonian Astrophysical Observation", "SAO 152470"},
        {"Wilson Evans Batten Catalogue", "WEB 6913"},
    },
    visualMagnitude: 6.23,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.33437727),
        dec: Angle.Degrees(-10.34657429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20803"},
        {"Hipparcos Number", "HIP 15590"},
        {"Geneva Identification System", "GEN# +1.00020803"},
        {"Smithsonian Astrophysical Observation", "SAO 148910"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.19553202),
        dec: Angle.Degrees(-10.34411929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189136"},
        {"Hipparcos Number", "HIP 98344"},
        {"Smithsonian Astrophysical Observation", "SAO 163153"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.71524185),
        dec: Angle.Degrees(-10.34345335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10047"},
        {"Hipparcos Number", "HIP 7611"},
        {"Smithsonian Astrophysical Observation", "SAO 147920"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.51886289),
        dec: Angle.Degrees(-10.33991588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96646",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12725 A"},
        {"Henry Draper", "HD 185342"},
        {"Hipparcos Number", "HIP 96646"},
        {"Geneva Identification System", "GEN# +1.00185342A"},
        {"Smithsonian Astrophysical Observation", "SAO 162847"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.73541266),
        dec: Angle.Degrees(-10.33906638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62743",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8684 A"},
        {"Henry Draper", "HD 111720"},
        {"Hipparcos Number", "HIP 62743"},
        {"Geneva Identification System", "GEN# +1.00111720A"},
        {"Smithsonian Astrophysical Observation", "SAO 157550"},
        {"Wilson Evans Batten Catalogue", "WEB 11125"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.84555077),
        dec: Angle.Degrees(-10.33821106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161205"},
        {"Hipparcos Number", "HIP 86832"},
        {"Fundamental Katalog 5th Edition", "FK5 5558"},
        {"Geneva Identification System", "GEN# +1.00161205"},
        {"Smithsonian Astrophysical Observation", "SAO 160794"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.14448225),
        dec: Angle.Degrees(-10.33629925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8645",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Baten Kaitos"},
        {"Henry Draper", "HD 11353"},
        {"Hipparcos Number", "HIP 8645"},
        {"Fundamental Katalog 5th Edition", "FK5 62"},
        {"Geneva Identification System", "GEN# +1.00011353"},
        {"Smithsonian Astrophysical Observation", "SAO 148059"},
        {"Wilson Evans Batten Catalogue", "WEB 1828"},
    },
    visualMagnitude: 3.74,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.86504416),
        dec: Angle.Degrees(-10.33494526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123630"},
        {"Hipparcos Number", "HIP 69127"},
        {"Geneva Identification System", "GEN# +1.00123630"},
        {"Smithsonian Astrophysical Observation", "SAO 158385"},
        {"Wilson Evans Batten Catalogue", "WEB 12070"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.25248994),
        dec: Angle.Degrees(-10.33459910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148497"},
        {"Hipparcos Number", "HIP 80724"},
        {"Smithsonian Astrophysical Observation", "SAO 159938"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.21999562),
        dec: Angle.Degrees(-10.33419976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96643",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12725 B"},
        {"Hipparcos Number", "HIP 96643"},
        {"Geneva Identification System", "GEN# +1.00185342B"},
        {"Smithsonian Astrophysical Observation", "SAO 162845"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.73251776),
        dec: Angle.Degrees(-10.33402871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98569",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98569"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.32679300),
        dec: Angle.Degrees(-10.33044702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137208"},
        {"Hipparcos Number", "HIP 75475"},
        {"Smithsonian Astrophysical Observation", "SAO 159245"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.27568996),
        dec: Angle.Degrees(-10.33021182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114287"},
        {"Hipparcos Number", "HIP 64224"},
        {"Geneva Identification System", "GEN# +1.00114287"},
        {"Smithsonian Astrophysical Observation", "SAO 157760"},
        {"Wilson Evans Batten Catalogue", "WEB 11353"},
    },
    visualMagnitude: 5.95,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.43870138),
        dec: Angle.Degrees(-10.32930884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118247"},
        {"Hipparcos Number", "HIP 66335"},
        {"Smithsonian Astrophysical Observation", "SAO 158030"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.92624704),
        dec: Angle.Degrees(-10.32929440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35536"},
        {"Hipparcos Number", "HIP 25329"},
        {"Geneva Identification System", "GEN# +1.00035536"},
        {"Smithsonian Astrophysical Observation", "SAO 150420"},
        {"Wilson Evans Batten Catalogue", "WEB 4912"},
    },
    visualMagnitude: 5.60,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.25725926),
        dec: Angle.Degrees(-10.32884540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59381"},
        {"Hipparcos Number", "HIP 36396"},
        {"Fundamental Katalog 5th Edition", "FK5 2579"},
        {"Geneva Identification System", "GEN# +1.00059381"},
        {"Smithsonian Astrophysical Observation", "SAO 152941"},
        {"Wilson Evans Batten Catalogue", "WEB 7246"},
    },
    visualMagnitude: 5.75,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.34212843),
        dec: Angle.Degrees(-10.32665700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168892"},
        {"Hipparcos Number", "HIP 90050"},
        {"Smithsonian Astrophysical Observation", "SAO 161397"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.62949075),
        dec: Angle.Degrees(-10.32591793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95178"},
        {"Hipparcos Number", "HIP 53705"},
        {"Smithsonian Astrophysical Observation", "SAO 156367"},
    },
    visualMagnitude: 7.25,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.82443928),
        dec: Angle.Degrees(-10.32544222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63873",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63873"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.36253470),
        dec: Angle.Degrees(-10.32491284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144637"},
        {"Hipparcos Number", "HIP 78965"},
        {"Smithsonian Astrophysical Observation", "SAO 159710"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.80551671),
        dec: Angle.Degrees(-10.32455995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123380"},
        {"Hipparcos Number", "HIP 68993"},
        {"Geneva Identification System", "GEN# +1.00123380"},
        {"Smithsonian Astrophysical Observation", "SAO 158366"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.87116221),
        dec: Angle.Degrees(-10.32362618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204513"},
        {"Hipparcos Number", "HIP 106087"},
        {"Smithsonian Astrophysical Observation", "SAO 164427"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.34387665),
        dec: Angle.Degrees(-10.32362449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18655",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2921 AB"},
        {"Henry Draper", "HD 25164"},
        {"Hipparcos Number", "HIP 18655"},
        {"Smithsonian Astrophysical Observation", "SAO 149300"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.90361635),
        dec: Angle.Degrees(-10.32292304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137052"},
        {"Hipparcos Number", "HIP 75379"},
        {"Geneva Identification System", "GEN# +1.00137052"},
        {"Smithsonian Astrophysical Observation", "SAO 159234"},
        {"Wilson Evans Batten Catalogue", "WEB 12860"},
    },
    visualMagnitude: 4.92,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.04970889),
        dec: Angle.Degrees(-10.32189476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88517"},
        {"Hipparcos Number", "HIP 49989"},
        {"Smithsonian Astrophysical Observation", "SAO 155810"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.08009742),
        dec: Angle.Degrees(-10.32144191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24146"},
        {"Hipparcos Number", "HIP 17965"},
        {"Smithsonian Astrophysical Observation", "SAO 149201"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.60579908),
        dec: Angle.Degrees(-10.31983401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81916"},
        {"Hipparcos Number", "HIP 46444"},
        {"Smithsonian Astrophysical Observation", "SAO 155215"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.08729335),
        dec: Angle.Degrees(-10.31884033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219129"},
        {"Hipparcos Number", "HIP 114666"},
        {"Geneva Identification System", "GEN# +1.00219129"},
        {"Smithsonian Astrophysical Observation", "SAO 165568"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.42377927),
        dec: Angle.Degrees(-10.31871876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63265"},
        {"Hipparcos Number", "HIP 38036"},
        {"Smithsonian Astrophysical Observation", "SAO 153403"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.93565176),
        dec: Angle.Degrees(-10.31745652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198599"},
        {"Hipparcos Number", "HIP 102975"},
        {"Geneva Identification System", "GEN# +1.00198599"},
        {"Smithsonian Astrophysical Observation", "SAO 163938"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.94706134),
        dec: Angle.Degrees(-10.31725640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55879"},
        {"Hipparcos Number", "HIP 34999"},
        {"Celescope Catalog", "CEL 1695"},
        {"Geneva Identification System", "GEN# +2.23530001"},
        {"Smithsonian Astrophysical Observation", "SAO 152598"},
        {"Wilson Evans Batten Catalogue", "WEB 7000"},
        {"New General Catalogue", "NGC 2353 1"},
    },
    visualMagnitude: 6.02,
    bvColour: -0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.61773082),
        dec: Angle.Degrees(-10.31624854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51726"},
        {"Hipparcos Number", "HIP 33534"},
        {"Smithsonian Astrophysical Observation", "SAO 152175"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.53555537),
        dec: Angle.Degrees(-10.31572506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83008"},
        {"Hipparcos Number", "HIP 47050"},
        {"Smithsonian Astrophysical Observation", "SAO 155316"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.82498910),
        dec: Angle.Degrees(-10.31380753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191087"},
        {"Hipparcos Number", "HIP 99218"},
        {"Geneva Identification System", "GEN# +1.00191087"},
        {"Smithsonian Astrophysical Observation", "SAO 163288"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.12458469),
        dec: Angle.Degrees(-10.31314780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208922"},
        {"Hipparcos Number", "HIP 108582"},
        {"Geneva Identification System", "GEN# +1.00208922"},
        {"Smithsonian Astrophysical Observation", "SAO 164799"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.93954481),
        dec: Angle.Degrees(-10.31307232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102574"},
        {"Hipparcos Number", "HIP 57587"},
        {"Geneva Identification System", "GEN# +1.00102574"},
        {"Smithsonian Astrophysical Observation", "SAO 156896"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.09812514),
        dec: Angle.Degrees(-10.31283950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208008"},
        {"Hipparcos Number", "HIP 108058"},
        {"Geneva Identification System", "GEN# +1.00208008J"},
        {"Smithsonian Astrophysical Observation", "SAO 164717"},
        {"Wilson Evans Batten Catalogue", "WEB 19479"},
    },
    visualMagnitude: 6.57,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.40011001),
        dec: Angle.Degrees(-10.31161664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47802"},
        {"Hipparcos Number", "HIP 31906"},
        {"Geneva Identification System", "GEN# +1.00047802"},
        {"Renson", "Renson 12860"},
        {"Smithsonian Astrophysical Observation", "SAO 151769"},
    },
    visualMagnitude: 8.54,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.02627871),
        dec: Angle.Degrees(-10.31075726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106516"},
        {"Hipparcos Number", "HIP 59750"},
        {"Cincinnati Publication", "Ci 20 693"},
        {"Geneva Identification System", "GEN# +1.00106516"},
        {"Smithsonian Astrophysical Observation", "SAO 157168"},
        {"Wilson Evans Batten Catalogue", "WEB 10618"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.79391146),
        dec: Angle.Degrees(-10.30993958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1012.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47040",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47040"},
    },
    visualMagnitude: 11.39,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.79953868),
        dec: Angle.Degrees(-10.30900766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -175.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193844"},
        {"Hipparcos Number", "HIP 100492"},
        {"Smithsonian Astrophysical Observation", "SAO 163509"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.67393980),
        dec: Angle.Degrees(-10.30169877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 219.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216626"},
        {"Hipparcos Number", "HIP 113123"},
        {"Smithsonian Astrophysical Observation", "SAO 165373"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.62512854),
        dec: Angle.Degrees(-10.29950750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84423",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10421 AB"},
        {"Henry Draper", "HD 156023"},
        {"Hipparcos Number", "HIP 84423"},
        {"Geneva Identification System", "GEN# +1.00156023J"},
        {"Smithsonian Astrophysical Observation", "SAO 160405"},
        {"Wilson Evans Batten Catalogue", "WEB 14252"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.89442169),
        dec: Angle.Degrees(-10.29749506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9419"},
        {"Hipparcos Number", "HIP 7178"},
        {"Geneva Identification System", "GEN# +1.00009419"},
        {"Smithsonian Astrophysical Observation", "SAO 147872"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.12973165),
        dec: Angle.Degrees(-10.29746862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104788"},
        {"Hipparcos Number", "HIP 58830"},
        {"Geneva Identification System", "GEN# +1.00104788"},
        {"Renson", "Renson 30320"},
        {"Smithsonian Astrophysical Observation", "SAO 157069"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.00147270),
        dec: Angle.Degrees(-10.29615015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25921"},
        {"Hipparcos Number", "HIP 19116"},
        {"Geneva Identification System", "GEN# +1.00025921"},
        {"Smithsonian Astrophysical Observation", "SAO 149368"},
        {"Wilson Evans Batten Catalogue", "WEB 3670"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.47533839),
        dec: Angle.Degrees(-10.29581615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141062"},
        {"Hipparcos Number", "HIP 77342"},
        {"Smithsonian Astrophysical Observation", "SAO 159496"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.84305036),
        dec: Angle.Degrees(-10.29557450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98591"},
        {"Hipparcos Number", "HIP 55389"},
        {"Smithsonian Astrophysical Observation", "SAO 156618"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.13043875),
        dec: Angle.Degrees(-10.29455236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96167"},
        {"Hipparcos Number", "HIP 54195"},
        {"Geneva Identification System", "GEN# +1.00096167"},
        {"Smithsonian Astrophysical Observation", "SAO 156444"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.31291196),
        dec: Angle.Degrees(-10.29128324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30963"},
        {"Hipparcos Number", "HIP 22588"},
        {"Smithsonian Astrophysical Observation", "SAO 149937"},
    },
    visualMagnitude: 7.27,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.91354812),
        dec: Angle.Degrees(-10.29032790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23528"},
        {"Hipparcos Number", "HIP 17559"},
        {"Smithsonian Astrophysical Observation", "SAO 149151"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.40917370),
        dec: Angle.Degrees(-10.28920429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42883"},
        {"Hipparcos Number", "HIP 29489"},
        {"Smithsonian Astrophysical Observation", "SAO 151225"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.21209617),
        dec: Angle.Degrees(-10.28919620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54569",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54569"},
        {"Geneva Identification System", "GEN# -0.00903222"},
    },
    visualMagnitude: 10.48,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.49033086),
        dec: Angle.Degrees(-10.28533468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131716"},
        {"Hipparcos Number", "HIP 73031"},
        {"Smithsonian Astrophysical Observation", "SAO 158896"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.87949336),
        dec: Angle.Degrees(-10.28151027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51479"},
        {"Hipparcos Number", "HIP 33432"},
        {"Geneva Identification System", "GEN# +1.00051479"},
        {"Smithsonian Astrophysical Observation", "SAO 152147"},
    },
    visualMagnitude: 8.44,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.28304613),
        dec: Angle.Degrees(-10.27987213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13784",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13784"},
        {"Smithsonian Astrophysical Observation", "SAO 148684"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.36790348),
        dec: Angle.Degrees(-10.27913430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155515"},
        {"Hipparcos Number", "HIP 84182"},
        {"Geneva Identification System", "GEN# +1.00155515"},
        {"Smithsonian Astrophysical Observation", "SAO 160364"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.13076624),
        dec: Angle.Degrees(-10.27810899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12901"},
        {"Hipparcos Number", "HIP 9807"},
        {"Geneva Identification System", "GEN# +1.00012901"},
        {"Smithsonian Astrophysical Observation", "SAO 148199"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.54458754),
        dec: Angle.Degrees(-10.27614984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69427",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Kang"},
        {"Henry Draper", "HD 124294"},
        {"Hipparcos Number", "HIP 69427"},
        {"Fundamental Katalog 5th Edition", "FK5 523"},
        {"Geneva Identification System", "GEN# +1.00124294"},
        {"Smithsonian Astrophysical Observation", "SAO 158427"},
        {"Wilson Evans Batten Catalogue", "WEB 12101"},
    },
    visualMagnitude: 4.18,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.22392088),
        dec: Angle.Degrees(-10.27404400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 140.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161904"},
        {"Hipparcos Number", "HIP 87177"},
        {"Smithsonian Astrophysical Observation", "SAO 160833"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.16159155),
        dec: Angle.Degrees(-10.27382236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76668",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76668"},
        {"Geneva Identification System", "GEN# -0.00904191"},
    },
    visualMagnitude: 10.18,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.84136358),
        dec: Angle.Degrees(-10.27281773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52212"},
        {"Hipparcos Number", "HIP 33687"},
        {"Geneva Identification System", "GEN# +1.00052212"},
        {"Smithsonian Astrophysical Observation", "SAO 152217"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.98006591),
        dec: Angle.Degrees(-10.27276893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81956"},
        {"Hipparcos Number", "HIP 46474"},
        {"Smithsonian Astrophysical Observation", "SAO 155220"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.17530242),
        dec: Angle.Degrees(-10.27110016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56213",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56213"},
    },
    visualMagnitude: 11.37,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.85297388),
        dec: Angle.Degrees(-10.27031596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -308.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60873"},
        {"Hipparcos Number", "HIP 36997"},
        {"Geneva Identification System", "GEN# +1.00060873"},
        {"Smithsonian Astrophysical Observation", "SAO 153123"},
        {"Wilson Evans Batten Catalogue", "WEB 7340"},
    },
    visualMagnitude: 8.35,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.06332513),
        dec: Angle.Degrees(-10.26784237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102358"},
        {"Hipparcos Number", "HIP 57472"},
        {"Smithsonian Astrophysical Observation", "SAO 138401"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.71775543),
        dec: Angle.Degrees(-10.26739153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57985"},
        {"Hipparcos Number", "HIP 35827"},
        {"Smithsonian Astrophysical Observation", "SAO 152795"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.82702753),
        dec: Angle.Degrees(-10.26610561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27720"},
        {"Hipparcos Number", "HIP 20409"},
        {"Renson", "Renson 7107"},
        {"Smithsonian Astrophysical Observation", "SAO 149585"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.55172877),
        dec: Angle.Degrees(-10.26504092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32008"},
        {"Hipparcos Number", "HIP 23221"},
        {"Fundamental Katalog 5th Edition", "FK5 2375"},
        {"Geneva Identification System", "GEN# +1.00032008"},
        {"Smithsonian Astrophysical Observation", "SAO 150060"},
        {"Wilson Evans Batten Catalogue", "WEB 4512"},
    },
    visualMagnitude: 5.39,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.96017027),
        dec: Angle.Degrees(-10.26299266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216882"},
        {"Hipparcos Number", "HIP 113310"},
        {"Smithsonian Astrophysical Observation", "SAO 165395"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.20580934),
        dec: Angle.Degrees(-10.26293349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117637"},
        {"Hipparcos Number", "HIP 65991"},
        {"Smithsonian Astrophysical Observation", "SAO 157984"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.95239733),
        dec: Angle.Degrees(-10.25867364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9335"},
        {"Hipparcos Number", "HIP 7125"},
        {"Smithsonian Astrophysical Observation", "SAO 147863"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.94903289),
        dec: Angle.Degrees(-10.25728380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12126",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12126"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.05474638),
        dec: Angle.Degrees(-10.25650985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19777",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3079 A"},
        {"Henry Draper", "HD 26846"},
        {"Hipparcos Number", "HIP 19777"},
        {"Geneva Identification System", "GEN# +1.00026846"},
        {"Smithsonian Astrophysical Observation", "SAO 149478"},
        {"Wilson Evans Batten Catalogue", "WEB 3773"},
    },
    visualMagnitude: 4.87,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.59872149),
        dec: Angle.Degrees(-10.25588890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207983"},
        {"Hipparcos Number", "HIP 108043"},
        {"Smithsonian Astrophysical Observation", "SAO 164715"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.33976162),
        dec: Angle.Degrees(-10.25556032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84667"},
        {"Hipparcos Number", "HIP 47971"},
        {"Geneva Identification System", "GEN# +1.00084667"},
        {"Smithsonian Astrophysical Observation", "SAO 155469"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.66262952),
        dec: Angle.Degrees(-10.25334659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13292",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13292"},
        {"Smithsonian Astrophysical Observation", "SAO 148638"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.76858597),
        dec: Angle.Degrees(-10.25332911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19366"},
        {"Hipparcos Number", "HIP 14455"},
        {"Geneva Identification System", "GEN# +1.00019366"},
        {"Smithsonian Astrophysical Observation", "SAO 148771"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.63899931),
        dec: Angle.Degrees(-10.25194445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93834"},
        {"Hipparcos Number", "HIP 52955"},
        {"Smithsonian Astrophysical Observation", "SAO 137816"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.45653438),
        dec: Angle.Degrees(-10.25183211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42679"},
        {"Hipparcos Number", "HIP 29393"},
        {"Smithsonian Astrophysical Observation", "SAO 151201"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.91991854),
        dec: Angle.Degrees(-10.25074243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182847"},
        {"Hipparcos Number", "HIP 95618"},
        {"Smithsonian Astrophysical Observation", "SAO 162628"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.73517827),
        dec: Angle.Degrees(-10.25040050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111182"},
        {"Hipparcos Number", "HIP 62418"},
        {"Smithsonian Astrophysical Observation", "SAO 138965"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.87992569),
        dec: Angle.Degrees(-10.24985676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118866"},
        {"Hipparcos Number", "HIP 66646"},
        {"Smithsonian Astrophysical Observation", "SAO 139472"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.93320303),
        dec: Angle.Degrees(-10.24766872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41547"},
        {"Hipparcos Number", "HIP 28854"},
        {"Geneva Identification System", "GEN# +1.00041547"},
        {"Smithsonian Astrophysical Observation", "SAO 151098"},
        {"Wilson Evans Batten Catalogue", "WEB 5645"},
    },
    visualMagnitude: 5.88,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.36258158),
        dec: Angle.Degrees(-10.24265912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11964A"},
        {"Henry Draper 2", "HD 11964"},
        {"Hipparcos Number", "HIP 9094"},
        {"Cincinnati Publication", "Ci 20 135"},
        {"Cincinnati Publication 2", "Ci 18 259"},
        {"Geneva Identification System", "GEN# +1.00011964A"},
        {"Smithsonian Astrophysical Observation", "SAO 148123"},
        {"Wilson Evans Batten Catalogue", "WEB 1909"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.29093654),
        dec: Angle.Degrees(-10.24183649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -368.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -243.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92340",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92340"},
        {"Smithsonian Astrophysical Observation", "SAO 161860"},
        {"Wilson Evans Batten Catalogue", "WEB 15946"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.29690871),
        dec: Angle.Degrees(-10.24108233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25710"},
        {"Hipparcos Number", "HIP 19016"},
        {"Geneva Identification System", "GEN# +1.00025710"},
        {"Smithsonian Astrophysical Observation", "SAO 149352"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.11117255),
        dec: Angle.Degrees(-10.23512445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51939"},
        {"Hipparcos Number", "HIP 33604"},
        {"Celescope Catalog", "CEL 1472"},
        {"Geneva Identification System", "GEN# +1.00051939"},
        {"Smithsonian Astrophysical Observation", "SAO 152195"},
    },
    visualMagnitude: 8.64,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.73807191),
        dec: Angle.Degrees(-10.22935645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51007",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51007"},
        {"Geneva Identification System", "GEN# -0.00903070"},
    },
    visualMagnitude: 10.15,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.29686702),
        dec: Angle.Degrees(-10.22898726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -689.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222421"},
        {"Hipparcos Number", "HIP 116811"},
        {"Smithsonian Astrophysical Observation", "SAO 165823"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.12036023),
        dec: Angle.Degrees(-10.22774467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110296",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110296"},
        {"Smithsonian Astrophysical Observation", "SAO 165010"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.10923482),
        dec: Angle.Degrees(-10.22744204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170248"},
        {"Hipparcos Number", "HIP 90565"},
        {"Geneva Identification System", "GEN# +1.00170248"},
        {"Smithsonian Astrophysical Observation", "SAO 161514"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.19866781),
        dec: Angle.Degrees(-10.22642060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74929"},
        {"Hipparcos Number", "HIP 43090"},
        {"Smithsonian Astrophysical Observation", "SAO 154625"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.64789222),
        dec: Angle.Degrees(-10.22638577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30322"},
        {"Hipparcos Number", "HIP 22171"},
        {"Smithsonian Astrophysical Observation", "SAO 149872"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.54875089),
        dec: Angle.Degrees(-10.22224256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55755"},
        {"Hipparcos Number", "HIP 34951"},
        {"Geneva Identification System", "GEN# +2.23530004"},
        {"Renson", "Renson 15170"},
        {"New General Catalogue", "NGC 2353 105"},
        {"New General Catalogue 2", "NGC 2353 4"},
    },
    visualMagnitude: 9.84,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.47712651),
        dec: Angle.Degrees(-10.22131741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54363",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54363"},
    },
    visualMagnitude: 10.91,
    bvColour: 1.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.83086912),
        dec: Angle.Degrees(-10.22105781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174886"},
        {"Hipparcos Number", "HIP 92694"},
        {"Geneva Identification System", "GEN# +1.00174886"},
        {"Smithsonian Astrophysical Observation", "SAO 161940"},
        {"Wilson Evans Batten Catalogue", "WEB 16031"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.31030577),
        dec: Angle.Degrees(-10.22011982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156567"},
        {"Hipparcos Number", "HIP 84678"},
        {"Smithsonian Astrophysical Observation", "SAO 160448"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.66839022),
        dec: Angle.Degrees(-10.21926338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169009"},
        {"Hipparcos Number", "HIP 90083"},
        {"Geneva Identification System", "GEN# +1.00169009"},
        {"Renson", "Renson 47400"},
        {"Smithsonian Astrophysical Observation", "SAO 161412"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.75876704),
        dec: Angle.Degrees(-10.21892931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178487"},
        {"Hipparcos Number", "HIP 94090"},
        {"Geneva Identification System", "GEN# +1.00178487"},
        {"Smithsonian Astrophysical Observation", "SAO 162250"},
        {"Wilson Evans Batten Catalogue", "WEB 16381"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.31181880),
        dec: Angle.Degrees(-10.21774649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19657"},
        {"Hipparcos Number", "HIP 14670"},
        {"Smithsonian Astrophysical Observation", "SAO 148797"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.38646107),
        dec: Angle.Degrees(-10.21585265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55930"},
        {"Hipparcos Number", "HIP 35023"},
        {"Geneva Identification System", "GEN# +2.23530002"},
        {"Smithsonian Astrophysical Observation", "SAO 152607"},
        {"New General Catalogue", "NGC 2353 101"},
        {"New General Catalogue 2", "NGC 2353 2"},
    },
    visualMagnitude: 9.15,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.66720168),
        dec: Angle.Degrees(-10.21345994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206815"},
        {"Hipparcos Number", "HIP 107373"},
        {"Smithsonian Astrophysical Observation", "SAO 164623"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.21829077),
        dec: Angle.Degrees(-10.21329954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219516"},
        {"Hipparcos Number", "HIP 114906"},
        {"Geneva Identification System", "GEN# +1.00219516"},
        {"Smithsonian Astrophysical Observation", "SAO 165597"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.11695952),
        dec: Angle.Degrees(-10.21144038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104310",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14659 AB"},
        {"Henry Draper", "HD 201102"},
        {"Hipparcos Number", "HIP 104310"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.97034407),
        dec: Angle.Degrees(-10.21131474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15802",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15802"},
        {"Smithsonian Astrophysical Observation", "SAO 148938"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.90230363),
        dec: Angle.Degrees(-10.21074241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19543"},
        {"Hipparcos Number", "HIP 14583"},
        {"Smithsonian Astrophysical Observation", "SAO 148786"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.06693321),
        dec: Angle.Degrees(-10.21003975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201569"},
        {"Hipparcos Number", "HIP 104554"},
        {"Fundamental Katalog 5th Edition", "FK5 5867"},
        {"Geneva Identification System", "GEN# +1.00201569"},
        {"Smithsonian Astrophysical Observation", "SAO 164195"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.68457811),
        dec: Angle.Degrees(-10.20944122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126723"},
        {"Hipparcos Number", "HIP 70688"},
        {"Smithsonian Astrophysical Observation", "SAO 139943"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.87631462),
        dec: Angle.Degrees(-10.20491798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117779"},
        {"Hipparcos Number", "HIP 66064"},
        {"Smithsonian Astrophysical Observation", "SAO 139398"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.14957801),
        dec: Angle.Degrees(-10.20257285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212396"},
        {"Hipparcos Number", "HIP 110580"},
        {"Smithsonian Astrophysical Observation", "SAO 165042"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.03163396),
        dec: Angle.Degrees(-10.19767255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72076"},
        {"Hipparcos Number", "HIP 41733"},
        {"Geneva Identification System", "GEN# +1.00072076"},
        {"Smithsonian Astrophysical Observation", "SAO 154332"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.64910834),
        dec: Angle.Degrees(-10.19765358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15015"},
        {"Hipparcos Number", "HIP 11264"},
        {"Geneva Identification System", "GEN# +1.00015015"},
        {"Smithsonian Astrophysical Observation", "SAO 148378"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.25389081),
        dec: Angle.Degrees(-10.19693576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61507"},
        {"Hipparcos Number", "HIP 37281"},
        {"Smithsonian Astrophysical Observation", "SAO 153197"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.83163275),
        dec: Angle.Degrees(-10.19573338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196889"},
        {"Hipparcos Number", "HIP 102024"},
        {"Smithsonian Astrophysical Observation", "SAO 163784"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.12642033),
        dec: Angle.Degrees(-10.19547933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47386",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47386"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)39, 14.9900),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)11, 38.000)
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
    primaryId: "HIP 16777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22408"},
        {"Hipparcos Number", "HIP 16777"},
        {"Smithsonian Astrophysical Observation", "SAO 149056"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.98036073),
        dec: Angle.Degrees(-10.19074590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115945"},
        {"Hipparcos Number", "HIP 65093"},
        {"Smithsonian Astrophysical Observation", "SAO 139285"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.11691642),
        dec: Angle.Degrees(-10.19046078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53268",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53268"},
        {"Smithsonian Astrophysical Observation", "SAO 137870"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.42064294),
        dec: Angle.Degrees(-10.19043945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146434"},
        {"Hipparcos Number", "HIP 79749"},
        {"Geneva Identification System", "GEN# +1.00146434"},
        {"Smithsonian Astrophysical Observation", "SAO 159827"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.15087540),
        dec: Angle.Degrees(-10.18953927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163405"},
        {"Hipparcos Number", "HIP 87829"},
        {"Fundamental Katalog 5th Edition", "FK5 5579"},
        {"Smithsonian Astrophysical Observation", "SAO 160920"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.11240606),
        dec: Angle.Degrees(-10.18893892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51028"},
        {"Hipparcos Number", "HIP 33281"},
        {"Smithsonian Astrophysical Observation", "SAO 152101"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.83631659),
        dec: Angle.Degrees(-10.18871997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 505"},
        {"Hipparcos Number", "HIP 771"},
        {"Smithsonian Astrophysical Observation", "SAO 147110"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.37674450),
        dec: Angle.Degrees(-10.18755017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89874",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89874"},
    },
    visualMagnitude: 10.59,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.09476498),
        dec: Angle.Degrees(-10.18703609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147341"},
        {"Hipparcos Number", "HIP 80159"},
        {"Geneva Identification System", "GEN# +1.00147341"},
        {"Smithsonian Astrophysical Observation", "SAO 159879"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.43654496),
        dec: Angle.Degrees(-10.18615938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12153"},
        {"Hipparcos Number", "HIP 9271"},
        {"Geneva Identification System", "GEN# +1.00012153"},
        {"Smithsonian Astrophysical Observation", "SAO 148141"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.78622856),
        dec: Angle.Degrees(-10.18554487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120149"},
        {"Hipparcos Number", "HIP 67315"},
        {"Geneva Identification System", "GEN# +1.00120149"},
        {"Smithsonian Astrophysical Observation", "SAO 139551"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.97042499),
        dec: Angle.Degrees(-10.18327705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6805"},
        {"Hipparcos Number", "HIP 5364"},
        {"Fundamental Katalog 5th Edition", "FK5 40"},
        {"Geneva Identification System", "GEN# +1.00006805"},
        {"Smithsonian Astrophysical Observation", "SAO 147632"},
        {"Wilson Evans Batten Catalogue", "WEB 1165"},
    },
    visualMagnitude: 3.46,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.14693197),
        dec: Angle.Degrees(-10.18192800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 215.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208802"},
        {"Hipparcos Number", "HIP 108515"},
        {"Smithsonian Astrophysical Observation", "SAO 164784"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.74965076),
        dec: Angle.Degrees(-10.17963110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19177"},
        {"Hipparcos Number", "HIP 14327"},
        {"Smithsonian Astrophysical Observation", "SAO 148749"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.19496651),
        dec: Angle.Degrees(-10.17905372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181574"},
        {"Hipparcos Number", "HIP 95138"},
        {"Smithsonian Astrophysical Observation", "SAO 162509"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.34235838),
        dec: Angle.Degrees(-10.17612930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205634"},
        {"Hipparcos Number", "HIP 106709"},
        {"Geneva Identification System", "GEN# +1.00205634"},
        {"Smithsonian Astrophysical Observation", "SAO 164519"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.22939278),
        dec: Angle.Degrees(-10.17449021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21591"},
        {"Hipparcos Number", "HIP 16207"},
        {"Geneva Identification System", "GEN# +1.00021591"},
        {"Smithsonian Astrophysical Observation", "SAO 148978"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.20419127),
        dec: Angle.Degrees(-10.17012812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108489"},
        {"Hipparcos Number", "HIP 60812"},
        {"Smithsonian Astrophysical Observation", "SAO 138797"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.96236365),
        dec: Angle.Degrees(-10.16709660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69997"},
        {"Hipparcos Number", "HIP 40766"},
        {"Fundamental Katalog 5th Edition", "FK5 1218"},
        {"Geneva Identification System", "GEN# +1.00069997"},
        {"Renson", "Renson 19320"},
        {"Smithsonian Astrophysical Observation", "SAO 154105"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.81294976),
        dec: Angle.Degrees(-10.16584342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117818"},
        {"Hipparcos Number", "HIP 66098"},
        {"Fundamental Katalog 5th Edition", "FK5 3081"},
        {"Geneva Identification System", "GEN# +1.00117818"},
        {"Smithsonian Astrophysical Observation", "SAO 139401"},
        {"Wilson Evans Batten Catalogue", "WEB 11681"},
    },
    visualMagnitude: 5.21,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.24204653),
        dec: Angle.Degrees(-10.16490767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10377",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10377"},
        {"Smithsonian Astrophysical Observation", "SAO 148275"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.41954067),
        dec: Angle.Degrees(-10.16258940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62816"},
        {"Hipparcos Number", "HIP 37844"},
        {"Geneva Identification System", "GEN# +1.00062816"},
        {"Smithsonian Astrophysical Observation", "SAO 153359"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.37181427),
        dec: Angle.Degrees(-10.16066798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31504"},
        {"Hipparcos Number", "HIP 22930"},
        {"Smithsonian Astrophysical Observation", "SAO 150001"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.01879596),
        dec: Angle.Degrees(-10.16051568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103893"},
        {"Hipparcos Number", "HIP 58336"},
        {"Smithsonian Astrophysical Observation", "SAO 138503"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.44836245),
        dec: Angle.Degrees(-10.15757966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184889"},
        {"Hipparcos Number", "HIP 96479"},
        {"Smithsonian Astrophysical Observation", "SAO 162815"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.21138439),
        dec: Angle.Degrees(-10.15744473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96622",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12715 AB"},
        {"Henry Draper", "HD 185298"},
        {"Hipparcos Number", "HIP 96622"},
        {"Smithsonian Astrophysical Observation", "SAO 162843"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.68067618),
        dec: Angle.Degrees(-10.15658266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221281"},
        {"Hipparcos Number", "HIP 116048"},
        {"Geneva Identification System", "GEN# +1.00221281"},
        {"Smithsonian Astrophysical Observation", "SAO 165729"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.71430768),
        dec: Angle.Degrees(-10.15576468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55419"},
        {"Hipparcos Number", "HIP 34818"},
        {"Celescope Catalog", "CEL 1666"},
        {"Geneva Identification System", "GEN# +1.00055419"},
        {"Smithsonian Astrophysical Observation", "SAO 152553"},
    },
    visualMagnitude: 8.90,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.10980733),
        dec: Angle.Degrees(-10.15510675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119620"},
        {"Hipparcos Number", "HIP 67047"},
        {"Smithsonian Astrophysical Observation", "SAO 139522"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.11250543),
        dec: Angle.Degrees(-10.15398467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87291"},
        {"Hipparcos Number", "HIP 49304"},
        {"Geneva Identification System", "GEN# +1.00087291"},
        {"Smithsonian Astrophysical Observation", "SAO 137329"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.95384303),
        dec: Angle.Degrees(-10.15293488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171466"},
        {"Hipparcos Number", "HIP 91134"},
        {"Smithsonian Astrophysical Observation", "SAO 161640"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.84747632),
        dec: Angle.Degrees(-10.15213136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92244"},
        {"Hipparcos Number", "HIP 52121"},
        {"Smithsonian Astrophysical Observation", "SAO 137705"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.72852699),
        dec: Angle.Degrees(-10.15090077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32646"},
        {"Hipparcos Number", "HIP 23593"},
        {"Geneva Identification System", "GEN# +1.00032646"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.09316092),
        dec: Angle.Degrees(-10.14895988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -275.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173872"},
        {"Hipparcos Number", "HIP 92250"},
        {"Cincinnati Publication", "Ci 18 2460"},
        {"Smithsonian Astrophysical Observation", "SAO 161841"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.00603713),
        dec: Angle.Degrees(-10.14575215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -229.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97390"},
        {"Hipparcos Number", "HIP 54737"},
        {"Smithsonian Astrophysical Observation", "SAO 138059"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.10460311),
        dec: Angle.Degrees(-10.14547398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193624"},
        {"Hipparcos Number", "HIP 100385"},
        {"Smithsonian Astrophysical Observation", "SAO 163495"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.37361601),
        dec: Angle.Degrees(-10.14418991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148319"},
        {"Hipparcos Number", "HIP 80608"},
        {"Geneva Identification System", "GEN# +1.00148319"},
        {"Smithsonian Astrophysical Observation", "SAO 159924"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.87871302),
        dec: Angle.Degrees(-10.14279097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62423"},
        {"Hipparcos Number", "HIP 37651"},
        {"Smithsonian Astrophysical Observation", "SAO 153309"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.89693643),
        dec: Angle.Degrees(-10.14178133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50029"},
        {"Hipparcos Number", "HIP 32870"},
        {"Smithsonian Astrophysical Observation", "SAO 152004"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.74602192),
        dec: Angle.Degrees(-10.14153906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225185"},
        {"Hipparcos Number", "HIP 329"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.05137431),
        dec: Angle.Degrees(-10.14127928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202577"},
        {"Hipparcos Number", "HIP 105060"},
        {"Geneva Identification System", "GEN# +1.00202577"},
        {"Smithsonian Astrophysical Observation", "SAO 164275"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.24264707),
        dec: Angle.Degrees(-10.13497821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78128"},
        {"Hipparcos Number", "HIP 44673"},
        {"Smithsonian Astrophysical Observation", "SAO 136578"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.55510669),
        dec: Angle.Degrees(-10.13318206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140918"},
        {"Hipparcos Number", "HIP 77274"},
        {"Geneva Identification System", "GEN# +1.00140918"},
        {"Smithsonian Astrophysical Observation", "SAO 140749"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.65335807),
        dec: Angle.Degrees(-10.13222485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98356"},
        {"Hipparcos Number", "HIP 55235"},
        {"Smithsonian Astrophysical Observation", "SAO 138123"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.828,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.66610892),
        dec: Angle.Degrees(-10.12638938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -276.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12978",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12978"},
        {"Geneva Identification System", "GEN# -0.01000548"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.73217846),
        dec: Angle.Degrees(-10.12638346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69811"},
        {"Hipparcos Number", "HIP 40683"},
        {"Smithsonian Astrophysical Observation", "SAO 135750"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.58633475),
        dec: Angle.Degrees(-10.12603480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214963"},
        {"Hipparcos Number", "HIP 112071"},
        {"Geneva Identification System", "GEN# +1.00214963"},
        {"Smithsonian Astrophysical Observation", "SAO 165240"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.49974825),
        dec: Angle.Degrees(-10.12556294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92136",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11670 A"},
        {"Aitken 2", "ADS 11670 AB"},
        {"Henry Draper", "HD 173638"},
        {"Hipparcos Number", "HIP 92136"},
        {"Geneva Identification System", "GEN# +1.00173638J"},
        {"Smithsonian Astrophysical Observation", "SAO 161817"},
        {"Wilson Evans Batten Catalogue", "WEB 15883"},
    },
    visualMagnitude: 5.69,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.68051716),
        dec: Angle.Degrees(-10.12503854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53240"},
        {"Hipparcos Number", "HIP 34066"},
        {"Celescope Catalog", "CEL 1542"},
        {"Geneva Identification System", "GEN# +1.00053240"},
        {"Smithsonian Astrophysical Observation", "SAO 152308"},
        {"Wilson Evans Batten Catalogue", "WEB 6829"},
    },
    visualMagnitude: 6.44,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.98941087),
        dec: Angle.Degrees(-10.12376711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140370"},
        {"Hipparcos Number", "HIP 77019"},
        {"Geneva Identification System", "GEN# +1.00140370"},
        {"Smithsonian Astrophysical Observation", "SAO 140718"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.88656637),
        dec: Angle.Degrees(-10.12375624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66956"},
        {"Hipparcos Number", "HIP 39595"},
        {"Smithsonian Astrophysical Observation", "SAO 135483"},
    },
    visualMagnitude: 6.97,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.37156212),
        dec: Angle.Degrees(-10.12304263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195826"},
        {"Hipparcos Number", "HIP 101476"},
        {"Smithsonian Astrophysical Observation", "SAO 163682"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.47868850),
        dec: Angle.Degrees(-10.12286816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197690"},
        {"Hipparcos Number", "HIP 102455"},
        {"Smithsonian Astrophysical Observation", "SAO 163854"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.42055920),
        dec: Angle.Degrees(-10.12207185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77915"},
        {"Hipparcos Number", "HIP 44578"},
        {"Geneva Identification System", "GEN# +1.00077915"},
        {"Smithsonian Astrophysical Observation", "SAO 136561"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.23909340),
        dec: Angle.Degrees(-10.12198437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211166"},
        {"Hipparcos Number", "HIP 109895"},
        {"Smithsonian Astrophysical Observation", "SAO 164959"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.87570720),
        dec: Angle.Degrees(-10.11442124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118841"},
        {"Hipparcos Number", "HIP 66638"},
        {"Smithsonian Astrophysical Observation", "SAO 139469"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.89393927),
        dec: Angle.Degrees(-10.11389119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216738"},
        {"Hipparcos Number", "HIP 113199"},
        {"Smithsonian Astrophysical Observation", "SAO 165382"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.86035346),
        dec: Angle.Degrees(-10.11308523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164616"},
        {"Hipparcos Number", "HIP 88335"},
        {"Smithsonian Astrophysical Observation", "SAO 161019"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.60072120),
        dec: Angle.Degrees(-10.11262144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79689"},
        {"Hipparcos Number", "HIP 45407"},
        {"Smithsonian Astrophysical Observation", "SAO 136695"},
    },
    visualMagnitude: 9.63,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.79805922),
        dec: Angle.Degrees(-10.11140729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188026"},
        {"Hipparcos Number", "HIP 97888"},
        {"Smithsonian Astrophysical Observation", "SAO 163084"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.37350591),
        dec: Angle.Degrees(-10.10954556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59730"},
        {"Hipparcos Number", "HIP 36539"},
        {"Geneva Identification System", "GEN# +1.00059730"},
        {"Smithsonian Astrophysical Observation", "SAO 152986"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.74462703),
        dec: Angle.Degrees(-10.10751888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49147"},
        {"Hipparcos Number", "HIP 32474"},
        {"Celescope Catalog", "CEL 1381"},
        {"Fundamental Katalog 5th Edition", "FK5 2521"},
        {"Geneva Identification System", "GEN# +1.00049147"},
        {"Smithsonian Astrophysical Observation", "SAO 151911"},
        {"Wilson Evans Batten Catalogue", "WEB 6549"},
    },
    visualMagnitude: 5.66,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.66259605),
        dec: Angle.Degrees(-10.10736196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114466"},
        {"Hipparcos Number", "HIP 64308"},
        {"Smithsonian Astrophysical Observation", "SAO 139199"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.70936190),
        dec: Angle.Degrees(-10.10297361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215097"},
        {"Hipparcos Number", "HIP 112161"},
        {"Smithsonian Astrophysical Observation", "SAO 165248"},
        {"Wilson Evans Batten Catalogue", "WEB 20013"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.75509173),
        dec: Angle.Degrees(-10.10271078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214529"},
        {"Hipparcos Number", "HIP 111822"},
        {"Geneva Identification System", "GEN# +1.00214529"},
        {"Smithsonian Astrophysical Observation", "SAO 165215"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.73996003),
        dec: Angle.Degrees(-10.10231449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79071",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9932 AB"},
        {"Henry Draper", "HD 144892"},
        {"Hipparcos Number", "HIP 79071"},
        {"Geneva Identification System", "GEN# +1.00144892"},
        {"Smithsonian Astrophysical Observation", "SAO 140981"},
        {"Wilson Evans Batten Catalogue", "WEB 13365"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.11345578),
        dec: Angle.Degrees(-10.10204063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64438",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64438"},
    },
    visualMagnitude: 12.00,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.10630760),
        dec: Angle.Degrees(-10.10090980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6866"},
        {"Hipparcos Number", "HIP 5396"},
        {"Geneva Identification System", "GEN# +1.00006866"},
        {"Smithsonian Astrophysical Observation", "SAO 147635"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.26060305),
        dec: Angle.Degrees(-10.10040181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9850",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9850"},
        {"Smithsonian Astrophysical Observation", "SAO 148207"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.67686487),
        dec: Angle.Degrees(-10.10021944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65412",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65412"},
        {"Smithsonian Astrophysical Observation", "SAO 139318"},
    },
    visualMagnitude: 10.01,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.10468227),
        dec: Angle.Degrees(-10.09694525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123236"},
        {"Hipparcos Number", "HIP 68921"},
        {"Smithsonian Astrophysical Observation", "SAO 139735"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.64224071),
        dec: Angle.Degrees(-10.09647891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158577"},
        {"Hipparcos Number", "HIP 85675"},
        {"Smithsonian Astrophysical Observation", "SAO 160596"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.62208658),
        dec: Angle.Degrees(-10.09618656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185967"},
        {"Hipparcos Number", "HIP 96916"},
        {"Smithsonian Astrophysical Observation", "SAO 162908"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.50834633),
        dec: Angle.Degrees(-10.09210558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76708"},
        {"Hipparcos Number", "HIP 43992"},
        {"Smithsonian Astrophysical Observation", "SAO 136442"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.37651969),
        dec: Angle.Degrees(-10.09173212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58693"},
        {"Hipparcos Number", "HIP 36120"},
        {"Smithsonian Astrophysical Observation", "SAO 134666"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.60543630),
        dec: Angle.Degrees(-10.08949147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92543"},
        {"Hipparcos Number", "HIP 52288"},
        {"Smithsonian Astrophysical Observation", "SAO 137723"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.26120046),
        dec: Angle.Degrees(-10.08898966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141086"},
        {"Hipparcos Number", "HIP 77367"},
        {"Geneva Identification System", "GEN# +1.00141086"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.89351358),
        dec: Angle.Degrees(-10.08856938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19938",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3103 A"},
        {"Henry Draper", "HD 27093"},
        {"Hipparcos Number", "HIP 19938"},
        {"Smithsonian Astrophysical Observation", "SAO 149503"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.14987202),
        dec: Angle.Degrees(-10.08583606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32893",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5516 A"},
        {"Henry Draper", "HD 50067"},
        {"Hipparcos Number", "HIP 32893"},
        {"Smithsonian Astrophysical Observation", "SAO 152011"},
        {"Wilson Evans Batten Catalogue", "WEB 6619"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.80025266),
        dec: Angle.Degrees(-10.08513462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94561"},
        {"Hipparcos Number", "HIP 53371"},
        {"Smithsonian Astrophysical Observation", "SAO 137882"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.70833003),
        dec: Angle.Degrees(-10.08500915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2431",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 426 A"},
        {"Henry Draper", "HD 2760"},
        {"Hipparcos Number", "HIP 2431"},
        {"Geneva Identification System", "GEN# +1.00002760"},
        {"Smithsonian Astrophysical Observation", "SAO 147317"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.74962079),
        dec: Angle.Degrees(-10.08465275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148021"},
        {"Hipparcos Number", "HIP 80477"},
        {"Smithsonian Astrophysical Observation", "SAO 141163"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.40921977),
        dec: Angle.Degrees(-10.08410869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2444",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 426 BC"},
        {"Henry Draper", "HD 2761"},
        {"Hipparcos Number", "HIP 2444"},
        {"Geneva Identification System", "GEN# +1.00002761"},
        {"Smithsonian Astrophysical Observation", "SAO 147318"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.77180237),
        dec: Angle.Degrees(-10.08386024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45976"},
        {"Hipparcos Number", "HIP 30986"},
        {"Fundamental Katalog 5th Edition", "FK5 2497"},
        {"Geneva Identification System", "GEN# +1.00045976"},
        {"Smithsonian Astrophysical Observation", "SAO 151573"},
    },
    visualMagnitude: 5.92,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.54700158),
        dec: Angle.Degrees(-10.08150589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110764"},
        {"Hipparcos Number", "HIP 62173"},
        {"Smithsonian Astrophysical Observation", "SAO 138945"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.11594609),
        dec: Angle.Degrees(-10.08130645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36379"},
        {"Hipparcos Number", "HIP 25840"},
        {"Geneva Identification System", "GEN# +1.00036379"},
        {"Smithsonian Astrophysical Observation", "SAO 150522"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.74935527),
        dec: Angle.Degrees(-10.08031884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 160.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -316.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210030"},
        {"Hipparcos Number", "HIP 109236"},
        {"Smithsonian Astrophysical Observation", "SAO 164870"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.94342076),
        dec: Angle.Degrees(-10.07851608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13740"},
        {"Hipparcos Number", "HIP 10383"},
        {"Smithsonian Astrophysical Observation", "SAO 148276"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.42597629),
        dec: Angle.Degrees(-10.07174805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29754"},
        {"Hipparcos Number", "HIP 21791"},
        {"Smithsonian Astrophysical Observation", "SAO 149823"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.21623798),
        dec: Angle.Degrees(-10.06863305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58925",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58925"},
        {"Smithsonian Astrophysical Observation", "SAO 138570"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.24816374),
        dec: Angle.Degrees(-10.06829745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57984"},
        {"Hipparcos Number", "HIP 35823"},
        {"Geneva Identification System", "GEN# +1.00057984"},
        {"Smithsonian Astrophysical Observation", "SAO 134601"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.81445967),
        dec: Angle.Degrees(-10.06822832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65502"},
        {"Hipparcos Number", "HIP 38986"},
        {"Smithsonian Astrophysical Observation", "SAO 135320"},
    },
    visualMagnitude: 8.63,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.66710666),
        dec: Angle.Degrees(-10.06781249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43161"},
        {"Hipparcos Number", "HIP 29607"},
        {"Smithsonian Astrophysical Observation", "SAO 151253"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.58597654),
        dec: Angle.Degrees(-10.06762791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198745"},
        {"Hipparcos Number", "HIP 103054"},
        {"Smithsonian Astrophysical Observation", "SAO 163949"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.18655841),
        dec: Angle.Degrees(-10.06507601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74647",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74647"},
        {"Smithsonian Astrophysical Observation", "SAO 140412"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.78488463),
        dec: Angle.Degrees(-10.06473882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145570"},
        {"Hipparcos Number", "HIP 79375"},
        {"Fundamental Katalog 5th Edition", "FK5 3280"},
        {"Geneva Identification System", "GEN# +1.00145570"},
        {"Renson", "Renson 41250"},
        {"Smithsonian Astrophysical Observation", "SAO 141022"},
        {"Wilson Evans Batten Catalogue", "WEB 13420"},
    },
    visualMagnitude: 4.93,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.00000648),
        dec: Angle.Degrees(-10.06418514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138716"},
        {"Hipparcos Number", "HIP 76219"},
        {"Fundamental Katalog 5th Edition", "FK5 1409"},
        {"Geneva Identification System", "GEN# +1.00138716"},
        {"Smithsonian Astrophysical Observation", "SAO 140609"},
        {"Wilson Evans Batten Catalogue", "WEB 12942"},
    },
    visualMagnitude: 4.61,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.54383219),
        dec: Angle.Degrees(-10.06395962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 305.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -234.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99918"},
        {"Hipparcos Number", "HIP 56077"},
        {"Fundamental Katalog 5th Edition", "FK5 5012"},
        {"Smithsonian Astrophysical Observation", "SAO 138234"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.40730217),
        dec: Angle.Degrees(-10.06262921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191110"},
        {"Hipparcos Number", "HIP 99221"},
        {"Geneva Identification System", "GEN# +1.00191110"},
        {"Renson", "Renson 53190"},
        {"Smithsonian Astrophysical Observation", "SAO 163290"},
        {"Wilson Evans Batten Catalogue", "WEB 17674"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.13028361),
        dec: Angle.Degrees(-10.06251198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16554",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2611 AB"},
        {"Henry Draper", "HD 22096"},
        {"Hipparcos Number", "HIP 16554"},
        {"Geneva Identification System", "GEN# +1.00022096"},
        {"Renson", "Renson 5548"},
        {"Smithsonian Astrophysical Observation", "SAO 149032"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.31477120),
        dec: Angle.Degrees(-10.05993359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216402"},
        {"Hipparcos Number", "HIP 112974"},
        {"Geneva Identification System", "GEN# +1.00216402"},
        {"Smithsonian Astrophysical Observation", "SAO 165353"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.19318515),
        dec: Angle.Degrees(-10.05888574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 251.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96515"},
        {"Hipparcos Number", "HIP 54350"},
        {"Smithsonian Astrophysical Observation", "SAO 137992"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.79138102),
        dec: Angle.Degrees(-10.05815204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186848"},
        {"Hipparcos Number", "HIP 97353"},
        {"Smithsonian Astrophysical Observation", "SAO 162983"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.79290551),
        dec: Angle.Degrees(-10.05709578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124803"},
        {"Hipparcos Number", "HIP 69685"},
        {"Smithsonian Astrophysical Observation", "SAO 139820"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.96118551),
        dec: Angle.Degrees(-10.05618092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138060"},
        {"Hipparcos Number", "HIP 75882"},
        {"Smithsonian Astrophysical Observation", "SAO 140568"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.49308610),
        dec: Angle.Degrees(-10.05542476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85221"},
        {"Hipparcos Number", "HIP 48250"},
        {"Smithsonian Astrophysical Observation", "SAO 137171"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.54584970),
        dec: Angle.Degrees(-10.05347567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106750"},
        {"Hipparcos Number", "HIP 59863"},
        {"Smithsonian Astrophysical Observation", "SAO 138689"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.15416137),
        dec: Angle.Degrees(-10.05307175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13456"},
        {"Hipparcos Number", "HIP 10215"},
        {"Fundamental Katalog 5th Edition", "FK5 2150"},
        {"Geneva Identification System", "GEN# +1.00013456"},
        {"Smithsonian Astrophysical Observation", "SAO 148262"},
        {"Wilson Evans Batten Catalogue", "WEB 2133"},
    },
    visualMagnitude: 6.00,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.84267760),
        dec: Angle.Degrees(-10.05174603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -171.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197980"},
        {"Hipparcos Number", "HIP 102607"},
        {"Geneva Identification System", "GEN# +1.00197980"},
        {"Smithsonian Astrophysical Observation", "SAO 163881"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.90052853),
        dec: Angle.Degrees(-10.05112291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41404"},
        {"Hipparcos Number", "HIP 28776"},
        {"Smithsonian Astrophysical Observation", "SAO 151080"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.14196045),
        dec: Angle.Degrees(-10.05045026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34316",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34316"},
        {"Geneva Identification System", "GEN# +2.23350004"},
        {"Smithsonian Astrophysical Observation", "SAO 134204"},
        {"New General Catalogue", "NGC 2335 4"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.71667483),
        dec: Angle.Degrees(-10.04842545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16555",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2611 C"},
        {"Henry Draper", "HD 22077"},
        {"Hipparcos Number", "HIP 16555"},
        {"Smithsonian Astrophysical Observation", "SAO 149029"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.29766764),
        dec: Angle.Degrees(-10.04533890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59211"},
        {"Hipparcos Number", "HIP 36320"},
        {"Geneva Identification System", "GEN# +1.00059211"},
        {"Smithsonian Astrophysical Observation", "SAO 134724"},
        {"Wilson Evans Batten Catalogue", "WEB 7227"},
    },
    visualMagnitude: 6.63,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.14311596),
        dec: Angle.Degrees(-10.04375765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13141"},
        {"Hipparcos Number", "HIP 9966"},
        {"Smithsonian Astrophysical Observation", "SAO 148231"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.08223772),
        dec: Angle.Degrees(-10.04135048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45298"},
        {"Hipparcos Number", "HIP 30634"},
        {"Smithsonian Astrophysical Observation", "SAO 151501"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.57511043),
        dec: Angle.Degrees(-10.04129933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51914"},
        {"Hipparcos Number", "HIP 33602"},
        {"Smithsonian Astrophysical Observation", "SAO 133987"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.72171054),
        dec: Angle.Degrees(-10.04086876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111243"},
        {"Hipparcos Number", "HIP 62465"},
        {"Smithsonian Astrophysical Observation", "SAO 138972"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.01658515),
        dec: Angle.Degrees(-10.03968905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108160"},
        {"Hipparcos Number", "HIP 60634"},
        {"Smithsonian Astrophysical Observation", "SAO 138772"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.39752281),
        dec: Angle.Degrees(-10.03835002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207687"},
        {"Hipparcos Number", "HIP 107857"},
        {"Geneva Identification System", "GEN# +1.00207687"},
        {"Smithsonian Astrophysical Observation", "SAO 164693"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.77334280),
        dec: Angle.Degrees(-10.03805305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188861"},
        {"Hipparcos Number", "HIP 98218"},
        {"Smithsonian Astrophysical Observation", "SAO 163138"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.39118069),
        dec: Angle.Degrees(-10.03802318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8951"},
        {"Hipparcos Number", "HIP 6846"},
        {"Smithsonian Astrophysical Observation", "SAO 147820"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.01840402),
        dec: Angle.Degrees(-10.03786976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195328"},
        {"Hipparcos Number", "HIP 101209"},
        {"Geneva Identification System", "GEN# +1.00195328"},
        {"Smithsonian Astrophysical Observation", "SAO 163643"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.73234316),
        dec: Angle.Degrees(-10.03528515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18775"},
        {"Hipparcos Number", "HIP 14050"},
        {"Smithsonian Astrophysical Observation", "SAO 148714"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.22604089),
        dec: Angle.Degrees(-10.03523515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220775"},
        {"Hipparcos Number", "HIP 115712"},
        {"Geneva Identification System", "GEN# +1.00220775"},
        {"Smithsonian Astrophysical Observation", "SAO 165695"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.65117894),
        dec: Angle.Degrees(-10.03412951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121608"},
        {"Hipparcos Number", "HIP 68107"},
        {"Geneva Identification System", "GEN# +1.00121608"},
        {"Smithsonian Astrophysical Observation", "SAO 139640"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.15219543),
        dec: Angle.Degrees(-10.03387630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -235.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68856"},
        {"Hipparcos Number", "HIP 40322"},
        {"Smithsonian Astrophysical Observation", "SAO 135663"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.49344428),
        dec: Angle.Degrees(-10.03212622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90375"},
        {"Hipparcos Number", "HIP 51053"},
        {"Smithsonian Astrophysical Observation", "SAO 137558"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.46515721),
        dec: Angle.Degrees(-10.03099293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70971"},
        {"Hipparcos Number", "HIP 41205"},
        {"Smithsonian Astrophysical Observation", "SAO 135881"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.12998972),
        dec: Angle.Degrees(-10.02867325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214572"},
        {"Hipparcos Number", "HIP 111843"},
        {"Geneva Identification System", "GEN# +1.00214572"},
        {"Smithsonian Astrophysical Observation", "SAO 165217"},
        {"Wilson Evans Batten Catalogue", "WEB 19978"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.81689800),
        dec: Angle.Degrees(-10.02778242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184704"},
        {"Hipparcos Number", "HIP 96410"},
        {"Cincinnati Publication", "Ci 20 1160"},
        {"Geneva Identification System", "GEN# +1.00184704"},
        {"Smithsonian Astrophysical Observation", "SAO 162808"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)36, 06.9600),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)01, 38.300)
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
    primaryId: "HIP 28475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40778"},
        {"Hipparcos Number", "HIP 28475"},
        {"Smithsonian Astrophysical Observation", "SAO 151016"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.17344702),
        dec: Angle.Degrees(-10.02697448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81874"},
        {"Hipparcos Number", "HIP 46429"},
        {"Smithsonian Astrophysical Observation", "SAO 136878"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.02609450),
        dec: Angle.Degrees(-10.02459388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28450"},
        {"Hipparcos Number", "HIP 20912"},
        {"Smithsonian Astrophysical Observation", "SAO 149669"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.22705981),
        dec: Angle.Degrees(-10.02118410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38277"},
        {"Hipparcos Number", "HIP 27058"},
        {"Geneva Identification System", "GEN# +1.00038277"},
        {"Smithsonian Astrophysical Observation", "SAO 150750"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.07315707),
        dec: Angle.Degrees(-10.01638315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175830"},
        {"Hipparcos Number", "HIP 93076"},
        {"Smithsonian Astrophysical Observation", "SAO 162023"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.39873605),
        dec: Angle.Degrees(-10.01598822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105519"},
        {"Hipparcos Number", "HIP 59236"},
        {"Smithsonian Astrophysical Observation", "SAO 138611"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.23321602),
        dec: Angle.Degrees(-10.01596324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 152.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101352",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101352"},
        {"Geneva Identification System", "GEN# -0.01005424"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.10932674),
        dec: Angle.Degrees(-10.00835760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187410"},
        {"Hipparcos Number", "HIP 97592"},
        {"Smithsonian Astrophysical Observation", "SAO 163026"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.54064250),
        dec: Angle.Degrees(-10.00715219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80612",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80612"},
    },
    visualMagnitude: 10.82,
    bvColour: 1.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.88895061),
        dec: Angle.Degrees(-10.00711350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -206.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -325.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126896"},
        {"Hipparcos Number", "HIP 70784"},
        {"Smithsonian Astrophysical Observation", "SAO 139953"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.13329321),
        dec: Angle.Degrees(-10.00423145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195105"},
        {"Hipparcos Number", "HIP 101095"},
        {"Geneva Identification System", "GEN# +1.00195105"},
        {"Smithsonian Astrophysical Observation", "SAO 163624"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.39809065),
        dec: Angle.Degrees(-10.00204983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26040"},
        {"Hipparcos Number", "HIP 19206"},
        {"Geneva Identification System", "GEN# +1.00026040"},
        {"Smithsonian Astrophysical Observation", "SAO 149379"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.75264311),
        dec: Angle.Degrees(-10.00011025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104461",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104461"},
        {"Geneva Identification System", "GEN# -0.01005614"},
    },
    visualMagnitude: 10.57,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.40224173),
        dec: Angle.Degrees(-10.00008289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116045"},
        {"Hipparcos Number", "HIP 65163"},
        {"Geneva Identification System", "GEN# +1.00116045"},
        {"Smithsonian Astrophysical Observation", "SAO 139293"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.30128767),
        dec: Angle.Degrees(-09.99921811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72664"},
        {"Hipparcos Number", "HIP 42013"},
        {"Smithsonian Astrophysical Observation", "SAO 136040"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.44490913),
        dec: Angle.Degrees(-09.99816371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20089"},
        {"Hipparcos Number", "HIP 15002"},
        {"Geneva Identification System", "GEN# +1.00020089"},
        {"Smithsonian Astrophysical Observation", "SAO 148842"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.34273429),
        dec: Angle.Degrees(-09.99731546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36542"},
        {"Hipparcos Number", "HIP 25931"},
        {"Geneva Identification System", "GEN# +1.00036542"},
        {"Smithsonian Astrophysical Observation", "SAO 150534"},
        {"Wilson Evans Batten Catalogue", "WEB 5042"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.00518620),
        dec: Angle.Degrees(-09.99703745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200228"},
        {"Hipparcos Number", "HIP 103851"},
        {"Smithsonian Astrophysical Observation", "SAO 164086"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.64679159),
        dec: Angle.Degrees(-09.99565539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95678"},
        {"Hipparcos Number", "HIP 53975"},
        {"Fundamental Katalog 5th Edition", "FK5 4973"},
        {"Smithsonian Astrophysical Observation", "SAO 137951"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.63027398),
        dec: Angle.Degrees(-09.99483632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204158"},
        {"Hipparcos Number", "HIP 105907"},
        {"Smithsonian Astrophysical Observation", "SAO 164396"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.74451118),
        dec: Angle.Degrees(-09.99377506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206623"},
        {"Hipparcos Number", "HIP 107266"},
        {"Smithsonian Astrophysical Observation", "SAO 164607"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.89723769),
        dec: Angle.Degrees(-09.99336961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35370"},
        {"Hipparcos Number", "HIP 25242"},
        {"Smithsonian Astrophysical Observation", "SAO 150403"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.96866394),
        dec: Angle.Degrees(-09.99168966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172890"},
        {"Hipparcos Number", "HIP 91788"},
        {"Smithsonian Astrophysical Observation", "SAO 161756"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.74537109),
        dec: Angle.Degrees(-09.99124011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84254"},
        {"Hipparcos Number", "HIP 47734"},
        {"Cincinnati Publication", "Ci 18 1156"},
        {"Geneva Identification System", "GEN# +1.00084254"},
        {"Smithsonian Astrophysical Observation", "SAO 137085"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.95450233),
        dec: Angle.Degrees(-09.99105684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -220.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12930"},
        {"Hipparcos Number", "HIP 9823"},
        {"Smithsonian Astrophysical Observation", "SAO 148203"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.60890156),
        dec: Angle.Degrees(-09.99078234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85576",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10576 AB"},
        {"Henry Draper", "HD 158373"},
        {"Hipparcos Number", "HIP 85576"},
        {"Smithsonian Astrophysical Observation", "SAO 141684"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.31930890),
        dec: Angle.Degrees(-09.99066231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206159"},
        {"Hipparcos Number", "HIP 107016"},
        {"Smithsonian Astrophysical Observation", "SAO 164565"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.10902055),
        dec: Angle.Degrees(-09.98959830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2996"},
        {"Hipparcos Number", "HIP 2608"},
        {"Geneva Identification System", "GEN# +1.00002996"},
        {"Smithsonian Astrophysical Observation", "SAO 147334"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.28113508),
        dec: Angle.Degrees(-09.98798507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82396"},
        {"Hipparcos Number", "HIP 46728"},
        {"Geneva Identification System", "GEN# +1.00082396"},
        {"Renson", "Renson 23410"},
        {"Smithsonian Astrophysical Observation", "SAO 136927"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.87452845),
        dec: Angle.Degrees(-09.98695152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46443",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7393 A"},
        {"Henry Draper", "HD 81902"},
        {"Hipparcos Number", "HIP 46443"},
        {"Smithsonian Astrophysical Observation", "SAO 136883"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.08551003),
        dec: Angle.Degrees(-09.98686543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54141"},
        {"Hipparcos Number", "HIP 34357"},
        {"Geneva Identification System", "GEN# +2.23350001"},
        {"Smithsonian Astrophysical Observation", "SAO 134220"},
        {"New General Catalogue", "NGC 2335 1"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.84036449),
        dec: Angle.Degrees(-09.98514088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222269"},
        {"Hipparcos Number", "HIP 116719"},
        {"Smithsonian Astrophysical Observation", "SAO 165812"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.81360385),
        dec: Angle.Degrees(-09.98474267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205457"},
        {"Hipparcos Number", "HIP 106617"},
        {"Smithsonian Astrophysical Observation", "SAO 164505"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.92073869),
        dec: Angle.Degrees(-09.98429611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43800"},
        {"Hipparcos Number", "HIP 29906"},
        {"Smithsonian Astrophysical Observation", "SAO 133072"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.45307263),
        dec: Angle.Degrees(-09.98419177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158826"},
        {"Hipparcos Number", "HIP 85784"},
        {"Smithsonian Astrophysical Observation", "SAO 141718"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.93732257),
        dec: Angle.Degrees(-09.98077843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48897"},
        {"Hipparcos Number", "HIP 32370"},
        {"Smithsonian Astrophysical Observation", "SAO 133643"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.35115438),
        dec: Angle.Degrees(-09.98025156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130176"},
        {"Hipparcos Number", "HIP 72283"},
        {"Smithsonian Astrophysical Observation", "SAO 140134"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.73604798),
        dec: Angle.Degrees(-09.97945702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97410"},
        {"Hipparcos Number", "HIP 54739"},
        {"Geneva Identification System", "GEN# +1.00097410"},
        {"Smithsonian Astrophysical Observation", "SAO 138060"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.11835854),
        dec: Angle.Degrees(-09.97924718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6482"},
        {"Hipparcos Number", "HIP 5121"},
        {"Geneva Identification System", "GEN# +1.00006482"},
        {"Smithsonian Astrophysical Observation", "SAO 147601"},
        {"Wilson Evans Batten Catalogue", "WEB 1053"},
    },
    visualMagnitude: 6.09,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.40375279),
        dec: Angle.Degrees(-09.97923948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162559"},
        {"Hipparcos Number", "HIP 87436"},
        {"Smithsonian Astrophysical Observation", "SAO 141912"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.00380876),
        dec: Angle.Degrees(-09.97817533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102989"},
        {"Hipparcos Number", "HIP 57816"},
        {"Smithsonian Astrophysical Observation", "SAO 138448"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.83740034),
        dec: Angle.Degrees(-09.97683964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222091"},
        {"Hipparcos Number", "HIP 116594"},
        {"Smithsonian Astrophysical Observation", "SAO 165806"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.42417764),
        dec: Angle.Degrees(-09.97489488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223524"},
        {"Hipparcos Number", "HIP 117541"},
        {"Fundamental Katalog 5th Edition", "FK5 897"},
        {"Geneva Identification System", "GEN# +1.00223524"},
        {"Smithsonian Astrophysical Observation", "SAO 165911"},
        {"Wilson Evans Batten Catalogue", "WEB 20698"},
    },
    visualMagnitude: 5.93,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.56103429),
        dec: Angle.Degrees(-09.97432690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 139.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38413"},
        {"Hipparcos Number", "HIP 27136"},
        {"Smithsonian Astrophysical Observation", "SAO 132511"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.30893124),
        dec: Angle.Degrees(-09.97404905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10226"},
        {"Hipparcos Number", "HIP 7759"},
        {"Cincinnati Publication", "Ci 18 233"},
        {"Geneva Identification System", "GEN# +1.00010226"},
        {"Smithsonian Astrophysical Observation", "SAO 147941"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.97691301),
        dec: Angle.Degrees(-09.97245897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 239.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179764"},
        {"Hipparcos Number", "HIP 94516"},
        {"Smithsonian Astrophysical Observation", "SAO 162348"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.55060421),
        dec: Angle.Degrees(-09.97087607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -265.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7465"},
        {"Hipparcos Number", "HIP 5814"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.66271886),
        dec: Angle.Degrees(-09.96994348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54359"},
        {"Hipparcos Number", "HIP 34423"},
        {"Geneva Identification System", "GEN# +1.00054359"},
        {"Smithsonian Astrophysical Observation", "SAO 134241"},
        {"Wilson Evans Batten Catalogue", "WEB 6898"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.03927228),
        dec: Angle.Degrees(-09.96877138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -199.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10383"},
        {"Hipparcos Number", "HIP 7862"},
        {"Smithsonian Astrophysical Observation", "SAO 147958"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.28736560),
        dec: Angle.Degrees(-09.96849317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58581"},
        {"Hipparcos Number", "HIP 36062"},
        {"Smithsonian Astrophysical Observation", "SAO 134657"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.47787163),
        dec: Angle.Degrees(-09.96823214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124141"},
        {"Hipparcos Number", "HIP 69363"},
        {"Smithsonian Astrophysical Observation", "SAO 139781"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.858,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.98066093),
        dec: Angle.Degrees(-09.96472740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1532",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1532"},
        {"Geneva Identification System", "GEN# -0.01000047"},
    },
    visualMagnitude: 9.90,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.77326587),
        dec: Angle.Degrees(-09.96411989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -301.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26329",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26329"},
        {"Smithsonian Astrophysical Observation", "SAO 132358"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.11640729),
        dec: Angle.Degrees(-09.96331921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94886"},
        {"Hipparcos Number", "HIP 53526"},
        {"Geneva Identification System", "GEN# +1.00094886"},
        {"Smithsonian Astrophysical Observation", "SAO 137907"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.27787125),
        dec: Angle.Degrees(-09.96198422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18885"},
        {"Hipparcos Number", "HIP 14110"},
        {"Fundamental Katalog 5th Edition", "FK5 2216"},
        {"Geneva Identification System", "GEN# +1.00018885"},
        {"Smithsonian Astrophysical Observation", "SAO 148721"},
        {"Wilson Evans Batten Catalogue", "WEB 2777"},
    },
    visualMagnitude: 5.84,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.48372163),
        dec: Angle.Degrees(-09.96139327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25524",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25524"},
        {"Smithsonian Astrophysical Observation", "SAO 150467"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.87503186),
        dec: Angle.Degrees(-09.96015154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3842"},
        {"Hipparcos Number", "HIP 3216"},
        {"Smithsonian Astrophysical Observation", "SAO 147400"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.22421172),
        dec: Angle.Degrees(-09.96006192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27015"},
        {"Hipparcos Number", "HIP 19882"},
        {"Smithsonian Astrophysical Observation", "SAO 149493"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.96981606),
        dec: Angle.Degrees(-09.95996272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37263",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6252 AB"},
        {"Henry Draper", "HD 61463"},
        {"Hipparcos Number", "HIP 37263"},
        {"Smithsonian Astrophysical Observation", "SAO 134943"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.78797467),
        dec: Angle.Degrees(-09.95929943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189340"},
        {"Hipparcos Number", "HIP 98416"},
        {"Cincinnati Publication", "Ci 20 1176"},
        {"Geneva Identification System", "GEN# +1.00189340"},
        {"Smithsonian Astrophysical Observation", "SAO 163168"},
        {"Wilson Evans Batten Catalogue", "WEB 17373"},
    },
    visualMagnitude: 5.87,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.94787255),
        dec: Angle.Degrees(-09.95728408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -246.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -392.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78342",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78342"},
        {"Smithsonian Astrophysical Observation", "SAO 140883"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.94566315),
        dec: Angle.Degrees(-09.95564880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75902"},
        {"Hipparcos Number", "HIP 43578"},
        {"Smithsonian Astrophysical Observation", "SAO 136360"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.12257918),
        dec: Angle.Degrees(-09.95343972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131181"},
        {"Hipparcos Number", "HIP 72745"},
        {"Smithsonian Astrophysical Observation", "SAO 140190"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.08030972),
        dec: Angle.Degrees(-09.95310961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72746"},
        {"Hipparcos Number", "HIP 42037"},
        {"Geneva Identification System", "GEN# +1.00072746"},
        {"Smithsonian Astrophysical Observation", "SAO 136051"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.53897169),
        dec: Angle.Degrees(-09.95272538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50532",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50532"},
        {"Smithsonian Astrophysical Observation", "SAO 137486"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.81541688),
        dec: Angle.Degrees(-09.95221922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20401",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3164 A"},
        {"Henry Draper", "HD 27708"},
        {"Hipparcos Number", "HIP 20401"},
        {"Smithsonian Astrophysical Observation", "SAO 149581"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.51536731),
        dec: Angle.Degrees(-09.95181246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128887"},
        {"Hipparcos Number", "HIP 71685"},
        {"Smithsonian Astrophysical Observation", "SAO 140055"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.93563299),
        dec: Angle.Degrees(-09.94987333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -218.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20517"},
        {"Hipparcos Number", "HIP 15319"},
        {"Smithsonian Astrophysical Observation", "SAO 148884"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.41212678),
        dec: Angle.Degrees(-09.94886605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55832"},
        {"Hipparcos Number", "HIP 34982"},
        {"Geneva Identification System", "GEN# +1.00055832"},
        {"Smithsonian Astrophysical Observation", "SAO 134395"},
        {"Wilson Evans Batten Catalogue", "WEB 6994"},
    },
    visualMagnitude: 5.90,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.56467751),
        dec: Angle.Degrees(-09.94753938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102884"},
        {"Hipparcos Number", "HIP 57758"},
        {"Smithsonian Astrophysical Observation", "SAO 138440"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.67550050),
        dec: Angle.Degrees(-09.94736795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63654"},
        {"Hipparcos Number", "HIP 38204"},
        {"Smithsonian Astrophysical Observation", "SAO 135143"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.40999791),
        dec: Angle.Degrees(-09.94561985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132393"},
        {"Hipparcos Number", "HIP 73340"},
        {"Smithsonian Astrophysical Observation", "SAO 140259"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.80764653),
        dec: Angle.Degrees(-09.94540073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110976",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110976"},
        {"Smithsonian Astrophysical Observation", "SAO 165112"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.26502209),
        dec: Angle.Degrees(-09.94499422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35549"},
        {"Hipparcos Number", "HIP 25338"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.29380444),
        dec: Angle.Degrees(-09.94091484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99507"},
        {"Hipparcos Number", "HIP 55857"},
        {"Geneva Identification System", "GEN# +1.00099507"},
        {"Smithsonian Astrophysical Observation", "SAO 138211"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.71693903),
        dec: Angle.Degrees(-09.94073670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122370"},
        {"Hipparcos Number", "HIP 68518"},
        {"Geneva Identification System", "GEN# +1.00122370"},
        {"Renson", "Renson 35074"},
        {"Smithsonian Astrophysical Observation", "SAO 139684"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.40964341),
        dec: Angle.Degrees(-09.94012482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78751"},
        {"Hipparcos Number", "HIP 44972"},
        {"Smithsonian Astrophysical Observation", "SAO 136625"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.41947107),
        dec: Angle.Degrees(-09.93785432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93062"},
        {"Hipparcos Number", "HIP 52561"},
        {"Smithsonian Astrophysical Observation", "SAO 137762"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.19457616),
        dec: Angle.Degrees(-09.93732973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213067"},
        {"Hipparcos Number", "HIP 110974"},
        {"Smithsonian Astrophysical Observation", "SAO 165111"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.26105152),
        dec: Angle.Degrees(-09.93576669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43531"},
        {"Hipparcos Number", "HIP 29794"},
        {"Smithsonian Astrophysical Observation", "SAO 133051"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.09549308),
        dec: Angle.Degrees(-09.93516029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71188",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71188"},
        {"Geneva Identification System", "GEN# -0.00903964"},
    },
    visualMagnitude: 10.54,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.39202909),
        dec: Angle.Degrees(-09.93077536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -261.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -506.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223217"},
        {"Hipparcos Number", "HIP 117351"},
        {"Smithsonian Astrophysical Observation", "SAO 165886"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.91198745),
        dec: Angle.Degrees(-09.93048290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88107"},
        {"Hipparcos Number", "HIP 49757"},
        {"Smithsonian Astrophysical Observation", "SAO 137379"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.35429502),
        dec: Angle.Degrees(-09.92858377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155362"},
        {"Hipparcos Number", "HIP 84094"},
        {"Smithsonian Astrophysical Observation", "SAO 141546"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.88083917),
        dec: Angle.Degrees(-09.92756993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39592",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6575 A"},
        {"Henry Draper", "HD 66954"},
        {"Hipparcos Number", "HIP 39592"},
        {"Smithsonian Astrophysical Observation", "SAO 135479"},
    },
    visualMagnitude: 8.01,
    bvColour: -0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.35497776),
        dec: Angle.Degrees(-09.92755487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28102"},
        {"Hipparcos Number", "HIP 20675"},
        {"Smithsonian Astrophysical Observation", "SAO 149622"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.42629116),
        dec: Angle.Degrees(-09.92662650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76371"},
        {"Hipparcos Number", "HIP 43818"},
        {"Smithsonian Astrophysical Observation", "SAO 136407"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.86429486),
        dec: Angle.Degrees(-09.92566843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151633"},
        {"Hipparcos Number", "HIP 82298"},
        {"Geneva Identification System", "GEN# +1.00151633"},
        {"Smithsonian Astrophysical Observation", "SAO 141375"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.24003522),
        dec: Angle.Degrees(-09.92209914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4048"},
        {"Hipparcos Number", "HIP 3369"},
        {"Geneva Identification System", "GEN# +1.00004048"},
        {"Smithsonian Astrophysical Observation", "SAO 147415"},
        {"Wilson Evans Batten Catalogue", "WEB 599"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.71149682),
        dec: Angle.Degrees(-09.92163939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144047"},
        {"Hipparcos Number", "HIP 78715"},
        {"Smithsonian Astrophysical Observation", "SAO 140925"},
        {"Wilson Evans Batten Catalogue", "WEB 13307"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.04083321),
        dec: Angle.Degrees(-09.91966903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215046"},
        {"Hipparcos Number", "HIP 112109"},
        {"Geneva Identification System", "GEN# +1.00215046"},
        {"Smithsonian Astrophysical Observation", "SAO 165242"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.62902296),
        dec: Angle.Degrees(-09.91886310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84984"},
        {"Hipparcos Number", "HIP 48126"},
        {"Fundamental Katalog 5th Edition", "FK5 2783"},
        {"Geneva Identification System", "GEN# +1.00084984"},
        {"Smithsonian Astrophysical Observation", "SAO 137151"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.18128209),
        dec: Angle.Degrees(-09.91863183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101517"},
        {"Hipparcos Number", "HIP 56980"},
        {"Smithsonian Astrophysical Observation", "SAO 138343"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.21206618),
        dec: Angle.Degrees(-09.91737031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28632"},
        {"Hipparcos Number", "HIP 21025"},
        {"Smithsonian Astrophysical Observation", "SAO 149686"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.62542785),
        dec: Angle.Degrees(-09.91526384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36961"},
        {"Hipparcos Number", "HIP 26179"},
        {"Geneva Identification System", "GEN# +1.00036961"},
        {"Smithsonian Astrophysical Observation", "SAO 132295"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.71390936),
        dec: Angle.Degrees(-09.91124974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141771"},
        {"Hipparcos Number", "HIP 77650"},
        {"Geneva Identification System", "GEN# +1.00141771"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.78877361),
        dec: Angle.Degrees(-09.90825636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3916",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3916"},
        {"Smithsonian Astrophysical Observation", "SAO 147471"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.56744367),
        dec: Angle.Degrees(-09.90633216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40068"},
        {"Hipparcos Number", "HIP 28089"},
        {"Smithsonian Astrophysical Observation", "SAO 132671"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.06646546),
        dec: Angle.Degrees(-09.90537905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80892"},
        {"Hipparcos Number", "HIP 45939"},
        {"Smithsonian Astrophysical Observation", "SAO 136790"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.51526559),
        dec: Angle.Degrees(-09.90462714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85690"},
        {"Hipparcos Number", "HIP 48491"},
        {"Smithsonian Astrophysical Observation", "SAO 137206"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.34129913),
        dec: Angle.Degrees(-09.90367701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200455"},
        {"Hipparcos Number", "HIP 103964"},
        {"Smithsonian Astrophysical Observation", "SAO 164110"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.96911506),
        dec: Angle.Degrees(-09.90358834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15117"},
        {"Hipparcos Number", "HIP 11340"},
        {"Smithsonian Astrophysical Observation", "SAO 148383"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.47395559),
        dec: Angle.Degrees(-09.90205822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124248"},
        {"Hipparcos Number", "HIP 69403"},
        {"Geneva Identification System", "GEN# +1.00124248"},
        {"Smithsonian Astrophysical Observation", "SAO 139785"},
        {"Wilson Evans Batten Catalogue", "WEB 12099"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.13933096),
        dec: Angle.Degrees(-09.90004642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91566"},
        {"Hipparcos Number", "HIP 51741"},
        {"Geneva Identification System", "GEN# +1.00091566"},
        {"Smithsonian Astrophysical Observation", "SAO 137648"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.57578337),
        dec: Angle.Degrees(-09.89923136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140491"},
        {"Hipparcos Number", "HIP 77076"},
        {"Geneva Identification System", "GEN# +1.00140491"},
        {"Smithsonian Astrophysical Observation", "SAO 140726"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.07176129),
        dec: Angle.Degrees(-09.89742869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209713"},
        {"Hipparcos Number", "HIP 109058"},
        {"Smithsonian Astrophysical Observation", "SAO 164852"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.39636449),
        dec: Angle.Degrees(-09.89725474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29346"},
        {"Hipparcos Number", "HIP 21493"},
        {"Geneva Identification System", "GEN# +1.00029346"},
        {"Smithsonian Astrophysical Observation", "SAO 131352"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.24383518),
        dec: Angle.Degrees(-09.89417350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44288"},
        {"Hipparcos Number", "HIP 30149"},
        {"Smithsonian Astrophysical Observation", "SAO 133135"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.16688531),
        dec: Angle.Degrees(-09.89099558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150753"},
        {"Hipparcos Number", "HIP 81869"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.82126555),
        dec: Angle.Degrees(-09.89036708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66072"},
        {"Hipparcos Number", "HIP 39244"},
        {"Smithsonian Astrophysical Observation", "SAO 135391"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.39458738),
        dec: Angle.Degrees(-09.88932623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12020",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1965 A"},
        {"Henry Draper", "HD 16116"},
        {"Hipparcos Number", "HIP 12020"},
        {"Smithsonian Astrophysical Observation", "SAO 148479"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.75991018),
        dec: Angle.Degrees(-09.88869425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52745"},
        {"Hipparcos Number", "HIP 33889"},
        {"Geneva Identification System", "GEN# +1.00052745"},
        {"Smithsonian Astrophysical Observation", "SAO 134084"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.52038742),
        dec: Angle.Degrees(-09.88690262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131935"},
        {"Hipparcos Number", "HIP 73132"},
        {"Smithsonian Astrophysical Observation", "SAO 140235"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.18919350),
        dec: Angle.Degrees(-09.88620021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74246",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74246"},
        {"Smithsonian Astrophysical Observation", "SAO 140362"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.59045789),
        dec: Angle.Degrees(-09.88617588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193099"},
        {"Hipparcos Number", "HIP 100138"},
        {"Smithsonian Astrophysical Observation", "SAO 163436"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.70007926),
        dec: Angle.Degrees(-09.88552076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4824",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4824"},
        {"Geneva Identification System", "GEN# -0.01000216"},
    },
    visualMagnitude: 10.49,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.48814996),
        dec: Angle.Degrees(-09.88437211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -194.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -487.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8070"},
        {"Hipparcos Number", "HIP 6237"},
        {"Geneva Identification System", "GEN# +1.00008070"},
        {"Smithsonian Astrophysical Observation", "SAO 147742"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.01238711),
        dec: Angle.Degrees(-09.88360181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23635"},
        {"Hipparcos Number", "HIP 17601"},
        {"Smithsonian Astrophysical Observation", "SAO 149160"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.55530210),
        dec: Angle.Degrees(-09.88280497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90736"},
        {"Hipparcos Number", "HIP 51283"},
        {"Smithsonian Astrophysical Observation", "SAO 137588"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.11966872),
        dec: Angle.Degrees(-09.88123513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99405"},
        {"Hipparcos Number", "HIP 55815"},
        {"Smithsonian Astrophysical Observation", "SAO 138206"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.57086350),
        dec: Angle.Degrees(-09.88117174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48237"},
        {"Hipparcos Number", "HIP 32078"},
        {"Celescope Catalog", "CEL 1357"},
        {"Geneva Identification System", "GEN# +1.00048237"},
        {"Smithsonian Astrophysical Observation", "SAO 133589"},
    },
    visualMagnitude: 9.31,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.52715405),
        dec: Angle.Degrees(-09.87986382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140369"},
        {"Hipparcos Number", "HIP 77026"},
        {"Geneva Identification System", "GEN# +1.00140369"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.90274732),
        dec: Angle.Degrees(-09.87942071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209208"},
        {"Hipparcos Number", "HIP 108757"},
        {"Smithsonian Astrophysical Observation", "SAO 164825"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.46004578),
        dec: Angle.Degrees(-09.87475721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44816"},
        {"Hipparcos Number", "HIP 30407"},
        {"Geneva Identification System", "GEN# +1.00044816"},
        {"Smithsonian Astrophysical Observation", "SAO 133203"},
    },
    visualMagnitude: 6.11,
    bvColour: 1.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.89966506),
        dec: Angle.Degrees(-09.87473901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2335"},
        {"Hipparcos Number", "HIP 2140"},
        {"Fundamental Katalog 5th Edition", "FK5 4044"},
        {"Geneva Identification System", "GEN# +1.00002335"},
        {"Smithsonian Astrophysical Observation", "SAO 147282"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.77889179),
        dec: Angle.Degrees(-09.87296309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13275"},
        {"Hipparcos Number", "HIP 10062"},
        {"Smithsonian Astrophysical Observation", "SAO 148241"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.38284959),
        dec: Angle.Degrees(-09.86883283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39942"},
        {"Hipparcos Number", "HIP 28009"},
        {"Smithsonian Astrophysical Observation", "SAO 132654"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.87369612),
        dec: Angle.Degrees(-09.86846848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22243"},
        {"Hipparcos Number", "HIP 16677"},
        {"Geneva Identification System", "GEN# +1.00022243"},
        {"Smithsonian Astrophysical Observation", "SAO 149047"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.65607976),
        dec: Angle.Degrees(-09.86827337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32220"},
        {"Hipparcos Number", "HIP 23338"},
        {"Smithsonian Astrophysical Observation", "SAO 131696"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.29998495),
        dec: Angle.Degrees(-09.86626019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23864",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3719 AB"},
        {"Henry Draper", "HD 33126"},
        {"Hipparcos Number", "HIP 23864"},
        {"Geneva Identification System", "GEN# +1.00033126"},
        {"Smithsonian Astrophysical Observation", "SAO 131793"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.93383251),
        dec: Angle.Degrees(-09.86484345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80442",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10046 AB"},
        {"Henry Draper", "HD 147967"},
        {"Hipparcos Number", "HIP 80442"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.31252985),
        dec: Angle.Degrees(-09.86477815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207270"},
        {"Hipparcos Number", "HIP 107622"},
        {"Geneva Identification System", "GEN# +1.00207270"},
        {"Smithsonian Astrophysical Observation", "SAO 164660"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.98194924),
        dec: Angle.Degrees(-09.86360241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64988"},
        {"Hipparcos Number", "HIP 38764"},
        {"Geneva Identification System", "GEN# +1.00064988"},
        {"Renson", "Renson 17840"},
        {"Smithsonian Astrophysical Observation", "SAO 135277"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.03757332),
        dec: Angle.Degrees(-09.86324041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6204"},
        {"Hipparcos Number", "HIP 4909"},
        {"Smithsonian Astrophysical Observation", "SAO 147582"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.73924598),
        dec: Angle.Degrees(-09.86127874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95624"},
        {"Hipparcos Number", "HIP 53926"},
        {"Smithsonian Astrophysical Observation", "SAO 137949"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.51595458),
        dec: Angle.Degrees(-09.86023830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60508"},
        {"Hipparcos Number", "HIP 36844"},
        {"Geneva Identification System", "GEN# +1.00060508"},
        {"Smithsonian Astrophysical Observation", "SAO 134852"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.63915411),
        dec: Angle.Degrees(-09.86018476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40761"},
        {"Hipparcos Number", "HIP 28458"},
        {"Smithsonian Astrophysical Observation", "SAO 132741"},
        {"Wilson Evans Batten Catalogue", "WEB 5563"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.13004364),
        dec: Angle.Degrees(-09.85691288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163154"},
        {"Hipparcos Number", "HIP 87720"},
        {"Smithsonian Astrophysical Observation", "SAO 141957"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.77874404),
        dec: Angle.Degrees(-09.85503477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196248"},
        {"Hipparcos Number", "HIP 101664"},
        {"Smithsonian Astrophysical Observation", "SAO 163723"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.10777394),
        dec: Angle.Degrees(-09.85408085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78423"},
        {"Hipparcos Number", "HIP 44801"},
        {"Smithsonian Astrophysical Observation", "SAO 136595"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.94995265),
        dec: Angle.Degrees(-09.85368471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101345",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13960 A"},
        {"Henry Draper", "HD 195564"},
        {"Hipparcos Number", "HIP 101345"},
        {"Fundamental Katalog 5th Edition", "FK5 1536"},
        {"Geneva Identification System", "GEN# +1.00195564J"},
        {"Smithsonian Astrophysical Observation", "SAO 163665"},
        {"Wilson Evans Batten Catalogue", "WEB 18309"},
    },
    visualMagnitude: 5.66,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.09797300),
        dec: Angle.Degrees(-09.85364143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 307.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19139"},
        {"Hipparcos Number", "HIP 14299"},
        {"Smithsonian Astrophysical Observation", "SAO 148746"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.10316652),
        dec: Angle.Degrees(-09.85298205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93833"},
        {"Hipparcos Number", "HIP 52948"},
        {"Geneva Identification System", "GEN# +1.00093833"},
        {"Smithsonian Astrophysical Observation", "SAO 137815"},
        {"Wilson Evans Batten Catalogue", "WEB 9634"},
    },
    visualMagnitude: 5.85,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.43117856),
        dec: Angle.Degrees(-09.85262893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147082"},
        {"Hipparcos Number", "HIP 80016"},
        {"Smithsonian Astrophysical Observation", "SAO 141101"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.00159066),
        dec: Angle.Degrees(-09.85092735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29392"},
        {"Hipparcos Number", "HIP 21536"},
        {"Geneva Identification System", "GEN# +1.00029392J"},
        {"Smithsonian Astrophysical Observation", "SAO 131357"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.35948105),
        dec: Angle.Degrees(-09.85034116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81422"},
        {"Hipparcos Number", "HIP 46203"},
        {"Smithsonian Astrophysical Observation", "SAO 136830"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.31273831),
        dec: Angle.Degrees(-09.84981896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178461"},
        {"Hipparcos Number", "HIP 94079"},
        {"Smithsonian Astrophysical Observation", "SAO 143073"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.27382762),
        dec: Angle.Degrees(-09.84766398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85507"},
        {"Hipparcos Number", "HIP 48399"},
        {"Smithsonian Astrophysical Observation", "SAO 137195"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.01291021),
        dec: Angle.Degrees(-09.84739382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34839",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5883 A"},
        {"Henry Draper", "HD 55439"},
        {"Hipparcos Number", "HIP 34839"},
        {"Celescope Catalog", "CEL 1670"},
        {"Geneva Identification System", "GEN# +1.00055439"},
        {"Smithsonian Astrophysical Observation", "SAO 134358"},
        {"Wilson Evans Batten Catalogue", "WEB 6964"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.14505180),
        dec: Angle.Degrees(-09.84503175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6530"},
        {"Hipparcos Number", "HIP 5164"},
        {"Geneva Identification System", "GEN# +1.00006530"},
        {"Smithsonian Astrophysical Observation", "SAO 147606"},
    },
    visualMagnitude: 5.58,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.52137513),
        dec: Angle.Degrees(-09.83936845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110300"},
        {"Hipparcos Number", "HIP 61904"},
        {"Smithsonian Astrophysical Observation", "SAO 138912"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.29003923),
        dec: Angle.Degrees(-09.82305313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45999",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7334 AB"},
        {"Henry Draper", "HD 81009"},
        {"Hipparcos Number", "HIP 45999"},
        {"Geneva Identification System", "GEN# +1.00081009"},
        {"Renson", "Renson 22990"},
        {"Smithsonian Astrophysical Observation", "SAO 136799"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.71197042),
        dec: Angle.Degrees(-09.83876248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101094"},
        {"Hipparcos Number", "HIP 56735"},
        {"Smithsonian Astrophysical Observation", "SAO 138312"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.48656371),
        dec: Angle.Degrees(-09.83488713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112758"},
        {"Hipparcos Number", "HIP 63366"},
        {"Cincinnati Publication", "Ci 20 750"},
        {"Cincinnati Publication 2", "Ci 18 1657"},
        {"Geneva Identification System", "GEN# +1.00112758J"},
        {"Smithsonian Astrophysical Observation", "SAO 139081"},
        {"Wilson Evans Batten Catalogue", "WEB 11221"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.75855022),
        dec: Angle.Degrees(-09.83456221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -827.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 196.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35414"},
        {"Hipparcos Number", "HIP 25261"},
        {"Renson", "Renson 9056"},
        {"Smithsonian Astrophysical Observation", "SAO 132068"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.03469099),
        dec: Angle.Degrees(-09.83261466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5039"},
        {"Hipparcos Number", "HIP 4071"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.05288279),
        dec: Angle.Degrees(-09.83240938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159739"},
        {"Hipparcos Number", "HIP 86190"},
        {"Smithsonian Astrophysical Observation", "SAO 141757"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.17729344),
        dec: Angle.Degrees(-09.83213448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113128"},
        {"Hipparcos Number", "HIP 63571"},
        {"Smithsonian Astrophysical Observation", "SAO 139105"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.41299747),
        dec: Angle.Degrees(-09.83130818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16569"},
        {"Hipparcos Number", "HIP 12363"},
        {"Geneva Identification System", "GEN# +1.00016569"},
        {"Smithsonian Astrophysical Observation", "SAO 148523"},
    },
    visualMagnitude: 6.65,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.78728898),
        dec: Angle.Degrees(-09.83113801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47077"},
        {"Hipparcos Number", "HIP 31571"},
        {"Geneva Identification System", "GEN# +1.00047077"},
        {"Smithsonian Astrophysical Observation", "SAO 133466"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.11519920),
        dec: Angle.Degrees(-09.82858790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134966"},
        {"Hipparcos Number", "HIP 74475"},
        {"Smithsonian Astrophysical Observation", "SAO 140382"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.26912838),
        dec: Angle.Degrees(-09.82802026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11766"},
        {"Hipparcos Number", "HIP 8944"},
        {"Geneva Identification System", "GEN# +1.00011766"},
        {"Smithsonian Astrophysical Observation", "SAO 148104"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.80340946),
        dec: Angle.Degrees(-09.82800885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147854"},
        {"Hipparcos Number", "HIP 80396"},
        {"Geneva Identification System", "GEN# +1.00147854"},
        {"Smithsonian Astrophysical Observation", "SAO 141153"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.15403564),
        dec: Angle.Degrees(-09.82667389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32818"},
        {"Hipparcos Number", "HIP 23689"},
        {"Geneva Identification System", "GEN# +1.00032818"},
        {"Smithsonian Astrophysical Observation", "SAO 131754"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.37108638),
        dec: Angle.Degrees(-09.82658000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44193",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44193"},
    },
    visualMagnitude: 11.37,
    bvColour: 0.869,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.02801390),
        dec: Angle.Degrees(-09.82454599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108879"},
        {"Hipparcos Number", "HIP 61042"},
        {"Smithsonian Astrophysical Observation", "SAO 138822"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.66061222),
        dec: Angle.Degrees(-09.82444898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45660"},
        {"Hipparcos Number", "HIP 30805"},
        {"Geneva Identification System", "GEN# +1.00045660"},
        {"Smithsonian Astrophysical Observation", "SAO 133302"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.08454341),
        dec: Angle.Degrees(-09.82422818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14044"},
        {"Hipparcos Number", "HIP 10584"},
        {"Fundamental Katalog 5th Edition", "FK5 4209"},
        {"Geneva Identification System", "GEN# +1.00014044"},
        {"Smithsonian Astrophysical Observation", "SAO 148304"},
        {"Wilson Evans Batten Catalogue", "WEB 2227"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.06545280),
        dec: Angle.Degrees(-09.82115255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 264.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57434"},
        {"Hipparcos Number", "HIP 35606"},
        {"Smithsonian Astrophysical Observation", "SAO 134547"},
    },
    visualMagnitude: 8.31,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.21432199),
        dec: Angle.Degrees(-09.82072030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168325"},
        {"Hipparcos Number", "HIP 89792"},
        {"Smithsonian Astrophysical Observation", "SAO 142222"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.86749582),
        dec: Angle.Degrees(-09.81519242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161306"},
        {"Hipparcos Number", "HIP 86884"},
        {"Geneva Identification System", "GEN# +1.00161306"},
        {"Smithsonian Astrophysical Observation", "SAO 141851"},
        {"Wilson Evans Batten Catalogue", "WEB 14655"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.28210504),
        dec: Angle.Degrees(-09.81510051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39403"},
        {"Hipparcos Number", "HIP 27709"},
        {"Geneva Identification System", "GEN# +1.00039403"},
        {"Smithsonian Astrophysical Observation", "SAO 132602"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.00729468),
        dec: Angle.Degrees(-09.81316803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8513"},
        {"Hipparcos Number", "HIP 6541"},
        {"Smithsonian Astrophysical Observation", "SAO 147786"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.01395266),
        dec: Angle.Degrees(-09.81205316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39888"},
        {"Hipparcos Number", "HIP 27986"},
        {"Geneva Identification System", "GEN# +1.00039888"},
        {"Smithsonian Astrophysical Observation", "SAO 132646"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.78007772),
        dec: Angle.Degrees(-09.81004266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34282"},
        {"Hipparcos Number", "HIP 24552"},
        {"Smithsonian Astrophysical Observation", "SAO 131926"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.00198574),
        dec: Angle.Degrees(-09.80982965)
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
    primaryId: "HIP 35845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58029"},
        {"Hipparcos Number", "HIP 35845"},
        {"Geneva Identification System", "GEN# +1.00058029"},
        {"Smithsonian Astrophysical Observation", "SAO 134609"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.86858531),
        dec: Angle.Degrees(-09.80958319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167591"},
        {"Hipparcos Number", "HIP 89544"},
        {"Smithsonian Astrophysical Observation", "SAO 142186"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.06355834),
        dec: Angle.Degrees(-09.80957274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129232"},
        {"Hipparcos Number", "HIP 71834"},
        {"Geneva Identification System", "GEN# +1.00129232"},
        {"Smithsonian Astrophysical Observation", "SAO 140075"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.42260548),
        dec: Angle.Degrees(-09.80947776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17318"},
        {"Hipparcos Number", "HIP 12945"},
        {"Smithsonian Astrophysical Observation", "SAO 148592"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.62445527),
        dec: Angle.Degrees(-09.80897790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70015"},
        {"Hipparcos Number", "HIP 40780"},
        {"Smithsonian Astrophysical Observation", "SAO 135775"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.84941787),
        dec: Angle.Degrees(-09.80880617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84430",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10423 AB"},
        {"Henry Draper", "HD 156034"},
        {"Hipparcos Number", "HIP 84430"},
        {"Geneva Identification System", "GEN# +1.00156034J"},
        {"Smithsonian Astrophysical Observation", "SAO 141578"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.92116506),
        dec: Angle.Degrees(-09.80876827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223180"},
        {"Hipparcos Number", "HIP 117318"},
        {"Smithsonian Astrophysical Observation", "SAO 165881"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.83155393),
        dec: Angle.Degrees(-09.80873825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149846"},
        {"Hipparcos Number", "HIP 81410"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.40680698),
        dec: Angle.Degrees(-09.80873764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74294"},
        {"Hipparcos Number", "HIP 42769"},
        {"Smithsonian Astrophysical Observation", "SAO 136210"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.72410512),
        dec: Angle.Degrees(-09.80551093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15319"},
        {"Hipparcos Number", "HIP 11449"},
        {"Smithsonian Astrophysical Observation", "SAO 148399"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.92761374),
        dec: Angle.Degrees(-09.80505938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5779",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5779"},
        {"Smithsonian Astrophysical Observation", "SAO 147685"},
    },
    visualMagnitude: 9.49,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.53465001),
        dec: Angle.Degrees(-09.80247637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100889"},
        {"Hipparcos Number", "HIP 56633"},
        {"Fundamental Katalog 5th Edition", "FK5 1299"},
        {"Geneva Identification System", "GEN# +1.00100889"},
        {"Smithsonian Astrophysical Observation", "SAO 138296"},
        {"Wilson Evans Batten Catalogue", "WEB 10181"},
    },
    visualMagnitude: 4.70,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.17061875),
        dec: Angle.Degrees(-09.80225368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138837"},
        {"Hipparcos Number", "HIP 76288"},
        {"Smithsonian Astrophysical Observation", "SAO 140620"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.74904510),
        dec: Angle.Degrees(-09.80173094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165888"},
        {"Hipparcos Number", "HIP 88872"},
        {"Smithsonian Astrophysical Observation", "SAO 142111"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.15492031),
        dec: Angle.Degrees(-09.80147896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211761"},
        {"Hipparcos Number", "HIP 110223"},
        {"Smithsonian Astrophysical Observation", "SAO 165001"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.90299704),
        dec: Angle.Degrees(-09.80084506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212444"},
        {"Hipparcos Number", "HIP 110607"},
        {"Smithsonian Astrophysical Observation", "SAO 165046"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.11915988),
        dec: Angle.Degrees(-09.80022320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177794"},
        {"Hipparcos Number", "HIP 93826"},
        {"Smithsonian Astrophysical Observation", "SAO 143026"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.60580409),
        dec: Angle.Degrees(-09.79782273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64942"},
        {"Hipparcos Number", "HIP 38747"},
        {"Geneva Identification System", "GEN# +1.00064942"},
        {"Smithsonian Astrophysical Observation", "SAO 135272"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.99256079),
        dec: Angle.Degrees(-09.79714418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43363",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43363"},
        {"Geneva Identification System", "GEN# -0.00902670"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.49131411),
        dec: Angle.Degrees(-09.79637517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163716"},
        {"Hipparcos Number", "HIP 87949"},
        {"Smithsonian Astrophysical Observation", "SAO 141988"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.819,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.49133204),
        dec: Angle.Degrees(-09.79600719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159677"},
        {"Hipparcos Number", "HIP 86157"},
        {"Smithsonian Astrophysical Observation", "SAO 141754"},
    },
    visualMagnitude: 9.53,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.09276027),
        dec: Angle.Degrees(-09.79445040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206116"},
        {"Hipparcos Number", "HIP 107001"},
        {"Geneva Identification System", "GEN# +1.00206116"},
        {"Smithsonian Astrophysical Observation", "SAO 164563"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.04918618),
        dec: Angle.Degrees(-09.79430978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -164.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90241"},
        {"Hipparcos Number", "HIP 50986"},
        {"Smithsonian Astrophysical Observation", "SAO 137552"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.23484808),
        dec: Angle.Degrees(-09.79252895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9753",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9753"},
        {"Smithsonian Astrophysical Observation", "SAO 148191"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.35281718),
        dec: Angle.Degrees(-09.79187862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 155.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154638"},
        {"Hipparcos Number", "HIP 83756"},
        {"Smithsonian Astrophysical Observation", "SAO 141523"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.77051650),
        dec: Angle.Degrees(-09.79161188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106255",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106255"},
        {"Cincinnati Publication", "Ci 20 1288"},
        {"Geneva Identification System", "GEN# +6.10010831"},
        {"Geneva Identification System 2", "GEN# +9.80026007"},
    },
    visualMagnitude: 11.96,
    bvColour: 1.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.82467099),
        dec: Angle.Degrees(-09.79053173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1161.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108931"},
        {"Hipparcos Number", "HIP 61077"},
        {"Smithsonian Astrophysical Observation", "SAO 138825"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.76592991),
        dec: Angle.Degrees(-09.78747625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7580"},
        {"Hipparcos Number", "HIP 5899"},
        {"Geneva Identification System", "GEN# +1.00007580"},
        {"Smithsonian Astrophysical Observation", "SAO 147699"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.94579057),
        dec: Angle.Degrees(-09.78722623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31343"},
        {"Hipparcos Number", "HIP 22825"},
        {"Geneva Identification System", "GEN# +1.00031343"},
        {"Smithsonian Astrophysical Observation", "SAO 131591"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.67997191),
        dec: Angle.Degrees(-09.78602158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6706"},
        {"Hipparcos Number", "HIP 5296"},
        {"Geneva Identification System", "GEN# +1.00006706"},
        {"Smithsonian Astrophysical Observation", "SAO 147622"},
        {"Wilson Evans Batten Catalogue", "WEB 1133"},
    },
    visualMagnitude: 5.71,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.94216802),
        dec: Angle.Degrees(-09.78559168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 149.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64610"},
        {"Hipparcos Number", "HIP 38611"},
        {"Geneva Identification System", "GEN# +1.00064610"},
        {"Smithsonian Astrophysical Observation", "SAO 135235"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.59857832),
        dec: Angle.Degrees(-09.78557383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71097"},
        {"Hipparcos Number", "HIP 41265"},
        {"Smithsonian Astrophysical Observation", "SAO 135890"},
    },
    visualMagnitude: 7.96,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.28857288),
        dec: Angle.Degrees(-09.78547383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118281"},
        {"Hipparcos Number", "HIP 66347"},
        {"Geneva Identification System", "GEN# +1.00118281"},
        {"Smithsonian Astrophysical Observation", "SAO 139432"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.97517312),
        dec: Angle.Degrees(-09.78512454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135994"},
        {"Hipparcos Number", "HIP 74908"},
        {"Smithsonian Astrophysical Observation", "SAO 140442"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.63165256),
        dec: Angle.Degrees(-09.78404184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40577"},
        {"Hipparcos Number", "HIP 28346"},
        {"Geneva Identification System", "GEN# +1.00040577"},
        {"Smithsonian Astrophysical Observation", "SAO 132721"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.84933601),
        dec: Angle.Degrees(-09.77968606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59693"},
        {"Hipparcos Number", "HIP 36521"},
        {"Geneva Identification System", "GEN# +1.00059693"},
        {"Smithsonian Astrophysical Observation", "SAO 134775"},
        {"Wilson Evans Batten Catalogue", "WEB 7265"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.69778697),
        dec: Angle.Degrees(-09.77689783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18557"},
        {"Hipparcos Number", "HIP 13883"},
        {"Geneva Identification System", "GEN# +1.00018557"},
        {"Renson", "Renson 4650"},
        {"Smithsonian Astrophysical Observation", "SAO 130216"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.69711267),
        dec: Angle.Degrees(-09.77646597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208042"},
        {"Hipparcos Number", "HIP 108067"},
        {"Smithsonian Astrophysical Observation", "SAO 164721"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.42654794),
        dec: Angle.Degrees(-09.77611302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174464"},
        {"Hipparcos Number", "HIP 92488"},
        {"Geneva Identification System", "GEN# +1.00174464"},
        {"Smithsonian Astrophysical Observation", "SAO 142692"},
        {"Wilson Evans Batten Catalogue", "WEB 15984"},
    },
    visualMagnitude: 5.82,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.74377104),
        dec: Angle.Degrees(-09.77410171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50747",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7738 AB"},
        {"Henry Draper", "HD 89795"},
        {"Hipparcos Number", "HIP 50747"},
        {"Smithsonian Astrophysical Observation", "SAO 137515"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.43106200),
        dec: Angle.Degrees(-09.77376796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163917"},
        {"Hipparcos Number", "HIP 88048"},
        {"Fundamental Katalog 5th Edition", "FK5 673"},
        {"Geneva Identification System", "GEN# +1.00163917"},
        {"Smithsonian Astrophysical Observation", "SAO 142004"},
        {"Wilson Evans Batten Catalogue", "WEB 14873"},
    },
    visualMagnitude: 3.32,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.75665662),
        dec: Angle.Degrees(-09.77334973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95501"},
        {"Hipparcos Number", "HIP 53868"},
        {"Smithsonian Astrophysical Observation", "SAO 137941"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.31239318),
        dec: Angle.Degrees(-09.77179304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107795"},
        {"Hipparcos Number", "HIP 60420"},
        {"Smithsonian Astrophysical Observation", "SAO 138751"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.81814665),
        dec: Angle.Degrees(-09.77117705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110661"},
        {"Hipparcos Number", "HIP 62113"},
        {"Geneva Identification System", "GEN# +1.00110661"},
        {"Smithsonian Astrophysical Observation", "SAO 138935"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.95259021),
        dec: Angle.Degrees(-09.76859025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6573"},
        {"Hipparcos Number", "HIP 5197"},
        {"Smithsonian Astrophysical Observation", "SAO 147610"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.61245345),
        dec: Angle.Degrees(-09.76671448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17378",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Rana"},
        {"Henry Draper", "HD 23249"},
        {"Hipparcos Number", "HIP 17378"},
        {"Cincinnati Publication", "Ci 20 255"},
        {"Fundamental Katalog 5th Edition", "FK5 135"},
        {"Geneva Identification System", "GEN# +1.00023249"},
        {"Smithsonian Astrophysical Observation", "SAO 130686"},
        {"Wilson Evans Batten Catalogue", "WEB 3283"},
    },
    visualMagnitude: 3.52,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.81231706),
        dec: Angle.Degrees(-09.76519868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 742.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16787"},
        {"Hipparcos Number", "HIP 12534"},
        {"Smithsonian Astrophysical Observation", "SAO 130059"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.31089623),
        dec: Angle.Degrees(-09.76355892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34737"},
        {"Hipparcos Number", "HIP 24826"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.82458070),
        dec: Angle.Degrees(-09.76256130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220172"},
        {"Hipparcos Number", "HIP 115347"},
        {"Geneva Identification System", "GEN# +1.00220172"},
        {"Smithsonian Astrophysical Observation", "SAO 165651"},
        {"Wilson Evans Batten Catalogue", "WEB 20428"},
    },
    visualMagnitude: 7.67,
    bvColour: -0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.46191357),
        dec: Angle.Degrees(-09.76137449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63240",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8715 A"},
        {"Henry Draper", "HD 112517"},
        {"Hipparcos Number", "HIP 63240"},
        {"Smithsonian Astrophysical Observation", "SAO 139061"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.36890905),
        dec: Angle.Degrees(-09.76103313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78177"},
        {"Hipparcos Number", "HIP 44706"},
        {"Smithsonian Astrophysical Observation", "SAO 136584"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.63952304),
        dec: Angle.Degrees(-09.75915617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167833"},
        {"Hipparcos Number", "HIP 89623"},
        {"Fundamental Katalog 5th Edition", "FK5 1475"},
        {"Geneva Identification System", "GEN# +1.00167833"},
        {"Smithsonian Astrophysical Observation", "SAO 142192"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.35065994),
        dec: Angle.Degrees(-09.75846509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26068"},
        {"Hipparcos Number", "HIP 19226"},
        {"Smithsonian Astrophysical Observation", "SAO 130961"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.81558661),
        dec: Angle.Degrees(-09.75780386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127600"},
        {"Hipparcos Number", "HIP 71118"},
        {"Geneva Identification System", "GEN# +1.00127600"},
        {"Smithsonian Astrophysical Observation", "SAO 139989"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.14314320),
        dec: Angle.Degrees(-09.75700377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207186"},
        {"Hipparcos Number", "HIP 107589"},
        {"Smithsonian Astrophysical Observation", "SAO 145667"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.86478679),
        dec: Angle.Degrees(-09.75650962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121496"},
        {"Hipparcos Number", "HIP 68038"},
        {"Geneva Identification System", "GEN# +1.00121496"},
        {"Smithsonian Astrophysical Observation", "SAO 139627"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.97131380),
        dec: Angle.Degrees(-09.75531377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169582"},
        {"Hipparcos Number", "HIP 90320"},
        {"Geneva Identification System", "GEN# +1.00169582"},
        {"Smithsonian Astrophysical Observation", "SAO 142305"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.42977826),
        dec: Angle.Degrees(-09.75305912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8294",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8294"},
    },
    visualMagnitude: 10.95,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.73542962),
        dec: Angle.Degrees(-09.75269988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13721"},
        {"Hipparcos Number", "HIP 10360"},
        {"Geneva Identification System", "GEN# +1.00013721"},
        {"Smithsonian Astrophysical Observation", "SAO 129759"},
        {"Wilson Evans Batten Catalogue", "WEB 2170"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.38812901),
        dec: Angle.Degrees(-09.75255908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24832"},
        {"Hipparcos Number", "HIP 18455"},
        {"Fundamental Katalog 5th Edition", "FK5 2284"},
        {"Geneva Identification System", "GEN# +1.00024832"},
        {"Smithsonian Astrophysical Observation", "SAO 130833"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.15792309),
        dec: Angle.Degrees(-09.75085732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198074"},
        {"Hipparcos Number", "HIP 102652"},
        {"Smithsonian Astrophysical Observation", "SAO 144816"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.03427695),
        dec: Angle.Degrees(-09.74882140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71766"},
        {"Hipparcos Number", "HIP 41597"},
        {"Geneva Identification System", "GEN# +1.00071766"},
        {"Smithsonian Astrophysical Observation", "SAO 135965"},
    },
    visualMagnitude: 6.01,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.21252354),
        dec: Angle.Degrees(-09.74859459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203875"},
        {"Hipparcos Number", "HIP 105761"},
        {"Geneva Identification System", "GEN# +1.00203875"},
        {"Smithsonian Astrophysical Observation", "SAO 145382"},
    },
    visualMagnitude: 5.71,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.30423875),
        dec: Angle.Degrees(-09.74814011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -169.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153726"},
        {"Hipparcos Number", "HIP 83298"},
        {"Smithsonian Astrophysical Observation", "SAO 141486"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.36034165),
        dec: Angle.Degrees(-09.74643767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86343"},
        {"Hipparcos Number", "HIP 48829"},
        {"Smithsonian Astrophysical Observation", "SAO 137257"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.41391012),
        dec: Angle.Degrees(-09.74559154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210619"},
        {"Hipparcos Number", "HIP 109574"},
        {"Smithsonian Astrophysical Observation", "SAO 145929"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.95864123),
        dec: Angle.Degrees(-09.74532142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122771"},
        {"Hipparcos Number", "HIP 68709"},
        {"Smithsonian Astrophysical Observation", "SAO 139704"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.99061454),
        dec: Angle.Degrees(-09.74515209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204848"},
        {"Hipparcos Number", "HIP 106280"},
        {"Fundamental Katalog 5th Edition", "FK5 5902"},
        {"Geneva Identification System", "GEN# +1.00204848"},
        {"Smithsonian Astrophysical Observation", "SAO 145455"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.89348459),
        dec: Angle.Degrees(-09.74440638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117141"},
        {"Hipparcos Number", "HIP 65735"},
        {"Fundamental Katalog 5th Edition", "FK5 5188"},
        {"Smithsonian Astrophysical Observation", "SAO 139354"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.11864344),
        dec: Angle.Degrees(-09.74359806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 953"},
        {"Hipparcos Number", "HIP 1117"},
        {"Smithsonian Astrophysical Observation", "SAO 147158"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.48324103),
        dec: Angle.Degrees(-09.74249444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211518"},
        {"Hipparcos Number", "HIP 110077"},
        {"Geneva Identification System", "GEN# +1.00211518"},
        {"Smithsonian Astrophysical Observation", "SAO 145999"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.45917507),
        dec: Angle.Degrees(-09.74187799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213066"},
        {"Hipparcos Number", "HIP 110979"},
        {"Geneva Identification System", "GEN# +1.00213066"},
        {"Smithsonian Astrophysical Observation", "SAO 146111"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.27036167),
        dec: Angle.Degrees(-09.74096190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128595"},
        {"Hipparcos Number", "HIP 71553"},
        {"Smithsonian Astrophysical Observation", "SAO 140042"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.51784306),
        dec: Angle.Degrees(-09.73787738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24231"},
        {"Hipparcos Number", "HIP 18016"},
        {"Geneva Identification System", "GEN# +1.00024231"},
        {"Smithsonian Astrophysical Observation", "SAO 130772"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.75941816),
        dec: Angle.Degrees(-09.73758650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21375",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3318 B"},
        {"Henry Draper", "HD 29172"},
        {"Hipparcos Number", "HIP 21375"},
        {"Geneva Identification System", "GEN# +1.00029172"},
        {"Renson", "Renson 7460"},
        {"Smithsonian Astrophysical Observation", "SAO 131334"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.80519261),
        dec: Angle.Degrees(-09.73694425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21377",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3318 A"},
        {"Henry Draper", "HD 29173"},
        {"Hipparcos Number", "HIP 21377"},
        {"Geneva Identification System", "GEN# +1.00029173J"},
        {"Renson", "Renson 7470"},
        {"Smithsonian Astrophysical Observation", "SAO 131335"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.80874220),
        dec: Angle.Degrees(-09.73633417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86606",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86606"},
        {"Smithsonian Astrophysical Observation", "SAO 141813"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.46535329),
        dec: Angle.Degrees(-09.73537043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40658"},
        {"Hipparcos Number", "HIP 28399"},
        {"Smithsonian Astrophysical Observation", "SAO 132731"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.97358663),
        dec: Angle.Degrees(-09.73317038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20572"},
        {"Hipparcos Number", "HIP 15378"},
        {"Geneva Identification System", "GEN# +1.00020572"},
        {"Smithsonian Astrophysical Observation", "SAO 130410"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.58241298),
        dec: Angle.Degrees(-09.73155700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56496"},
        {"Hipparcos Number", "HIP 35230"},
        {"Fundamental Katalog 5th Edition", "FK5 4655"},
        {"Smithsonian Astrophysical Observation", "SAO 134452"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.22120316),
        dec: Angle.Degrees(-09.73109260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21811"},
        {"Hipparcos Number", "HIP 16350"},
        {"Smithsonian Astrophysical Observation", "SAO 130532"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.66904923),
        dec: Angle.Degrees(-09.73032801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8729",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1492 AB"},
        {"Henry Draper", "HD 11434"},
        {"Hipparcos Number", "HIP 8729"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.06598932),
        dec: Angle.Degrees(-09.73031320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153241"},
        {"Hipparcos Number", "HIP 83077"},
        {"Smithsonian Astrophysical Observation", "SAO 141462"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.63922493),
        dec: Angle.Degrees(-09.72611200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15410"},
        {"Hipparcos Number", "HIP 11525"},
        {"Geneva Identification System", "GEN# +1.00015410"},
        {"Smithsonian Astrophysical Observation", "SAO 129928"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.14971688),
        dec: Angle.Degrees(-09.72537266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142662"},
        {"Hipparcos Number", "HIP 78056"},
        {"Smithsonian Astrophysical Observation", "SAO 140843"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.05197230),
        dec: Angle.Degrees(-09.72274733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92054"},
        {"Hipparcos Number", "HIP 52017"},
        {"Renson", "Renson 26450"},
        {"Smithsonian Astrophysical Observation", "SAO 137689"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.40931531),
        dec: Angle.Degrees(-09.71830947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136343"},
        {"Hipparcos Number", "HIP 75081"},
        {"Smithsonian Astrophysical Observation", "SAO 140468"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.14049122),
        dec: Angle.Degrees(-09.71792249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157200"},
        {"Hipparcos Number", "HIP 84990"},
        {"Smithsonian Astrophysical Observation", "SAO 141632"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.56838170),
        dec: Angle.Degrees(-09.71631582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103433"},
        {"Hipparcos Number", "HIP 58072"},
        {"Smithsonian Astrophysical Observation", "SAO 138473"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.64631476),
        dec: Angle.Degrees(-09.71553900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73178"},
        {"Hipparcos Number", "HIP 42234"},
        {"Smithsonian Astrophysical Observation", "SAO 136086"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.16486539),
        dec: Angle.Degrees(-09.71422403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221685"},
        {"Hipparcos Number", "HIP 116329"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.58050131),
        dec: Angle.Degrees(-09.70950599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120033"},
        {"Hipparcos Number", "HIP 67271"},
        {"Geneva Identification System", "GEN# +1.00120033J"},
        {"Smithsonian Astrophysical Observation", "SAO 139544"},
        {"Wilson Evans Batten Catalogue", "WEB 11835"},
    },
    visualMagnitude: 6.04,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.80585036),
        dec: Angle.Degrees(-09.70935031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37635"},
        {"Hipparcos Number", "HIP 26623"},
        {"Celescope Catalog", "CEL 902"},
        {"Geneva Identification System", "GEN# +1.00037635"},
        {"Smithsonian Astrophysical Observation", "SAO 132425"},
        {"Wilson Evans Batten Catalogue", "WEB 5250"},
    },
    visualMagnitude: 6.49,
    bvColour: -0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.87849027),
        dec: Angle.Degrees(-09.70660690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129784"},
        {"Hipparcos Number", "HIP 72082"},
        {"Geneva Identification System", "GEN# +1.00129784"},
        {"Smithsonian Astrophysical Observation", "SAO 140109"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.18779117),
        dec: Angle.Degrees(-09.70394499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191931"},
        {"Hipparcos Number", "HIP 99582"},
        {"Smithsonian Astrophysical Observation", "SAO 144168"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.14139449),
        dec: Angle.Degrees(-09.70365133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 738"},
        {"Hipparcos Number", "HIP 947"},
        {"Geneva Identification System", "GEN# +1.00000738"},
        {"Smithsonian Astrophysical Observation", "SAO 128633"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.91985390),
        dec: Angle.Degrees(-09.70277372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9309"},
        {"Hipparcos Number", "HIP 7102"},
        {"Smithsonian Astrophysical Observation", "SAO 129349"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.87862784),
        dec: Angle.Degrees(-09.70153873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34776"},
        {"Hipparcos Number", "HIP 24844"},
        {"Smithsonian Astrophysical Observation", "SAO 131988"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.89321277),
        dec: Angle.Degrees(-09.70079618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24964"},
        {"Hipparcos Number", "HIP 18522"},
        {"Smithsonian Astrophysical Observation", "SAO 130847"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.40954661),
        dec: Angle.Degrees(-09.69990052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129566"},
        {"Hipparcos Number", "HIP 71997"},
        {"Geneva Identification System", "GEN# +1.00129566"},
        {"Smithsonian Astrophysical Observation", "SAO 140094"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.85761107),
        dec: Angle.Degrees(-09.69966828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215582"},
        {"Hipparcos Number", "HIP 112425"},
        {"Smithsonian Astrophysical Observation", "SAO 146302"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.58014203),
        dec: Angle.Degrees(-09.69850213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103401",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14449 A"},
        {"Henry Draper", "HD 199345"},
        {"Hipparcos Number", "HIP 103401"},
        {"Geneva Identification System", "GEN# +1.00199345"},
        {"Smithsonian Astrophysical Observation", "SAO 144968"},
        {"Wilson Evans Batten Catalogue", "WEB 18800"},
    },
    visualMagnitude: 5.49,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.22512443),
        dec: Angle.Degrees(-09.69751669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148967"},
        {"Hipparcos Number", "HIP 80968"},
        {"Geneva Identification System", "GEN# +1.00148967"},
        {"Smithsonian Astrophysical Observation", "SAO 141226"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.00427187),
        dec: Angle.Degrees(-09.69609174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117516"},
        {"Hipparcos Number", "HIP 65927"},
        {"Smithsonian Astrophysical Observation", "SAO 139375"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.72440897),
        dec: Angle.Degrees(-09.69317955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98605"},
        {"Hipparcos Number", "HIP 55395"},
        {"Renson", "Renson 28400"},
        {"Smithsonian Astrophysical Observation", "SAO 138143"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.14101914),
        dec: Angle.Degrees(-09.69088425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50513"},
        {"Hipparcos Number", "HIP 33076"},
        {"Smithsonian Astrophysical Observation", "SAO 133831"},
    },
    visualMagnitude: 7.83,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.32730080),
        dec: Angle.Degrees(-09.69032339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221802"},
        {"Hipparcos Number", "HIP 116404"},
        {"Smithsonian Astrophysical Observation", "SAO 146790"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.81734314),
        dec: Angle.Degrees(-09.68982729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219256"},
        {"Hipparcos Number", "HIP 114752"},
        {"Smithsonian Astrophysical Observation", "SAO 146587"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.67456355),
        dec: Angle.Degrees(-09.68836024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20205"},
        {"Hipparcos Number", "HIP 15084"},
        {"Geneva Identification System", "GEN# +1.00020205"},
        {"Smithsonian Astrophysical Observation", "SAO 130375"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.63692622),
        dec: Angle.Degrees(-09.68689013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180727"},
        {"Hipparcos Number", "HIP 94851"},
        {"Geneva Identification System", "GEN# +1.00180727"},
        {"Smithsonian Astrophysical Observation", "SAO 143234"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.50276459),
        dec: Angle.Degrees(-09.68622681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19448",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19448"},
        {"Smithsonian Astrophysical Observation", "SAO 130997"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.47444926),
        dec: Angle.Degrees(-09.68553131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39189"},
        {"Hipparcos Number", "HIP 27577"},
        {"Smithsonian Astrophysical Observation", "SAO 132582"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.61286152),
        dec: Angle.Degrees(-09.68444729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44482"},
        {"Hipparcos Number", "HIP 30240"},
        {"Celescope Catalog", "CEL 1198"},
        {"Geneva Identification System", "GEN# +1.00044482"},
        {"Smithsonian Astrophysical Observation", "SAO 133158"},
    },
    visualMagnitude: 7.36,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.42879282),
        dec: Angle.Degrees(-09.68291408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186909"},
        {"Hipparcos Number", "HIP 97380"},
        {"Smithsonian Astrophysical Observation", "SAO 143799"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.86919970),
        dec: Angle.Degrees(-09.68026196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219906"},
        {"Hipparcos Number", "HIP 115160"},
        {"Smithsonian Astrophysical Observation", "SAO 146640"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.91244052),
        dec: Angle.Degrees(-09.67670530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155662"},
        {"Hipparcos Number", "HIP 84251"},
        {"Smithsonian Astrophysical Observation", "SAO 141560"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.33061862),
        dec: Angle.Degrees(-09.67499809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222775"},
        {"Hipparcos Number", "HIP 117044"},
        {"Geneva Identification System", "GEN# +1.00222775"},
        {"Smithsonian Astrophysical Observation", "SAO 146867"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.90215463),
        dec: Angle.Degrees(-09.67395268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149463"},
        {"Hipparcos Number", "HIP 81217"},
        {"Geneva Identification System", "GEN# +1.00149463"},
        {"Smithsonian Astrophysical Observation", "SAO 141256"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.83401430),
        dec: Angle.Degrees(-09.67222726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27366",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Saiph"},
        {"Henry Draper", "HD 38771"},
        {"Hipparcos Number", "HIP 27366"},
        {"Celescope Catalog", "CEL 976"},
        {"Fundamental Katalog 5th Edition", "FK5 220"},
        {"Geneva Identification System", "GEN# +1.00038771"},
        {"Smithsonian Astrophysical Observation", "SAO 132542"},
        {"Wilson Evans Batten Catalogue", "WEB 5378"},
    },
    visualMagnitude: 2.07,
    bvColour: -0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.93911641),
        dec: Angle.Degrees(-09.66960186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60114"},
        {"Hipparcos Number", "HIP 36673"},
        {"Smithsonian Astrophysical Observation", "SAO 134821"},
    },
    visualMagnitude: 7.56,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.17429001),
        dec: Angle.Degrees(-09.66934387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114204",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16521 A"},
        {"Henry Draper", "HD 218400"},
        {"Hipparcos Number", "HIP 114204"},
        {"Geneva Identification System", "GEN# +1.00218400"},
        {"Smithsonian Astrophysical Observation", "SAO 146518"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.92549126),
        dec: Angle.Degrees(-09.66716612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50213",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50213"},
        {"Cincinnati Publication", "Ci 20 569"},
    },
    visualMagnitude: 11.74,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.76239339),
        dec: Angle.Degrees(-09.66651938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -514.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -214.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22573"},
        {"Hipparcos Number", "HIP 16902"},
        {"Smithsonian Astrophysical Observation", "SAO 130612"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.36833289),
        dec: Angle.Degrees(-09.66404430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111001",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15977 A"},
        {"Henry Draper", "HD 213123"},
        {"Hipparcos Number", "HIP 111001"},
        {"Smithsonian Astrophysical Observation", "SAO 146113"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.32729704),
        dec: Angle.Degrees(-09.66271709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205130"},
        {"Hipparcos Number", "HIP 106444"},
        {"Geneva Identification System", "GEN# +1.00205130"},
        {"Smithsonian Astrophysical Observation", "SAO 145483"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.39711020),
        dec: Angle.Degrees(-09.66056060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109783"},
        {"Hipparcos Number", "HIP 61606"},
        {"Smithsonian Astrophysical Observation", "SAO 138879"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.37982214),
        dec: Angle.Degrees(-09.65913238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64113"},
        {"Hipparcos Number", "HIP 38393"},
        {"Smithsonian Astrophysical Observation", "SAO 135189"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.98607115),
        dec: Angle.Degrees(-09.65570948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193896"},
        {"Hipparcos Number", "HIP 100524"},
        {"Fundamental Katalog 5th Edition", "FK5 3632"},
        {"Geneva Identification System", "GEN# +1.00193896"},
        {"Smithsonian Astrophysical Observation", "SAO 144361"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.75322975),
        dec: Angle.Degrees(-09.65467053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103379",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103379"},
        {"Geneva Identification System", "GEN# -0.01005549"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.16659482),
        dec: Angle.Degrees(-09.65445171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -353.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46060"},
        {"Hipparcos Number", "HIP 31042"},
        {"Celescope Catalog", "CEL 1274"},
        {"Geneva Identification System", "GEN# +1.00046060"},
        {"Smithsonian Astrophysical Observation", "SAO 133356"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.70756390),
        dec: Angle.Degrees(-09.65411177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31045",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31045"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.70936800),
        dec: Angle.Degrees(-09.65141623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31210"},
        {"Hipparcos Number", "HIP 22752"},
        {"Geneva Identification System", "GEN# +1.00031210"},
        {"Smithsonian Astrophysical Observation", "SAO 131579"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.41267847),
        dec: Angle.Degrees(-09.65061831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20908"},
        {"Hipparcos Number", "HIP 15682"},
        {"Smithsonian Astrophysical Observation", "SAO 130444"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.50715773),
        dec: Angle.Degrees(-09.65051460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51027"},
        {"Hipparcos Number", "HIP 33285"},
        {"Geneva Identification System", "GEN# +1.00051027"},
        {"Smithsonian Astrophysical Observation", "SAO 133901"},
    },
    visualMagnitude: 8.55,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.85774471),
        dec: Angle.Degrees(-09.64932067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42184"},
        {"Hipparcos Number", "HIP 29153"},
        {"Smithsonian Astrophysical Observation", "SAO 132886"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.24245088),
        dec: Angle.Degrees(-09.64790891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145005"},
        {"Hipparcos Number", "HIP 79122"},
        {"Geneva Identification System", "GEN# +1.00145005"},
        {"Smithsonian Astrophysical Observation", "SAO 140989"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.25898204),
        dec: Angle.Degrees(-09.64778598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224383"},
        {"Hipparcos Number", "HIP 118115"},
        {"Cincinnati Publication", "Ci 20 1462"},
        {"Geneva Identification System", "GEN# +1.00224383"},
        {"Smithsonian Astrophysical Observation", "SAO 146997"},
        {"Wilson Evans Batten Catalogue", "WEB 20765"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.38853299),
        dec: Angle.Degrees(-09.64716359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 455.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112346",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16238 A"},
        {"Henry Draper", "HD 215449"},
        {"Hipparcos Number", "HIP 112346"},
        {"Smithsonian Astrophysical Observation", "SAO 146296"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.33660972),
        dec: Angle.Degrees(-09.64450892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196994"},
        {"Hipparcos Number", "HIP 102072"},
        {"Smithsonian Astrophysical Observation", "SAO 144696"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.28062302),
        dec: Angle.Degrees(-09.64440299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122084"},
        {"Hipparcos Number", "HIP 68371"},
        {"Smithsonian Astrophysical Observation", "SAO 139665"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.93074433),
        dec: Angle.Degrees(-09.64416463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113127"},
        {"Hipparcos Number", "HIP 63573"},
        {"Geneva Identification System", "GEN# +1.00113127"},
        {"Smithsonian Astrophysical Observation", "SAO 139106"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.42001998),
        dec: Angle.Degrees(-09.64085654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92341",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92341"},
    },
    visualMagnitude: 10.94,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.30138739),
        dec: Angle.Degrees(-09.63876380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52384"},
        {"Hipparcos Number", "HIP 33764"},
        {"Celescope Catalog", "CEL 1498"},
        {"Geneva Identification System", "GEN# +1.00052384"},
        {"Smithsonian Astrophysical Observation", "SAO 134043"},
    },
    visualMagnitude: 8.99,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.18390161),
        dec: Angle.Degrees(-09.63663212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42604"},
        {"Hipparcos Number", "HIP 29361"},
        {"Smithsonian Astrophysical Observation", "SAO 132934"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.82763528),
        dec: Angle.Degrees(-09.63580686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177706"},
        {"Hipparcos Number", "HIP 93801"},
        {"Geneva Identification System", "GEN# +1.00177706"},
        {"Smithsonian Astrophysical Observation", "SAO 143015"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.54481817),
        dec: Angle.Degrees(-09.63218568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4375",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4375"},
        {"Smithsonian Astrophysical Observation", "SAO 129036"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.01135866),
        dec: Angle.Degrees(-09.63209801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57863"},
        {"Hipparcos Number", "HIP 35775"},
        {"Geneva Identification System", "GEN# +1.00057863"},
        {"Smithsonian Astrophysical Observation", "SAO 134593"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.70072879),
        dec: Angle.Degrees(-09.63174705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154364"},
        {"Hipparcos Number", "HIP 83605"},
        {"Smithsonian Astrophysical Observation", "SAO 141511"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.33236172),
        dec: Angle.Degrees(-09.63024295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202020"},
        {"Hipparcos Number", "HIP 104785"},
        {"Geneva Identification System", "GEN# +1.00202020"},
        {"Smithsonian Astrophysical Observation", "SAO 145216"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.41459624),
        dec: Angle.Degrees(-09.62830061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1828"},
        {"Hipparcos Number", "HIP 1787"},
        {"Geneva Identification System", "GEN# +1.00001828"},
        {"Smithsonian Astrophysical Observation", "SAO 128724"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.67984255),
        dec: Angle.Degrees(-09.62276852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79993"},
        {"Hipparcos Number", "HIP 45547"},
        {"Smithsonian Astrophysical Observation", "SAO 136731"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.24942067),
        dec: Angle.Degrees(-09.62159358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76620"},
        {"Hipparcos Number", "HIP 43943"},
        {"Smithsonian Astrophysical Observation", "SAO 136431"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.25771256),
        dec: Angle.Degrees(-09.62094611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139660"},
        {"Hipparcos Number", "HIP 76703"},
        {"Smithsonian Astrophysical Observation", "SAO 140684"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.93254588),
        dec: Angle.Degrees(-09.61932050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21963",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3404 A"},
        {"Henry Draper", "HD 29980"},
        {"Hipparcos Number", "HIP 21963"},
        {"Geneva Identification System", "GEN# +1.00029980"},
        {"Smithsonian Astrophysical Observation", "SAO 131440"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.81824177),
        dec: Angle.Degrees(-09.61821424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112050"},
        {"Hipparcos Number", "HIP 62920"},
        {"Smithsonian Astrophysical Observation", "SAO 139028"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.42394529),
        dec: Angle.Degrees(-09.61820581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192207"},
        {"Hipparcos Number", "HIP 99714"},
        {"Smithsonian Astrophysical Observation", "SAO 144188"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.50181952),
        dec: Angle.Degrees(-09.61795309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63"},
        {"Hipparcos Number", "HIP 462"},
        {"Geneva Identification System", "GEN# +1.00000063"},
        {"Smithsonian Astrophysical Observation", "SAO 128577"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.37961808),
        dec: Angle.Degrees(-09.61729691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91913"},
        {"Hipparcos Number", "HIP 51944"},
        {"Geneva Identification System", "GEN# +1.00091913"},
        {"Smithsonian Astrophysical Observation", "SAO 137673"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.17857968),
        dec: Angle.Degrees(-09.61643003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119351"},
        {"Hipparcos Number", "HIP 66929"},
        {"Smithsonian Astrophysical Observation", "SAO 139501"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.74583111),
        dec: Angle.Degrees(-09.61597099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86780"},
        {"Hipparcos Number", "HIP 49049"},
        {"Smithsonian Astrophysical Observation", "SAO 137284"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.13671411),
        dec: Angle.Degrees(-09.61266279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128275"},
        {"Hipparcos Number", "HIP 71417"},
        {"Smithsonian Astrophysical Observation", "SAO 140027"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.07523593),
        dec: Angle.Degrees(-09.61248198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115115",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16671 A"},
        {"Henry Draper", "HD 219832"},
        {"Hipparcos Number", "HIP 115115"},
        {"Fundamental Katalog 5th Edition", "FK5 1609"},
        {"Geneva Identification System", "GEN# +1.00219832"},
        {"Smithsonian Astrophysical Observation", "SAO 146635"},
        {"Wilson Evans Batten Catalogue", "WEB 20392"},
    },
    visualMagnitude: 4.99,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.74021218),
        dec: Angle.Degrees(-09.61073100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45802",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7311 B"},
        {"Henry Draper", "HD 80550"},
        {"Hipparcos Number", "HIP 45802"},
        {"Geneva Identification System", "GEN# +1.00080550"},
        {"Smithsonian Astrophysical Observation", "SAO 136767"},
        {"Wilson Evans Batten Catalogue", "WEB 8685"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.08757014),
        dec: Angle.Degrees(-09.61010253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213780"},
        {"Hipparcos Number", "HIP 111398"},
        {"Smithsonian Astrophysical Observation", "SAO 146161"},
        {"Wilson Evans Batten Catalogue", "WEB 19922"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.52760425),
        dec: Angle.Degrees(-09.60847619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218210"},
        {"Hipparcos Number", "HIP 114079"},
        {"Smithsonian Astrophysical Observation", "SAO 146509"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.57151541),
        dec: Angle.Degrees(-09.60598773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68083"},
        {"Hipparcos Number", "HIP 40025"},
        {"Smithsonian Astrophysical Observation", "SAO 135587"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.62735561),
        dec: Angle.Degrees(-09.60474731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161770"},
        {"Hipparcos Number", "HIP 87101"},
        {"Geneva Identification System", "GEN# +1.00161770"},
        {"Smithsonian Astrophysical Observation", "SAO 141880"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.94233997),
        dec: Angle.Degrees(-09.60461627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -144.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -209.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23304"},
        {"Hipparcos Number", "HIP 17406"},
        {"Smithsonian Astrophysical Observation", "SAO 130691"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.93999960),
        dec: Angle.Degrees(-09.60299388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109392"},
        {"Hipparcos Number", "HIP 61360"},
        {"Geneva Identification System", "GEN# +1.00109392"},
        {"Smithsonian Astrophysical Observation", "SAO 138854"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.60275228),
        dec: Angle.Degrees(-09.60108100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11277",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1843 AB"},
        {"Henry Draper", "HD 15044"},
        {"Hipparcos Number", "HIP 11277"},
        {"Smithsonian Astrophysical Observation", "SAO 129892"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.30581813),
        dec: Angle.Degrees(-09.60005685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10919"},
        {"Hipparcos Number", "HIP 8304"},
        {"Smithsonian Astrophysical Observation", "SAO 129497"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.77622276),
        dec: Angle.Degrees(-09.59930670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64203",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64203"},
        {"Geneva Identification System", "GEN# -0.00803497"},
    },
    visualMagnitude: 10.30,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.37169256),
        dec: Angle.Degrees(-09.59868841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -144.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9399",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9399"},
        {"Smithsonian Astrophysical Observation", "SAO 129629"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.19721439),
        dec: Angle.Degrees(-09.59866000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205787"},
        {"Hipparcos Number", "HIP 106795"},
        {"Renson", "Renson 57308"},
        {"Smithsonian Astrophysical Observation", "SAO 145539"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.45944309),
        dec: Angle.Degrees(-09.59680060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168443"},
        {"Hipparcos Number", "HIP 89844"},
        {"Cincinnati Publication", "Ci 18 2414"},
        {"Geneva Identification System", "GEN# +1.00168443"},
        {"Smithsonian Astrophysical Observation", "SAO 142228"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.01660879),
        dec: Angle.Degrees(-09.59517776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -224.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119829"},
        {"Hipparcos Number", "HIP 67145"},
        {"Geneva Identification System", "GEN# +1.00119829"},
        {"Smithsonian Astrophysical Observation", "SAO 139532"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.40614732),
        dec: Angle.Degrees(-09.59488410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133728"},
        {"Hipparcos Number", "HIP 73906"},
        {"Smithsonian Astrophysical Observation", "SAO 140321"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.56399288),
        dec: Angle.Degrees(-09.59114509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38024"},
        {"Hipparcos Number", "HIP 26881"},
        {"Smithsonian Astrophysical Observation", "SAO 132473"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.60365234),
        dec: Angle.Degrees(-09.59040086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73766"},
        {"Hipparcos Number", "HIP 42489"},
        {"Geneva Identification System", "GEN# +1.00073766"},
        {"Smithsonian Astrophysical Observation", "SAO 136144"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.93228399),
        dec: Angle.Degrees(-09.58689964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86242"},
        {"Hipparcos Number", "HIP 48784"},
        {"Geneva Identification System", "GEN# +1.00086242"},
        {"Smithsonian Astrophysical Observation", "SAO 137246"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.25505074),
        dec: Angle.Degrees(-09.58647683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138410"},
        {"Hipparcos Number", "HIP 76080"},
        {"Smithsonian Astrophysical Observation", "SAO 140590"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.07444140),
        dec: Angle.Degrees(-09.58640128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192648"},
        {"Hipparcos Number", "HIP 99900"},
        {"Smithsonian Astrophysical Observation", "SAO 144229"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.04311465),
        dec: Angle.Degrees(-09.58598378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208445"},
        {"Hipparcos Number", "HIP 108298"},
        {"Smithsonian Astrophysical Observation", "SAO 145758"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.10368405),
        dec: Angle.Degrees(-09.58586100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139626"},
        {"Hipparcos Number", "HIP 76682"},
        {"Geneva Identification System", "GEN# +1.00139626"},
        {"Smithsonian Astrophysical Observation", "SAO 140681"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.88226903),
        dec: Angle.Degrees(-09.58537402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90529",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90529"},
        {"Geneva Identification System", "GEN# -0.00904742"},
        {"Smithsonian Astrophysical Observation", "SAO 142335"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.08389277),
        dec: Angle.Degrees(-09.58478523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218047"},
        {"Hipparcos Number", "HIP 113986"},
        {"Geneva Identification System", "GEN# +1.00218047"},
        {"Smithsonian Astrophysical Observation", "SAO 146496"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.25776925),
        dec: Angle.Degrees(-09.58328606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54104"},
        {"Hipparcos Number", "HIP 34355"},
        {"Celescope Catalog", "CEL 1596"},
        {"Geneva Identification System", "GEN# +1.00054104"},
        {"Smithsonian Astrophysical Observation", "SAO 134219"},
        {"Wilson Evans Batten Catalogue", "WEB 6883"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.83620022),
        dec: Angle.Degrees(-09.58321830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11410"},
        {"Hipparcos Number", "HIP 8710"},
        {"Smithsonian Astrophysical Observation", "SAO 129542"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.01594637),
        dec: Angle.Degrees(-09.58132133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114522"},
        {"Hipparcos Number", "HIP 64342"},
        {"Smithsonian Astrophysical Observation", "SAO 139204"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.82850871),
        dec: Angle.Degrees(-09.58061660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196028"},
        {"Hipparcos Number", "HIP 101567"},
        {"Smithsonian Astrophysical Observation", "SAO 144595"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.76492975),
        dec: Angle.Degrees(-09.58052105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12176"},
        {"Hipparcos Number", "HIP 9282"},
        {"Geneva Identification System", "GEN# +1.00012176"},
        {"Smithsonian Astrophysical Observation", "SAO 129606"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.82743464),
        dec: Angle.Degrees(-09.58005648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19668"},
        {"Hipparcos Number", "HIP 14684"},
        {"Smithsonian Astrophysical Observation", "SAO 130311"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.42597613),
        dec: Angle.Degrees(-09.57933346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202928"},
        {"Hipparcos Number", "HIP 105258"},
        {"Smithsonian Astrophysical Observation", "SAO 145293"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.81418851),
        dec: Angle.Degrees(-09.57878607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165200"},
        {"Hipparcos Number", "HIP 88582"},
        {"Geneva Identification System", "GEN# +1.00165200"},
        {"Smithsonian Astrophysical Observation", "SAO 142071"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.29610500),
        dec: Angle.Degrees(-09.57823135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73714"},
        {"Hipparcos Number", "HIP 42457"},
        {"Smithsonian Astrophysical Observation", "SAO 136140"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.84778802),
        dec: Angle.Degrees(-09.57768623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115608"},
        {"Hipparcos Number", "HIP 64911"},
        {"Smithsonian Astrophysical Observation", "SAO 139270"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.57663969),
        dec: Angle.Degrees(-09.57638946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174866"},
        {"Hipparcos Number", "HIP 92674"},
        {"Geneva Identification System", "GEN# +1.00174866"},
        {"Smithsonian Astrophysical Observation", "SAO 142741"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.25748147),
        dec: Angle.Degrees(-09.57555831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76570",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76570"},
        {"Smithsonian Astrophysical Observation", "SAO 140666"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.56813116),
        dec: Angle.Degrees(-09.57425280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4435"},
        {"Hipparcos Number", "HIP 3630"},
        {"Smithsonian Astrophysical Observation", "SAO 128949"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.62970425),
        dec: Angle.Degrees(-09.57421488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87262"},
        {"Hipparcos Number", "HIP 49293"},
        {"Geneva Identification System", "GEN# +1.00087262"},
        {"Smithsonian Astrophysical Observation", "SAO 137326"},
    },
    visualMagnitude: 6.09,
    bvColour: 1.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.92079300),
        dec: Angle.Degrees(-09.57376953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121373"},
        {"Hipparcos Number", "HIP 67968"},
        {"Smithsonian Astrophysical Observation", "SAO 139620"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.78258126),
        dec: Angle.Degrees(-09.57363191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217775"},
        {"Hipparcos Number", "HIP 113828"},
        {"Smithsonian Astrophysical Observation", "SAO 146475"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.77066813),
        dec: Angle.Degrees(-09.57084622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
