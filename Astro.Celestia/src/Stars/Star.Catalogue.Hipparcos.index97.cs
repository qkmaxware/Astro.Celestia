using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_97() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34381"},
        {"Hipparcos Number", "HIP 24793"},
        {"Geneva Identification System", "GEN# +1.00034381"},
        {"Smithsonian Astrophysical Observation", "SAO 40229"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.73081880),
        dec: Angle.Degrees(+41.09556405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182192"},
        {"Hipparcos Number", "HIP 95174"},
        {"Smithsonian Astrophysical Observation", "SAO 48364"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.42534158),
        dec: Angle.Degrees(+41.09670669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196241"},
        {"Hipparcos Number", "HIP 101533"},
        {"Geneva Identification System", "GEN# +9.00031093"},
        {"Smithsonian Astrophysical Observation", "SAO 49823"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.65001544),
        dec: Angle.Degrees(+41.09835831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27354",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27354"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.90334026),
        dec: Angle.Degrees(+41.10064250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25475"},
        {"Hipparcos Number", "HIP 19023"},
        {"Geneva Identification System", "GEN# +1.00025475"},
        {"Renson", "Renson 6502"},
        {"Smithsonian Astrophysical Observation", "SAO 39294"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.12717441),
        dec: Angle.Degrees(+41.10065441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6794",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1151 A"},
        {"Henry Draper", "HD 8801"},
        {"Hipparcos Number", "HIP 6794"},
        {"Geneva Identification System", "GEN# +1.00008801"},
        {"Renson", "Renson 2120"},
        {"Smithsonian Astrophysical Observation", "SAO 37227"},
        {"Wilson Evans Batten Catalogue", "WEB 1481"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.86110539),
        dec: Angle.Degrees(+41.10109784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117388",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117388"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.02826722),
        dec: Angle.Degrees(+41.10193574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56670",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56670"},
        {"Smithsonian Astrophysical Observation", "SAO 43828"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.30606677),
        dec: Angle.Degrees(+41.10399927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171087"},
        {"Hipparcos Number", "HIP 90747"},
        {"Geneva Identification System", "GEN# +1.00171087"},
        {"Smithsonian Astrophysical Observation", "SAO 47556"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.74099203),
        dec: Angle.Degrees(+41.10640592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223276"},
        {"Hipparcos Number", "HIP 117390"},
        {"Geneva Identification System", "GEN# +1.00223276"},
        {"Smithsonian Astrophysical Observation", "SAO 53382"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.03500126),
        dec: Angle.Degrees(+41.10800375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75032"},
        {"Hipparcos Number", "HIP 43280"},
        {"Smithsonian Astrophysical Observation", "SAO 42559"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.25250210),
        dec: Angle.Degrees(+41.10805325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133817"},
        {"Hipparcos Number", "HIP 73801"},
        {"Geneva Identification System", "GEN# +1.00133817"},
        {"Smithsonian Astrophysical Observation", "SAO 45364"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.25103254),
        dec: Angle.Degrees(+41.10946000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52823",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7929 AB"},
        {"Henry Draper", "HD 93457"},
        {"Hipparcos Number", "HIP 52823"},
        {"Renson", "Renson 27005"},
        {"Smithsonian Astrophysical Observation", "SAO 43475"},
        {"Wilson Evans Batten Catalogue", "WEB 9616"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.01070588),
        dec: Angle.Degrees(+41.10995606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89498",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11219 A"},
        {"Hipparcos Number", "HIP 89498"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.95701594),
        dec: Angle.Degrees(+41.11060704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220575"},
        {"Hipparcos Number", "HIP 115567"},
        {"Geneva Identification System", "GEN# +1.00220575"},
        {"Renson", "Renson 60490"},
        {"Smithsonian Astrophysical Observation", "SAO 52987"},
        {"Wilson Evans Batten Catalogue", "WEB 20457"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.14544429),
        dec: Angle.Degrees(+41.11291325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67513",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67513"},
    },
    visualMagnitude: 11.74,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.50663793),
        dec: Angle.Degrees(+41.11390176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83658",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83658"},
        {"Smithsonian Astrophysical Observation", "SAO 46485"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.48280607),
        dec: Angle.Degrees(+41.11428123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65675",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65675"},
        {"Geneva Identification System", "GEN# +0.04102399"},
        {"Smithsonian Astrophysical Observation", "SAO 44618"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.99314751),
        dec: Angle.Degrees(+41.11483491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50949"},
        {"Hipparcos Number", "HIP 33450"},
        {"Wilson Evans Batten Catalogue", "WEB 6727"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.32244176),
        dec: Angle.Degrees(+41.11769186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26960",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4288 B"},
        {"Hipparcos Number", "HIP 26960"},
    },
    visualMagnitude: 10.31,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.81760659),
        dec: Angle.Degrees(+41.11851899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19057"},
        {"Hipparcos Number", "HIP 14363"},
        {"Celescope Catalog", "CEL 300"},
        {"Geneva Identification System", "GEN# +1.00019057"},
        {"Smithsonian Astrophysical Observation", "SAO 38558"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.32933345),
        dec: Angle.Degrees(+41.12081299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214524"},
        {"Hipparcos Number", "HIP 111743"},
        {"Celescope Catalog", "CEL 5502"},
        {"Geneva Identification System", "GEN# +1.00214524"},
        {"Smithsonian Astrophysical Observation", "SAO 52204"},
    },
    visualMagnitude: 7.47,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.53744978),
        dec: Angle.Degrees(+41.12085646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26961",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4288 A"},
        {"Henry Draper", "HD 37841"},
        {"Hipparcos Number", "HIP 26961"},
        {"Celescope Catalog", "CEL 937"},
        {"Geneva Identification System", "GEN# +1.00037841"},
        {"Smithsonian Astrophysical Observation", "SAO 40560"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.82153522),
        dec: Angle.Degrees(+41.12287941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27970"},
        {"Hipparcos Number", "HIP 20744"},
        {"Smithsonian Astrophysical Observation", "SAO 39535"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.67740791),
        dec: Angle.Degrees(+41.12307094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36535"},
        {"Hipparcos Number", "HIP 26128"},
        {"Smithsonian Astrophysical Observation", "SAO 40439"},
        {"Wilson Evans Batten Catalogue", "WEB 5089"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.871,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.57087511),
        dec: Angle.Degrees(+41.12342530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69255",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69255"},
        {"Smithsonian Astrophysical Observation", "SAO 44922"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.67255541),
        dec: Angle.Degrees(+41.12621908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62993",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62993"},
    },
    visualMagnitude: 11.46,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.62006212),
        dec: Angle.Degrees(+41.12873212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224613"},
        {"Hipparcos Number", "HIP 118269"},
        {"Smithsonian Astrophysical Observation", "SAO 53553"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.83045572),
        dec: Angle.Degrees(+41.12899823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110763",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110763"},
        {"Smithsonian Astrophysical Observation", "SAO 51995"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.60183334),
        dec: Angle.Degrees(+41.13063973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4669"},
        {"Hipparcos Number", "HIP 3817"},
        {"Geneva Identification System", "GEN# +1.00004669"},
        {"Smithsonian Astrophysical Observation", "SAO 36685"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.25927144),
        dec: Angle.Degrees(+41.13208313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194069"},
        {"Hipparcos Number", "HIP 100434"},
        {"Geneva Identification System", "GEN# +1.00194069"},
        {"Smithsonian Astrophysical Observation", "SAO 49524"},
        {"Wilson Evans Batten Catalogue", "WEB 18133"},
    },
    visualMagnitude: 6.38,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.51272943),
        dec: Angle.Degrees(+41.13214600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110644",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110644"},
        {"Smithsonian Astrophysical Observation", "SAO 51972"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.21063806),
        dec: Angle.Degrees(+41.13231367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89468"},
        {"Hipparcos Number", "HIP 50621"},
        {"Geneva Identification System", "GEN# +1.00089468"},
        {"Smithsonian Astrophysical Observation", "SAO 43289"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.10483368),
        dec: Angle.Degrees(+41.13396292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184380"},
        {"Hipparcos Number", "HIP 96104"},
        {"Smithsonian Astrophysical Observation", "SAO 48560"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.09683561),
        dec: Angle.Degrees(+41.13589431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132089"},
        {"Hipparcos Number", "HIP 73070"},
        {"Smithsonian Astrophysical Observation", "SAO 45280"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.99940407),
        dec: Angle.Degrees(+41.13651987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68659"},
        {"Hipparcos Number", "HIP 40411"},
        {"Geneva Identification System", "GEN# +1.00068659"},
        {"Smithsonian Astrophysical Observation", "SAO 42244"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.74941775),
        dec: Angle.Degrees(+41.14131216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110144",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110144"},
        {"Smithsonian Astrophysical Observation", "SAO 51861"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.66303417),
        dec: Angle.Degrees(+41.14148196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219384"},
        {"Hipparcos Number", "HIP 114779"},
        {"Smithsonian Astrophysical Observation", "SAO 52834"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.74582905),
        dec: Angle.Degrees(+41.14244413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198495"},
        {"Hipparcos Number", "HIP 102768"},
        {"Geneva Identification System", "GEN# +1.00198495"},
        {"Smithsonian Astrophysical Observation", "SAO 50104"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.31856322),
        dec: Angle.Degrees(+41.14259224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56827",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8252 AB"},
        {"Henry Draper", "HD 101207"},
        {"Hipparcos Number", "HIP 56827"},
        {"Smithsonian Astrophysical Observation", "SAO 43844"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.73870268),
        dec: Angle.Degrees(+41.14310482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78212"},
        {"Hipparcos Number", "HIP 44865"},
        {"Fundamental Katalog 5th Edition", "FK5 4813"},
        {"Geneva Identification System", "GEN# +1.00078212"},
        {"Smithsonian Astrophysical Observation", "SAO 42711"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.11791394),
        dec: Angle.Degrees(+41.14493632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63749"},
        {"Hipparcos Number", "HIP 38415"},
        {"Smithsonian Astrophysical Observation", "SAO 42038"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.05515725),
        dec: Angle.Degrees(+41.14671278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104844",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14778 AB"},
        {"Henry Draper", "HD 202403"},
        {"Hipparcos Number", "HIP 104844"},
        {"Smithsonian Astrophysical Observation", "SAO 50604"},
        {"Wilson Evans Batten Catalogue", "WEB 19065"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.57852003),
        dec: Angle.Degrees(+41.14673441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167304"},
        {"Hipparcos Number", "HIP 89246"},
        {"Geneva Identification System", "GEN# +1.00167304"},
        {"Smithsonian Astrophysical Observation", "SAO 47305"},
        {"Wilson Evans Batten Catalogue", "WEB 15171"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.17759517),
        dec: Angle.Degrees(+41.14694669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207673"},
        {"Hipparcos Number", "HIP 107749"},
        {"Fundamental Katalog 5th Edition", "FK5 3745"},
        {"Geneva Identification System", "GEN# +1.00207673"},
        {"Smithsonian Astrophysical Observation", "SAO 51344"},
        {"Wilson Evans Batten Catalogue", "WEB 19432"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.41706759),
        dec: Angle.Degrees(+41.14880103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5723",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 994 A"},
        {"Henry Draper", "HD 7267"},
        {"Hipparcos Number", "HIP 5723"},
        {"Geneva Identification System", "GEN# +1.00007267"},
        {"Smithsonian Astrophysical Observation", "SAO 37035"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.39284013),
        dec: Angle.Degrees(+41.15079324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71905",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71905"},
        {"Smithsonian Astrophysical Observation", "SAO 45181"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.61702911),
        dec: Angle.Degrees(+41.15159675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74692",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74692"},
        {"Smithsonian Astrophysical Observation", "SAO 45453"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.97054601),
        dec: Angle.Degrees(+41.15243051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46186",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46186"},
        {"Smithsonian Astrophysical Observation", "SAO 42843"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.25438160),
        dec: Angle.Degrees(+41.15485903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206749"},
        {"Hipparcos Number", "HIP 107235"},
        {"Geneva Identification System", "GEN# +1.00206749"},
        {"Smithsonian Astrophysical Observation", "SAO 51221"},
        {"Wilson Evans Batten Catalogue", "WEB 19366"},
    },
    visualMagnitude: 5.51,
    bvColour: 1.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.77701184),
        dec: Angle.Degrees(+41.15499969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47851",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7506 AB"},
        {"Hipparcos Number", "HIP 47851"},
        {"Smithsonian Astrophysical Observation", "SAO 43016"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.30441714),
        dec: Angle.Degrees(+41.15510935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101817",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101817"},
        {"Smithsonian Astrophysical Observation", "SAO 49875"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.49451468),
        dec: Angle.Degrees(+41.15553049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93520"},
        {"Hipparcos Number", "HIP 52850"},
        {"Geneva Identification System", "GEN# +1.00093520"},
        {"Smithsonian Astrophysical Observation", "SAO 43478"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.10142065),
        dec: Angle.Degrees(+41.15771392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61252"},
        {"Hipparcos Number", "HIP 37365"},
        {"Geneva Identification System", "GEN# +1.00061252"},
        {"Smithsonian Astrophysical Observation", "SAO 41921"},
    },
    visualMagnitude: 6.83,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.05664983),
        dec: Angle.Degrees(+41.16348337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223616"},
        {"Hipparcos Number", "HIP 117601"},
        {"Smithsonian Astrophysical Observation", "SAO 53418"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.74198191),
        dec: Angle.Degrees(+41.16377003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22843",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22843"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.71820335),
        dec: Angle.Degrees(+41.16427565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199629"},
        {"Hipparcos Number", "HIP 103413"},
        {"Celescope Catalog", "CEL 5218"},
        {"Fundamental Katalog 5th Edition", "FK5 788"},
        {"Geneva Identification System", "GEN# +1.00199629"},
        {"Smithsonian Astrophysical Observation", "SAO 50274"},
        {"Wilson Evans Batten Catalogue", "WEB 18807"},
    },
    visualMagnitude: 3.94,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.29338184),
        dec: Angle.Degrees(+41.16719384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39534",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39534"},
        {"Smithsonian Astrophysical Observation", "SAO 42158"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.18592824),
        dec: Angle.Degrees(+41.16899637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118251",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118251"},
        {"Smithsonian Astrophysical Observation", "SAO 53547"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.77831769),
        dec: Angle.Degrees(+41.17054665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64315",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64315"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.72662517),
        dec: Angle.Degrees(+41.17205431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59847"},
        {"Hipparcos Number", "HIP 36769"},
        {"Smithsonian Astrophysical Observation", "SAO 41850"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.43990263),
        dec: Angle.Degrees(+41.17393670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54498",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54498"},
        {"Smithsonian Astrophysical Observation", "SAO 43625"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.24346716),
        dec: Angle.Degrees(+41.17581529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32592",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32592"},
        {"Geneva Identification System", "GEN# +2.22810045"},
        {"New General Catalogue", "NGC 2281 45"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.99528882),
        dec: Angle.Degrees(+41.17714509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99775"},
        {"Hipparcos Number", "HIP 56026"},
        {"Geneva Identification System", "GEN# +1.00099775"},
        {"Smithsonian Astrophysical Observation", "SAO 43765"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.24454886),
        dec: Angle.Degrees(+41.17796059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7614",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7614"},
        {"Smithsonian Astrophysical Observation", "SAO 37384"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.51961669),
        dec: Angle.Degrees(+41.17916581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19663"},
        {"Hipparcos Number", "HIP 14826"},
        {"Geneva Identification System", "GEN# +1.00019663"},
        {"Smithsonian Astrophysical Observation", "SAO 38626"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.85396451),
        dec: Angle.Degrees(+41.18057625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201910"},
        {"Hipparcos Number", "HIP 104599"},
        {"Celescope Catalog", "CEL 5263"},
        {"Geneva Identification System", "GEN# +1.00201910"},
        {"Smithsonian Astrophysical Observation", "SAO 50546"},
        {"Wilson Evans Batten Catalogue", "WEB 19034"},
    },
    visualMagnitude: 7.41,
    bvColour: -0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.84138359),
        dec: Angle.Degrees(+41.18517273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114123",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114123"},
        {"Smithsonian Astrophysical Observation", "SAO 52690"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.67757309),
        dec: Angle.Degrees(+41.18576584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73539",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73539"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.805,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.45628406),
        dec: Angle.Degrees(+41.18605141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275054"},
        {"Hipparcos Number", "HIP 15437"},
        {"Geneva Identification System", "GEN# +1.00275054"},
        {"Smithsonian Astrophysical Observation", "SAO 38715"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.73816025),
        dec: Angle.Degrees(+41.18635135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6778",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6778"},
        {"Smithsonian Astrophysical Observation", "SAO 37221"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.78482586),
        dec: Angle.Degrees(+41.18666534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69513",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9175 AB"},
        {"Henry Draper", "HD 124641"},
        {"Hipparcos Number", "HIP 69513"},
        {"Smithsonian Astrophysical Observation", "SAO 44943"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.44855486),
        dec: Angle.Degrees(+41.18758047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40958"},
        {"Hipparcos Number", "HIP 28737"},
        {"Geneva Identification System", "GEN# +1.00040958"},
        {"Smithsonian Astrophysical Observation", "SAO 40828"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.03333729),
        dec: Angle.Degrees(+41.18830423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22732"},
        {"Hipparcos Number", "HIP 17196"},
        {"Fundamental Katalog 5th Edition", "FK5 4333"},
        {"Geneva Identification System", "GEN# +1.00022732"},
        {"Smithsonian Astrophysical Observation", "SAO 39038"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.23384743),
        dec: Angle.Degrees(+41.18857606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 88.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66470"},
        {"Hipparcos Number", "HIP 39593"},
        {"Smithsonian Astrophysical Observation", "SAO 42168"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.35515698),
        dec: Angle.Degrees(+41.19013602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82109",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82109"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.57481991),
        dec: Angle.Degrees(+41.19132150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48818",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48818"},
        {"Smithsonian Astrophysical Observation", "SAO 43114"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.37533755),
        dec: Angle.Degrees(+41.19401310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105824",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105824"},
        {"Smithsonian Astrophysical Observation", "SAO 50838"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.49672416),
        dec: Angle.Degrees(+41.19442452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62284"},
        {"Hipparcos Number", "HIP 37800"},
        {"Smithsonian Astrophysical Observation", "SAO 41977"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.26214378),
        dec: Angle.Degrees(+41.19456721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30877"},
        {"Smithsonian Astrophysical Observation", "SAO 41122"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.22733529),
        dec: Angle.Degrees(+41.19494639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154256"},
        {"Hipparcos Number", "HIP 83382"},
        {"Geneva Identification System", "GEN# +1.00154256"},
        {"Smithsonian Astrophysical Observation", "SAO 46447"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.62474324),
        dec: Angle.Degrees(+41.19522711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81774",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10169 AB"},
        {"Henry Draper", "HD 150903"},
        {"Hipparcos Number", "HIP 81774"},
        {"Smithsonian Astrophysical Observation", "SAO 46234"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.54062735),
        dec: Angle.Degrees(+41.19524362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183055"},
        {"Hipparcos Number", "HIP 95528"},
        {"Smithsonian Astrophysical Observation", "SAO 48430"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.47446812),
        dec: Angle.Degrees(+41.19799190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 277667"},
        {"Hipparcos Number", "HIP 24101"},
        {"Celescope Catalog", "CEL 550"},
        {"Geneva Identification System", "GEN# +1.00277667"},
        {"Smithsonian Astrophysical Observation", "SAO 40079"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.65798656),
        dec: Angle.Degrees(+41.19806938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183613"},
        {"Hipparcos Number", "HIP 95761"},
        {"Fundamental Katalog 5th Edition", "FK5 5714"},
        {"Smithsonian Astrophysical Observation", "SAO 48492"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.15987796),
        dec: Angle.Degrees(+41.19826505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87313",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10835 AB"},
        {"Hipparcos Number", "HIP 87313"},
        {"Smithsonian Astrophysical Observation", "SAO 46999"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.61312989),
        dec: Angle.Degrees(+41.19982032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41468"},
        {"Hipparcos Number", "HIP 29016"},
        {"Smithsonian Astrophysical Observation", "SAO 40867"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.84406345),
        dec: Angle.Degrees(+41.20038243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224602"},
        {"Hipparcos Number", "HIP 118254"},
        {"Geneva Identification System", "GEN# +1.00224602"},
        {"Smithsonian Astrophysical Observation", "SAO 53549"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.78738056),
        dec: Angle.Degrees(+41.20173610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76584",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76584"},
        {"Smithsonian Astrophysical Observation", "SAO 45649"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.60772245),
        dec: Angle.Degrees(+41.20188830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197204"},
        {"Hipparcos Number", "HIP 102051"},
        {"Celescope Catalog", "CEL 5140"},
        {"Fundamental Katalog 5th Edition", "FK5 5819"},
        {"Geneva Identification System", "GEN# +1.00197204"},
        {"Smithsonian Astrophysical Observation", "SAO 49929"},
    },
    visualMagnitude: 7.01,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.22196887),
        dec: Angle.Degrees(+41.20249882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220932"},
        {"Hipparcos Number", "HIP 115791"},
        {"Smithsonian Astrophysical Observation", "SAO 53045"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.86749875),
        dec: Angle.Degrees(+41.20262227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215593"},
        {"Hipparcos Number", "HIP 112382"},
        {"Smithsonian Astrophysical Observation", "SAO 52340"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.42350920),
        dec: Angle.Degrees(+41.20262416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 162.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 118.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63524",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63524"},
    },
    visualMagnitude: 11.37,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.25765076),
        dec: Angle.Degrees(+41.20445259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46256",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46256"},
        {"Smithsonian Astrophysical Observation", "SAO 42851"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.45749029),
        dec: Angle.Degrees(+41.20675920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67900",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67900"},
        {"Smithsonian Astrophysical Observation", "SAO 44795"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.60403574),
        dec: Angle.Degrees(+41.20678351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47280",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47280"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.52820636),
        dec: Angle.Degrees(+41.20691496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20872"},
        {"Hipparcos Number", "HIP 15791"},
        {"Smithsonian Astrophysical Observation", "SAO 38776"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.87745451),
        dec: Angle.Degrees(+41.20699477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55331"},
        {"Hipparcos Number", "HIP 34988"},
        {"Geneva Identification System", "GEN# +1.00055331"},
        {"Smithsonian Astrophysical Observation", "SAO 41636"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.58543178),
        dec: Angle.Degrees(+41.21016421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89573"},
        {"Hipparcos Number", "HIP 50691"},
        {"Smithsonian Astrophysical Observation", "SAO 43297"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.27753081),
        dec: Angle.Degrees(+41.21150747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141022"},
        {"Hipparcos Number", "HIP 77153"},
        {"Smithsonian Astrophysical Observation", "SAO 45706"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.28653067),
        dec: Angle.Degrees(+41.21167899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45023",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45023"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.56496325),
        dec: Angle.Degrees(+41.21233517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12245"},
        {"Hipparcos Number", "HIP 9438"},
        {"Smithsonian Astrophysical Observation", "SAO 37701"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.30679758),
        dec: Angle.Degrees(+41.21235515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135322"},
        {"Hipparcos Number", "HIP 74462"},
        {"Smithsonian Astrophysical Observation", "SAO 45437"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.24722963),
        dec: Angle.Degrees(+41.21259092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169243"},
        {"Hipparcos Number", "HIP 90007"},
        {"Smithsonian Astrophysical Observation", "SAO 47418"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.46699712),
        dec: Angle.Degrees(+41.21340016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33461"},
        {"Hipparcos Number", "HIP 24238"},
        {"Geneva Identification System", "GEN# +1.00033461"},
        {"Smithsonian Astrophysical Observation", "SAO 40108"},
        {"Wilson Evans Batten Catalogue", "WEB 4705"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.06039811),
        dec: Angle.Degrees(+41.21522502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66508",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66508"},
        {"Geneva Identification System", "GEN# +0.04102415"},
        {"Smithsonian Astrophysical Observation", "SAO 44690"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.49837392),
        dec: Angle.Degrees(+41.21633184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111175",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16018 A"},
        {"Henry Draper", "HD 213532"},
        {"Hipparcos Number", "HIP 111175"},
        {"Smithsonian Astrophysical Observation", "SAO 52101"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.83417305),
        dec: Angle.Degrees(+41.21861088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34492"},
        {"Hipparcos Number", "HIP 24852"},
        {"Geneva Identification System", "GEN# +1.00034492"},
        {"Renson", "Renson 8800"},
        {"Smithsonian Astrophysical Observation", "SAO 40238"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.91968331),
        dec: Angle.Degrees(+41.22021138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5553",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 974 AB"},
        {"Henry Draper", "HD 7018"},
        {"Hipparcos Number", "HIP 5553"},
        {"Smithsonian Astrophysical Observation", "SAO 37001"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.81066005),
        dec: Angle.Degrees(+41.22146549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207610"},
        {"Hipparcos Number", "HIP 107712"},
        {"Geneva Identification System", "GEN# +1.00207610"},
        {"Smithsonian Astrophysical Observation", "SAO 51330"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.29742875),
        dec: Angle.Degrees(+41.22336615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 184.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 124.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175576"},
        {"Hipparcos Number", "HIP 92771"},
        {"Geneva Identification System", "GEN# +1.00175576"},
        {"Smithsonian Astrophysical Observation", "SAO 47902"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.55968798),
        dec: Angle.Degrees(+41.22574437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188500"},
        {"Hipparcos Number", "HIP 97914"},
        {"Smithsonian Astrophysical Observation", "SAO 48947"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.46809721),
        dec: Angle.Degrees(+41.22932481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111172",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16018 BC"},
        {"Hipparcos Number", "HIP 111172"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.82763572),
        dec: Angle.Degrees(+41.22981506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89744"},
        {"Hipparcos Number", "HIP 50786"},
        {"Geneva Identification System", "GEN# +1.00089744"},
        {"Smithsonian Astrophysical Observation", "SAO 43309"},
        {"Wilson Evans Batten Catalogue", "WEB 9295"},
    },
    visualMagnitude: 5.73,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.54439708),
        dec: Angle.Degrees(+41.22986684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4902"},
        {"Hipparcos Number", "HIP 4017"},
        {"Celescope Catalog", "CEL 95"},
        {"Geneva Identification System", "GEN# +1.00004902"},
        {"Smithsonian Astrophysical Observation", "SAO 36718"},
        {"Wilson Evans Batten Catalogue", "WEB 718"},
    },
    visualMagnitude: 7.26,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.87554510),
        dec: Angle.Degrees(+41.23185846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42141"},
        {"Hipparcos Number", "HIP 29332"},
        {"Smithsonian Astrophysical Observation", "SAO 40920"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.76526483),
        dec: Angle.Degrees(+41.23251465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23767",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Haedus"},
        {"Henry Draper", "HD 32630"},
        {"Hipparcos Number", "HIP 23767"},
        {"Celescope Catalog", "CEL 531"},
        {"Fundamental Katalog 5th Edition", "FK5 185"},
        {"Geneva Identification System", "GEN# +1.00032630"},
        {"Smithsonian Astrophysical Observation", "SAO 40026"},
        {"Wilson Evans Batten Catalogue", "WEB 4637"},
    },
    visualMagnitude: 3.18,
    bvColour: -0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.62862102),
        dec: Angle.Degrees(+41.23464074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90509"},
        {"Hipparcos Number", "HIP 51222"},
        {"Geneva Identification System", "GEN# +1.00090509"},
        {"Smithsonian Astrophysical Observation", "SAO 43348"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.93281739),
        dec: Angle.Degrees(+41.23585619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112744",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112744"},
        {"Smithsonian Astrophysical Observation", "SAO 52403"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.48734533),
        dec: Angle.Degrees(+41.23586732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7243"},
        {"Hipparcos Number", "HIP 5698"},
        {"Smithsonian Astrophysical Observation", "SAO 37031"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.33559575),
        dec: Angle.Degrees(+41.23644897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101620"},
        {"Hipparcos Number", "HIP 57053"},
        {"Geneva Identification System", "GEN# +1.00101620"},
        {"Smithsonian Astrophysical Observation", "SAO 43864"},
        {"Wilson Evans Batten Catalogue", "WEB 10270"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.44294565),
        dec: Angle.Degrees(+41.23767380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179869"},
        {"Hipparcos Number", "HIP 94354"},
        {"Smithsonian Astrophysical Observation", "SAO 48191"},
        {"Wilson Evans Batten Catalogue", "WEB 16438"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.07250066),
        dec: Angle.Degrees(+41.23777232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8380",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8380"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.01191134),
        dec: Angle.Degrees(+41.23924127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104614",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14733 AB"},
        {"Henry Draper", "HD 201936"},
        {"Hipparcos Number", "HIP 104614"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.87872542),
        dec: Angle.Degrees(+41.24142841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101364",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Cyg OB2 12"},
        {"Common Name 2", "VI Cyg 12"},
        {"Hipparcos Number", "HIP 101364"},
        {"Geneva Identification System", "GEN# +9.00030012"},
        {"Geneva Identification System 2", "GEN# +9.00030041"},
        {"Geneva Identification System 3", "GEN# +8.03410034"},
    },
    visualMagnitude: 11.40,
    bvColour: 3.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.17065606),
        dec: Angle.Degrees(+41.24147429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159501"},
        {"Hipparcos Number", "HIP 85888"},
        {"Fundamental Katalog 5th Edition", "FK5 1462"},
        {"Geneva Identification System", "GEN# +1.00159501"},
        {"Smithsonian Astrophysical Observation", "SAO 46792"},
        {"Wilson Evans Batten Catalogue", "WEB 14496"},
    },
    visualMagnitude: 5.72,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.28045982),
        dec: Angle.Degrees(+41.24359953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136710"},
        {"Hipparcos Number", "HIP 75099"},
        {"Geneva Identification System", "GEN# +1.00136710"},
        {"Smithsonian Astrophysical Observation", "SAO 45496"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.18915780),
        dec: Angle.Degrees(+41.24658139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191944"},
        {"Hipparcos Number", "HIP 99420"},
        {"Smithsonian Astrophysical Observation", "SAO 49274"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.68443148),
        dec: Angle.Degrees(+41.24702079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148590"},
        {"Hipparcos Number", "HIP 80592"},
        {"Geneva Identification System", "GEN# +1.00148590"},
        {"Smithsonian Astrophysical Observation", "SAO 46096"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.81407330),
        dec: Angle.Degrees(+41.24845319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77551",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77551"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.50716135),
        dec: Angle.Degrees(+41.24890711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119704"},
        {"Hipparcos Number", "HIP 67011"},
        {"Geneva Identification System", "GEN# +1.00119704"},
        {"Smithsonian Astrophysical Observation", "SAO 44728"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.00095201),
        dec: Angle.Degrees(+41.24929656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29332"},
        {"Hipparcos Number", "HIP 21667"},
        {"Smithsonian Astrophysical Observation", "SAO 39667"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.77037233),
        dec: Angle.Degrees(+41.25000780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87857",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87857"},
        {"Smithsonian Astrophysical Observation", "SAO 47078"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.21572048),
        dec: Angle.Degrees(+41.25152878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101419",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "VI Cyg 9"},
        {"Common Name 2", "Cyg OB2 9"},
        {"Hipparcos Number", "HIP 101419"},
        {"Geneva Identification System", "GEN# +8.03410036"},
        {"Geneva Identification System 2", "GEN# +9.00030009"},
        {"Geneva Identification System 3", "GEN# +9.00030035"},
    },
    visualMagnitude: 10.78,
    bvColour: 1.825,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.29474284),
        dec: Angle.Degrees(+41.25229442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101989",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101989"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.03243923),
        dec: Angle.Degrees(+41.25277139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 170.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 109.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56117",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56117"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.54913040),
        dec: Angle.Degrees(+41.25526887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21038"},
        {"Hipparcos Number", "HIP 15925"},
        {"Geneva Identification System", "GEN# +1.00021038"},
        {"Smithsonian Astrophysical Observation", "SAO 38809"},
        {"Wilson Evans Batten Catalogue", "WEB 3041"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.28913697),
        dec: Angle.Degrees(+41.25728591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59174"},
        {"Hipparcos Number", "HIP 36511"},
        {"Smithsonian Astrophysical Observation", "SAO 41823"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.66655126),
        dec: Angle.Degrees(+41.25800982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53713"},
        {"Hipparcos Number", "HIP 34403"},
        {"Geneva Identification System", "GEN# +1.00053713"},
        {"Smithsonian Astrophysical Observation", "SAO 41577"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.99029026),
        dec: Angle.Degrees(+41.25860935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18788"},
        {"Hipparcos Number", "HIP 14179"},
        {"Smithsonian Astrophysical Observation", "SAO 38529"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.70696987),
        dec: Angle.Degrees(+41.25877022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6611"},
        {"Henry Draper 2", "HD 6611A"},
        {"Hipparcos Number", "HIP 5276"},
        {"Geneva Identification System", "GEN# +1.00006611"},
        {"Smithsonian Astrophysical Observation", "SAO 36943"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.86936763),
        dec: Angle.Degrees(+41.25901151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62700",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62700"},
        {"Geneva Identification System", "GEN# +0.04202345"},
        {"Smithsonian Astrophysical Observation", "SAO 44351"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.72652611),
        dec: Angle.Degrees(+41.25915086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110687"},
        {"Hipparcos Number", "HIP 62097"},
        {"Geneva Identification System", "GEN# +1.00110687"},
        {"Smithsonian Astrophysical Observation", "SAO 44300"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.89062012),
        dec: Angle.Degrees(+41.26151878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181068"},
        {"Henry Draper 2", "HD 181068C"},
        {"Henry Draper 3", "HD 181068A"},
        {"Henry Draper 4", "HD 181068B"},
        {"Hipparcos Number", "HIP 94780"},
        {"Geneva Identification System", "GEN# +1.00181068"},
        {"Smithsonian Astrophysical Observation", "SAO 48282"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.28740871),
        dec: Angle.Degrees(+41.26482786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29094"},
        {"Henry Draper 2", "HD 29095"},
        {"Hipparcos Number", "HIP 21476"},
        {"Fundamental Katalog 5th Edition", "FK5 2338"},
        {"Geneva Identification System", "GEN# +1.00029094"},
        {"Smithsonian Astrophysical Observation", "SAO 39639"},
        {"Wilson Evans Batten Catalogue", "WEB 4121"},
    },
    visualMagnitude: 4.25,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.17264013),
        dec: Angle.Degrees(+41.26485467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118143"},
        {"Hipparcos Number", "HIP 66201"},
        {"Geneva Identification System", "GEN# +1.00118143"},
        {"Smithsonian Astrophysical Observation", "SAO 44664"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.54128089),
        dec: Angle.Degrees(+41.26997505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181679"},
        {"Hipparcos Number", "HIP 94972"},
        {"Geneva Identification System", "GEN# +1.00181679"},
        {"Smithsonian Astrophysical Observation", "SAO 48331"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.89047266),
        dec: Angle.Degrees(+41.27119870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275052"},
        {"Hipparcos Number", "HIP 15446"},
    },
    visualMagnitude: 10.55,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.79276671),
        dec: Angle.Degrees(+41.27167664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33783",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33783"},
        {"Smithsonian Astrophysical Observation", "SAO 41496"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.22618029),
        dec: Angle.Degrees(+41.27370064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218042"},
        {"Hipparcos Number", "HIP 113938"},
        {"Celescope Catalog", "CEL 5563"},
        {"Geneva Identification System", "GEN# +1.00218042"},
        {"Smithsonian Astrophysical Observation", "SAO 52651"},
    },
    visualMagnitude: 7.77,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.10387105),
        dec: Angle.Degrees(+41.27441602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126511"},
        {"Hipparcos Number", "HIP 70470"},
        {"Geneva Identification System", "GEN# +1.00126511"},
        {"Smithsonian Astrophysical Observation", "SAO 45046"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.20442741),
        dec: Angle.Degrees(+41.27561662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -209.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88959"},
        {"Hipparcos Number", "HIP 50325"},
        {"Geneva Identification System", "GEN# +1.00088959"},
        {"Smithsonian Astrophysical Observation", "SAO 43264"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.15883074),
        dec: Angle.Degrees(+41.27589632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172068"},
        {"Hipparcos Number", "HIP 91192"},
        {"Celescope Catalog", "CEL 4634"},
        {"Geneva Identification System", "GEN# +1.00172068J"},
        {"Smithsonian Astrophysical Observation", "SAO 47639"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.04997430),
        dec: Angle.Degrees(+41.27807382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217799"},
        {"Hipparcos Number", "HIP 113796"},
        {"Geneva Identification System", "GEN# +1.00217799"},
        {"Smithsonian Astrophysical Observation", "SAO 52625"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.68180163),
        dec: Angle.Degrees(+41.27851648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190916"},
        {"Hipparcos Number", "HIP 98975"},
        {"Geneva Identification System", "GEN# +1.00190916"},
        {"Smithsonian Astrophysical Observation", "SAO 49173"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.41084425),
        dec: Angle.Degrees(+41.27986188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104557"},
        {"Hipparcos Number", "HIP 58716"},
        {"Geneva Identification System", "GEN# +1.00104557"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.64668249),
        dec: Angle.Degrees(+41.28067174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46880"},
        {"Hipparcos Number", "HIP 31687"},
        {"Smithsonian Astrophysical Observation", "SAO 41220"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.44187126),
        dec: Angle.Degrees(+41.28134439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25773",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4083 AB"},
        {"Henry Draper", "HD 35951"},
        {"Hipparcos Number", "HIP 25773"},
        {"Smithsonian Astrophysical Observation", "SAO 40378"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.55465769),
        dec: Angle.Degrees(+41.28252127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22544"},
        {"Hipparcos Number", "HIP 17042"},
        {"Smithsonian Astrophysical Observation", "SAO 39020"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.80072805),
        dec: Angle.Degrees(+41.28279370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42525",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6905 A"},
        {"Hipparcos Number", "HIP 42525"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.04985720),
        dec: Angle.Degrees(+41.28551565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74789",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9571 A"},
        {"Henry Draper", "HD 136045"},
        {"Hipparcos Number", "HIP 74789"},
        {"Geneva Identification System", "GEN# +1.00136045"},
        {"Smithsonian Astrophysical Observation", "SAO 45467"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.26640617),
        dec: Angle.Degrees(+41.28569555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200528"},
        {"Hipparcos Number", "HIP 103856"},
    },
    visualMagnitude: 8.59,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.66585753),
        dec: Angle.Degrees(+41.28588302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56165",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8189 AB"},
        {"Henry Draper", "HD 100018"},
        {"Hipparcos Number", "HIP 56165"},
        {"Geneva Identification System", "GEN# +1.00100018J"},
        {"Smithsonian Astrophysical Observation", "SAO 43789"},
        {"Wilson Evans Batten Catalogue", "WEB 10084"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.70765156),
        dec: Angle.Degrees(+41.28710842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45627",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45627"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.50316280),
        dec: Angle.Degrees(+41.28836701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32419"},
        {"Hipparcos Number", "HIP 23657"},
        {"Celescope Catalog", "CEL 524"},
        {"Smithsonian Astrophysical Observation", "SAO 40003"},
        {"Wilson Evans Batten Catalogue", "WEB 4614"},
    },
    visualMagnitude: 8.83,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.26458237),
        dec: Angle.Degrees(+41.28864610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8644",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8644"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.86281412),
        dec: Angle.Degrees(+41.29120377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122502"},
        {"Hipparcos Number", "HIP 68497"},
        {"Geneva Identification System", "GEN# +1.00122502"},
        {"Smithsonian Astrophysical Observation", "SAO 44849"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.33293176),
        dec: Angle.Degrees(+41.29160623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142453"},
        {"Hipparcos Number", "HIP 77791"},
        {"Smithsonian Astrophysical Observation", "SAO 45777"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.26831778),
        dec: Angle.Degrees(+41.29547510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215745"},
        {"Hipparcos Number", "HIP 112456"},
        {"Smithsonian Astrophysical Observation", "SAO 52357"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.69837210),
        dec: Angle.Degrees(+41.29621714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192803"},
        {"Hipparcos Number", "HIP 99813"},
        {"Celescope Catalog", "CEL 4996"},
        {"Geneva Identification System", "GEN# +1.00192803J"},
        {"Smithsonian Astrophysical Observation", "SAO 49365"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.78376501),
        dec: Angle.Degrees(+41.29873006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28503",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28503"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.26072614),
        dec: Angle.Degrees(+41.30118916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48072"},
        {"Hipparcos Number", "HIP 32217"},
        {"Smithsonian Astrophysical Observation", "SAO 41296"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.88810468),
        dec: Angle.Degrees(+41.30135429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49009"},
        {"Hipparcos Number", "HIP 32623"},
        {"Geneva Identification System", "GEN# +2.22810063"},
        {"Smithsonian Astrophysical Observation", "SAO 41354"},
        {"Wilson Evans Batten Catalogue", "WEB 6578"},
        {"New General Catalogue", "NGC 2281 63"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.09052673),
        dec: Angle.Degrees(+41.30234086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87046"},
        {"Hipparcos Number", "HIP 49271"},
        {"Smithsonian Astrophysical Observation", "SAO 43164"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.86509019),
        dec: Angle.Degrees(+41.30475116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30152"},
        {"Hipparcos Number", "HIP 22236"},
        {"Celescope Catalog", "CEL 462"},
        {"Geneva Identification System", "GEN# +1.00030152"},
        {"Smithsonian Astrophysical Observation", "SAO 39748"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.75888622),
        dec: Angle.Degrees(+41.30504731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101341",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "VI Cyg 5"},
        {"Common Name 2", "Cyg OB2 5"},
        {"Hipparcos Number", "HIP 101341"},
        {"Geneva Identification System", "GEN# +9.00030629V"},
        {"Geneva Identification System 2", "GEN# +9.00030629"},
        {"Geneva Identification System 3", "GEN# +9.00030005"},
        {"Wilson Evans Batten Catalogue", "WEB 18312"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.09343797),
        dec: Angle.Degrees(+41.30527289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38956",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38956"},
        {"Geneva Identification System", "GEN# +9.80111047"},
    },
    visualMagnitude: 12.02,
    bvColour: 1.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.55222364),
        dec: Angle.Degrees(+41.30537105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 212.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -685.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50327",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50327"},
        {"Smithsonian Astrophysical Observation", "SAO 43265"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.16304963),
        dec: Angle.Degrees(+41.30550106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5283",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5283"},
        {"Smithsonian Astrophysical Observation", "SAO 36945"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.89269023),
        dec: Angle.Degrees(+41.30632525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212584"},
        {"Hipparcos Number", "HIP 110622"},
        {"Smithsonian Astrophysical Observation", "SAO 51969"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.15395314),
        dec: Angle.Degrees(+41.30666823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56722",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56722"},
        {"Smithsonian Astrophysical Observation", "SAO 43833"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.44830726),
        dec: Angle.Degrees(+41.30756602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93044"},
        {"Hipparcos Number", "HIP 52602"},
        {"Geneva Identification System", "GEN# +1.00093044"},
        {"Smithsonian Astrophysical Observation", "SAO 43461"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.34757597),
        dec: Angle.Degrees(+41.30777490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7145"},
        {"Hipparcos Number", "HIP 5637"},
        {"Smithsonian Astrophysical Observation", "SAO 37022"},
    },
    visualMagnitude: 8.62,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.10257856),
        dec: Angle.Degrees(+41.30863750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112888",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16321 E"},
        {"Henry Draper", "HD 216341"},
        {"Hipparcos Number", "HIP 112888"},
        {"Geneva Identification System", "GEN# +1.00216341"},
        {"Smithsonian Astrophysical Observation", "SAO 52431"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.91229314),
        dec: Angle.Degrees(+41.30876913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53411"},
        {"Hipparcos Number", "HIP 34315"},
        {"Geneva Identification System", "GEN# +1.00053411"},
        {"Smithsonian Astrophysical Observation", "SAO 41559"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.71496590),
        dec: Angle.Degrees(+41.30995096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57180"},
        {"Hipparcos Number", "HIP 35704"},
        {"Geneva Identification System", "GEN# +1.00057180"},
        {"Smithsonian Astrophysical Observation", "SAO 41715"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.50176952),
        dec: Angle.Degrees(+41.31110692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220285"},
        {"Hipparcos Number", "HIP 115375"},
        {"Geneva Identification System", "GEN# +1.00220285"},
        {"Smithsonian Astrophysical Observation", "SAO 52944"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.57638289),
        dec: Angle.Degrees(+41.31268527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112905",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16321 A"},
        {"Henry Draper", "HD 216369"},
        {"Hipparcos Number", "HIP 112905"},
        {"Celescope Catalog", "CEL 5533"},
        {"Geneva Identification System", "GEN# +1.00216369"},
        {"Smithsonian Astrophysical Observation", "SAO 52433"},
        {"Wilson Evans Batten Catalogue", "WEB 20106"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.95588643),
        dec: Angle.Degrees(+41.31297200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8000",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8000"},
        {"Smithsonian Astrophysical Observation", "SAO 37454"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.68413894),
        dec: Angle.Degrees(+41.31301000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90301",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90301"},
        {"Smithsonian Astrophysical Observation", "SAO 47480"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.37873727),
        dec: Angle.Degrees(+41.31380424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101425",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "VI Cyg 8"},
        {"Common Name 2", "Cyg OB2 8"},
        {"Hipparcos Number", "HIP 101425"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.31283272),
        dec: Angle.Degrees(+41.31403597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214821"},
        {"Hipparcos Number", "HIP 111905"},
        {"Smithsonian Astrophysical Observation", "SAO 52246"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.01955433),
        dec: Angle.Degrees(+41.31425357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24396"},
        {"Hipparcos Number", "HIP 18279"},
        {"Smithsonian Astrophysical Observation", "SAO 39187"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.64723528),
        dec: Angle.Degrees(+41.32185599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218805"},
        {"Hipparcos Number", "HIP 114432"},
        {"Geneva Identification System", "GEN# +1.00218805"},
        {"Smithsonian Astrophysical Observation", "SAO 52762"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.62234089),
        dec: Angle.Degrees(+41.32208874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39660"},
        {"Hipparcos Number", "HIP 28054"},
        {"Fundamental Katalog 5th Edition", "FK5 4541"},
        {"Geneva Identification System", "GEN# +1.00039660"},
        {"Smithsonian Astrophysical Observation", "SAO 40707"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.98591641),
        dec: Angle.Degrees(+41.32337809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150812"},
        {"Hipparcos Number", "HIP 81718"},
        {"Geneva Identification System", "GEN# +1.00150812"},
        {"Smithsonian Astrophysical Observation", "SAO 46229"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.38041170),
        dec: Angle.Degrees(+41.32339564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14137"},
        {"Hipparcos Number", "HIP 10749"},
        {"Smithsonian Astrophysical Observation", "SAO 37936"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.57211752),
        dec: Angle.Degrees(+41.32594118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89927",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89927"},
        {"Smithsonian Astrophysical Observation", "SAO 47405"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.24004501),
        dec: Angle.Degrees(+41.32658900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -254.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1951",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1951"},
        {"Smithsonian Astrophysical Observation", "SAO 36336"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.16357358),
        dec: Angle.Degrees(+41.32684915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184565"},
        {"Hipparcos Number", "HIP 96179"},
        {"Smithsonian Astrophysical Observation", "SAO 48582"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.34070114),
        dec: Angle.Degrees(+41.32974208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77831",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77831"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.38104895),
        dec: Angle.Degrees(+41.33037310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -213.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 139.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102759"},
        {"Hipparcos Number", "HIP 57699"},
        {"Smithsonian Astrophysical Observation", "SAO 43905"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.49603475),
        dec: Angle.Degrees(+41.33166379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108020"},
        {"Hipparcos Number", "HIP 60539"},
        {"Geneva Identification System", "GEN# +1.00108020"},
        {"Smithsonian Astrophysical Observation", "SAO 44162"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.15893897),
        dec: Angle.Degrees(+41.33240156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112901",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16321 C"},
        {"Henry Draper", "HD 216353"},
        {"Hipparcos Number", "HIP 112901"},
        {"Geneva Identification System", "GEN# +1.00216353"},
        {"Smithsonian Astrophysical Observation", "SAO 52432"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.94418754),
        dec: Angle.Degrees(+41.33399131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275917"},
        {"Hipparcos Number", "HIP 18231"},
        {"Smithsonian Astrophysical Observation", "SAO 39180"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.46179773),
        dec: Angle.Degrees(+41.33475867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33815"},
        {"Hipparcos Number", "HIP 24455"},
        {"Smithsonian Astrophysical Observation", "SAO 40152"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.70505661),
        dec: Angle.Degrees(+41.33499690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216854"},
        {"Hipparcos Number", "HIP 113245"},
        {"Celescope Catalog", "CEL 5542"},
        {"Geneva Identification System", "GEN# +1.00216854"},
        {"Smithsonian Astrophysical Observation", "SAO 52502"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.98626751),
        dec: Angle.Degrees(+41.33512803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18830"},
        {"Hipparcos Number", "HIP 14207"},
        {"Smithsonian Astrophysical Observation", "SAO 38532"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.79695055),
        dec: Angle.Degrees(+41.33517191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194779"},
        {"Hipparcos Number", "HIP 100771"},
        {"Geneva Identification System", "GEN# +1.00194779"},
        {"Smithsonian Astrophysical Observation", "SAO 49609"},
        {"Wilson Evans Batten Catalogue", "WEB 18212"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.47948785),
        dec: Angle.Degrees(+41.33660007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20920"},
        {"Hipparcos Number", "HIP 15831"},
        {"Smithsonian Astrophysical Observation", "SAO 38784"},
    },
    visualMagnitude: 8.04,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.98147314),
        dec: Angle.Degrees(+41.33704682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128367"},
        {"Hipparcos Number", "HIP 71329"},
        {"Smithsonian Astrophysical Observation", "SAO 45122"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.80609478),
        dec: Angle.Degrees(+41.33835242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94425"},
        {"Hipparcos Number", "HIP 53341"},
        {"Cincinnati Publication", "Ci 18 1320"},
        {"Smithsonian Astrophysical Observation", "SAO 43518"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.64082804),
        dec: Angle.Degrees(+41.33848847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76386"},
        {"Hipparcos Number", "HIP 43963"},
        {"Smithsonian Astrophysical Observation", "SAO 42616"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.30046055),
        dec: Angle.Degrees(+41.34077668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4903",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 863 A"},
        {"Henry Draper", "HD 6116"},
        {"Hipparcos Number", "HIP 4903"},
        {"Geneva Identification System", "GEN# +1.00006116"},
        {"Renson", "Renson 1570"},
        {"Smithsonian Astrophysical Observation", "SAO 36874"},
        {"Wilson Evans Batten Catalogue", "WEB 962"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.72614941),
        dec: Angle.Degrees(+41.34519861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223835"},
        {"Hipparcos Number", "HIP 117769"},
        {"Smithsonian Astrophysical Observation", "SAO 53445"},
        {"Wilson Evans Batten Catalogue", "WEB 20723"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.25029651),
        dec: Angle.Degrees(+41.34569723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188101"},
        {"Hipparcos Number", "HIP 97750"},
        {"Smithsonian Astrophysical Observation", "SAO 48913"},
    },
    visualMagnitude: 7.74,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.96248358),
        dec: Angle.Degrees(+41.34880137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12100"},
        {"Hipparcos Number", "HIP 9320"},
        {"Geneva Identification System", "GEN# +1.00012100"},
        {"Smithsonian Astrophysical Observation", "SAO 37685"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.93009000),
        dec: Angle.Degrees(+41.34991399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88792",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88792"},
        {"Smithsonian Astrophysical Observation", "SAO 47236"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.87441879),
        dec: Angle.Degrees(+41.35069063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209902"},
        {"Hipparcos Number", "HIP 109071"},
        {"Smithsonian Astrophysical Observation", "SAO 51636"},
    },
    visualMagnitude: 7.69,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.42981356),
        dec: Angle.Degrees(+41.35234180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8584"},
        {"Hipparcos Number", "HIP 6663"},
        {"Smithsonian Astrophysical Observation", "SAO 37193"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.37756306),
        dec: Angle.Degrees(+41.35244603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191978"},
        {"Hipparcos Number", "HIP 99439"},
        {"Celescope Catalog", "CEL 4962"},
        {"Geneva Identification System", "GEN# +1.00191978"},
        {"Smithsonian Astrophysical Observation", "SAO 49280"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.74285302),
        dec: Angle.Degrees(+41.35276641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108464"},
        {"Henry Draper 2", "HD 108465"},
        {"Hipparcos Number", "HIP 60791"},
        {"Fundamental Katalog 5th Edition", "FK5 5099"},
        {"Geneva Identification System", "GEN# +1.00108465"},
        {"Geneva Identification System 2", "GEN# +1.00108464"},
        {"Smithsonian Astrophysical Observation", "SAO 44184"},
        {"Wilson Evans Batten Catalogue", "WEB 10814"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.88812355),
        dec: Angle.Degrees(+41.35508327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188461"},
        {"Hipparcos Number", "HIP 97895"},
        {"Fundamental Katalog 5th Edition", "FK5 5756"},
        {"Geneva Identification System", "GEN# +1.00188461"},
        {"Smithsonian Astrophysical Observation", "SAO 48943"},
        {"Wilson Evans Batten Catalogue", "WEB 17224"},
    },
    visualMagnitude: 6.99,
    bvColour: -0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.41036976),
        dec: Angle.Degrees(+41.35581063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61317",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Chara"},
        {"Henry Draper", "HD 109358"},
        {"Hipparcos Number", "HIP 61317"},
        {"Cincinnati Publication", "Ci 20 718"},
        {"Fundamental Katalog 5th Edition", "FK5 470"},
        {"Geneva Identification System", "GEN# +1.00109358"},
        {"Smithsonian Astrophysical Observation", "SAO 44230"},
        {"Wilson Evans Batten Catalogue", "WEB 10914"},
    },
    visualMagnitude: 4.24,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.43788561),
        dec: Angle.Degrees(+41.35676779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -705.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 292.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199871"},
        {"Hipparcos Number", "HIP 103528"},
        {"Geneva Identification System", "GEN# +1.00199871"},
        {"Smithsonian Astrophysical Observation", "SAO 50301"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.61359213),
        dec: Angle.Degrees(+41.35773129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37250"},
        {"Hipparcos Number", "HIP 26592"},
        {"Smithsonian Astrophysical Observation", "SAO 40512"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.78633530),
        dec: Angle.Degrees(+41.35885300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26757",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26757"},
        {"Smithsonian Astrophysical Observation", "SAO 40533"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.26378944),
        dec: Angle.Degrees(+41.36115456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12201"},
        {"Hipparcos Number", "HIP 9396"},
        {"Geneva Identification System", "GEN# +1.00012201"},
        {"Smithsonian Astrophysical Observation", "SAO 37697"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.19135392),
        dec: Angle.Degrees(+41.36115870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122692"},
        {"Hipparcos Number", "HIP 68585"},
        {"Geneva Identification System", "GEN# +1.00122692"},
        {"Smithsonian Astrophysical Observation", "SAO 44860"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.60616981),
        dec: Angle.Degrees(+41.36133391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84894",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84894"},
        {"Smithsonian Astrophysical Observation", "SAO 46656"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.25057685),
        dec: Angle.Degrees(+41.36356859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57511"},
        {"Hipparcos Number", "HIP 35852"},
        {"Geneva Identification System", "GEN# +1.00057511"},
        {"Smithsonian Astrophysical Observation", "SAO 41734"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.87193722),
        dec: Angle.Degrees(+41.36409670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100289",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100289"},
        {"Geneva Identification System", "GEN# +0.04004124"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.11768074),
        dec: Angle.Degrees(+41.36433066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73407"},
        {"Hipparcos Number", "HIP 42498"},
        {"Smithsonian Astrophysical Observation", "SAO 42475"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.96188920),
        dec: Angle.Degrees(+41.36601210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42352",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42352"},
        {"Smithsonian Astrophysical Observation", "SAO 42464"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.51830190),
        dec: Angle.Degrees(+41.37103821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204275"},
        {"Hipparcos Number", "HIP 105850"},
        {"Smithsonian Astrophysical Observation", "SAO 50845"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.57993290),
        dec: Angle.Degrees(+41.37159739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2740",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2740"},
        {"Smithsonian Astrophysical Observation", "SAO 36488"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.75083279),
        dec: Angle.Degrees(+41.37254593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112945",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112945"},
        {"Celescope Catalog", "CEL 5537"},
        {"Geneva Identification System", "GEN# +0.04004932"},
        {"Smithsonian Astrophysical Observation", "SAO 52440"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.12222692),
        dec: Angle.Degrees(+41.37445359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82018",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82018"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.31534299),
        dec: Angle.Degrees(+41.37467069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55669"},
        {"Hipparcos Number", "HIP 35125"},
        {"Geneva Identification System", "GEN# +1.00055669"},
        {"Smithsonian Astrophysical Observation", "SAO 41647"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.92802532),
        dec: Angle.Degrees(+41.37653655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194839"},
        {"Hipparcos Number", "HIP 100804"},
        {"Geneva Identification System", "GEN# +1.00194839"},
        {"Smithsonian Astrophysical Observation", "SAO 49618"},
        {"Wilson Evans Batten Catalogue", "WEB 18216"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.58977780),
        dec: Angle.Degrees(+41.37935759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217905"},
        {"Hipparcos Number", "HIP 113862"},
        {"Smithsonian Astrophysical Observation", "SAO 52641"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.88029373),
        dec: Angle.Degrees(+41.38124021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90297",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90297"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.37229000),
        dec: Angle.Degrees(+41.38221187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 180.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175132"},
        {"Hipparcos Number", "HIP 92599"},
        {"Celescope Catalog", "CEL 4662"},
        {"Geneva Identification System", "GEN# +1.00175132"},
        {"Renson", "Renson 49000"},
        {"Smithsonian Astrophysical Observation", "SAO 47874"},
        {"Wilson Evans Batten Catalogue", "WEB 16018"},
    },
    visualMagnitude: 6.28,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.03022057),
        dec: Angle.Degrees(+41.38324734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44558",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44558"},
        {"Smithsonian Astrophysical Observation", "SAO 42677"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.18142129),
        dec: Angle.Degrees(+41.38378133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89240",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11174 AB"},
        {"Henry Draper", "HD 167303"},
        {"Hipparcos Number", "HIP 89240"},
        {"Smithsonian Astrophysical Observation", "SAO 47304"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.16192459),
        dec: Angle.Degrees(+41.38551180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9172",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1560 A"},
        {"Henry Draper", "HD 11926"},
        {"Hipparcos Number", "HIP 9172"},
        {"Geneva Identification System", "GEN# +1.00011926"},
        {"Smithsonian Astrophysical Observation", "SAO 37658"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.51920667),
        dec: Angle.Degrees(+41.38598203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9176",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1560 B"},
        {"Hipparcos Number", "HIP 9176"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.52952489),
        dec: Angle.Degrees(+41.38701942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65664"},
        {"Hipparcos Number", "HIP 39243"},
        {"Fundamental Katalog 5th Edition", "FK5 4722"},
        {"Geneva Identification System", "GEN# +1.00065664"},
        {"Smithsonian Astrophysical Observation", "SAO 42130"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.38569736),
        dec: Angle.Degrees(+41.38734901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150046"},
        {"Hipparcos Number", "HIP 81328"},
        {"Smithsonian Astrophysical Observation", "SAO 46189"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.15898583),
        dec: Angle.Degrees(+41.38841563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173052"},
        {"Hipparcos Number", "HIP 91663"},
        {"Smithsonian Astrophysical Observation", "SAO 47706"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.38849337),
        dec: Angle.Degrees(+41.38921446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93664"},
        {"Hipparcos Number", "HIP 52925"},
        {"Geneva Identification System", "GEN# +1.00093664"},
        {"Smithsonian Astrophysical Observation", "SAO 43482"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.35792837),
        dec: Angle.Degrees(+41.39005976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46989",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46989"},
        {"Smithsonian Astrophysical Observation", "SAO 42927"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.65774815),
        dec: Angle.Degrees(+41.39059573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14137",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2292 B"},
        {"Henry Draper", "HD 18751B"},
        {"Hipparcos Number", "HIP 14137"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.788,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.57188858),
        dec: Angle.Degrees(+41.39109877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46230",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46230"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.38338859),
        dec: Angle.Degrees(+41.39124131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193594"},
        {"Hipparcos Number", "HIP 100191"},
        {"Geneva Identification System", "GEN# +1.00193594"},
        {"Smithsonian Astrophysical Observation", "SAO 49465"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.83618787),
        dec: Angle.Degrees(+41.39139301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103769"},
        {"Hipparcos Number", "HIP 58274"},
        {"Geneva Identification System", "GEN# +1.00103769"},
        {"Smithsonian Astrophysical Observation", "SAO 43960"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.26793038),
        dec: Angle.Degrees(+41.39210994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196672"},
        {"Hipparcos Number", "HIP 101757"},
        {"Geneva Identification System", "GEN# +1.00196672"},
        {"Smithsonian Astrophysical Observation", "SAO 49866"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.35538936),
        dec: Angle.Degrees(+41.39304557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14134",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2292 A"},
        {"Henry Draper", "HD 18751"},
        {"Hipparcos Number", "HIP 14134"},
        {"Smithsonian Astrophysical Observation", "SAO 38525"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.56995735),
        dec: Angle.Degrees(+41.39576433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 107.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111874",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16153 D"},
        {"Henry Draper", "HD 214756"},
        {"Hipparcos Number", "HIP 111874"},
        {"Smithsonian Astrophysical Observation", "SAO 52235"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.90795014),
        dec: Angle.Degrees(+41.39586024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14622"},
        {"Hipparcos Number", "HIP 11090"},
        {"Fundamental Katalog 5th Edition", "FK5 2161"},
        {"Geneva Identification System", "GEN# +1.00014622"},
        {"Smithsonian Astrophysical Observation", "SAO 37986"},
        {"Wilson Evans Batten Catalogue", "WEB 2330"},
    },
    visualMagnitude: 5.81,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.70984185),
        dec: Angle.Degrees(+41.39653472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165846"},
        {"Hipparcos Number", "HIP 88660"},
        {"Smithsonian Astrophysical Observation", "SAO 47213"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.51296857),
        dec: Angle.Degrees(+41.39840574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158693"},
        {"Hipparcos Number", "HIP 85539"},
        {"Smithsonian Astrophysical Observation", "SAO 46742"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.20908951),
        dec: Angle.Degrees(+41.39942370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45622"},
        {"Hipparcos Number", "HIP 31006"},
        {"Smithsonian Astrophysical Observation", "SAO 41134"},
    },
    visualMagnitude: 6.70,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.60526503),
        dec: Angle.Degrees(+41.40172153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58789",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8402 AB"},
        {"Hipparcos Number", "HIP 58789"},
        {"Smithsonian Astrophysical Observation", "SAO 44014"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.86899634),
        dec: Angle.Degrees(+41.40431771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173867"},
        {"Hipparcos Number", "HIP 92048"},
        {"Smithsonian Astrophysical Observation", "SAO 47775"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.42298747),
        dec: Angle.Degrees(+41.40558741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209541"},
        {"Hipparcos Number", "HIP 108861"},
        {"Smithsonian Astrophysical Observation", "SAO 51597"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.79635819),
        dec: Angle.Degrees(+41.40604682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7513",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Titawin"},
        {"Henry Draper", "HD 9826"},
        {"Hipparcos Number", "HIP 7513"},
        {"Cincinnati Publication", "Ci 20 110"},
        {"Fundamental Katalog 5th Edition", "FK5 1045"},
        {"Geneva Identification System", "GEN# +1.00009826"},
        {"Smithsonian Astrophysical Observation", "SAO 37362"},
        {"Wilson Evans Batten Catalogue", "WEB 1608"},
    },
    visualMagnitude: 4.10,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.19990413),
        dec: Angle.Degrees(+41.40638491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -172.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -381.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42250",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42250"},
        {"Smithsonian Astrophysical Observation", "SAO 42449"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.20790982),
        dec: Angle.Degrees(+41.40663411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107324"},
        {"Hipparcos Number", "HIP 60156"},
        {"Geneva Identification System", "GEN# +1.00107324"},
        {"Smithsonian Astrophysical Observation", "SAO 44130"},
        {"Wilson Evans Batten Catalogue", "WEB 10694"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.04341141),
        dec: Angle.Degrees(+41.40688865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133543"},
        {"Hipparcos Number", "HIP 73681"},
        {"Smithsonian Astrophysical Observation", "SAO 45352"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.91191714),
        dec: Angle.Degrees(+41.40715316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27448"},
        {"Hipparcos Number", "HIP 20367"},
        {"Smithsonian Astrophysical Observation", "SAO 39486"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.42463237),
        dec: Angle.Degrees(+41.40742081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207113"},
        {"Hipparcos Number", "HIP 107440"},
        {"Smithsonian Astrophysical Observation", "SAO 51266"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.41996372),
        dec: Angle.Degrees(+41.41079978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178329"},
        {"Hipparcos Number", "HIP 93808"},
        {"Celescope Catalog", "CEL 4700"},
        {"Fundamental Katalog 5th Edition", "FK5 3526"},
        {"Geneva Identification System", "GEN# +1.00178329"},
        {"Smithsonian Astrophysical Observation", "SAO 48084"},
        {"Wilson Evans Batten Catalogue", "WEB 16312"},
    },
    visualMagnitude: 6.51,
    bvColour: -0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.57097754),
        dec: Angle.Degrees(+41.41378620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177061"},
        {"Hipparcos Number", "HIP 93382"},
        {"Celescope Catalog", "CEL 4689"},
        {"Geneva Identification System", "GEN# +1.00177061"},
        {"Smithsonian Astrophysical Observation", "SAO 48003"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.29053225),
        dec: Angle.Degrees(+41.41499520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2958",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2958"},
        {"Smithsonian Astrophysical Observation", "SAO 36521"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.39158520),
        dec: Angle.Degrees(+41.41860972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178060"},
        {"Hipparcos Number", "HIP 93741"},
        {"Smithsonian Astrophysical Observation", "SAO 48066"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.32268878),
        dec: Angle.Degrees(+41.42187557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65369"},
        {"Hipparcos Number", "HIP 39113"},
        {"Smithsonian Astrophysical Observation", "SAO 42115"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.03422601),
        dec: Angle.Degrees(+41.42302399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27294"},
        {"Hipparcos Number", "HIP 20247"},
        {"Smithsonian Astrophysical Observation", "SAO 39471"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.07939628),
        dec: Angle.Degrees(+41.42450921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64325",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64325"},
        {"Geneva Identification System", "GEN# +0.04202379"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.76628192),
        dec: Angle.Degrees(+41.42853462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184788"},
        {"Hipparcos Number", "HIP 96256"},
        {"Celescope Catalog", "CEL 4786"},
        {"Geneva Identification System", "GEN# +1.00184788"},
        {"Smithsonian Astrophysical Observation", "SAO 48597"},
    },
    visualMagnitude: 7.16,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.58003035),
        dec: Angle.Degrees(+41.42904477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147004"},
        {"Hipparcos Number", "HIP 79825"},
        {"Smithsonian Astrophysical Observation", "SAO 46011"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.39234228),
        dec: Angle.Degrees(+41.42961869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17666",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2757 A"},
        {"Henry Draper", "HD 23439"},
        {"Henry Draper 2", "HD 23439A"},
        {"Hipparcos Number", "HIP 17666"},
        {"Cincinnati Publication", "Ci 20 260"},
        {"Geneva Identification System", "GEN# +1.00023439A"},
        {"Smithsonian Astrophysical Observation", "SAO 39100"},
        {"Wilson Evans Batten Catalogue", "WEB 3365"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.75687379),
        dec: Angle.Degrees(+41.43027841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 598.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1239.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18161"},
        {"Hipparcos Number", "HIP 13694"},
        {"Smithsonian Astrophysical Observation", "SAO 38453"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.08994094),
        dec: Angle.Degrees(+41.43203504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220823"},
        {"Hipparcos Number", "HIP 115708"},
        {"Smithsonian Astrophysical Observation", "SAO 53022"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.64715425),
        dec: Angle.Degrees(+41.43318303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118687"},
        {"Hipparcos Number", "HIP 66464"},
        {"Geneva Identification System", "GEN# +1.00118687"},
        {"Smithsonian Astrophysical Observation", "SAO 44686"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.39537294),
        dec: Angle.Degrees(+41.43510985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147664"},
        {"Hipparcos Number", "HIP 80135"},
        {"Geneva Identification System", "GEN# +1.00147664"},
        {"Smithsonian Astrophysical Observation", "SAO 46046"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.34784366),
        dec: Angle.Degrees(+41.43517204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83929",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83929"},
    },
    visualMagnitude: 11.02,
    bvColour: 1.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.33241251),
        dec: Angle.Degrees(+41.43541382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -208.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 267.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100167"},
        {"Hipparcos Number", "HIP 56257"},
        {"Geneva Identification System", "GEN# +1.00100167"},
        {"Smithsonian Astrophysical Observation", "SAO 43797"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.97478154),
        dec: Angle.Degrees(+41.43918763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 85.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32188"},
        {"Hipparcos Number", "HIP 23511"},
        {"Geneva Identification System", "GEN# +1.00032188"},
        {"Renson", "Renson 8200"},
        {"Smithsonian Astrophysical Observation", "SAO 39979"},
        {"Wilson Evans Batten Catalogue", "WEB 4579"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.82765661),
        dec: Angle.Degrees(+41.44165308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173936"},
        {"Hipparcos Number", "HIP 92098"},
        {"Celescope Catalog", "CEL 4652"},
        {"Fundamental Katalog 5th Edition", "FK5 3493"},
        {"Geneva Identification System", "GEN# +1.00173936"},
        {"Smithsonian Astrophysical Observation", "SAO 47779"},
        {"Wilson Evans Batten Catalogue", "WEB 15874"},
    },
    visualMagnitude: 6.06,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.55420304),
        dec: Angle.Degrees(+41.44181072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214736"},
        {"Hipparcos Number", "HIP 111859"},
        {"Smithsonian Astrophysical Observation", "SAO 52232"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.86993521),
        dec: Angle.Degrees(+41.44191137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105397",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14896 AB"},
        {"Henry Draper", "HD 203426"},
        {"Hipparcos Number", "HIP 105397"},
        {"Smithsonian Astrophysical Observation", "SAO 50736"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.22382282),
        dec: Angle.Degrees(+41.44211959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42093",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42093"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.69424565),
        dec: Angle.Degrees(+41.44433357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57466",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57466"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.69277551),
        dec: Angle.Degrees(+41.44510825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 277656"},
        {"Hipparcos Number", "HIP 24243"},
        {"Geneva Identification System", "GEN# +1.00277656"},
        {"Smithsonian Astrophysical Observation", "SAO 40109"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.07245707),
        dec: Angle.Degrees(+41.44713595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -471.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208762"},
        {"Hipparcos Number", "HIP 108390"},
        {"Smithsonian Astrophysical Observation", "SAO 51481"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.38499657),
        dec: Angle.Degrees(+41.44951047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126080"},
        {"Hipparcos Number", "HIP 70240"},
        {"Smithsonian Astrophysical Observation", "SAO 45017"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.57378898),
        dec: Angle.Degrees(+41.45063161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148697"},
        {"Hipparcos Number", "HIP 80660"},
        {"Geneva Identification System", "GEN# +1.00148697"},
        {"Smithsonian Astrophysical Observation", "SAO 46105"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.02922641),
        dec: Angle.Degrees(+41.45922501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94537"},
        {"Hipparcos Number", "HIP 53405"},
        {"Smithsonian Astrophysical Observation", "SAO 43525"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.84585742),
        dec: Angle.Degrees(+41.45962636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36040"},
        {"Hipparcos Number", "HIP 25816"},
        {"Fundamental Katalog 5th Edition", "FK5 2412"},
        {"Geneva Identification System", "GEN# +1.00036040"},
        {"Smithsonian Astrophysical Observation", "SAO 40387"},
        {"Wilson Evans Batten Catalogue", "WEB 5014"},
    },
    visualMagnitude: 5.99,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.70270666),
        dec: Angle.Degrees(+41.46207800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111923",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111923"},
        {"Smithsonian Astrophysical Observation", "SAO 52249"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.07309227),
        dec: Angle.Degrees(+41.46238026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188667"},
        {"Hipparcos Number", "HIP 97965"},
        {"Smithsonian Astrophysical Observation", "SAO 48963"},
        {"Wilson Evans Batten Catalogue", "WEB 17242"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.64723774),
        dec: Angle.Degrees(+41.46444502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175080"},
        {"Hipparcos Number", "HIP 92570"},
        {"Smithsonian Astrophysical Observation", "SAO 47869"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.95277904),
        dec: Angle.Degrees(+41.46513372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163620"},
        {"Hipparcos Number", "HIP 87721"},
        {"Smithsonian Astrophysical Observation", "SAO 47062"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.78307717),
        dec: Angle.Degrees(+41.46600037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60233"},
        {"Hipparcos Number", "HIP 36920"},
        {"Smithsonian Astrophysical Observation", "SAO 41871"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.85128637),
        dec: Angle.Degrees(+41.46611390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13439"},
        {"Hipparcos Number", "HIP 10290"},
        {"Geneva Identification System", "GEN# +1.00013439"},
        {"Smithsonian Astrophysical Observation", "SAO 37856"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.12939010),
        dec: Angle.Degrees(+41.46703719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89053"},
        {"Hipparcos Number", "HIP 50389"},
        {"Smithsonian Astrophysical Observation", "SAO 43270"},
        {"Wilson Evans Batten Catalogue", "WEB 9248"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.32371428),
        dec: Angle.Degrees(+41.46747844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42652"},
        {"Hipparcos Number", "HIP 29577"},
        {"Smithsonian Astrophysical Observation", "SAO 40962"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.48183008),
        dec: Angle.Degrees(+41.46769010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110268",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110268"},
        {"Smithsonian Astrophysical Observation", "SAO 51886"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.03196180),
        dec: Angle.Degrees(+41.46784589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49134",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49134"},
        {"Smithsonian Astrophysical Observation", "SAO 43147"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.41628110),
        dec: Angle.Degrees(+41.46830610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38195",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6385 AB"},
        {"Henry Draper", "HD 63207"},
        {"Hipparcos Number", "HIP 38195"},
        {"Cincinnati Publication", "Ci 18 930"},
        {"Smithsonian Astrophysical Observation", "SAO 42020"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.38316029),
        dec: Angle.Degrees(+41.46962606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -275.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190401"},
        {"Hipparcos Number", "HIP 98728"},
        {"Geneva Identification System", "GEN# +1.00190401"},
        {"Renson", "Renson 52940"},
        {"Smithsonian Astrophysical Observation", "SAO 49126"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.78782612),
        dec: Angle.Degrees(+41.47437965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167389"},
        {"Hipparcos Number", "HIP 89282"},
        {"Geneva Identification System", "GEN# +1.00167389"},
        {"Smithsonian Astrophysical Observation", "SAO 47313"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.27994137),
        dec: Angle.Degrees(+41.47567892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90903"},
        {"Hipparcos Number", "HIP 51449"},
        {"Smithsonian Astrophysical Observation", "SAO 43365"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.61311744),
        dec: Angle.Degrees(+41.47593540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43331"},
        {"Hipparcos Number", "HIP 29890"},
        {"Smithsonian Astrophysical Observation", "SAO 41003"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.41212060),
        dec: Angle.Degrees(+41.47663645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96210",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96210"},
        {"Smithsonian Astrophysical Observation", "SAO 48587"},
    },
    visualMagnitude: 9.20,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.45701968),
        dec: Angle.Degrees(+41.47925109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164754"},
        {"Hipparcos Number", "HIP 88211"},
        {"Smithsonian Astrophysical Observation", "SAO 47131"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.20332795),
        dec: Angle.Degrees(+41.47987403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14633"},
        {"Hipparcos Number", "HIP 11099"},
        {"Geneva Identification System", "GEN# +1.00014633"},
        {"Smithsonian Astrophysical Observation", "SAO 37987"},
        {"Wilson Evans Batten Catalogue", "WEB 2334"},
    },
    visualMagnitude: 7.46,
    bvColour: -0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.72621943),
        dec: Angle.Degrees(+41.47994063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219136"},
        {"Hipparcos Number", "HIP 114617"},
        {"Smithsonian Astrophysical Observation", "SAO 52801"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.30197516),
        dec: Angle.Degrees(+41.48283832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107484"},
        {"Hipparcos Number", "HIP 60240"},
        {"Geneva Identification System", "GEN# +1.00107484"},
        {"Smithsonian Astrophysical Observation", "SAO 44136"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.29215359),
        dec: Angle.Degrees(+41.48309821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93427",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Perky"},
        {"Henry Draper", "HD 177153"},
        {"Hipparcos Number", "HIP 93427"},
        {"Geneva Identification System", "GEN# +1.00177153"},
        {"Smithsonian Astrophysical Observation", "SAO 48012"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.41557750),
        dec: Angle.Degrees(+41.49001530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19307",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3001 A"},
        {"Henry Draper", "HD 25949"},
        {"Hipparcos Number", "HIP 19307"},
        {"Smithsonian Astrophysical Observation", "SAO 39334"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.08004283),
        dec: Angle.Degrees(+41.49047999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99336",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99336"},
        {"Wilson Evans Batten Catalogue", "WEB 17725"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.43427897),
        dec: Angle.Degrees(+41.49346970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47099"},
        {"Hipparcos Number", "HIP 31807"},
        {"Smithsonian Astrophysical Observation", "SAO 41236"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.74525893),
        dec: Angle.Degrees(+41.49480562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65739",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65739"},
    },
    visualMagnitude: 10.15,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.13489759),
        dec: Angle.Degrees(+41.49535206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16882"},
        {"Hipparcos Number", "HIP 12737"},
        {"Smithsonian Astrophysical Observation", "SAO 38287"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.93309746),
        dec: Angle.Degrees(+41.49795856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50801",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Tania Australis"},
        {"Henry Draper", "HD 89758"},
        {"Hipparcos Number", "HIP 50801"},
        {"Fundamental Katalog 5th Edition", "FK5 386"},
        {"Geneva Identification System", "GEN# +1.00089758"},
        {"Smithsonian Astrophysical Observation", "SAO 43310"},
        {"Wilson Evans Batten Catalogue", "WEB 9297"},
    },
    visualMagnitude: 3.06,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.58251355),
        dec: Angle.Degrees(+41.49943350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46506",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46506"},
        {"Smithsonian Astrophysical Observation", "SAO 42883"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.27525278),
        dec: Angle.Degrees(+41.50001029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229274"},
        {"Hipparcos Number", "HIP 100660"},
        {"Geneva Identification System", "GEN# +1.00229274"},
        {"Geneva Identification System 2", "GEN# +0.04103735"},
        {"Smithsonian Astrophysical Observation", "SAO 49586"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.15072199),
        dec: Angle.Degrees(+41.50104650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26031"},
        {"Hipparcos Number", "HIP 19370"},
        {"Smithsonian Astrophysical Observation", "SAO 39341"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.23675406),
        dec: Angle.Degrees(+41.50401507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204829"},
        {"Hipparcos Number", "HIP 106144"},
        {"Smithsonian Astrophysical Observation", "SAO 50941"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.49920184),
        dec: Angle.Degrees(+41.51050914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6646"},
        {"Hipparcos Number", "HIP 5298"},
        {"Smithsonian Astrophysical Observation", "SAO 36948"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.94484149),
        dec: Angle.Degrees(+41.51329231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178399"},
        {"Hipparcos Number", "HIP 93841"},
        {"Smithsonian Astrophysical Observation", "SAO 48090"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.65376511),
        dec: Angle.Degrees(+41.51569832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215400"},
        {"Hipparcos Number", "HIP 112258"},
        {"Smithsonian Astrophysical Observation", "SAO 52319"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.06742835),
        dec: Angle.Degrees(+41.51668318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148240"},
        {"Hipparcos Number", "HIP 80419"},
        {"Smithsonian Astrophysical Observation", "SAO 46072"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.21994834),
        dec: Angle.Degrees(+41.51822776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124755"},
        {"Hipparcos Number", "HIP 69569"},
        {"Geneva Identification System", "GEN# +1.00124755"},
        {"Smithsonian Astrophysical Observation", "SAO 44952"},
        {"Wilson Evans Batten Catalogue", "WEB 12115"},
    },
    visualMagnitude: 6.23,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.59818899),
        dec: Angle.Degrees(+41.51901546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92922",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92922"},
        {"Smithsonian Astrophysical Observation", "SAO 47926"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.97841183),
        dec: Angle.Degrees(+41.52158153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 92.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2702"},
        {"Hipparcos Number", "HIP 2420"},
        {"Smithsonian Astrophysical Observation", "SAO 36429"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.71796419),
        dec: Angle.Degrees(+41.52169210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15125"},
        {"Hipparcos Number", "HIP 11424"},
        {"Smithsonian Astrophysical Observation", "SAO 38033"},
    },
    visualMagnitude: 8.04,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.83531051),
        dec: Angle.Degrees(+41.52179673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67203"},
        {"Hipparcos Number", "HIP 39865"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.15483006),
        dec: Angle.Degrees(+41.52198694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21566"},
        {"Hipparcos Number", "HIP 16317"},
        {"Smithsonian Astrophysical Observation", "SAO 38888"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.57780679),
        dec: Angle.Degrees(+41.52369285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52264",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7880 A"},
        {"Henry Draper", "HD 92388"},
        {"Hipparcos Number", "HIP 52264"},
        {"Smithsonian Astrophysical Observation", "SAO 43429"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.19214607),
        dec: Angle.Degrees(+41.52675444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127985"},
        {"Hipparcos Number", "HIP 71148"},
        {"Smithsonian Astrophysical Observation", "SAO 45106"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.28129262),
        dec: Angle.Degrees(+41.52691798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62184",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62184"},
        {"Smithsonian Astrophysical Observation", "SAO 44311"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.16669540),
        dec: Angle.Degrees(+41.52698484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215942"},
        {"Hipparcos Number", "HIP 112595"},
        {"Geneva Identification System", "GEN# +1.00215942"},
        {"Smithsonian Astrophysical Observation", "SAO 52379"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.05862302),
        dec: Angle.Degrees(+41.53283232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -157.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12751"},
        {"Hipparcos Number", "HIP 9800"},
        {"Geneva Identification System", "GEN# +1.00012751"},
        {"Renson", "Renson 3250"},
        {"Smithsonian Astrophysical Observation", "SAO 37763"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.50717776),
        dec: Angle.Degrees(+41.53290656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2172"},
        {"Hipparcos Number", "HIP 2053"},
        {"Smithsonian Astrophysical Observation", "SAO 36360"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.51066757),
        dec: Angle.Degrees(+41.53392376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35354",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35354"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.53795107),
        dec: Angle.Degrees(+41.53557230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205010"},
        {"Hipparcos Number", "HIP 106250"},
        {"Smithsonian Astrophysical Observation", "SAO 50966"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.80714966),
        dec: Angle.Degrees(+41.53901405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209342"},
        {"Hipparcos Number", "HIP 108745"},
        {"Fundamental Katalog 5th Edition", "FK5 5946"},
        {"Smithsonian Astrophysical Observation", "SAO 51566"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.42918168),
        dec: Angle.Degrees(+41.53917713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36680"},
        {"Hipparcos Number", "HIP 26244"},
        {"Celescope Catalog", "CEL 798"},
        {"Geneva Identification System", "GEN# +1.00036680"},
        {"Smithsonian Astrophysical Observation", "SAO 40460"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.86065819),
        dec: Angle.Degrees(+41.53947892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27144"},
        {"Hipparcos Number", "HIP 20133"},
        {"Smithsonian Astrophysical Observation", "SAO 39458"},
        {"Wilson Evans Batten Catalogue", "WEB 3841"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.75372639),
        dec: Angle.Degrees(+41.54115489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113864"},
        {"Hipparcos Number", "HIP 63928"},
        {"Geneva Identification System", "GEN# +1.00113864"},
        {"Smithsonian Astrophysical Observation", "SAO 44466"},
        {"Wilson Evans Batten Catalogue", "WEB 11296"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.51098160),
        dec: Angle.Degrees(+41.54317637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121389"},
        {"Hipparcos Number", "HIP 67883"},
        {"Geneva Identification System", "GEN# +1.00121389"},
        {"Smithsonian Astrophysical Observation", "SAO 44791"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.54532361),
        dec: Angle.Degrees(+41.54368209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84965"},
        {"Hipparcos Number", "HIP 48221"},
        {"Cincinnati Publication", "Ci 18 1164"},
        {"Geneva Identification System", "GEN# +1.00084965"},
        {"Smithsonian Astrophysical Observation", "SAO 43058"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.47269518),
        dec: Angle.Degrees(+41.54621112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -198.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91574",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91574"},
        {"Smithsonian Astrophysical Observation", "SAO 47690"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.10204138),
        dec: Angle.Degrees(+41.54651922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215030"},
        {"Hipparcos Number", "HIP 112041"},
        {"Smithsonian Astrophysical Observation", "SAO 52270"},
        {"Wilson Evans Batten Catalogue", "WEB 20002"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.39975815),
        dec: Angle.Degrees(+41.54897766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 140.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41765"},
        {"Hipparcos Number", "HIP 29161"},
        {"Geneva Identification System", "GEN# +1.00041765"},
        {"Smithsonian Astrophysical Observation", "SAO 40889"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.27304439),
        dec: Angle.Degrees(+41.55023465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10808"},
        {"Hipparcos Number", "HIP 8272"},
        {"Geneva Identification System", "GEN# +1.00010808"},
        {"Smithsonian Astrophysical Observation", "SAO 37497"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.64945245),
        dec: Angle.Degrees(+41.55197082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137896"},
        {"Hipparcos Number", "HIP 75631"},
        {"Geneva Identification System", "GEN# +1.00137896"},
        {"Smithsonian Astrophysical Observation", "SAO 45549"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.78737064),
        dec: Angle.Degrees(+41.55356202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113622"},
        {"Hipparcos Number", "HIP 63785"},
        {"Geneva Identification System", "GEN# +1.00113622"},
        {"Smithsonian Astrophysical Observation", "SAO 44451"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.10481813),
        dec: Angle.Degrees(+41.55454163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65999",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65999"},
        {"Geneva Identification System", "GEN# +0.04202407"},
        {"Smithsonian Astrophysical Observation", "SAO 44640"},
    },
    visualMagnitude: 9.89,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.96541403),
        dec: Angle.Degrees(+41.55531918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138198"},
        {"Hipparcos Number", "HIP 75793"},
        {"Smithsonian Astrophysical Observation", "SAO 45563"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.26500399),
        dec: Angle.Degrees(+41.55999926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18859"},
        {"Hipparcos Number", "HIP 14225"},
        {"Smithsonian Astrophysical Observation", "SAO 38535"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.85620822),
        dec: Angle.Degrees(+41.56017572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40236",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6656 AB"},
        {"Henry Draper", "HD 68196"},
        {"Hipparcos Number", "HIP 40236"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.27606157),
        dec: Angle.Degrees(+41.56122130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171763"},
        {"Hipparcos Number", "HIP 91078"},
        {"Geneva Identification System", "GEN# +1.00171763"},
        {"Smithsonian Astrophysical Observation", "SAO 47614"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.66190967),
        dec: Angle.Degrees(+41.56669420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93947"},
        {"Hipparcos Number", "HIP 53060"},
        {"Smithsonian Astrophysical Observation", "SAO 43494"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.84057118),
        dec: Angle.Degrees(+41.56725879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58941",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58941"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.28237710),
        dec: Angle.Degrees(+41.56750636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111423"},
        {"Hipparcos Number", "HIP 62530"},
        {"Geneva Identification System", "GEN# +1.00111423"},
        {"Smithsonian Astrophysical Observation", "SAO 44333"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.21058242),
        dec: Angle.Degrees(+41.56968839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3447",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3447"},
        {"Smithsonian Astrophysical Observation", "SAO 36609"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.01619112),
        dec: Angle.Degrees(+41.57086283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111460",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16084 AB"},
        {"Henry Draper", "HD 214040"},
        {"Hipparcos Number", "HIP 111460"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.73018892),
        dec: Angle.Degrees(+41.57195328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12796",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12796"},
        {"Smithsonian Astrophysical Observation", "SAO 38295"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.11289487),
        dec: Angle.Degrees(+41.57287892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49732"},
        {"Hipparcos Number", "HIP 32955"},
        {"Geneva Identification System", "GEN# +1.00049732"},
        {"Smithsonian Astrophysical Observation", "SAO 41394"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.96231282),
        dec: Angle.Degrees(+41.57612889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201560"},
        {"Hipparcos Number", "HIP 104410"},
        {"Smithsonian Astrophysical Observation", "SAO 50496"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.27126030),
        dec: Angle.Degrees(+41.58100760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171886"},
        {"Hipparcos Number", "HIP 91120"},
        {"Geneva Identification System", "GEN# +1.00171886"},
        {"Smithsonian Astrophysical Observation", "SAO 47620"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.81037927),
        dec: Angle.Degrees(+41.58135404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 82.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31776",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5269 AB"},
        {"Henry Draper", "HD 47046"},
        {"Hipparcos Number", "HIP 31776"},
        {"Smithsonian Astrophysical Observation", "SAO 41232"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.66981785),
        dec: Angle.Degrees(+41.58149494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47426",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7475 AB"},
        {"Hipparcos Number", "HIP 47426"},
        {"Smithsonian Astrophysical Observation", "SAO 42967"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.94739213),
        dec: Angle.Degrees(+41.58206304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2604",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2604"},
        {"Wilson Evans Batten Catalogue", "WEB 477"},
    },
    visualMagnitude: 10.94,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.27211859),
        dec: Angle.Degrees(+42.00110936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 315.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 151.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187637"},
        {"Hipparcos Number", "HIP 97527"},
        {"Geneva Identification System", "GEN# +1.00187637"},
        {"Smithsonian Astrophysical Observation", "SAO 48869"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.32523785),
        dec: Angle.Degrees(+41.58288539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68990",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68990"},
        {"Geneva Identification System", "GEN# +9.80178004"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.86403549),
        dec: Angle.Degrees(+41.58344528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -253.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 164.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114818",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114818"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.87227925),
        dec: Angle.Degrees(+41.58466102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19344"},
        {"Hipparcos Number", "HIP 14578"},
        {"Smithsonian Astrophysical Observation", "SAO 38591"},
        {"Wilson Evans Batten Catalogue", "WEB 2832"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.04599602),
        dec: Angle.Degrees(+41.58536187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201469"},
        {"Hipparcos Number", "HIP 104354"},
        {"Smithsonian Astrophysical Observation", "SAO 50488"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.11058645),
        dec: Angle.Degrees(+41.58617691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 227457"},
        {"Hipparcos Number", "HIP 98814"},
        {"Wilson Evans Batten Catalogue", "WEB 17515"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.01129656),
        dec: Angle.Degrees(+41.58791975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57970",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57970"},
        {"Geneva Identification System", "GEN# +0.04202253"},
        {"Smithsonian Astrophysical Observation", "SAO 43935"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.36098730),
        dec: Angle.Degrees(+41.58995660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180658"},
        {"Hipparcos Number", "HIP 94644"},
        {"Smithsonian Astrophysical Observation", "SAO 48244"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.88761020),
        dec: Angle.Degrees(+41.59296302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86219"},
        {"Hipparcos Number", "HIP 48875"},
        {"Smithsonian Astrophysical Observation", "SAO 43121"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.53184228),
        dec: Angle.Degrees(+41.59525909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90735",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90735"},
        {"Smithsonian Astrophysical Observation", "SAO 47553"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.69889597),
        dec: Angle.Degrees(+41.59575479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23487"},
        {"Hipparcos Number", "HIP 17682"},
        {"Geneva Identification System", "GEN# +1.00023487"},
        {"Smithsonian Astrophysical Observation", "SAO 39103"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.81977605),
        dec: Angle.Degrees(+41.59677862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107346",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107346"},
        {"Geneva Identification System", "GEN# +0.04004631"},
        {"Wilson Evans Batten Catalogue", "WEB 19387"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.12503938),
        dec: Angle.Degrees(+41.59736227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212096"},
        {"Hipparcos Number", "HIP 110352"},
        {"Smithsonian Astrophysical Observation", "SAO 51903"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.25734154),
        dec: Angle.Degrees(+41.59812797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36475",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6122 A"},
        {"Henry Draper", "HD 59083"},
        {"Hipparcos Number", "HIP 36475"},
        {"Smithsonian Astrophysical Observation", "SAO 41819"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.57872683),
        dec: Angle.Degrees(+41.59899405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81539"},
        {"Hipparcos Number", "HIP 46381"},
        {"Geneva Identification System", "GEN# +1.00081539"},
        {"Smithsonian Astrophysical Observation", "SAO 42867"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.86018249),
        dec: Angle.Degrees(+41.60006366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90470"},
        {"Hipparcos Number", "HIP 51200"},
        {"Geneva Identification System", "GEN# +1.00090470"},
        {"Smithsonian Astrophysical Observation", "SAO 43344"},
        {"Wilson Evans Batten Catalogue", "WEB 9359"},
    },
    visualMagnitude: 6.00,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.86699226),
        dec: Angle.Degrees(+41.60121201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35013"},
        {"Hipparcos Number", "HIP 25211"},
        {"Smithsonian Astrophysical Observation", "SAO 40300"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.89977190),
        dec: Angle.Degrees(+41.60131269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53763",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53763"},
        {"Geneva Identification System", "GEN# +0.04202173"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.00190937),
        dec: Angle.Degrees(+41.60222733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193666"},
        {"Hipparcos Number", "HIP 100249"},
        {"Smithsonian Astrophysical Observation", "SAO 49480"},
    },
    visualMagnitude: 8.14,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.97645245),
        dec: Angle.Degrees(+41.60239027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92831",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11840 A"},
        {"Henry Draper", "HD 175740"},
        {"Hipparcos Number", "HIP 92831"},
        {"Geneva Identification System", "GEN# +1.00175740"},
        {"Smithsonian Astrophysical Observation", "SAO 47909"},
        {"Wilson Evans Batten Catalogue", "WEB 16069"},
    },
    visualMagnitude: 5.46,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.71740921),
        dec: Angle.Degrees(+41.60272814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208121"},
        {"Hipparcos Number", "HIP 108024"},
        {"Smithsonian Astrophysical Observation", "SAO 51401"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.26769121),
        dec: Angle.Degrees(+41.60337200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113281",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16381 A"},
        {"Henry Draper", "HD 216916"},
        {"Hipparcos Number", "HIP 113281"},
        {"Celescope Catalog", "CEL 5546"},
        {"Geneva Identification System", "GEN# +1.00216916A"},
        {"Smithsonian Astrophysical Observation", "SAO 52512"},
        {"Wilson Evans Batten Catalogue", "WEB 20155"},
    },
    visualMagnitude: 5.60,
    bvColour: -0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.09846242),
        dec: Angle.Degrees(+41.60388627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224381"},
        {"Hipparcos Number", "HIP 118099"},
        {"Geneva Identification System", "GEN# +1.00224381"},
        {"Smithsonian Astrophysical Observation", "SAO 53519"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.34400094),
        dec: Angle.Degrees(+41.60750273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40369",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40369"},
        {"Smithsonian Astrophysical Observation", "SAO 42240"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.62922627),
        dec: Angle.Degrees(+41.60949399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32152",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5346 AB"},
        {"Hipparcos Number", "HIP 32152"},
        {"Smithsonian Astrophysical Observation", "SAO 41286"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.71794731),
        dec: Angle.Degrees(+41.61154558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 276618"},
        {"Hipparcos Number", "HIP 21559"},
        {"Smithsonian Astrophysical Observation", "SAO 39655"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.43141762),
        dec: Angle.Degrees(+41.61188670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210209"},
        {"Hipparcos Number", "HIP 109242"},
        {"Smithsonian Astrophysical Observation", "SAO 51672"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.96437881),
        dec: Angle.Degrees(+41.61262362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220524"},
        {"Hipparcos Number", "HIP 115530"},
        {"Smithsonian Astrophysical Observation", "SAO 52978"},
    },
    visualMagnitude: 6.37,
    bvColour: 1.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.03699006),
        dec: Angle.Degrees(+41.61286800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72642",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72642"},
        {"Smithsonian Astrophysical Observation", "SAO 45237"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.78349927),
        dec: Angle.Degrees(+41.61389441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161443"},
        {"Hipparcos Number", "HIP 86754"},
        {"Geneva Identification System", "GEN# +1.00161443"},
        {"Smithsonian Astrophysical Observation", "SAO 46911"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.90120975),
        dec: Angle.Degrees(+41.61686801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34120",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34120"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.12501351),
        dec: Angle.Degrees(+41.61706394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198538"},
        {"Hipparcos Number", "HIP 102797"},
        {"Smithsonian Astrophysical Observation", "SAO 50112"},
    },
    visualMagnitude: 8.87,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.38981717),
        dec: Angle.Degrees(+41.61739162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116669",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116669"},
        {"Smithsonian Astrophysical Observation", "SAO 53228"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.65385294),
        dec: Angle.Degrees(+41.62422617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30810",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30810"},
        {"Smithsonian Astrophysical Observation", "SAO 41116"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.10696888),
        dec: Angle.Degrees(+41.62492799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105248"},
        {"Hipparcos Number", "HIP 59085"},
        {"Cincinnati Publication", "Ci 18 1500"},
        {"Smithsonian Astrophysical Observation", "SAO 44035"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.75339539),
        dec: Angle.Degrees(+41.62789824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -265.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200723"},
        {"Hipparcos Number", "HIP 103963"},
        {"Geneva Identification System", "GEN# +1.00200723A"},
        {"Smithsonian Astrophysical Observation", "SAO 50409"},
        {"Wilson Evans Batten Catalogue", "WEB 18934"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.96723970),
        dec: Angle.Degrees(+41.62830431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140343"},
        {"Hipparcos Number", "HIP 76847"},
        {"Smithsonian Astrophysical Observation", "SAO 45681"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.36970754),
        dec: Angle.Degrees(+41.63410434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52281"},
        {"Hipparcos Number", "HIP 33936"},
        {"Geneva Identification System", "GEN# +1.00052281"},
        {"Smithsonian Astrophysical Observation", "SAO 41511"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.63420612),
        dec: Angle.Degrees(+41.63571447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94931",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94931"},
        {"Cincinnati Publication", "Ci 20 1145"},
        {"Geneva Identification System", "GEN# +0.04103306"},
        {"Wilson Evans Batten Catalogue", "WEB 16574"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.806,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.75196603),
        dec: Angle.Degrees(+41.63613932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -631.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176645"},
        {"Hipparcos Number", "HIP 93222"},
        {"Smithsonian Astrophysical Observation", "SAO 47977"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.83936458),
        dec: Angle.Degrees(+41.63695343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100642"},
        {"Hipparcos Number", "HIP 56514"},
        {"Geneva Identification System", "GEN# +1.00100642"},
        {"Smithsonian Astrophysical Observation", "SAO 43815"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.79058402),
        dec: Angle.Degrees(+41.63719011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221642"},
        {"Hipparcos Number", "HIP 116267"},
        {"Geneva Identification System", "GEN# +1.00221642"},
        {"Smithsonian Astrophysical Observation", "SAO 53144"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.37123145),
        dec: Angle.Degrees(+41.63790180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67586"},
        {"Hipparcos Number", "HIP 40013"},
        {"Smithsonian Astrophysical Observation", "SAO 42204"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.58155719),
        dec: Angle.Degrees(+41.63795118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83019",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83019"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.47153815),
        dec: Angle.Degrees(+41.64083574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152793"},
        {"Hipparcos Number", "HIP 82644"},
        {"Smithsonian Astrophysical Observation", "SAO 46352"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.40116937),
        dec: Angle.Degrees(+41.64119505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 118.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28405",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28405"},
        {"Smithsonian Astrophysical Observation", "SAO 40760"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.99275971),
        dec: Angle.Degrees(+41.64154452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53712"},
        {"Hipparcos Number", "HIP 34404"},
        {"Smithsonian Astrophysical Observation", "SAO 41576"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.99221048),
        dec: Angle.Degrees(+41.64289729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103404",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103404"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.23829460),
        dec: Angle.Degrees(+41.64724790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 118.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60854",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60854"},
        {"Geneva Identification System", "GEN# +0.04202309"},
        {"Wilson Evans Batten Catalogue", "WEB 10829"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.09242111),
        dec: Angle.Degrees(+41.64797613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225875"},
        {"Hipparcos Number", "HIP 97411"},
        {"Smithsonian Astrophysical Observation", "SAO 48845"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.98050736),
        dec: Angle.Degrees(+41.64851167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156452"},
        {"Hipparcos Number", "HIP 84441"},
        {"Smithsonian Astrophysical Observation", "SAO 46589"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.95727941),
        dec: Angle.Degrees(+41.64908410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207954"},
        {"Hipparcos Number", "HIP 107918"},
        {"Geneva Identification System", "GEN# +1.00207954"},
        {"Smithsonian Astrophysical Observation", "SAO 51377"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.811,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.96444180),
        dec: Angle.Degrees(+41.64916690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83995",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83995"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.54995021),
        dec: Angle.Degrees(+41.65375588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 92.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98268",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98268"},
        {"Smithsonian Astrophysical Observation", "SAO 49035"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.50541830),
        dec: Angle.Degrees(+41.65387642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183416"},
        {"Hipparcos Number", "HIP 95681"},
        {"Geneva Identification System", "GEN# +1.00183416"},
        {"Smithsonian Astrophysical Observation", "SAO 48468"},
    },
    visualMagnitude: 8.72,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.92195635),
        dec: Angle.Degrees(+41.65388079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7205"},
        {"Hipparcos Number", "HIP 5684"},
        {"Geneva Identification System", "GEN# +1.00007205"},
        {"Smithsonian Astrophysical Observation", "SAO 37026"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.27426204),
        dec: Angle.Degrees(+41.65439442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 314.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86550",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10722"},
        {"Henry Draper", "HD 161016"},
        {"Hipparcos Number", "HIP 86550"},
        {"Smithsonian Astrophysical Observation", "SAO 46884"},
        {"Wilson Evans Batten Catalogue", "WEB 14597"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.30755930),
        dec: Angle.Degrees(+41.65491078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44027",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44027"},
        {"Smithsonian Astrophysical Observation", "SAO 42621"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.49107133),
        dec: Angle.Degrees(+41.65550198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134166"},
        {"Hipparcos Number", "HIP 73970"},
        {"Smithsonian Astrophysical Observation", "SAO 45379"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.74669808),
        dec: Angle.Degrees(+41.65598525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65162",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65162"},
        {"Geneva Identification System", "GEN# +0.04202394"},
        {"Smithsonian Astrophysical Observation", "SAO 44576"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.29756826),
        dec: Angle.Degrees(+41.65690833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59599",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59599"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.33230766),
        dec: Angle.Degrees(+41.65906680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79957",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10006 AB"},
        {"Henry Draper", "HD 147276"},
        {"Henry Draper 2", "HD 147275"},
        {"Hipparcos Number", "HIP 79957"},
        {"Geneva Identification System", "GEN# +1.00147275"},
        {"Renson", "Renson 41603"},
        {"Smithsonian Astrophysical Observation", "SAO 46022"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.81031477),
        dec: Angle.Degrees(+41.65932137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78146",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9861 AB"},
        {"Henry Draper", "HD 143208"},
        {"Hipparcos Number", "HIP 78146"},
        {"Smithsonian Astrophysical Observation", "SAO 45802"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.36215871),
        dec: Angle.Degrees(+41.66191063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17612"},
        {"Hipparcos Number", "HIP 13282"},
        {"Smithsonian Astrophysical Observation", "SAO 38389"},
    },
    visualMagnitude: 8.76,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.73196653),
        dec: Angle.Degrees(+41.66208007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152031"},
        {"Hipparcos Number", "HIP 82308"},
        {"Geneva Identification System", "GEN# +1.00152031"},
        {"Smithsonian Astrophysical Observation", "SAO 46300"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.25831436),
        dec: Angle.Degrees(+41.66328252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45460",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45460"},
        {"Smithsonian Astrophysical Observation", "SAO 42773"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.96594332),
        dec: Angle.Degrees(+41.66622088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10132"},
        {"Hipparcos Number", "HIP 7767"},
        {"Geneva Identification System", "GEN# +1.00010132"},
        {"Smithsonian Astrophysical Observation", "SAO 37415"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.99213427),
        dec: Angle.Degrees(+41.66674096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51492",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51492"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.75280085),
        dec: Angle.Degrees(+41.66723295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24661",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24661"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.37871455),
        dec: Angle.Degrees(+41.66889497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61367",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61367"},
        {"Geneva Identification System", "GEN# +0.04202322"},
        {"Smithsonian Astrophysical Observation", "SAO 44234"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.63036102),
        dec: Angle.Degrees(+41.67041210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74377"},
        {"Hipparcos Number", "HIP 42940"},
        {"Cincinnati Publication", "Ci 20 487"},
        {"Geneva Identification System", "GEN# +1.00074377"},
        {"Smithsonian Astrophysical Observation", "SAO 42526"},
        {"Wilson Evans Batten Catalogue", "WEB 8301"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.29424441),
        dec: Angle.Degrees(+41.67341814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -283.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -651.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21334"},
        {"Hipparcos Number", "HIP 16145"},
        {"Smithsonian Astrophysical Observation", "SAO 38852"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.00936791),
        dec: Angle.Degrees(+41.67368137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119445"},
        {"Hipparcos Number", "HIP 66892"},
        {"Geneva Identification System", "GEN# +1.00119445"},
        {"Smithsonian Astrophysical Observation", "SAO 44720"},
        {"Wilson Evans Batten Catalogue", "WEB 11792"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.62030712),
        dec: Angle.Degrees(+41.67425191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111375",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111375"},
        {"Smithsonian Astrophysical Observation", "SAO 52147"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.45058367),
        dec: Angle.Degrees(+41.67437332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30131",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30131"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.10774504),
        dec: Angle.Degrees(+41.67751034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43836",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7084 AB"},
        {"Henry Draper", "HD 76117"},
        {"Hipparcos Number", "HIP 43836"},
        {"Smithsonian Astrophysical Observation", "SAO 42601"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.91884095),
        dec: Angle.Degrees(+41.67797771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60506",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60506"},
        {"Geneva Identification System", "GEN# +0.04202300"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.06181555),
        dec: Angle.Degrees(+41.68077928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63874",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8769 AB"},
        {"Henry Draper", "HD 113770"},
        {"Hipparcos Number", "HIP 63874"},
        {"Geneva Identification System", "GEN# +1.00113770"},
        {"Smithsonian Astrophysical Observation", "SAO 44460"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.36287497),
        dec: Angle.Degrees(+41.68122484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95032",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95032"},
    },
    visualMagnitude: 11.35,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.03648777),
        dec: Angle.Degrees(+41.68310528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176894"},
        {"Hipparcos Number", "HIP 93327"},
        {"Geneva Identification System", "GEN# +1.00176894"},
        {"Smithsonian Astrophysical Observation", "SAO 47996"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.13302249),
        dec: Angle.Degrees(+41.68422949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22566"},
        {"Hipparcos Number", "HIP 17060"},
        {"Smithsonian Astrophysical Observation", "SAO 39022"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.85910095),
        dec: Angle.Degrees(+41.68637037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173980"},
        {"Hipparcos Number", "HIP 92113"},
        {"Smithsonian Astrophysical Observation", "SAO 47787"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.59539554),
        dec: Angle.Degrees(+41.68878179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199679"},
        {"Hipparcos Number", "HIP 103442"},
        {"Geneva Identification System", "GEN# +1.00199679"},
        {"Smithsonian Astrophysical Observation", "SAO 50279"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.35421445),
        dec: Angle.Degrees(+41.68955762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45385",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45385"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.73470799),
        dec: Angle.Degrees(+41.69389586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11905"},
        {"Hipparcos Number", "HIP 9158"},
        {"Geneva Identification System", "GEN# +1.00011905"},
        {"Renson", "Renson 3050"},
        {"Smithsonian Astrophysical Observation", "SAO 37653"},
        {"Wilson Evans Batten Catalogue", "WEB 1922"},
    },
    visualMagnitude: 6.77,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.48484304),
        dec: Angle.Degrees(+41.69457318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208962"},
        {"Hipparcos Number", "HIP 108507"},
        {"Celescope Catalog", "CEL 5414"},
        {"Geneva Identification System", "GEN# +1.00208962"},
        {"Smithsonian Astrophysical Observation", "SAO 51507"},
    },
    visualMagnitude: 7.59,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.73251276),
        dec: Angle.Degrees(+41.69620683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37799"},
        {"Hipparcos Number", "HIP 26957"},
        {"Geneva Identification System", "GEN# +1.00037799"},
        {"Smithsonian Astrophysical Observation", "SAO 40559"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.80729125),
        dec: Angle.Degrees(+41.69654577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42616"},
        {"Hipparcos Number", "HIP 29565"},
        {"Geneva Identification System", "GEN# +1.00042616"},
        {"Renson", "Renson 11390"},
        {"Smithsonian Astrophysical Observation", "SAO 40959"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.42981260),
        dec: Angle.Degrees(+41.69726804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80063"},
        {"Hipparcos Number", "HIP 45701"},
        {"Smithsonian Astrophysical Observation", "SAO 42800"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.74900501),
        dec: Angle.Degrees(+41.69886940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31391",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31391"},
        {"Smithsonian Astrophysical Observation", "SAO 41190"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.71275225),
        dec: Angle.Degrees(+41.70020952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205467"},
        {"Hipparcos Number", "HIP 106499"},
        {"Smithsonian Astrophysical Observation", "SAO 51040"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.57112875),
        dec: Angle.Degrees(+41.70031617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51098"},
        {"Hipparcos Number", "HIP 33507"},
        {"Geneva Identification System", "GEN# +1.00051098"},
        {"Smithsonian Astrophysical Observation", "SAO 41469"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.47498908),
        dec: Angle.Degrees(+41.70558877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77856"},
        {"Hipparcos Number", "HIP 44677"},
        {"Smithsonian Astrophysical Observation", "SAO 42692"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.58064372),
        dec: Angle.Degrees(+41.70609859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36368",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36368"},
        {"Smithsonian Astrophysical Observation", "SAO 41803"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.29020421),
        dec: Angle.Degrees(+41.70900343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92954"},
        {"Hipparcos Number", "HIP 52556"},
        {"Smithsonian Astrophysical Observation", "SAO 43456"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.18277726),
        dec: Angle.Degrees(+41.71461468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119747"},
        {"Hipparcos Number", "HIP 67039"},
        {"Smithsonian Astrophysical Observation", "SAO 44730"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.07834695),
        dec: Angle.Degrees(+41.71537390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71246"},
        {"Hipparcos Number", "HIP 41514"},
        {"Smithsonian Astrophysical Observation", "SAO 42377"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.99719966),
        dec: Angle.Degrees(+41.71554633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49526",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49526"},
        {"Cincinnati Publication", "Ci 20 560"},
    },
    visualMagnitude: 11.32,
    bvColour: 1.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.68346415),
        dec: Angle.Degrees(+41.71563375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -272.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -414.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84790",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84790"},
        {"Cincinnati Publication", "Ci 20 1034"},
        {"Geneva Identification System", "GEN# +9.80181039"},
    },
    visualMagnitude: 11.37,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.96871107),
        dec: Angle.Degrees(+41.71582141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 285.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -822.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104877"},
        {"Geneva Identification System", "GEN# +0.04104049"},
        {"Wilson Evans Batten Catalogue", "WEB 19069"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.66847852),
        dec: Angle.Degrees(+41.71635167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197392"},
        {"Hipparcos Number", "HIP 102155"},
        {"Celescope Catalog", "CEL 5147"},
        {"Fundamental Katalog 5th Edition", "FK5 3655"},
        {"Geneva Identification System", "GEN# +1.00197392"},
        {"Smithsonian Astrophysical Observation", "SAO 49946"},
        {"Wilson Evans Batten Catalogue", "WEB 18481"},
    },
    visualMagnitude: 5.68,
    bvColour: -0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.48540748),
        dec: Angle.Degrees(+41.71687197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28088",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28088"},
        {"Smithsonian Astrophysical Observation", "SAO 40714"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.06109682),
        dec: Angle.Degrees(+41.71717584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78814",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78814"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.34145333),
        dec: Angle.Degrees(+41.71836139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166253"},
        {"Hipparcos Number", "HIP 88820"},
        {"Geneva Identification System", "GEN# +1.00166253"},
        {"Smithsonian Astrophysical Observation", "SAO 47242"},
        {"Wilson Evans Batten Catalogue", "WEB 15053"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.96227383),
        dec: Angle.Degrees(+41.71921848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74828"},
        {"Hipparcos Number", "HIP 43183"},
        {"Geneva Identification System", "GEN# +1.00074828"},
        {"Smithsonian Astrophysical Observation", "SAO 42549"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.95228081),
        dec: Angle.Degrees(+41.71924710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141347"},
        {"Hipparcos Number", "HIP 77312"},
        {"Geneva Identification System", "GEN# +1.00141347"},
        {"Smithsonian Astrophysical Observation", "SAO 45724"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.75897322),
        dec: Angle.Degrees(+41.71972069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101853"},
        {"Hipparcos Number", "HIP 57191"},
        {"Geneva Identification System", "GEN# +1.00101853"},
        {"Smithsonian Astrophysical Observation", "SAO 43875"},
        {"Wilson Evans Batten Catalogue", "WEB 10287"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.90477540),
        dec: Angle.Degrees(+41.72247449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80749",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80749"},
    },
    visualMagnitude: 10.12,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.30900151),
        dec: Angle.Degrees(+41.72313638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7010",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7010"},
        {"Smithsonian Astrophysical Observation", "SAO 37278"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.56447549),
        dec: Angle.Degrees(+41.72551911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98029"},
        {"Hipparcos Number", "HIP 55101"},
        {"Smithsonian Astrophysical Observation", "SAO 43677"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.22281352),
        dec: Angle.Degrees(+41.72566901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21650"},
        {"Hipparcos Number", "HIP 16406"},
        {"Geneva Identification System", "GEN# +1.00021650"},
        {"Smithsonian Astrophysical Observation", "SAO 38907"},
        {"Wilson Evans Batten Catalogue", "WEB 3135"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.81530355),
        dec: Angle.Degrees(+41.72646805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126426"},
        {"Hipparcos Number", "HIP 70409"},
        {"Smithsonian Astrophysical Observation", "SAO 45037"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.06840312),
        dec: Angle.Degrees(+41.72904935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27729"},
        {"Hipparcos Number", "HIP 20576"},
        {"Fundamental Katalog 5th Edition", "FK5 4403"},
        {"Geneva Identification System", "GEN# +1.00027729"},
        {"Smithsonian Astrophysical Observation", "SAO 39509"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.11495590),
        dec: Angle.Degrees(+41.73006148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155784"},
        {"Hipparcos Number", "HIP 84118"},
        {"Geneva Identification System", "GEN# +1.00155784"},
        {"Smithsonian Astrophysical Observation", "SAO 46558"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.95916982),
        dec: Angle.Degrees(+41.73011044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3933",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3933"},
        {"Geneva Identification System", "GEN# +0.04000173"},
        {"Smithsonian Astrophysical Observation", "SAO 36705"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.61634353),
        dec: Angle.Degrees(+41.73028685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3223",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3223"},
        {"Smithsonian Astrophysical Observation", "SAO 36570"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.24161169),
        dec: Angle.Degrees(+41.73086813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88247"},
        {"Hipparcos Number", "HIP 49920"},
        {"Smithsonian Astrophysical Observation", "SAO 43226"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.88581945),
        dec: Angle.Degrees(+41.73179017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19978",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19978"},
        {"Wilson Evans Batten Catalogue", "WEB 3813"},
    },
    visualMagnitude: 11.22,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.27527467),
        dec: Angle.Degrees(+41.73184099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 276885"},
        {"Hipparcos Number", "HIP 22452"},
        {"Smithsonian Astrophysical Observation", "SAO 39786"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.47250681),
        dec: Angle.Degrees(+41.73241194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164503"},
        {"Hipparcos Number", "HIP 88096"},
        {"Geneva Identification System", "GEN# +1.00164503"},
        {"Smithsonian Astrophysical Observation", "SAO 47111"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.88232043),
        dec: Angle.Degrees(+41.73259391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74961",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Nikawiy"},
        {"Henry Draper", "HD 136418"},
        {"Hipparcos Number", "HIP 74961"},
        {"Geneva Identification System", "GEN# +1.00136418"},
        {"Smithsonian Astrophysical Observation", "SAO 45483"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.77582335),
        dec: Angle.Degrees(+41.73364823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14707",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14707"},
        {"Smithsonian Astrophysical Observation", "SAO 38616"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.50775784),
        dec: Angle.Degrees(+41.73386285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187141"},
        {"Hipparcos Number", "HIP 97314"},
        {"Smithsonian Astrophysical Observation", "SAO 48824"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.65140363),
        dec: Angle.Degrees(+41.73802887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72614"},
        {"Hipparcos Number", "HIP 42145"},
        {"Cincinnati Publication", "Ci 18 1000"},
        {"Cincinnati Publication 2", "Ci 20 477"},
        {"Geneva Identification System", "GEN# +1.00072614"},
        {"Wilson Evans Batten Catalogue", "WEB 8099"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.86700732),
        dec: Angle.Degrees(+41.74180876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -267.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -635.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180213"},
        {"Hipparcos Number", "HIP 94483"},
        {"Smithsonian Astrophysical Observation", "SAO 48222"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.46365663),
        dec: Angle.Degrees(+41.74278471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205086"},
        {"Hipparcos Number", "HIP 106302"},
        {"Smithsonian Astrophysical Observation", "SAO 50983"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.95042562),
        dec: Angle.Degrees(+41.74391410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47778",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47778"},
        {"Smithsonian Astrophysical Observation", "SAO 43006"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.11135393),
        dec: Angle.Degrees(+41.74555857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26285"},
        {"Hipparcos Number", "HIP 19550"},
        {"Smithsonian Astrophysical Observation", "SAO 39362"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.80516825),
        dec: Angle.Degrees(+41.74755834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15242"},
        {"Hipparcos Number", "HIP 11519"},
        {"Smithsonian Astrophysical Observation", "SAO 38053"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.14071518),
        dec: Angle.Degrees(+41.74900713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65138",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65138"},
        {"Geneva Identification System", "GEN# +0.04202392"},
        {"Smithsonian Astrophysical Observation", "SAO 44574"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.22576948),
        dec: Angle.Degrees(+41.75182703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219989"},
        {"Hipparcos Number", "HIP 115200"},
        {"Smithsonian Astrophysical Observation", "SAO 52917"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.00496536),
        dec: Angle.Degrees(+41.75484073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138933"},
        {"Hipparcos Number", "HIP 76180"},
        {"Smithsonian Astrophysical Observation", "SAO 45611"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.40389431),
        dec: Angle.Degrees(+41.75602468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27520",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27520"},
        {"Smithsonian Astrophysical Observation", "SAO 40629"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.41071167),
        dec: Angle.Degrees(+41.75797846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223602"},
        {"Hipparcos Number", "HIP 117588"},
        {"Geneva Identification System", "GEN# +1.00223602"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.70787508),
        dec: Angle.Degrees(+41.75811744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72235"},
        {"Hipparcos Number", "HIP 41974"},
        {"Geneva Identification System", "GEN# +1.00072235"},
        {"Smithsonian Astrophysical Observation", "SAO 42425"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.33946579),
        dec: Angle.Degrees(+41.75815537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61386",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61386"},
        {"Geneva Identification System", "GEN# +0.04202323"},
        {"Smithsonian Astrophysical Observation", "SAO 44237"},
        {"Wilson Evans Batten Catalogue", "WEB 10927"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.68859923),
        dec: Angle.Degrees(+41.75935935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198401"},
        {"Hipparcos Number", "HIP 102714"},
        {"Geneva Identification System", "GEN# +1.00198401"},
        {"Smithsonian Astrophysical Observation", "SAO 50089"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.17874388),
        dec: Angle.Degrees(+41.76285890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11839"},
        {"Hipparcos Number", "HIP 9101"},
        {"Smithsonian Astrophysical Observation", "SAO 37632"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.30624796),
        dec: Angle.Degrees(+41.76593389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196134"},
        {"Hipparcos Number", "HIP 101467"},
        {"Geneva Identification System", "GEN# +1.00196134"},
        {"Smithsonian Astrophysical Observation", "SAO 49796"},
        {"Wilson Evans Batten Catalogue", "WEB 18331"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.45231332),
        dec: Angle.Degrees(+41.77282122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186619"},
        {"Hipparcos Number", "HIP 97081"},
        {"Geneva Identification System", "GEN# +1.00186619"},
        {"Smithsonian Astrophysical Observation", "SAO 48771"},
        {"Wilson Evans Batten Catalogue", "WEB 17038"},
    },
    visualMagnitude: 5.86,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.93784116),
        dec: Angle.Degrees(+41.77308397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217464"},
        {"Hipparcos Number", "HIP 113578"},
        {"Smithsonian Astrophysical Observation", "SAO 52576"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.08011131),
        dec: Angle.Degrees(+41.77323932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55147",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8117 AB"},
        {"Henry Draper", "HD 98087"},
        {"Hipparcos Number", "HIP 55147"},
        {"Smithsonian Astrophysical Observation", "SAO 43682"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.36092509),
        dec: Angle.Degrees(+41.77330769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219815"},
        {"Hipparcos Number", "HIP 115065"},
        {"Geneva Identification System", "GEN# +1.00219815"},
        {"Renson", "Renson 60340"},
        {"Smithsonian Astrophysical Observation", "SAO 52881"},
        {"Wilson Evans Batten Catalogue", "WEB 20386"},
    },
    visualMagnitude: 5.98,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.59721541),
        dec: Angle.Degrees(+41.77370255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8028",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8028"},
        {"Smithsonian Astrophysical Observation", "SAO 37458"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.77317388),
        dec: Angle.Degrees(+41.77420617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229230"},
        {"Hipparcos Number", "HIP 100583"},
        {"Geneva Identification System", "GEN# +1.00229230"},
        {"Smithsonian Astrophysical Observation", "SAO 49575"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.95872843),
        dec: Angle.Degrees(+41.77505603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48563"},
        {"Hipparcos Number", "HIP 32421"},
        {"Smithsonian Astrophysical Observation", "SAO 41324"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.51679173),
        dec: Angle.Degrees(+41.77516353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100266"},
        {"Hipparcos Number", "HIP 56306"},
        {"Fundamental Katalog 5th Edition", "FK5 5016"},
        {"Smithsonian Astrophysical Observation", "SAO 43801"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.14676224),
        dec: Angle.Degrees(+41.77529748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94234",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12142 A"},
        {"Henry Draper", "HD 179506"},
        {"Hipparcos Number", "HIP 94234"},
        {"Celescope Catalog", "CEL 4714"},
        {"Geneva Identification System", "GEN# +1.00179506"},
        {"Smithsonian Astrophysical Observation", "SAO 48165"},
    },
    visualMagnitude: 7.91,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.74066602),
        dec: Angle.Degrees(+41.77595484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108092",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108092"},
        {"Cincinnati Publication", "Ci 20 1320"},
        {"Geneva Identification System", "GEN# +6.10010839"},
        {"Wilson Evans Batten Catalogue", "WEB 19489"},
    },
    visualMagnitude: 10.30,
    bvColour: 1.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.49458666),
        dec: Angle.Degrees(+41.77989728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 384.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -357.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49520"},
        {"Hipparcos Number", "HIP 32844"},
        {"Fundamental Katalog 5th Edition", "FK5 2527"},
        {"Geneva Identification System", "GEN# +1.00049520"},
        {"Smithsonian Astrophysical Observation", "SAO 41380"},
        {"Wilson Evans Batten Catalogue", "WEB 6610"},
    },
    visualMagnitude: 4.99,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.69151315),
        dec: Angle.Degrees(+41.78156548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86590",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86590"},
        {"Smithsonian Astrophysical Observation", "SAO 46891"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.44486467),
        dec: Angle.Degrees(+41.78218428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76943"},
        {"Henry Draper 2", "HD 76943B"},
        {"Hipparcos Number", "HIP 44248"},
        {"Cincinnati Publication", "Ci 20 502"},
        {"Fundamental Katalog 5th Edition", "FK5 339"},
        {"Geneva Identification System", "GEN# +1.00076943"},
        {"Smithsonian Astrophysical Observation", "SAO 42642"},
        {"Wilson Evans Batten Catalogue", "WEB 8490"},
    },
    visualMagnitude: 3.96,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.16146765),
        dec: Angle.Degrees(+41.78344401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -487.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85904",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85904"},
    },
    visualMagnitude: 11.27,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.32089017),
        dec: Angle.Degrees(+41.78489651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 277012"},
        {"Hipparcos Number", "HIP 22673"},
        {"Smithsonian Astrophysical Observation", "SAO 39823"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.14704269),
        dec: Angle.Degrees(+41.78505528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114071",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16516 AB"},
        {"Hipparcos Number", "HIP 114071"},
        {"Smithsonian Astrophysical Observation", "SAO 52677"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.54046633),
        dec: Angle.Degrees(+41.78985978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210968"},
        {"Hipparcos Number", "HIP 109688"},
        {"Smithsonian Astrophysical Observation", "SAO 51770"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.28708577),
        dec: Angle.Degrees(+41.79007469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151604"},
        {"Hipparcos Number", "HIP 82123"},
        {"Geneva Identification System", "GEN# +1.00151604"},
        {"Renson", "Renson 42906"},
        {"Smithsonian Astrophysical Observation", "SAO 46276"},
        {"Wilson Evans Batten Catalogue", "WEB 13867"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.64784918),
        dec: Angle.Degrees(+41.79234317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143917"},
        {"Hipparcos Number", "HIP 78490"},
        {"Smithsonian Astrophysical Observation", "SAO 45845"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.34824822),
        dec: Angle.Degrees(+41.79623526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127334"},
        {"Hipparcos Number", "HIP 70873"},
        {"Cincinnati Publication", "Ci 18 1906"},
        {"Fundamental Katalog 5th Edition", "FK5 3146"},
        {"Geneva Identification System", "GEN# +1.00127334"},
        {"Smithsonian Astrophysical Observation", "SAO 45075"},
        {"Wilson Evans Batten Catalogue", "WEB 12270"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.40284392),
        dec: Angle.Degrees(+41.79644804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 161.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -220.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132752"},
        {"Hipparcos Number", "HIP 73351"},
        {"Smithsonian Astrophysical Observation", "SAO 45317"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.84926745),
        dec: Angle.Degrees(+41.83368407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110373",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15867 AB"},
        {"Henry Draper", "HD 212153"},
        {"Hipparcos Number", "HIP 110373"},
        {"Smithsonian Astrophysical Observation", "SAO 51911"},
    },
    visualMagnitude: 8.34,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.33802401),
        dec: Angle.Degrees(+41.79670013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67008"},
        {"Hipparcos Number", "HIP 39771"},
        {"Smithsonian Astrophysical Observation", "SAO 42180"},
        {"Wilson Evans Batten Catalogue", "WEB 7759"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.92327619),
        dec: Angle.Degrees(+41.80057221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42314",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6894 AB"},
        {"Henry Draper", "HD 73018"},
        {"Hipparcos Number", "HIP 42314"},
        {"Smithsonian Astrophysical Observation", "SAO 42459"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.41366718),
        dec: Angle.Degrees(+41.80088143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41943",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41943"},
        {"Smithsonian Astrophysical Observation", "SAO 42422"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.26267193),
        dec: Angle.Degrees(+41.80113327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34759"},
        {"Hipparcos Number", "HIP 25048"},
        {"Celescope Catalog", "CEL 639"},
        {"Fundamental Katalog 5th Edition", "FK5 2400"},
        {"Geneva Identification System", "GEN# +1.00034759"},
        {"Smithsonian Astrophysical Observation", "SAO 40269"},
        {"Wilson Evans Batten Catalogue", "WEB 4854"},
    },
    visualMagnitude: 5.22,
    bvColour: -0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.45168832),
        dec: Angle.Degrees(+41.80466344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28178"},
        {"Hipparcos Number", "HIP 20886"},
        {"Geneva Identification System", "GEN# +1.00028178"},
        {"Smithsonian Astrophysical Observation", "SAO 39554"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.14446602),
        dec: Angle.Degrees(+41.80671135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18112"},
        {"Hipparcos Number", "HIP 13662"},
        {"Fundamental Katalog 5th Edition", "FK5 4267"},
        {"Geneva Identification System", "GEN# +1.00018112"},
        {"Smithsonian Astrophysical Observation", "SAO 38446"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.98075593),
        dec: Angle.Degrees(+41.80684199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15923"},
        {"Hipparcos Number", "HIP 12008"},
        {"Smithsonian Astrophysical Observation", "SAO 38138"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.69967458),
        dec: Angle.Degrees(+41.80716005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27278"},
        {"Hipparcos Number", "HIP 20241"},
        {"Geneva Identification System", "GEN# +1.00027278"},
        {"Smithsonian Astrophysical Observation", "SAO 39468"},
        {"Wilson Evans Batten Catalogue", "WEB 3859"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.06007219),
        dec: Angle.Degrees(+41.80815345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76156",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9694 AB"},
        {"Henry Draper", "HD 138884"},
        {"Hipparcos Number", "HIP 76156"},
        {"Smithsonian Astrophysical Observation", "SAO 45606"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.31625426),
        dec: Angle.Degrees(+41.80956961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67509",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67509"},
        {"Smithsonian Astrophysical Observation", "SAO 44770"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.50181375),
        dec: Angle.Degrees(+41.81142894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88577"},
        {"Hipparcos Number", "HIP 50117"},
        {"Geneva Identification System", "GEN# +1.00088577"},
        {"Smithsonian Astrophysical Observation", "SAO 43239"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.46934567),
        dec: Angle.Degrees(+41.81458796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30482",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30482"},
        {"Smithsonian Astrophysical Observation", "SAO 41074"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.11672361),
        dec: Angle.Degrees(+41.81621672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190112"},
        {"Hipparcos Number", "HIP 98607"},
        {"Smithsonian Astrophysical Observation", "SAO 49101"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.43414869),
        dec: Angle.Degrees(+41.81644370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64261",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64261"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.56696097),
        dec: Angle.Degrees(+41.81748476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48099",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48099"},
        {"Smithsonian Astrophysical Observation", "SAO 43045"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.10771730),
        dec: Angle.Degrees(+41.85420186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15754"},
        {"Hipparcos Number", "HIP 11871"},
        {"Geneva Identification System", "GEN# +1.00015754"},
        {"Smithsonian Astrophysical Observation", "SAO 38113"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.28870951),
        dec: Angle.Degrees(+41.81766985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56604",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56604"},
        {"Smithsonian Astrophysical Observation", "SAO 43820"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.08271373),
        dec: Angle.Degrees(+41.81846712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64206"},
        {"Hipparcos Number", "HIP 38632"},
        {"Smithsonian Astrophysical Observation", "SAO 42059"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.66123482),
        dec: Angle.Degrees(+41.81852384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112242",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16227 A"},
        {"Henry Draper", "HD 215373"},
        {"Hipparcos Number", "HIP 112242"},
        {"Fundamental Katalog 5th Edition", "FK5 858"},
        {"Geneva Identification System", "GEN# +1.00215373"},
        {"Smithsonian Astrophysical Observation", "SAO 52317"},
        {"Wilson Evans Batten Catalogue", "WEB 20029"},
    },
    visualMagnitude: 5.11,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.02285629),
        dec: Angle.Degrees(+41.81922714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66390"},
        {"Hipparcos Number", "HIP 39563"},
        {"Smithsonian Astrophysical Observation", "SAO 42164"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.26117939),
        dec: Angle.Degrees(+41.82011604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206655"},
        {"Hipparcos Number", "HIP 107168"},
        {"Geneva Identification System", "GEN# +1.00206655"},
        {"Smithsonian Astrophysical Observation", "SAO 51211"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.61795366),
        dec: Angle.Degrees(+41.82093628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193116"},
        {"Hipparcos Number", "HIP 99976"},
        {"Smithsonian Astrophysical Observation", "SAO 49416"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.23937167),
        dec: Angle.Degrees(+41.82144307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112138"},
        {"Hipparcos Number", "HIP 62935"},
        {"Geneva Identification System", "GEN# +1.00112138"},
        {"Smithsonian Astrophysical Observation", "SAO 44379"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.46574307),
        dec: Angle.Degrees(+41.82255807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48451",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48451"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.18459242),
        dec: Angle.Degrees(+41.82274597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56729",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56729"},
        {"Smithsonian Astrophysical Observation", "SAO 43834"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.46144378),
        dec: Angle.Degrees(+41.82606672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -194.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54663",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54663"},
    },
    visualMagnitude: 9.89,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.84966507),
        dec: Angle.Degrees(+41.82673920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -264.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35120"},
        {"Hipparcos Number", "HIP 25284"},
        {"Celescope Catalog", "CEL 670"},
        {"Geneva Identification System", "GEN# +1.00035120"},
        {"Smithsonian Astrophysical Observation", "SAO 40317"},
        {"Wilson Evans Batten Catalogue", "WEB 4900"},
    },
    visualMagnitude: 7.66,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.12723462),
        dec: Angle.Degrees(+41.82706387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223583"},
        {"Hipparcos Number", "HIP 117582"},
        {"Geneva Identification System", "GEN# +1.00223583"},
        {"Smithsonian Astrophysical Observation", "SAO 53415"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.68344152),
        dec: Angle.Degrees(+41.82756689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 180.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26392",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4204 AB"},
        {"Henry Draper", "HD 36929"},
        {"Hipparcos Number", "HIP 26392"},
        {"Smithsonian Astrophysical Observation", "SAO 40485"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.27996591),
        dec: Angle.Degrees(+41.82833557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55403",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55403"},
        {"Smithsonian Astrophysical Observation", "SAO 43704"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.18149823),
        dec: Angle.Degrees(+41.83022375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103943"},
        {"Hipparcos Number", "HIP 58390"},
        {"Geneva Identification System", "GEN# +1.00103943"},
        {"Smithsonian Astrophysical Observation", "SAO 43977"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.58711700),
        dec: Angle.Degrees(+41.83108135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179837"},
        {"Hipparcos Number", "HIP 94343"},
        {"Geneva Identification System", "GEN# +1.00179837"},
        {"Smithsonian Astrophysical Observation", "SAO 48187"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.03967539),
        dec: Angle.Degrees(+41.83764701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37184"},
        {"Hipparcos Number", "HIP 26546"},
        {"Smithsonian Astrophysical Observation", "SAO 40507"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.68263282),
        dec: Angle.Degrees(+41.83931285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61657",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61657"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.58741208),
        dec: Angle.Degrees(+41.84136162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11375"},
        {"Hipparcos Number", "HIP 8763"},
        {"Smithsonian Astrophysical Observation", "SAO 37579"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.18807385),
        dec: Angle.Degrees(+41.84157427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22721"},
        {"Hipparcos Number", "HIP 17189"},
        {"Geneva Identification System", "GEN# +1.00022721"},
        {"Smithsonian Astrophysical Observation", "SAO 39034"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.20769835),
        dec: Angle.Degrees(+41.84175152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55649",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55649"},
        {"Smithsonian Astrophysical Observation", "SAO 43728"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.00468969),
        dec: Angle.Degrees(+41.84224438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197679"},
        {"Hipparcos Number", "HIP 102313"},
        {"Celescope Catalog", "CEL 5156"},
        {"Geneva Identification System", "GEN# +1.00197679"},
        {"Smithsonian Astrophysical Observation", "SAO 49999"},
    },
    visualMagnitude: 8.50,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.95533752),
        dec: Angle.Degrees(+41.84230138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145889"},
        {"Hipparcos Number", "HIP 79347"},
        {"Smithsonian Astrophysical Observation", "SAO 45955"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.90688010),
        dec: Angle.Degrees(+41.84312897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106893",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106893"},
        {"Smithsonian Astrophysical Observation", "SAO 51139"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.74641406),
        dec: Angle.Degrees(+41.84485349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126969"},
        {"Hipparcos Number", "HIP 70701"},
        {"Geneva Identification System", "GEN# +1.00126969"},
        {"Smithsonian Astrophysical Observation", "SAO 45060"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.90401889),
        dec: Angle.Degrees(+41.84876575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89572"},
        {"Hipparcos Number", "HIP 50687"},
        {"Geneva Identification System", "GEN# +1.00089572"},
        {"Smithsonian Astrophysical Observation", "SAO 43296"},
        {"Wilson Evans Batten Catalogue", "WEB 9290"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.26528908),
        dec: Angle.Degrees(+41.84938697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1212"},
        {"Hipparcos Number", "HIP 1335"},
        {"Geneva Identification System", "GEN# +1.00001212"},
        {"Smithsonian Astrophysical Observation", "SAO 36229"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.18103104),
        dec: Angle.Degrees(+41.84943398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222499"},
        {"Hipparcos Number", "HIP 116847"},
        {"Geneva Identification System", "GEN# +1.00222499"},
        {"Smithsonian Astrophysical Observation", "SAO 53267"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.26899312),
        dec: Angle.Degrees(+41.85055043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83712",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83712"},
        {"Smithsonian Astrophysical Observation", "SAO 46488"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.62634306),
        dec: Angle.Degrees(+41.85124865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59859",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59859"},
        {"Smithsonian Astrophysical Observation", "SAO 44100"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.14726308),
        dec: Angle.Degrees(+41.85179743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73233",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73233"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.51184482),
        dec: Angle.Degrees(+41.85213926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41467"},
        {"Hipparcos Number", "HIP 29025"},
        {"Geneva Identification System", "GEN# +1.00041467"},
        {"Smithsonian Astrophysical Observation", "SAO 40868"},
        {"Wilson Evans Batten Catalogue", "WEB 5681"},
    },
    visualMagnitude: 6.15,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.86149787),
        dec: Angle.Degrees(+41.85432982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24945"},
        {"Hipparcos Number", "HIP 18664"},
        {"Geneva Identification System", "GEN# +1.00024945"},
        {"Smithsonian Astrophysical Observation", "SAO 39232"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.93846093),
        dec: Angle.Degrees(+41.85613051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23438"},
        {"Hipparcos Number", "HIP 17655"},
        {"Geneva Identification System", "GEN# +1.00023438"},
        {"Smithsonian Astrophysical Observation", "SAO 39099"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.72025355),
        dec: Angle.Degrees(+41.85927934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19564",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3038 AB"},
        {"Henry Draper", "HD 26310"},
        {"Hipparcos Number", "HIP 19564"},
        {"Geneva Identification System", "GEN# +1.00026310J"},
        {"Smithsonian Astrophysical Observation", "SAO 39365"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.86250741),
        dec: Angle.Degrees(+41.85995522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20179"},
        {"Hipparcos Number", "HIP 15216"},
        {"Geneva Identification System", "GEN# +1.00020179"},
        {"Smithsonian Astrophysical Observation", "SAO 38687"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.03543963),
        dec: Angle.Degrees(+41.86028452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95464"},
        {"Hipparcos Number", "HIP 53894"},
        {"Geneva Identification System", "GEN# +1.00095464"},
        {"Smithsonian Astrophysical Observation", "SAO 43579"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.41291594),
        dec: Angle.Degrees(+41.86045419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45790",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45790"},
    },
    visualMagnitude: 10.87,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.04677485),
        dec: Angle.Degrees(+41.86560927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54088",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54088"},
        {"Smithsonian Astrophysical Observation", "SAO 43598"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.01651521),
        dec: Angle.Degrees(+41.86714650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26746"},
        {"Hipparcos Number", "HIP 19863"},
        {"Geneva Identification System", "GEN# +1.00026746"},
        {"Smithsonian Astrophysical Observation", "SAO 39419"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.90022811),
        dec: Angle.Degrees(+41.86938137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91544"},
        {"Hipparcos Number", "HIP 51803"},
        {"Smithsonian Astrophysical Observation", "SAO 43389"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.76456979),
        dec: Angle.Degrees(+41.86999600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98001",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13125 AB"},
        {"Henry Draper", "HD 188753"},
        {"Hipparcos Number", "HIP 98001"},
        {"Geneva Identification System", "GEN# +1.00188753"},
        {"Smithsonian Astrophysical Observation", "SAO 48968"},
        {"Wilson Evans Batten Catalogue", "WEB 17257"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.74338277),
        dec: Angle.Degrees(+41.87083952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 284.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56325"},
        {"Hipparcos Number", "HIP 35382"},
        {"Geneva Identification System", "GEN# +1.00056325"},
        {"Smithsonian Astrophysical Observation", "SAO 41687"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.62917415),
        dec: Angle.Degrees(+41.87173672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148095"},
        {"Hipparcos Number", "HIP 80321"},
        {"Smithsonian Astrophysical Observation", "SAO 46064"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.98018100),
        dec: Angle.Degrees(+41.87313170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31664"},
        {"Hipparcos Number", "HIP 23213"},
        {"Geneva Identification System", "GEN# +1.00031664"},
        {"Smithsonian Astrophysical Observation", "SAO 39921"},
        {"Wilson Evans Batten Catalogue", "WEB 4508"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.92827400),
        dec: Angle.Degrees(+41.87315953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88785"},
        {"Hipparcos Number", "HIP 50238"},
        {"Geneva Identification System", "GEN# +1.00088785"},
        {"Smithsonian Astrophysical Observation", "SAO 43247"},
        {"Wilson Evans Batten Catalogue", "WEB 9229"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.85871246),
        dec: Angle.Degrees(+41.87511875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204583"},
        {"Hipparcos Number", "HIP 106023"},
        {"Smithsonian Astrophysical Observation", "SAO 50906"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.11529791),
        dec: Angle.Degrees(+41.87594600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61478"},
        {"Hipparcos Number", "HIP 37463"},
        {"Smithsonian Astrophysical Observation", "SAO 41937"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.34373321),
        dec: Angle.Degrees(+41.87632964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87026",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87026"},
        {"Smithsonian Astrophysical Observation", "SAO 46946"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.72326915),
        dec: Angle.Degrees(+41.88021138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32418"},
        {"Hipparcos Number", "HIP 23650"},
        {"Geneva Identification System", "GEN# +1.00032418"},
        {"Smithsonian Astrophysical Observation", "SAO 40001"},
        {"Wilson Evans Batten Catalogue", "WEB 4611"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.24432087),
        dec: Angle.Degrees(+41.88047717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24689"},
        {"Hipparcos Number", "HIP 18499"},
        {"Smithsonian Astrophysical Observation", "SAO 39212"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.31792750),
        dec: Angle.Degrees(+41.88065989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106810",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15155 AB"},
        {"Henry Draper", "HD 205997"},
        {"Hipparcos Number", "HIP 106810"},
        {"Smithsonian Astrophysical Observation", "SAO 51118"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.49311305),
        dec: Angle.Degrees(+41.88080434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148783"},
        {"Hipparcos Number", "HIP 80704"},
        {"Fundamental Katalog 5th Edition", "FK5 3303"},
        {"Geneva Identification System", "GEN# +1.00148783"},
        {"Smithsonian Astrophysical Observation", "SAO 46108"},
        {"Wilson Evans Batten Catalogue", "WEB 13650"},
    },
    visualMagnitude: 4.83,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.16052050),
        dec: Angle.Degrees(+41.88169065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215592"},
        {"Hipparcos Number", "HIP 112377"},
        {"Geneva Identification System", "GEN# +1.00215592"},
        {"Smithsonian Astrophysical Observation", "SAO 52339"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.40880764),
        dec: Angle.Degrees(+41.88291346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88513"},
        {"Hipparcos Number", "HIP 50077"},
        {"Geneva Identification System", "GEN# +1.00088513"},
        {"Smithsonian Astrophysical Observation", "SAO 43238"},
        {"Wilson Evans Batten Catalogue", "WEB 9207"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.36705729),
        dec: Angle.Degrees(+41.88362306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53523",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53523"},
        {"Cincinnati Publication", "Ci 20 599"},
        {"Geneva Identification System", "GEN# +0.04202163"},
        {"Wilson Evans Batten Catalogue", "WEB 9719"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.808,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.25256762),
        dec: Angle.Degrees(+41.88513025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -686.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -286.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156965"},
        {"Hipparcos Number", "HIP 84670"},
        {"Geneva Identification System", "GEN# +1.00156965"},
        {"Renson", "Renson 44140"},
        {"Smithsonian Astrophysical Observation", "SAO 46626"},
        {"Wilson Evans Batten Catalogue", "WEB 14298"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.65188488),
        dec: Angle.Degrees(+41.88808610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196360"},
        {"Hipparcos Number", "HIP 101588"},
        {"Geneva Identification System", "GEN# +1.00196360"},
        {"Smithsonian Astrophysical Observation", "SAO 49835"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.82508657),
        dec: Angle.Degrees(+41.89013179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59173"},
        {"Hipparcos Number", "HIP 36507"},
        {"Smithsonian Astrophysical Observation", "SAO 41822"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.66368980),
        dec: Angle.Degrees(+41.89041335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33168"},
        {"Hipparcos Number", "HIP 24075"},
        {"Geneva Identification System", "GEN# +1.00033168"},
        {"Smithsonian Astrophysical Observation", "SAO 40073"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.58295029),
        dec: Angle.Degrees(+41.89192632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11780"},
        {"Hipparcos Number", "HIP 9045"},
        {"Smithsonian Astrophysical Observation", "SAO 37625"},
    },
    visualMagnitude: 6.98,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.13406327),
        dec: Angle.Degrees(+41.89208424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185265"},
        {"Hipparcos Number", "HIP 96442"},
        {"Smithsonian Astrophysical Observation", "SAO 48638"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.11218701),
        dec: Angle.Degrees(+41.89270734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71549",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71549"},
        {"Smithsonian Astrophysical Observation", "SAO 45142"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.50474523),
        dec: Angle.Degrees(+41.89329059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152262"},
        {"Hipparcos Number", "HIP 82419"},
        {"Geneva Identification System", "GEN# +1.00152262"},
        {"Smithsonian Astrophysical Observation", "SAO 46317"},
        {"Wilson Evans Batten Catalogue", "WEB 13915"},
    },
    visualMagnitude: 6.29,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.65062571),
        dec: Angle.Degrees(+41.89634680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90744",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90744"},
        {"Smithsonian Astrophysical Observation", "SAO 47557"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.73844736),
        dec: Angle.Degrees(+41.89645190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20589"},
        {"Hipparcos Number", "HIP 15544"},
        {"Geneva Identification System", "GEN# +1.00020589"},
        {"Smithsonian Astrophysical Observation", "SAO 38738"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.07199554),
        dec: Angle.Degrees(+41.89724650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195987"},
        {"Hipparcos Number", "HIP 101382"},
        {"Cincinnati Publication", "Ci 20 1214"},
        {"Cincinnati Publication 2", "Ci 18 2667"},
        {"Geneva Identification System", "GEN# +9.00031359"},
        {"Smithsonian Astrophysical Observation", "SAO 49769"},
        {"Wilson Evans Batten Catalogue", "WEB 18320"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.21568724),
        dec: Angle.Degrees(+41.89737776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -156.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 452.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83447",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10322 AB"},
        {"Henry Draper", "HD 154393"},
        {"Hipparcos Number", "HIP 83447"},
        {"Smithsonian Astrophysical Observation", "SAO 46459"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.81994845),
        dec: Angle.Degrees(+41.89749368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33412"},
        {"Hipparcos Number", "HIP 24220"},
        {"Geneva Identification System", "GEN# +1.00033412J"},
        {"Smithsonian Astrophysical Observation", "SAO 40102"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.01086598),
        dec: Angle.Degrees(+41.89792587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59835",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8490 A"},
        {"Henry Draper", "HD 106712"},
        {"Hipparcos Number", "HIP 59835"},
        {"Geneva Identification System", "GEN# +1.00106712J"},
        {"Smithsonian Astrophysical Observation", "SAO 44098"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.04416824),
        dec: Angle.Degrees(+41.89867474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105448",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105448"},
        {"Renson", "Renson 56677"},
        {"Smithsonian Astrophysical Observation", "SAO 50752"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.37309460),
        dec: Angle.Degrees(+41.89945413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46770",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46770"},
    },
    visualMagnitude: 11.01,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.98669698),
        dec: Angle.Degrees(+41.90113245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13718"},
        {"Hipparcos Number", "HIP 10457"},
        {"Smithsonian Astrophysical Observation", "SAO 37892"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.69464627),
        dec: Angle.Degrees(+41.90578311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115640",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115640"},
        {"Smithsonian Astrophysical Observation", "SAO 53001"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.39217764),
        dec: Angle.Degrees(+41.90589792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91564"},
        {"Hipparcos Number", "HIP 51813"},
        {"Fundamental Katalog 5th Edition", "FK5 4941"},
        {"Geneva Identification System", "GEN# +1.00091564"},
        {"Smithsonian Astrophysical Observation", "SAO 43390"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.78573768),
        dec: Angle.Degrees(+41.90896548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194684"},
        {"Hipparcos Number", "HIP 100737"},
        {"Smithsonian Astrophysical Observation", "SAO 49602"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.35977163),
        dec: Angle.Degrees(+41.91040726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66271",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66271"},
        {"Geneva Identification System", "GEN# +0.04202416"},
    },
    visualMagnitude: 9.85,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.73784721),
        dec: Angle.Degrees(+41.91205554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96853"},
        {"Hipparcos Number", "HIP 54536"},
        {"Smithsonian Astrophysical Observation", "SAO 43628"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.40826041),
        dec: Angle.Degrees(+41.91409410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172945"},
        {"Hipparcos Number", "HIP 91610"},
        {"Fundamental Katalog 5th Edition", "FK5 5640"},
        {"Smithsonian Astrophysical Observation", "SAO 47700"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.24872195),
        dec: Angle.Degrees(+41.91716557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40206"},
        {"Hipparcos Number", "HIP 28347"},
        {"Smithsonian Astrophysical Observation", "SAO 40749"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.84944670),
        dec: Angle.Degrees(+41.91743844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37124",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37124"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.42707120),
        dec: Angle.Degrees(+41.91842954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114193",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114193"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.87933602),
        dec: Angle.Degrees(+41.92038645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224366"},
        {"Hipparcos Number", "HIP 118083"},
        {"Geneva Identification System", "GEN# +1.00224366"},
        {"Smithsonian Astrophysical Observation", "SAO 53512"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.29711560),
        dec: Angle.Degrees(+41.92149006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46513"},
        {"Hipparcos Number", "HIP 31514"},
        {"Smithsonian Astrophysical Observation", "SAO 41200"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.98620680),
        dec: Angle.Degrees(+41.92253785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119766"},
        {"Hipparcos Number", "HIP 67044"},
        {"Smithsonian Astrophysical Observation", "SAO 44731"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.10038491),
        dec: Angle.Degrees(+41.92487657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3091",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3091"},
        {"Smithsonian Astrophysical Observation", "SAO 36551"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.83112690),
        dec: Angle.Degrees(+41.92536553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3962",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3962"},
        {"Geneva Identification System", "GEN# +0.04100148"},
        {"Smithsonian Astrophysical Observation", "SAO 36709"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.71840536),
        dec: Angle.Degrees(+41.92567322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20811"},
        {"Hipparcos Number", "HIP 15731"},
        {"Geneva Identification System", "GEN# +1.00020811"},
        {"Smithsonian Astrophysical Observation", "SAO 38763"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.66548657),
        dec: Angle.Degrees(+41.92637292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184787"},
        {"Hipparcos Number", "HIP 96252"},
        {"Celescope Catalog", "CEL 4787"},
        {"Geneva Identification System", "GEN# +1.00184787"},
        {"Smithsonian Astrophysical Observation", "SAO 48596"},
    },
    visualMagnitude: 6.68,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.57575716),
        dec: Angle.Degrees(+41.92723898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42151"},
        {"Hipparcos Number", "HIP 29346"},
        {"Smithsonian Astrophysical Observation", "SAO 40923"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.80594955),
        dec: Angle.Degrees(+41.92841143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24462"},
        {"Hipparcos Number", "HIP 18344"},
        {"Geneva Identification System", "GEN# +1.00024462"},
        {"Smithsonian Astrophysical Observation", "SAO 39192"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.82764390),
        dec: Angle.Degrees(+41.92966783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14136"},
        {"Hipparcos Number", "HIP 10753"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.58107859),
        dec: Angle.Degrees(+41.92967170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113036"},
        {"Hipparcos Number", "HIP 63473"},
        {"Geneva Identification System", "GEN# +1.00113036"},
        {"Smithsonian Astrophysical Observation", "SAO 44423"},
        {"Wilson Evans Batten Catalogue", "WEB 11233"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.09696321),
        dec: Angle.Degrees(+41.93019817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7828",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7828"},
    },
    visualMagnitude: 11.06,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.17884900),
        dec: Angle.Degrees(+41.93158346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 282.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15269"},
        {"Hipparcos Number", "HIP 11536"},
        {"Renson", "Renson 3810"},
        {"Smithsonian Astrophysical Observation", "SAO 38059"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.18234966),
        dec: Angle.Degrees(+41.93186388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25320"},
        {"Hipparcos Number", "HIP 18903"},
        {"Smithsonian Astrophysical Observation", "SAO 39271"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.77755382),
        dec: Angle.Degrees(+41.93207513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205732"},
        {"Hipparcos Number", "HIP 106646"},
        {"Geneva Identification System", "GEN# +1.00205732"},
        {"Smithsonian Astrophysical Observation", "SAO 51082"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.03558382),
        dec: Angle.Degrees(+41.93252448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217161"},
        {"Hipparcos Number", "HIP 113411"},
        {"Celescope Catalog", "CEL 5551"},
        {"Smithsonian Astrophysical Observation", "SAO 52543"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.52782792),
        dec: Angle.Degrees(+41.93444769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40488"},
        {"Hipparcos Number", "HIP 28511"},
        {"Geneva Identification System", "GEN# +1.00040488"},
        {"Smithsonian Astrophysical Observation", "SAO 40782"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.27599495),
        dec: Angle.Degrees(+41.93861895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69071"},
        {"Hipparcos Number", "HIP 40573"},
        {"Smithsonian Astrophysical Observation", "SAO 42266"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.25306207),
        dec: Angle.Degrees(+41.93882850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199892"},
        {"Hipparcos Number", "HIP 103532"},
        {"Celescope Catalog", "CEL 5223"},
        {"Geneva Identification System", "GEN# +1.00199892"},
        {"Smithsonian Astrophysical Observation", "SAO 50303"},
        {"Wilson Evans Batten Catalogue", "WEB 18835"},
    },
    visualMagnitude: 6.17,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.62893463),
        dec: Angle.Degrees(+41.93992417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86239",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86239"},
        {"Smithsonian Astrophysical Observation", "SAO 46845"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.34554779),
        dec: Angle.Degrees(+41.94278484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110722",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110722"},
        {"Smithsonian Astrophysical Observation", "SAO 51987"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.49687102),
        dec: Angle.Degrees(+41.94397351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55643",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55643"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.98159806),
        dec: Angle.Degrees(+41.94571765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88565",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11054 A"},
        {"Henry Draper", "HD 165645"},
        {"Hipparcos Number", "HIP 88565"},
        {"Geneva Identification System", "GEN# +1.00165645"},
        {"Smithsonian Astrophysical Observation", "SAO 47195"},
        {"Wilson Evans Batten Catalogue", "WEB 14997"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.25339289),
        dec: Angle.Degrees(+41.94605135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216200"},
        {"Hipparcos Number", "HIP 112778"},
        {"Geneva Identification System", "GEN# +1.00216200"},
        {"Smithsonian Astrophysical Observation", "SAO 52412"},
        {"Wilson Evans Batten Catalogue", "WEB 20094"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.59070173),
        dec: Angle.Degrees(+41.95340325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70705",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70705"},
    },
    visualMagnitude: 9.91,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.92432527),
        dec: Angle.Degrees(+41.95366816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87274",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10829 A"},
        {"Henry Draper", "HD 162622"},
        {"Hipparcos Number", "HIP 87274"},
        {"Geneva Identification System", "GEN# +1.00162622"},
        {"Smithsonian Astrophysical Observation", "SAO 46991"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.49482897),
        dec: Angle.Degrees(+41.95526358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 357"},
        {"Hipparcos Number", "HIP 683"},
        {"Smithsonian Astrophysical Observation", "SAO 36090"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.10850712),
        dec: Angle.Degrees(+41.95798984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108533",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15520 A"},
        {"Henry Draper", "HD 209005"},
        {"Hipparcos Number", "HIP 108533"},
        {"Smithsonian Astrophysical Observation", "SAO 51513"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.80786694),
        dec: Angle.Degrees(+41.95909472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192039"},
        {"Hipparcos Number", "HIP 99469"},
        {"Celescope Catalog", "CEL 4965"},
        {"Geneva Identification System", "GEN# +1.00192039"},
        {"Smithsonian Astrophysical Observation", "SAO 49290"},
        {"Wilson Evans Batten Catalogue", "WEB 17783"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.82055688),
        dec: Angle.Degrees(+41.95915448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44901"},
        {"Hipparcos Number", "HIP 30640"},
        {"Fundamental Katalog 5th Edition", "FK5 1172"},
        {"Geneva Identification System", "GEN# +1.00044901"},
        {"Smithsonian Astrophysical Observation", "SAO 41099"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.59001552),
        dec: Angle.Degrees(+41.95952345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53448"},
        {"Hipparcos Number", "HIP 34336"},
        {"Smithsonian Astrophysical Observation", "SAO 41565"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.77257920),
        dec: Angle.Degrees(+41.95966594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64309"},
        {"Hipparcos Number", "HIP 38675"},
        {"Smithsonian Astrophysical Observation", "SAO 42066"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.78118357),
        dec: Angle.Degrees(+41.96047911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87275",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10829 B"},
        {"Hipparcos Number", "HIP 87275"},
        {"Smithsonian Astrophysical Observation", "SAO 46992"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.49570733),
        dec: Angle.Degrees(+41.96091277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31759"},
        {"Hipparcos Number", "HIP 23274"},
        {"Geneva Identification System", "GEN# +1.00031759"},
        {"Smithsonian Astrophysical Observation", "SAO 39929"},
        {"Wilson Evans Batten Catalogue", "WEB 4523"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.10896291),
        dec: Angle.Degrees(+41.96168372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209919"},
        {"Hipparcos Number", "HIP 109080"},
        {"Geneva Identification System", "GEN# +1.00209919"},
        {"Smithsonian Astrophysical Observation", "SAO 51638"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.46152472),
        dec: Angle.Degrees(+41.96329038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3677",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 646 AB"},
        {"Henry Draper", "HD 4444"},
        {"Hipparcos Number", "HIP 3677"},
        {"Smithsonian Astrophysical Observation", "SAO 36654"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.76347968),
        dec: Angle.Degrees(+41.96478728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13077"},
        {"Hipparcos Number", "HIP 10028"},
        {"Celescope Catalog", "CEL 210"},
        {"Smithsonian Astrophysical Observation", "SAO 37804"},
    },
    visualMagnitude: 7.16,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.26528867),
        dec: Angle.Degrees(+41.96550265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40786"},
        {"Hipparcos Number", "HIP 28660"},
        {"Smithsonian Astrophysical Observation", "SAO 40814"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.77908546),
        dec: Angle.Degrees(+41.96671115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50906"},
        {"Hipparcos Number", "HIP 33433"},
        {"Smithsonian Astrophysical Observation", "SAO 41456"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.28429341),
        dec: Angle.Degrees(+41.96732035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116443",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116443"},
        {"Cincinnati Publication", "Ci 20 1437"},
    },
    visualMagnitude: 11.17,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.93301426),
        dec: Angle.Degrees(+41.96735815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 701.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 151.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57814"},
        {"Hipparcos Number", "HIP 35968"},
        {"Smithsonian Astrophysical Observation", "SAO 41749"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.20269068),
        dec: Angle.Degrees(+41.96983291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8007"},
        {"Hipparcos Number", "HIP 6241"},
        {"Geneva Identification System", "GEN# +1.00008007"},
        {"Smithsonian Astrophysical Observation", "SAO 37123"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.02040815),
        dec: Angle.Degrees(+41.97066745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177673"},
        {"Hipparcos Number", "HIP 93612"},
        {"Smithsonian Astrophysical Observation", "SAO 48042"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.95309474),
        dec: Angle.Degrees(+41.97427998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216853"},
        {"Hipparcos Number", "HIP 113237"},
        {"Smithsonian Astrophysical Observation", "SAO 52500"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.97057658),
        dec: Angle.Degrees(+41.97556619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28434"},
        {"Hipparcos Number", "HIP 21067"},
        {"Geneva Identification System", "GEN# +1.00028434"},
        {"Smithsonian Astrophysical Observation", "SAO 39577"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.74247062),
        dec: Angle.Degrees(+41.97591011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198974"},
        {"Hipparcos Number", "HIP 103041"},
        {"Smithsonian Astrophysical Observation", "SAO 50162"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.14257416),
        dec: Angle.Degrees(+41.97960939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203469"},
        {"Hipparcos Number", "HIP 105419"},
        {"Smithsonian Astrophysical Observation", "SAO 50742"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.28943381),
        dec: Angle.Degrees(+41.98029706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41225",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41225"},
        {"Smithsonian Astrophysical Observation", "SAO 42343"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.18116970),
        dec: Angle.Degrees(+41.98219955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 950"},
        {"Hipparcos Number", "HIP 1122"},
        {"Smithsonian Astrophysical Observation", "SAO 36184"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.50766107),
        dec: Angle.Degrees(+41.98323934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1417"},
        {"Hipparcos Number", "HIP 1490"},
        {"Smithsonian Astrophysical Observation", "SAO 36252"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.63372115),
        dec: Angle.Degrees(+41.98442698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39668",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6572 A"},
        {"Henry Draper", "HD 66661"},
        {"Hipparcos Number", "HIP 39668"},
        {"Geneva Identification System", "GEN# +1.00066661"},
        {"Smithsonian Astrophysical Observation", "SAO 42171"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.58985226),
        dec: Angle.Degrees(+41.98559451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75781"},
        {"Hipparcos Number", "HIP 43649"},
        {"Smithsonian Astrophysical Observation", "SAO 42587"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.36000541),
        dec: Angle.Degrees(+41.98580015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112914"},
        {"Hipparcos Number", "HIP 63406"},
        {"Geneva Identification System", "GEN# +1.00112914"},
        {"Smithsonian Astrophysical Observation", "SAO 44415"},
        {"Wilson Evans Batten Catalogue", "WEB 11224"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.88736041),
        dec: Angle.Degrees(+41.98632389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -235.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 181.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11027"},
        {"Hipparcos Number", "HIP 8473"},
        {"Fundamental Katalog 5th Edition", "FK5 4166"},
        {"Geneva Identification System", "GEN# +1.00011027"},
        {"Smithsonian Astrophysical Observation", "SAO 37541"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.31137287),
        dec: Angle.Degrees(+41.98915502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92221"},
        {"Hipparcos Number", "HIP 52173"},
        {"Smithsonian Astrophysical Observation", "SAO 43420"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.88595825),
        dec: Angle.Degrees(+41.99013605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39670",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6572 B"},
        {"Hipparcos Number", "HIP 39670"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.59405373),
        dec: Angle.Degrees(+41.99104553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60952",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60952"},
        {"Geneva Identification System", "GEN# +0.04202312"},
        {"Smithsonian Astrophysical Observation", "SAO 44202"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.41465767),
        dec: Angle.Degrees(+41.99227704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111346"},
        {"Hipparcos Number", "HIP 62490"},
        {"Geneva Identification System", "GEN# +1.00111346"},
        {"Smithsonian Astrophysical Observation", "SAO 44330"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.08948325),
        dec: Angle.Degrees(+41.99359951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75493",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75493"},
        {"Smithsonian Astrophysical Observation", "SAO 45528"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.32079233),
        dec: Angle.Degrees(+41.99431349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62003",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62003"},
    },
    visualMagnitude: 11.69,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.61838462),
        dec: Angle.Degrees(+41.99643396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196240"},
        {"Hipparcos Number", "HIP 101528"},
        {"Geneva Identification System", "GEN# +1.00196240"},
        {"Renson", "Renson 54700"},
        {"Smithsonian Astrophysical Observation", "SAO 49822"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.63782973),
        dec: Angle.Degrees(+41.99664263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83444",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83444"},
        {"Smithsonian Astrophysical Observation", "SAO 46458"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.81625849),
        dec: Angle.Degrees(+42.00142111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168827"},
        {"Hipparcos Number", "HIP 89820"},
        {"Smithsonian Astrophysical Observation", "SAO 47394"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.95434490),
        dec: Angle.Degrees(+42.00166728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164182"},
        {"Hipparcos Number", "HIP 87952"},
        {"Geneva Identification System", "GEN# +1.00164182"},
        {"Smithsonian Astrophysical Observation", "SAO 47097"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.50530664),
        dec: Angle.Degrees(+42.00202900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75556"},
        {"Hipparcos Number", "HIP 43550"},
        {"Geneva Identification System", "GEN# +1.00075556"},
        {"Smithsonian Astrophysical Observation", "SAO 42581"},
        {"Wilson Evans Batten Catalogue", "WEB 8394"},
    },
    visualMagnitude: 5.98,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.04187782),
        dec: Angle.Degrees(+42.00288543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31834",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5280 AB"},
        {"Henry Draper", "HD 47193"},
        {"Hipparcos Number", "HIP 31834"},
        {"Smithsonian Astrophysical Observation", "SAO 41240"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.83445777),
        dec: Angle.Degrees(+42.00460582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125547"},
        {"Hipparcos Number", "HIP 69959"},
        {"Fundamental Katalog 5th Edition", "FK5 5265"},
        {"Geneva Identification System", "GEN# +1.00125547"},
        {"Smithsonian Astrophysical Observation", "SAO 44990"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.73809230),
        dec: Angle.Degrees(+42.00510861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70647"},
        {"Hipparcos Number", "HIP 41224"},
        {"Geneva Identification System", "GEN# +1.00070647"},
        {"Smithsonian Astrophysical Observation", "SAO 42342"},
        {"Wilson Evans Batten Catalogue", "WEB 7977"},
    },
    visualMagnitude: 6.02,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.17819420),
        dec: Angle.Degrees(+42.00521805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31895"},
        {"Hipparcos Number", "HIP 23359"},
        {"Geneva Identification System", "GEN# +1.00031895"},
        {"Smithsonian Astrophysical Observation", "SAO 39947"},
        {"Wilson Evans Batten Catalogue", "WEB 4534"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.34343892),
        dec: Angle.Degrees(+42.00606542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23267"},
        {"Hipparcos Number", "HIP 17549"},
        {"Smithsonian Astrophysical Observation", "SAO 39082"},
    },
    visualMagnitude: 6.89,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.37934905),
        dec: Angle.Degrees(+42.00699700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216240"},
        {"Hipparcos Number", "HIP 112810"},
        {"Geneva Identification System", "GEN# +1.00216240"},
        {"Smithsonian Astrophysical Observation", "SAO 52415"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.68731851),
        dec: Angle.Degrees(+42.00733412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13138"},
        {"Hipparcos Number", "HIP 10086"},
        {"Celescope Catalog", "CEL 213"},
        {"Geneva Identification System", "GEN# +1.00013138"},
        {"Smithsonian Astrophysical Observation", "SAO 37819"},
    },
    visualMagnitude: 7.74,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.41750877),
        dec: Angle.Degrees(+42.00836529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94669"},
        {"Hipparcos Number", "HIP 53465"},
        {"Geneva Identification System", "GEN# +1.00094669"},
        {"Smithsonian Astrophysical Observation", "SAO 43535"},
        {"Wilson Evans Batten Catalogue", "WEB 9702"},
    },
    visualMagnitude: 6.03,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.06044690),
        dec: Angle.Degrees(+42.00839210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189957"},
        {"Hipparcos Number", "HIP 98530"},
        {"Celescope Catalog", "CEL 4912"},
        {"Geneva Identification System", "GEN# +1.00189957"},
        {"Smithsonian Astrophysical Observation", "SAO 49080"},
        {"Wilson Evans Batten Catalogue", "WEB 17406"},
    },
    visualMagnitude: 7.80,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.25003037),
        dec: Angle.Degrees(+42.00857088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87034"},
        {"Hipparcos Number", "HIP 49268"},
        {"Geneva Identification System", "GEN# +1.00087034"},
        {"Smithsonian Astrophysical Observation", "SAO 43162"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.85226743),
        dec: Angle.Degrees(+42.00928335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195229"},
        {"Hipparcos Number", "HIP 100987"},
        {"Celescope Catalog", "CEL 5074"},
        {"Geneva Identification System", "GEN# +1.00195229"},
        {"Smithsonian Astrophysical Observation", "SAO 49670"},
        {"Wilson Evans Batten Catalogue", "WEB 18242"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.12597503),
        dec: Angle.Degrees(+42.00981541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212977"},
        {"Hipparcos Number", "HIP 110851"},
        {"Fundamental Katalog 5th Edition", "FK5 5981"},
        {"Geneva Identification System", "GEN# +1.00212977"},
        {"Smithsonian Astrophysical Observation", "SAO 52020"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.87605981),
        dec: Angle.Degrees(+42.01358770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103683"},
        {"Hipparcos Number", "HIP 58217"},
        {"Geneva Identification System", "GEN# +1.00103683"},
        {"Smithsonian Astrophysical Observation", "SAO 43951"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.09525870),
        dec: Angle.Degrees(+42.01380905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64897",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64897"},
        {"Geneva Identification System", "GEN# +0.04202386"},
        {"Smithsonian Astrophysical Observation", "SAO 44554"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.52956276),
        dec: Angle.Degrees(+42.01475427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207351"},
        {"Hipparcos Number", "HIP 107572"},
        {"Smithsonian Astrophysical Observation", "SAO 51297"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.80336964),
        dec: Angle.Degrees(+42.01778379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216645"},
        {"Hipparcos Number", "HIP 113073"},
        {"Smithsonian Astrophysical Observation", "SAO 52468"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.50493450),
        dec: Angle.Degrees(+42.02042775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17756"},
        {"Hipparcos Number", "HIP 13393"},
        {"Smithsonian Astrophysical Observation", "SAO 38406"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.09366134),
        dec: Angle.Degrees(+42.02097538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179395"},
        {"Hipparcos Number", "HIP 94192"},
        {"Celescope Catalog", "CEL 4713"},
        {"Geneva Identification System", "GEN# +1.00179395"},
        {"Smithsonian Astrophysical Observation", "SAO 48156"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.64149207),
        dec: Angle.Degrees(+42.02218618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96642",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96642"},
        {"Smithsonian Astrophysical Observation", "SAO 48679"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.72931530),
        dec: Angle.Degrees(+42.02321772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225125"},
        {"Hipparcos Number", "HIP 300"},
        {"Smithsonian Astrophysical Observation", "SAO 36027"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.93490863),
        dec: Angle.Degrees(+42.02349764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206196"},
        {"Hipparcos Number", "HIP 106927"},
        {"Geneva Identification System", "GEN# +1.00206196"},
        {"Smithsonian Astrophysical Observation", "SAO 51149"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.82642281),
        dec: Angle.Degrees(+42.02435582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101366"},
        {"Hipparcos Number", "HIP 56915"},
        {"Geneva Identification System", "GEN# +1.00101366"},
        {"Smithsonian Astrophysical Observation", "SAO 43854"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.02037143),
        dec: Angle.Degrees(+42.02570960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107029"},
        {"Hipparcos Number", "HIP 59997"},
        {"Geneva Identification System", "GEN# +1.00107029"},
        {"Smithsonian Astrophysical Observation", "SAO 44113"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.57616723),
        dec: Angle.Degrees(+42.02592708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202568"},
        {"Hipparcos Number", "HIP 104941"},
        {"Fundamental Katalog 5th Edition", "FK5 5875"},
        {"Geneva Identification System", "GEN# +1.00202568"},
        {"Smithsonian Astrophysical Observation", "SAO 50623"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.86329509),
        dec: Angle.Degrees(+42.02606531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 130.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144681"},
        {"Hipparcos Number", "HIP 78816"},
        {"Smithsonian Astrophysical Observation", "SAO 45884"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.34618020),
        dec: Angle.Degrees(+42.02672471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33050",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33050"},
        {"Smithsonian Astrophysical Observation", "SAO 41407"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.27394158),
        dec: Angle.Degrees(+42.02895090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212669"},
        {"Hipparcos Number", "HIP 110670"},
        {"Smithsonian Astrophysical Observation", "SAO 51976"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.30071514),
        dec: Angle.Degrees(+42.03179861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42976"},
        {"Hipparcos Number", "HIP 29743"},
        {"Smithsonian Astrophysical Observation", "SAO 40980"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.96576123),
        dec: Angle.Degrees(+42.03511034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195089"},
        {"Hipparcos Number", "HIP 100912"},
        {"Celescope Catalog", "CEL 5070"},
        {"Geneva Identification System", "GEN# +1.00195089"},
        {"Smithsonian Astrophysical Observation", "SAO 49653"},
        {"Wilson Evans Batten Catalogue", "WEB 18230"},
    },
    visualMagnitude: 7.31,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.90322776),
        dec: Angle.Degrees(+42.03543295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109728",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109728"},
        {"Smithsonian Astrophysical Observation", "SAO 51778"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.40895190),
        dec: Angle.Degrees(+42.03589573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54367",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54367"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.84772560),
        dec: Angle.Degrees(+42.03632623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100884"},
        {"Hipparcos Number", "HIP 56652"},
        {"Smithsonian Astrophysical Observation", "SAO 43825"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.24752236),
        dec: Angle.Degrees(+42.03656975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48748"},
        {"Hipparcos Number", "HIP 32493"},
        {"Renson", "Renson 13010"},
        {"Smithsonian Astrophysical Observation", "SAO 41338"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.71585081),
        dec: Angle.Degrees(+42.03827069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7420",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7420"},
        {"Geneva Identification System", "GEN# +6.20030378"},
        {"Geneva Identification System 2", "GEN# +6.10212241"},
    },
    visualMagnitude: 10.97,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.90649977),
        dec: Angle.Degrees(+42.03933665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -197.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33304",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33304"},
        {"Smithsonian Astrophysical Observation", "SAO 41437"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.90766212),
        dec: Angle.Degrees(+42.04355079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32432",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5415 AB"},
        {"Henry Draper", "HD 48588"},
        {"Hipparcos Number", "HIP 32432"},
        {"Smithsonian Astrophysical Observation", "SAO 41326"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.54403675),
        dec: Angle.Degrees(+42.04562288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55256"},
        {"Hipparcos Number", "HIP 34972"},
        {"Smithsonian Astrophysical Observation", "SAO 41632"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.54211191),
        dec: Angle.Degrees(+42.04722981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120348"},
        {"Hipparcos Number", "HIP 67338"},
        {"Fundamental Katalog 5th Edition", "FK5 3095"},
        {"Geneva Identification System", "GEN# +1.00120348"},
        {"Smithsonian Astrophysical Observation", "SAO 44754"},
        {"Wilson Evans Batten Catalogue", "WEB 11847"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.02121484),
        dec: Angle.Degrees(+42.04760661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216121"},
        {"Hipparcos Number", "HIP 112719"},
        {"Smithsonian Astrophysical Observation", "SAO 52399"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.40998026),
        dec: Angle.Degrees(+42.04878317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122253"},
        {"Hipparcos Number", "HIP 68369"},
        {"Fundamental Katalog 5th Edition", "FK5 5239"},
        {"Smithsonian Astrophysical Observation", "SAO 44833"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.92298550),
        dec: Angle.Degrees(+42.04973687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143290"},
        {"Hipparcos Number", "HIP 78192"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.48964644),
        dec: Angle.Degrees(+42.04978145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84123"},
        {"Hipparcos Number", "HIP 47752"},
        {"Geneva Identification System", "GEN# +1.00084123"},
        {"Smithsonian Astrophysical Observation", "SAO 43003"},
        {"Wilson Evans Batten Catalogue", "WEB 8944"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.02871705),
        dec: Angle.Degrees(+42.05107731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140432"},
        {"Hipparcos Number", "HIP 76882"},
        {"Geneva Identification System", "GEN# +1.00140432"},
        {"Smithsonian Astrophysical Observation", "SAO 45685"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.49289196),
        dec: Angle.Degrees(+42.05131305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133252"},
        {"Hipparcos Number", "HIP 73567"},
        {"Smithsonian Astrophysical Observation", "SAO 45342"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.52685131),
        dec: Angle.Degrees(+42.05236874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111525"},
        {"Hipparcos Number", "HIP 62594"},
        {"Geneva Identification System", "GEN# +1.00111525"},
        {"Smithsonian Astrophysical Observation", "SAO 44342"},
        {"Wilson Evans Batten Catalogue", "WEB 11108"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.38831779),
        dec: Angle.Degrees(+42.05277249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62719"},
        {"Hipparcos Number", "HIP 37999"},
        {"Smithsonian Astrophysical Observation", "SAO 41999"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.81502317),
        dec: Angle.Degrees(+42.05357788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1919"},
        {"Hipparcos Number", "HIP 1867"},
        {"Geneva Identification System", "GEN# +1.00001919"},
        {"Smithsonian Astrophysical Observation", "SAO 36320"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.90892322),
        dec: Angle.Degrees(+42.05607017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212424"},
        {"Hipparcos Number", "HIP 110521"},
        {"Smithsonian Astrophysical Observation", "SAO 51950"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.85787121),
        dec: Angle.Degrees(+42.05897945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175884"},
        {"Hipparcos Number", "HIP 92891"},
        {"Geneva Identification System", "GEN# +1.00175884"},
        {"Smithsonian Astrophysical Observation", "SAO 47922"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.89876630),
        dec: Angle.Degrees(+42.06017650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1741",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1741"},
        {"Smithsonian Astrophysical Observation", "SAO 36301"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.50865237),
        dec: Angle.Degrees(+42.06054068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219109"},
        {"Hipparcos Number", "HIP 114604"},
        {"Geneva Identification System", "GEN# +1.00219109"},
        {"Smithsonian Astrophysical Observation", "SAO 52798"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.25642403),
        dec: Angle.Degrees(+42.06223643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12191",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Buna"},
        {"Henry Draper", "HD 16175"},
        {"Hipparcos Number", "HIP 12191"},
        {"Geneva Identification System", "GEN# +1.00016175"},
        {"Smithsonian Astrophysical Observation", "SAO 38170"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.25808932),
        dec: Angle.Degrees(+42.06273007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102619",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14306 AB"},
        {"Henry Draper", "HD 198253"},
        {"Hipparcos Number", "HIP 102619"},
        {"Geneva Identification System", "GEN# +1.00198253J"},
        {"Smithsonian Astrophysical Observation", "SAO 50066"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.91992410),
        dec: Angle.Degrees(+42.06856245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221363"},
        {"Hipparcos Number", "HIP 116081"},
        {"Smithsonian Astrophysical Observation", "SAO 53111"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.83135815),
        dec: Angle.Degrees(+42.06882025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105319"},
        {"Hipparcos Number", "HIP 59136"},
        {"Geneva Identification System", "GEN# +1.00105319"},
        {"Smithsonian Astrophysical Observation", "SAO 44040"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.89755448),
        dec: Angle.Degrees(+42.07088141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6438",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6438"},
        {"Smithsonian Astrophysical Observation", "SAO 37159"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.67426002),
        dec: Angle.Degrees(+42.07123933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196819"},
        {"Hipparcos Number", "HIP 101841"},
        {"Geneva Identification System", "GEN# +1.00196819"},
        {"Smithsonian Astrophysical Observation", "SAO 49884"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.57154297),
        dec: Angle.Degrees(+42.07368346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27251",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27251"},
        {"Smithsonian Astrophysical Observation", "SAO 40598"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.63326493),
        dec: Angle.Degrees(+42.07385525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9121",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9121"},
        {"Geneva Identification System", "GEN# +0.04100379"},
        {"Smithsonian Astrophysical Observation", "SAO 37640"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.39436836),
        dec: Angle.Degrees(+42.07695156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 285.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111444"},
        {"Hipparcos Number", "HIP 62545"},
        {"Geneva Identification System", "GEN# +1.00111444"},
        {"Smithsonian Astrophysical Observation", "SAO 44334"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.23343371),
        dec: Angle.Degrees(+42.07724176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219981"},
        {"Hipparcos Number", "HIP 115191"},
        {"Fundamental Katalog 5th Edition", "FK5 3870"},
        {"Geneva Identification System", "GEN# +1.00219981"},
        {"Smithsonian Astrophysical Observation", "SAO 52914"},
        {"Wilson Evans Batten Catalogue", "WEB 20406"},
    },
    visualMagnitude: 5.81,
    bvColour: 1.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.96825485),
        dec: Angle.Degrees(+42.07803394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212222"},
        {"Hipparcos Number", "HIP 110408"},
        {"Geneva Identification System", "GEN# +1.00212222"},
        {"Smithsonian Astrophysical Observation", "SAO 51918"},
        {"Wilson Evans Batten Catalogue", "WEB 19801"},
    },
    visualMagnitude: 6.38,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.46191327),
        dec: Angle.Degrees(+42.07816870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152377"},
        {"Hipparcos Number", "HIP 82464"},
        {"Geneva Identification System", "GEN# +1.00152377"},
        {"Smithsonian Astrophysical Observation", "SAO 46324"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.78653621),
        dec: Angle.Degrees(+42.08019874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6920"},
        {"Hipparcos Number", "HIP 5493"},
        {"Fundamental Katalog 5th Edition", "FK5 2075"},
        {"Geneva Identification System", "GEN# +1.00006920"},
        {"Smithsonian Astrophysical Observation", "SAO 36984"},
        {"Wilson Evans Batten Catalogue", "WEB 1212"},
    },
    visualMagnitude: 5.67,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.57852966),
        dec: Angle.Degrees(+42.08157668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -135.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117646",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17050 AB"},
        {"Henry Draper", "HD 223672"},
        {"Hipparcos Number", "HIP 117646"},
        {"Smithsonian Astrophysical Observation", "SAO 53427"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.88763375),
        dec: Angle.Degrees(+42.08272032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47583",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47583"},
    },
    visualMagnitude: 10.87,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.53225683),
        dec: Angle.Degrees(+42.08469383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59923"},
        {"Hipparcos Number", "HIP 36804"},
        {"Geneva Identification System", "GEN# +1.00059923"},
        {"Smithsonian Astrophysical Observation", "SAO 41854"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.54063360),
        dec: Angle.Degrees(+42.08777699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117643",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17050 C"},
        {"Hipparcos Number", "HIP 117643"},
    },
    visualMagnitude: 9.24,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)51, 32.5200),
        dec: Angle.DegreesMinutesSeconds((int)+42, (int)05, 17.800)
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
    primaryId: "HIP 2681",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2681"},
        {"Smithsonian Astrophysical Observation", "SAO 36473"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.49423271),
        dec: Angle.Degrees(+42.08843420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99831"},
        {"Hipparcos Number", "HIP 56059"},
        {"Geneva Identification System", "GEN# +1.00099831"},
        {"Renson", "Renson 28730"},
        {"Smithsonian Astrophysical Observation", "SAO 43770"},
        {"Wilson Evans Batten Catalogue", "WEB 10065"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.34435258),
        dec: Angle.Degrees(+42.09180713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 365",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 30"},
        {"Henry Draper", "HD 225218"},
        {"Hipparcos Number", "HIP 365"},
        {"Smithsonian Astrophysical Observation", "SAO 36037"},
        {"Wilson Evans Batten Catalogue", "WEB 53"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.15248379),
        dec: Angle.Degrees(+42.09256148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50166",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50166"},
        {"Smithsonian Astrophysical Observation", "SAO 43244"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.60161612),
        dec: Angle.Degrees(+42.09388054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75198",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75198"},
        {"Smithsonian Astrophysical Observation", "SAO 45508"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.50174830),
        dec: Angle.Degrees(+42.09549051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32752"},
        {"Hipparcos Number", "HIP 23825"},
        {"Geneva Identification System", "GEN# +1.00032752"},
        {"Smithsonian Astrophysical Observation", "SAO 40034"},
        {"Wilson Evans Batten Catalogue", "WEB 4647"},
    },
    visualMagnitude: 8.33,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.82677728),
        dec: Angle.Degrees(+42.09559674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165503"},
        {"Hipparcos Number", "HIP 88498"},
        {"Geneva Identification System", "GEN# +1.00165503"},
        {"Smithsonian Astrophysical Observation", "SAO 47188"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.07044451),
        dec: Angle.Degrees(+42.09582742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108368",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108368"},
        {"Smithsonian Astrophysical Observation", "SAO 51479"},
    },
    visualMagnitude: 9.30,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.30629261),
        dec: Angle.Degrees(+42.09805038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123532"},
        {"Hipparcos Number", "HIP 68982"},
        {"Smithsonian Astrophysical Observation", "SAO 44896"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.83779635),
        dec: Angle.Degrees(+42.09856258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83841",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83841"},
        {"Smithsonian Astrophysical Observation", "SAO 46507"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.01369986),
        dec: Angle.Degrees(+42.10017510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109800",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109800"},
        {"Smithsonian Astrophysical Observation", "SAO 51788"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.59247171),
        dec: Angle.Degrees(+42.10058692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74214"},
        {"Hipparcos Number", "HIP 42876"},
        {"Geneva Identification System", "GEN# +1.00074214"},
        {"Smithsonian Astrophysical Observation", "SAO 42518"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.06440163),
        dec: Angle.Degrees(+42.10062648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62381"},
        {"Hipparcos Number", "HIP 37847"},
        {"Smithsonian Astrophysical Observation", "SAO 41981"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.38223470),
        dec: Angle.Degrees(+42.10070662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69895"},
        {"Hipparcos Number", "HIP 40898"},
        {"Smithsonian Astrophysical Observation", "SAO 42298"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.19376400),
        dec: Angle.Degrees(+42.10158897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14771"},
        {"Hipparcos Number", "HIP 11185"},
        {"Smithsonian Astrophysical Observation", "SAO 38002"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.01148065),
        dec: Angle.Degrees(+42.10230026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176229"},
        {"Hipparcos Number", "HIP 93064"},
        {"Geneva Identification System", "GEN# +1.00176229"},
        {"Smithsonian Astrophysical Observation", "SAO 47950"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.35591457),
        dec: Angle.Degrees(+42.10381163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99749",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13572 AB"},
        {"Henry Draper", "HD 192659"},
        {"Hipparcos Number", "HIP 99749"},
        {"Celescope Catalog", "CEL 4985"},
        {"Geneva Identification System", "GEN# +1.00192659"},
        {"Smithsonian Astrophysical Observation", "SAO 49345"},
        {"Wilson Evans Batten Catalogue", "WEB 17913"},
    },
    visualMagnitude: 6.67,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.58972815),
        dec: Angle.Degrees(+42.10434533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37368",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6250 A"},
        {"Henry Draper", "HD 61233"},
        {"Hipparcos Number", "HIP 37368"},
        {"Smithsonian Astrophysical Observation", "SAO 41920"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.05834074),
        dec: Angle.Degrees(+42.10444396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117710"},
        {"Hipparcos Number", "HIP 65951"},
        {"Geneva Identification System", "GEN# +1.00117710"},
        {"Smithsonian Astrophysical Observation", "SAO 44637"},
        {"Wilson Evans Batten Catalogue", "WEB 11664"},
    },
    visualMagnitude: 6.07,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.81600806),
        dec: Angle.Degrees(+42.10608614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156074"},
        {"Hipparcos Number", "HIP 84266"},
        {"Geneva Identification System", "GEN# +1.00156074"},
        {"Smithsonian Astrophysical Observation", "SAO 46574"},
        {"Wilson Evans Batten Catalogue", "WEB 14229"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.38018747),
        dec: Angle.Degrees(+42.10642400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169716"},
        {"Hipparcos Number", "HIP 90177"},
        {"Smithsonian Astrophysical Observation", "SAO 47464"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.02662958),
        dec: Angle.Degrees(+42.10732985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36404"},
        {"Hipparcos Number", "HIP 26057"},
        {"Celescope Catalog", "CEL 772"},
        {"Geneva Identification System", "GEN# +1.00036404"},
        {"Renson", "Renson 9400"},
        {"Smithsonian Astrophysical Observation", "SAO 40426"},
        {"Wilson Evans Batten Catalogue", "WEB 5066"},
    },
    visualMagnitude: 6.55,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.36966732),
        dec: Angle.Degrees(+42.10896549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11129"},
        {"Hipparcos Number", "HIP 8555"},
        {"Smithsonian Astrophysical Observation", "SAO 37553"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.59197681),
        dec: Angle.Degrees(+42.10942754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55889",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55889"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.82032614),
        dec: Angle.Degrees(+42.11045566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156925"},
        {"Hipparcos Number", "HIP 84648"},
        {"Geneva Identification System", "GEN# +1.00156925"},
        {"Smithsonian Astrophysical Observation", "SAO 46620"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.57758443),
        dec: Angle.Degrees(+42.11104271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148085"},
        {"Hipparcos Number", "HIP 80314"},
        {"Geneva Identification System", "GEN# +1.00148085"},
        {"Smithsonian Astrophysical Observation", "SAO 46063"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.94938461),
        dec: Angle.Degrees(+42.11127226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18338"},
        {"Hipparcos Number", "HIP 13840"},
        {"Smithsonian Astrophysical Observation", "SAO 38476"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.53756597),
        dec: Angle.Degrees(+42.11127579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30883"},
        {"Hipparcos Number", "HIP 22726"},
        {"Geneva Identification System", "GEN# +1.00030883"},
        {"Smithsonian Astrophysical Observation", "SAO 39831"},
        {"Wilson Evans Batten Catalogue", "WEB 4396"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.33136418),
        dec: Angle.Degrees(+42.11241974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17611",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17611"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.59343394),
        dec: Angle.Degrees(+42.11378524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26420"},
        {"Hipparcos Number", "HIP 19647"},
        {"Geneva Identification System", "GEN# +1.00026420"},
        {"Smithsonian Astrophysical Observation", "SAO 39384"},
        {"Wilson Evans Batten Catalogue", "WEB 3752"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.15193394),
        dec: Angle.Degrees(+42.11844230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29587"},
        {"Hipparcos Number", "HIP 21832"},
        {"Cincinnati Publication", "Ci 20 300"},
        {"Fundamental Katalog 5th Edition", "FK5 4419"},
        {"Geneva Identification System", "GEN# +1.00029587"},
        {"Smithsonian Astrophysical Observation", "SAO 39690"},
        {"Wilson Evans Batten Catalogue", "WEB 4199"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.39956712),
        dec: Angle.Degrees(+42.11948366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 536.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -416.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31178"},
        {"Hipparcos Number", "HIP 22901"},
        {"Geneva Identification System", "GEN# +1.00031178"},
        {"Smithsonian Astrophysical Observation", "SAO 39866"},
        {"Wilson Evans Batten Catalogue", "WEB 4442"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.88861311),
        dec: Angle.Degrees(+42.12254030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275241"},
        {"Hipparcos Number", "HIP 15934"},
        {"Geneva Identification System", "GEN# +1.00275241"},
        {"Smithsonian Astrophysical Observation", "SAO 38810"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.30382641),
        dec: Angle.Degrees(+42.12350302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 181.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42820"},
        {"Hipparcos Number", "HIP 29659"},
        {"Geneva Identification System", "GEN# +1.00042820"},
        {"Smithsonian Astrophysical Observation", "SAO 40970"},
        {"Wilson Evans Batten Catalogue", "WEB 5838"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.72802135),
        dec: Angle.Degrees(+42.12351386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192001"},
        {"Hipparcos Number", "HIP 99443"},
        {"Geneva Identification System", "GEN# +1.00192001"},
        {"Smithsonian Astrophysical Observation", "SAO 49284"},
        {"Wilson Evans Batten Catalogue", "WEB 17765"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.75712689),
        dec: Angle.Degrees(+42.12678999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6398",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6398"},
        {"Smithsonian Astrophysical Observation", "SAO 37153"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.54560633),
        dec: Angle.Degrees(+42.12884666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139442"},
        {"Hipparcos Number", "HIP 76428"},
        {"Smithsonian Astrophysical Observation", "SAO 45637"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.14104121),
        dec: Angle.Degrees(+42.13019594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107596"},
        {"Hipparcos Number", "HIP 60303"},
        {"Cincinnati Publication", "Ci 20 697"},
        {"Cincinnati Publication 2", "Ci 18 1551"},
        {"Geneva Identification System", "GEN# +1.00107596"},
        {"Wilson Evans Batten Catalogue", "WEB 10723"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.47473564),
        dec: Angle.Degrees(+42.13514194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 175.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -516.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72132"},
        {"Hipparcos Number", "HIP 41914"},
        {"Geneva Identification System", "GEN# +1.00072132"},
        {"Smithsonian Astrophysical Observation", "SAO 42419"},
        {"Wilson Evans Batten Catalogue", "WEB 8064"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.18212668),
        dec: Angle.Degrees(+42.14002978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18550"},
        {"Hipparcos Number", "HIP 14005"},
        {"Geneva Identification System", "GEN# +1.00018550"},
        {"Smithsonian Astrophysical Observation", "SAO 38500"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.07593486),
        dec: Angle.Degrees(+42.14042809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27026"},
        {"Hipparcos Number", "HIP 20063"},
        {"Celescope Catalog", "CEL 380"},
        {"Geneva Identification System", "GEN# +1.00027026"},
        {"Smithsonian Astrophysical Observation", "SAO 39447"},
        {"Wilson Evans Batten Catalogue", "WEB 3829"},
    },
    visualMagnitude: 6.22,
    bvColour: -0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.53371946),
        dec: Angle.Degrees(+42.14124624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224757"},
        {"Hipparcos Number", "HIP 30"},
        {"Smithsonian Astrophysical Observation", "SAO 53562"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.09613563),
        dec: Angle.Degrees(+42.14149882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186222"},
        {"Hipparcos Number", "HIP 96857"},
        {"Celescope Catalog", "CEL 4816"},
        {"Geneva Identification System", "GEN# +1.00186222"},
        {"Smithsonian Astrophysical Observation", "SAO 48725"},
    },
    visualMagnitude: 8.03,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.31243268),
        dec: Angle.Degrees(+42.14165797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211783"},
        {"Hipparcos Number", "HIP 110155"},
        {"Smithsonian Astrophysical Observation", "SAO 51865"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.69103763),
        dec: Angle.Degrees(+42.14262488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42893"},
        {"Hipparcos Number", "HIP 29690"},
        {"Smithsonian Astrophysical Observation", "SAO 40973"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.82340934),
        dec: Angle.Degrees(+42.14284977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17972"},
        {"Hipparcos Number", "HIP 13560"},
        {"Smithsonian Astrophysical Observation", "SAO 38432"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.66855558),
        dec: Angle.Degrees(+42.14396760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65359",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65359"},
    },
    visualMagnitude: 10.35,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.92946940),
        dec: Angle.Degrees(+42.14651164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51336",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51336"},
    },
    visualMagnitude: 11.01,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.28228544),
        dec: Angle.Degrees(+42.14734749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 197",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 197"},
        {"Smithsonian Astrophysical Observation", "SAO 53593"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.63232895),
        dec: Angle.Degrees(+42.14779896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114217"},
        {"Hipparcos Number", "HIP 64123"},
        {"Geneva Identification System", "GEN# +1.00114217"},
        {"Smithsonian Astrophysical Observation", "SAO 44484"},
        {"Wilson Evans Batten Catalogue", "WEB 11334"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.13635352),
        dec: Angle.Degrees(+42.14790142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42213"},
        {"Hipparcos Number", "HIP 29382"},
        {"Smithsonian Astrophysical Observation", "SAO 40930"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.88935140),
        dec: Angle.Degrees(+42.15188271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52253",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7878 AB"},
        {"Henry Draper", "HD 92370"},
        {"Hipparcos Number", "HIP 52253"},
        {"Smithsonian Astrophysical Observation", "SAO 43428"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.14599394),
        dec: Angle.Degrees(+42.15320190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106348"},
        {"Hipparcos Number", "HIP 59651"},
        {"Geneva Identification System", "GEN# +1.00106348"},
        {"Smithsonian Astrophysical Observation", "SAO 44085"},
        {"Wilson Evans Batten Catalogue", "WEB 10599"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.50423710),
        dec: Angle.Degrees(+42.15506886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120817"},
        {"Hipparcos Number", "HIP 67581"},
        {"Geneva Identification System", "GEN# +1.00120817"},
        {"Smithsonian Astrophysical Observation", "SAO 44774"},
        {"Wilson Evans Batten Catalogue", "WEB 11883"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.71565053),
        dec: Angle.Degrees(+42.15515849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48695",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48695"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.95531025),
        dec: Angle.Degrees(+42.15544632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4851",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4851"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.60946845),
        dec: Angle.Degrees(+42.15587900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167965"},
        {"Hipparcos Number", "HIP 89482"},
        {"Fundamental Katalog 5th Edition", "FK5 684"},
        {"Geneva Identification System", "GEN# +1.00167965"},
        {"Smithsonian Astrophysical Observation", "SAO 47342"},
        {"Wilson Evans Batten Catalogue", "WEB 15228"},
    },
    visualMagnitude: 5.56,
    bvColour: -0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.91158071),
        dec: Angle.Degrees(+42.15934312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149223"},
        {"Hipparcos Number", "HIP 80929"},
        {"Smithsonian Astrophysical Observation", "SAO 46144"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.88023264),
        dec: Angle.Degrees(+42.16264890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13024"},
        {"Hipparcos Number", "HIP 9991"},
        {"Geneva Identification System", "GEN# +1.00013024"},
        {"Smithsonian Astrophysical Observation", "SAO 37797"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.16999436),
        dec: Angle.Degrees(+42.16320065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33357"},
        {"Hipparcos Number", "HIP 24201"},
        {"Geneva Identification System", "GEN# +1.00033357"},
        {"Smithsonian Astrophysical Observation", "SAO 40094"},
        {"Wilson Evans Batten Catalogue", "WEB 4698"},
    },
    visualMagnitude: 8.56,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.92886671),
        dec: Angle.Degrees(+42.16535830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134826"},
        {"Hipparcos Number", "HIP 74251"},
        {"Smithsonian Astrophysical Observation", "SAO 45411"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.62617153),
        dec: Angle.Degrees(+42.16591281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207112"},
        {"Hipparcos Number", "HIP 107437"},
        {"Smithsonian Astrophysical Observation", "SAO 51265"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.40847278),
        dec: Angle.Degrees(+42.16594993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58093"},
        {"Hipparcos Number", "HIP 36075"},
        {"Geneva Identification System", "GEN# +1.00058093"},
        {"Smithsonian Astrophysical Observation", "SAO 41763"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.49944365),
        dec: Angle.Degrees(+42.16654684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124170"},
        {"Hipparcos Number", "HIP 69274"},
        {"Geneva Identification System", "GEN# +1.00124170"},
        {"Smithsonian Astrophysical Observation", "SAO 44926"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.71852805),
        dec: Angle.Degrees(+42.16670838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105763",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105763"},
        {"Smithsonian Astrophysical Observation", "SAO 50821"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.31291800),
        dec: Angle.Degrees(+42.16819020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 226978"},
        {"Hipparcos Number", "HIP 98381"},
    },
    visualMagnitude: 9.91,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.83052162),
        dec: Angle.Degrees(+42.16844720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 175.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 160.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175536"},
        {"Hipparcos Number", "HIP 92736"},
        {"Smithsonian Astrophysical Observation", "SAO 47899"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.46096345),
        dec: Angle.Degrees(+42.17106512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135530"},
        {"Hipparcos Number", "HIP 74571"},
        {"Geneva Identification System", "GEN# +1.00135530"},
        {"Smithsonian Astrophysical Observation", "SAO 45445"},
        {"Wilson Evans Batten Catalogue", "WEB 12727"},
    },
    visualMagnitude: 6.12,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.54288301),
        dec: Angle.Degrees(+42.17144853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101832",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101832"},
        {"Smithsonian Astrophysical Observation", "SAO 49881"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.54551270),
        dec: Angle.Degrees(+42.17387575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26199"},
        {"Hipparcos Number", "HIP 19487"},
        {"Geneva Identification System", "GEN# +1.00026199"},
        {"Smithsonian Astrophysical Observation", "SAO 39349"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.60441407),
        dec: Angle.Degrees(+42.17399086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17219"},
        {"Hipparcos Number", "HIP 13000"},
        {"Smithsonian Astrophysical Observation", "SAO 38329"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.78545702),
        dec: Angle.Degrees(+42.17545041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16738"},
        {"Hipparcos Number", "HIP 12617"},
        {"Geneva Identification System", "GEN# +1.00016738"},
        {"Smithsonian Astrophysical Observation", "SAO 38253"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.54761468),
        dec: Angle.Degrees(+42.17569905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275149"},
        {"Hipparcos Number", "HIP 15496"},
        {"Smithsonian Astrophysical Observation", "SAO 38726"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.92136672),
        dec: Angle.Degrees(+42.17609746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40651"},
        {"Hipparcos Number", "HIP 28602"},
        {"Smithsonian Astrophysical Observation", "SAO 40797"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.55246284),
        dec: Angle.Degrees(+42.17643283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34667",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34667"},
        {"Smithsonian Astrophysical Observation", "SAO 41602"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.69319297),
        dec: Angle.Degrees(+42.17675359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2422"},
        {"Hipparcos Number", "HIP 2229"},
        {"Geneva Identification System", "GEN# +1.00002422"},
        {"Smithsonian Astrophysical Observation", "SAO 36392"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.06071918),
        dec: Angle.Degrees(+42.17702095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178090"},
        {"Hipparcos Number", "HIP 93749"},
        {"Smithsonian Astrophysical Observation", "SAO 48069"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.35582969),
        dec: Angle.Degrees(+42.17767650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194669"},
        {"Hipparcos Number", "HIP 100724"},
        {"Geneva Identification System", "GEN# +1.00194669"},
        {"Smithsonian Astrophysical Observation", "SAO 49596"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.31330771),
        dec: Angle.Degrees(+42.17950931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44855",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7192 AB"},
        {"Henry Draper", "HD 78211"},
        {"Hipparcos Number", "HIP 44855"},
        {"Smithsonian Astrophysical Observation", "SAO 42709"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.08467114),
        dec: Angle.Degrees(+42.17976268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47101",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47101"},
    },
    visualMagnitude: 10.73,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.99564663),
        dec: Angle.Degrees(+42.18084105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18935",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2950 AB"},
        {"Henry Draper", "HD 25367"},
        {"Hipparcos Number", "HIP 18935"},
        {"Smithsonian Astrophysical Observation", "SAO 39278"},
    },
    visualMagnitude: 7.90,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.88034804),
        dec: Angle.Degrees(+42.18204863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26333",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26333"},
        {"Smithsonian Astrophysical Observation", "SAO 40474"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.12648095),
        dec: Angle.Degrees(+42.18460006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67800",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9044 A"},
        {"Henry Draper", "HD 121247"},
        {"Hipparcos Number", "HIP 67800"},
        {"Geneva Identification System", "GEN# +1.00121247J"},
        {"Smithsonian Astrophysical Observation", "SAO 44787"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.33674052),
        dec: Angle.Degrees(+42.18480019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50679",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50679"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.23565152),
        dec: Angle.Degrees(+42.18803581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220844"},
        {"Hipparcos Number", "HIP 115732"},
        {"Smithsonian Astrophysical Observation", "SAO 53032"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.70089769),
        dec: Angle.Degrees(+42.19164013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75536",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75536"},
        {"Smithsonian Astrophysical Observation", "SAO 45536"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.47320884),
        dec: Angle.Degrees(+42.19307498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223330"},
        {"Hipparcos Number", "HIP 117421"},
        {"Smithsonian Astrophysical Observation", "SAO 53392"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.13981160),
        dec: Angle.Degrees(+42.19352529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190675"},
        {"Hipparcos Number", "HIP 98850"},
        {"Celescope Catalog", "CEL 4925"},
        {"Geneva Identification System", "GEN# +1.00190675"},
        {"Smithsonian Astrophysical Observation", "SAO 49146"},
    },
    visualMagnitude: 8.33,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.10746743),
        dec: Angle.Degrees(+42.19840452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118669"},
        {"Hipparcos Number", "HIP 66470"},
        {"Geneva Identification System", "GEN# +1.00118669"},
        {"Smithsonian Astrophysical Observation", "SAO 44687"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.41126925),
        dec: Angle.Degrees(+42.20091952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214767"},
        {"Hipparcos Number", "HIP 111875"},
        {"Geneva Identification System", "GEN# +1.00214767"},
        {"Smithsonian Astrophysical Observation", "SAO 52239"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.91483403),
        dec: Angle.Degrees(+42.20102698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80743"},
        {"Hipparcos Number", "HIP 45994"},
        {"Geneva Identification System", "GEN# +1.00080743"},
        {"Smithsonian Astrophysical Observation", "SAO 42831"},
        {"Wilson Evans Batten Catalogue", "WEB 8719"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.70506914),
        dec: Angle.Degrees(+42.20235412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21589"},
        {"Hipparcos Number", "HIP 16357"},
        {"Geneva Identification System", "GEN# +1.00021589"},
        {"Smithsonian Astrophysical Observation", "SAO 38898"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.68759500),
        dec: Angle.Degrees(+42.20248367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195746"},
        {"Hipparcos Number", "HIP 101265"},
        {"Celescope Catalog", "CEL 5095"},
        {"Geneva Identification System", "GEN# +1.00195746"},
        {"Smithsonian Astrophysical Observation", "SAO 49742"},
    },
    visualMagnitude: 8.56,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.88983357),
        dec: Angle.Degrees(+42.20390581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220871"},
        {"Hipparcos Number", "HIP 115747"},
        {"Geneva Identification System", "GEN# +1.00220871"},
        {"Smithsonian Astrophysical Observation", "SAO 53035"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.75024795),
        dec: Angle.Degrees(+42.20519084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125262"},
        {"Hipparcos Number", "HIP 69809"},
        {"Smithsonian Astrophysical Observation", "SAO 44971"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.30029554),
        dec: Angle.Degrees(+42.20817953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26234"},
        {"Hipparcos Number", "HIP 19517"},
        {"Smithsonian Astrophysical Observation", "SAO 39354"},
        {"Wilson Evans Batten Catalogue", "WEB 3739"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.71633997),
        dec: Angle.Degrees(+42.20965130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204919"},
        {"Hipparcos Number", "HIP 106191"},
        {"Smithsonian Astrophysical Observation", "SAO 50950"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.64585143),
        dec: Angle.Degrees(+42.21124294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119349"},
        {"Hipparcos Number", "HIP 66848"},
        {"Geneva Identification System", "GEN# +1.00119349"},
        {"Smithsonian Astrophysical Observation", "SAO 44718"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.50356046),
        dec: Angle.Degrees(+42.21127940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63506",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63506"},
    },
    visualMagnitude: 11.36,
    bvColour: 1.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.19111035),
        dec: Angle.Degrees(+42.21221445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -397.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163204"},
        {"Hipparcos Number", "HIP 87531"},
        {"Smithsonian Astrophysical Observation", "SAO 47034"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.23654757),
        dec: Angle.Degrees(+42.21247257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54979",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54979"},
        {"Smithsonian Astrophysical Observation", "SAO 43660"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.86816239),
        dec: Angle.Degrees(+42.21280733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35897"},
        {"Hipparcos Number", "HIP 25750"},
        {"Smithsonian Astrophysical Observation", "SAO 40372"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.47763508),
        dec: Angle.Degrees(+42.21595528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189821"},
        {"Hipparcos Number", "HIP 98459"},
        {"Smithsonian Astrophysical Observation", "SAO 49069"},
        {"Wilson Evans Batten Catalogue", "WEB 17387"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.06444178),
        dec: Angle.Degrees(+42.21787928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142374"},
        {"Hipparcos Number", "HIP 77759"},
        {"Geneva Identification System", "GEN# +1.00142374"},
        {"Smithsonian Astrophysical Observation", "SAO 45771"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.16113733),
        dec: Angle.Degrees(+42.21796124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48330",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48330"},
    },
    visualMagnitude: 10.98,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.77405211),
        dec: Angle.Degrees(+42.21802364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111603"},
        {"Hipparcos Number", "HIP 62634"},
        {"Geneva Identification System", "GEN# +1.00111603"},
        {"Smithsonian Astrophysical Observation", "SAO 44346"},
        {"Wilson Evans Batten Catalogue", "WEB 11114"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.52108295),
        dec: Angle.Degrees(+42.21803864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158415"},
        {"Hipparcos Number", "HIP 85414"},
        {"Geneva Identification System", "GEN# +1.00158415"},
        {"Smithsonian Astrophysical Observation", "SAO 46727"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.80783500),
        dec: Angle.Degrees(+42.21806690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126719"},
        {"Hipparcos Number", "HIP 70564"},
        {"Smithsonian Astrophysical Observation", "SAO 45051"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.50978555),
        dec: Angle.Degrees(+42.21807490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27899"},
        {"Hipparcos Number", "HIP 20701"},
        {"Smithsonian Astrophysical Observation", "SAO 39529"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.51991507),
        dec: Angle.Degrees(+42.21947086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197700"},
        {"Hipparcos Number", "HIP 102321"},
        {"Geneva Identification System", "GEN# +1.00197700"},
        {"Smithsonian Astrophysical Observation", "SAO 50001"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.97321911),
        dec: Angle.Degrees(+42.22023128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113830",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113830"},
        {"Smithsonian Astrophysical Observation", "SAO 52632"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.77815057),
        dec: Angle.Degrees(+42.22028282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213544"},
        {"Hipparcos Number", "HIP 111189"},
        {"Geneva Identification System", "GEN# +1.00213544"},
        {"Smithsonian Astrophysical Observation", "SAO 52105"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.88181818),
        dec: Angle.Degrees(+42.22172997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 349"},
        {"Hipparcos Number", "HIP 668"},
        {"Smithsonian Astrophysical Observation", "SAO 36088"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.06109217),
        dec: Angle.Degrees(+42.22343513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88832",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88832"},
        {"Smithsonian Astrophysical Observation", "SAO 47244"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.99582225),
        dec: Angle.Degrees(+42.22378542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90142"},
        {"Hipparcos Number", "HIP 51003"},
        {"Smithsonian Astrophysical Observation", "SAO 43329"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.28846398),
        dec: Angle.Degrees(+42.22491696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220624"},
        {"Hipparcos Number", "HIP 115601"},
        {"Geneva Identification System", "GEN# +1.00220624"},
        {"Smithsonian Astrophysical Observation", "SAO 52991"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.26080138),
        dec: Angle.Degrees(+42.22536773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25057"},
        {"Hipparcos Number", "HIP 18716"},
        {"Smithsonian Astrophysical Observation", "SAO 39244"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.14500350),
        dec: Angle.Degrees(+42.22556686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7105"},
        {"Hipparcos Number", "HIP 5606"},
        {"Geneva Identification System", "GEN# +1.00007105"},
        {"Smithsonian Astrophysical Observation", "SAO 37010"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.97556240),
        dec: Angle.Degrees(+42.22648010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183383"},
        {"Hipparcos Number", "HIP 95653"},
        {"Smithsonian Astrophysical Observation", "SAO 48463"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.85172092),
        dec: Angle.Degrees(+42.22935852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191636"},
        {"Hipparcos Number", "HIP 99280"},
        {"Smithsonian Astrophysical Observation", "SAO 49245"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.30074075),
        dec: Angle.Degrees(+42.23028464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52630"},
        {"Hipparcos Number", "HIP 34063"},
        {"Geneva Identification System", "GEN# +1.00052630"},
        {"Smithsonian Astrophysical Observation", "SAO 41534"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.98560794),
        dec: Angle.Degrees(+42.23331377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151897"},
        {"Hipparcos Number", "HIP 82252"},
        {"Smithsonian Astrophysical Observation", "SAO 46295"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.09278281),
        dec: Angle.Degrees(+42.23378894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223000"},
        {"Hipparcos Number", "HIP 117190"},
        {"Smithsonian Astrophysical Observation", "SAO 53351"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.41312649),
        dec: Angle.Degrees(+42.23484627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194007"},
        {"Hipparcos Number", "HIP 100408"},
        {"Smithsonian Astrophysical Observation", "SAO 49518"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.41650390),
        dec: Angle.Degrees(+42.23489080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51687"},
        {"Hipparcos Number", "HIP 33726"},
        {"Smithsonian Astrophysical Observation", "SAO 41488"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.09664069),
        dec: Angle.Degrees(+42.23649613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117378"},
        {"Hipparcos Number", "HIP 65775"},
        {"Geneva Identification System", "GEN# +1.00117378"},
        {"Smithsonian Astrophysical Observation", "SAO 44624"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.26411251),
        dec: Angle.Degrees(+42.23830625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143254"},
        {"Hipparcos Number", "HIP 78176"},
        {"Smithsonian Astrophysical Observation", "SAO 45805"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.43803203),
        dec: Angle.Degrees(+42.23834994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151732"},
        {"Hipparcos Number", "HIP 82172"},
        {"Fundamental Katalog 5th Edition", "FK5 3336"},
        {"Geneva Identification System", "GEN# +1.00151732"},
        {"Smithsonian Astrophysical Observation", "SAO 46288"},
        {"Wilson Evans Batten Catalogue", "WEB 13878"},
    },
    visualMagnitude: 5.86,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.83227018),
        dec: Angle.Degrees(+42.23897955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29297"},
        {"Hipparcos Number", "HIP 21642"},
        {"Smithsonian Astrophysical Observation", "SAO 39666"},
        {"Wilson Evans Batten Catalogue", "WEB 4158"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.72220826),
        dec: Angle.Degrees(+42.24003966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49486",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49486"},
        {"Smithsonian Astrophysical Observation", "SAO 43185"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.54895425),
        dec: Angle.Degrees(+42.24160293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111039",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111039"},
        {"Smithsonian Astrophysical Observation", "SAO 52060"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.42794928),
        dec: Angle.Degrees(+42.24193879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 276758"},
        {"Hipparcos Number", "HIP 22051"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.13865954),
        dec: Angle.Degrees(+42.24289604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78640",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78640"},
        {"Geneva Identification System", "GEN# +0.04202667"},
        {"Wilson Evans Batten Catalogue", "WEB 13292"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.80605410),
        dec: Angle.Degrees(+42.24718050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -195.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -366.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197037"},
        {"Hipparcos Number", "HIP 101948"},
        {"Geneva Identification System", "GEN# +1.00197037"},
        {"Smithsonian Astrophysical Observation", "SAO 49900"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.88753903),
        dec: Angle.Degrees(+42.24908836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -221.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5285"},
        {"Hipparcos Number", "HIP 4307"},
        {"Smithsonian Astrophysical Observation", "SAO 36765"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.79261761),
        dec: Angle.Degrees(+42.25052433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93961"},
        {"Hipparcos Number", "HIP 53068"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.86578366),
        dec: Angle.Degrees(+42.25057951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202720"},
        {"Hipparcos Number", "HIP 105034"},
        {"Smithsonian Astrophysical Observation", "SAO 50656"},
        {"Wilson Evans Batten Catalogue", "WEB 19082"},
    },
    visualMagnitude: 6.23,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.12341131),
        dec: Angle.Degrees(+42.25182572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176969"},
        {"Hipparcos Number", "HIP 93350"},
        {"Geneva Identification System", "GEN# +1.00176969"},
        {"Smithsonian Astrophysical Observation", "SAO 48000"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.20903220),
        dec: Angle.Degrees(+42.25288346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115162",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115162"},
        {"Smithsonian Astrophysical Observation", "SAO 52910"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.91458420),
        dec: Angle.Degrees(+42.25289236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 751",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 751"},
        {"Smithsonian Astrophysical Observation", "SAO 36108"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.30375144),
        dec: Angle.Degrees(+42.25439291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19517"},
        {"Hipparcos Number", "HIP 14693"},
        {"Smithsonian Astrophysical Observation", "SAO 38612"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.45656252),
        dec: Angle.Degrees(+42.26004079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98253",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13186 AB"},
        {"Henry Draper", "HD 189377"},
        {"Hipparcos Number", "HIP 98253"},
        {"Smithsonian Astrophysical Observation", "SAO 49031"},
        {"Wilson Evans Batten Catalogue", "WEB 17334"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.48382616),
        dec: Angle.Degrees(+42.26079538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12456",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12456"},
        {"Geneva Identification System", "GEN# +2.10390503"},
        {"Wilson Evans Batten Catalogue", "WEB 2548"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.10740986),
        dec: Angle.Degrees(+42.26336843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 250.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46587",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7398 AB"},
        {"Henry Draper", "HD 81939"},
        {"Hipparcos Number", "HIP 46587"},
        {"Smithsonian Astrophysical Observation", "SAO 42893"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.50818227),
        dec: Angle.Degrees(+42.26375289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48587"},
        {"Hipparcos Number", "HIP 32433"},
        {"Fundamental Katalog 5th Edition", "FK5 4616"},
        {"Smithsonian Astrophysical Observation", "SAO 41327"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.54711862),
        dec: Angle.Degrees(+42.26558367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30996",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30996"},
        {"Smithsonian Astrophysical Observation", "SAO 41132"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.58584994),
        dec: Angle.Degrees(+42.26677860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181143"},
        {"Hipparcos Number", "HIP 94809"},
        {"Smithsonian Astrophysical Observation", "SAO 48292"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.37807863),
        dec: Angle.Degrees(+42.26735641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8907"},
        {"Hipparcos Number", "HIP 6878"},
        {"Geneva Identification System", "GEN# +1.00008907"},
        {"Smithsonian Astrophysical Observation", "SAO 37248"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.14299164),
        dec: Angle.Degrees(+42.26792878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156535"},
        {"Hipparcos Number", "HIP 84464"},
        {"Smithsonian Astrophysical Observation", "SAO 46592"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.01830824),
        dec: Angle.Degrees(+42.26799745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157463"},
        {"Hipparcos Number", "HIP 84932"},
        {"Smithsonian Astrophysical Observation", "SAO 46661"},
        {"Wilson Evans Batten Catalogue", "WEB 14342"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.37261727),
        dec: Angle.Degrees(+42.26925892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35761"},
        {"Hipparcos Number", "HIP 25674"},
        {"Geneva Identification System", "GEN# +1.00035761"},
        {"Smithsonian Astrophysical Observation", "SAO 40360"},
        {"Wilson Evans Batten Catalogue", "WEB 4981"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.25449650),
        dec: Angle.Degrees(+42.27059001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85109"},
        {"Hipparcos Number", "HIP 48304"},
        {"Smithsonian Astrophysical Observation", "SAO 43065"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.71964327),
        dec: Angle.Degrees(+42.27217296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5358",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5358"},
        {"Smithsonian Astrophysical Observation", "SAO 36959"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.12674647),
        dec: Angle.Degrees(+42.27374838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24204"},
        {"Hipparcos Number", "HIP 18162"},
        {"Smithsonian Astrophysical Observation", "SAO 39170"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.24562772),
        dec: Angle.Degrees(+42.27387027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103952",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103952"},
        {"Smithsonian Astrophysical Observation", "SAO 50405"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.94184647),
        dec: Angle.Degrees(+42.27802138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8995"},
        {"Hipparcos Number", "HIP 6943"},
        {"Geneva Identification System", "GEN# +1.00008995"},
        {"Smithsonian Astrophysical Observation", "SAO 37264"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.35975641),
        dec: Angle.Degrees(+42.28205058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3432",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3432"},
        {"Geneva Identification System", "GEN# +0.04100119"},
        {"Smithsonian Astrophysical Observation", "SAO 36605"},
        {"Wilson Evans Batten Catalogue", "WEB 607"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.95007865),
        dec: Angle.Degrees(+42.28216652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114619",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114619"},
        {"Smithsonian Astrophysical Observation", "SAO 52802"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.30521796),
        dec: Angle.Degrees(+42.28413753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83423"},
        {"Hipparcos Number", "HIP 47399"},
        {"Geneva Identification System", "GEN# +1.00083423"},
        {"Smithsonian Astrophysical Observation", "SAO 42964"},
        {"Wilson Evans Batten Catalogue", "WEB 8900"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.86432913),
        dec: Angle.Degrees(+42.28588911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34769"},
        {"Hipparcos Number", "HIP 25064"},
        {"Smithsonian Astrophysical Observation", "SAO 40275"},
        {"Wilson Evans Batten Catalogue", "WEB 4860"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.48781966),
        dec: Angle.Degrees(+42.28600361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55908",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55908"},
    },
    visualMagnitude: 10.94,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.89220722),
        dec: Angle.Degrees(+42.28718430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87583"},
        {"Hipparcos Number", "HIP 49534"},
        {"Geneva Identification System", "GEN# +1.00087583"},
        {"Smithsonian Astrophysical Observation", "SAO 43194"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.71356269),
        dec: Angle.Degrees(+42.28862234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169284"},
        {"Hipparcos Number", "HIP 90010"},
        {"Smithsonian Astrophysical Observation", "SAO 47422"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.49808086),
        dec: Angle.Degrees(+42.28925188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 276861"},
        {"Hipparcos Number", "HIP 22445"},
        {"Smithsonian Astrophysical Observation", "SAO 39783"},
        {"Wilson Evans Batten Catalogue", "WEB 4332"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.44975922),
        dec: Angle.Degrees(+42.28971939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119978"},
        {"Hipparcos Number", "HIP 67158"},
        {"Smithsonian Astrophysical Observation", "SAO 44738"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.44300977),
        dec: Angle.Degrees(+42.28974845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113446"},
        {"Hipparcos Number", "HIP 63697"},
        {"Geneva Identification System", "GEN# +1.00113446"},
        {"Smithsonian Astrophysical Observation", "SAO 44443"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.80720516),
        dec: Angle.Degrees(+42.29508415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65194"},
        {"Hipparcos Number", "HIP 39053"},
        {"Smithsonian Astrophysical Observation", "SAO 42107"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.84527131),
        dec: Angle.Degrees(+42.29559673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205212"},
        {"Hipparcos Number", "HIP 106373"},
        {"Smithsonian Astrophysical Observation", "SAO 51006"},
        {"Wilson Evans Batten Catalogue", "WEB 19260"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.16648163),
        dec: Angle.Degrees(+42.29567603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278199"},
        {"Hipparcos Number", "HIP 25508"},
        {"Geneva Identification System", "GEN# +1.00278199"},
        {"Smithsonian Astrophysical Observation", "SAO 40342"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.81732264),
        dec: Angle.Degrees(+42.29640299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66043",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66043"},
    },
    visualMagnitude: 10.93,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.09202997),
        dec: Angle.Degrees(+42.29643206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100628",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100628"},
        {"Celescope Catalog", "CEL 5051"},
        {"Geneva Identification System", "GEN# +0.04103731"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.06549109),
        dec: Angle.Degrees(+42.30039867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103269",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103269"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.81963144),
        dec: Angle.Degrees(+42.30113633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -389.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68700",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68700"},
        {"Smithsonian Astrophysical Observation", "SAO 44868"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.94158372),
        dec: Angle.Degrees(+42.30431194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93941",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93941"},
        {"Celescope Catalog", "CEL 4705"},
        {"Geneva Identification System", "GEN# +0.04203250"},
    },
    visualMagnitude: 10.64,
    bvColour: -0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.91888462),
        dec: Angle.Degrees(+42.30616460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62118"},
        {"Hipparcos Number", "HIP 37706"},
        {"Smithsonian Astrophysical Observation", "SAO 41968"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.03572330),
        dec: Angle.Degrees(+42.30963750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105679"},
        {"Hipparcos Number", "HIP 59297"},
        {"Geneva Identification System", "GEN# +1.00105679"},
        {"Smithsonian Astrophysical Observation", "SAO 44059"},
        {"Wilson Evans Batten Catalogue", "WEB 10548"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.48033444),
        dec: Angle.Degrees(+42.30967370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8672"},
        {"Hipparcos Number", "HIP 6709"},
        {"Geneva Identification System", "GEN# +1.00008672"},
        {"Smithsonian Astrophysical Observation", "SAO 37203"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.57009210),
        dec: Angle.Degrees(+42.31128452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 276247"},
        {"Hipparcos Number", "HIP 20245"},
        {"Wilson Evans Batten Catalogue", "WEB 3865"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.06987269),
        dec: Angle.Degrees(+42.31440574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51418"},
        {"Hipparcos Number", "HIP 33643"},
        {"Renson", "Renson 14180"},
        {"Smithsonian Astrophysical Observation", "SAO 41475"},
        {"Wilson Evans Batten Catalogue", "WEB 6759"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.83388245),
        dec: Angle.Degrees(+42.31478161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98247"},
        {"Hipparcos Number", "HIP 55218"},
        {"Geneva Identification System", "GEN# +1.00098247"},
        {"Smithsonian Astrophysical Observation", "SAO 43689"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.61943347),
        dec: Angle.Degrees(+42.31643326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86511"},
        {"Hipparcos Number", "HIP 49019"},
        {"Geneva Identification System", "GEN# +1.00086511"},
        {"Smithsonian Astrophysical Observation", "SAO 43134"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.01385897),
        dec: Angle.Degrees(+42.31675531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195405"},
        {"Hipparcos Number", "HIP 101087"},
        {"Geneva Identification System", "GEN# +1.00195405"},
        {"Smithsonian Astrophysical Observation", "SAO 49692"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.36827129),
        dec: Angle.Degrees(+42.31682789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187342"},
        {"Hipparcos Number", "HIP 97395"},
        {"Smithsonian Astrophysical Observation", "SAO 48843"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.92177297),
        dec: Angle.Degrees(+42.31851342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200030"},
        {"Hipparcos Number", "HIP 103596"},
        {"Celescope Catalog", "CEL 5226"},
        {"Geneva Identification System", "GEN# +1.00200030"},
        {"Smithsonian Astrophysical Observation", "SAO 50319"},
    },
    visualMagnitude: 6.47,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.85252626),
        dec: Angle.Degrees(+42.32445032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217675"},
        {"Henry Draper 2", "HD 217676"},
        {"Hipparcos Number", "HIP 113726"},
        {"Celescope Catalog", "CEL 5556"},
        {"Fundamental Katalog 5th Edition", "FK5 869"},
        {"Geneva Identification System", "GEN# +1.00217675"},
        {"Smithsonian Astrophysical Observation", "SAO 52609"},
        {"Wilson Evans Batten Catalogue", "WEB 20208"},
    },
    visualMagnitude: 3.62,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.48019377),
        dec: Angle.Degrees(+42.32597866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183125"},
        {"Hipparcos Number", "HIP 95548"},
        {"Smithsonian Astrophysical Observation", "SAO 48437"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.52284578),
        dec: Angle.Degrees(+42.32609112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4082",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4082"},
        {"Geneva Identification System", "GEN# +0.04100150"},
        {"Smithsonian Astrophysical Observation", "SAO 36729"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.08713204),
        dec: Angle.Degrees(+42.32637349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58702",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58702"},
        {"Smithsonian Astrophysical Observation", "SAO 44004"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.59890363),
        dec: Angle.Degrees(+42.32658715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -151.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45244",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7241 B"},
        {"Hipparcos Number", "HIP 45244"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.33556153),
        dec: Angle.Degrees(+42.32681686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9416"},
        {"Hipparcos Number", "HIP 7252"},
        {"Smithsonian Astrophysical Observation", "SAO 37308"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.35908125),
        dec: Angle.Degrees(+42.32766865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101206"},
        {"Hipparcos Number", "HIP 56829"},
        {"Cincinnati Publication", "Ci 18 1435"},
        {"Cincinnati Publication 2", "Ci 20 654"},
        {"Geneva Identification System", "GEN# +1.00101206"},
        {"Smithsonian Astrophysical Observation", "SAO 43847"},
        {"Wilson Evans Batten Catalogue", "WEB 10232"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.74924888),
        dec: Angle.Degrees(+42.32774572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 436.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26979",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26979"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.87270851),
        dec: Angle.Degrees(+42.32799301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45247",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7241 A"},
        {"Henry Draper", "HD 79095"},
        {"Hipparcos Number", "HIP 45247"},
        {"Smithsonian Astrophysical Observation", "SAO 42754"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.33823025),
        dec: Angle.Degrees(+42.32947875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9640",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Almach"},
        {"Aitken", "ADS 1630 A"},
        {"Henry Draper", "HD 12533"},
        {"Hipparcos Number", "HIP 9640"},
        {"Fundamental Katalog 5th Edition", "FK5 73"},
        {"Geneva Identification System", "GEN# +1.00012533"},
        {"Geneva Identification System 2", "GEN# +1.00012533A"},
        {"Smithsonian Astrophysical Observation", "SAO 37734"},
        {"Wilson Evans Batten Catalogue", "WEB 2024"},
    },
    visualMagnitude: 2.10,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.97466283),
        dec: Angle.Degrees(+42.32984832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114065",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114065"},
    },
    visualMagnitude: 11.17,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.50941423),
        dec: Angle.Degrees(+42.32984958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -263.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82247"},
        {"Hipparcos Number", "HIP 46798"},
        {"Smithsonian Astrophysical Observation", "SAO 42906"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.04498716),
        dec: Angle.Degrees(+42.33249021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84223",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84223"},
        {"Cincinnati Publication", "Ci 20 1025"},
        {"Cincinnati Publication 2", "Ci 18 2297"},
        {"Geneva Identification System", "GEN# +0.04202810"},
        {"Wilson Evans Batten Catalogue", "WEB 14225"},
    },
    visualMagnitude: 10.07,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.23289668),
        dec: Angle.Degrees(+42.33261362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1015.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -354.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120463"},
        {"Hipparcos Number", "HIP 67392"},
        {"Geneva Identification System", "GEN# +1.00120463"},
        {"Smithsonian Astrophysical Observation", "SAO 44760"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.17875907),
        dec: Angle.Degrees(+42.33773957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97814"},
        {"Hipparcos Number", "HIP 54992"},
        {"Geneva Identification System", "GEN# +1.00097814"},
        {"Smithsonian Astrophysical Observation", "SAO 43663"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.90077049),
        dec: Angle.Degrees(+42.33940762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104689",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104689"},
        {"Smithsonian Astrophysical Observation", "SAO 50565"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.09751421),
        dec: Angle.Degrees(+42.35620670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16793",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2630 AB"},
        {"Henry Draper", "HD 22193"},
        {"Hipparcos Number", "HIP 16793"},
        {"Geneva Identification System", "GEN# +1.00022193J"},
        {"Smithsonian Astrophysical Observation", "SAO 38976"},
        {"Wilson Evans Batten Catalogue", "WEB 3196"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.03899417),
        dec: Angle.Degrees(+42.33976798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 141.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44004"},
        {"Hipparcos Number", "HIP 30205"},
        {"Smithsonian Astrophysical Observation", "SAO 41039"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.32455360),
        dec: Angle.Degrees(+42.34037708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124291"},
        {"Hipparcos Number", "HIP 69350"},
        {"Smithsonian Astrophysical Observation", "SAO 44929"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.90465378),
        dec: Angle.Degrees(+42.34069203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18704",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18704"},
        {"Smithsonian Astrophysical Observation", "SAO 39240"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.10204968),
        dec: Angle.Degrees(+42.34166791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57464",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57464"},
        {"Smithsonian Astrophysical Observation", "SAO 43887"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.68693168),
        dec: Angle.Degrees(+42.34373198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1144"},
        {"Hipparcos Number", "HIP 1261"},
        {"Smithsonian Astrophysical Observation", "SAO 36212"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.95952151),
        dec: Angle.Degrees(+42.34394657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31949"},
        {"Hipparcos Number", "HIP 23399"},
        {"Geneva Identification System", "GEN# +1.00031949"},
        {"Smithsonian Astrophysical Observation", "SAO 39951"},
        {"Wilson Evans Batten Catalogue", "WEB 4544"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.43878643),
        dec: Angle.Degrees(+42.34454081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107920",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15400 A"},
        {"Henry Draper", "HD 207966"},
        {"Henry Draper 2", "HD 207966A"},
        {"Hipparcos Number", "HIP 107920"},
        {"Cincinnati Publication", "Ci 18 2843"},
        {"Geneva Identification System", "GEN# +1.00207966"},
        {"Smithsonian Astrophysical Observation", "SAO 51378"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.97112044),
        dec: Angle.Degrees(+42.34462130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -175.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -305.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30090"},
        {"Hipparcos Number", "HIP 22196"},
        {"Geneva Identification System", "GEN# +1.00030090"},
        {"Smithsonian Astrophysical Observation", "SAO 39741"},
        {"Wilson Evans Batten Catalogue", "WEB 4268"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.61218377),
        dec: Angle.Degrees(+42.34838914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18710",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18710"},
        {"Smithsonian Astrophysical Observation", "SAO 39241"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.11400390),
        dec: Angle.Degrees(+42.34882317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164966"},
        {"Hipparcos Number", "HIP 88279"},
        {"Geneva Identification System", "GEN# +1.00164966"},
        {"Smithsonian Astrophysical Observation", "SAO 47148"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.772,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.40266920),
        dec: Angle.Degrees(+42.35055151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23861"},
        {"Hipparcos Number", "HIP 17941"},
        {"Smithsonian Astrophysical Observation", "SAO 39137"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.54971894),
        dec: Angle.Degrees(+42.35092499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225105"},
        {"Hipparcos Number", "HIP 288"},
        {"Smithsonian Astrophysical Observation", "SAO 36023"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.88875927),
        dec: Angle.Degrees(+42.35221969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91617",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91617"},
    },
    visualMagnitude: 10.03,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.27171802),
        dec: Angle.Degrees(+42.35335024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97973"},
        {"Hipparcos Number", "HIP 55073"},
        {"Smithsonian Astrophysical Observation", "SAO 43673"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.13203649),
        dec: Angle.Degrees(+42.35436675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64874",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64874"},
    },
    visualMagnitude: 10.37,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.46363118),
        dec: Angle.Degrees(+42.35438931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51643",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51643"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.26949539),
        dec: Angle.Degrees(+42.35740180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207609"},
        {"Hipparcos Number", "HIP 107707"},
        {"Smithsonian Astrophysical Observation", "SAO 51329"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.27787638),
        dec: Angle.Degrees(+42.35818205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69759",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69759"},
        {"Wilson Evans Batten Catalogue", "WEB 12148"},
    },
    visualMagnitude: 11.03,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.15243634),
        dec: Angle.Degrees(+42.36000216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221160"},
        {"Hipparcos Number", "HIP 115931"},
        {"Smithsonian Astrophysical Observation", "SAO 53072"},
    },
    visualMagnitude: 7.68,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.32099269),
        dec: Angle.Degrees(+42.36009617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192869"},
        {"Hipparcos Number", "HIP 99859"},
        {"Geneva Identification System", "GEN# +1.00192869"},
        {"Smithsonian Astrophysical Observation", "SAO 49383"},
        {"Wilson Evans Batten Catalogue", "WEB 17956"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.90142543),
        dec: Angle.Degrees(+42.36204936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103086",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103086"},
        {"Renson", "Renson 55430"},
        {"Smithsonian Astrophysical Observation", "SAO 50179"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.30779624),
        dec: Angle.Degrees(+42.36306390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96390",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96390"},
        {"Smithsonian Astrophysical Observation", "SAO 48630"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.95777665),
        dec: Angle.Degrees(+42.36612566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108253"},
        {"Hipparcos Number", "HIP 60659"},
        {"Smithsonian Astrophysical Observation", "SAO 44174"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.48885758),
        dec: Angle.Degrees(+42.36694388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224906"},
        {"Hipparcos Number", "HIP 137"},
        {"Geneva Identification System", "GEN# +1.00224906"},
        {"Renson", "Renson 61670"},
        {"Smithsonian Astrophysical Observation", "SAO 53580"},
        {"Wilson Evans Batten Catalogue", "WEB 21"},
    },
    visualMagnitude: 6.25,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.43268925),
        dec: Angle.Degrees(+42.36714821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76828"},
        {"Hipparcos Number", "HIP 44184"},
        {"Smithsonian Astrophysical Observation", "SAO 42638"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.00970832),
        dec: Angle.Degrees(+42.36800354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153776"},
        {"Hipparcos Number", "HIP 83149"},
        {"Smithsonian Astrophysical Observation", "SAO 46423"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.88904534),
        dec: Angle.Degrees(+42.36959999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114124"},
        {"Hipparcos Number", "HIP 64074"},
        {"Geneva Identification System", "GEN# +1.00114124"},
        {"Smithsonian Astrophysical Observation", "SAO 44481"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.96811073),
        dec: Angle.Degrees(+42.37398850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92822"},
        {"Hipparcos Number", "HIP 52483"},
        {"Smithsonian Astrophysical Observation", "SAO 43445"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.95020573),
        dec: Angle.Degrees(+42.37431494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79357",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9962 A"},
        {"Henry Draper", "HD 145931"},
        {"Hipparcos Number", "HIP 79357"},
        {"Fundamental Katalog 5th Edition", "FK5 3281"},
        {"Geneva Identification System", "GEN# +1.00145931A"},
        {"Smithsonian Astrophysical Observation", "SAO 45957"},
        {"Wilson Evans Batten Catalogue", "WEB 13417"},
    },
    visualMagnitude: 5.89,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.94835302),
        dec: Angle.Degrees(+42.37450876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
