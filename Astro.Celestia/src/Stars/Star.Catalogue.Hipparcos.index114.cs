using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_114() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36738"},
        {"Hipparcos Number", "HIP 26598"},
        {"Smithsonian Astrophysical Observation", "SAO 13558"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.79919791),
        dec: Angle.Degrees(+67.22717336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56738"},
        {"Hipparcos Number", "HIP 35840"},
        {"Smithsonian Astrophysical Observation", "SAO 14172"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.85270051),
        dec: Angle.Degrees(+67.22810110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47876"},
        {"Hipparcos Number", "HIP 32419"},
        {"Smithsonian Astrophysical Observation", "SAO 13948"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.51549085),
        dec: Angle.Degrees(+67.22941793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35495"},
        {"Hipparcos Number", "HIP 25756"},
        {"Geneva Identification System", "GEN# +1.00035495"},
        {"Smithsonian Astrophysical Observation", "SAO 13510"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.51010830),
        dec: Angle.Degrees(+67.23411901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2552",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 433 AB"},
        {"Aitken 2", "ADS 440 AB"},
        {"Hipparcos Number", "HIP 2552"},
        {"Cincinnati Publication", "Ci 20 34"},
        {"Wilson Evans Batten Catalogue", "WEB 465"},
    },
    visualMagnitude: 10.27,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.11171615),
        dec: Angle.Degrees(+67.23621544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1739.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -224.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5851",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5851"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.76163870),
        dec: Angle.Degrees(+67.23672550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15482",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2452 AB"},
        {"Henry Draper", "HD 20274"},
        {"Hipparcos Number", "HIP 15482"},
        {"Smithsonian Astrophysical Observation", "SAO 12698"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.89732087),
        dec: Angle.Degrees(+67.23758783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147379"},
        {"Hipparcos Number", "HIP 79755"},
        {"Cincinnati Publication", "Ci 20 981"},
        {"Cincinnati Publication 2", "Ci 18 2184"},
        {"Geneva Identification System", "GEN# +1.10147379"},
        {"Geneva Identification System 2", "GEN# +1.00147379A"},
        {"Smithsonian Astrophysical Observation", "SAO 17026"},
        {"Wilson Evans Batten Catalogue", "WEB 13498"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.18123674),
        dec: Angle.Degrees(+67.23863768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -497.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 85.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218829"},
        {"Hipparcos Number", "HIP 114377"},
        {"Smithsonian Astrophysical Observation", "SAO 20466"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.48211537),
        dec: Angle.Degrees(+67.24203079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112640"},
        {"Hipparcos Number", "HIP 63203"},
        {"Smithsonian Astrophysical Observation", "SAO 15950"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.24185566),
        dec: Angle.Degrees(+67.24283408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103940",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103940"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.90197833),
        dec: Angle.Degrees(+67.24362400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146988"},
        {"Hipparcos Number", "HIP 79597"},
        {"Smithsonian Astrophysical Observation", "SAO 17007"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.61324798),
        dec: Angle.Degrees(+67.25055114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55590",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55590"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.81376486),
        dec: Angle.Degrees(+67.25293739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85142"},
        {"Hipparcos Number", "HIP 48460"},
        {"Smithsonian Astrophysical Observation", "SAO 15005"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.21180373),
        dec: Angle.Degrees(+67.25577881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79762",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79762"},
        {"Geneva Identification System", "GEN# +1.00147379B"},
        {"Geneva Identification System 2", "GEN# +1.20147379"},
        {"Wilson Evans Batten Catalogue", "WEB 13499"},
    },
    visualMagnitude: 10.69,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.19184900),
        dec: Angle.Degrees(+67.25602668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -485.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 90.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209722"},
        {"Hipparcos Number", "HIP 108834"},
        {"Smithsonian Astrophysical Observation", "SAO 19816"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.71592047),
        dec: Angle.Degrees(+67.26091969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108828",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108828"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.70598112),
        dec: Angle.Degrees(+67.26422956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103539"},
        {"Hipparcos Number", "HIP 58160"},
        {"Geneva Identification System", "GEN# +1.00103539"},
        {"Smithsonian Astrophysical Observation", "SAO 15658"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.91861064),
        dec: Angle.Degrees(+67.26494450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56936",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56936"},
        {"Cincinnati Publication", "Ci 20 655"},
        {"Geneva Identification System", "GEN# +9.80236080"},
        {"Wilson Evans Batten Catalogue", "WEB 10250"},
    },
    visualMagnitude: 12.20,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.08296376),
        dec: Angle.Degrees(+67.26666675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 262.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3157.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152222"},
        {"Hipparcos Number", "HIP 82158"},
        {"Smithsonian Astrophysical Observation", "SAO 17226"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.76918423),
        dec: Angle.Degrees(+67.26689933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12012",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12012"},
        {"Smithsonian Astrophysical Observation", "SAO 12340"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.71937213),
        dec: Angle.Degrees(+67.26953480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83126"},
        {"Hipparcos Number", "HIP 47401"},
        {"Fundamental Katalog 5th Edition", "FK5 2769"},
        {"Geneva Identification System", "GEN# +1.00083126"},
        {"Smithsonian Astrophysical Observation", "SAO 14949"},
        {"Wilson Evans Batten Catalogue", "WEB 8899"},
    },
    visualMagnitude: 5.96,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.86631917),
        dec: Angle.Degrees(+67.27232436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198454"},
        {"Hipparcos Number", "HIP 102518"},
        {"Smithsonian Astrophysical Observation", "SAO 19036"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.63474919),
        dec: Angle.Degrees(+67.27571493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87043"},
        {"Hipparcos Number", "HIP 49414"},
        {"Smithsonian Astrophysical Observation", "SAO 15067"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.30294204),
        dec: Angle.Degrees(+67.27976818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21782"},
        {"Hipparcos Number", "HIP 16700"},
        {"Smithsonian Astrophysical Observation", "SAO 12818"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.72755268),
        dec: Angle.Degrees(+67.28025204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84738",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84738"},
        {"Smithsonian Astrophysical Observation", "SAO 17434"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.83190845),
        dec: Angle.Degrees(+67.28225034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13725"},
        {"Hipparcos Number", "HIP 10618"},
        {"Geneva Identification System", "GEN# +1.00013725"},
        {"Smithsonian Astrophysical Observation", "SAO 12199"},
        {"Wilson Evans Batten Catalogue", "WEB 2232"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.17400105),
        dec: Angle.Degrees(+67.28391848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67161",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67161"},
        {"Smithsonian Astrophysical Observation", "SAO 16169"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.45444864),
        dec: Angle.Degrees(+67.28402113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70545"},
        {"Hipparcos Number", "HIP 41432"},
        {"Smithsonian Astrophysical Observation", "SAO 14549"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.75470318),
        dec: Angle.Degrees(+67.28627821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115136"},
        {"Hipparcos Number", "HIP 64522"},
        {"Geneva Identification System", "GEN# +1.00115136"},
        {"Smithsonian Astrophysical Observation", "SAO 16018"},
        {"Wilson Evans Batten Catalogue", "WEB 11409"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.36776285),
        dec: Angle.Degrees(+67.28793399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71881",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71881"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.53950547),
        dec: Angle.Degrees(+67.28882510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71704"},
        {"Hipparcos Number", "HIP 41948"},
        {"Smithsonian Astrophysical Observation", "SAO 14585"},
        {"Wilson Evans Batten Catalogue", "WEB 8074"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.26954801),
        dec: Angle.Degrees(+67.29300932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29330"},
        {"Hipparcos Number", "HIP 21877"},
        {"Smithsonian Astrophysical Observation", "SAO 13230"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.54713313),
        dec: Angle.Degrees(+67.29333790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42220",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42220"},
        {"Cincinnati Publication", "Ci 20 475"},
        {"Geneva Identification System", "GEN# +0.06700552"},
        {"Wilson Evans Batten Catalogue", "WEB 8114"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.11275725),
        dec: Angle.Degrees(+67.29495249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1065.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86830",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86830"},
        {"Cincinnati Publication", "Ci 18 2370"},
        {"Geneva Identification System", "GEN# +0.06701034"},
        {"Wilson Evans Batten Catalogue", "WEB 14649"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.13785557),
        dec: Angle.Degrees(+67.29565910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -221.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62737",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62737"},
    },
    visualMagnitude: 11.28,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.82823444),
        dec: Angle.Degrees(+67.29613013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 226.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76049"},
        {"Hipparcos Number", "HIP 44015"},
        {"Smithsonian Astrophysical Observation", "SAO 14711"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.44754058),
        dec: Angle.Degrees(+67.29615449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71088"},
        {"Hipparcos Number", "HIP 41676"},
        {"Fundamental Katalog 5th Edition", "FK5 2662"},
        {"Geneva Identification System", "GEN# +1.00071088"},
        {"Smithsonian Astrophysical Observation", "SAO 14568"},
        {"Wilson Evans Batten Catalogue", "WEB 8040"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.44289151),
        dec: Angle.Degrees(+67.29741477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5330",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5330"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.04632230),
        dec: Angle.Degrees(+67.30182050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158633"},
        {"Hipparcos Number", "HIP 85235"},
        {"Cincinnati Publication", "Ci 20 1040"},
        {"Geneva Identification System", "GEN# +1.00158633"},
        {"Smithsonian Astrophysical Observation", "SAO 17474"},
        {"Wilson Evans Batten Catalogue", "WEB 14392"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.25375612),
        dec: Angle.Degrees(+67.30669599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -531.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196406"},
        {"Hipparcos Number", "HIP 101401"},
        {"Geneva Identification System", "GEN# +1.00196406"},
        {"Smithsonian Astrophysical Observation", "SAO 18925"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.25628671),
        dec: Angle.Degrees(+67.30950923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115061"},
        {"Hipparcos Number", "HIP 64482"},
        {"Geneva Identification System", "GEN# +1.00115061"},
        {"Smithsonian Astrophysical Observation", "SAO 16014"},
        {"Wilson Evans Batten Catalogue", "WEB 11398"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.25178250),
        dec: Angle.Degrees(+67.30966125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -156.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201715"},
        {"Hipparcos Number", "HIP 104295"},
        {"Smithsonian Astrophysical Observation", "SAO 19213"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.93433104),
        dec: Angle.Degrees(+67.30993114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64410"},
        {"Hipparcos Number", "HIP 38971"},
        {"Smithsonian Astrophysical Observation", "SAO 14388"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.61850285),
        dec: Angle.Degrees(+67.31509126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44707"},
        {"Hipparcos Number", "HIP 30829"},
        {"Geneva Identification System", "GEN# +1.00044707"},
        {"Smithsonian Astrophysical Observation", "SAO 13844"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.14687265),
        dec: Angle.Degrees(+67.31537363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72625",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72625"},
    },
    visualMagnitude: 11.38,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.73266503),
        dec: Angle.Degrees(+67.31939226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97301"},
        {"Hipparcos Number", "HIP 54801"},
        {"Geneva Identification System", "GEN# +1.00097301"},
        {"Smithsonian Astrophysical Observation", "SAO 15438"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.28160000),
        dec: Angle.Degrees(+67.32289937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31914",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5267 AB"},
        {"Henry Draper", "HD 46701"},
        {"Hipparcos Number", "HIP 31914"},
        {"Smithsonian Astrophysical Observation", "SAO 13914"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.04166527),
        dec: Angle.Degrees(+67.32351263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1478"},
        {"Hipparcos Number", "HIP 1557"},
        {"Smithsonian Astrophysical Observation", "SAO 11110"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.84628102),
        dec: Angle.Degrees(+67.32351674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57640",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8313 B"},
        {"Hipparcos Number", "HIP 57640"},
        {"Wilson Evans Batten Catalogue", "WEB 10354"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.29397771),
        dec: Angle.Degrees(+67.32546157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57639",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8313 A"},
        {"Henry Draper", "HD 102616"},
        {"Hipparcos Number", "HIP 57639"},
        {"Smithsonian Astrophysical Observation", "SAO 15640"},
        {"Wilson Evans Batten Catalogue", "WEB 10351"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.29364463),
        dec: Angle.Degrees(+67.32855162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100971"},
        {"Hipparcos Number", "HIP 56734"},
        {"Geneva Identification System", "GEN# +1.00100971"},
        {"Smithsonian Astrophysical Observation", "SAO 15575"},
        {"Wilson Evans Batten Catalogue", "WEB 10203"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.48615504),
        dec: Angle.Degrees(+67.32992805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50904"},
        {"Hipparcos Number", "HIP 33722"},
        {"Geneva Identification System", "GEN# +1.00050904"},
        {"Smithsonian Astrophysical Observation", "SAO 14037"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.08715087),
        dec: Angle.Degrees(+67.33066173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87354"},
        {"Hipparcos Number", "HIP 49573"},
        {"Smithsonian Astrophysical Observation", "SAO 15084"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.79452366),
        dec: Angle.Degrees(+67.34564067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69767",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69767"},
    },
    visualMagnitude: 11.07,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.17087425),
        dec: Angle.Degrees(+67.34610461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136064"},
        {"Hipparcos Number", "HIP 74605"},
        {"Cincinnati Publication", "Ci 20 921"},
        {"Fundamental Katalog 5th Edition", "FK5 565"},
        {"Geneva Identification System", "GEN# +1.00136064"},
        {"Smithsonian Astrophysical Observation", "SAO 16660"},
        {"Wilson Evans Batten Catalogue", "WEB 12734"},
    },
    visualMagnitude: 5.15,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.65834777),
        dec: Angle.Degrees(+67.34767598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 221.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -392.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149503"},
        {"Hipparcos Number", "HIP 80833"},
        {"Smithsonian Astrophysical Observation", "SAO 17121"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.61419136),
        dec: Angle.Degrees(+67.35206731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35900",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35900"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.01071273),
        dec: Angle.Degrees(+67.35352883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -169.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104984",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14819 A"},
        {"Hipparcos Number", "HIP 104984"},
        {"Smithsonian Astrophysical Observation", "SAO 19282"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.95334796),
        dec: Angle.Degrees(+67.35391282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127557"},
        {"Hipparcos Number", "HIP 70812"},
        {"Smithsonian Astrophysical Observation", "SAO 16398"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.22733634),
        dec: Angle.Degrees(+67.35667503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17172"},
        {"Hipparcos Number", "HIP 13126"},
        {"Smithsonian Astrophysical Observation", "SAO 12448"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.21082490),
        dec: Angle.Degrees(+67.35742741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118808"},
        {"Hipparcos Number", "HIP 66414"},
        {"Smithsonian Astrophysical Observation", "SAO 16123"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.24124612),
        dec: Angle.Degrees(+67.35791589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33323"},
        {"Hipparcos Number", "HIP 24453"},
        {"Geneva Identification System", "GEN# +1.00033323"},
        {"Smithsonian Astrophysical Observation", "SAO 13421"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.69221459),
        dec: Angle.Degrees(+67.36077497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146043"},
        {"Hipparcos Number", "HIP 79171"},
        {"Smithsonian Astrophysical Observation", "SAO 16983"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.38001999),
        dec: Angle.Degrees(+67.36500902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51159",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7766 AB"},
        {"Henry Draper", "HD 90203"},
        {"Hipparcos Number", "HIP 51159"},
        {"Smithsonian Astrophysical Observation", "SAO 15181"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.75113013),
        dec: Angle.Degrees(+67.37016169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120461"},
        {"Hipparcos Number", "HIP 67273"},
        {"Smithsonian Astrophysical Observation", "SAO 16182"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.81124433),
        dec: Angle.Degrees(+67.37249395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4377",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4377"},
        {"Smithsonian Astrophysical Observation", "SAO 11471"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.01879540),
        dec: Angle.Degrees(+67.37723538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176525"},
        {"Hipparcos Number", "HIP 92889"},
        {"Smithsonian Astrophysical Observation", "SAO 18077"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.89223558),
        dec: Angle.Degrees(+67.38066290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11978"},
        {"Hipparcos Number", "HIP 9357"},
        {"Smithsonian Astrophysical Observation", "SAO 12078"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.06027788),
        dec: Angle.Degrees(+67.38201102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81187",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81187"},
        {"Smithsonian Astrophysical Observation", "SAO 17158"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.74978473),
        dec: Angle.Degrees(+67.38635247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156946"},
        {"Hipparcos Number", "HIP 84393"},
        {"Smithsonian Astrophysical Observation", "SAO 17408"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.81024842),
        dec: Angle.Degrees(+67.38835595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11569",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "iot Cas AB"},
        {"Aitken", "ADS 1860 AB"},
        {"Henry Draper", "HD 15089"},
        {"Hipparcos Number", "HIP 11569"},
        {"Geneva Identification System", "GEN# +1.00015089"},
        {"Smithsonian Astrophysical Observation", "SAO 12298"},
        {"Wilson Evans Batten Catalogue", "WEB 2410"},
    },
    visualMagnitude: 4.46,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.26661741),
        dec: Angle.Degrees(+67.40238385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 172",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 172"},
        {"Geneva Identification System", "GEN# +2.78220014"},
        {"Smithsonian Astrophysical Observation", "SAO 21019"},
        {"New General Catalogue", "NGC 7822 14"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.54288062),
        dec: Angle.Degrees(+67.40895644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18962"},
        {"Hipparcos Number", "HIP 14476"},
        {"Geneva Identification System", "GEN# +1.00018962"},
        {"Smithsonian Astrophysical Observation", "SAO 12607"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.70576093),
        dec: Angle.Degrees(+67.41051025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92839"},
        {"Hipparcos Number", "HIP 52577"},
        {"Geneva Identification System", "GEN# +1.00092839"},
        {"Smithsonian Astrophysical Observation", "SAO 15274"},
        {"Wilson Evans Batten Catalogue", "WEB 9577"},
    },
    visualMagnitude: 5.95,
    bvColour: 2.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.26676102),
        dec: Angle.Degrees(+67.41138225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166974"},
        {"Hipparcos Number", "HIP 88813"},
        {"Smithsonian Astrophysical Observation", "SAO 17779"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.94911001),
        dec: Angle.Degrees(+67.41622949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24140"},
        {"Hipparcos Number", "HIP 18342"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.82616019),
        dec: Angle.Degrees(+67.41940070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31150"},
        {"Hipparcos Number", "HIP 23124"},
        {"Smithsonian Astrophysical Observation", "SAO 13321"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.63827380),
        dec: Angle.Degrees(+67.42040686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88497",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88497"},
        {"Smithsonian Astrophysical Observation", "SAO 17750"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.06806899),
        dec: Angle.Degrees(+67.42229262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87000"},
        {"Hipparcos Number", "HIP 49387"},
        {"Geneva Identification System", "GEN# +1.00087000"},
        {"Smithsonian Astrophysical Observation", "SAO 15064"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.23779267),
        dec: Angle.Degrees(+67.42292227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59788",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59788"},
    },
    visualMagnitude: 10.37,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.88983316),
        dec: Angle.Degrees(+67.42409314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21477"},
        {"Hipparcos Number", "HIP 16453"},
        {"Smithsonian Astrophysical Observation", "SAO 12790"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.98789331),
        dec: Angle.Degrees(+67.42532753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97781",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97781"},
    },
    visualMagnitude: 11.22,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.04261343),
        dec: Angle.Degrees(+67.42553139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 187.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169508"},
        {"Hipparcos Number", "HIP 89807"},
        {"Smithsonian Astrophysical Observation", "SAO 17857"},
        {"Wilson Evans Batten Catalogue", "WEB 15326"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.91904555),
        dec: Angle.Degrees(+67.43502439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4580",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 800 AB"},
        {"Henry Draper", "HD 5563"},
        {"Hipparcos Number", "HIP 4580"},
        {"Smithsonian Astrophysical Observation", "SAO 11504"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.66630786),
        dec: Angle.Degrees(+67.44021506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64143"},
        {"Hipparcos Number", "HIP 38875"},
        {"Smithsonian Astrophysical Observation", "SAO 14376"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.32935313),
        dec: Angle.Degrees(+67.44346134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74462"},
        {"Hipparcos Number", "HIP 43228"},
        {"Geneva Identification System", "GEN# +1.00074462"},
        {"Smithsonian Astrophysical Observation", "SAO 14665"},
        {"Wilson Evans Batten Catalogue", "WEB 8334"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.08570448),
        dec: Angle.Degrees(+67.45019595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36945",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36945"},
        {"Smithsonian Astrophysical Observation", "SAO 14244"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.92304283),
        dec: Angle.Degrees(+67.45279031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15855",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2494 A"},
        {"Henry Draper", "HD 20711"},
        {"Hipparcos Number", "HIP 15855"},
        {"Geneva Identification System", "GEN# +1.00020711"},
        {"Smithsonian Astrophysical Observation", "SAO 12738"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.06198037),
        dec: Angle.Degrees(+67.45520743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15852",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2494 B"},
        {"Hipparcos Number", "HIP 15852"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.05467840),
        dec: Angle.Degrees(+67.45658804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51708"},
        {"Hipparcos Number", "HIP 34047"},
        {"Geneva Identification System", "GEN# +1.00051708"},
        {"Smithsonian Astrophysical Observation", "SAO 14059"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.94214053),
        dec: Angle.Degrees(+67.45700228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99737"},
        {"Hipparcos Number", "HIP 56042"},
        {"Smithsonian Astrophysical Observation", "SAO 15519"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.29022801),
        dec: Angle.Degrees(+67.45828741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202461"},
        {"Hipparcos Number", "HIP 104692"},
        {"Smithsonian Astrophysical Observation", "SAO 19250"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.10956180),
        dec: Angle.Degrees(+67.46046571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78274"},
        {"Hipparcos Number", "HIP 45081"},
        {"Geneva Identification System", "GEN# +1.00078274"},
        {"Smithsonian Astrophysical Observation", "SAO 14795"},
        {"Wilson Evans Batten Catalogue", "WEB 8603"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.74551028),
        dec: Angle.Degrees(+67.46516659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -137.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10526",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10526"},
        {"Smithsonian Astrophysical Observation", "SAO 12191"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.91129617),
        dec: Angle.Degrees(+67.46534566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190145"},
        {"Hipparcos Number", "HIP 98357"},
        {"Geneva Identification System", "GEN# +1.00190145"},
        {"Renson", "Renson 52790"},
        {"Smithsonian Astrophysical Observation", "SAO 18637"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.74805678),
        dec: Angle.Degrees(+67.47209918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187611"},
        {"Hipparcos Number", "HIP 97265"},
        {"Geneva Identification System", "GEN# +1.00187611"},
        {"Smithsonian Astrophysical Observation", "SAO 18522"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.51818772),
        dec: Angle.Degrees(+67.47694168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153680"},
        {"Hipparcos Number", "HIP 82841"},
        {"Smithsonian Astrophysical Observation", "SAO 17282"},
    },
    visualMagnitude: 6.78,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.94275889),
        dec: Angle.Degrees(+67.47845587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33231"},
        {"Hipparcos Number", "HIP 24404"},
        {"Smithsonian Astrophysical Observation", "SAO 13416"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.53240502),
        dec: Angle.Degrees(+67.48190982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5340",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 927 AB"},
        {"Henry Draper", "HD 6599"},
        {"Hipparcos Number", "HIP 5340"},
        {"Smithsonian Astrophysical Observation", "SAO 11590"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.06969144),
        dec: Angle.Degrees(+67.48337626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79872",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79872"},
    },
    visualMagnitude: 10.54,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.55366443),
        dec: Angle.Degrees(+67.48411490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 170.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22768",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3479 AB"},
        {"Henry Draper", "HD 30555"},
        {"Hipparcos Number", "HIP 22768"},
        {"Smithsonian Astrophysical Observation", "SAO 13296"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.46603716),
        dec: Angle.Degrees(+67.48755872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17062",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17062"},
        {"Smithsonian Astrophysical Observation", "SAO 12843"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.86633252),
        dec: Angle.Degrees(+67.48764006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221862"},
        {"Hipparcos Number", "HIP 116394"},
        {"Fundamental Katalog 5th Edition", "FK5 6086"},
        {"Geneva Identification System", "GEN# +1.00221862"},
        {"Smithsonian Astrophysical Observation", "SAO 20713"},
        {"Wilson Evans Batten Catalogue", "WEB 20565"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.78920772),
        dec: Angle.Degrees(+67.49186403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114703"},
        {"Hipparcos Number", "HIP 64275"},
        {"Cincinnati Publication", "Ci 18 1693"},
        {"Cincinnati Publication 2", "Ci 20 764"},
        {"Geneva Identification System", "GEN# +1.00114703"},
        {"Smithsonian Astrophysical Observation", "SAO 16003"},
        {"Wilson Evans Batten Catalogue", "WEB 11362"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.59072235),
        dec: Angle.Degrees(+67.49486859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -710.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141264"},
        {"Hipparcos Number", "HIP 77031"},
        {"Smithsonian Astrophysical Observation", "SAO 16829"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.92635388),
        dec: Angle.Degrees(+67.50173005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197053"},
        {"Hipparcos Number", "HIP 101715"},
        {"Smithsonian Astrophysical Observation", "SAO 18955"},
    },
    visualMagnitude: 7.70,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.26692049),
        dec: Angle.Degrees(+67.50424787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3846",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3846"},
        {"Smithsonian Astrophysical Observation", "SAO 11414"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.33368104),
        dec: Angle.Degrees(+67.50526639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 139",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 139"},
        {"Geneva Identification System", "GEN# +2.78220003"},
        {"New General Catalogue", "NGC 7822 3"},
    },
    visualMagnitude: 10.03,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.44529240),
        dec: Angle.Degrees(+67.50697620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91453",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91453"},
        {"Smithsonian Astrophysical Observation", "SAO 17968"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.78853451),
        dec: Angle.Degrees(+67.50819252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15849"},
        {"Hipparcos Number", "HIP 12132"},
        {"Geneva Identification System", "GEN# +1.00015849"},
        {"Smithsonian Astrophysical Observation", "SAO 12351"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.07034525),
        dec: Angle.Degrees(+67.51283378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48680"},
        {"Hipparcos Number", "HIP 32773"},
        {"Geneva Identification System", "GEN# +1.00048680"},
        {"Smithsonian Astrophysical Observation", "SAO 13964"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.49479830),
        dec: Angle.Degrees(+67.51330195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3066"},
        {"Hipparcos Number", "HIP 2719"},
        {"Smithsonian Astrophysical Observation", "SAO 11268"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.65585518),
        dec: Angle.Degrees(+67.51646962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39063"},
        {"Hipparcos Number", "HIP 28013"},
        {"Geneva Identification System", "GEN# +1.00039063"},
        {"Smithsonian Astrophysical Observation", "SAO 13648"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.88239874),
        dec: Angle.Degrees(+67.52296905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91255"},
        {"Hipparcos Number", "HIP 51729"},
        {"Geneva Identification System", "GEN# +1.00091255"},
        {"Smithsonian Astrophysical Observation", "SAO 15219"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.54094776),
        dec: Angle.Degrees(+67.52488088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69285"},
        {"Hipparcos Number", "HIP 40902"},
        {"Smithsonian Astrophysical Observation", "SAO 14507"},
        {"Wilson Evans Batten Catalogue", "WEB 7932"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.19999994),
        dec: Angle.Degrees(+67.52695346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46698",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7399 B"},
        {"Hipparcos Number", "HIP 46698"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.79453078),
        dec: Angle.Degrees(+67.53607745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46696",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7399 A"},
        {"Henry Draper", "HD 81787"},
        {"Hipparcos Number", "HIP 46696"},
        {"Geneva Identification System", "GEN# +1.00081787"},
        {"Smithsonian Astrophysical Observation", "SAO 14903"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.79106072),
        dec: Angle.Degrees(+67.54124880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30751"},
        {"Hipparcos Number", "HIP 22896"},
        {"Smithsonian Astrophysical Observation", "SAO 13303"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.86792921),
        dec: Angle.Degrees(+67.54767007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116814",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16921 AB"},
        {"Henry Draper", "HD 222471"},
        {"Hipparcos Number", "HIP 116814"},
        {"Smithsonian Astrophysical Observation", "SAO 20765"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.12425827),
        dec: Angle.Degrees(+67.55328331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118113",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118113"},
        {"Geneva Identification System", "GEN# +2.78220006"},
        {"Smithsonian Astrophysical Observation", "SAO 20958"},
        {"New General Catalogue", "NGC 7822 6"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.38585841),
        dec: Angle.Degrees(+67.55425222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23818"},
        {"Hipparcos Number", "HIP 18129"},
        {"Geneva Identification System", "GEN# +1.00023818"},
        {"Smithsonian Astrophysical Observation", "SAO 12938"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.14751490),
        dec: Angle.Degrees(+67.55665189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64489",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64489"},
        {"Smithsonian Astrophysical Observation", "SAO 16015"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.27687069),
        dec: Angle.Degrees(+67.55793395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34464"},
        {"Hipparcos Number", "HIP 25144"},
        {"Smithsonian Astrophysical Observation", "SAO 13468"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.70994873),
        dec: Angle.Degrees(+67.56049943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18478",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18478"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.23652007),
        dec: Angle.Degrees(+67.56145134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60911"},
        {"Hipparcos Number", "HIP 37503"},
        {"Geneva Identification System", "GEN# +1.00060911"},
        {"Smithsonian Astrophysical Observation", "SAO 14282"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.45188960),
        dec: Angle.Degrees(+67.56649140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223567"},
        {"Hipparcos Number", "HIP 117550"},
        {"Geneva Identification System", "GEN# +1.00223567"},
        {"Smithsonian Astrophysical Observation", "SAO 20886"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.59149586),
        dec: Angle.Degrees(+67.56940379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48879"},
        {"Hipparcos Number", "HIP 32864"},
        {"Fundamental Katalog 5th Edition", "FK5 2523"},
        {"Geneva Identification System", "GEN# +1.00048879"},
        {"Smithsonian Astrophysical Observation", "SAO 13973"},
        {"Wilson Evans Batten Catalogue", "WEB 6615"},
    },
    visualMagnitude: 5.14,
    bvColour: -0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.73786720),
        dec: Angle.Degrees(+67.57192306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14542",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14542"},
        {"Geneva Identification System", "GEN# +0.06700244"},
        {"Smithsonian Astrophysical Observation", "SAO 12609"},
        {"Wilson Evans Batten Catalogue", "WEB 2828"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.94064073),
        dec: Angle.Degrees(+67.57739816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11824"},
        {"Hipparcos Number", "HIP 9231"},
        {"Smithsonian Astrophysical Observation", "SAO 12062"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.66920009),
        dec: Angle.Degrees(+67.57946544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16459",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2576 A"},
        {"Henry Draper", "HD 21476"},
        {"Hipparcos Number", "HIP 16459"},
        {"Renson", "Renson 5360"},
        {"Smithsonian Astrophysical Observation", "SAO 12792"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.00592643),
        dec: Angle.Degrees(+67.58567944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124752"},
        {"Hipparcos Number", "HIP 69400"},
        {"Geneva Identification System", "GEN# +1.00124752J"},
        {"Smithsonian Astrophysical Observation", "SAO 16306"},
        {"Wilson Evans Batten Catalogue", "WEB 12098"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.11180064),
        dec: Angle.Degrees(+67.58617881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53086",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53086"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.91287707),
        dec: Angle.Degrees(+67.58656148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -171.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -299.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21750",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21750"},
    },
    visualMagnitude: 10.81,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.05064230),
        dec: Angle.Degrees(+67.58910934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 221.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -283.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9777"},
        {"Hipparcos Number", "HIP 7590"},
        {"Smithsonian Astrophysical Observation", "SAO 11873"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.43497011),
        dec: Angle.Degrees(+67.59030587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100433"},
        {"Hipparcos Number", "HIP 56425"},
        {"Smithsonian Astrophysical Observation", "SAO 15553"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.53063184),
        dec: Angle.Degrees(+67.59091542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209004"},
        {"Hipparcos Number", "HIP 108387"},
        {"Smithsonian Astrophysical Observation", "SAO 19764"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.37719808),
        dec: Angle.Degrees(+67.59149615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16458",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2576 B"},
        {"Hipparcos Number", "HIP 16458"},
        {"Smithsonian Astrophysical Observation", "SAO 12791"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.00594160),
        dec: Angle.Degrees(+67.59195473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94879"},
        {"Hipparcos Number", "HIP 53661"},
        {"Smithsonian Astrophysical Observation", "SAO 15352"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.68097112),
        dec: Angle.Degrees(+67.59288206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152644"},
        {"Hipparcos Number", "HIP 82336"},
        {"Smithsonian Astrophysical Observation", "SAO 17238"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.36270080),
        dec: Angle.Degrees(+67.59655739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115467",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115467"},
        {"Smithsonian Astrophysical Observation", "SAO 20598"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.85537909),
        dec: Angle.Degrees(+67.60580399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61232"},
        {"Hipparcos Number", "HIP 37626"},
        {"Smithsonian Astrophysical Observation", "SAO 14293"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.81452259),
        dec: Angle.Degrees(+67.60860440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46623",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46623"},
        {"Smithsonian Astrophysical Observation", "SAO 14899"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.61186512),
        dec: Angle.Degrees(+67.61232184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9614"},
        {"Hipparcos Number", "HIP 7486"},
        {"Smithsonian Astrophysical Observation", "SAO 11853"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.09792854),
        dec: Angle.Degrees(+67.61505930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30859",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30859"},
    },
    visualMagnitude: 10.77,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.18965404),
        dec: Angle.Degrees(+67.61529858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49284",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49284"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.90137559),
        dec: Angle.Degrees(+67.62569749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184273"},
        {"Hipparcos Number", "HIP 95776"},
        {"Geneva Identification System", "GEN# +1.00184273"},
        {"Smithsonian Astrophysical Observation", "SAO 18362"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.19596286),
        dec: Angle.Degrees(+67.62667280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144282"},
        {"Hipparcos Number", "HIP 78402"},
        {"Geneva Identification System", "GEN# +1.00144282"},
        {"Smithsonian Astrophysical Observation", "SAO 16925"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.08796078),
        dec: Angle.Degrees(+67.62736889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162522"},
        {"Hipparcos Number", "HIP 86957"},
        {"Smithsonian Astrophysical Observation", "SAO 17632"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.53668811),
        dec: Angle.Degrees(+67.62832763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51040",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51040"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.40867297),
        dec: Angle.Degrees(+67.62872712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76827"},
        {"Hipparcos Number", "HIP 44390"},
        {"Fundamental Katalog 5th Edition", "FK5 338"},
        {"Geneva Identification System", "GEN# +1.00076827"},
        {"Smithsonian Astrophysical Observation", "SAO 14742"},
        {"Wilson Evans Batten Catalogue", "WEB 8509"},
    },
    visualMagnitude: 4.74,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.63635792),
        dec: Angle.Degrees(+67.62957486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28342"},
        {"Hipparcos Number", "HIP 21219"},
        {"Smithsonian Astrophysical Observation", "SAO 13176"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.27962305),
        dec: Angle.Degrees(+67.63149302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8630",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8630"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.83081802),
        dec: Angle.Degrees(+67.63150184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221725"},
        {"Hipparcos Number", "HIP 116308"},
        {"Geneva Identification System", "GEN# +1.00221725"},
        {"Smithsonian Astrophysical Observation", "SAO 20705"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.48178981),
        dec: Angle.Degrees(+67.63446325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117517",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117517"},
        {"Geneva Identification System", "GEN# +0.06601646"},
        {"Smithsonian Astrophysical Observation", "SAO 20882"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.48120054),
        dec: Angle.Degrees(+67.63744526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83772",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83772"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.81453032),
        dec: Angle.Degrees(+67.63971565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40708"},
        {"Hipparcos Number", "HIP 28905"},
        {"Cincinnati Publication", "Ci 18 748"},
        {"Smithsonian Astrophysical Observation", "SAO 13706"},
        {"Wilson Evans Batten Catalogue", "WEB 5654"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.53100039),
        dec: Angle.Degrees(+67.64075778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -314.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54714"},
        {"Hipparcos Number", "HIP 35073"},
        {"Smithsonian Astrophysical Observation", "SAO 14122"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.78909429),
        dec: Angle.Degrees(+67.64870794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10926"},
        {"Hipparcos Number", "HIP 8506"},
        {"Smithsonian Astrophysical Observation", "SAO 12000"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.42452242),
        dec: Angle.Degrees(+67.65944978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -162.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94376",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Altais"},
        {"Henry Draper", "HD 180711"},
        {"Hipparcos Number", "HIP 94376"},
        {"Fundamental Katalog 5th Edition", "FK5 723"},
        {"Geneva Identification System", "GEN# +1.00180711"},
        {"Smithsonian Astrophysical Observation", "SAO 18222"},
        {"Wilson Evans Batten Catalogue", "WEB 16446"},
    },
    visualMagnitude: 3.07,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.13814581),
        dec: Angle.Degrees(+67.66131695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 92.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56168"},
        {"Hipparcos Number", "HIP 35628"},
        {"Smithsonian Astrophysical Observation", "SAO 14155"},
        {"Wilson Evans Batten Catalogue", "WEB 7099"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.27849906),
        dec: Angle.Degrees(+67.66166399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117028",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117028"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.85812568),
        dec: Angle.Degrees(+67.66512284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77769",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77769"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.19147993),
        dec: Angle.Degrees(+67.66702959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1674",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 283 AB"},
        {"Henry Draper", "HD 1624"},
        {"Hipparcos Number", "HIP 1674"},
        {"Geneva Identification System", "GEN# +1.00001624"},
        {"Smithsonian Astrophysical Observation", "SAO 11124"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.23788452),
        dec: Angle.Degrees(+67.66729201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105979",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105979"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.95135468),
        dec: Angle.Degrees(+67.66766646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65580"},
        {"Hipparcos Number", "HIP 39484"},
        {"Smithsonian Astrophysical Observation", "SAO 14419"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.04703544),
        dec: Angle.Degrees(+67.67217021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13579"},
        {"Hipparcos Number", "HIP 10531"},
        {"Cincinnati Publication", "Ci 18 286"},
        {"Cincinnati Publication 2", "Ci 20 154"},
        {"Geneva Identification System", "GEN# +1.00013579"},
        {"Smithsonian Astrophysical Observation", "SAO 12190"},
        {"Wilson Evans Batten Catalogue", "WEB 2209"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.92400175),
        dec: Angle.Degrees(+67.67305655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 515.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -318.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9743",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9743"},
        {"Smithsonian Astrophysical Observation", "SAO 12114"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.33399805),
        dec: Angle.Degrees(+67.67439517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10529",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10529"},
        {"Smithsonian Astrophysical Observation", "SAO 12192"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.91876882),
        dec: Angle.Degrees(+67.67781871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 515.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -318.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33001"},
        {"Hipparcos Number", "HIP 24255"},
        {"Geneva Identification System", "GEN# +1.00033001"},
        {"Smithsonian Astrophysical Observation", "SAO 13400"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.09643370),
        dec: Angle.Degrees(+67.67950355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27783"},
        {"Hipparcos Number", "HIP 20855"},
        {"Geneva Identification System", "GEN# +1.00027783"},
        {"Smithsonian Astrophysical Observation", "SAO 13148"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.03299391),
        dec: Angle.Degrees(+67.68064841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9746",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9746"},
        {"Smithsonian Astrophysical Observation", "SAO 12115"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.34382704),
        dec: Angle.Degrees(+67.68359984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90107"},
        {"Hipparcos Number", "HIP 51091"},
        {"Smithsonian Astrophysical Observation", "SAO 15176"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.57902913),
        dec: Angle.Degrees(+67.68525146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115866"},
        {"Hipparcos Number", "HIP 64903"},
        {"Smithsonian Astrophysical Observation", "SAO 16037"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.54941862),
        dec: Angle.Degrees(+67.68794818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43411",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43411"},
        {"Smithsonian Astrophysical Observation", "SAO 14675"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.63552453),
        dec: Angle.Degrees(+67.68900171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125372"},
        {"Hipparcos Number", "HIP 69710"},
        {"Smithsonian Astrophysical Observation", "SAO 16323"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.03299960),
        dec: Angle.Degrees(+67.68929878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58671",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58671"},
    },
    visualMagnitude: 11.99,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.44699147),
        dec: Angle.Degrees(+67.70346848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80518"},
        {"Hipparcos Number", "HIP 46086"},
        {"Smithsonian Astrophysical Observation", "SAO 14864"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.96851202),
        dec: Angle.Degrees(+67.71005712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11389",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11389"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.68965883),
        dec: Angle.Degrees(+67.71045949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112499"},
        {"Hipparcos Number", "HIP 63114"},
        {"Smithsonian Astrophysical Observation", "SAO 15944"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.98373767),
        dec: Angle.Degrees(+67.71078627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30189",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30189"},
    },
    visualMagnitude: 11.32,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.26923857),
        dec: Angle.Degrees(+67.71658829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109339",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109339"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.25753873),
        dec: Angle.Degrees(+67.71744947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210604"},
        {"Hipparcos Number", "HIP 109335"},
        {"Smithsonian Astrophysical Observation", "SAO 19899"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.25005482),
        dec: Angle.Degrees(+67.72315525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71301",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71301"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.72566650),
        dec: Angle.Degrees(+67.72355625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 116.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27136"},
        {"Hipparcos Number", "HIP 20399"},
        {"Geneva Identification System", "GEN# +1.00027136"},
        {"Smithsonian Astrophysical Observation", "SAO 13107"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.51421826),
        dec: Angle.Degrees(+67.72660455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29974",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4876 AB"},
        {"Henry Draper", "HD 42891"},
        {"Hipparcos Number", "HIP 29974"},
        {"Smithsonian Astrophysical Observation", "SAO 13789"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.65632829),
        dec: Angle.Degrees(+67.72846320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14486",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14486"},
    },
    visualMagnitude: 11.74,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.75073978),
        dec: Angle.Degrees(+67.73434521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14483",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14483"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.73890759),
        dec: Angle.Degrees(+67.73685147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187610"},
        {"Hipparcos Number", "HIP 97262"},
        {"Geneva Identification System", "GEN# +1.00187610"},
        {"Smithsonian Astrophysical Observation", "SAO 18521"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.50905168),
        dec: Angle.Degrees(+67.73789996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15682"},
        {"Hipparcos Number", "HIP 11984"},
        {"Geneva Identification System", "GEN# +1.00015682"},
        {"Smithsonian Astrophysical Observation", "SAO 12337"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.64849550),
        dec: Angle.Degrees(+67.74301419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8851",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8851"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.46270991),
        dec: Angle.Degrees(+67.74712288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73327",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73327"},
        {"Geneva Identification System", "GEN# +0.06800813"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.76359678),
        dec: Angle.Degrees(+67.74930576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -144.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 202.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107426",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15315 AB"},
        {"Henry Draper", "HD 207369"},
        {"Hipparcos Number", "HIP 107426"},
        {"Smithsonian Astrophysical Observation", "SAO 19631"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.37244643),
        dec: Angle.Degrees(+67.75130863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3004",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3004"},
        {"Smithsonian Astrophysical Observation", "SAO 11303"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.55169844),
        dec: Angle.Degrees(+67.75184206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208629"},
        {"Hipparcos Number", "HIP 108151"},
        {"Fundamental Katalog 5th Edition", "FK5 3750"},
        {"Geneva Identification System", "GEN# +1.00208629"},
        {"Smithsonian Astrophysical Observation", "SAO 19735"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.67884042),
        dec: Angle.Degrees(+67.75375521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20390"},
        {"Hipparcos Number", "HIP 15595"},
        {"Geneva Identification System", "GEN# +1.00020390"},
        {"Smithsonian Astrophysical Observation", "SAO 12711"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.20959738),
        dec: Angle.Degrees(+67.75640127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109429",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109429"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.55109758),
        dec: Angle.Degrees(+67.75916741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113378"},
        {"Hipparcos Number", "HIP 63587"},
        {"Smithsonian Astrophysical Observation", "SAO 15963"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.45721015),
        dec: Angle.Degrees(+67.76078434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48803",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48803"},
        {"Smithsonian Astrophysical Observation", "SAO 15027"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.30704711),
        dec: Angle.Degrees(+67.76312111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200149"},
        {"Hipparcos Number", "HIP 103474"},
        {"Smithsonian Astrophysical Observation", "SAO 19129"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.45817569),
        dec: Angle.Degrees(+67.76349283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29949"},
        {"Hipparcos Number", "HIP 22312"},
        {"Geneva Identification System", "GEN# +1.00029949"},
        {"Smithsonian Astrophysical Observation", "SAO 13267"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.08101613),
        dec: Angle.Degrees(+67.76349823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110776"},
        {"Hipparcos Number", "HIP 62080"},
        {"Smithsonian Astrophysical Observation", "SAO 15881"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.85907220),
        dec: Angle.Degrees(+67.76579311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85330",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10573 AB"},
        {"Henry Draper", "HD 158867"},
        {"Hipparcos Number", "HIP 85330"},
        {"Smithsonian Astrophysical Observation", "SAO 17489"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.57171248),
        dec: Angle.Degrees(+67.76583840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99791",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99791"},
        {"Smithsonian Astrophysical Observation", "SAO 18778"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.70450526),
        dec: Angle.Degrees(+67.76683091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66195",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8959 AB"},
        {"Henry Draper", "HD 118328"},
        {"Hipparcos Number", "HIP 66195"},
        {"Geneva Identification System", "GEN# +1.00118328"},
        {"Smithsonian Astrophysical Observation", "SAO 16111"},
        {"Wilson Evans Batten Catalogue", "WEB 11694"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.52627839),
        dec: Angle.Degrees(+67.76881134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -180.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174732"},
        {"Hipparcos Number", "HIP 92137"},
        {"Geneva Identification System", "GEN# +1.00174732"},
        {"Smithsonian Astrophysical Observation", "SAO 18022"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.69101550),
        dec: Angle.Degrees(+67.77145729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31014"},
        {"Hipparcos Number", "HIP 23066"},
        {"Smithsonian Astrophysical Observation", "SAO 13315"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.44807086),
        dec: Angle.Degrees(+67.77615550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171992"},
        {"Hipparcos Number", "HIP 90882"},
        {"Smithsonian Astrophysical Observation", "SAO 17922"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.07838327),
        dec: Angle.Degrees(+67.77689330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3816"},
        {"Hipparcos Number", "HIP 3281"},
        {"Geneva Identification System", "GEN# +1.00003816"},
        {"Smithsonian Astrophysical Observation", "SAO 11334"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.832,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.45624803),
        dec: Angle.Degrees(+67.77984560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6840"},
        {"Hipparcos Number", "HIP 5531"},
        {"Geneva Identification System", "GEN# +1.00006840"},
        {"Smithsonian Astrophysical Observation", "SAO 11614"},
        {"Wilson Evans Batten Catalogue", "WEB 1225"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.70982927),
        dec: Angle.Degrees(+67.78003781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 250.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135384"},
        {"Hipparcos Number", "HIP 74272"},
        {"Smithsonian Astrophysical Observation", "SAO 16630"},
        {"Wilson Evans Batten Catalogue", "WEB 12680"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.68498350),
        dec: Angle.Degrees(+67.78106662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167469"},
        {"Hipparcos Number", "HIP 89011"},
        {"Geneva Identification System", "GEN# +1.00167469"},
        {"Smithsonian Astrophysical Observation", "SAO 17797"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.50540077),
        dec: Angle.Degrees(+67.78216115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70041",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9231 A"},
        {"Henry Draper", "HD 126028"},
        {"Hipparcos Number", "HIP 70041"},
        {"Smithsonian Astrophysical Observation", "SAO 16342"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.97883054),
        dec: Angle.Degrees(+67.78248362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19131",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19131"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.51408857),
        dec: Angle.Degrees(+67.78318658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78732",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78732"},
        {"Smithsonian Astrophysical Observation", "SAO 16948"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.09412137),
        dec: Angle.Degrees(+67.79222034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197471"},
        {"Hipparcos Number", "HIP 101971"},
        {"Smithsonian Astrophysical Observation", "SAO 18981"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.97692492),
        dec: Angle.Degrees(+67.79254095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88036",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88036"},
        {"Geneva Identification System", "GEN# +0.06701044"},
        {"Smithsonian Astrophysical Observation", "SAO 17718"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.72783406),
        dec: Angle.Degrees(+67.79361671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113703",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16459 AB"},
        {"Henry Draper", "HD 217781"},
        {"Hipparcos Number", "HIP 113703"},
        {"Smithsonian Astrophysical Observation", "SAO 20376"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.42691331),
        dec: Angle.Degrees(+67.79520220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27168",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27168"},
    },
    visualMagnitude: 10.85,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.37724294),
        dec: Angle.Degrees(+67.79550209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -225.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126228"},
        {"Hipparcos Number", "HIP 70141"},
        {"Smithsonian Astrophysical Observation", "SAO 16352"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.28240153),
        dec: Angle.Degrees(+67.80289529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96298",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12675 A"},
        {"Hipparcos Number", "HIP 96298"},
        {"Smithsonian Astrophysical Observation", "SAO 18418"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.69510263),
        dec: Angle.Degrees(+67.80431421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172824"},
        {"Hipparcos Number", "HIP 91263"},
        {"Smithsonian Astrophysical Observation", "SAO 17957"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.23432055),
        dec: Angle.Degrees(+67.80439412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7770"},
        {"Hipparcos Number", "HIP 6173"},
        {"Smithsonian Astrophysical Observation", "SAO 11689"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.79298677),
        dec: Angle.Degrees(+67.80502717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139586"},
        {"Hipparcos Number", "HIP 76256"},
        {"Geneva Identification System", "GEN# +1.00139586"},
        {"Smithsonian Astrophysical Observation", "SAO 16773"},
        {"Wilson Evans Batten Catalogue", "WEB 12947"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.65051220),
        dec: Angle.Degrees(+67.80584722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223274"},
        {"Hipparcos Number", "HIP 117371"},
        {"Fundamental Katalog 5th Edition", "FK5 895"},
        {"Geneva Identification System", "GEN# +1.00223274"},
        {"Smithsonian Astrophysical Observation", "SAO 20853"},
        {"Wilson Evans Batten Catalogue", "WEB 20677"},
    },
    visualMagnitude: 5.05,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.97811533),
        dec: Angle.Degrees(+67.80681263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145454"},
        {"Hipparcos Number", "HIP 78893"},
        {"Fundamental Katalog 5th Edition", "FK5 3276"},
        {"Geneva Identification System", "GEN# +1.00145454"},
        {"Smithsonian Astrophysical Observation", "SAO 16962"},
        {"Wilson Evans Batten Catalogue", "WEB 13335"},
    },
    visualMagnitude: 5.44,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.58221690),
        dec: Angle.Degrees(+67.80998136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114785",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114785"},
        {"Smithsonian Astrophysical Observation", "SAO 20513"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.77687374),
        dec: Angle.Degrees(+67.81120904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103903"},
        {"Hipparcos Number", "HIP 58358"},
        {"Smithsonian Astrophysical Observation", "SAO 15672"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.50135398),
        dec: Angle.Degrees(+67.81215892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17443"},
        {"Hipparcos Number", "HIP 13330"},
        {"Geneva Identification System", "GEN# +1.00017443"},
        {"Smithsonian Astrophysical Observation", "SAO 12469"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.88646519),
        dec: Angle.Degrees(+67.81506714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7665"},
        {"Hipparcos Number", "HIP 6099"},
        {"Geneva Identification System", "GEN# +1.00007665"},
        {"Smithsonian Astrophysical Observation", "SAO 11681"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.57780185),
        dec: Angle.Degrees(+67.81643881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137070"},
        {"Hipparcos Number", "HIP 75022"},
        {"Smithsonian Astrophysical Observation", "SAO 16698"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.94952072),
        dec: Angle.Degrees(+67.81900344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90460",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90460"},
        {"Smithsonian Astrophysical Observation", "SAO 17897"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.88028172),
        dec: Angle.Degrees(+67.82026378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1695"},
        {"Hipparcos Number", "HIP 1725"},
        {"Smithsonian Astrophysical Observation", "SAO 11130"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.42684242),
        dec: Angle.Degrees(+67.82302547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16769"},
        {"Hipparcos Number", "HIP 12821"},
        {"Fundamental Katalog 5th Edition", "FK5 92"},
        {"Geneva Identification System", "GEN# +1.00016769"},
        {"Renson", "Renson 4240"},
        {"Smithsonian Astrophysical Observation", "SAO 12421"},
        {"Wilson Evans Batten Catalogue", "WEB 2605"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.20695883),
        dec: Angle.Degrees(+67.82470926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33763",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33763"},
        {"Smithsonian Astrophysical Observation", "SAO 14039"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.18375127),
        dec: Angle.Degrees(+67.83310025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110362"},
        {"Hipparcos Number", "HIP 61850"},
        {"Geneva Identification System", "GEN# +1.00110362"},
        {"Smithsonian Astrophysical Observation", "SAO 15864"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.13925633),
        dec: Angle.Degrees(+67.83322677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42062"},
        {"Hipparcos Number", "HIP 29588"},
        {"Geneva Identification System", "GEN# +1.00042062"},
        {"Smithsonian Astrophysical Observation", "SAO 13759"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.53552566),
        dec: Angle.Degrees(+67.83764600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1"},
        {"Hipparcos Number", "HIP 422"},
        {"Smithsonian Astrophysical Observation", "SAO 10963"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.28675856),
        dec: Angle.Degrees(+67.84002075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152376"},
        {"Hipparcos Number", "HIP 82214"},
        {"Smithsonian Astrophysical Observation", "SAO 17232"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.94276348),
        dec: Angle.Degrees(+67.84208483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19110",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19110"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.44035518),
        dec: Angle.Degrees(+67.84287050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118126",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118126"},
        {"Geneva Identification System", "GEN# +2.78220005"},
        {"New General Catalogue", "NGC 7822 5"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.40270628),
        dec: Angle.Degrees(+67.84467802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114128",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114128"},
        {"Smithsonian Astrophysical Observation", "SAO 20430"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.70162656),
        dec: Angle.Degrees(+67.84742671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222016"},
        {"Hipparcos Number", "HIP 116503"},
        {"Smithsonian Astrophysical Observation", "SAO 20725"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.11859408),
        dec: Angle.Degrees(+67.84890995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20891",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20891"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.15656056),
        dec: Angle.Degrees(+67.85165743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 182.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103010"},
        {"Hipparcos Number", "HIP 57853"},
        {"Fundamental Katalog 5th Edition", "FK5 5044"},
        {"Smithsonian Astrophysical Observation", "SAO 15645"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.97477619),
        dec: Angle.Degrees(+67.85625158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72129",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72129"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.31952590),
        dec: Angle.Degrees(+67.85795794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220906"},
        {"Hipparcos Number", "HIP 115735"},
        {"Geneva Identification System", "GEN# +1.00220906J"},
        {"Smithsonian Astrophysical Observation", "SAO 20636"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.70930883),
        dec: Angle.Degrees(+67.86681758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190940"},
        {"Hipparcos Number", "HIP 98702"},
        {"Fundamental Katalog 5th Edition", "FK5 3608"},
        {"Geneva Identification System", "GEN# +1.00190940"},
        {"Smithsonian Astrophysical Observation", "SAO 18676"},
        {"Wilson Evans Batten Catalogue", "WEB 17479"},
    },
    visualMagnitude: 4.51,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.70436340),
        dec: Angle.Degrees(+67.87344872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195588"},
        {"Hipparcos Number", "HIP 100936"},
        {"Smithsonian Astrophysical Observation", "SAO 18881"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.98422369),
        dec: Angle.Degrees(+67.87748176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106022",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106022"},
        {"Smithsonian Astrophysical Observation", "SAO 19445"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.11497974),
        dec: Angle.Degrees(+67.87753732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20221",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3110 AB"},
        {"Henry Draper", "HD 26881"},
        {"Hipparcos Number", "HIP 20221"},
        {"Smithsonian Astrophysical Observation", "SAO 13095"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.99603724),
        dec: Angle.Degrees(+67.88032731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31818",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31818"},
    },
    visualMagnitude: 10.94,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.78584349),
        dec: Angle.Degrees(+67.88190699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98044"},
        {"Hipparcos Number", "HIP 55162"},
        {"Smithsonian Astrophysical Observation", "SAO 15463"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.40010718),
        dec: Angle.Degrees(+67.88338066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63158"},
        {"Hipparcos Number", "HIP 38426"},
        {"Smithsonian Astrophysical Observation", "SAO 14345"},
    },
    visualMagnitude: 9.00,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.07660381),
        dec: Angle.Degrees(+67.89081286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91129"},
        {"Hipparcos Number", "HIP 51668"},
        {"Fundamental Katalog 5th Edition", "FK5 4937"},
        {"Smithsonian Astrophysical Observation", "SAO 15217"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.33868183),
        dec: Angle.Degrees(+67.89451469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13553"},
        {"Hipparcos Number", "HIP 10488"},
        {"Geneva Identification System", "GEN# +1.00013553"},
        {"Smithsonian Astrophysical Observation", "SAO 12187"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.80473309),
        dec: Angle.Degrees(+67.89895965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133814"},
        {"Hipparcos Number", "HIP 73582"},
        {"Geneva Identification System", "GEN# +1.00133814"},
        {"Smithsonian Astrophysical Observation", "SAO 16581"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.60900239),
        dec: Angle.Degrees(+67.90438747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181180"},
        {"Hipparcos Number", "HIP 94535"},
        {"Smithsonian Astrophysical Observation", "SAO 18236"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.59558587),
        dec: Angle.Degrees(+67.90584885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80095",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80095"},
        {"Smithsonian Astrophysical Observation", "SAO 17056"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.23913388),
        dec: Angle.Degrees(+67.90746020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122006"},
        {"Hipparcos Number", "HIP 68084"},
        {"Smithsonian Astrophysical Observation", "SAO 16226"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.10378438),
        dec: Angle.Degrees(+67.90791940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181179"},
        {"Hipparcos Number", "HIP 94527"},
        {"Smithsonian Astrophysical Observation", "SAO 18235"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.58373053),
        dec: Angle.Degrees(+67.90800050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4281",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4281"},
        {"Fundamental Katalog 5th Edition", "FK5 4078"},
        {"Smithsonian Astrophysical Observation", "SAO 11460"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.70339760),
        dec: Angle.Degrees(+67.90850064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153058"},
        {"Hipparcos Number", "HIP 82518"},
        {"Smithsonian Astrophysical Observation", "SAO 17253"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.97929087),
        dec: Angle.Degrees(+67.91501042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35250"},
        {"Hipparcos Number", "HIP 25665"},
        {"Geneva Identification System", "GEN# +1.00035250J"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.22328611),
        dec: Angle.Degrees(+67.91579168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89913",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89913"},
        {"Smithsonian Astrophysical Observation", "SAO 17863"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.20934239),
        dec: Angle.Degrees(+67.91710875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53390",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53390"},
        {"Smithsonian Astrophysical Observation", "SAO 15332"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.80787340),
        dec: Angle.Degrees(+67.92333645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3147"},
        {"Hipparcos Number", "HIP 2796"},
        {"Geneva Identification System", "GEN# +1.00003147"},
        {"Smithsonian Astrophysical Observation", "SAO 11279"},
        {"Wilson Evans Batten Catalogue", "WEB 501"},
    },
    visualMagnitude: 6.92,
    bvColour: 2.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.90488601),
        dec: Angle.Degrees(+67.92595909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1949"},
        {"Hipparcos Number", "HIP 1932"},
        {"Geneva Identification System", "GEN# +1.00001949"},
        {"Smithsonian Astrophysical Observation", "SAO 11166"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.08640723),
        dec: Angle.Degrees(+67.94293833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217525"},
        {"Hipparcos Number", "HIP 113553"},
        {"Smithsonian Astrophysical Observation", "SAO 20359"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.97997611),
        dec: Angle.Degrees(+67.94978511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21922"},
        {"Hipparcos Number", "HIP 16818"},
        {"Geneva Identification System", "GEN# +1.00021922"},
        {"Smithsonian Astrophysical Observation", "SAO 12829"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.10813149),
        dec: Angle.Degrees(+67.95214918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3860",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3860"},
    },
    visualMagnitude: 10.42,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.39207268),
        dec: Angle.Degrees(+67.95272431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 236.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102500",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102500"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.59066493),
        dec: Angle.Degrees(+67.95674586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153623"},
        {"Hipparcos Number", "HIP 82799"},
        {"Smithsonian Astrophysical Observation", "SAO 17278"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.81874820),
        dec: Angle.Degrees(+67.95904593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9186"},
        {"Hipparcos Number", "HIP 7175"},
        {"Smithsonian Astrophysical Observation", "SAO 11806"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.12467548),
        dec: Angle.Degrees(+67.96119466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59328",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59328"},
    },
    visualMagnitude: 10.29,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.56039994),
        dec: Angle.Degrees(+67.96192999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132326"},
        {"Hipparcos Number", "HIP 72963"},
        {"Geneva Identification System", "GEN# +1.00132326"},
        {"Smithsonian Astrophysical Observation", "SAO 16549"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.67071187),
        dec: Angle.Degrees(+67.96306033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52163",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52163"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.85728731),
        dec: Angle.Degrees(+67.97369910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108583",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15542 AB"},
        {"Henry Draper", "HD 209328"},
        {"Hipparcos Number", "HIP 108583"},
        {"Smithsonian Astrophysical Observation", "SAO 19787"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.94591602),
        dec: Angle.Degrees(+67.97400237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70645"},
        {"Hipparcos Number", "HIP 41488"},
        {"Geneva Identification System", "GEN# +1.00070645"},
        {"Smithsonian Astrophysical Observation", "SAO 14552"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.91742307),
        dec: Angle.Degrees(+67.97419942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29067",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29067"},
        {"Geneva Identification System", "GEN# +6.20030234"},
        {"Wilson Evans Batten Catalogue", "WEB 5694"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.98052613),
        dec: Angle.Degrees(+67.97709065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37553"},
        {"Hipparcos Number", "HIP 27109"},
        {"Geneva Identification System", "GEN# +1.00037553"},
        {"Smithsonian Astrophysical Observation", "SAO 13592"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.23105386),
        dec: Angle.Degrees(+67.97922052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167274"},
        {"Hipparcos Number", "HIP 88909"},
        {"Smithsonian Astrophysical Observation", "SAO 17792"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.23198712),
        dec: Angle.Degrees(+67.98822087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216606"},
        {"Hipparcos Number", "HIP 112970"},
        {"Fundamental Katalog 5th Edition", "FK5 6021"},
        {"Geneva Identification System", "GEN# +1.00216606"},
        {"Smithsonian Astrophysical Observation", "SAO 20295"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.17565965),
        dec: Angle.Degrees(+67.99001147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216582"},
        {"Hipparcos Number", "HIP 112946"},
        {"Geneva Identification System", "GEN# +1.00216582"},
        {"Smithsonian Astrophysical Observation", "SAO 20291"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.12519808),
        dec: Angle.Degrees(+67.99346916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22086"},
        {"Hipparcos Number", "HIP 16937"},
        {"Geneva Identification System", "GEN# +1.00022086"},
        {"Smithsonian Astrophysical Observation", "SAO 12836"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.49652122),
        dec: Angle.Degrees(+67.99458076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34018"},
        {"Hipparcos Number", "HIP 24858"},
        {"Renson", "Renson 8666"},
        {"Smithsonian Astrophysical Observation", "SAO 13454"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.92898743),
        dec: Angle.Degrees(+67.99642490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1227",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1227"},
    },
    visualMagnitude: 11.67,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.81343259),
        dec: Angle.Degrees(+68.00650677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27692",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27692"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.94302138),
        dec: Angle.Degrees(+68.00830577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150142"},
        {"Hipparcos Number", "HIP 81104"},
        {"Smithsonian Astrophysical Observation", "SAO 17150"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.47908062),
        dec: Angle.Degrees(+68.01301648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35863"},
        {"Hipparcos Number", "HIP 26008"},
        {"Geneva Identification System", "GEN# +1.00035863"},
        {"Smithsonian Astrophysical Observation", "SAO 13527"},
        {"Wilson Evans Batten Catalogue", "WEB 5059"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.26211940),
        dec: Angle.Degrees(+68.01343183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83020"},
        {"Hipparcos Number", "HIP 47348"},
        {"Smithsonian Astrophysical Observation", "SAO 14948"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.71214076),
        dec: Angle.Degrees(+68.01420510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68768",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68768"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.12899909),
        dec: Angle.Degrees(+68.02316333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24513"},
        {"Hipparcos Number", "HIP 18596"},
        {"Geneva Identification System", "GEN# +1.00024513"},
        {"Smithsonian Astrophysical Observation", "SAO 12975"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.68345071),
        dec: Angle.Degrees(+68.02389995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82896",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82896"},
        {"Cincinnati Publication", "Ci 18 2266"},
        {"Geneva Identification System", "GEN# +0.06800901"},
        {"Smithsonian Astrophysical Observation", "SAO 17287"},
        {"Wilson Evans Batten Catalogue", "WEB 14015"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.10112194),
        dec: Angle.Degrees(+68.02452093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 263.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191372"},
        {"Hipparcos Number", "HIP 98890"},
        {"Geneva Identification System", "GEN# +1.00191372"},
        {"Smithsonian Astrophysical Observation", "SAO 18699"},
        {"Wilson Evans Batten Catalogue", "WEB 17554"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.22255255),
        dec: Angle.Degrees(+68.02718293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198737"},
        {"Hipparcos Number", "HIP 102684"},
        {"Geneva Identification System", "GEN# +1.00198737"},
        {"Smithsonian Astrophysical Observation", "SAO 19045"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.10636975),
        dec: Angle.Degrees(+68.03262979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 108.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81017",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81017"},
        {"Smithsonian Astrophysical Observation", "SAO 17140"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.18666387),
        dec: Angle.Degrees(+68.03723870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27626"},
        {"Hipparcos Number", "HIP 20729"},
        {"Smithsonian Astrophysical Observation", "SAO 13141"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.63114777),
        dec: Angle.Degrees(+68.03989231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10221"},
        {"Hipparcos Number", "HIP 7965"},
        {"Fundamental Katalog 5th Edition", "FK5 55"},
        {"Geneva Identification System", "GEN# +1.00010221"},
        {"Renson", "Renson 2550"},
        {"Smithsonian Astrophysical Observation", "SAO 11919"},
        {"Wilson Evans Batten Catalogue", "WEB 1705"},
    },
    visualMagnitude: 5.57,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.58518510),
        dec: Angle.Degrees(+68.04304624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38511",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38511"},
        {"Smithsonian Astrophysical Observation", "SAO 14347"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.30380249),
        dec: Angle.Degrees(+68.04518984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16066"},
        {"Hipparcos Number", "HIP 12297"},
        {"Geneva Identification System", "GEN# +1.00016066"},
        {"Smithsonian Astrophysical Observation", "SAO 12364"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.59698516),
        dec: Angle.Degrees(+68.06132131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16505"},
        {"Hipparcos Number", "HIP 12641"},
        {"Geneva Identification System", "GEN# +1.00016505"},
        {"Smithsonian Astrophysical Observation", "SAO 12393"},
        {"Wilson Evans Batten Catalogue", "WEB 2572"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.59459004),
        dec: Angle.Degrees(+68.06438224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95341",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95341"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.94762262),
        dec: Angle.Degrees(+68.06541953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107886"},
        {"Hipparcos Number", "HIP 60431"},
        {"Smithsonian Astrophysical Observation", "SAO 15789"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.86119669),
        dec: Angle.Degrees(+68.07052469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115650",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115650"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.42425277),
        dec: Angle.Degrees(+68.07077161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122051"},
        {"Hipparcos Number", "HIP 68111"},
        {"Smithsonian Astrophysical Observation", "SAO 16227"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.17064602),
        dec: Angle.Degrees(+68.07292429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10974",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10974"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.33904474),
        dec: Angle.Degrees(+68.08127681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127945"},
        {"Hipparcos Number", "HIP 70963"},
        {"Smithsonian Astrophysical Observation", "SAO 16410"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.72358082),
        dec: Angle.Degrees(+68.08174531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214583"},
        {"Hipparcos Number", "HIP 111675"},
        {"Smithsonian Astrophysical Observation", "SAO 20180"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.828,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.34691324),
        dec: Angle.Degrees(+68.08199775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208376"},
        {"Hipparcos Number", "HIP 108008"},
        {"Smithsonian Astrophysical Observation", "SAO 19709"},
        {"Wilson Evans Batten Catalogue", "WEB 19473"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.23293207),
        dec: Angle.Degrees(+68.09848752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151541"},
        {"Hipparcos Number", "HIP 81813"},
        {"Cincinnati Publication", "Ci 20 1009"},
        {"Cincinnati Publication 2", "Ci 18 2242"},
        {"Geneva Identification System", "GEN# +1.00151541"},
        {"Smithsonian Astrophysical Observation", "SAO 17200"},
        {"Wilson Evans Batten Catalogue", "WEB 13823"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.66257909),
        dec: Angle.Degrees(+68.10112992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -282.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 427.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70599",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70599"},
        {"Smithsonian Astrophysical Observation", "SAO 16380"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.60288415),
        dec: Angle.Degrees(+68.10181510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77326"},
        {"Hipparcos Number", "HIP 44645"},
        {"Smithsonian Astrophysical Observation", "SAO 14756"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.45492350),
        dec: Angle.Degrees(+68.10184639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119080"},
        {"Hipparcos Number", "HIP 66570"},
        {"Smithsonian Astrophysical Observation", "SAO 16133"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.68233339),
        dec: Angle.Degrees(+68.10411597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208411"},
        {"Hipparcos Number", "HIP 108030"},
        {"Smithsonian Astrophysical Observation", "SAO 19712"},
        {"Wilson Evans Batten Catalogue", "WEB 19476"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.28415739),
        dec: Angle.Degrees(+68.10748225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115088",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16666 AB"},
        {"Henry Draper", "HD 219916"},
        {"Hipparcos Number", "HIP 115088"},
        {"Geneva Identification System", "GEN# +1.00219916"},
        {"Smithsonian Astrophysical Observation", "SAO 20554"},
        {"Wilson Evans Batten Catalogue", "WEB 20388"},
    },
    visualMagnitude: 4.75,
    bvColour: 0.836,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.65586210),
        dec: Angle.Degrees(+68.11141807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174103"},
        {"Hipparcos Number", "HIP 91836"},
        {"Smithsonian Astrophysical Observation", "SAO 17992"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.85309513),
        dec: Angle.Degrees(+68.11242169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61145"},
        {"Hipparcos Number", "HIP 37605"},
        {"Smithsonian Astrophysical Observation", "SAO 14287"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.73834760),
        dec: Angle.Degrees(+68.11881402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160450"},
        {"Hipparcos Number", "HIP 85988"},
        {"Smithsonian Astrophysical Observation", "SAO 17547"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.61889649),
        dec: Angle.Degrees(+68.11945323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98987"},
        {"Hipparcos Number", "HIP 55676"},
        {"Smithsonian Astrophysical Observation", "SAO 15495"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.12056415),
        dec: Angle.Degrees(+68.12090100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79367",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79367"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.97455193),
        dec: Angle.Degrees(+68.12580776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99858"},
        {"Hipparcos Number", "HIP 56110"},
        {"Smithsonian Astrophysical Observation", "SAO 15526"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.52255023),
        dec: Angle.Degrees(+68.12717687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13448"},
        {"Hipparcos Number", "HIP 10433"},
        {"Fundamental Katalog 5th Edition", "FK5 4205"},
        {"Geneva Identification System", "GEN# +1.00013448"},
        {"Smithsonian Astrophysical Observation", "SAO 12178"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.61019599),
        dec: Angle.Degrees(+68.12735406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6692",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1129 A"},
        {"Henry Draper", "HD 8491"},
        {"Hipparcos Number", "HIP 6692"},
        {"Fundamental Katalog 5th Edition", "FK5 46"},
        {"Geneva Identification System", "GEN# +1.00008491"},
        {"Smithsonian Astrophysical Observation", "SAO 11751"},
        {"Wilson Evans Batten Catalogue", "WEB 1461"},
    },
    visualMagnitude: 4.72,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.48293404),
        dec: Angle.Degrees(+68.12994739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106966",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15217 AB"},
        {"Henry Draper", "HD 206578"},
        {"Hipparcos Number", "HIP 106966"},
        {"Smithsonian Astrophysical Observation", "SAO 19566"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.96324286),
        dec: Angle.Degrees(+68.13074774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64165",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64165"},
        {"Smithsonian Astrophysical Observation", "SAO 15997"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.25881191),
        dec: Angle.Degrees(+68.13111240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112317",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16252 AB"},
        {"Henry Draper", "HD 215661"},
        {"Hipparcos Number", "HIP 112317"},
        {"Geneva Identification System", "GEN# +1.00215661J"},
        {"Wilson Evans Batten Catalogue", "WEB 20038"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.26083456),
        dec: Angle.Degrees(+68.13290233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50618",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50618"},
    },
    visualMagnitude: 11.32,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.09489671),
        dec: Angle.Degrees(+68.13411278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159966"},
        {"Hipparcos Number", "HIP 85805"},
        {"Fundamental Katalog 5th Edition", "FK5 659"},
        {"Geneva Identification System", "GEN# +1.00159966"},
        {"Smithsonian Astrophysical Observation", "SAO 17526"},
        {"Wilson Evans Batten Catalogue", "WEB 14480"},
    },
    visualMagnitude: 5.07,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.99120820),
        dec: Angle.Degrees(+68.13470186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 132.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50620",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50620"},
        {"Smithsonian Astrophysical Observation", "SAO 15143"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.09943614),
        dec: Angle.Degrees(+68.13900025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2582"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.20112580),
        dec: Angle.Degrees(+68.14294462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39642"},
        {"Hipparcos Number", "HIP 28362"},
        {"Smithsonian Astrophysical Observation", "SAO 13667"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.88330587),
        dec: Angle.Degrees(+68.14721136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29476"},
        {"Hipparcos Number", "HIP 21995"},
        {"Smithsonian Astrophysical Observation", "SAO 13241"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.91945826),
        dec: Angle.Degrees(+68.14963073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11395"},
        {"Hipparcos Number", "HIP 8896"},
        {"Geneva Identification System", "GEN# +1.00011395"},
        {"Smithsonian Astrophysical Observation", "SAO 12030"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.64259295),
        dec: Angle.Degrees(+68.15125113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200775"},
        {"Hipparcos Number", "HIP 103763"},
        {"Fundamental Katalog 5th Edition", "FK5 5852"},
        {"Geneva Identification System", "GEN# +1.00200775"},
        {"Smithsonian Astrophysical Observation", "SAO 19158"},
        {"Wilson Evans Batten Catalogue", "WEB 18885"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.40378840),
        dec: Angle.Degrees(+68.16327115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3923"},
        {"Hipparcos Number", "HIP 3349"},
        {"Smithsonian Astrophysical Observation", "SAO 11341"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.67024391),
        dec: Angle.Degrees(+68.16399006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 561",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 561"},
    },
    visualMagnitude: 11.79,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.70960701),
        dec: Angle.Degrees(+68.16712552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5556",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5556"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.81536521),
        dec: Angle.Degrees(+68.16813526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30243"},
        {"Hipparcos Number", "HIP 22552"},
        {"Smithsonian Astrophysical Observation", "SAO 13285"},
        {"Wilson Evans Batten Catalogue", "WEB 4355"},
    },
    visualMagnitude: 6.54,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.80563970),
        dec: Angle.Degrees(+68.16879623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116926"},
        {"Hipparcos Number", "HIP 65449"},
        {"Cincinnati Publication", "Ci 18 1738"},
        {"Geneva Identification System", "GEN# +1.00116926"},
        {"Smithsonian Astrophysical Observation", "SAO 16067"},
        {"Wilson Evans Batten Catalogue", "WEB 11549"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.20521597),
        dec: Angle.Degrees(+68.17550070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -218.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17947"},
        {"Hipparcos Number", "HIP 13743"},
        {"Geneva Identification System", "GEN# +1.00017947"},
        {"Smithsonian Astrophysical Observation", "SAO 12522"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.23249449),
        dec: Angle.Degrees(+68.17793153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24545",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24545"},
        {"Smithsonian Astrophysical Observation", "SAO 13427"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.98528284),
        dec: Angle.Degrees(+68.18259559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11250"},
        {"Hipparcos Number", "HIP 8797"},
        {"Smithsonian Astrophysical Observation", "SAO 12018"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.27140287),
        dec: Angle.Degrees(+68.18488337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206135"},
        {"Hipparcos Number", "HIP 106712"},
        {"Geneva Identification System", "GEN# +1.00206135"},
        {"Smithsonian Astrophysical Observation", "SAO 19532"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.23773589),
        dec: Angle.Degrees(+68.18537221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184330"},
        {"Hipparcos Number", "HIP 95780"},
        {"Smithsonian Astrophysical Observation", "SAO 18365"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.21829289),
        dec: Angle.Degrees(+68.18678035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 386",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 386"},
        {"Geneva Identification System", "GEN# +2.78220009"},
        {"Smithsonian Astrophysical Observation", "SAO 10957"},
        {"New General Catalogue", "NGC 7822 9"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.20394853),
        dec: Angle.Degrees(+68.18869710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30833",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30833"},
        {"Cincinnati Publication", "Ci 18 794"},
        {"Smithsonian Astrophysical Observation", "SAO 13843"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.14891499),
        dec: Angle.Degrees(+68.18871691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -229.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50053"},
        {"Hipparcos Number", "HIP 33416"},
        {"Smithsonian Astrophysical Observation", "SAO 14008"},
    },
    visualMagnitude: 8.36,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.23409689),
        dec: Angle.Degrees(+68.19389039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36450"},
        {"Hipparcos Number", "HIP 26415"},
        {"Smithsonian Astrophysical Observation", "SAO 13545"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.33054701),
        dec: Angle.Degrees(+68.20332115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30426"},
        {"Hipparcos Number", "HIP 22707"},
        {"Smithsonian Astrophysical Observation", "SAO 13292"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.24255988),
        dec: Angle.Degrees(+68.21568519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48878"},
        {"Hipparcos Number", "HIP 32881"},
        {"Smithsonian Astrophysical Observation", "SAO 13974"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.77572386),
        dec: Angle.Degrees(+68.21816552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30530"},
        {"Hipparcos Number", "HIP 22765"},
        {"Smithsonian Astrophysical Observation", "SAO 13295"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.46001720),
        dec: Angle.Degrees(+68.21903484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205938"},
        {"Hipparcos Number", "HIP 106604"},
        {"Renson", "Renson 57340"},
        {"Smithsonian Astrophysical Observation", "SAO 19521"},
    },
    visualMagnitude: 6.47,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.85795750),
        dec: Angle.Degrees(+68.21925148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73817"},
        {"Hipparcos Number", "HIP 42896"},
        {"Smithsonian Astrophysical Observation", "SAO 14642"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.12526862),
        dec: Angle.Degrees(+68.22079346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213503"},
        {"Henry Draper 2", "HD 213504"},
        {"Hipparcos Number", "HIP 111046"},
        {"Geneva Identification System", "GEN# +1.00213503"},
        {"Smithsonian Astrophysical Observation", "SAO 20110"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.44246836),
        dec: Angle.Degrees(+68.22117687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101318"},
        {"Hipparcos Number", "HIP 56923"},
        {"Smithsonian Astrophysical Observation", "SAO 15588"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.05456175),
        dec: Angle.Degrees(+68.22316209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138116"},
        {"Hipparcos Number", "HIP 75513"},
        {"Smithsonian Astrophysical Observation", "SAO 16734"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.40384698),
        dec: Angle.Degrees(+68.22593899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45501",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45501"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.07710408),
        dec: Angle.Degrees(+68.22811174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130984"},
        {"Hipparcos Number", "HIP 72320"},
        {"Smithsonian Astrophysical Observation", "SAO 16501"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.83909567),
        dec: Angle.Degrees(+68.23026008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109967",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109967"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.08278903),
        dec: Angle.Degrees(+68.23029574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117650",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117650"},
    },
    visualMagnitude: 11.43,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.90343926),
        dec: Angle.Degrees(+68.23181213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63602",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63602"},
    },
    visualMagnitude: 9.94,
    bvColour: 1.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.51735734),
        dec: Angle.Degrees(+68.23203031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11892"},
        {"Hipparcos Number", "HIP 9309"},
        {"Geneva Identification System", "GEN# +1.00011892"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.89932615),
        dec: Angle.Degrees(+68.23331784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188625"},
        {"Hipparcos Number", "HIP 97686"},
        {"Geneva Identification System", "GEN# +1.00188625"},
        {"Smithsonian Astrophysical Observation", "SAO 18566"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.79351867),
        dec: Angle.Degrees(+68.24020825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221302"},
        {"Hipparcos Number", "HIP 116010"},
        {"Smithsonian Astrophysical Observation", "SAO 20667"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.56900647),
        dec: Angle.Degrees(+68.24259302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58215",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58215"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.09099899),
        dec: Angle.Degrees(+68.24654921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1080",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1080"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.36300334),
        dec: Angle.Degrees(+68.24822384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216992"},
        {"Hipparcos Number", "HIP 113243"},
        {"Geneva Identification System", "GEN# +1.00216992"},
        {"Smithsonian Astrophysical Observation", "SAO 20329"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.98272160),
        dec: Angle.Degrees(+68.24888371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107249",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107249"},
        {"Smithsonian Astrophysical Observation", "SAO 19606"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.83886984),
        dec: Angle.Degrees(+68.24962205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49597"},
        {"Hipparcos Number", "HIP 33207"},
        {"Geneva Identification System", "GEN# +1.00049597"},
        {"Smithsonian Astrophysical Observation", "SAO 14000"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.66894817),
        dec: Angle.Degrees(+68.25205789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201731"},
        {"Hipparcos Number", "HIP 104291"},
        {"Fundamental Katalog 5th Edition", "FK5 3694"},
        {"Geneva Identification System", "GEN# +1.00201731"},
        {"Smithsonian Astrophysical Observation", "SAO 19214"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.92018111),
        dec: Angle.Degrees(+68.25406758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63873"},
        {"Hipparcos Number", "HIP 38762"},
        {"Smithsonian Astrophysical Observation", "SAO 14367"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.02809983),
        dec: Angle.Degrees(+68.25520831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47207",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47207"},
    },
    visualMagnitude: 10.77,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.30470044),
        dec: Angle.Degrees(+68.25602207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74862",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74862"},
    },
    visualMagnitude: 10.10,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.47496031),
        dec: Angle.Degrees(+68.25799227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152028"},
        {"Hipparcos Number", "HIP 82056"},
        {"Geneva Identification System", "GEN# +1.00152028"},
        {"Smithsonian Astrophysical Observation", "SAO 17215"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.42163900),
        dec: Angle.Degrees(+68.25854034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108811",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15587 A"},
        {"Henry Draper", "HD 209675"},
        {"Hipparcos Number", "HIP 108811"},
        {"Geneva Identification System", "GEN# +1.00209675"},
        {"Smithsonian Astrophysical Observation", "SAO 19813"},
        {"Wilson Evans Batten Catalogue", "WEB 19573"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.64249921),
        dec: Angle.Degrees(+68.25898952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 176.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108802",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15587 BC"},
        {"Hipparcos Number", "HIP 108802"},
    },
    visualMagnitude: 12.37,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)02, 28.5500),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)15, 33.200)
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
    primaryId: "HIP 24044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32637"},
        {"Hipparcos Number", "HIP 24044"},
        {"Smithsonian Astrophysical Observation", "SAO 13387"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.51438075),
        dec: Angle.Degrees(+68.26556256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32141"},
        {"Hipparcos Number", "HIP 23754"},
        {"Smithsonian Astrophysical Observation", "SAO 13366"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.59263937),
        dec: Angle.Degrees(+68.26859500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17137",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17137"},
        {"Smithsonian Astrophysical Observation", "SAO 12851"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.05007987),
        dec: Angle.Degrees(+68.26919509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97138"},
        {"Hipparcos Number", "HIP 54721"},
        {"Smithsonian Astrophysical Observation", "SAO 15431"},
        {"Wilson Evans Batten Catalogue", "WEB 9878"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.04539839),
        dec: Angle.Degrees(+68.27185385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192575"},
        {"Hipparcos Number", "HIP 99435"},
        {"Fundamental Katalog 5th Edition", "FK5 5776"},
        {"Geneva Identification System", "GEN# +1.00192575"},
        {"Smithsonian Astrophysical Observation", "SAO 18750"},
        {"Wilson Evans Batten Catalogue", "WEB 17760"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.73718662),
        dec: Angle.Degrees(+68.27222348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35706",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35706"},
        {"Geneva Identification System", "GEN# +0.06800474"},
    },
    visualMagnitude: 10.11,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.50825821),
        dec: Angle.Degrees(+68.27403951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 122.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117829"},
        {"Hipparcos Number", "HIP 65916"},
        {"Geneva Identification System", "GEN# +1.00117829"},
        {"Smithsonian Astrophysical Observation", "SAO 16095"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.69830201),
        dec: Angle.Degrees(+68.27615439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43615",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43615"},
        {"Smithsonian Astrophysical Observation", "SAO 14688"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.24777853),
        dec: Angle.Degrees(+68.27740918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12919"},
        {"Hipparcos Number", "HIP 10049"},
        {"Smithsonian Astrophysical Observation", "SAO 12147"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.34487118),
        dec: Angle.Degrees(+68.27825503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28779"},
        {"Hipparcos Number", "HIP 21530"},
        {"Smithsonian Astrophysical Observation", "SAO 13201"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.34823370),
        dec: Angle.Degrees(+68.28237201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34115",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34115"},
    },
    visualMagnitude: 11.95,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.10581565),
        dec: Angle.Degrees(+68.28866968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 346.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191667"},
        {"Hipparcos Number", "HIP 99036"},
        {"Smithsonian Astrophysical Observation", "SAO 18718"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.60724276),
        dec: Angle.Degrees(+68.29108615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176841"},
        {"Hipparcos Number", "HIP 93007"},
        {"Geneva Identification System", "GEN# +1.00176841"},
        {"Smithsonian Astrophysical Observation", "SAO 18085"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.20597185),
        dec: Angle.Degrees(+68.29239059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205235"},
        {"Hipparcos Number", "HIP 106193"},
        {"Smithsonian Astrophysical Observation", "SAO 19467"},
    },
    visualMagnitude: 7.04,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.64970899),
        dec: Angle.Degrees(+68.29324557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192438"},
        {"Hipparcos Number", "HIP 99378"},
        {"Geneva Identification System", "GEN# +1.00192438"},
        {"Smithsonian Astrophysical Observation", "SAO 18746"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.56274015),
        dec: Angle.Degrees(+68.29838567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210341"},
        {"Hipparcos Number", "HIP 109196"},
        {"Geneva Identification System", "GEN# +1.00210341"},
        {"Smithsonian Astrophysical Observation", "SAO 19872"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.80683928),
        dec: Angle.Degrees(+68.30214230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74160",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74160"},
        {"Smithsonian Astrophysical Observation", "SAO 16621"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.29112452),
        dec: Angle.Degrees(+68.31154628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121146"},
        {"Hipparcos Number", "HIP 67589"},
        {"Fundamental Katalog 5th Edition", "FK5 3103"},
        {"Geneva Identification System", "GEN# +1.00121146"},
        {"Smithsonian Astrophysical Observation", "SAO 16197"},
        {"Wilson Evans Batten Catalogue", "WEB 11885"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.74749152),
        dec: Angle.Degrees(+68.31544168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -176.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42765"},
        {"Hipparcos Number", "HIP 29943"},
        {"Smithsonian Astrophysical Observation", "SAO 13785"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.55989311),
        dec: Angle.Degrees(+68.31879462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150982"},
        {"Hipparcos Number", "HIP 81539"},
        {"Geneva Identification System", "GEN# +1.00150982"},
        {"Smithsonian Astrophysical Observation", "SAO 17182"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.80873114),
        dec: Angle.Degrees(+68.32112104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178304"},
        {"Hipparcos Number", "HIP 93517"},
        {"Smithsonian Astrophysical Observation", "SAO 18132"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.67902095),
        dec: Angle.Degrees(+68.32517208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90820"},
        {"Hipparcos Number", "HIP 51519"},
        {"Smithsonian Astrophysical Observation", "SAO 15205"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.83978786),
        dec: Angle.Degrees(+68.32527514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121163"},
        {"Hipparcos Number", "HIP 67609"},
        {"Geneva Identification System", "GEN# +1.00121163"},
        {"Smithsonian Astrophysical Observation", "SAO 16200"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.80433823),
        dec: Angle.Degrees(+68.32624262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26110"},
        {"Hipparcos Number", "HIP 19680"},
        {"Smithsonian Astrophysical Observation", "SAO 13063"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.24535565),
        dec: Angle.Degrees(+68.32851260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181875"},
        {"Hipparcos Number", "HIP 94769"},
        {"Smithsonian Astrophysical Observation", "SAO 18268"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.24527802),
        dec: Angle.Degrees(+68.33493705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109980",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109980"},
        {"Cincinnati Publication", "Ci 18 2908"},
        {"Geneva Identification System", "GEN# +0.06701424"},
        {"Smithsonian Astrophysical Observation", "SAO 19977"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.12996055),
        dec: Angle.Degrees(+68.33981857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 377.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163148"},
        {"Hipparcos Number", "HIP 87209"},
        {"Smithsonian Astrophysical Observation", "SAO 17648"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.25847266),
        dec: Angle.Degrees(+68.34183260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86162",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86162"},
        {"Cincinnati Publication", "Ci 18 2354"},
        {"Cincinnati Publication 2", "Ci 20 1053"},
        {"Geneva Identification System", "GEN# +0.06800946"},
        {"Smithsonian Astrophysical Observation", "SAO 17568"},
        {"Wilson Evans Batten Catalogue", "WEB 14533"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.11002650),
        dec: Angle.Degrees(+68.34222717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -320.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1269.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141323"},
        {"Hipparcos Number", "HIP 77035"},
        {"Smithsonian Astrophysical Observation", "SAO 16830"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.94613335),
        dec: Angle.Degrees(+68.34804513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202986"},
        {"Hipparcos Number", "HIP 104969"},
        {"Geneva Identification System", "GEN# +1.00202986"},
        {"Smithsonian Astrophysical Observation", "SAO 19281"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.92741459),
        dec: Angle.Degrees(+68.35225615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62513",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62513"},
    },
    visualMagnitude: 11.31,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.16499020),
        dec: Angle.Degrees(+68.35616941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24493"},
        {"Hipparcos Number", "HIP 18574"},
        {"Geneva Identification System", "GEN# +1.00024493"},
        {"Smithsonian Astrophysical Observation", "SAO 12974"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.64170161),
        dec: Angle.Degrees(+68.35690003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222568"},
        {"Hipparcos Number", "HIP 116856"},
        {"Geneva Identification System", "GEN# +1.00222568"},
        {"Smithsonian Astrophysical Observation", "SAO 20776"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.29631919),
        dec: Angle.Degrees(+68.35988514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11091"},
        {"Hipparcos Number", "HIP 8662"},
        {"Geneva Identification System", "GEN# +1.00011091"},
        {"Smithsonian Astrophysical Observation", "SAO 12008"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.90196925),
        dec: Angle.Degrees(+68.36127691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19277"},
        {"Hipparcos Number", "HIP 14724"},
        {"Fundamental Katalog 5th Edition", "FK5 4290"},
        {"Smithsonian Astrophysical Observation", "SAO 12625"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.54637426),
        dec: Angle.Degrees(+68.36294978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8062",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8062"},
        {"Smithsonian Astrophysical Observation", "SAO 11939"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.88755358),
        dec: Angle.Degrees(+68.36374507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100645",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100645"},
        {"Smithsonian Astrophysical Observation", "SAO 18854"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.11842783),
        dec: Angle.Degrees(+68.36435669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96360"},
        {"Hipparcos Number", "HIP 54396"},
        {"Smithsonian Astrophysical Observation", "SAO 15407"},
        {"Wilson Evans Batten Catalogue", "WEB 9823"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.96999740),
        dec: Angle.Degrees(+68.36640116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15784"},
        {"Hipparcos Number", "HIP 12083"},
        {"Geneva Identification System", "GEN# +1.00015784"},
        {"Smithsonian Astrophysical Observation", "SAO 12345"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.93242541),
        dec: Angle.Degrees(+68.36780067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25765"},
        {"Hipparcos Number", "HIP 19458"},
        {"Geneva Identification System", "GEN# +1.00025765"},
        {"Smithsonian Astrophysical Observation", "SAO 13043"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.50769330),
        dec: Angle.Degrees(+68.37370575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15156",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15156"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.83807953),
        dec: Angle.Degrees(+68.37756277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65871"},
        {"Hipparcos Number", "HIP 39616"},
        {"Cincinnati Publication", "Ci 18 950"},
        {"Geneva Identification System", "GEN# +1.00065871"},
        {"Smithsonian Astrophysical Observation", "SAO 14426"},
        {"Wilson Evans Batten Catalogue", "WEB 7741"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.43480605),
        dec: Angle.Degrees(+68.38213222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -213.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -223.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160861"},
        {"Hipparcos Number", "HIP 86187"},
        {"Smithsonian Astrophysical Observation", "SAO 17570"},
        {"Wilson Evans Batten Catalogue", "WEB 14537"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.17537112),
        dec: Angle.Degrees(+68.38286031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107004",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15225 AB"},
        {"Henry Draper", "HD 206631"},
        {"Hipparcos Number", "HIP 107004"},
        {"Smithsonian Astrophysical Observation", "SAO 19573"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.07768234),
        dec: Angle.Degrees(+68.38938502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217224"},
        {"Hipparcos Number", "HIP 113385"},
        {"Geneva Identification System", "GEN# +1.00217224"},
        {"Smithsonian Astrophysical Observation", "SAO 20345"},
        {"Wilson Evans Batten Catalogue", "WEB 20169"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.44715109),
        dec: Angle.Degrees(+68.40723588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115612"},
        {"Hipparcos Number", "HIP 64774"},
        {"Fundamental Katalog 5th Edition", "FK5 3060"},
        {"Geneva Identification System", "GEN# +1.00115612"},
        {"Smithsonian Astrophysical Observation", "SAO 16033"},
        {"Wilson Evans Batten Catalogue", "WEB 11449"},
    },
    visualMagnitude: 6.20,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.11939858),
        dec: Angle.Degrees(+68.40796113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117287",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117287"},
    },
    visualMagnitude: 11.05,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.72951352),
        dec: Angle.Degrees(+68.40824095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9166"},
        {"Hipparcos Number", "HIP 7166"},
        {"Geneva Identification System", "GEN# +1.00009166"},
        {"Smithsonian Astrophysical Observation", "SAO 11803"},
        {"Wilson Evans Batten Catalogue", "WEB 1548"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.10112547),
        dec: Angle.Degrees(+68.40906428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190109"},
        {"Hipparcos Number", "HIP 98324"},
        {"Smithsonian Astrophysical Observation", "SAO 18635"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.65468829),
        dec: Angle.Degrees(+68.41194339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41413"},
        {"Hipparcos Number", "HIP 29300"},
        {"Geneva Identification System", "GEN# +1.00041413"},
        {"Smithsonian Astrophysical Observation", "SAO 13734"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.65787784),
        dec: Angle.Degrees(+68.41339874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218209"},
        {"Hipparcos Number", "HIP 113989"},
        {"Cincinnati Publication", "Ci 18 3019"},
        {"Cincinnati Publication 2", "Ci 20 1401"},
        {"Geneva Identification System", "GEN# +1.00218209"},
        {"Smithsonian Astrophysical Observation", "SAO 20408"},
        {"Wilson Evans Batten Catalogue", "WEB 20241"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.27146742),
        dec: Angle.Degrees(+68.41666824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 592.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 162.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14370"},
        {"Hipparcos Number", "HIP 11077"},
        {"Smithsonian Astrophysical Observation", "SAO 12246"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.64603100),
        dec: Angle.Degrees(+68.42335855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99471"},
        {"Hipparcos Number", "HIP 55919"},
        {"Smithsonian Astrophysical Observation", "SAO 15512"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.91657110),
        dec: Angle.Degrees(+68.42821829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218779"},
        {"Hipparcos Number", "HIP 114344"},
        {"Smithsonian Astrophysical Observation", "SAO 20464"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.36834449),
        dec: Angle.Degrees(+68.42844722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212027"},
        {"Hipparcos Number", "HIP 110181"},
        {"Smithsonian Astrophysical Observation", "SAO 20006"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.75936818),
        dec: Angle.Degrees(+68.43247890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41114",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6758 A"},
        {"Henry Draper", "HD 69804"},
        {"Hipparcos Number", "HIP 41114"},
        {"Smithsonian Astrophysical Observation", "SAO 14520"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.83494969),
        dec: Angle.Degrees(+68.43304715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140726"},
        {"Hipparcos Number", "HIP 76788"},
        {"Geneva Identification System", "GEN# +1.00140726"},
        {"Smithsonian Astrophysical Observation", "SAO 16816"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.17805857),
        dec: Angle.Degrees(+68.43326405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21267"},
        {"Hipparcos Number", "HIP 16306"},
        {"Geneva Identification System", "GEN# +1.00021267"},
        {"Smithsonian Astrophysical Observation", "SAO 12780"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.55397055),
        dec: Angle.Degrees(+68.43356906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190424"},
        {"Hipparcos Number", "HIP 98439"},
        {"Smithsonian Astrophysical Observation", "SAO 18650"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.01656693),
        dec: Angle.Degrees(+68.43672183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87598"},
        {"Hipparcos Number", "HIP 49686"},
        {"Cincinnati Publication", "Ci 18 1201"},
        {"Smithsonian Astrophysical Observation", "SAO 15092"},
        {"Wilson Evans Batten Catalogue", "WEB 9163"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.13768550),
        dec: Angle.Degrees(+68.43780434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -262.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187764"},
        {"Hipparcos Number", "HIP 97326"},
        {"Geneva Identification System", "GEN# +1.00187764"},
        {"Smithsonian Astrophysical Observation", "SAO 18530"},
        {"Wilson Evans Batten Catalogue", "WEB 17104"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.68607234),
        dec: Angle.Degrees(+68.43800200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41110",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6758 C"},
        {"Hipparcos Number", "HIP 41110"},
    },
    visualMagnitude: 9.70,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)23, 18.9100),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)26, 17.200)
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
    primaryId: "HIP 28111",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28111"},
        {"Smithsonian Astrophysical Observation", "SAO 13652"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.11668029),
        dec: Angle.Degrees(+68.43829402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92354"},
        {"Hipparcos Number", "HIP 52338"},
        {"Geneva Identification System", "GEN# +1.00092354"},
        {"Smithsonian Astrophysical Observation", "SAO 15260"},
        {"Wilson Evans Batten Catalogue", "WEB 9526"},
    },
    visualMagnitude: 5.74,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.45127204),
        dec: Angle.Degrees(+68.44355985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103702",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103702"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.21422039),
        dec: Angle.Degrees(+68.44478599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77426"},
        {"Hipparcos Number", "HIP 44683"},
        {"Geneva Identification System", "GEN# +1.00077426"},
        {"Smithsonian Astrophysical Observation", "SAO 14761"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.59334377),
        dec: Angle.Degrees(+68.44510360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129168"},
        {"Hipparcos Number", "HIP 71513"},
        {"Smithsonian Astrophysical Observation", "SAO 16443"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.38548355),
        dec: Angle.Degrees(+68.44930970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60133"},
        {"Hipparcos Number", "HIP 37175"},
        {"Smithsonian Astrophysical Observation", "SAO 14260"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.57852431),
        dec: Angle.Degrees(+68.45299829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112789",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112789"},
        {"Smithsonian Astrophysical Observation", "SAO 20275"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.61479635),
        dec: Angle.Degrees(+68.45390906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20363"},
        {"Hipparcos Number", "HIP 15602"},
        {"Smithsonian Astrophysical Observation", "SAO 12710"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.22433901),
        dec: Angle.Degrees(+68.45706193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35274",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35274"},
        {"Geneva Identification System", "GEN# +0.06800467"},
        {"Wilson Evans Batten Catalogue", "WEB 7042"},
    },
    visualMagnitude: 10.20,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.31707765),
        dec: Angle.Degrees(+68.46283095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 249.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67058",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67058"},
    },
    visualMagnitude: 11.62,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.12391875),
        dec: Angle.Degrees(+68.46385455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -270.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58425"},
        {"Hipparcos Number", "HIP 36528"},
        {"Fundamental Katalog 5th Edition", "FK5 284"},
        {"Geneva Identification System", "GEN# +1.00058425"},
        {"Smithsonian Astrophysical Observation", "SAO 14211"},
        {"Wilson Evans Batten Catalogue", "WEB 7266"},
    },
    visualMagnitude: 5.63,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.71958057),
        dec: Angle.Degrees(+68.46572700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4612"},
        {"Hipparcos Number", "HIP 3839"},
        {"Smithsonian Astrophysical Observation", "SAO 11413"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.31726199),
        dec: Angle.Degrees(+68.46724492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16440"},
        {"Hipparcos Number", "HIP 12585"},
        {"Geneva Identification System", "GEN# +1.00016440"},
        {"Smithsonian Astrophysical Observation", "SAO 12387"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.46166911),
        dec: Angle.Degrees(+68.46963567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75715"},
        {"Hipparcos Number", "HIP 43840"},
        {"Smithsonian Astrophysical Observation", "SAO 14697"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.93693542),
        dec: Angle.Degrees(+68.46988614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38645"},
        {"Hipparcos Number", "HIP 27795"},
        {"Fundamental Katalog 5th Edition", "FK5 2438"},
        {"Geneva Identification System", "GEN# +1.00038645"},
        {"Smithsonian Astrophysical Observation", "SAO 13635"},
        {"Wilson Evans Batten Catalogue", "WEB 5447"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.23119883),
        dec: Angle.Degrees(+68.47165107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54667",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54667"},
        {"Smithsonian Astrophysical Observation", "SAO 15426"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.86014817),
        dec: Angle.Degrees(+68.47389772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67447"},
        {"Hipparcos Number", "HIP 40215"},
        {"Fundamental Katalog 5th Edition", "FK5 1215"},
        {"Geneva Identification System", "GEN# +1.00067447"},
        {"Smithsonian Astrophysical Observation", "SAO 14456"},
        {"Wilson Evans Batten Catalogue", "WEB 7842"},
    },
    visualMagnitude: 5.34,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.20328577),
        dec: Angle.Degrees(+68.47405416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118142",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118142"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.45729974),
        dec: Angle.Degrees(+68.47457975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72860"},
        {"Hipparcos Number", "HIP 42476"},
        {"Geneva Identification System", "GEN# +1.00072860"},
        {"Smithsonian Astrophysical Observation", "SAO 14611"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.89479794),
        dec: Angle.Degrees(+68.47791945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85828"},
        {"Hipparcos Number", "HIP 48813"},
        {"Smithsonian Astrophysical Observation", "SAO 15028"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.35485464),
        dec: Angle.Degrees(+68.48040960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160832"},
        {"Hipparcos Number", "HIP 86167"},
        {"Smithsonian Astrophysical Observation", "SAO 17569"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.12416182),
        dec: Angle.Degrees(+68.48894260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75796",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75796"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.27052277),
        dec: Angle.Degrees(+68.49030305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202012"},
        {"Hipparcos Number", "HIP 104451"},
        {"Geneva Identification System", "GEN# +1.00202012"},
        {"Smithsonian Astrophysical Observation", "SAO 19229"},
        {"Wilson Evans Batten Catalogue", "WEB 19014"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.38270949),
        dec: Angle.Degrees(+68.49100019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29940",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29940"},
        {"Smithsonian Astrophysical Observation", "SAO 13784"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.55181761),
        dec: Angle.Degrees(+68.49244135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27203"},
        {"Hipparcos Number", "HIP 20449"},
        {"Smithsonian Astrophysical Observation", "SAO 13116"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.71670429),
        dec: Angle.Degrees(+68.49366363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145369"},
        {"Hipparcos Number", "HIP 78837"},
        {"Smithsonian Astrophysical Observation", "SAO 16957"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.40319977),
        dec: Angle.Degrees(+68.49686384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208410"},
        {"Hipparcos Number", "HIP 108027"},
        {"Smithsonian Astrophysical Observation", "SAO 19710"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.27241542),
        dec: Angle.Degrees(+68.49856471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159287"},
        {"Hipparcos Number", "HIP 85483"},
        {"Smithsonian Astrophysical Observation", "SAO 17496"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.05038515),
        dec: Angle.Degrees(+68.49932070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15665",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2468 AB"},
        {"Hipparcos Number", "HIP 15665"},
        {"Smithsonian Astrophysical Observation", "SAO 12715"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.44149257),
        dec: Angle.Degrees(+68.49999030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1426"},
        {"Hipparcos Number", "HIP 1510"},
        {"Smithsonian Astrophysical Observation", "SAO 11099"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.69999100),
        dec: Angle.Degrees(+68.50010060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26101"},
        {"Hipparcos Number", "HIP 19673"},
        {"Geneva Identification System", "GEN# +1.00026101"},
        {"Smithsonian Astrophysical Observation", "SAO 13061"},
        {"Wilson Evans Batten Catalogue", "WEB 3754"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.21614655),
        dec: Angle.Degrees(+68.50113286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87736",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87736"},
        {"Smithsonian Astrophysical Observation", "SAO 17693"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.82180181),
        dec: Angle.Degrees(+68.50233182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68589",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68589"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.846,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.61870495),
        dec: Angle.Degrees(+68.50285321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -176.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111319",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16058 AB"},
        {"Henry Draper", "HD 213989"},
        {"Hipparcos Number", "HIP 111319"},
        {"Smithsonian Astrophysical Observation", "SAO 20151"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.28111482),
        dec: Angle.Degrees(+68.50498290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93095",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93095"},
        {"Fundamental Katalog 5th Edition", "FK5 5672"},
        {"Smithsonian Astrophysical Observation", "SAO 18093"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.47938866),
        dec: Angle.Degrees(+68.50570127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23662"},
        {"Hipparcos Number", "HIP 18067"},
        {"Geneva Identification System", "GEN# +1.00023662"},
        {"Renson", "Renson 6080"},
        {"Smithsonian Astrophysical Observation", "SAO 12929"},
    },
    visualMagnitude: 6.31,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.92395956),
        dec: Angle.Degrees(+68.50753643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61896",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61896"},
    },
    visualMagnitude: 11.51,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.26082145),
        dec: Angle.Degrees(+68.50855433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109154"},
        {"Hipparcos Number", "HIP 61157"},
        {"Geneva Identification System", "GEN# +1.00109154"},
        {"Smithsonian Astrophysical Observation", "SAO 15822"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.97795001),
        dec: Angle.Degrees(+68.51481786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71223"},
        {"Hipparcos Number", "HIP 41741"},
        {"Smithsonian Astrophysical Observation", "SAO 14572"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.68432042),
        dec: Angle.Degrees(+68.51500115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61900",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61900"},
        {"Smithsonian Astrophysical Observation", "SAO 15868"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.26866406),
        dec: Angle.Degrees(+68.51607625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210477"},
        {"Hipparcos Number", "HIP 109258"},
        {"Geneva Identification System", "GEN# +1.00210477"},
        {"Smithsonian Astrophysical Observation", "SAO 19888"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.03097895),
        dec: Angle.Degrees(+68.51903822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107808"},
        {"Hipparcos Number", "HIP 60377"},
        {"Geneva Identification System", "GEN# +1.00107808"},
        {"Smithsonian Astrophysical Observation", "SAO 15787"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.70387828),
        dec: Angle.Degrees(+68.52476291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19634"},
        {"Hipparcos Number", "HIP 15036"},
        {"Geneva Identification System", "GEN# +1.00019634"},
        {"Smithsonian Astrophysical Observation", "SAO 12661"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.45634278),
        dec: Angle.Degrees(+68.52573353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78630",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78630"},
        {"Cincinnati Publication", "Ci 18 2162"},
        {"Geneva Identification System", "GEN# +0.06800861"},
        {"Smithsonian Astrophysical Observation", "SAO 16943"},
        {"Wilson Evans Batten Catalogue", "WEB 13293"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.78505735),
        dec: Angle.Degrees(+68.52623154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -230.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 126.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83270"},
        {"Henry Draper 2", "HD 83271"},
        {"Hipparcos Number", "HIP 47461"},
        {"Geneva Identification System", "GEN# +1.00083270"},
        {"Renson", "Renson 23760"},
        {"Smithsonian Astrophysical Observation", "SAO 14955"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.13002495),
        dec: Angle.Degrees(+68.53681812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11771"},
        {"Hipparcos Number", "HIP 9184"},
        {"Smithsonian Astrophysical Observation", "SAO 12056"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.56173889),
        dec: Angle.Degrees(+68.53831565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35579",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5962 B"},
        {"Hipparcos Number", "HIP 35579"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.13614001),
        dec: Angle.Degrees(+68.53955322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35574",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5962 A"},
        {"Henry Draper", "HD 55943"},
        {"Hipparcos Number", "HIP 35574"},
        {"Geneva Identification System", "GEN# +1.00055943"},
        {"Smithsonian Astrophysical Observation", "SAO 14151"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.12751612),
        dec: Angle.Degrees(+68.54003432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14269"},
        {"Hipparcos Number", "HIP 11002"},
        {"Smithsonian Astrophysical Observation", "SAO 12236"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.44260688),
        dec: Angle.Degrees(+68.54202157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28816"},
        {"Hipparcos Number", "HIP 21568"},
        {"Smithsonian Astrophysical Observation", "SAO 13204"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.45081896),
        dec: Angle.Degrees(+68.54668243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5208",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5208"},
        {"Smithsonian Astrophysical Observation", "SAO 11572"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.65669083),
        dec: Angle.Degrees(+68.54860731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198385"},
        {"Hipparcos Number", "HIP 102466"},
        {"Smithsonian Astrophysical Observation", "SAO 19029"},
        {"Wilson Evans Batten Catalogue", "WEB 18555"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.45608346),
        dec: Angle.Degrees(+68.55190214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 137.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147662"},
        {"Hipparcos Number", "HIP 79867"},
        {"Smithsonian Astrophysical Observation", "SAO 17036"},
        {"Wilson Evans Batten Catalogue", "WEB 13521"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.54086863),
        dec: Angle.Degrees(+68.55443584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88188",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88188"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.829,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.15045549),
        dec: Angle.Degrees(+68.55650700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 92.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197052"},
        {"Hipparcos Number", "HIP 101701"},
        {"Smithsonian Astrophysical Observation", "SAO 18952"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.20694636),
        dec: Angle.Degrees(+68.55807440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105662"},
        {"Hipparcos Number", "HIP 59287"},
        {"Smithsonian Astrophysical Observation", "SAO 15726"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.43004989),
        dec: Angle.Degrees(+68.56315646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38008",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38008"},
        {"Smithsonian Astrophysical Observation", "SAO 14325"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.84882542),
        dec: Angle.Degrees(+68.56408931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8136"},
        {"Hipparcos Number", "HIP 6436"},
        {"Geneva Identification System", "GEN# +1.00008136"},
        {"Smithsonian Astrophysical Observation", "SAO 11724"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.66619142),
        dec: Angle.Degrees(+68.56543964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203318"},
        {"Hipparcos Number", "HIP 105137"},
        {"Geneva Identification System", "GEN# +1.00203318"},
        {"Smithsonian Astrophysical Observation", "SAO 19297"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.47859465),
        dec: Angle.Degrees(+68.56561097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31277"},
        {"Hipparcos Number", "HIP 23220"},
        {"Smithsonian Astrophysical Observation", "SAO 13329"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.95179245),
        dec: Angle.Degrees(+68.56693522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112670",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16291 AB"},
        {"Henry Draper", "HD 216172"},
        {"Hipparcos Number", "HIP 112670"},
        {"Wilson Evans Batten Catalogue", "WEB 20081"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.25283476),
        dec: Angle.Degrees(+68.57006392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94523"},
        {"Hipparcos Number", "HIP 53482"},
        {"Smithsonian Astrophysical Observation", "SAO 15340"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.11402405),
        dec: Angle.Degrees(+68.58170441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94185",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94185"},
    },
    visualMagnitude: 10.47,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.61645180),
        dec: Angle.Degrees(+68.58266976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165587"},
        {"Hipparcos Number", "HIP 88226"},
        {"Smithsonian Astrophysical Observation", "SAO 17728"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.25203284),
        dec: Angle.Degrees(+68.58543941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53351"},
        {"Hipparcos Number", "HIP 34620"},
        {"Smithsonian Astrophysical Observation", "SAO 14092"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.54996464),
        dec: Angle.Degrees(+68.58672726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10721"},
        {"Hipparcos Number", "HIP 8323"},
        {"Smithsonian Astrophysical Observation", "SAO 11976"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.83034632),
        dec: Angle.Degrees(+68.58985110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192274"},
        {"Hipparcos Number", "HIP 99291"},
        {"Smithsonian Astrophysical Observation", "SAO 18741"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.33576030),
        dec: Angle.Degrees(+68.59962839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188521"},
        {"Hipparcos Number", "HIP 97638"},
        {"Geneva Identification System", "GEN# +1.00188521"},
        {"Smithsonian Astrophysical Observation", "SAO 18562"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.66613523),
        dec: Angle.Degrees(+68.60104722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92454"},
        {"Hipparcos Number", "HIP 52386"},
        {"Geneva Identification System", "GEN# +1.00092454"},
        {"Smithsonian Astrophysical Observation", "SAO 15264"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.61973113),
        dec: Angle.Degrees(+68.60387066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12492"},
        {"Hipparcos Number", "HIP 9745"},
        {"Smithsonian Astrophysical Observation", "SAO 12112"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.34302294),
        dec: Angle.Degrees(+68.60481950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172066"},
        {"Hipparcos Number", "HIP 90902"},
        {"Geneva Identification System", "GEN# +1.00172066"},
        {"Smithsonian Astrophysical Observation", "SAO 17924"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.12598422),
        dec: Angle.Degrees(+68.61403433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201684"},
        {"Hipparcos Number", "HIP 104254"},
        {"Geneva Identification System", "GEN# +1.00201684"},
        {"Smithsonian Astrophysical Observation", "SAO 19211"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.81850070),
        dec: Angle.Degrees(+68.61530019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112609"},
        {"Hipparcos Number", "HIP 63184"},
        {"Geneva Identification System", "GEN# +1.00112609"},
        {"Smithsonian Astrophysical Observation", "SAO 15947"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.16808654),
        dec: Angle.Degrees(+68.61616952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216944"},
        {"Hipparcos Number", "HIP 113216"},
        {"Geneva Identification System", "GEN# +1.00216944"},
        {"Smithsonian Astrophysical Observation", "SAO 20325"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.91714873),
        dec: Angle.Degrees(+68.61725070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36635",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36635"},
        {"Geneva Identification System", "GEN# +9.80250049"},
        {"Wilson Evans Batten Catalogue", "WEB 7285"},
    },
    visualMagnitude: 10.84,
    bvColour: 1.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.00956625),
        dec: Angle.Degrees(+68.62127385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -174.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56757"},
        {"Hipparcos Number", "HIP 35883"},
        {"Smithsonian Astrophysical Observation", "SAO 14176"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.97056364),
        dec: Angle.Degrees(+68.63146548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218843"},
        {"Hipparcos Number", "HIP 114381"},
        {"Smithsonian Astrophysical Observation", "SAO 20467"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.49080361),
        dec: Angle.Degrees(+68.63182304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29892"},
        {"Hipparcos Number", "HIP 22285"},
        {"Smithsonian Astrophysical Observation", "SAO 13262"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.98784490),
        dec: Angle.Degrees(+68.63597112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 527",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 527"},
        {"Smithsonian Astrophysical Observation", "SAO 10976"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.58655035),
        dec: Angle.Degrees(+68.63612309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168340"},
        {"Hipparcos Number", "HIP 89327"},
        {"Smithsonian Astrophysical Observation", "SAO 17830"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.39850857),
        dec: Angle.Degrees(+68.63899733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45342",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45342"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.59938200),
        dec: Angle.Degrees(+68.64562284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46896"},
        {"Hipparcos Number", "HIP 32032"},
        {"Smithsonian Astrophysical Observation", "SAO 13920"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.36960995),
        dec: Angle.Degrees(+68.64732704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89523",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89523"},
        {"Cincinnati Publication", "Ci 20 1083"},
        {"Geneva Identification System", "GEN# +0.06800986"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.01565012),
        dec: Angle.Degrees(+68.64751027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 441.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105849",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105849"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.57949564),
        dec: Angle.Degrees(+68.64954386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 124.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 124.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186426"},
        {"Hipparcos Number", "HIP 96662"},
        {"Geneva Identification System", "GEN# +1.00186426"},
        {"Smithsonian Astrophysical Observation", "SAO 18457"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.865,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.79315280),
        dec: Angle.Degrees(+68.65250336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12722",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12722"},
        {"Smithsonian Astrophysical Observation", "SAO 12406"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.87963754),
        dec: Angle.Degrees(+68.65274076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14980"},
        {"Hipparcos Number", "HIP 11498"},
        {"Smithsonian Astrophysical Observation", "SAO 12291"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.07185012),
        dec: Angle.Degrees(+68.65631480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87703"},
        {"Hipparcos Number", "HIP 49765"},
        {"Smithsonian Astrophysical Observation", "SAO 15100"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.37959839),
        dec: Angle.Degrees(+68.66408596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87206"},
        {"Hipparcos Number", "HIP 49497"},
        {"Smithsonian Astrophysical Observation", "SAO 15075"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.58555793),
        dec: Angle.Degrees(+68.66416725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223434"},
        {"Hipparcos Number", "HIP 117469"},
        {"Smithsonian Astrophysical Observation", "SAO 20873"},
    },
    visualMagnitude: 8.29,
    bvColour: 2.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.28801776),
        dec: Angle.Degrees(+68.66851582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222629"},
        {"Hipparcos Number", "HIP 116908"},
        {"Celescope Catalog", "CEL 5650"},
        {"Geneva Identification System", "GEN# +1.00222629"},
        {"Smithsonian Astrophysical Observation", "SAO 20784"},
    },
    visualMagnitude: 7.88,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.47322992),
        dec: Angle.Degrees(+68.67188560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23189"},
        {"Hipparcos Number", "HIP 17749"},
        {"Cincinnati Publication", "Ci 18 499"},
        {"Geneva Identification System", "GEN# +1.00023189A"},
        {"Geneva Identification System 2", "GEN# +1.10023189"},
        {"Smithsonian Astrophysical Observation", "SAO 12903"},
        {"Wilson Evans Batten Catalogue", "WEB 3395"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.00347701),
        dec: Angle.Degrees(+68.67228707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 126.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 239.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17750",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "GJ 153 BC"},
        {"Hipparcos Number", "HIP 17750"},
        {"Geneva Identification System", "GEN# +1.20023189"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.00558859),
        dec: Angle.Degrees(+68.67688918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 464.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42992"},
        {"Hipparcos Number", "HIP 30065"},
        {"Geneva Identification System", "GEN# +1.00042992"},
        {"Smithsonian Astrophysical Observation", "SAO 13799"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.91247402),
        dec: Angle.Degrees(+68.67690293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122909"},
        {"Hipparcos Number", "HIP 68537"},
        {"Geneva Identification System", "GEN# +1.00122909"},
        {"Smithsonian Astrophysical Observation", "SAO 16254"},
        {"Wilson Evans Batten Catalogue", "WEB 12004"},
    },
    visualMagnitude: 6.34,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.46126995),
        dec: Angle.Degrees(+68.67868547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154320"},
        {"Hipparcos Number", "HIP 83128"},
        {"Geneva Identification System", "GEN# +1.00154320"},
        {"Smithsonian Astrophysical Observation", "SAO 17308"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.82387338),
        dec: Angle.Degrees(+68.67891215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141506"},
        {"Hipparcos Number", "HIP 77115"},
        {"Smithsonian Astrophysical Observation", "SAO 16839"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.19067855),
        dec: Angle.Degrees(+68.67984598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25274"},
        {"Hipparcos Number", "HIP 19129"},
        {"Fundamental Katalog 5th Edition", "FK5 2291"},
        {"Geneva Identification System", "GEN# +1.00025274"},
        {"Smithsonian Astrophysical Observation", "SAO 13006"},
        {"Wilson Evans Batten Catalogue", "WEB 3674"},
    },
    visualMagnitude: 5.88,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.51320978),
        dec: Angle.Degrees(+68.67996526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9342"},
        {"Hipparcos Number", "HIP 7318"},
        {"Smithsonian Astrophysical Observation", "SAO 11832"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.55520722),
        dec: Angle.Degrees(+68.68247030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149429"},
        {"Hipparcos Number", "HIP 80774"},
        {"Smithsonian Astrophysical Observation", "SAO 17117"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.38752737),
        dec: Angle.Degrees(+68.68507000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11529"},
        {"Hipparcos Number", "HIP 9009"},
        {"Fundamental Katalog 5th Edition", "FK5 2129"},
        {"Geneva Identification System", "GEN# +1.00011529"},
        {"Renson", "Renson 2950"},
        {"Smithsonian Astrophysical Observation", "SAO 12038"},
        {"Wilson Evans Batten Catalogue", "WEB 1893"},
    },
    visualMagnitude: 4.97,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.00001575),
        dec: Angle.Degrees(+68.68526545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25233",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25233"},
    },
    visualMagnitude: 10.99,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.93942600),
        dec: Angle.Degrees(+68.68796335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -315.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108345"},
        {"Hipparcos Number", "HIP 60694"},
        {"Wilson Evans Batten Catalogue", "WEB 10795"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.58719219),
        dec: Angle.Degrees(+68.68803997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163214"},
        {"Hipparcos Number", "HIP 87237"},
        {"Renson", "Renson 46150"},
        {"Smithsonian Astrophysical Observation", "SAO 17651"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.36706386),
        dec: Angle.Degrees(+68.68885400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38016"},
        {"Hipparcos Number", "HIP 27432"},
        {"Geneva Identification System", "GEN# +1.00038016"},
        {"Smithsonian Astrophysical Observation", "SAO 13610"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.13809321),
        dec: Angle.Degrees(+68.68935453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59018",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 10.87,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)06, 01.4800),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)41, 30.400)
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
    primaryId: "HIP 59017",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8419 AB"},
        {"Henry Draper", "HD 105122"},
        {"Hipparcos Number", "HIP 59017"},
        {"Geneva Identification System", "GEN# +1.00105122J"},
        {"Smithsonian Astrophysical Observation", "SAO 15713"},
        {"Wilson Evans Batten Catalogue", "WEB 10511"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.50571919),
        dec: Angle.Degrees(+68.69875832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95604"},
        {"Hipparcos Number", "HIP 54051"},
        {"Smithsonian Astrophysical Observation", "SAO 15380"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.90461474),
        dec: Angle.Degrees(+68.70340017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47838",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47838"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.26342132),
        dec: Angle.Degrees(+68.70404478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3282"},
        {"Hipparcos Number", "HIP 2897"},
        {"Geneva Identification System", "GEN# +1.00003282"},
        {"Smithsonian Astrophysical Observation", "SAO 11294"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.18268835),
        dec: Angle.Degrees(+68.70417482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112844"},
        {"Hipparcos Number", "HIP 63288"},
        {"Geneva Identification System", "GEN# +1.00112844"},
        {"Smithsonian Astrophysical Observation", "SAO 15954"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.54579868),
        dec: Angle.Degrees(+68.70575749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91329"},
        {"Hipparcos Number", "HIP 51782"},
        {"Smithsonian Astrophysical Observation", "SAO 15224"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.70889231),
        dec: Angle.Degrees(+68.70728149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65168",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65168"},
        {"Smithsonian Astrophysical Observation", "SAO 16057"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.32851375),
        dec: Angle.Degrees(+68.70793118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41073"},
        {"Hipparcos Number", "HIP 29130"},
        {"Smithsonian Astrophysical Observation", "SAO 13721"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.15484074),
        dec: Angle.Degrees(+68.71214950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177856"},
        {"Hipparcos Number", "HIP 93355"},
        {"Smithsonian Astrophysical Observation", "SAO 18119"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.23239036),
        dec: Angle.Degrees(+68.71622174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49121",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7603 A"},
        {"Henry Draper", "HD 86458"},
        {"Hipparcos Number", "HIP 49121"},
        {"Renson", "Renson 24730"},
        {"Smithsonian Astrophysical Observation", "SAO 15046"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.38386060),
        dec: Angle.Degrees(+68.71812669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143105"},
        {"Hipparcos Number", "HIP 77838"},
        {"Geneva Identification System", "GEN# +1.00143105"},
        {"Smithsonian Astrophysical Observation", "SAO 16890"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.40231193),
        dec: Angle.Degrees(+68.72019204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116700",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116700"},
        {"Smithsonian Astrophysical Observation", "SAO 20750"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.73961171),
        dec: Angle.Degrees(+68.72605471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174619"},
        {"Hipparcos Number", "HIP 92057"},
        {"Smithsonian Astrophysical Observation", "SAO 18014"},
    },
    visualMagnitude: 7.82,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.45016270),
        dec: Angle.Degrees(+68.72772386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26452",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26452"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.41322115),
        dec: Angle.Degrees(+68.73552905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 245.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115283",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115283"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.23207689),
        dec: Angle.Degrees(+68.73880208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169027"},
        {"Hipparcos Number", "HIP 89594"},
        {"Geneva Identification System", "GEN# +1.00169027"},
        {"Renson", "Renson 47420"},
        {"Smithsonian Astrophysical Observation", "SAO 17847"},
        {"Wilson Evans Batten Catalogue", "WEB 15260"},
    },
    visualMagnitude: 6.79,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.24488766),
        dec: Angle.Degrees(+68.74169017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55330"},
        {"Hipparcos Number", "HIP 35335"},
        {"Smithsonian Astrophysical Observation", "SAO 14135"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.48853348),
        dec: Angle.Degrees(+68.74225974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184737"},
        {"Hipparcos Number", "HIP 95945"},
        {"Smithsonian Astrophysical Observation", "SAO 18380"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.67527763),
        dec: Angle.Degrees(+68.74668961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89343"},
        {"Hipparcos Number", "HIP 50685"},
        {"Fundamental Katalog 5th Edition", "FK5 2828"},
        {"Geneva Identification System", "GEN# +1.00089343"},
        {"Smithsonian Astrophysical Observation", "SAO 15147"},
        {"Wilson Evans Batten Catalogue", "WEB 9289"},
    },
    visualMagnitude: 5.88,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.26428436),
        dec: Angle.Degrees(+68.74773415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137554"},
        {"Hipparcos Number", "HIP 75218"},
        {"Smithsonian Astrophysical Observation", "SAO 16714"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.55747367),
        dec: Angle.Degrees(+68.74802753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 92.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159712"},
        {"Hipparcos Number", "HIP 85678"},
        {"Smithsonian Astrophysical Observation", "SAO 17512"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.63149908),
        dec: Angle.Degrees(+68.74822634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13465",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13465"},
        {"Geneva Identification System", "GEN# +0.06800201"},
        {"Smithsonian Astrophysical Observation", "SAO 12484"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.35640377),
        dec: Angle.Degrees(+68.75081321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125672"},
        {"Hipparcos Number", "HIP 69855"},
        {"Geneva Identification System", "GEN# +1.00125672"},
        {"Smithsonian Astrophysical Observation", "SAO 16329"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.44070744),
        dec: Angle.Degrees(+68.75195549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50476"},
        {"Hipparcos Number", "HIP 33624"},
        {"Geneva Identification System", "GEN# +1.00050476"},
        {"Smithsonian Astrophysical Observation", "SAO 14025"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.78245455),
        dec: Angle.Degrees(+68.75311996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168653"},
        {"Hipparcos Number", "HIP 89448"},
        {"Fundamental Katalog 5th Edition", "FK5 3455"},
        {"Geneva Identification System", "GEN# +1.00168653"},
        {"Smithsonian Astrophysical Observation", "SAO 17837"},
        {"Wilson Evans Batten Catalogue", "WEB 15220"},
    },
    visualMagnitude: 5.96,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.82103715),
        dec: Angle.Degrees(+68.75596485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160922"},
        {"Hipparcos Number", "HIP 86201"},
        {"Fundamental Katalog 5th Edition", "FK5 664"},
        {"Geneva Identification System", "GEN# +1.00160922"},
        {"Smithsonian Astrophysical Observation", "SAO 17576"},
        {"Wilson Evans Batten Catalogue", "WEB 14539"},
    },
    visualMagnitude: 4.77,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.23787472),
        dec: Angle.Degrees(+68.75718933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 321.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2996",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2996"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.52149021),
        dec: Angle.Degrees(+68.75940290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 148.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -175.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58976",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8413 E"},
        {"Henry Draper", "HD 105029"},
        {"Hipparcos Number", "HIP 58976"},
        {"Geneva Identification System", "GEN# +1.00105029"},
        {"Smithsonian Astrophysical Observation", "SAO 15708"},
        {"Wilson Evans Batten Catalogue", "WEB 10502"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.38717304),
        dec: Angle.Degrees(+68.75945467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41807",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41807"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.85283242),
        dec: Angle.Degrees(+68.76122491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14402"},
        {"Hipparcos Number", "HIP 11097"},
        {"Geneva Identification System", "GEN# +1.00014402"},
        {"Smithsonian Astrophysical Observation", "SAO 12250"},
        {"Wilson Evans Batten Catalogue", "WEB 2331"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.71986407),
        dec: Angle.Degrees(+68.76193197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195527"},
        {"Hipparcos Number", "HIP 100884"},
        {"Geneva Identification System", "GEN# +1.00195527"},
        {"Smithsonian Astrophysical Observation", "SAO 18877"},
        {"Wilson Evans Batten Catalogue", "WEB 18227"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.83369157),
        dec: Angle.Degrees(+68.76736334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11633",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11633"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.52816042),
        dec: Angle.Degrees(+68.76744038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149212"},
        {"Hipparcos Number", "HIP 80650"},
        {"Fundamental Katalog 5th Edition", "FK5 619"},
        {"Geneva Identification System", "GEN# +1.00149212"},
        {"Renson", "Renson 42190"},
        {"Smithsonian Astrophysical Observation", "SAO 17107"},
        {"Wilson Evans Batten Catalogue", "WEB 13641"},
    },
    visualMagnitude: 4.94,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.99605488),
        dec: Angle.Degrees(+68.76805491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97286"},
        {"Hipparcos Number", "HIP 54797"},
        {"Smithsonian Astrophysical Observation", "SAO 15437"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.27677005),
        dec: Angle.Degrees(+68.76805632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81438"},
        {"Hipparcos Number", "HIP 46513"},
        {"Smithsonian Astrophysical Observation", "SAO 14892"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.30792977),
        dec: Angle.Degrees(+68.76808604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15846",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15846"},
        {"Geneva Identification System", "GEN# +8.01680021"},
    },
    visualMagnitude: 10.81,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.02784963),
        dec: Angle.Degrees(+68.77153710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132274"},
        {"Hipparcos Number", "HIP 72922"},
        {"Smithsonian Astrophysical Observation", "SAO 16547"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.54727988),
        dec: Angle.Degrees(+68.77355027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5357"},
        {"Hipparcos Number", "HIP 4446"},
        {"Geneva Identification System", "GEN# +1.00005357"},
        {"Renson", "Renson 1420"},
        {"Smithsonian Astrophysical Observation", "SAO 11481"},
        {"Wilson Evans Batten Catalogue", "WEB 800"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.22912074),
        dec: Angle.Degrees(+68.77574214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92763"},
        {"Hipparcos Number", "HIP 52546"},
        {"Geneva Identification System", "GEN# +1.00092763"},
        {"Smithsonian Astrophysical Observation", "SAO 15273"},
        {"Wilson Evans Batten Catalogue", "WEB 9571"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.16057355),
        dec: Angle.Degrees(+68.77580521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98709"},
        {"Hipparcos Number", "HIP 55540"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.63775752),
        dec: Angle.Degrees(+68.77762206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6829"},
        {"Hipparcos Number", "HIP 5518"},
        {"Fundamental Katalog 5th Edition", "FK5 2074"},
        {"Geneva Identification System", "GEN# +1.00006829"},
        {"Smithsonian Astrophysical Observation", "SAO 11612"},
        {"Wilson Evans Batten Catalogue", "WEB 1219"},
    },
    visualMagnitude: 5.32,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.66360631),
        dec: Angle.Degrees(+68.77868759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1505",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1505"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.68702561),
        dec: Angle.Degrees(+68.78093291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112956"},
        {"Hipparcos Number", "HIP 63346"},
        {"Cincinnati Publication", "Ci 20 751"},
        {"Cincinnati Publication 2", "Ci 18 1660"},
        {"Geneva Identification System", "GEN# +1.00112956"},
        {"Smithsonian Astrophysical Observation", "SAO 15958"},
        {"Wilson Evans Batten Catalogue", "WEB 11219"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.70728324),
        dec: Angle.Degrees(+68.78464293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -294.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 244.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49230",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7611 AB"},
        {"Henry Draper", "HD 86677"},
        {"Hipparcos Number", "HIP 49230"},
        {"Smithsonian Astrophysical Observation", "SAO 15054"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.73535567),
        dec: Angle.Degrees(+68.78592263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84002",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84002"},
        {"Smithsonian Astrophysical Observation", "SAO 17377"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.57091013),
        dec: Angle.Degrees(+68.79112343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16968",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16968"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.56651826),
        dec: Angle.Degrees(+68.79364775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58979",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8413 A"},
        {"Henry Draper", "HD 105028"},
        {"Hipparcos Number", "HIP 58979"},
        {"Geneva Identification System", "GEN# +1.00105028"},
        {"Smithsonian Astrophysical Observation", "SAO 15709"},
        {"Wilson Evans Batten Catalogue", "WEB 10501"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.38968326),
        dec: Angle.Degrees(+68.79437026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107028"},
        {"Hipparcos Number", "HIP 59975"},
        {"Geneva Identification System", "GEN# +1.00107028"},
        {"Smithsonian Astrophysical Observation", "SAO 15761"},
        {"Wilson Evans Batten Catalogue", "WEB 10658"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.50183144),
        dec: Angle.Degrees(+68.79697746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108076",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108076"},
        {"Smithsonian Astrophysical Observation", "SAO 19724"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.45930892),
        dec: Angle.Degrees(+68.79851333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36972"},
        {"Hipparcos Number", "HIP 26753"},
        {"Geneva Identification System", "GEN# +1.00036972"},
        {"Smithsonian Astrophysical Observation", "SAO 13563"},
        {"Wilson Evans Batten Catalogue", "WEB 5276"},
    },
    visualMagnitude: 8.93,
    bvColour: 2.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.26039351),
        dec: Angle.Degrees(+68.79861273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110313"},
        {"Hipparcos Number", "HIP 61811"},
        {"Cincinnati Publication", "Ci 18 1604"},
        {"Cincinnati Publication 2", "Ci 20 730"},
        {"Geneva Identification System", "GEN# +1.00110313"},
        {"Smithsonian Astrophysical Observation", "SAO 15861"},
        {"Wilson Evans Batten Catalogue", "WEB 10997"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.01737051),
        dec: Angle.Degrees(+68.80236893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -438.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40812"},
        {"Hipparcos Number", "HIP 28996"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.77334746),
        dec: Angle.Degrees(+68.80242327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54587"},
        {"Hipparcos Number", "HIP 35045"},
        {"Smithsonian Astrophysical Observation", "SAO 14121"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.71687338),
        dec: Angle.Degrees(+68.80423669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50399",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50399"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.37411736),
        dec: Angle.Degrees(+68.80607750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22829"},
        {"Hipparcos Number", "HIP 17495"},
        {"Smithsonian Astrophysical Observation", "SAO 12885"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.21100438),
        dec: Angle.Degrees(+68.82069881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140412"},
        {"Hipparcos Number", "HIP 76604"},
        {"Geneva Identification System", "GEN# +1.00140412"},
        {"Smithsonian Astrophysical Observation", "SAO 16801"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.67251244),
        dec: Angle.Degrees(+68.82179992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 85.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218865"},
        {"Hipparcos Number", "HIP 114403"},
        {"Smithsonian Astrophysical Observation", "SAO 20469"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.53560302),
        dec: Angle.Degrees(+68.82547454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102925"},
        {"Hipparcos Number", "HIP 57813"},
        {"Renson", "Renson 29725"},
        {"Smithsonian Astrophysical Observation", "SAO 15643"},
        {"Wilson Evans Batten Catalogue", "WEB 10374"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.83409588),
        dec: Angle.Degrees(+68.83395451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17929"},
        {"Hipparcos Number", "HIP 13728"},
        {"Geneva Identification System", "GEN# +1.00017929"},
        {"Smithsonian Astrophysical Observation", "SAO 12520"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.20355865),
        dec: Angle.Degrees(+68.83597771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24806"},
        {"Hipparcos Number", "HIP 18800"},
        {"Smithsonian Astrophysical Observation", "SAO 12986"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.42048422),
        dec: Angle.Degrees(+68.84573332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1559"},
        {"Hipparcos Number", "HIP 1629"},
        {"Geneva Identification System", "GEN# +1.00001559"},
        {"Smithsonian Astrophysical Observation", "SAO 11118"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.09270914),
        dec: Angle.Degrees(+68.84700611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101193"},
        {"Hipparcos Number", "HIP 56849"},
        {"Geneva Identification System", "GEN# +1.00101193"},
        {"Smithsonian Astrophysical Observation", "SAO 15581"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.83255566),
        dec: Angle.Degrees(+68.85052408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210953"},
        {"Hipparcos Number", "HIP 109534"},
        {"Smithsonian Astrophysical Observation", "SAO 19929"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.81691222),
        dec: Angle.Degrees(+68.85633754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51197",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51197"},
        {"Smithsonian Astrophysical Observation", "SAO 15183"},
        {"Wilson Evans Batten Catalogue", "WEB 9358"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.86067479),
        dec: Angle.Degrees(+68.85683702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 158.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80532"},
        {"Hipparcos Number", "HIP 46103"},
        {"Smithsonian Astrophysical Observation", "SAO 14865"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.02712959),
        dec: Angle.Degrees(+68.86133528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124369"},
        {"Hipparcos Number", "HIP 69207"},
        {"Smithsonian Astrophysical Observation", "SAO 16297"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.53679627),
        dec: Angle.Degrees(+68.86339256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91309"},
        {"Hipparcos Number", "HIP 51774"},
        {"Geneva Identification System", "GEN# +1.00091309"},
        {"Smithsonian Astrophysical Observation", "SAO 15223"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.69450283),
        dec: Angle.Degrees(+68.86350128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4116",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 710 AB"},
        {"Henry Draper", "HD 4947"},
        {"Hipparcos Number", "HIP 4116"},
        {"Smithsonian Astrophysical Observation", "SAO 11440"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.18843085),
        dec: Angle.Degrees(+68.86580974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76811"},
        {"Hipparcos Number", "HIP 44396"},
        {"Geneva Identification System", "GEN# +1.00076811"},
        {"Smithsonian Astrophysical Observation", "SAO 14741"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.64969257),
        dec: Angle.Degrees(+68.86687456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198328"},
        {"Hipparcos Number", "HIP 102429"},
        {"Smithsonian Astrophysical Observation", "SAO 19026"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.33683202),
        dec: Angle.Degrees(+68.87242252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97669",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97669"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.73398998),
        dec: Angle.Degrees(+68.87320768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92306",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92306"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.19976437),
        dec: Angle.Degrees(+68.87619941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 163.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157664"},
        {"Hipparcos Number", "HIP 84714"},
        {"Geneva Identification System", "GEN# +1.00157664"},
        {"Smithsonian Astrophysical Observation", "SAO 17432"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.74334206),
        dec: Angle.Degrees(+68.87793112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194258"},
        {"Hipparcos Number", "HIP 100261"},
        {"Fundamental Katalog 5th Edition", "FK5 3631"},
        {"Geneva Identification System", "GEN# +1.00194258"},
        {"Smithsonian Astrophysical Observation", "SAO 18817"},
        {"Wilson Evans Batten Catalogue", "WEB 18079"},
    },
    visualMagnitude: 5.59,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.02493212),
        dec: Angle.Degrees(+68.88025320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79438",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79438"},
        {"Smithsonian Astrophysical Observation", "SAO 16997"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.18167711),
        dec: Angle.Degrees(+68.88172164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14"},
        {"Hipparcos Number", "HIP 440"},
        {"Smithsonian Astrophysical Observation", "SAO 10965"},
    },
    visualMagnitude: 7.08,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.33276937),
        dec: Angle.Degrees(+68.88440910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49340"},
        {"Hipparcos Number", "HIP 33104"},
        {"Fundamental Katalog 5th Edition", "FK5 259"},
        {"Geneva Identification System", "GEN# +1.00049340"},
        {"Smithsonian Astrophysical Observation", "SAO 13986"},
        {"Wilson Evans Batten Catalogue", "WEB 6662"},
    },
    visualMagnitude: 5.11,
    bvColour: -0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.42600463),
        dec: Angle.Degrees(+68.88829173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17463"},
        {"Hipparcos Number", "HIP 13367"},
        {"Fundamental Katalog 5th Edition", "FK5 2195"},
        {"Geneva Identification System", "GEN# +1.00017463"},
        {"Smithsonian Astrophysical Observation", "SAO 12472"},
        {"Wilson Evans Batten Catalogue", "WEB 2677"},
    },
    visualMagnitude: 5.94,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.99478506),
        dec: Angle.Degrees(+68.88851683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10364",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10364"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.39474980),
        dec: Angle.Degrees(+68.89511456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51804"},
        {"Hipparcos Number", "HIP 34114"},
        {"Geneva Identification System", "GEN# +1.00051804"},
        {"Smithsonian Astrophysical Observation", "SAO 14061"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.10460098),
        dec: Angle.Degrees(+68.89594712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173237"},
        {"Hipparcos Number", "HIP 91429"},
        {"Smithsonian Astrophysical Observation", "SAO 17967"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.68603983),
        dec: Angle.Degrees(+68.89926153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66034",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66034"},
    },
    visualMagnitude: 10.15,
    bvColour: -0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.07396799),
        dec: Angle.Degrees(+68.90044397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48639",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7566 AB"},
        {"Henry Draper", "HD 85458"},
        {"Hipparcos Number", "HIP 48639"},
        {"Smithsonian Astrophysical Observation", "SAO 15020"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.76675082),
        dec: Angle.Degrees(+68.90168801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89989",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11316 AB"},
        {"Henry Draper", "HD 170001"},
        {"Hipparcos Number", "HIP 89989"},
        {"Smithsonian Astrophysical Observation", "SAO 17864"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.40972844),
        dec: Angle.Degrees(+68.91482140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102128"},
        {"Hipparcos Number", "HIP 57372"},
        {"Smithsonian Astrophysical Observation", "SAO 15625"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.43362484),
        dec: Angle.Degrees(+68.91874799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108720"},
        {"Hipparcos Number", "HIP 60889"},
        {"Geneva Identification System", "GEN# +1.00108720"},
        {"Smithsonian Astrophysical Observation", "SAO 15809"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.18331973),
        dec: Angle.Degrees(+68.92019346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40347",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40347"},
    },
    visualMagnitude: 11.09,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.56794140),
        dec: Angle.Degrees(+68.92282323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -305.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69892"},
        {"Hipparcos Number", "HIP 41170"},
        {"Geneva Identification System", "GEN# +1.00069892"},
        {"Smithsonian Astrophysical Observation", "SAO 14528"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.00047438),
        dec: Angle.Degrees(+68.92450716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5880"},
        {"Hipparcos Number", "HIP 4810"},
        {"Smithsonian Astrophysical Observation", "SAO 11530"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.43423284),
        dec: Angle.Degrees(+68.92454756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2211",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2211"},
        {"Smithsonian Astrophysical Observation", "SAO 11212"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.98647042),
        dec: Angle.Degrees(+68.92581886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89481"},
        {"Hipparcos Number", "HIP 50778"},
        {"Smithsonian Astrophysical Observation", "SAO 15152"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.53565816),
        dec: Angle.Degrees(+68.92601131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80762",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10098 AB"},
        {"Henry Draper", "HD 149428"},
        {"Hipparcos Number", "HIP 80762"},
        {"Smithsonian Astrophysical Observation", "SAO 17115"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.34805980),
        dec: Angle.Degrees(+68.93111448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117724",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117724"},
        {"Wilson Evans Batten Catalogue", "WEB 20719"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.13718468),
        dec: Angle.Degrees(+68.93380879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7215",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7215"},
        {"Smithsonian Astrophysical Observation", "SAO 11812"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.24058009),
        dec: Angle.Degrees(+68.93439122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104739"},
        {"Hipparcos Number", "HIP 58808"},
        {"Smithsonian Astrophysical Observation", "SAO 15697"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.93428922),
        dec: Angle.Degrees(+68.93497801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78927",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78927"},
        {"Smithsonian Astrophysical Observation", "SAO 16965"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.68586019),
        dec: Angle.Degrees(+68.93948531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48635",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7565 A"},
        {"Hipparcos Number", "HIP 48635"},
        {"Smithsonian Astrophysical Observation", "SAO 15018"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.76159700),
        dec: Angle.Degrees(+68.93959503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91497"},
        {"Hipparcos Number", "HIP 51890"},
        {"Smithsonian Astrophysical Observation", "SAO 15233"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.02732056),
        dec: Angle.Degrees(+68.94004942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100253"},
        {"Hipparcos Number", "HIP 56349"},
        {"Geneva Identification System", "GEN# +1.00100253"},
        {"Smithsonian Astrophysical Observation", "SAO 15547"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.26469309),
        dec: Angle.Degrees(+68.94126376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136174"},
        {"Hipparcos Number", "HIP 74625"},
        {"Geneva Identification System", "GEN# +1.00136174"},
        {"Smithsonian Astrophysical Observation", "SAO 16662"},
        {"Wilson Evans Batten Catalogue", "WEB 12736"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.71513471),
        dec: Angle.Degrees(+68.94572276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9407"},
        {"Hipparcos Number", "HIP 7339"},
        {"Cincinnati Publication", "Ci 18 204"},
        {"Cincinnati Publication 2", "Ci 20 108"},
        {"Geneva Identification System", "GEN# +1.00009407"},
        {"Smithsonian Astrophysical Observation", "SAO 11834"},
        {"Wilson Evans Batten Catalogue", "WEB 1578"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.64116285),
        dec: Angle.Degrees(+68.94785738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -379.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 115.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101500"},
        {"Hipparcos Number", "HIP 57015"},
        {"Geneva Identification System", "GEN# +1.00101500"},
        {"Smithsonian Astrophysical Observation", "SAO 15602"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.34184322),
        dec: Angle.Degrees(+68.95150312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72790"},
        {"Hipparcos Number", "HIP 42437"},
        {"Smithsonian Astrophysical Observation", "SAO 14608"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.79800773),
        dec: Angle.Degrees(+68.95320347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220781"},
        {"Hipparcos Number", "HIP 115645"},
        {"Smithsonian Astrophysical Observation", "SAO 20622"},
        {"Wilson Evans Batten Catalogue", "WEB 20467"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.41175023),
        dec: Angle.Degrees(+68.95603845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2524",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2524"},
        {"Smithsonian Astrophysical Observation", "SAO 11250"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.01144798),
        dec: Angle.Degrees(+68.95947357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32049"},
        {"Hipparcos Number", "HIP 23730"},
        {"Geneva Identification System", "GEN# +1.00032049"},
        {"Smithsonian Astrophysical Observation", "SAO 13362"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.52528407),
        dec: Angle.Degrees(+68.97261893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33748"},
        {"Hipparcos Number", "HIP 24704"},
        {"Geneva Identification System", "GEN# +1.00033748"},
        {"Smithsonian Astrophysical Observation", "SAO 13442"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.49179107),
        dec: Angle.Degrees(+68.97344655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115089"},
        {"Hipparcos Number", "HIP 64492"},
        {"Smithsonian Astrophysical Observation", "SAO 16016"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.28877189),
        dec: Angle.Degrees(+68.98003157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211193"},
        {"Hipparcos Number", "HIP 109661"},
        {"Smithsonian Astrophysical Observation", "SAO 19944"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.22449826),
        dec: Angle.Degrees(+68.98327249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43101",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43101"},
    },
    visualMagnitude: 10.10,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.66958470),
        dec: Angle.Degrees(+68.98877762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25991"},
        {"Hipparcos Number", "HIP 19607"},
        {"Smithsonian Astrophysical Observation", "SAO 13055"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.02125542),
        dec: Angle.Degrees(+68.99198578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30329",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30329"},
        {"Smithsonian Astrophysical Observation", "SAO 13817"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.69397018),
        dec: Angle.Degrees(+68.99848222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36522",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36522"},
        {"Smithsonian Astrophysical Observation", "SAO 14210"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.70003514),
        dec: Angle.Degrees(+68.99927991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120162"},
        {"Hipparcos Number", "HIP 67109"},
        {"Geneva Identification System", "GEN# +1.00120162"},
        {"Smithsonian Astrophysical Observation", "SAO 16166"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.32941879),
        dec: Angle.Degrees(+68.99932500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101364"},
        {"Hipparcos Number", "HIP 56948"},
        {"Geneva Identification System", "GEN# +1.00101364"},
        {"Smithsonian Astrophysical Observation", "SAO 15590"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.11954419),
        dec: Angle.Degrees(+69.00850537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82887",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82887"},
        {"Smithsonian Astrophysical Observation", "SAO 17288"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.07935112),
        dec: Angle.Degrees(+69.00865396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115423",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115423"},
        {"Smithsonian Astrophysical Observation", "SAO 20594"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.71104699),
        dec: Angle.Degrees(+69.00963584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109701"},
        {"Hipparcos Number", "HIP 61483"},
        {"Geneva Identification System", "GEN# +1.00109701"},
        {"Smithsonian Astrophysical Observation", "SAO 15835"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.96574914),
        dec: Angle.Degrees(+69.01374486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183317"},
        {"Hipparcos Number", "HIP 95320"},
        {"Smithsonian Astrophysical Observation", "SAO 18327"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.89244412),
        dec: Angle.Degrees(+69.01476142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18593",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18593"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.68180734),
        dec: Angle.Degrees(+69.01652601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104725"},
        {"Hipparcos Number", "HIP 58798"},
        {"Smithsonian Astrophysical Observation", "SAO 15696"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.89830261),
        dec: Angle.Degrees(+69.01997480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89289"},
        {"Hipparcos Number", "HIP 50652"},
        {"Smithsonian Astrophysical Observation", "SAO 15144"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.16877353),
        dec: Angle.Degrees(+69.02079434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65707",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65707"},
    },
    visualMagnitude: 9.85,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.07582128),
        dec: Angle.Degrees(+69.02119978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9238",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9238"},
        {"Geneva Identification System", "GEN# +0.06800138"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.69232647),
        dec: Angle.Degrees(+69.02409040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 353.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77102"},
        {"Hipparcos Number", "HIP 44544"},
        {"Smithsonian Astrophysical Observation", "SAO 14750"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.13631958),
        dec: Angle.Degrees(+69.02552747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113477",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113477"},
        {"Cincinnati Publication", "Ci 20 1394"},
        {"Cincinnati Publication 2", "Ci 18 3002"},
        {"Geneva Identification System", "GEN# +0.06801345"},
        {"Smithsonian Astrophysical Observation", "SAO 20353"},
        {"Wilson Evans Batten Catalogue", "WEB 20178"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.72015977),
        dec: Angle.Degrees(+69.02986843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 593.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 299.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100176"},
        {"Hipparcos Number", "HIP 56298"},
        {"Geneva Identification System", "GEN# +1.00100176"},
        {"Smithsonian Astrophysical Observation", "SAO 15541"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.11121422),
        dec: Angle.Degrees(+69.03030811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69389"},
        {"Hipparcos Number", "HIP 40964"},
        {"Fundamental Katalog 5th Edition", "FK5 4750"},
        {"Geneva Identification System", "GEN# +1.00069389"},
        {"Smithsonian Astrophysical Observation", "SAO 14511"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.39890021),
        dec: Angle.Degrees(+69.03045307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86574"},
        {"Hipparcos Number", "HIP 49193"},
        {"Smithsonian Astrophysical Observation", "SAO 15048"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.60838989),
        dec: Angle.Degrees(+69.04073265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32945",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32945"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.94000518),
        dec: Angle.Degrees(+69.04125532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78361"},
        {"Hipparcos Number", "HIP 45147"},
        {"Smithsonian Astrophysical Observation", "SAO 14797"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.97555658),
        dec: Angle.Degrees(+69.04316554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213011"},
        {"Hipparcos Number", "HIP 110749"},
        {"Geneva Identification System", "GEN# +1.00213011"},
        {"Smithsonian Astrophysical Observation", "SAO 20069"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.55468227),
        dec: Angle.Degrees(+69.04363534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5351"},
        {"Hipparcos Number", "HIP 4454"},
        {"Cincinnati Publication", "Ci 20 63"},
        {"Cincinnati Publication 2", "Ci 18 122"},
        {"Geneva Identification System", "GEN# +1.00005351"},
        {"Smithsonian Astrophysical Observation", "SAO 11483"},
        {"Wilson Evans Batten Catalogue", "WEB 801"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.26352093),
        dec: Angle.Degrees(+69.04402238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 715.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -234.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5109"},
        {"Hipparcos Number", "HIP 4258"},
        {"Smithsonian Astrophysical Observation", "SAO 11454"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.57495949),
        dec: Angle.Degrees(+69.04735787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207030"},
        {"Hipparcos Number", "HIP 107205"},
        {"Smithsonian Astrophysical Observation", "SAO 19603"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.70501470),
        dec: Angle.Degrees(+69.05370055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11101",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11101"},
        {"Smithsonian Astrophysical Observation", "SAO 12251"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.72798233),
        dec: Angle.Degrees(+69.05521562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15948"},
        {"Hipparcos Number", "HIP 12237"},
        {"Smithsonian Astrophysical Observation", "SAO 12357"},
        {"Wilson Evans Batten Catalogue", "WEB 2511"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.39254917),
        dec: Angle.Degrees(+69.05687737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200099"},
        {"Hipparcos Number", "HIP 103420"},
        {"Smithsonian Astrophysical Observation", "SAO 19127"},
        {"Wilson Evans Batten Catalogue", "WEB 18808"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.30350635),
        dec: Angle.Degrees(+69.05765320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16228"},
        {"Hipparcos Number", "HIP 12434"},
        {"Smithsonian Astrophysical Observation", "SAO 12375"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.00868764),
        dec: Angle.Degrees(+69.05927937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214442"},
        {"Hipparcos Number", "HIP 111569"},
        {"Geneva Identification System", "GEN# +1.00214442"},
        {"Smithsonian Astrophysical Observation", "SAO 20174"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.03469572),
        dec: Angle.Degrees(+69.06119911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59095",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8428 B"},
        {"Henry Draper", "HD 105287B"},
        {"Hipparcos Number", "HIP 59095"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.78166738),
        dec: Angle.Degrees(+69.07073915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116589",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116589"},
        {"Smithsonian Astrophysical Observation", "SAO 20735"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.40842342),
        dec: Angle.Degrees(+69.07410530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162195"},
        {"Hipparcos Number", "HIP 86775"},
        {"Geneva Identification System", "GEN# +1.00162195"},
        {"Smithsonian Astrophysical Observation", "SAO 17624"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.98268550),
        dec: Angle.Degrees(+69.07410990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112584",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112584"},
        {"Smithsonian Astrophysical Observation", "SAO 20251"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.03160202),
        dec: Angle.Degrees(+69.07503323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59094",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8428 A"},
        {"Henry Draper", "HD 105287"},
        {"Hipparcos Number", "HIP 59094"},
        {"Geneva Identification System", "GEN# +1.00105287"},
        {"Smithsonian Astrophysical Observation", "SAO 15716"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.78153642),
        dec: Angle.Degrees(+69.07623829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92523"},
        {"Hipparcos Number", "HIP 52425"},
        {"Fundamental Katalog 5th Edition", "FK5 403"},
        {"Geneva Identification System", "GEN# +1.00092523"},
        {"Smithsonian Astrophysical Observation", "SAO 15269"},
        {"Wilson Evans Batten Catalogue", "WEB 9546"},
    },
    visualMagnitude: 5.01,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.76683096),
        dec: Angle.Degrees(+69.07624525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10195"},
        {"Hipparcos Number", "HIP 7949"},
        {"Geneva Identification System", "GEN# +1.00010195"},
        {"Smithsonian Astrophysical Observation", "SAO 11916"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.52543359),
        dec: Angle.Degrees(+69.08601991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 183.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79518"},
        {"Hipparcos Number", "HIP 45670"},
        {"Smithsonian Astrophysical Observation", "SAO 14834"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.64562770),
        dec: Angle.Degrees(+69.09148806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180096"},
        {"Hipparcos Number", "HIP 94128"},
        {"Smithsonian Astrophysical Observation", "SAO 18193"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.41287467),
        dec: Angle.Degrees(+69.09308766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29018"},
        {"Hipparcos Number", "HIP 21708"},
        {"Smithsonian Astrophysical Observation", "SAO 13218"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.91293777),
        dec: Angle.Degrees(+69.09384404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29268"},
        {"Hipparcos Number", "HIP 21862"},
        {"Geneva Identification System", "GEN# +1.00029268"},
        {"Smithsonian Astrophysical Observation", "SAO 13229"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.51545673),
        dec: Angle.Degrees(+69.09390248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114777",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114777"},
        {"Smithsonian Astrophysical Observation", "SAO 20511"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.74527115),
        dec: Angle.Degrees(+69.09516450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102976",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102976"},
    },
    visualMagnitude: 13.21,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.94803074),
        dec: Angle.Degrees(+69.09731917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152375"},
        {"Hipparcos Number", "HIP 82182"},
        {"Smithsonian Astrophysical Observation", "SAO 17228"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.84480750),
        dec: Angle.Degrees(+69.09878088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7852"},
        {"Hipparcos Number", "HIP 6245"},
        {"Geneva Identification System", "GEN# +1.00007852"},
        {"Smithsonian Astrophysical Observation", "SAO 11697"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.03207251),
        dec: Angle.Degrees(+69.09918135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142371"},
        {"Hipparcos Number", "HIP 77487"},
        {"Smithsonian Astrophysical Observation", "SAO 16868"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.32855459),
        dec: Angle.Degrees(+69.09943931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209451"},
        {"Hipparcos Number", "HIP 108648"},
        {"Smithsonian Astrophysical Observation", "SAO 19796"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.15982108),
        dec: Angle.Degrees(+69.10179417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116285"},
        {"Hipparcos Number", "HIP 65123"},
        {"Geneva Identification System", "GEN# +1.00116285"},
        {"Smithsonian Astrophysical Observation", "SAO 16055"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.18882758),
        dec: Angle.Degrees(+69.10229137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23551"},
        {"Hipparcos Number", "HIP 18012"},
        {"Smithsonian Astrophysical Observation", "SAO 12924"},
        {"Wilson Evans Batten Catalogue", "WEB 3471"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.75193805),
        dec: Angle.Degrees(+69.10282468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155952"},
        {"Hipparcos Number", "HIP 83919"},
        {"Geneva Identification System", "GEN# +1.00155952"},
        {"Smithsonian Astrophysical Observation", "SAO 17371"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.25930608),
        dec: Angle.Degrees(+69.10416276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148293"},
        {"Hipparcos Number", "HIP 80161"},
        {"Geneva Identification System", "GEN# +1.00148293"},
        {"Smithsonian Astrophysical Observation", "SAO 17062"},
        {"Wilson Evans Batten Catalogue", "WEB 13569"},
    },
    visualMagnitude: 5.26,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.45308916),
        dec: Angle.Degrees(+69.10941712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31149"},
        {"Hipparcos Number", "HIP 23160"},
        {"Smithsonian Astrophysical Observation", "SAO 13325"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.74241011),
        dec: Angle.Degrees(+69.11165517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82031",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82031"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.36029141),
        dec: Angle.Degrees(+69.12416412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29059"},
        {"Hipparcos Number", "HIP 21728"},
        {"Smithsonian Astrophysical Observation", "SAO 13220"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.98670906),
        dec: Angle.Degrees(+69.12545567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8502",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8502"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.40968508),
        dec: Angle.Degrees(+69.12672263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27275"},
        {"Hipparcos Number", "HIP 20517"},
        {"Geneva Identification System", "GEN# +1.00027275"},
        {"Smithsonian Astrophysical Observation", "SAO 13120"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.94401287),
        dec: Angle.Degrees(+69.12963441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190061"},
        {"Hipparcos Number", "HIP 98288"},
        {"Smithsonian Astrophysical Observation", "SAO 18630"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.55564292),
        dec: Angle.Degrees(+69.14006627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 144.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 136.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191416"},
        {"Hipparcos Number", "HIP 98885"},
        {"Smithsonian Astrophysical Observation", "SAO 18702"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.21008080),
        dec: Angle.Degrees(+69.14109678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161538"},
        {"Hipparcos Number", "HIP 86481"},
        {"Geneva Identification System", "GEN# +1.00161538"},
        {"Smithsonian Astrophysical Observation", "SAO 17601"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.07008247),
        dec: Angle.Degrees(+69.14998008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 124.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19964",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19964"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.21035742),
        dec: Angle.Degrees(+69.14998041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121129"},
        {"Hipparcos Number", "HIP 67583"},
        {"Smithsonian Astrophysical Observation", "SAO 16196"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.72125971),
        dec: Angle.Degrees(+69.15343961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61951"},
        {"Hipparcos Number", "HIP 37979"},
        {"Geneva Identification System", "GEN# +1.00061951"},
        {"Smithsonian Astrophysical Observation", "SAO 14320"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.77035705),
        dec: Angle.Degrees(+69.15471500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136691"},
        {"Hipparcos Number", "HIP 74834"},
        {"Smithsonian Astrophysical Observation", "SAO 16677"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.40827303),
        dec: Angle.Degrees(+69.15473717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171312"},
        {"Hipparcos Number", "HIP 90535"},
        {"Smithsonian Astrophysical Observation", "SAO 17902"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.09582506),
        dec: Angle.Degrees(+69.15485806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139115"},
        {"Hipparcos Number", "HIP 76025"},
        {"Smithsonian Astrophysical Observation", "SAO 16762"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.91736663),
        dec: Angle.Degrees(+69.15912733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31499"},
        {"Hipparcos Number", "HIP 23425"},
        {"Smithsonian Astrophysical Observation", "SAO 13338"},
        {"Wilson Evans Batten Catalogue", "WEB 4550"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.52277909),
        dec: Angle.Degrees(+69.16046325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118084",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118084"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.30468755),
        dec: Angle.Degrees(+69.16165338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150825"},
        {"Hipparcos Number", "HIP 81433"},
        {"Geneva Identification System", "GEN# +1.00150825"},
        {"Smithsonian Astrophysical Observation", "SAO 17175"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.49897790),
        dec: Angle.Degrees(+69.16260739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42669"},
        {"Hipparcos Number", "HIP 29916"},
        {"Smithsonian Astrophysical Observation", "SAO 13780"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.47212614),
        dec: Angle.Degrees(+69.17050777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11347"},
        {"Hipparcos Number", "HIP 8878"},
        {"Smithsonian Astrophysical Observation", "SAO 12028"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.58455399),
        dec: Angle.Degrees(+69.18232670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58567",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8387 AB"},
        {"Henry Draper", "HD 104288"},
        {"Hipparcos Number", "HIP 58567"},
        {"Smithsonian Astrophysical Observation", "SAO 15686"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.15643440),
        dec: Angle.Degrees(+69.18548949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154319"},
        {"Hipparcos Number", "HIP 83114"},
        {"Smithsonian Astrophysical Observation", "SAO 17305"},
        {"Wilson Evans Batten Catalogue", "WEB 14048"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.76072549),
        dec: Angle.Degrees(+69.18634733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13836",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2226 AB"},
        {"Henry Draper", "HD 18056"},
        {"Hipparcos Number", "HIP 13836"},
        {"Geneva Identification System", "GEN# +1.00018056J"},
        {"Smithsonian Astrophysical Observation", "SAO 12530"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.52888048),
        dec: Angle.Degrees(+69.19350970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111146",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111146"},
        {"Smithsonian Astrophysical Observation", "SAO 20127"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.77335392),
        dec: Angle.Degrees(+69.19978474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23321"},
        {"Hipparcos Number", "HIP 17848"},
        {"Geneva Identification System", "GEN# +1.00023321"},
        {"Smithsonian Astrophysical Observation", "SAO 12907"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.29117029),
        dec: Angle.Degrees(+69.19993521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108907"},
        {"Hipparcos Number", "HIP 60998"},
        {"Geneva Identification System", "GEN# +1.00108907"},
        {"Smithsonian Astrophysical Observation", "SAO 15816"},
        {"Wilson Evans Batten Catalogue", "WEB 10860"},
    },
    visualMagnitude: 5.01,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.52817199),
        dec: Angle.Degrees(+69.20126087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51349"},
        {"Hipparcos Number", "HIP 33949"},
        {"Smithsonian Astrophysical Observation", "SAO 14051"},
        {"Wilson Evans Batten Catalogue", "WEB 6811"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.66981328),
        dec: Angle.Degrees(+69.20824310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214606"},
        {"Henry Draper 2", "HD 214605"},
        {"Hipparcos Number", "HIP 111670"},
        {"Geneva Identification System", "GEN# +1.00214605"},
        {"Renson", "Renson 59407"},
        {"Smithsonian Astrophysical Observation", "SAO 20179"},
        {"Wilson Evans Batten Catalogue", "WEB 19958"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.32969265),
        dec: Angle.Degrees(+69.20863270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77833"},
        {"Hipparcos Number", "HIP 44925"},
        {"Smithsonian Astrophysical Observation", "SAO 14775"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.27114302),
        dec: Angle.Degrees(+69.21077788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97854"},
        {"Hipparcos Number", "HIP 55076"},
        {"Geneva Identification System", "GEN# +1.00097854"},
        {"Smithsonian Astrophysical Observation", "SAO 15456"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.13735561),
        dec: Angle.Degrees(+69.21803886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67046",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9016 AB"},
        {"Henry Draper", "HD 120032"},
        {"Hipparcos Number", "HIP 67046"},
        {"Geneva Identification System", "GEN# +1.00120032"},
        {"Smithsonian Astrophysical Observation", "SAO 16162"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.10495717),
        dec: Angle.Degrees(+69.21998633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86534",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86534"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.26760825),
        dec: Angle.Degrees(+69.22026147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 217.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164373"},
        {"Hipparcos Number", "HIP 87703"},
        {"Smithsonian Astrophysical Observation", "SAO 17689"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.71472589),
        dec: Angle.Degrees(+69.22197943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34666"},
        {"Hipparcos Number", "HIP 25325"},
        {"Smithsonian Astrophysical Observation", "SAO 13479"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.25278516),
        dec: Angle.Degrees(+69.22364137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58183",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58183"},
        {"Smithsonian Astrophysical Observation", "SAO 15660"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.99781780),
        dec: Angle.Degrees(+69.22524731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95327"},
        {"Hipparcos Number", "HIP 53918"},
        {"Smithsonian Astrophysical Observation", "SAO 15367"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.49262100),
        dec: Angle.Degrees(+69.22587923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50001",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50001"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.11770101),
        dec: Angle.Degrees(+69.22597985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5996"},
        {"Hipparcos Number", "HIP 4907"},
        {"Cincinnati Publication", "Ci 18 132"},
        {"Geneva Identification System", "GEN# +1.00005996"},
        {"Smithsonian Astrophysical Observation", "SAO 11539"},
        {"Wilson Evans Batten Catalogue", "WEB 959"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.73689231),
        dec: Angle.Degrees(+69.22742039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 223.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132464"},
        {"Hipparcos Number", "HIP 73011"},
        {"Smithsonian Astrophysical Observation", "SAO 16551"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.81787159),
        dec: Angle.Degrees(+69.22782350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18490"},
        {"Hipparcos Number", "HIP 14160"},
        {"Smithsonian Astrophysical Observation", "SAO 12569"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.64481502),
        dec: Angle.Degrees(+69.22870139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99922",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99922"},
        {"Smithsonian Astrophysical Observation", "SAO 18792"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.10525768),
        dec: Angle.Degrees(+69.22966888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121585"},
        {"Hipparcos Number", "HIP 67826"},
        {"Geneva Identification System", "GEN# +1.00121585"},
        {"Smithsonian Astrophysical Observation", "SAO 16209"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.41081794),
        dec: Angle.Degrees(+69.23243407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118194",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118194"},
    },
    visualMagnitude: 10.82,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.61680265),
        dec: Angle.Degrees(+69.23337362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69870",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9220 AB"},
        {"Henry Draper", "HD 125725"},
        {"Hipparcos Number", "HIP 69870"},
        {"Smithsonian Astrophysical Observation", "SAO 16331"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.47014717),
        dec: Angle.Degrees(+69.23426385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8034"},
        {"Hipparcos Number", "HIP 6366"},
        {"Smithsonian Astrophysical Observation", "SAO 11715"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.44396644),
        dec: Angle.Degrees(+69.23652249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14932",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14932"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.14019897),
        dec: Angle.Degrees(+69.23720698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83489"},
        {"Hipparcos Number", "HIP 47594"},
        {"Fundamental Katalog 5th Edition", "FK5 363"},
        {"Geneva Identification System", "GEN# +1.00083489"},
        {"Smithsonian Astrophysical Observation", "SAO 14966"},
        {"Wilson Evans Batten Catalogue", "WEB 8922"},
    },
    visualMagnitude: 5.72,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.56222108),
        dec: Angle.Degrees(+69.23770604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22777",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22777"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.48513015),
        dec: Angle.Degrees(+69.23936049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 220.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11070",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11070"},
        {"Smithsonian Astrophysical Observation", "SAO 12244"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.62827568),
        dec: Angle.Degrees(+69.24263434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75700",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75700"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.97591357),
        dec: Angle.Degrees(+69.24364541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89113",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11178 AB"},
        {"Henry Draper", "HD 167855"},
        {"Hipparcos Number", "HIP 89113"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.81342176),
        dec: Angle.Degrees(+69.24986450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6729",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6729"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.66882990),
        dec: Angle.Degrees(+69.25067262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 153.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129844"},
        {"Hipparcos Number", "HIP 71790"},
        {"Smithsonian Astrophysical Observation", "SAO 16465"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.27332211),
        dec: Angle.Degrees(+69.25218220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127455"},
        {"Hipparcos Number", "HIP 70736"},
        {"Geneva Identification System", "GEN# +1.00127455"},
        {"Smithsonian Astrophysical Observation", "SAO 16392"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.99195198),
        dec: Angle.Degrees(+69.25318445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28021"},
        {"Hipparcos Number", "HIP 21058"},
        {"Smithsonian Astrophysical Observation", "SAO 13160"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.70291736),
        dec: Angle.Degrees(+69.25379906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201489"},
        {"Hipparcos Number", "HIP 104143"},
        {"Smithsonian Astrophysical Observation", "SAO 19197"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.49661039),
        dec: Angle.Degrees(+69.26541259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20921"},
        {"Smithsonian Astrophysical Observation", "SAO 13153"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.27239218),
        dec: Angle.Degrees(+69.27053719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51410",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51410"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.51234959),
        dec: Angle.Degrees(+69.27153612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27175",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27175"},
        {"Smithsonian Astrophysical Observation", "SAO 13595"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.39549243),
        dec: Angle.Degrees(+69.27339373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115717",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115717"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.66483332),
        dec: Angle.Degrees(+69.27395475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 181.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114041",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114041"},
        {"Smithsonian Astrophysical Observation", "SAO 20420"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.41746711),
        dec: Angle.Degrees(+69.27645516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127686"},
        {"Hipparcos Number", "HIP 70830"},
        {"Smithsonian Astrophysical Observation", "SAO 16402"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.26942162),
        dec: Angle.Degrees(+69.27955237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21106"},
        {"Hipparcos Number", "HIP 16213"},
        {"Geneva Identification System", "GEN# +1.00021106"},
        {"Smithsonian Astrophysical Observation", "SAO 12769"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.22552870),
        dec: Angle.Degrees(+69.28273534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140227"},
        {"Hipparcos Number", "HIP 76519"},
        {"Fundamental Katalog 5th Edition", "FK5 3240"},
        {"Geneva Identification System", "GEN# +1.00140227"},
        {"Smithsonian Astrophysical Observation", "SAO 16794"},
        {"Wilson Evans Batten Catalogue", "WEB 12987"},
    },
    visualMagnitude: 5.65,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.41337239),
        dec: Angle.Degrees(+69.28321732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47356",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7459 AB"},
        {"Henry Draper", "HD 82992"},
        {"Hipparcos Number", "HIP 47356"},
        {"Smithsonian Astrophysical Observation", "SAO 14947"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.73587139),
        dec: Angle.Degrees(+69.28859395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111889"},
        {"Hipparcos Number", "HIP 62714"},
        {"Smithsonian Astrophysical Observation", "SAO 15921"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.78504847),
        dec: Angle.Degrees(+69.29421133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156558"},
        {"Hipparcos Number", "HIP 84179"},
        {"Geneva Identification System", "GEN# +1.00156558"},
        {"Smithsonian Astrophysical Observation", "SAO 17396"},
        {"Wilson Evans Batten Catalogue", "WEB 14218"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.12449343),
        dec: Angle.Degrees(+69.30478202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38607",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38607"},
        {"Smithsonian Astrophysical Observation", "SAO 14356"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.57852983),
        dec: Angle.Degrees(+69.31045653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71553"},
        {"Hipparcos Number", "HIP 41927"},
        {"Geneva Identification System", "GEN# +1.00071553"},
        {"Smithsonian Astrophysical Observation", "SAO 14582"},
        {"Wilson Evans Batten Catalogue", "WEB 8067"},
    },
    visualMagnitude: 6.31,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.22196648),
        dec: Angle.Degrees(+69.31996254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42818"},
        {"Hipparcos Number", "HIP 29997"},
        {"Fundamental Katalog 5th Edition", "FK5 234"},
        {"Geneva Identification System", "GEN# +1.00042818"},
        {"Smithsonian Astrophysical Observation", "SAO 13788"},
        {"Wilson Evans Batten Catalogue", "WEB 5949"},
    },
    visualMagnitude: 4.76,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.71158258),
        dec: Angle.Degrees(+69.32003430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100696"},
        {"Hipparcos Number", "HIP 56583"},
        {"Smithsonian Astrophysical Observation", "SAO 15567"},
        {"Wilson Evans Batten Catalogue", "WEB 10170"},
    },
    visualMagnitude: 5.19,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.01089937),
        dec: Angle.Degrees(+69.32325973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60316"},
        {"Hipparcos Number", "HIP 37287"},
        {"Smithsonian Astrophysical Observation", "SAO 14271"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.84562732),
        dec: Angle.Degrees(+69.32450049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4295"},
        {"Hipparcos Number", "HIP 3641"},
        {"Geneva Identification System", "GEN# +1.00004295"},
        {"Smithsonian Astrophysical Observation", "SAO 11380"},
        {"Wilson Evans Batten Catalogue", "WEB 648"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.65929285),
        dec: Angle.Degrees(+69.32537127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 166.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84597",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84597"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.39745258),
        dec: Angle.Degrees(+69.32554245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 179.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195352"},
        {"Hipparcos Number", "HIP 100789"},
        {"Geneva Identification System", "GEN# +1.00195352"},
        {"Smithsonian Astrophysical Observation", "SAO 18870"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.53527912),
        dec: Angle.Degrees(+69.32670495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1068",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1068"},
        {"Cincinnati Publication", "Ci 20 12"},
    },
    visualMagnitude: 12.49,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.31099304),
        dec: Angle.Degrees(+69.32759224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 717.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -292.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107629",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15350 AB"},
        {"Hipparcos Number", "HIP 107629"},
        {"Smithsonian Astrophysical Observation", "SAO 19657"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.01158354),
        dec: Angle.Degrees(+69.32812057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56211",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Giausar"},
        {"Henry Draper", "HD 100029"},
        {"Hipparcos Number", "HIP 56211"},
        {"Fundamental Katalog 5th Edition", "FK5 433"},
        {"Geneva Identification System", "GEN# +1.00100029"},
        {"Smithsonian Astrophysical Observation", "SAO 15532"},
        {"Wilson Evans Batten Catalogue", "WEB 10100"},
    },
    visualMagnitude: 3.82,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.85120199),
        dec: Angle.Degrees(+69.33112161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135854"},
        {"Hipparcos Number", "HIP 74453"},
        {"Smithsonian Astrophysical Observation", "SAO 16650"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.22444132),
        dec: Angle.Degrees(+69.33406180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35169"},
        {"Hipparcos Number", "HIP 25649"},
        {"Smithsonian Astrophysical Observation", "SAO 13503"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.19014854),
        dec: Angle.Degrees(+69.33648500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61144"},
        {"Hipparcos Number", "HIP 37627"},
        {"Smithsonian Astrophysical Observation", "SAO 14289"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.81868982),
        dec: Angle.Degrees(+69.33658062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187340"},
        {"Hipparcos Number", "HIP 97122"},
        {"Geneva Identification System", "GEN# +1.00187340"},
        {"Smithsonian Astrophysical Observation", "SAO 18508"},
        {"Wilson Evans Batten Catalogue", "WEB 17049"},
    },
    visualMagnitude: 5.90,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.07667340),
        dec: Angle.Degrees(+69.33711857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224518"},
        {"Hipparcos Number", "HIP 118201"},
        {"Geneva Identification System", "GEN# +1.00224518"},
        {"Smithsonian Astrophysical Observation", "SAO 20970"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.63951914),
        dec: Angle.Degrees(+69.34396183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187178"},
        {"Hipparcos Number", "HIP 97039"},
        {"Smithsonian Astrophysical Observation", "SAO 18498"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.82559990),
        dec: Angle.Degrees(+69.34744285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174123"},
        {"Hipparcos Number", "HIP 91812"},
        {"Geneva Identification System", "GEN# +1.00174123"},
        {"Smithsonian Astrophysical Observation", "SAO 17991"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.79360350),
        dec: Angle.Degrees(+69.34973187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80365"},
        {"Hipparcos Number", "HIP 46030"},
        {"Fundamental Katalog 5th Edition", "FK5 4833"},
        {"Smithsonian Astrophysical Observation", "SAO 14860"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.82027010),
        dec: Angle.Degrees(+69.35336196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46046"},
        {"Hipparcos Number", "HIP 31610"},
        {"Fundamental Katalog 5th Edition", "FK5 4601"},
        {"Geneva Identification System", "GEN# +1.00046046"},
        {"Smithsonian Astrophysical Observation", "SAO 13890"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.23898692),
        dec: Angle.Degrees(+69.35794906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4789",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 836 AB"},
        {"Henry Draper", "HD 5839"},
        {"Hipparcos Number", "HIP 4789"},
        {"Smithsonian Astrophysical Observation", "SAO 11526"},
        {"Wilson Evans Batten Catalogue", "WEB 911"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.37565359),
        dec: Angle.Degrees(+69.35852805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124422"},
        {"Hipparcos Number", "HIP 69239"},
        {"Smithsonian Astrophysical Observation", "SAO 16300"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.62167145),
        dec: Angle.Degrees(+69.35912078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53105"},
        {"Hipparcos Number", "HIP 34565"},
        {"Smithsonian Astrophysical Observation", "SAO 14086"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.39295006),
        dec: Angle.Degrees(+69.35960716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212265"},
        {"Hipparcos Number", "HIP 110307"},
        {"Geneva Identification System", "GEN# +1.00212265"},
        {"Smithsonian Astrophysical Observation", "SAO 20019"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.13343120),
        dec: Angle.Degrees(+69.36323573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43390",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43390"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.58283328),
        dec: Angle.Degrees(+69.36498686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13320"},
        {"Hipparcos Number", "HIP 10349"},
        {"Smithsonian Astrophysical Observation", "SAO 12171"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.33631806),
        dec: Angle.Degrees(+69.36724517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39361",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39361"},
        {"Smithsonian Astrophysical Observation", "SAO 14404"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.68951056),
        dec: Angle.Degrees(+69.36756274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -200.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27932"},
        {"Hipparcos Number", "HIP 20974"},
        {"Fundamental Katalog 5th Edition", "FK5 1122"},
        {"Geneva Identification System", "GEN# +1.00027932"},
        {"Smithsonian Astrophysical Observation", "SAO 13157"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.46631561),
        dec: Angle.Degrees(+69.37839766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116902",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116902"},
        {"Smithsonian Astrophysical Observation", "SAO 20782"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.44314253),
        dec: Angle.Degrees(+69.39298675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36533"},
        {"Hipparcos Number", "HIP 26517"},
        {"Smithsonian Astrophysical Observation", "SAO 13554"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.58595414),
        dec: Angle.Degrees(+69.39941360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116617",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116617"},
        {"Smithsonian Astrophysical Observation", "SAO 20742"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.50248817),
        dec: Angle.Degrees(+69.40001695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34409"},
        {"Hipparcos Number", "HIP 25156"},
        {"Geneva Identification System", "GEN# +1.00034409"},
        {"Smithsonian Astrophysical Observation", "SAO 13467"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.74940094),
        dec: Angle.Degrees(+69.40131231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39610"},
        {"Hipparcos Number", "HIP 28366"},
        {"Smithsonian Astrophysical Observation", "SAO 13666"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.89376935),
        dec: Angle.Degrees(+69.40463055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42652",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6907 AB"},
        {"Hipparcos Number", "HIP 42652"},
        {"Smithsonian Astrophysical Observation", "SAO 14622"},
    },
    visualMagnitude: 10.67,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.39404240),
        dec: Angle.Degrees(+69.40509567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190396"},
        {"Hipparcos Number", "HIP 98405"},
        {"Smithsonian Astrophysical Observation", "SAO 18648"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.92225784),
        dec: Angle.Degrees(+69.40904690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104707",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104707"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.14776920),
        dec: Angle.Degrees(+69.41213910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40002",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40002"},
        {"Smithsonian Astrophysical Observation", "SAO 14445"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.54845482),
        dec: Angle.Degrees(+69.41581453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116104",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116104"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.87872207),
        dec: Angle.Degrees(+69.41781429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180500"},
        {"Hipparcos Number", "HIP 94264"},
        {"Geneva Identification System", "GEN# +1.00180500"},
        {"Smithsonian Astrophysical Observation", "SAO 18207"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.80388158),
        dec: Angle.Degrees(+69.41919397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98888",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98888"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.22024713),
        dec: Angle.Degrees(+69.42690819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124730"},
        {"Hipparcos Number", "HIP 69373"},
        {"Fundamental Katalog 5th Edition", "FK5 3128"},
        {"Geneva Identification System", "GEN# +1.00124730"},
        {"Smithsonian Astrophysical Observation", "SAO 16305"},
        {"Wilson Evans Batten Catalogue", "WEB 12096"},
    },
    visualMagnitude: 5.18,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.01688963),
        dec: Angle.Degrees(+69.43266873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3037"},
        {"Hipparcos Number", "HIP 2718"},
        {"Geneva Identification System", "GEN# +1.00003037"},
        {"Smithsonian Astrophysical Observation", "SAO 11267"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.65561030),
        dec: Angle.Degrees(+69.43460119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66752"},
        {"Hipparcos Number", "HIP 40000"},
        {"Geneva Identification System", "GEN# +1.00066752"},
        {"Smithsonian Astrophysical Observation", "SAO 14444"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.53103902),
        dec: Angle.Degrees(+69.44010312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93490",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12015 AB"},
        {"Henry Draper", "HD 178303"},
        {"Hipparcos Number", "HIP 93490"},
        {"Smithsonian Astrophysical Observation", "SAO 18130"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.59441899),
        dec: Angle.Degrees(+69.44174581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9776"},
        {"Hipparcos Number", "HIP 7613"},
        {"Smithsonian Astrophysical Observation", "SAO 11876"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.51976512),
        dec: Angle.Degrees(+69.44377672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215895"},
        {"Hipparcos Number", "HIP 112446"},
        {"Smithsonian Astrophysical Observation", "SAO 20242"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.67176953),
        dec: Angle.Degrees(+69.44466142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48573",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48573"},
        {"Smithsonian Astrophysical Observation", "SAO 15014"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.61239907),
        dec: Angle.Degrees(+69.45038013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57201"},
        {"Hipparcos Number", "HIP 36051"},
        {"Geneva Identification System", "GEN# +1.00057201"},
        {"Smithsonian Astrophysical Observation", "SAO 14183"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.44480916),
        dec: Angle.Degrees(+69.45487611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21140"},
        {"Hipparcos Number", "HIP 16249"},
        {"Smithsonian Astrophysical Observation", "SAO 12774"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.35390824),
        dec: Angle.Degrees(+69.45971592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20016"},
        {"Hipparcos Number", "HIP 15317"},
        {"Smithsonian Astrophysical Observation", "SAO 12682"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.40680611),
        dec: Angle.Degrees(+69.46016727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19203",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19203"},
        {"Smithsonian Astrophysical Observation", "SAO 13013"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.74559040),
        dec: Angle.Degrees(+69.47426261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40647"},
        {"Hipparcos Number", "HIP 28902"},
        {"Geneva Identification System", "GEN# +1.00040647"},
        {"Smithsonian Astrophysical Observation", "SAO 13702"},
        {"Wilson Evans Batten Catalogue", "WEB 5653"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.52469347),
        dec: Angle.Degrees(+69.47626911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141987"},
        {"Hipparcos Number", "HIP 77309"},
        {"Smithsonian Astrophysical Observation", "SAO 16854"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.74817819),
        dec: Angle.Degrees(+69.47745057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42507"},
        {"Hipparcos Number", "HIP 29844"},
        {"Smithsonian Astrophysical Observation", "SAO 13775"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.26707758),
        dec: Angle.Degrees(+69.47812203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57308"},
        {"Hipparcos Number", "HIP 36113"},
        {"Geneva Identification System", "GEN# +1.00057308"},
        {"Smithsonian Astrophysical Observation", "SAO 14187"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.59045008),
        dec: Angle.Degrees(+69.48371325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36109",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36109"},
    },
    visualMagnitude: 10.95,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)26, 17.7600),
        dec: Angle.DegreesMinutesSeconds((int)+69, (int)29, 16.400)
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
    primaryId: "HIP 97041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187177"},
        {"Hipparcos Number", "HIP 97041"},
        {"Smithsonian Astrophysical Observation", "SAO 18500"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.83467199),
        dec: Angle.Degrees(+69.48899943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64415",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64415"},
        {"Smithsonian Astrophysical Observation", "SAO 16011"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.03251159),
        dec: Angle.Degrees(+69.49524764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35311"},
        {"Hipparcos Number", "HIP 25740"},
        {"Geneva Identification System", "GEN# +1.00035311"},
        {"Smithsonian Astrophysical Observation", "SAO 13507"},
        {"Wilson Evans Batten Catalogue", "WEB 4997"},
    },
    visualMagnitude: 8.59,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.44542198),
        dec: Angle.Degrees(+69.49595237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5753",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5753"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.46590298),
        dec: Angle.Degrees(+69.50012176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16893",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16893"},
        {"Geneva Identification System", "GEN# +0.06900219"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.34188088),
        dec: Angle.Degrees(+69.50182674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18267"},
        {"Hipparcos Number", "HIP 14000"},
        {"Smithsonian Astrophysical Observation", "SAO 12553"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.06893659),
        dec: Angle.Degrees(+69.50212223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19998",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19998"},
        {"Smithsonian Astrophysical Observation", "SAO 13073"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.33083993),
        dec: Angle.Degrees(+69.50229010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10524"},
        {"Hipparcos Number", "HIP 8164"},
        {"Smithsonian Astrophysical Observation", "SAO 11952"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.25211088),
        dec: Angle.Degrees(+69.50250095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223566"},
        {"Hipparcos Number", "HIP 117546"},
        {"Geneva Identification System", "GEN# +1.00223566"},
        {"Smithsonian Astrophysical Observation", "SAO 20883"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.57703867),
        dec: Angle.Degrees(+69.50401666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26232"},
        {"Hipparcos Number", "HIP 19770"},
        {"Smithsonian Astrophysical Observation", "SAO 13067"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.58460857),
        dec: Angle.Degrees(+69.50671361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59946",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59946"},
        {"Wilson Evans Batten Catalogue", "WEB 10654"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.44447021),
        dec: Angle.Degrees(+69.51063822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194681"},
        {"Hipparcos Number", "HIP 100452"},
        {"Smithsonian Astrophysical Observation", "SAO 18834"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.55707069),
        dec: Angle.Degrees(+69.51255649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24297"},
        {"Hipparcos Number", "HIP 18487"},
        {"Geneva Identification System", "GEN# +1.00024297"},
        {"Smithsonian Astrophysical Observation", "SAO 12964"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.27952587),
        dec: Angle.Degrees(+69.51566202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173866"},
        {"Hipparcos Number", "HIP 91678"},
        {"Smithsonian Astrophysical Observation", "SAO 17986"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.42853726),
        dec: Angle.Degrees(+69.52436661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184873"},
        {"Hipparcos Number", "HIP 95988"},
        {"Smithsonian Astrophysical Observation", "SAO 18385"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.77311786),
        dec: Angle.Degrees(+69.52695609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32280"},
        {"Hipparcos Number", "HIP 23869"},
        {"Smithsonian Astrophysical Observation", "SAO 13371"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.94798483),
        dec: Angle.Degrees(+69.52897300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96014"},
        {"Hipparcos Number", "HIP 54256"},
        {"Smithsonian Astrophysical Observation", "SAO 15397"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.49119502),
        dec: Angle.Degrees(+69.52976103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177410"},
        {"Hipparcos Number", "HIP 93187"},
        {"Fundamental Katalog 5th Edition", "FK5 3517"},
        {"Geneva Identification System", "GEN# +1.00177410"},
        {"Renson", "Renson 49490"},
        {"Smithsonian Astrophysical Observation", "SAO 18103"},
        {"Wilson Evans Batten Catalogue", "WEB 16154"},
    },
    visualMagnitude: 6.52,
    bvColour: -0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.71924825),
        dec: Angle.Degrees(+69.53126334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204260"},
        {"Hipparcos Number", "HIP 105635"},
        {"Smithsonian Astrophysical Observation", "SAO 19385"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.93747036),
        dec: Angle.Degrees(+69.53446463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68559",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68559"},
        {"Smithsonian Astrophysical Observation", "SAO 16255"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.52360381),
        dec: Angle.Degrees(+69.53592263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4500"},
        {"Hipparcos Number", "HIP 3759"},
        {"Smithsonian Astrophysical Observation", "SAO 11399"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.06913336),
        dec: Angle.Degrees(+69.53615661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35007",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35007"},
    },
    visualMagnitude: 10.03,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.63923723),
        dec: Angle.Degrees(+69.53972463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25665"},
        {"Hipparcos Number", "HIP 19422"},
        {"Cincinnati Publication", "Ci 18 546"},
        {"Geneva Identification System", "GEN# +1.00025665"},
        {"Smithsonian Astrophysical Observation", "SAO 13039"},
        {"Wilson Evans Batten Catalogue", "WEB 3731"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.39549302),
        dec: Angle.Degrees(+69.54211787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -298.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109235",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109235"},
        {"Smithsonian Astrophysical Observation", "SAO 19881"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.94146214),
        dec: Angle.Degrees(+69.55328134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31613",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31613"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.24945062),
        dec: Angle.Degrees(+69.55760108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16615"},
        {"Hipparcos Number", "HIP 12734"},
        {"Smithsonian Astrophysical Observation", "SAO 12408"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.92586830),
        dec: Angle.Degrees(+69.56429826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34463"},
        {"Hipparcos Number", "HIP 25200"},
        {"Geneva Identification System", "GEN# +1.00034463"},
        {"Smithsonian Astrophysical Observation", "SAO 13471"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.87394239),
        dec: Angle.Degrees(+69.56490577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203694"},
        {"Hipparcos Number", "HIP 105331"},
        {"Geneva Identification System", "GEN# +1.00203694"},
        {"Smithsonian Astrophysical Observation", "SAO 19338"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.03154394),
        dec: Angle.Degrees(+69.56824393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42937"},
        {"Hipparcos Number", "HIP 30058"},
        {"Geneva Identification System", "GEN# +1.00042937"},
        {"Smithsonian Astrophysical Observation", "SAO 13796"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.89931645),
        dec: Angle.Degrees(+69.56917215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160933"},
        {"Hipparcos Number", "HIP 86184"},
        {"Geneva Identification System", "GEN# +1.00160933"},
        {"Smithsonian Astrophysical Observation", "SAO 17572"},
        {"Wilson Evans Batten Catalogue", "WEB 14538"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.16679686),
        dec: Angle.Degrees(+69.57125889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -217.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100640"},
        {"Hipparcos Number", "HIP 56547"},
        {"Geneva Identification System", "GEN# +1.00100640"},
        {"Smithsonian Astrophysical Observation", "SAO 15566"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.91700291),
        dec: Angle.Degrees(+69.57269377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62856",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62856"},
        {"Smithsonian Astrophysical Observation", "SAO 15931"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.25627888),
        dec: Angle.Degrees(+69.57886328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72130"},
        {"Hipparcos Number", "HIP 42180"},
        {"Geneva Identification System", "GEN# +1.00072130"},
        {"Smithsonian Astrophysical Observation", "SAO 14595"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.98756207),
        dec: Angle.Degrees(+69.57923117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12288"},
        {"Hipparcos Number", "HIP 9604"},
        {"Geneva Identification System", "GEN# +1.00012288"},
        {"Renson", "Renson 3130"},
        {"Smithsonian Astrophysical Observation", "SAO 12098"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.87704735),
        dec: Angle.Degrees(+69.58232390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95155"},
        {"Hipparcos Number", "HIP 53847"},
        {"Fundamental Katalog 5th Edition", "FK5 4971"},
        {"Geneva Identification System", "GEN# +1.00095155"},
        {"Smithsonian Astrophysical Observation", "SAO 15358"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.23064482),
        dec: Angle.Degrees(+69.58406771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124290"},
        {"Hipparcos Number", "HIP 69161"},
        {"Geneva Identification System", "GEN# +1.00124290"},
        {"Smithsonian Astrophysical Observation", "SAO 16291"},
    },
    visualMagnitude: 7.33,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.36062305),
        dec: Angle.Degrees(+69.59041084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53580",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53580"},
        {"Cincinnati Publication", "Ci 20 598"},
        {"Geneva Identification System", "GEN# +0.07000639"},
        {"Smithsonian Astrophysical Observation", "SAO 15345"},
        {"Wilson Evans Batten Catalogue", "WEB 9722"},
    },
    visualMagnitude: 10.28,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.41310433),
        dec: Angle.Degrees(+69.59647402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -630.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159906"},
        {"Hipparcos Number", "HIP 85742"},
        {"Smithsonian Astrophysical Observation", "SAO 17517"},
        {"Wilson Evans Batten Catalogue", "WEB 14469"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.82453097),
        dec: Angle.Degrees(+69.60002483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224836"},
        {"Hipparcos Number", "HIP 86"},
        {"Smithsonian Astrophysical Observation", "SAO 20998"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.26038262),
        dec: Angle.Degrees(+69.60349830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39354"},
        {"Hipparcos Number", "HIP 28243"},
        {"Geneva Identification System", "GEN# +1.00039354"},
        {"Smithsonian Astrophysical Observation", "SAO 13663"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.52859073),
        dec: Angle.Degrees(+69.60430643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25745"},
        {"Hipparcos Number", "HIP 19475"},
        {"Smithsonian Astrophysical Observation", "SAO 13044"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.57167356),
        dec: Angle.Degrees(+69.60548101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78953",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78953"},
        {"Smithsonian Astrophysical Observation", "SAO 16968"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.76032761),
        dec: Angle.Degrees(+69.60592495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7315"},
        {"Hipparcos Number", "HIP 5865"},
        {"Smithsonian Astrophysical Observation", "SAO 11655"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.80064674),
        dec: Angle.Degrees(+69.61536000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164446"},
        {"Hipparcos Number", "HIP 87730"},
        {"Smithsonian Astrophysical Observation", "SAO 17694"},
        {"Wilson Evans Batten Catalogue", "WEB 14804"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.79972637),
        dec: Angle.Degrees(+69.61562228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93623"},
        {"Hipparcos Number", "HIP 52984"},
        {"Smithsonian Astrophysical Observation", "SAO 15306"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.57855433),
        dec: Angle.Degrees(+69.62045660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48049"},
        {"Hipparcos Number", "HIP 32549"},
        {"Geneva Identification System", "GEN# +1.00048049"},
        {"Smithsonian Astrophysical Observation", "SAO 13951"},
        {"Wilson Evans Batten Catalogue", "WEB 6564"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.87003982),
        dec: Angle.Degrees(+69.62912377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86066",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86066"},
        {"Smithsonian Astrophysical Observation", "SAO 17555"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.83667103),
        dec: Angle.Degrees(+69.63373171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17138"},
        {"Hipparcos Number", "HIP 13133"},
        {"Geneva Identification System", "GEN# +1.00017138"},
        {"Smithsonian Astrophysical Observation", "SAO 12445"},
        {"Wilson Evans Batten Catalogue", "WEB 2644"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.23127335),
        dec: Angle.Degrees(+69.63419857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154273"},
        {"Hipparcos Number", "HIP 83088"},
        {"Smithsonian Astrophysical Observation", "SAO 17302"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.66726276),
        dec: Angle.Degrees(+69.63485569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116245"},
        {"Hipparcos Number", "HIP 65070"},
        {"Geneva Identification System", "GEN# +1.00116245"},
        {"Smithsonian Astrophysical Observation", "SAO 16052"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.06656509),
        dec: Angle.Degrees(+69.63562593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82620"},
        {"Hipparcos Number", "HIP 47165"},
        {"Geneva Identification System", "GEN# +1.00082620"},
        {"Smithsonian Astrophysical Observation", "SAO 14934"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.17104830),
        dec: Angle.Degrees(+69.63672582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152123"},
        {"Hipparcos Number", "HIP 82065"},
        {"Geneva Identification System", "GEN# +1.00152123"},
        {"Smithsonian Astrophysical Observation", "SAO 17217"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.44754334),
        dec: Angle.Degrees(+69.63712134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 144.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143804"},
        {"Hipparcos Number", "HIP 78138"},
        {"Smithsonian Astrophysical Observation", "SAO 16903"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.32684808),
        dec: Angle.Degrees(+69.63892360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24003",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Mago"},
        {"Henry Draper", "HD 32518"},
        {"Hipparcos Number", "HIP 24003"},
        {"Fundamental Katalog 5th Edition", "FK5 2382"},
        {"Geneva Identification System", "GEN# +1.00032518"},
        {"Smithsonian Astrophysical Observation", "SAO 13382"},
        {"Wilson Evans Batten Catalogue", "WEB 4676"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.40257498),
        dec: Angle.Degrees(+69.63955569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6500",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6500"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.87555163),
        dec: Angle.Degrees(+69.64423441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96392"},
        {"Hipparcos Number", "HIP 54415"},
        {"Smithsonian Astrophysical Observation", "SAO 15408"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.02231366),
        dec: Angle.Degrees(+69.64496594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51068"},
        {"Hipparcos Number", "HIP 33858"},
        {"Geneva Identification System", "GEN# +1.00051068"},
        {"Smithsonian Astrophysical Observation", "SAO 14044"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.43835748),
        dec: Angle.Degrees(+69.64645329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219811"},
        {"Hipparcos Number", "HIP 115014"},
        {"Smithsonian Astrophysical Observation", "SAO 20545"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.41326213),
        dec: Angle.Degrees(+69.64957289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135119"},
        {"Hipparcos Number", "HIP 74155"},
        {"Geneva Identification System", "GEN# +1.00135119"},
        {"Smithsonian Astrophysical Observation", "SAO 16622"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.27603820),
        dec: Angle.Degrees(+69.65308961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120965"},
        {"Hipparcos Number", "HIP 67507"},
        {"Smithsonian Astrophysical Observation", "SAO 16193"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.49654735),
        dec: Angle.Degrees(+69.65380915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126288"},
        {"Hipparcos Number", "HIP 70146"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.29015807),
        dec: Angle.Degrees(+69.65571463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113846"},
        {"Hipparcos Number", "HIP 63825"},
        {"Smithsonian Astrophysical Observation", "SAO 15977"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.21515503),
        dec: Angle.Degrees(+69.65707932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205452"},
        {"Hipparcos Number", "HIP 106314"},
        {"Smithsonian Astrophysical Observation", "SAO 19478"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.98336097),
        dec: Angle.Degrees(+69.65720216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198792"},
        {"Hipparcos Number", "HIP 102694"},
        {"Smithsonian Astrophysical Observation", "SAO 19048"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.12333330),
        dec: Angle.Degrees(+69.65786630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26109",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4118 A"},
        {"Henry Draper", "HD 35919"},
        {"Hipparcos Number", "HIP 26109"},
        {"Geneva Identification System", "GEN# +1.00035919"},
        {"Smithsonian Astrophysical Observation", "SAO 13531"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.51680092),
        dec: Angle.Degrees(+69.66058902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26111",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4118 B"},
        {"Hipparcos Number", "HIP 26111"},
    },
    visualMagnitude: 10.43,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.52200328),
        dec: Angle.Degrees(+69.66425924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96100",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alsafi"},
        {"Henry Draper", "HD 185144"},
        {"Hipparcos Number", "HIP 96100"},
        {"Cincinnati Publication", "Ci 20 1161"},
        {"Geneva Identification System", "GEN# +1.00185144"},
        {"Smithsonian Astrophysical Observation", "SAO 18396"},
        {"Wilson Evans Batten Catalogue", "WEB 16831"},
    },
    visualMagnitude: 4.67,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.08577692),
        dec: Angle.Degrees(+69.66540172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 598.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1738.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56167"},
        {"Hipparcos Number", "HIP 35681"},
        {"Geneva Identification System", "GEN# +1.00056167"},
        {"Smithsonian Astrophysical Observation", "SAO 14157"},
        {"Wilson Evans Batten Catalogue", "WEB 7107"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.43381733),
        dec: Angle.Degrees(+69.67076044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196541"},
        {"Hipparcos Number", "HIP 101434"},
        {"Smithsonian Astrophysical Observation", "SAO 18929"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.35395545),
        dec: Angle.Degrees(+69.67155035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201651"},
        {"Hipparcos Number", "HIP 104225"},
        {"Geneva Identification System", "GEN# +1.00201651"},
        {"Smithsonian Astrophysical Observation", "SAO 19206"},
        {"Wilson Evans Batten Catalogue", "WEB 18986"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.73419305),
        dec: Angle.Degrees(+69.67443613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49443"},
        {"Hipparcos Number", "HIP 33195"},
        {"Smithsonian Astrophysical Observation", "SAO 13995"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.63060498),
        dec: Angle.Degrees(+69.67774205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196848"},
        {"Hipparcos Number", "HIP 101602"},
        {"Geneva Identification System", "GEN# +1.00196848"},
        {"Smithsonian Astrophysical Observation", "SAO 18941"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.87036983),
        dec: Angle.Degrees(+69.68002037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167605"},
        {"Hipparcos Number", "HIP 89005"},
        {"Cincinnati Publication", "Ci 18 2407"},
        {"Smithsonian Astrophysical Observation", "SAO 17800"},
        {"Wilson Evans Batten Catalogue", "WEB 15103"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.48142744),
        dec: Angle.Degrees(+69.68002551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 193.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42096",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42096"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.70967064),
        dec: Angle.Degrees(+69.68574287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6675"},
        {"Hipparcos Number", "HIP 5414"},
        {"Geneva Identification System", "GEN# +1.00006675"},
        {"Smithsonian Astrophysical Observation", "SAO 11595"},
        {"Wilson Evans Batten Catalogue", "WEB 1182"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.30446371),
        dec: Angle.Degrees(+69.68652608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40615",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40615"},
        {"Smithsonian Astrophysical Observation", "SAO 14482"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.37813492),
        dec: Angle.Degrees(+69.68931422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206821"},
        {"Hipparcos Number", "HIP 107083"},
        {"Smithsonian Astrophysical Observation", "SAO 19585"},
        {"Wilson Evans Batten Catalogue", "WEB 19343"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.33944750),
        dec: Angle.Degrees(+69.69279707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208452"},
        {"Hipparcos Number", "HIP 108031"},
        {"Smithsonian Astrophysical Observation", "SAO 19716"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.28457328),
        dec: Angle.Degrees(+69.69656690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68477",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68477"},
        {"Smithsonian Astrophysical Observation", "SAO 16253"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.29267321),
        dec: Angle.Degrees(+69.69714949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72338"},
        {"Hipparcos Number", "HIP 42273"},
        {"Fundamental Katalog 5th Edition", "FK5 2670"},
        {"Geneva Identification System", "GEN# +1.00072338"},
        {"Smithsonian Astrophysical Observation", "SAO 14600"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.29214912),
        dec: Angle.Degrees(+69.69895322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60673",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60673"},
        {"Smithsonian Astrophysical Observation", "SAO 15804"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.51578655),
        dec: Angle.Degrees(+69.69940773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108860"},
        {"Hipparcos Number", "HIP 60963"},
        {"Smithsonian Astrophysical Observation", "SAO 15813"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.45781814),
        dec: Angle.Degrees(+69.70524630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180754"},
        {"Hipparcos Number", "HIP 94337"},
        {"Geneva Identification System", "GEN# +1.00180754"},
        {"Smithsonian Astrophysical Observation", "SAO 18217"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.02124072),
        dec: Angle.Degrees(+69.70791448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169002"},
        {"Hipparcos Number", "HIP 89571"},
        {"Geneva Identification System", "GEN# +1.00169002"},
        {"Smithsonian Astrophysical Observation", "SAO 17846"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.16988501),
        dec: Angle.Degrees(+69.70964823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16393"},
        {"Hipparcos Number", "HIP 12567"},
        {"Geneva Identification System", "GEN# +1.00016393"},
        {"Smithsonian Astrophysical Observation", "SAO 12386"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.40376477),
        dec: Angle.Degrees(+69.70967843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203916"},
        {"Hipparcos Number", "HIP 105443"},
        {"Smithsonian Astrophysical Observation", "SAO 19353"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.36497727),
        dec: Angle.Degrees(+69.71081843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22290"},
        {"Hipparcos Number", "HIP 17130"},
        {"Smithsonian Astrophysical Observation", "SAO 12847"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.03485648),
        dec: Angle.Degrees(+69.71360709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66751"},
        {"Hipparcos Number", "HIP 40015"},
        {"Geneva Identification System", "GEN# +1.00066751"},
        {"Smithsonian Astrophysical Observation", "SAO 14446"},
        {"Wilson Evans Batten Catalogue", "WEB 7802"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.58415252),
        dec: Angle.Degrees(+69.72479195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 161.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 117.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108436"},
        {"Hipparcos Number", "HIP 60739"},
        {"Fundamental Katalog 5th Edition", "FK5 5097"},
        {"Smithsonian Astrophysical Observation", "SAO 7566"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.72476307),
        dec: Angle.Degrees(+69.72993287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -180.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15534",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2455 A"},
        {"Henry Draper", "HD 20273"},
        {"Hipparcos Number", "HIP 15534"},
        {"Fundamental Katalog 5th Edition", "FK5 2231"},
        {"Geneva Identification System", "GEN# +1.00020273"},
        {"Renson", "Renson 5020"},
        {"Smithsonian Astrophysical Observation", "SAO 12703"},
        {"Wilson Evans Batten Catalogue", "WEB 2982"},
    },
    visualMagnitude: 6.60,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.02887690),
        dec: Angle.Degrees(+69.73132966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74055",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74055"},
        {"Smithsonian Astrophysical Observation", "SAO 16611"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.808,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.02205468),
        dec: Angle.Degrees(+69.73219808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3122"},
        {"Hipparcos Number", "HIP 2770"},
        {"Smithsonian Astrophysical Observation", "SAO 11272"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.82711882),
        dec: Angle.Degrees(+69.73728078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38285",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38285"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.66315665),
        dec: Angle.Degrees(+69.73891958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149282"},
        {"Hipparcos Number", "HIP 80676"},
        {"Smithsonian Astrophysical Observation", "SAO 17110"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.06483024),
        dec: Angle.Degrees(+69.74692471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162863"},
        {"Hipparcos Number", "HIP 87051"},
        {"Smithsonian Astrophysical Observation", "SAO 17639"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.80066950),
        dec: Angle.Degrees(+69.74787574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27663",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27663"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.86212236),
        dec: Angle.Degrees(+69.74947390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198236"},
        {"Hipparcos Number", "HIP 102370"},
        {"Smithsonian Astrophysical Observation", "SAO 19018"},
        {"Wilson Evans Batten Catalogue", "WEB 18532"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.13783516),
        dec: Angle.Degrees(+69.75190057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157891"},
        {"Hipparcos Number", "HIP 84814"},
        {"Smithsonian Astrophysical Observation", "SAO 17443"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.01207402),
        dec: Angle.Degrees(+69.75363955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222958"},
        {"Hipparcos Number", "HIP 117146"},
        {"Celescope Catalog", "CEL 5659"},
        {"Fundamental Katalog 5th Edition", "FK5 3907"},
        {"Geneva Identification System", "GEN# +1.00222958"},
        {"Smithsonian Astrophysical Observation", "SAO 20818"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.23610877),
        dec: Angle.Degrees(+69.75487035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8006",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8006"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.69832461),
        dec: Angle.Degrees(+69.75865017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93894"},
        {"Hipparcos Number", "HIP 53128"},
        {"Smithsonian Astrophysical Observation", "SAO 7223"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.832,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.02220962),
        dec: Angle.Degrees(+69.76114630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132188"},
        {"Hipparcos Number", "HIP 72862"},
        {"Smithsonian Astrophysical Observation", "SAO 16544"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.39729904),
        dec: Angle.Degrees(+69.76279659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48139",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48139"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.20779891),
        dec: Angle.Degrees(+69.76624309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -327.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72860",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 10.86,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)53, 32.5200),
        dec: Angle.DegreesMinutesSeconds((int)+69, (int)46, 05.800)
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
    primaryId: "HIP 22371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29948"},
        {"Hipparcos Number", "HIP 22371"},
        {"Smithsonian Astrophysical Observation", "SAO 13268"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.24029485),
        dec: Angle.Degrees(+69.77124787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158459"},
        {"Hipparcos Number", "HIP 85098"},
        {"Smithsonian Astrophysical Observation", "SAO 17467"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.88227889),
        dec: Angle.Degrees(+69.77184280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19164"},
        {"Hipparcos Number", "HIP 14650"},
        {"Smithsonian Astrophysical Observation", "SAO 12617"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.33399934),
        dec: Angle.Degrees(+69.77617707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66388",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8976 AB"},
        {"Henry Draper", "HD 118807"},
        {"Hipparcos Number", "HIP 66388"},
        {"Smithsonian Astrophysical Observation", "SAO 7851"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.17433148),
        dec: Angle.Degrees(+69.77662996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2663"},
        {"Hipparcos Number", "HIP 2453"},
        {"Geneva Identification System", "GEN# +1.00002663"},
        {"Smithsonian Astrophysical Observation", "SAO 11239"},
        {"Wilson Evans Batten Catalogue", "WEB 446"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.80170012),
        dec: Angle.Degrees(+69.78543643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 297.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109387"},
        {"Hipparcos Number", "HIP 61281"},
        {"Fundamental Katalog 5th Edition", "FK5 472"},
        {"Geneva Identification System", "GEN# +1.00109387"},
        {"Smithsonian Astrophysical Observation", "SAO 7593"},
        {"Wilson Evans Batten Catalogue", "WEB 10906"},
    },
    visualMagnitude: 3.85,
    bvColour: -0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.37101041),
        dec: Angle.Degrees(+69.78820992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78028"},
        {"Hipparcos Number", "HIP 45032"},
        {"Smithsonian Astrophysical Observation", "SAO 14784"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.58544818),
        dec: Angle.Degrees(+69.79015987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99516"},
        {"Hipparcos Number", "HIP 55957"},
        {"Geneva Identification System", "GEN# +1.00099516"},
        {"Smithsonian Astrophysical Observation", "SAO 7360"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.00867223),
        dec: Angle.Degrees(+69.79136458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76616"},
        {"Hipparcos Number", "HIP 44329"},
        {"Smithsonian Astrophysical Observation", "SAO 14736"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.41623550),
        dec: Angle.Degrees(+69.79235969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81332",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10140 AB"},
        {"Henry Draper", "HD 150631"},
        {"Hipparcos Number", "HIP 81332"},
        {"Geneva Identification System", "GEN# +1.00150631J"},
        {"Smithsonian Astrophysical Observation", "SAO 17167"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.16271607),
        dec: Angle.Degrees(+69.79298414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83477",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10340 AB"},
        {"Henry Draper", "HD 155090"},
        {"Hipparcos Number", "HIP 83477"},
        {"Smithsonian Astrophysical Observation", "SAO 17341"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.91058411),
        dec: Angle.Degrees(+69.79802299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28583",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28583"},
        {"Smithsonian Astrophysical Observation", "SAO 13680"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.50520865),
        dec: Angle.Degrees(+69.79921935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158063"},
        {"Hipparcos Number", "HIP 84910"},
        {"Geneva Identification System", "GEN# +1.00158063"},
        {"Smithsonian Astrophysical Observation", "SAO 17451"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.29357785),
        dec: Angle.Degrees(+69.80063792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185799"},
        {"Hipparcos Number", "HIP 96350"},
        {"Smithsonian Astrophysical Observation", "SAO 18428"},
        {"Wilson Evans Batten Catalogue", "WEB 16895"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.85069235),
        dec: Angle.Degrees(+69.80542694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53662",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7993 A"},
        {"Henry Draper", "HD 94847"},
        {"Hipparcos Number", "HIP 53662"},
        {"Geneva Identification System", "GEN# +1.00094847"},
        {"Smithsonian Astrophysical Observation", "SAO 7248"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.68230360),
        dec: Angle.Degrees(+69.81212248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56099",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56099"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.49064481),
        dec: Angle.Degrees(+69.81333693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81363",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10140 DP"},
        {"Henry Draper", "HD 150693"},
        {"Hipparcos Number", "HIP 81363"},
        {"Geneva Identification System", "GEN# +1.00150693J"},
        {"Smithsonian Astrophysical Observation", "SAO 17169"},
        {"Wilson Evans Batten Catalogue", "WEB 13752"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.24719896),
        dec: Angle.Degrees(+69.82155362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29619"},
        {"Hipparcos Number", "HIP 22119"},
        {"Smithsonian Astrophysical Observation", "SAO 13249"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.40450876),
        dec: Angle.Degrees(+69.82312132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24417",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3759 A"},
        {"Henry Draper", "HD 33164"},
        {"Hipparcos Number", "HIP 24417"},
        {"Smithsonian Astrophysical Observation", "SAO 13412"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.58246917),
        dec: Angle.Degrees(+69.82394480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82210"},
        {"Hipparcos Number", "HIP 46977"},
        {"Fundamental Katalog 5th Edition", "FK5 357"},
        {"Geneva Identification System", "GEN# +1.00082210"},
        {"Smithsonian Astrophysical Observation", "SAO 6897"},
        {"Wilson Evans Batten Catalogue", "WEB 8855"},
    },
    visualMagnitude: 4.54,
    bvColour: 0.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.62069943),
        dec: Angle.Degrees(+69.83015419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129663"},
        {"Hipparcos Number", "HIP 71691"},
        {"Smithsonian Astrophysical Observation", "SAO 8065"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.97121115),
        dec: Angle.Degrees(+69.83614345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113450",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16426 AB"},
        {"Hipparcos Number", "HIP 113450"},
        {"Smithsonian Astrophysical Observation", "SAO 20352"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.64786292),
        dec: Angle.Degrees(+69.83939341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65136"},
        {"Hipparcos Number", "HIP 39345"},
        {"Smithsonian Astrophysical Observation", "SAO 14401"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.64799781),
        dec: Angle.Degrees(+69.84157083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29402",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29402"},
        {"Smithsonian Astrophysical Observation", "SAO 13743"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.93981301),
        dec: Angle.Degrees(+69.84411792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22553"},
        {"Hipparcos Number", "HIP 17347"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.68821404),
        dec: Angle.Degrees(+69.84571989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18448",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18448"},
        {"Cincinnati Publication", "Ci 18 520"},
        {"Smithsonian Astrophysical Observation", "SAO 12957"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.14955148),
        dec: Angle.Degrees(+69.84924819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 192.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -164.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94132"},
        {"Hipparcos Number", "HIP 53257"},
        {"Cincinnati Publication", "Ci 20 594"},
        {"Fundamental Katalog 5th Edition", "FK5 2866"},
        {"Geneva Identification System", "GEN# +1.00094132"},
        {"Smithsonian Astrophysical Observation", "SAO 7229"},
        {"Wilson Evans Batten Catalogue", "WEB 9670"},
    },
    visualMagnitude: 5.91,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.38074963),
        dec: Angle.Degrees(+69.85404505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -397.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99475",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99475"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.82612613),
        dec: Angle.Degrees(+69.85454325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85161"},
        {"Hipparcos Number", "HIP 48486"},
        {"Smithsonian Astrophysical Observation", "SAO 6988"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.32187230),
        dec: Angle.Degrees(+69.85879083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45035",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45035"},
        {"Smithsonian Astrophysical Observation", "SAO 6765"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.59330023),
        dec: Angle.Degrees(+69.85944895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119369"},
        {"Hipparcos Number", "HIP 66703"},
        {"Geneva Identification System", "GEN# +1.00119369"},
        {"Smithsonian Astrophysical Observation", "SAO 7862"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.09605771),
        dec: Angle.Degrees(+69.85956753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49596",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7636 AB"},
        {"Henry Draper", "HD 87353"},
        {"Hipparcos Number", "HIP 49596"},
        {"Smithsonian Astrophysical Observation", "SAO 7050"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.86515898),
        dec: Angle.Degrees(+69.86460756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25452"},
        {"Hipparcos Number", "HIP 19279"},
        {"Smithsonian Astrophysical Observation", "SAO 13024"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.97172616),
        dec: Angle.Degrees(+69.86504222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114099",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114099"},
    },
    visualMagnitude: 10.71,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.63669557),
        dec: Angle.Degrees(+69.87220034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 216.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13219",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13219"},
        {"Smithsonian Astrophysical Observation", "SAO 12453"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.54371448),
        dec: Angle.Degrees(+69.87270932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79315"},
        {"Hipparcos Number", "HIP 45591"},
        {"Smithsonian Astrophysical Observation", "SAO 6804"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.37983019),
        dec: Angle.Degrees(+69.87352686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5273",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5273"},
    },
    visualMagnitude: 10.58,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.85136635),
        dec: Angle.Degrees(+69.87942742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 332.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -168.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50573",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50573"},
        {"Fundamental Katalog 5th Edition", "FK5 4919"},
        {"Smithsonian Astrophysical Observation", "SAO 7111"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.96377904),
        dec: Angle.Degrees(+69.87994086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12761"},
        {"Hipparcos Number", "HIP 9956"},
        {"Fundamental Katalog 5th Edition", "FK5 4197"},
        {"Smithsonian Astrophysical Observation", "SAO 12139"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.04460655),
        dec: Angle.Degrees(+69.88121845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92489",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92489"},
        {"Wilson Evans Batten Catalogue", "WEB 15988"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.74724536),
        dec: Angle.Degrees(+69.88257010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38918",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38918"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.46536590),
        dec: Angle.Degrees(+69.88477813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -183.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1518"},
        {"Hipparcos Number", "HIP 1584"},
        {"Smithsonian Astrophysical Observation", "SAO 11112"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.95817818),
        dec: Angle.Degrees(+69.88703648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63071",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8705 AB"},
        {"Hipparcos Number", "HIP 63071"},
        {"Smithsonian Astrophysical Observation", "SAO 7701"},
        {"Wilson Evans Batten Catalogue", "WEB 11184"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.84382834),
        dec: Angle.Degrees(+69.88747409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212976"},
        {"Hipparcos Number", "HIP 110711"},
        {"Smithsonian Astrophysical Observation", "SAO 20066"},
        {"Wilson Evans Batten Catalogue", "WEB 19836"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.45776687),
        dec: Angle.Degrees(+69.89517234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211386"},
        {"Hipparcos Number", "HIP 109764"},
        {"Geneva Identification System", "GEN# +1.00211386"},
        {"Smithsonian Astrophysical Observation", "SAO 19956"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.49339223),
        dec: Angle.Degrees(+69.89756365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9382"},
        {"Hipparcos Number", "HIP 7351"},
        {"Smithsonian Astrophysical Observation", "SAO 11835"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.69203115),
        dec: Angle.Degrees(+69.90051839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111314",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16057 AB"},
        {"Henry Draper", "HD 213973"},
        {"Henry Draper 2", "HD 213974"},
        {"Hipparcos Number", "HIP 111314"},
        {"Geneva Identification System", "GEN# +1.00213973"},
        {"Smithsonian Astrophysical Observation", "SAO 20150"},
        {"Wilson Evans Batten Catalogue", "WEB 19913"},
    },
    visualMagnitude: 6.01,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.26123343),
        dec: Angle.Degrees(+69.91337219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182712"},
        {"Hipparcos Number", "HIP 95044"},
        {"Cincinnati Publication", "Ci 18 2531"},
        {"Smithsonian Astrophysical Observation", "SAO 18303"},
        {"Wilson Evans Batten Catalogue", "WEB 16600"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.08091103),
        dec: Angle.Degrees(+69.91590160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 221.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187708"},
        {"Hipparcos Number", "HIP 97263"},
        {"Smithsonian Astrophysical Observation", "SAO 18526"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.51047751),
        dec: Angle.Degrees(+69.91912223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112762",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112762"},
        {"Smithsonian Astrophysical Observation", "SAO 20272"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.54546748),
        dec: Angle.Degrees(+69.91967459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211772"},
        {"Hipparcos Number", "HIP 110005"},
        {"Smithsonian Astrophysical Observation", "SAO 19980"},
    },
    visualMagnitude: 8.58,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.21395858),
        dec: Angle.Degrees(+69.92088410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29296"},
        {"Hipparcos Number", "HIP 21905"},
        {"Smithsonian Astrophysical Observation", "SAO 13232"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.65602019),
        dec: Angle.Degrees(+69.92823130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96344",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96344"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.81233028),
        dec: Angle.Degrees(+69.92887031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -220.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44807"},
        {"Hipparcos Number", "HIP 30964"},
        {"Smithsonian Astrophysical Observation", "SAO 13851"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.49336780),
        dec: Angle.Degrees(+69.92973832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102044"},
        {"Hipparcos Number", "HIP 57304"},
        {"Smithsonian Astrophysical Observation", "SAO 7418"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.25277810),
        dec: Angle.Degrees(+69.93134667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87441"},
        {"Hipparcos Number", "HIP 49649"},
        {"Geneva Identification System", "GEN# +1.00087441"},
        {"Smithsonian Astrophysical Observation", "SAO 7054"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.02647564),
        dec: Angle.Degrees(+69.93362879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121920"},
        {"Hipparcos Number", "HIP 67993"},
        {"Fundamental Katalog 5th Edition", "FK5 5226"},
        {"Smithsonian Astrophysical Observation", "SAO 7906"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.86532647),
        dec: Angle.Degrees(+69.93511370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198549"},
        {"Hipparcos Number", "HIP 102526"},
        {"Smithsonian Astrophysical Observation", "SAO 19038"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.65562766),
        dec: Angle.Degrees(+69.93572576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90358"},
        {"Hipparcos Number", "HIP 51275"},
        {"Smithsonian Astrophysical Observation", "SAO 7146"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.10420442),
        dec: Angle.Degrees(+69.93650164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78656"},
        {"Hipparcos Number", "HIP 45276"},
        {"Geneva Identification System", "GEN# +1.00078656"},
        {"Smithsonian Astrophysical Observation", "SAO 6782"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.42384706),
        dec: Angle.Degrees(+69.93853574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73455",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73455"},
        {"Smithsonian Astrophysical Observation", "SAO 8139"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.16544015),
        dec: Angle.Degrees(+69.94103547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9877",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1646 AB"},
        {"Henry Draper", "HD 12649"},
        {"Hipparcos Number", "HIP 9877"},
        {"Smithsonian Astrophysical Observation", "SAO 12129"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.77394051),
        dec: Angle.Degrees(+69.94392586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110740"},
        {"Hipparcos Number", "HIP 62054"},
        {"Smithsonian Astrophysical Observation", "SAO 7641"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.78108660),
        dec: Angle.Degrees(+69.94508410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56819"},
        {"Hipparcos Number", "HIP 35925"},
        {"Geneva Identification System", "GEN# +1.00056819"},
        {"Smithsonian Astrophysical Observation", "SAO 6174"},
        {"Wilson Evans Batten Catalogue", "WEB 7154"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.08551586),
        dec: Angle.Degrees(+69.94702655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103190",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14441 A"},
        {"Henry Draper", "HD 199660"},
        {"Hipparcos Number", "HIP 103190"},
        {"Smithsonian Astrophysical Observation", "SAO 19093"},
        {"Wilson Evans Batten Catalogue", "WEB 18744"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.59343632),
        dec: Angle.Degrees(+69.94749386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115604",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115604"},
        {"Smithsonian Astrophysical Observation", "SAO 20619"},
        {"Wilson Evans Batten Catalogue", "WEB 20462"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.27368446),
        dec: Angle.Degrees(+69.94987186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 196.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183221"},
        {"Hipparcos Number", "HIP 95259"},
        {"Smithsonian Astrophysical Observation", "SAO 18322"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.71162910),
        dec: Angle.Degrees(+69.94998794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172130"},
        {"Hipparcos Number", "HIP 90898"},
        {"Smithsonian Astrophysical Observation", "SAO 17925"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.11494850),
        dec: Angle.Degrees(+69.95008443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
