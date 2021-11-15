using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_36() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66153"},
        {"Hipparcos Number", "HIP 39202"},
        {"Smithsonian Astrophysical Observation", "SAO 174987"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.28186282),
        dec: Angle.Degrees(-29.87764531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9783"},
        {"Hipparcos Number", "HIP 7378"},
        {"Geneva Identification System", "GEN# +1.00009783"},
        {"Smithsonian Astrophysical Observation", "SAO 193191"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.76786701),
        dec: Angle.Degrees(-29.87567790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215918"},
        {"Hipparcos Number", "HIP 112677"},
        {"Smithsonian Astrophysical Observation", "SAO 214106"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.26696357),
        dec: Angle.Degrees(-29.87512945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67920"},
        {"Hipparcos Number", "HIP 39915"},
        {"Geneva Identification System", "GEN# +1.00067920"},
        {"Smithsonian Astrophysical Observation", "SAO 175272"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.27937892),
        dec: Angle.Degrees(-29.87206163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83705"},
        {"Hipparcos Number", "HIP 47408"},
        {"Smithsonian Astrophysical Observation", "SAO 177808"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.90324100),
        dec: Angle.Degrees(-29.87129581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157416"},
        {"Hipparcos Number", "HIP 85171"},
        {"Geneva Identification System", "GEN# +1.00157416"},
        {"Smithsonian Astrophysical Observation", "SAO 185358"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.08211065),
        dec: Angle.Degrees(-29.87039419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223120"},
        {"Hipparcos Number", "HIP 117292"},
        {"Smithsonian Astrophysical Observation", "SAO 214769"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.74006455),
        dec: Angle.Degrees(-29.87037127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43806"},
        {"Hipparcos Number", "HIP 29836"},
        {"Geneva Identification System", "GEN# +1.00043806"},
        {"Smithsonian Astrophysical Observation", "SAO 171504"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.23517455),
        dec: Angle.Degrees(-29.87018228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14882"},
        {"Hipparcos Number", "HIP 11131"},
        {"Geneva Identification System", "GEN# +1.00014882J"},
        {"Smithsonian Astrophysical Observation", "SAO 193680"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.81079265),
        dec: Angle.Degrees(-29.86908576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3810"},
        {"Hipparcos Number", "HIP 3182"},
        {"Geneva Identification System", "GEN# +1.00003810"},
        {"Smithsonian Astrophysical Observation", "SAO 192672"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.13394965),
        dec: Angle.Degrees(-29.86854449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 107.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203879"},
        {"Hipparcos Number", "HIP 105809"},
        {"Smithsonian Astrophysical Observation", "SAO 212993"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.43219763),
        dec: Angle.Degrees(-29.86752189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170958"},
        {"Hipparcos Number", "HIP 90973"},
        {"Geneva Identification System", "GEN# +1.00170958"},
        {"Smithsonian Astrophysical Observation", "SAO 186961"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.35352425),
        dec: Angle.Degrees(-29.86673576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157919"},
        {"Hipparcos Number", "HIP 85423"},
        {"Fundamental Katalog 5th Edition", "FK5 646"},
        {"Geneva Identification System", "GEN# +1.00157919"},
        {"Renson", "Renson 44410"},
        {"Smithsonian Astrophysical Observation", "SAO 185412"},
        {"Wilson Evans Batten Catalogue", "WEB 14429"},
    },
    visualMagnitude: 4.28,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.83860010),
        dec: Angle.Degrees(-29.86669942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34483"},
        {"Hipparcos Number", "HIP 24585"},
        {"Smithsonian Astrophysical Observation", "SAO 170264"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.11911314),
        dec: Angle.Degrees(-29.86618507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12318"},
        {"Hipparcos Number", "HIP 9354"},
        {"Smithsonian Astrophysical Observation", "SAO 193444"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.05038202),
        dec: Angle.Degrees(-29.86611925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57618"},
        {"Hipparcos Number", "HIP 35604"},
        {"Celescope Catalog", "CEL 1796"},
        {"Geneva Identification System", "GEN# +1.00057618"},
        {"Smithsonian Astrophysical Observation", "SAO 173520"},
    },
    visualMagnitude: 7.88,
    bvColour: -0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.20845404),
        dec: Angle.Degrees(-29.86328111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90475"},
        {"Hipparcos Number", "HIP 51089"},
        {"Smithsonian Astrophysical Observation", "SAO 178816"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.56986496),
        dec: Angle.Degrees(-29.86324092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15478",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15478"},
        {"Smithsonian Astrophysical Observation", "SAO 194232"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.89460854),
        dec: Angle.Degrees(-29.86323430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15059"},
        {"Hipparcos Number", "HIP 11248"},
        {"Smithsonian Astrophysical Observation", "SAO 193692"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.20342587),
        dec: Angle.Degrees(-29.86315090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44978"},
        {"Hipparcos Number", "HIP 30395"},
        {"Smithsonian Astrophysical Observation", "SAO 171677"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.87311649),
        dec: Angle.Degrees(-29.86077944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44775"},
        {"Hipparcos Number", "HIP 30291"},
        {"Geneva Identification System", "GEN# +1.00044775"},
        {"Smithsonian Astrophysical Observation", "SAO 171647"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.57781334),
        dec: Angle.Degrees(-29.85950699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113369"},
        {"Hipparcos Number", "HIP 63718"},
        {"Smithsonian Astrophysical Observation", "SAO 181350"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.86422382),
        dec: Angle.Degrees(-29.85886721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18466"},
        {"Hipparcos Number", "HIP 13768"},
        {"Geneva Identification System", "GEN# +1.00018466"},
        {"Renson", "Renson 4600"},
        {"Smithsonian Astrophysical Observation", "SAO 194002"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.30380182),
        dec: Angle.Degrees(-29.85527529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51980",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51980"},
    },
    visualMagnitude: 12.86,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.31503989),
        dec: Angle.Degrees(-29.85503857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217724"},
        {"Hipparcos Number", "HIP 113817"},
        {"Smithsonian Astrophysical Observation", "SAO 214266"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.72513477),
        dec: Angle.Degrees(-29.85265108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36965"},
        {"Hipparcos Number", "HIP 26091"},
        {"Geneva Identification System", "GEN# +1.00036965"},
        {"Smithsonian Astrophysical Observation", "SAO 170561"},
    },
    visualMagnitude: 6.52,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.46661049),
        dec: Angle.Degrees(-29.84923521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43946",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7108 B"},
        {"Hipparcos Number", "HIP 43946"},
        {"Smithsonian Astrophysical Observation", "SAO 176740"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)57, 03.6100),
        dec: Angle.DegreesMinutesSeconds((int)-29, (int)50, 54.200)
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
    primaryId: "HIP 73682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133113"},
        {"Hipparcos Number", "HIP 73682"},
        {"Geneva Identification System", "GEN# +1.00133113"},
        {"Smithsonian Astrophysical Observation", "SAO 183130"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.91371789),
        dec: Angle.Degrees(-29.84815708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219409"},
        {"Hipparcos Number", "HIP 114842"},
        {"Geneva Identification System", "GEN# +1.00219409"},
        {"Smithsonian Astrophysical Observation", "SAO 214410"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.93595591),
        dec: Angle.Degrees(-29.84749476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 145.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1923"},
        {"Hipparcos Number", "HIP 1849"},
        {"Geneva Identification System", "GEN# +1.00001923"},
        {"Smithsonian Astrophysical Observation", "SAO 192498"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.84219107),
        dec: Angle.Degrees(-29.84715760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43947",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7108 A"},
        {"Henry Draper", "HD 76740"},
        {"Hipparcos Number", "HIP 43947"},
        {"Smithsonian Astrophysical Observation", "SAO 176741"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.26686880),
        dec: Angle.Degrees(-29.84585169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95003",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95003"},
        {"Smithsonian Astrophysical Observation", "SAO 187975"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.97896437),
        dec: Angle.Degrees(-29.84574477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21298"},
        {"Hipparcos Number", "HIP 15930"},
        {"Geneva Identification System", "GEN# +1.00021298"},
        {"Smithsonian Astrophysical Observation", "SAO 194282"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.29823661),
        dec: Angle.Degrees(-29.84307994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18220"},
        {"Hipparcos Number", "HIP 13556"},
        {"Smithsonian Astrophysical Observation", "SAO 193974"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.65433354),
        dec: Angle.Degrees(-29.84277666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40723",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40723"},
        {"Geneva Identification System", "GEN# +2.25710111"},
        {"New General Catalogue", "NGC 2571 111"},
    },
    visualMagnitude: 11.47,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.68473416),
        dec: Angle.Degrees(-29.84244207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118600"},
        {"Hipparcos Number", "HIP 66539"},
        {"Geneva Identification System", "GEN# +1.00118600"},
        {"Smithsonian Astrophysical Observation", "SAO 181821"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.59730180),
        dec: Angle.Degrees(-29.83880609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134266"},
        {"Hipparcos Number", "HIP 74207"},
        {"Smithsonian Astrophysical Observation", "SAO 183228"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.46595777),
        dec: Angle.Degrees(-29.83717146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18064"},
        {"Hipparcos Number", "HIP 13454"},
        {"Geneva Identification System", "GEN# +1.00018064"},
        {"Smithsonian Astrophysical Observation", "SAO 193961"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.30950838),
        dec: Angle.Degrees(-29.83289453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179669"},
        {"Hipparcos Number", "HIP 94548"},
        {"Geneva Identification System", "GEN# +1.00179669"},
        {"Smithsonian Astrophysical Observation", "SAO 187862"},
        {"Wilson Evans Batten Catalogue", "WEB 16478"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.65169025),
        dec: Angle.Degrees(-29.83119759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149170"},
        {"Hipparcos Number", "HIP 81133"},
        {"Smithsonian Astrophysical Observation", "SAO 184464"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.53795420),
        dec: Angle.Degrees(-29.83084521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22593"},
        {"Hipparcos Number", "HIP 16876"},
        {"Smithsonian Astrophysical Observation", "SAO 168685"},
        {"Wilson Evans Batten Catalogue", "WEB 3209"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.28794919),
        dec: Angle.Degrees(-29.83006551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89931",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Kaus Media"},
        {"Aitken", "ADS 11264 A"},
        {"Henry Draper", "HD 168454"},
        {"Hipparcos Number", "HIP 89931"},
        {"Fundamental Katalog 5th Edition", "FK5 687"},
        {"Geneva Identification System", "GEN# +1.00168454"},
        {"Smithsonian Astrophysical Observation", "SAO 186681"},
        {"Wilson Evans Batten Catalogue", "WEB 15356"},
    },
    visualMagnitude: 2.72,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.24842337),
        dec: Angle.Degrees(-29.82803914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82313"},
        {"Hipparcos Number", "HIP 46619"},
        {"Smithsonian Astrophysical Observation", "SAO 177572"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.59678029),
        dec: Angle.Degrees(-29.82777709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144454"},
        {"Hipparcos Number", "HIP 78952"},
        {"Smithsonian Astrophysical Observation", "SAO 184126"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.75794739),
        dec: Angle.Degrees(-29.82752564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170278"},
        {"Hipparcos Number", "HIP 90648"},
        {"Geneva Identification System", "GEN# +1.00170278"},
        {"Smithsonian Astrophysical Observation", "SAO 186879"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.43763224),
        dec: Angle.Degrees(-29.82719321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11877"},
        {"Hipparcos Number", "HIP 9019"},
        {"Smithsonian Astrophysical Observation", "SAO 193390"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.03282794),
        dec: Angle.Degrees(-29.82423258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64595"},
        {"Hipparcos Number", "HIP 38535"},
        {"Geneva Identification System", "GEN# +1.00064595"},
        {"Smithsonian Astrophysical Observation", "SAO 174741"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.36793333),
        dec: Angle.Degrees(-29.82412481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60464"},
        {"Hipparcos Number", "HIP 36734"},
        {"Smithsonian Astrophysical Observation", "SAO 173997"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.33923695),
        dec: Angle.Degrees(-29.82360551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167121"},
        {"Hipparcos Number", "HIP 89429"},
        {"Smithsonian Astrophysical Observation", "SAO 186531"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.77128168),
        dec: Angle.Degrees(-29.82296064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117192",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117192"},
        {"Smithsonian Astrophysical Observation", "SAO 214758"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.43086259),
        dec: Angle.Degrees(-29.82112252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157336"},
        {"Hipparcos Number", "HIP 85132"},
        {"Geneva Identification System", "GEN# +1.00157336"},
        {"Smithsonian Astrophysical Observation", "SAO 185354"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.97496448),
        dec: Angle.Degrees(-29.82106611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3695"},
        {"Hipparcos Number", "HIP 3105"},
        {"Smithsonian Astrophysical Observation", "SAO 192659"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.88754157),
        dec: Angle.Degrees(-29.82017102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77547"},
        {"Hipparcos Number", "HIP 44374"},
        {"Smithsonian Astrophysical Observation", "SAO 176858"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.56547466),
        dec: Angle.Degrees(-29.81878092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42569"},
        {"Hipparcos Number", "HIP 29256"},
        {"Smithsonian Astrophysical Observation", "SAO 171325"},
    },
    visualMagnitude: 7.49,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.53145675),
        dec: Angle.Degrees(-29.81861116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213475"},
        {"Hipparcos Number", "HIP 111232"},
        {"Smithsonian Astrophysical Observation", "SAO 213890"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.03850024),
        dec: Angle.Degrees(-29.81795172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102339",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102339"},
        {"Geneva Identification System", "GEN# -0.03018142"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.03176721),
        dec: Angle.Degrees(-29.81716339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78878"},
        {"Hipparcos Number", "HIP 44960"},
        {"Smithsonian Astrophysical Observation", "SAO 177048"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.39339573),
        dec: Angle.Degrees(-29.81696135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169830"},
        {"Hipparcos Number", "HIP 90485"},
        {"Geneva Identification System", "GEN# +1.00169830"},
        {"Smithsonian Astrophysical Observation", "SAO 186838"},
    },
    visualMagnitude: 5.90,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.95618477),
        dec: Angle.Degrees(-29.81690216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125983"},
        {"Hipparcos Number", "HIP 70343"},
        {"Smithsonian Astrophysical Observation", "SAO 182491"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.87862465),
        dec: Angle.Degrees(-29.81573220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12585"},
        {"Hipparcos Number", "HIP 9550"},
        {"Geneva Identification System", "GEN# +1.00012585"},
        {"Smithsonian Astrophysical Observation", "SAO 193469"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.68084420),
        dec: Angle.Degrees(-29.81430011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32727"},
        {"Hipparcos Number", "HIP 23562"},
        {"Smithsonian Astrophysical Observation", "SAO 170034"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.99247945),
        dec: Angle.Degrees(-29.81345750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178673"},
        {"Hipparcos Number", "HIP 94202"},
        {"Geneva Identification System", "GEN# +1.00178673"},
        {"Smithsonian Astrophysical Observation", "SAO 187768"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.67454191),
        dec: Angle.Degrees(-29.81345143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162979"},
        {"Hipparcos Number", "HIP 87725"},
        {"Smithsonian Astrophysical Observation", "SAO 185930"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.78648014),
        dec: Angle.Degrees(-29.81142264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10685"},
        {"Hipparcos Number", "HIP 8084"},
        {"Geneva Identification System", "GEN# +1.00010685"},
        {"Smithsonian Astrophysical Observation", "SAO 193270"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.95568056),
        dec: Angle.Degrees(-29.81136334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97338",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97338"},
        {"Smithsonian Astrophysical Observation", "SAO 188556"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.74510016),
        dec: Angle.Degrees(-29.81131714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24861"},
        {"Hipparcos Number", "HIP 18398"},
        {"Smithsonian Astrophysical Observation", "SAO 168967"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.99810306),
        dec: Angle.Degrees(-29.81068349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223491"},
        {"Hipparcos Number", "HIP 117523"},
        {"Smithsonian Astrophysical Observation", "SAO 214801"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.51141934),
        dec: Angle.Degrees(-29.81027375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84834"},
        {"Hipparcos Number", "HIP 48011"},
        {"Smithsonian Astrophysical Observation", "SAO 177989"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.81390622),
        dec: Angle.Degrees(-29.80872805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8164"},
        {"Hipparcos Number", "HIP 6280"},
        {"Geneva Identification System", "GEN# +1.00008164"},
        {"Smithsonian Astrophysical Observation", "SAO 193063"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.13987896),
        dec: Angle.Degrees(-29.80821424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55447"},
        {"Hipparcos Number", "HIP 34757"},
        {"Geneva Identification System", "GEN# +1.00055447"},
        {"Smithsonian Astrophysical Observation", "SAO 173175"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.92268160),
        dec: Angle.Degrees(-29.80805813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69689",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9141 A"},
        {"Henry Draper", "HD 124720"},
        {"Hipparcos Number", "HIP 69689"},
        {"Smithsonian Astrophysical Observation", "SAO 182387"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.98104929),
        dec: Angle.Degrees(-29.80667274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221108"},
        {"Hipparcos Number", "HIP 115932"},
        {"Smithsonian Astrophysical Observation", "SAO 214575"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.32752924),
        dec: Angle.Degrees(-29.80663549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79643"},
        {"Hipparcos Number", "HIP 45347"},
        {"Smithsonian Astrophysical Observation", "SAO 177157"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.61275941),
        dec: Angle.Degrees(-29.80611299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20176"},
        {"Hipparcos Number", "HIP 15024"},
        {"Geneva Identification System", "GEN# +1.00020176"},
        {"Smithsonian Astrophysical Observation", "SAO 168397"},
    },
    visualMagnitude: 6.17,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.40806266),
        dec: Angle.Degrees(-29.80412191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84273"},
        {"Hipparcos Number", "HIP 47681"},
        {"Geneva Identification System", "GEN# +1.00084273"},
        {"Smithsonian Astrophysical Observation", "SAO 177891"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.83475575),
        dec: Angle.Degrees(-29.80409261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83414"},
        {"Hipparcos Number", "HIP 47226"},
        {"Smithsonian Astrophysical Observation", "SAO 177764"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.37058670),
        dec: Angle.Degrees(-29.80227445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146496"},
        {"Hipparcos Number", "HIP 79833"},
        {"Geneva Identification System", "GEN# +1.00146496"},
        {"Smithsonian Astrophysical Observation", "SAO 184292"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.43071792),
        dec: Angle.Degrees(-29.79867120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6390"},
        {"Hipparcos Number", "HIP 5036"},
        {"Smithsonian Astrophysical Observation", "SAO 192906"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.12466551),
        dec: Angle.Degrees(-29.79683067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111185"},
        {"Hipparcos Number", "HIP 62432"},
        {"Smithsonian Astrophysical Observation", "SAO 181103"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.92501486),
        dec: Angle.Degrees(-29.79504757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97022"},
        {"Hipparcos Number", "HIP 54570"},
        {"Smithsonian Astrophysical Observation", "SAO 179604"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.49489241),
        dec: Angle.Degrees(-29.79414445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189542"},
        {"Hipparcos Number", "HIP 98595"},
        {"Smithsonian Astrophysical Observation", "SAO 188830"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.39667489),
        dec: Angle.Degrees(-29.78862367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43636"},
        {"Hipparcos Number", "HIP 29756"},
        {"Geneva Identification System", "GEN# +1.00043636"},
        {"Smithsonian Astrophysical Observation", "SAO 171482"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.98819485),
        dec: Angle.Degrees(-29.78843376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217536"},
        {"Hipparcos Number", "HIP 113693"},
        {"Smithsonian Astrophysical Observation", "SAO 214254"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.39700271),
        dec: Angle.Degrees(-29.78727155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123951"},
        {"Hipparcos Number", "HIP 69326"},
        {"Smithsonian Astrophysical Observation", "SAO 182319"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.83064023),
        dec: Angle.Degrees(-29.78466359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97412"},
        {"Hipparcos Number", "HIP 54731"},
        {"Smithsonian Astrophysical Observation", "SAO 179635"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.07914409),
        dec: Angle.Degrees(-29.78249827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110858"},
        {"Hipparcos Number", "HIP 62236"},
        {"Smithsonian Astrophysical Observation", "SAO 181076"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.33459838),
        dec: Angle.Degrees(-29.78190281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147594"},
        {"Hipparcos Number", "HIP 80320"},
        {"Smithsonian Astrophysical Observation", "SAO 184357"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.97445669),
        dec: Angle.Degrees(-29.77774440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139365"},
        {"Hipparcos Number", "HIP 76600"},
        {"Geneva Identification System", "GEN# +1.00139365"},
        {"Smithsonian Astrophysical Observation", "SAO 183649"},
        {"Wilson Evans Batten Catalogue", "WEB 13002"},
    },
    visualMagnitude: 3.66,
    bvColour: -0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.66410153),
        dec: Angle.Degrees(-29.77768935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30952"},
        {"Hipparcos Number", "HIP 22515"},
        {"Smithsonian Astrophysical Observation", "SAO 169811"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.67561187),
        dec: Angle.Degrees(-29.77746926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40764",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40764"},
        {"Geneva Identification System", "GEN# +2.25710039"},
        {"Smithsonian Astrophysical Observation", "SAO 175594"},
        {"New General Catalogue", "NGC 2571 39"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.80992301),
        dec: Angle.Degrees(-29.76958750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64401"},
        {"Hipparcos Number", "HIP 38446"},
        {"Geneva Identification System", "GEN# +1.00064401"},
        {"Smithsonian Astrophysical Observation", "SAO 174713"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.14153076),
        dec: Angle.Degrees(-29.76640412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29085"},
        {"Hipparcos Number", "HIP 21248"},
        {"Geneva Identification System", "GEN# +1.00029085"},
        {"Smithsonian Astrophysical Observation", "SAO 169570"},
        {"Wilson Evans Batten Catalogue", "WEB 4082"},
    },
    visualMagnitude: 4.49,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.37762290),
        dec: Angle.Degrees(-29.76583186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -271.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52902",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52902"},
        {"Smithsonian Astrophysical Observation", "SAO 179253"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.29529704),
        dec: Angle.Degrees(-29.76456445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34394",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34394"},
    },
    visualMagnitude: 9.67,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.96953488),
        dec: Angle.Degrees(-29.76352296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48022"},
        {"Hipparcos Number", "HIP 31891"},
        {"Geneva Identification System", "GEN# +1.00048022"},
        {"Smithsonian Astrophysical Observation", "SAO 172121"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.99689011),
        dec: Angle.Degrees(-29.75927431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34325"},
        {"Hipparcos Number", "HIP 24496"},
        {"Smithsonian Astrophysical Observation", "SAO 170239"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.83614190),
        dec: Angle.Degrees(-29.75912836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41843"},
        {"Hipparcos Number", "HIP 28899"},
        {"Fundamental Katalog 5th Edition", "FK5 1164"},
        {"Geneva Identification System", "GEN# +1.00041843"},
        {"Smithsonian Astrophysical Observation", "SAO 171231"},
        {"Wilson Evans Batten Catalogue", "WEB 5657"},
    },
    visualMagnitude: 5.79,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.52304862),
        dec: Angle.Degrees(-29.75852227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75022"},
        {"Hipparcos Number", "HIP 43088"},
        {"Geneva Identification System", "GEN# +1.00075022"},
        {"Smithsonian Astrophysical Observation", "SAO 176457"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.64567430),
        dec: Angle.Degrees(-29.75834540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74521",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9536 AB"},
        {"Henry Draper", "HD 134969"},
        {"Hipparcos Number", "HIP 74521"},
        {"Smithsonian Astrophysical Observation", "SAO 183277"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.41572268),
        dec: Angle.Degrees(-29.75734665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316092"},
        {"Hipparcos Number", "HIP 86260"},
    },
    visualMagnitude: 11.42,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.39059353),
        dec: Angle.Degrees(-29.75700495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20887",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3253 AB"},
        {"Henry Draper", "HD 28508"},
        {"Hipparcos Number", "HIP 20887"},
        {"Smithsonian Astrophysical Observation", "SAO 169492"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.14594871),
        dec: Angle.Degrees(-29.75685711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27890"},
        {"Hipparcos Number", "HIP 20453"},
        {"Smithsonian Astrophysical Observation", "SAO 169388"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.72540446),
        dec: Angle.Degrees(-29.75509079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211583"},
        {"Hipparcos Number", "HIP 110156"},
        {"Geneva Identification System", "GEN# +1.00211583"},
        {"Smithsonian Astrophysical Observation", "SAO 213725"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.69200174),
        dec: Angle.Degrees(-29.75235243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 220.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58134"},
        {"Hipparcos Number", "HIP 35791"},
        {"Geneva Identification System", "GEN# +1.00058134"},
        {"Smithsonian Astrophysical Observation", "SAO 173596"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.74164513),
        dec: Angle.Degrees(-29.75078982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40730",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40730"},
        {"Geneva Identification System", "GEN# +2.25710024"},
        {"New General Catalogue", "NGC 2571 24"},
    },
    visualMagnitude: 10.85,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.69426027),
        dec: Angle.Degrees(-29.75032209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199929"},
        {"Hipparcos Number", "HIP 103726"},
        {"Smithsonian Astrophysical Observation", "SAO 189933"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.27689817),
        dec: Angle.Degrees(-29.75001131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88088"},
        {"Hipparcos Number", "HIP 49709"},
        {"Geneva Identification System", "GEN# +1.00088088"},
        {"Smithsonian Astrophysical Observation", "SAO 178467"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.22007259),
        dec: Angle.Degrees(-29.74964882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170748"},
        {"Hipparcos Number", "HIP 90881"},
        {"Smithsonian Astrophysical Observation", "SAO 186935"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.07772723),
        dec: Angle.Degrees(-29.74799182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101959"},
        {"Hipparcos Number", "HIP 57217"},
        {"Geneva Identification System", "GEN# +1.00101959"},
        {"Smithsonian Astrophysical Observation", "SAO 180141"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.98663331),
        dec: Angle.Degrees(-29.74779498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -275.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96802"},
        {"Hipparcos Number", "HIP 54468"},
        {"Smithsonian Astrophysical Observation", "SAO 179575"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.16601290),
        dec: Angle.Degrees(-29.74731001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65313"},
        {"Hipparcos Number", "HIP 38850"},
        {"Geneva Identification System", "GEN# +1.00065313"},
        {"Smithsonian Astrophysical Observation", "SAO 174861"},
    },
    visualMagnitude: 9.78,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.25245460),
        dec: Angle.Degrees(-29.74609826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121769"},
        {"Hipparcos Number", "HIP 68239"},
        {"Smithsonian Astrophysical Observation", "SAO 182128"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.54052884),
        dec: Angle.Degrees(-29.74418319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79775",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9983 A"},
        {"Henry Draper", "HD 146332"},
        {"Hipparcos Number", "HIP 79775"},
        {"Geneva Identification System", "GEN# +1.00146332J"},
        {"Smithsonian Astrophysical Observation", "SAO 184280"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.21897038),
        dec: Angle.Degrees(-29.74369894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49793"},
        {"Hipparcos Number", "HIP 32669"},
        {"Smithsonian Astrophysical Observation", "SAO 172368"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.21075832),
        dec: Angle.Degrees(-29.74367063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21125",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21125"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.91339532),
        dec: Angle.Degrees(-29.74351105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4220"},
        {"Hipparcos Number", "HIP 3480"},
        {"Geneva Identification System", "GEN# +1.00004220"},
        {"Smithsonian Astrophysical Observation", "SAO 192706"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.11095997),
        dec: Angle.Degrees(-29.74319086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182681"},
        {"Hipparcos Number", "HIP 95619"},
        {"Fundamental Katalog 5th Edition", "FK5 731"},
        {"Geneva Identification System", "GEN# +1.00182681"},
        {"Smithsonian Astrophysical Observation", "SAO 188127"},
        {"Wilson Evans Batten Catalogue", "WEB 16725"},
    },
    visualMagnitude: 5.66,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.73529268),
        dec: Angle.Degrees(-29.74310537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27167"},
        {"Hipparcos Number", "HIP 19910"},
        {"Smithsonian Astrophysical Observation", "SAO 169286"},
    },
    visualMagnitude: 9.87,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.06496645),
        dec: Angle.Degrees(-29.74051647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208662"},
        {"Hipparcos Number", "HIP 108474"},
        {"Smithsonian Astrophysical Observation", "SAO 190783"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.61920573),
        dec: Angle.Degrees(-29.73868894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82893"},
        {"Hipparcos Number", "HIP 46943"},
        {"Smithsonian Astrophysical Observation", "SAO 177667"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.50632789),
        dec: Angle.Degrees(-29.73848306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40748",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40748"},
        {"Geneva Identification System", "GEN# +2.25710012"},
        {"New General Catalogue", "NGC 2571 12"},
    },
    visualMagnitude: 10.40,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.76895337),
        dec: Angle.Degrees(-29.73809984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85785"},
        {"Hipparcos Number", "HIP 48508"},
        {"Smithsonian Astrophysical Observation", "SAO 178149"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.38953639),
        dec: Angle.Degrees(-29.73766014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77920",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77920"},
        {"Smithsonian Astrophysical Observation", "SAO 183915"},
    },
    visualMagnitude: 9.90,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.69727082),
        dec: Angle.Degrees(-29.73493643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64620"},
        {"Hipparcos Number", "HIP 38543"},
        {"Geneva Identification System", "GEN# +1.00064620"},
        {"Smithsonian Astrophysical Observation", "SAO 174747"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.38871774),
        dec: Angle.Degrees(-29.73431176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156039"},
        {"Hipparcos Number", "HIP 84501"},
        {"Geneva Identification System", "GEN# +1.00156039"},
        {"Smithsonian Astrophysical Observation", "SAO 185217"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.13590372),
        dec: Angle.Degrees(-29.73091862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118986"},
        {"Hipparcos Number", "HIP 66761"},
        {"Geneva Identification System", "GEN# +1.00118986"},
        {"Smithsonian Astrophysical Observation", "SAO 181854"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.25727597),
        dec: Angle.Degrees(-29.73082525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56730"},
        {"Hipparcos Number", "HIP 35245"},
        {"Smithsonian Astrophysical Observation", "SAO 173376"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.24674699),
        dec: Angle.Degrees(-29.72988325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199917"},
        {"Hipparcos Number", "HIP 103720"},
        {"Geneva Identification System", "GEN# +1.00199917"},
        {"Smithsonian Astrophysical Observation", "SAO 189930"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.26368155),
        dec: Angle.Degrees(-29.72856077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50289",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50289"},
        {"Geneva Identification System", "GEN# -0.02908222"},
        {"Wilson Evans Batten Catalogue", "WEB 9236"},
    },
    visualMagnitude: 10.95,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.02050971),
        dec: Angle.Degrees(-29.72832742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75021"},
        {"Hipparcos Number", "HIP 43093"},
        {"Geneva Identification System", "GEN# +1.00075021"},
        {"Smithsonian Astrophysical Observation", "SAO 176458"},
        {"Wilson Evans Batten Catalogue", "WEB 8316"},
    },
    visualMagnitude: 7.29,
    bvColour: 2.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.65140107),
        dec: Angle.Degrees(-29.72811587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124091"},
        {"Hipparcos Number", "HIP 69377"},
        {"Smithsonian Astrophysical Observation", "SAO 182340"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.03856538),
        dec: Angle.Degrees(-29.72807513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25105",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3970 B"},
        {"Hipparcos Number", "HIP 25105"},
    },
    visualMagnitude: 10.93,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)22, 31.6200),
        dec: Angle.DegreesMinutesSeconds((int)-29, (int)43, 35.600)
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
    primaryId: "HIP 7174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9475"},
        {"Hipparcos Number", "HIP 7174"},
        {"Geneva Identification System", "GEN# +1.00009475"},
        {"Smithsonian Astrophysical Observation", "SAO 167123"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.12306218),
        dec: Angle.Degrees(-29.72649191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157955"},
        {"Hipparcos Number", "HIP 85442"},
        {"Celescope Catalog", "CEL 4519"},
        {"Geneva Identification System", "GEN# +1.00157955"},
        {"Smithsonian Astrophysical Observation", "SAO 185417"},
        {"Wilson Evans Batten Catalogue", "WEB 14431"},
    },
    visualMagnitude: 5.98,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.90648805),
        dec: Angle.Degrees(-29.72448960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11021"},
        {"Hipparcos Number", "HIP 8352"},
        {"Geneva Identification System", "GEN# +1.00011021"},
        {"Smithsonian Astrophysical Observation", "SAO 167301"},
        {"Wilson Evans Batten Catalogue", "WEB 1777"},
    },
    visualMagnitude: 8.84,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.91889115),
        dec: Angle.Degrees(-29.72301072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25104",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3970 A"},
        {"Hipparcos Number", "HIP 25104"},
        {"Smithsonian Astrophysical Observation", "SAO 170363"},
    },
    visualMagnitude: 9.99,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.63192883),
        dec: Angle.Degrees(-29.72140899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25101",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25101"},
    },
    visualMagnitude: 11.55,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.60650381),
        dec: Angle.Degrees(-29.72109803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80597",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80597"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.83502937),
        dec: Angle.Degrees(+00.92485206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201390"},
        {"Hipparcos Number", "HIP 104499"},
        {"Smithsonian Astrophysical Observation", "SAO 190079"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.52474153),
        dec: Angle.Degrees(-29.72104625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190727"},
        {"Hipparcos Number", "HIP 99121"},
        {"Smithsonian Astrophysical Observation", "SAO 188927"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.84922482),
        dec: Angle.Degrees(-29.72088380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37961"},
        {"Hipparcos Number", "HIP 26738"},
        {"Geneva Identification System", "GEN# +1.00037961"},
        {"Smithsonian Astrophysical Observation", "SAO 170689"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.21847505),
        dec: Angle.Degrees(-29.72074170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224990"},
        {"Hipparcos Number", "HIP 183"},
        {"Fundamental Katalog 5th Edition", "FK5 3932"},
        {"Wilson Evans Batten Catalogue", "WEB 31"},
    },
    visualMagnitude: 5.04,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.58297574),
        dec: Angle.Degrees(-29.72044805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154167"},
        {"Hipparcos Number", "HIP 83592"},
        {"Smithsonian Astrophysical Observation", "SAO 185002"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.26721813),
        dec: Angle.Degrees(-29.72028217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80523"},
        {"Hipparcos Number", "HIP 45736"},
        {"Smithsonian Astrophysical Observation", "SAO 177277"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.86072306),
        dec: Angle.Degrees(-29.72010014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211806"},
        {"Hipparcos Number", "HIP 110284"},
        {"Smithsonian Astrophysical Observation", "SAO 191066"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.08488777),
        dec: Angle.Degrees(-29.72002174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15393"},
        {"Hipparcos Number", "HIP 11463"},
        {"Smithsonian Astrophysical Observation", "SAO 167803"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.96235302),
        dec: Angle.Degrees(-29.71592311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29984"},
        {"Hipparcos Number", "HIP 21891"},
        {"Smithsonian Astrophysical Observation", "SAO 169682"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.58523743),
        dec: Angle.Degrees(-29.71206033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -192.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37705"},
        {"Hipparcos Number", "HIP 26600"},
        {"Geneva Identification System", "GEN# +1.00037705"},
        {"Smithsonian Astrophysical Observation", "SAO 170646"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.81253141),
        dec: Angle.Degrees(-29.70999837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8613",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8613"},
        {"Smithsonian Astrophysical Observation", "SAO 167350"},
    },
    visualMagnitude: 10.07,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.77873921),
        dec: Angle.Degrees(-29.70817741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85962"},
        {"Hipparcos Number", "HIP 48610"},
        {"Smithsonian Astrophysical Observation", "SAO 178170"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.70026564),
        dec: Angle.Degrees(-29.70767474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52395"},
        {"Hipparcos Number", "HIP 33671"},
        {"Geneva Identification System", "GEN# +1.00052395"},
        {"Smithsonian Astrophysical Observation", "SAO 172707"},
        {"Wilson Evans Batten Catalogue", "WEB 6766"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.93081754),
        dec: Angle.Degrees(-29.70751071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208272"},
        {"Hipparcos Number", "HIP 108241"},
        {"Geneva Identification System", "GEN# +1.00208272"},
        {"Smithsonian Astrophysical Observation", "SAO 190739"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.842,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.92481722),
        dec: Angle.Degrees(-29.70570198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80399",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10035 AB"},
        {"Aitken 2", "ADS 10035"},
        {"Hipparcos Number", "HIP 80399"},
    },
    visualMagnitude: 5.40,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.16552568),
        dec: Angle.Degrees(-29.70446361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45382"},
        {"Hipparcos Number", "HIP 30583"},
        {"Celescope Catalog", "CEL 1234"},
        {"Fundamental Katalog 5th Edition", "FK5 4583"},
        {"Geneva Identification System", "GEN# +1.00045382"},
        {"Smithsonian Astrophysical Observation", "SAO 171731"},
    },
    visualMagnitude: 6.89,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.41866049),
        dec: Angle.Degrees(-29.70297256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219246"},
        {"Hipparcos Number", "HIP 114746"},
        {"Smithsonian Astrophysical Observation", "SAO 191747"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.65991526),
        dec: Angle.Degrees(-29.70242445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171416"},
        {"Hipparcos Number", "HIP 91172"},
        {"Fundamental Katalog 5th Edition", "FK5 3478"},
        {"Geneva Identification System", "GEN# +1.00171416"},
        {"Smithsonian Astrophysical Observation", "SAO 187024"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.99850622),
        dec: Angle.Degrees(-29.69907952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109735"},
        {"Hipparcos Number", "HIP 61582"},
        {"Smithsonian Astrophysical Observation", "SAO 180957"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.29163229),
        dec: Angle.Degrees(-29.69857255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205265"},
        {"Hipparcos Number", "HIP 106564"},
        {"Fundamental Katalog 5th Edition", "FK5 3721"},
        {"Geneva Identification System", "GEN# +1.00205265"},
        {"Smithsonian Astrophysical Observation", "SAO 190458"},
    },
    visualMagnitude: 6.42,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.72080115),
        dec: Angle.Degrees(-29.69608094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212273"},
        {"Hipparcos Number", "HIP 110535"},
        {"Fundamental Katalog 5th Edition", "FK5 5975"},
        {"Smithsonian Astrophysical Observation", "SAO 191104"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.88587390),
        dec: Angle.Degrees(-29.69422365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7310"},
        {"Hipparcos Number", "HIP 5678"},
        {"Geneva Identification System", "GEN# +1.00007310"},
        {"Smithsonian Astrophysical Observation", "SAO 166879"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.24092283),
        dec: Angle.Degrees(-29.69398631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63373"},
        {"Hipparcos Number", "HIP 38015"},
        {"Geneva Identification System", "GEN# +1.00063373"},
        {"Smithsonian Astrophysical Observation", "SAO 174542"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.87020238),
        dec: Angle.Degrees(-29.69328388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72054",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72054"},
        {"Smithsonian Astrophysical Observation", "SAO 182819"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.07067363),
        dec: Angle.Degrees(-29.69291554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72974",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72974"},
        {"Smithsonian Astrophysical Observation", "SAO 182989"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.69857137),
        dec: Angle.Degrees(-29.69273623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70725"},
        {"Hipparcos Number", "HIP 41042"},
        {"Renson", "Renson 19510"},
        {"Smithsonian Astrophysical Observation", "SAO 175704"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.63736972),
        dec: Angle.Degrees(-29.69238804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54059",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54059"},
        {"Geneva Identification System", "GEN# -0.02908822"},
        {"Smithsonian Astrophysical Observation", "SAO 179488"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.92747603),
        dec: Angle.Degrees(-29.69174848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175389"},
        {"Hipparcos Number", "HIP 92966"},
        {"Geneva Identification System", "GEN# +1.00175389"},
        {"Smithsonian Astrophysical Observation", "SAO 187472"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.09658515),
        dec: Angle.Degrees(-29.69171087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195171"},
        {"Hipparcos Number", "HIP 101196"},
        {"Smithsonian Astrophysical Observation", "SAO 189368"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.68625283),
        dec: Angle.Degrees(-29.69079961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4954"},
        {"Hipparcos Number", "HIP 3987"},
        {"Smithsonian Astrophysical Observation", "SAO 166627"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.81735582),
        dec: Angle.Degrees(-29.68976644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1674"},
        {"Hipparcos Number", "HIP 1668"},
        {"Geneva Identification System", "GEN# +1.00001674"},
        {"Smithsonian Astrophysical Observation", "SAO 166204"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.22523196),
        dec: Angle.Degrees(-29.68962325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141664"},
        {"Hipparcos Number", "HIP 77664"},
        {"Smithsonian Astrophysical Observation", "SAO 183862"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.82980596),
        dec: Angle.Degrees(-29.68551446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83280",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10304 A"},
        {"Henry Draper", "HD 153515"},
        {"Hipparcos Number", "HIP 83280"},
        {"Geneva Identification System", "GEN# +1.00153515"},
        {"Smithsonian Astrophysical Observation", "SAO 184918"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.30249604),
        dec: Angle.Degrees(-29.68434487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93171"},
        {"Hipparcos Number", "HIP 52576"},
        {"Fundamental Katalog 5th Edition", "FK5 4955"},
        {"Smithsonian Astrophysical Observation", "SAO 179193"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.26667387),
        dec: Angle.Degrees(-29.68349744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103193",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103193"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.60028179),
        dec: Angle.Degrees(-29.68178119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 184.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101923"},
        {"Hipparcos Number", "HIP 57200"},
        {"Smithsonian Astrophysical Observation", "SAO 180139"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.94670872),
        dec: Angle.Degrees(-29.67941847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316013"},
        {"Hipparcos Number", "HIP 86138"},
    },
    visualMagnitude: 11.14,
    bvColour: 1.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.04782219),
        dec: Angle.Degrees(-29.67925459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -175.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149790"},
        {"Hipparcos Number", "HIP 81455"},
        {"Geneva Identification System", "GEN# +1.00149790"},
        {"Smithsonian Astrophysical Observation", "SAO 184502"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.54506495),
        dec: Angle.Degrees(-29.67784052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5425"},
        {"Hipparcos Number", "HIP 4353"},
        {"Geneva Identification System", "GEN# +1.00005425"},
        {"Smithsonian Astrophysical Observation", "SAO 166685"},
        {"Wilson Evans Batten Catalogue", "WEB 779"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.95413097),
        dec: Angle.Degrees(-29.67637996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 394.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 174.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126057"},
        {"Hipparcos Number", "HIP 70375"},
        {"Smithsonian Astrophysical Observation", "SAO 182498"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.98215343),
        dec: Angle.Degrees(-29.67627800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214749"},
        {"Hipparcos Number", "HIP 111960"},
        {"Geneva Identification System", "GEN# +1.00214749"},
        {"Smithsonian Astrophysical Observation", "SAO 191319"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.17970196),
        dec: Angle.Degrees(-29.67443776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 380.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10290"},
        {"Hipparcos Number", "HIP 7770"},
        {"Smithsonian Astrophysical Observation", "SAO 167210"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.00044733),
        dec: Angle.Degrees(-29.67384624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206320"},
        {"Hipparcos Number", "HIP 107130"},
        {"Smithsonian Astrophysical Observation", "SAO 190557"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.50941111),
        dec: Angle.Degrees(-29.67209571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195755"},
        {"Hipparcos Number", "HIP 101503"},
        {"Smithsonian Astrophysical Observation", "SAO 189440"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.53845385),
        dec: Angle.Degrees(-29.67182666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153484"},
        {"Hipparcos Number", "HIP 83258"},
        {"Smithsonian Astrophysical Observation", "SAO 184912"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.25596397),
        dec: Angle.Degrees(-29.67170155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14753",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14753"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.62481665),
        dec: Angle.Degrees(+00.92509791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14377"},
        {"Hipparcos Number", "HIP 10765"},
        {"Smithsonian Astrophysical Observation", "SAO 167693"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.64037404),
        dec: Angle.Degrees(-29.67107026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127794"},
        {"Hipparcos Number", "HIP 71231"},
        {"Smithsonian Astrophysical Observation", "SAO 182664"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.50197299),
        dec: Angle.Degrees(-29.67103692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44524"},
        {"Hipparcos Number", "HIP 30174"},
        {"Geneva Identification System", "GEN# +1.00044524"},
        {"Smithsonian Astrophysical Observation", "SAO 171609"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.23492722),
        dec: Angle.Degrees(-29.67067855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157611"},
        {"Hipparcos Number", "HIP 85278"},
        {"Smithsonian Astrophysical Observation", "SAO 185381"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.37351856),
        dec: Angle.Degrees(-29.67062307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89211"},
        {"Hipparcos Number", "HIP 50367"},
        {"Geneva Identification System", "GEN# +1.00089211"},
        {"Smithsonian Astrophysical Observation", "SAO 178618"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.25515561),
        dec: Angle.Degrees(-29.66987304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88339",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88339"},
    },
    visualMagnitude: 10.69,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.61259972),
        dec: Angle.Degrees(-29.66728209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12563"},
        {"Hipparcos Number", "HIP 9521"},
        {"Geneva Identification System", "GEN# +1.00012563"},
        {"Renson", "Renson 3210"},
        {"Smithsonian Astrophysical Observation", "SAO 167511"},
        {"Wilson Evans Batten Catalogue", "WEB 1998"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.61781113),
        dec: Angle.Degrees(-29.66566527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213655"},
        {"Hipparcos Number", "HIP 111350"},
        {"Geneva Identification System", "GEN# +1.00213655"},
        {"Smithsonian Astrophysical Observation", "SAO 191223"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.38967910),
        dec: Angle.Degrees(-29.66492098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79456"},
        {"Hipparcos Number", "HIP 45249"},
        {"Smithsonian Astrophysical Observation", "SAO 177127"},
    },
    visualMagnitude: 6.38,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.33972458),
        dec: Angle.Degrees(-29.66442214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90957"},
        {"Hipparcos Number", "HIP 51364"},
        {"Geneva Identification System", "GEN# +1.00090957"},
        {"Smithsonian Astrophysical Observation", "SAO 178888"},
        {"Wilson Evans Batten Catalogue", "WEB 9379"},
    },
    visualMagnitude: 5.58,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.37088906),
        dec: Angle.Degrees(-29.66385399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113354"},
        {"Hipparcos Number", "HIP 63708"},
        {"Geneva Identification System", "GEN# +1.00113354"},
        {"Smithsonian Astrophysical Observation", "SAO 181349"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.84293487),
        dec: Angle.Degrees(-29.66346853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201989"},
        {"Hipparcos Number", "HIP 104809"},
        {"Geneva Identification System", "GEN# +1.00201989"},
        {"Smithsonian Astrophysical Observation", "SAO 190143"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.50685518),
        dec: Angle.Degrees(-29.66343267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 231.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120250"},
        {"Hipparcos Number", "HIP 67406"},
        {"Geneva Identification System", "GEN# +1.00120250"},
        {"Smithsonian Astrophysical Observation", "SAO 181978"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.22135310),
        dec: Angle.Degrees(-29.66113977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24875"},
        {"Hipparcos Number", "HIP 18411"},
        {"Smithsonian Astrophysical Observation", "SAO 168973"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.04622262),
        dec: Angle.Degrees(-29.66041721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138444"},
        {"Hipparcos Number", "HIP 76139"},
        {"Smithsonian Astrophysical Observation", "SAO 183562"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.839,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.28132150),
        dec: Angle.Degrees(-29.65977423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91668",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91668"},
        {"Cincinnati Publication", "Ci 20 1102"},
        {"Geneva Identification System", "GEN# +9.80021023"},
    },
    visualMagnitude: 12.23,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.40138788),
        dec: Angle.Degrees(+00.92532938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1980.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36596"},
        {"Hipparcos Number", "HIP 25884"},
        {"Geneva Identification System", "GEN# +1.00036596"},
        {"Smithsonian Astrophysical Observation", "SAO 170515"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.88940062),
        dec: Angle.Degrees(-29.65642165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110089"},
        {"Hipparcos Number", "HIP 61784"},
        {"Smithsonian Astrophysical Observation", "SAO 180995"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.95002922),
        dec: Angle.Degrees(-29.65636642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183432"},
        {"Hipparcos Number", "HIP 95941"},
        {"Smithsonian Astrophysical Observation", "SAO 188210"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.66912942),
        dec: Angle.Degrees(-29.65319092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94181"},
        {"Hipparcos Number", "HIP 53099"},
        {"Geneva Identification System", "GEN# +1.00094181"},
        {"Smithsonian Astrophysical Observation", "SAO 179284"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.94309556),
        dec: Angle.Degrees(-29.65235280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1957",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1957"},
        {"Smithsonian Astrophysical Observation", "SAO 166249"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.19025687),
        dec: Angle.Degrees(-29.65201440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13939"},
        {"Hipparcos Number", "HIP 10469"},
        {"Smithsonian Astrophysical Observation", "SAO 167655"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.74227090),
        dec: Angle.Degrees(-29.65198775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17545",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17545"},
        {"Smithsonian Astrophysical Observation", "SAO 168808"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.35347260),
        dec: Angle.Degrees(-29.65183306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158902"},
        {"Hipparcos Number", "HIP 85881"},
        {"Geneva Identification System", "GEN# +1.00158902"},
        {"Smithsonian Astrophysical Observation", "SAO 185490"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.26433951),
        dec: Angle.Degrees(-29.65083754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64479",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64479"},
        {"Geneva Identification System", "GEN# -0.02809945"},
        {"Smithsonian Astrophysical Observation", "SAO 181459"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.23427192),
        dec: Angle.Degrees(-29.65021603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145657"},
        {"Hipparcos Number", "HIP 79473"},
        {"Geneva Identification System", "GEN# +1.00145657"},
        {"Smithsonian Astrophysical Observation", "SAO 184231"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.28965690),
        dec: Angle.Degrees(-29.64723574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90156"},
        {"Hipparcos Number", "HIP 50921"},
        {"Geneva Identification System", "GEN# +1.00090156"},
        {"Smithsonian Astrophysical Observation", "SAO 178771"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.98041827),
        dec: Angle.Degrees(-29.64577142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 99.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148806"},
        {"Hipparcos Number", "HIP 80951"},
        {"Smithsonian Astrophysical Observation", "SAO 184439"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.94066455),
        dec: Angle.Degrees(-29.64510852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44009"},
        {"Hipparcos Number", "HIP 29923"},
        {"Smithsonian Astrophysical Observation", "SAO 171529"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.49621107),
        dec: Angle.Degrees(-29.64316092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26047",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26047"},
        {"Smithsonian Astrophysical Observation", "SAO 170550"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.35199577),
        dec: Angle.Degrees(-29.64261284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220414"},
        {"Hipparcos Number", "HIP 115499"},
        {"Smithsonian Astrophysical Observation", "SAO 191870"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.94600240),
        dec: Angle.Degrees(-29.64124413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205789"},
        {"Hipparcos Number", "HIP 106840"},
        {"Renson", "Renson 57310"},
        {"Smithsonian Astrophysical Observation", "SAO 190511"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.60083770),
        dec: Angle.Degrees(-29.64053833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 695"},
        {"Hipparcos Number", "HIP 912"},
        {"Smithsonian Astrophysical Observation", "SAO 166099"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.82287739),
        dec: Angle.Degrees(-29.64051891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219104"},
        {"Hipparcos Number", "HIP 114656"},
        {"Geneva Identification System", "GEN# +1.00219104"},
        {"Smithsonian Astrophysical Observation", "SAO 191736"},
    },
    visualMagnitude: 8.55,
    bvColour: -0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.39901715),
        dec: Angle.Degrees(-29.63961792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166309"},
        {"Hipparcos Number", "HIP 89116"},
        {"Smithsonian Astrophysical Observation", "SAO 186422"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.81599713),
        dec: Angle.Degrees(-29.63955828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101758"},
        {"Hipparcos Number", "HIP 57118"},
        {"Smithsonian Astrophysical Observation", "SAO 180127"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.64742760),
        dec: Angle.Degrees(-29.63937876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29250"},
        {"Hipparcos Number", "HIP 21374"},
        {"Smithsonian Astrophysical Observation", "SAO 169590"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.80369947),
        dec: Angle.Degrees(-29.63636942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81964",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10177 AB"},
        {"Henry Draper", "HD 150817"},
        {"Hipparcos Number", "HIP 81964"},
        {"Smithsonian Astrophysical Observation", "SAO 184595"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.15385742),
        dec: Angle.Degrees(-29.63568332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48743"},
        {"Hipparcos Number", "HIP 32213"},
        {"Geneva Identification System", "GEN# +1.00048743"},
        {"Smithsonian Astrophysical Observation", "SAO 172235"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.87790545),
        dec: Angle.Degrees(-29.63541763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60197"},
        {"Hipparcos Number", "HIP 36643"},
        {"Geneva Identification System", "GEN# +1.00060197"},
        {"Smithsonian Astrophysical Observation", "SAO 173956"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.03316194),
        dec: Angle.Degrees(-29.63515371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99350",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13427 A"},
        {"Henry Draper", "HD 191235"},
        {"Hipparcos Number", "HIP 99350"},
        {"Geneva Identification System", "GEN# +1.00191235"},
        {"Smithsonian Astrophysical Observation", "SAO 188968"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.47331432),
        dec: Angle.Degrees(-29.63308152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 181.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225264"},
        {"Hipparcos Number", "HIP 389"},
        {"Geneva Identification System", "GEN# +4.09010086"},
        {"Renson", "Renson 61780"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.21171086),
        dec: Angle.Degrees(-29.63304603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143114"},
        {"Hipparcos Number", "HIP 78330"},
        {"Geneva Identification System", "GEN# +1.00143114"},
        {"Smithsonian Astrophysical Observation", "SAO 183999"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.90967327),
        dec: Angle.Degrees(-29.63245782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29964"},
        {"Hipparcos Number", "HIP 21860"},
        {"Smithsonian Astrophysical Observation", "SAO 169679"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.51373682),
        dec: Angle.Degrees(-29.63220975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37794"},
        {"Hipparcos Number", "HIP 26645"},
        {"Geneva Identification System", "GEN# +1.00037794"},
        {"Smithsonian Astrophysical Observation", "SAO 170660"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.94635077),
        dec: Angle.Degrees(-29.63211700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64361"},
        {"Hipparcos Number", "HIP 38429"},
        {"Geneva Identification System", "GEN# +1.00064361"},
        {"Smithsonian Astrophysical Observation", "SAO 174704"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.08410993),
        dec: Angle.Degrees(-29.63211312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173484"},
        {"Hipparcos Number", "HIP 92142"},
        {"Smithsonian Astrophysical Observation", "SAO 187263"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.69694829),
        dec: Angle.Degrees(-29.63155862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46813"},
        {"Hipparcos Number", "HIP 31325"},
        {"Renson", "Renson 12560"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.53379288),
        dec: Angle.Degrees(-29.62951899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132664"},
        {"Hipparcos Number", "HIP 73489"},
        {"Smithsonian Astrophysical Observation", "SAO 183084"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.28828747),
        dec: Angle.Degrees(-29.62927711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96930",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96930"},
        {"Smithsonian Astrophysical Observation", "SAO 188465"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.55257874),
        dec: Angle.Degrees(-29.62696351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130345"},
        {"Hipparcos Number", "HIP 72416"},
        {"Geneva Identification System", "GEN# +1.00130345"},
        {"Smithsonian Astrophysical Observation", "SAO 182886"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.10527764),
        dec: Angle.Degrees(-29.62515418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77026"},
        {"Hipparcos Number", "HIP 44095"},
        {"Smithsonian Astrophysical Observation", "SAO 176782"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.72265702),
        dec: Angle.Degrees(-29.62493851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59299"},
        {"Hipparcos Number", "HIP 36282"},
        {"Smithsonian Astrophysical Observation", "SAO 173807"},
    },
    visualMagnitude: 8.53,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.03762055),
        dec: Angle.Degrees(-29.62435012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222593"},
        {"Hipparcos Number", "HIP 116925"},
        {"Smithsonian Astrophysical Observation", "SAO 192096"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.50786300),
        dec: Angle.Degrees(-29.62416233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193084"},
        {"Hipparcos Number", "HIP 100196"},
        {"Smithsonian Astrophysical Observation", "SAO 189139"},
    },
    visualMagnitude: 7.61,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.84806644),
        dec: Angle.Degrees(-29.62391896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59825",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8488 AB"},
        {"Henry Draper", "HD 106664"},
        {"Hipparcos Number", "HIP 59825"},
        {"Renson", "Renson 30880"},
        {"Smithsonian Astrophysical Observation", "SAO 180628"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.01246476),
        dec: Angle.Degrees(-29.62311717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84445"},
        {"Hipparcos Number", "HIP 47797"},
        {"Smithsonian Astrophysical Observation", "SAO 177921"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.16227588),
        dec: Angle.Degrees(-29.62272972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6868"},
        {"Hipparcos Number", "HIP 5383"},
        {"Geneva Identification System", "GEN# +1.00006868J"},
        {"Smithsonian Astrophysical Observation", "SAO 166834"},
        {"Wilson Evans Batten Catalogue", "WEB 1172"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.21576657),
        dec: Angle.Degrees(-29.62242151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13517",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13517"},
        {"Smithsonian Astrophysical Observation", "SAO 168130"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.52110274),
        dec: Angle.Degrees(-29.62193556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113368",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Fomalhaut"},
        {"Henry Draper", "HD 216956"},
        {"Hipparcos Number", "HIP 113368"},
        {"Celescope Catalog", "CEL 5549"},
        {"Fundamental Katalog 5th Edition", "FK5 867"},
        {"Geneva Identification System", "GEN# +1.00216956"},
        {"Smithsonian Astrophysical Observation", "SAO 191524"},
        {"Wilson Evans Batten Catalogue", "WEB 20167"},
    },
    visualMagnitude: 1.17,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.41177323),
        dec: Angle.Degrees(-29.62183701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 329.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -164.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168169"},
        {"Hipparcos Number", "HIP 89811"},
        {"Smithsonian Astrophysical Observation", "SAO 186651"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.92539380),
        dec: Angle.Degrees(-29.61989634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155462"},
        {"Hipparcos Number", "HIP 84222"},
        {"Geneva Identification System", "GEN# +1.00155462"},
        {"Smithsonian Astrophysical Observation", "SAO 185152"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.23388360),
        dec: Angle.Degrees(-29.61986467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14850"},
        {"Hipparcos Number", "HIP 11116"},
        {"Geneva Identification System", "GEN# +1.00014850"},
        {"Smithsonian Astrophysical Observation", "SAO 167739"},
        {"Wilson Evans Batten Catalogue", "WEB 2340"},
    },
    visualMagnitude: 8.43,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.75218538),
        dec: Angle.Degrees(-29.61945733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212146"},
        {"Hipparcos Number", "HIP 110483"},
        {"Cincinnati Publication", "Ci 20 1358"},
        {"Geneva Identification System", "GEN# +1.00212146"},
        {"Smithsonian Astrophysical Observation", "SAO 191095"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.69578815),
        dec: Angle.Degrees(-29.61919948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 440.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316239"},
        {"Hipparcos Number", "HIP 86761"},
        {"Geneva Identification System", "GEN# +1.00316239"},
        {"Smithsonian Astrophysical Observation", "SAO 185662"},
    },
    visualMagnitude: 10.26,
    bvColour: 1.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.92710558),
        dec: Angle.Degrees(-29.61865090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184710"},
        {"Hipparcos Number", "HIP 96486"},
        {"Smithsonian Astrophysical Observation", "SAO 188340"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.22359039),
        dec: Angle.Degrees(-29.61786835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6670"},
        {"Hipparcos Number", "HIP 5241"},
        {"Fundamental Katalog 5th Edition", "FK5 4102"},
        {"Geneva Identification System", "GEN# +1.00006670"},
        {"Smithsonian Astrophysical Observation", "SAO 166811"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.75436248),
        dec: Angle.Degrees(-29.61514365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110157"},
        {"Hipparcos Number", "HIP 61836"},
        {"Smithsonian Astrophysical Observation", "SAO 181006"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.08021578),
        dec: Angle.Degrees(-29.61510130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209837"},
        {"Hipparcos Number", "HIP 109172"},
        {"Geneva Identification System", "GEN# +1.00209837"},
        {"Smithsonian Astrophysical Observation", "SAO 190894"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.72245072),
        dec: Angle.Degrees(-29.61426105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 101.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176888"},
        {"Hipparcos Number", "HIP 93583"},
        {"Smithsonian Astrophysical Observation", "SAO 187614"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.88965961),
        dec: Angle.Degrees(-29.61399574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88447",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88447"},
    },
    visualMagnitude: 10.30,
    bvColour: 1.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.86490884),
        dec: Angle.Degrees(-29.61279526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14933",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14933"},
        {"Smithsonian Astrophysical Observation", "SAO 168382"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.14349261),
        dec: Angle.Degrees(-29.61182979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14700"},
        {"Hipparcos Number", "HIP 10988"},
        {"Smithsonian Astrophysical Observation", "SAO 167728"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.40453563),
        dec: Angle.Degrees(-29.61016874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198671"},
        {"Hipparcos Number", "HIP 103060"},
    },
    visualMagnitude: 10.16,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.21450644),
        dec: Angle.Degrees(-29.60928876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49392"},
        {"Hipparcos Number", "HIP 32497"},
        {"Smithsonian Astrophysical Observation", "SAO 172322"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.72905924),
        dec: Angle.Degrees(-29.60756991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181428"},
        {"Hipparcos Number", "HIP 95164"},
        {"Geneva Identification System", "GEN# +1.00181428"},
        {"Smithsonian Astrophysical Observation", "SAO 188014"},
        {"Wilson Evans Batten Catalogue", "WEB 16619"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.41368758),
        dec: Angle.Degrees(-29.60544093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29619",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4858 A"},
        {"Henry Draper", "HD 43369"},
        {"Hipparcos Number", "HIP 29619"},
        {"Smithsonian Astrophysical Observation", "SAO 171448"},
    },
    visualMagnitude: 6.98,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.62627178),
        dec: Angle.Degrees(-29.60429193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186649"},
        {"Hipparcos Number", "HIP 97325"},
        {"Smithsonian Astrophysical Observation", "SAO 188553"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.68335558),
        dec: Angle.Degrees(-29.60195674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8145"},
        {"Hipparcos Number", "HIP 6269"},
        {"Geneva Identification System", "GEN# +1.00008145"},
        {"Smithsonian Astrophysical Observation", "SAO 166972"},
        {"Wilson Evans Batten Catalogue", "WEB 1401"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.10240020),
        dec: Angle.Degrees(-29.59988233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160391"},
        {"Hipparcos Number", "HIP 86522"},
        {"Smithsonian Astrophysical Observation", "SAO 185609"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.22039939),
        dec: Angle.Degrees(-29.59968914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59696",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59696"},
        {"Geneva Identification System", "GEN# -0.02809374"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.62400691),
        dec: Angle.Degrees(-29.59850530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33759"},
        {"Hipparcos Number", "HIP 24152"},
        {"Geneva Identification System", "GEN# +1.00033759"},
        {"Smithsonian Astrophysical Observation", "SAO 170168"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.80056279),
        dec: Angle.Degrees(-29.59587268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8270",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8270"},
        {"Geneva Identification System", "GEN# -0.03000607"},
        {"Smithsonian Astrophysical Observation", "SAO 167285"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.63490678),
        dec: Angle.Degrees(-29.59489481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -236.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98730"},
        {"Hipparcos Number", "HIP 55450"},
        {"Smithsonian Astrophysical Observation", "SAO 179802"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.35016488),
        dec: Angle.Degrees(-29.59451472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151195"},
        {"Hipparcos Number", "HIP 82161"},
        {"Smithsonian Astrophysical Observation", "SAO 184632"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.76920401),
        dec: Angle.Degrees(-29.59360950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3117",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3117"},
        {"Smithsonian Astrophysical Observation", "SAO 166462"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.91051431),
        dec: Angle.Degrees(-29.59147601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74721",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74721"},
    },
    visualMagnitude: 11.90,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.05156293),
        dec: Angle.Degrees(-29.58896827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15260",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15260"},
        {"Smithsonian Astrophysical Observation", "SAO 168436"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.20703464),
        dec: Angle.Degrees(-29.58542341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46524"},
        {"Hipparcos Number", "HIP 31187"},
        {"Geneva Identification System", "GEN# +1.00046524"},
        {"Smithsonian Astrophysical Observation", "SAO 171921"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.15469968),
        dec: Angle.Degrees(-29.58259339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2364"},
        {"Hipparcos Number", "HIP 2155"},
        {"Smithsonian Astrophysical Observation", "SAO 166281"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.80619907),
        dec: Angle.Degrees(-29.58186243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211257"},
        {"Hipparcos Number", "HIP 109975"},
        {"Smithsonian Astrophysical Observation", "SAO 191014"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.11900630),
        dec: Angle.Degrees(-29.58162792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88567",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11029 A"},
        {"Henry Draper", "HD 164975"},
        {"Hipparcos Number", "HIP 88567"},
        {"Geneva Identification System", "GEN# +1.00164975"},
        {"Smithsonian Astrophysical Observation", "SAO 186237"},
        {"Wilson Evans Batten Catalogue", "WEB 14993"},
    },
    visualMagnitude: 4.66,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.25509380),
        dec: Angle.Degrees(-29.58007620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138394"},
        {"Hipparcos Number", "HIP 76122"},
        {"Geneva Identification System", "GEN# +1.00138394"},
        {"Smithsonian Astrophysical Observation", "SAO 183558"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.20478404),
        dec: Angle.Degrees(-29.57754263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19851",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19851"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.83398247),
        dec: Angle.Degrees(-29.57659960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -239.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32182"},
        {"Hipparcos Number", "HIP 23232"},
        {"Smithsonian Astrophysical Observation", "SAO 169959"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.98556674),
        dec: Angle.Degrees(-29.57621716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50264"},
        {"Hipparcos Number", "HIP 32894"},
        {"Geneva Identification System", "GEN# +1.00050264"},
        {"Smithsonian Astrophysical Observation", "SAO 172443"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.80196093),
        dec: Angle.Degrees(-29.57591954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 923"},
        {"Hipparcos Number", "HIP 1088"},
        {"Geneva Identification System", "GEN# +1.00000923"},
        {"Renson", "Renson 140"},
        {"Smithsonian Astrophysical Observation", "SAO 166128"},
        {"Wilson Evans Batten Catalogue", "WEB 190"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.39177671),
        dec: Angle.Degrees(-29.57562528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36081"},
        {"Hipparcos Number", "HIP 25564"},
        {"Geneva Identification System", "GEN# +1.00036081"},
        {"Smithsonian Astrophysical Observation", "SAO 170452"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.96644156),
        dec: Angle.Degrees(-29.57414615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138874"},
        {"Hipparcos Number", "HIP 76370"},
        {"Smithsonian Astrophysical Observation", "SAO 183604"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.96862730),
        dec: Angle.Degrees(-29.57354964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137747"},
        {"Hipparcos Number", "HIP 75765"},
        {"Renson", "Renson 39170"},
        {"Smithsonian Astrophysical Observation", "SAO 183500"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.17225021),
        dec: Angle.Degrees(-29.56831850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62708"},
        {"Hipparcos Number", "HIP 37721"},
        {"Smithsonian Astrophysical Observation", "SAO 174424"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.05581020),
        dec: Angle.Degrees(-29.56806434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117864"},
        {"Hipparcos Number", "HIP 66148"},
        {"Smithsonian Astrophysical Observation", "SAO 181755"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.38860433),
        dec: Angle.Degrees(-29.56773046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117718"},
        {"Hipparcos Number", "HIP 66060"},
        {"Geneva Identification System", "GEN# +1.00117718"},
        {"Smithsonian Astrophysical Observation", "SAO 181735"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.14383052),
        dec: Angle.Degrees(-29.56528224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31459"},
        {"Hipparcos Number", "HIP 22837"},
        {"Smithsonian Astrophysical Observation", "SAO 169884"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.70590054),
        dec: Angle.Degrees(-29.56146635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49258"},
        {"Hipparcos Number", "HIP 32444"},
        {"Geneva Identification System", "GEN# +1.00049258"},
        {"Smithsonian Astrophysical Observation", "SAO 172304"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.56835282),
        dec: Angle.Degrees(-29.56108436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42483",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6923 A"},
        {"Henry Draper", "HD 73898"},
        {"Hipparcos Number", "HIP 42483"},
        {"Fundamental Katalog 5th Edition", "FK5 2680"},
        {"Geneva Identification System", "GEN# +1.00073898"},
        {"Smithsonian Astrophysical Observation", "SAO 176253"},
        {"Wilson Evans Batten Catalogue", "WEB 8177"},
    },
    visualMagnitude: 4.86,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.92704475),
        dec: Angle.Degrees(-29.56086189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118646"},
        {"Hipparcos Number", "HIP 66563"},
        {"Geneva Identification System", "GEN# +1.00118646"},
        {"Smithsonian Astrophysical Observation", "SAO 181825"},
        {"Wilson Evans Batten Catalogue", "WEB 11744"},
    },
    visualMagnitude: 5.81,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.67552479),
        dec: Angle.Degrees(-29.56067984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130433"},
        {"Hipparcos Number", "HIP 72456"},
        {"Smithsonian Astrophysical Observation", "SAO 182889"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.24660250),
        dec: Angle.Degrees(-29.55897489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66183"},
        {"Hipparcos Number", "HIP 39206"},
        {"Smithsonian Astrophysical Observation", "SAO 174994"},
    },
    visualMagnitude: 8.35,
    bvColour: -0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.30004703),
        dec: Angle.Degrees(-29.55858468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3059"},
        {"Hipparcos Number", "HIP 2661"},
        {"Fundamental Katalog 5th Edition", "FK5 1013"},
        {"Geneva Identification System", "GEN# +1.00003059"},
        {"Smithsonian Astrophysical Observation", "SAO 166367"},
        {"Wilson Evans Batten Catalogue", "WEB 485"},
    },
    visualMagnitude: 5.55,
    bvColour: 1.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.42108802),
        dec: Angle.Degrees(-29.55820696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97956"},
        {"Hipparcos Number", "HIP 55008"},
        {"Smithsonian Astrophysical Observation", "SAO 179703"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.94267338),
        dec: Angle.Degrees(-29.55719029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91761",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91761"},
        {"Smithsonian Astrophysical Observation", "SAO 187166"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.68029461),
        dec: Angle.Degrees(-29.55660417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89948"},
        {"Hipparcos Number", "HIP 50805"},
        {"Geneva Identification System", "GEN# +1.00089948"},
        {"Smithsonian Astrophysical Observation", "SAO 178741"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.59108861),
        dec: Angle.Degrees(-29.55603405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49983"},
        {"Hipparcos Number", "HIP 32749"},
        {"Smithsonian Astrophysical Observation", "SAO 172396"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.44029024),
        dec: Angle.Degrees(-29.55581514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156394"},
        {"Hipparcos Number", "HIP 84665"},
        {"Smithsonian Astrophysical Observation", "SAO 185247"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.62868590),
        dec: Angle.Degrees(-29.55551268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27745"},
        {"Hipparcos Number", "HIP 20355"},
        {"Smithsonian Astrophysical Observation", "SAO 169371"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.39027863),
        dec: Angle.Degrees(-29.55483554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203477"},
        {"Hipparcos Number", "HIP 105592"},
        {"Smithsonian Astrophysical Observation", "SAO 190288"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.80813000),
        dec: Angle.Degrees(-29.55435602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162476"},
        {"Hipparcos Number", "HIP 87482"},
        {"Smithsonian Astrophysical Observation", "SAO 185876"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.11241320),
        dec: Angle.Degrees(-29.55372812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191697"},
        {"Hipparcos Number", "HIP 99553"},
        {"Smithsonian Astrophysical Observation", "SAO 189010"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.05107268),
        dec: Angle.Degrees(-29.55296929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65658",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65658"},
        {"Smithsonian Astrophysical Observation", "SAO 181670"},
    },
    visualMagnitude: 10.01,
    bvColour: 1.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.93370644),
        dec: Angle.Degrees(-29.55129842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220646"},
        {"Hipparcos Number", "HIP 115644"},
        {"Smithsonian Astrophysical Observation", "SAO 191894"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.40705987),
        dec: Angle.Degrees(-29.55018735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 317501"},
        {"Hipparcos Number", "HIP 90213"},
        {"Geneva Identification System", "GEN# +1.00317501"},
        {"Smithsonian Astrophysical Observation", "SAO 186774"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.11182009),
        dec: Angle.Degrees(-29.54412855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 191.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215949"},
        {"Hipparcos Number", "HIP 112690"},
        {"Smithsonian Astrophysical Observation", "SAO 191425"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.31309805),
        dec: Angle.Degrees(-29.54335301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13058"},
        {"Hipparcos Number", "HIP 9879"},
        {"Geneva Identification System", "GEN# +1.00013058"},
        {"Smithsonian Astrophysical Observation", "SAO 167562"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.78504683),
        dec: Angle.Degrees(-29.54291845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86090",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86090"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.90076562),
        dec: Angle.Degrees(+01.11927644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84579"},
        {"Hipparcos Number", "HIP 47882"},
        {"Smithsonian Astrophysical Observation", "SAO 177942"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.37385614),
        dec: Angle.Degrees(-29.53991956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54339"},
        {"Hipparcos Number", "HIP 34342"},
        {"Smithsonian Astrophysical Observation", "SAO 172999"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.78993456),
        dec: Angle.Degrees(-29.53957345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210758"},
        {"Hipparcos Number", "HIP 109684"},
        {"Smithsonian Astrophysical Observation", "SAO 190968"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.27799631),
        dec: Angle.Degrees(-29.53807783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110015"},
        {"Hipparcos Number", "HIP 61756"},
        {"Geneva Identification System", "GEN# +1.00110015"},
        {"Smithsonian Astrophysical Observation", "SAO 180989"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.85096820),
        dec: Angle.Degrees(-29.53685401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216210"},
        {"Hipparcos Number", "HIP 112862"},
        {"Geneva Identification System", "GEN# +1.00216210"},
        {"Smithsonian Astrophysical Observation", "SAO 191444"},
    },
    visualMagnitude: 5.99,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.83726823),
        dec: Angle.Degrees(-29.53627381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91585"},
        {"Hipparcos Number", "HIP 51714"},
        {"Geneva Identification System", "GEN# +1.00091585"},
        {"Smithsonian Astrophysical Observation", "SAO 178980"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.48905497),
        dec: Angle.Degrees(-29.53396854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -377.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 183.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201164"},
        {"Hipparcos Number", "HIP 104378"},
        {"Smithsonian Astrophysical Observation", "SAO 190051"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.18137030),
        dec: Angle.Degrees(-29.53349026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84430"},
        {"Hipparcos Number", "HIP 47785"},
        {"Smithsonian Astrophysical Observation", "SAO 177918"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.14605315),
        dec: Angle.Degrees(-29.53347649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17404",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17404"},
        {"Smithsonian Astrophysical Observation", "SAO 168778"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.93693293),
        dec: Angle.Degrees(-29.53162934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -163.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169141"},
        {"Hipparcos Number", "HIP 90212"},
        {"Smithsonian Astrophysical Observation", "SAO 186775"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.11067961),
        dec: Angle.Degrees(-29.53139741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -199.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160108"},
        {"Hipparcos Number", "HIP 86404"},
        {"Geneva Identification System", "GEN# +1.00160108"},
        {"Smithsonian Astrophysical Observation", "SAO 185591"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.83518932),
        dec: Angle.Degrees(-29.53093595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149386"},
        {"Hipparcos Number", "HIP 81226"},
        {"Smithsonian Astrophysical Observation", "SAO 184476"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.85427536),
        dec: Angle.Degrees(-29.53091472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222334"},
        {"Hipparcos Number", "HIP 116759"},
        {"Geneva Identification System", "GEN# +1.00222334"},
        {"Smithsonian Astrophysical Observation", "SAO 192069"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.94626344),
        dec: Angle.Degrees(-29.53031173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131588"},
        {"Hipparcos Number", "HIP 73012"},
        {"Geneva Identification System", "GEN# +1.00131588"},
        {"Smithsonian Astrophysical Observation", "SAO 182999"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.81875727),
        dec: Angle.Degrees(-29.52896350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -203.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 129.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16947",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16947"},
    },
    visualMagnitude: 11.48,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.51396613),
        dec: Angle.Degrees(-29.52820857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37272",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37272"},
    },
    visualMagnitude: 11.18,
    bvColour: 1.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.80722930),
        dec: Angle.Degrees(-29.52796369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6269"},
        {"Hipparcos Number", "HIP 4932"},
        {"Geneva Identification System", "GEN# +1.00006269"},
        {"Smithsonian Astrophysical Observation", "SAO 166774"},
        {"Wilson Evans Batten Catalogue", "WEB 985"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.82401808),
        dec: Angle.Degrees(-29.52577074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218759"},
        {"Hipparcos Number", "HIP 114453"},
        {"Geneva Identification System", "GEN# +1.00218759"},
        {"Smithsonian Astrophysical Observation", "SAO 191703"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.69426036),
        dec: Angle.Degrees(-29.52499485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74429"},
        {"Hipparcos Number", "HIP 42785"},
        {"Smithsonian Astrophysical Observation", "SAO 176352"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.76642720),
        dec: Angle.Degrees(-29.52435947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73088"},
        {"Hipparcos Number", "HIP 42151"},
        {"Smithsonian Astrophysical Observation", "SAO 176133"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.87360847),
        dec: Angle.Degrees(-29.52360432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181544"},
        {"Hipparcos Number", "HIP 95203"},
        {"Geneva Identification System", "GEN# +1.00181544"},
        {"Smithsonian Astrophysical Observation", "SAO 188025"},
        {"Wilson Evans Batten Catalogue", "WEB 16632"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.51569703),
        dec: Angle.Degrees(-29.52310007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220903"},
        {"Hipparcos Number", "HIP 115816"},
        {"Smithsonian Astrophysical Observation", "SAO 191924"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.93690122),
        dec: Angle.Degrees(-29.51884051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76986",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76986"},
        {"Smithsonian Astrophysical Observation", "SAO 183728"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.79450611),
        dec: Angle.Degrees(-29.51617423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97895"},
        {"Hipparcos Number", "HIP 54970"},
        {"Geneva Identification System", "GEN# +1.00097895"},
        {"Smithsonian Astrophysical Observation", "SAO 179695"},
    },
    visualMagnitude: 8.77,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.83971943),
        dec: Angle.Degrees(-29.51605005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25815"},
        {"Hipparcos Number", "HIP 19015"},
        {"Fundamental Katalog 5th Edition", "FK5 4366"},
        {"Smithsonian Astrophysical Observation", "SAO 169094"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.10412492),
        dec: Angle.Degrees(-29.51529979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128117"},
        {"Hipparcos Number", "HIP 71383"},
        {"Smithsonian Astrophysical Observation", "SAO 182683"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.96011713),
        dec: Angle.Degrees(-29.51484738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80070",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10004 AB"},
        {"Henry Draper", "HD 147046"},
        {"Hipparcos Number", "HIP 80070"},
        {"Geneva Identification System", "GEN# +1.00147046"},
        {"Smithsonian Astrophysical Observation", "SAO 184325"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.14095609),
        dec: Angle.Degrees(-29.51482087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202648"},
        {"Hipparcos Number", "HIP 105156"},
        {"Geneva Identification System", "GEN# +1.00202648"},
        {"Smithsonian Astrophysical Observation", "SAO 190207"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.52131000),
        dec: Angle.Degrees(-29.51305066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94281"},
        {"Hipparcos Number", "HIP 53161"},
        {"Smithsonian Astrophysical Observation", "SAO 179295"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.13777161),
        dec: Angle.Degrees(-29.51248403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3524"},
        {"Hipparcos Number", "HIP 2992"},
        {"Smithsonian Astrophysical Observation", "SAO 166428"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.50803099),
        dec: Angle.Degrees(-29.51230293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224285"},
        {"Hipparcos Number", "HIP 118034"},
        {"Smithsonian Astrophysical Observation", "SAO 192254"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.13448910),
        dec: Angle.Degrees(-29.51013525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59463"},
        {"Hipparcos Number", "HIP 36342"},
        {"Geneva Identification System", "GEN# +1.00059463"},
        {"Smithsonian Astrophysical Observation", "SAO 173832"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.19832255),
        dec: Angle.Degrees(-29.50877670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169678"},
        {"Hipparcos Number", "HIP 90431"},
        {"Smithsonian Astrophysical Observation", "SAO 186825"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.77205195),
        dec: Angle.Degrees(-29.50823671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52237",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52237"},
    },
    visualMagnitude: 11.79,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.07740574),
        dec: Angle.Degrees(-29.50626148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -196.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115169"},
        {"Hipparcos Number", "HIP 64713"},
        {"Smithsonian Astrophysical Observation", "SAO 181494"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.94775850),
        dec: Angle.Degrees(-29.50568632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175893"},
        {"Hipparcos Number", "HIP 93181"},
        {"Geneva Identification System", "GEN# +1.00175893"},
        {"Smithsonian Astrophysical Observation", "SAO 187523"},
        {"Wilson Evans Batten Catalogue", "WEB 16145"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.69703286),
        dec: Angle.Degrees(-29.50501067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49821",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49821"},
    },
    visualMagnitude: 11.48,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.55734839),
        dec: Angle.Degrees(-29.50480987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -219.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 136.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133803"},
        {"Hipparcos Number", "HIP 73990"},
        {"Geneva Identification System", "GEN# +1.00133803"},
        {"Smithsonian Astrophysical Observation", "SAO 183191"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.81231287),
        dec: Angle.Degrees(-29.50441012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173483"},
        {"Hipparcos Number", "HIP 92134"},
        {"Geneva Identification System", "GEN# +1.00173483"},
        {"Smithsonian Astrophysical Observation", "SAO 187261"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.67971127),
        dec: Angle.Degrees(-29.50277906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178840"},
        {"Hipparcos Number", "HIP 94272"},
        {"Geneva Identification System", "GEN# +1.00178840"},
        {"Smithsonian Astrophysical Observation", "SAO 187786"},
        {"Wilson Evans Batten Catalogue", "WEB 16420"},
    },
    visualMagnitude: 6.28,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.82835331),
        dec: Angle.Degrees(-29.50224142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4566"},
        {"Hipparcos Number", "HIP 3696"},
        {"Smithsonian Astrophysical Observation", "SAO 166577"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.84077308),
        dec: Angle.Degrees(-29.49944934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88643"},
        {"Hipparcos Number", "HIP 50025"},
        {"Geneva Identification System", "GEN# +1.00088643"},
        {"Smithsonian Astrophysical Observation", "SAO 178539"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.19867506),
        dec: Angle.Degrees(-29.49924772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95695",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12453 AB"},
        {"Henry Draper", "HD 182878"},
        {"Hipparcos Number", "HIP 95695"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.96507021),
        dec: Angle.Degrees(-29.49851719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183501"},
        {"Hipparcos Number", "HIP 95991"},
        {"Smithsonian Astrophysical Observation", "SAO 188220"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.77696984),
        dec: Angle.Degrees(-29.49488737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102437"},
        {"Hipparcos Number", "HIP 57514"},
        {"Geneva Identification System", "GEN# +1.00102437"},
        {"Smithsonian Astrophysical Observation", "SAO 180190"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.83038712),
        dec: Angle.Degrees(-29.49242992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70753",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9270 AB"},
        {"Henry Draper", "HD 126769"},
        {"Hipparcos Number", "HIP 70753"},
        {"Fundamental Katalog 5th Edition", "FK5 532"},
        {"Geneva Identification System", "GEN# +1.00126769"},
        {"Smithsonian Astrophysical Observation", "SAO 182570"},
        {"Wilson Evans Batten Catalogue", "WEB 12256"},
    },
    visualMagnitude: 4.97,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.04351389),
        dec: Angle.Degrees(-29.49157976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156423"},
        {"Hipparcos Number", "HIP 84684"},
        {"Geneva Identification System", "GEN# +1.00156423"},
        {"Smithsonian Astrophysical Observation", "SAO 185249"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.68296057),
        dec: Angle.Degrees(-29.48986498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -171.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -202.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120469"},
        {"Hipparcos Number", "HIP 67531"},
        {"Smithsonian Astrophysical Observation", "SAO 182000"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.53894331),
        dec: Angle.Degrees(-29.48608510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224630"},
        {"Hipparcos Number", "HIP 118277"},
        {"Geneva Identification System", "GEN# +1.00224630"},
        {"Geneva Identification System 2", "GEN# +4.09010009"},
        {"Smithsonian Astrophysical Observation", "SAO 192294"},
    },
    visualMagnitude: 5.59,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.86625700),
        dec: Angle.Degrees(-29.48515314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141190"},
        {"Hipparcos Number", "HIP 77457"},
        {"Smithsonian Astrophysical Observation", "SAO 183818"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.21721944),
        dec: Angle.Degrees(-29.48339835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148655"},
        {"Hipparcos Number", "HIP 80859"},
        {"Geneva Identification System", "GEN# +1.00148655"},
        {"Renson", "Renson 42040"},
        {"Smithsonian Astrophysical Observation", "SAO 184432"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.67508379),
        dec: Angle.Degrees(-29.48301616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172660"},
        {"Hipparcos Number", "HIP 91759"},
        {"Smithsonian Astrophysical Observation", "SAO 187164"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.67060386),
        dec: Angle.Degrees(-29.47860303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179903"},
        {"Hipparcos Number", "HIP 94642"},
        {"Smithsonian Astrophysical Observation", "SAO 187880"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.88103587),
        dec: Angle.Degrees(-29.47734660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112773"},
        {"Hipparcos Number", "HIP 63392"},
        {"Smithsonian Astrophysical Observation", "SAO 181290"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.85743885),
        dec: Angle.Degrees(-29.47695727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199752"},
        {"Hipparcos Number", "HIP 103651"},
        {"Smithsonian Astrophysical Observation", "SAO 189910"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.01632497),
        dec: Angle.Degrees(-29.47694981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175346"},
        {"Hipparcos Number", "HIP 92940"},
        {"Fundamental Katalog 5th Edition", "FK5 5668"},
        {"Smithsonian Astrophysical Observation", "SAO 187467"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.03599374),
        dec: Angle.Degrees(-29.47665769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165487"},
        {"Hipparcos Number", "HIP 88783"},
        {"Smithsonian Astrophysical Observation", "SAO 186304"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.85940921),
        dec: Angle.Degrees(-29.47581559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61653"},
        {"Hipparcos Number", "HIP 37268"},
        {"Smithsonian Astrophysical Observation", "SAO 174213"},
    },
    visualMagnitude: 7.97,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.79538170),
        dec: Angle.Degrees(-29.47518945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114003"},
        {"Hipparcos Number", "HIP 64066"},
        {"Smithsonian Astrophysical Observation", "SAO 181398"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.95206036),
        dec: Angle.Degrees(-29.47467408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8859"},
        {"Hipparcos Number", "HIP 6744"},
        {"Geneva Identification System", "GEN# +1.00008859"},
        {"Smithsonian Astrophysical Observation", "SAO 167048"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.70511682),
        dec: Angle.Degrees(-29.47450648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -189.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155310"},
        {"Hipparcos Number", "HIP 84131"},
        {"Smithsonian Astrophysical Observation", "SAO 185132"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.98618631),
        dec: Angle.Degrees(-29.47438136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144549"},
        {"Hipparcos Number", "HIP 79004"},
        {"Smithsonian Astrophysical Observation", "SAO 184136"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.90088805),
        dec: Angle.Degrees(-29.47166387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73294",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73294"},
        {"Smithsonian Astrophysical Observation", "SAO 183059"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.68605463),
        dec: Angle.Degrees(-29.46998407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23869"},
        {"Hipparcos Number", "HIP 17693"},
        {"Smithsonian Astrophysical Observation", "SAO 168835"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.84281391),
        dec: Angle.Degrees(-29.46852978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217518"},
        {"Hipparcos Number", "HIP 113694"},
        {"Smithsonian Astrophysical Observation", "SAO 191589"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.39715596),
        dec: Angle.Degrees(-29.46787508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205095"},
        {"Hipparcos Number", "HIP 106467"},
        {"Smithsonian Astrophysical Observation", "SAO 190442"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.45564413),
        dec: Angle.Degrees(-29.46773185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125030"},
        {"Hipparcos Number", "HIP 69843"},
        {"Geneva Identification System", "GEN# +1.00125030"},
        {"Smithsonian Astrophysical Observation", "SAO 182417"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.41244443),
        dec: Angle.Degrees(-29.46733120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75903"},
        {"Hipparcos Number", "HIP 43517"},
        {"Geneva Identification System", "GEN# +1.00075903"},
        {"Smithsonian Astrophysical Observation", "SAO 176596"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.95051628),
        dec: Angle.Degrees(-29.46414324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75629"},
        {"Hipparcos Number", "HIP 43370"},
        {"Geneva Identification System", "GEN# +1.00075629"},
        {"Smithsonian Astrophysical Observation", "SAO 176546"},
        {"Wilson Evans Batten Catalogue", "WEB 8356"},
    },
    visualMagnitude: 5.86,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.50934024),
        dec: Angle.Degrees(-29.46301021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12023"},
        {"Hipparcos Number", "HIP 9113"},
        {"Smithsonian Astrophysical Observation", "SAO 167431"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.35998685),
        dec: Angle.Degrees(-29.46291245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217236"},
        {"Hipparcos Number", "HIP 113532"},
        {"Geneva Identification System", "GEN# +1.00217236"},
        {"Smithsonian Astrophysical Observation", "SAO 191550"},
        {"Wilson Evans Batten Catalogue", "WEB 20183"},
    },
    visualMagnitude: 5.51,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.89901144),
        dec: Angle.Degrees(-29.46232352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42500"},
        {"Hipparcos Number", "HIP 29227"},
        {"Smithsonian Astrophysical Observation", "SAO 171319"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.43856697),
        dec: Angle.Degrees(-29.46005128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99906"},
        {"Hipparcos Number", "HIP 56068"},
        {"Geneva Identification System", "GEN# +1.00099906"},
        {"Smithsonian Astrophysical Observation", "SAO 179933"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.36248409),
        dec: Angle.Degrees(-29.45840812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42967"},
        {"Hipparcos Number", "HIP 29458"},
        {"Smithsonian Astrophysical Observation", "SAO 171388"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.11175093),
        dec: Angle.Degrees(-29.45726615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76607"},
        {"Hipparcos Number", "HIP 43877"},
        {"Smithsonian Astrophysical Observation", "SAO 176722"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.07883542),
        dec: Angle.Degrees(-29.45252180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54690",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54690"},
        {"Geneva Identification System", "GEN# -0.02808704"},
    },
    visualMagnitude: 10.45,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.94656648),
        dec: Angle.Degrees(-29.45106690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40877"},
        {"Smithsonian Astrophysical Observation", "SAO 175640"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.11792494),
        dec: Angle.Degrees(-29.44960055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39543"},
        {"Hipparcos Number", "HIP 27705"},
        {"Geneva Identification System", "GEN# +1.00039543"},
        {"Smithsonian Astrophysical Observation", "SAO 170945"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.99828407),
        dec: Angle.Degrees(-29.44939942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50177"},
        {"Hipparcos Number", "HIP 32842"},
        {"Geneva Identification System", "GEN# +1.00050177"},
        {"Smithsonian Astrophysical Observation", "SAO 172427"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.68948002),
        dec: Angle.Degrees(-29.44754420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120392"},
        {"Hipparcos Number", "HIP 67479"},
        {"Smithsonian Astrophysical Observation", "SAO 181992"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.42633828),
        dec: Angle.Degrees(-29.44601086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81695"},
        {"Hipparcos Number", "HIP 46291"},
        {"Geneva Identification System", "GEN# +1.00081695J"},
        {"Smithsonian Astrophysical Observation", "SAO 177452"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.60476790),
        dec: Angle.Degrees(-29.44369588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27295",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27295"},
        {"Smithsonian Astrophysical Observation", "SAO 170833"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.75169719),
        dec: Angle.Degrees(-29.44196156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198502"},
        {"Hipparcos Number", "HIP 102963"},
        {"Geneva Identification System", "GEN# +1.00198502"},
        {"Smithsonian Astrophysical Observation", "SAO 189778"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.91201331),
        dec: Angle.Degrees(-29.44172773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110604"},
        {"Hipparcos Number", "HIP 62095"},
        {"Geneva Identification System", "GEN# +1.00110604"},
        {"Smithsonian Astrophysical Observation", "SAO 181054"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.88725621),
        dec: Angle.Degrees(-29.44124248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160665"},
        {"Hipparcos Number", "HIP 86665"},
        {"Geneva Identification System", "GEN# +1.00160665"},
        {"Smithsonian Astrophysical Observation", "SAO 185632"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.61280026),
        dec: Angle.Degrees(-29.43886243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34458"},
        {"Hipparcos Number", "HIP 24573"},
        {"Smithsonian Astrophysical Observation", "SAO 170259"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.07244068),
        dec: Angle.Degrees(-29.43870077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161908"},
        {"Hipparcos Number", "HIP 87233"},
        {"Geneva Identification System", "GEN# +1.00161908"},
        {"Smithsonian Astrophysical Observation", "SAO 185797"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.35913393),
        dec: Angle.Degrees(-29.43857693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194235"},
        {"Hipparcos Number", "HIP 100747"},
        {"Smithsonian Astrophysical Observation", "SAO 189266"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.39203825),
        dec: Angle.Degrees(-29.43807790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13090",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13090"},
        {"Smithsonian Astrophysical Observation", "SAO 168064"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.06465406),
        dec: Angle.Degrees(-29.43574499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54522"},
        {"Hipparcos Number", "HIP 34391"},
        {"Smithsonian Astrophysical Observation", "SAO 173028"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.96213298),
        dec: Angle.Degrees(-29.43261849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31171"},
        {"Hipparcos Number", "HIP 22643"},
        {"Geneva Identification System", "GEN# +1.00031171"},
        {"Smithsonian Astrophysical Observation", "SAO 169832"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.08179117),
        dec: Angle.Degrees(-29.43223317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16373",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16373"},
    },
    visualMagnitude: 11.38,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.72977071),
        dec: Angle.Degrees(-29.43122991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137276"},
        {"Hipparcos Number", "HIP 75550"},
        {"Smithsonian Astrophysical Observation", "SAO 183461"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.51790022),
        dec: Angle.Degrees(-29.43053057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21592"},
        {"Hipparcos Number", "HIP 16157"},
        {"Smithsonian Astrophysical Observation", "SAO 168569"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.05185445),
        dec: Angle.Degrees(-29.42770774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12493",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12493"},
        {"Geneva Identification System", "GEN# +0.00000444"},
        {"Smithsonian Astrophysical Observation", "SAO 110676"},
        {"Wilson Evans Batten Catalogue", "WEB 2557"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.17794724),
        dec: Angle.Degrees(+01.19811427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 281.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 230.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16055"},
        {"Hipparcos Number", "HIP 11922"},
        {"Smithsonian Astrophysical Observation", "SAO 167883"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.47166291),
        dec: Angle.Degrees(-29.42615667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41111"},
        {"Hipparcos Number", "HIP 28569"},
        {"Smithsonian Astrophysical Observation", "SAO 171148"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.43938061),
        dec: Angle.Degrees(-29.42422071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197214"},
        {"Hipparcos Number", "HIP 102264"},
        {"Geneva Identification System", "GEN# +1.00197214"},
        {"Smithsonian Astrophysical Observation", "SAO 189606"},
        {"Wilson Evans Batten Catalogue", "WEB 18507"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.81678113),
        dec: Angle.Degrees(-29.42340416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20047"},
        {"Hipparcos Number", "HIP 14920"},
        {"Geneva Identification System", "GEN# +1.00020047"},
        {"Smithsonian Astrophysical Observation", "SAO 168380"},
        {"Wilson Evans Batten Catalogue", "WEB 2883"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.12051319),
        dec: Angle.Degrees(-29.42240412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3809"},
        {"Hipparcos Number", "HIP 3188"},
        {"Geneva Identification System", "GEN# +1.00003809"},
        {"Smithsonian Astrophysical Observation", "SAO 166477"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.13886688),
        dec: Angle.Degrees(-29.42087891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105747"},
        {"Hipparcos Number", "HIP 59337"},
        {"Smithsonian Astrophysical Observation", "SAO 180533"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.58110353),
        dec: Angle.Degrees(-29.41950911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66698"},
        {"Hipparcos Number", "HIP 39439"},
        {"Geneva Identification System", "GEN# +1.00066698"},
        {"Renson", "Renson 18430"},
        {"Smithsonian Astrophysical Observation", "SAO 175087"},
    },
    visualMagnitude: 7.74,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.92514390),
        dec: Angle.Degrees(-29.41896702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 657",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 657"},
        {"Smithsonian Astrophysical Observation", "SAO 166069"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.02090072),
        dec: Angle.Degrees(-29.41637426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145250"},
        {"Hipparcos Number", "HIP 79302"},
        {"Geneva Identification System", "GEN# +1.00145250"},
        {"Smithsonian Astrophysical Observation", "SAO 184197"},
        {"Wilson Evans Batten Catalogue", "WEB 13406"},
    },
    visualMagnitude: 5.09,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.75886281),
        dec: Angle.Degrees(-29.41600661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80223"},
        {"Hipparcos Number", "HIP 45601"},
        {"Smithsonian Astrophysical Observation", "SAO 177227"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.41795753),
        dec: Angle.Degrees(-29.41595222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190619"},
        {"Hipparcos Number", "HIP 99081"},
        {"Smithsonian Astrophysical Observation", "SAO 188922"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.72684981),
        dec: Angle.Degrees(-29.41557149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54597",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54597"},
        {"Geneva Identification System", "GEN# -0.02808692"},
        {"Smithsonian Astrophysical Observation", "SAO 179614"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.60829474),
        dec: Angle.Degrees(-29.41379941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10646"},
        {"Hipparcos Number", "HIP 8048"},
        {"Geneva Identification System", "GEN# +1.00010646"},
        {"Renson", "Renson 2630"},
        {"Smithsonian Astrophysical Observation", "SAO 167252"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.83457946),
        dec: Angle.Degrees(-29.41365661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83197"},
        {"Hipparcos Number", "HIP 47100"},
        {"Smithsonian Astrophysical Observation", "SAO 177720"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.98207089),
        dec: Angle.Degrees(-29.41051468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60725"},
        {"Hipparcos Number", "HIP 36870"},
        {"Smithsonian Astrophysical Observation", "SAO 174040"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.69850252),
        dec: Angle.Degrees(-29.41000991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54205",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54205"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.33920954),
        dec: Angle.Degrees(+01.23849160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151928"},
        {"Hipparcos Number", "HIP 82492"},
        {"Geneva Identification System", "GEN# +1.00151928"},
        {"Smithsonian Astrophysical Observation", "SAO 184716"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.88908553),
        dec: Angle.Degrees(-29.40951927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10102",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10102"},
        {"Smithsonian Astrophysical Observation", "SAO 167604"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.47844085),
        dec: Angle.Degrees(-29.40926647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198953"},
        {"Hipparcos Number", "HIP 103221"},
        {"Smithsonian Astrophysical Observation", "SAO 189824"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.68818981),
        dec: Angle.Degrees(-29.40840983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30497"},
        {"Hipparcos Number", "HIP 22233"},
        {"Smithsonian Astrophysical Observation", "SAO 169764"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.74561537),
        dec: Angle.Degrees(-29.40761603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213185"},
        {"Hipparcos Number", "HIP 111076"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.53861333),
        dec: Angle.Degrees(-29.40696088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55176",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55176"},
        {"Smithsonian Astrophysical Observation", "SAO 179749"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.45152003),
        dec: Angle.Degrees(-29.40498128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83378"},
        {"Hipparcos Number", "HIP 47209"},
        {"Smithsonian Astrophysical Observation", "SAO 177755"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.31239735),
        dec: Angle.Degrees(-29.40474338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112087"},
        {"Hipparcos Number", "HIP 62969"},
        {"Smithsonian Astrophysical Observation", "SAO 181207"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.55294066),
        dec: Angle.Degrees(-29.40416810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72284",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72284"},
        {"Smithsonian Astrophysical Observation", "SAO 182866"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.73691832),
        dec: Angle.Degrees(-29.40325950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67458"},
        {"Hipparcos Number", "HIP 39710"},
        {"Cincinnati Publication", "Ci 20 457"},
        {"Geneva Identification System", "GEN# +1.00067458"},
        {"Smithsonian Astrophysical Observation", "SAO 175200"},
        {"Wilson Evans Batten Catalogue", "WEB 7750"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.75122909),
        dec: Angle.Degrees(-29.40207468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 339.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -354.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223515"},
        {"Hipparcos Number", "HIP 117542"},
        {"Geneva Identification System", "GEN# +1.00223515"},
        {"Smithsonian Astrophysical Observation", "SAO 192188"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.839,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.56157179),
        dec: Angle.Degrees(-29.40177067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 185.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5769"},
        {"Hipparcos Number", "HIP 4603"},
        {"Geneva Identification System", "GEN# +1.00005769"},
        {"Smithsonian Astrophysical Observation", "SAO 166719"},
        {"Wilson Evans Batten Catalogue", "WEB 853"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.75491472),
        dec: Angle.Degrees(-29.40170903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139732"},
        {"Hipparcos Number", "HIP 76801"},
        {"Smithsonian Astrophysical Observation", "SAO 183695"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.21591007),
        dec: Angle.Degrees(-29.40092779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24304"},
        {"Hipparcos Number", "HIP 18010"},
        {"Smithsonian Astrophysical Observation", "SAO 168886"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.74781446),
        dec: Angle.Degrees(-29.40089513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80478",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10048 AB"},
        {"Henry Draper", "HD 147890"},
        {"Hipparcos Number", "HIP 80478"},
        {"Geneva Identification System", "GEN# +1.00147890J"},
        {"Renson", "Renson 41720"},
        {"Smithsonian Astrophysical Observation", "SAO 184380"},
        {"Wilson Evans Batten Catalogue", "WEB 13619"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.41310257),
        dec: Angle.Degrees(-29.40041209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122477"},
        {"Hipparcos Number", "HIP 68613"},
        {"Smithsonian Astrophysical Observation", "SAO 182190"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.69504282),
        dec: Angle.Degrees(-29.39936964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6339"},
        {"Hipparcos Number", "HIP 5003"},
        {"Geneva Identification System", "GEN# +1.00006339"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.02251373),
        dec: Angle.Degrees(-29.39805288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47210"},
        {"Hipparcos Number", "HIP 31543"},
        {"Geneva Identification System", "GEN# +1.00047210"},
        {"Smithsonian Astrophysical Observation", "SAO 172011"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.04191794),
        dec: Angle.Degrees(-29.39783500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105970"},
        {"Hipparcos Number", "HIP 59460"},
        {"Smithsonian Astrophysical Observation", "SAO 180555"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.94439692),
        dec: Angle.Degrees(-29.39738050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223934"},
        {"Hipparcos Number", "HIP 117822"},
        {"Smithsonian Astrophysical Observation", "SAO 192224"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.43406009),
        dec: Angle.Degrees(-29.39658751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43179"},
        {"Hipparcos Number", "HIP 29546"},
        {"Geneva Identification System", "GEN# +1.00043179"},
        {"Smithsonian Astrophysical Observation", "SAO 171425"},
        {"Wilson Evans Batten Catalogue", "WEB 5808"},
    },
    visualMagnitude: 6.52,
    bvColour: -0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.38953151),
        dec: Angle.Degrees(-29.39574581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72810",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72810"},
        {"Smithsonian Astrophysical Observation", "SAO 182956"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.22609568),
        dec: Angle.Degrees(-29.39562657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192752"},
        {"Hipparcos Number", "HIP 100024"},
        {"Smithsonian Astrophysical Observation", "SAO 189105"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.40042273),
        dec: Angle.Degrees(-29.39405645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10002"},
        {"Hipparcos Number", "HIP 7539"},
        {"Cincinnati Publication", "Ci 18 222"},
        {"Geneva Identification System", "GEN# +1.00010002"},
        {"Smithsonian Astrophysical Observation", "SAO 167179"},
        {"Wilson Evans Batten Catalogue", "WEB 1611"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.28515039),
        dec: Angle.Degrees(-29.39309256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 285.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194897"},
        {"Hipparcos Number", "HIP 101060"},
        {"Smithsonian Astrophysical Observation", "SAO 189336"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.29942696),
        dec: Angle.Degrees(-29.39281983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9905"},
        {"Hipparcos Number", "HIP 7467"},
        {"Geneva Identification System", "GEN# +1.00009905"},
        {"Smithsonian Astrophysical Observation", "SAO 167168"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.04220085),
        dec: Angle.Degrees(-29.39235687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150496"},
        {"Hipparcos Number", "HIP 81808"},
        {"Smithsonian Astrophysical Observation", "SAO 184559"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.63117764),
        dec: Angle.Degrees(-29.39121633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7514"},
        {"Hipparcos Number", "HIP 5831"},
        {"Smithsonian Astrophysical Observation", "SAO 166903"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.69637103),
        dec: Angle.Degrees(-29.39046068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53438"},
        {"Hipparcos Number", "HIP 34051"},
        {"Smithsonian Astrophysical Observation", "SAO 172881"},
    },
    visualMagnitude: 9.17,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.95874832),
        dec: Angle.Degrees(-29.38750973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182963"},
        {"Hipparcos Number", "HIP 95735"},
        {"Geneva Identification System", "GEN# +1.00182963"},
        {"Smithsonian Astrophysical Observation", "SAO 188162"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.09215182),
        dec: Angle.Degrees(-29.38697942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9693"},
        {"Hipparcos Number", "HIP 7332"},
        {"Geneva Identification System", "GEN# +1.00009693"},
        {"Smithsonian Astrophysical Observation", "SAO 167149"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.59991227),
        dec: Angle.Degrees(-29.38530032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29843"},
        {"Hipparcos Number", "HIP 21798"},
        {"Smithsonian Astrophysical Observation", "SAO 169665"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.24398719),
        dec: Angle.Degrees(-29.38331289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225206"},
        {"Hipparcos Number", "HIP 349"},
        {"Geneva Identification System", "GEN# +4.09010076"},
        {"Renson", "Renson 61760"},
        {"Smithsonian Astrophysical Observation", "SAO 166032"},
    },
    visualMagnitude: 7.77,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.09539438),
        dec: Angle.Degrees(-29.38157885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174631"},
        {"Hipparcos Number", "HIP 92643"},
        {"Geneva Identification System", "GEN# +1.00174631"},
        {"Smithsonian Astrophysical Observation", "SAO 187389"},
    },
    visualMagnitude: 6.12,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.15435467),
        dec: Angle.Degrees(-29.37956282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63508"},
        {"Hipparcos Number", "HIP 38065"},
        {"Geneva Identification System", "GEN# +1.00063508"},
        {"Smithsonian Astrophysical Observation", "SAO 174560"},
    },
    visualMagnitude: 8.94,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.01707515),
        dec: Angle.Degrees(-29.37939700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79412"},
        {"Hipparcos Number", "HIP 45230"},
        {"Smithsonian Astrophysical Observation", "SAO 177124"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.26592149),
        dec: Angle.Degrees(-29.37817676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118189"},
        {"Hipparcos Number", "HIP 66334"},
        {"Geneva Identification System", "GEN# +1.00118189"},
        {"Smithsonian Astrophysical Observation", "SAO 181779"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.92097778),
        dec: Angle.Degrees(-29.37775767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106017",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106017"},
    },
    visualMagnitude: 11.12,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.09498322),
        dec: Angle.Degrees(-29.37540823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 193.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50358"},
        {"Hipparcos Number", "HIP 32920"},
        {"Smithsonian Astrophysical Observation", "SAO 172453"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.88647564),
        dec: Angle.Degrees(-29.37505332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194696"},
        {"Hipparcos Number", "HIP 100952"},
        {"Smithsonian Astrophysical Observation", "SAO 189310"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.02466324),
        dec: Angle.Degrees(-29.37398834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72467"},
        {"Hipparcos Number", "HIP 41856"},
        {"Smithsonian Astrophysical Observation", "SAO 176026"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.00788758),
        dec: Angle.Degrees(-29.37085507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128431"},
        {"Hipparcos Number", "HIP 71516"},
        {"Geneva Identification System", "GEN# +1.00128431"},
        {"Smithsonian Astrophysical Observation", "SAO 182714"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.39120991),
        dec: Angle.Degrees(-29.36729552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118332"},
        {"Hipparcos Number", "HIP 66401"},
        {"Smithsonian Astrophysical Observation", "SAO 181788"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.20290271),
        dec: Angle.Degrees(-29.36586818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207346"},
        {"Hipparcos Number", "HIP 107686"},
        {"Smithsonian Astrophysical Observation", "SAO 190646"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.21629839),
        dec: Angle.Degrees(-29.36571166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43471"},
        {"Hipparcos Number", "HIP 29671"},
        {"Smithsonian Astrophysical Observation", "SAO 171461"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.75702756),
        dec: Angle.Degrees(-29.36534532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21079"},
        {"Hipparcos Number", "HIP 15764"},
        {"Geneva Identification System", "GEN# +1.00021079"},
        {"Smithsonian Astrophysical Observation", "SAO 168501"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.77859914),
        dec: Angle.Degrees(-29.36533076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134052"},
        {"Hipparcos Number", "HIP 74105"},
        {"Geneva Identification System", "GEN# +1.00134052"},
        {"Smithsonian Astrophysical Observation", "SAO 183206"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.17848505),
        dec: Angle.Degrees(-29.36523673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156721"},
        {"Hipparcos Number", "HIP 84846"},
        {"Smithsonian Astrophysical Observation", "SAO 185278"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.11505332),
        dec: Angle.Degrees(-29.36494727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117566",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117566"},
        {"Smithsonian Astrophysical Observation", "SAO 192193"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.63025483),
        dec: Angle.Degrees(-29.36317586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214966"},
        {"Hipparcos Number", "HIP 112102"},
        {"Geneva Identification System", "GEN# +1.00214966"},
        {"Smithsonian Astrophysical Observation", "SAO 191337"},
        {"Wilson Evans Batten Catalogue", "WEB 20007"},
    },
    visualMagnitude: 6.12,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.59198418),
        dec: Angle.Degrees(-29.36099924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62558"},
        {"Hipparcos Number", "HIP 37639"},
        {"Geneva Identification System", "GEN# +1.00062558"},
        {"Smithsonian Astrophysical Observation", "SAO 174385"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.85249892),
        dec: Angle.Degrees(-29.35998288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116649",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16885 AB"},
        {"Henry Draper", "HD 222160"},
        {"Hipparcos Number", "HIP 116649"},
        {"Smithsonian Astrophysical Observation", "SAO 192051"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.58866053),
        dec: Angle.Degrees(-29.35986257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129178"},
        {"Hipparcos Number", "HIP 71859"},
        {"Geneva Identification System", "GEN# +1.00129178"},
        {"Smithsonian Astrophysical Observation", "SAO 182774"},
        {"Wilson Evans Batten Catalogue", "WEB 12376"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.48158747),
        dec: Angle.Degrees(-29.35955891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202154"},
        {"Hipparcos Number", "HIP 104896"},
        {"Smithsonian Astrophysical Observation", "SAO 190159"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.72549232),
        dec: Angle.Degrees(-29.35770544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29249"},
        {"Hipparcos Number", "HIP 21378"},
        {"Smithsonian Astrophysical Observation", "SAO 169591"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.81278754),
        dec: Angle.Degrees(-29.35747663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5737"},
        {"Hipparcos Number", "HIP 4577"},
        {"Fundamental Katalog 5th Edition", "FK5 35"},
        {"Geneva Identification System", "GEN# +1.00005737"},
        {"Renson", "Renson 1490"},
        {"Smithsonian Astrophysical Observation", "SAO 166716"},
        {"Wilson Evans Batten Catalogue", "WEB 839"},
    },
    visualMagnitude: 4.30,
    bvColour: -0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.65144118),
        dec: Angle.Degrees(-29.35746436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102363"},
        {"Hipparcos Number", "HIP 57469"},
        {"Smithsonian Astrophysical Observation", "SAO 180181"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.70811204),
        dec: Angle.Degrees(-29.35491061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197787"},
        {"Hipparcos Number", "HIP 102541"},
        {"Smithsonian Astrophysical Observation", "SAO 189686"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.69752074),
        dec: Angle.Degrees(-29.35392763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11024",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1816 A"},
        {"Henry Draper", "HD 14758"},
        {"Hipparcos Number", "HIP 11024"},
        {"Geneva Identification System", "GEN# +1.00014758"},
        {"Smithsonian Astrophysical Observation", "SAO 167730"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.49651707),
        dec: Angle.Degrees(-29.35166467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -173.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56581"},
        {"Hipparcos Number", "HIP 35190"},
        {"Smithsonian Astrophysical Observation", "SAO 173347"},
    },
    visualMagnitude: 9.51,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.08758806),
        dec: Angle.Degrees(-29.35068110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202960"},
        {"Hipparcos Number", "HIP 105323"},
        {"Geneva Identification System", "GEN# +1.00202960"},
        {"Smithsonian Astrophysical Observation", "SAO 190240"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.00008599),
        dec: Angle.Degrees(-29.34934154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36170"},
        {"Hipparcos Number", "HIP 25632"},
        {"Smithsonian Astrophysical Observation", "SAO 170468"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.12717351),
        dec: Angle.Degrees(-29.34929413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55143"},
        {"Hipparcos Number", "HIP 34645"},
        {"Smithsonian Astrophysical Observation", "SAO 173134"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.62608470),
        dec: Angle.Degrees(-29.34709925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209386"},
        {"Hipparcos Number", "HIP 108908"},
        {"Smithsonian Astrophysical Observation", "SAO 190856"},
    },
    visualMagnitude: 7.39,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.91285213),
        dec: Angle.Degrees(-29.34655949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76637"},
        {"Hipparcos Number", "HIP 43890"},
        {"Smithsonian Astrophysical Observation", "SAO 176726"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.11966997),
        dec: Angle.Degrees(-29.34511161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3733",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 664 AB"},
        {"Henry Draper", "HD 4623"},
        {"Hipparcos Number", "HIP 3733"},
        {"Geneva Identification System", "GEN# +1.00004623"},
        {"Smithsonian Astrophysical Observation", "SAO 166584"},
        {"Wilson Evans Batten Catalogue", "WEB 665"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.98621508),
        dec: Angle.Degrees(-29.34391690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72547",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72547"},
        {"Smithsonian Astrophysical Observation", "SAO 182904"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.47894590),
        dec: Angle.Degrees(-29.34374485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73753"},
        {"Hipparcos Number", "HIP 42420"},
        {"Smithsonian Astrophysical Observation", "SAO 176225"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.75232476),
        dec: Angle.Degrees(-29.34223176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136646"},
        {"Hipparcos Number", "HIP 75272"},
        {"Smithsonian Astrophysical Observation", "SAO 183417"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.68828639),
        dec: Angle.Degrees(-29.34190690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176613"},
        {"Hipparcos Number", "HIP 93485"},
        {"Geneva Identification System", "GEN# +1.00176613"},
        {"Smithsonian Astrophysical Observation", "SAO 187594"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.58186612),
        dec: Angle.Degrees(-29.34182116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 315741"},
        {"Hipparcos Number", "HIP 85148"},
    },
    visualMagnitude: 11.19,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.00950875),
        dec: Angle.Degrees(-29.34112355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52673",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52673"},
        {"Geneva Identification System", "GEN# -0.02808426"},
        {"Smithsonian Astrophysical Observation", "SAO 179207"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.55943863),
        dec: Angle.Degrees(-29.33978973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -261.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172140"},
        {"Hipparcos Number", "HIP 91514"},
        {"Geneva Identification System", "GEN# +1.00172140"},
        {"Smithsonian Astrophysical Observation", "SAO 187100"},
        {"Wilson Evans Batten Catalogue", "WEB 15730"},
    },
    visualMagnitude: 9.94,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.95104628),
        dec: Angle.Degrees(-29.33926659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41473"},
        {"Hipparcos Number", "HIP 28735"},
        {"Smithsonian Astrophysical Observation", "SAO 171201"},
    },
    visualMagnitude: 7.80,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.03009100),
        dec: Angle.Degrees(-29.33903071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25260"},
        {"Hipparcos Number", "HIP 18654"},
        {"Smithsonian Astrophysical Observation", "SAO 169014"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.90232878),
        dec: Angle.Degrees(-29.33877276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57504"},
        {"Hipparcos Number", "HIP 35562"},
        {"Smithsonian Astrophysical Observation", "SAO 173500"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.07951301),
        dec: Angle.Degrees(-29.33866599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23738"},
        {"Hipparcos Number", "HIP 17618"},
        {"Geneva Identification System", "GEN# +1.00023738J"},
        {"Smithsonian Astrophysical Observation", "SAO 168820"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.61426555),
        dec: Angle.Degrees(-29.33816606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28325"},
        {"Hipparcos Number", "HIP 20758"},
        {"Smithsonian Astrophysical Observation", "SAO 169457"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.71738684),
        dec: Angle.Degrees(-29.33558066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125199"},
        {"Hipparcos Number", "HIP 69931"},
        {"Smithsonian Astrophysical Observation", "SAO 182430"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.66158761),
        dec: Angle.Degrees(-29.33536576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91894",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91894"},
        {"Smithsonian Astrophysical Observation", "SAO 187197"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.00047219),
        dec: Angle.Degrees(-29.33105738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -171.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38210"},
        {"Hipparcos Number", "HIP 26923"},
        {"Renson", "Renson 10300"},
        {"Smithsonian Astrophysical Observation", "SAO 170729"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.72103807),
        dec: Angle.Degrees(-29.32984474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152471"},
        {"Hipparcos Number", "HIP 82742"},
        {"Smithsonian Astrophysical Observation", "SAO 184780"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.67800457),
        dec: Angle.Degrees(-29.32772947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16473"},
        {"Hipparcos Number", "HIP 12246"},
        {"Smithsonian Astrophysical Observation", "SAO 167932"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.42021484),
        dec: Angle.Degrees(-29.32368347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37641",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37641"},
        {"Geneva Identification System", "GEN# -0.02904849"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.87073971),
        dec: Angle.Degrees(-29.32012823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174446"},
        {"Hipparcos Number", "HIP 92564"},
        {"Smithsonian Astrophysical Observation", "SAO 187367"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.93072640),
        dec: Angle.Degrees(-29.31741986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161907"},
        {"Hipparcos Number", "HIP 87238"},
        {"Smithsonian Astrophysical Observation", "SAO 185798"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.36818079),
        dec: Angle.Degrees(-29.31473579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140993"},
        {"Hipparcos Number", "HIP 77374"},
        {"Geneva Identification System", "GEN# +1.00140993"},
        {"Smithsonian Astrophysical Observation", "SAO 183794"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.92051248),
        dec: Angle.Degrees(-29.31395851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214661"},
        {"Hipparcos Number", "HIP 111914"},
        {"Smithsonian Astrophysical Observation", "SAO 191312"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.04112989),
        dec: Angle.Degrees(-29.31267244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108742"},
        {"Hipparcos Number", "HIP 60962"},
        {"Smithsonian Astrophysical Observation", "SAO 180843"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.45331673),
        dec: Angle.Degrees(-29.31197225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139123"},
        {"Hipparcos Number", "HIP 76496"},
        {"Geneva Identification System", "GEN# +1.00139123"},
        {"Smithsonian Astrophysical Observation", "SAO 183629"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.35552651),
        dec: Angle.Degrees(-29.31109319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127174"},
        {"Hipparcos Number", "HIP 70941"},
        {"Geneva Identification System", "GEN# +1.00127174"},
        {"Smithsonian Astrophysical Observation", "SAO 182608"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.65227120),
        dec: Angle.Degrees(-29.30993018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46413"},
        {"Hipparcos Number", "HIP 31133"},
        {"Smithsonian Astrophysical Observation", "SAO 171899"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.98435497),
        dec: Angle.Degrees(-29.30959217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16287",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16287"},
        {"Smithsonian Astrophysical Observation", "SAO 111222"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.48751687),
        dec: Angle.Degrees(+01.23997589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95456",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12400 A"},
        {"Henry Draper", "HD 182286"},
        {"Hipparcos Number", "HIP 95456"},
        {"Geneva Identification System", "GEN# +1.00182286J"},
        {"Smithsonian Astrophysical Observation", "SAO 188093"},
    },
    visualMagnitude: 5.91,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.26687908),
        dec: Angle.Degrees(-29.30920884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62939",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8698 AB"},
        {"Henry Draper", "HD 112052"},
        {"Hipparcos Number", "HIP 62939"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.47191814),
        dec: Angle.Degrees(-29.30819701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39010",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39010"},
        {"Geneva Identification System", "GEN# -0.02805221"},
    },
    visualMagnitude: 10.61,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.74675433),
        dec: Angle.Degrees(-29.30788671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152537"},
        {"Hipparcos Number", "HIP 82782"},
        {"Geneva Identification System", "GEN# +1.00152537"},
        {"Smithsonian Astrophysical Observation", "SAO 184789"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.76285022),
        dec: Angle.Degrees(-29.30523242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86564"},
        {"Hipparcos Number", "HIP 48916"},
        {"Smithsonian Astrophysical Observation", "SAO 178261"},
        {"Wilson Evans Batten Catalogue", "WEB 9085"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.68195374),
        dec: Angle.Degrees(-29.30476275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144894"},
        {"Hipparcos Number", "HIP 79142"},
        {"Geneva Identification System", "GEN# +1.00144894"},
        {"Smithsonian Astrophysical Observation", "SAO 184170"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.30687687),
        dec: Angle.Degrees(-29.30430288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219569"},
        {"Hipparcos Number", "HIP 114956"},
        {"Smithsonian Astrophysical Observation", "SAO 191790"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.25730563),
        dec: Angle.Degrees(-29.30379082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35904",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Aludra"},
        {"Henry Draper", "HD 58350"},
        {"Hipparcos Number", "HIP 35904"},
        {"Celescope Catalog", "CEL 1826"},
        {"Fundamental Katalog 5th Edition", "FK5 283"},
        {"Geneva Identification System", "GEN# +5.11210034"},
        {"Smithsonian Astrophysical Observation", "SAO 173651"},
        {"Wilson Evans Batten Catalogue", "WEB 7150"},
    },
    visualMagnitude: 2.45,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.02377104),
        dec: Angle.Degrees(-29.30311979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9651"},
        {"Hipparcos Number", "HIP 7306"},
        {"Geneva Identification System", "GEN# +1.00009651"},
        {"Smithsonian Astrophysical Observation", "SAO 167143"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.51505331),
        dec: Angle.Degrees(-29.30216567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128931"},
        {"Hipparcos Number", "HIP 71734"},
        {"Geneva Identification System", "GEN# +1.00128931"},
        {"Smithsonian Astrophysical Observation", "SAO 182751"},
        {"Wilson Evans Batten Catalogue", "WEB 12358"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.10596877),
        dec: Angle.Degrees(-29.30154067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211582"},
        {"Hipparcos Number", "HIP 110151"},
        {"Smithsonian Astrophysical Observation", "SAO 191045"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.862,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.68602451),
        dec: Angle.Degrees(-29.30120161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7304",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7304"},
    },
    visualMagnitude: 11.99,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.50902958),
        dec: Angle.Degrees(-29.29978538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139867"},
        {"Hipparcos Number", "HIP 76851"},
        {"Geneva Identification System", "GEN# +1.00139867"},
        {"Smithsonian Astrophysical Observation", "SAO 183705"},
        {"Wilson Evans Batten Catalogue", "WEB 13036"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.38776933),
        dec: Angle.Degrees(-29.29950854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185812"},
        {"Hipparcos Number", "HIP 96909"},
        {"Smithsonian Astrophysical Observation", "SAO 188459"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.49816004),
        dec: Angle.Degrees(-29.29949055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2347"},
        {"Hipparcos Number", "HIP 2141"},
        {"Smithsonian Astrophysical Observation", "SAO 166280"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.77989220),
        dec: Angle.Degrees(-29.29858047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12767"},
        {"Hipparcos Number", "HIP 9677"},
        {"Fundamental Katalog 5th Edition", "FK5 1055"},
        {"Geneva Identification System", "GEN# +1.00012767"},
        {"Renson", "Renson 3260"},
        {"Smithsonian Astrophysical Observation", "SAO 167532"},
        {"Wilson Evans Batten Catalogue", "WEB 2031"},
    },
    visualMagnitude: 4.68,
    bvColour: -0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.12262534),
        dec: Angle.Degrees(-29.29683966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90921"},
        {"Smithsonian Astrophysical Observation", "SAO 186947"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.20515507),
        dec: Angle.Degrees(-29.29638164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57119"},
        {"Hipparcos Number", "HIP 35407"},
        {"Renson", "Renson 15590"},
        {"Smithsonian Astrophysical Observation", "SAO 173448"},
    },
    visualMagnitude: 8.74,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.66047995),
        dec: Angle.Degrees(-29.29585427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117717"},
        {"Hipparcos Number", "HIP 66063"},
        {"Smithsonian Astrophysical Observation", "SAO 181736"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.14565392),
        dec: Angle.Degrees(-29.29560120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156571"},
        {"Hipparcos Number", "HIP 84758"},
        {"Geneva Identification System", "GEN# +1.00156571"},
        {"Smithsonian Astrophysical Observation", "SAO 185267"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.87669320),
        dec: Angle.Degrees(-29.29384797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195704"},
        {"Hipparcos Number", "HIP 101469"},
        {"Smithsonian Astrophysical Observation", "SAO 189430"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.45563057),
        dec: Angle.Degrees(-29.29261322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78350"},
        {"Hipparcos Number", "HIP 44726"},
        {"Geneva Identification System", "GEN# +1.00078350"},
        {"Smithsonian Astrophysical Observation", "SAO 176976"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.70619901),
        dec: Angle.Degrees(-29.29236299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148199"},
        {"Hipparcos Number", "HIP 80607"},
        {"Geneva Identification System", "GEN# +1.00148199"},
        {"Renson", "Renson 41870"},
        {"Smithsonian Astrophysical Observation", "SAO 184398"},
        {"Wilson Evans Batten Catalogue", "WEB 13634"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.87371240),
        dec: Angle.Degrees(-29.28824157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6724"},
        {"Hipparcos Number", "HIP 5284"},
        {"Geneva Identification System", "GEN# +1.00006724"},
        {"Smithsonian Astrophysical Observation", "SAO 166816"},
        {"Wilson Evans Batten Catalogue", "WEB 1129"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.89323852),
        dec: Angle.Degrees(-29.28675143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88250"},
        {"Hipparcos Number", "HIP 49803"},
        {"Smithsonian Astrophysical Observation", "SAO 178489"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.48577875),
        dec: Angle.Degrees(-29.28568158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106672",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106672"},
        {"Smithsonian Astrophysical Observation", "SAO 190482"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.09093916),
        dec: Angle.Degrees(-29.28553506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2477"},
        {"Hipparcos Number", "HIP 2239"},
        {"Geneva Identification System", "GEN# +1.00002477"},
        {"Smithsonian Astrophysical Observation", "SAO 166299"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.11006492),
        dec: Angle.Degrees(-29.28464781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145103"},
        {"Hipparcos Number", "HIP 79247"},
        {"Smithsonian Astrophysical Observation", "SAO 184186"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.59740595),
        dec: Angle.Degrees(-29.28333651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98670",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98670"},
        {"Smithsonian Astrophysical Observation", "SAO 188842"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.61943750),
        dec: Angle.Degrees(-29.28311851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316418"},
        {"Hipparcos Number", "HIP 87250"},
        {"Geneva Identification System", "GEN# +1.00316418"},
        {"Smithsonian Astrophysical Observation", "SAO 185803"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.42411213),
        dec: Angle.Degrees(-29.28258481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124576"},
        {"Hipparcos Number", "HIP 69623"},
        {"Geneva Identification System", "GEN# +1.00124576"},
        {"Smithsonian Astrophysical Observation", "SAO 182374"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.75532477),
        dec: Angle.Degrees(-29.28186854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94956"},
        {"Hipparcos Number", "HIP 53561"},
        {"Geneva Identification System", "GEN# +1.00094956"},
        {"Smithsonian Astrophysical Observation", "SAO 179378"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.35000632),
        dec: Angle.Degrees(-29.28079460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91337"},
        {"Hipparcos Number", "HIP 51583"},
        {"Renson", "Renson 26280"},
        {"Smithsonian Astrophysical Observation", "SAO 178945"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.04107349),
        dec: Angle.Degrees(-29.27756583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207312"},
        {"Hipparcos Number", "HIP 107675"},
        {"Smithsonian Astrophysical Observation", "SAO 190642"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.819,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.17404775),
        dec: Angle.Degrees(-29.27702663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152618"},
        {"Hipparcos Number", "HIP 82821"},
        {"Smithsonian Astrophysical Observation", "SAO 184798"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.88462858),
        dec: Angle.Degrees(-29.27685303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168210"},
        {"Hipparcos Number", "HIP 89829"},
        {"Smithsonian Astrophysical Observation", "SAO 186657"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.96753065),
        dec: Angle.Degrees(-29.27567261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94537",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12184 AB"},
        {"Henry Draper", "HD 179613"},
        {"Hipparcos Number", "HIP 94537"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.61033360),
        dec: Angle.Degrees(-29.27379624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225200"},
        {"Hipparcos Number", "HIP 345"},
        {"Geneva Identification System", "GEN# +4.09010075"},
        {"Smithsonian Astrophysical Observation", "SAO 166031"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.08457463),
        dec: Angle.Degrees(-29.26883006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86283"},
        {"Hipparcos Number", "HIP 48764"},
        {"Smithsonian Astrophysical Observation", "SAO 178215"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.19647200),
        dec: Angle.Degrees(-29.26646614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63627",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8745 AB"},
        {"Henry Draper", "HD 113204"},
        {"Hipparcos Number", "HIP 63627"},
        {"Smithsonian Astrophysical Observation", "SAO 181335"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.60579169),
        dec: Angle.Degrees(-29.26553182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53"},
    },
    visualMagnitude: 10.96,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.14739023),
        dec: Angle.Degrees(-29.26338247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114964"},
        {"Hipparcos Number", "HIP 64594"},
        {"Smithsonian Astrophysical Observation", "SAO 181475"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.59836288),
        dec: Angle.Degrees(-29.26219125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56280",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8202 AB"},
        {"Aitken 2", "ADS 8202"},
        {"Hipparcos Number", "HIP 56280"},
        {"Geneva Identification System", "GEN# +1.00100287"},
    },
    visualMagnitude: 4.93,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.06840611),
        dec: Angle.Degrees(-29.26137351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 144.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34036"},
        {"Hipparcos Number", "HIP 24324"},
        {"Smithsonian Astrophysical Observation", "SAO 170203"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.29914844),
        dec: Angle.Degrees(-29.26034865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170142"},
        {"Hipparcos Number", "HIP 90596"},
        {"Smithsonian Astrophysical Observation", "SAO 186867"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.29969528),
        dec: Angle.Degrees(-29.25941911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9246"},
        {"Hipparcos Number", "HIP 7018"},
        {"Geneva Identification System", "GEN# +1.00009246"},
        {"Smithsonian Astrophysical Observation", "SAO 167094"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.60409150),
        dec: Angle.Degrees(-29.25940999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 220.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119101"},
        {"Hipparcos Number", "HIP 66818"},
        {"Geneva Identification System", "GEN# +1.00119101"},
        {"Smithsonian Astrophysical Observation", "SAO 181869"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.43302004),
        dec: Angle.Degrees(-29.25720631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159212"},
        {"Hipparcos Number", "HIP 86005"},
        {"Geneva Identification System", "GEN# +1.00159212"},
        {"Smithsonian Astrophysical Observation", "SAO 185518"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.66657582),
        dec: Angle.Degrees(-29.25582385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217583"},
        {"Hipparcos Number", "HIP 113732"},
        {"Smithsonian Astrophysical Observation", "SAO 191596"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.49692794),
        dec: Angle.Degrees(-29.25118602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38271",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38271"},
        {"Smithsonian Astrophysical Observation", "SAO 174644"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.61307123),
        dec: Angle.Degrees(-29.25107756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161489"},
        {"Hipparcos Number", "HIP 87038"},
        {"Smithsonian Astrophysical Observation", "SAO 185742"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.76554678),
        dec: Angle.Degrees(-29.24835538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203654"},
        {"Hipparcos Number", "HIP 105697"},
        {"Smithsonian Astrophysical Observation", "SAO 190300"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.10689563),
        dec: Angle.Degrees(-29.24686581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -202.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74498",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74498"},
        {"Smithsonian Astrophysical Observation", "SAO 183273"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.36437379),
        dec: Angle.Degrees(-29.24657679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2370",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2370"},
        {"Geneva Identification System", "GEN# +6.20035009"},
    },
    visualMagnitude: 12.22,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.56804795),
        dec: Angle.Degrees(-29.24375218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179695"},
        {"Hipparcos Number", "HIP 94558"},
        {"Smithsonian Astrophysical Observation", "SAO 187865"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.66602698),
        dec: Angle.Degrees(-29.24314959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146237"},
        {"Hipparcos Number", "HIP 79722"},
        {"Geneva Identification System", "GEN# +1.00146237"},
        {"Smithsonian Astrophysical Observation", "SAO 184272"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.826,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.06299284),
        dec: Angle.Degrees(-29.24234598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67887"},
        {"Hipparcos Number", "HIP 39902"},
        {"Geneva Identification System", "GEN# +1.00067887"},
        {"Smithsonian Astrophysical Observation", "SAO 175266"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.24703826),
        dec: Angle.Degrees(-29.24171020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24714"},
        {"Hipparcos Number", "HIP 18291"},
        {"Smithsonian Astrophysical Observation", "SAO 168943"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.67684337),
        dec: Angle.Degrees(-29.24052855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19140"},
        {"Hipparcos Number", "HIP 14247"},
        {"Smithsonian Astrophysical Observation", "SAO 168271"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.94084575),
        dec: Angle.Degrees(-29.24030075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95064"},
        {"Hipparcos Number", "HIP 53617"},
        {"Smithsonian Astrophysical Observation", "SAO 179385"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.54411575),
        dec: Angle.Degrees(-29.23987142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69577",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9171 A"},
        {"Henry Draper", "HD 124464"},
        {"Hipparcos Number", "HIP 69577"},
        {"Smithsonian Astrophysical Observation", "SAO 182362"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.62719478),
        dec: Angle.Degrees(-29.23917347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106584"},
        {"Hipparcos Number", "HIP 59790"},
        {"Smithsonian Astrophysical Observation", "SAO 180612"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.89554935),
        dec: Angle.Degrees(-29.23846241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171628"},
        {"Hipparcos Number", "HIP 91282"},
        {"Geneva Identification System", "GEN# +1.00171628"},
        {"Smithsonian Astrophysical Observation", "SAO 187050"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.29217202),
        dec: Angle.Degrees(-29.23736060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48629"},
        {"Hipparcos Number", "HIP 32175"},
        {"Celescope Catalog", "CEL 1364"},
        {"Fundamental Katalog 5th Edition", "FK5 4611"},
        {"Geneva Identification System", "GEN# +1.00048629"},
        {"Smithsonian Astrophysical Observation", "SAO 172224"},
    },
    visualMagnitude: 7.28,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.77520477),
        dec: Angle.Degrees(-29.23733560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106500"},
        {"Hipparcos Number", "HIP 59742"},
        {"Smithsonian Astrophysical Observation", "SAO 180604"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.77674609),
        dec: Angle.Degrees(-29.23719253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25333"},
        {"Hipparcos Number", "HIP 18703"},
        {"Geneva Identification System", "GEN# +1.00025333"},
        {"Smithsonian Astrophysical Observation", "SAO 169027"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.10178712),
        dec: Angle.Degrees(-29.23492855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69579",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9171 BC"},
        {"Henry Draper", "HD 124465"},
        {"Hipparcos Number", "HIP 69579"},
        {"Smithsonian Astrophysical Observation", "SAO 182363"},
    },
    visualMagnitude: 8.56,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.62883583),
        dec: Angle.Degrees(-29.23442213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 315809"},
        {"Hipparcos Number", "HIP 85396"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.75609288),
        dec: Angle.Degrees(-29.23216254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206109"},
        {"Hipparcos Number", "HIP 107023"},
        {"Smithsonian Astrophysical Observation", "SAO 190540"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.13181431),
        dec: Angle.Degrees(-29.23140125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162908"},
        {"Hipparcos Number", "HIP 87690"},
        {"Smithsonian Astrophysical Observation", "SAO 185919"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.66253309),
        dec: Angle.Degrees(-29.22800083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73696",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73696"},
        {"Smithsonian Astrophysical Observation", "SAO 183133"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.95144606),
        dec: Angle.Degrees(-29.22759199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99750",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99750"},
        {"Smithsonian Astrophysical Observation", "SAO 189052"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.59166816),
        dec: Angle.Degrees(-29.22739644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139612"},
        {"Hipparcos Number", "HIP 76728"},
        {"Geneva Identification System", "GEN# +1.00139612"},
        {"Smithsonian Astrophysical Observation", "SAO 183680"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.02785176),
        dec: Angle.Degrees(-29.22448120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135970"},
        {"Hipparcos Number", "HIP 74949"},
        {"Smithsonian Astrophysical Observation", "SAO 183366"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.73216934),
        dec: Angle.Degrees(-29.22134142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117904",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117904"},
    },
    visualMagnitude: 11.54,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.72239109),
        dec: Angle.Degrees(-29.21996788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45834",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7318 AB"},
        {"Henry Draper", "HD 80752"},
        {"Hipparcos Number", "HIP 45834"},
        {"Smithsonian Astrophysical Observation", "SAO 177308"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.17594212),
        dec: Angle.Degrees(-29.21980676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33525"},
        {"Hipparcos Number", "HIP 23999"},
        {"Smithsonian Astrophysical Observation", "SAO 170132"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.39400753),
        dec: Angle.Degrees(-29.21907652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71523"},
        {"Hipparcos Number", "HIP 41413"},
        {"Geneva Identification System", "GEN# +1.00071523"},
        {"Smithsonian Astrophysical Observation", "SAO 175851"},
    },
    visualMagnitude: 6.73,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.71153036),
        dec: Angle.Degrees(-29.21564943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56478",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56478"},
        {"Smithsonian Astrophysical Observation", "SAO 180001"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.68383618),
        dec: Angle.Degrees(-29.21496957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78104",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Iklil"},
        {"Aitken", "ADS 9846 A"},
        {"Henry Draper", "HD 142669"},
        {"Hipparcos Number", "HIP 78104"},
        {"Fundamental Katalog 5th Edition", "FK5 3258"},
        {"Geneva Identification System", "GEN# +1.00142669"},
        {"Smithsonian Astrophysical Observation", "SAO 183957"},
        {"Wilson Evans Batten Catalogue", "WEB 13209"},
    },
    visualMagnitude: 3.87,
    bvColour: -0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.22119438),
        dec: Angle.Degrees(-29.21401221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28055"},
        {"Hipparcos Number", "HIP 20583"},
        {"Smithsonian Astrophysical Observation", "SAO 169417"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.13361045),
        dec: Angle.Degrees(-29.21389921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175193"},
        {"Hipparcos Number", "HIP 92870"},
        {"Geneva Identification System", "GEN# +1.00175193"},
        {"Smithsonian Astrophysical Observation", "SAO 187452"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.85799250),
        dec: Angle.Degrees(-29.21310295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7703"},
        {"Hipparcos Number", "HIP 5940"},
        {"Smithsonian Astrophysical Observation", "SAO 166920"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.10581631),
        dec: Angle.Degrees(-29.21281611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224515"},
        {"Hipparcos Number", "HIP 118202"},
        {"Smithsonian Astrophysical Observation", "SAO 192279"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.64020020),
        dec: Angle.Degrees(-29.21035167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46680"},
        {"Hipparcos Number", "HIP 31271"},
        {"Smithsonian Astrophysical Observation", "SAO 171945"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.36637717),
        dec: Angle.Degrees(-29.20987507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3218"},
        {"Hipparcos Number", "HIP 2766"},
        {"Smithsonian Astrophysical Observation", "SAO 166384"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.81650444),
        dec: Angle.Degrees(-29.20968604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40825"},
        {"Hipparcos Number", "HIP 28412"},
        {"Geneva Identification System", "GEN# +1.00040825"},
        {"Smithsonian Astrophysical Observation", "SAO 171114"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.01143345),
        dec: Angle.Degrees(-29.20619026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35071"},
        {"Hipparcos Number", "HIP 24961"},
        {"Fundamental Katalog 5th Edition", "FK5 4485"},
        {"Smithsonian Astrophysical Observation", "SAO 170336"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.18542812),
        dec: Angle.Degrees(-29.20610768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29135"},
        {"Hipparcos Number", "HIP 21288"},
        {"Smithsonian Astrophysical Observation", "SAO 169575"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.51089150),
        dec: Angle.Degrees(-29.20413308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196762"},
        {"Hipparcos Number", "HIP 102020"},
        {"Smithsonian Astrophysical Observation", "SAO 189553"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.10599281),
        dec: Angle.Degrees(-29.19885611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100288",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13702 AB"},
        {"Aitken 2", "ADS 13702 A"},
        {"Henry Draper", "HD 193281"},
        {"Hipparcos Number", "HIP 100288"},
        {"Geneva Identification System", "GEN# +1.00193281"},
        {"Smithsonian Astrophysical Observation", "SAO 189164"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.11616874),
        dec: Angle.Degrees(-29.19721586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28388"},
        {"Hipparcos Number", "HIP 20802"},
        {"Geneva Identification System", "GEN# +1.00028388"},
        {"Smithsonian Astrophysical Observation", "SAO 169470"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.86068100),
        dec: Angle.Degrees(-29.19693139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101563"},
        {"Hipparcos Number", "HIP 57001"},
        {"Geneva Identification System", "GEN# +1.00101563"},
        {"Smithsonian Astrophysical Observation", "SAO 180098"},
        {"Wilson Evans Batten Catalogue", "WEB 10262"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.28584703),
        dec: Angle.Degrees(-29.19682236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -305.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 225.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90366"},
        {"Hipparcos Number", "HIP 51021"},
        {"Smithsonian Astrophysical Observation", "SAO 178801"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.34899492),
        dec: Angle.Degrees(-29.19385294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76448",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76448"},
        {"Smithsonian Astrophysical Observation", "SAO 183614"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.19794004),
        dec: Angle.Degrees(-29.19308484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100286",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13702 C"},
        {"Henry Draper", "HD 193256"},
        {"Hipparcos Number", "HIP 100286"},
        {"Geneva Identification System", "GEN# +1.00193256"},
        {"Smithsonian Astrophysical Observation", "SAO 189163"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.11063650),
        dec: Angle.Degrees(-29.19098691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61759"},
        {"Hipparcos Number", "HIP 37315"},
        {"Smithsonian Astrophysical Observation", "SAO 174230"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.91277809),
        dec: Angle.Degrees(-29.19097874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20790",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20790"},
        {"Geneva Identification System", "GEN# -0.02901725"},
        {"Smithsonian Astrophysical Observation", "SAO 169464"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.82346475),
        dec: Angle.Degrees(-29.19089397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44362",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44362"},
        {"Smithsonian Astrophysical Observation", "SAO 176850"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.51141718),
        dec: Angle.Degrees(-29.19077759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142406"},
        {"Hipparcos Number", "HIP 77988"},
        {"Smithsonian Astrophysical Observation", "SAO 183930"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.88298637),
        dec: Angle.Degrees(-29.19033384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170747"},
        {"Hipparcos Number", "HIP 90874"},
        {"Geneva Identification System", "GEN# +1.00170747"},
        {"Smithsonian Astrophysical Observation", "SAO 186932"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.05837329),
        dec: Angle.Degrees(-29.19021287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188378"},
        {"Hipparcos Number", "HIP 98077"},
        {"Wilson Evans Batten Catalogue", "WEB 17280"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.98519025),
        dec: Angle.Degrees(-29.19001454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7999"},
        {"Hipparcos Number", "HIP 6157"},
        {"Geneva Identification System", "GEN# +1.00007999"},
        {"Smithsonian Astrophysical Observation", "SAO 166952"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.74176946),
        dec: Angle.Degrees(-29.18838055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104893"},
        {"Hipparcos Number", "HIP 58896"},
        {"Geneva Identification System", "GEN# +1.00104893"},
        {"Smithsonian Astrophysical Observation", "SAO 180433"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.17978734),
        dec: Angle.Degrees(-29.18475900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107420"},
        {"Hipparcos Number", "HIP 60227"},
        {"Smithsonian Astrophysical Observation", "SAO 180707"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.25718358),
        dec: Angle.Degrees(-29.18375288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40480"},
        {"Hipparcos Number", "HIP 28221"},
        {"Smithsonian Astrophysical Observation", "SAO 171076"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.44498333),
        dec: Angle.Degrees(-29.18313443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55836"},
        {"Hipparcos Number", "HIP 34917"},
        {"Smithsonian Astrophysical Observation", "SAO 173237"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.36548627),
        dec: Angle.Degrees(-29.18237519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216361"},
        {"Hipparcos Number", "HIP 112971"},
        {"Geneva Identification System", "GEN# +1.00216361"},
        {"Smithsonian Astrophysical Observation", "SAO 191460"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.17564024),
        dec: Angle.Degrees(-29.18163668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140673"},
        {"Hipparcos Number", "HIP 77220"},
        {"Smithsonian Astrophysical Observation", "SAO 183768"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.49892041),
        dec: Angle.Degrees(-29.18091638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81378"},
        {"Hipparcos Number", "HIP 46127"},
        {"Smithsonian Astrophysical Observation", "SAO 177403"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.09520536),
        dec: Angle.Degrees(-29.18072722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99185"},
        {"Hipparcos Number", "HIP 55689"},
        {"Smithsonian Astrophysical Observation", "SAO 179852"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.16274876),
        dec: Angle.Degrees(-29.17986003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25468"},
        {"Hipparcos Number", "HIP 18798"},
        {"Smithsonian Astrophysical Observation", "SAO 169044"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.41512873),
        dec: Angle.Degrees(-29.17831564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111651"},
        {"Hipparcos Number", "HIP 62713"},
        {"Geneva Identification System", "GEN# +1.00111651"},
        {"Smithsonian Astrophysical Observation", "SAO 181155"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.77669524),
        dec: Angle.Degrees(-29.17740848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81140",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81140"},
    },
    visualMagnitude: 11.34,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.57864133),
        dec: Angle.Degrees(-29.17526339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -169.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -189.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97512",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97512"},
    },
    visualMagnitude: 11.56,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.29533880),
        dec: Angle.Degrees(-29.17428418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 204.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -182.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75286",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9611 AB"},
        {"Henry Draper", "HD 136663"},
        {"Hipparcos Number", "HIP 75286"},
        {"Smithsonian Astrophysical Observation", "SAO 183421"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.72743650),
        dec: Angle.Degrees(-29.17342605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66789"},
        {"Hipparcos Number", "HIP 39473"},
        {"Geneva Identification System", "GEN# +1.00066789"},
        {"Smithsonian Astrophysical Observation", "SAO 175099"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.02037764),
        dec: Angle.Degrees(-29.17330360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115009",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115009"},
        {"Smithsonian Astrophysical Observation", "SAO 191796"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.40288626),
        dec: Angle.Degrees(-29.17216277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203242"},
        {"Hipparcos Number", "HIP 105476"},
        {"Fundamental Katalog 5th Edition", "FK5 5883"},
        {"Smithsonian Astrophysical Observation", "SAO 190261"},
    },
    visualMagnitude: 6.53,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.45454870),
        dec: Angle.Degrees(-29.16601809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84304"},
        {"Hipparcos Number", "HIP 47715"},
        {"Smithsonian Astrophysical Observation", "SAO 177899"},
    },
    visualMagnitude: 9.02,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.91440069),
        dec: Angle.Degrees(-29.16425230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19987"},
        {"Hipparcos Number", "HIP 14851"},
        {"Geneva Identification System", "GEN# +1.00019987"},
        {"Smithsonian Astrophysical Observation", "SAO 168368"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.95451399),
        dec: Angle.Degrees(-29.16266791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177736"},
        {"Hipparcos Number", "HIP 93877"},
        {"Smithsonian Astrophysical Observation", "SAO 187685"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.77691340),
        dec: Angle.Degrees(-29.16081039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95196"},
        {"Hipparcos Number", "HIP 53696"},
        {"Smithsonian Astrophysical Observation", "SAO 179400"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.79227766),
        dec: Angle.Degrees(-29.15982288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186853"},
        {"Hipparcos Number", "HIP 97405"},
        {"Geneva Identification System", "GEN# +1.00186853"},
        {"Smithsonian Astrophysical Observation", "SAO 188572"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.96320454),
        dec: Angle.Degrees(-29.15933342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215421"},
        {"Hipparcos Number", "HIP 112353"},
        {"Smithsonian Astrophysical Observation", "SAO 191379"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.36343913),
        dec: Angle.Degrees(-29.15812318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131919"},
        {"Hipparcos Number", "HIP 73171"},
        {"Geneva Identification System", "GEN# +1.00131919"},
        {"Smithsonian Astrophysical Observation", "SAO 183030"},
        {"Wilson Evans Batten Catalogue", "WEB 12537"},
    },
    visualMagnitude: 6.28,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.30716730),
        dec: Angle.Degrees(-29.15760702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69375"},
        {"Hipparcos Number", "HIP 40464"},
        {"Smithsonian Astrophysical Observation", "SAO 175469"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.92713343),
        dec: Angle.Degrees(-29.15694174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59256"},
        {"Hipparcos Number", "HIP 36258"},
        {"Celescope Catalog", "CEL 1868"},
        {"Geneva Identification System", "GEN# +1.00059256"},
        {"Renson", "Renson 16180"},
        {"Smithsonian Astrophysical Observation", "SAO 173799"},
        {"Wilson Evans Batten Catalogue", "WEB 7224"},
    },
    visualMagnitude: 5.55,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.99653073),
        dec: Angle.Degrees(-29.15590180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36619",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36619"},
        {"Smithsonian Astrophysical Observation", "SAO 173936"},
    },
    visualMagnitude: 9.50,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.95737028),
        dec: Angle.Degrees(-29.15460497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25962"},
        {"Hipparcos Number", "HIP 19100"},
        {"Smithsonian Astrophysical Observation", "SAO 169112"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.42058880),
        dec: Angle.Degrees(-29.15453679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193747"},
        {"Hipparcos Number", "HIP 100517"},
        {"Geneva Identification System", "GEN# +1.00193747"},
        {"Smithsonian Astrophysical Observation", "SAO 189213"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.73586799),
        dec: Angle.Degrees(-29.15208688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141"},
        {"Hipparcos Number", "HIP 512"},
        {"Fundamental Katalog 5th Edition", "FK5 4011"},
        {"Geneva Identification System", "GEN# +4.09010111"},
        {"Smithsonian Astrophysical Observation", "SAO 166043"},
        {"Wilson Evans Batten Catalogue", "WEB 84"},
    },
    visualMagnitude: 7.90,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.53776681),
        dec: Angle.Degrees(-29.15139035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44642"},
        {"Hipparcos Number", "HIP 30223"},
        {"Geneva Identification System", "GEN# +1.00044642"},
        {"Smithsonian Astrophysical Observation", "SAO 171623"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.37995353),
        dec: Angle.Degrees(-29.15073316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200419"},
        {"Hipparcos Number", "HIP 103994"},
        {"Geneva Identification System", "GEN# +1.00200419"},
        {"Smithsonian Astrophysical Observation", "SAO 189981"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.04968205),
        dec: Angle.Degrees(-29.14841099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159255"},
        {"Hipparcos Number", "HIP 86030"},
        {"Geneva Identification System", "GEN# +1.00159255"},
        {"Smithsonian Astrophysical Observation", "SAO 185521"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.72607119),
        dec: Angle.Degrees(-29.14721616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85003",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85003"},
        {"Smithsonian Astrophysical Observation", "SAO 185329"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.61113014),
        dec: Angle.Degrees(-29.14716697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39891"},
        {"Hipparcos Number", "HIP 27901"},
        {"Geneva Identification System", "GEN# +1.00039891J"},
        {"Smithsonian Astrophysical Observation", "SAO 170993"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.55852070),
        dec: Angle.Degrees(-29.14710228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190527"},
        {"Hipparcos Number", "HIP 99030"},
        {"Smithsonian Astrophysical Observation", "SAO 188912"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.57564027),
        dec: Angle.Degrees(-29.14535521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15214"},
        {"Hipparcos Number", "HIP 11363"},
        {"Smithsonian Astrophysical Observation", "SAO 167793"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.58561593),
        dec: Angle.Degrees(-29.14260976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100317"},
        {"Hipparcos Number", "HIP 56300"},
        {"Smithsonian Astrophysical Observation", "SAO 179972"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.13167163),
        dec: Angle.Degrees(-29.14188763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316856"},
        {"Hipparcos Number", "HIP 88001"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.63431724),
        dec: Angle.Degrees(-29.14178696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118812"},
        {"Hipparcos Number", "HIP 66648"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.93594936),
        dec: Angle.Degrees(-29.14079054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -344.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40125"},
        {"Hipparcos Number", "HIP 28031"},
        {"Geneva Identification System", "GEN# +1.00040125"},
        {"Smithsonian Astrophysical Observation", "SAO 171021"},
        {"Wilson Evans Batten Catalogue", "WEB 5490"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.91348147),
        dec: Angle.Degrees(-29.13751459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4530"},
        {"Hipparcos Number", "HIP 3682"},
        {"Geneva Identification System", "GEN# +1.00004530"},
        {"Smithsonian Astrophysical Observation", "SAO 166571"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.78054110),
        dec: Angle.Degrees(-29.13641028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78575",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9896 A"},
        {"Henry Draper", "HD 143619"},
        {"Hipparcos Number", "HIP 78575"},
        {"Geneva Identification System", "GEN# +1.00143619"},
        {"Smithsonian Astrophysical Observation", "SAO 184049"},
    },
    visualMagnitude: 6.07,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.66416321),
        dec: Angle.Degrees(-29.13577664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123812"},
        {"Hipparcos Number", "HIP 69237"},
        {"Geneva Identification System", "GEN# +1.00123812"},
        {"Smithsonian Astrophysical Observation", "SAO 182309"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.61967952),
        dec: Angle.Degrees(-29.13391854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93786"},
        {"Hipparcos Number", "HIP 52907"},
        {"Smithsonian Astrophysical Observation", "SAO 179254"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.30677221),
        dec: Angle.Degrees(-29.13259927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -157.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69757"},
        {"Hipparcos Number", "HIP 40607"},
        {"Smithsonian Astrophysical Observation", "SAO 175521"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.36132499),
        dec: Angle.Degrees(-29.13222266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6350",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6350"},
        {"Smithsonian Astrophysical Observation", "SAO 166984"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.38723602),
        dec: Angle.Degrees(-29.13128826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56809"},
        {"Hipparcos Number", "HIP 35286"},
        {"Geneva Identification System", "GEN# +1.00056809"},
        {"Renson", "Renson 15480"},
        {"Smithsonian Astrophysical Observation", "SAO 173396"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.34330901),
        dec: Angle.Degrees(-29.13109384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193244"},
        {"Hipparcos Number", "HIP 100267"},
        {"Smithsonian Astrophysical Observation", "SAO 189160"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.06148039),
        dec: Angle.Degrees(-29.13103433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65589"},
        {"Hipparcos Number", "HIP 38965"},
        {"Smithsonian Astrophysical Observation", "SAO 174904"},
        {"Wilson Evans Batten Catalogue", "WEB 7641"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.59204362),
        dec: Angle.Degrees(-29.13010028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14441",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14441"},
    },
    visualMagnitude: 11.45,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.60489135),
        dec: Angle.Degrees(-29.12918779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102847"},
        {"Hipparcos Number", "HIP 57727"},
        {"Smithsonian Astrophysical Observation", "SAO 180227"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.57524385),
        dec: Angle.Degrees(-29.12871488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21137"},
        {"Hipparcos Number", "HIP 15815"},
        {"Smithsonian Astrophysical Observation", "SAO 168508"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.93474910),
        dec: Angle.Degrees(-29.12691024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80705"},
        {"Hipparcos Number", "HIP 45805"},
        {"Smithsonian Astrophysical Observation", "SAO 177304"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.10966452),
        dec: Angle.Degrees(-29.12674675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105225"},
        {"Hipparcos Number", "HIP 59076"},
        {"Geneva Identification System", "GEN# +1.00105225"},
        {"Smithsonian Astrophysical Observation", "SAO 180474"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.72497149),
        dec: Angle.Degrees(-29.12603827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150437"},
        {"Hipparcos Number", "HIP 81767"},
        {"Geneva Identification System", "GEN# +1.00150437"},
        {"Smithsonian Astrophysical Observation", "SAO 184553"},
        {"Wilson Evans Batten Catalogue", "WEB 13820"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.53034874),
        dec: Angle.Degrees(-29.12475163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95472",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95472"},
    },
    visualMagnitude: 10.60,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.29994126),
        dec: Angle.Degrees(-29.12378428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151561"},
        {"Hipparcos Number", "HIP 82326"},
        {"Smithsonian Astrophysical Observation", "SAO 184669"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.31629831),
        dec: Angle.Degrees(-29.12223032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8919",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8919"},
        {"Smithsonian Astrophysical Observation", "SAO 167388"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.70885967),
        dec: Angle.Degrees(-29.11961962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87685"},
        {"Hipparcos Number", "HIP 49476"},
        {"Smithsonian Astrophysical Observation", "SAO 178405"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.52294110),
        dec: Angle.Degrees(-29.11880362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59411"},
        {"Hipparcos Number", "HIP 36328"},
        {"Smithsonian Astrophysical Observation", "SAO 173829"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.17100056),
        dec: Angle.Degrees(-29.11862273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316224"},
        {"Hipparcos Number", "HIP 86911"},
        {"Geneva Identification System", "GEN# +1.00316224"},
        {"Smithsonian Astrophysical Observation", "SAO 185702"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.37501904),
        dec: Angle.Degrees(-29.11782017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115884",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115884"},
        {"Smithsonian Astrophysical Observation", "SAO 191936"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.18071027),
        dec: Angle.Degrees(-29.11760104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 152.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208573"},
        {"Hipparcos Number", "HIP 108416"},
        {"Geneva Identification System", "GEN# +1.00208573"},
        {"Smithsonian Astrophysical Observation", "SAO 190774"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.45508609),
        dec: Angle.Degrees(-29.11602653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11854"},
        {"Hipparcos Number", "HIP 8990"},
        {"Smithsonian Astrophysical Observation", "SAO 167404"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.95751119),
        dec: Angle.Degrees(-29.11389795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186402"},
        {"Hipparcos Number", "HIP 97191"},
        {"Geneva Identification System", "GEN# +1.00186402"},
        {"Smithsonian Astrophysical Observation", "SAO 188522"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.30412676),
        dec: Angle.Degrees(-29.11354722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126933"},
        {"Hipparcos Number", "HIP 70839"},
        {"Geneva Identification System", "GEN# +1.00126933"},
        {"Smithsonian Astrophysical Observation", "SAO 182587"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.29106625),
        dec: Angle.Degrees(-29.11353861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195206"},
        {"Hipparcos Number", "HIP 101211"},
        {"Geneva Identification System", "GEN# +1.00195206"},
        {"Smithsonian Astrophysical Observation", "SAO 189374"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.73663000),
        dec: Angle.Degrees(-29.11265034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128279"},
        {"Hipparcos Number", "HIP 71458"},
        {"Geneva Identification System", "GEN# +1.00128279"},
        {"Smithsonian Astrophysical Observation", "SAO 182701"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.20194951),
        dec: Angle.Degrees(-29.11211938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -344.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39352"},
        {"Hipparcos Number", "HIP 27609"},
        {"Smithsonian Astrophysical Observation", "SAO 170914"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.68851597),
        dec: Angle.Degrees(-29.11127384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 162.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51716",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51716"},
        {"Smithsonian Astrophysical Observation", "SAO 118366"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.49647847),
        dec: Angle.Degrees(+01.32778322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200199"},
        {"Hipparcos Number", "HIP 103880"},
        {"Renson", "Renson 55760"},
        {"Smithsonian Astrophysical Observation", "SAO 189963"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.73536967),
        dec: Angle.Degrees(-29.11033771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5568",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5568"},
        {"Smithsonian Astrophysical Observation", "SAO 166858"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.85667160),
        dec: Angle.Degrees(-29.10804481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210950"},
        {"Hipparcos Number", "HIP 109804"},
        {"Smithsonian Astrophysical Observation", "SAO 190987"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.60345048),
        dec: Angle.Degrees(-29.10288470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22894"},
        {"Hipparcos Number", "HIP 17074"},
        {"Smithsonian Astrophysical Observation", "SAO 168717"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.88593314),
        dec: Angle.Degrees(-29.10220377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200953"},
        {"Hipparcos Number", "HIP 104277"},
        {"Smithsonian Astrophysical Observation", "SAO 190030"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.87634658),
        dec: Angle.Degrees(-29.10142986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64480",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8818 AB"},
        {"Henry Draper", "HD 114769"},
        {"Hipparcos Number", "HIP 64480"},
        {"Renson", "Renson 33210"},
        {"Smithsonian Astrophysical Observation", "SAO 181460"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.24556083),
        dec: Angle.Degrees(-29.09998239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26728"},
        {"Hipparcos Number", "HIP 19638"},
        {"Geneva Identification System", "GEN# +1.00026728"},
        {"Smithsonian Astrophysical Observation", "SAO 169219"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.12250990),
        dec: Angle.Degrees(-29.09997954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125066"},
        {"Hipparcos Number", "HIP 69869"},
        {"Smithsonian Astrophysical Observation", "SAO 182424"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.46833467),
        dec: Angle.Degrees(-29.09897965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92135"},
        {"Hipparcos Number", "HIP 52025"},
        {"Smithsonian Astrophysical Observation", "SAO 179051"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.44012895),
        dec: Angle.Degrees(-29.09765021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188298"},
        {"Hipparcos Number", "HIP 98049"},
        {"Geneva Identification System", "GEN# +1.00188298"},
        {"Smithsonian Astrophysical Observation", "SAO 188716"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.87431508),
        dec: Angle.Degrees(-29.09695751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77218"},
        {"Hipparcos Number", "HIP 44196"},
        {"Smithsonian Astrophysical Observation", "SAO 176812"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.04124222),
        dec: Angle.Degrees(-29.09414194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160572"},
        {"Hipparcos Number", "HIP 86619"},
        {"Smithsonian Astrophysical Observation", "SAO 185626"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.49135362),
        dec: Angle.Degrees(-29.09257527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15261"},
        {"Hipparcos Number", "HIP 11383"},
        {"Geneva Identification System", "GEN# +1.00015261"},
        {"Smithsonian Astrophysical Observation", "SAO 167796"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.66420933),
        dec: Angle.Degrees(-29.09219466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121271"},
        {"Hipparcos Number", "HIP 67960"},
        {"Geneva Identification System", "GEN# +1.00121271"},
        {"Smithsonian Astrophysical Observation", "SAO 182074"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.76142092),
        dec: Angle.Degrees(-29.09028601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -276.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188737"},
        {"Hipparcos Number", "HIP 98225"},
        {"Smithsonian Astrophysical Observation", "SAO 188755"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.41716841),
        dec: Angle.Degrees(-29.08376349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107414",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107414"},
        {"Smithsonian Astrophysical Observation", "SAO 190601"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.34460502),
        dec: Angle.Degrees(-29.08283468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73879"},
        {"Hipparcos Number", "HIP 42482"},
        {"Smithsonian Astrophysical Observation", "SAO 176249"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.92038789),
        dec: Angle.Degrees(-29.08260659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212617"},
        {"Hipparcos Number", "HIP 110743"},
        {"Geneva Identification System", "GEN# +1.00212617"},
        {"Smithsonian Astrophysical Observation", "SAO 191138"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.54042827),
        dec: Angle.Degrees(-29.08216475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120455"},
        {"Hipparcos Number", "HIP 67523"},
        {"Fundamental Katalog 5th Edition", "FK5 3097"},
        {"Geneva Identification System", "GEN# +1.00120455"},
        {"Smithsonian Astrophysical Observation", "SAO 181999"},
        {"Wilson Evans Batten Catalogue", "WEB 11874"},
    },
    visualMagnitude: 6.19,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.52725777),
        dec: Angle.Degrees(-29.08124029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177427"},
        {"Hipparcos Number", "HIP 93769"},
        {"Geneva Identification System", "GEN# +1.00177427"},
        {"Smithsonian Astrophysical Observation", "SAO 187661"},
    },
    visualMagnitude: 7.09,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.44543275),
        dec: Angle.Degrees(-29.08110923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316319"},
        {"Hipparcos Number", "HIP 86948"},
        {"Smithsonian Astrophysical Observation", "SAO 185715"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.50383753),
        dec: Angle.Degrees(-29.08084822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190305"},
        {"Hipparcos Number", "HIP 98942"},
        {"Geneva Identification System", "GEN# +1.00190305"},
        {"Smithsonian Astrophysical Observation", "SAO 188895"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.33138203),
        dec: Angle.Degrees(-29.07933112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213095"},
        {"Hipparcos Number", "HIP 111019"},
        {"Smithsonian Astrophysical Observation", "SAO 191179"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.37870064),
        dec: Angle.Degrees(-29.07929096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39732",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39732"},
        {"Geneva Identification System", "GEN# -0.02805472"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.82183117),
        dec: Angle.Degrees(-29.07811256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194086"},
        {"Hipparcos Number", "HIP 100674"},
        {"Smithsonian Astrophysical Observation", "SAO 189251"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.17786828),
        dec: Angle.Degrees(-29.07771110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92363",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11702 AB"},
        {"Henry Draper", "HD 173967"},
        {"Hipparcos Number", "HIP 92363"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.35986970),
        dec: Angle.Degrees(-29.07764564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 212",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 212"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.66344190),
        dec: Angle.Degrees(-29.07525103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135188"},
        {"Hipparcos Number", "HIP 74612"},
        {"Geneva Identification System", "GEN# +1.00135188"},
        {"Smithsonian Astrophysical Observation", "SAO 183301"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.846,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.67409996),
        dec: Angle.Degrees(-29.07503839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165383"},
        {"Hipparcos Number", "HIP 88738"},
        {"Smithsonian Astrophysical Observation", "SAO 186288"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.73095166),
        dec: Angle.Degrees(-29.07471942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3000"},
        {"Hipparcos Number", "HIP 2601"},
        {"Geneva Identification System", "GEN# +1.00003000"},
        {"Smithsonian Astrophysical Observation", "SAO 166354"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.26035878),
        dec: Angle.Degrees(-29.07422762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194432"},
        {"Hipparcos Number", "HIP 100819"},
        {"Smithsonian Astrophysical Observation", "SAO 189281"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.63643334),
        dec: Angle.Degrees(-29.07379587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222711"},
        {"Hipparcos Number", "HIP 117006"},
        {"Geneva Identification System", "GEN# +1.00222711"},
        {"Smithsonian Astrophysical Observation", "SAO 192103"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.79523845),
        dec: Angle.Degrees(-29.07362179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203476"},
        {"Hipparcos Number", "HIP 105593"},
        {"Smithsonian Astrophysical Observation", "SAO 190289"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.81426630),
        dec: Angle.Degrees(-29.07350220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54282",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54282"},
        {"Smithsonian Astrophysical Observation", "SAO 179533"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.56605907),
        dec: Angle.Degrees(-29.07275537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209741"},
        {"Hipparcos Number", "HIP 109125"},
        {"Smithsonian Astrophysical Observation", "SAO 190886"},
    },
    visualMagnitude: 7.59,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.55639742),
        dec: Angle.Degrees(-29.07092164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199162"},
        {"Hipparcos Number", "HIP 103344"},
        {"Smithsonian Astrophysical Observation", "SAO 189850"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.05424584),
        dec: Angle.Degrees(-29.07084145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126311"},
        {"Hipparcos Number", "HIP 70511"},
        {"Smithsonian Astrophysical Observation", "SAO 182526"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.35647256),
        dec: Angle.Degrees(-29.07060990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53889"},
        {"Hipparcos Number", "HIP 34195"},
        {"Smithsonian Astrophysical Observation", "SAO 172938"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.37174751),
        dec: Angle.Degrees(-29.06945148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69234"},
        {"Hipparcos Number", "HIP 40414"},
        {"Smithsonian Astrophysical Observation", "SAO 175452"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.75372466),
        dec: Angle.Degrees(-29.06781005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9338"},
        {"Hipparcos Number", "HIP 7096"},
        {"Smithsonian Astrophysical Observation", "SAO 167108"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.87019534),
        dec: Angle.Degrees(-29.06606083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108337"},
        {"Hipparcos Number", "HIP 60740"},
        {"Smithsonian Astrophysical Observation", "SAO 180803"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.72999006),
        dec: Angle.Degrees(-29.06531889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92945"},
        {"Hipparcos Number", "HIP 52462"},
        {"Geneva Identification System", "GEN# +1.00092945"},
        {"Smithsonian Astrophysical Observation", "SAO 179168"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.86839787),
        dec: Angle.Degrees(-29.06416571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -215.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217391"},
        {"Hipparcos Number", "HIP 113616"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.16960435),
        dec: Angle.Degrees(-29.06411324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105329"},
        {"Hipparcos Number", "HIP 59140"},
        {"Smithsonian Astrophysical Observation", "SAO 180487"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.90347594),
        dec: Angle.Degrees(-29.06276507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122775"},
        {"Hipparcos Number", "HIP 68760"},
        {"Geneva Identification System", "GEN# +1.00122775"},
        {"Smithsonian Astrophysical Observation", "SAO 182215"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.11084207),
        dec: Angle.Degrees(-29.06274986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116900"},
        {"Hipparcos Number", "HIP 65610"},
        {"Smithsonian Astrophysical Observation", "SAO 181666"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.79027775),
        dec: Angle.Degrees(-29.06239650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30395"},
        {"Hipparcos Number", "HIP 22162"},
        {"Geneva Identification System", "GEN# +1.00030395"},
        {"Smithsonian Astrophysical Observation", "SAO 169747"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.52414051),
        dec: Angle.Degrees(-29.06218204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 134.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12294"},
        {"Hipparcos Number", "HIP 9348"},
        {"Fundamental Katalog 5th Edition", "FK5 4180"},
        {"Geneva Identification System", "GEN# +1.00012294"},
        {"Smithsonian Astrophysical Observation", "SAO 167474"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.00332113),
        dec: Angle.Degrees(-29.06032562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158088"},
        {"Hipparcos Number", "HIP 85507"},
        {"Fundamental Katalog 5th Edition", "FK5 5537"},
        {"Geneva Identification System", "GEN# +1.00158088"},
        {"Smithsonian Astrophysical Observation", "SAO 185429"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.851,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.11489672),
        dec: Angle.Degrees(-29.05858082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145736"},
        {"Hipparcos Number", "HIP 79520"},
        {"Geneva Identification System", "GEN# +1.00145736"},
        {"Smithsonian Astrophysical Observation", "SAO 184234"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.40946770),
        dec: Angle.Degrees(-29.05682446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208810"},
        {"Hipparcos Number", "HIP 108565"},
        {"Smithsonian Astrophysical Observation", "SAO 190798"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.87790669),
        dec: Angle.Degrees(-29.05652520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125300"},
        {"Hipparcos Number", "HIP 69990"},
        {"Smithsonian Astrophysical Observation", "SAO 182439"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.81989179),
        dec: Angle.Degrees(-29.05571981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26558"},
        {"Hipparcos Number", "HIP 19518"},
        {"Geneva Identification System", "GEN# +1.00026558"},
        {"Smithsonian Astrophysical Observation", "SAO 169202"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.72304507),
        dec: Angle.Degrees(-29.05423631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127669"},
        {"Hipparcos Number", "HIP 71170"},
        {"Smithsonian Astrophysical Observation", "SAO 182657"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.33822201),
        dec: Angle.Degrees(-29.05252427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138791"},
        {"Hipparcos Number", "HIP 76318"},
        {"Geneva Identification System", "GEN# +1.00138791"},
        {"Renson", "Renson 39540"},
        {"Smithsonian Astrophysical Observation", "SAO 183596"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.83589048),
        dec: Angle.Degrees(-29.05043534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148417"},
        {"Hipparcos Number", "HIP 80735"},
        {"Smithsonian Astrophysical Observation", "SAO 184411"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.24511372),
        dec: Angle.Degrees(-29.04912710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19087"},
        {"Hipparcos Number", "HIP 14217"},
        {"Smithsonian Astrophysical Observation", "SAO 168266"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.83522007),
        dec: Angle.Degrees(-29.04824053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133095"},
        {"Hipparcos Number", "HIP 73660"},
        {"Renson", "Renson 37800"},
        {"Smithsonian Astrophysical Observation", "SAO 183126"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.85904891),
        dec: Angle.Degrees(-29.04769131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158514"},
        {"Hipparcos Number", "HIP 85712"},
        {"Geneva Identification System", "GEN# +1.00158514"},
        {"Smithsonian Astrophysical Observation", "SAO 185465"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.72714553),
        dec: Angle.Degrees(-29.04551579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91380"},
        {"Hipparcos Number", "HIP 51607"},
        {"Geneva Identification System", "GEN# +1.00091380"},
        {"Smithsonian Astrophysical Observation", "SAO 178951"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.13109876),
        dec: Angle.Degrees(-29.04475933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214306"},
        {"Hipparcos Number", "HIP 111705"},
        {"Geneva Identification System", "GEN# +1.00214306"},
        {"Smithsonian Astrophysical Observation", "SAO 191276"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.42773820),
        dec: Angle.Degrees(-29.04450730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222699"},
        {"Hipparcos Number", "HIP 116988"},
        {"Smithsonian Astrophysical Observation", "SAO 192101"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.75932700),
        dec: Angle.Degrees(-29.04395969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31447"},
        {"Hipparcos Number", "HIP 22821"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.67002412),
        dec: Angle.Degrees(-29.04372629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87320"},
        {"Hipparcos Number", "HIP 49285"},
        {"Geneva Identification System", "GEN# +1.00087320"},
        {"Smithsonian Astrophysical Observation", "SAO 178355"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.90641992),
        dec: Angle.Degrees(-29.04340718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -237.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65702"},
        {"Hipparcos Number", "HIP 38999"},
        {"Fundamental Katalog 5th Edition", "FK5 4718"},
        {"Smithsonian Astrophysical Observation", "SAO 174927"},
    },
    visualMagnitude: 9.30,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.72002659),
        dec: Angle.Degrees(-29.04315636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114162"},
        {"Hipparcos Number", "HIP 64176"},
        {"Smithsonian Astrophysical Observation", "SAO 181411"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.29140665),
        dec: Angle.Degrees(-29.04263670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11249"},
        {"Hipparcos Number", "HIP 8526"},
        {"Smithsonian Astrophysical Observation", "SAO 167334"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.48972793),
        dec: Angle.Degrees(-29.04084707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2455"},
        {"Hipparcos Number", "HIP 2227"},
        {"Geneva Identification System", "GEN# +1.00002455"},
        {"Smithsonian Astrophysical Observation", "SAO 166295"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.05893751),
        dec: Angle.Degrees(-29.04020581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51202"},
        {"Hipparcos Number", "HIP 33270"},
        {"Smithsonian Astrophysical Observation", "SAO 172574"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.81140532),
        dec: Angle.Degrees(-29.03828356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14868"},
        {"Hipparcos Number", "HIP 11125"},
        {"Geneva Identification System", "GEN# +1.00014868"},
        {"Smithsonian Astrophysical Observation", "SAO 167741"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.79613112),
        dec: Angle.Degrees(-29.03693387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 152.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 102.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130626"},
        {"Hipparcos Number", "HIP 72551"},
        {"Smithsonian Astrophysical Observation", "SAO 182905"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.49016768),
        dec: Angle.Degrees(-29.03465593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107262"},
        {"Hipparcos Number", "HIP 60143"},
        {"Smithsonian Astrophysical Observation", "SAO 180692"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.00271772),
        dec: Angle.Degrees(-29.03422490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85225"},
        {"Hipparcos Number", "HIP 48213"},
        {"Smithsonian Astrophysical Observation", "SAO 178060"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.45001195),
        dec: Angle.Degrees(-29.03353130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198100"},
        {"Hipparcos Number", "HIP 102733"},
        {"Smithsonian Astrophysical Observation", "SAO 189722"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.25631981),
        dec: Angle.Degrees(-29.03286658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28639"},
        {"Hipparcos Number", "HIP 20965"},
        {"Smithsonian Astrophysical Observation", "SAO 169505"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.43104246),
        dec: Angle.Degrees(-29.02970162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5194",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5194"},
        {"Geneva Identification System", "GEN# -0.02900327J"},
        {"Wilson Evans Batten Catalogue", "WEB 1090"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.61074736),
        dec: Angle.Degrees(-29.02880464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20968",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20968"},
    },
    visualMagnitude: 11.42,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.43713116),
        dec: Angle.Degrees(-29.02636695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -283.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123342"},
        {"Hipparcos Number", "HIP 69017"},
        {"Smithsonian Astrophysical Observation", "SAO 182261"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.93154986),
        dec: Angle.Degrees(-29.02601468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102899"},
        {"Hipparcos Number", "HIP 57756"},
        {"Smithsonian Astrophysical Observation", "SAO 180233"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.66956367),
        dec: Angle.Degrees(-29.02528481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10209"},
        {"Hipparcos Number", "HIP 7711"},
        {"Fundamental Katalog 5th Edition", "FK5 2114"},
        {"Geneva Identification System", "GEN# +1.00010209"},
        {"Smithsonian Astrophysical Observation", "SAO 167202"},
        {"Wilson Evans Batten Catalogue", "WEB 1655"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.81894050),
        dec: Angle.Degrees(-29.02246900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180904"},
        {"Hipparcos Number", "HIP 94958"},
        {"Geneva Identification System", "GEN# +1.00180904"},
        {"Smithsonian Astrophysical Observation", "SAO 187962"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.85692214),
        dec: Angle.Degrees(-29.02102626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21147"},
        {"Hipparcos Number", "HIP 15825"},
        {"Smithsonian Astrophysical Observation", "SAO 168510"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.97323730),
        dec: Angle.Degrees(-29.01995070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78035"},
        {"Hipparcos Number", "HIP 44596"},
        {"Smithsonian Astrophysical Observation", "SAO 176924"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.27756625),
        dec: Angle.Degrees(-29.01815824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53375"},
        {"Hipparcos Number", "HIP 34037"},
        {"Smithsonian Astrophysical Observation", "SAO 172874"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.91160901),
        dec: Angle.Degrees(-29.01798694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42988"},
        {"Hipparcos Number", "HIP 29466"},
        {"Geneva Identification System", "GEN# +1.00042988"},
        {"Smithsonian Astrophysical Observation", "SAO 171389"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.12871548),
        dec: Angle.Degrees(-29.01791246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35311",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35311"},
    },
    visualMagnitude: 11.09,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)17, 38.6700),
        dec: Angle.DegreesMinutesSeconds((int)-29, (int)01, 00.100)
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
    primaryId: "HIP 16465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22025"},
        {"Hipparcos Number", "HIP 16465"},
        {"Smithsonian Astrophysical Observation", "SAO 168615"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.01935412),
        dec: Angle.Degrees(-29.01615589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112905"},
        {"Hipparcos Number", "HIP 63476"},
        {"Smithsonian Astrophysical Observation", "SAO 181305"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.10448775),
        dec: Angle.Degrees(-29.01578980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61735"},
        {"Hipparcos Number", "HIP 37314"},
        {"Smithsonian Astrophysical Observation", "SAO 174229"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.90793480),
        dec: Angle.Degrees(-29.01546974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57238"},
        {"Hipparcos Number", "HIP 35456"},
        {"Smithsonian Astrophysical Observation", "SAO 173468"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.79695858),
        dec: Angle.Degrees(-29.01307983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204044"},
        {"Hipparcos Number", "HIP 105887"},
        {"Smithsonian Astrophysical Observation", "SAO 190340"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.67832287),
        dec: Angle.Degrees(-29.01289997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165898"},
        {"Hipparcos Number", "HIP 88955"},
        {"Smithsonian Astrophysical Observation", "SAO 186369"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.36609204),
        dec: Angle.Degrees(-29.01135416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146141"},
        {"Hipparcos Number", "HIP 79688"},
        {"Geneva Identification System", "GEN# +1.00146141"},
        {"Smithsonian Astrophysical Observation", "SAO 184265"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.94861401),
        dec: Angle.Degrees(-29.01073357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13335"},
        {"Hipparcos Number", "HIP 10089"},
        {"Geneva Identification System", "GEN# +1.00013335"},
        {"Smithsonian Astrophysical Observation", "SAO 167600"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.42869442),
        dec: Angle.Degrees(-29.00691558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1097"},
        {"Hipparcos Number", "HIP 1210"},
        {"Geneva Identification System", "GEN# +1.00001097"},
        {"Renson", "Renson 210"},
        {"Smithsonian Astrophysical Observation", "SAO 166146"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.78313679),
        dec: Angle.Degrees(-29.00641128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132938"},
        {"Hipparcos Number", "HIP 73602"},
        {"Smithsonian Astrophysical Observation", "SAO 183110"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.66995926),
        dec: Angle.Degrees(-29.00485257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3910",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3910"},
        {"Smithsonian Astrophysical Observation", "SAO 166615"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.53482510),
        dec: Angle.Degrees(-29.00444562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316849"},
        {"Hipparcos Number", "HIP 88075"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.81957307),
        dec: Angle.Degrees(-29.00317332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22187"},
        {"Hipparcos Number", "HIP 16585"},
        {"Geneva Identification System", "GEN# +1.00022187"},
        {"Smithsonian Astrophysical Observation", "SAO 168629"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.37753594),
        dec: Angle.Degrees(-29.00266852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17847"},
        {"Hipparcos Number", "HIP 13285"},
        {"Smithsonian Astrophysical Observation", "SAO 168097"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.75127223),
        dec: Angle.Degrees(-29.00254566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103554"},
        {"Hipparcos Number", "HIP 58125"},
        {"Smithsonian Astrophysical Observation", "SAO 180297"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.83419571),
        dec: Angle.Degrees(-29.00222103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 151.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143403"},
        {"Hipparcos Number", "HIP 78480"},
        {"Geneva Identification System", "GEN# +1.00143403"},
        {"Smithsonian Astrophysical Observation", "SAO 184026"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.30451331),
        dec: Angle.Degrees(-29.00190502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145469"},
        {"Hipparcos Number", "HIP 79403"},
        {"Geneva Identification System", "GEN# +1.00145469"},
        {"Smithsonian Astrophysical Observation", "SAO 184219"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.07361875),
        dec: Angle.Degrees(-29.00080597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 275",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 18 AB"},
        {"Henry Draper", "HD 225099"},
        {"Hipparcos Number", "HIP 275"},
        {"Geneva Identification System", "GEN# +4.09010059"},
        {"Smithsonian Astrophysical Observation", "SAO 166021"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.85767485),
        dec: Angle.Degrees(-29.00061360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220388"},
        {"Hipparcos Number", "HIP 115478"},
        {"Smithsonian Astrophysical Observation", "SAO 191865"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.89295372),
        dec: Angle.Degrees(-29.00004149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168121"},
        {"Hipparcos Number", "HIP 89786"},
        {"Smithsonian Astrophysical Observation", "SAO 186642"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.85104095),
        dec: Angle.Degrees(-28.99962472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24705"},
        {"Hipparcos Number", "HIP 18278"},
        {"Smithsonian Astrophysical Observation", "SAO 168940"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.64619551),
        dec: Angle.Degrees(-28.99719022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29096",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29096"},
    },
    visualMagnitude: 11.85,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.06056542),
        dec: Angle.Degrees(-28.99493284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 113.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16403"},
        {"Hipparcos Number", "HIP 12196"},
        {"Geneva Identification System", "GEN# +1.00016403"},
        {"Smithsonian Astrophysical Observation", "SAO 167922"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.27131402),
        dec: Angle.Degrees(-28.99326796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154420"},
        {"Hipparcos Number", "HIP 83708"},
        {"Smithsonian Astrophysical Observation", "SAO 185025"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.62093321),
        dec: Angle.Degrees(-28.99253275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20774"},
        {"Hipparcos Number", "HIP 15518"},
        {"Smithsonian Astrophysical Observation", "SAO 168467"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.99252382),
        dec: Angle.Degrees(-28.99243096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89353"},
        {"Hipparcos Number", "HIP 50456"},
        {"Fundamental Katalog 5th Edition", "FK5 1265"},
        {"Geneva Identification System", "GEN# +1.00089353"},
        {"Smithsonian Astrophysical Observation", "SAO 178644"},
        {"Wilson Evans Batten Catalogue", "WEB 9259"},
    },
    visualMagnitude: 5.52,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.53166913),
        dec: Angle.Degrees(-28.99202661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54914"},
        {"Hipparcos Number", "HIP 34558"},
        {"Smithsonian Astrophysical Observation", "SAO 173093"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.38249943),
        dec: Angle.Degrees(-28.99137032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14879",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2402 AB"},
        {"Henry Draper", "HD 20010"},
        {"Hipparcos Number", "HIP 14879"},
        {"Cincinnati Publication", "Ci 20 211"},
        {"Smithsonian Astrophysical Observation", "SAO 168373"},
        {"Wilson Evans Batten Catalogue", "WEB 2871"},
    },
    visualMagnitude: 3.80,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.01783332),
        dec: Angle.Degrees(-28.98910623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 371.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 612.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15133"},
        {"Hipparcos Number", "HIP 11305"},
        {"Smithsonian Astrophysical Observation", "SAO 167778"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.38629048),
        dec: Angle.Degrees(-28.98748110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 275.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1187",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1187"},
        {"Smithsonian Astrophysical Observation", "SAO 166144"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.70741484),
        dec: Angle.Degrees(-28.98739664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8144"},
        {"Hipparcos Number", "HIP 6267"},
        {"Geneva Identification System", "GEN# +1.00008144"},
        {"Smithsonian Astrophysical Observation", "SAO 166971"},
        {"Wilson Evans Batten Catalogue", "WEB 1400"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.09401274),
        dec: Angle.Degrees(-28.98688346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118944"},
        {"Hipparcos Number", "HIP 66731"},
        {"Smithsonian Astrophysical Observation", "SAO 181851"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.17208556),
        dec: Angle.Degrees(-28.98680297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142058"},
        {"Hipparcos Number", "HIP 77820"},
        {"Smithsonian Astrophysical Observation", "SAO 183892"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.36232682),
        dec: Angle.Degrees(-28.98544472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111060"},
        {"Hipparcos Number", "HIP 62365"},
        {"Smithsonian Astrophysical Observation", "SAO 181095"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.71435383),
        dec: Angle.Degrees(-28.98534608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74524",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74524"},
        {"Smithsonian Astrophysical Observation", "SAO 183279"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.42993131),
        dec: Angle.Degrees(-28.98449783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213588"},
        {"Hipparcos Number", "HIP 111311"},
        {"Fundamental Katalog 5th Edition", "FK5 5987"},
        {"Smithsonian Astrophysical Observation", "SAO 191218"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.25135834),
        dec: Angle.Degrees(-28.98219269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1737"},
        {"Hipparcos Number", "HIP 1708"},
        {"Geneva Identification System", "GEN# +1.00001737"},
        {"Smithsonian Astrophysical Observation", "SAO 166207"},
        {"Wilson Evans Batten Catalogue", "WEB 310"},
    },
    visualMagnitude: 5.18,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.37990144),
        dec: Angle.Degrees(-28.98129509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2026"},
        {"Hipparcos Number", "HIP 1928"},
        {"Geneva Identification System", "GEN# +1.00002026"},
        {"Renson", "Renson 470"},
        {"Smithsonian Astrophysical Observation", "SAO 166240"},
        {"Wilson Evans Batten Catalogue", "WEB 356"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.07775526),
        dec: Angle.Degrees(-28.98065123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25289",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25289"},
        {"Smithsonian Astrophysical Observation", "SAO 170404"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.15342140),
        dec: Angle.Degrees(-28.97945096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81529"},
        {"Hipparcos Number", "HIP 46212"},
        {"Smithsonian Astrophysical Observation", "SAO 177422"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.32777313),
        dec: Angle.Degrees(-28.97901739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50309",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7706 AB"},
        {"Henry Draper", "HD 89117"},
        {"Hipparcos Number", "HIP 50309"},
        {"Geneva Identification System", "GEN# +1.00089117J"},
        {"Smithsonian Astrophysical Observation", "SAO 178601"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.07863337),
        dec: Angle.Degrees(-28.97845412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33240"},
        {"Hipparcos Number", "HIP 23855"},
        {"Smithsonian Astrophysical Observation", "SAO 170096"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.91065945),
        dec: Angle.Degrees(-28.97742904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153763"},
        {"Hipparcos Number", "HIP 83378"},
        {"Geneva Identification System", "GEN# +1.00153763"},
        {"Smithsonian Astrophysical Observation", "SAO 184947"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.61517134),
        dec: Angle.Degrees(-28.97703923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70724"},
        {"Hipparcos Number", "HIP 41044"},
        {"Geneva Identification System", "GEN# +1.00070724"},
        {"Smithsonian Astrophysical Observation", "SAO 175703"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.64137046),
        dec: Angle.Degrees(-28.97645463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1183",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1183"},
        {"Smithsonian Astrophysical Observation", "SAO 166143"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.69688877),
        dec: Angle.Degrees(-28.97501431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20155"},
        {"Hipparcos Number", "HIP 15005"},
        {"Geneva Identification System", "GEN# +1.00020155"},
        {"Smithsonian Astrophysical Observation", "SAO 168393"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.35002779),
        dec: Angle.Degrees(-28.97453016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136033"},
        {"Hipparcos Number", "HIP 74979"},
        {"Geneva Identification System", "GEN# +1.00136033"},
        {"Smithsonian Astrophysical Observation", "SAO 183369"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.83305451),
        dec: Angle.Degrees(-28.97417204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49872"},
        {"Hipparcos Number", "HIP 32697"},
        {"Geneva Identification System", "GEN# +1.00049872"},
        {"Smithsonian Astrophysical Observation", "SAO 172375"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.31808277),
        dec: Angle.Degrees(-28.97354286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33579",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Adhara"},
        {"Aitken", "ADS 5654 A"},
        {"Henry Draper", "HD 52089"},
        {"Hipparcos Number", "HIP 33579"},
        {"Celescope Catalog", "CEL 1473"},
        {"Fundamental Katalog 5th Edition", "FK5 268"},
        {"Geneva Identification System", "GEN# +1.00052089J"},
        {"Smithsonian Astrophysical Observation", "SAO 172676"},
        {"Wilson Evans Batten Catalogue", "WEB 6753"},
    },
    visualMagnitude: 1.50,
    bvColour: -0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.65644451),
        dec: Angle.Degrees(-28.97208931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144749"},
        {"Hipparcos Number", "HIP 79073"},
        {"Geneva Identification System", "GEN# +1.00144749"},
        {"Smithsonian Astrophysical Observation", "SAO 184153"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.12294131),
        dec: Angle.Degrees(-28.97147144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117820"},
        {"Hipparcos Number", "HIP 66118"},
        {"Smithsonian Astrophysical Observation", "SAO 181750"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.30715625),
        dec: Angle.Degrees(-28.97142987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41154",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6794 A"},
        {"Henry Draper", "HD 70963"},
        {"Hipparcos Number", "HIP 41154"},
        {"Fundamental Katalog 5th Edition", "FK5 2651"},
        {"Smithsonian Astrophysical Observation", "SAO 175743"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.95575056),
        dec: Angle.Degrees(-28.97030725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13752"},
        {"Hipparcos Number", "HIP 10352"},
        {"Geneva Identification System", "GEN# +1.00013752"},
        {"Smithsonian Astrophysical Observation", "SAO 167642"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.35310090),
        dec: Angle.Degrees(-28.97015422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183091"},
        {"Hipparcos Number", "HIP 95782"},
        {"Smithsonian Astrophysical Observation", "SAO 188174"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.22455469),
        dec: Angle.Degrees(-28.96998527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23534",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3657 AB"},
        {"Henry Draper", "HD 32668"},
        {"Hipparcos Number", "HIP 23534"},
        {"Smithsonian Astrophysical Observation", "SAO 170028"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.90652309),
        dec: Angle.Degrees(-28.96937892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99613"},
        {"Hipparcos Number", "HIP 55901"},
        {"Smithsonian Astrophysical Observation", "SAO 179902"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.87850207),
        dec: Angle.Degrees(-28.96674346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56211"},
        {"Hipparcos Number", "HIP 35051"},
        {"Celescope Catalog", "CEL 1710"},
        {"Geneva Identification System", "GEN# +1.00056211"},
        {"Smithsonian Astrophysical Observation", "SAO 173286"},
        {"Wilson Evans Batten Catalogue", "WEB 7009"},
    },
    visualMagnitude: 7.38,
    bvColour: -0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.72964184),
        dec: Angle.Degrees(-28.96444657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89584"},
        {"Hipparcos Number", "HIP 50568"},
        {"Geneva Identification System", "GEN# +1.00089584"},
        {"Smithsonian Astrophysical Observation", "SAO 178690"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.94907282),
        dec: Angle.Degrees(-28.96236422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5204"},
        {"Hipparcos Number", "HIP 4201"},
        {"Geneva Identification System", "GEN# +1.00005204"},
        {"Smithsonian Astrophysical Observation", "SAO 166656"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.40830607),
        dec: Angle.Degrees(-28.96100784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151348"},
        {"Hipparcos Number", "HIP 82228"},
        {"Geneva Identification System", "GEN# +1.00151348"},
        {"Smithsonian Astrophysical Observation", "SAO 184647"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.784,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.98360050),
        dec: Angle.Degrees(-28.95708407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78752"},
        {"Hipparcos Number", "HIP 44915"},
        {"Geneva Identification System", "GEN# +1.00078752"},
        {"Smithsonian Astrophysical Observation", "SAO 177031"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.25762036),
        dec: Angle.Degrees(-28.95700287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62623"},
        {"Hipparcos Number", "HIP 37677"},
        {"Celescope Catalog", "CEL 1998"},
        {"Fundamental Katalog 5th Edition", "FK5 2601"},
        {"Geneva Identification System", "GEN# +1.00062623"},
        {"Smithsonian Astrophysical Observation", "SAO 174400"},
        {"Wilson Evans Batten Catalogue", "WEB 7448"},
    },
    visualMagnitude: 3.94,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.95196716),
        dec: Angle.Degrees(-28.95483520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13177",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13177"},
    },
    visualMagnitude: 11.34,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.37436706),
        dec: Angle.Degrees(-28.95420839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40101"},
        {"Hipparcos Number", "HIP 28017"},
        {"Smithsonian Astrophysical Observation", "SAO 171018"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.89386965),
        dec: Angle.Degrees(-28.95368835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29445"},
        {"Hipparcos Number", "HIP 21497"},
        {"Geneva Identification System", "GEN# +1.00029445"},
        {"Smithsonian Astrophysical Observation", "SAO 169616"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.25794187),
        dec: Angle.Degrees(-28.95280292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28287"},
        {"Hipparcos Number", "HIP 20737"},
        {"Geneva Identification System", "GEN# +1.00028287"},
        {"Smithsonian Astrophysical Observation", "SAO 169452"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.66072727),
        dec: Angle.Degrees(-28.95182755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106435"},
        {"Hipparcos Number", "HIP 59705"},
        {"Smithsonian Astrophysical Observation", "SAO 180597"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.66833595),
        dec: Angle.Degrees(-28.95054576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13692",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2231 AB"},
        {"Henry Draper", "HD 18387"},
        {"Hipparcos Number", "HIP 13692"},
        {"Smithsonian Astrophysical Observation", "SAO 168163"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.08236269),
        dec: Angle.Degrees(-28.95044440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79290"},
        {"Hipparcos Number", "HIP 45176"},
        {"Geneva Identification System", "GEN# +1.00079290"},
        {"Smithsonian Astrophysical Observation", "SAO 177110"},
    },
    visualMagnitude: 6.76,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.09123949),
        dec: Angle.Degrees(-28.94764419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116130"},
        {"Hipparcos Number", "HIP 65222"},
        {"Smithsonian Astrophysical Observation", "SAO 181592"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.49666166),
        dec: Angle.Degrees(-28.94590656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218682"},
        {"Hipparcos Number", "HIP 114399"},
        {"Smithsonian Astrophysical Observation", "SAO 191693"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.53106214),
        dec: Angle.Degrees(-28.94568198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100158",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100158"},
        {"Smithsonian Astrophysical Observation", "SAO 189131"},
    },
    visualMagnitude: 9.82,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.75063570),
        dec: Angle.Degrees(-28.94527447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117308"},
        {"Hipparcos Number", "HIP 65847"},
        {"Smithsonian Astrophysical Observation", "SAO 181698"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.47074427),
        dec: Angle.Degrees(-28.94472028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116105",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16813 AB"},
        {"Henry Draper", "HD 221341"},
        {"Hipparcos Number", "HIP 116105"},
        {"Smithsonian Astrophysical Observation", "SAO 191966"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.87945780),
        dec: Angle.Degrees(-28.94367195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150126"},
        {"Hipparcos Number", "HIP 81616"},
        {"Smithsonian Astrophysical Observation", "SAO 184532"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.04439756),
        dec: Angle.Degrees(-28.94005972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156253"},
        {"Hipparcos Number", "HIP 84609"},
        {"Smithsonian Astrophysical Observation", "SAO 185232"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.42474302),
        dec: Angle.Degrees(-28.93830513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37510"},
        {"Hipparcos Number", "HIP 26473"},
        {"Smithsonian Astrophysical Observation", "SAO 170614"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.46121249),
        dec: Angle.Degrees(-28.93737029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1019"},
        {"Hipparcos Number", "HIP 1151"},
        {"Geneva Identification System", "GEN# +1.00001019"},
        {"Smithsonian Astrophysical Observation", "SAO 166139"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.59303635),
        dec: Angle.Degrees(-28.93445248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43764"},
        {"Hipparcos Number", "HIP 29819"},
        {"Smithsonian Astrophysical Observation", "SAO 171496"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.19497958),
        dec: Angle.Degrees(-28.93426669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34628",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34628"},
        {"Smithsonian Astrophysical Observation", "SAO 173128"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.59424522),
        dec: Angle.Degrees(-28.93329701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120730"},
        {"Hipparcos Number", "HIP 67661"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.94372040),
        dec: Angle.Degrees(-28.93240597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -168.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215220"},
        {"Hipparcos Number", "HIP 112243"},
        {"Geneva Identification System", "GEN# +1.00215220"},
        {"Smithsonian Astrophysical Observation", "SAO 191358"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.02303348),
        dec: Angle.Degrees(-28.93138164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143976"},
        {"Hipparcos Number", "HIP 78743"},
        {"Smithsonian Astrophysical Observation", "SAO 184083"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.12734482),
        dec: Angle.Degrees(-28.93103888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113569"},
        {"Hipparcos Number", "HIP 63831"},
        {"Geneva Identification System", "GEN# +1.00113569"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.23250530),
        dec: Angle.Degrees(-28.92870316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119624"},
        {"Hipparcos Number", "HIP 67078"},
        {"Smithsonian Astrophysical Observation", "SAO 181923"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.22022400),
        dec: Angle.Degrees(-28.92546843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14420"},
        {"Hipparcos Number", "HIP 10804"},
        {"Smithsonian Astrophysical Observation", "SAO 167698"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.76570659),
        dec: Angle.Degrees(-28.92362661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160319"},
        {"Hipparcos Number", "HIP 86487"},
        {"Geneva Identification System", "GEN# +1.00160319"},
        {"Smithsonian Astrophysical Observation", "SAO 185604"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.09947956),
        dec: Angle.Degrees(-28.92318841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126192"},
        {"Hipparcos Number", "HIP 70471"},
        {"Smithsonian Astrophysical Observation", "SAO 182516"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.20484072),
        dec: Angle.Degrees(-28.92187873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155773"},
        {"Hipparcos Number", "HIP 84355"},
        {"Smithsonian Astrophysical Observation", "SAO 185187"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.68883912),
        dec: Angle.Degrees(-28.92143413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 315982"},
        {"Hipparcos Number", "HIP 85928"},
        {"Geneva Identification System", "GEN# +1.00315982"},
        {"Smithsonian Astrophysical Observation", "SAO 185502"},
    },
    visualMagnitude: 10.13,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.40242075),
        dec: Angle.Degrees(-28.91999817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27736"},
        {"Hipparcos Number", "HIP 20346"},
        {"Geneva Identification System", "GEN# +1.00027736"},
        {"Smithsonian Astrophysical Observation", "SAO 169370"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.37867736),
        dec: Angle.Degrees(-28.91931505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131184"},
        {"Hipparcos Number", "HIP 72799"},
        {"Smithsonian Astrophysical Observation", "SAO 182952"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.20615410),
        dec: Angle.Degrees(-28.91428500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63148"},
        {"Hipparcos Number", "HIP 37927"},
        {"Geneva Identification System", "GEN# +1.00063148"},
        {"Smithsonian Astrophysical Observation", "SAO 174500"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.58108080),
        dec: Angle.Degrees(-28.91054879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26349"},
        {"Hipparcos Number", "HIP 19371"},
        {"Geneva Identification System", "GEN# +1.00026349"},
        {"Smithsonian Astrophysical Observation", "SAO 169171"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.23815992),
        dec: Angle.Degrees(-28.90936623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222397"},
        {"Hipparcos Number", "HIP 116800"},
        {"Smithsonian Astrophysical Observation", "SAO 192074"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.07567583),
        dec: Angle.Degrees(-28.90899327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18650"},
        {"Hipparcos Number", "HIP 13907"},
        {"Geneva Identification System", "GEN# +1.00018650"},
        {"Smithsonian Astrophysical Observation", "SAO 168202"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.77705541),
        dec: Angle.Degrees(-28.90707982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122682"},
        {"Hipparcos Number", "HIP 68711"},
        {"Smithsonian Astrophysical Observation", "SAO 182205"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.99853355),
        dec: Angle.Degrees(-28.90466239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149961"},
        {"Hipparcos Number", "HIP 81527"},
        {"Smithsonian Astrophysical Observation", "SAO 184521"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.77945821),
        dec: Angle.Degrees(-28.90395512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166469"},
        {"Hipparcos Number", "HIP 89178"},
        {"Geneva Identification System", "GEN# +1.00166469"},
        {"Renson", "Renson 46860"},
        {"Smithsonian Astrophysical Observation", "SAO 186444"},
    },
    visualMagnitude: 6.51,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.99229445),
        dec: Angle.Degrees(-28.90151763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73022"},
        {"Hipparcos Number", "HIP 42113"},
        {"Smithsonian Astrophysical Observation", "SAO 176124"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.77241329),
        dec: Angle.Degrees(-28.89968241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190931"},
        {"Hipparcos Number", "HIP 99208"},
        {"Geneva Identification System", "GEN# +1.00190931"},
        {"Smithsonian Astrophysical Observation", "SAO 188942"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.10868345),
        dec: Angle.Degrees(-28.89878982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1659",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1659"},
        {"Geneva Identification System", "GEN# -0.02900081"},
    },
    visualMagnitude: 10.98,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.19813515),
        dec: Angle.Degrees(-28.89795890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -250.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98949"},
        {"Hipparcos Number", "HIP 55576"},
        {"Smithsonian Astrophysical Observation", "SAO 179828"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.77140916),
        dec: Angle.Degrees(-28.89696884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13083"},
        {"Hipparcos Number", "HIP 9900"},
        {"Geneva Identification System", "GEN# +1.00013083"},
        {"Smithsonian Astrophysical Observation", "SAO 167564"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.85671305),
        dec: Angle.Degrees(-28.89655193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126334"},
        {"Hipparcos Number", "HIP 70514"},
        {"Smithsonian Astrophysical Observation", "SAO 182527"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.36537407),
        dec: Angle.Degrees(-28.89543524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8960"},
        {"Hipparcos Number", "HIP 6825"},
        {"Smithsonian Astrophysical Observation", "SAO 167060"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.836,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.95110611),
        dec: Angle.Degrees(-28.89490252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27230"},
        {"Hipparcos Number", "HIP 19972"},
        {"Renson", "Renson 6980"},
        {"Smithsonian Astrophysical Observation", "SAO 169299"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.23478361),
        dec: Angle.Degrees(-28.89380625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38772"},
        {"Hipparcos Number", "HIP 27281"},
        {"Geneva Identification System", "GEN# +1.00038772"},
        {"Smithsonian Astrophysical Observation", "SAO 170829"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.71946461),
        dec: Angle.Degrees(-28.88993838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46723"},
        {"Hipparcos Number", "HIP 31283"},
        {"Smithsonian Astrophysical Observation", "SAO 171951"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.41514670),
        dec: Angle.Degrees(-28.88917830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133879"},
        {"Hipparcos Number", "HIP 74025"},
        {"Smithsonian Astrophysical Observation", "SAO 183196"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.91761433),
        dec: Angle.Degrees(-28.88887133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205229"},
        {"Hipparcos Number", "HIP 106540"},
        {"Smithsonian Astrophysical Observation", "SAO 190454"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.66495447),
        dec: Angle.Degrees(-28.88802828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31939"},
        {"Hipparcos Number", "HIP 23125"},
        {"Smithsonian Astrophysical Observation", "SAO 169937"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.63842250),
        dec: Angle.Degrees(-28.88773011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79935"},
        {"Hipparcos Number", "HIP 45487"},
        {"Smithsonian Astrophysical Observation", "SAO 177193"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.03180620),
        dec: Angle.Degrees(-28.88635470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69346",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69346"},
        {"Smithsonian Astrophysical Observation", "SAO 182327"},
        {"Wilson Evans Batten Catalogue", "WEB 12093"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.89335264),
        dec: Angle.Degrees(-28.88532479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85277"},
        {"Hipparcos Number", "HIP 48237"},
        {"Smithsonian Astrophysical Observation", "SAO 178066"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.51165114),
        dec: Angle.Degrees(-28.88522873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6023"},
        {"Hipparcos Number", "HIP 4767"},
        {"Smithsonian Astrophysical Observation", "SAO 166752"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.31536589),
        dec: Angle.Degrees(-28.88454755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28823"},
        {"Hipparcos Number", "HIP 21104"},
        {"Geneva Identification System", "GEN# +1.00028823"},
        {"Smithsonian Astrophysical Observation", "SAO 169533"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.83486777),
        dec: Angle.Degrees(-28.88190525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102318",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102318"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.96642476),
        dec: Angle.Degrees(+01.69004672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40404"},
        {"Hipparcos Number", "HIP 28177"},
        {"Smithsonian Astrophysical Observation", "SAO 171062"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.30686021),
        dec: Angle.Degrees(-28.88150399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31445"},
        {"Hipparcos Number", "HIP 22822"},
        {"Smithsonian Astrophysical Observation", "SAO 169879"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.66969304),
        dec: Angle.Degrees(-28.88119973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28665"},
        {"Hipparcos Number", "HIP 20979"},
        {"Geneva Identification System", "GEN# +1.00028665"},
        {"Smithsonian Astrophysical Observation", "SAO 169509"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.49003518),
        dec: Angle.Degrees(-28.87965152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83041"},
        {"Hipparcos Number", "HIP 47018"},
        {"Geneva Identification System", "GEN# +1.00083041"},
        {"Smithsonian Astrophysical Observation", "SAO 177696"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.73568293),
        dec: Angle.Degrees(-28.87762597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199928"},
        {"Hipparcos Number", "HIP 103723"},
        {"Smithsonian Astrophysical Observation", "SAO 189932"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.26745272),
        dec: Angle.Degrees(-28.87653631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154333"},
        {"Hipparcos Number", "HIP 83659"},
        {"Geneva Identification System", "GEN# +1.00154333"},
        {"Smithsonian Astrophysical Observation", "SAO 185017"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.48611591),
        dec: Angle.Degrees(-28.87263132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34799"},
        {"Hipparcos Number", "HIP 24780"},
        {"Geneva Identification System", "GEN# +1.00034799"},
        {"Smithsonian Astrophysical Observation", "SAO 170303"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.69190174),
        dec: Angle.Degrees(-28.87238827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11932"},
        {"Hipparcos Number", "HIP 9047"},
        {"Smithsonian Astrophysical Observation", "SAO 167415"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.14104107),
        dec: Angle.Degrees(-28.87207728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178582"},
        {"Hipparcos Number", "HIP 94176"},
        {"Smithsonian Astrophysical Observation", "SAO 187763"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.56659413),
        dec: Angle.Degrees(-28.87164124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76870"},
        {"Hipparcos Number", "HIP 44028"},
        {"Smithsonian Astrophysical Observation", "SAO 176750"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.49276345),
        dec: Angle.Degrees(-28.87099817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44861"},
        {"Hipparcos Number", "HIP 30334"},
        {"Smithsonian Astrophysical Observation", "SAO 171658"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.70914198),
        dec: Angle.Degrees(-28.87025749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87828"},
        {"Hipparcos Number", "HIP 49559"},
        {"Geneva Identification System", "GEN# +1.00087828"},
        {"Smithsonian Astrophysical Observation", "SAO 178432"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.77793191),
        dec: Angle.Degrees(-28.86780242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112489"},
        {"Hipparcos Number", "HIP 63227"},
        {"Smithsonian Astrophysical Observation", "SAO 181262"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.33319907),
        dec: Angle.Degrees(-28.86750879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75790",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9659 AB"},
        {"Henry Draper", "HD 137798"},
        {"Hipparcos Number", "HIP 75790"},
        {"Smithsonian Astrophysical Observation", "SAO 183506"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.24453930),
        dec: Angle.Degrees(-28.86681151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144527"},
        {"Hipparcos Number", "HIP 78988"},
        {"Geneva Identification System", "GEN# +1.00144527"},
        {"Smithsonian Astrophysical Observation", "SAO 184133"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.85037560),
        dec: Angle.Degrees(-28.86574004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9218"},
        {"Hipparcos Number", "HIP 7008"},
        {"Smithsonian Astrophysical Observation", "SAO 167092"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.55768245),
        dec: Angle.Degrees(-28.86541317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8074"},
        {"Hipparcos Number", "HIP 6215"},
        {"Smithsonian Astrophysical Observation", "SAO 166961"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.92181083),
        dec: Angle.Degrees(-28.86193873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153257"},
        {"Hipparcos Number", "HIP 83142"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.85711852),
        dec: Angle.Degrees(-28.86172293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75669"},
        {"Hipparcos Number", "HIP 43389"},
        {"Smithsonian Astrophysical Observation", "SAO 176551"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.58204888),
        dec: Angle.Degrees(-28.86098973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20782"},
        {"Hipparcos Number", "HIP 15527"},
        {"Geneva Identification System", "GEN# +1.00020782"},
        {"Smithsonian Astrophysical Observation", "SAO 168469"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.01393863),
        dec: Angle.Degrees(-28.85391344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 348.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217484"},
        {"Hipparcos Number", "HIP 113669"},
        {"Geneva Identification System", "GEN# +1.00217484"},
        {"Smithsonian Astrophysical Observation", "SAO 191581"},
    },
    visualMagnitude: 5.55,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.33061462),
        dec: Angle.Degrees(-28.85390821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118274",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118274"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.86131483),
        dec: Angle.Degrees(-28.85383418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118227",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118227"},
    },
    visualMagnitude: 10.82,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.71523964),
        dec: Angle.Degrees(-28.85354754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -274.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3381"},
        {"Hipparcos Number", "HIP 2884"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.13629636),
        dec: Angle.Degrees(-28.85334014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14565"},
        {"Hipparcos Number", "HIP 10917"},
        {"Smithsonian Astrophysical Observation", "SAO 167718"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.13020175),
        dec: Angle.Degrees(-28.85308788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48165"},
        {"Hipparcos Number", "HIP 31959"},
        {"Celescope Catalog", "CEL 1351"},
        {"Geneva Identification System", "GEN# +1.00048165"},
        {"Smithsonian Astrophysical Observation", "SAO 172148"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.19202836),
        dec: Angle.Degrees(-28.85252494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185770"},
        {"Hipparcos Number", "HIP 96899"},
        {"Smithsonian Astrophysical Observation", "SAO 188453"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.46172932),
        dec: Angle.Degrees(-28.85183876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101063"},
        {"Hipparcos Number", "HIP 56713"},
        {"Geneva Identification System", "GEN# +1.00101063"},
        {"Smithsonian Astrophysical Observation", "SAO 180048"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.41921523),
        dec: Angle.Degrees(-28.85131082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -313.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75836",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9665 AB"},
        {"Henry Draper", "HD 137876"},
        {"Hipparcos Number", "HIP 75836"},
        {"Smithsonian Astrophysical Observation", "SAO 183517"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.36212160),
        dec: Angle.Degrees(-28.84772103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89965"},
        {"Hipparcos Number", "HIP 50807"},
        {"Geneva Identification System", "GEN# +1.00089965"},
        {"Smithsonian Astrophysical Observation", "SAO 178742"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.59789000),
        dec: Angle.Degrees(-28.84769569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83924"},
        {"Hipparcos Number", "HIP 47493"},
        {"Smithsonian Astrophysical Observation", "SAO 177834"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.22461748),
        dec: Angle.Degrees(-28.84725690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12068"},
        {"Hipparcos Number", "HIP 9148"},
        {"Geneva Identification System", "GEN# +1.00012068"},
        {"Smithsonian Astrophysical Observation", "SAO 167436"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.47155227),
        dec: Angle.Degrees(-28.84625846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 212.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150436"},
        {"Hipparcos Number", "HIP 81765"},
        {"Smithsonian Astrophysical Observation", "SAO 184552"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.52753306),
        dec: Angle.Degrees(-28.84581685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204591"},
        {"Hipparcos Number", "HIP 106180"},
        {"Smithsonian Astrophysical Observation", "SAO 190392"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.59702797),
        dec: Angle.Degrees(-28.83986971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53346"},
        {"Hipparcos Number", "HIP 34023"},
        {"Smithsonian Astrophysical Observation", "SAO 172869"},
    },
    visualMagnitude: 9.11,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.88892594),
        dec: Angle.Degrees(-28.83900986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167016"},
        {"Hipparcos Number", "HIP 89392"},
        {"Geneva Identification System", "GEN# +1.00167016"},
        {"Smithsonian Astrophysical Observation", "SAO 186512"},
    },
    visualMagnitude: 7.94,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.63844245),
        dec: Angle.Degrees(-28.83887314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24390"},
        {"Hipparcos Number", "HIP 18075"},
        {"Geneva Identification System", "GEN# +1.00024390"},
        {"Smithsonian Astrophysical Observation", "SAO 168897"},
        {"Wilson Evans Batten Catalogue", "WEB 3484"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.96030787),
        dec: Angle.Degrees(-28.83733438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28076"},
        {"Hipparcos Number", "HIP 20599"},
        {"Smithsonian Astrophysical Observation", "SAO 169419"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.17520568),
        dec: Angle.Degrees(-28.83690468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37627"},
        {"Hipparcos Number", "HIP 26528"},
        {"Geneva Identification System", "GEN# +1.00037627"},
        {"Smithsonian Astrophysical Observation", "SAO 170631"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.63828919),
        dec: Angle.Degrees(-28.83658312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47209"},
        {"Hipparcos Number", "HIP 31541"},
        {"Smithsonian Astrophysical Observation", "SAO 172010"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.03934779),
        dec: Angle.Degrees(-28.83552934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221368"},
        {"Hipparcos Number", "HIP 116129"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.96344627),
        dec: Angle.Degrees(-28.83525112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81169"},
        {"Hipparcos Number", "HIP 46026"},
        {"Fundamental Katalog 5th Edition", "FK5 2747"},
        {"Geneva Identification System", "GEN# +1.00081169"},
        {"Smithsonian Astrophysical Observation", "SAO 177374"},
        {"Wilson Evans Batten Catalogue", "WEB 8721"},
    },
    visualMagnitude: 4.71,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.80140137),
        dec: Angle.Degrees(-28.83392305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112648",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112648"},
        {"Geneva Identification System", "GEN# -0.02918469"},
    },
    visualMagnitude: 10.67,
    bvColour: 1.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.22108413),
        dec: Angle.Degrees(-28.83357319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -170.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -242.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155216"},
        {"Hipparcos Number", "HIP 84080"},
        {"Geneva Identification System", "GEN# +1.00155216"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.84291594),
        dec: Angle.Degrees(-28.83331195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108293"},
        {"Hipparcos Number", "HIP 60723"},
        {"Smithsonian Astrophysical Observation", "SAO 180800"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.66653740),
        dec: Angle.Degrees(-28.83064313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58377"},
        {"Hipparcos Number", "HIP 35906"},
        {"Celescope Catalog", "CEL 1828"},
        {"Geneva Identification System", "GEN# +1.00058377"},
        {"Smithsonian Astrophysical Observation", "SAO 173654"},
        {"Wilson Evans Batten Catalogue", "WEB 7151"},
    },
    visualMagnitude: 6.79,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.03333062),
        dec: Angle.Degrees(-28.82789633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196354"},
        {"Hipparcos Number", "HIP 101793"},
        {"Smithsonian Astrophysical Observation", "SAO 189499"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.44722958),
        dec: Angle.Degrees(-28.82571559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172431"},
        {"Hipparcos Number", "HIP 91640"},
        {"Smithsonian Astrophysical Observation", "SAO 187128"},
    },
    visualMagnitude: 8.32,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.32676355),
        dec: Angle.Degrees(-28.82566228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10802",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10802"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.75763047),
        dec: Angle.Degrees(-28.82382926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218434"},
        {"Hipparcos Number", "HIP 114254"},
        {"Geneva Identification System", "GEN# +1.00218434"},
        {"Smithsonian Astrophysical Observation", "SAO 191674"},
    },
    visualMagnitude: 5.60,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.08790152),
        dec: Angle.Degrees(-28.82356853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133778"},
        {"Hipparcos Number", "HIP 73976"},
        {"Geneva Identification System", "GEN# +1.00133778"},
        {"Smithsonian Astrophysical Observation", "SAO 183188"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.77648837),
        dec: Angle.Degrees(-28.82302447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184269"},
        {"Hipparcos Number", "HIP 96293"},
        {"Geneva Identification System", "GEN# +1.00184269"},
        {"Smithsonian Astrophysical Observation", "SAO 188298"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.68594410),
        dec: Angle.Degrees(-28.82270254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89313"},
        {"Hipparcos Number", "HIP 50420"},
        {"Smithsonian Astrophysical Observation", "SAO 178636"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.42470877),
        dec: Angle.Degrees(-28.82162320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153100"},
        {"Hipparcos Number", "HIP 83078"},
        {"Smithsonian Astrophysical Observation", "SAO 184856"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.63925039),
        dec: Angle.Degrees(-28.82035583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88915"},
        {"Hipparcos Number", "HIP 50198"},
        {"Smithsonian Astrophysical Observation", "SAO 178574"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.71293683),
        dec: Angle.Degrees(-28.82026566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129196"},
        {"Hipparcos Number", "HIP 71871"},
        {"Renson", "Renson 36850"},
        {"Smithsonian Astrophysical Observation", "SAO 182776"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.50152873),
        dec: Angle.Degrees(-28.81813855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197747"},
        {"Hipparcos Number", "HIP 102522"},
        {"Smithsonian Astrophysical Observation", "SAO 189677"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.64751407),
        dec: Angle.Degrees(-28.81797005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208431"},
        {"Hipparcos Number", "HIP 108328"},
        {"Smithsonian Astrophysical Observation", "SAO 190761"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.19760769),
        dec: Angle.Degrees(-28.81758441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110592"},
        {"Hipparcos Number", "HIP 62082"},
        {"Smithsonian Astrophysical Observation", "SAO 181049"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.86422943),
        dec: Angle.Degrees(-28.81679833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184954"},
        {"Hipparcos Number", "HIP 96566"},
        {"Geneva Identification System", "GEN# +1.00184954"},
        {"Smithsonian Astrophysical Observation", "SAO 188360"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.47003061),
        dec: Angle.Degrees(-28.81600985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12084"},
        {"Hipparcos Number", "HIP 9170"},
        {"Geneva Identification System", "GEN# +1.00012084"},
        {"Smithsonian Astrophysical Observation", "SAO 167439"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.51407920),
        dec: Angle.Degrees(-28.81506476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11411"},
        {"Hipparcos Number", "HIP 8676"},
        {"Smithsonian Astrophysical Observation", "SAO 167356"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.91920726),
        dec: Angle.Degrees(-28.81450300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194587"},
        {"Hipparcos Number", "HIP 100897"},
        {"Geneva Identification System", "GEN# +1.00194587"},
        {"Smithsonian Astrophysical Observation", "SAO 189302"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.86897176),
        dec: Angle.Degrees(-28.81405021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82482",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82482"},
    },
    visualMagnitude: 10.32,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.86059707),
        dec: Angle.Degrees(+01.81335769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49188"},
        {"Hipparcos Number", "HIP 32408"},
        {"Geneva Identification System", "GEN# +1.00049188"},
        {"Smithsonian Astrophysical Observation", "SAO 172297"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.49140244),
        dec: Angle.Degrees(-28.81206280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19211",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3005 AB"},
        {"Henry Draper", "HD 26134"},
        {"Hipparcos Number", "HIP 19211"},
        {"Smithsonian Astrophysical Observation", "SAO 169138"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.76833822),
        dec: Angle.Degrees(-28.81112730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19384"},
        {"Hipparcos Number", "HIP 14418"},
        {"Smithsonian Astrophysical Observation", "SAO 168303"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.53656530),
        dec: Angle.Degrees(-28.80983745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75180"},
        {"Hipparcos Number", "HIP 43157"},
        {"Smithsonian Astrophysical Observation", "SAO 176472"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.85297363),
        dec: Angle.Degrees(-28.80639747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17097"},
        {"Hipparcos Number", "HIP 12741"},
        {"Smithsonian Astrophysical Observation", "SAO 168006"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.95083767),
        dec: Angle.Degrees(-28.80625925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28901"},
        {"Hipparcos Number", "HIP 21154"},
        {"Geneva Identification System", "GEN# +1.00028901"},
        {"Smithsonian Astrophysical Observation", "SAO 169545"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.02818382),
        dec: Angle.Degrees(-28.80611300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 162.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77087"},
        {"Hipparcos Number", "HIP 44130"},
        {"Geneva Identification System", "GEN# +1.00077087"},
        {"Smithsonian Astrophysical Observation", "SAO 176789"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.81604453),
        dec: Angle.Degrees(-28.80607879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42730"},
        {"Hipparcos Number", "HIP 29337"},
        {"Geneva Identification System", "GEN# +1.00042730"},
        {"Smithsonian Astrophysical Observation", "SAO 171353"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.77279374),
        dec: Angle.Degrees(-28.80559966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80771"},
        {"Hipparcos Number", "HIP 45842"},
        {"Smithsonian Astrophysical Observation", "SAO 177312"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.19659425),
        dec: Angle.Degrees(-28.80297484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25559",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25559"},
    },
    visualMagnitude: 10.12,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.94105136),
        dec: Angle.Degrees(-28.79963153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15392"},
        {"Hipparcos Number", "HIP 11468"},
        {"Geneva Identification System", "GEN# +1.00015392"},
        {"Smithsonian Astrophysical Observation", "SAO 167804"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.98288814),
        dec: Angle.Degrees(-28.79726319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20606"},
        {"Hipparcos Number", "HIP 15357"},
        {"Geneva Identification System", "GEN# +1.00020606"},
        {"Smithsonian Astrophysical Observation", "SAO 168449"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.51038343),
        dec: Angle.Degrees(-28.79703600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 155.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73240"},
        {"Hipparcos Number", "HIP 42217"},
        {"Smithsonian Astrophysical Observation", "SAO 176160"},
    },
    visualMagnitude: 8.11,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.10640382),
        dec: Angle.Degrees(-28.79660633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170415"},
        {"Hipparcos Number", "HIP 90715"},
        {"Smithsonian Astrophysical Observation", "SAO 186892"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.62923200),
        dec: Angle.Degrees(-28.79525217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10988"},
        {"Hipparcos Number", "HIP 8330"},
        {"Smithsonian Astrophysical Observation", "SAO 167294"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.84542731),
        dec: Angle.Degrees(-28.79507036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73521",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73521"},
        {"Smithsonian Astrophysical Observation", "SAO 183091"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.40499126),
        dec: Angle.Degrees(-28.79470351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112978",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112978"},
    },
    visualMagnitude: 11.82,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.20144081),
        dec: Angle.Degrees(-28.79451806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -407.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -277.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8253"},
        {"Hipparcos Number", "HIP 6335"},
        {"Geneva Identification System", "GEN# +1.00008253"},
        {"Smithsonian Astrophysical Observation", "SAO 166981"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.34987133),
        dec: Angle.Degrees(-28.79396169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210585"},
        {"Hipparcos Number", "HIP 109583"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.97867041),
        dec: Angle.Degrees(-28.79379050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196717"},
        {"Hipparcos Number", "HIP 101985"},
        {"Geneva Identification System", "GEN# +1.00196717"},
        {"Wilson Evans Batten Catalogue", "WEB 18435"},
    },
    visualMagnitude: 10.22,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.01247333),
        dec: Angle.Degrees(-28.79199794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47644"},
        {"Hipparcos Number", "HIP 31741"},
        {"Smithsonian Astrophysical Observation", "SAO 172075"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.60277570),
        dec: Angle.Degrees(-28.79078484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26390"},
        {"Hipparcos Number", "HIP 19396"},
        {"Smithsonian Astrophysical Observation", "SAO 169176"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.32298623),
        dec: Angle.Degrees(-28.79019453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141107"},
        {"Hipparcos Number", "HIP 77427"},
        {"Geneva Identification System", "GEN# +1.00141107"},
        {"Smithsonian Astrophysical Observation", "SAO 183810"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.09421481),
        dec: Angle.Degrees(-28.78905892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187098"},
        {"Hipparcos Number", "HIP 97515"},
        {"Fundamental Katalog 5th Edition", "FK5 3582"},
        {"Geneva Identification System", "GEN# +1.00187098"},
        {"Smithsonian Astrophysical Observation", "SAO 188603"},
        {"Wilson Evans Batten Catalogue", "WEB 17147"},
    },
    visualMagnitude: 6.04,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.29803947),
        dec: Angle.Degrees(-28.78873269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23149"},
        {"Hipparcos Number", "HIP 17258"},
        {"Smithsonian Astrophysical Observation", "SAO 168748"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.45434992),
        dec: Angle.Degrees(-28.78779510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46329",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7379 AB"},
        {"Aitken 2", "ADS 7379"},
        {"Henry Draper", "HD 81753"},
        {"Hipparcos Number", "HIP 46329"},
        {"Geneva Identification System", "GEN# +1.00081753J"},
        {"Smithsonian Astrophysical Observation", "SAO 177461"},
    },
    visualMagnitude: 6.12,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.68714002),
        dec: Angle.Degrees(-28.78768232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64438"},
        {"Hipparcos Number", "HIP 38487"},
        {"Geneva Identification System", "GEN# +1.00064438"},
        {"Smithsonian Astrophysical Observation", "SAO 174722"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.22573767),
        dec: Angle.Degrees(-28.78709586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109394",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109394"},
    },
    visualMagnitude: 11.84,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.43580027),
        dec: Angle.Degrees(-28.78672007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316407"},
        {"Hipparcos Number", "HIP 87419"},
        {"Smithsonian Astrophysical Observation", "SAO 185851"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.97037688),
        dec: Angle.Degrees(-28.78671332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27530"},
        {"Hipparcos Number", "HIP 20184"},
        {"Geneva Identification System", "GEN# +1.00027530"},
        {"Smithsonian Astrophysical Observation", "SAO 169342"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.89257620),
        dec: Angle.Degrees(-28.78639057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223106"},
        {"Hipparcos Number", "HIP 117272"},
        {"Smithsonian Astrophysical Observation", "SAO 192144"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.69912052),
        dec: Angle.Degrees(-28.78630588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15750"},
        {"Hipparcos Number", "HIP 11708"},
        {"Geneva Identification System", "GEN# +1.00015750"},
        {"Smithsonian Astrophysical Observation", "SAO 167849"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.77208914),
        dec: Angle.Degrees(-28.78517074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115661"},
        {"Hipparcos Number", "HIP 64967"},
        {"Smithsonian Astrophysical Observation", "SAO 181544"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.74234028),
        dec: Angle.Degrees(-28.78483952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20781"},
        {"Hipparcos Number", "HIP 15526"},
        {"Geneva Identification System", "GEN# +1.00020781"},
        {"Smithsonian Astrophysical Observation", "SAO 168468"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.01129402),
        dec: Angle.Degrees(-28.78366881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 349.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9650"},
        {"Hipparcos Number", "HIP 7309"},
        {"Smithsonian Astrophysical Observation", "SAO 167144"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.52258128),
        dec: Angle.Degrees(-28.78355177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201903"},
        {"Hipparcos Number", "HIP 104760"},
        {"Geneva Identification System", "GEN# +1.00201903"},
        {"Smithsonian Astrophysical Observation", "SAO 190132"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.34394212),
        dec: Angle.Degrees(-28.78293776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8717"},
        {"Hipparcos Number", "HIP 6659"},
        {"Geneva Identification System", "GEN# +1.00008717"},
        {"Renson", "Renson 2100"},
        {"Smithsonian Astrophysical Observation", "SAO 167038"},
        {"Wilson Evans Batten Catalogue", "WEB 1455"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.36514010),
        dec: Angle.Degrees(-28.78219752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36462"},
        {"Hipparcos Number", "HIP 25798"},
        {"Smithsonian Astrophysical Observation", "SAO 170495"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.63670439),
        dec: Angle.Degrees(-28.78063205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45184"},
        {"Hipparcos Number", "HIP 30503"},
        {"Geneva Identification System", "GEN# +1.00045184"},
        {"Smithsonian Astrophysical Observation", "SAO 171711"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.18328956),
        dec: Angle.Degrees(-28.77981914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -164.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82849"},
        {"Hipparcos Number", "HIP 46932"},
        {"Smithsonian Astrophysical Observation", "SAO 177661"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.48129100),
        dec: Angle.Degrees(-28.77674924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74823",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74823"},
        {"Smithsonian Astrophysical Observation", "SAO 183342"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.37120518),
        dec: Angle.Degrees(-28.77617573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18644",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2922 AB"},
        {"Henry Draper", "HD 25243"},
        {"Hipparcos Number", "HIP 18644"},
        {"Smithsonian Astrophysical Observation", "SAO 169011"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.86264754),
        dec: Angle.Degrees(-28.77398440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214287"},
        {"Hipparcos Number", "HIP 111692"},
        {"Smithsonian Astrophysical Observation", "SAO 191272"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.38372656),
        dec: Angle.Degrees(-28.77374577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20103"},
        {"Hipparcos Number", "HIP 14963"},
        {"Geneva Identification System", "GEN# +1.00020103"},
        {"Smithsonian Astrophysical Observation", "SAO 168385"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.22040814),
        dec: Angle.Degrees(-28.77353453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94425",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94425"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.27966029),
        dec: Angle.Degrees(-28.77336449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211993"},
        {"Hipparcos Number", "HIP 110393"},
        {"Geneva Identification System", "GEN# +1.00211993"},
        {"Smithsonian Astrophysical Observation", "SAO 191082"},
    },
    visualMagnitude: 8.21,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.40800628),
        dec: Angle.Degrees(-28.77265301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
