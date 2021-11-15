using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_87() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172498"},
        {"Hipparcos Number", "HIP 91473"},
        {"Smithsonian Astrophysical Observation", "SAO 86291"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.85123697),
        dec: Angle.Degrees(+29.51827772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110276",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15843 AB"},
        {"Henry Draper", "HD 211933"},
        {"Hipparcos Number", "HIP 110276"},
        {"Smithsonian Astrophysical Observation", "SAO 90427"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.05299673),
        dec: Angle.Degrees(+29.51876591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176938"},
        {"Hipparcos Number", "HIP 93397"},
        {"Smithsonian Astrophysical Observation", "SAO 86709"},
        {"Wilson Evans Batten Catalogue", "WEB 16199"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.33046561),
        dec: Angle.Degrees(+29.51889477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41099"},
        {"Hipparcos Number", "HIP 28747"},
        {"Smithsonian Astrophysical Observation", "SAO 77914"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.06490277),
        dec: Angle.Degrees(+29.51935973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175083"},
        {"Hipparcos Number", "HIP 92632"},
        {"Smithsonian Astrophysical Observation", "SAO 86534"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.11436377),
        dec: Angle.Degrees(+29.52139434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5585"},
        {"Hipparcos Number", "HIP 4517"},
        {"Smithsonian Astrophysical Observation", "SAO 74396"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.47391203),
        dec: Angle.Degrees(+29.52152447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246338"},
        {"Hipparcos Number", "HIP 26845"},
        {"Geneva Identification System", "GEN# +1.00246338"},
        {"Smithsonian Astrophysical Observation", "SAO 77409"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.49734157),
        dec: Angle.Degrees(+29.52264020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83892",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83892"},
        {"Smithsonian Astrophysical Observation", "SAO 84874"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.19416010),
        dec: Angle.Degrees(+29.52315283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195967"},
        {"Hipparcos Number", "HIP 101431"},
        {"Smithsonian Astrophysical Observation", "SAO 88833"},
        {"Wilson Evans Batten Catalogue", "WEB 18326"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.34430606),
        dec: Angle.Degrees(+29.52400166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27933"},
        {"Hipparcos Number", "HIP 20663"},
        {"Smithsonian Astrophysical Observation", "SAO 76603"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.40940114),
        dec: Angle.Degrees(+29.52674264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84139",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84139"},
        {"Geneva Identification System", "GEN# +0.02902958"},
        {"Smithsonian Astrophysical Observation", "SAO 84914"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.03005789),
        dec: Angle.Degrees(+29.52735172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2732"},
        {"Hipparcos Number", "HIP 2421"},
        {"Geneva Identification System", "GEN# +1.00002732"},
        {"Smithsonian Astrophysical Observation", "SAO 74054"},
        {"Wilson Evans Batten Catalogue", "WEB 444"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.72226733),
        dec: Angle.Degrees(+29.52842817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188994"},
        {"Hipparcos Number", "HIP 98151"},
        {"Geneva Identification System", "GEN# +1.00188994"},
        {"Smithsonian Astrophysical Observation", "SAO 87961"},
        {"Wilson Evans Batten Catalogue", "WEB 17300"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.20238229),
        dec: Angle.Degrees(+29.53091312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82640",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82640"},
        {"Smithsonian Astrophysical Observation", "SAO 84673"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.39156784),
        dec: Angle.Degrees(+29.53166036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111271"},
        {"Hipparcos Number", "HIP 62439"},
        {"Geneva Identification System", "GEN# +1.00111271"},
        {"Smithsonian Astrophysical Observation", "SAO 82498"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.95366739),
        dec: Angle.Degrees(+29.53211871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281433"},
        {"Hipparcos Number", "HIP 18472"},
        {"Smithsonian Astrophysical Observation", "SAO 76338"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.21702504),
        dec: Angle.Degrees(+29.53262884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60196",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60196"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.16970422),
        dec: Angle.Degrees(+29.53354131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86338"},
        {"Hipparcos Number", "HIP 48898"},
        {"Smithsonian Astrophysical Observation", "SAO 81121"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.62421027),
        dec: Angle.Degrees(+29.53448650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187074"},
        {"Hipparcos Number", "HIP 97329"},
        {"Celescope Catalog", "CEL 4841"},
        {"Geneva Identification System", "GEN# +1.00187074"},
        {"Renson", "Renson 51560"},
        {"Smithsonian Astrophysical Observation", "SAO 87713"},
    },
    visualMagnitude: 8.19,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.71421804),
        dec: Angle.Degrees(+29.53507409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77975",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9844 AB"},
        {"Henry Draper", "HD 142796"},
        {"Hipparcos Number", "HIP 77975"},
        {"Smithsonian Astrophysical Observation", "SAO 84078"},
        {"Wilson Evans Batten Catalogue", "WEB 13187"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.85757256),
        dec: Angle.Degrees(+29.53706679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97385"},
        {"Hipparcos Number", "HIP 54778"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.21775825),
        dec: Angle.Degrees(+29.53832871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70835",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9279 A"},
        {"Hipparcos Number", "HIP 70835"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.28762105),
        dec: Angle.Degrees(+29.53865487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205700"},
        {"Hipparcos Number", "HIP 106674"},
        {"Geneva Identification System", "GEN# +1.00205700"},
        {"Smithsonian Astrophysical Observation", "SAO 89838"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.09577580),
        dec: Angle.Degrees(+29.53978233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64977",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64977"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.76298262),
        dec: Angle.Degrees(+29.53982826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19104"},
        {"Hipparcos Number", "HIP 14364"},
        {"Smithsonian Astrophysical Observation", "SAO 75721"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.33330494),
        dec: Angle.Degrees(+29.54062732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44092"},
        {"Hipparcos Number", "HIP 30200"},
        {"Geneva Identification System", "GEN# +1.00044092"},
        {"Renson", "Renson 11700"},
        {"Smithsonian Astrophysical Observation", "SAO 78259"},
        {"Wilson Evans Batten Catalogue", "WEB 6006"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.29963245),
        dec: Angle.Degrees(+29.54092745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40209",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6653 AB"},
        {"Henry Draper", "HD 68253"},
        {"Hipparcos Number", "HIP 40209"},
        {"Geneva Identification System", "GEN# +1.00068253J"},
        {"Smithsonian Astrophysical Observation", "SAO 80014"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.18510508),
        dec: Angle.Degrees(+29.54192487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 254288"},
        {"Hipparcos Number", "HIP 29846"},
        {"Smithsonian Astrophysical Observation", "SAO 78175"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.27182484),
        dec: Angle.Degrees(+29.54195522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213534"},
        {"Hipparcos Number", "HIP 111191"},
        {"Geneva Identification System", "GEN# +1.00213534"},
        {"Renson", "Renson 59220"},
        {"Smithsonian Astrophysical Observation", "SAO 90568"},
        {"Wilson Evans Batten Catalogue", "WEB 19897"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.89321398),
        dec: Angle.Degrees(+29.54283895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9032"},
        {"Hipparcos Number", "HIP 6950"},
        {"Smithsonian Astrophysical Observation", "SAO 74749"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.37237411),
        dec: Angle.Degrees(+29.54353649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60395",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60395"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.75042252),
        dec: Angle.Degrees(+29.54501656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81209"},
        {"Hipparcos Number", "HIP 46195"},
        {"Geneva Identification System", "GEN# +1.00081209"},
        {"Smithsonian Astrophysical Observation", "SAO 80813"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.28330139),
        dec: Angle.Degrees(+29.54694883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57403"},
        {"Hipparcos Number", "HIP 35732"},
        {"Smithsonian Astrophysical Observation", "SAO 79329"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.56585309),
        dec: Angle.Degrees(+29.54770755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104451"},
        {"Hipparcos Number", "HIP 58658"},
        {"Geneva Identification System", "GEN# +1.00104451"},
        {"Wilson Evans Batten Catalogue", "WEB 10465"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.43328082),
        dec: Angle.Degrees(+29.54857391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25764",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4086 AB"},
        {"Henry Draper", "HD 36044"},
        {"Hipparcos Number", "HIP 25764"},
        {"Smithsonian Astrophysical Observation", "SAO 77210"},
        {"Wilson Evans Batten Catalogue", "WEB 5003"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.52559013),
        dec: Angle.Degrees(+29.54868848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109040",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109040"},
    },
    visualMagnitude: 10.81,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.33905209),
        dec: Angle.Degrees(+29.54887664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 178.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153650"},
        {"Hipparcos Number", "HIP 83152"},
        {"Smithsonian Astrophysical Observation", "SAO 84742"},
        {"Wilson Evans Batten Catalogue", "WEB 14052"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.89531037),
        dec: Angle.Degrees(+29.54949619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8266",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8266"},
        {"Smithsonian Astrophysical Observation", "SAO 74920"},
        {"Wilson Evans Batten Catalogue", "WEB 1761"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.62259180),
        dec: Angle.Degrees(+29.55034830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 664"},
        {"Hipparcos Number", "HIP 895"},
        {"Smithsonian Astrophysical Observation", "SAO 73791"},
        {"Wilson Evans Batten Catalogue", "WEB 156"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.75589325),
        dec: Angle.Degrees(+29.55052263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97489"},
        {"Hipparcos Number", "HIP 54826"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.35591640),
        dec: Angle.Degrees(+29.55217159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25763",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4086 C"},
        {"Henry Draper", "HD 36044C"},
        {"Hipparcos Number", "HIP 25763"},
        {"Geneva Identification System", "GEN# +1.00036044C"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.52490033),
        dec: Angle.Degrees(+29.55286332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90594",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11393 A"},
        {"Henry Draper", "HD 170619"},
        {"Hipparcos Number", "HIP 90594"},
        {"Geneva Identification System", "GEN# +1.00170619"},
        {"Smithsonian Astrophysical Observation", "SAO 86109"},
        {"Wilson Evans Batten Catalogue", "WEB 15514"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.29798929),
        dec: Angle.Degrees(+29.55374276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74312",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74312"},
        {"Smithsonian Astrophysical Observation", "SAO 83707"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.83778845),
        dec: Angle.Degrees(+29.55391294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58019",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58019"},
        {"Wilson Evans Batten Catalogue", "WEB 10393"},
    },
    visualMagnitude: 10.92,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.50348799),
        dec: Angle.Degrees(+29.55415350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89084"},
        {"Hipparcos Number", "HIP 50374"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.28078699),
        dec: Angle.Degrees(+29.55433235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98901"},
        {"Hipparcos Number", "HIP 55584"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.79106264),
        dec: Angle.Degrees(+29.55455849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86840",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86840"},
        {"Smithsonian Astrophysical Observation", "SAO 85375"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.15678355),
        dec: Angle.Degrees(+29.56006405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88308",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88308"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.50919437),
        dec: Angle.Degrees(+29.56013083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107387",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107387"},
    },
    visualMagnitude: 9.89,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.25565558),
        dec: Angle.Degrees(+29.56167869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222935"},
        {"Hipparcos Number", "HIP 117159"},
        {"Cincinnati Publication", "Ci 20 1450"},
        {"Geneva Identification System", "GEN# +1.00222935"},
        {"Smithsonian Astrophysical Observation", "SAO 91465"},
        {"Wilson Evans Batten Catalogue", "WEB 20649"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.28874773),
        dec: Angle.Degrees(+29.56188121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 948.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16669",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16669"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.62989855),
        dec: Angle.Degrees(+29.56530666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10015"},
        {"Hipparcos Number", "HIP 7636"},
        {"Cincinnati Publication", "Ci 18 226"},
        {"Cincinnati Publication 2", "Ci 20 114"},
        {"Geneva Identification System", "GEN# +1.00010015"},
        {"Smithsonian Astrophysical Observation", "SAO 74842"},
        {"Wilson Evans Batten Catalogue", "WEB 1632"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.59919414),
        dec: Angle.Degrees(+29.56741916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 392.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -254.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136420"},
        {"Hipparcos Number", "HIP 75005"},
        {"Smithsonian Astrophysical Observation", "SAO 83765"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.89929423),
        dec: Angle.Degrees(+29.56759143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282544"},
        {"Hipparcos Number", "HIP 22727"},
        {"Smithsonian Astrophysical Observation", "SAO 76808"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.34081248),
        dec: Angle.Degrees(+29.56882793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84309",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84309"},
        {"Geneva Identification System", "GEN# +0.02902963"},
        {"Smithsonian Astrophysical Observation", "SAO 84945"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.54826795),
        dec: Angle.Degrees(+29.56942746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34790"},
        {"Hipparcos Number", "HIP 25001"},
        {"Celescope Catalog", "CEL 635"},
        {"Geneva Identification System", "GEN# +1.00034790"},
        {"Smithsonian Astrophysical Observation", "SAO 77124"},
        {"Wilson Evans Batten Catalogue", "WEB 4841"},
    },
    visualMagnitude: 5.66,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.30286824),
        dec: Angle.Degrees(+29.56988462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 265672"},
        {"Hipparcos Number", "HIP 33131"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.48631252),
        dec: Angle.Degrees(+29.57013585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13017"},
        {"Hipparcos Number", "HIP 9945"},
        {"Smithsonian Astrophysical Observation", "SAO 75157"},
        {"Wilson Evans Batten Catalogue", "WEB 2086"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.00025839),
        dec: Angle.Degrees(+29.57044461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55135",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55135"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.31126347),
        dec: Angle.Degrees(+29.57059698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -211.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 256714"},
        {"Hipparcos Number", "HIP 30561"},
        {"Geneva Identification System", "GEN# +1.00256714"},
        {"Smithsonian Astrophysical Observation", "SAO 78343"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.36344913),
        dec: Angle.Degrees(+29.57118938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152264"},
        {"Hipparcos Number", "HIP 82469"},
        {"Geneva Identification System", "GEN# +1.00152264"},
        {"Smithsonian Astrophysical Observation", "SAO 84644"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.80347797),
        dec: Angle.Degrees(+29.57123795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30466"},
        {"Hipparcos Number", "HIP 22402"},
        {"Geneva Identification System", "GEN# +1.00030466"},
        {"Renson", "Renson 7870"},
        {"Smithsonian Astrophysical Observation", "SAO 76771"},
        {"Wilson Evans Batten Catalogue", "WEB 4320"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.31665359),
        dec: Angle.Degrees(+29.57144210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164595"},
        {"Hipparcos Number", "HIP 88194"},
        {"Cincinnati Publication", "Ci 18 2385"},
        {"Geneva Identification System", "GEN# +1.00164595"},
        {"Smithsonian Astrophysical Observation", "SAO 85632"},
        {"Wilson Evans Batten Catalogue", "WEB 14904"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.16244923),
        dec: Angle.Degrees(+29.57150083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -139.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 173.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50642",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50642"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.14497068),
        dec: Angle.Degrees(+29.57172059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109815",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15769 AB"},
        {"Henry Draper", "HD 211139"},
        {"Hipparcos Number", "HIP 109815"},
        {"Smithsonian Astrophysical Observation", "SAO 90348"},
        {"Wilson Evans Batten Catalogue", "WEB 19725"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.64421629),
        dec: Angle.Degrees(+29.57244160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82069"},
        {"Hipparcos Number", "HIP 46625"},
        {"Wilson Evans Batten Catalogue", "WEB 8796"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.61671082),
        dec: Angle.Degrees(+29.57351813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143255"},
        {"Hipparcos Number", "HIP 78218"},
        {"Smithsonian Astrophysical Observation", "SAO 84108"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.58797040),
        dec: Angle.Degrees(+29.57529973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8796",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Mothallah"},
        {"Henry Draper", "HD 11443"},
        {"Hipparcos Number", "HIP 8796"},
        {"Fundamental Katalog 5th Edition", "FK5 64"},
        {"Geneva Identification System", "GEN# +1.00011443"},
        {"Smithsonian Astrophysical Observation", "SAO 74996"},
        {"Wilson Evans Batten Catalogue", "WEB 1850"},
    },
    visualMagnitude: 3.42,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.27041595),
        dec: Angle.Degrees(+29.57939727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -233.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101953"},
        {"Hipparcos Number", "HIP 57234"},
        {"Geneva Identification System", "GEN# +1.00101953"},
        {"Renson", "Renson 29370"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.03096282),
        dec: Angle.Degrees(+29.58011400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63591",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63591"},
        {"Geneva Identification System", "GEN# +0.03002355"},
    },
    visualMagnitude: 10.65,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.47068956),
        dec: Angle.Degrees(+29.58255967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36454",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36454"},
        {"Smithsonian Astrophysical Observation", "SAO 79436"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.51880333),
        dec: Angle.Degrees(+29.58389642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104848",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104848"},
        {"Smithsonian Astrophysical Observation", "SAO 89550"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.58941612),
        dec: Angle.Degrees(+29.58405298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49109",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49109"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.34235404),
        dec: Angle.Degrees(+29.58461824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172169"},
        {"Hipparcos Number", "HIP 91306"},
        {"Geneva Identification System", "GEN# +1.00172169"},
        {"Smithsonian Astrophysical Observation", "SAO 86256"},
        {"Wilson Evans Batten Catalogue", "WEB 15691"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.36996324),
        dec: Angle.Degrees(+29.58464839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 88.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 333410"},
        {"Hipparcos Number", "HIP 98635"},
        {"Smithsonian Astrophysical Observation", "SAO 88100"},
        {"Wilson Evans Batten Catalogue", "WEB 17449"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.50543535),
        dec: Angle.Degrees(+29.58589343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59877"},
        {"Geneva Identification System", "GEN# +0.03002250"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.19315548),
        dec: Angle.Degrees(+29.58665732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215305"},
        {"Hipparcos Number", "HIP 112228"},
        {"Smithsonian Astrophysical Observation", "SAO 90744"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.95893729),
        dec: Angle.Degrees(+29.58760019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153224"},
        {"Hipparcos Number", "HIP 82928"},
        {"Geneva Identification System", "GEN# +1.00153224"},
        {"Smithsonian Astrophysical Observation", "SAO 84709"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.20755124),
        dec: Angle.Degrees(+29.58963761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108629"},
        {"Hipparcos Number", "HIP 60867"},
        {"Geneva Identification System", "GEN# +1.00108629"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.13629438),
        dec: Angle.Degrees(+29.58991947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213803"},
        {"Hipparcos Number", "HIP 111359"},
        {"Geneva Identification System", "GEN# +1.00213803"},
        {"Smithsonian Astrophysical Observation", "SAO 90597"},
        {"Wilson Evans Batten Catalogue", "WEB 19916"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.40643855),
        dec: Angle.Degrees(+29.59008963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95419"},
        {"Hipparcos Number", "HIP 53869"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.31729077),
        dec: Angle.Degrees(+29.59143745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 310.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62881"},
        {"Hipparcos Number", "HIP 38002"},
        {"Smithsonian Astrophysical Observation", "SAO 79691"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.83425625),
        dec: Angle.Degrees(+29.59156584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84679"},
        {"Hipparcos Number", "HIP 48048"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.92125847),
        dec: Angle.Degrees(+29.59174105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14259",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14259"},
        {"Geneva Identification System", "GEN# +9.80036050"},
    },
    visualMagnitude: 12.02,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.96145505),
        dec: Angle.Degrees(+29.59321195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 337.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -315.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72062",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72062"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.10051346),
        dec: Angle.Degrees(+29.59555972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65775"},
        {"Hipparcos Number", "HIP 39233"},
        {"Smithsonian Astrophysical Observation", "SAO 79866"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.36295147),
        dec: Angle.Degrees(+29.59733685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160952"},
        {"Hipparcos Number", "HIP 86579"},
        {"Smithsonian Astrophysical Observation", "SAO 85326"},
        {"Wilson Evans Batten Catalogue", "WEB 14601"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.40597620),
        dec: Angle.Degrees(+29.59904904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111004"},
        {"Hipparcos Number", "HIP 62305"},
        {"Geneva Identification System", "GEN# +1.00111004"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.50556706),
        dec: Angle.Degrees(+29.60006083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140889"},
        {"Hipparcos Number", "HIP 77147"},
        {"Smithsonian Astrophysical Observation", "SAO 83984"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.27052896),
        dec: Angle.Degrees(+29.60148666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74826",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74826"},
        {"Geneva Identification System", "GEN# +0.03002637"},
        {"Smithsonian Astrophysical Observation", "SAO 83751"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.38398261),
        dec: Angle.Degrees(+29.60285290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149132"},
        {"Hipparcos Number", "HIP 80941"},
        {"Geneva Identification System", "GEN# +1.00149132"},
        {"Smithsonian Astrophysical Observation", "SAO 84429"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.91675139),
        dec: Angle.Degrees(+29.60562937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79713",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9986 AB"},
        {"Henry Draper", "HD 146622"},
        {"Hipparcos Number", "HIP 79713"},
        {"Smithsonian Astrophysical Observation", "SAO 84273"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.02262852),
        dec: Angle.Degrees(+29.60768822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2941"},
        {"Hipparcos Number", "HIP 2593"},
        {"Smithsonian Astrophysical Observation", "SAO 74091"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.22406233),
        dec: Angle.Degrees(+29.61099790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16376",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2578 AB"},
        {"Henry Draper", "HD 21674"},
        {"Hipparcos Number", "HIP 16376"},
        {"Smithsonian Astrophysical Observation", "SAO 75961"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.74713917),
        dec: Angle.Degrees(+29.61370614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185332"},
        {"Hipparcos Number", "HIP 96530"},
        {"Smithsonian Astrophysical Observation", "SAO 87474"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.37450894),
        dec: Angle.Degrees(+29.61508307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51660",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51660"},
        {"Geneva Identification System", "GEN# +0.03002034"},
    },
    visualMagnitude: 10.35,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.31225215),
        dec: Angle.Degrees(+29.61530254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89993"},
        {"Hipparcos Number", "HIP 50904"},
        {"Geneva Identification System", "GEN# +1.00089993"},
        {"Smithsonian Astrophysical Observation", "SAO 81328"},
        {"Wilson Evans Batten Catalogue", "WEB 9312"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.92402043),
        dec: Angle.Degrees(+29.61588746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148005"},
        {"Hipparcos Number", "HIP 80335"},
        {"Geneva Identification System", "GEN# +1.00148005"},
        {"Smithsonian Astrophysical Observation", "SAO 84354"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.00407820),
        dec: Angle.Degrees(+29.61599592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136512"},
        {"Hipparcos Number", "HIP 75049"},
        {"Geneva Identification System", "GEN# +1.00136512"},
        {"Smithsonian Astrophysical Observation", "SAO 83768"},
        {"Wilson Evans Batten Catalogue", "WEB 12800"},
    },
    visualMagnitude: 5.51,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.03599149),
        dec: Angle.Degrees(+29.61631109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182568"},
        {"Hipparcos Number", "HIP 95372"},
        {"Fundamental Katalog 5th Edition", "FK5 3550"},
        {"Geneva Identification System", "GEN# +1.00182568"},
        {"Renson", "Renson 50490"},
        {"Smithsonian Astrophysical Observation", "SAO 87159"},
        {"Wilson Evans Batten Catalogue", "WEB 16668"},
    },
    visualMagnitude: 4.99,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.03154901),
        dec: Angle.Degrees(+29.62131120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139815"},
        {"Hipparcos Number", "HIP 76658"},
        {"Geneva Identification System", "GEN# +1.00139815"},
        {"Smithsonian Astrophysical Observation", "SAO 83931"},
        {"Wilson Evans Batten Catalogue", "WEB 13015"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.81349370),
        dec: Angle.Degrees(+29.62212821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70978",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70978"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.76004347),
        dec: Angle.Degrees(+29.62282556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154651"},
        {"Hipparcos Number", "HIP 83640"},
        {"Geneva Identification System", "GEN# +1.00154651"},
        {"Smithsonian Astrophysical Observation", "SAO 84827"},
        {"Wilson Evans Batten Catalogue", "WEB 14146"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.40666396),
        dec: Angle.Degrees(+29.62318026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140385"},
        {"Hipparcos Number", "HIP 76911"},
        {"Geneva Identification System", "GEN# +1.00140385"},
        {"Smithsonian Astrophysical Observation", "SAO 83953"},
        {"Wilson Evans Batten Catalogue", "WEB 13045"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.56807573),
        dec: Angle.Degrees(+29.62332597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -165.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56401",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56401"},
        {"Wilson Evans Batten Catalogue", "WEB 10135"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.44201810),
        dec: Angle.Degrees(+29.62557180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28270",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4544 AB"},
        {"Henry Draper", "HD 40163"},
        {"Hipparcos Number", "HIP 28270"},
        {"Renson", "Renson 10711"},
        {"Smithsonian Astrophysical Observation", "SAO 77781"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.60018718),
        dec: Angle.Degrees(+29.62700241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112414"},
        {"Hipparcos Number", "HIP 63138"},
        {"Geneva Identification System", "GEN# +1.00112414"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.06225259),
        dec: Angle.Degrees(+29.62782336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73712",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73712"},
    },
    visualMagnitude: 9.96,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.01124479),
        dec: Angle.Degrees(+29.62945799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23598",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3651 AB"},
        {"Henry Draper", "HD 32429"},
        {"Hipparcos Number", "HIP 23598"},
        {"Smithsonian Astrophysical Observation", "SAO 76937"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.11070277),
        dec: Angle.Degrees(+29.62969951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200289"},
        {"Hipparcos Number", "HIP 103775"},
        {"Geneva Identification System", "GEN# +1.00200289J"},
        {"Smithsonian Astrophysical Observation", "SAO 89380"},
    },
    visualMagnitude: 7.98,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.43119275),
        dec: Angle.Degrees(+29.63013979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94457"},
        {"Hipparcos Number", "HIP 53345"},
        {"Geneva Identification System", "GEN# +1.00094457"},
        {"Smithsonian Astrophysical Observation", "SAO 81574"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.64759296),
        dec: Angle.Degrees(+29.63019262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70218",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70218"},
        {"Cincinnati Publication", "Ci 20 854"},
        {"Cincinnati Publication 2", "Ci 18 1885"},
        {"Fundamental Katalog 5th Edition", "FK5 5267"},
        {"Geneva Identification System", "GEN# +0.03002512"},
        {"Smithsonian Astrophysical Observation", "SAO 83309"},
        {"Wilson Evans Batten Catalogue", "WEB 12193"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.49016751),
        dec: Angle.Degrees(+29.63036497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -631.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -307.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45006"},
        {"Hipparcos Number", "HIP 30639"},
        {"Geneva Identification System", "GEN# +1.00045006"},
        {"Smithsonian Astrophysical Observation", "SAO 78364"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.58493652),
        dec: Angle.Degrees(+29.63067255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60970",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60970"},
    },
    visualMagnitude: 11.91,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.47891094),
        dec: Angle.Degrees(+36.44537349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9922",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9922"},
        {"Smithsonian Astrophysical Observation", "SAO 75155"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.92996510),
        dec: Angle.Degrees(+29.63312176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42371",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42371"},
        {"Smithsonian Astrophysical Observation", "SAO 80306"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.58650193),
        dec: Angle.Degrees(+29.63323708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -250.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83113",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83113"},
    },
    visualMagnitude: 11.69,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.75665979),
        dec: Angle.Degrees(+29.63473218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 205.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198198"},
        {"Hipparcos Number", "HIP 102629"},
        {"Smithsonian Astrophysical Observation", "SAO 89133"},
        {"Wilson Evans Batten Catalogue", "WEB 18601"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.94799248),
        dec: Angle.Degrees(+29.63796129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224016"},
        {"Hipparcos Number", "HIP 117870"},
        {"Smithsonian Astrophysical Observation", "SAO 91568"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.62370746),
        dec: Angle.Degrees(+29.63870532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203698"},
        {"Hipparcos Number", "HIP 105586"},
        {"Geneva Identification System", "GEN# +1.00203698"},
        {"Smithsonian Astrophysical Observation", "SAO 89665"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.78821836),
        dec: Angle.Degrees(+29.63965750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45207"},
        {"Hipparcos Number", "HIP 30738"},
        {"Geneva Identification System", "GEN# +1.00045207"},
        {"Smithsonian Astrophysical Observation", "SAO 78389"},
        {"Wilson Evans Batten Catalogue", "WEB 6129"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.87712855),
        dec: Angle.Degrees(+29.64218095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40484",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40484"},
        {"Smithsonian Astrophysical Observation", "SAO 80050"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.99518553),
        dec: Angle.Degrees(+29.64416750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 249103"},
        {"Hipparcos Number", "HIP 28015"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.88568945),
        dec: Angle.Degrees(+29.64429189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23946"},
        {"Hipparcos Number", "HIP 17937"},
        {"Geneva Identification System", "GEN# +1.00023946"},
        {"Smithsonian Astrophysical Observation", "SAO 76253"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.54148171),
        dec: Angle.Degrees(+29.64431801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86513"},
        {"Hipparcos Number", "HIP 48982"},
        {"Fundamental Katalog 5th Edition", "FK5 2803"},
        {"Geneva Identification System", "GEN# +1.00086513"},
        {"Smithsonian Astrophysical Observation", "SAO 81129"},
        {"Wilson Evans Batten Catalogue", "WEB 9090"},
    },
    visualMagnitude: 5.75,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.90115690),
        dec: Angle.Degrees(+29.64532453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198976"},
        {"Hipparcos Number", "HIP 103079"},
        {"Geneva Identification System", "GEN# +1.00198976"},
        {"Smithsonian Astrophysical Observation", "SAO 89241"},
        {"Wilson Evans Batten Catalogue", "WEB 18715"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.28071316),
        dec: Angle.Degrees(+29.64925374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27532"},
        {"Hipparcos Number", "HIP 20386"},
        {"Smithsonian Astrophysical Observation", "SAO 76566"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.48203051),
        dec: Angle.Degrees(+29.65034393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70858"},
        {"Hipparcos Number", "HIP 41283"},
        {"Geneva Identification System", "GEN# +1.00070858"},
        {"Smithsonian Astrophysical Observation", "SAO 80169"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.33124883),
        dec: Angle.Degrees(+29.65177538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161196"},
        {"Hipparcos Number", "HIP 86709"},
        {"Geneva Identification System", "GEN# +1.00161196"},
        {"Smithsonian Astrophysical Observation", "SAO 85354"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.75541667),
        dec: Angle.Degrees(+29.65294190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 333965"},
        {"Hipparcos Number", "HIP 99736"},
        {"Smithsonian Astrophysical Observation", "SAO 88389"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.55079976),
        dec: Angle.Degrees(+29.65304341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85310",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85310"},
        {"Smithsonian Astrophysical Observation", "SAO 85082"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.49728376),
        dec: Angle.Degrees(+29.65353502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78235"},
        {"Hipparcos Number", "HIP 44818"},
        {"Fundamental Katalog 5th Edition", "FK5 2719"},
        {"Geneva Identification System", "GEN# +1.00078235"},
        {"Smithsonian Astrophysical Observation", "SAO 80650"},
        {"Wilson Evans Batten Catalogue", "WEB 8564"},
    },
    visualMagnitude: 5.42,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.00029758),
        dec: Angle.Degrees(+29.65422729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18007",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2805 A"},
        {"Henry Draper", "HD 24052"},
        {"Hipparcos Number", "HIP 18007"},
        {"Geneva Identification System", "GEN# +1.00024052"},
        {"Smithsonian Astrophysical Observation", "SAO 76263"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.74468200),
        dec: Angle.Degrees(+29.65524121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68351"},
        {"Hipparcos Number", "HIP 40240"},
        {"Fundamental Katalog 5th Edition", "FK5 2641"},
        {"Geneva Identification System", "GEN# +1.00068351"},
        {"Renson", "Renson 18900"},
        {"Smithsonian Astrophysical Observation", "SAO 80016"},
        {"Wilson Evans Batten Catalogue", "WEB 7846"},
    },
    visualMagnitude: 5.62,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.28697716),
        dec: Angle.Degrees(+29.65658620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27336",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4371 AB"},
        {"Henry Draper", "HD 38491"},
        {"Hipparcos Number", "HIP 27336"},
        {"Geneva Identification System", "GEN# +1.00038491"},
        {"Smithsonian Astrophysical Observation", "SAO 77555"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.85352575),
        dec: Angle.Degrees(+29.65786475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6301"},
        {"Hipparcos Number", "HIP 5034"},
        {"Geneva Identification System", "GEN# +1.00006301"},
        {"Smithsonian Astrophysical Observation", "SAO 74471"},
        {"Wilson Evans Batten Catalogue", "WEB 1030"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.11487415),
        dec: Angle.Degrees(+29.65909865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13806",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13806"},
        {"Geneva Identification System", "GEN# +5.20250153"},
        {"Smithsonian Astrophysical Observation", "SAO 75658"},
        {"Wilson Evans Batten Catalogue", "WEB 2734"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.44394488),
        dec: Angle.Degrees(+29.66157319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 188.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160834"},
        {"Hipparcos Number", "HIP 86520"},
        {"Smithsonian Astrophysical Observation", "SAO 85308"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.21505795),
        dec: Angle.Degrees(+29.66501813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168694"},
        {"Hipparcos Number", "HIP 89827"},
        {"Geneva Identification System", "GEN# +1.00168694"},
        {"Smithsonian Astrophysical Observation", "SAO 85933"},
        {"Wilson Evans Batten Catalogue", "WEB 15331"},
    },
    visualMagnitude: 6.01,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.96696427),
        dec: Angle.Degrees(+29.66638344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15257"},
        {"Hipparcos Number", "HIP 11486"},
        {"Fundamental Katalog 5th Edition", "FK5 1068"},
        {"Geneva Identification System", "GEN# +1.00015257"},
        {"Smithsonian Astrophysical Observation", "SAO 75382"},
        {"Wilson Evans Batten Catalogue", "WEB 2400"},
    },
    visualMagnitude: 5.29,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.04162643),
        dec: Angle.Degrees(+29.66953828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218660"},
        {"Hipparcos Number", "HIP 114348"},
        {"Smithsonian Astrophysical Observation", "SAO 91049"},
        {"Wilson Evans Batten Catalogue", "WEB 20302"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.38524464),
        dec: Angle.Degrees(+29.66960189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74464"},
        {"Hipparcos Number", "HIP 42938"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.29191047),
        dec: Angle.Degrees(+29.67012797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166868"},
        {"Hipparcos Number", "HIP 89130"},
        {"Geneva Identification System", "GEN# +1.00166868"},
        {"Smithsonian Astrophysical Observation", "SAO 85810"},
        {"Wilson Evans Batten Catalogue", "WEB 15136"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.85220982),
        dec: Angle.Degrees(+29.67039251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51162",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51162"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.857,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.75606713),
        dec: Angle.Degrees(+29.67114552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23459"},
        {"Hipparcos Number", "HIP 17616"},
        {"Geneva Identification System", "GEN# +1.00023459"},
        {"Smithsonian Astrophysical Observation", "SAO 76171"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.60764624),
        dec: Angle.Degrees(+29.67214862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220501"},
        {"Hipparcos Number", "HIP 115520"},
        {"Smithsonian Astrophysical Observation", "SAO 91233"},
        {"Wilson Evans Batten Catalogue", "WEB 20450"},
    },
    visualMagnitude: 7.36,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.01381338),
        dec: Angle.Degrees(+29.67273057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150205"},
        {"Hipparcos Number", "HIP 81459"},
        {"Geneva Identification System", "GEN# +1.00150205"},
        {"Smithsonian Astrophysical Observation", "SAO 84499"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.56750747),
        dec: Angle.Degrees(+29.67295490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -192.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83571",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83571"},
        {"Geneva Identification System", "GEN# +0.02902933"},
        {"Smithsonian Astrophysical Observation", "SAO 84813"},
        {"Wilson Evans Batten Catalogue", "WEB 14131"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.19763080),
        dec: Angle.Degrees(+29.67505224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61655",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61655"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.58170129),
        dec: Angle.Degrees(+29.67527162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90441"},
        {"Hipparcos Number", "HIP 51158"},
        {"Geneva Identification System", "GEN# +1.00090441"},
        {"Smithsonian Astrophysical Observation", "SAO 81347"},
        {"Wilson Evans Batten Catalogue", "WEB 9350"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.74823328),
        dec: Angle.Degrees(+29.67531699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13047",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2126 A"},
        {"Henry Draper", "HD 17330"},
        {"Hipparcos Number", "HIP 13047"},
        {"Renson", "Renson 4370"},
        {"Smithsonian Astrophysical Observation", "SAO 75576"},
        {"Wilson Evans Batten Catalogue", "WEB 2634"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.91085513),
        dec: Angle.Degrees(+29.67854290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119496"},
        {"Hipparcos Number", "HIP 66935"},
        {"Geneva Identification System", "GEN# +1.00119496"},
        {"Wilson Evans Batten Catalogue", "WEB 11799"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.76548165),
        dec: Angle.Degrees(+29.67879992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104710"},
        {"Hipparcos Number", "HIP 58795"},
        {"Geneva Identification System", "GEN# +1.00104710"},
        {"Wilson Evans Batten Catalogue", "WEB 10476"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.88826481),
        dec: Angle.Degrees(+29.67916737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42394"},
        {"Hipparcos Number", "HIP 29407"},
        {"Smithsonian Astrophysical Observation", "SAO 78086"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.94975953),
        dec: Angle.Degrees(+29.68041339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87524",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10866 AB"},
        {"Henry Draper", "HD 163032"},
        {"Hipparcos Number", "HIP 87524"},
        {"Smithsonian Astrophysical Observation", "SAO 85504"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.21913674),
        dec: Angle.Degrees(+29.68046682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335163"},
        {"Hipparcos Number", "HIP 102625"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.93731190),
        dec: Angle.Degrees(+29.68124117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51358",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51358"},
        {"Geneva Identification System", "GEN# +0.03002022"},
        {"Wilson Evans Batten Catalogue", "WEB 9377"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.35303714),
        dec: Angle.Degrees(+29.68221072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23168"},
        {"Hipparcos Number", "HIP 17423"},
        {"Geneva Identification System", "GEN# +1.00023168"},
        {"Smithsonian Astrophysical Observation", "SAO 76111"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.99150399),
        dec: Angle.Degrees(+29.68300368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210183"},
        {"Hipparcos Number", "HIP 109257"},
        {"Geneva Identification System", "GEN# +1.00210183"},
        {"Smithsonian Astrophysical Observation", "SAO 90256"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.01948727),
        dec: Angle.Degrees(+29.68383031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89054"},
        {"Hipparcos Number", "HIP 50358"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.23924753),
        dec: Angle.Degrees(+29.68485713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196072"},
        {"Hipparcos Number", "HIP 101484"},
        {"Smithsonian Astrophysical Observation", "SAO 88845"},
    },
    visualMagnitude: 8.48,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.49063149),
        dec: Angle.Degrees(+29.68655494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15326"},
        {"Hipparcos Number", "HIP 11541"},
        {"Geneva Identification System", "GEN# +1.00015326"},
        {"Smithsonian Astrophysical Observation", "SAO 75390"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.19057421),
        dec: Angle.Degrees(+29.68703995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166181"},
        {"Hipparcos Number", "HIP 88848"},
        {"Geneva Identification System", "GEN# +1.00166181"},
        {"Smithsonian Astrophysical Observation", "SAO 85767"},
        {"Wilson Evans Batten Catalogue", "WEB 15062"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.06648494),
        dec: Angle.Degrees(+29.69120611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109730"},
        {"Hipparcos Number", "HIP 61559"},
        {"Geneva Identification System", "GEN# +1.00109730"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.20028420),
        dec: Angle.Degrees(+29.69213773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218455"},
        {"Hipparcos Number", "HIP 114221"},
        {"Smithsonian Astrophysical Observation", "SAO 91029"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.97149181),
        dec: Angle.Degrees(+29.69236452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104116",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104116"},
        {"Smithsonian Astrophysical Observation", "SAO 89449"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.40234000),
        dec: Angle.Degrees(+29.69439360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6525"},
        {"Hipparcos Number", "HIP 5212"},
        {"Geneva Identification System", "GEN# +1.00006525"},
        {"Smithsonian Astrophysical Observation", "SAO 74493"},
        {"Wilson Evans Batten Catalogue", "WEB 1092"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.66045120),
        dec: Angle.Degrees(+29.69612205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68172",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68172"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.34265959),
        dec: Angle.Degrees(+29.69819495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140592"},
        {"Hipparcos Number", "HIP 77014"},
        {"Geneva Identification System", "GEN# +1.00140592"},
        {"Smithsonian Astrophysical Observation", "SAO 83965"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.86290453),
        dec: Angle.Degrees(+29.69872474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129696"},
        {"Hipparcos Number", "HIP 71976"},
        {"Smithsonian Astrophysical Observation", "SAO 83485"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.81775685),
        dec: Angle.Degrees(+29.69886642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213024"},
        {"Hipparcos Number", "HIP 110897"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.02371868),
        dec: Angle.Degrees(+29.70208048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282642"},
        {"Hipparcos Number", "HIP 23048"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.38874088),
        dec: Angle.Degrees(+29.70306187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44766"},
        {"Hipparcos Number", "HIP 30518"},
        {"Geneva Identification System", "GEN# +1.00044766"},
        {"Smithsonian Astrophysical Observation", "SAO 78333"},
        {"Wilson Evans Batten Catalogue", "WEB 6078"},
    },
    visualMagnitude: 6.70,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.21980820),
        dec: Angle.Degrees(+29.70709412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1680",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1680"},
        {"Smithsonian Astrophysical Observation", "SAO 73908"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.25340620),
        dec: Angle.Degrees(+29.70762778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86151",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86151"},
        {"Smithsonian Astrophysical Observation", "SAO 85242"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.07994404),
        dec: Angle.Degrees(+29.70833439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18328"},
        {"Hipparcos Number", "HIP 13791"},
        {"Smithsonian Astrophysical Observation", "SAO 75656"},
        {"Wilson Evans Batten Catalogue", "WEB 2732"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.39454710),
        dec: Angle.Degrees(+29.70961117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25063"},
        {"Hipparcos Number", "HIP 18687"},
        {"Geneva Identification System", "GEN# +1.00025063"},
        {"Smithsonian Astrophysical Observation", "SAO 76377"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.03637966),
        dec: Angle.Degrees(+29.71084969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72052"},
        {"Hipparcos Number", "HIP 41841"},
        {"Geneva Identification System", "GEN# +1.00072052"},
        {"Wilson Evans Batten Catalogue", "WEB 8056"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.96550562),
        dec: Angle.Degrees(+29.71128125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214566"},
        {"Hipparcos Number", "HIP 111800"},
        {"Smithsonian Astrophysical Observation", "SAO 90671"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.67085317),
        dec: Angle.Degrees(+29.71145633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201912"},
        {"Hipparcos Number", "HIP 104643"},
        {"Geneva Identification System", "GEN# +1.00201912"},
        {"Smithsonian Astrophysical Observation", "SAO 89520"},
        {"Wilson Evans Batten Catalogue", "WEB 19038"},
    },
    visualMagnitude: 6.85,
    bvColour: -0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.95222081),
        dec: Angle.Degrees(+29.71171243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111765",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16132 AB"},
        {"Henry Draper", "HD 214525"},
        {"Hipparcos Number", "HIP 111765"},
        {"Smithsonian Astrophysical Observation", "SAO 90667"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.59715308),
        dec: Angle.Degrees(+29.71201465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95805",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95805"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.31080880),
        dec: Angle.Degrees(+29.71277276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79974",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79974"},
        {"Wilson Evans Batten Catalogue", "WEB 13536"},
    },
    visualMagnitude: 11.43,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.85778118),
        dec: Angle.Degrees(+29.71329729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47730"},
        {"Hipparcos Number", "HIP 32014"},
        {"Smithsonian Astrophysical Observation", "SAO 78633"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.32712797),
        dec: Angle.Degrees(+29.71367643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11762"},
        {"Hipparcos Number", "HIP 9002"},
        {"Smithsonian Astrophysical Observation", "SAO 75029"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.97861748),
        dec: Angle.Degrees(+29.71392745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 332683"},
        {"Hipparcos Number", "HIP 97327"},
        {"Smithsonian Astrophysical Observation", "SAO 87711"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.70078938),
        dec: Angle.Degrees(+29.71509952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89185",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89185"},
        {"Smithsonian Astrophysical Observation", "SAO 85819"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.02038177),
        dec: Angle.Degrees(+29.71611257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61956",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61956"},
        {"Geneva Identification System", "GEN# +0.03002314J"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.45917124),
        dec: Angle.Degrees(+29.71983287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 333533"},
        {"Hipparcos Number", "HIP 99092"},
        {"Smithsonian Astrophysical Observation", "SAO 88214"},
        {"Wilson Evans Batten Catalogue", "WEB 17626"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.75617149),
        dec: Angle.Degrees(+29.72076882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87497",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87497"},
        {"Smithsonian Astrophysical Observation", "SAO 85501"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.16538649),
        dec: Angle.Degrees(+29.72119684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101803",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14079 A"},
        {"Henry Draper", "HD 196655"},
        {"Hipparcos Number", "HIP 101803"},
        {"Renson", "Renson 54880"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.45909000),
        dec: Angle.Degrees(+29.72165434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104379",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104379"},
        {"Smithsonian Astrophysical Observation", "SAO 89486"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.18258896),
        dec: Angle.Degrees(+29.72185659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 369",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 369"},
        {"Smithsonian Astrophysical Observation", "SAO 73726"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.15890684),
        dec: Angle.Degrees(+29.72229656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335054"},
        {"Hipparcos Number", "HIP 102382"},
    },
    visualMagnitude: 10.48,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.17955015),
        dec: Angle.Degrees(+29.72230384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 253267"},
        {"Hipparcos Number", "HIP 29500"},
        {"Smithsonian Astrophysical Observation", "SAO 78105"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.23716494),
        dec: Angle.Degrees(+29.72338426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84935",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84935"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.38156973),
        dec: Angle.Degrees(+29.72581096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246417"},
        {"Hipparcos Number", "HIP 26875"},
        {"Geneva Identification System", "GEN# +1.00246417"},
        {"Smithsonian Astrophysical Observation", "SAO 77424"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.58611407),
        dec: Angle.Degrees(+29.72633272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38749"},
        {"Hipparcos Number", "HIP 27492"},
        {"Geneva Identification System", "GEN# +1.00038749"},
        {"Renson", "Renson 10424"},
        {"Smithsonian Astrophysical Observation", "SAO 77594"},
        {"Wilson Evans Batten Catalogue", "WEB 5399"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.32208450),
        dec: Angle.Degrees(+29.72685682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193553"},
        {"Hipparcos Number", "HIP 100242"},
        {"Celescope Catalog", "CEL 5024"},
        {"Geneva Identification System", "GEN# +1.00193553"},
        {"Renson", "Renson 54027"},
        {"Smithsonian Astrophysical Observation", "SAO 88528"},
    },
    visualMagnitude: 6.78,
    bvColour: -0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.95755095),
        dec: Angle.Degrees(+29.72685772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90717"},
        {"Hipparcos Number", "HIP 51325"},
        {"Geneva Identification System", "GEN# +1.00090717"},
        {"Smithsonian Astrophysical Observation", "SAO 81371"},
        {"Wilson Evans Batten Catalogue", "WEB 9372"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.25660654),
        dec: Angle.Degrees(+29.72759635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282383"},
        {"Hipparcos Number", "HIP 21804"},
        {"Smithsonian Astrophysical Observation", "SAO 76701"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.26236665),
        dec: Angle.Degrees(+29.72801510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46746"},
        {"Hipparcos Number", "HIP 31559"},
        {"Geneva Identification System", "GEN# +1.00046746"},
        {"Smithsonian Astrophysical Observation", "SAO 78538"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.08726443),
        dec: Angle.Degrees(+29.72807508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112132",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112132"},
        {"Smithsonian Astrophysical Observation", "SAO 90728"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.70677349),
        dec: Angle.Degrees(+29.72853650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35034"},
        {"Hipparcos Number", "HIP 25157"},
        {"Celescope Catalog", "CEL 654"},
        {"Geneva Identification System", "GEN# +1.00035034"},
        {"Smithsonian Astrophysical Observation", "SAO 77136"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.75069891),
        dec: Angle.Degrees(+29.72906680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33413"},
        {"Hipparcos Number", "HIP 24160"},
        {"Celescope Catalog", "CEL 557"},
        {"Smithsonian Astrophysical Observation", "SAO 77017"},
    },
    visualMagnitude: 7.11,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.82559775),
        dec: Angle.Degrees(+29.72999918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 667",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 667"},
        {"Smithsonian Astrophysical Observation", "SAO 73763"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.05695057),
        dec: Angle.Degrees(+29.73233165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91163"},
        {"Hipparcos Number", "HIP 51574"},
        {"Geneva Identification System", "GEN# +1.00091163"},
        {"Wilson Evans Batten Catalogue", "WEB 9408"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.00568793),
        dec: Angle.Degrees(+29.73265682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52101"},
        {"Hipparcos Number", "HIP 33808"},
        {"Geneva Identification System", "GEN# +1.00052101"},
        {"Smithsonian Astrophysical Observation", "SAO 78971"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.28600685),
        dec: Angle.Degrees(+29.73590167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7299"},
        {"Hipparcos Number", "HIP 5717"},
        {"Smithsonian Astrophysical Observation", "SAO 74566"},
        {"Wilson Evans Batten Catalogue", "WEB 1301"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.38656537),
        dec: Angle.Degrees(+29.73631681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15305"},
        {"Hipparcos Number", "HIP 11526"},
        {"Geneva Identification System", "GEN# +1.00015305"},
        {"Smithsonian Astrophysical Observation", "SAO 75389"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.15073005),
        dec: Angle.Degrees(+29.73667192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 333826"},
        {"Hipparcos Number", "HIP 99598"},
        {"Geneva Identification System", "GEN# +1.00333826"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.18722800),
        dec: Angle.Degrees(+29.73675321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101798",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14079 BC"},
        {"Hipparcos Number", "HIP 101798"},
    },
    visualMagnitude: 9.94,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.45373103),
        dec: Angle.Degrees(+29.73690212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66149",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8943"},
        {"Aitken 2", "ADS 8943 AB"},
        {"Henry Draper", "HD 117998"},
        {"Hipparcos Number", "HIP 66149"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.39084280),
        dec: Angle.Degrees(+29.73787513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68313",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68313"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.75203264),
        dec: Angle.Degrees(+29.73828672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -177.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12972"},
        {"Hipparcos Number", "HIP 9914"},
        {"Smithsonian Astrophysical Observation", "SAO 75154"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.90592205),
        dec: Angle.Degrees(+29.74150174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171550"},
        {"Hipparcos Number", "HIP 91042"},
        {"Smithsonian Astrophysical Observation", "SAO 86204"},
        {"Wilson Evans Batten Catalogue", "WEB 15624"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.58204710),
        dec: Angle.Degrees(+29.74197876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111390",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16059 A"},
        {"Henry Draper", "HD 213857"},
        {"Hipparcos Number", "HIP 111390"},
        {"Geneva Identification System", "GEN# +1.00213857"},
        {"Smithsonian Astrophysical Observation", "SAO 90603"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.50183133),
        dec: Angle.Degrees(+29.74312401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203048"},
        {"Hipparcos Number", "HIP 105240"},
        {"Geneva Identification System", "GEN# +1.00203048"},
        {"Smithsonian Astrophysical Observation", "SAO 89613"},
    },
    visualMagnitude: 7.30,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.75742813),
        dec: Angle.Degrees(+29.74314808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136527"},
        {"Hipparcos Number", "HIP 75060"},
        {"Smithsonian Astrophysical Observation", "SAO 83772"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.08172657),
        dec: Angle.Degrees(+29.74338869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128167"},
        {"Hipparcos Number", "HIP 71284"},
        {"Fundamental Katalog 5th Edition", "FK5 1380"},
        {"Geneva Identification System", "GEN# +1.00128167"},
        {"Smithsonian Astrophysical Observation", "SAO 83416"},
        {"Wilson Evans Batten Catalogue", "WEB 12315"},
    },
    visualMagnitude: 4.47,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.66954381),
        dec: Angle.Degrees(+29.74480735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 188.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 132.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24000"},
        {"Hipparcos Number", "HIP 17971"},
        {"Geneva Identification System", "GEN# +1.00024000"},
        {"Smithsonian Astrophysical Observation", "SAO 76258"},
        {"Wilson Evans Batten Catalogue", "WEB 3462"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.63340559),
        dec: Angle.Degrees(+29.74492442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149803"},
        {"Hipparcos Number", "HIP 81267"},
        {"Geneva Identification System", "GEN# +1.00149803"},
        {"Smithsonian Astrophysical Observation", "SAO 84474"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.97614218),
        dec: Angle.Degrees(+29.74540738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205618"},
        {"Hipparcos Number", "HIP 106620"},
        {"Geneva Identification System", "GEN# +1.00205618"},
        {"Smithsonian Astrophysical Observation", "SAO 89826"},
    },
    visualMagnitude: 8.15,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.93532062),
        dec: Angle.Degrees(+29.74555221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96709",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12759 A"},
        {"Henry Draper", "HD 185756"},
        {"Hipparcos Number", "HIP 96709"},
        {"Celescope Catalog", "CEL 4810"},
        {"Geneva Identification System", "GEN# +1.00185756"},
        {"Smithsonian Astrophysical Observation", "SAO 87522"},
    },
    visualMagnitude: 7.51,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.89666250),
        dec: Angle.Degrees(+29.74874908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64634",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64634"},
    },
    visualMagnitude: 11.00,
    bvColour: 0.802,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.72075686),
        dec: Angle.Degrees(+29.74908762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87358"},
        {"Hipparcos Number", "HIP 49398"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.27295611),
        dec: Angle.Degrees(+29.74938060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2355",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 409 A"},
        {"Henry Draper", "HD 2628"},
        {"Hipparcos Number", "HIP 2355"},
        {"Geneva Identification System", "GEN# +1.00002628"},
        {"Renson", "Renson 620"},
        {"Smithsonian Astrophysical Observation", "SAO 74041"},
        {"Wilson Evans Batten Catalogue", "WEB 432"},
    },
    visualMagnitude: 5.20,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.53056566),
        dec: Angle.Degrees(+29.75169567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246706"},
        {"Hipparcos Number", "HIP 26993"},
        {"Geneva Identification System", "GEN# +1.00246706"},
        {"Renson", "Renson 10232"},
        {"Smithsonian Astrophysical Observation", "SAO 77454"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.90344034),
        dec: Angle.Degrees(+29.75281332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56794",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56794"},
        {"Smithsonian Astrophysical Observation", "SAO 62636"},
        {"Wilson Evans Batten Catalogue", "WEB 10225"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.65252265),
        dec: Angle.Degrees(+29.75645216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104304",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104304"},
        {"Geneva Identification System", "GEN# +0.02904321"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.95117851),
        dec: Angle.Degrees(+29.75678655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -247.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99207"},
        {"Hipparcos Number", "HIP 55741"},
        {"Geneva Identification System", "GEN# +1.00099207"},
        {"Smithsonian Astrophysical Observation", "SAO 62545"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.31916136),
        dec: Angle.Degrees(+29.75874493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194542"},
        {"Hipparcos Number", "HIP 100722"},
        {"Smithsonian Astrophysical Observation", "SAO 88655"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.30844167),
        dec: Angle.Degrees(+29.75892578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335424"},
        {"Hipparcos Number", "HIP 103683"},
        {"Smithsonian Astrophysical Observation", "SAO 89364"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.14575079),
        dec: Angle.Degrees(+29.76004032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85913",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85913"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.34614825),
        dec: Angle.Degrees(+29.76117830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199291"},
        {"Hipparcos Number", "HIP 103275"},
        {"Smithsonian Astrophysical Observation", "SAO 89283"},
        {"Wilson Evans Batten Catalogue", "WEB 18768"},
    },
    visualMagnitude: 8.69,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.84273660),
        dec: Angle.Degrees(+29.76202759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186717"},
        {"Hipparcos Number", "HIP 97169"},
        {"Smithsonian Astrophysical Observation", "SAO 87661"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.24791121),
        dec: Angle.Degrees(+29.76210383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81932",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81932"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.02023062),
        dec: Angle.Degrees(+29.76214752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159608"},
        {"Hipparcos Number", "HIP 85978"},
        {"Fundamental Katalog 5th Edition", "FK5 5543"},
        {"Smithsonian Astrophysical Observation", "SAO 85217"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.58970550),
        dec: Angle.Degrees(+29.76290853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32684"},
        {"Hipparcos Number", "HIP 23744"},
        {"Geneva Identification System", "GEN# +1.00032684"},
        {"Smithsonian Astrophysical Observation", "SAO 76958"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.55366887),
        dec: Angle.Degrees(+29.76502064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27783",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4464 ABP"},
        {"Henry Draper", "HD 39274"},
        {"Hipparcos Number", "HIP 27783"},
        {"Smithsonian Astrophysical Observation", "SAO 77659"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.19300620),
        dec: Angle.Degrees(+29.76805406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27786",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4464 C"},
        {"Henry Draper", "HD 39275"},
        {"Hipparcos Number", "HIP 27786"},
        {"Smithsonian Astrophysical Observation", "SAO 77660"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.19744774),
        dec: Angle.Degrees(+29.77035924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222888"},
        {"Hipparcos Number", "HIP 117113"},
        {"Fundamental Katalog 5th Edition", "FK5 6104"},
        {"Smithsonian Astrophysical Observation", "SAO 91460"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.13899116),
        dec: Angle.Degrees(+29.77093633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8815"},
        {"Hipparcos Number", "HIP 6786"},
        {"Geneva Identification System", "GEN# +1.00008815"},
        {"Smithsonian Astrophysical Observation", "SAO 74732"},
        {"Wilson Evans Batten Catalogue", "WEB 1480"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.83518136),
        dec: Angle.Degrees(+29.77109059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219291"},
        {"Hipparcos Number", "HIP 114725"},
        {"Geneva Identification System", "GEN# +1.00219291"},
        {"Smithsonian Astrophysical Observation", "SAO 91111"},
        {"Wilson Evans Batten Catalogue", "WEB 20342"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.59050295),
        dec: Angle.Degrees(+29.77185000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51834"},
        {"Hipparcos Number", "HIP 33701"},
        {"Geneva Identification System", "GEN# +1.00051834"},
        {"Smithsonian Astrophysical Observation", "SAO 78954"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.02925261),
        dec: Angle.Degrees(+29.77213423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30378"},
        {"Hipparcos Number", "HIP 22314"},
        {"Fundamental Katalog 5th Edition", "FK5 4436"},
        {"Geneva Identification System", "GEN# +1.00030378"},
        {"Smithsonian Astrophysical Observation", "SAO 76762"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.09474836),
        dec: Angle.Degrees(+29.77306588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207674"},
        {"Hipparcos Number", "HIP 107776"},
        {"Smithsonian Astrophysical Observation", "SAO 90043"},
    },
    visualMagnitude: 8.28,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.50952864),
        dec: Angle.Degrees(+29.77442850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63988",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63988"},
        {"Geneva Identification System", "GEN# +0.03002366"},
    },
    visualMagnitude: 11.51,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.69084845),
        dec: Angle.Degrees(+29.77549555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110950"},
        {"Hipparcos Number", "HIP 62246"},
        {"Geneva Identification System", "GEN# +1.00110950"},
        {"Smithsonian Astrophysical Observation", "SAO 63178"},
        {"Wilson Evans Batten Catalogue", "WEB 11058"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.35597610),
        dec: Angle.Degrees(+29.77596803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118407"},
        {"Hipparcos Number", "HIP 66368"},
        {"Geneva Identification System", "GEN# +1.00118407"},
        {"Smithsonian Astrophysical Observation", "SAO 63635"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.06397949),
        dec: Angle.Degrees(+29.77622733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 99.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5381"},
        {"Hipparcos Number", "HIP 4378"},
        {"Smithsonian Astrophysical Observation", "SAO 74374"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.02077421),
        dec: Angle.Degrees(+29.78017836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60618"},
        {"Hipparcos Number", "HIP 37035"},
        {"Geneva Identification System", "GEN# +1.00060618"},
        {"Smithsonian Astrophysical Observation", "SAO 79542"},
        {"Wilson Evans Batten Catalogue", "WEB 7345"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.16247451),
        dec: Angle.Degrees(+29.78122420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43646"},
        {"Hipparcos Number", "HIP 29975"},
        {"Geneva Identification System", "GEN# +1.00043646"},
        {"Smithsonian Astrophysical Observation", "SAO 78201"},
        {"Wilson Evans Batten Catalogue", "WEB 5946"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.65734183),
        dec: Angle.Degrees(+29.78152955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96315",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12633 AB"},
        {"Hipparcos Number", "HIP 96315"},
        {"Smithsonian Astrophysical Observation", "SAO 87392"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.75342325),
        dec: Angle.Degrees(+29.78371043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90190",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90190"},
    },
    visualMagnitude: 11.69,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.05302469),
        dec: Angle.Degrees(+29.78416756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85958"},
        {"Hipparcos Number", "HIP 48713"},
        {"Geneva Identification System", "GEN# +1.00085958"},
        {"Smithsonian Astrophysical Observation", "SAO 61765"},
        {"Wilson Evans Batten Catalogue", "WEB 9057"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.03587048),
        dec: Angle.Degrees(+29.78860484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33169"},
        {"Hipparcos Number", "HIP 24005"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.41197085),
        dec: Angle.Degrees(+29.79042730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45432",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45432"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.88819287),
        dec: Angle.Degrees(+29.79253238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59339",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59339"},
        {"Smithsonian Astrophysical Observation", "SAO 62874"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.58942755),
        dec: Angle.Degrees(+29.79325500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213177"},
        {"Hipparcos Number", "HIP 110975"},
        {"Geneva Identification System", "GEN# +1.00213177"},
        {"Smithsonian Astrophysical Observation", "SAO 90542"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.26389024),
        dec: Angle.Degrees(+29.79545928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16580"},
        {"Hipparcos Number", "HIP 12452"},
        {"Smithsonian Astrophysical Observation", "SAO 75506"},
        {"Wilson Evans Batten Catalogue", "WEB 2545"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.07714407),
        dec: Angle.Degrees(+29.79643061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 334461"},
        {"Hipparcos Number", "HIP 101071"},
        {"Smithsonian Astrophysical Observation", "SAO 88748"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.33874117),
        dec: Angle.Degrees(+29.79834077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33185"},
        {"Hipparcos Number", "HIP 24016"},
        {"Geneva Identification System", "GEN# +1.00033185"},
        {"Smithsonian Astrophysical Observation", "SAO 76989"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.43188452),
        dec: Angle.Degrees(+29.79863873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117729"},
        {"Hipparcos Number", "HIP 65985"},
        {"Geneva Identification System", "GEN# +1.00117729"},
        {"Smithsonian Astrophysical Observation", "SAO 63584"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.93550104),
        dec: Angle.Degrees(+29.79870949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16170",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16170"},
        {"Geneva Identification System", "GEN# +0.02900565"},
        {"Smithsonian Astrophysical Observation", "SAO 75942"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.08706435),
        dec: Angle.Degrees(+29.79926132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112861",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112861"},
        {"Smithsonian Astrophysical Observation", "SAO 90831"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.83535465),
        dec: Angle.Degrees(+29.79944505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56662",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56662"},
        {"Geneva Identification System", "GEN# +6.10060140"},
    },
    visualMagnitude: 12.49,
    bvColour: -0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.27168180),
        dec: Angle.Degrees(+29.79955309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95137",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95137"},
        {"Smithsonian Astrophysical Observation", "SAO 87110"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.34120048),
        dec: Angle.Degrees(+29.80020583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93960",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12071 AB"},
        {"Henry Draper", "HD 178592"},
        {"Hipparcos Number", "HIP 93960"},
        {"Celescope Catalog", "CEL 4704"},
        {"Smithsonian Astrophysical Observation", "SAO 86844"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.97382694),
        dec: Angle.Degrees(+29.80068112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335238"},
        {"Hipparcos Number", "HIP 102896"},
        {"Geneva Identification System", "GEN# +1.00335238"},
        {"Renson", "Renson 55280"},
        {"Smithsonian Astrophysical Observation", "SAO 89203"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.68194132),
        dec: Angle.Degrees(+29.80335346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13943"},
        {"Hipparcos Number", "HIP 10598"},
        {"Smithsonian Astrophysical Observation", "SAO 75249"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.11232207),
        dec: Angle.Degrees(+29.80497794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113785",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113785"},
        {"Smithsonian Astrophysical Observation", "SAO 90966"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.64437938),
        dec: Angle.Degrees(+29.80505598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102033",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14149 AB"},
        {"Henry Draper", "HD 197120"},
        {"Hipparcos Number", "HIP 102033"},
        {"Geneva Identification System", "GEN# +1.00197120J"},
        {"Smithsonian Astrophysical Observation", "SAO 88997"},
        {"Wilson Evans Batten Catalogue", "WEB 18448"},
    },
    visualMagnitude: 6.02,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.15110122),
        dec: Angle.Degrees(+29.80544750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152173"},
        {"Hipparcos Number", "HIP 82422"},
        {"Fundamental Katalog 5th Edition", "FK5 3339"},
        {"Geneva Identification System", "GEN# +1.00152173"},
        {"Smithsonian Astrophysical Observation", "SAO 84641"},
        {"Wilson Evans Batten Catalogue", "WEB 13914"},
    },
    visualMagnitude: 5.73,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.66234241),
        dec: Angle.Degrees(+29.80654506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281920"},
        {"Hipparcos Number", "HIP 20076"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.56998035),
        dec: Angle.Degrees(+29.80703897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10140",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10140"},
        {"Cincinnati Publication", "Ci 18 276"},
        {"Geneva Identification System", "GEN# +0.02900366"},
        {"Smithsonian Astrophysical Observation", "SAO 75179"},
        {"Wilson Evans Batten Catalogue", "WEB 2119"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.60138751),
        dec: Angle.Degrees(+29.80722074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 290.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -265.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173213"},
        {"Hipparcos Number", "HIP 91789"},
        {"Smithsonian Astrophysical Observation", "SAO 86358"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.75471312),
        dec: Angle.Degrees(+29.80787165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9067",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9067"},
        {"Wilson Evans Batten Catalogue", "WEB 1902"},
    },
    visualMagnitude: 11.62,
    bvColour: 1.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.18260755),
        dec: Angle.Degrees(+29.81073081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10892",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1780 AB"},
        {"Henry Draper", "HD 14394"},
        {"Hipparcos Number", "HIP 10892"},
        {"Smithsonian Astrophysical Observation", "SAO 75289"},
        {"Wilson Evans Batten Catalogue", "WEB 2296"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.04340529),
        dec: Angle.Degrees(+29.81177152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87644",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10880 AB"},
        {"Henry Draper", "HD 163284"},
        {"Hipparcos Number", "HIP 87644"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.53355208),
        dec: Angle.Degrees(+29.81246867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57784",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57784"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.73703786),
        dec: Angle.Degrees(+29.81307253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203733"},
        {"Hipparcos Number", "HIP 105596"},
        {"Geneva Identification System", "GEN# +1.00203733"},
        {"Smithsonian Astrophysical Observation", "SAO 89667"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.82820213),
        dec: Angle.Degrees(+29.81319484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208906"},
        {"Hipparcos Number", "HIP 108490"},
        {"Cincinnati Publication", "Ci 20 1326"},
        {"Geneva Identification System", "GEN# +1.00208906"},
        {"Smithsonian Astrophysical Observation", "SAO 90147"},
        {"Wilson Evans Batten Catalogue", "WEB 19535"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.67115015),
        dec: Angle.Degrees(+29.81356873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -361.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -386.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92419",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11741 A"},
        {"Henry Draper", "HD 174586"},
        {"Hipparcos Number", "HIP 92419"},
        {"Geneva Identification System", "GEN# +1.00174586"},
        {"Smithsonian Astrophysical Observation", "SAO 86484"},
    },
    visualMagnitude: 7.61,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.51367350),
        dec: Angle.Degrees(+29.81527475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108545"},
        {"Hipparcos Number", "HIP 60826"},
        {"Geneva Identification System", "GEN# +1.00108545J"},
        {"Smithsonian Astrophysical Observation", "SAO 63011"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.01540100),
        dec: Angle.Degrees(+29.81770061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64539",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8826 AB"},
        {"Henry Draper", "HD 114976"},
        {"Hipparcos Number", "HIP 64539"},
        {"Geneva Identification System", "GEN# +1.00114976J"},
        {"Smithsonian Astrophysical Observation", "SAO 63416"},
        {"Wilson Evans Batten Catalogue", "WEB 11414"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.42468685),
        dec: Angle.Degrees(+29.81780856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15746",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2499 B"},
        {"Hipparcos Number", "HIP 15746"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.71912213),
        dec: Angle.Degrees(+29.81788207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166093"},
        {"Hipparcos Number", "HIP 88821"},
        {"Geneva Identification System", "GEN# +1.00166093"},
        {"Smithsonian Astrophysical Observation", "SAO 85760"},
        {"Wilson Evans Batten Catalogue", "WEB 15055"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.96662045),
        dec: Angle.Degrees(+29.81802946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15744",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2499 A"},
        {"Henry Draper", "HD 20873"},
        {"Hipparcos Number", "HIP 15744"},
        {"Renson", "Renson 5197"},
        {"Wilson Evans Batten Catalogue", "WEB 3012"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.71584258),
        dec: Angle.Degrees(+29.81845928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89276"},
        {"Hipparcos Number", "HIP 50484"},
        {"Geneva Identification System", "GEN# +1.00089276"},
        {"Smithsonian Astrophysical Observation", "SAO 61978"},
        {"Wilson Evans Batten Catalogue", "WEB 9262"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.63443201),
        dec: Angle.Degrees(+29.81938007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103944"},
        {"Hipparcos Number", "HIP 58373"},
        {"Smithsonian Astrophysical Observation", "SAO 62775"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.54810862),
        dec: Angle.Degrees(+29.81976670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80131"},
        {"Hipparcos Number", "HIP 45686"},
        {"Geneva Identification System", "GEN# +1.00080131"},
        {"Smithsonian Astrophysical Observation", "SAO 61393"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.70665662),
        dec: Angle.Degrees(+29.82063610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189706"},
        {"Hipparcos Number", "HIP 98467"},
        {"Celescope Catalog", "CEL 4903"},
        {"Geneva Identification System", "GEN# +1.00189706"},
        {"Smithsonian Astrophysical Observation", "SAO 88051"},
        {"Wilson Evans Batten Catalogue", "WEB 17386"},
    },
    visualMagnitude: 7.78,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.08015131),
        dec: Angle.Degrees(+29.82151736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23244"},
        {"Hipparcos Number", "HIP 17474"},
        {"Geneva Identification System", "GEN# +1.00023244"},
        {"Smithsonian Astrophysical Observation", "SAO 76123"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.16955551),
        dec: Angle.Degrees(+29.82248167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7865"},
        {"Hipparcos Number", "HIP 6128"},
        {"Smithsonian Astrophysical Observation", "SAO 74627"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.66830653),
        dec: Angle.Degrees(+29.82307462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335300"},
        {"Hipparcos Number", "HIP 103214"},
    },
    visualMagnitude: 10.28,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.66816361),
        dec: Angle.Degrees(+29.82328012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189087"},
        {"Hipparcos Number", "HIP 98192"},
        {"Cincinnati Publication", "Ci 18 2605"},
        {"Geneva Identification System", "GEN# +1.00189087"},
        {"Smithsonian Astrophysical Observation", "SAO 87976"},
        {"Wilson Evans Batten Catalogue", "WEB 17311"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.30561123),
        dec: Angle.Degrees(+29.82344076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 236.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99593"},
        {"Hipparcos Number", "HIP 55927"},
        {"Geneva Identification System", "GEN# +1.00099593"},
        {"Smithsonian Astrophysical Observation", "SAO 62563"},
        {"Wilson Evans Batten Catalogue", "WEB 10042"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.92718476),
        dec: Angle.Degrees(+29.82382968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57470"},
        {"Hipparcos Number", "HIP 35759"},
        {"Smithsonian Astrophysical Observation", "SAO 79331"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.64108268),
        dec: Angle.Degrees(+29.82458319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335352"},
        {"Hipparcos Number", "HIP 103449"},
        {"Smithsonian Astrophysical Observation", "SAO 89318"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.37552034),
        dec: Angle.Degrees(+29.82526029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50481"},
        {"Hipparcos Number", "HIP 33219"},
        {"Smithsonian Astrophysical Observation", "SAO 78854"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.69567148),
        dec: Angle.Degrees(+29.82733344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116166",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116166"},
        {"Smithsonian Astrophysical Observation", "SAO 91328"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.05888330),
        dec: Angle.Degrees(+29.82781575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45784"},
        {"Hipparcos Number", "HIP 31036"},
        {"Geneva Identification System", "GEN# +1.00045784"},
        {"Smithsonian Astrophysical Observation", "SAO 78450"},
        {"Wilson Evans Batten Catalogue", "WEB 6179"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.69011906),
        dec: Angle.Degrees(+29.82857916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169981"},
        {"Hipparcos Number", "HIP 90342"},
        {"Fundamental Katalog 5th Edition", "FK5 1479"},
        {"Geneva Identification System", "GEN# +1.00169981"},
        {"Smithsonian Astrophysical Observation", "SAO 86043"},
        {"Wilson Evans Batten Catalogue", "WEB 15465"},
    },
    visualMagnitude: 5.81,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.49488169),
        dec: Angle.Degrees(+29.82898959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26397"},
        {"Hipparcos Number", "HIP 19572"},
        {"Geneva Identification System", "GEN# +5.20250138"},
        {"Smithsonian Astrophysical Observation", "SAO 76489"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.871,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.90820859),
        dec: Angle.Degrees(+29.83044049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282539"},
        {"Hipparcos Number", "HIP 22571"},
        {"Smithsonian Astrophysical Observation", "SAO 76786"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.86581247),
        dec: Angle.Degrees(+29.83173036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19785"},
        {"Hipparcos Number", "HIP 14867"},
        {"Smithsonian Astrophysical Observation", "SAO 75785"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.98897020),
        dec: Angle.Degrees(+29.83177812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180916"},
        {"Hipparcos Number", "HIP 94790"},
        {"Smithsonian Astrophysical Observation", "SAO 87029"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.30622639),
        dec: Angle.Degrees(+29.83273418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37386"},
        {"Hipparcos Number", "HIP 26619"},
        {"Geneva Identification System", "GEN# +1.00037386"},
        {"Smithsonian Astrophysical Observation", "SAO 77356"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.87416136),
        dec: Angle.Degrees(+29.83350171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61953"},
        {"Hipparcos Number", "HIP 37602"},
        {"Smithsonian Astrophysical Observation", "SAO 79630"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.73145590),
        dec: Angle.Degrees(+29.83427103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53927"},
        {"Hipparcos Number", "HIP 34414"},
        {"Cincinnati Publication", "Ci 18 854"},
        {"Geneva Identification System", "GEN# +1.00053927"},
        {"Smithsonian Astrophysical Observation", "SAO 79090"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.01810055),
        dec: Angle.Degrees(+29.83521044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -157.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -295.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 333"},
        {"Hipparcos Number", "HIP 650"},
        {"Geneva Identification System", "GEN# +1.00000333"},
        {"Smithsonian Astrophysical Observation", "SAO 73760"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.00316528),
        dec: Angle.Degrees(+29.83750636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57362"},
        {"Hipparcos Number", "HIP 35713"},
        {"Geneva Identification System", "GEN# +1.00057362"},
        {"Smithsonian Astrophysical Observation", "SAO 79327"},
        {"Wilson Evans Batten Catalogue", "WEB 7115"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.51764490),
        dec: Angle.Degrees(+29.83768938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 263349"},
        {"Hipparcos Number", "HIP 32468"},
        {"Smithsonian Astrophysical Observation", "SAO 78723"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.63954330),
        dec: Angle.Degrees(+29.84023078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8496"},
        {"Hipparcos Number", "HIP 6573"},
        {"Smithsonian Astrophysical Observation", "SAO 74693"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.11232240),
        dec: Angle.Degrees(+29.84171716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31648"},
        {"Hipparcos Number", "HIP 23143"},
        {"Geneva Identification System", "GEN# +1.00031648"},
        {"Smithsonian Astrophysical Observation", "SAO 76866"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.69275950),
        dec: Angle.Degrees(+29.84366860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69961",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69961"},
        {"Geneva Identification System", "GEN# +0.03002505"},
        {"Smithsonian Astrophysical Observation", "SAO 64061"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.74077131),
        dec: Angle.Degrees(+29.84525362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2064"},
        {"Hipparcos Number", "HIP 1980"},
        {"Geneva Identification System", "GEN# +1.00002064"},
        {"Smithsonian Astrophysical Observation", "SAO 73962"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.26985724),
        dec: Angle.Degrees(+29.84722204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14155"},
        {"Hipparcos Number", "HIP 10731"},
        {"Smithsonian Astrophysical Observation", "SAO 75270"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.52818334),
        dec: Angle.Degrees(+29.84732520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35064",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35064"},
        {"Smithsonian Astrophysical Observation", "SAO 79204"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.76239393),
        dec: Angle.Degrees(+29.84960928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143807"},
        {"Hipparcos Number", "HIP 78493"},
        {"Fundamental Katalog 5th Edition", "FK5 3264"},
        {"Geneva Identification System", "GEN# +1.00143807"},
        {"Renson", "Renson 40740"},
        {"Smithsonian Astrophysical Observation", "SAO 84152"},
        {"Wilson Evans Batten Catalogue", "WEB 13271"},
    },
    visualMagnitude: 4.98,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.36079431),
        dec: Angle.Degrees(+29.85107821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64681"},
        {"Hipparcos Number", "HIP 38778"},
        {"Fundamental Katalog 5th Edition", "FK5 4713"},
        {"Smithsonian Astrophysical Observation", "SAO 79806"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.06463927),
        dec: Angle.Degrees(+29.85206618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34677",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34677"},
        {"Smithsonian Astrophysical Observation", "SAO 79135"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.71733829),
        dec: Angle.Degrees(+29.85356592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75637"},
        {"Hipparcos Number", "HIP 43549"},
        {"Smithsonian Astrophysical Observation", "SAO 61097"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.04034239),
        dec: Angle.Degrees(+29.85374049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282339"},
        {"Hipparcos Number", "HIP 21373"},
        {"Smithsonian Astrophysical Observation", "SAO 76663"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.80066919),
        dec: Angle.Degrees(+29.85496112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205953"},
        {"Hipparcos Number", "HIP 106814"},
        {"Smithsonian Astrophysical Observation", "SAO 89862"},
    },
    visualMagnitude: 8.15,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.50317256),
        dec: Angle.Degrees(+29.85763647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68188",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68188"},
        {"Geneva Identification System", "GEN# +0.03002469"},
        {"Wilson Evans Batten Catalogue", "WEB 11963"},
    },
    visualMagnitude: 11.38,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.39196019),
        dec: Angle.Degrees(+29.85800393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150537"},
        {"Hipparcos Number", "HIP 81630"},
        {"Geneva Identification System", "GEN# +1.00150537"},
        {"Smithsonian Astrophysical Observation", "SAO 84532"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.11743136),
        dec: Angle.Degrees(+29.85858346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168913"},
        {"Hipparcos Number", "HIP 89925"},
        {"Geneva Identification System", "GEN# +1.00168913"},
        {"Renson", "Renson 47360"},
        {"Smithsonian Astrophysical Observation", "SAO 85956"},
        {"Wilson Evans Batten Catalogue", "WEB 15355"},
    },
    visualMagnitude: 5.61,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.23737263),
        dec: Angle.Degrees(+29.85879387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120364"},
        {"Hipparcos Number", "HIP 67372"},
        {"Geneva Identification System", "GEN# +1.00120364"},
        {"Smithsonian Astrophysical Observation", "SAO 63759"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.13493612),
        dec: Angle.Degrees(+29.86122511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 334181"},
        {"Hipparcos Number", "HIP 100277"},
        {"Smithsonian Astrophysical Observation", "SAO 88539"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.09336533),
        dec: Angle.Degrees(+29.86555173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117392",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117392"},
        {"Smithsonian Astrophysical Observation", "SAO 91496"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.04450810),
        dec: Angle.Degrees(+29.86557335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109018",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15610 AB"},
        {"Henry Draper", "HD 209745"},
        {"Hipparcos Number", "HIP 109018"},
        {"Geneva Identification System", "GEN# +1.00209745J"},
        {"Smithsonian Astrophysical Observation", "SAO 90215"},
        {"Wilson Evans Batten Catalogue", "WEB 19603"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.28771061),
        dec: Angle.Degrees(+29.86756852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132678"},
        {"Hipparcos Number", "HIP 73364"},
        {"Smithsonian Astrophysical Observation", "SAO 64446"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.88650632),
        dec: Angle.Degrees(+29.86757240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16164",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16164"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.07246987),
        dec: Angle.Degrees(+29.86866553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95515"},
        {"Hipparcos Number", "HIP 53906"},
        {"Smithsonian Astrophysical Observation", "SAO 62361"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.45552738),
        dec: Angle.Degrees(+29.87128957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11490",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1868 AB"},
        {"Henry Draper", "HD 15256"},
        {"Hipparcos Number", "HIP 11490"},
        {"Smithsonian Astrophysical Observation", "SAO 75383"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.04889010),
        dec: Angle.Degrees(+29.87333776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219654"},
        {"Hipparcos Number", "HIP 114985"},
        {"Smithsonian Astrophysical Observation", "SAO 91146"},
        {"Wilson Evans Batten Catalogue", "WEB 20369"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.32982755),
        dec: Angle.Degrees(+29.87338267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221644"},
        {"Hipparcos Number", "HIP 116286"},
        {"Geneva Identification System", "GEN# +1.00221644"},
        {"Smithsonian Astrophysical Observation", "SAO 91344"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.41677198),
        dec: Angle.Degrees(+29.87474855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23597"},
        {"Hipparcos Number", "HIP 17698"},
        {"Geneva Identification System", "GEN# +1.00023597"},
        {"Smithsonian Astrophysical Observation", "SAO 76190"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.85695138),
        dec: Angle.Degrees(+29.87579195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73224",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73224"},
        {"Smithsonian Astrophysical Observation", "SAO 64424"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.47303361),
        dec: Angle.Degrees(+29.87618923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -198.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123671"},
        {"Hipparcos Number", "HIP 69086"},
        {"Smithsonian Astrophysical Observation", "SAO 63949"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.10863049),
        dec: Angle.Degrees(+29.87647297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14969"},
        {"Hipparcos Number", "HIP 11304"},
        {"Smithsonian Astrophysical Observation", "SAO 75355"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.37984612),
        dec: Angle.Degrees(+29.88044349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132030"},
        {"Hipparcos Number", "HIP 73077"},
        {"Smithsonian Astrophysical Observation", "SAO 64411"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.03179081),
        dec: Angle.Degrees(+29.88150880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142176"},
        {"Hipparcos Number", "HIP 77721"},
        {"Smithsonian Astrophysical Observation", "SAO 64956"},
        {"Wilson Evans Batten Catalogue", "WEB 13148"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.00946322),
        dec: Angle.Degrees(+29.88167659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160117"},
        {"Hipparcos Number", "HIP 86205"},
        {"Smithsonian Astrophysical Observation", "SAO 85252"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.24318297),
        dec: Angle.Degrees(+29.88181538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187460"},
        {"Hipparcos Number", "HIP 97501"},
        {"Geneva Identification System", "GEN# +1.00187460"},
        {"Smithsonian Astrophysical Observation", "SAO 87765"},
        {"Wilson Evans Batten Catalogue", "WEB 17142"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.26245156),
        dec: Angle.Degrees(+29.88285547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208987"},
        {"Hipparcos Number", "HIP 108559"},
        {"Smithsonian Astrophysical Observation", "SAO 90151"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.85271887),
        dec: Angle.Degrees(+29.88462664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52192",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52192"},
        {"Smithsonian Astrophysical Observation", "SAO 62187"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.94367662),
        dec: Angle.Degrees(+29.88758904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94539",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94539"},
        {"Smithsonian Astrophysical Observation", "SAO 86972"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.61375365),
        dec: Angle.Degrees(+29.88781495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189779"},
        {"Hipparcos Number", "HIP 98497"},
        {"Celescope Catalog", "CEL 4906"},
        {"Geneva Identification System", "GEN# +1.00189779"},
        {"Smithsonian Astrophysical Observation", "SAO 88062"},
        {"Wilson Evans Batten Catalogue", "WEB 17394"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.15703043),
        dec: Angle.Degrees(+29.88858502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141510"},
        {"Hipparcos Number", "HIP 77436"},
        {"Smithsonian Astrophysical Observation", "SAO 64920"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.11519571),
        dec: Angle.Degrees(+29.88995354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94291",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12150 A"},
        {"Henry Draper", "HD 179485"},
        {"Hipparcos Number", "HIP 94291"},
        {"Smithsonian Astrophysical Observation", "SAO 86914"},
        {"Wilson Evans Batten Catalogue", "WEB 16425"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.88088610),
        dec: Angle.Degrees(+29.89018279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204774"},
        {"Hipparcos Number", "HIP 106155"},
        {"Smithsonian Astrophysical Observation", "SAO 89757"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.53211961),
        dec: Angle.Degrees(+29.89030666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220898"},
        {"Hipparcos Number", "HIP 115782"},
        {"Smithsonian Astrophysical Observation", "SAO 91274"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.84916333),
        dec: Angle.Degrees(+29.89142514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101968"},
        {"Hipparcos Number", "HIP 57239"},
        {"Geneva Identification System", "GEN# +1.00101968"},
        {"Renson", "Renson 29390"},
        {"Smithsonian Astrophysical Observation", "SAO 62677"},
        {"Wilson Evans Batten Catalogue", "WEB 10294"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.05443783),
        dec: Angle.Degrees(+29.89542048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190360"},
        {"Hipparcos Number", "HIP 98767"},
        {"Cincinnati Publication", "Ci 20 1184"},
        {"Geneva Identification System", "GEN# +1.00190360A"},
        {"Smithsonian Astrophysical Observation", "SAO 88133"},
        {"Wilson Evans Batten Catalogue", "WEB 17497"},
    },
    visualMagnitude: 5.73,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.90394052),
        dec: Angle.Degrees(+29.89807932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 683.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -524.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113876",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16482 AB"},
        {"Henry Draper", "HD 217923"},
        {"Hipparcos Number", "HIP 113876"},
        {"Smithsonian Astrophysical Observation", "SAO 90980"},
    },
    visualMagnitude: 8.16,
    bvColour: -0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.92613102),
        dec: Angle.Degrees(+29.89973598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89534",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89534"},
        {"Smithsonian Astrophysical Observation", "SAO 85879"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.04528774),
        dec: Angle.Degrees(+29.90047028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202314"},
        {"Hipparcos Number", "HIP 104822"},
        {"Geneva Identification System", "GEN# +1.00202314"},
        {"Smithsonian Astrophysical Observation", "SAO 89549"},
        {"Wilson Evans Batten Catalogue", "WEB 19063"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.54284318),
        dec: Angle.Degrees(+29.90096125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26766"},
        {"Hipparcos Number", "HIP 19835"},
        {"Geneva Identification System", "GEN# +1.00026766"},
        {"Smithsonian Astrophysical Observation", "SAO 76520"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.79292459),
        dec: Angle.Degrees(+29.90246378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33463"},
        {"Hipparcos Number", "HIP 24193"},
        {"Geneva Identification System", "GEN# +1.00033463"},
        {"Smithsonian Astrophysical Observation", "SAO 77025"},
        {"Wilson Evans Batten Catalogue", "WEB 4696"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.90962360),
        dec: Angle.Degrees(+29.90363622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144779"},
        {"Hipparcos Number", "HIP 78906"},
        {"Smithsonian Astrophysical Observation", "SAO 65078"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.60852527),
        dec: Angle.Degrees(+29.90464596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12582"},
        {"Hipparcos Number", "HIP 9644"},
        {"Geneva Identification System", "GEN# +1.00012582"},
        {"Smithsonian Astrophysical Observation", "SAO 75119"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.99253417),
        dec: Angle.Degrees(+29.90495433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182057"},
        {"Hipparcos Number", "HIP 95170"},
        {"Smithsonian Astrophysical Observation", "SAO 87117"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.42149865),
        dec: Angle.Degrees(+29.90547075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109072",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15620 A"},
        {"Henry Draper", "HD 209844"},
        {"Hipparcos Number", "HIP 109072"},
    },
    visualMagnitude: 8.16,
    bvColour: 2.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.43556733),
        dec: Angle.Degrees(+29.90650044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282169"},
        {"Hipparcos Number", "HIP 20674"},
        {"Geneva Identification System", "GEN# +1.00282169"},
        {"Smithsonian Astrophysical Observation", "SAO 76604"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.42488689),
        dec: Angle.Degrees(+29.90746809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166867"},
        {"Hipparcos Number", "HIP 89126"},
        {"Smithsonian Astrophysical Observation", "SAO 85808"},
        {"Wilson Evans Batten Catalogue", "WEB 15135"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.84859986),
        dec: Angle.Degrees(+29.90914100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37267",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37267"},
    },
    visualMagnitude: 10.92,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.79354517),
        dec: Angle.Degrees(+29.90942674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -168.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -201.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 260547"},
        {"Hipparcos Number", "HIP 31659"},
        {"Smithsonian Astrophysical Observation", "SAO 78556"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.38979377),
        dec: Angle.Degrees(+29.90961938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197840"},
        {"Hipparcos Number", "HIP 102411"},
        {"Smithsonian Astrophysical Observation", "SAO 89093"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.29443252),
        dec: Angle.Degrees(+29.91155788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155817"},
        {"Hipparcos Number", "HIP 84202"},
        {"Geneva Identification System", "GEN# +1.00155817"},
        {"Smithsonian Astrophysical Observation", "SAO 84925"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.18589153),
        dec: Angle.Degrees(+29.91180478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6417",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6417"},
        {"Smithsonian Astrophysical Observation", "SAO 74665"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.60068540),
        dec: Angle.Degrees(+29.91330854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67902",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9051 AB"},
        {"Henry Draper", "HD 121369"},
        {"Hipparcos Number", "HIP 67902"},
        {"Geneva Identification System", "GEN# +1.00121369"},
        {"Renson", "Renson 34940"},
        {"Smithsonian Astrophysical Observation", "SAO 63822"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.60635750),
        dec: Angle.Degrees(+29.91562970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136291"},
        {"Hipparcos Number", "HIP 74944"},
        {"Geneva Identification System", "GEN# +1.00136291"},
        {"Smithsonian Astrophysical Observation", "SAO 64624"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.71408688),
        dec: Angle.Degrees(+29.91739593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98460",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13236 AB"},
        {"Henry Draper", "HD 189690"},
        {"Hipparcos Number", "HIP 98460"},
        {"Celescope Catalog", "CEL 4902"},
        {"Geneva Identification System", "GEN# +1.00189690J"},
        {"Smithsonian Astrophysical Observation", "SAO 88049"},
        {"Wilson Evans Batten Catalogue", "WEB 17385"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.06474284),
        dec: Angle.Degrees(+29.92063903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35601"},
        {"Hipparcos Number", "HIP 25500"},
        {"Geneva Identification System", "GEN# +1.00035601"},
        {"Smithsonian Astrophysical Observation", "SAO 77179"},
        {"Wilson Evans Batten Catalogue", "WEB 4947"},
    },
    visualMagnitude: 7.48,
    bvColour: 2.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.79257511),
        dec: Angle.Degrees(+29.92106135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178003"},
        {"Hipparcos Number", "HIP 93770"},
        {"Geneva Identification System", "GEN# +1.00178003"},
        {"Smithsonian Astrophysical Observation", "SAO 86796"},
        {"Wilson Evans Batten Catalogue", "WEB 16297"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.44637945),
        dec: Angle.Degrees(+29.92170180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214458"},
        {"Hipparcos Number", "HIP 111728"},
        {"Geneva Identification System", "GEN# +1.00214458"},
        {"Smithsonian Astrophysical Observation", "SAO 90664"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.48216090),
        dec: Angle.Degrees(+29.92382068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185735"},
        {"Hipparcos Number", "HIP 96687"},
        {"Geneva Identification System", "GEN# +1.00185735"},
        {"Smithsonian Astrophysical Observation", "SAO 87517"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.85386629),
        dec: Angle.Degrees(+29.92473862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 254838"},
        {"Hipparcos Number", "HIP 30036"},
        {"Fundamental Katalog 5th Edition", "FK5 4574"},
        {"Smithsonian Astrophysical Observation", "SAO 78212"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.80880680),
        dec: Angle.Degrees(+29.92559119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109626"},
        {"Hipparcos Number", "HIP 61492"},
        {"Geneva Identification System", "GEN# +1.00109626"},
        {"Smithsonian Astrophysical Observation", "SAO 63092"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.98940873),
        dec: Angle.Degrees(+29.92686557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 333119"},
        {"Hipparcos Number", "HIP 98185"},
        {"Cincinnati Publication", "Ci 18 2604"},
        {"Geneva Identification System", "GEN# +1.00333119"},
        {"Smithsonian Astrophysical Observation", "SAO 87973"},
        {"Wilson Evans Batten Catalogue", "WEB 17316"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.29398927),
        dec: Angle.Degrees(+29.92693421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -203.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28592"},
        {"Hipparcos Number", "HIP 21122"},
        {"Smithsonian Astrophysical Observation", "SAO 76639"},
        {"Wilson Evans Batten Catalogue", "WEB 4061"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.90061673),
        dec: Angle.Degrees(+29.92716127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15335"},
        {"Hipparcos Number", "HIP 11548"},
        {"Geneva Identification System", "GEN# +1.00015335"},
        {"Smithsonian Astrophysical Observation", "SAO 75391"},
        {"Wilson Evans Batten Catalogue", "WEB 2408"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.20224439),
        dec: Angle.Degrees(+29.93158402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12232"},
        {"Hipparcos Number", "HIP 9390"},
        {"Smithsonian Astrophysical Observation", "SAO 75084"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.17438649),
        dec: Angle.Degrees(+29.93195718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63904"},
        {"Hipparcos Number", "HIP 38442"},
        {"Smithsonian Astrophysical Observation", "SAO 60401"},
    },
    visualMagnitude: 8.67,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.12958061),
        dec: Angle.Degrees(+29.93419708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69784",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69784"},
        {"Geneva Identification System", "GEN# +0.03002501"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.25468243),
        dec: Angle.Degrees(+29.93604706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 334456"},
        {"Hipparcos Number", "HIP 101050"},
        {"Smithsonian Astrophysical Observation", "SAO 88743"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.26990884),
        dec: Angle.Degrees(+29.93988315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189379"},
        {"Hipparcos Number", "HIP 98323"},
        {"Geneva Identification System", "GEN# +1.00189379"},
        {"Smithsonian Astrophysical Observation", "SAO 88007"},
        {"Wilson Evans Batten Catalogue", "WEB 17342"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.65250061),
        dec: Angle.Degrees(+29.94111429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 333521"},
        {"Hipparcos Number", "HIP 99015"},
        {"Geneva Identification System", "GEN# +1.00333521"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.53193692),
        dec: Angle.Degrees(+29.94224106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206198"},
        {"Hipparcos Number", "HIP 106959"},
        {"Fundamental Katalog 5th Edition", "FK5 5910"},
        {"Geneva Identification System", "GEN# +1.00206198"},
        {"Smithsonian Astrophysical Observation", "SAO 89888"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.95009259),
        dec: Angle.Degrees(+29.94398250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79340"},
        {"Hipparcos Number", "HIP 45341"},
        {"Geneva Identification System", "GEN# +1.00079340"},
        {"Smithsonian Astrophysical Observation", "SAO 61347"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.59791287),
        dec: Angle.Degrees(+29.94478455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23711"},
        {"Hipparcos Number", "HIP 17773"},
        {"Geneva Identification System", "GEN# +1.00023711"},
        {"Smithsonian Astrophysical Observation", "SAO 76209"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.07705794),
        dec: Angle.Degrees(+29.94751058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10625",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10625"},
        {"Fundamental Katalog 5th Edition", "FK5 4211"},
        {"Smithsonian Astrophysical Observation", "SAO 75254"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.19423604),
        dec: Angle.Degrees(+29.95074304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60597",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60597"},
        {"Geneva Identification System", "GEN# +0.03002267"},
        {"Smithsonian Astrophysical Observation", "SAO 62994"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.30745162),
        dec: Angle.Degrees(+29.95147616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166435"},
        {"Hipparcos Number", "HIP 88945"},
        {"Geneva Identification System", "GEN# +1.00166435"},
        {"Smithsonian Astrophysical Observation", "SAO 85784"},
        {"Wilson Evans Batten Catalogue", "WEB 15086"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.33888844),
        dec: Angle.Degrees(+29.95156418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17151",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17151"},
        {"Smithsonian Astrophysical Observation", "SAO 76066"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.10102763),
        dec: Angle.Degrees(+29.95612264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181226"},
        {"Hipparcos Number", "HIP 94875"},
        {"Celescope Catalog", "CEL 4733"},
        {"Geneva Identification System", "GEN# +1.00181226"},
        {"Smithsonian Astrophysical Observation", "SAO 87054"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.61294774),
        dec: Angle.Degrees(+29.95682941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 249118"},
        {"Hipparcos Number", "HIP 28028"},
        {"Geneva Identification System", "GEN# +1.00249118"},
        {"Smithsonian Astrophysical Observation", "SAO 77723"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.91216789),
        dec: Angle.Degrees(+29.95693281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213992"},
        {"Hipparcos Number", "HIP 111455"},
        {"Smithsonian Astrophysical Observation", "SAO 90613"},
        {"Wilson Evans Batten Catalogue", "WEB 19928"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.69762068),
        dec: Angle.Degrees(+29.95740265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 333388"},
        {"Hipparcos Number", "HIP 98746"},
        {"Smithsonian Astrophysical Observation", "SAO 88126"},
        {"Wilson Evans Batten Catalogue", "WEB 17491"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.85036494),
        dec: Angle.Degrees(+29.95784038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209680"},
        {"Hipparcos Number", "HIP 108974"},
        {"Geneva Identification System", "GEN# +1.00209680"},
        {"Smithsonian Astrophysical Observation", "SAO 90207"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.14926584),
        dec: Angle.Degrees(+29.95955747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196609"},
        {"Hipparcos Number", "HIP 101761"},
        {"Smithsonian Astrophysical Observation", "SAO 88913"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.36178991),
        dec: Angle.Degrees(+29.95967392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72586",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72586"},
    },
    visualMagnitude: 11.35,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.63110606),
        dec: Angle.Degrees(+29.96040753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -191.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75783"},
        {"Hipparcos Number", "HIP 43616"},
        {"Smithsonian Astrophysical Observation", "SAO 61109"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.25046400),
        dec: Angle.Degrees(+29.96162698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195195"},
        {"Hipparcos Number", "HIP 101032"},
        {"Smithsonian Astrophysical Observation", "SAO 88735"},
    },
    visualMagnitude: 8.27,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.22926646),
        dec: Angle.Degrees(+29.96265646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44250"},
        {"Hipparcos Number", "HIP 30273"},
        {"Smithsonian Astrophysical Observation", "SAO 78275"},
        {"Wilson Evans Batten Catalogue", "WEB 6020"},
    },
    visualMagnitude: 7.01,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.51597766),
        dec: Angle.Degrees(+29.96417272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151937"},
        {"Hipparcos Number", "HIP 82324"},
        {"Fundamental Katalog 5th Edition", "FK5 5485"},
        {"Geneva Identification System", "GEN# +1.00151937"},
        {"Smithsonian Astrophysical Observation", "SAO 65577"},
        {"Wilson Evans Batten Catalogue", "WEB 13897"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.31383101),
        dec: Angle.Degrees(+29.96452023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15788"},
        {"Hipparcos Number", "HIP 11869"},
        {"Smithsonian Astrophysical Observation", "SAO 75436"},
        {"Wilson Evans Batten Catalogue", "WEB 2455"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.28326617),
        dec: Angle.Degrees(+29.96470155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99946"},
        {"Hipparcos Number", "HIP 56109"},
        {"Fundamental Katalog 5th Edition", "FK5 2916"},
        {"Geneva Identification System", "GEN# +1.00099946A"},
        {"Smithsonian Astrophysical Observation", "SAO 62579"},
        {"Wilson Evans Batten Catalogue", "WEB 10074"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.51821988),
        dec: Angle.Degrees(+29.96511521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -199.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 334260"},
        {"Hipparcos Number", "HIP 100620"},
        {"Smithsonian Astrophysical Observation", "SAO 88630"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.04473133),
        dec: Angle.Degrees(+29.96685574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90632",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90632"},
        {"Smithsonian Astrophysical Observation", "SAO 86121"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.39542468),
        dec: Angle.Degrees(+29.96797059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126306"},
        {"Hipparcos Number", "HIP 70378"},
        {"Smithsonian Astrophysical Observation", "SAO 64121"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.98906119),
        dec: Angle.Degrees(+29.96845354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36111",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36111"},
        {"Smithsonian Astrophysical Observation", "SAO 60078"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.58258510),
        dec: Angle.Degrees(+29.96895697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93699"},
        {"Hipparcos Number", "HIP 52936"},
        {"Smithsonian Astrophysical Observation", "SAO 62272"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.38482956),
        dec: Angle.Degrees(+29.97071422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140087"},
        {"Hipparcos Number", "HIP 76792"},
        {"Smithsonian Astrophysical Observation", "SAO 64842"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.18886336),
        dec: Angle.Degrees(+29.97217752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29537"},
        {"Hipparcos Number", "HIP 21760"},
        {"Geneva Identification System", "GEN# +1.00029537"},
        {"Smithsonian Astrophysical Observation", "SAO 76697"},
        {"Wilson Evans Batten Catalogue", "WEB 4184"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.09437207),
        dec: Angle.Degrees(+29.97232007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84107"},
        {"Hipparcos Number", "HIP 47701"},
        {"Fundamental Katalog 5th Edition", "FK5 1251"},
        {"Geneva Identification System", "GEN# +1.00084107"},
        {"Smithsonian Astrophysical Observation", "SAO 61656"},
        {"Wilson Evans Batten Catalogue", "WEB 8938"},
    },
    visualMagnitude: 5.64,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.88863057),
        dec: Angle.Degrees(+29.97472479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114761"},
        {"Hipparcos Number", "HIP 64422"},
        {"Geneva Identification System", "GEN# +1.00114761"},
        {"Smithsonian Astrophysical Observation", "SAO 63400"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.06146279),
        dec: Angle.Degrees(+29.97624720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224458"},
        {"Hipparcos Number", "HIP 118161"},
        {"Geneva Identification System", "GEN# +1.00224458"},
        {"Smithsonian Astrophysical Observation", "SAO 91618"},
        {"Wilson Evans Batten Catalogue", "WEB 20773"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.52570664),
        dec: Angle.Degrees(+29.97675238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198612"},
        {"Hipparcos Number", "HIP 102871"},
        {"Smithsonian Astrophysical Observation", "SAO 89200"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.63682873),
        dec: Angle.Degrees(+29.97757106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90627",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90627"},
        {"Smithsonian Astrophysical Observation", "SAO 86120"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.38575407),
        dec: Angle.Degrees(+29.97919164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335463"},
        {"Hipparcos Number", "HIP 103884"},
        {"Smithsonian Astrophysical Observation", "SAO 89406"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.74382955),
        dec: Angle.Degrees(+29.97938789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74309",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74309"},
        {"Smithsonian Astrophysical Observation", "SAO 64544"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.82674578),
        dec: Angle.Degrees(+29.98044080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93373"},
        {"Hipparcos Number", "HIP 52769"},
        {"Geneva Identification System", "GEN# +1.00093373"},
        {"Smithsonian Astrophysical Observation", "SAO 62252"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.84425931),
        dec: Angle.Degrees(+29.98147915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74530",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74530"},
        {"Smithsonian Astrophysical Observation", "SAO 64573"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.44540998),
        dec: Angle.Degrees(+29.98282332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16795",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2633 AB"},
        {"Henry Draper", "HD 22280"},
        {"Hipparcos Number", "HIP 16795"},
        {"Renson", "Renson 5610"},
        {"Smithsonian Astrophysical Observation", "SAO 76017"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.04726903),
        dec: Angle.Degrees(+29.98335533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40255"},
        {"Hipparcos Number", "HIP 28309"},
        {"Smithsonian Astrophysical Observation", "SAO 77795"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.73277109),
        dec: Angle.Degrees(+29.98387119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171622"},
        {"Hipparcos Number", "HIP 91077"},
        {"Smithsonian Astrophysical Observation", "SAO 86211"},
    },
    visualMagnitude: 7.66,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.65885047),
        dec: Angle.Degrees(+29.98429077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92261",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92261"},
        {"Smithsonian Astrophysical Observation", "SAO 86452"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.04379043),
        dec: Angle.Degrees(+29.98500152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6132"},
        {"Hipparcos Number", "HIP 4901"},
        {"Smithsonian Astrophysical Observation", "SAO 74446"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.72255626),
        dec: Angle.Degrees(+29.98613198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116810",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116810"},
    },
    visualMagnitude: 10.99,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.12023031),
        dec: Angle.Degrees(+29.98664208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 201.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35479"},
        {"Hipparcos Number", "HIP 25422"},
        {"Geneva Identification System", "GEN# +1.00035479"},
        {"Renson", "Renson 9090"},
        {"Smithsonian Astrophysical Observation", "SAO 77164"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.56087354),
        dec: Angle.Degrees(+29.98666568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99267"},
        {"Hipparcos Number", "HIP 55766"},
        {"Geneva Identification System", "GEN# +1.00099267"},
        {"Smithsonian Astrophysical Observation", "SAO 62550"},
        {"Wilson Evans Batten Catalogue", "WEB 10020"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.40933390),
        dec: Angle.Degrees(+29.98731299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213234"},
        {"Hipparcos Number", "HIP 111024"},
        {"Smithsonian Astrophysical Observation", "SAO 90547"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.38587829),
        dec: Angle.Degrees(+29.98875590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 332954"},
        {"Hipparcos Number", "HIP 98039"},
        {"Smithsonian Astrophysical Observation", "SAO 87932"},
        {"Wilson Evans Batten Catalogue", "WEB 17269"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.83343957),
        dec: Angle.Degrees(+29.98910078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190403"},
        {"Hipparcos Number", "HIP 98783"},
        {"Geneva Identification System", "GEN# +1.00190403"},
        {"Smithsonian Astrophysical Observation", "SAO 88137"},
        {"Wilson Evans Batten Catalogue", "WEB 17499"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.93119979),
        dec: Angle.Degrees(+29.98946538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139389"},
        {"Hipparcos Number", "HIP 76456"},
        {"Geneva Identification System", "GEN# +1.00139389"},
        {"Smithsonian Astrophysical Observation", "SAO 64808"},
        {"Wilson Evans Batten Catalogue", "WEB 12980"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.22236763),
        dec: Angle.Degrees(+29.99132177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7684"},
        {"Hipparcos Number", "HIP 5994"},
        {"Geneva Identification System", "GEN# +1.00007684"},
        {"Smithsonian Astrophysical Observation", "SAO 74604"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.27102321),
        dec: Angle.Degrees(+29.99263528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82064",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10201 C"},
        {"Henry Draper", "HD 151368"},
        {"Hipparcos Number", "HIP 82064"},
        {"Geneva Identification System", "GEN# +1.00151368"},
        {"Smithsonian Astrophysical Observation", "SAO 65534"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.44727548),
        dec: Angle.Degrees(+29.99315425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35032",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35032"},
        {"Smithsonian Astrophysical Observation", "SAO 59914"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.69796389),
        dec: Angle.Degrees(+29.99363708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2844",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 497 AB"},
        {"Henry Draper", "HD 3266"},
        {"Hipparcos Number", "HIP 2844"},
        {"Cincinnati Publication", "Ci 20 38"},
        {"Cincinnati Publication 2", "Ci 18 73"},
        {"Geneva Identification System", "GEN# +1.00003266"},
        {"Smithsonian Astrophysical Observation", "SAO 74132"},
        {"Wilson Evans Batten Catalogue", "WEB 508"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.00932703),
        dec: Angle.Degrees(+29.99400304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 185.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -408.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73889"},
        {"Hipparcos Number", "HIP 42658"},
        {"Smithsonian Astrophysical Observation", "SAO 60987"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.41332240),
        dec: Angle.Degrees(+29.99451980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282635"},
        {"Hipparcos Number", "HIP 22964"},
        {"Geneva Identification System", "GEN# +1.00282635"},
        {"Smithsonian Astrophysical Observation", "SAO 76851"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.12089092),
        dec: Angle.Degrees(+29.99496901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32158"},
        {"Hipparcos Number", "HIP 23438"},
        {"Smithsonian Astrophysical Observation", "SAO 76908"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.57355548),
        dec: Angle.Degrees(+29.99503259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67053",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67053"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.12124994),
        dec: Angle.Degrees(+29.99562995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162668"},
        {"Hipparcos Number", "HIP 87352"},
        {"Smithsonian Astrophysical Observation", "SAO 66378"},
        {"Wilson Evans Batten Catalogue", "WEB 14739"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.73862667),
        dec: Angle.Degrees(+29.99580709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96198"},
        {"Hipparcos Number", "HIP 54240"},
        {"Smithsonian Astrophysical Observation", "SAO 62405"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.45709412),
        dec: Angle.Degrees(+29.99844100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82060",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10201 B"},
        {"Hipparcos Number", "HIP 82060"},
        {"Geneva Identification System", "GEN# +1.00151367B"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.43372913),
        dec: Angle.Degrees(+30.00154439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143349"},
        {"Hipparcos Number", "HIP 78260"},
        {"Smithsonian Astrophysical Observation", "SAO 64997"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.68644481),
        dec: Angle.Degrees(+30.00462315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82058",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10201 A"},
        {"Henry Draper", "HD 151367"},
        {"Hipparcos Number", "HIP 82058"},
        {"Geneva Identification System", "GEN# +1.00151367A"},
        {"Smithsonian Astrophysical Observation", "SAO 65531"},
        {"Wilson Evans Batten Catalogue", "WEB 13856"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.43111023),
        dec: Angle.Degrees(+30.00478888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21834"},
        {"Hipparcos Number", "HIP 16474"},
        {"Smithsonian Astrophysical Observation", "SAO 75980"},
        {"Wilson Evans Batten Catalogue", "WEB 3148"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.04055459),
        dec: Angle.Degrees(+30.00608034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3766"},
        {"Hipparcos Number", "HIP 3191"},
        {"Smithsonian Astrophysical Observation", "SAO 74189"},
        {"Wilson Evans Batten Catalogue", "WEB 571"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.16512674),
        dec: Angle.Degrees(+30.00645813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120876"},
        {"Hipparcos Number", "HIP 67651"},
        {"Smithsonian Astrophysical Observation", "SAO 63788"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.91158062),
        dec: Angle.Degrees(+30.00821163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138440"},
        {"Hipparcos Number", "HIP 75991"},
        {"Smithsonian Astrophysical Observation", "SAO 64750"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.78440249),
        dec: Angle.Degrees(+30.00845542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73960",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73960"},
        {"Geneva Identification System", "GEN# +0.03002611"},
        {"Smithsonian Astrophysical Observation", "SAO 64506"},
        {"Wilson Evans Batten Catalogue", "WEB 12632"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.72424534),
        dec: Angle.Degrees(+30.01028029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 332518"},
        {"Hipparcos Number", "HIP 97223"},
        {"Smithsonian Astrophysical Observation", "SAO 87679"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.39855126),
        dec: Angle.Degrees(+30.01046344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95452",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95452"},
        {"Smithsonian Astrophysical Observation", "SAO 87183"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.25041774),
        dec: Angle.Degrees(+30.01211977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128885"},
        {"Hipparcos Number", "HIP 71605"},
        {"Smithsonian Astrophysical Observation", "SAO 64252"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.66754027),
        dec: Angle.Degrees(+30.01498208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60713"},
        {"Hipparcos Number", "HIP 37071"},
        {"Geneva Identification System", "GEN# +1.00060713"},
        {"Smithsonian Astrophysical Observation", "SAO 60228"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.27051118),
        dec: Angle.Degrees(+30.01516608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72823"},
        {"Hipparcos Number", "HIP 42182"},
        {"Smithsonian Astrophysical Observation", "SAO 60915"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.00605110),
        dec: Angle.Degrees(+30.01802929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187711"},
        {"Hipparcos Number", "HIP 97603"},
        {"Celescope Catalog", "CEL 4857"},
        {"Geneva Identification System", "GEN# +1.00187711"},
        {"Smithsonian Astrophysical Observation", "SAO 87794"},
    },
    visualMagnitude: 8.34,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.56803983),
        dec: Angle.Degrees(+30.01815956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73209"},
        {"Hipparcos Number", "HIP 42358"},
        {"Smithsonian Astrophysical Observation", "SAO 60938"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.54546568),
        dec: Angle.Degrees(+30.01892618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192732"},
        {"Hipparcos Number", "HIP 99830"},
        {"Smithsonian Astrophysical Observation", "SAO 88414"},
        {"Wilson Evans Batten Catalogue", "WEB 17943"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.83508195),
        dec: Angle.Degrees(+30.02042827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60955",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60955"},
        {"Geneva Identification System", "GEN# +0.03002283"},
        {"Smithsonian Astrophysical Observation", "SAO 63026"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.42849801),
        dec: Angle.Degrees(+30.02209854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116254",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116254"},
        {"Smithsonian Astrophysical Observation", "SAO 91339"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.34398917),
        dec: Angle.Degrees(+30.02237176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97949",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13096 AB"},
        {"Henry Draper", "HD 188504"},
        {"Hipparcos Number", "HIP 97949"},
        {"Geneva Identification System", "GEN# +1.00188504J"},
        {"Smithsonian Astrophysical Observation", "SAO 87907"},
        {"Wilson Evans Batten Catalogue", "WEB 17237"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.59613137),
        dec: Angle.Degrees(+30.02527612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171947"},
        {"Hipparcos Number", "HIP 91198"},
        {"Smithsonian Astrophysical Observation", "SAO 86236"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.05991195),
        dec: Angle.Degrees(+30.02590829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93442",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93442"},
        {"Renson", "Renson 49390"},
        {"Smithsonian Astrophysical Observation", "SAO 86723"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.45595301),
        dec: Angle.Degrees(+30.02628217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170467"},
        {"Hipparcos Number", "HIP 90531"},
        {"Geneva Identification System", "GEN# +1.00170467"},
        {"Smithsonian Astrophysical Observation", "SAO 86095"},
    },
    visualMagnitude: 8.31,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.08963349),
        dec: Angle.Degrees(+30.02679007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221767"},
        {"Hipparcos Number", "HIP 116372"},
        {"Renson", "Renson 60780"},
        {"Smithsonian Astrophysical Observation", "SAO 91357"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.71496378),
        dec: Angle.Degrees(+30.02972591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222049"},
        {"Hipparcos Number", "HIP 116552"},
        {"Smithsonian Astrophysical Observation", "SAO 91381"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.31080852),
        dec: Angle.Degrees(+30.02985722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175578"},
        {"Hipparcos Number", "HIP 92827"},
        {"Geneva Identification System", "GEN# +1.00175578"},
        {"Smithsonian Astrophysical Observation", "SAO 86571"},
        {"Wilson Evans Batten Catalogue", "WEB 16066"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.71218796),
        dec: Angle.Degrees(+30.03276052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59103",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59103"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.79913530),
        dec: Angle.Degrees(+30.03579429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19895",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3089 AB"},
        {"Henry Draper", "HD 26873"},
        {"Hipparcos Number", "HIP 19895"},
    },
    visualMagnitude: 7.64,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.00884871),
        dec: Angle.Degrees(+30.03590280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209517"},
        {"Hipparcos Number", "HIP 108885"},
        {"Smithsonian Astrophysical Observation", "SAO 90197"},
        {"Wilson Evans Batten Catalogue", "WEB 19586"},
    },
    visualMagnitude: 7.48,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.85169374),
        dec: Angle.Degrees(+30.03743613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82011"},
        {"Hipparcos Number", "HIP 46592"},
        {"Smithsonian Astrophysical Observation", "SAO 61524"},
        {"Wilson Evans Batten Catalogue", "WEB 8791"},
    },
    visualMagnitude: 10.17,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.52046460),
        dec: Angle.Degrees(+30.03915442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 256496"},
        {"Hipparcos Number", "HIP 30510"},
        {"Smithsonian Astrophysical Observation", "SAO 59057"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.20036454),
        dec: Angle.Degrees(+30.03956155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109281"},
        {"Hipparcos Number", "HIP 61282"},
        {"Geneva Identification System", "GEN# +1.00109281"},
        {"Smithsonian Astrophysical Observation", "SAO 63064"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.37210371),
        dec: Angle.Degrees(+30.04032669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96778"},
        {"Hipparcos Number", "HIP 54504"},
        {"Fundamental Katalog 5th Edition", "FK5 2890"},
        {"Geneva Identification System", "GEN# +1.00096778"},
        {"Smithsonian Astrophysical Observation", "SAO 62426"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.26071315),
        dec: Angle.Degrees(+30.04048418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218880"},
        {"Hipparcos Number", "HIP 114486"},
        {"Smithsonian Astrophysical Observation", "SAO 91069"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.79490121),
        dec: Angle.Degrees(+30.04306712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78514",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78514"},
        {"Smithsonian Astrophysical Observation", "SAO 65027"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.43430200),
        dec: Angle.Degrees(+30.04479032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216331"},
        {"Hipparcos Number", "HIP 112894"},
        {"Geneva Identification System", "GEN# +1.00216331"},
        {"Smithsonian Astrophysical Observation", "SAO 90838"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.93616660),
        dec: Angle.Degrees(+30.04484383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179891"},
        {"Hipparcos Number", "HIP 94422"},
        {"Geneva Identification System", "GEN# +1.00179891"},
        {"Smithsonian Astrophysical Observation", "SAO 86945"},
    },
    visualMagnitude: 8.18,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.27650140),
        dec: Angle.Degrees(+30.04614758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65706",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65706"},
    },
    visualMagnitude: 11.21,
    bvColour: 1.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.07452188),
        dec: Angle.Degrees(+30.04656178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -184.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -185.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56942",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56942"},
        {"Smithsonian Astrophysical Observation", "SAO 62648"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.10662362),
        dec: Angle.Degrees(+30.04670910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10348"},
        {"Hipparcos Number", "HIP 7906"},
        {"Geneva Identification System", "GEN# +1.00010348"},
        {"Smithsonian Astrophysical Observation", "SAO 74872"},
        {"Wilson Evans Batten Catalogue", "WEB 1689"},
    },
    visualMagnitude: 5.97,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.41350900),
        dec: Angle.Degrees(+30.04713542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203158"},
        {"Hipparcos Number", "HIP 105305"},
        {"Geneva Identification System", "GEN# +1.00203158"},
        {"Smithsonian Astrophysical Observation", "SAO 89624"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.93035407),
        dec: Angle.Degrees(+30.04736287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211406"},
        {"Hipparcos Number", "HIP 109959"},
        {"Geneva Identification System", "GEN# +1.00211406"},
        {"Smithsonian Astrophysical Observation", "SAO 90374"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.06728290),
        dec: Angle.Degrees(+30.04796234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88055",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10955 A"},
        {"Henry Draper", "HD 164252"},
        {"Hipparcos Number", "HIP 88055"},
        {"Geneva Identification System", "GEN# +1.00164252"},
        {"Smithsonian Astrophysical Observation", "SAO 66535"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.76508956),
        dec: Angle.Degrees(+30.04888805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88051",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10955 B"},
        {"Henry Draper", "HD 164253"},
        {"Hipparcos Number", "HIP 88051"},
        {"Geneva Identification System", "GEN# +1.00164253"},
        {"Wilson Evans Batten Catalogue", "WEB 14874"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.75883484),
        dec: Angle.Degrees(+30.04956884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218428"},
        {"Hipparcos Number", "HIP 114201"},
        {"Fundamental Katalog 5th Edition", "FK5 3851"},
        {"Geneva Identification System", "GEN# +1.00218428"},
        {"Smithsonian Astrophysical Observation", "SAO 91025"},
        {"Wilson Evans Batten Catalogue", "WEB 20280"},
    },
    visualMagnitude: 7.58,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.91745502),
        dec: Angle.Degrees(+30.05428233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106661",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15126 AB"},
        {"Henry Draper", "HD 205688"},
        {"Hipparcos Number", "HIP 106661"},
        {"Smithsonian Astrophysical Observation", "SAO 89834"},
        {"Wilson Evans Batten Catalogue", "WEB 19292"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.05840594),
        dec: Angle.Degrees(+30.05527642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137424"},
        {"Hipparcos Number", "HIP 75465"},
        {"Fundamental Katalog 5th Edition", "FK5 5364"},
        {"Smithsonian Astrophysical Observation", "SAO 64690"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.24601071),
        dec: Angle.Degrees(+30.05765697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222248"},
        {"Hipparcos Number", "HIP 116696"},
        {"Smithsonian Astrophysical Observation", "SAO 91400"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.72317507),
        dec: Angle.Degrees(+30.05967680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146191"},
        {"Hipparcos Number", "HIP 79538"},
        {"Smithsonian Astrophysical Observation", "SAO 65162"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.45956202),
        dec: Angle.Degrees(+30.06016839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11943",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11943"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.52521051),
        dec: Angle.Degrees(+30.06078940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131764"},
        {"Hipparcos Number", "HIP 72953"},
        {"Geneva Identification System", "GEN# +1.00131764"},
        {"Smithsonian Astrophysical Observation", "SAO 64393"},
        {"Wilson Evans Batten Catalogue", "WEB 12520"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.64847701),
        dec: Angle.Degrees(+30.06359889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5679",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 990 A"},
        {"Henry Draper", "HD 7229"},
        {"Hipparcos Number", "HIP 5679"},
        {"Geneva Identification System", "GEN# +1.00007229A"},
        {"Smithsonian Astrophysical Observation", "SAO 74561"},
        {"Wilson Evans Batten Catalogue", "WEB 1290"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.24774657),
        dec: Angle.Degrees(+30.06430791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56088",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56088"},
        {"Geneva Identification System", "GEN# +0.03002162"},
        {"Smithsonian Astrophysical Observation", "SAO 62578"},
        {"Wilson Evans Batten Catalogue", "WEB 10072"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.45224043),
        dec: Angle.Degrees(+30.06745887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113544",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16436 AB"},
        {"Henry Draper", "HD 217351"},
        {"Hipparcos Number", "HIP 113544"},
    },
    visualMagnitude: 8.44,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.94803404),
        dec: Angle.Degrees(+30.07734759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13313"},
        {"Hipparcos Number", "HIP 10169"},
        {"Smithsonian Astrophysical Observation", "SAO 75181"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.69423375),
        dec: Angle.Degrees(+30.07829796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10133"},
        {"Hipparcos Number", "HIP 7741"},
        {"Smithsonian Astrophysical Observation", "SAO 74858"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.92176762),
        dec: Angle.Degrees(+30.08365537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69333",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69333"},
        {"Cincinnati Publication", "Ci 20 836"},
        {"Geneva Identification System", "GEN# +0.03002490"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.85210940),
        dec: Angle.Degrees(+30.08431064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -455.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66439",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8970 A"},
        {"Henry Draper", "HD 118576"},
        {"Hipparcos Number", "HIP 66439"},
        {"Geneva Identification System", "GEN# +1.00118576A"},
        {"Geneva Identification System 2", "GEN# +1.10118576"},
        {"Smithsonian Astrophysical Observation", "SAO 63646"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.30196817),
        dec: Angle.Degrees(+30.08501186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -156.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110554",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110554"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.93383082),
        dec: Angle.Degrees(+30.08513548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 166.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94632",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94632"},
        {"Smithsonian Astrophysical Observation", "SAO 86992"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.85817645),
        dec: Angle.Degrees(+30.08582828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 392",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 40 AB"},
        {"Henry Draper", "HD 225260"},
        {"Hipparcos Number", "HIP 392"},
        {"Smithsonian Astrophysical Observation", "SAO 73728"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.21651501),
        dec: Angle.Degrees(+30.08593131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80747",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80747"},
    },
    visualMagnitude: 11.18,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.29405512),
        dec: Angle.Degrees(+30.08617672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37453"},
        {"Hipparcos Number", "HIP 26658"},
        {"Smithsonian Astrophysical Observation", "SAO 58308"},
        {"Wilson Evans Batten Catalogue", "WEB 5256"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.98593539),
        dec: Angle.Degrees(+30.08646395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66441",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8970 B"},
        {"Hipparcos Number", "HIP 66441"},
        {"Geneva Identification System", "GEN# +1.20118576"},
        {"Geneva Identification System 2", "GEN# +1.00118576B"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.30798521),
        dec: Angle.Degrees(+30.08716942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -151.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7106"},
        {"Hipparcos Number", "HIP 5586"},
        {"Fundamental Katalog 5th Edition", "FK5 43"},
        {"Geneva Identification System", "GEN# +1.00007106"},
        {"Smithsonian Astrophysical Observation", "SAO 74546"},
        {"Wilson Evans Batten Catalogue", "WEB 1249"},
    },
    visualMagnitude: 4.51,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.91494471),
        dec: Angle.Degrees(+30.08972962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275227"},
        {"Hipparcos Number", "HIP 15466"},
    },
    visualMagnitude: 10.79,
    bvColour: 1.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.86074412),
        dec: Angle.Degrees(+38.01338299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211474"},
        {"Hipparcos Number", "HIP 110001"},
        {"Smithsonian Astrophysical Observation", "SAO 90385"},
        {"Wilson Evans Batten Catalogue", "WEB 19751"},
    },
    visualMagnitude: 7.63,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.20074951),
        dec: Angle.Degrees(+30.09137985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215274"},
        {"Hipparcos Number", "HIP 112219"},
        {"Geneva Identification System", "GEN# +1.00215274"},
        {"Smithsonian Astrophysical Observation", "SAO 90742"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.91793317),
        dec: Angle.Degrees(+30.09245400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 239.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174896"},
        {"Hipparcos Number", "HIP 92554"},
        {"Smithsonian Astrophysical Observation", "SAO 67482"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.90861745),
        dec: Angle.Degrees(+30.09294431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68526",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68526"},
        {"Geneva Identification System", "GEN# +0.03002475"},
        {"Smithsonian Astrophysical Observation", "SAO 63895"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.43361675),
        dec: Angle.Degrees(+30.09500729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10406"},
        {"Hipparcos Number", "HIP 7953"},
        {"Geneva Identification System", "GEN# +1.00010406"},
        {"Smithsonian Astrophysical Observation", "SAO 74881"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.53407873),
        dec: Angle.Degrees(+30.09594401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62899"},
        {"Hipparcos Number", "HIP 38012"},
        {"Geneva Identification System", "GEN# +1.00062899"},
        {"Smithsonian Astrophysical Observation", "SAO 60339"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.85612954),
        dec: Angle.Degrees(+30.09747510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 247835"},
        {"Hipparcos Number", "HIP 27488"},
        {"Geneva Identification System", "GEN# +1.00247835"},
        {"Smithsonian Astrophysical Observation", "SAO 58474"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.30567361),
        dec: Angle.Degrees(+30.09909014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207243"},
        {"Hipparcos Number", "HIP 107540"},
        {"Smithsonian Astrophysical Observation", "SAO 89986"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.71660466),
        dec: Angle.Degrees(+30.10150688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59611",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59611"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.37593676),
        dec: Angle.Degrees(+30.10211698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43228"},
        {"Hipparcos Number", "HIP 29790"},
        {"Smithsonian Astrophysical Observation", "SAO 58927"},
    },
    visualMagnitude: 6.91,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.08578842),
        dec: Angle.Degrees(+30.10253736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4006"},
        {"Hipparcos Number", "HIP 3360"},
        {"Geneva Identification System", "GEN# +1.00004006"},
        {"Smithsonian Astrophysical Observation", "SAO 74217"},
        {"Wilson Evans Batten Catalogue", "WEB 598"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.69841273),
        dec: Angle.Degrees(+30.10266422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77390"},
        {"Hipparcos Number", "HIP 44426"},
        {"Smithsonian Astrophysical Observation", "SAO 61220"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.77998716),
        dec: Angle.Degrees(+30.10274180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139569"},
        {"Hipparcos Number", "HIP 76536"},
        {"Smithsonian Astrophysical Observation", "SAO 64818"},
        {"Wilson Evans Batten Catalogue", "WEB 12991"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.47387961),
        dec: Angle.Degrees(+30.10290212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31562",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5228 AB"},
        {"Henry Draper", "HD 46745"},
        {"Hipparcos Number", "HIP 31562"},
        {"Smithsonian Astrophysical Observation", "SAO 59281"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.09313357),
        dec: Angle.Degrees(+30.10549361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63800",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63800"},
        {"Geneva Identification System", "GEN# +0.03002361"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.14599879),
        dec: Angle.Degrees(+30.10595634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 251838"},
        {"Hipparcos Number", "HIP 29060"},
        {"Smithsonian Astrophysical Observation", "SAO 58771"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.95230467),
        dec: Angle.Degrees(+30.10639283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75712",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75712"},
        {"Smithsonian Astrophysical Observation", "SAO 64713"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.01269014),
        dec: Angle.Degrees(+30.10824116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81694",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10158 AB"},
        {"Hipparcos Number", "HIP 81694"},
        {"Geneva Identification System", "GEN# +0.03002860"},
    },
    visualMagnitude: 9.96,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)41, 17.7200),
        dec: Angle.DegreesMinutesSeconds((int)+30, (int)06, 34.600)
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
    primaryId: "HIP 69431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124423"},
        {"Hipparcos Number", "HIP 69431"},
        {"Geneva Identification System", "GEN# +1.00124423"},
        {"Smithsonian Astrophysical Observation", "SAO 63987"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.23405688),
        dec: Angle.Degrees(+30.11091968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71389",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71389"},
        {"Geneva Identification System", "GEN# +6.20001097"},
    },
    visualMagnitude: 12.44,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.97278173),
        dec: Angle.Degrees(+30.11142049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84005"},
        {"Hipparcos Number", "HIP 47636"},
        {"Geneva Identification System", "GEN# +1.00084005"},
        {"Smithsonian Astrophysical Observation", "SAO 61649"},
        {"Wilson Evans Batten Catalogue", "WEB 8927"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.68577594),
        dec: Angle.Degrees(+30.11145670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 334068"},
        {"Hipparcos Number", "HIP 99991"},
        {"Geneva Identification System", "GEN# +1.00334068"},
        {"Smithsonian Astrophysical Observation", "SAO 88458"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.28406988),
        dec: Angle.Degrees(+30.11198284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13342"},
        {"Hipparcos Number", "HIP 10199"},
        {"Geneva Identification System", "GEN# +1.00013342"},
        {"Smithsonian Astrophysical Observation", "SAO 75186"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.78606331),
        dec: Angle.Degrees(+30.11577136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49041"},
        {"Hipparcos Number", "HIP 32566"},
        {"Geneva Identification System", "GEN# +1.00049041"},
        {"Smithsonian Astrophysical Observation", "SAO 59490"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.93707820),
        dec: Angle.Degrees(+30.11585900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 334451"},
        {"Hipparcos Number", "HIP 100932"},
        {"Smithsonian Astrophysical Observation", "SAO 88708"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.96378563),
        dec: Angle.Degrees(+30.11968992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98500"},
        {"Hipparcos Number", "HIP 55362"},
        {"Smithsonian Astrophysical Observation", "SAO 62498"},
        {"Wilson Evans Batten Catalogue", "WEB 9964"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.04653352),
        dec: Angle.Degrees(+30.12050079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169330"},
        {"Hipparcos Number", "HIP 90080"},
        {"Smithsonian Astrophysical Observation", "SAO 66921"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.74969367),
        dec: Angle.Degrees(+30.12182657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149251"},
        {"Hipparcos Number", "HIP 80986"},
        {"Smithsonian Astrophysical Observation", "SAO 65370"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.09011632),
        dec: Angle.Degrees(+30.12385069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60669",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60669"},
        {"Geneva Identification System", "GEN# +0.03002268"},
        {"Smithsonian Astrophysical Observation", "SAO 63002"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.50952067),
        dec: Angle.Degrees(+30.12396721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166895"},
        {"Hipparcos Number", "HIP 89134"},
        {"Geneva Identification System", "GEN# +1.00166895"},
        {"Smithsonian Astrophysical Observation", "SAO 66729"},
        {"Wilson Evans Batten Catalogue", "WEB 15137"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.86226114),
        dec: Angle.Degrees(+30.12549620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14805",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14805"},
    },
    visualMagnitude: 11.41,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.79788755),
        dec: Angle.Degrees(+30.12806484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 182.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215849"},
        {"Hipparcos Number", "HIP 112548"},
        {"Geneva Identification System", "GEN# +1.00215849"},
        {"Smithsonian Astrophysical Observation", "SAO 90794"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.93345002),
        dec: Angle.Degrees(+30.12979705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105374",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105374"},
        {"Smithsonian Astrophysical Observation", "SAO 89637"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.15270717),
        dec: Angle.Degrees(+30.13136816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204922"},
        {"Hipparcos Number", "HIP 106233"},
        {"Geneva Identification System", "GEN# +1.00204922"},
        {"Smithsonian Astrophysical Observation", "SAO 89768"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.76335795),
        dec: Angle.Degrees(+30.13410512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23268"},
        {"Hipparcos Number", "HIP 17498"},
        {"Geneva Identification System", "GEN# +1.00023268"},
        {"Smithsonian Astrophysical Observation", "SAO 76125"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.21356508),
        dec: Angle.Degrees(+30.13573672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106510"},
        {"Hipparcos Number", "HIP 59735"},
        {"Geneva Identification System", "GEN# +1.00106510"},
        {"Smithsonian Astrophysical Observation", "SAO 62913"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.75611063),
        dec: Angle.Degrees(+30.14145936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118233"},
        {"Hipparcos Number", "HIP 66277"},
        {"Geneva Identification System", "GEN# +1.00118233"},
        {"Smithsonian Astrophysical Observation", "SAO 63624"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.75920340),
        dec: Angle.Degrees(+30.14447507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188612"},
        {"Hipparcos Number", "HIP 97994"},
        {"Geneva Identification System", "GEN# +1.00188612"},
        {"Smithsonian Astrophysical Observation", "SAO 69068"},
        {"Wilson Evans Batten Catalogue", "WEB 17253"},
    },
    visualMagnitude: 8.25,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.72878320),
        dec: Angle.Degrees(+30.14691423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54242"},
        {"Hipparcos Number", "HIP 34531"},
        {"Fundamental Katalog 5th Edition", "FK5 4645"},
        {"Smithsonian Astrophysical Observation", "SAO 59825"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.32894301),
        dec: Angle.Degrees(+30.14774884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150664"},
        {"Hipparcos Number", "HIP 81690"},
        {"Geneva Identification System", "GEN# +1.00150664"},
        {"Smithsonian Astrophysical Observation", "SAO 65482"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.31419587),
        dec: Angle.Degrees(+30.14804847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88329"},
        {"Hipparcos Number", "HIP 49933"},
        {"Smithsonian Astrophysical Observation", "SAO 61921"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.94084009),
        dec: Angle.Degrees(+30.14898284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37352"},
        {"Hipparcos Number", "HIP 26601"},
        {"Geneva Identification System", "GEN# +1.00037352"},
        {"Smithsonian Astrophysical Observation", "SAO 58292"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.81317114),
        dec: Angle.Degrees(+30.15056342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6998",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6998"},
        {"Smithsonian Astrophysical Observation", "SAO 74755"},
        {"Wilson Evans Batten Catalogue", "WEB 1514"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.52394416),
        dec: Angle.Degrees(+30.15058508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62139",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62139"},
        {"Geneva Identification System", "GEN# +0.03002318"},
        {"Smithsonian Astrophysical Observation", "SAO 63164"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.03550024),
        dec: Angle.Degrees(+30.15168464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58645",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58645"},
    },
    visualMagnitude: 11.06,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.38413015),
        dec: Angle.Degrees(+30.15195501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83395"},
        {"Hipparcos Number", "HIP 47340"},
        {"Geneva Identification System", "GEN# +1.00083395"},
        {"Smithsonian Astrophysical Observation", "SAO 61614"},
        {"Wilson Evans Batten Catalogue", "WEB 8893"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.70376352),
        dec: Angle.Degrees(+30.15307867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185734"},
        {"Hipparcos Number", "HIP 96683"},
        {"Fundamental Katalog 5th Edition", "FK5 3570"},
        {"Geneva Identification System", "GEN# +1.00185734"},
        {"Smithsonian Astrophysical Observation", "SAO 68637"},
        {"Wilson Evans Batten Catalogue", "WEB 16962"},
    },
    visualMagnitude: 4.68,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.84418456),
        dec: Angle.Degrees(+30.15323350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77121",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77121"},
        {"Smithsonian Astrophysical Observation", "SAO 64877"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.21157646),
        dec: Angle.Degrees(+30.15493443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106940",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15182 AB"},
        {"Henry Draper", "HD 206168"},
        {"Hipparcos Number", "HIP 106940"},
        {"Smithsonian Astrophysical Observation", "SAO 89883"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.87601091),
        dec: Angle.Degrees(+30.15616286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171364"},
        {"Hipparcos Number", "HIP 90960"},
        {"Smithsonian Astrophysical Observation", "SAO 67101"},
    },
    visualMagnitude: 8.67,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.32745677),
        dec: Angle.Degrees(+30.16128404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33287",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5570 AB"},
        {"Henry Draper", "HD 50662"},
        {"Hipparcos Number", "HIP 33287"},
        {"Cincinnati Publication", "Ci 18 836"},
        {"Smithsonian Astrophysical Observation", "SAO 59611"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.86814245),
        dec: Angle.Degrees(+30.16245118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 229.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -242.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6050"},
        {"Hipparcos Number", "HIP 4838"},
        {"Geneva Identification System", "GEN# +1.00006050"},
        {"Smithsonian Astrophysical Observation", "SAO 74440"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.55449759),
        dec: Angle.Degrees(+30.16298924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2601"},
        {"Hipparcos Number", "HIP 2326"},
        {"Smithsonian Astrophysical Observation", "SAO 74040"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.42518534),
        dec: Angle.Degrees(+30.16420187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70641",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70641"},
        {"Geneva Identification System", "GEN# +0.03002523"},
        {"Smithsonian Astrophysical Observation", "SAO 64142"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.74275735),
        dec: Angle.Degrees(+30.16508683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91489",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91489"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.88404496),
        dec: Angle.Degrees(+30.16562779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38480",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38480"},
        {"Smithsonian Astrophysical Observation", "SAO 60407"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.21580888),
        dec: Angle.Degrees(+30.16625405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93634",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93634"},
        {"Fundamental Katalog 5th Edition", "FK5 5679"},
        {"Smithsonian Astrophysical Observation", "SAO 67760"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.01397452),
        dec: Angle.Degrees(+30.16772123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38231"},
        {"Hipparcos Number", "HIP 27179"},
        {"Geneva Identification System", "GEN# +1.00038231"},
        {"Smithsonian Astrophysical Observation", "SAO 58407"},
        {"Wilson Evans Batten Catalogue", "WEB 5343"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.40220561),
        dec: Angle.Degrees(+30.16773083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61805"},
        {"Hipparcos Number", "HIP 37545"},
        {"Geneva Identification System", "GEN# +1.00061805"},
        {"Smithsonian Astrophysical Observation", "SAO 60283"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.58060328),
        dec: Angle.Degrees(+30.16786631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107212"},
        {"Hipparcos Number", "HIP 60100"},
        {"Geneva Identification System", "GEN# +1.00107212"},
        {"Smithsonian Astrophysical Observation", "SAO 62950"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.88009592),
        dec: Angle.Degrees(+30.16794655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28711",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28711"},
        {"Geneva Identification System", "GEN# +8.05300031"},
    },
    visualMagnitude: 10.95,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.95881376),
        dec: Angle.Degrees(+30.16921446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16197"},
        {"Hipparcos Number", "HIP 12177"},
        {"Smithsonian Astrophysical Observation", "SAO 75468"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.22416922),
        dec: Angle.Degrees(+30.17270624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144044"},
        {"Hipparcos Number", "HIP 78589"},
        {"Smithsonian Astrophysical Observation", "SAO 65039"},
        {"Wilson Evans Batten Catalogue", "WEB 13284"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.69112981),
        dec: Angle.Degrees(+30.17308754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207650"},
        {"Hipparcos Number", "HIP 107763"},
        {"Fundamental Katalog 5th Edition", "FK5 1575"},
        {"Geneva Identification System", "GEN# +1.00207650"},
        {"Smithsonian Astrophysical Observation", "SAO 90040"},
        {"Wilson Evans Batten Catalogue", "WEB 19433"},
    },
    visualMagnitude: 5.07,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.46117477),
        dec: Angle.Degrees(+30.17427852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155091"},
        {"Hipparcos Number", "HIP 83856"},
        {"Smithsonian Astrophysical Observation", "SAO 65816"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.07007312),
        dec: Angle.Degrees(+30.17483713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70518"},
        {"Hipparcos Number", "HIP 41124"},
        {"Geneva Identification System", "GEN# +1.00070518"},
        {"Smithsonian Astrophysical Observation", "SAO 60777"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.86828871),
        dec: Angle.Degrees(+30.17612591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192517"},
        {"Hipparcos Number", "HIP 99746"},
        {"Celescope Catalog", "CEL 4984"},
        {"Geneva Identification System", "GEN# +1.00192517"},
        {"Renson", "Renson 53655"},
        {"Smithsonian Astrophysical Observation", "SAO 69660"},
        {"Wilson Evans Batten Catalogue", "WEB 17902"},
    },
    visualMagnitude: 7.12,
    bvColour: -0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.57743104),
        dec: Angle.Degrees(+30.17727039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176377"},
        {"Hipparcos Number", "HIP 93185"},
        {"Geneva Identification System", "GEN# +1.00176377"},
        {"Smithsonian Astrophysical Observation", "SAO 67661"},
        {"Wilson Evans Batten Catalogue", "WEB 16147"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.71235563),
        dec: Angle.Degrees(+30.18017204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 194.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74827",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74827"},
        {"Smithsonian Astrophysical Observation", "SAO 64613"},
    },
    visualMagnitude: 9.89,
    bvColour: 1.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.38641463),
        dec: Angle.Degrees(+30.18145569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17801"},
        {"Hipparcos Number", "HIP 13395"},
        {"Smithsonian Astrophysical Observation", "SAO 75614"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.09625044),
        dec: Angle.Degrees(+30.18165816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7229",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7229"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.28827097),
        dec: Angle.Degrees(+30.18307057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 169.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35958",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35958"},
        {"Smithsonian Astrophysical Observation", "SAO 60058"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.18727338),
        dec: Angle.Degrees(+30.18364832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 249962"},
        {"Hipparcos Number", "HIP 28402"},
        {"Renson", "Renson 10797"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.97914171),
        dec: Angle.Degrees(+30.18598109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168011"},
        {"Hipparcos Number", "HIP 89563"},
        {"Smithsonian Astrophysical Observation", "SAO 66817"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.13722615),
        dec: Angle.Degrees(+30.18617954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184150"},
        {"Hipparcos Number", "HIP 96063"},
        {"Smithsonian Astrophysical Observation", "SAO 68449"},
        {"Wilson Evans Batten Catalogue", "WEB 16826"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.98333889),
        dec: Angle.Degrees(+30.18790215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14373"},
        {"Hipparcos Number", "HIP 10884"},
        {"Smithsonian Astrophysical Observation", "SAO 75287"},
        {"Wilson Evans Batten Catalogue", "WEB 2294"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.01851742),
        dec: Angle.Degrees(+30.18817435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164136"},
        {"Hipparcos Number", "HIP 87998"},
        {"Geneva Identification System", "GEN# +1.00164136"},
        {"Renson", "Renson 46397"},
        {"Smithsonian Astrophysical Observation", "SAO 66524"},
        {"Wilson Evans Batten Catalogue", "WEB 14859"},
    },
    visualMagnitude: 4.41,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.62562385),
        dec: Angle.Degrees(+30.18926892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207946"},
        {"Hipparcos Number", "HIP 107944"},
        {"Smithsonian Astrophysical Observation", "SAO 90058"},
    },
    visualMagnitude: 7.91,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.02947356),
        dec: Angle.Degrees(+30.19108933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242029"},
        {"Hipparcos Number", "HIP 24557"},
        {"Smithsonian Astrophysical Observation", "SAO 57814"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.03235728),
        dec: Angle.Degrees(+30.19135381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197207"},
        {"Hipparcos Number", "HIP 102081"},
        {"Geneva Identification System", "GEN# +1.00197207"},
        {"Smithsonian Astrophysical Observation", "SAO 70368"},
        {"Wilson Evans Batten Catalogue", "WEB 18461"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.32542909),
        dec: Angle.Degrees(+30.19136604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 231.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109497"},
        {"Hipparcos Number", "HIP 61409"},
        {"Geneva Identification System", "GEN# +1.00109497"},
        {"Smithsonian Astrophysical Observation", "SAO 63077"},
        {"Wilson Evans Batten Catalogue", "WEB 10930"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.75158198),
        dec: Angle.Degrees(+30.19275013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17777"},
        {"Hipparcos Number", "HIP 13374"},
        {"Geneva Identification System", "GEN# +1.00017777"},
        {"Smithsonian Astrophysical Observation", "SAO 75608"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.02041803),
        dec: Angle.Degrees(+30.19293242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19079"},
        {"Hipparcos Number", "HIP 14353"},
        {"Geneva Identification System", "GEN# +1.00019079"},
        {"Smithsonian Astrophysical Observation", "SAO 56141"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.28546151),
        dec: Angle.Degrees(+30.19439534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98017",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13117 A"},
        {"Henry Draper", "HD 188651"},
        {"Hipparcos Number", "HIP 98017"},
        {"Celescope Catalog", "CEL 4876"},
        {"Geneva Identification System", "GEN# +1.00188651A"},
        {"Smithsonian Astrophysical Observation", "SAO 69079"},
        {"Wilson Evans Batten Catalogue", "WEB 17260"},
    },
    visualMagnitude: 6.58,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.77707755),
        dec: Angle.Degrees(+30.19489579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46009",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46009"},
        {"Smithsonian Astrophysical Observation", "SAO 61434"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.75050444),
        dec: Angle.Degrees(+30.19712738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110949"},
        {"Hipparcos Number", "HIP 62256"},
        {"Geneva Identification System", "GEN# +1.00110949"},
        {"Smithsonian Astrophysical Observation", "SAO 63179"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.37417228),
        dec: Angle.Degrees(+30.19779634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2102",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2102"},
        {"Geneva Identification System", "GEN# +0.02900071"},
        {"Smithsonian Astrophysical Observation", "SAO 73989"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.66796380),
        dec: Angle.Degrees(+30.19982954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 254.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92455"},
        {"Hipparcos Number", "HIP 52275"},
        {"Smithsonian Astrophysical Observation", "SAO 62194"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.23246317),
        dec: Angle.Degrees(+30.20147289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -188.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209484"},
        {"Hipparcos Number", "HIP 108864"},
        {"Smithsonian Astrophysical Observation", "SAO 90195"},
        {"Wilson Evans Batten Catalogue", "WEB 19579"},
    },
    visualMagnitude: 7.02,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.81023865),
        dec: Angle.Degrees(+30.20319703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90041"},
        {"Hipparcos Number", "HIP 50926"},
        {"Smithsonian Astrophysical Observation", "SAO 62017"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.01028998),
        dec: Angle.Degrees(+30.20367972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121410"},
        {"Hipparcos Number", "HIP 67914"},
        {"Geneva Identification System", "GEN# +1.00121410"},
        {"Smithsonian Astrophysical Observation", "SAO 63827"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.64970244),
        dec: Angle.Degrees(+30.20438991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 334066"},
        {"Hipparcos Number", "HIP 99975"},
        {"Smithsonian Astrophysical Observation", "SAO 69744"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.23747031),
        dec: Angle.Degrees(+30.20465297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193816"},
        {"Hipparcos Number", "HIP 100371"},
        {"Smithsonian Astrophysical Observation", "SAO 69878"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.33290536),
        dec: Angle.Degrees(+30.20470423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 332812"},
        {"Hipparcos Number", "HIP 97624"},
        {"Smithsonian Astrophysical Observation", "SAO 68937"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.63053131),
        dec: Angle.Degrees(+30.20477841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104371",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14682 AB"},
        {"Henry Draper", "HD 201433"},
        {"Hipparcos Number", "HIP 104371"},
        {"Geneva Identification System", "GEN# +1.00201433"},
        {"Smithsonian Astrophysical Observation", "SAO 70968"},
        {"Wilson Evans Batten Catalogue", "WEB 19003"},
        {"Wilson Evans Batten Catalogue 2", "WEB 19002"},
    },
    visualMagnitude: 5.60,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.16196997),
        dec: Angle.Degrees(+30.20568797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139859"},
        {"Hipparcos Number", "HIP 76677"},
        {"Smithsonian Astrophysical Observation", "SAO 64830"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.86018447),
        dec: Angle.Degrees(+30.20733563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55054",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55054"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.05954846),
        dec: Angle.Degrees(+30.20759707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35600"},
        {"Hipparcos Number", "HIP 25492"},
        {"Celescope Catalog", "CEL 698"},
        {"Geneva Identification System", "GEN# +1.00035600"},
        {"Smithsonian Astrophysical Observation", "SAO 58040"},
        {"Wilson Evans Batten Catalogue", "WEB 4942"},
    },
    visualMagnitude: 5.69,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.78446999),
        dec: Angle.Degrees(+30.20861412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41624",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41624"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.28979021),
        dec: Angle.Degrees(+30.21059904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4059"},
        {"Hipparcos Number", "HIP 3396"},
        {"Smithsonian Astrophysical Observation", "SAO 74222"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.82039992),
        dec: Angle.Degrees(+30.21109458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47629"},
        {"Hipparcos Number", "HIP 31969"},
        {"Smithsonian Astrophysical Observation", "SAO 59354"},
    },
    visualMagnitude: 8.22,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.21906946),
        dec: Angle.Degrees(+30.21142116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84853",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84853"},
        {"Smithsonian Astrophysical Observation", "SAO 65958"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.13463766),
        dec: Angle.Degrees(+30.21586224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 333663"},
        {"Hipparcos Number", "HIP 99315"},
        {"Geneva Identification System", "GEN# +1.00333663"},
        {"Smithsonian Astrophysical Observation", "SAO 69516"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.39003884),
        dec: Angle.Degrees(+30.21610953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114249",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114249"},
        {"Smithsonian Astrophysical Observation", "SAO 91035"},
        {"Wilson Evans Batten Catalogue", "WEB 20289"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.07780008),
        dec: Angle.Degrees(+30.21660876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124642"},
        {"Hipparcos Number", "HIP 69526"},
        {"Cincinnati Publication", "Ci 18 1868"},
        {"Cincinnati Publication 2", "Ci 20 841"},
        {"Geneva Identification System", "GEN# +1.00124642"},
        {"Smithsonian Astrophysical Observation", "SAO 64005"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.48894486),
        dec: Angle.Degrees(+30.21676092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -398.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 175.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104130",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104130"},
        {"Smithsonian Astrophysical Observation", "SAO 70897"},
        {"Wilson Evans Batten Catalogue", "WEB 18966"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.45476736),
        dec: Angle.Degrees(+30.21727409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76009"},
        {"Hipparcos Number", "HIP 43732"},
        {"Geneva Identification System", "GEN# +1.00076009"},
        {"Smithsonian Astrophysical Observation", "SAO 61127"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.59745334),
        dec: Angle.Degrees(+30.21781666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33570"},
        {"Hipparcos Number", "HIP 24258"},
        {"Smithsonian Astrophysical Observation", "SAO 57740"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.11036721),
        dec: Angle.Degrees(+30.21789278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189943"},
        {"Hipparcos Number", "HIP 98587"},
        {"Geneva Identification System", "GEN# +1.00189943"},
        {"Smithsonian Astrophysical Observation", "SAO 69272"},
        {"Wilson Evans Batten Catalogue", "WEB 17430"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.38235814),
        dec: Angle.Degrees(+30.21811313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97304"},
        {"Hipparcos Number", "HIP 54729"},
        {"Smithsonian Astrophysical Observation", "SAO 62447"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.07279832),
        dec: Angle.Degrees(+30.21902623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112158",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Matar"},
        {"Aitken", "ADS 16211 A"},
        {"Henry Draper", "HD 215182"},
        {"Hipparcos Number", "HIP 112158"},
        {"Fundamental Katalog 5th Edition", "FK5 857"},
        {"Geneva Identification System", "GEN# +1.00215182"},
        {"Smithsonian Astrophysical Observation", "SAO 90734"},
        {"Wilson Evans Batten Catalogue", "WEB 20017"},
    },
    visualMagnitude: 2.93,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.75053573),
        dec: Angle.Degrees(+30.22130866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69321",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69321"},
        {"Smithsonian Astrophysical Observation", "SAO 63980"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.82220891),
        dec: Angle.Degrees(+30.22397867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245684"},
        {"Hipparcos Number", "HIP 26550"},
        {"Geneva Identification System", "GEN# +1.00245684"},
        {"Smithsonian Astrophysical Observation", "SAO 58284"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.68696447),
        dec: Angle.Degrees(+30.22399201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202109"},
        {"Hipparcos Number", "HIP 104732"},
        {"Fundamental Katalog 5th Edition", "FK5 797"},
        {"Geneva Identification System", "GEN# +1.00202109"},
        {"Smithsonian Astrophysical Observation", "SAO 71070"},
        {"Wilson Evans Batten Catalogue", "WEB 19047"},
    },
    visualMagnitude: 3.21,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.23408977),
        dec: Angle.Degrees(+30.22708128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244981"},
        {"Hipparcos Number", "HIP 26208"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.78711545),
        dec: Angle.Degrees(+30.22835035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208276"},
        {"Hipparcos Number", "HIP 108136"},
        {"Smithsonian Astrophysical Observation", "SAO 90090"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.62554873),
        dec: Angle.Degrees(+30.22908566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147250"},
        {"Hipparcos Number", "HIP 79986"},
        {"Smithsonian Astrophysical Observation", "SAO 65230"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.90527174),
        dec: Angle.Degrees(+30.23097309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186441"},
        {"Hipparcos Number", "HIP 97035"},
        {"Celescope Catalog", "CEL 4827"},
        {"Geneva Identification System", "GEN# +1.00186441"},
        {"Smithsonian Astrophysical Observation", "SAO 68745"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.81291099),
        dec: Angle.Degrees(+30.23236786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57395",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57395"},
    },
    visualMagnitude: 11.60,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.49835470),
        dec: Angle.Degrees(+30.23322637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -180.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 103.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162687"},
        {"Hipparcos Number", "HIP 87362"},
        {"Smithsonian Astrophysical Observation", "SAO 66381"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.76506267),
        dec: Angle.Degrees(+30.23373918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44031",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7107 AB"},
        {"Henry Draper", "HD 76572"},
        {"Hipparcos Number", "HIP 44031"},
        {"Geneva Identification System", "GEN# +1.00076572"},
        {"Smithsonian Astrophysical Observation", "SAO 61157"},
        {"Wilson Evans Batten Catalogue", "WEB 8463"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.49430922),
        dec: Angle.Degrees(+30.23375878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28777",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4646 A"},
        {"Henry Draper", "HD 41163"},
        {"Hipparcos Number", "HIP 28777"},
        {"Smithsonian Astrophysical Observation", "SAO 58711"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.14268079),
        dec: Angle.Degrees(+30.23445877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243129"},
        {"Hipparcos Number", "HIP 25237"},
        {"Smithsonian Astrophysical Observation", "SAO 57973"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.96357833),
        dec: Angle.Degrees(+30.23671257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44176",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44176"},
        {"Geneva Identification System", "GEN# +0.03001801"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.97606726),
        dec: Angle.Degrees(+30.23726763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 286.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -414.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5850",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5850"},
        {"Smithsonian Astrophysical Observation", "SAO 74587"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.75875392),
        dec: Angle.Degrees(+30.23739495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28774",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4646 B"},
        {"Henry Draper", "HD 250962"},
        {"Hipparcos Number", "HIP 28774"},
        {"Renson", "Renson 11003"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.13697956),
        dec: Angle.Degrees(+30.23844163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100204"},
        {"Hipparcos Number", "HIP 56265"},
        {"Geneva Identification System", "GEN# +1.00100204"},
        {"Smithsonian Astrophysical Observation", "SAO 62588"},
        {"Wilson Evans Batten Catalogue", "WEB 10117"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.99995738),
        dec: Angle.Degrees(+30.23863007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211959"},
        {"Hipparcos Number", "HIP 110281"},
        {"Smithsonian Astrophysical Observation", "SAO 90428"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.07364910),
        dec: Angle.Degrees(+30.23904412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52758",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52758"},
        {"Smithsonian Astrophysical Observation", "SAO 62251"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.80983006),
        dec: Angle.Degrees(+30.24221070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94933",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94933"},
        {"Smithsonian Astrophysical Observation", "SAO 68122"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.76360563),
        dec: Angle.Degrees(+30.24312316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114254"},
        {"Hipparcos Number", "HIP 64172"},
        {"Geneva Identification System", "GEN# +1.00114254"},
        {"Smithsonian Astrophysical Observation", "SAO 63367"},
        {"Wilson Evans Batten Catalogue", "WEB 11342"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.27698829),
        dec: Angle.Degrees(+30.24372294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243504"},
        {"Hipparcos Number", "HIP 25418"},
        {"Smithsonian Astrophysical Observation", "SAO 58022"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.54956225),
        dec: Angle.Degrees(+30.24459018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158488"},
        {"Hipparcos Number", "HIP 85498"},
        {"Smithsonian Astrophysical Observation", "SAO 66074"},
    },
    visualMagnitude: 8.20,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.08878829),
        dec: Angle.Degrees(+30.24520260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34693",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5846 AB"},
        {"Henry Draper", "HD 54719"},
        {"Hipparcos Number", "HIP 34693"},
        {"Geneva Identification System", "GEN# +1.00054719J"},
        {"Smithsonian Astrophysical Observation", "SAO 59858"},
        {"Wilson Evans Batten Catalogue", "WEB 6934"},
    },
    visualMagnitude: 4.41,
    bvColour: 1.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.78496505),
        dec: Angle.Degrees(+30.24528065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35582"},
        {"Smithsonian Astrophysical Observation", "SAO 59988"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.14629639),
        dec: Angle.Degrees(+30.24884452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107054"},
        {"Henry Draper 2", "HD 107055"},
        {"Hipparcos Number", "HIP 60018"},
        {"Fundamental Katalog 5th Edition", "FK5 2984"},
        {"Geneva Identification System", "GEN# +1.00107054"},
        {"Smithsonian Astrophysical Observation", "SAO 62943"},
        {"Wilson Evans Batten Catalogue", "WEB 10666"},
    },
    visualMagnitude: 6.23,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.63153600),
        dec: Angle.Degrees(+30.24933506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30182",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30182"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.25471734),
        dec: Angle.Degrees(+30.25273439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51957",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51957"},
        {"Smithsonian Astrophysical Observation", "SAO 62154"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.21023642),
        dec: Angle.Degrees(+30.25284752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196243"},
        {"Hipparcos Number", "HIP 101575"},
        {"Smithsonian Astrophysical Observation", "SAO 70232"},
        {"Wilson Evans Batten Catalogue", "WEB 18353"},
    },
    visualMagnitude: 7.60,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.78101199),
        dec: Angle.Degrees(+30.25286608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160542"},
        {"Hipparcos Number", "HIP 86399"},
        {"Geneva Identification System", "GEN# +1.00160542"},
        {"Smithsonian Astrophysical Observation", "SAO 66220"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.81640251),
        dec: Angle.Degrees(+30.25346748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178450"},
        {"Hipparcos Number", "HIP 93926"},
        {"Geneva Identification System", "GEN# +1.00178450"},
        {"Smithsonian Astrophysical Observation", "SAO 67836"},
        {"Wilson Evans Batten Catalogue", "WEB 16346"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.88463423),
        dec: Angle.Degrees(+30.25424179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 103.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105700",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14950 AB"},
        {"Hipparcos Number", "HIP 105700"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.12823816),
        dec: Angle.Degrees(+30.25486531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66608",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66608"},
    },
    visualMagnitude: 11.88,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.80105923),
        dec: Angle.Degrees(+30.25540207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39200",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39200"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.27843873),
        dec: Angle.Degrees(+30.25681418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186860"},
        {"Hipparcos Number", "HIP 97235"},
        {"Geneva Identification System", "GEN# +1.00186860"},
        {"Smithsonian Astrophysical Observation", "SAO 68801"},
        {"Wilson Evans Batten Catalogue", "WEB 17072"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.42877540),
        dec: Angle.Degrees(+30.25709720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242386"},
        {"Hipparcos Number", "HIP 24759"},
        {"Geneva Identification System", "GEN# +1.00242386"},
        {"Smithsonian Astrophysical Observation", "SAO 57871"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.62636796),
        dec: Angle.Degrees(+30.25823965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88717",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88717"},
        {"Smithsonian Astrophysical Observation", "SAO 66636"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.66905489),
        dec: Angle.Degrees(+30.25952010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127738"},
        {"Hipparcos Number", "HIP 71092"},
        {"Smithsonian Astrophysical Observation", "SAO 64205"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.07654241),
        dec: Angle.Degrees(+30.26003165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 259661"},
        {"Hipparcos Number", "HIP 31389"},
        {"Smithsonian Astrophysical Observation", "SAO 59252"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.70463767),
        dec: Angle.Degrees(+30.26061188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195666"},
        {"Hipparcos Number", "HIP 101278"},
        {"Smithsonian Astrophysical Observation", "SAO 70154"},
        {"Wilson Evans Batten Catalogue", "WEB 18299"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.93177528),
        dec: Angle.Degrees(+30.26084382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63611"},
        {"Hipparcos Number", "HIP 38318"},
        {"Geneva Identification System", "GEN# +1.00063611"},
        {"Smithsonian Astrophysical Observation", "SAO 60382"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.75561026),
        dec: Angle.Degrees(+30.26190476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148284"},
        {"Hipparcos Number", "HIP 80489"},
        {"Smithsonian Astrophysical Observation", "SAO 65293"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.45180443),
        dec: Angle.Degrees(+30.26532747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4402",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4402"},
        {"Fundamental Katalog 5th Edition", "FK5 4084"},
        {"Smithsonian Astrophysical Observation", "SAO 74378"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.11340615),
        dec: Angle.Degrees(+30.26559258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197395"},
        {"Hipparcos Number", "HIP 102196"},
        {"Smithsonian Astrophysical Observation", "SAO 70404"},
        {"Wilson Evans Batten Catalogue", "WEB 18491"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.60844833),
        dec: Angle.Degrees(+30.26700580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182292"},
        {"Hipparcos Number", "HIP 95249"},
        {"Smithsonian Astrophysical Observation", "SAO 68221"},
        {"Wilson Evans Batten Catalogue", "WEB 16646"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.69417750),
        dec: Angle.Degrees(+30.27107018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68922",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68922"},
        {"Smithsonian Astrophysical Observation", "SAO 63934"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.65071785),
        dec: Angle.Degrees(+30.27234400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150681"},
        {"Hipparcos Number", "HIP 81704"},
        {"Geneva Identification System", "GEN# +1.00150681"},
        {"Smithsonian Astrophysical Observation", "SAO 65486"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.33976148),
        dec: Angle.Degrees(+30.27320291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25834"},
        {"Hipparcos Number", "HIP 19197"},
        {"Geneva Identification System", "GEN# +1.00025834"},
        {"Smithsonian Astrophysical Observation", "SAO 56974"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.71734353),
        dec: Angle.Degrees(+30.27339290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191766"},
        {"Hipparcos Number", "HIP 99401"},
        {"Geneva Identification System", "GEN# +1.00191766"},
        {"Smithsonian Astrophysical Observation", "SAO 69547"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.63372981),
        dec: Angle.Degrees(+30.27369220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105424"},
        {"Hipparcos Number", "HIP 59185"},
        {"Geneva Identification System", "GEN# +1.00105424"},
        {"Smithsonian Astrophysical Observation", "SAO 62856"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.06422725),
        dec: Angle.Degrees(+30.27537278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47361",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47361"},
        {"Fundamental Katalog 5th Edition", "FK5 4855"},
        {"Smithsonian Astrophysical Observation", "SAO 61616"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.74721957),
        dec: Angle.Degrees(+30.27545245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48912"},
        {"Hipparcos Number", "HIP 32512"},
        {"Wilson Evans Batten Catalogue", "WEB 6558"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.77938656),
        dec: Angle.Degrees(+30.27623230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86277",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86277"},
        {"Smithsonian Astrophysical Observation", "SAO 66193"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.43651345),
        dec: Angle.Degrees(+30.27772086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20726"},
        {"Hipparcos Number", "HIP 15637"},
        {"Smithsonian Astrophysical Observation", "SAO 56373"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.33245803),
        dec: Angle.Degrees(+30.27798963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204921"},
        {"Hipparcos Number", "HIP 106240"},
        {"Geneva Identification System", "GEN# +1.00204921"},
        {"Smithsonian Astrophysical Observation", "SAO 71419"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.78450035),
        dec: Angle.Degrees(+30.27881674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57382"},
        {"Hipparcos Number", "HIP 35721"},
        {"Smithsonian Astrophysical Observation", "SAO 60016"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.54263876),
        dec: Angle.Degrees(+30.27980921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113339"},
        {"Hipparcos Number", "HIP 63644"},
        {"Geneva Identification System", "GEN# +1.00113339"},
        {"Smithsonian Astrophysical Observation", "SAO 63315"},
        {"Wilson Evans Batten Catalogue", "WEB 11264"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.65939435),
        dec: Angle.Degrees(+30.28099327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1614",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1614"},
        {"Smithsonian Astrophysical Observation", "SAO 53819"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.04636989),
        dec: Angle.Degrees(+30.28116896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138734"},
        {"Hipparcos Number", "HIP 76128"},
        {"Smithsonian Astrophysical Observation", "SAO 64768"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.23554228),
        dec: Angle.Degrees(+30.28118879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90273",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90273"},
    },
    visualMagnitude: 11.69,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.29113100),
        dec: Angle.Degrees(+30.28168748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 257.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282433"},
        {"Hipparcos Number", "HIP 22108"},
        {"Geneva Identification System", "GEN# +1.00282433"},
        {"Smithsonian Astrophysical Observation", "SAO 57416"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.36983222),
        dec: Angle.Degrees(+30.28178436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106223"},
        {"Hipparcos Number", "HIP 59594"},
        {"Geneva Identification System", "GEN# +1.00106223"},
        {"Smithsonian Astrophysical Observation", "SAO 62899"},
        {"Wilson Evans Batten Catalogue", "WEB 10591"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.32059927),
        dec: Angle.Degrees(+30.28299279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44687",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44687"},
        {"Geneva Identification System", "GEN# +0.03001814"},
    },
    visualMagnitude: 10.69,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.59747871),
        dec: Angle.Degrees(+30.28412923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -156.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -263.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 268542"},
        {"Hipparcos Number", "HIP 34145"},
        {"Smithsonian Astrophysical Observation", "SAO 59752"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.20446581),
        dec: Angle.Degrees(+30.28530401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 257670"},
        {"Hipparcos Number", "HIP 30855"},
        {"Geneva Identification System", "GEN# +1.00257670"},
        {"Smithsonian Astrophysical Observation", "SAO 59132"},
        {"Wilson Evans Batten Catalogue", "WEB 6147"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.18253477),
        dec: Angle.Degrees(+30.28542999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96182",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96182"},
        {"Smithsonian Astrophysical Observation", "SAO 68485"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.34897708),
        dec: Angle.Degrees(+30.28611894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51833"},
        {"Hipparcos Number", "HIP 33706"},
        {"Smithsonian Astrophysical Observation", "SAO 59678"},
        {"Wilson Evans Batten Catalogue", "WEB 6771"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.04291218),
        dec: Angle.Degrees(+30.28627614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17674"},
        {"Hipparcos Number", "HIP 13291"},
        {"Geneva Identification System", "GEN# +1.00017674"},
        {"Smithsonian Astrophysical Observation", "SAO 55940"},
        {"Wilson Evans Batten Catalogue", "WEB 2668"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.76749511),
        dec: Angle.Degrees(+30.28682012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169551"},
        {"Hipparcos Number", "HIP 90164"},
        {"Smithsonian Astrophysical Observation", "SAO 66930"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.98867362),
        dec: Angle.Degrees(+30.28802807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75312",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9617 AB"},
        {"Henry Draper", "HD 137107J"},
        {"Hipparcos Number", "HIP 75312"},
        {"Geneva Identification System", "GEN# +1.00137107"},
        {"Smithsonian Astrophysical Observation", "SAO 64673"},
    },
    visualMagnitude: 4.99,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.80094284),
        dec: Angle.Degrees(+30.28824114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195531"},
        {"Hipparcos Number", "HIP 101207"},
        {"Smithsonian Astrophysical Observation", "SAO 70130"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.72422924),
        dec: Angle.Degrees(+30.29066008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91635",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11579 C"},
        {"Hipparcos Number", "HIP 91635"},
        {"Geneva Identification System", "GEN# +1.00172865C"},
        {"Wilson Evans Batten Catalogue", "WEB 15759"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.31720791),
        dec: Angle.Degrees(+30.29085034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94349"},
        {"Hipparcos Number", "HIP 53275"},
        {"Geneva Identification System", "GEN# +1.00094349"},
        {"Smithsonian Astrophysical Observation", "SAO 62299"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.43769922),
        dec: Angle.Degrees(+30.29114181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29581"},
        {"Hipparcos Number", "HIP 21783"},
        {"Geneva Identification System", "GEN# +1.00029581"},
        {"Smithsonian Astrophysical Observation", "SAO 57371"},
        {"Wilson Evans Batten Catalogue", "WEB 4191"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.19491813),
        dec: Angle.Degrees(+30.29165647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116287"},
        {"Hipparcos Number", "HIP 65245"},
        {"Geneva Identification System", "GEN# +1.00116287"},
        {"Smithsonian Astrophysical Observation", "SAO 63499"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.56277875),
        dec: Angle.Degrees(+30.29202053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87900",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87900"},
        {"Geneva Identification System", "GEN# +0.03003089"},
        {"Smithsonian Astrophysical Observation", "SAO 66501"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.33082807),
        dec: Angle.Degrees(+30.29286307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91636",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11579 AB"},
        {"Henry Draper", "HD 172865"},
        {"Hipparcos Number", "HIP 91636"},
        {"Geneva Identification System", "GEN# +1.00172865J"},
        {"Smithsonian Astrophysical Observation", "SAO 67250"},
        {"Wilson Evans Batten Catalogue", "WEB 15758"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.31815697),
        dec: Angle.Degrees(+30.29469963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130002"},
        {"Hipparcos Number", "HIP 72098"},
        {"Smithsonian Astrophysical Observation", "SAO 64303"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.23233159),
        dec: Angle.Degrees(+30.29493508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191356"},
        {"Hipparcos Number", "HIP 99206"},
        {"Geneva Identification System", "GEN# +1.00191356"},
        {"Smithsonian Astrophysical Observation", "SAO 69478"},
        {"Wilson Evans Batten Catalogue", "WEB 17667"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.10227509),
        dec: Angle.Degrees(+30.29693931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206385"},
        {"Hipparcos Number", "HIP 107059"},
        {"Smithsonian Astrophysical Observation", "SAO 71590"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.25140575),
        dec: Angle.Degrees(+30.29736634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246363"},
        {"Hipparcos Number", "HIP 26854"},
        {"Geneva Identification System", "GEN# +1.00246363"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.52046283),
        dec: Angle.Degrees(+30.29952688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79007"},
        {"Hipparcos Number", "HIP 45175"},
        {"Smithsonian Astrophysical Observation", "SAO 61331"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.08633912),
        dec: Angle.Degrees(+30.29993324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178798"},
        {"Hipparcos Number", "HIP 94052"},
        {"Smithsonian Astrophysical Observation", "SAO 67869"},
        {"Wilson Evans Batten Catalogue", "WEB 16374"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.21644540),
        dec: Angle.Degrees(+30.30100628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156224"},
        {"Hipparcos Number", "HIP 84392"},
        {"Geneva Identification System", "GEN# +1.00156224"},
        {"Smithsonian Astrophysical Observation", "SAO 65889"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.80624473),
        dec: Angle.Degrees(+30.30125112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10280",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1697 AB"},
        {"Henry Draper", "HD 13480"},
        {"Hipparcos Number", "HIP 10280"},
        {"Geneva Identification System", "GEN# +1.00013480"},
        {"Smithsonian Astrophysical Observation", "SAO 55347"},
        {"Wilson Evans Batten Catalogue", "WEB 2141"},
    },
    visualMagnitude: 4.94,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.09301632),
        dec: Angle.Degrees(+30.30321507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47376"},
        {"Hipparcos Number", "HIP 31853"},
        {"Smithsonian Astrophysical Observation", "SAO 59337"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.89067649),
        dec: Angle.Degrees(+30.30396971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66620",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66620"},
        {"Smithsonian Astrophysical Observation", "SAO 63666"},
    },
    visualMagnitude: 10.86,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.83597967),
        dec: Angle.Degrees(+30.30406789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282477"},
        {"Hipparcos Number", "HIP 22410"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.846,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.33438695),
        dec: Angle.Degrees(+30.30654167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203630"},
        {"Hipparcos Number", "HIP 105558"},
        {"Geneva Identification System", "GEN# +1.00203630"},
        {"Smithsonian Astrophysical Observation", "SAO 71259"},
        {"Wilson Evans Batten Catalogue", "WEB 19163"},
    },
    visualMagnitude: 6.07,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.67513322),
        dec: Angle.Degrees(+30.30986401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175785"},
        {"Hipparcos Number", "HIP 92911"},
        {"Celescope Catalog", "CEL 4669"},
        {"Geneva Identification System", "GEN# +1.00175785"},
        {"Smithsonian Astrophysical Observation", "SAO 67588"},
        {"Wilson Evans Batten Catalogue", "WEB 16087"},
    },
    visualMagnitude: 7.62,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.95517563),
        dec: Angle.Degrees(+30.31207037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51487",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51487"},
        {"Smithsonian Astrophysical Observation", "SAO 62092"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.74011077),
        dec: Angle.Degrees(+30.31296646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83018",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83018"},
        {"Smithsonian Astrophysical Observation", "SAO 65676"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.47101761),
        dec: Angle.Degrees(+30.31315273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206899"},
        {"Hipparcos Number", "HIP 107341"},
        {"Smithsonian Astrophysical Observation", "SAO 71655"},
        {"Wilson Evans Batten Catalogue", "WEB 19382"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.11139386),
        dec: Angle.Degrees(+30.31335174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5584"},
        {"Hipparcos Number", "HIP 4531"},
        {"Smithsonian Astrophysical Observation", "SAO 54298"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.50572408),
        dec: Angle.Degrees(+30.31426655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 202.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 253123"},
        {"Hipparcos Number", "HIP 29463"},
        {"Smithsonian Astrophysical Observation", "SAO 58854"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.12016226),
        dec: Angle.Degrees(+30.31610586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78299"},
        {"Hipparcos Number", "HIP 44856"},
        {"Smithsonian Astrophysical Observation", "SAO 61281"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.09810574),
        dec: Angle.Degrees(+30.31660097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210060"},
        {"Hipparcos Number", "HIP 109187"},
        {"Smithsonian Astrophysical Observation", "SAO 72041"},
        {"Wilson Evans Batten Catalogue", "WEB 19627"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.78024708),
        dec: Angle.Degrees(+30.31780389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159118"},
        {"Hipparcos Number", "HIP 85781"},
        {"Smithsonian Astrophysical Observation", "SAO 66109"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.92724045),
        dec: Angle.Degrees(+30.31813911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17119"},
        {"Hipparcos Number", "HIP 12881"},
        {"Geneva Identification System", "GEN# +1.00017119"},
        {"Smithsonian Astrophysical Observation", "SAO 55848"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.39649049),
        dec: Angle.Degrees(+30.31947253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66081",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66081"},
        {"Geneva Identification System", "GEN# +0.03102506"},
        {"Smithsonian Astrophysical Observation", "SAO 63596"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.19778144),
        dec: Angle.Degrees(+30.32136647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58727"},
        {"Hipparcos Number", "HIP 36272"},
        {"Smithsonian Astrophysical Observation", "SAO 60100"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.01819873),
        dec: Angle.Degrees(+30.32278077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85778",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 10.41,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)31, 41.0100),
        dec: Angle.DegreesMinutesSeconds((int)+30, (int)19, 23.800)
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
    primaryId: "HIP 110019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211498"},
        {"Hipparcos Number", "HIP 110019"},
        {"Geneva Identification System", "GEN# +1.00211498"},
        {"Smithsonian Astrophysical Observation", "SAO 72201"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.24986099),
        dec: Angle.Degrees(+30.32380702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134475"},
        {"Hipparcos Number", "HIP 74156"},
        {"Smithsonian Astrophysical Observation", "SAO 64522"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.28343881),
        dec: Angle.Degrees(+30.32392325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202883"},
        {"Hipparcos Number", "HIP 105147"},
        {"Geneva Identification System", "GEN# +1.00202883"},
        {"Smithsonian Astrophysical Observation", "SAO 71174"},
    },
    visualMagnitude: 8.19,
    bvColour: -0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.50120812),
        dec: Angle.Degrees(+30.32402388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14608"},
        {"Hipparcos Number", "HIP 11065"},
        {"Smithsonian Astrophysical Observation", "SAO 55496"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.60046748),
        dec: Angle.Degrees(+30.32441578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96480",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12688 A"},
        {"Henry Draper", "HD 185224"},
        {"Hipparcos Number", "HIP 96480"},
        {"Celescope Catalog", "CEL 4800"},
        {"Geneva Identification System", "GEN# +1.00185224J"},
        {"Smithsonian Astrophysical Observation", "SAO 68578"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.21747062),
        dec: Angle.Degrees(+30.32502445)
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
    primaryId: "HIP 31233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46158"},
        {"Hipparcos Number", "HIP 31233"},
        {"Geneva Identification System", "GEN# +1.00046158"},
        {"Smithsonian Astrophysical Observation", "SAO 59214"},
        {"Wilson Evans Batten Catalogue", "WEB 6240"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.26932048),
        dec: Angle.Degrees(+30.32533045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122716"},
        {"Hipparcos Number", "HIP 68627"},
        {"Geneva Identification System", "GEN# +1.00122716"},
        {"Smithsonian Astrophysical Observation", "SAO 63909"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.71660094),
        dec: Angle.Degrees(+30.32598150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98981",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13359 A"},
        {"Henry Draper", "HD 190814"},
        {"Hipparcos Number", "HIP 98981"},
        {"Smithsonian Astrophysical Observation", "SAO 69387"},
        {"Wilson Evans Batten Catalogue", "WEB 17578"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.42635854),
        dec: Angle.Degrees(+30.32784912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 264610"},
        {"Hipparcos Number", "HIP 32834"},
        {"Smithsonian Astrophysical Observation", "SAO 59541"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.67394035),
        dec: Angle.Degrees(+30.32902606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 423",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 47 A"},
        {"Henry Draper", "HD 4"},
        {"Hipparcos Number", "HIP 423"},
        {"Geneva Identification System", "GEN# +1.00000004A"},
        {"Smithsonian Astrophysical Observation", "SAO 53627"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.28858787),
        dec: Angle.Degrees(+30.32911509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85331"},
        {"Hipparcos Number", "HIP 48387"},
        {"Smithsonian Astrophysical Observation", "SAO 61721"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.95806881),
        dec: Angle.Degrees(+30.32928210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92809",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92809"},
        {"Smithsonian Astrophysical Observation", "SAO 67557"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.65897916),
        dec: Angle.Degrees(+30.32935695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113120",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113120"},
        {"Smithsonian Astrophysical Observation", "SAO 72828"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.61774898),
        dec: Angle.Degrees(+30.33116320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89883"},
        {"Hipparcos Number", "HIP 50840"},
        {"Geneva Identification System", "GEN# +1.00089883"},
        {"Smithsonian Astrophysical Observation", "SAO 62006"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.71599450),
        dec: Angle.Degrees(+30.33130295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 426",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 47 B"},
        {"Henry Draper", "HD 4B"},
        {"Hipparcos Number", "HIP 426"},
        {"Geneva Identification System", "GEN# +1.00000004B"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.29174694),
        dec: Angle.Degrees(+30.33130736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56524",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56524"},
        {"Geneva Identification System", "GEN# +0.03102280"},
        {"Smithsonian Astrophysical Observation", "SAO 62615"},
        {"Wilson Evans Batten Catalogue", "WEB 10160"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.84065535),
        dec: Angle.Degrees(+30.33149329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196852"},
        {"Hipparcos Number", "HIP 101899"},
        {"Geneva Identification System", "GEN# +1.00196852"},
        {"Smithsonian Astrophysical Observation", "SAO 70323"},
        {"Wilson Evans Batten Catalogue", "WEB 18413"},
    },
    visualMagnitude: 5.68,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.74806489),
        dec: Angle.Degrees(+30.33442469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4298"},
        {"Hipparcos Number", "HIP 3569"},
        {"Smithsonian Astrophysical Observation", "SAO 54128"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.40567201),
        dec: Angle.Degrees(+30.33634097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 230",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 230"},
        {"Smithsonian Astrophysical Observation", "SAO 53597"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.71569526),
        dec: Angle.Degrees(+30.33651580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117150",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117150"},
        {"Geneva Identification System", "GEN# +9.80130007"},
    },
    visualMagnitude: 11.73,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.24961461),
        dec: Angle.Degrees(+30.33666095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 214.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241906"},
        {"Hipparcos Number", "HIP 24501"},
        {"Smithsonian Astrophysical Observation", "SAO 57800"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.84153761),
        dec: Angle.Degrees(+30.34029103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64372"},
        {"Hipparcos Number", "HIP 38643"},
        {"Geneva Identification System", "GEN# +1.00064372"},
        {"Smithsonian Astrophysical Observation", "SAO 60437"},
        {"Wilson Evans Batten Catalogue", "WEB 7585"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.69124145),
        dec: Angle.Degrees(+30.34183344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39939",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6621 B"},
        {"Hipparcos Number", "HIP 39939"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.34789279),
        dec: Angle.Degrees(+30.34278745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24497",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24497"},
    },
    visualMagnitude: 10.55,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.83820084),
        dec: Angle.Degrees(+30.34641882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39940",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6621 A"},
        {"Henry Draper", "HD 67502"},
        {"Hipparcos Number", "HIP 39940"},
        {"Smithsonian Astrophysical Observation", "SAO 60603"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.34980640),
        dec: Angle.Degrees(+30.34700789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83955",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83955"},
        {"Smithsonian Astrophysical Observation", "SAO 65836"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.42793245),
        dec: Angle.Degrees(+30.34734215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94363",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12162 A"},
        {"Henry Draper", "HD 179709"},
        {"Hipparcos Number", "HIP 94363"},
        {"Celescope Catalog", "CEL 4720"},
        {"Geneva Identification System", "GEN# +1.00179709"},
        {"Smithsonian Astrophysical Observation", "SAO 67963"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.09834226),
        dec: Angle.Degrees(+30.34776371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5092"},
        {"Hipparcos Number", "HIP 4159"},
        {"Smithsonian Astrophysical Observation", "SAO 54231"},
        {"Wilson Evans Batten Catalogue", "WEB 743"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.28230331),
        dec: Angle.Degrees(+30.34923305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165073"},
        {"Hipparcos Number", "HIP 88387"},
        {"Geneva Identification System", "GEN# +1.00165073"},
        {"Smithsonian Astrophysical Observation", "SAO 66579"},
        {"Wilson Evans Batten Catalogue", "WEB 14940"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.73307222),
        dec: Angle.Degrees(+30.35048834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 81.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180187"},
        {"Hipparcos Number", "HIP 94530"},
        {"Smithsonian Astrophysical Observation", "SAO 68020"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.58778963),
        dec: Angle.Degrees(+30.35087228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117559",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117559"},
        {"Cincinnati Publication", "Ci 18 3127"},
        {"Geneva Identification System", "GEN# +0.02905007"},
        {"Smithsonian Astrophysical Observation", "SAO 73544"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.61537150),
        dec: Angle.Degrees(+30.35323272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 253.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155329"},
        {"Hipparcos Number", "HIP 83954"},
        {"Geneva Identification System", "GEN# +1.00155329"},
        {"Smithsonian Astrophysical Observation", "SAO 65835"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.42766846),
        dec: Angle.Degrees(+30.35407998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97034"},
        {"Hipparcos Number", "HIP 54608"},
        {"Geneva Identification System", "GEN# +1.00097034"},
        {"Smithsonian Astrophysical Observation", "SAO 62434"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.63954103),
        dec: Angle.Degrees(+30.35421170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11736"},
        {"Hipparcos Number", "HIP 8986"},
        {"Geneva Identification System", "GEN# +1.00011736"},
        {"Smithsonian Astrophysical Observation", "SAO 55100"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.95155548),
        dec: Angle.Degrees(+30.35478148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161195"},
        {"Hipparcos Number", "HIP 86706"},
        {"Renson", "Renson 45400"},
        {"Smithsonian Astrophysical Observation", "SAO 66278"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.74826279),
        dec: Angle.Degrees(+30.35680483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110462",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15883 A"},
        {"Henry Draper", "HD 212280"},
        {"Hipparcos Number", "HIP 110462"},
        {"Geneva Identification System", "GEN# +1.00212280"},
        {"Smithsonian Astrophysical Observation", "SAO 72275"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.63571666),
        dec: Angle.Degrees(+30.35749689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113284"},
        {"Hipparcos Number", "HIP 63619"},
        {"Geneva Identification System", "GEN# +1.00113284"},
        {"Smithsonian Astrophysical Observation", "SAO 63310"},
        {"Wilson Evans Batten Catalogue", "WEB 11260"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.58735412),
        dec: Angle.Degrees(+30.35750566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205202"},
        {"Hipparcos Number", "HIP 106403"},
        {"Geneva Identification System", "GEN# +1.00205202"},
        {"Smithsonian Astrophysical Observation", "SAO 71454"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.26138549),
        dec: Angle.Degrees(+30.35972547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 155.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20904",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3243 A"},
        {"Henry Draper", "HD 28271"},
        {"Hipparcos Number", "HIP 20904"},
        {"Geneva Identification System", "GEN# +1.00028271A"},
        {"Smithsonian Astrophysical Observation", "SAO 57249"},
        {"Wilson Evans Batten Catalogue", "WEB 4017"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.21656906),
        dec: Angle.Degrees(+30.36154112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53078"},
        {"Hipparcos Number", "HIP 34160"},
        {"Geneva Identification System", "GEN# +1.00053078"},
        {"Smithsonian Astrophysical Observation", "SAO 59755"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.24682552),
        dec: Angle.Degrees(+30.36235064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20907",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3243 B"},
        {"Henry Draper", "HD 28271B"},
        {"Hipparcos Number", "HIP 20907"},
        {"Geneva Identification System", "GEN# +1.00028271B"},
        {"Geneva Identification System 2", "GEN# +1.20028271"},
        {"Smithsonian Astrophysical Observation", "SAO 57250"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.21933786),
        dec: Angle.Degrees(+30.36488163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113420",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113420"},
        {"Smithsonian Astrophysical Observation", "SAO 72890"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.55625414),
        dec: Angle.Degrees(+30.36522498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113414",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113414"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.53753931),
        dec: Angle.Degrees(+30.36536726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 333092"},
        {"Hipparcos Number", "HIP 98347"},
        {"Smithsonian Astrophysical Observation", "SAO 69196"},
        {"Wilson Evans Batten Catalogue", "WEB 17353"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.72239851),
        dec: Angle.Degrees(+30.36542252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109664",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109664"},
        {"Smithsonian Astrophysical Observation", "SAO 72134"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.22986405),
        dec: Angle.Degrees(+30.36656328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193270"},
        {"Hipparcos Number", "HIP 100098"},
        {"Geneva Identification System", "GEN# +1.00193270"},
        {"Smithsonian Astrophysical Observation", "SAO 69792"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.60511049),
        dec: Angle.Degrees(+30.36744859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195295"},
        {"Hipparcos Number", "HIP 101076"},
        {"Fundamental Katalog 5th Edition", "FK5 1534"},
        {"Geneva Identification System", "GEN# +1.00195295"},
        {"Smithsonian Astrophysical Observation", "SAO 70095"},
        {"Wilson Evans Batten Catalogue", "WEB 18253"},
    },
    visualMagnitude: 4.01,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.34887900),
        dec: Angle.Degrees(+30.36855661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43926"},
        {"Hipparcos Number", "HIP 30115"},
        {"Geneva Identification System", "GEN# +1.00043926"},
        {"Smithsonian Astrophysical Observation", "SAO 58993"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.06086258),
        dec: Angle.Degrees(+30.36938324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194863"},
        {"Hipparcos Number", "HIP 100857"},
        {"Celescope Catalog", "CEL 5065"},
        {"Geneva Identification System", "GEN# +1.00194863"},
        {"Smithsonian Astrophysical Observation", "SAO 70036"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.74212665),
        dec: Angle.Degrees(+30.36965166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163219"},
        {"Hipparcos Number", "HIP 87610"},
        {"Geneva Identification System", "GEN# +1.00163219"},
        {"Smithsonian Astrophysical Observation", "SAO 66443"},
        {"Wilson Evans Batten Catalogue", "WEB 14783"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.45708409),
        dec: Angle.Degrees(+30.37037911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63231",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8716 AB"},
        {"Henry Draper", "HD 112571"},
        {"Hipparcos Number", "HIP 63231"},
        {"Geneva Identification System", "GEN# +1.00112571J"},
        {"Smithsonian Astrophysical Observation", "SAO 63265"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.35104450),
        dec: Angle.Degrees(+30.37096485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71053",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9296 A"},
        {"Henry Draper", "HD 127665"},
        {"Hipparcos Number", "HIP 71053"},
        {"Fundamental Katalog 5th Edition", "FK5 534"},
        {"Geneva Identification System", "GEN# +1.00127665"},
        {"Smithsonian Astrophysical Observation", "SAO 64202"},
        {"Wilson Evans Batten Catalogue", "WEB 12288"},
    },
    visualMagnitude: 3.57,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.95774098),
        dec: Angle.Degrees(+30.37114497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90164"},
        {"Hipparcos Number", "HIP 50997"},
        {"Geneva Identification System", "GEN# +1.00090164"},
        {"Smithsonian Astrophysical Observation", "SAO 62028"},
        {"Wilson Evans Batten Catalogue", "WEB 9327"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.25672922),
        dec: Angle.Degrees(+30.37155203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219627"},
        {"Hipparcos Number", "HIP 114949"},
        {"Smithsonian Astrophysical Observation", "SAO 73137"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.24137611),
        dec: Angle.Degrees(+30.37389386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79800"},
        {"Hipparcos Number", "HIP 45549"},
        {"Smithsonian Astrophysical Observation", "SAO 61378"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.25435906),
        dec: Angle.Degrees(+30.37463517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21483"},
        {"Hipparcos Number", "HIP 16203"},
        {"Fundamental Katalog 5th Edition", "FK5 4315"},
        {"Geneva Identification System", "GEN# +1.00021483"},
        {"Smithsonian Astrophysical Observation", "SAO 56488"},
        {"Wilson Evans Batten Catalogue", "WEB 3087"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.19438591),
        dec: Angle.Degrees(+30.37536712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201490"},
        {"Hipparcos Number", "HIP 104421"},
        {"Geneva Identification System", "GEN# +1.00201490"},
        {"Smithsonian Astrophysical Observation", "SAO 70975"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.29414128),
        dec: Angle.Degrees(+30.37642794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174665"},
        {"Hipparcos Number", "HIP 92439"},
        {"Smithsonian Astrophysical Observation", "SAO 67454"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.57742603),
        dec: Angle.Degrees(+30.37693020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34414"},
        {"Hipparcos Number", "HIP 24755"},
        {"Smithsonian Astrophysical Observation", "SAO 57870"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.61946555),
        dec: Angle.Degrees(+30.37763557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110248"},
        {"Hipparcos Number", "HIP 61851"},
        {"Geneva Identification System", "GEN# +1.00110248"},
        {"Renson", "Renson 32030"},
        {"Smithsonian Astrophysical Observation", "SAO 63132"},
        {"Wilson Evans Batten Catalogue", "WEB 11000"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.14596419),
        dec: Angle.Degrees(+30.37765042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165281"},
        {"Hipparcos Number", "HIP 88471"},
        {"Geneva Identification System", "GEN# +1.00165281"},
        {"Smithsonian Astrophysical Observation", "SAO 66596"},
        {"Wilson Evans Batten Catalogue", "WEB 14964"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.97264532),
        dec: Angle.Degrees(+30.37789155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -273.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59936",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59936"},
        {"Geneva Identification System", "GEN# +0.03102348"},
    },
    visualMagnitude: 10.66,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.40828029),
        dec: Angle.Degrees(+30.37799061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143453"},
        {"Hipparcos Number", "HIP 78300"},
        {"Geneva Identification System", "GEN# +1.00143453"},
        {"Smithsonian Astrophysical Observation", "SAO 65006"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.82606290),
        dec: Angle.Degrees(+30.37963420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32447"},
        {"Henry Draper 2", "HD 282867"},
        {"Hipparcos Number", "HIP 23608"},
        {"Geneva Identification System", "GEN# +1.00032447"},
        {"Smithsonian Astrophysical Observation", "SAO 57615"},
        {"Wilson Evans Batten Catalogue", "WEB 4602"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.14366255),
        dec: Angle.Degrees(+30.38036815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48158",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48158"},
        {"Smithsonian Astrophysical Observation", "SAO 61696"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.24402639),
        dec: Angle.Degrees(+30.38068164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145225"},
        {"Hipparcos Number", "HIP 79089"},
        {"Smithsonian Astrophysical Observation", "SAO 65105"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.16172524),
        dec: Angle.Degrees(+30.38239052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53193",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53193"},
        {"Smithsonian Astrophysical Observation", "SAO 62294"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.20124086),
        dec: Angle.Degrees(+30.38423914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85417"},
        {"Hipparcos Number", "HIP 48424"},
        {"Smithsonian Astrophysical Observation", "SAO 61727"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.08167382),
        dec: Angle.Degrees(+30.38596051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54182"},
        {"Hipparcos Number", "HIP 34521"},
        {"Geneva Identification System", "GEN# +1.00054182"},
        {"Smithsonian Astrophysical Observation", "SAO 59823"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.29345530),
        dec: Angle.Degrees(+30.38715217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282528"},
        {"Hipparcos Number", "HIP 22677"},
        {"Smithsonian Astrophysical Observation", "SAO 57476"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.15734461),
        dec: Angle.Degrees(+30.38847104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9483"},
        {"Hipparcos Number", "HIP 7269"},
        {"Fundamental Katalog 5th Edition", "FK5 4140"},
        {"Geneva Identification System", "GEN# +1.00009483"},
        {"Smithsonian Astrophysical Observation", "SAO 54783"},
        {"Wilson Evans Batten Catalogue", "WEB 1565"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.40449956),
        dec: Angle.Degrees(+30.38926015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1511",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1511"},
    },
    visualMagnitude: 11.61,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.70747652),
        dec: Angle.Degrees(+30.39270222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13746"},
        {"Hipparcos Number", "HIP 10453"},
        {"Smithsonian Astrophysical Observation", "SAO 55384"},
        {"Wilson Evans Batten Catalogue", "WEB 2189"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.67561862),
        dec: Angle.Degrees(+30.39479692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105696"},
        {"Hipparcos Number", "HIP 59311"},
        {"Geneva Identification System", "GEN# +1.00105696"},
        {"Smithsonian Astrophysical Observation", "SAO 62870"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.51894246),
        dec: Angle.Degrees(+30.39581368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199763"},
        {"Hipparcos Number", "HIP 103510"},
        {"Smithsonian Astrophysical Observation", "SAO 70732"},
        {"Wilson Evans Batten Catalogue", "WEB 18829"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.56471667),
        dec: Angle.Degrees(+30.39588341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224804"},
        {"Hipparcos Number", "HIP 69"},
        {"Smithsonian Astrophysical Observation", "SAO 73677"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.20137175),
        dec: Angle.Degrees(+30.39589283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1406"},
        {"Hipparcos Number", "HIP 1477"},
        {"Smithsonian Astrophysical Observation", "SAO 53800"},
        {"Wilson Evans Batten Catalogue", "WEB 269"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.58641223),
        dec: Angle.Degrees(+30.39606440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111318"},
        {"Hipparcos Number", "HIP 62479"},
        {"Geneva Identification System", "GEN# +1.00111318"},
        {"Smithsonian Astrophysical Observation", "SAO 63197"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.06379680),
        dec: Angle.Degrees(+30.39616322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220433"},
        {"Hipparcos Number", "HIP 115477"},
        {"Smithsonian Astrophysical Observation", "SAO 73218"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.88839424),
        dec: Angle.Degrees(+30.39702581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68360",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68360"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.89956471),
        dec: Angle.Degrees(+30.39818228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167856"},
        {"Hipparcos Number", "HIP 89505"},
        {"Fundamental Katalog 5th Edition", "FK5 5607"},
        {"Smithsonian Astrophysical Observation", "SAO 66804"},
        {"Wilson Evans Batten Catalogue", "WEB 15239"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.97221091),
        dec: Angle.Degrees(+30.39983546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33829"},
        {"Hipparcos Number", "HIP 24413"},
        {"Geneva Identification System", "GEN# +1.00033829"},
        {"Smithsonian Astrophysical Observation", "SAO 57780"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.56020415),
        dec: Angle.Degrees(+30.39986329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29214"},
        {"Hipparcos Number", "HIP 21516"},
        {"Geneva Identification System", "GEN# +1.00029214"},
        {"Smithsonian Astrophysical Observation", "SAO 57341"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.30994479),
        dec: Angle.Degrees(+30.40015190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91712"},
        {"Hipparcos Number", "HIP 51878"},
        {"Smithsonian Astrophysical Observation", "SAO 62144"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.98573897),
        dec: Angle.Degrees(+30.40054119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240764"},
        {"Hipparcos Number", "HIP 23873"},
        {"Wilson Evans Batten Catalogue", "WEB 4656"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.95650549),
        dec: Angle.Degrees(+30.40148699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152187"},
        {"Hipparcos Number", "HIP 82428"},
        {"Smithsonian Astrophysical Observation", "SAO 65593"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.68397905),
        dec: Angle.Degrees(+30.40245309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91863",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11624 A"},
        {"Henry Draper", "HD 173384"},
        {"Hipparcos Number", "HIP 91863"},
        {"Smithsonian Astrophysical Observation", "SAO 67290"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.92610287),
        dec: Angle.Degrees(+30.40470287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91869",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11624 B"},
        {"Hipparcos Number", "HIP 91869"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.93249962),
        dec: Angle.Degrees(+30.40752775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29259"},
        {"Hipparcos Number", "HIP 21566"},
        {"Smithsonian Astrophysical Observation", "SAO 57345"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.43885009),
        dec: Angle.Degrees(+30.40765913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16245"},
        {"Hipparcos Number", "HIP 12207"},
        {"Smithsonian Astrophysical Observation", "SAO 55716"},
        {"Wilson Evans Batten Catalogue", "WEB 2507"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.29397300),
        dec: Angle.Degrees(+30.40783978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95816",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95816"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.33447748),
        dec: Angle.Degrees(+30.40794145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6785"},
        {"Hipparcos Number", "HIP 5379"},
        {"Geneva Identification System", "GEN# +1.00006785"},
        {"Smithsonian Astrophysical Observation", "SAO 54460"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.20280868),
        dec: Angle.Degrees(+30.40798387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185755"},
        {"Hipparcos Number", "HIP 96697"},
        {"Celescope Catalog", "CEL 4808"},
        {"Geneva Identification System", "GEN# +1.00185755"},
        {"Smithsonian Astrophysical Observation", "SAO 68641"},
        {"Wilson Evans Batten Catalogue", "WEB 16965"},
    },
    visualMagnitude: 7.17,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.87403313),
        dec: Angle.Degrees(+30.40829025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206978"},
        {"Hipparcos Number", "HIP 107391"},
        {"Smithsonian Astrophysical Observation", "SAO 71666"},
        {"Wilson Evans Batten Catalogue", "WEB 19395"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.27095820),
        dec: Angle.Degrees(+30.40893746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87681",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87681"},
        {"Wilson Evans Batten Catalogue", "WEB 14799"},
    },
    visualMagnitude: 11.50,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.62999047),
        dec: Angle.Degrees(+30.41047316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102877",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14356 AB"},
        {"Henry Draper", "HD 198627"},
        {"Hipparcos Number", "HIP 102877"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.65162023),
        dec: Angle.Degrees(+30.41308748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83718",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83718"},
        {"Smithsonian Astrophysical Observation", "SAO 65791"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.65607990),
        dec: Angle.Degrees(+30.41401046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220088"},
        {"Hipparcos Number", "HIP 115271"},
        {"Geneva Identification System", "GEN# +1.00220088"},
        {"Smithsonian Astrophysical Observation", "SAO 73187"},
        {"Wilson Evans Batten Catalogue", "WEB 20420"},
    },
    visualMagnitude: 5.58,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.20626846),
        dec: Angle.Degrees(+30.41508840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34740",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34740"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.88205459),
        dec: Angle.Degrees(+30.41512429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95660"},
        {"Hipparcos Number", "HIP 54003"},
        {"Geneva Identification System", "GEN# +1.00095660"},
        {"Smithsonian Astrophysical Observation", "SAO 62372"},
        {"Wilson Evans Batten Catalogue", "WEB 9769"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.71625421),
        dec: Angle.Degrees(+30.41520557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105341"},
        {"Hipparcos Number", "HIP 59148"},
        {"Geneva Identification System", "GEN# +1.00105341"},
        {"Smithsonian Astrophysical Observation", "SAO 62849"},
        {"Wilson Evans Batten Catalogue", "WEB 10522"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.93746412),
        dec: Angle.Degrees(+30.42043979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212240"},
        {"Hipparcos Number", "HIP 110446"},
        {"Smithsonian Astrophysical Observation", "SAO 72269"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.57031249),
        dec: Angle.Degrees(+30.42071319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61591",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61591"},
        {"Geneva Identification System", "GEN# +0.03102387"},
        {"Smithsonian Astrophysical Observation", "SAO 63104"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.30975422),
        dec: Angle.Degrees(+30.42089231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86417"},
        {"Hipparcos Number", "HIP 48944"},
        {"Smithsonian Astrophysical Observation", "SAO 61791"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.77975257),
        dec: Angle.Degrees(+30.42204159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57449",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57449"},
        {"Smithsonian Astrophysical Observation", "SAO 62700"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.64882991),
        dec: Angle.Degrees(+30.42282472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95606"},
        {"Hipparcos Number", "HIP 53969"},
        {"Smithsonian Astrophysical Observation", "SAO 62369"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.60710582),
        dec: Angle.Degrees(+30.42298200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183240"},
        {"Hipparcos Number", "HIP 95650"},
        {"Celescope Catalog", "CEL 4763"},
        {"Geneva Identification System", "GEN# +1.00183240"},
        {"Smithsonian Astrophysical Observation", "SAO 68333"},
    },
    visualMagnitude: 8.41,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.84453791),
        dec: Angle.Degrees(+30.42390103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27570"},
        {"Hipparcos Number", "HIP 20415"},
        {"Geneva Identification System", "GEN# +5.20250139"},
        {"Smithsonian Astrophysical Observation", "SAO 57191"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.58597214),
        dec: Angle.Degrees(+30.42399316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56054",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8177 A"},
        {"Henry Draper", "HD 99832"},
        {"Henry Draper 2", "HD 99832A"},
        {"Hipparcos Number", "HIP 56054"},
        {"Geneva Identification System", "GEN# +1.00099832"},
        {"Smithsonian Astrophysical Observation", "SAO 62574"},
        {"Wilson Evans Batten Catalogue", "WEB 10063"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.32838355),
        dec: Angle.Degrees(+30.42487152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335336"},
        {"Hipparcos Number", "HIP 103364"},
        {"Geneva Identification System", "GEN# +1.00335336"},
        {"Wilson Evans Batten Catalogue", "WEB 18792"},
    },
    visualMagnitude: 11.24,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.11794375),
        dec: Angle.Degrees(+30.42789134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25789",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25789"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.60659815),
        dec: Angle.Degrees(+30.42838256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50446",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50446"},
        {"Smithsonian Astrophysical Observation", "SAO 61971"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.50069587),
        dec: Angle.Degrees(+30.42874701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125658"},
        {"Hipparcos Number", "HIP 70051"},
        {"Fundamental Katalog 5th Edition", "FK5 3136"},
        {"Geneva Identification System", "GEN# +1.00125658"},
        {"Renson", "Renson 35890"},
        {"Smithsonian Astrophysical Observation", "SAO 64074"},
        {"Wilson Evans Batten Catalogue", "WEB 12181"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.03613336),
        dec: Angle.Degrees(+30.42914436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131112"},
        {"Hipparcos Number", "HIP 72615"},
        {"Smithsonian Astrophysical Observation", "SAO 64358"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.70526692),
        dec: Angle.Degrees(+30.42934956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6731"},
        {"Hipparcos Number", "HIP 5343"},
        {"Smithsonian Astrophysical Observation", "SAO 54449"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.07831461),
        dec: Angle.Degrees(+30.42958737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281415"},
        {"Hipparcos Number", "HIP 18676"},
        {"Smithsonian Astrophysical Observation", "SAO 56878"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.98911739),
        dec: Angle.Degrees(+30.43108595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127066"},
        {"Hipparcos Number", "HIP 70775"},
        {"Geneva Identification System", "GEN# +1.00127066"},
        {"Smithsonian Astrophysical Observation", "SAO 64162"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.12390999),
        dec: Angle.Degrees(+30.43165580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221170"},
        {"Hipparcos Number", "HIP 115949"},
        {"Geneva Identification System", "GEN# +1.00221170"},
        {"Smithsonian Astrophysical Observation", "SAO 73293"},
        {"Wilson Evans Batten Catalogue", "WEB 20509"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.37008305),
        dec: Angle.Degrees(+30.43286660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114311"},
        {"Hipparcos Number", "HIP 64202"},
        {"Geneva Identification System", "GEN# +1.00114311"},
        {"Smithsonian Astrophysical Observation", "SAO 63370"},
        {"Wilson Evans Batten Catalogue", "WEB 11348"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.37064621),
        dec: Angle.Degrees(+30.43506223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4728"},
        {"Hipparcos Number", "HIP 3875"},
        {"Smithsonian Astrophysical Observation", "SAO 54170"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.43693653),
        dec: Angle.Degrees(+30.43598803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67149"},
        {"Hipparcos Number", "HIP 39792"},
        {"Smithsonian Astrophysical Observation", "SAO 60585"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.96455165),
        dec: Angle.Degrees(+30.43687591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110326"},
        {"Hipparcos Number", "HIP 61902"},
        {"Geneva Identification System", "GEN# +1.00110326"},
        {"Renson", "Renson 32070"},
        {"Smithsonian Astrophysical Observation", "SAO 63135"},
        {"Wilson Evans Batten Catalogue", "WEB 11003"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.28240031),
        dec: Angle.Degrees(+30.43709047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93798",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12040 AB"},
        {"Henry Draper", "HD 178091"},
        {"Hipparcos Number", "HIP 93798"},
        {"Smithsonian Astrophysical Observation", "SAO 67811"},
        {"Wilson Evans Batten Catalogue", "WEB 16308"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.53904850),
        dec: Angle.Degrees(+30.43854472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20921"},
        {"Hipparcos Number", "HIP 15789"},
        {"Smithsonian Astrophysical Observation", "SAO 56405"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.87484505),
        dec: Angle.Degrees(+30.43909613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218454"},
        {"Hipparcos Number", "HIP 114213"},
        {"Geneva Identification System", "GEN# +1.00218454"},
        {"Smithsonian Astrophysical Observation", "SAO 73016"},
        {"Wilson Evans Batten Catalogue", "WEB 20283"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.94932054),
        dec: Angle.Degrees(+30.43958158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11813"},
        {"Hipparcos Number", "HIP 9039"},
        {"Geneva Identification System", "GEN# +1.00011813"},
        {"Smithsonian Astrophysical Observation", "SAO 55115"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.11223074),
        dec: Angle.Degrees(+30.43976977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152794"},
        {"Hipparcos Number", "HIP 82707"},
        {"Geneva Identification System", "GEN# +1.00152794"},
        {"Smithsonian Astrophysical Observation", "SAO 65641"},
        {"Wilson Evans Batten Catalogue", "WEB 13974"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.58376721),
        dec: Angle.Degrees(+30.44171516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104496",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104496"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.51729659),
        dec: Angle.Degrees(+30.44194721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172007"},
        {"Hipparcos Number", "HIP 91228"},
        {"Geneva Identification System", "GEN# +1.00172007"},
        {"Smithsonian Astrophysical Observation", "SAO 67162"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.14047959),
        dec: Angle.Degrees(+30.44253244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68309"},
        {"Hipparcos Number", "HIP 40226"},
        {"Geneva Identification System", "GEN# +1.00068309"},
        {"Smithsonian Astrophysical Observation", "SAO 60646"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.23632926),
        dec: Angle.Degrees(+30.44316539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112368",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16248 A"},
        {"Henry Draper", "HD 215549"},
        {"Hipparcos Number", "HIP 112368"},
        {"Cincinnati Publication", "Ci 20 1379"},
        {"Geneva Identification System", "GEN# +1.00215549"},
        {"Smithsonian Astrophysical Observation", "SAO 72692"},
        {"Wilson Evans Batten Catalogue", "WEB 20045"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.39432691),
        dec: Angle.Degrees(+30.44340669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -250.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -349.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129171"},
        {"Hipparcos Number", "HIP 71726"},
        {"Geneva Identification System", "GEN# +1.00129171"},
        {"Smithsonian Astrophysical Observation", "SAO 64262"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.07637929),
        dec: Angle.Degrees(+30.44394473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54646",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8083 A"},
        {"Henry Draper", "HD 97101"},
        {"Hipparcos Number", "HIP 54646"},
        {"Cincinnati Publication", "Ci 18 1361"},
        {"Cincinnati Publication 2", "Ci 20 613"},
        {"Geneva Identification System", "GEN# +1.00097101A"},
        {"Smithsonian Astrophysical Observation", "SAO 62440"},
        {"Wilson Evans Batten Catalogue", "WEB 9858"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.76988214),
        dec: Angle.Degrees(+30.44649640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 592.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -197.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65304"},
        {"Hipparcos Number", "HIP 39047"},
        {"Geneva Identification System", "GEN# +1.00065304"},
        {"Smithsonian Astrophysical Observation", "SAO 60501"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.83048617),
        dec: Angle.Degrees(+30.44939157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 691"},
        {"Hipparcos Number", "HIP 919"},
        {"Geneva Identification System", "GEN# +1.00000691"},
        {"Smithsonian Astrophysical Observation", "SAO 53703"},
        {"Wilson Evans Batten Catalogue", "WEB 161"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.84289740),
        dec: Angle.Degrees(+30.44948927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 210.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4744"},
        {"Hipparcos Number", "HIP 3884"},
        {"Geneva Identification System", "GEN# +1.00004744"},
        {"Smithsonian Astrophysical Observation", "SAO 54175"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.46928589),
        dec: Angle.Degrees(+30.45035886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 240.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172381"},
        {"Hipparcos Number", "HIP 91417"},
        {"Smithsonian Astrophysical Observation", "SAO 67202"},
        {"Wilson Evans Batten Catalogue", "WEB 15713"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.66573959),
        dec: Angle.Degrees(+30.45203944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219736"},
        {"Hipparcos Number", "HIP 115029"},
        {"Smithsonian Astrophysical Observation", "SAO 73151"},
        {"Wilson Evans Batten Catalogue", "WEB 20380"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.47389336),
        dec: Angle.Degrees(+30.45859124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79505",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79505"},
        {"Smithsonian Astrophysical Observation", "SAO 65154"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.35949191),
        dec: Angle.Degrees(+30.45878107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120006"},
        {"Hipparcos Number", "HIP 67201"},
        {"Geneva Identification System", "GEN# +1.00120006"},
        {"Smithsonian Astrophysical Observation", "SAO 63734"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.57070140),
        dec: Angle.Degrees(+30.45993484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71119",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71119"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.15013631),
        dec: Angle.Degrees(+30.46176314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79814",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79814"},
        {"Smithsonian Astrophysical Observation", "SAO 65199"},
    },
    visualMagnitude: 11.20,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.33721283),
        dec: Angle.Degrees(+30.46363709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44087",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44087"},
        {"Smithsonian Astrophysical Observation", "SAO 61166"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.70245315),
        dec: Angle.Degrees(+30.46710460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60050",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60050"},
        {"Geneva Identification System", "GEN# +0.03102351"},
        {"Smithsonian Astrophysical Observation", "SAO 62945"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.72706438),
        dec: Angle.Degrees(+30.46826453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95904",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95904"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.56041870),
        dec: Angle.Degrees(+30.46895213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166411"},
        {"Hipparcos Number", "HIP 88929"},
        {"Geneva Identification System", "GEN# +1.00166411"},
        {"Smithsonian Astrophysical Observation", "SAO 66682"},
        {"Wilson Evans Batten Catalogue", "WEB 15083"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.29242500),
        dec: Angle.Degrees(+30.46919267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 139.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8201",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8201"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.35950125),
        dec: Angle.Degrees(+30.47051210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76908",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76908"},
        {"Smithsonian Astrophysical Observation", "SAO 64856"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.56224515),
        dec: Angle.Degrees(+30.47052725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11191"},
        {"Hipparcos Number", "HIP 8576"},
        {"Geneva Identification System", "GEN# +1.00011191"},
        {"Smithsonian Astrophysical Observation", "SAO 55020"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.64955005),
        dec: Angle.Degrees(+30.47228030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54777"},
        {"Hipparcos Number", "HIP 34733"},
        {"Geneva Identification System", "GEN# +1.00054777"},
        {"Smithsonian Astrophysical Observation", "SAO 59869"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.87070639),
        dec: Angle.Degrees(+30.47258713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117831"},
        {"Hipparcos Number", "HIP 66040"},
        {"Geneva Identification System", "GEN# +1.00117831"},
        {"Smithsonian Astrophysical Observation", "SAO 63590"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.08616956),
        dec: Angle.Degrees(+30.47329668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93369",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93369"},
        {"Smithsonian Astrophysical Observation", "SAO 67700"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.26312010),
        dec: Angle.Degrees(+30.47616560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192286"},
        {"Hipparcos Number", "HIP 99622"},
        {"Geneva Identification System", "GEN# +1.00192286"},
        {"Smithsonian Astrophysical Observation", "SAO 69615"},
        {"Wilson Evans Batten Catalogue", "WEB 17843"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.26036330),
        dec: Angle.Degrees(+30.47740330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66702",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66702"},
        {"Smithsonian Astrophysical Observation", "SAO 63678"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.09422604),
        dec: Angle.Degrees(+30.47793305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75074"},
        {"Hipparcos Number", "HIP 43263"},
        {"Smithsonian Astrophysical Observation", "SAO 61059"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.19393200),
        dec: Angle.Degrees(+30.47968167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47939",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47939"},
        {"Smithsonian Astrophysical Observation", "SAO 61672"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.53731073),
        dec: Angle.Degrees(+30.48079521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48413"},
        {"Hipparcos Number", "HIP 32298"},
        {"Smithsonian Astrophysical Observation", "SAO 59437"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.14397226),
        dec: Angle.Degrees(+30.48560163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107287"},
        {"Hipparcos Number", "HIP 60139"},
        {"Geneva Identification System", "GEN# +1.00107287"},
        {"Smithsonian Astrophysical Observation", "SAO 62951"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.99249525),
        dec: Angle.Degrees(+30.48655625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38094"},
        {"Hipparcos Number", "HIP 27077"},
        {"Geneva Identification System", "GEN# +1.00038094"},
        {"Smithsonian Astrophysical Observation", "SAO 58385"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.12886639),
        dec: Angle.Degrees(+30.48824787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102160"},
        {"Hipparcos Number", "HIP 57356"},
        {"Geneva Identification System", "GEN# +1.00102160"},
        {"Smithsonian Astrophysical Observation", "SAO 62692"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.38701869),
        dec: Angle.Degrees(+30.49114671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26536",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4229 AB"},
        {"Henry Draper", "HD 37269"},
        {"Hipparcos Number", "HIP 26536"},
        {"Celescope Catalog", "CEL 876"},
        {"Geneva Identification System", "GEN# +1.00037269"},
        {"Smithsonian Astrophysical Observation", "SAO 58280"},
        {"Wilson Evans Batten Catalogue", "WEB 5229"},
    },
    visualMagnitude: 5.40,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.65874822),
        dec: Angle.Degrees(+30.49244147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45412"},
        {"Hipparcos Number", "HIP 30827"},
        {"Geneva Identification System", "GEN# +1.00045412"},
        {"Smithsonian Astrophysical Observation", "SAO 59128"},
        {"Wilson Evans Batten Catalogue", "WEB 6145"},
    },
    visualMagnitude: 5.75,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.14203636),
        dec: Angle.Degrees(+30.49306993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81265"},
        {"Hipparcos Number", "HIP 46227"},
        {"Geneva Identification System", "GEN# +1.00081265"},
        {"Smithsonian Astrophysical Observation", "SAO 61475"},
        {"Wilson Evans Batten Catalogue", "WEB 8746"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.37218136),
        dec: Angle.Degrees(+30.49367569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85921"},
        {"Smithsonian Astrophysical Observation", "SAO 66134"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.37245146),
        dec: Angle.Degrees(+30.49379045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 256870"},
        {"Hipparcos Number", "HIP 30609"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.49537178),
        dec: Angle.Degrees(+30.49437621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32406"},
        {"Hipparcos Number", "HIP 23583"},
        {"Geneva Identification System", "GEN# +1.00032406"},
        {"Smithsonian Astrophysical Observation", "SAO 57610"},
        {"Wilson Evans Batten Catalogue", "WEB 4594"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.06065446),
        dec: Angle.Degrees(+30.49461984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138711"},
        {"Hipparcos Number", "HIP 76116"},
        {"Geneva Identification System", "GEN# +1.00138711"},
        {"Smithsonian Astrophysical Observation", "SAO 64767"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.19655349),
        dec: Angle.Degrees(+30.49583251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34051"},
        {"Hipparcos Number", "HIP 24540"},
        {"Smithsonian Astrophysical Observation", "SAO 57809"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.97406001),
        dec: Angle.Degrees(+30.49695105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81066",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10116 A"},
        {"Henry Draper", "HD 149420"},
        {"Hipparcos Number", "HIP 81066"},
        {"Geneva Identification System", "GEN# +1.00149420"},
        {"Renson", "Renson 42290"},
        {"Smithsonian Astrophysical Observation", "SAO 65380"},
        {"Wilson Evans Batten Catalogue", "WEB 13709"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.37145313),
        dec: Angle.Degrees(+30.49907268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101951",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14124 AB"},
        {"Henry Draper", "HD 196954"},
        {"Hipparcos Number", "HIP 101951"},
        {"Smithsonian Astrophysical Observation", "SAO 70331"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.89643809),
        dec: Angle.Degrees(+30.50418377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100643"},
        {"Hipparcos Number", "HIP 56503"},
        {"Geneva Identification System", "GEN# +1.00100643"},
        {"Smithsonian Astrophysical Observation", "SAO 62611"},
        {"Wilson Evans Batten Catalogue", "WEB 10152"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.75709239),
        dec: Angle.Degrees(+30.50887410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147366"},
        {"Hipparcos Number", "HIP 80055"},
        {"Geneva Identification System", "GEN# +1.00147366"},
        {"Smithsonian Astrophysical Observation", "SAO 65236"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.10582694),
        dec: Angle.Degrees(+30.50954289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17673"},
        {"Hipparcos Number", "HIP 13294"},
        {"Geneva Identification System", "GEN# +1.00017673"},
        {"Smithsonian Astrophysical Observation", "SAO 55942"},
        {"Wilson Evans Batten Catalogue", "WEB 2667"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.77813053),
        dec: Angle.Degrees(+30.50989955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111799",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111799"},
        {"Smithsonian Astrophysical Observation", "SAO 72561"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.66955691),
        dec: Angle.Degrees(+30.51011527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34602"},
        {"Hipparcos Number", "HIP 24878"},
        {"Smithsonian Astrophysical Observation", "SAO 57910"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.00329009),
        dec: Angle.Degrees(+30.51052790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18939"},
        {"Hipparcos Number", "HIP 14245"},
        {"Smithsonian Astrophysical Observation", "SAO 56119"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.92507720),
        dec: Angle.Degrees(+30.51081471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8826"},
        {"Hipparcos Number", "HIP 6801"},
        {"Geneva Identification System", "GEN# +1.00008826"},
        {"Smithsonian Astrophysical Observation", "SAO 54707"},
        {"Wilson Evans Batten Catalogue", "WEB 1484"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.87447992),
        dec: Angle.Degrees(+30.51166039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282248"},
        {"Hipparcos Number", "HIP 21162"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.05043848),
        dec: Angle.Degrees(+30.51475001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96295",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Campbell's star"},
        {"Common Name 2", "Campbell's Hydrogen Star"},
        {"Henry Draper", "HD 184738"},
        {"Hipparcos Number", "HIP 96295"},
        {"Wilson Evans Batten Catalogue", "WEB 16884"},
    },
    visualMagnitude: 10.00,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.68847988),
        dec: Angle.Degrees(+30.51639594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86311"},
        {"Hipparcos Number", "HIP 48890"},
        {"Smithsonian Astrophysical Observation", "SAO 61782"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.57628970),
        dec: Angle.Degrees(+30.51725852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98424"},
        {"Hipparcos Number", "HIP 55311"},
        {"Smithsonian Astrophysical Observation", "SAO 62495"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.91091037),
        dec: Angle.Degrees(+30.51953921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129209"},
        {"Hipparcos Number", "HIP 71737"},
        {"Geneva Identification System", "GEN# +1.00129209"},
        {"Smithsonian Astrophysical Observation", "SAO 64264"},
        {"Wilson Evans Batten Catalogue", "WEB 12362"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.11806883),
        dec: Angle.Degrees(+30.52061836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73278",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73278"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.65075123),
        dec: Angle.Degrees(+30.52179826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200390"},
        {"Hipparcos Number", "HIP 103815"},
        {"Smithsonian Astrophysical Observation", "SAO 70811"},
        {"Wilson Evans Batten Catalogue", "WEB 18896"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.56153122),
        dec: Angle.Degrees(+30.52188718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2838"},
        {"Hipparcos Number", "HIP 2522"},
        {"Geneva Identification System", "GEN# +1.00002838"},
        {"Smithsonian Astrophysical Observation", "SAO 53965"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.98998239),
        dec: Angle.Degrees(+30.52200340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116205"},
        {"Hipparcos Number", "HIP 65195"},
        {"Smithsonian Astrophysical Observation", "SAO 63495"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.41138872),
        dec: Angle.Degrees(+30.52204024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17787"},
        {"Hipparcos Number", "HIP 13377"},
        {"Smithsonian Astrophysical Observation", "SAO 55958"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.03404101),
        dec: Angle.Degrees(+30.52392506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13210",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2158 A"},
        {"Henry Draper", "HD 17572"},
        {"Henry Draper 2", "HD 17572A"},
        {"Hipparcos Number", "HIP 13210"},
        {"Smithsonian Astrophysical Observation", "SAO 55920"},
        {"Wilson Evans Batten Catalogue", "WEB 2654"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.50129674),
        dec: Angle.Degrees(+30.52632898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180450"},
        {"Hipparcos Number", "HIP 94630"},
        {"Geneva Identification System", "GEN# +1.00180450"},
        {"Smithsonian Astrophysical Observation", "SAO 68040"},
        {"Wilson Evans Batten Catalogue", "WEB 16495"},
    },
    visualMagnitude: 5.88,
    bvColour: 1.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.85348310),
        dec: Angle.Degrees(+30.52644519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282323"},
        {"Hipparcos Number", "HIP 21573"},
        {"Smithsonian Astrophysical Observation", "SAO 57347"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.47559180),
        dec: Angle.Degrees(+30.52690750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19257"},
        {"Hipparcos Number", "HIP 14479"},
        {"Geneva Identification System", "GEN# +1.00019257"},
        {"Smithsonian Astrophysical Observation", "SAO 56166"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.71619479),
        dec: Angle.Degrees(+30.52718363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117413",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117413"},
        {"Smithsonian Astrophysical Observation", "SAO 73521"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.12652164),
        dec: Angle.Degrees(+30.52748687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157513"},
        {"Hipparcos Number", "HIP 85009"},
        {"Smithsonian Astrophysical Observation", "SAO 65990"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.62210304),
        dec: Angle.Degrees(+30.52819719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10157"},
        {"Hipparcos Number", "HIP 7764"},
        {"Smithsonian Astrophysical Observation", "SAO 54883"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.98235862),
        dec: Angle.Degrees(+30.52959956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63711"},
        {"Hipparcos Number", "HIP 38364"},
        {"Smithsonian Astrophysical Observation", "SAO 60390"},
    },
    visualMagnitude: 8.22,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.87599499),
        dec: Angle.Degrees(+30.53032570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94426"},
        {"Hipparcos Number", "HIP 53324"},
        {"Geneva Identification System", "GEN# +1.00094426"},
        {"Smithsonian Astrophysical Observation", "SAO 62306"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.60627694),
        dec: Angle.Degrees(+30.53199507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1179"},
        {"Hipparcos Number", "HIP 1294"},
        {"Smithsonian Astrophysical Observation", "SAO 53766"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.04772248),
        dec: Angle.Degrees(+30.53248386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 192.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130023"},
        {"Hipparcos Number", "HIP 72113"},
        {"Smithsonian Astrophysical Observation", "SAO 64304"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.26992160),
        dec: Angle.Degrees(+30.53430164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27404",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4383 A"},
        {"Henry Draper", "HD 38583"},
        {"Hipparcos Number", "HIP 27404"},
        {"Geneva Identification System", "GEN# +1.00038583A"},
        {"Smithsonian Astrophysical Observation", "SAO 58451"},
        {"Wilson Evans Batten Catalogue", "WEB 5383"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.04774951),
        dec: Angle.Degrees(+30.53524601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109370",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109370"},
        {"Smithsonian Astrophysical Observation", "SAO 72068"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.36213945),
        dec: Angle.Degrees(+30.53800795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16420"},
        {"Hipparcos Number", "HIP 12331"},
        {"Fundamental Katalog 5th Edition", "FK5 4244"},
        {"Smithsonian Astrophysical Observation", "SAO 55751"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.70300344),
        dec: Angle.Degrees(+30.54045993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65926",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65926"},
        {"Smithsonian Astrophysical Observation", "SAO 63577"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.72422852),
        dec: Angle.Degrees(+30.54175904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5795",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1000 A"},
        {"Henry Draper", "HD 7384"},
        {"Hipparcos Number", "HIP 5795"},
        {"Smithsonian Astrophysical Observation", "SAO 54541"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.58679726),
        dec: Angle.Degrees(+30.54210847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2529",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2529"},
        {"Geneva Identification System", "GEN# +0.02900095"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.02134225),
        dec: Angle.Degrees(+30.54418783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218879"},
        {"Hipparcos Number", "HIP 114483"},
        {"Smithsonian Astrophysical Observation", "SAO 73063"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.79145655),
        dec: Angle.Degrees(+30.54445567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137029"},
        {"Hipparcos Number", "HIP 75274"},
        {"Geneva Identification System", "GEN# +1.00137029"},
        {"Smithsonian Astrophysical Observation", "SAO 64666"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.69079247),
        dec: Angle.Degrees(+30.54793300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27825",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27825"},
    },
    visualMagnitude: 10.86,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.31936528),
        dec: Angle.Degrees(+30.54901004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183629"},
        {"Hipparcos Number", "HIP 95808"},
        {"Smithsonian Astrophysical Observation", "SAO 68381"},
        {"Wilson Evans Batten Catalogue", "WEB 16773"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.31431632),
        dec: Angle.Degrees(+30.54913022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42106"},
        {"Hipparcos Number", "HIP 29273"},
        {"Geneva Identification System", "GEN# +1.00042106"},
        {"Smithsonian Astrophysical Observation", "SAO 58818"},
        {"Wilson Evans Batten Catalogue", "WEB 5741"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.56046817),
        dec: Angle.Degrees(+30.54979601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161620"},
        {"Hipparcos Number", "HIP 86901"},
        {"Smithsonian Astrophysical Observation", "SAO 66306"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.33991641),
        dec: Angle.Degrees(+30.54989703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71277"},
        {"Hipparcos Number", "HIP 41482"},
        {"Geneva Identification System", "GEN# +1.00071277"},
        {"Smithsonian Astrophysical Observation", "SAO 60826"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.89994900),
        dec: Angle.Degrees(+30.55002633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31293"},
        {"Hipparcos Number", "HIP 22910"},
        {"Geneva Identification System", "GEN# +1.00031293"},
        {"Smithsonian Astrophysical Observation", "SAO 57506"},
        {"Wilson Evans Batten Catalogue", "WEB 4447"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.94101407),
        dec: Angle.Degrees(+30.55125115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210594"},
        {"Hipparcos Number", "HIP 109493"},
        {"Geneva Identification System", "GEN# +1.00210594"},
        {"Smithsonian Astrophysical Observation", "SAO 72095"},
        {"Wilson Evans Batten Catalogue", "WEB 19674"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.71540024),
        dec: Angle.Degrees(+30.55304243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90923",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11446 A"},
        {"Henry Draper", "HD 171301"},
        {"Hipparcos Number", "HIP 90923"},
        {"Geneva Identification System", "GEN# +1.00171301J"},
        {"Smithsonian Astrophysical Observation", "SAO 67090"},
        {"Wilson Evans Batten Catalogue", "WEB 15595"},
    },
    visualMagnitude: 5.47,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.20812019),
        dec: Angle.Degrees(+30.55418062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165008"},
        {"Hipparcos Number", "HIP 88356"},
        {"Geneva Identification System", "GEN# +1.00165008"},
        {"Smithsonian Astrophysical Observation", "SAO 66573"},
        {"Wilson Evans Batten Catalogue", "WEB 14938"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.64447889),
        dec: Angle.Degrees(+30.55528901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 91.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37456",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37456"},
        {"Smithsonian Astrophysical Observation", "SAO 60269"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.32738381),
        dec: Angle.Degrees(+30.55541068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195395"},
        {"Hipparcos Number", "HIP 101131"},
        {"Smithsonian Astrophysical Observation", "SAO 70109"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.49502201),
        dec: Angle.Degrees(+30.55664418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20149"},
        {"Hipparcos Number", "HIP 15154"},
        {"Geneva Identification System", "GEN# +1.00020149"},
        {"Smithsonian Astrophysical Observation", "SAO 56285"},
        {"Wilson Evans Batten Catalogue", "WEB 2918"},
    },
    visualMagnitude: 5.61,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.83519839),
        dec: Angle.Degrees(+30.55667481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8909"},
        {"Hipparcos Number", "HIP 6862"},
        {"Geneva Identification System", "GEN# +1.00008909"},
        {"Smithsonian Astrophysical Observation", "SAO 54719"},
        {"Wilson Evans Batten Catalogue", "WEB 1496"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.07964796),
        dec: Angle.Degrees(+30.55784315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13565"},
        {"Hipparcos Number", "HIP 10334"},
        {"Geneva Identification System", "GEN# +1.00013565"},
        {"Smithsonian Astrophysical Observation", "SAO 55358"},
        {"Wilson Evans Batten Catalogue", "WEB 2163"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.29042812),
        dec: Angle.Degrees(+30.55885630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38852"},
        {"Hipparcos Number", "HIP 27548"},
        {"Geneva Identification System", "GEN# +1.00038852"},
        {"Smithsonian Astrophysical Observation", "SAO 58486"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.50141294),
        dec: Angle.Degrees(+30.56028318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82742"},
        {"Hipparcos Number", "HIP 46993"},
        {"Smithsonian Astrophysical Observation", "SAO 61575"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.67205191),
        dec: Angle.Degrees(+30.56106710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88745",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11077 AB"},
        {"Henry Draper", "HD 165908"},
        {"Hipparcos Number", "HIP 88745"},
        {"Geneva Identification System", "GEN# +1.00165908"},
        {"Smithsonian Astrophysical Observation", "SAO 66648"},
        {"Wilson Evans Batten Catalogue", "WEB 15034"},
    },
    visualMagnitude: 5.05,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.75669828),
        dec: Angle.Degrees(+30.56186809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 111.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204891"},
        {"Hipparcos Number", "HIP 106220"},
        {"Smithsonian Astrophysical Observation", "SAO 71416"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.72251627),
        dec: Angle.Degrees(+30.56203572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106279"},
        {"Hipparcos Number", "HIP 59617"},
        {"Geneva Identification System", "GEN# +1.00106279"},
        {"Smithsonian Astrophysical Observation", "SAO 62900"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.39435184),
        dec: Angle.Degrees(+30.56249837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141268"},
        {"Hipparcos Number", "HIP 77323"},
        {"Smithsonian Astrophysical Observation", "SAO 64902"},
    },
    visualMagnitude: 7.80,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.79065418),
        dec: Angle.Degrees(+30.56569771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94104",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12110 A"},
        {"Henry Draper", "HD 178947"},
        {"Hipparcos Number", "HIP 94104"},
        {"Celescope Catalog", "CEL 4709"},
        {"Geneva Identification System", "GEN# +1.00178947"},
        {"Smithsonian Astrophysical Observation", "SAO 67883"},
        {"Wilson Evans Batten Catalogue", "WEB 16387"},
    },
    visualMagnitude: 6.92,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.34637492),
        dec: Angle.Degrees(+30.56627180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282624"},
        {"Hipparcos Number", "HIP 22925"},
        {"Smithsonian Astrophysical Observation", "SAO 57509"},
        {"Wilson Evans Batten Catalogue", "WEB 4453"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.99743503),
        dec: Angle.Degrees(+30.56714305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44330",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44330"},
    },
    visualMagnitude: 11.45,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.41670636),
        dec: Angle.Degrees(+30.56738012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -207.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194525"},
        {"Hipparcos Number", "HIP 100708"},
        {"Geneva Identification System", "GEN# +1.00194525"},
        {"Smithsonian Astrophysical Observation", "SAO 69987"},
        {"Wilson Evans Batten Catalogue", "WEB 18197"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.26059376),
        dec: Angle.Degrees(+30.56816751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84214",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84214"},
        {"Smithsonian Astrophysical Observation", "SAO 65871"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.22136846),
        dec: Angle.Degrees(+30.56908068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18602"},
        {"Hipparcos Number", "HIP 14018"},
        {"Smithsonian Astrophysical Observation", "SAO 56082"},
        {"Wilson Evans Batten Catalogue", "WEB 2761"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.11202072),
        dec: Angle.Degrees(+30.56934407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82474"},
        {"Hipparcos Number", "HIP 46868"},
        {"Smithsonian Astrophysical Observation", "SAO 61555"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.25778487),
        dec: Angle.Degrees(+30.56941142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39459",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39459"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.98206356),
        dec: Angle.Degrees(+30.57296565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41785"},
        {"Hipparcos Number", "HIP 29125"},
        {"Geneva Identification System", "GEN# +1.00041785"},
        {"Smithsonian Astrophysical Observation", "SAO 58784"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.12692711),
        dec: Angle.Degrees(+30.57327017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36530",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6137 AB"},
        {"Henry Draper", "HD 59372"},
        {"Hipparcos Number", "HIP 36530"},
        {"Smithsonian Astrophysical Observation", "SAO 60144"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.72876315),
        dec: Angle.Degrees(+30.57395528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33269"},
        {"Hipparcos Number", "HIP 24065"},
        {"Geneva Identification System", "GEN# +1.00033269"},
        {"Smithsonian Astrophysical Observation", "SAO 57706"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.56019870),
        dec: Angle.Degrees(+30.57503623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50185",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50185"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.67046475),
        dec: Angle.Degrees(+30.57727547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196723"},
        {"Hipparcos Number", "HIP 101826"},
        {"Smithsonian Astrophysical Observation", "SAO 70311"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.53453402),
        dec: Angle.Degrees(+30.57749214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43721",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7071 AB"},
        {"Henry Draper", "HD 75959"},
        {"Hipparcos Number", "HIP 43721"},
        {"Geneva Identification System", "GEN# +1.00075959"},
        {"Smithsonian Astrophysical Observation", "SAO 61125"},
        {"Wilson Evans Batten Catalogue", "WEB 8416"},
    },
    visualMagnitude: 5.40,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.56126962),
        dec: Angle.Degrees(+30.57917723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51978",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51978"},
        {"Smithsonian Astrophysical Observation", "SAO 62159"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.30734979),
        dec: Angle.Degrees(+30.58099554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110043"},
        {"Hipparcos Number", "HIP 61735"},
        {"Geneva Identification System", "GEN# +1.00110043"},
        {"Smithsonian Astrophysical Observation", "SAO 63117"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.80545726),
        dec: Angle.Degrees(+30.58315481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171946"},
        {"Hipparcos Number", "HIP 91200"},
        {"Geneva Identification System", "GEN# +1.00171946"},
        {"Smithsonian Astrophysical Observation", "SAO 67152"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.06245602),
        dec: Angle.Degrees(+30.58466676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153452"},
        {"Hipparcos Number", "HIP 83075"},
        {"Smithsonian Astrophysical Observation", "SAO 65688"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.63237584),
        dec: Angle.Degrees(+30.58573938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173908"},
        {"Hipparcos Number", "HIP 92129"},
        {"Smithsonian Astrophysical Observation", "SAO 67369"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.66344571),
        dec: Angle.Degrees(+30.58657035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89725",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89725"},
        {"Smithsonian Astrophysical Observation", "SAO 66842"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.66429894),
        dec: Angle.Degrees(+30.58689622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86777"},
        {"Hipparcos Number", "HIP 49113"},
        {"Smithsonian Astrophysical Observation", "SAO 61813"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.35345977),
        dec: Angle.Degrees(+30.58715960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105162",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14835 AB"},
        {"Henry Draper", "HD 202924"},
        {"Hipparcos Number", "HIP 105162"},
        {"Smithsonian Astrophysical Observation", "SAO 71176"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.54533088),
        dec: Angle.Degrees(+30.58934418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193857"},
        {"Hipparcos Number", "HIP 100384"},
        {"Geneva Identification System", "GEN# +1.00193857"},
        {"Renson", "Renson 54110"},
        {"Smithsonian Astrophysical Observation", "SAO 69888"},
        {"Wilson Evans Batten Catalogue", "WEB 18116"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.37313960),
        dec: Angle.Degrees(+30.59021844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95724"},
        {"Hipparcos Number", "HIP 54028"},
        {"Cincinnati Publication", "Ci 18 1345"},
        {"Smithsonian Astrophysical Observation", "SAO 62375"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.81073123),
        dec: Angle.Degrees(+30.59224057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -160.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87865"},
        {"Hipparcos Number", "HIP 49685"},
        {"Smithsonian Astrophysical Observation", "SAO 61888"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.13782680),
        dec: Angle.Degrees(+30.59457774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96163"},
        {"Hipparcos Number", "HIP 54230"},
        {"Smithsonian Astrophysical Observation", "SAO 62400"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.43887149),
        dec: Angle.Degrees(+30.59588381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201194"},
        {"Hipparcos Number", "HIP 104235"},
        {"Fundamental Katalog 5th Edition", "FK5 5858"},
        {"Geneva Identification System", "GEN# +1.00201194"},
        {"Smithsonian Astrophysical Observation", "SAO 70931"},
        {"Wilson Evans Batten Catalogue", "WEB 18990"},
    },
    visualMagnitude: 7.55,
    bvColour: -0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.78478531),
        dec: Angle.Degrees(+30.59597776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100369",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13745 AB"},
        {"Henry Draper", "HD 334154"},
        {"Hipparcos Number", "HIP 100369"},
        {"Smithsonian Astrophysical Observation", "SAO 69879"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.33145773),
        dec: Angle.Degrees(+30.60098352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40671",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40671"},
        {"Cincinnati Publication", "Ci 18 977"},
        {"Cincinnati Publication 2", "Ci 20 468"},
        {"Geneva Identification System", "GEN# +0.03101781"},
        {"Smithsonian Astrophysical Observation", "SAO 60712"},
        {"Wilson Evans Batten Catalogue", "WEB 7903"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.54571465),
        dec: Angle.Degrees(+30.60281736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -281.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -823.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5051"},
        {"Hipparcos Number", "HIP 4110"},
        {"Smithsonian Astrophysical Observation", "SAO 54223"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.17483456),
        dec: Angle.Degrees(+30.60508604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18554"},
        {"Hipparcos Number", "HIP 13969"},
        {"Geneva Identification System", "GEN# +1.00018554"},
        {"Smithsonian Astrophysical Observation", "SAO 56065"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.97835239),
        dec: Angle.Degrees(+30.60646739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119915"},
        {"Hipparcos Number", "HIP 67154"},
        {"Geneva Identification System", "GEN# +1.00119915"},
        {"Smithsonian Astrophysical Observation", "SAO 63725"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.42391432),
        dec: Angle.Degrees(+30.60829840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64090"},
        {"Hipparcos Number", "HIP 38541"},
        {"Cincinnati Publication", "Ci 20 443"},
        {"Cincinnati Publication 2", "Ci 18 935"},
        {"Geneva Identification System", "GEN# +1.00064090"},
        {"Smithsonian Astrophysical Observation", "SAO 60416"},
        {"Wilson Evans Batten Catalogue", "WEB 7572"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.38600920),
        dec: Angle.Degrees(+30.60952919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 705.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1834.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39925"},
        {"Hipparcos Number", "HIP 28157"},
        {"Smithsonian Astrophysical Observation", "SAO 58601"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.25094708),
        dec: Angle.Degrees(+30.60966981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60400",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60400"},
        {"Geneva Identification System", "GEN# +0.03102358"},
        {"Smithsonian Astrophysical Observation", "SAO 62977"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.76851710),
        dec: Angle.Degrees(+30.61057859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57478",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57478"},
        {"Geneva Identification System", "GEN# +0.03102298"},
        {"Smithsonian Astrophysical Observation", "SAO 62701"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.73250570),
        dec: Angle.Degrees(+30.61130115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11824",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11824"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.13804147),
        dec: Angle.Degrees(+30.61262879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115520"},
        {"Hipparcos Number", "HIP 64827"},
        {"Geneva Identification System", "GEN# +1.00115520"},
        {"Smithsonian Astrophysical Observation", "SAO 63450"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.33934716),
        dec: Angle.Degrees(+30.61270009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117664",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117664"},
        {"Smithsonian Astrophysical Observation", "SAO 73561"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.94236615),
        dec: Angle.Degrees(+30.61394926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80326",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80326"},
        {"Smithsonian Astrophysical Observation", "SAO 65274"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.98948277),
        dec: Angle.Degrees(+30.61396348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201939"},
        {"Hipparcos Number", "HIP 104653"},
        {"Geneva Identification System", "GEN# +1.00201939"},
        {"Smithsonian Astrophysical Observation", "SAO 71050"},
        {"Wilson Evans Batten Catalogue", "WEB 19040"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.98676921),
        dec: Angle.Degrees(+30.61908032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218301"},
        {"Hipparcos Number", "HIP 114093"},
        {"Geneva Identification System", "GEN# +1.00218301"},
        {"Smithsonian Astrophysical Observation", "SAO 72995"},
        {"Wilson Evans Batten Catalogue", "WEB 20260"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.62607801),
        dec: Angle.Degrees(+30.61950818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192698"},
        {"Hipparcos Number", "HIP 99812"},
        {"Celescope Catalog", "CEL 4990"},
        {"Geneva Identification System", "GEN# +1.00192698"},
        {"Renson", "Renson 53780"},
        {"Smithsonian Astrophysical Observation", "SAO 69692"},
    },
    visualMagnitude: 8.74,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.78295384),
        dec: Angle.Degrees(+30.62000679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 260770"},
        {"Hipparcos Number", "HIP 31728"},
        {"Smithsonian Astrophysical Observation", "SAO 59312"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.57079309),
        dec: Angle.Degrees(+30.62455980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9269"},
        {"Hipparcos Number", "HIP 7123"},
        {"Smithsonian Astrophysical Observation", "SAO 54758"},
        {"Wilson Evans Batten Catalogue", "WEB 1538"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.94426018),
        dec: Angle.Degrees(+30.62485379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28229",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28229"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.46196924),
        dec: Angle.Degrees(+30.62523708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215881"},
        {"Hipparcos Number", "HIP 112573"},
        {"Fundamental Katalog 5th Edition", "FK5 6010"},
        {"Smithsonian Astrophysical Observation", "SAO 72727"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.01004134),
        dec: Angle.Degrees(+30.62581804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335217"},
        {"Hipparcos Number", "HIP 103015"},
        {"Smithsonian Astrophysical Observation", "SAO 70601"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.06272560),
        dec: Angle.Degrees(+30.62622012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
